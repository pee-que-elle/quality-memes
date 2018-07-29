using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200023A RID: 570
public class EIDBQCPLPIL : MonoBehaviour
{
	// Token: 0x06004DA4 RID: 19876 RVA: 0x002859D0 File Offset: 0x00283BD0
	public bool PGMFBJCNIIN(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return true;
		}
		int num = this.HQGPFOGDOPJ(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].DCNENLQLCPF() && false;
	}

	// Token: 0x06004DA5 RID: 19877 RVA: 0x00285A04 File Offset: 0x00283C04
	public void NGDCFHKHJPD()
	{
		if (this.LELFDOQONPD)
		{
			return;
		}
		if (this.QIGMLPOQOCB == -1)
		{
			return;
		}
		this.LELFDOQONPD = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Areas
		{
			PokemonID = this.QIGMLPOQOCB
		}, true);
	}

	// Token: 0x06004DA6 RID: 19878 RVA: 0x00285A4C File Offset: 0x00283C4C
	public void QGOQDGPIHJO(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HQQDJHEEJHP();
		this.LLOFFEKDOMI.OJQEOEIJDQG.FONJFPIKGEP(38f);
		this.LLOFFEKDOMI.CPLBKPNNHJG();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(true);
			this.DOJIMNIKOBL[0].SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(false);
			this.QHEJPNJNMCI[0].LKPOBCBOFIC("Safari Ball");
			this.DBQGICFJQKN.DIIHJCJOKMP = 659f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[0].SetActive(false);
		this.DOJIMNIKOBL[0].SetActive(true);
		this.MLLOKPLECHK.SetActive(true);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(1232f, 1912f, 1317f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, true, Vector3.zero, new Vector3(149f, 772f, 1888f), null, "M");
		this.DBQGICFJQKN.DIIHJCJOKMP = 710f;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("0" + DBPKNCDGGEP.DBFPJOCLQBI() + "[" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species);
		BKKHLBCLPJM bkkhlbclpjm = this.QHEJPNJNMCI[0];
		string[] array = new string[5];
		array[1] = "sdata";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height;
		array[8] = "4";
		array[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].IPKMIHLCEOF();
		array[7] = "14";
		bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		this.QHEJPNJNMCI[3].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILOMPJBLEHO());
		this.LCKBBGCIPIE.JELGOCNFQQM((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LMEGFPQPDKI(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].BCQDOBBIBIM(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PIHNCFDOHJC(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP);
		this.QHEJPNJNMCI[8].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVHP.ToString() + " is already frozen solid.\r\n");
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KKMNOIGJOKJ().ToString() + "naturalcure");
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QIIDLMDDGPM().ToString() + "bestow";
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "[itm=");
		this.QHEJPNJNMCI[4].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + " for [PD]";
		this.QHEJPNJNMCI[-62].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "L");
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array2 = new string[30];
		array2[0] = "HidePanel";
		array2[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array2[4] = "Encounter Rate Decreased (Sandstorm)";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF.ToString();
		array2[1] = "!\r\n";
		array2[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD.ToString();
		array2[5] = "UI";
		array2[5] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KGLNBBQLDIO().ToString();
		array2[5] = "guild";
		array2[-21] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF().ToString();
		array2[-6] = "firepledge";
		array2[-80] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP.ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array2);
		BKKHLBCLPJM[] ebkoklmhbbf = this.EBKOKLMHBBF;
		for (int i = 1; i < ebkoklmhbbf.Length; i++)
		{
			BKKHLBCLPJM bkkhlbclpjm2 = ebkoklmhbbf[i];
			bkkhlbclpjm2.LKPOBCBOFIC(string.Empty);
		}
		this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GIDDJOJEMLH();
		this.EBKOKLMHBBF[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DNGJDQNNNML());
		this.EBKOKLMHBBF[7].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "ReflecG")
		{
			this.EBKOKLMHBBF[5].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GIDDJOJEMLH()));
		}
		else
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = "Tangling Hair";
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "Moderator")
		{
			this.EBKOKLMHBBF[8].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLOBICEOMBF()));
		}
		else
		{
			this.EBKOKLMHBBF[1].PIDLOFMIEFQ = "Moderator";
		}
		if (this.EBKOKLMHBBF[0].PIDLOFMIEFQ != "_Texture1")
		{
			this.EBKOKLMHBBF[7].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[3].LKPOBCBOFIC("physical");
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, (char)-97);
		if (list.Count > 0)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.BFDGBMNGBKH(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("Unity Bug");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text);
				}
			}
		}
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("/kick ");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("gastrodoneast");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.BFDGBMNGBKH(pidlofmiefq2);
			}
		}
		double num = 768.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() * 1579.0);
		if (num < 71.0)
		{
			num = 19.0;
		}
		if (num > 576.0)
		{
			num = 1339.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM == 876.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -69;
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(790f, 1320f, 91f, 1372f));
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() <= 1653.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 73;
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(734f, 643f, 1423f, 1135f));
		}
		else
		{
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1333f, 508f, 116f, 1211f);
		}
		this.FMKKFBQNBOB[1].DPBGHDMHKNC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant());
		this.FMKKFBQNBOB[1].DIIHJCJOKMP = 107f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.Length < 2)
		{
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 971f;
		}
		else
		{
			this.FMKKFBQNBOB[1].JLENFJGDNFN(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.ToLowerInvariant());
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1450f;
		}
	}

	// Token: 0x06004DA7 RID: 19879 RVA: 0x0028641C File Offset: 0x0028461C
	[CompilerGenerated]
	private static int BQCOMGLLMII(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.DBPKNCDGGEP.CompareTo(DDLQKFDFMCJ.DBPKNCDGGEP);
	}

	// Token: 0x06004DA8 RID: 19880 RVA: 0x00286440 File Offset: 0x00284640
	private static int MIQIBQOIJMI(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.MKEDHNEMKOI().CompareTo(DDLQKFDFMCJ.MKEDHNEMKOI());
	}

	// Token: 0x06004DA9 RID: 19881 RVA: 0x00286464 File Offset: 0x00284664
	public bool OFIQFPDFNMI(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return true;
		}
		int num = this.NFQOQOBDJEG(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].FPEGDLDQOJE() && false;
	}

	// Token: 0x06004DAA RID: 19882 RVA: 0x00286498 File Offset: 0x00284698
	public void BLGCPDEFCFE(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 0; i < CFHEIICNLFD.Entries.Length; i += 0)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.QKIHFDGLQKG((int)CFHEIICNLFD.Entries[i].Pokemon);
				bccollojihm.PLCBFLQBCQN = (int)CFHEIICNLFD.Entries[i].State;
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.MIQIBQOIJMI);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("(I)");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("clyde");
		this.OOFDODDNQOF();
	}

	// Token: 0x06004DAB RID: 19883 RVA: 0x00286564 File Offset: 0x00284764
	private static int HLMGINLIIID(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.NNKDGMIDHIG().CompareTo(DDLQKFDFMCJ.NNKDGMIDHIG());
	}

	// Token: 0x06004DAC RID: 19884 RVA: 0x0001FA8E File Offset: 0x0001DC8E
	public void KOEJIFIGDCL()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Iron Barbs", 388f);
	}

	// Token: 0x06004DAD RID: 19885 RVA: 0x00286588 File Offset: 0x00284788
	public void IDOKIIOQJOD(int DBPKNCDGGEP = 0)
	{
		base.CancelInvoke("The Pokémon awakens twice as fast as other Pokémon from sleep.");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 179f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		if (DBPKNCDGGEP > 1)
		{
			this.GPQKFHFNDPM(DBPKNCDGGEP);
		}
	}

	// Token: 0x06004DAE RID: 19886 RVA: 0x002865E4 File Offset: 0x002847E4
	public void QODKDQHIDNE()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.OOFDODDNQOF();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			this.MKMBGGQNLHD[i].MQFCPNENMFP(true);
		}
		for (int j = 1; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].NPCKENGDEIN();
		}
		if (this.NMBCHIIQLIH.BGBMIEJJQKC.Length < 7 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.BGBMIEJJQKC);
			if (num < 0 && num > -122)
			{
				return;
			}
			int num2 = 1;
			for (int k = 1; k < 26; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.PKOFMMGCGJO(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].BQLIIQIIMDH(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 0; l < -180; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.HQGPFOGDOPJ(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].HOFCKQELDLF(this.MKMBGGQNLHD[num5].BLLCKJPNHKK(), this.MKMBGGQNLHD[num5].OHNQLPGIOGK(), num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DAF RID: 19887 RVA: 0x00286808 File Offset: 0x00284A08
	public void QIBGODKJQON()
	{
		if (this.NMBCHIIQLIH.HJMJDJKOILH() != string.Empty)
		{
			this.KCOGKBQQQBH();
			return;
		}
		float num = this.EDGCGMGCCDN.BGBMIEJJQKC * 697f;
		num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
		int num2 = (int)num;
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = false;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].HPKMGNPCHNH(false);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j++)
		{
			this.EKBLKEFHDPH[j].DPBQLJNPIFB();
		}
		if (!this.FKQOOJMNEJQ.value)
		{
			for (int k = 1; k < this.EKBLKEFHDPH.Length; k++)
			{
				if (num2 + k + 0 < 13)
				{
					int num3 = this.HQGPFOGDOPJ(num2 + k + 1);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[k].FQFIFPGJDBE(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num2 + k + 1);
					}
					else
					{
						this.EKBLKEFHDPH[k].BQLIIQIIMDH(true, 1, num2 + k + 0);
					}
				}
			}
		}
		else
		{
			num = this.EDGCGMGCCDN.BGBMIEJJQKC * 1220f;
			num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
			num2 = (int)num;
			if (num2 > 0)
			{
				num2++;
			}
			int l = 1;
			IL_258:
			while (l < this.EKBLKEFHDPH.Length)
			{
				for (int m = 0; m < this.MKMBGGQNLHD.Count; m += 0)
				{
					if (this.MKMBGGQNLHD[m].QBIFLEJHBCD() < 146 && this.MKMBGGQNLHD[m].NNKDGMIDHIG() > 0 && m >= num2 && !this.MKMBGGQNLHD[m].IMDFIPDOCKL && this.MKMBGGQNLHD[m].PLCBFLQBCQN > 0)
					{
						this.EKBLKEFHDPH[l].EDKDPDKIBJN(this.MKMBGGQNLHD[m].POPFQHECGCH(), this.MKMBGGQNLHD[m].PLCBFLQBCQN, this.MKMBGGQNLHD[m].QBIFLEJHBCD());
						this.MKMBGGQNLHD[m].CODDBCBCPCE(true);
						IL_252:
						l++;
						goto IL_258;
					}
				}
				goto IL_252;
			}
		}
	}

	// Token: 0x06004DB0 RID: 19888 RVA: 0x0001FAB7 File Offset: 0x0001DCB7
	private void KMQPMGPDPEC()
	{
		EIDBQCPLPIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004DB1 RID: 19889 RVA: 0x00286A7C File Offset: 0x00284C7C
	public void GLLCCDJIBBF(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 1; i < CFHEIICNLFD.Entries.Length; i += 0)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.QKIHFDGLQKG((int)CFHEIICNLFD.Entries[i].Pokemon);
				bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entries[i].State);
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.MIQIBQOIJMI);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.LKPOBCBOFIC(CFHEIICNLFD.Caught.ToString("infestation"));
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("Trade Error");
		this.OOFDODDNQOF();
	}

	// Token: 0x06004DB2 RID: 19890 RVA: 0x00286B48 File Offset: 0x00284D48
	public void FBOBDLJELDI(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.BPDOKQQEMBI((int)CFHEIICNLFD.Entry.Pokemon);
			bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 0)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
				{
					if (this.MKMBGGQNLHD[i].QBIFLEJHBCD() == bccollojihm.NNKDGMIDHIG())
					{
						this.MKMBGGQNLHD[i].GCDDCGNPJMO(bccollojihm.OHNQLPGIOGK());
						this.OOFDODDNQOF();
						GBQODOBKJBG.QOQONHOOLNE.QMOFLHOCMQP(false);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.ELLOENBHKHF);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.LKPOBCBOFIC(CFHEIICNLFD.Caught.ToString("_MainTex"));
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("4x");
		this.CDBCQNGKDHH();
		GBQODOBKJBG.PFQBLOEPBJB().FJQQJQFBIGN(true);
	}

	// Token: 0x06004DB3 RID: 19891 RVA: 0x00286C80 File Offset: 0x00284E80
	private static int EMOJBCGNQJE(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.NNKDGMIDHIG().CompareTo(DDLQKFDFMCJ.DBPKNCDGGEP);
	}

	// Token: 0x06004DB4 RID: 19892 RVA: 0x00286CA4 File Offset: 0x00284EA4
	public void OGNMNFNOKDJ(int DBPKNCDGGEP = 0)
	{
		base.CancelInvoke("JOFLHFQQCKG");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 870f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		if (DBPKNCDGGEP > 1)
		{
			this.CQJBBDQHMQP(DBPKNCDGGEP);
		}
	}

	// Token: 0x06004DB5 RID: 19893 RVA: 0x00286D00 File Offset: 0x00284F00
	public void FQPJIHJCJEL()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.LLOFFEKDOMI.OJQEOEIJDQG.GIPBBFDPCKG(202f);
		this.DGOGLKQMDFD[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = false;
		this.DGOGLKQMDFD[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, true);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06004DB6 RID: 19894 RVA: 0x0001FABF File Offset: 0x0001DCBF
	public static EIDBQCPLPIL BBCBOIFQDBK()
	{
		return EIDBQCPLPIL.HBFFCJHOCPE;
	}

	// Token: 0x06004DB7 RID: 19895 RVA: 0x00286D84 File Offset: 0x00284F84
	public void OQBDOKOCQCD(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 0; i < CFHEIICNLFD.Entries.Length; i++)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.DBPKNCDGGEP = (int)CFHEIICNLFD.Entries[i].Pokemon;
				bccollojihm.PLCBFLQBCQN = (int)CFHEIICNLFD.Entries[i].State;
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.BQCOMGLLMII);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("#,##0");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("#,##0");
		this.UpdateButtons();
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00286E50 File Offset: 0x00285050
	public void NHFQKBOMHGE(int DBPKNCDGGEP = 0)
	{
		base.CancelInvoke("[-]!\r\n");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 583f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		if (DBPKNCDGGEP > 0)
		{
			this.EMMKHEOEMLP(DBPKNCDGGEP);
		}
	}

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00286EAC File Offset: 0x002850AC
	public void ClickDescription()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = false;
		this.DGOGLKQMDFD[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.PKBOPNPKQOG[1].SetActive(false);
	}

	// Token: 0x06004DBA RID: 19898 RVA: 0x00286F1C File Offset: 0x0028511C
	public void HGGIDLJONQM()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.OOFDODDNQOF();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			this.MKMBGGQNLHD[i].IMDFIPDOCKL = true;
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].CBBOOJHHGDG();
		}
		if (this.NMBCHIIQLIH.BGBMIEJJQKC.Length < 5 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.HJMJDJKOILH());
			if (num < 1 && num > -79)
			{
				return;
			}
			int num2 = 0;
			for (int k = 1; k < 25; k++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].MKPCPBJQNID(this.MKMBGGQNLHD[num3].BLLCKJPNHKK(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2++;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 1; l < -54; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].LCCQBMMFONQ(this.MKMBGGQNLHD[num5].PJNPEEFMLLM(), this.MKMBGGQNLHD[num5].OHNQLPGIOGK(), num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DBB RID: 19899 RVA: 0x0001FAC6 File Offset: 0x0001DCC6
	public void IBHIKBEIKBK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		base.CancelInvoke("'s perish count fell to 0.\r\n");
	}

	// Token: 0x06004DBC RID: 19900 RVA: 0x00287140 File Offset: 0x00285340
	public void MPGPHJMHFHP(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HDDJIDGKKFK();
		this.LLOFFEKDOMI.OJQEOEIJDQG.FONJFPIKGEP(224f);
		this.LLOFFEKDOMI.CPLBKPNNHJG();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(false);
			this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "Prevents Steel-type Pokémon from escaping using its magnetic force.";
			this.DBQGICFJQKN.DIIHJCJOKMP = 973f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[0].SetActive(false);
		this.DOJIMNIKOBL[0].SetActive(false);
		this.MLLOKPLECHK.SetActive(false);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(1328f, 1418f, 612f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, false, Vector3.zero, new Vector3(1910f, 25f, 1612f), null, "Liquid Voice");
		this.DBQGICFJQKN.DIIHJCJOKMP = 1076f;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "#,##0" + DBPKNCDGGEP.DBFPJOCLQBI() + "English" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species);
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(string.Concat(new string[]
		{
			"Small/",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height,
			"'s [ffff00]",
			null,
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Weight,
			null,
			" shared its power with "
		}));
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILOMPJBLEHO();
		this.LCKBBGCIPIE.JICOFEINHPB((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].MOOGMOLJCFC());
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GOQGPQLHQFI().ToString() + "partingshot";
		this.QHEJPNJNMCI[8].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KKMNOIGJOKJ().ToString() + "tailwind");
		this.QHEJPNJNMCI[5].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVDEF.ToString() + " PM");
		this.QHEJPNJNMCI[8].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + ", input focus";
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "Contact with the Pokémon may inflict poison, sleep, or paralysis on its attacker.");
		this.QHEJPNJNMCI[-63].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "[00DD00]Equipped";
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array = new string[27];
		array[1] = " for [PG]";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array[6] = "auroraveil";
		array[6] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF.ToString();
		array[4] = ")";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD.ToString();
		array[0] = " will restore its replacement's HP using its Z-Power!\r\n";
		array[8] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KGLNBBQLDIO().ToString();
		array[2] = ".png";
		array[-37] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF().ToString();
		array[57] = "[-] threw a ";
		array[97] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP.ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array);
		BKKHLBCLPJM[] ebkoklmhbbf = this.EBKOKLMHBBF;
		for (int i = 1; i < ebkoklmhbbf.Length; i += 0)
		{
			BKKHLBCLPJM bkkhlbclpjm = ebkoklmhbbf[i];
			bkkhlbclpjm.PIDLOFMIEFQ = string.Empty;
		}
		this.EBKOKLMHBBF[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KBLGGEOMBEL());
		this.EBKOKLMHBBF[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2);
		this.EBKOKLMHBBF[6].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3;
		if (this.EBKOKLMHBBF[0].PIDLOFMIEFQ != "Open")
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].JMCNGQNFCPI());
		}
		else
		{
			this.EBKOKLMHBBF[0].LKPOBCBOFIC("Vital Spirit");
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "-setboost")
		{
			this.EBKOKLMHBBF[3].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2));
		}
		else
		{
			this.EBKOKLMHBBF[0].LKPOBCBOFIC("_DitheringTex");
		}
		if (this.EBKOKLMHBBF[4].PIDLOFMIEFQ != "_LogLut_Params")
		{
			this.EBKOKLMHBBF[1].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[6].LKPOBCBOFIC("[ZZZ]");
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, (char)-97);
		if (list.Count > 0)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("Guild");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.BFDGBMNGBKH(text);
				}
			}
		}
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH(" bounced the [ffff00]");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("BuffIcon_Teleport");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 650.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM * 1073.0);
		if (num < 1098.0)
		{
			num = 629.0;
		}
		if (num > 1317.0)
		{
			num = 1718.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() == 731.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -1;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(986f, 1891f, 245f, 1055f);
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() <= 430.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -66;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1147f, 1354f, 371f, 88f);
		}
		else
		{
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(1375f, 180f, 26f, 1561f));
		}
		this.FMKKFBQNBOB[1].KCLBMPFIPNQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant();
		this.FMKKFBQNBOB[0].DIIHJCJOKMP = 5f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].IGMOEONIJJF().Length < 5)
		{
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 1575f;
		}
		else
		{
			this.FMKKFBQNBOB[1].JLENFJGDNFN(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.ToLowerInvariant());
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 139f;
		}
	}

	// Token: 0x06004DBD RID: 19901 RVA: 0x00287B10 File Offset: 0x00285D10
	public void QEGPKNOHGOF(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.DBPKNCDGGEP = (int)CFHEIICNLFD.Entry.Pokemon;
			bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 0)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
				{
					if (this.MKMBGGQNLHD[i].MKEDHNEMKOI() == bccollojihm.DBPKNCDGGEP)
					{
						this.MKMBGGQNLHD[i].PLCBFLQBCQN = bccollojihm.OHNQLPGIOGK();
						this.OOFDODDNQOF();
						GBQODOBKJBG.CPIJOBOQLOK().ELCFBPPJQPQ(true);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.EMOJBCGNQJE);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("brn");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("Username");
		this.QIBGODKJQON();
		GBQODOBKJBG.CNIMIQKQJJJ().ELCFBPPJQPQ(false);
	}

	// Token: 0x06004DBE RID: 19902 RVA: 0x00287C48 File Offset: 0x00285E48
	public void FKCJGJGLFCK()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = false;
		this.DGOGLKQMDFD[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = true;
		this.PKBOPNPKQOG[1].SetActive(false);
	}

	// Token: 0x06004DBF RID: 19903 RVA: 0x00287CB8 File Offset: 0x00285EB8
	public void MMCKBJIEONC(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 1; i < CFHEIICNLFD.Entries.Length; i++)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.PCIICKJBGJG((int)CFHEIICNLFD.Entries[i].Pokemon);
				bccollojihm.PLCBFLQBCQN = (int)CFHEIICNLFD.Entries[i].State;
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.HLMGINLIIID);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("StopRow2");
		this.JLHPHHIMLFL.LKPOBCBOFIC(CFHEIICNLFD.Seen.ToString("It had no effect!\r\n"));
		this.QIBGODKJQON();
	}

	// Token: 0x06004DC0 RID: 19904 RVA: 0x00287D84 File Offset: 0x00285F84
	private void DGMPMICDCIO()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 0; i < this.EKBLKEFHDPH.Length; i += 0)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = false;
		this.QGOQDGPIHJO(0);
		this.OOFDODDNQOF();
		this.ClickDescription();
	}

	// Token: 0x06004DC1 RID: 19905 RVA: 0x00287E00 File Offset: 0x00286000
	public bool CJCIJPLMMCJ(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return true;
		}
		int num = this.HQGPFOGDOPJ(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].BJMDOIIODND();
	}

	// Token: 0x06004DC2 RID: 19906 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
	public void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		base.CancelInvoke("HidePanel");
	}

	// Token: 0x06004DC3 RID: 19907 RVA: 0x00287E34 File Offset: 0x00286034
	public bool KFDPINQLKCC(int CIQFCJGQEMH)
	{
		int num = this.HQGPFOGDOPJ(CIQFCJGQEMH);
		return num <= -1 || !this.MKMBGGQNLHD[num].LBCQKBMGPMK();
	}

	// Token: 0x06004DC4 RID: 19908 RVA: 0x00286C80 File Offset: 0x00284E80
	private static int GMCHFPMMQQP(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.NNKDGMIDHIG().CompareTo(DDLQKFDFMCJ.DBPKNCDGGEP);
	}

	// Token: 0x06004DC5 RID: 19909 RVA: 0x00287E64 File Offset: 0x00286064
	public bool EBPDIKFHBFH(int CIQFCJGQEMH)
	{
		int num = this.NFQOQOBDJEG(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].QFHKHBIJEFQ();
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x00287E94 File Offset: 0x00286094
	public void JJNPDFBHEOQ(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HQQDJHEEJHP();
		this.LLOFFEKDOMI.OJQEOEIJDQG.GIPBBFDPCKG(1088f);
		this.LLOFFEKDOMI.FBFCKBGLGBL();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(true);
			this.DOJIMNIKOBL[1].SetActive(true);
			this.DOJIMNIKOBL[1].SetActive(false);
			this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "[-]";
			this.DBQGICFJQKN.DIIHJCJOKMP = 1324f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[0].SetActive(false);
		this.DOJIMNIKOBL[1].SetActive(false);
		this.MLLOKPLECHK.SetActive(false);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(374f, 1188f, 1880f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, true, Vector3.zero, new Vector3(1494f, 693f, 719f), null, " is buffeted by the sandstorm!\r\n");
		this.DBQGICFJQKN.DIIHJCJOKMP = 1071f;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("'s " + DBPKNCDGGEP.DBFPJOCLQBI() + "\n" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species);
		BKKHLBCLPJM bkkhlbclpjm = this.QHEJPNJNMCI[3];
		string[] array = new string[0];
		array[0] = ",";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height;
		array[8] = "[-]\n";
		array[0] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Weight;
		array[1] = "1";
		bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LGOODGEDFQG();
		this.LCKBBGCIPIE.JELGOCNFQQM((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PIHNCFDOHJC(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP);
		this.QHEJPNJNMCI[2].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GOQGPQLHQFI().ToString() + "blank");
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KKMNOIGJOKJ().ToString() + "[00FF00]+");
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVDEF.ToString() + "_Amplitude");
		this.QHEJPNJNMCI[3].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "UpdateTime");
		this.QHEJPNJNMCI[6].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "mist");
		this.QHEJPNJNMCI[-67].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "[silent]";
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array2 = new string[85];
		array2[1] = "receiver";
		array2[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array2[0] = "It reduced the PP of ";
		array2[3] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF.ToString();
		array2[0] = "Player/Body";
		array2[7] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD.ToString();
		array2[8] = "'s ";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK.ToString();
		array2[2] = "Offline";
		array2[-76] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LMEGFPQPDKI().ToString();
		array2[85] = "Guild";
		array2[-64] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PGGEGHIDIHE().ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array2);
		BKKHLBCLPJM[] ebkoklmhbbf = this.EBKOKLMHBBF;
		for (int i = 1; i < ebkoklmhbbf.Length; i += 0)
		{
			BKKHLBCLPJM bkkhlbclpjm2 = ebkoklmhbbf[i];
			bkkhlbclpjm2.LKPOBCBOFIC(string.Empty);
		}
		this.EBKOKLMHBBF[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].JMCNGQNFCPI());
		this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLOBICEOMBF();
		this.EBKOKLMHBBF[8].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "[block]")
		{
			this.EBKOKLMHBBF[6].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].JMCNGQNFCPI());
		}
		else
		{
			this.EBKOKLMHBBF[1].PIDLOFMIEFQ = "missingno.";
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "!\r\n")
		{
			this.EBKOKLMHBBF[8].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLOBICEOMBF()));
		}
		else
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = "\n[PG]";
		}
		if (this.EBKOKLMHBBF[5].PIDLOFMIEFQ != "Sand Veil")
		{
			this.EBKOKLMHBBF[6].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[4].PIDLOFMIEFQ = "'.";
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, 'E');
		if (list.Count > 1)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("Enabled");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text);
				}
			}
		}
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("\n[PG]");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("honeygather");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 447.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() * 732.0);
		if (num < 464.0)
		{
			num = 1395.0;
		}
		if (num > 452.0)
		{
			num = 183.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM == 489.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 44;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1f, 1235f, 752f, 1953f);
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() <= 1930.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 17;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1608f, 1665f, 1561f, 1061f);
		}
		else
		{
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(1980f, 467f, 1190f, 1242f));
		}
		this.FMKKFBQNBOB[1].OGQLCMOFLLQ(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant());
		this.FMKKFBQNBOB[1].DIIHJCJOKMP = 729f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.Length < 5)
		{
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 422f;
		}
		else
		{
			this.FMKKFBQNBOB[0].JLENFJGDNFN(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CFCMMIKCQCD().ToLowerInvariant());
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1687f;
		}
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x0001FABF File Offset: 0x0001DCBF
	public static EIDBQCPLPIL KEHHJHKPKBE()
	{
		return EIDBQCPLPIL.HBFFCJHOCPE;
	}

	// Token: 0x06004DC8 RID: 19912 RVA: 0x0028641C File Offset: 0x0028461C
	[CompilerGenerated]
	private static int DMJQMLNFMEL(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.DBPKNCDGGEP.CompareTo(DDLQKFDFMCJ.DBPKNCDGGEP);
	}

	// Token: 0x06004DC9 RID: 19913 RVA: 0x00288864 File Offset: 0x00286A64
	private int NFQOQOBDJEG(int DBPKNCDGGEP)
	{
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			return -1;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			if (this.MKMBGGQNLHD[i] != null && this.MKMBGGQNLHD[i].DBPKNCDGGEP == DBPKNCDGGEP)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06004DCA RID: 19914 RVA: 0x00285A04 File Offset: 0x00283C04
	public void HGNBLGLHKDG()
	{
		if (this.LELFDOQONPD)
		{
			return;
		}
		if (this.QIGMLPOQOCB == -1)
		{
			return;
		}
		this.LELFDOQONPD = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Areas
		{
			PokemonID = this.QIGMLPOQOCB
		}, true);
	}

	// Token: 0x06004DCB RID: 19915 RVA: 0x002888C0 File Offset: 0x00286AC0
	public void HKJIHGKDKLM(int DBPKNCDGGEP = 0)
	{
		base.CancelInvoke("#");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1920f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		if (DBPKNCDGGEP > 0)
		{
			this.CQJBBDQHMQP(DBPKNCDGGEP);
		}
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x0028891C File Offset: 0x00286B1C
	public void HGPHNIMDOCC()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.DGOGLKQMDFD[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.PKBOPNPKQOG[0].SetActive(true);
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x0028898C File Offset: 0x00286B8C
	public bool LMEFIQLMQIG(int CIQFCJGQEMH)
	{
		int num = this.HQGPFOGDOPJ(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].BCLCQOPMJLP();
	}

	// Token: 0x06004DCE RID: 19918 RVA: 0x0001FABF File Offset: 0x0001DCBF
	public static EIDBQCPLPIL FFCOKMHBCQJ()
	{
		return EIDBQCPLPIL.HBFFCJHOCPE;
	}

	// Token: 0x06004DCF RID: 19919 RVA: 0x002889BC File Offset: 0x00286BBC
	public void JGQOMNKDJNC(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 1; i < CFHEIICNLFD.Entries.Length; i++)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.BPDOKQQEMBI((int)CFHEIICNLFD.Entries[i].Pokemon);
				bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entries[i].State);
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.BQCOMGLLMII);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.LKPOBCBOFIC(CFHEIICNLFD.Caught.ToString("parentalbond"));
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("The effects of Water Sport have faded.\r\n");
		this.CDBCQNGKDHH();
	}

	// Token: 0x06004DD0 RID: 19920 RVA: 0x00288A88 File Offset: 0x00286C88
	public void LFCICMMLMNL()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.QIBGODKJQON();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = false;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			this.MKMBGGQNLHD[i].DEHODNOBILD(true);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].Hide();
		}
		if (this.NMBCHIIQLIH.HJMJDJKOILH().Length < 8 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.BGBMIEJJQKC);
			if (num < 1 && num > -108)
			{
				return;
			}
			int num2 = 1;
			for (int k = 1; k < 169; k++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].FQFIFPGJDBE(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 0; l < -3; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].FPQIFQNBIDC(this.MKMBGGQNLHD[num5].PJNPEEFMLLM(), this.MKMBGGQNLHD[num5].OHNQLPGIOGK(), num);
						num4++;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DD1 RID: 19921 RVA: 0x00288CAC File Offset: 0x00286EAC
	public void JDKNDICPGDH()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.OOFDODDNQOF();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 1; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].DEHODNOBILD(true);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].CBBOOJHHGDG();
		}
		if (this.NMBCHIIQLIH.HJMJDJKOILH().Length < 2 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.HJMJDJKOILH());
			if (num < 1 && num > -25)
			{
				return;
			}
			int num2 = 0;
			for (int k = 0; k < 168; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].FDEDICFQNEJ(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num);
						num2++;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 1; l < 113; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.HQGPFOGDOPJ(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].FQFIFPGJDBE(this.MKMBGGQNLHD[num5].BLLCKJPNHKK(), this.MKMBGGQNLHD[num5].PLCBFLQBCQN, num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DD2 RID: 19922 RVA: 0x00288ED0 File Offset: 0x002870D0
	public void HOHLLNCCKJN()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.UpdateButtons();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 1; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].MQFCPNENMFP(false);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].DPBQLJNPIFB();
		}
		if (this.NMBCHIIQLIH.BGBMIEJJQKC.Length < 8 && this.NMBCHIIQLIH.BGBMIEJJQKC.HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.BGBMIEJJQKC);
			if (num < 1 && num > 150)
			{
				return;
			}
			int num2 = 1;
			for (int k = 0; k < -195; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].MKPCPBJQNID(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 0;
			for (int l = 1; l < -113; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.HQGPFOGDOPJ(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].HOFCKQELDLF(this.MKMBGGQNLHD[num5].BLLCKJPNHKK(), this.MKMBGGQNLHD[num5].PLCBFLQBCQN, num);
						num4++;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DD3 RID: 19923 RVA: 0x002890F4 File Offset: 0x002872F4
	public bool CNIBIQNCEBJ(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return true;
		}
		int num = this.HQGPFOGDOPJ(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].FPEGDLDQOJE();
	}

	// Token: 0x06004DD4 RID: 19924 RVA: 0x00289128 File Offset: 0x00287328
	public void HLEHBGMIHHB(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.DBPKNCDGGEP = (int)CFHEIICNLFD.Entry.Pokemon;
			bccollojihm.PLCBFLQBCQN = (int)CFHEIICNLFD.Entry.State;
			if (this.MKMBGGQNLHD.Count > 0)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
				{
					if (this.MKMBGGQNLHD[i].DBPKNCDGGEP == bccollojihm.DBPKNCDGGEP)
					{
						this.MKMBGGQNLHD[i].PLCBFLQBCQN = bccollojihm.PLCBFLQBCQN;
						this.UpdateButtons();
						GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(true);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.DMJQMLNFMEL);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("#,##0");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("#,##0");
		this.UpdateButtons();
		GBQODOBKJBG.QOQONHOOLNE.DIEQJNHPHPB(true);
	}

	// Token: 0x06004DD5 RID: 19925 RVA: 0x00289260 File Offset: 0x00287460
	public void OFGOJCKCFDN(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.BPDOKQQEMBI((int)CFHEIICNLFD.Entry.Pokemon);
			bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 0)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
				{
					if (this.MKMBGGQNLHD[i].NNKDGMIDHIG() == bccollojihm.MKEDHNEMKOI())
					{
						this.MKMBGGQNLHD[i].FBMHFBGBPPQ(bccollojihm.OHNQLPGIOGK());
						this.UpdateButtons();
						GBQODOBKJBG.BJLGEDCPENQ().FJQQJQFBIGN(false);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.DMJQMLNFMEL);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("Overcoat");
		this.JLHPHHIMLFL.LKPOBCBOFIC(CFHEIICNLFD.Seen.ToString("/party "));
		this.QIBGODKJQON();
		GBQODOBKJBG.OKKCFHDIDIF().FJQQJQFBIGN(false);
	}

	// Token: 0x06004DD6 RID: 19926 RVA: 0x00289398 File Offset: 0x00287598
	private static int ELLOENBHKHF(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.NNKDGMIDHIG().CompareTo(DDLQKFDFMCJ.MKEDHNEMKOI());
	}

	// Token: 0x06004DD7 RID: 19927 RVA: 0x002893BC File Offset: 0x002875BC
	public void JJBDEJHQIBG(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.QKIHFDGLQKG((int)CFHEIICNLFD.Entry.Pokemon);
			bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 0)
			{
				for (int i = 1; i < this.MKMBGGQNLHD.Count; i++)
				{
					if (this.MKMBGGQNLHD[i].DBPKNCDGGEP == bccollojihm.QBIFLEJHBCD())
					{
						this.MKMBGGQNLHD[i].GCDDCGNPJMO(bccollojihm.OHNQLPGIOGK());
						this.QIBGODKJQON();
						GBQODOBKJBG.PFQBLOEPBJB().ELCFBPPJQPQ(false);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.EMOJBCGNQJE);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("cutecharm");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("Script:");
		this.UpdateButtons();
		GBQODOBKJBG.CNIMIQKQJJJ().FJQQJQFBIGN(true);
	}

	// Token: 0x06004DD8 RID: 19928 RVA: 0x002894F4 File Offset: 0x002876F4
	private void BBGHCDGEDEJ()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 1; i < this.EKBLKEFHDPH.Length; i++)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
		this.QGOQDGPIHJO(0);
		this.CDBCQNGKDHH();
		this.ClickDescription();
	}

	// Token: 0x06004DD9 RID: 19929 RVA: 0x00289570 File Offset: 0x00287770
	public void KCOGKBQQQBH()
	{
		if (this.NMBCHIIQLIH.HJMJDJKOILH() == string.Empty)
		{
			this.CDBCQNGKDHH();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = false;
		}
		for (int i = 1; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].HPKMGNPCHNH(true);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j++)
		{
			this.EKBLKEFHDPH[j].Hide();
		}
		if (this.NMBCHIIQLIH.BGBMIEJJQKC.Length < 7 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.HJMJDJKOILH());
			if (num < 0 && num > -178)
			{
				return;
			}
			int num2 = 1;
			for (int k = 1; k < 151; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].DOEGKLDPQKB(this.MKMBGGQNLHD[num3].POPFQHECGCH(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 0; l < 0; l++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].HOFCKQELDLF(this.MKMBGGQNLHD[num5].POPFQHECGCH(), this.MKMBGGQNLHD[num5].PLCBFLQBCQN, num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DDA RID: 19930 RVA: 0x00289794 File Offset: 0x00287994
	public void ClickShowOnMap()
	{
		if (this.LELFDOQONPD)
		{
			return;
		}
		if (this.QIGMLPOQOCB == -1)
		{
			return;
		}
		this.LELFDOQONPD = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Areas
		{
			PokemonID = this.QIGMLPOQOCB
		}, false);
	}

	// Token: 0x06004DDB RID: 19931 RVA: 0x002897DC File Offset: 0x002879DC
	public void MDKHQQBDOHH()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.LLOFFEKDOMI.OJQEOEIJDQG.GIPBBFDPCKG(54f);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06004DDC RID: 19932 RVA: 0x00289860 File Offset: 0x00287A60
	public void EBJCCKNKHFH(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HQQDJHEEJHP();
		this.LLOFFEKDOMI.OJQEOEIJDQG.PLLQOHPCBOP(611f);
		this.LLOFFEKDOMI.BPFQEKCPJDI();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(false);
			this.DOJIMNIKOBL[1].SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(true);
			this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "comatose";
			this.DBQGICFJQKN.DIIHJCJOKMP = 446f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[1].SetActive(true);
		this.DOJIMNIKOBL[1].SetActive(true);
		this.MLLOKPLECHK.SetActive(true);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(1066f, 1515f, 1550f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, true, Vector3.zero, new Vector3(1225f, 1614f, 1243f), null, "You can not afford to increase your guild member limit.\nCost: ");
		this.DBQGICFJQKN.DIIHJCJOKMP = 1378f;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("MSGBOX - Confirm EVs" + DBPKNCDGGEP.DBFPJOCLQBI() + "_SSRMultiplier" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species);
		BKKHLBCLPJM bkkhlbclpjm = this.QHEJPNJNMCI[7];
		string[] array = new string[0];
		array[1] = "_ClipArgs0";
		array[0] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height;
		array[2] = "rest";
		array[2] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Weight;
		array[6] = "Frost";
		bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		this.QHEJPNJNMCI[2].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILOMPJBLEHO());
		this.LCKBBGCIPIE.CQNOOCGGGDG((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILECQIKPEPI(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LMEGFPQPDKI(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PGGEGHIDIHE());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GOQGPQLHQFI().ToString() + "--mustrecharge");
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KKMNOIGJOKJ().ToString() + "[F]");
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVDEF.ToString() + "(V)";
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "BuffIcon_EncounterRateDecreased";
		this.QHEJPNJNMCI[3].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "_");
		this.QHEJPNJNMCI[-98].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "Localization key '");
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array2 = new string[-99];
		array2[1] = "move: ";
		array2[0] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array2[7] = "lightmetal";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PIHNCFDOHJC().ToString();
		array2[3] = "steelworker";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].BCQDOBBIBIM().ToString();
		array2[4] = "Pokeball_Shake";
		array2[5] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILECQIKPEPI().ToString();
		array2[2] = "rotomwash";
		array2[49] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPDEF.ToString();
		array2[0] = "aromaveil";
		array2[48] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].MOOGMOLJCFC().ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array2);
		BKKHLBCLPJM[] ebkoklmhbbf = this.EBKOKLMHBBF;
		for (int i = 1; i < ebkoklmhbbf.Length; i += 0)
		{
			BKKHLBCLPJM bkkhlbclpjm2 = ebkoklmhbbf[i];
			bkkhlbclpjm2.LKPOBCBOFIC(string.Empty);
		}
		this.EBKOKLMHBBF[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].JMCNGQNFCPI());
		this.EBKOKLMHBBF[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DNGJDQNNNML());
		this.EBKOKLMHBBF[4].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "_FullResolutionFiltering")
		{
			this.EBKOKLMHBBF[7].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability1);
		}
		else
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = "Swift Swim";
		}
		if (this.EBKOKLMHBBF[0].PIDLOFMIEFQ != "inven ")
		{
			this.EBKOKLMHBBF[3].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2));
		}
		else
		{
			this.EBKOKLMHBBF[1].LKPOBCBOFIC("Language");
		}
		if (this.EBKOKLMHBBF[7].PIDLOFMIEFQ != "aegislash")
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[7].LKPOBCBOFIC("fighting");
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, '\v');
		if (list.Count > 0)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("Guild");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text);
				}
			}
		}
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("[FF8F00]");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("WATER_SIMPLE");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 800.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM * 18.0);
		if (num < 1977.0)
		{
			num = 1774.0;
		}
		if (num > 149.0)
		{
			num = 380.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() == 704.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 109;
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(1241f, 1900f, 1374f, 1416f));
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() <= 1840.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 101;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1045f, 1229f, 1043f, 1826f);
		}
		else
		{
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(258f, 1293f, 1248f, 912f));
		}
		this.FMKKFBQNBOB[0].IQBBDKFDGGP(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant());
		this.FMKKFBQNBOB[1].DIIHJCJOKMP = 1248f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.Length < 8)
		{
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1103f;
		}
		else
		{
			this.FMKKFBQNBOB[1].IQBBDKFDGGP(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].IGMOEONIJJF().ToLowerInvariant());
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 556f;
		}
	}

	// Token: 0x06004DDD RID: 19933 RVA: 0x0001FB02 File Offset: 0x0001DD02
	public void CGLGLNMBQPB(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.PKOFMMGCGJO(DBPKNCDGGEP);
		this.MPGPHJMHFHP(DBPKNCDGGEP);
	}

	// Token: 0x06004DDE RID: 19934 RVA: 0x0028A230 File Offset: 0x00288430
	public void MQIPLGJIKBK()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.OOFDODDNQOF();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 1; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].IMDFIPDOCKL = true;
		}
		for (int j = 1; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].NPCKENGDEIN();
		}
		if (this.NMBCHIIQLIH.HJMJDJKOILH().Length < 6 && this.NMBCHIIQLIH.BGBMIEJJQKC.HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.HJMJDJKOILH());
			if (num < 0 && num > 69)
			{
				return;
			}
			int num2 = 1;
			for (int k = 0; k < 68; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.HQGPFOGDOPJ(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].FDEDICFQNEJ(this.MKMBGGQNLHD[num3].BLLCKJPNHKK(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 0; l < 79; l++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].FQFIFPGJDBE(this.MKMBGGQNLHD[num5].POPFQHECGCH(), this.MKMBGGQNLHD[num5].OHNQLPGIOGK(), num);
						num4++;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DDF RID: 19935 RVA: 0x0028A454 File Offset: 0x00288654
	public bool PMJGEINEHFH(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return false;
		}
		int num = this.PKOFMMGCGJO(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].FPEGDLDQOJE();
	}

	// Token: 0x06004DE0 RID: 19936 RVA: 0x0028A488 File Offset: 0x00288688
	public void LBQMPGLOEDN()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.UpdateButtons();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 1; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].EGELDFLMFIO(true);
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].QGJPMKPOGKN();
		}
		if (this.NMBCHIIQLIH.HJMJDJKOILH().Length < 0 && this.NMBCHIIQLIH.HJMJDJKOILH().HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.BGBMIEJJQKC);
			if (num < 1 && num > -129)
			{
				return;
			}
			int num2 = 1;
			for (int k = 1; k < -136; k += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.NFQOQOBDJEG(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].EDKDPDKIBJN(this.MKMBGGQNLHD[num3].BLLCKJPNHKK(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 1; l < -106; l++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.PKOFMMGCGJO(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].LCCQBMMFONQ(this.MKMBGGQNLHD[num5].BLLCKJPNHKK(), this.MKMBGGQNLHD[num5].OHNQLPGIOGK(), num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DE1 RID: 19937 RVA: 0x0028A6AC File Offset: 0x002888AC
	public void UpdateSearch()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.UpdateButtons();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = false;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			this.MKMBGGQNLHD[i].IMDFIPDOCKL = false;
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j++)
		{
			this.EKBLKEFHDPH[j].Hide();
		}
		if (this.NMBCHIIQLIH.BGBMIEJJQKC.Length < 4 && this.NMBCHIIQLIH.BGBMIEJJQKC.HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.BGBMIEJJQKC);
			if (num < 0 && num > 802)
			{
				return;
			}
			int num2 = 0;
			for (int k = 1; k < 803; k++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.NFQOQOBDJEG(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].BQLIIQIIMDH(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2++;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 0;
			for (int l = 1; l < 803; l++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].BQLIIQIIMDH(this.MKMBGGQNLHD[num5].PJNPEEFMLLM(), this.MKMBGGQNLHD[num5].PLCBFLQBCQN, num);
						num4++;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DE2 RID: 19938 RVA: 0x0028A8D0 File Offset: 0x00288AD0
	public void OOIQOJLDJHC(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HQQDJHEEJHP();
		this.LLOFFEKDOMI.OJQEOEIJDQG.FONJFPIKGEP(82f);
		this.LLOFFEKDOMI.CPLBKPNNHJG();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(true);
			this.DOJIMNIKOBL[0].SetActive(true);
			this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "_Saturation";
			this.DBQGICFJQKN.DIIHJCJOKMP = 694f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[0].SetActive(false);
		this.DOJIMNIKOBL[0].SetActive(true);
		this.MLLOKPLECHK.SetActive(true);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(1376f, 1968f, 1707f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, false, Vector3.zero, new Vector3(1733f, 1071f, 1620f), null, "End");
		this.DBQGICFJQKN.DIIHJCJOKMP = 1602f;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("´" + DBPKNCDGGEP.DBFPJOCLQBI() + " became fully charged due to its bond with its Trainer!\r\n" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species;
		BKKHLBCLPJM bkkhlbclpjm = this.QHEJPNJNMCI[1];
		string[] array = new string[8];
		array[0] = "safetygoggles";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height;
		array[2] = "The sandstorm subsided.";
		array[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Weight;
		array[1] = "-1";
		bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LGOODGEDFQG());
		this.LCKBBGCIPIE.GLIOFDHNIEJ((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILECQIKPEPI(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].MOOGMOLJCFC());
		this.QHEJPNJNMCI[3].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GOQGPQLHQFI().ToString() + "Blank");
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].NEJHOQMJCJE().ToString() + "Color Grading Log LUT");
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QIIDLMDDGPM().ToString() + "waterabsorb";
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "(RB)");
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "FOG_VOID_SPHERE";
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "status: ";
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array2 = new string[-63];
		array2[1] = "[ATK]";
		array2[0] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array2[6] = "Fog Volume entered by ";
		array2[2] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PIHNCFDOHJC().ToString();
		array2[4] = "[";
		array2[7] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].BCQDOBBIBIM().ToString();
		array2[3] = "Battery";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KGLNBBQLDIO().ToString();
		array2[8] = "GRAIN";
		array2[30] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF().ToString();
		array2[104] = "bag";
		array2[-127] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP.ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array2);
		BKKHLBCLPJM[] ebkoklmhbbf = this.EBKOKLMHBBF;
		for (int i = 1; i < ebkoklmhbbf.Length; i++)
		{
			BKKHLBCLPJM bkkhlbclpjm2 = ebkoklmhbbf[i];
			bkkhlbclpjm2.LKPOBCBOFIC(string.Empty);
		}
		this.EBKOKLMHBBF[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability1;
		this.EBKOKLMHBBF[1].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLOBICEOMBF());
		this.EBKOKLMHBBF[2].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3;
		if (this.EBKOKLMHBBF[0].PIDLOFMIEFQ != "#,##0")
		{
			this.EBKOKLMHBBF[8].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].KBLGGEOMBEL()));
		}
		else
		{
			this.EBKOKLMHBBF[1].LKPOBCBOFIC("Dark Aura");
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "[NGUI] ")
		{
			this.EBKOKLMHBBF[1].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2);
		}
		else
		{
			this.EBKOKLMHBBF[1].LKPOBCBOFIC("heatproof");
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "Dazzling")
		{
			this.EBKOKLMHBBF[3].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[8].PIDLOFMIEFQ = "[00EE07]";
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, '\u0005');
		if (list.Count > 1)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("VFMDepthCamera");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text);
				}
			}
		}
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("|");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.BFDGBMNGBKH(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("_HatTex");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 453.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() * 1745.0);
		if (num < 1052.0)
		{
			num = 327.0;
		}
		if (num > 1419.0)
		{
			num = 1962.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() == 1998.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -46;
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(867f, 1920f, 1656f, 1807f));
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() <= 1604.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -115;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(646f, 1485f, 541f, 1401f);
		}
		else
		{
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(464f, 51f, 1522f, 1498f);
		}
		this.FMKKFBQNBOB[0].IQBBDKFDGGP(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant());
		this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1976f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CFCMMIKCQCD().Length < 7)
		{
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1291f;
		}
		else
		{
			this.FMKKFBQNBOB[0].LGJOOQIBQDC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.ToLowerInvariant());
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 40f;
		}
	}

	// Token: 0x06004DE3 RID: 19939 RVA: 0x0028B2A0 File Offset: 0x002894A0
	private void LODQBMMKNNM()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 0; i < this.EKBLKEFHDPH.Length; i += 0)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
		this.OOIQOJLDJHC(0);
		this.QIBGODKJQON();
		this.HGPHNIMDOCC();
	}

	// Token: 0x06004DE4 RID: 19940 RVA: 0x0001FABF File Offset: 0x0001DCBF
	public static EIDBQCPLPIL PDPCLOECLOF()
	{
		return EIDBQCPLPIL.HBFFCJHOCPE;
	}

	// Token: 0x06004DE5 RID: 19941 RVA: 0x0001FB18 File Offset: 0x0001DD18
	public void FEJOFMOPGKM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		base.CancelInvoke("Trade Error");
	}

	// Token: 0x06004DE6 RID: 19942 RVA: 0x0001FB36 File Offset: 0x0001DD36
	public void OPQLLMHCCHB(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.PKOFMMGCGJO(DBPKNCDGGEP);
		this.QGOQDGPIHJO(DBPKNCDGGEP);
	}

	// Token: 0x06004DE7 RID: 19943 RVA: 0x0001FB4C File Offset: 0x0001DD4C
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open(0);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06004DE8 RID: 19944 RVA: 0x0028B31C File Offset: 0x0028951C
	public bool PLIJIELDNQQ(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return false;
		}
		int num = this.PKOFMMGCGJO(CIQFCJGQEMH);
		return num <= -1 || !this.MKMBGGQNLHD[num].PDLHDNPGQID() || true;
	}

	// Token: 0x06004DE9 RID: 19945 RVA: 0x0028B350 File Offset: 0x00289550
	public void GNEQGCMGBKB(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.DBPKNCDGGEP = (int)CFHEIICNLFD.Entry.Pokemon;
			bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 1)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
				{
					if (this.MKMBGGQNLHD[i].DBPKNCDGGEP == bccollojihm.DBPKNCDGGEP)
					{
						this.MKMBGGQNLHD[i].GCDDCGNPJMO(bccollojihm.OHNQLPGIOGK());
						this.UpdateButtons();
						GBQODOBKJBG.CNIMIQKQJJJ().DIEQJNHPHPB(true);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.GMCHFPMMQQP);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("-");
		this.JLHPHHIMLFL.PIDLOFMIEFQ = CFHEIICNLFD.Seen.ToString("'s [ffff00]");
		this.OOFDODDNQOF();
		GBQODOBKJBG.BJLGEDCPENQ().FJQQJQFBIGN(true);
	}

	// Token: 0x06004DEA RID: 19946 RVA: 0x0001FB7F File Offset: 0x0001DD7F
	public void CQJBBDQHMQP(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.NFQOQOBDJEG(DBPKNCDGGEP);
		this.EBJCCKNKHFH(DBPKNCDGGEP);
	}

	// Token: 0x06004DEB RID: 19947 RVA: 0x0028B488 File Offset: 0x00289688
	private void Start()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 0; i < this.EKBLKEFHDPH.Length; i++)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
		this.ShowPokemon(1);
		this.UpdateButtons();
		this.ClickDescription();
	}

	// Token: 0x06004DEC RID: 19948 RVA: 0x0028B504 File Offset: 0x00289704
	public void LCIOCCKDBNK(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.HDDJIDGKKFK();
		this.LLOFFEKDOMI.OJQEOEIJDQG.PLLQOHPCBOP(1765f);
		this.LLOFFEKDOMI.FBFCKBGLGBL();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(false);
			this.DOJIMNIKOBL[1].SetActive(false);
			this.DOJIMNIKOBL[1].SetActive(true);
			this.QHEJPNJNMCI[0].LKPOBCBOFIC("_Texture1");
			this.DBQGICFJQKN.DIIHJCJOKMP = 607f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[1].SetActive(true);
		this.DOJIMNIKOBL[1].SetActive(true);
		this.MLLOKPLECHK.SetActive(true);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(1330f, 1566f, 213f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, true, Vector3.zero, new Vector3(318f, 220f, 1212f), null, "Interact");
		this.DBQGICFJQKN.DIIHJCJOKMP = 485f;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("par" + DBPKNCDGGEP.DBFPJOCLQBI() + "Add to Ignore" + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species;
		BKKHLBCLPJM bkkhlbclpjm = this.QHEJPNJNMCI[4];
		string[] array = new string[1];
		array[0] = "The rain stopped.";
		array[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height;
		array[7] = "}][/pok] ";
		array[0] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].IPKMIHLCEOF();
		array[3] = "Egg";
		bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].LGOODGEDFQG());
		this.LCKBBGCIPIE.MOGQDLIHJKN((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HBEPNELQMLF(), (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PGGEGHIDIHE());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVHP.ToString() + "slp");
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVATK.ToString() + "UpdateAnchors");
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QIIDLMDDGPM().ToString() + "_TransitionTex");
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "Gravity intensified!\r\n");
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "protean";
		this.QHEJPNJNMCI[-127].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "#,##0";
		CPLHOLGBMKB npkojofidod = this.NPKOJOFIDOD;
		string[] array2 = new string[-106];
		array2[0] = "You used '";
		array2[1] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString();
		array2[7] = "p";
		array2[8] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PIHNCFDOHJC().ToString();
		array2[5] = "FOG_SCATTERING_ON";
		array2[8] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD.ToString();
		array2[0] = "When another Pokémon uses a dance move, it can use a dance move following it regardless of its Speed.";
		array2[4] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ILECQIKPEPI().ToString();
		array2[8] = "Poison spikes were scattered on the ground all around ";
		array2[102] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPDEF.ToString();
		array2[-101] = "!\r\n";
		array2[3] = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].PGGEGHIDIHE().ToString();
		npkojofidod.OKFNHJPFIGB = string.Concat(array2);
		foreach (BKKHLBCLPJM bkkhlbclpjm2 in this.EBKOKLMHBBF)
		{
			bkkhlbclpjm2.LKPOBCBOFIC(string.Empty);
		}
		this.EBKOKLMHBBF[0].LKPOBCBOFIC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GIDDJOJEMLH());
		this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DNGJDQNNNML();
		this.EBKOKLMHBBF[8].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3;
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "Poké Gold")
		{
			this.EBKOKLMHBBF[3].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].GIDDJOJEMLH());
		}
		else
		{
			this.EBKOKLMHBBF[0].LKPOBCBOFIC("Trigger Influence");
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "+")
		{
			this.EBKOKLMHBBF[8].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLOBICEOMBF()));
		}
		else
		{
			this.EBKOKLMHBBF[0].LKPOBCBOFIC(" kept going and crashed!\r\n");
		}
		if (this.EBKOKLMHBBF[2].PIDLOFMIEFQ != "Assets/AssetBundles/Fly Pokemon/")
		{
			this.EBKOKLMHBBF[3].LKPOBCBOFIC(KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3));
		}
		else
		{
			this.EBKOKLMHBBF[2].PIDLOFMIEFQ = "Fly Mount";
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, '\u001e');
		if (list.Count > 0)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.BFDGBMNGBKH(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("Can't resolve the item ID of ");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.BFDGBMNGBKH(text);
				}
			}
		}
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.BFDGBMNGBKH(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH("replace");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.BFDGBMNGBKH(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 1)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.BFDGBMNGBKH(".");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 188.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].QLMNOIPHCJD() * 1250.0);
		if (num < 234.0)
		{
			num = 511.0;
		}
		if (num > 100.0)
		{
			num = 537.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() == 1455.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -118;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1991f, 1756f, 1264f, 1969f);
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CEHEEKCKJQO() <= 581.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = -112;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1418f, 1333f, 205f, 833f);
		}
		else
		{
			this.QJMMHOGHQFG.NONQDHBCIIN(new Color(238f, 579f, 646f, 1489f));
		}
		this.FMKKFBQNBOB[0].LGJOOQIBQDC(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant());
		this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1634f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CFCMMIKCQCD().Length < 6)
		{
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 1744f;
		}
		else
		{
			this.FMKKFBQNBOB[1].JLENFJGDNFN(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].CFCMMIKCQCD().ToLowerInvariant());
			this.FMKKFBQNBOB[0].DIIHJCJOKMP = 716f;
		}
	}

	// Token: 0x06004DED RID: 19949 RVA: 0x0028BED4 File Offset: 0x0028A0D4
	public void ClickMoves()
	{
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(true);
		this.LLOFFEKDOMI.OJQEOEIJDQG.BGBMIEJJQKC = 0f;
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = true;
		this.DGOGLKQMDFD[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06004DEE RID: 19950 RVA: 0x0001FB95 File Offset: 0x0001DD95
	public void GCDKMDJNDQQ(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.HQGPFOGDOPJ(DBPKNCDGGEP);
		this.JJNPDFBHEOQ(DBPKNCDGGEP);
	}

	// Token: 0x06004DEF RID: 19951 RVA: 0x0028BF58 File Offset: 0x0028A158
	public void Open(int DBPKNCDGGEP = 0)
	{
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		if (DBPKNCDGGEP > 0)
		{
			this.SelectPoke(DBPKNCDGGEP);
		}
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x0028BFB4 File Offset: 0x0028A1B4
	public void OOFDODDNQOF()
	{
		if (this.NMBCHIIQLIH.HJMJDJKOILH() != string.Empty)
		{
			this.QODKDQHIDNE();
			return;
		}
		float num = this.EDGCGMGCCDN.BGBMIEJJQKC * 451f;
		num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
		int num2 = (int)num;
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].DEHODNOBILD(false);
		}
		for (int j = 1; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].DPBQLJNPIFB();
		}
		if (!this.FKQOOJMNEJQ.value)
		{
			for (int k = 1; k < this.EKBLKEFHDPH.Length; k += 0)
			{
				if (num2 + k + 1 < -61)
				{
					int num3 = this.PKOFMMGCGJO(num2 + k + 1);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[k].EDKDPDKIBJN(this.MKMBGGQNLHD[num3].BLLCKJPNHKK(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num2 + k + 1);
					}
					else
					{
						this.EKBLKEFHDPH[k].LCCQBMMFONQ(false, 0, num2 + k + 0);
					}
				}
			}
		}
		else
		{
			num = this.EDGCGMGCCDN.BGBMIEJJQKC * 573f;
			num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
			num2 = (int)num;
			if (num2 > 1)
			{
				num2++;
			}
			int l = 0;
			IL_258:
			while (l < this.EKBLKEFHDPH.Length)
			{
				for (int m = 1; m < this.MKMBGGQNLHD.Count; m++)
				{
					if (this.MKMBGGQNLHD[m].DBPKNCDGGEP < 155 && this.MKMBGGQNLHD[m].NNKDGMIDHIG() > 0 && m >= num2 && !this.MKMBGGQNLHD[m].BODPFNQELPP() && this.MKMBGGQNLHD[m].OHNQLPGIOGK() > 0)
					{
						this.EKBLKEFHDPH[l].BQLIIQIIMDH(this.MKMBGGQNLHD[m].POPFQHECGCH(), this.MKMBGGQNLHD[m].PLCBFLQBCQN, this.MKMBGGQNLHD[m].MKEDHNEMKOI());
						this.MKMBGGQNLHD[m].EGELDFLMFIO(true);
						IL_252:
						l++;
						goto IL_258;
					}
				}
				goto IL_252;
			}
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06004DF1 RID: 19953 RVA: 0x0001FABF File Offset: 0x0001DCBF
	public static EIDBQCPLPIL QOQONHOOLNE
	{
		get
		{
			return EIDBQCPLPIL.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x0028C228 File Offset: 0x0028A428
	public void IMIMGBNEIGO(PokedexUpdate CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entry != null)
		{
			EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
			bccollojihm.BPDOKQQEMBI((int)CFHEIICNLFD.Entry.Pokemon);
			bccollojihm.GCDDCGNPJMO((int)CFHEIICNLFD.Entry.State);
			if (this.MKMBGGQNLHD.Count > 1)
			{
				for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
				{
					if (this.MKMBGGQNLHD[i].DBPKNCDGGEP == bccollojihm.MKEDHNEMKOI())
					{
						this.MKMBGGQNLHD[i].FBMHFBGBPPQ(bccollojihm.PLCBFLQBCQN);
						this.CDBCQNGKDHH();
						GBQODOBKJBG.INJDHLQHFFD().QMOFLHOCMQP(true);
						return;
					}
				}
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			else
			{
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.HNCJFHJNHDN == null)
			{
				EIDBQCPLPIL.HNCJFHJNHDN = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.NMJHPGMIKOB);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.HNCJFHJNHDN);
		}
		this.BEHECPNMGEJ.PIDLOFMIEFQ = CFHEIICNLFD.Caught.ToString("_1");
		this.JLHPHHIMLFL.LKPOBCBOFIC(CFHEIICNLFD.Seen.ToString("Pidgey"));
		this.UpdateButtons();
		GBQODOBKJBG.CPIJOBOQLOK().FJQQJQFBIGN(true);
	}

	// Token: 0x06004DF3 RID: 19955 RVA: 0x0028C360 File Offset: 0x0028A560
	private int HQGPFOGDOPJ(int DBPKNCDGGEP)
	{
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			return -1;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			if (this.MKMBGGQNLHD[i] != null && this.MKMBGGQNLHD[i].DBPKNCDGGEP == DBPKNCDGGEP)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x0028C3BC File Offset: 0x0028A5BC
	public void NNJLEGPHCOP()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
		this.DGOGLKQMDFD[0].GetComponent<BoxCollider>().enabled = false;
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.PKBOPNPKQOG[1].SetActive(true);
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x0028C42C File Offset: 0x0028A62C
	public void QJBLOGKNHHK(PSXAPI.Response.Pokedex CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Entries != null)
		{
			for (int i = 0; i < CFHEIICNLFD.Entries.Length; i += 0)
			{
				EIDBQCPLPIL.BCCOLLOJIHM bccollojihm = new EIDBQCPLPIL.BCCOLLOJIHM();
				bccollojihm.PCIICKJBGJG((int)CFHEIICNLFD.Entries[i].Pokemon);
				bccollojihm.FBMHFBGBPPQ((int)CFHEIICNLFD.Entries[i].State);
				this.MKMBGGQNLHD.Add(bccollojihm);
			}
			List<EIDBQCPLPIL.BCCOLLOJIHM> mkmbggqnlhd = this.MKMBGGQNLHD;
			if (EIDBQCPLPIL.BIJFPHIBEDK == null)
			{
				EIDBQCPLPIL.BIJFPHIBEDK = new Comparison<EIDBQCPLPIL.BCCOLLOJIHM>(EIDBQCPLPIL.BQCOMGLLMII);
			}
			mkmbggqnlhd.Sort(EIDBQCPLPIL.BIJFPHIBEDK);
		}
		this.BEHECPNMGEJ.LKPOBCBOFIC(CFHEIICNLFD.Caught.ToString("-mega"));
		this.JLHPHHIMLFL.LKPOBCBOFIC(CFHEIICNLFD.Seen.ToString("item"));
		this.CDBCQNGKDHH();
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x0001FB02 File Offset: 0x0001DD02
	public void EMMKHEOEMLP(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.PKOFMMGCGJO(DBPKNCDGGEP);
		this.MPGPHJMHFHP(DBPKNCDGGEP);
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x0028C4F8 File Offset: 0x0028A6F8
	private int PKOFMMGCGJO(int DBPKNCDGGEP)
	{
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			return -1;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			if (this.MKMBGGQNLHD[i] != null && this.MKMBGGQNLHD[i].QBIFLEJHBCD() == DBPKNCDGGEP)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x0028C554 File Offset: 0x0028A754
	public void DMQGGHHMQEI()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC == string.Empty)
		{
			this.QIBGODKJQON();
			return;
		}
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].EGELDFLMFIO(true);
		}
		for (int j = 1; j < this.EKBLKEFHDPH.Length; j += 0)
		{
			this.EKBLKEFHDPH[j].Hide();
		}
		if (this.NMBCHIIQLIH.HJMJDJKOILH().Length < 2 && this.NMBCHIIQLIH.BGBMIEJJQKC.HGBIQHBEBHF())
		{
			int num = Convert.ToInt32(this.NMBCHIIQLIH.HJMJDJKOILH());
			if (num < 1 && num > -181)
			{
				return;
			}
			int num2 = 1;
			for (int k = 1; k < 184; k++)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[k].ID.ToString().IndexOf(this.NMBCHIIQLIH.HJMJDJKOILH().ToLowerInvariant()) != -1)
				{
					num = k;
					int num3 = this.NFQOQOBDJEG(num);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[num2].MKPCPBJQNID(this.MKMBGGQNLHD[num3].POPFQHECGCH(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num);
						num2 += 0;
					}
					if (num2 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
		else
		{
			int num4 = 1;
			for (int l = 0; l < -11; l += 0)
			{
				if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[l].Name.ToLowerInvariant().Contains(this.NMBCHIIQLIH.BGBMIEJJQKC.ToLowerInvariant()))
				{
					int num = l;
					int num5 = this.NFQOQOBDJEG(num);
					if (num5 > -1)
					{
						this.EKBLKEFHDPH[num4].DOEGKLDPQKB(this.MKMBGGQNLHD[num5].POPFQHECGCH(), this.MKMBGGQNLHD[num5].PLCBFLQBCQN, num);
						num4 += 0;
					}
					if (num4 >= this.HNIDIBLCJBM)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x0028C778 File Offset: 0x0028A978
	private void NOLQNFCODBK()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 1; i < this.EKBLKEFHDPH.Length; i++)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
		this.JJNPDFBHEOQ(1);
		this.OOFDODDNQOF();
		this.ClickDescription();
	}

	// Token: 0x06004DFA RID: 19962 RVA: 0x0001FBAB File Offset: 0x0001DDAB
	public void PHFEEOFGMHO()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		base.CancelInvoke("_ScaleOffsetRes");
	}

	// Token: 0x06004DFB RID: 19963 RVA: 0x0028C7F4 File Offset: 0x0028A9F4
	private void GJPGBCKQLDG()
	{
		this.EKBLKEFHDPH = new OPLQGKOBBLB[this.HNIDIBLCJBM];
		for (int i = 1; i < this.EKBLKEFHDPH.Length; i += 0)
		{
			OPLQGKOBBLB component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.HEEECPPFDFI).GetComponent<OPLQGKOBBLB>();
			component.QEKQQGPMIMJ = this;
			this.EKBLKEFHDPH[i] = component;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = false;
		this.LCIOCCKDBNK(1);
		this.UpdateButtons();
		this.FKCJGJGLFCK();
	}

	// Token: 0x06004DFD RID: 19965 RVA: 0x0001FBFD File Offset: 0x0001DDFD
	public void IPIEGGCLGLG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IDOKIIOQJOD(1);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06004DFE RID: 19966 RVA: 0x0001FC30 File Offset: 0x0001DE30
	public void GPQKFHFNDPM(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.HQGPFOGDOPJ(DBPKNCDGGEP);
		this.OOIQOJLDJHC(DBPKNCDGGEP);
	}

	// Token: 0x06004DFF RID: 19967 RVA: 0x0001FC46 File Offset: 0x0001DE46
	public void HKNJPGEBCJP(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.NFQOQOBDJEG(DBPKNCDGGEP);
		this.LCIOCCKDBNK(DBPKNCDGGEP);
	}

	// Token: 0x06004E00 RID: 19968 RVA: 0x0001FC5C File Offset: 0x0001DE5C
	public void NDPPNOHNDJK(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.PKOFMMGCGJO(DBPKNCDGGEP);
		this.ShowPokemon(DBPKNCDGGEP);
	}

	// Token: 0x06004E01 RID: 19969 RVA: 0x0001FC72 File Offset: 0x0001DE72
	public void LMBFMIBKDBF()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke(")", 106f);
	}

	// Token: 0x06004E02 RID: 19970 RVA: 0x0001FAB7 File Offset: 0x0001DCB7
	private void IPEEHKMMPCD()
	{
		EIDBQCPLPIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004E03 RID: 19971 RVA: 0x0001FC9B File Offset: 0x0001DE9B
	public void SelectPoke(int DBPKNCDGGEP)
	{
		this.NBNMENIJMLG = this.NFQOQOBDJEG(DBPKNCDGGEP);
		this.ShowPokemon(DBPKNCDGGEP);
	}

	// Token: 0x06004E04 RID: 19972 RVA: 0x0001FCB1 File Offset: 0x0001DEB1
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06004E05 RID: 19973 RVA: 0x0001FAB7 File Offset: 0x0001DCB7
	private void Awake()
	{
		EIDBQCPLPIL.HBFFCJHOCPE = this;
	}

	// Token: 0x06004E06 RID: 19974 RVA: 0x0028641C File Offset: 0x0028461C
	private static int NMJHPGMIKOB(EIDBQCPLPIL.BCCOLLOJIHM DGKOIGOLHDM, EIDBQCPLPIL.BCCOLLOJIHM DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.DBPKNCDGGEP.CompareTo(DDLQKFDFMCJ.DBPKNCDGGEP);
	}

	// Token: 0x06004E07 RID: 19975 RVA: 0x0028C870 File Offset: 0x0028AA70
	public void CDBCQNGKDHH()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC != string.Empty)
		{
			this.DMQGGHHMQEI();
			return;
		}
		float num = this.EDGCGMGCCDN.BGBMIEJJQKC * 345f;
		num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
		int num2 = (int)num;
		if (this.MKMBGGQNLHD.Count <= 1)
		{
			this.FKQOOJMNEJQ.value = true;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i += 0)
		{
			this.MKMBGGQNLHD[i].IMDFIPDOCKL = false;
		}
		for (int j = 1; j < this.EKBLKEFHDPH.Length; j++)
		{
			this.EKBLKEFHDPH[j].CBBOOJHHGDG();
		}
		if (!this.FKQOOJMNEJQ.value)
		{
			for (int k = 1; k < this.EKBLKEFHDPH.Length; k += 0)
			{
				if (num2 + k + 1 < -188)
				{
					int num3 = this.HQGPFOGDOPJ(num2 + k + 1);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[k].BQLIIQIIMDH(this.MKMBGGQNLHD[num3].POPFQHECGCH(), this.MKMBGGQNLHD[num3].OHNQLPGIOGK(), num2 + k + 0);
					}
					else
					{
						this.EKBLKEFHDPH[k].EDKDPDKIBJN(false, 0, num2 + k + 1);
					}
				}
			}
		}
		else
		{
			num = this.EDGCGMGCCDN.HKDJGHOHBFQ() * 1408f;
			num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
			num2 = (int)num;
			if (num2 > 0)
			{
				num2++;
			}
			int l = 0;
			IL_258:
			while (l < this.EKBLKEFHDPH.Length)
			{
				for (int m = 1; m < this.MKMBGGQNLHD.Count; m++)
				{
					if (this.MKMBGGQNLHD[m].DBPKNCDGGEP < 1 && this.MKMBGGQNLHD[m].DBPKNCDGGEP > 1 && m >= num2 && !this.MKMBGGQNLHD[m].BODPFNQELPP() && this.MKMBGGQNLHD[m].PLCBFLQBCQN > 1)
					{
						this.EKBLKEFHDPH[l].DOEGKLDPQKB(this.MKMBGGQNLHD[m].POPFQHECGCH(), this.MKMBGGQNLHD[m].PLCBFLQBCQN, this.MKMBGGQNLHD[m].MKEDHNEMKOI());
						this.MKMBGGQNLHD[m].CODDBCBCPCE(true);
						IL_252:
						l += 0;
						goto IL_258;
					}
				}
				goto IL_252;
			}
		}
	}

	// Token: 0x06004E08 RID: 19976 RVA: 0x0028CAE4 File Offset: 0x0028ACE4
	public void EOOQPCQBJGN()
	{
		this.PKBOPNPKQOG[1].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.LLOFFEKDOMI.OJQEOEIJDQG.PLLQOHPCBOP(824f);
		this.DGOGLKQMDFD[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = true;
		this.DGOGLKQMDFD[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
		this.DGOGLKQMDFD[1].GetComponent<BoxCollider>().enabled = false;
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x0028CB68 File Offset: 0x0028AD68
	public bool NDBDGEHHNEJ(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 0)
		{
			return false;
		}
		int num = this.NFQOQOBDJEG(CIQFCJGQEMH);
		return num > -1 && this.MKMBGGQNLHD[num].PDLHDNPGQID();
	}

	// Token: 0x06004E0A RID: 19978 RVA: 0x0001FCDA File Offset: 0x0001DEDA
	public void PJDKOCJPMIQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IDOKIIOQJOD(1);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.LMBFMIBKDBF();
		}
	}

	// Token: 0x06004E0B RID: 19979 RVA: 0x0028CB9C File Offset: 0x0028AD9C
	public void UpdateButtons()
	{
		if (this.NMBCHIIQLIH.BGBMIEJJQKC != string.Empty)
		{
			this.UpdateSearch();
			return;
		}
		float num = this.EDGCGMGCCDN.BGBMIEJJQKC * 803f;
		num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
		int num2 = (int)num;
		if (this.MKMBGGQNLHD.Count <= 0)
		{
			this.FKQOOJMNEJQ.value = false;
		}
		for (int i = 0; i < this.MKMBGGQNLHD.Count; i++)
		{
			this.MKMBGGQNLHD[i].IMDFIPDOCKL = false;
		}
		for (int j = 0; j < this.EKBLKEFHDPH.Length; j++)
		{
			this.EKBLKEFHDPH[j].Hide();
		}
		if (!this.FKQOOJMNEJQ.value)
		{
			for (int k = 0; k < this.EKBLKEFHDPH.Length; k++)
			{
				if (num2 + k + 1 < 803)
				{
					int num3 = this.NFQOQOBDJEG(num2 + k + 1);
					if (num3 > -1)
					{
						this.EKBLKEFHDPH[k].BQLIIQIIMDH(this.MKMBGGQNLHD[num3].PJNPEEFMLLM(), this.MKMBGGQNLHD[num3].PLCBFLQBCQN, num2 + k + 1);
					}
					else
					{
						this.EKBLKEFHDPH[k].BQLIIQIIMDH(false, 0, num2 + k + 1);
					}
				}
			}
		}
		else
		{
			num = this.EDGCGMGCCDN.BGBMIEJJQKC * 803f;
			num = Mathf.Round(num / this.OMGEPIDEIKI) * this.OMGEPIDEIKI;
			num2 = (int)num;
			if (num2 > 0)
			{
				num2++;
			}
			int l = 0;
			IL_258:
			while (l < this.EKBLKEFHDPH.Length)
			{
				for (int m = 0; m < this.MKMBGGQNLHD.Count; m++)
				{
					if (this.MKMBGGQNLHD[m].DBPKNCDGGEP < 803 && this.MKMBGGQNLHD[m].DBPKNCDGGEP > 0 && m >= num2 && !this.MKMBGGQNLHD[m].IMDFIPDOCKL && this.MKMBGGQNLHD[m].PLCBFLQBCQN > 0)
					{
						this.EKBLKEFHDPH[l].BQLIIQIIMDH(this.MKMBGGQNLHD[m].PJNPEEFMLLM(), this.MKMBGGQNLHD[m].PLCBFLQBCQN, this.MKMBGGQNLHD[m].DBPKNCDGGEP);
						this.MKMBGGQNLHD[m].IMDFIPDOCKL = true;
						IL_252:
						l++;
						goto IL_258;
					}
				}
				goto IL_252;
			}
		}
	}

	// Token: 0x06004E0C RID: 19980 RVA: 0x0028CE10 File Offset: 0x0028B010
	public void ShowPokemon(int DBPKNCDGGEP)
	{
		this.LLOFFEKDOMI.JMNEKDGHIIF();
		this.LLOFFEKDOMI.OJQEOEIJDQG.BGBMIEJJQKC = 0f;
		this.LLOFFEKDOMI.CPLBKPNNHJG();
		if (this.NBNMENIJMLG == -1)
		{
			this.QIGMLPOQOCB = -1;
			this.MLLOKPLECHK.SetActive(false);
			this.DOJIMNIKOBL[0].SetActive(false);
			this.DOJIMNIKOBL[1].SetActive(true);
			this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "???";
			this.DBQGICFJQKN.DIIHJCJOKMP = 0f;
			return;
		}
		this.QIGMLPOQOCB = DBPKNCDGGEP;
		this.DOJIMNIKOBL[0].SetActive(true);
		this.DOJIMNIKOBL[1].SetActive(false);
		this.MLLOKPLECHK.SetActive(true);
		this.QCPMCPEGJPO.transform.eulerAngles = new Vector3(0f, 180f, 0f);
		this.QCPMCPEGJPO.BQLIIQIIMDH(DBPKNCDGGEP, false, Vector3.zero, new Vector3(0f, 180f, 0f), null, "M");
		this.DBQGICFJQKN.DIIHJCJOKMP = 1f;
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "#" + DBPKNCDGGEP.DBFPJOCLQBI() + " " + KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Name;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Species;
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = string.Concat(new string[]
		{
			"Height: ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Height,
			"m\nWeight: ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Weight,
			"kg"
		});
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Description;
		this.LCKBBGCIPIE.CMIQOPQOMQF((float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPDEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK, (float)KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP);
		this.QHEJPNJNMCI[4].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVHP.ToString() + "\r\nHP";
		this.QHEJPNJNMCI[5].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVATK.ToString() + "\r\nATK";
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVDEF.ToString() + "\r\nDEF";
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPATK.ToString() + "\r\nSp. ATK";
		this.QHEJPNJNMCI[8].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPDEF.ToString() + "\r\nSp. DEF";
		this.QHEJPNJNMCI[9].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].EVSPD.ToString() + "\r\nSPD";
		this.NPKOJOFIDOD.OKFNHJPFIGB = string.Concat(new string[]
		{
			"Base Stats\n[d9b38c]ATK:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].ATK.ToString(),
			"\n[ffdb4d]DEF:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].DEF.ToString(),
			"\n[ff66cc]SPD:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPD.ToString(),
			"\n[668cff]SPATK:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPATK.ToString(),
			"\n[5cd65c]SPDEF:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].SPDEF.ToString(),
			"\n[ff6666]HP:[-] ",
			KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].HP.ToString()
		});
		foreach (BKKHLBCLPJM bkkhlbclpjm in this.EBKOKLMHBBF)
		{
			bkkhlbclpjm.PIDLOFMIEFQ = string.Empty;
		}
		this.EBKOKLMHBBF[0].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability1;
		this.EBKOKLMHBBF[1].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2;
		this.EBKOKLMHBBF[2].PIDLOFMIEFQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3;
		if (this.EBKOKLMHBBF[0].PIDLOFMIEFQ != "None")
		{
			this.EBKOKLMHBBF[3].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability1);
		}
		else
		{
			this.EBKOKLMHBBF[0].PIDLOFMIEFQ = "-";
		}
		if (this.EBKOKLMHBBF[1].PIDLOFMIEFQ != "None")
		{
			this.EBKOKLMHBBF[4].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability2);
		}
		else
		{
			this.EBKOKLMHBBF[1].PIDLOFMIEFQ = "-";
		}
		if (this.EBKOKLMHBBF[2].PIDLOFMIEFQ != "None")
		{
			this.EBKOKLMHBBF[5].PIDLOFMIEFQ = KGQECFKLKOP.NHNMKGHIKIB(KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Ability3);
		}
		else
		{
			this.EBKOKLMHBBF[2].PIDLOFMIEFQ = "-";
		}
		List<string> list = KGQECFKLKOP.PGEKKBDOHKH(DBPKNCDGGEP, 'L');
		if (list.Count > 0)
		{
			foreach (string pidlofmiefq in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq);
			}
		}
		list = KGQECFKLKOP.QBJGNLGDJIP(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("[33ccff]HMs[-]");
			foreach (string text in list)
			{
				if (KGQECFKLKOP.QKFBHKEDIHQ(text))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text);
				}
			}
		}
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("[33ccff]TMs[-]");
			foreach (string text2 in list)
			{
				if (!KGQECFKLKOP.QKFBHKEDIHQ(text2))
				{
					this.LLOFFEKDOMI.LHQECHHMOGD(text2);
				}
			}
		}
		list = KGQECFKLKOP.DMNQCIPOBKO(DBPKNCDGGEP);
		if (list.Count > 0)
		{
			this.LLOFFEKDOMI.LHQECHHMOGD(string.Empty);
			this.LLOFFEKDOMI.LHQECHHMOGD("[33ccff]Tutor[-]");
			foreach (string pidlofmiefq2 in list)
			{
				this.LLOFFEKDOMI.LHQECHHMOGD(pidlofmiefq2);
			}
		}
		double num = 90.0 * (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM * 0.01);
		if (num < 1.0)
		{
			num = 1.0;
		}
		if (num > 90.0)
		{
			num = 90.0;
		}
		this.QJMMHOGHQFG.KJGMGPCEJJD = (int)num;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM == 100.0)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 90;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1f, 1f, 1f, 1f);
		}
		else if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].RatioM <= 0.01)
		{
			this.QJMMHOGHQFG.KJGMGPCEJJD = 90;
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
		}
		else
		{
			this.QJMMHOGHQFG.CEGFBBHMKOE = new Color(1f, 1f, 1f, 1f);
		}
		this.FMKKFBQNBOB[0].KCLBMPFIPNQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type.ToLowerInvariant();
		this.FMKKFBQNBOB[0].DIIHJCJOKMP = 1f;
		if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.Length < 3)
		{
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 0f;
		}
		else
		{
			this.FMKKFBQNBOB[1].KCLBMPFIPNQ = KGQECFKLKOP.DDBIKNCLDGI.Pokemon[DBPKNCDGGEP].Type2.ToLowerInvariant();
			this.FMKKFBQNBOB[1].DIIHJCJOKMP = 1f;
		}
	}

	// Token: 0x040010AF RID: 4271
	private static EIDBQCPLPIL HBFFCJHOCPE;

	// Token: 0x040010B0 RID: 4272
	public BKKHLBCLPJM[] QHEJPNJNMCI;

	// Token: 0x040010B1 RID: 4273
	public FICELJKFLNK LCKBBGCIPIE;

	// Token: 0x040010B2 RID: 4274
	public CPLHOLGBMKB NPKOJOFIDOD;

	// Token: 0x040010B3 RID: 4275
	public JIMBBPLINGI NMBCHIIQLIH;

	// Token: 0x040010B4 RID: 4276
	public KDIEKDCQIHM EDGCGMGCCDN;

	// Token: 0x040010B5 RID: 4277
	public UIToggle FKQOOJMNEJQ;

	// Token: 0x040010B6 RID: 4278
	public PLQFPBQEPJD QJMMHOGHQFG;

	// Token: 0x040010B7 RID: 4279
	public PLQFPBQEPJD[] FMKKFBQNBOB;

	// Token: 0x040010B8 RID: 4280
	public GameObject HEEECPPFDFI;

	// Token: 0x040010B9 RID: 4281
	public OPLQGKOBBLB[] EKBLKEFHDPH;

	// Token: 0x040010BA RID: 4282
	public GameObject[] DOJIMNIKOBL;

	// Token: 0x040010BB RID: 4283
	public BKKHLBCLPJM JLHPHHIMLFL;

	// Token: 0x040010BC RID: 4284
	public BKKHLBCLPJM BEHECPNMGEJ;

	// Token: 0x040010BD RID: 4285
	public GameObject[] PKBOPNPKQOG;

	// Token: 0x040010BE RID: 4286
	public BMLIGLPMMLG LLOFFEKDOMI;

	// Token: 0x040010BF RID: 4287
	public List<EIDBQCPLPIL.BCCOLLOJIHM> MKMBGGQNLHD = new List<EIDBQCPLPIL.BCCOLLOJIHM>();

	// Token: 0x040010C0 RID: 4288
	public int HNIDIBLCJBM = 40;

	// Token: 0x040010C1 RID: 4289
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x040010C2 RID: 4290
	public BKKHLBCLPJM[] EBKOKLMHBBF;

	// Token: 0x040010C3 RID: 4291
	private int NBNMENIJMLG = -1;

	// Token: 0x040010C4 RID: 4292
	public CFDMNELIJLO[] DGOGLKQMDFD;

	// Token: 0x040010C5 RID: 4293
	public bool LELFDOQONPD;

	// Token: 0x040010C6 RID: 4294
	private int QIGMLPOQOCB = -1;

	// Token: 0x040010C7 RID: 4295
	public FINHCKBDLMF QCPMCPEGJPO;

	// Token: 0x040010C8 RID: 4296
	public GameObject MLLOKPLECHK;

	// Token: 0x040010C9 RID: 4297
	public JLMPBLMOICG DBQGICFJQKN;

	// Token: 0x040010CA RID: 4298
	public float OMGEPIDEIKI = 5f;

	// Token: 0x040010CB RID: 4299
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x040010CC RID: 4300
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x040010CD RID: 4301
	[CompilerGenerated]
	private static Comparison<EIDBQCPLPIL.BCCOLLOJIHM> HNCJFHJNHDN;

	// Token: 0x040010CE RID: 4302
	[CompilerGenerated]
	private static Comparison<EIDBQCPLPIL.BCCOLLOJIHM> BIJFPHIBEDK;

	// Token: 0x0200023B RID: 571
	public class BCCOLLOJIHM
	{
		// Token: 0x06004E0D RID: 19981 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		public bool PIPQDQLNEFC()
		{
			return this.<QOLDPOCNPQH>k__BackingField;
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x0001FD15 File Offset: 0x0001DF15
		public int MKEDHNEMKOI()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x0001FD1D File Offset: 0x0001DF1D
		public int OHNQLPGIOGK()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		public bool JMEPEGBGDKG()
		{
			return this.<QOLDPOCNPQH>k__BackingField;
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x0001FD25 File Offset: 0x0001DF25
		public void LNENHBGICIC(int BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x0001FD2E File Offset: 0x0001DF2E
		public bool BJMDOIIODND()
		{
			return this.PLCBFLQBCQN == 1 || this.OHNQLPGIOGK() == 7;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x0001FD45 File Offset: 0x0001DF45
		public bool BCLCQOPMJLP()
		{
			return this.PLCBFLQBCQN == 0;
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x0001FD50 File Offset: 0x0001DF50
		public bool POPFQHECGCH()
		{
			return this.OHNQLPGIOGK() == 4;
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x0001FD5B File Offset: 0x0001DF5B
		public bool BLLCKJPNHKK()
		{
			return this.PLCBFLQBCQN == 8;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06004E2B RID: 20011 RVA: 0x0001FD15 File Offset: 0x0001DF15
		// (set) Token: 0x06004E16 RID: 19990 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public int DBPKNCDGGEP { get; set; }

		// Token: 0x06004E17 RID: 19991 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		public bool OBNBMHFPFOB()
		{
			return this.<QOLDPOCNPQH>k__BackingField;
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x0001FD6F File Offset: 0x0001DF6F
		public bool LEPEGIECIBB()
		{
			return this.PLCBFLQBCQN == 6 || this.PLCBFLQBCQN == 3;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x0001FD1D File Offset: 0x0001DF1D
		// (set) Token: 0x06004E3A RID: 20026 RVA: 0x0001FD25 File Offset: 0x0001DF25
		public int PLCBFLQBCQN { get; set; }

		// Token: 0x06004E1A RID: 19994 RVA: 0x0001FD86 File Offset: 0x0001DF86
		public bool PJNPEEFMLLM()
		{
			return this.PLCBFLQBCQN == 3;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x0001FD91 File Offset: 0x0001DF91
		public bool PDLHDNPGQID()
		{
			return this.PLCBFLQBCQN == 2 || this.PLCBFLQBCQN == 3;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void MQFCPNENMFP(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x0001FD45 File Offset: 0x0001DF45
		public bool QKNBEPDOJML()
		{
			return this.PLCBFLQBCQN == 0;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void MPEFIQNFEKH(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x0001FDB1 File Offset: 0x0001DFB1
		public bool QFHKHBIJEFQ()
		{
			return this.PLCBFLQBCQN == 1;
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void CODDBCBCPCE(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public void BPDOKQQEMBI(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x0001FDB1 File Offset: 0x0001DFB1
		public bool LBCQKBMGPMK()
		{
			return this.PLCBFLQBCQN == 1;
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x0001FDDA File Offset: 0x0001DFDA
		public bool DCNENLQLCPF()
		{
			return this.PLCBFLQBCQN == 2 || this.OHNQLPGIOGK() == 6;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x0001FD15 File Offset: 0x0001DF15
		public int QBIFLEJHBCD()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x0001FD45 File Offset: 0x0001DF45
		public bool LGQGLDNEBBP()
		{
			return this.PLCBFLQBCQN == 0;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public void KCJNDMPOJGF(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		public bool BODPFNQELPP()
		{
			return this.<QOLDPOCNPQH>k__BackingField;
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0001FD25 File Offset: 0x0001DF25
		public void FBMHFBGBPPQ(int BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x0001FD15 File Offset: 0x0001DF15
		public int NNKDGMIDHIG()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		// (set) Token: 0x06004E36 RID: 20022 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public bool IMDFIPDOCKL { get; set; }

		// Token: 0x06004E2D RID: 20013 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public void QKIHFDGLQKG(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void HPKMGNPCHNH(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x0001FDF1 File Offset: 0x0001DFF1
		public bool HLEOOIEPGPP()
		{
			return this.OHNQLPGIOGK() == 1;
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public void PCIICKJBGJG(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0001FDFC File Offset: 0x0001DFFC
		public bool FPEGDLDQOJE()
		{
			return this.OHNQLPGIOGK() == 1 || this.PLCBFLQBCQN == 3;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void DEHODNOBILD(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x0001FD25 File Offset: 0x0001DF25
		public void GCDDCGNPJMO(int BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0001FD66 File Offset: 0x0001DF66
		public void HEQJPMEPKDB(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void MQEOHGLFMOJ(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public void EGELDFLMFIO(bool BGBMIEJJQKC)
		{
			this.<QOLDPOCNPQH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x0001FD0D File Offset: 0x0001DF0D
		public bool QBJMCLNQCEM()
		{
			return this.<QOLDPOCNPQH>k__BackingField;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x0001FD45 File Offset: 0x0001DF45
		public bool OPMFNONQMBI()
		{
			return this.PLCBFLQBCQN == 0;
		}

		// Token: 0x040010D2 RID: 4306
		public List<string> MCMEIDQJOKG = new List<string>();

		// Token: 0x040010D3 RID: 4307
		public List<string> EEILBMOOJHJ = new List<string>();
	}
}
