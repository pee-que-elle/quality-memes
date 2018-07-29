using System;
using System.Reflection;
using UnityEngine;

// Token: 0x0200023E RID: 574
public static class ELPDNBFIKBP
{
	// Token: 0x06004E85 RID: 20101 RVA: 0x00020205 File Offset: 0x0001E405
	public static Keyframe BCLHLBIGHCG(float MOGLGJGFNDM, float BGBMIEJJQKC, ELPDNBFIKBP.FGNDIKGKGED EFBDPFLQQEC)
	{
		return ELPDNBFIKBP.BCLHLBIGHCG(MOGLGJGFNDM, BGBMIEJJQKC, EFBDPFLQQEC, EFBDPFLQQEC);
	}

	// Token: 0x06004E86 RID: 20102 RVA: 0x0028E22C File Offset: 0x0028C42C
	public static Keyframe BCLHLBIGHCG(float MOGLGJGFNDM, float BGBMIEJJQKC, ELPDNBFIKBP.FGNDIKGKGED DEQIFCDFMDK, ELPDNBFIKBP.FGNDIKGKGED JKDFCPKCQJP)
	{
		object obj = new Keyframe(MOGLGJGFNDM, BGBMIEJJQKC);
		ELPDNBFIKBP.QCQMGLCLEID(obj, true);
		ELPDNBFIKBP.PNMJMEOJKOJ(obj, 0, DEQIFCDFMDK);
		ELPDNBFIKBP.PNMJMEOJKOJ(obj, 1, JKDFCPKCQJP);
		Keyframe result = (Keyframe)obj;
		if (DEQIFCDFMDK == ELPDNBFIKBP.FGNDIKGKGED.Stepped)
		{
			result.inTangent = float.PositiveInfinity;
		}
		if (JKDFCPKCQJP == ELPDNBFIKBP.FGNDIKGKGED.Stepped)
		{
			result.outTangent = float.PositiveInfinity;
		}
		return result;
	}

	// Token: 0x06004E87 RID: 20103 RVA: 0x0028E288 File Offset: 0x0028C488
	public static void PNMJMEOJKOJ(object DGCMQHQHKQH, int DGFBCMBILOE, ELPDNBFIKBP.FGNDIKGKGED BGIIEGILLHN)
	{
		Type typeFromHandle = typeof(Keyframe);
		FieldInfo field = typeFromHandle.GetField("m_TangentMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		int num = (int)field.GetValue(DGCMQHQHKQH);
		if (DGFBCMBILOE == 0)
		{
			num &= -7;
			num |= (int)((int)BGIIEGILLHN << 1);
		}
		else
		{
			num &= -25;
			num |= (int)((int)BGIIEGILLHN << 3);
		}
		field.SetValue(DGCMQHQHKQH, num);
		if (ELPDNBFIKBP.DOBKNOQDFGE(num, DGFBCMBILOE) == BGIIEGILLHN)
		{
			return;
		}
		Debug.Log("bug");
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x00020210 File Offset: 0x0001E410
	public static ELPDNBFIKBP.FGNDIKGKGED DOBKNOQDFGE(int PFFKLPJONJD, int DGFBCMBILOE)
	{
		if (DGFBCMBILOE == 0)
		{
			return (ELPDNBFIKBP.FGNDIKGKGED)((PFFKLPJONJD & 6) >> 1);
		}
		return (ELPDNBFIKBP.FGNDIKGKGED)((PFFKLPJONJD & 24) >> 3);
	}

	// Token: 0x06004E89 RID: 20105 RVA: 0x0028E2F8 File Offset: 0x0028C4F8
	public static ELPDNBFIKBP.FGNDIKGKGED DOBKNOQDFGE(Keyframe DGCMQHQHKQH, int DGFBCMBILOE)
	{
		Type typeFromHandle = typeof(Keyframe);
		FieldInfo field = typeFromHandle.GetField("m_TangentMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		int num = (int)field.GetValue(DGCMQHQHKQH);
		if (DGFBCMBILOE == 0)
		{
			return (ELPDNBFIKBP.FGNDIKGKGED)((num & 6) >> 1);
		}
		return (ELPDNBFIKBP.FGNDIKGKGED)((num & 24) >> 3);
	}

	// Token: 0x06004E8A RID: 20106 RVA: 0x0028E340 File Offset: 0x0028C540
	public static void QCQMGLCLEID(object DGCMQHQHKQH, bool IEJDINIGJNF)
	{
		Type typeFromHandle = typeof(Keyframe);
		FieldInfo field = typeFromHandle.GetField("m_TangentMode", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		int num = (int)field.GetValue(DGCMQHQHKQH);
		if (IEJDINIGJNF)
		{
			num |= 1;
		}
		else
		{
			num &= -2;
		}
		field.SetValue(DGCMQHQHKQH, num);
	}

	// Token: 0x0200023F RID: 575
	public enum FGNDIKGKGED
	{
		// Token: 0x040010D9 RID: 4313
		Editable,
		// Token: 0x040010DA RID: 4314
		Smooth,
		// Token: 0x040010DB RID: 4315
		Linear,
		// Token: 0x040010DC RID: 4316
		Stepped
	}

	// Token: 0x02000240 RID: 576
	public enum KHPJHNQNCEJ
	{
		// Token: 0x040010DE RID: 4318
		Left,
		// Token: 0x040010DF RID: 4319
		Right
	}
}
