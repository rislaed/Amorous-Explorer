using System;
using Microsoft.Xna.Framework;

public class _BlUQCbX8YXbBc38I7iPEHyF1rUQ : _8lVOgkauaSHbAkAqHzI1K7mIyOI
{
	public Action _uIOOxdCbSvCxXvjNgoXh2qYj0hr { get; set; }

	public Action _HmpXEsA3mxR8eI4MZmgIPCtSGQb { get; set; }

	public Action _vE5Pvwth7cQFh82bMTB5u59Ju4o { get; set; }

	public _BlUQCbX8YXbBc38I7iPEHyF1rUQ(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		_aiunwWjasFcF9afjl2FnUxWXB0M("Assets/Scenes/MainMenu/NEW GAME button dim", "Assets/Scenes/MainMenu/NEW GAME button illuminated", -240, -135, new Rectangle(1020, 525, 210, 100), _CD7mbFgvqfL9Cx207U8NnHC7FCi);
		_aiunwWjasFcF9afjl2FnUxWXB0M("Assets/Scenes/MainMenu/CONTINUE button dim", "Assets/Scenes/MainMenu/CONTINUE button illuminated", -240, -135, new Rectangle(1240, 535, 210, 100), _6529SurdTJ5RkS6BucuzfiMXA7B);
		_aiunwWjasFcF9afjl2FnUxWXB0M("Assets/Scenes/MainMenu/QUIT button dim", "Assets/Scenes/MainMenu/QUIT button illuminated", -240, -135, new Rectangle(1460, 545, 210, 100), _o4JI0pvuMl1BL0ggf0VEWqm2eXF);
	}

	private void _CD7mbFgvqfL9Cx207U8NnHC7FCi()
	{
		if (_uIOOxdCbSvCxXvjNgoXh2qYj0hr == null)
		{
			return;
		}
		while (true)
		{
			int num = -1061621208;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF603E40u) % 3u)
				{
				case 2u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000a:
				_uIOOxdCbSvCxXvjNgoXh2qYj0hr();
				num = (int)(num2 * 2042041095) ^ -372758359;
			}
		}
	}

	private void _6529SurdTJ5RkS6BucuzfiMXA7B()
	{
		if (_HmpXEsA3mxR8eI4MZmgIPCtSGQb == null)
		{
			return;
		}
		while (true)
		{
			int num = 15883838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21232800u) % 3u)
				{
				case 2u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000a:
				_HmpXEsA3mxR8eI4MZmgIPCtSGQb();
				num = ((int)num2 * -606802378) ^ -884238857;
			}
		}
	}

	private void _o4JI0pvuMl1BL0ggf0VEWqm2eXF()
	{
		if (_vE5Pvwth7cQFh82bMTB5u59Ju4o == null)
		{
			return;
		}
		while (true)
		{
			int num = -1704469277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8AFFF924u) % 3u)
				{
				case 2u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000a:
				_vE5Pvwth7cQFh82bMTB5u59Ju4o();
				num = ((int)num2 * -812758646) ^ -1374589877;
			}
		}
	}
}
