namespace Amorous.Game.Scenes;

public class RemyLivingRoomScene : TimeOfDayScene
{
	public RemyLivingRoomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 1959664084;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64636C45u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				RemyLivingRoomScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_26<string>(18108931u), _003CModule_003E.smethod_26<string>(4066099841u), 0, 0);
				num = ((int)num2 * -588050888) ^ 0x738CB683;
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}
}
