using System;
using System.Collections;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020001D6 RID: 470
public class CGNFQJPJEPC : MonoBehaviour
{
	// Token: 0x06003CF7 RID: 15607 RVA: 0x001CB554 File Offset: 0x001C9754
	public void ELKFNGPLCDI(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 468f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1343f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1410f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1151f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1636f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 789f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1251f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1298f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.FGICOLEMQFI(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 959f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1767f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("[00DD00]Equipped");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1833f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("Boosts evasion in a hailstorm.");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1227f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].JLENFJGDNFN("!\r\n");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1395f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("[-]!\r\n");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 384f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("[-]!\r\n");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 858f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[1].LGJOOQIBQDC(" melted the ice!\r\n");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1591f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1278f;
		IL_33A:
		int num = (int)(1762.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1359.0) * 1110.0 - 774.0);
		if (num > 93)
		{
			num = -123;
		}
		if (num <= 8)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 99;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1318f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1095f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -77;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(746f, 46f, 1706f, 1931f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 812f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -98;
		}
		else
		{
			int num2 = (int)(147.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1809.0) * 629.0 - 1975.0);
			if (num2 > -111)
			{
				num2 = 117;
			}
			if (num2 <= 3)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[3].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1274f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 3;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 5;
					this.MPMOKOOHPLI[2].DIIHJCJOKMP = 229f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 224f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Steps Taken:" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("replace" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "It started to hail!";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 877f;
		}
		else
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1252f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "[00EE07]" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(false);
		string empty = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -91)
		{
			int num3 = FFJJCIQPLOP.QKNEIJQHGCB % 1;
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("[o]" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + empty, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1799f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator LOOKQEMEKMB(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		BKKHLBCLPJM component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003CF9 RID: 15609 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator ENQGDFEHQEE(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x001CBC74 File Offset: 0x001C9E74
	public void HDNLCNIHJBM(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1942f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 200f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 656f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 796f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 477f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1812f;
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 938f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 657f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ONOOEKOJDLI(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1012f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1081f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("Becomes competitive and deals more damage to Pokémon of the same gender, but deals less to Pokémon of the opposite gender.");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1275f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("Delete Tab");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1764f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[8].OGQLCMOFLLQ("_");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1749f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].JLENFJGDNFN("Disabled");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1630f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("Blank");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1392f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[6].JLENFJGDNFN(" is in love with ");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1477f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 282f;
		IL_33A:
		int num = (int)(746.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1369.0) * 1337.0 - 1067.0);
		if (num > 5)
		{
			num = -97;
		}
		if (num <= 7)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 2;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1520f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1418f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -105;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(280f, 1926f, 1180f, 506f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 792f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 88;
		}
		else
		{
			int num2 = (int)(413.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1748.0) * 762.0 - 246.0);
			if (num2 > -3)
			{
				num2 = -29;
			}
			if (num2 <= 6)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 293f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 7;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1324f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 367f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "(G)" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Frost" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("HidePanel");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 308f;
		}
		else
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 705f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Slot Machine" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -85 && FFJJCIQPLOP.QKNEIJQHGCB % 91 > 1)
		{
			str = "[00EE07]" + (FFJJCIQPLOP.QKNEIJQHGCB % 106).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("WATER_REFLECTIVE" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 770f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x001CC394 File Offset: 0x001CA594
	public void LCCLHQMCGNB(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1330f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1712f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1176f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 628f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1626f;
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1259f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 743f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1773f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.QDMKFMJBGNN(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1133f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 997f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[4].OGQLCMOFLLQ("[-]!\r\n");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1071f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[2].DPBGHDMHKNC("'?");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1242f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[3].DPBGHDMHKNC("status: ");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1108f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("item");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1033f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("Purchasing");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 963f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("Player/Body");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 146f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[5].DIIHJCJOKMP = 895f;
		IL_33A:
		int num = (int)(1719.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1646.0) * 1441.0 - 1878.0);
		if (num > -18)
		{
			num = 76;
		}
		if (num <= 8)
		{
			num = 1;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -37;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1557f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1178f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -100;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(994f, 721f, 1627f, 1517f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1199f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 104;
		}
		else
		{
			int num2 = (int)(51.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1898.0) * 442.0 - 58.0);
			if (num2 > -32)
			{
				num2 = -8;
			}
			if (num2 <= 8)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[3].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1592f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 3;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 4;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 654f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1238f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Coal Badge" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = " was subjected to torment!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("Account Suspended");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 826f;
		}
		else
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1650f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("CombinersAlphaPassThrough" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -111 && FFJJCIQPLOP.QKNEIJQHGCB % 34 > 0)
		{
			str = "High" + (FFJJCIQPLOP.QKNEIJQHGCB % 70).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("Trigger Boundaries" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 657f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x001CCAB4 File Offset: 0x001CACB4
	public void KGBBFDJGGPQ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 743f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 227f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1761f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 860f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 939f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 699f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1906f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 345f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NLHMHCJPHOG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 126f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1093f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].JLENFJGDNFN("4");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1399f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC(" has chosen to shift.");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1139f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("Boosts its Sp. Atk stat every time a Pokémon faints.");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 596f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[2].OGQLCMOFLLQ("ReleasePoke");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1247f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].OGQLCMOFLLQ(")");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 177f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].KCLBMPFIPNQ = ".";
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1721f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1299f;
		IL_33A:
		int num = (int)(504.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1275.0) * 13.0 - 698.0);
		if (num > 8)
		{
			num = -10;
		}
		if (num <= 6)
		{
			num = 7;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 3;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1460f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1910f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 57;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(765f, 589f, 623f, 1102f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1353f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -122;
		}
		else
		{
			int num2 = (int)(901.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 796.0) * 1008.0 - 867.0);
			if (num2 > -55)
			{
				num2 = 61;
			}
			if (num2 <= 4)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[2].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1233f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 0;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1418f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 188f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "_1" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "$" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Shields Down";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 971f;
		}
		else
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1882f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Creating Account" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 184 && FFJJCIQPLOP.QKNEIJQHGCB % -120 > 1)
		{
			str = "Reset EVs" + (FFJJCIQPLOP.CCMOCLMEKJN() % -125).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" shared its guard with " + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 161f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x001CD1D4 File Offset: 0x001CB3D4
	public void MKPCPBJQNID(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1726f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 56f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1705f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 239f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1883f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1845f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1964f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 270f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.IDHFMBMIKMO(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 661f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 874f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("'s torment wore off!\r\n");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1418f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("[00EE07]");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1710f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = ".";
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 702f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[1].JOHBNEHCEJH("Score: ");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1660f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].JLENFJGDNFN("l");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 6f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[4].LGJOOQIBQDC("-activate");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1384f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1524f;
		IL_33A:
		int num = (int)(883.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 930.0) * 984.0 - 1730.0);
		if (num > 48)
		{
			num = 78;
		}
		if (num <= 2)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -28;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 820f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 686f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -105;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1602f, 443f, 886f, 1571f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1493f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -19;
		}
		else
		{
			int num2 = (int)(1373.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1636.0) * 1687.0 - 1914.0);
			if (num2 > -120)
			{
				num2 = -76;
			}
			if (num2 <= 3)
			{
				num2 = 4;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 676f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 4;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[3].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 206f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1385f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "OnScroll" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Player/Body" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = " tucked in its head!\r\n";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 938f;
		}
		else
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1749f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Materials/DFOWithSky" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 87 && FFJJCIQPLOP.QKNEIJQHGCB % -86 > 0)
		{
			str = "[-]!\r\n" + (FFJJCIQPLOP.QKNEIJQHGCB % -98).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("sleep" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 870f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x001CD8F4 File Offset: 0x001CBAF4
	public void NPBOJJOKEME(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1363f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1499f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1551f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 456f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 503f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 316f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1158f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 99f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.GBEMLGFEMCF(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1846f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1858f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("U");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1852f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[3].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 926f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[4].DPBGHDMHKNC("ability: ");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1261f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[6].IQBBDKFDGGP("Cloud Nine");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 373f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].JOHBNEHCEJH("[ATK]");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 526f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[3].JLENFJGDNFN("The Pokémon's strong jaw boosts the power of its biting moves.");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1760f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1422f;
		IL_33A:
		int num = (int)(260.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 585.0) * 1399.0 - 61.0);
		if (num > -28)
		{
			num = 15;
		}
		if (num <= 8)
		{
			num = 6;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 43;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 604f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1046f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 120;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1550f, 1838f, 339f, 1880f);
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 62f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -112;
		}
		else
		{
			int num2 = (int)(839.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1657.0) * 1190.0 - 900.0);
			if (num2 > -15)
			{
				num2 = 119;
			}
			if (num2 <= 6)
			{
				num2 = 8;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[5].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[0].DIIHJCJOKMP = 974f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 3;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1651f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 479f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Fishing Bites occur more often" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("psychicterrain" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("[o]");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1688f;
		}
		else
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 166f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Natural Cure" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -96 && FFJJCIQPLOP.QKNEIJQHGCB % -118 > 0)
		{
			str = " is confused!\r\n" + (FFJJCIQPLOP.QKNEIJQHGCB % -92).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("ability: " + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 442f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator NLHMHCJPHOG(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator BOQOGCELGQM(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator QBHICQMJCJF(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x001CE014 File Offset: 0x001CC214
	public void DEPHJMJBIPE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 438f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1610f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 468f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1372f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1079f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1139f;
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 141f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 789f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.LEOMJDLLCJJ(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 142f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1162f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[2].JLENFJGDNFN("Icon_Status_Paralyzed");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 750f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[7].KCLBMPFIPNQ = " is hurt!\r\n";
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 425f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].JOHBNEHCEJH("Clear Body");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1991f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[3].KCLBMPFIPNQ = "/510)";
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 28f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[3].KCLBMPFIPNQ = "You used Sweet Scent recently and are unable to use it again.";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1214f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[4].IQBBDKFDGGP("ice");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 702f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1440f;
		IL_33A:
		int num = (int)(1404.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1331.0) * 1778.0 - 174.0);
		if (num > 35)
		{
			num = -84;
		}
		if (num <= 5)
		{
			num = 5;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -7;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 621f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1718f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 14;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(1901f, 47f, 87f, 1328f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1880f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 44;
		}
		else
		{
			int num2 = (int)(849.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1174.0) * 1543.0 - 235.0);
			if (num2 > 112)
			{
				num2 = 98;
			}
			if (num2 <= 8)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[8].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[0].DIIHJCJOKMP = 250f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 4;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[6].KJGMGPCEJJD = 6;
					this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1569f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 718f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Hidden/Post FX/Uber Shader" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("destinybond" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Music";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 959f;
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 784f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "1" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 90 && FFJJCIQPLOP.CCMOCLMEKJN() % -20 > 0)
		{
			str = "ProCamera2D Repeater extension - No ObjectToRepeat defined!" + (FFJJCIQPLOP.CCMOCLMEKJN() % 63).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("RC" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 713f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator EIJIGQKEPLE(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x001CE734 File Offset: 0x001CC934
	public void JPQNFJLGHJE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1097f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 468f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 582f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 324f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1521f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 521f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1801f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1689f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NDQHDPOQJLB(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 550f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1437f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH(".");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 226f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("slp");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 723f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[5].OGQLCMOFLLQ("l");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1738f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[4].KCLBMPFIPNQ = "ffb649";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 804f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[6].LGJOOQIBQDC(" switched items with its target!\r\n");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1939f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("!\r\n");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 56f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 178f;
		IL_33A:
		int num = (int)(1024.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1819.0) * 1331.0 - 1326.0);
		if (num > -83)
		{
			num = -44;
		}
		if (num <= 4)
		{
			num = 7;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 35;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 98f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 124f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 91;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1285f, 622f, 1632f, 434f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 160f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 83;
		}
		else
		{
			int num2 = (int)(330.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1828.0) * 1767.0 - 697.0);
			if (num2 > 33)
			{
				num2 = -68;
			}
			if (num2 <= 0)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1473f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 0;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[4].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[6].DIIHJCJOKMP = 699f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1177f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = " began charging power!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "door_2" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Guild Name: ";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 595f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 553f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Blank" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 131 && FFJJCIQPLOP.CCMOCLMEKJN() % -36 > 0)
		{
			str = "The spikes disappeared from the ground around " + (FFJJCIQPLOP.CCMOCLMEKJN() % -86).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(" would like to be friends. Do you wish to accept?" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 576f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x001CEE54 File Offset: 0x001CD054
	public void OJIBNMPCFBQ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 278f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1191f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 507f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 93f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 11f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1384f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 614f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 915f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.MNOJFKIGEMJ(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1307f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1713f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("Hi-Score: ");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1580f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("_ReflectionTexture4");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1867f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("Assets/AssetBundles/Pokes");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1493f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("Player Information");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1250f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[2].IQBBDKFDGGP("White Smoke");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1971f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[2].LGJOOQIBQDC("recycle");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 509f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 77f;
		IL_33A:
		int num = (int)(1579.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 493.0) * 91.0 - 460.0);
		if (num > -115)
		{
			num = -98;
		}
		if (num <= 5)
		{
			num = 2;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 67;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 513f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 215f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -111;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(97f, 160f, 406f, 1634f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1964f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -122;
		}
		else
		{
			int num2 = (int)(737.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 840.0) * 542.0 - 1761.0);
			if (num2 > -107)
			{
				num2 = -124;
			}
			if (num2 <= 7)
			{
				num2 = 1;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1158f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 1;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[5].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 469f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1738f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "OnNavigate" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("General");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 929f;
		}
		else
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1508f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(" restored its HP!\r\n" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -95 && FFJJCIQPLOP.QKNEIJQHGCB % -32 > 0)
		{
			str = "Error calling " + (FFJJCIQPLOP.CCMOCLMEKJN() % 63).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("-supereffective" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1768f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x001CF574 File Offset: 0x001CD774
	public void CQKHIPOLJNL(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1597f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1030f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 310f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1410f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 446f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 698f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1609f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1599f;
		bool flag = false;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.DFGNOLELPOL(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 262f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1727f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("Thunder Badge");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 861f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[3].LGJOOQIBQDC("[s]");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 930f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].DPBGHDMHKNC("Member");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 106f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[6].KCLBMPFIPNQ = "You are already in a guild and can not do this.";
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 194f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[6].LGJOOQIBQDC("[ffb649]");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1309f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "4";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1564f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 479f;
		IL_33A:
		int num = (int)(257.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 743.0) * 1783.0 - 1468.0);
		if (num > -48)
		{
			num = -95;
		}
		if (num <= 4)
		{
			num = 8;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 27;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 548f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1348f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -64;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(1496f, 1521f, 34f, 1077f);
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 984f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -8;
		}
		else
		{
			int num2 = (int)(28.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1515.0) * 877.0 - 1732.0);
			if (num2 > 67)
			{
				num2 = 95;
			}
			if (num2 <= 1)
			{
				num2 = 4;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[3].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 410f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 6;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[2].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1092f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 893f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "berry_13" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("[broken]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Stop";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 400f;
		}
		else
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 556f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "HH:mm:ss" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 151 && FFJJCIQPLOP.QKNEIJQHGCB % -22 > 0)
		{
			str = ")" + (FFJJCIQPLOP.QKNEIJQHGCB % -98).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("[FFFFFF][" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1483f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x001CFC94 File Offset: 0x001CDE94
	public void LCCQBMMFONQ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1662f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 485f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 718f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 86f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1267f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1377f;
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 342f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1034f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.EIJIGQKEPLE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 188f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 962f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("Temp Sound Clip");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1737f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "Water";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 734f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("FOG_SCATTERING_ON");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1992f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "_Texture1";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 61f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "Chromatic Aberration Spectrum Lookup";
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1297f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[3].IQBBDKFDGGP("Blade");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 312f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1036f;
		IL_33A:
		int num = (int)(1963.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1462.0) * 303.0 - 473.0);
		if (num > -32)
		{
			num = -26;
		}
		if (num <= 1)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -19;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 349f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1934f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 40;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1042f, 1591f, 722f, 99f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1445f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -72;
		}
		else
		{
			int num2 = (int)(521.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1324.0) * 938.0 - 1653.0);
			if (num2 > 29)
			{
				num2 = 108;
			}
			if (num2 <= 8)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[6].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1757f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 2;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1247f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1773f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Reset EVs" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "[-] was taken over!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Player/Mounts/";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 936f;
		}
		else
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1213f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Are you sure you wish to delete your '" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -197 && FFJJCIQPLOP.CCMOCLMEKJN() % 52 > 1)
		{
			str = "--offline" + (FFJJCIQPLOP.QKNEIJQHGCB % -93).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("less than 1 minute ago" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1205f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator BIHHICKHNHK(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D0A RID: 15626 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator NDQHDPOQJLB(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x001D03B4 File Offset: 0x001CE5B4
	public void BFBEIJGQKHJ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 844f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1235f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 389f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1965f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 964f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 700f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1600f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1872f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.QBHICQMJCJF(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1359f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 410f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[1].LGJOOQIBQDC("Unequip");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1760f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[2].OGQLCMOFLLQ("b");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1545f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].KCLBMPFIPNQ = "[PG]";
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1482f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[4].LGJOOQIBQDC("r");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1785f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("[d9b38c]Message");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 635f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[3].LGJOOQIBQDC("]");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1937f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[4].DIIHJCJOKMP = 529f;
		IL_33A:
		int num = (int)(368.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 134.0) * 1328.0 - 257.0);
		if (num > -17)
		{
			num = 63;
		}
		if (num <= 1)
		{
			num = 1;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -21;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 204f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 74f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -11;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(614f, 1318f, 1935f, 252f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1437f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -100;
		}
		else
		{
			int num2 = (int)(1768.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1072.0) * 1956.0 - 1640.0);
			if (num2 > -15)
			{
				num2 = 18;
			}
			if (num2 <= 3)
			{
				num2 = 1;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[2].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 457f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 0;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 5;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1665f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1266f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "#,##0" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "snatch" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "game4.poke.one";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 274f;
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 983f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "-primal" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -61 && FFJJCIQPLOP.CCMOCLMEKJN() % -51 > 1)
		{
			str = "!\r\n" + (FFJJCIQPLOP.CCMOCLMEKJN() % 92).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("snorlax" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1203f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x001D0AD4 File Offset: 0x001CECD4
	public void EGFLCLQJBHG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 424f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 63f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 448f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1766f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 193f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 696f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 473f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 438f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.JPEODCEJNOM(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1076f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 918f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[6].KCLBMPFIPNQ = "motordrive";
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 744f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[3].KCLBMPFIPNQ = "Stop";
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 193f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[4].JLENFJGDNFN("item");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 674f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[4].JLENFJGDNFN("[/i]");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 88f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].JLENFJGDNFN("[ff6666]");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 249f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[2].JOHBNEHCEJH(" is making an uproar!\r\n");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 793f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[6].DIIHJCJOKMP = 322f;
		IL_33A:
		int num = (int)(963.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1787.0) * 437.0 - 920.0);
		if (num > 55)
		{
			num = 112;
		}
		if (num <= 2)
		{
			num = 6;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -38;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1021f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 108f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -51;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1879f, 111f, 1645f, 1247f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 345f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 54;
		}
		else
		{
			int num2 = (int)(361.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 676.0) * 91.0 - 1147.0);
			if (num2 > 40)
			{
				num2 = 32;
			}
			if (num2 <= 5)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[5].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1651f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 5;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 3;
					this.MPMOKOOHPLI[7].DIIHJCJOKMP = 866f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 63f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Down" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Login" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("[ffb649]");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 343f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1796f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Player/Hats/" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 88 && FFJJCIQPLOP.QKNEIJQHGCB % 78 > 0)
		{
			str = "DirX" + (FFJJCIQPLOP.QKNEIJQHGCB % 65).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("ENABLE_BLUE_CHANNEL" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1559f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x001D11F4 File Offset: 0x001CF3F4
	public void QNJHMCKNJIK(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1517f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1671f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 142f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1161f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1535f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 483f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1209f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1025f;
		bool flag = false;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ENQGDFEHQEE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 894f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1843f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("Forest Badge");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1096f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[7].DPBGHDMHKNC("Fishing Cooldown");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1231f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].JOHBNEHCEJH("MegaRayquaza");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1459f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("'s ");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 610f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "Icon_Status_BadlyPoisoned";
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1617f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[6].JLENFJGDNFN("Player/Hair");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1057f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1371f;
		IL_33A:
		int num = (int)(1289.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1049.0) * 1641.0 - 1020.0);
		if (num > 79)
		{
			num = -30;
		}
		if (num <= 3)
		{
			num = 7;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 120;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 65f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 880f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 111;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(128f, 1729f, 1967f, 378f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1811f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 37;
		}
		else
		{
			int num2 = (int)(1320.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 393.0) * 81.0 - 618.0);
			if (num2 > 91)
			{
				num2 = 35;
			}
			if (num2 <= 4)
			{
				num2 = 2;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[6].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[1].DIIHJCJOKMP = 969f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 6;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 2;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 703f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1434f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Boosts the Sp. Atk stat sharply when a stat is lowered." + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC(" can't use [ffff00]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("More Likely Male Encounters");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1590f;
		}
		else
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 146f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "inven " + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 47 && FFJJCIQPLOP.CCMOCLMEKJN() % -82 > 0)
		{
			str = "[ATK]" + (FFJJCIQPLOP.QKNEIJQHGCB % 57).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD(" used [ffff00]" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1319f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D0E RID: 15630 RVA: 0x001D1914 File Offset: 0x001CFB14
	public void BLFPCGEIDNL(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 654f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1103f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1759f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 304f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 842f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 544f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1241f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1032f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.LEOMJDLLCJJ(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 352f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1914f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("[04B9E6]Party");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1894f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("map:");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 927f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[4].LGJOOQIBQDC("2_");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1443f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[3].LGJOOQIBQDC("]");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 26f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "0";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1669f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("[pok=");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1858f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1191f;
		IL_33A:
		int num = (int)(1928.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1692.0) * 1474.0 - 873.0);
		if (num > -63)
		{
			num = -97;
		}
		if (num <= 6)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 63;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 409f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 651f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -62;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1848f, 1495f, 1173f, 42f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 980f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -62;
		}
		else
		{
			int num2 = (int)(392.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 696.0) * 1959.0 - 639.0);
			if (num2 > -111)
			{
				num2 = 126;
			}
			if (num2 <= 7)
			{
				num2 = 6;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[6].DIIHJCJOKMP = 552f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 3;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[2].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1812f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 509f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "l" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC(" shared its guard with the target!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("Remove Item");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1667f;
		}
		else
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1154f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " minute" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -58 && FFJJCIQPLOP.CCMOCLMEKJN() % -27 > 0)
		{
			str = "_FogPointLightColor5" + (FFJJCIQPLOP.QKNEIJQHGCB % 109).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("lightscreen" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 854f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x001D2034 File Offset: 0x001D0234
	public void GLFKLCGKJEI(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1255f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1890f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 828f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1204f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1558f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1903f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 60f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 261f;
		bool flag = false;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.CQMEDPBOHEI(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1616f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 938f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[2].LGJOOQIBQDC("user: ");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 911f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC(")");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1460f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("_SSRMultiplier");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 851f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[3].JLENFJGDNFN(" did not learn the move ");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 998f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("LJMOLEKDCLP");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1967f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[4].DPBGHDMHKNC("protean");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1434f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1177f;
		IL_33A:
		int num = (int)(1984.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1497.0) * 1514.0 - 566.0);
		if (num > 15)
		{
			num = 109;
		}
		if (num <= 3)
		{
			num = 1;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 35;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 293f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 184f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -13;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1484f, 890f, 826f, 90f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1958f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 54;
		}
		else
		{
			int num2 = (int)(1398.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1177.0) * 772.0 - 920.0);
			if (num2 > -117)
			{
				num2 = -101;
			}
			if (num2 <= 1)
			{
				num2 = 7;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[6].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1484f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 6;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[2].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 494f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 83f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("[FF8F00]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "dots" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "bag";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1642f;
		}
		else
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1847f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " minutes ago" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 107 && FFJJCIQPLOP.QKNEIJQHGCB % 110 > 1)
		{
			str = "~" + (FFJJCIQPLOP.CCMOCLMEKJN() % -70).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD(". " + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 359f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x001D2754 File Offset: 0x001D0954
	public void LBIHDCQJNGB(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 396f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 624f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1395f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1130f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1905f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1367f;
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 118f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 687f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NLHMHCJPHOG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1129f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1008f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[6].DPBGHDMHKNC("It's so gutsy that having a status condition boosts the Pokémon's Attack stat.");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 439f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("OnDragOut");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1381f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].DPBGHDMHKNC("wonderroom");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 748f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[6].IQBBDKFDGGP("ENABLE_GREEN_CHANNEL");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 851f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[4].KCLBMPFIPNQ = "Player/Mounts/";
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1691f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("[ATK]");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 961f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 681f;
		IL_33A:
		int num = (int)(1499.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 41.0) * 1050.0 - 1801.0);
		if (num > 4)
		{
			num = -48;
		}
		if (num <= 4)
		{
			num = 6;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 14;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 690f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 59f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -62;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1790f, 1989f, 1725f, 867f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1476f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 46;
		}
		else
		{
			int num2 = (int)(715.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 883.0) * 812.0 - 1331.0);
			if (num2 > -12)
			{
				num2 = 26;
			}
			if (num2 <= 8)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1800f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 5;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[7].DIIHJCJOKMP = 732f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 976f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = " surrounded itself with a veil of water!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("frisked " + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "[-]!\r\n";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 795f;
		}
		else
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 854f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("The trade with '" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -87 && FFJJCIQPLOP.CCMOCLMEKJN() % 78 > 1)
		{
			str = "Obtain the " + (FFJJCIQPLOP.CCMOCLMEKJN() % 117).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("Sound" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1785f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator MNOJFKIGEMJ(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x001D2E74 File Offset: 0x001D1074
	public void QPONNMLDLQD(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1719f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 774f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 986f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 956f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 718f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1376f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 26f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1573f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.FGICOLEMQFI(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 876f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1505f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("DEPTH_OF_FIELD");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 40f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("aromatherapy");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1962f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[5].JLENFJGDNFN("Color Grading Log LUT");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 167f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("_Female");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 423f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("I");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1682f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[6].LGJOOQIBQDC("+");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1510f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 102f;
		IL_33A:
		int num = (int)(1476.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 280.0) * 970.0 - 1543.0);
		if (num > 83)
		{
			num = -49;
		}
		if (num <= 2)
		{
			num = 0;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 11;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 916f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1566f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -7;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(1895f, 207f, 63f, 33f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1091f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -123;
		}
		else
		{
			int num2 = (int)(1348.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1004.0) * 1084.0 - 1051.0);
			if (num2 > -45)
			{
				num2 = 44;
			}
			if (num2 <= 0)
			{
				num2 = 4;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[7].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1452f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 2;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[4].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1031f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 347f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("static" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "[-]";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1324f;
		}
		else
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1973f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Unable to add '" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 37 && FFJJCIQPLOP.QKNEIJQHGCB % 99 > 0)
		{
			str = "Symbiosis" + (FFJJCIQPLOP.CCMOCLMEKJN() % 35).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("raindish" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 36f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator IDHFMBMIKMO(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator FGICOLEMQFI(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator IFEJINOMGGD(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x001D3594 File Offset: 0x001D1794
	public void FQFIFPGJDBE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 244f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1682f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1126f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 636f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 52f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1405f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 988f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 744f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NLHMHCJPHOG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 370f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 752f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[0].JLENFJGDNFN("Clear Body");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1763f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "TCPManager";
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 830f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("Button");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 198f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("HidePanel");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 943f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[7].IQBBDKFDGGP("0");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 669f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "[00EE07]";
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1804f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 76f;
		IL_33A:
		int num = (int)(1881.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1518.0) * 1891.0 - 572.0);
		if (num > -107)
		{
			num = -5;
		}
		if (num <= 7)
		{
			num = 6;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 71;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 873f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1240f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -69;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1633f, 419f, 939f, 105f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1193f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -118;
		}
		else
		{
			int num2 = (int)(1255.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1517.0) * 1437.0 - 903.0);
			if (num2 > 95)
			{
				num2 = -124;
			}
			if (num2 <= 5)
			{
				num2 = 8;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[4].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1051f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 5;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1799f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1044f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("any" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("[eat]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("Right");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 80f;
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1548f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("RenderType" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -136 && FFJJCIQPLOP.QKNEIJQHGCB % -104 > 1)
		{
			str = "[/sub]" + (FFJJCIQPLOP.QKNEIJQHGCB % 90).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI(" requires " + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 651f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator MGBOHDBDPMH(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x001D3CB4 File Offset: 0x001D1EB4
	public void KEHBPLMFDIP(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1479f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 671f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1677f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 114f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1510f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 977f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 597f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 669f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.QDMKFMJBGNN(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 965f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 381f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC(".");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1330f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("(Z)");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 123f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[2].KCLBMPFIPNQ = "#,##0";
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 880f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].JLENFJGDNFN("Run_White");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1537f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("OnPress");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1368f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].JOHBNEHCEJH("Data/learnsets");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 50f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1213f;
		IL_33A:
		int num = (int)(1280.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1598.0) * 590.0 - 1362.0);
		if (num > 127)
		{
			num = -101;
		}
		if (num <= 1)
		{
			num = 4;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -16;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 783f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1501f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 56;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(1161f, 1440f, 618f, 182f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 577f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -96;
		}
		else
		{
			int num2 = (int)(120.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1358.0) * 198.0 - 466.0);
			if (num2 > 51)
			{
				num2 = -121;
			}
			if (num2 <= 0)
			{
				num2 = 2;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[3].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[4].DIIHJCJOKMP = 946f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 6;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 5;
					this.MPMOKOOHPLI[5].DIIHJCJOKMP = 82f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1698f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Small/" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "longreach" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("Turns the ground into Grassy Terrain when the Pokémon enters a battle.");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 546f;
		}
		else
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 657f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("4x" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 4 && FFJJCIQPLOP.CCMOCLMEKJN() % -1 > 0)
		{
			str = "/01_" + (FFJJCIQPLOP.CCMOCLMEKJN() % -116).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Interact" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 414f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x001D43D4 File Offset: 0x001D25D4
	public void EDKDPDKIBJN(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1628f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 46f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 674f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 986f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1317f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 647f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1248f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 899f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NLHMHCJPHOG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 444f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 646f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("General");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 681f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].OGQLCMOFLLQ("#,##0");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1786f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].KCLBMPFIPNQ = "'s [ffff00]";
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1431f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("fighting");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1957f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[2].DPBGHDMHKNC("Icon_Pokemon_Dead");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 144f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "BuffIcon_SweetScent";
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 790f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1495f;
		IL_33A:
		int num = (int)(1847.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 879.0) * 1560.0 - 591.0);
		if (num > -100)
		{
			num = 76;
		}
		if (num <= 4)
		{
			num = 4;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 78;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 304f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1080f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -40;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(451f, 1883f, 108f, 791f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1599f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 99;
		}
		else
		{
			int num2 = (int)(1800.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1099.0) * 1440.0 - 1316.0);
			if (num2 > 101)
			{
				num2 = 97;
			}
			if (num2 <= 4)
			{
				num2 = 7;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 397f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 2;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 7;
					this.MPMOKOOHPLI[7].DIIHJCJOKMP = 318f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1412f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "-crit" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC(".prefab" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("Player/Hats/");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 701f;
		}
		else
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1680f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "!\r\n" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 56 && FFJJCIQPLOP.CCMOCLMEKJN() % 33 > 1)
		{
			str = "item" + (FFJJCIQPLOP.QKNEIJQHGCB % 102).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("_FogData2" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 293f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D1A RID: 15642 RVA: 0x001D4AF4 File Offset: 0x001D2CF4
	public void DFEONCOPCPE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1764f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 139f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 449f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 633f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 111f;
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1303f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1295f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1736f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.GBNQEKLJFCI() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.MGBOHDBDPMH(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 657f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 142f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[6].KCLBMPFIPNQ = "0";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 321f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("BuffIcon_MaleIncrease");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1902f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].LGJOOQIBQDC("Esc");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1849f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[5].LGJOOQIBQDC("money=");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 398f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[6].KCLBMPFIPNQ = "Sky";
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1607f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[4].OGQLCMOFLLQ("Pokemon3D/Index");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 848f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[6].DIIHJCJOKMP = 895f;
		IL_33A:
		int num = (int)(661.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 85.0) * 1267.0 - 1777.0);
		if (num > 10)
		{
			num = 117;
		}
		if (num <= 5)
		{
			num = 7;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -28;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 312f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 277f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -13;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(1860f, 1735f, 888f, 397f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1327f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 59;
		}
		else
		{
			int num2 = (int)(1212.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 573.0) * 1795.0 - 568.0);
			if (num2 > 46)
			{
				num2 = 113;
			}
			if (num2 <= 3)
			{
				num2 = 1;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[5].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1131f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 1;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 8;
					this.MPMOKOOHPLI[2].DIIHJCJOKMP = 85f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1384f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("bloom" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("blacksludge" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "[PG]";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1176f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 646f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " was burned" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -49 && FFJJCIQPLOP.CCMOCLMEKJN() % -101 > 1)
		{
			str = "Technician" + (FFJJCIQPLOP.CCMOCLMEKJN() % -38).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("'s perish count fell to 3.\r\n" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 218f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D1B RID: 15643 RVA: 0x001D5214 File Offset: 0x001D3414
	public void LBGCODKNHHP(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 281f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1455f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 332f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1339f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 396f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 830f;
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 98f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1111f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.BIHHICKHNHK(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1619f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1898f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[4].LGJOOQIBQDC("'.");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 735f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("X8");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1755f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("HideEmote");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1656f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("Schooling");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1937f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[4].OGQLCMOFLLQ("Quest Complete!");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 181f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("_WaveScale");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1617f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[5].DIIHJCJOKMP = 782f;
		IL_33A:
		int num = (int)(1117.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 511.0) * 1315.0 - 681.0);
		if (num > 86)
		{
			num = 21;
		}
		if (num <= 0)
		{
			num = 1;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -78;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 604f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 817f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -14;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(72f, 1762f, 1494f, 299f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 264f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 53;
		}
		else
		{
			int num2 = (int)(1869.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1732.0) * 1836.0 - 980.0);
			if (num2 > 65)
			{
				num2 = -33;
			}
			if (num2 <= 6)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[2].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 621f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 1;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[6].KJGMGPCEJJD = 2;
					this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1393f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1127f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "[FF8F00]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Run_White" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "[ff9900]";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1527f;
		}
		else
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1803f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("The Water-type attack evaporated in the harsh sunlight!\r\n" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -151 && FFJJCIQPLOP.QKNEIJQHGCB % 112 > 0)
		{
			str = "13" + (FFJJCIQPLOP.CCMOCLMEKJN() % 38).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("replace" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1415f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator ICIHKHJLQNG(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D1D RID: 15645 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator JPEODCEJNOM(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x001D5934 File Offset: 0x001D3B34
	public void BQLIIQIIMDH(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 0f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 0f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 0f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 0f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 0f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 0f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 0f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ICIHKHJLQNG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 0f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "burn";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "freeze";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "paralize";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "psn";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "sleep";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "psn";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[5].DIIHJCJOKMP = 0f;
		IL_33A:
		int num = (int)(75.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 100.0) * 100.0 - 1.0);
		if (num > 75)
		{
			num = 75;
		}
		if (num <= 2)
		{
			num = 2;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 75;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 74;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1f, 0f, 0f, 0.5f);
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 75;
		}
		else
		{
			int num2 = (int)(75.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 100.0) * 100.0 - 1.0);
			if (num2 > 75)
			{
				num2 = 75;
			}
			if (num2 <= 2)
			{
				num2 = 2;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[7].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 2;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 2;
					this.MPMOKOOHPLI[7].DIIHJCJOKMP = 0f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Lv" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "[FF8787]Lv" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Egg";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1f;
		}
		else
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 0f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "[Shiny]" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 201 && FFJJCIQPLOP.QKNEIJQHGCB % 28 > 0)
		{
			str = "_" + (FFJJCIQPLOP.QKNEIJQHGCB % 28).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x001D6054 File Offset: 0x001D4254
	public void LGDBKJFOFOK(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1127f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.JNDDMKHOEJI();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1128f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 855f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1381f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 461f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1940f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 256f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1432f;
		bool flag = false;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.QBHICQMJCJF(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 4f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1913f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[8].LGJOOQIBQDC("Female Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1590f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].JLENFJGDNFN("stench");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 859f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("\" because it doesn't specify an item slot");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 540f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[6].IQBBDKFDGGP("CombinersArgsColorOp0");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 798f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[3].KCLBMPFIPNQ = "UnityEngine.";
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1713f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[3].LGJOOQIBQDC("Equip");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 987f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1991f;
		IL_33A:
		int num = (int)(596.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 418.0) * 1988.0 - 411.0);
		if (num > -48)
		{
			num = -28;
		}
		if (num <= 4)
		{
			num = 5;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 29;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1790f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1073f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 18;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(484f, 1994f, 444f, 1936f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1511f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -101;
		}
		else
		{
			int num2 = (int)(662.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 471.0) * 1824.0 - 294.0);
			if (num2 > 29)
			{
				num2 = 45;
			}
			if (num2 <= 8)
			{
				num2 = 6;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[3].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 809f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 5;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 6;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 683f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 289f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("bag" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("(W)" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("#,##0");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1070f;
		}
		else
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1224f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("NGUI State: " + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -19 && FFJJCIQPLOP.CCMOCLMEKJN() % 89 > 1)
		{
			str = "Timer Ball" + (FFJJCIQPLOP.QKNEIJQHGCB % -113).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" go!\r\n" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 934f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x001D6774 File Offset: 0x001D4974
	public void KIBBEKODBBQ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 56f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 871f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 794f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1420f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 32f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 275f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 235f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1504f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ONOOEKOJDLI(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 72f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 388f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[2].DPBGHDMHKNC("gem");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1618f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[7].JOHBNEHCEJH("ScriptPokemon");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 74f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[8].OGQLCMOFLLQ("[00EE07]");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1246f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[4].OGQLCMOFLLQ("#,##0");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 845f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = " already has a substitute!\r\n";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1236f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[2].DPBGHDMHKNC("fling");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 535f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 464f;
		IL_33A:
		int num = (int)(1622.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1073.0) * 1632.0 - 32.0);
		if (num > -33)
		{
			num = 10;
		}
		if (num <= 8)
		{
			num = 7;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -93;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1802f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 278f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 55;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(1707f, 497f, 968f, 982f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 167f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -95;
		}
		else
		{
			int num2 = (int)(833.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 399.0) * 816.0 - 1570.0);
			if (num2 > 115)
			{
				num2 = -95;
			}
			if (num2 <= 5)
			{
				num2 = 2;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1212f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 8;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[2].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 953f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 37f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "-fail" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "_Texture0" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("aa");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 919f;
		}
		else
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1392f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Flame Body" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -19 && FFJJCIQPLOP.QKNEIJQHGCB % -27 > 0)
		{
			str = "\r\n" + (FFJJCIQPLOP.QKNEIJQHGCB % -96).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("Its majesty pressures the opposing Pokémon, making it unable to attack using priority moves." + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 704f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D21 RID: 15649 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator DFGNOLELPOL(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D22 RID: 15650 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator CQMPCBGHNDQ(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D23 RID: 15651 RVA: 0x001D6E94 File Offset: 0x001D5094
	public void MDFGEPJEJCQ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1547f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1849f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 291f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1571f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1028f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1481f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 411f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 852f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.GBEMLGFEMCF(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.FCQMGQOEDLJ();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 465f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 436f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[4].DPBGHDMHKNC("leafguard");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1964f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].JOHBNEHCEJH(" hold [2ecc71]");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1447f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].LGJOOQIBQDC("Map");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1641f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("[-] weakened the damage to ");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 84f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[5].DPBGHDMHKNC("4");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1757f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[2].JLENFJGDNFN("Fishing Cooldown");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1222f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1291f;
		IL_33A:
		int num = (int)(168.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1557.0) * 1848.0 - 533.0);
		if (num > 44)
		{
			num = 7;
		}
		if (num <= 0)
		{
			num = 4;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -20;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1606f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 501f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 50;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1301f, 1852f, 1630f, 142f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 95f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -99;
		}
		else
		{
			int num2 = (int)(785.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1539.0) * 376.0 - 1895.0);
			if (num2 > 52)
			{
				num2 = 57;
			}
			if (num2 <= 0)
			{
				num2 = 3;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 235f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 7;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[5].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1864f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1813f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Ditto" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("pressure" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "electricterrain";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 811f;
		}
		else
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 245f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " " + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 92 && FFJJCIQPLOP.CCMOCLMEKJN() % 17 > 0)
		{
			str = "Failed to use '" + (FFJJCIQPLOP.CCMOCLMEKJN() % -93).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP(" became fully charged due to its [ffff00]Power Herb[-]!\r\n" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 949f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator OMNIKFGHFPM(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D25 RID: 15653 RVA: 0x001D75B4 File Offset: 0x001D57B4
	public void FIJEJMDOLJN(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 524f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1105f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 782f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1775f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 774f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 241f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1468f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 969f;
		bool flag = false;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ENQGDFEHQEE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 623f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1547f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[7].OGQLCMOFLLQ("BattlePoke");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 704f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[6].JOHBNEHCEJH("Right");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1218f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[4].LGJOOQIBQDC("Wonder Guard");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1232f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("(T)");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 167f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[3].OGQLCMOFLLQ("Email Address already in use");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 250f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[6].LGJOOQIBQDC(" is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 236f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[3].DIIHJCJOKMP = 974f;
		IL_33A:
		int num = (int)(722.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1637.0) * 1474.0 - 1249.0);
		if (num > 55)
		{
			num = -57;
		}
		if (num <= 6)
		{
			num = 4;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 69;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1070f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1453f;
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -119;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(249f, 872f, 732f, 1590f);
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1800f;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 4;
		}
		else
		{
			int num2 = (int)(1874.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1452.0) * 12.0 - 663.0);
			if (num2 > 117)
			{
				num2 = 45;
			}
			if (num2 <= 8)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[2].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[0].DIIHJCJOKMP = 692f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 8;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[3].KJGMGPCEJJD = 8;
					this.MPMOKOOHPLI[2].DIIHJCJOKMP = 824f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1880f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("HideResponse" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Suction Cups" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "Hard armor protects the Pokémon from critical hits.";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 858f;
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 29f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Fresnel" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 167 && FFJJCIQPLOP.CCMOCLMEKJN() % 13 > 0)
		{
			str = "[-] threw a " + (FFJJCIQPLOP.QKNEIJQHGCB % -41).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("_FogPointLightColor5" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 881f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D26 RID: 15654 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator LEOMJDLLCJJ(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x001D7CD4 File Offset: 0x001D5ED4
	public void PCFNFCMCMII(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 301f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 903f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 307f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1995f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1756f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1108f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 778f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 924f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.FCQMGQOEDLJ() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.EIJIGQKEPLE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 120f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1154f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[2].LGJOOQIBQDC("Protects the Pokémon from things like sand, hail, and powder.");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 286f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("[pok=");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 487f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[6].IQBBDKFDGGP(" on ");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1927f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[8].KCLBMPFIPNQ = "PokeboxCollider";
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1702f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[2].IQBBDKFDGGP("][");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 924f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[8].IQBBDKFDGGP("-clearpositiveboost");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 880f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 751f;
		IL_33A:
		int num = (int)(1399.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1153.0) * 879.0 - 1466.0);
		if (num > -97)
		{
			num = -79;
		}
		if (num <= 1)
		{
			num = 5;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -90;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1709f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 726f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 51;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(427f, 357f, 44f, 1164f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 19f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -81;
		}
		else
		{
			int num2 = (int)(358.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1231.0) * 1025.0 - 417.0);
			if (num2 > 66)
			{
				num2 = -45;
			}
			if (num2 <= 7)
			{
				num2 = 5;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[7].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[1].DIIHJCJOKMP = 823f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 0;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[2].KJGMGPCEJJD = 5;
					this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1384f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1796f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.BJLGEDCPENQ().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("[-] move using [ffff00]Leppa Berry[-]!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC(" woke it up!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("-");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1600f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 477f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "shielddust" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 26 && FFJJCIQPLOP.CCMOCLMEKJN() % 87 > 1)
		{
			str = "_DepthOfFieldCoCTex" + (FFJJCIQPLOP.QKNEIJQHGCB % -125).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("physical" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1881f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator ONOOEKOJDLI(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator CQMEDPBOHEI(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator LGBGLBJKPMF(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator QDMKFMJBGNN(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator LKFLMEBMEIK(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator GHOQKJKHPLE(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x001D83F4 File Offset: 0x001D65F4
	public void IQMKEHHHQKG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1363f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 772f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 460f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 809f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 559f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1023f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 495f;
			this.LGJMJDIQCFC.PIDLOFMIEFQ = string.Empty;
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 810f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.NLHMHCJPHOG(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1456f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1439f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("_TraceBehindObjects");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1561f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("Right");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1210f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[5].KCLBMPFIPNQ = "u";
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1724f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].IQBBDKFDGGP("Eggs will now hatch quicker then normal.\nTriggers: [2ecc71]Flame Body[-], [2ecc71]Magma Armor[-]");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 260f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[2].JLENFJGDNFN("Base Power: ");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 248f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[3].JLENFJGDNFN("HideEmote");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 968f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1332f;
		IL_33A:
		int num = (int)(1500.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1145.0) * 1442.0 - 47.0);
		if (num > -89)
		{
			num = -113;
		}
		if (num <= 6)
		{
			num = 8;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -52;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1247f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1772f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -31;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(new Color(1576f, 1465f, 1842f, 1931f));
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 823f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -124;
		}
		else
		{
			int num2 = (int)(1253.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1671.0) * 1432.0 - 1167.0);
			if (num2 > 48)
			{
				num2 = -33;
			}
			if (num2 <= 6)
			{
				num2 = 1;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[5].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[6].DIIHJCJOKMP = 817f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 2;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 2;
					this.MPMOKOOHPLI[0].DIIHJCJOKMP = 480f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 42f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "Fly" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("-unboost" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("The Pokémon changes the weather to nullify Water-type attacks.");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 949f;
		}
		else
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 200f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "[FFFFFF][" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -136 && FFJJCIQPLOP.CCMOCLMEKJN() % -98 > 0)
		{
			str = "p2" + (FFJJCIQPLOP.QKNEIJQHGCB % -18).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Kick" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1432f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x001D8B14 File Offset: 0x001D6D14
	public void FCLODIHFFQL(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1413f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 426f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 692f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 292f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1879f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 380f;
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 784f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1336f;
		bool flag = true;
		this.LPFGBJEFGPO = 1;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.MNOJFKIGEMJ(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KPJLEOCJFFO();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 16f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1210f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[4].JLENFJGDNFN("Map");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1137f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].JLENFJGDNFN("For five turns, the Pokémon's Attack and Speed stats are halved.");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1999f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("CombinersColor");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 641f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[8].JOHBNEHCEJH("R");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1765f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].JOHBNEHCEJH("Rooms");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 613f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("[00EE07]");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1543f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 161f;
		IL_33A:
		int num = (int)(1024.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1193.0) * 1946.0 - 616.0);
		if (num > -77)
		{
			num = -21;
		}
		if (num <= 7)
		{
			num = 0;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 47;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1155f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1755f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -50;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1431f, 896f, 1792f, 1509f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 104f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -64;
		}
		else
		{
			int num2 = (int)(269.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1214.0) * 1910.0 - 1468.0);
			if (num2 > -85)
			{
				num2 = -52;
			}
			if (num2 <= 5)
			{
				num2 = 8;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[4].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1818f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 4;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 8;
					this.MPMOKOOHPLI[2].DIIHJCJOKMP = 780f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1068f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "[00EE07]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("UpdateTime" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("http://poke.one/terms.html");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1201f;
		}
		else
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 131f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("powerconstruct" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 17 && FFJJCIQPLOP.QKNEIJQHGCB % -59 > 1)
		{
			str = "_LoopCount" + (FFJJCIQPLOP.QKNEIJQHGCB % -55).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("-center" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1899f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x001D9234 File Offset: 0x001D7434
	public void EJJBDNMPFIM(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1514f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 218f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 852f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1792f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 777f;
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1935f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1197f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 793f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = false;
			this.GMNPOMNJGKH = base.StartCoroutine(this.OMNIKFGHFPM(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.LDQDJLFIDCN)
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1604f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.HBBQJQEQGMP())
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1573f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[5].JLENFJGDNFN("Level Ups:");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 772f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[8].IQBBDKFDGGP("[00]");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 37f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[3].JLENFJGDNFN("innardsout");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1686f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].LGJOOQIBQDC("[SHINY]");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 544f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("[-]!\r\n");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 281f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[5].DPBGHDMHKNC("The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 722f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1463f;
		IL_33A:
		int num = (int)(266.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1655.0) * 1268.0 - 1829.0);
		if (num > 71)
		{
			num = -80;
		}
		if (num <= 7)
		{
			num = 8;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 6;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1020f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1093f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 49;
			this.MPMOKOOHPLI[0].CEGFBBHMKOE = new Color(1576f, 1251f, 71f, 1135f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 995f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = 63;
		}
		else
		{
			int num2 = (int)(1552.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 71.0) * 1586.0 - 1123.0);
			if (num2 > 87)
			{
				num2 = 3;
			}
			if (num2 <= 6)
			{
				num2 = 0;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[6].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1276f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 0;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[4].KJGMGPCEJJD = 0;
					this.MPMOKOOHPLI[6].DIIHJCJOKMP = 459f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1736f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "grassyterrain" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("[ATK]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "HM";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 538f;
		}
		else
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1159f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("all" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == -68 && FFJJCIQPLOP.QKNEIJQHGCB % 121 > 1)
		{
			str = "CacheDefaultColor" + (FFJJCIQPLOP.QKNEIJQHGCB % -23).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("powerofalchemy" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1927f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x001D9954 File Offset: 0x001D7B54
	public void MFBIIOKFFQG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 975f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 793f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1689f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1090f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 363f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1696f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1381f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1891f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.LDQDJLFIDCN && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.LKFLMEBMEIK(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.FCQMGQOEDLJ())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 327f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 402f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[8].KCLBMPFIPNQ = "message";
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 962f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[4].IQBBDKFDGGP("weakarmor");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 931f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[1].JLENFJGDNFN("_MountTopTex");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1033f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "replace";
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1340f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("]");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1045f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[4].IQBBDKFDGGP("item: ");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1281f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 517f;
		IL_33A:
		int num = (int)(990.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1894.0) * 1970.0 - 688.0);
		if (num > -61)
		{
			num = -15;
		}
		if (num <= 5)
		{
			num = 2;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -20;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 128f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 23f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -83;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(1087f, 391f, 609f, 1443f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 2f;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = Color.white;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -2;
		}
		else
		{
			int num2 = (int)(365.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1314.0) * 1342.0 - 306.0);
			if (num2 > 85)
			{
				num2 = 8;
			}
			if (num2 <= 2)
			{
				num2 = 6;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[6].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1369f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 7;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 6;
					this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1897f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 288f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "East" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("3");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1592f;
		}
		else
		{
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1852f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("/" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 178 && FFJJCIQPLOP.QKNEIJQHGCB % -40 > 0)
		{
			str = "minus" + (FFJJCIQPLOP.QKNEIJQHGCB % -61).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("14.5 17\n14 17\n14 20\n7 20\n\n7 26\n7 30\n2 30\n2 26" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 543f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D32 RID: 15666 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator GBEMLGFEMCF(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x001DA074 File Offset: 0x001D8274
	public void BPJHFHOPKEL(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1166f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 426f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 355f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 271f;
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1724f;
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1974f;
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 418f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1250f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KPJLEOCJFFO() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.ENQGDFEHQEE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.GBNQEKLJFCI())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.GBNQEKLJFCI();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 326f;
		if (component != null)
		{
			component.GGBPLMICFHN = false;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1634f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[3].JLENFJGDNFN("aa");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 743f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("-sp");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1374f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[4].KCLBMPFIPNQ = "Boxes Owned: ";
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1480f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[4].JOHBNEHCEJH("[/urn]");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1154f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].DPBGHDMHKNC("][/pok] ");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 792f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("FOG_OFF");
			this.MPMOKOOHPLI[7].DIIHJCJOKMP = 934f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 953f;
		IL_33A:
		int num = (int)(184.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1441.0) * 39.0 - 1880.0);
		if (num > 67)
		{
			num = 92;
		}
		if (num <= 2)
		{
			num = 6;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 78;
		}
		this.MPMOKOOHPLI[1].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1528f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1633f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -23;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(565f, 1185f, 315f, 1339f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 206f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = -49;
		}
		else
		{
			int num2 = (int)(183.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1268.0) * 1805.0 - 1970.0);
			if (num2 > -126)
			{
				num2 = -126;
			}
			if (num2 <= 0)
			{
				num2 = 8;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[8].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1114f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 1;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[1].KJGMGPCEJJD = 1;
					this.MPMOKOOHPLI[5].DIIHJCJOKMP = 329f;
				}
			}
		}
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1369f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "-heal" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "JOFLHFQQCKG" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC("_");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 1)
		{
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 446f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 312f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "swiftswim" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 46 && FFJJCIQPLOP.QKNEIJQHGCB % -64 > 0)
		{
			str = "_1" + (FFJJCIQPLOP.CCMOCLMEKJN() % 68).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD(" declined the Friend Request." + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1645f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x001CBC50 File Offset: 0x001C9E50
	private IEnumerator ODGEEPLQCPQ(int DPDCGFEEFPB)
	{
		yield return null;
		return 1;
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			goto IL_10B;
		}
		component = base.transform.parent.gameObject.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.FDOEENLQFMQ).GetComponent<BKKHLBCLPJM>();
		component.transform.localPosition = new Vector3(-131f, 25f, 0f);
		component.PIDLOFMIEFQ = "+" + DPDCGFEEFPB.ToString() + " EXP";
		UnityEngine.Object.Destroy(component.gameObject, 3f);
		yield return new WaitForSeconds(1f);
		return 1;
		IL_10B:
		yield return null;
		return 1;
		if (this.LPFGBJEFGPO < 2)
		{
			goto IL_163;
		}
		this.JOHLPPHIPNB = JLCINGQBJPJ.FJCEGFKJLCL(this.MPMOKOOHPLI[1], 1.5f, this.LPFGBJEFGPO, 0f);
		IL_163:
		yield break;
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x001DA794 File Offset: 0x001D8994
	public void QKJMCFHGKQC(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 444f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KGMFIOCJLEP() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1723f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 316f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1130f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1969f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 7f;
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 177f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1187f;
		bool flag = false;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.QBHICQMJCJF(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.KGMFIOCJLEP();
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1094f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1621f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[6].IQBBDKFDGGP("The trade with '");
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 264f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[5].OGQLCMOFLLQ("ability");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1963f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[7].LGJOOQIBQDC("rattled");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 968f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("megay");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1615f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[8].IQBBDKFDGGP("X8");
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1987f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[5].JOHBNEHCEJH("Take 001");
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 888f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[8].DIIHJCJOKMP = 119f;
		IL_33A:
		int num = (int)(1053.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 111.0) * 988.0 - 175.0);
		if (num > 84)
		{
			num = -95;
		}
		if (num <= 5)
		{
			num = 3;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = -104;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[1].DIIHJCJOKMP = 866f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 682f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -78;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(new Color(1357f, 1870f, 298f, 434f));
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1732f;
			this.MPMOKOOHPLI[1].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -55;
		}
		else
		{
			int num2 = (int)(349.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 1771.0) * 377.0 - 902.0);
			if (num2 > 3)
			{
				num2 = 56;
			}
			if (num2 <= 1)
			{
				num2 = 4;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[8].DIIHJCJOKMP = 626f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 5;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[0].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[7].KJGMGPCEJJD = 4;
					this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1547f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 735f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.QOQONHOOLNE != null && (ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "'s stat changes were inverted!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
			else
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("-mega-x" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
		}
		else
		{
			this.LGJMJDIQCFC.LKPOBCBOFIC(" became shrouded in mist!\r\n");
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 1429f;
		}
		else
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1523f;
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Mouse ScrollWheel" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		}
		this.JPGLKGNOICN.SetActive(false);
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -125 && FFJJCIQPLOP.QKNEIJQHGCB % 112 > 1)
		{
			str = "_1" + (FFJJCIQPLOP.CCMOCLMEKJN() % 116).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("insomnia" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1290f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x06003D36 RID: 15670 RVA: 0x001DAEB4 File Offset: 0x001D90B4
	public void QKCOIIKFPKG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		this.DGKDPPQICKH = FFJJCIQPLOP;
		CFDMNELIJLO component = base.transform.parent.GetComponent<CFDMNELIJLO>();
		if (this.JLCQGFOQNON)
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 438f;
		}
		if (FFJJCIQPLOP != null && this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO() && this.GMNPOMNJGKH != null)
		{
			base.StopCoroutine(this.GMNPOMNJGKH);
			this.GMNPOMNJGKH = null;
		}
		if (FFJJCIQPLOP == null)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			if (component != null)
			{
				component.FKGJKJFFBFQ();
			}
			this.LQKBJPMICOD.DIIHJCJOKMP = 1508f;
			this.HHKNGKFJGHB.DIIHJCJOKMP = 1558f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 97f;
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1982f;
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 1286f;
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1982f;
			this.LGJMJDIQCFC.LKPOBCBOFIC(string.Empty);
			return;
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1631f;
		bool flag = true;
		this.LPFGBJEFGPO = 0;
		if (this.POGBBIPKGJF == FFJJCIQPLOP.KGMFIOCJLEP() && this.COOPDFEHHNL != 0 && this.COOPDFEHHNL != FFJJCIQPLOP.CKPQFBKFLND && this.JLCQGFOQNON)
		{
			if (this.GMNPOMNJGKH != null)
			{
				base.StopCoroutine(this.GMNPOMNJGKH);
				this.GMNPOMNJGKH = null;
			}
			int dpdcgfeefpb = FFJJCIQPLOP.CKPQFBKFLND - this.COOPDFEHHNL;
			flag = true;
			this.GMNPOMNJGKH = base.StartCoroutine(this.GHOQKJKHPLE(dpdcgfeefpb));
		}
		if (this.POGBBIPKGJF != FFJJCIQPLOP.KPJLEOCJFFO())
		{
			this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		}
		this.POGBBIPKGJF = FFJJCIQPLOP.LDQDJLFIDCN;
		this.COOPDFEHHNL = FFJJCIQPLOP.CKPQFBKFLND;
		this.LQKBJPMICOD.DIIHJCJOKMP = 1129f;
		if (component != null)
		{
			component.GGBPLMICFHN = true;
			component.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		}
		switch (FFJJCIQPLOP.PLCBFLQBCQN)
		{
		case KGQECFKLKOP.PFPBKQFQFFG.None:
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 333f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Burn:
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("ChatSettings");
			this.MPMOKOOHPLI[2].DIIHJCJOKMP = 110f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Freeze:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("psn");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1835f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Paralysis:
			this.MPMOKOOHPLI[5].IQBBDKFDGGP("The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.");
			this.MPMOKOOHPLI[8].DIIHJCJOKMP = 1976f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Poison:
			this.MPMOKOOHPLI[7].JLENFJGDNFN(" is locked in a nightmare!\r\n");
			this.MPMOKOOHPLI[5].DIIHJCJOKMP = 1178f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.Sleep:
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("galvanize");
			this.MPMOKOOHPLI[4].DIIHJCJOKMP = 316f;
			goto IL_33A;
		case KGQECFKLKOP.PFPBKQFQFFG.BadlyPoisoned:
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("[00EE07]");
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 1368f;
			goto IL_33A;
		}
		this.MPMOKOOHPLI[2].DIIHJCJOKMP = 1847f;
		IL_33A:
		int num = (int)(478.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1462.0) * 1898.0 - 1634.0);
		if (num > 0)
		{
			num = -7;
		}
		if (num <= 6)
		{
			num = 0;
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			num = 20;
		}
		this.MPMOKOOHPLI[0].KJGMGPCEJJD = num;
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1986f;
		if (FFJJCIQPLOP.DCFKMOILHEC == 0 && FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1557f;
			this.MPMOKOOHPLI[0].KJGMGPCEJJD = -115;
			this.MPMOKOOHPLI[1].CEGFBBHMKOE = new Color(634f, 409f, 263f, 1088f);
		}
		else
		{
			this.MPMOKOOHPLI[1].DIIHJCJOKMP = 460f;
			this.MPMOKOOHPLI[0].NONQDHBCIIN(Color.white);
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.MPMOKOOHPLI[1].KJGMGPCEJJD = 52;
		}
		else
		{
			int num2 = (int)(977.0 / ((double)(FFJJCIQPLOP.EGDMHCLOGCC - FFJJCIQPLOP.BNGBQLEQCPL) / (double)(FFJJCIQPLOP.CKPQFBKFLND - FFJJCIQPLOP.BNGBQLEQCPL) * 943.0) * 184.0 - 1849.0);
			if (num2 > -58)
			{
				num2 = -49;
			}
			if (num2 <= 6)
			{
				num2 = 8;
			}
			if (flag && this.JLCQGFOQNON)
			{
				this.MPMOKOOHPLI[8].KJGMGPCEJJD = num2;
				this.MPMOKOOHPLI[7].DIIHJCJOKMP = 1280f;
				if (this.NIKKBDNNBIB != FFJJCIQPLOP.EOMPMQNGIBD)
				{
					this.MPMOKOOHPLI[0].KJGMGPCEJJD = 1;
				}
				this.LPFGBJEFGPO = num2;
			}
			else
			{
				if (this.JOHLPPHIPNB != null)
				{
					UnityEngine.Object.DestroyImmediate(this.JOHLPPHIPNB);
				}
				this.MPMOKOOHPLI[1].KJGMGPCEJJD = num2;
				if (this.JLCQGFOQNON)
				{
					this.MPMOKOOHPLI[8].KJGMGPCEJJD = 8;
					this.MPMOKOOHPLI[1].DIIHJCJOKMP = 319f;
				}
			}
		}
		this.MPMOKOOHPLI[0].DIIHJCJOKMP = 1182f;
		this.NIKKBDNNBIB = FFJJCIQPLOP.EOMPMQNGIBD;
		if (FFJJCIQPLOP.CQQPFJQINIM == EggState.None)
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO() != null && (ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)FFJJCIQPLOP.EOMPMQNGIBD))
			{
				this.LGJMJDIQCFC.LKPOBCBOFIC("Old Password is to Short" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
			}
			else
			{
				this.LGJMJDIQCFC.PIDLOFMIEFQ = "'s [ffff00]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
			}
		}
		else
		{
			this.LGJMJDIQCFC.PIDLOFMIEFQ = "1";
		}
		if (FFJJCIQPLOP.GECLELHHNIO > 0)
		{
			this.MPMOKOOHPLI[3].DIIHJCJOKMP = 1747f;
		}
		else
		{
			this.MPMOKOOHPLI[6].DIIHJCJOKMP = 340f;
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "steel" + KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		}
		else
		{
			this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		}
		this.JPGLKGNOICN.SetActive(true);
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 0 && FFJJCIQPLOP.CCMOCLMEKJN() % 10 > 1)
		{
			str = "Sniper" + (FFJJCIQPLOP.QKNEIJQHGCB % 124).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" cured its poison!\r\n" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HHKNGKFJGHB.DIIHJCJOKMP = 1311f;
		this.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
	}

	// Token: 0x04000D9D RID: 3485
	public PLQFPBQEPJD LQKBJPMICOD;

	// Token: 0x04000D9E RID: 3486
	public PLQFPBQEPJD[] MPMOKOOHPLI;

	// Token: 0x04000D9F RID: 3487
	public JLMPBLMOICG HHKNGKFJGHB;

	// Token: 0x04000DA0 RID: 3488
	public BKKHLBCLPJM LGJMJDIQCFC;

	// Token: 0x04000DA1 RID: 3489
	public KGQECFKLKOP.FEKOIOJQNKH DGKDPPQICKH;

	// Token: 0x04000DA2 RID: 3490
	public CFDMNELIJLO BLLHQPQBHBB;

	// Token: 0x04000DA3 RID: 3491
	public BKKHLBCLPJM JCKICOFIHIB;

	// Token: 0x04000DA4 RID: 3492
	public GameObject JPGLKGNOICN;

	// Token: 0x04000DA5 RID: 3493
	private Guid POGBBIPKGJF;

	// Token: 0x04000DA6 RID: 3494
	private int COOPDFEHHNL;

	// Token: 0x04000DA7 RID: 3495
	private int NIKKBDNNBIB;

	// Token: 0x04000DA8 RID: 3496
	public int PELCNBCMNFH;

	// Token: 0x04000DA9 RID: 3497
	private Coroutine GMNPOMNJGKH;

	// Token: 0x04000DAA RID: 3498
	private int LPFGBJEFGPO;

	// Token: 0x04000DAB RID: 3499
	private JLCINGQBJPJ JOHLPPHIPNB;

	// Token: 0x04000DAC RID: 3500
	public bool JLCQGFOQNON;
}
