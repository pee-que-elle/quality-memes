using System;
using System.Collections.Generic;

// Token: 0x02000098 RID: 152
[Serializable]
public class BMGlyph
{
	// Token: 0x0600139D RID: 5021 RVA: 0x000914FC File Offset: 0x0008F6FC
	public void PIHCJFIDMPD(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i++)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0009156C File Offset: 0x0008F76C
	public void OLKDIJQKOOL(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00091638 File Offset: 0x0008F838
	public int BPKCGJHGGKM(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 4;
			}
		}
		return 1;
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x0009168C File Offset: 0x0008F88C
	public int DICCJJIKKKM(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i++;
			}
		}
		return 0;
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x000916E0 File Offset: 0x0008F8E0
	public int KJIPDKBGHBF(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 6;
			}
		}
		return 0;
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00091734 File Offset: 0x0008F934
	public int NPDBPKIJPEF(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 7;
			}
		}
		return 0;
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00091788 File Offset: 0x0008F988
	public void KMQBNDQOQJP(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i += 3)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x0009156C File Offset: 0x0008F76C
	public void PCNCNHMKBKL(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x000917F8 File Offset: 0x0008F9F8
	public int JCENLBIPOGN(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 0;
			}
		}
		return 0;
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0009156C File Offset: 0x0008F76C
	public void DLHJLMBNQNL(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0009156C File Offset: 0x0008F76C
	public void GDCBIOBBEEM(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0009184C File Offset: 0x0008FA4C
	public void HGCJEBLFGED(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i += 3)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x000914FC File Offset: 0x0008F6FC
	public void JCJIOEPPNKO(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i++)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x000918BC File Offset: 0x0008FABC
	public int FIOLQGJQBEO(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 6;
			}
		}
		return 1;
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0009156C File Offset: 0x0008F76C
	public void MMMNKNEBPHD(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0009156C File Offset: 0x0008F76C
	public void QODGFCFDGHP(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00091910 File Offset: 0x0008FB10
	public int FQMIGOCHNQL(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 4;
			}
		}
		return 0;
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00091964 File Offset: 0x0008FB64
	public void CHOMQHLGECM(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 8)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00091910 File Offset: 0x0008FB10
	public int OLGPHGGMMJG(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 4;
			}
		}
		return 0;
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0009156C File Offset: 0x0008F76C
	public void LLCLKPQFFEK(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x000919D4 File Offset: 0x0008FBD4
	public void MOIFOCCBQGQ(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 5)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00091A44 File Offset: 0x0008FC44
	public int ECMCHNLLGFC(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 8;
			}
		}
		return 0;
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00091A98 File Offset: 0x0008FC98
	public void NGKOJGCLPEH(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 5)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0009156C File Offset: 0x0008F76C
	public void DLQEQMPDDCH(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0009156C File Offset: 0x0008F76C
	public void BJDDQNQNFED(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0009156C File Offset: 0x0008F76C
	public void IFHOGLLOHGF(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x0009156C File Offset: 0x0008F76C
	public void QGOMBDGJMKO(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x0009156C File Offset: 0x0008F76C
	public void BEDEMKDHQOG(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0009156C File Offset: 0x0008F76C
	public void HLCIKFNDQLI(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x0009156C File Offset: 0x0008F76C
	public void LCLFOMGNEMQ(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x00091B08 File Offset: 0x0008FD08
	public int EKOCBDCEMON(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 3;
			}
		}
		return 1;
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00091B5C File Offset: 0x0008FD5C
	public int BGMCFJJLPPN(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 5;
			}
		}
		return 0;
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x00091BB0 File Offset: 0x0008FDB0
	public int PFBHNJHJJNK(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 7;
			}
		}
		return 0;
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00091C04 File Offset: 0x0008FE04
	public void LQKHPOHNPKO(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 2)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x00091C74 File Offset: 0x0008FE74
	public void GBEHHOJKDCP(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i += 2)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00091CE4 File Offset: 0x0008FEE4
	public void DHBKMGMCIBM(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 7)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00091D54 File Offset: 0x0008FF54
	public int NPGQMQHHDEF(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i++;
			}
		}
		return 0;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0009156C File Offset: 0x0008F76C
	public void FEFPMEPJBJF(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00091DA8 File Offset: 0x0008FFA8
	public void HQMBDCCEHMG(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i += 4)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00091E18 File Offset: 0x00090018
	public int GGEMGJFOGCI(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 3;
			}
		}
		return 0;
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00091C04 File Offset: 0x0008FE04
	public void PCOHDMOIEQJ(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 2)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00091E6C File Offset: 0x0009006C
	public int LJFDOKDFIIK(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i++;
			}
		}
		return 1;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00091788 File Offset: 0x0008F988
	public void FNQQCFQFOIB(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 1; i < this.kerning.Count; i += 3)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x00091EC0 File Offset: 0x000900C0
	public int QMBLLOFJJOO(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i++;
			}
		}
		return 1;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x00091F14 File Offset: 0x00090114
	public int QBNKFFNBDIF(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 7;
			}
		}
		return 1;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00091CE4 File Offset: 0x0008FEE4
	public void IEFFIGEHIJG(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 7)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x0009156C File Offset: 0x0008F76C
	public void BJKQOKGDJGC(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		int num = this.x + this.width;
		int num2 = this.y + this.height;
		if (this.x < GMQPHOGQFMG)
		{
			int num3 = GMQPHOGQFMG - this.x;
			this.x += num3;
			this.width -= num3;
			this.offsetX += num3;
		}
		if (this.y < HLIPOQGBJNN)
		{
			int num4 = HLIPOQGBJNN - this.y;
			this.y += num4;
			this.height -= num4;
			this.offsetY += num4;
		}
		if (num > FJDGINJEHOE)
		{
			this.width -= num - FJDGINJEHOE;
		}
		if (num2 > JFJFCGQOEMC)
		{
			this.height -= num2 - JFJFCGQOEMC;
		}
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00091A44 File Offset: 0x0008FC44
	public int ELQEMMDIDGD(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 8;
			}
		}
		return 0;
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x00091F68 File Offset: 0x00090168
	public int OQNPPHQECJO(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 2;
			}
		}
		return 0;
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x00091C04 File Offset: 0x0008FE04
	public void CGMMFDPCIBK(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 2)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 1] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00091FBC File Offset: 0x000901BC
	public void QKKFLCLJBQI(int LEHLOHQCHGD, int DPDCGFEEFPB)
	{
		if (this.kerning == null)
		{
			this.kerning = new List<int>();
		}
		for (int i = 0; i < this.kerning.Count; i += 2)
		{
			if (this.kerning[i] == LEHLOHQCHGD)
			{
				this.kerning[i + 0] = DPDCGFEEFPB;
				return;
			}
		}
		this.kerning.Add(LEHLOHQCHGD);
		this.kerning.Add(DPDCGFEEFPB);
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00091A44 File Offset: 0x0008FC44
	public int GLBCIBFDDJM(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 8;
			}
		}
		return 0;
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0009202C File Offset: 0x0009022C
	public int LEJPDDKMMQE(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 1;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 1];
				}
				i += 8;
			}
		}
		return 1;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00092080 File Offset: 0x00090280
	public int GCHMKGCMCBI(int LEHLOHQCHGD)
	{
		if (this.kerning != null && LEHLOHQCHGD != 0)
		{
			int i = 0;
			int count = this.kerning.Count;
			while (i < count)
			{
				if (this.kerning[i] == LEHLOHQCHGD)
				{
					return this.kerning[i + 0];
				}
				i += 5;
			}
		}
		return 0;
	}

	// Token: 0x0400039C RID: 924
	public int index;

	// Token: 0x0400039D RID: 925
	public int x;

	// Token: 0x0400039E RID: 926
	public int y;

	// Token: 0x0400039F RID: 927
	public int width;

	// Token: 0x040003A0 RID: 928
	public int height;

	// Token: 0x040003A1 RID: 929
	public int offsetX;

	// Token: 0x040003A2 RID: 930
	public int offsetY;

	// Token: 0x040003A3 RID: 931
	public int advance;

	// Token: 0x040003A4 RID: 932
	public int channel;

	// Token: 0x040003A5 RID: 933
	public List<int> kerning;
}
