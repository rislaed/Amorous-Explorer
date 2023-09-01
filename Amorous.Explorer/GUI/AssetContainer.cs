using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Amorous.Explorer.Content.Asset;
using Amorous.Explorer.Content.Skeleton;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.GUI.View.Inherits;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI;

public class AssetContainer : AbstractContainer<Fragment, ContentManager>
{
	public override Fragment Fragment { get; protected set; } = new Fragment()
	{
		["Task"] = new FrameFragment()
		{
			Visible = false,
			["Placeholder"] = new AmorousLabel(),
			["State"] = new AmorousMessage(),
			["Progress"] = new ProgressBar()
		},
		["Conversion"] = new AmorousLabel()
		{
			Text = "Conversion"
		},
		["Conversion Kinds"] = new ListFragment()
		{
			Mode = ChoiceMode.Combine,
			TaggedItems = {
				["Export Textures"] = (object value) => value is Texture2D,
				["Export Sounds"] = (object value) => value is SoundEffect,
				["Export Fonts"] = (object value) => value is SpriteFont,
				["Export Effects"] = (object value) => value is Effect
			},
			UnselectOnDeattach = true,
			OnChecked = (self, keys) => (self.GetContainer() as AssetContainer).UpdateTranscodingButton()
		},
		["Conversion Separator"] = new AmorousSeparator(),
		["Conversion Perform"] = new PagerApplyControl()
		{
			TurnRightVisible = true,
			Style = "buttonAccent",
			Text = "Do it!"
		},
		["Conversion Advanced"] = new FrameFragment()
		{
			Visible = false,
			Padding = new Margin(8),
			["Conversion Eplanation"] = new AmorousMessage()
			{
				Text = "Decode assets with framework to save it transcoded variants (such as .png's, .wav's, etc.) into files."
			}
		},
		["Repacking"] = new AmorousLabel()
		{
			Text = "Repacking"
		},
		["Repacking Type"] = new CarouselChoiceFragment()
		{
			UnselectOnDeattach = false,
			MayUnselected = false,
			Items = {
				"Decompress",
				"Compress"
			},
			SelectedItem = "Decompress"
		},
		["Repacking Before Separator"] = new AmorousSeparator(),
		["Repacking Kinds"] = new ListFragment()
		{
			Mode = ChoiceMode.Combine,
			TaggedItems = {
				["Include Assets"] = "Assets[/|\\\\]([^\\.]*|([^\\.]*\\.)+(?!(xml|og[agv]|xnb)$)[^\\.]*)$",
				["Include Packed Assets"] = "Assets[/|\\\\]([^\\.]*\\.)+xnb$",
				["Include Quests"] = "Data[/|\\\\]Quests[/|\\\\]",
				["Include Templates"] = "Data[/|\\\\]PlayerCustomization[/|\\\\]",
				["Include Miscellaneous"] = "Data[/|\\\\](?!(Quests|PlayerCustomization)[/|\\\\])"
			},
			UnselectOnDeattach = true,
			OnChecked = (self, keys) => (self.GetContainer() as AssetContainer).UpdateRepackingButton()
		},
		["Repacking Separator"] = new AmorousSeparator(),
		["Repacking Perform"] = new PagerApplyControl()
		{
			TurnRightVisible = true,
			Style = "buttonAccent",
			Text = "Do it!"
		},
		["Repacking Advanced"] = new FrameFragment()
		{
			Visible = false,
			Padding = new Margin(8),
			["Conversion Eplanation"] = new AmorousMessage()
			{
				Text = "Repacking resources between ordinal binaries and GZip archives, which is used to compress assets."
			}
		},
		["Miscellaneous"] = new AmorousLabel()
		{
			Text = "Miscellaneous"
		},
		["Extract Everything"] = new ExpandableFragment()
		{
			Text = "Content-Release to Content(-Indev)",
			["Extract Explanation"] = new AmorousMessage()
			{
				Text = "Packed assets will be transcoded as binary files (such as .png's, .wav's, etc.), compressed binaries, texts (such as quests, customization, etc.) into temporary directory.",
			},
			["Remove Destination Before"] = new AmorousButton()
			{
				Style = "buttonOpaqueSwitch",
				Text = "Remove Destination Before",
				CheckOnClick = true
			},
			["Extract Everything Separator"] = new AmorousSeparator(),
			["Extract Everything Perform"] = new DangerousButton()
			{
				Style = "buttonOpaqueQueued",
				Text = "Do it!",
				Confirmation = "Are you absolutely sure?"
			}
		},
		["Up/downgrade Spines"] = new ExpandableFragment()
		{
			Text = "Upgrade or Downgrade Spines",
			["Up/downgrade Explanation"] = new AmorousMessage()
			{
				Text = "Skeletons will be upgraded to be editable in newer versions of Spine (importable in exactly same version), or downgraded to be usable right in Amorous."
			},
			["Up/downgrade Type"] = new CarouselChoiceFragment()
			{
				UnselectOnDeattach = false,
				MayUnselected = false,
				Items = {
					"Downgrade",
					"Upgrade"
				},
				SelectedItem = "Upgrade",
				OnSelect = (self, key) => (self.GetContainer() as AssetContainer).UpdateUpdowngradeFragment(key)
			},
			["Up/downgrade Version Label"] = new AmorousLabel()
			{
				Text = "Target Version"
			},
			["Up/downgrade Version"] = new CarouselPanelFragment()
			{
				["Segment 1"] = new AmorousTextBox()
				{
					Dock = DockStyle.Left,
					Mode = TextBoxMode.Numeric
				},
				["Segment 2"] = new AmorousTextBox()
				{
					Dock = DockStyle.Left,
					Mode = TextBoxMode.Numeric
				},
				["Segment 3"] = new AmorousTextBox()
				{
					Dock = DockStyle.Left,
					Mode = TextBoxMode.Numeric
				}
			},
			["Up/downgrade Separator"] = new AmorousSeparator(),
			["Up/downgrade Perform"] = new AmorousButton()
			{
				Style = "buttonAccent",
				Text = "Do it!"
			}
		},
		OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as AssetContainer).HideEssentials()
	};

	public static readonly string ContentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content");
	public static readonly string ContentReleaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content-Release");
	public static readonly string ContentIndevDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content-Indev");

	public AssetDecoder AssetDecoder { get; }
	public string CurrentDirectory { get; protected set; }
	public bool IsExternalDirectory { get; protected set; }

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;
	protected FrameFragment TaskFrame => this["Task"] as FrameFragment;
	protected ListFragment ConversionKindsList => this["Conversion Kinds"] as ListFragment;
	protected PagerApplyControl ConversionPerformApply => this["Conversion Perform"] as PagerApplyControl;
	protected FrameFragment ConversionAdvancedFrame => this["Conversion Advanced"] as FrameFragment;
	protected CarouselChoiceFragment RepackingTypeCarousel => this["Repacking Type"] as CarouselChoiceFragment;
	protected ListFragment RepackingKindsList => this["Repacking Kinds"] as ListFragment;
	protected PagerApplyControl RepackingPerformApply => this["Repacking Perform"] as PagerApplyControl;
	protected FrameFragment RepackingAdvancedFrame => this["Repacking Advanced"] as FrameFragment;
	protected CarouselChoiceFragment UpdowngradeTypeCarousel => GetFragment("Up/downgrade Type") as CarouselChoiceFragment;
	protected CarouselPanelFragment UpdowngradeVersionCarousel => GetFragment("Up/downgrade Version") as CarouselPanelFragment;
	protected Button UpdowngradeApply => GetControl("Up/downgrade Perform") as Button;
	protected Button RemoveDestinationBeforeButton => GetControl("Remove Destination Before") as Button;
	protected DangerousButton ExtractEverythingPerformApply => GetControl("Extract Everything Perform") as DangerousButton;

	public AssetContainer(AbstractDesktop desktop = null) : base(desktop)
	{
		AssetDecoder = new AssetDecoder();
		ConversionPerformApply.Button.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			if (eventArgs.Button <= 0) TranscodeSelectedKinds();
		};
		ConversionPerformApply.TurnRight.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			if (eventArgs.Button <= 0) ConversionAdvancedFrame.Visible = !ConversionAdvancedFrame.Visible;
		};
		RepackingPerformApply.Button.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			if (eventArgs.Button <= 0) RecompressSelectedKinds();
		};
		RepackingPerformApply.TurnRight.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			if (eventArgs.Button <= 0) RepackingAdvancedFrame.Visible = !RepackingAdvancedFrame.Visible;
		};
		UpdowngradeApply.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			if (eventArgs.Button <= 0) UpdowngradeSelectedKinds();
		};
		ExtractEverythingPerformApply.MouseAccept += (control) => ExtractEverything();
	}

	private bool? unexpectedDrawInterrupted, unexpectedUpdateInterrupted;
	private int ticksBeforeGettingStarted;
	private Action then;
	private string currentlyAssetPath;

	public override void Provide(ContentManager data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		base.Provide(data);
		CurrentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, data.RootDirectory);
		IsExternalDirectory = CurrentDirectory != ContentReleaseDirectory;
	}

	private void UpdateRepackingButton()
	{
		RepackingPerformApply.Button.Enabled = RepackingKindsList.SelectedItem != null;
	}

	private void UpdateTranscodingButton()
	{
		ConversionPerformApply.Button.Enabled = ConversionKindsList.SelectedItem != null;
	}

	private void UpdateUpdowngradeFragment(string key)
	{
		int[] version = key == "Upgrade" ? SpineConverter.UpgradeVersion : SpineConverter.DowngradeVersion;
		int index = 0;
		foreach (TextBox box in UpdowngradeVersionCarousel.Controls.OfType<TextBox>())
		{
			box.Text = (index < version.Length ? version[index] : 0).ToString();
			index++;
		}
	}

	public void RecompressSelectedKinds()
	{
		RecompressPatterns(RepackingKindsList.SelectedTags, RepackingTypeCarousel.SelectedItem == "Compress" ? CompressionMode.Compress : CompressionMode.Decompress);
	}

	public virtual void RecompressPatterns(ICollection<object> patterns, CompressionMode mode, bool simpleComparing = false)
	{
		string directory = IsExternalDirectory ? ContentIndevDirectory : ContentDirectory;
		TryExpectTask(directory, $"{(mode == CompressionMode.Decompress ? "Decompressing" : "Compressing")} assets", delegate()
		{
			return patterns.SelectMany((pattern) => simpleComparing ? Data.GetFiles((string)pattern) : Data.MatchFiles((string)pattern)).ToArray();
		}, (directory, asset, index) => {
			if (!EnsureGZip(directory, Path.ChangeExtension(asset, null), Path.GetExtension(asset), mode))
			{
				Logger.Debug("Asset {0} already {1}", asset, mode == CompressionMode.Decompress ? "decompressed" : "compressed");
			}
		});
	}

	public void TranscodeSelectedKinds()
	{
		TranscodePredicates(ConversionKindsList.SelectedTags);
	}

	public virtual void TranscodePredicates(ICollection<object> predicates)
	{
		string directory = IsExternalDirectory ? ContentIndevDirectory : ContentDirectory;
		Func<object, bool> predicate = delegate(object value)
		{
			foreach (Func<object, bool> predicate in predicates)
			{
				if (predicate == null || predicate.Invoke(value))
				{
					return true;
				}
			}
			return false;
		};
		TryExpectTask(directory, "Transcoding assets", () => Data.GetFiles("*.xnb"), (directory, asset, index) => {
			if (!Decode(directory, Path.ChangeExtension(asset, null), Path.GetExtension(asset), predicate))
			{
				Logger.Debug("Undecodeable asset {0}", asset);
			}
		});
	}

	public void UpdowngradeSelectedKinds()
	{
		UpdowngradeThings(string.Join(".", UpdowngradeVersionCarousel.Controls.OfType<TextBox>().Select((box) => Convert.ToInt32(box.Text))), UpdowngradeTypeCarousel.SelectedItem == "Downgrade");
	}

	public virtual void UpdowngradeThings(string version, bool downgrade = false)
	{
		string directory = IsExternalDirectory ? ContentIndevDirectory : ContentDirectory;
		TryExpectTask(directory, $"{(downgrade ? "Downgrading" : "Upgrading")} skeletons", () => Data.MatchFiles("Assets[/|\\\\]([^\\.]*\\.)+json$"), (directory, asset, index) => {
			string assetName = Path.ChangeExtension(asset, null);
			if (!EnsureSpineGrade(directory, assetName, Path.GetExtension(asset), version, downgrade))
			{
				Logger.Debug("Spine {0} already {1}", assetName, downgrade ? "downgraded" : "upgraded");
			}
		});
	}

	public virtual void ExtractEverything()
	{
		string directory = IsExternalDirectory ? ContentIndevDirectory : ContentDirectory;
		bool removeDirectoryBeforeStarting = RemoveDestinationBeforeButton.Checked;
		if (removeDirectoryBeforeStarting && Directory.Exists(directory))
		{
			Logger.Warning("Removing existing directory {0}!", directory);
		}
		TryExpectTask(directory, "Extracting everything", delegate()
		{
			if (removeDirectoryBeforeStarting && Directory.Exists(directory))
			{
				Directory.Delete(directory, recursive: true);
			}
			return Data.MatchFiles("(^[^\\.]*|\\.(?!(xml|og[agv])$)[^\\.]*)$");
		}, (directory, asset, index) => {
			if (!Decode(directory, Path.ChangeExtension(asset, null), Path.GetExtension(asset)))
			{
				Logger.Debug("Undecodeable asset {0}", asset);
			}
		});
	}

	protected virtual void TryExpectTask(string directory, string label, Func<string[]> enumerate, Action<string, string, int> stuff)
	{
		Logger.Debug("{0} to {1}", label, directory);
		UpdateProgress("Enumerating assets...", 0f);
		TryExpect(label, delegate()
		{
			BeforeUpdatingProgress();
			string[] files = enumerate.Invoke();
			currentlyAssetPath = null;
			int index = 0;
			then = delegate()
			{
				if (currentlyAssetPath != null)
				{
					stuff.Invoke(directory, currentlyAssetPath, index);
				}
				if (index < files.Length)
				{
					currentlyAssetPath = files[index];
					if (currentlyAssetPath.StartsWith(Data.RootDirectory))
					{
						currentlyAssetPath = currentlyAssetPath.Substring(Data.RootDirectory.Length).TrimStart('/', '\\');
					}
					index++;
					UpdateProgress(currentlyAssetPath, (float)index / (float)files.Length);
					return;
				}
				currentlyAssetPath = null;
				Deexpect();
			};
		});
	}

	protected virtual void CopyGZip(string input, string output, CompressionMode mode = CompressionMode.Decompress)
	{
		using (FileStream reader = File.OpenRead(input))
		{
			if (currentlyAssetPath != null)
			{
				Logger.Debug("{0} asset {1}", mode == CompressionMode.Decompress ? "Decompressing" : "Compressing", currentlyAssetPath);
			}
			if (mode == CompressionMode.Decompress)
			{
				using (GZipStream gzip = new GZipStream(reader, mode))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(output));
					using (FileStream writer = File.OpenWrite(output))
					{
						gzip.CopyTo(writer);
					}
				}
			}
			else
			{
				Directory.CreateDirectory(Path.GetDirectoryName(output));
				using (FileStream writer = File.OpenWrite(output))
				{
					using (GZipStream gzip = new GZipStream(writer, mode))
					{
						reader.CopyTo(gzip);
					}
				}
			}
		}
	}

	protected virtual bool RegradeSpine(string input, string output, string version, bool downgrade = false)
	{
		using (Stream stream = Compressions.ReadStream(input))
		{
			using StreamReader reader = new StreamReader(stream);
			object token = JsonConvert.DeserializeObject(reader.ReadToEnd());
			string name = Path.GetFileNameWithoutExtension(input);
			if (downgrade)
			{
				token = SpineConverter.Downgrade(name, token as JToken, version);
			}
			else
			{
				token = SpineConverter.Upgrade(name, token as JToken, version);
			}
			if (token != null)
			{
				if (currentlyAssetPath != null)
				{
					Logger.Debug("{0} spine {1}", downgrade ? "Downgrading" : "Upgrading", Path.ChangeExtension(currentlyAssetPath, null));
				}
				Directory.CreateDirectory(Path.GetDirectoryName(output));
				using (FileStream substream = File.OpenWrite(output))
				{
					using StreamWriter writer = new StreamWriter(substream);
					writer.Write(JsonConvert.SerializeObject(token));
				}
				return true;
			}
		}
		return false;
	}

	public virtual bool Decode(string directory, string assetName, string extension, Func<object, bool> predicate = null)
	{
		string path = Path.Combine(Data.RootDirectory, $"{assetName}{extension}");
		try
		{
			XnbHeader.Of(path);
			try
			{
				return AssetDecoder.Decode(directory, assetName, Data, predicate);
			}
			catch (ContentLoadException exception)
			{
				Logger.Warning(exception.ToString());
			}
		}
		catch (InvalidXnbHeader exception)
		{
			if (extension == ".xnb")
			{
				Logger.Warning(exception.ToString());
			}
		}
		if (predicate != null)
		{
			return false;
		}
		return EnsureGZip(directory, assetName, extension);
	}

	public virtual bool EnsureGZip(string directory, string assetName, string extension, CompressionMode mode = CompressionMode.Decompress)
	{
		string path = Path.Combine(Data.RootDirectory, $"{assetName}{extension}");
		try
		{
			if (Storages.EnsureGZipHeader(path))
			{
				if (mode == CompressionMode.Compress)
				{
					return false;
				}
			}
			else if (mode == CompressionMode.Decompress)
			{
				return false;
			}
			CopyGZip(path, Path.Combine(directory, $"{assetName}{extension}"), mode);
			return true;
		}
		catch (IOException exception)
		{
			Logger.Warning(exception.ToString());
		}
		return false;
	}

	public virtual bool EnsureSpineGrade(string directory, string assetName, string extension, string version, bool downgrade = false)
	{
		string path = Path.Combine(Data.RootDirectory, $"{assetName}{extension}");
		try
		{
			return RegradeSpine(path, Path.Combine(directory, $"{assetName}{extension}"), version, downgrade);
		}
		catch (SystemException exception)
		{
			Logger.Warning(exception.ToString());
		}
		return false;
	}

	protected virtual void HideEssentials()
	{
		TaskFrame.Visible = false;
		ProgressBar bar = TaskFrame["Progress"] as ProgressBar;
		bar.Style = "buttonOpaqueQueued";
		bar.Text = string.Empty;
		bar.Format = null;
		bar.Progress = 0.5f;
		(TaskFrame["Placeholder"] as Label).Text = string.Empty;
		UpdateRepackingButton();
		UpdateTranscodingButton();
		UpdateUpdowngradeFragment(UpdowngradeTypeCarousel.SelectedItem);
	}

	public virtual void BeforeExpecting(string label)
	{
		TaskFrame.Visible = true;
		(TaskFrame["Placeholder"] as Label).Text = label;
	}

	public virtual void BeforeUpdatingProgress()
	{
		ProgressBar bar = TaskFrame["Progress"] as ProgressBar;
		bar.Style = "buttonOpaqueSelected";
		bar.Format = "0.0";
		bar.Progress = 0f;
	}

	public virtual void UpdateProgress(string label, float progress)
	{
		(TaskFrame["State"] as Label).Text = label;
		(TaskFrame["Progress"] as ProgressBar).Progress = progress;
	}

	public virtual bool TryExpect(string key, Action when = null, bool occupiedByRislaeD = true)
	{
		if (!StartupDesktop.TryExpect("Assets"))
		{
			StartupDesktop.Deexpect();
			return false;
		}
		BeforeExpecting(key);
		TaskFrame.Frame.Lock();
		StartupDesktop.MenuFragment.TabbedList.ItemContent.VScroll.Value = StartupDesktop.MenuFragment.TabbedList.ItemContent.HScroll.Value = 0;
		if (occupiedByRislaeD)
		{
			unexpectedDrawInterrupted = Desktop.Explorer.IsDrawInterrupted;
			unexpectedUpdateInterrupted = Desktop.Explorer.IsUpdateInterrupted;
			// TODO: Move redrawing to preferences, sligthly increases performance
			// Desktop.Explorer.IsDrawInterrupted = true;
			Desktop.Explorer.IsUpdateInterrupted = true;
			Desktop.Explorer.Game.IsFixedTimeStep = false;
		}
		then = when;
		ticksBeforeGettingStarted = 800;
		return true;
	}

	public virtual void Deexpect()
	{
		then = null;
		ticksBeforeGettingStarted = 0;
		if (unexpectedDrawInterrupted.HasValue)
		{
			Desktop.Explorer.IsDrawInterrupted = unexpectedDrawInterrupted.Value;
		}
		if (unexpectedUpdateInterrupted.HasValue)
		{
			Desktop.Explorer.IsUpdateInterrupted = unexpectedUpdateInterrupted.Value;
		}
		Desktop.Explorer.Game.IsFixedTimeStep = true;
		TaskFrame.Frame.Unlock();
		StartupDesktop.Deexpect();
		if (IsAttached)
		{
			HideEssentials();
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (ticksBeforeGettingStarted >= 0)
		{
			ticksBeforeGettingStarted -= gameTime.ElapsedGameTime.Milliseconds;
			return;
		}
		if (then != null)
		{
			then.Invoke();
		}
	}
}
