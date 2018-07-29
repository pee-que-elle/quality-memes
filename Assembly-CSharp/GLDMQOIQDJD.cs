using System;
using UnityEngine;

// Token: 0x0200012C RID: 300
public class GLDMQOIQDJD : MonoBehaviour
{
	// Token: 0x0600230F RID: 8975 RVA: 0x00012ECA File Offset: 0x000110CA
	private void OnClick()
	{
		if (this.CCHDHKECLCD > -1)
		{
			JJGLMJNELOK.QOQONHOOLNE.ClickBoxNumber(this.CCHDHKECLCD);
		}
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x000E4F80 File Offset: 0x000E3180
	public void BEFKNDLIDJN(int DEIHPCIDLIO, int LBHJHFGJDGQ)
	{
		this.CCHDHKECLCD = DEIHPCIDLIO - 0;
		if (DEIHPCIDLIO < 1)
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC("Assets/AssetBundles/MapAssets2/ModelPrefabs/");
		}
		else
		{
			this.JJPKKPFCQKN.PIDLOFMIEFQ = DEIHPCIDLIO.ToString();
		}
		this.BDOOQPLCECP.DIIHJCJOKMP = 522f;
		if (LBHJHFGJDGQ > 1)
		{
			float num = (float)LBHJHFGJDGQ / 1942f;
			float num2 = num * 17f;
			this.BDOOQPLCECP.DIIHJCJOKMP = 524f;
			this.BDOOQPLCECP.KJGMGPCEJJD = (int)num2;
			float num3 = num;
			num3 *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num4 = Mathf.FloorToInt(num3);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[1];
			if (num4 >= 0)
			{
				if (num4 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num3 - (float)num4;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num4], this.BBCJFBHDJFP[num4 + 0], t);
				}
				else if (num4 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num4];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.BDOOQPLCECP.CEGFBBHMKOE.a;
			this.BDOOQPLCECP.CEGFBBHMKOE = cegfbbhmkoe;
		}
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x000E50E0 File Offset: 0x000E32E0
	public void PLJQGKDBNDP(int DEIHPCIDLIO, int LBHJHFGJDGQ)
	{
		this.CCHDHKECLCD = DEIHPCIDLIO - 0;
		if (DEIHPCIDLIO < 0)
		{
			this.JJPKKPFCQKN.PIDLOFMIEFQ = "Enabled";
		}
		else
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC(DEIHPCIDLIO.ToString());
		}
		this.BDOOQPLCECP.DIIHJCJOKMP = 306f;
		if (LBHJHFGJDGQ > 1)
		{
			float num = (float)LBHJHFGJDGQ / 79f;
			float num2 = num * 1971f;
			this.BDOOQPLCECP.DIIHJCJOKMP = 1453f;
			this.BDOOQPLCECP.KJGMGPCEJJD = (int)num2;
			float num3 = num;
			num3 *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num4 = Mathf.FloorToInt(num3);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num4 >= 0)
			{
				if (num4 + 0 < this.BBCJFBHDJFP.Length)
				{
					float t = num3 - (float)num4;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num4], this.BBCJFBHDJFP[num4 + 0], t);
				}
				else if (num4 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num4];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.BDOOQPLCECP.CEGFBBHMKOE.a;
			this.BDOOQPLCECP.CEGFBBHMKOE = cegfbbhmkoe;
		}
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x000E529C File Offset: 0x000E349C
	public void GGGKGNOCCMD(int DEIHPCIDLIO, int LBHJHFGJDGQ)
	{
		this.CCHDHKECLCD = DEIHPCIDLIO - 1;
		if (DEIHPCIDLIO < 0)
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC("Battle Update: ");
		}
		else
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC(DEIHPCIDLIO.ToString());
		}
		this.BDOOQPLCECP.DIIHJCJOKMP = 1705f;
		if (LBHJHFGJDGQ > 1)
		{
			float num = (float)LBHJHFGJDGQ / 304f;
			float num2 = num * 1585f;
			this.BDOOQPLCECP.DIIHJCJOKMP = 570f;
			this.BDOOQPLCECP.KJGMGPCEJJD = (int)num2;
			float num3 = num;
			num3 *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num4 = Mathf.FloorToInt(num3);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num4 >= 0)
			{
				if (num4 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num3 - (float)num4;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num4], this.BBCJFBHDJFP[num4 + 1], t);
				}
				else if (num4 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num4];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			bgbmiejjqkc.a = this.BDOOQPLCECP.CEGFBBHMKOE.a;
			this.BDOOQPLCECP.NONQDHBCIIN(bgbmiejjqkc);
		}
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x000E53FC File Offset: 0x000E35FC
	public void MIBJQJQEJQD(int DEIHPCIDLIO, int LBHJHFGJDGQ)
	{
		this.CCHDHKECLCD = DEIHPCIDLIO - 1;
		if (DEIHPCIDLIO < 1)
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC("0");
		}
		else
		{
			this.JJPKKPFCQKN.LKPOBCBOFIC(DEIHPCIDLIO.ToString());
		}
		this.BDOOQPLCECP.DIIHJCJOKMP = 1097f;
		if (LBHJHFGJDGQ > 1)
		{
			float num = (float)LBHJHFGJDGQ / 252f;
			float num2 = num * 419f;
			this.BDOOQPLCECP.DIIHJCJOKMP = 1106f;
			this.BDOOQPLCECP.KJGMGPCEJJD = (int)num2;
			float num3 = num;
			num3 *= (float)(this.BBCJFBHDJFP.Length - 0);
			int num4 = Mathf.FloorToInt(num3);
			Color bgbmiejjqkc = this.BBCJFBHDJFP[1];
			if (num4 >= 1)
			{
				if (num4 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num3 - (float)num4;
					bgbmiejjqkc = Color.Lerp(this.BBCJFBHDJFP[num4], this.BBCJFBHDJFP[num4 + 0], t);
				}
				else if (num4 < this.BBCJFBHDJFP.Length)
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[num4];
				}
				else
				{
					bgbmiejjqkc = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 0];
				}
			}
			bgbmiejjqkc.a = this.BDOOQPLCECP.CEGFBBHMKOE.a;
			this.BDOOQPLCECP.NONQDHBCIIN(bgbmiejjqkc);
		}
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x000E555C File Offset: 0x000E375C
	public void NNCPPBFPEPK(int DEIHPCIDLIO, int LBHJHFGJDGQ)
	{
		this.CCHDHKECLCD = DEIHPCIDLIO - 1;
		if (DEIHPCIDLIO < 0)
		{
			this.JJPKKPFCQKN.PIDLOFMIEFQ = "-";
		}
		else
		{
			this.JJPKKPFCQKN.PIDLOFMIEFQ = DEIHPCIDLIO.ToString();
		}
		this.BDOOQPLCECP.DIIHJCJOKMP = 0f;
		if (LBHJHFGJDGQ > 0)
		{
			float num = (float)LBHJHFGJDGQ / 24f;
			float num2 = num * 26f;
			this.BDOOQPLCECP.DIIHJCJOKMP = 1f;
			this.BDOOQPLCECP.KJGMGPCEJJD = (int)num2;
			float num3 = num;
			num3 *= (float)(this.BBCJFBHDJFP.Length - 1);
			int num4 = Mathf.FloorToInt(num3);
			Color cegfbbhmkoe = this.BBCJFBHDJFP[0];
			if (num4 >= 0)
			{
				if (num4 + 1 < this.BBCJFBHDJFP.Length)
				{
					float t = num3 - (float)num4;
					cegfbbhmkoe = Color.Lerp(this.BBCJFBHDJFP[num4], this.BBCJFBHDJFP[num4 + 1], t);
				}
				else if (num4 < this.BBCJFBHDJFP.Length)
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[num4];
				}
				else
				{
					cegfbbhmkoe = this.BBCJFBHDJFP[this.BBCJFBHDJFP.Length - 1];
				}
			}
			cegfbbhmkoe.a = this.BDOOQPLCECP.CEGFBBHMKOE.a;
			this.BDOOQPLCECP.CEGFBBHMKOE = cegfbbhmkoe;
		}
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x00012EE5 File Offset: 0x000110E5
	private void CDMJBDGFHBD()
	{
		if (this.CCHDHKECLCD > -1)
		{
			JJGLMJNELOK.KGOPJQOMMNC().HOEQQEHMGQO(this.CCHDHKECLCD);
		}
	}

	// Token: 0x04000798 RID: 1944
	public PLQFPBQEPJD BDOOQPLCECP;

	// Token: 0x04000799 RID: 1945
	public BKKHLBCLPJM JJPKKPFCQKN;

	// Token: 0x0400079A RID: 1946
	public int CCHDHKECLCD = -1;

	// Token: 0x0400079B RID: 1947
	public Color[] BBCJFBHDJFP = new Color[]
	{
		Color.red,
		Color.yellow,
		Color.green
	};
}
