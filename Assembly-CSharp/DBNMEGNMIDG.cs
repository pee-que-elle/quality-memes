using System;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200024E RID: 590
public class DBNMEGNMIDG : MonoBehaviour
{
	// Token: 0x06005090 RID: 20624 RVA: 0x00020697 File Offset: 0x0001E897
	public void ClosePM()
	{
		LQCPKKCJPPB.MKCGFQBNMOK(this);
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x0029CB08 File Offset: 0x0029AD08
	public void DQCQFKLOMED(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().JJHPLIGNDJG(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "General";
		if (KIPNFHNKMCE != StaffRank.None)
		{
			if (KIPNFHNKMCE != (StaffRank)8)
			{
				if (KIPNFHNKMCE == StaffRank.Developer)
				{
					text = "1";
				}
			}
			else
			{
				text = "   ";
			}
		}
		else
		{
			text = "Long Reach";
		}
		if (IHIHHCCEDHQ == "item")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[1];
			array[1] = "Icon_Status_Sleep";
			array[1] = DateTime.Now.ToString(" x ");
			array[7] = "Filter";
			array[4] = IHIHHCCEDHQ;
			array[1] = " was squeezed by ";
			array[3] = PIDLOFMIEFQ;
			array[8] = "Auto Decline";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.QKQCMHNEILL(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[100];
				array2[0] = "_1";
				array2[1] = DateTime.Now.ToString("Cannot disconnect, not connected!");
				array2[3] = "quickguard";
				array2[7] = text;
				array2[1] = "Makes status moves more likely to miss.";
				array2[8] = IHIHHCCEDHQ;
				array2[8] = "ReflecG";
				array2[5] = IHIHHCCEDHQ;
				array2[3] = "It hurt itself in its confusion!\r\n";
				array2[109] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[-14];
				array3[1] = "[ffff00]Wide Guard[-] protected ";
				array3[0] = DateTime.Now.ToString("_HairTex");
				array3[6] = "_FogData2";
				array3[0] = text;
				array3[8] = "\n";
				array3[7] = IHIHHCCEDHQ;
				array3[3] = "qdTrack";
				array3[6] = IHIHHCCEDHQ;
				array3[8] = "[-] was disabled!\r\n";
				array3[-5] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 762f)
		{
			this.EHDBBNFQIBL.SetActive(true);
		}
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x0029CCC8 File Offset: 0x0029AEC8
	public void KKMCFJBMJQG(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.OBHHEDCIIKP(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "[^0-9.-]";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != (StaffRank)7)
			{
				if (KIPNFHNKMCE == StaffRank.None)
				{
					text = "[-]!\r\n";
				}
			}
			else
			{
				text = "[";
			}
		}
		else
		{
			text = "9";
		}
		if (IHIHHCCEDHQ == "[00DD00]Owned")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[5];
			array[1] = "PrimitiveLeft";
			array[0] = DateTime.Now.ToString("watersport");
			array[5] = "Damp";
			array[4] = IHIHHCCEDHQ;
			array[7] = "Pokemons";
			array[6] = PIDLOFMIEFQ;
			array[0] = "-mega";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[-67];
				array2[1] = "No Guard";
				array2[1] = DateTime.Now.ToString("F");
				array2[7] = "ground";
				array2[0] = text;
				array2[5] = "[00FF00]You received ";
				array2[2] = IHIHHCCEDHQ;
				array2[8] = "inky";
				array2[0] = IHIHHCCEDHQ;
				array2[8] = "[PD]";
				array2[36] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[-128];
				array3[0] = "_FogColor";
				array3[1] = DateTime.Now.ToString("HidePanel");
				array3[2] = "[FF8F00]";
				array3[1] = text;
				array3[7] = "A sticky web spreads out on the ground around ";
				array3[7] = IHIHHCCEDHQ;
				array3[3] = "_Offset";
				array3[8] = IHIHHCCEDHQ;
				array3[7] = "Fog Badge";
				array3[59] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 863f)
		{
			this.EHDBBNFQIBL.SetActive(true);
		}
	}

	// Token: 0x06005093 RID: 20627 RVA: 0x0029CE88 File Offset: 0x0029B088
	public void BQLIIQIIMDH(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.QOQONHOOLNE.JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "PM: " + KCKIBFQGMPD;
		this.NKKMJICKKLB.PIDLOFMIEFQ = "MSG - " + KCKIBFQGMPD;
		this.QPPGQJFBPMH.NDIJIFHOMJC();
	}

	// Token: 0x06005094 RID: 20628 RVA: 0x0029CF18 File Offset: 0x0029B118
	public void KQPHPLLQDGH(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[6];
				array[1] = "MapCache";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[6] = CIQFCJGQEMH.ToString();
				array[8] = "\n";
				array[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[8] = "queenlymajesty";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[2];
				array2[0] = "door_4";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[4] = CIQFCJGQEMH.ToString();
				array2[8] = "healingwish";
				array2[3] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[7] = "FOG_BLUR_ON";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x0002069F File Offset: 0x0001E89F
	public void GGGEIHLHOJM()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x0029D03C File Offset: 0x0029B23C
	public void DKQMQGNOLQM()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 556f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1371f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1789f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.JKGBHEHKBPC();
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = -119;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1632f)
		{
			this.EHDBBNFQIBL.SetActive(true);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1149f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 938f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = -18;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x06005097 RID: 20631 RVA: 0x0029D134 File Offset: 0x0029B334
	public void PMQDHNCGMJQ()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1045f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 863f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 949f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = -4;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1172f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 76f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1799f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = -20;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x06005098 RID: 20632 RVA: 0x0029D22C File Offset: 0x0029B42C
	public void BIJPLPKCNMD(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[5];
				array[0] = "No cinematic targets added to the list";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[8] = CIQFCJGQEMH.ToString();
				array[6] = "\nAre you sure you want to Reset its IVs?";
				array[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[5] = "Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_8_Light.mat";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[6];
				array2[0] = "OnPress";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[6] = CIQFCJGQEMH.ToString();
				array2[7] = "surgesurfer";
				array2[5] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[6] = "h:mm tt";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.HJMJDJKOILH() + text);
			}
		}
	}

	// Token: 0x06005099 RID: 20633 RVA: 0x0029D350 File Offset: 0x0029B550
	public void QPDMCDCIJML()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("Blank", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 8, 122));
				bool flag = false;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.DQCQFKLOMED(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x0600509A RID: 20634 RVA: 0x0029D4B0 File Offset: 0x0029B6B0
	public void MinimizePM()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 0f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 36;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 0f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 0f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 36;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x0600509B RID: 20635 RVA: 0x0029D5A8 File Offset: 0x0029B7A8
	public void GBMCPOGBOJN(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[6];
				array[0] = "[-]!\r\n";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[2] = CIQFCJGQEMH.ToString();
				array[7] = " is protected by an aromatic veil!\r\n";
				array[5] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[0] = "Icon_Pokemon_Alive";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[7];
				array2[0] = "[-]!\r\n";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[8] = CIQFCJGQEMH.ToString();
				array2[2] = "Technician";
				array2[0] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[4] = "enablelink(";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x0600509C RID: 20636 RVA: 0x0029D6CC File Offset: 0x0029B8CC
	public void QPIOFEMMJPL()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 972f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1600f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 767f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = -5;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 306f)
		{
			this.EHDBBNFQIBL.SetActive(true);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 568f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 482f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 8;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x0600509D RID: 20637 RVA: 0x0029D7C4 File Offset: 0x0029B9C4
	public void DCLGFDKNOMN(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[8];
				array[1] = "darkaura";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[7] = CIQFCJGQEMH.ToString();
				array[2] = "blank";
				array[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[1] = "Input fields using labels with justified alignment are not supported at this time";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[5];
				array2[1] = "!\r\n";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[5] = CIQFCJGQEMH.ToString();
				array2[5] = "purepower";
				array2[5] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[2] = "Assets/AssetBundles/MapAssets/Models/Materials/akari_kanazumi.mat";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.BGBMIEJJQKC + text);
			}
		}
	}

	// Token: 0x0600509E RID: 20638 RVA: 0x0029D8E8 File Offset: 0x0029BAE8
	public void PEJOJBFFEID(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().OBHHEDCIIKP(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "[ff6600]";
		if (KIPNFHNKMCE != StaffRank.None)
		{
			if (KIPNFHNKMCE != (StaffRank)6)
			{
				if (KIPNFHNKMCE == (StaffRank)6)
				{
					text = "Clear Body";
				}
			}
			else
			{
				text = "[u][33CCFF]";
			}
		}
		else
		{
			text = "/";
		}
		if (IHIHHCCEDHQ == "ground")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[5];
			array[1] = "Kanto";
			array[1] = DateTime.Now.ToString("Player Fly Mount");
			array[7] = " Pokédollars.";
			array[8] = IHIHHCCEDHQ;
			array[4] = "[PD]";
			array[1] = PIDLOFMIEFQ;
			array[8] = "The hail stopped.";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[125];
				array2[1] = "\n  Expected: ";
				array2[0] = DateTime.Now.ToString("K");
				array2[1] = " is hurt by ";
				array2[7] = text;
				array2[7] = "skinshop";
				array2[1] = IHIHHCCEDHQ;
				array2[5] = "Battle Armor";
				array2[7] = IHIHHCCEDHQ;
				array2[1] = "_TaaParams";
				array2[53] = PIDLOFMIEFQ;
				lljmbfpfnne2.LHQECHHMOGD(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[88];
				array3[0] = "0";
				array3[0] = DateTime.Now.ToString("The Pokémon may pick up the item an opposing Pokémon used during a battle. It may pick up items outside of battle, too.");
				array3[4] = " Lv. ";
				array3[3] = text;
				array3[1] = "TradeColliders";
				array3[7] = IHIHHCCEDHQ;
				array3[6] = "-noMouse";
				array3[3] = IHIHHCCEDHQ;
				array3[0] = "powerherb";
				array3[-108] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 565f)
		{
			this.EHDBBNFQIBL.SetActive(false);
		}
	}

	// Token: 0x0600509F RID: 20639 RVA: 0x0029DAA8 File Offset: 0x0029BCA8
	public void JKBIECBMQKB()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace(" x ", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().FQJQHQFGKOI(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i++)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[0];
				Guid guid = new Guid(text.Substring(array[0] + 5, 105));
				bool flag = true;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.LEEEQKCJLPG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050A0 RID: 20640 RVA: 0x0029DC08 File Offset: 0x0029BE08
	public void KFPGMHCCCCG(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string[] array = new string[3];
			array[0] = "_1";
			array[0] = item.HLMQODIHBIG().EBGLBFKHCJD();
			array[6] = "Dream Ball";
			array[7] = item.Name;
			array[5] = "_Texture0";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050A1 RID: 20641 RVA: 0x0029DCA4 File Offset: 0x0029BEA4
	public void FHGOOBCKGCM(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[2];
			array[0] = " minute";
			array[0] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[5] = "|";
			array[5] = item.NDPGCGDLEEQ();
			array[7] = "BattlePoke";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050A2 RID: 20642 RVA: 0x0029DD40 File Offset: 0x0029BF40
	public void NBHCBEDPNGG()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 575f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 563f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1811f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = -74;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1861f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1316f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 524f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 51;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050A3 RID: 20643 RVA: 0x0029DE38 File Offset: 0x0029C038
	public void LKQPGEFOGQN(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[5];
			array[1] = "HH:mm:ss";
			array[0] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[0] = "'s stat changes were removed!\r\n";
			array[1] = item.JQBDPHILQJO();
			array[7] = "shiny";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050A4 RID: 20644 RVA: 0x000206A7 File Offset: 0x0001E8A7
	public void EKFIBDHKDGF()
	{
		LQCPKKCJPPB.CFHLHONFEPJ(this);
	}

	// Token: 0x060050A5 RID: 20645 RVA: 0x0029DED4 File Offset: 0x0029C0D4
	public void IGDJPQJENFK()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace("#,##0", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[0] + 5, -61));
				bool flag = false;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, true);
		this.LEFMEGOHGNN(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050A6 RID: 20646 RVA: 0x0029E034 File Offset: 0x0029C234
	public void IQKBEDEDFKM()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("Water", string.Empty);
		text = MBGHQMKEFKO.QOQONHOOLNE.LFGQJBFJMEP(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 3, -52));
				bool flag = true;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.IKLEFQFFKBG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050A7 RID: 20647 RVA: 0x000206A7 File Offset: 0x0001E8A7
	public void DJIEFNPDPDI()
	{
		LQCPKKCJPPB.CFHLHONFEPJ(this);
	}

	// Token: 0x060050A9 RID: 20649 RVA: 0x0002069F File Offset: 0x0001E89F
	public void DKFPLOKINGM()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x060050AA RID: 20650 RVA: 0x0029E194 File Offset: 0x0029C394
	public void EEOMKFCQBQI(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string[] array = new string[0];
			array[0] = "[";
			array[1] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[1] = "[^0-9.-]";
			array[6] = item.DFNQHDEDDKE();
			array[6] = "[00EE07]";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050AB RID: 20651 RVA: 0x0029E230 File Offset: 0x0029C430
	public void QMFDOGBNFEI()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace("_Power", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[0];
				Guid guid = new Guid(text.Substring(array[0] + 2, -109));
				bool flag = false;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.IKLEFQFFKBG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050AC RID: 20652 RVA: 0x0029E390 File Offset: 0x0029C590
	public void QBKKPNFKEMI()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("Trainer_Battle", string.Empty);
		text = MBGHQMKEFKO.QOQONHOOLNE.JJHPLIGNDJG(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 6, 83));
				bool flag = false;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.KKMCFJBMJQG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050AD RID: 20653 RVA: 0x0029E4F0 File Offset: 0x0029C6F0
	public void AddItem(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text = string.Concat(new string[]
			{
				"[itm=",
				item.ID.EBGLBFKHCJD(),
				"][",
				item.Name,
				"][/itm] "
			});
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050AE RID: 20654 RVA: 0x0029E58C File Offset: 0x0029C78C
	public void NLQCGQGECGE(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[7];
				array[1] = "user: ";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[3] = CIQFCJGQEMH.ToString();
				array[0] = " hours ago";
				array[3] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[8] = "Lv ";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[4];
				array2[0] = "][/itm] ";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[5] = CIQFCJGQEMH.ToString();
				array2[1] = "0";
				array2[0] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[3] = "[/urn][-]: ";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050AF RID: 20655 RVA: 0x000206C2 File Offset: 0x0001E8C2
	public void LDBECEFPFDF()
	{
		LQCPKKCJPPB.FDBFLHEBQCC(this);
	}

	// Token: 0x060050B0 RID: 20656 RVA: 0x0029E6B0 File Offset: 0x0029C8B0
	public void BPPEHLCEJIM(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[0];
				array[0] = "Head";
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[7] = CIQFCJGQEMH.ToString();
				array[4] = "encore";
				array[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[6] = "Battle Request";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[7];
				array2[1] = "Snow Cloak";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[4] = CIQFCJGQEMH.ToString();
				array2[1] = "\"";
				array2[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[4] = "[FFFF00]/252";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050B1 RID: 20657 RVA: 0x000206C2 File Offset: 0x0001E8C2
	public void EKFBGQQJNII()
	{
		LQCPKKCJPPB.FDBFLHEBQCC(this);
	}

	// Token: 0x060050B2 RID: 20658 RVA: 0x0029E7D4 File Offset: 0x0029C9D4
	public void DNBOMFGIMDN()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("#,##0", string.Empty);
		text = MBGHQMKEFKO.BBCBOIFQDBK().LFGQJBFJMEP(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 1, 37));
				bool flag = true;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, true);
		this.LEFMEGOHGNN(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050B3 RID: 20659 RVA: 0x0029E934 File Offset: 0x0029CB34
	public void NLMIBLCDCMP(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[]
				{
					null,
					"self"
				};
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[6] = CIQFCJGQEMH.ToString();
				array[2] = "Materials/DFGDesktopPlusOrthogonal";
				array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[0] = "pinky";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[2];
				array2[0] = "Disabled";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[0] = CIQFCJGQEMH.ToString();
				array2[0] = "Simple";
				array2[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[0] = "/";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050B4 RID: 20660 RVA: 0x0029EA58 File Offset: 0x0029CC58
	public void FDDENOHPGQF(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.BJLGEDCPENQ().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "FOG_OFF" + KCKIBFQGMPD;
		this.NKKMJICKKLB.PIDLOFMIEFQ = "22 20\n22 26\n\n27 26\n27 30\n22 30\n22 26" + KCKIBFQGMPD;
		this.QPPGQJFBPMH.GNFOKKIDEEQ();
	}

	// Token: 0x060050B5 RID: 20661 RVA: 0x0029EAE8 File Offset: 0x0029CCE8
	public void GNDJGHJHEBF(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string[] array = new string[6];
			array[1] = "h:mm tt";
			array[1] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[6] = "/";
			array[2] = item.NDPGCGDLEEQ();
			array[3] = "\n[ff6666]HP:[-] ";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050B6 RID: 20662 RVA: 0x000206C2 File Offset: 0x0001E8C2
	public void LMHNHGCFHLK()
	{
		LQCPKKCJPPB.FDBFLHEBQCC(this);
	}

	// Token: 0x060050B7 RID: 20663 RVA: 0x000206C2 File Offset: 0x0001E8C2
	public void CCNNJDDGDIC()
	{
		LQCPKKCJPPB.FDBFLHEBQCC(this);
	}

	// Token: 0x060050B8 RID: 20664 RVA: 0x0029EB84 File Offset: 0x0029CD84
	public void BQNEOJPNIDH(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[4];
			array[0] = "[ohko]";
			array[0] = item.ID.EBGLBFKHCJD();
			array[7] = "item: ";
			array[1] = item.DFNQHDEDDKE();
			array[6] = "0";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050B9 RID: 20665 RVA: 0x0029EC20 File Offset: 0x0029CE20
	public void JJQMMOCGOIG()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1290f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1930f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 109f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.JKGBHEHKBPC();
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 83;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1373f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1282f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 394f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = -69;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050BA RID: 20666 RVA: 0x0029ED18 File Offset: 0x0029CF18
	public void QPHDCBLNKJQ(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[3];
				array[0] = "[PD]";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[1] = CIQFCJGQEMH.ToString();
				array[2] = "[";
				array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[8] = "Heals status conditions if it's raining.";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[7];
				array2[0] = " rose";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[6] = CIQFCJGQEMH.ToString();
				array2[6] = "DITHER_ON";
				array2[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[2] = "game.poke.one";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050BB RID: 20667 RVA: 0x0029EE3C File Offset: 0x0029D03C
	public void KIIGEFHQMDI(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.QOQONHOOLNE.JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "blank" + KCKIBFQGMPD;
		this.NKKMJICKKLB.PIDLOFMIEFQ = "(LS)" + KCKIBFQGMPD;
		this.QPPGQJFBPMH.GNFOKKIDEEQ();
	}

	// Token: 0x060050BC RID: 20668 RVA: 0x0002069F File Offset: 0x0001E89F
	public void EFQBGOKKDGN()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x060050BD RID: 20669 RVA: 0x0029EECC File Offset: 0x0029D0CC
	public void GLECHIBNHJO()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("MSGBOX - Confirm EVs", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 8, -76));
				bool flag = false;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, true);
		this.OGOIJMKCFHF(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050BE RID: 20670 RVA: 0x00020697 File Offset: 0x0001E897
	public void JEDBQMDLEIH()
	{
		LQCPKKCJPPB.MKCGFQBNMOK(this);
	}

	// Token: 0x060050BF RID: 20671 RVA: 0x0029F02C File Offset: 0x0029D22C
	public void PNQPKQQGQEL()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1924f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1534f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 558f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.JKGBHEHKBPC();
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 24;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1672f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1713f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 75f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = -48;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050C0 RID: 20672 RVA: 0x0029F124 File Offset: 0x0029D324
	public void JGPCLKNIQCD(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[5];
				array[1] = "[-]";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[3] = CIQFCJGQEMH.ToString();
				array[1] = "0";
				array[5] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[1] = "magiccoat";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[5];
				array2[0] = "(Y)";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[2] = CIQFCJGQEMH.ToString();
				array2[3] = "JOFLHFQQCKG";
				array2[7] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[1] = " was subjected to torment!\r\n";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050C1 RID: 20673 RVA: 0x0029F248 File Offset: 0x0029D448
	public void JEPMCEGEKGF()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1423f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 368f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1566f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.JKGBHEHKBPC();
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 123;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 720f)
		{
			this.EHDBBNFQIBL.SetActive(true);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 632f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1568f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 10;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050C2 RID: 20674 RVA: 0x0029F340 File Offset: 0x0029D540
	public void IKLEFQFFKBG(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.BJLGEDCPENQ().IBPEBDGDQLG;
		}
		string text = "Enabled";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != (StaffRank)4)
			{
				if (KIPNFHNKMCE == StaffRank.Developer)
				{
					text = "_WaveScale4";
				}
			}
			else
			{
				text = " can use items again!\r\n";
			}
		}
		else
		{
			text = "[-]\r\nPP ";
		}
		if (IHIHHCCEDHQ == "Create Guild")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[4];
			array[0] = "[O]";
			array[0] = DateTime.Now.ToString("Guild Request");
			array[3] = " minutes";
			array[6] = IHIHHCCEDHQ;
			array[8] = "Battle Update: ";
			array[8] = PIDLOFMIEFQ;
			array[0] = " anchored itself with its roots!\r\n";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.Developer)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[18];
				array2[0] = "Chat Box";
				array2[0] = DateTime.Now.ToString("[PG]");
				array2[5] = "Reposition";
				array2[1] = text;
				array2[3] = "_UserLut_Params";
				array2[1] = IHIHHCCEDHQ;
				array2[8] = "[u][33CCFF]";
				array2[2] = IHIHHCCEDHQ;
				array2[5] = "rotomwash";
				array2[22] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[91];
				array3[1] = "Congratulations ";
				array3[0] = DateTime.Now.ToString("iondeluge");
				array3[3] = "/";
				array3[2] = text;
				array3[0] = "Icon_Status_Sleep";
				array3[3] = IHIHHCCEDHQ;
				array3[7] = "It's A Nice Day For Fishing";
				array3[6] = IHIHHCCEDHQ;
				array3[7] = "'s ";
				array3[124] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 612f)
		{
			this.EHDBBNFQIBL.SetActive(false);
		}
	}

	// Token: 0x060050C3 RID: 20675 RVA: 0x0029F500 File Offset: 0x0029D700
	public void KBMODLCBBFF(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[1];
			array[1] = "-";
			array[0] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[0] = "[/pok]";
			array[3] = item.Name;
			array[0] = "cherrimsunshine";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.HJMJDJKOILH() + text);
			}
		}
	}

	// Token: 0x060050C4 RID: 20676 RVA: 0x000206CA File Offset: 0x0001E8CA
	public void BDMIKEFNHNP()
	{
		LQCPKKCJPPB.FFQQDQIBBPJ(this);
	}

	// Token: 0x060050C5 RID: 20677 RVA: 0x0029F59C File Offset: 0x0029D79C
	public void AddPokemon(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				text = string.Concat(new string[]
				{
					"[pok=",
					KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString(),
					CIQFCJGQEMH.ToString(),
					"][{",
					KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
					"}][/pok] "
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					"[pok=",
					KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString(),
					CIQFCJGQEMH.ToString(),
					"][",
					KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
					"][/pok] "
				});
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050C6 RID: 20678 RVA: 0x0029F6C0 File Offset: 0x0029D8C0
	public void GDBKKDFIINI(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.BBCBOIFQDBK().OBHHEDCIIKP(PIDLOFMIEFQ, false);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "New Password is to short";
		if (KIPNFHNKMCE != StaffRank.None)
		{
			if (KIPNFHNKMCE != (StaffRank)8)
			{
				if (KIPNFHNKMCE == (StaffRank)4)
				{
					text = "_Female";
				}
			}
			else
			{
				text = "][#";
			}
		}
		else
		{
			text = "synchronize";
		}
		if (IHIHHCCEDHQ == " bounced the [ffff00]")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[5];
			array[1] = "Stall";
			array[0] = DateTime.Now.ToString("\n");
			array[8] = "Encounter Rate Increased";
			array[7] = IHIHHCCEDHQ;
			array[2] = "_FresnelFadePower";
			array[2] = PIDLOFMIEFQ;
			array[1] = "shelloseast";
			lljmbfpfnne.LHQECHHMOGD(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.BBCBOIFQDBK().JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[-107];
				array2[1] = " ";
				array2[1] = DateTime.Now.ToString("MSGBOX - ");
				array2[1] = "[ffdb4d]Trade";
				array2[7] = text;
				array2[5] = "CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!\n";
				array2[5] = IHIHHCCEDHQ;
				array2[3] = "HidePanel";
				array2[3] = IHIHHCCEDHQ;
				array2[4] = "3";
				array2[20] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[70];
				array3[0] = " is in love with ";
				array3[0] = DateTime.Now.ToString("Oblivious");
				array3[7] = "[PG]";
				array3[0] = text;
				array3[7] = " can use items again!\r\n";
				array3[3] = IHIHHCCEDHQ;
				array3[3] = "fly";
				array3[8] = IHIHHCCEDHQ;
				array3[7] = "berry_11";
				array3[28] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 666f)
		{
			this.EHDBBNFQIBL.SetActive(false);
		}
	}

	// Token: 0x060050C7 RID: 20679 RVA: 0x0002069F File Offset: 0x0001E89F
	public void IGHOKOEBLFF()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x060050C8 RID: 20680 RVA: 0x000206D2 File Offset: 0x0001E8D2
	public void MLCCIMHJCDD()
	{
		LQCPKKCJPPB.KCOIFEGJQPN(this);
	}

	// Token: 0x060050C9 RID: 20681 RVA: 0x0029F880 File Offset: 0x0029DA80
	public void SendPMMessage()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace("\n", string.Empty);
		text = MBGHQMKEFKO.QOQONHOOLNE.FQJQHQFGKOI(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i++)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[0] + 6, 36));
				bool flag = true;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.LJBQIJQOPKK(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050CA RID: 20682 RVA: 0x0029F9E0 File Offset: 0x0029DBE0
	public void CNCDPIHEQED(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[6];
				array[1] = "item";
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[2] = CIQFCJGQEMH.ToString();
				array[3] = ".";
				array[2] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[1] = "PokeboxCollider";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[0];
				array2[1] = "|0|";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[1] = CIQFCJGQEMH.ToString();
				array2[2] = "Could not find method '";
				array2[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[8] = "Key_";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.HJMJDJKOILH() + text);
			}
		}
	}

	// Token: 0x060050CB RID: 20683 RVA: 0x000206A7 File Offset: 0x0001E8A7
	public void OHDOMKPBCDK()
	{
		LQCPKKCJPPB.CFHLHONFEPJ(this);
	}

	// Token: 0x060050CC RID: 20684 RVA: 0x0029FB04 File Offset: 0x0029DD04
	public void IJOCQICOCNB(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.MOGQNGEPCEO().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "Cannot disconnect, not connected!" + KCKIBFQGMPD;
		this.NKKMJICKKLB.LKPOBCBOFIC("game.poke.one" + KCKIBFQGMPD);
		this.QPPGQJFBPMH.BBQFPBIIHCH();
	}

	// Token: 0x060050CD RID: 20685 RVA: 0x0029FB94 File Offset: 0x0029DD94
	public void LEFMEGOHGNN(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().OBHHEDCIIKP(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "/";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != StaffRank.Moderator)
			{
				if (KIPNFHNKMCE == (StaffRank)6)
				{
					text = "[-]";
				}
			}
			else
			{
				text = "5";
			}
		}
		else
		{
			text = "Motion Blur";
		}
		if (IHIHHCCEDHQ == "Sandy")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[3];
			array[0] = "'s move...\r\n";
			array[0] = DateTime.Now.ToString("_Detail");
			array[4] = "ability: ";
			array[2] = IHIHHCCEDHQ;
			array[6] = " is hoping to take its attacker down with it!\r\n";
			array[6] = PIDLOFMIEFQ;
			array[6] = " for [PD]";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.Developer)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[81];
				array2[0] = "Right";
				array2[0] = DateTime.Now.ToString("WATER_VERTEX_DISPLACEMENT_OFF");
				array2[7] = "No cinematic targets added to the list";
				array2[8] = text;
				array2[0] = " copied ";
				array2[1] = IHIHHCCEDHQ;
				array2[5] = "baddreams";
				array2[2] = IHIHHCCEDHQ;
				array2[8] = "Guild Request";
				array2[83] = PIDLOFMIEFQ;
				lljmbfpfnne2.LHQECHHMOGD(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[120];
				array3[0] = "\nAccuracy: ";
				array3[0] = DateTime.Now.ToString("pressure");
				array3[1] = "ditto";
				array3[7] = text;
				array3[3] = "[00EE07]";
				array3[0] = IHIHHCCEDHQ;
				array3[7] = "Intelligence increases mana";
				array3[4] = IHIHHCCEDHQ;
				array3[1] = "K7";
				array3[-11] = PIDLOFMIEFQ;
				lljmbfpfnne3.BFDGBMNGBKH(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1852f)
		{
			this.EHDBBNFQIBL.SetActive(true);
		}
	}

	// Token: 0x060050CE RID: 20686 RVA: 0x0029FD54 File Offset: 0x0029DF54
	public void OMQMHMJBDQO(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.HDDJIDGKKFK();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.BJLGEDCPENQ().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "/" + KCKIBFQGMPD;
		this.NKKMJICKKLB.LKPOBCBOFIC(")" + KCKIBFQGMPD);
		this.QPPGQJFBPMH.NDIJIFHOMJC();
	}

	// Token: 0x060050CF RID: 20687 RVA: 0x0029FDE4 File Offset: 0x0029DFE4
	public void DFNDGODMFOM(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.HDDJIDGKKFK();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.QOQONHOOLNE.JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "HTE/Camera Effects Shader" + KCKIBFQGMPD;
		this.NKKMJICKKLB.PIDLOFMIEFQ = "General" + KCKIBFQGMPD;
		this.QPPGQJFBPMH.GNFOKKIDEEQ();
	}

	// Token: 0x060050D0 RID: 20688 RVA: 0x0029FE74 File Offset: 0x0029E074
	public void KFBPHNNDKDC(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[6];
				array[1] = "[000000]..";
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[3] = CIQFCJGQEMH.ToString();
				array[4] = "Mouse ScrollWheel";
				array[6] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[4] = "[/urn][-]: ";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[]
				{
					null,
					"Lv "
				};
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[8] = CIQFCJGQEMH.ToString();
				array2[2] = "_FinalBlendParameters";
				array2[4] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[6] = "'s attack continues!\r\n";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050D1 RID: 20689 RVA: 0x0029FF98 File Offset: 0x0029E198
	public void NMDPODQMBJL()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("Icon_Status_Poisoned", string.Empty);
		text = MBGHQMKEFKO.QOQONHOOLNE.OBHHEDCIIKP(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 1, -84));
				bool flag = false;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, true);
		this.OGOIJMKCFHF(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050D2 RID: 20690 RVA: 0x002A00F8 File Offset: 0x0029E2F8
	public void QLPKBCQJOIB()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1081f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1729f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1375f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 47;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 881f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1943f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 66f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 55;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050D3 RID: 20691 RVA: 0x002A01F0 File Offset: 0x0029E3F0
	public void LCOEHDJFKQQ(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string[] array = new string[2];
			array[0] = "Dive Ball";
			array[0] = item.HLMQODIHBIG().EBGLBFKHCJD();
			array[1] = "TM";
			array[4] = item.NDPGCGDLEEQ();
			array[2] = "A";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.BGBMIEJJQKC + text);
			}
		}
	}

	// Token: 0x060050D4 RID: 20692 RVA: 0x002A028C File Offset: 0x0029E48C
	public void EGFLCLQJBHG(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.HDDJIDGKKFK();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.MOGQNGEPCEO().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "Verification" + KCKIBFQGMPD;
		this.NKKMJICKKLB.LKPOBCBOFIC(" requires " + KCKIBFQGMPD);
		this.QPPGQJFBPMH.OPDBQFELFQO();
	}

	// Token: 0x060050D5 RID: 20693 RVA: 0x002A031C File Offset: 0x0029E51C
	public void CFGNFCOCGLO(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.KGOPJQOMMNC().OBHHEDCIIKP(PIDLOFMIEFQ, false);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.MOGQNGEPCEO().IBPEBDGDQLG;
		}
		string text = "_FogHeightData";
		if (KIPNFHNKMCE != StaffRank.None)
		{
			if (KIPNFHNKMCE != (StaffRank)8)
			{
				if (KIPNFHNKMCE == StaffRank.GameModerator)
				{
					text = "lockon";
				}
			}
			else
			{
				text = "powertrick";
			}
		}
		else
		{
			text = "/";
		}
		if (IHIHHCCEDHQ == "BuffIcon_Synchronize")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[6];
			array[1] = "Icon_Pokemon_Dead";
			array[0] = DateTime.Now.ToString("J11");
			array[0] = "damp";
			array[1] = IHIHHCCEDHQ;
			array[8] = "TabSettings";
			array[7] = PIDLOFMIEFQ;
			array[8] = "[/u][/url]";
			lljmbfpfnne.LHQECHHMOGD(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.BBCBOIFQDBK().QKQCMHNEILL(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.Developer)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[-48];
				array2[0] = "#,##0";
				array2[1] = DateTime.Now.ToString("desolateland");
				array2[1] = "'s [ffff00]";
				array2[7] = text;
				array2[7] = "'s [ffff00]";
				array2[6] = IHIHHCCEDHQ;
				array2[3] = "The mysterious strong winds blow on regardless!\r\n";
				array2[1] = IHIHHCCEDHQ;
				array2[3] = "4";
				array2[43] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[50];
				array3[0] = "/friend ";
				array3[1] = DateTime.Now.ToString("HidePanel");
				array3[5] = "It doesn't affect ";
				array3[7] = text;
				array3[1] = "Battle Update: ";
				array3[8] = IHIHHCCEDHQ;
				array3[6] = "Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.";
				array3[7] = IHIHHCCEDHQ;
				array3[0] = "u";
				array3[-101] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1377f)
		{
			this.EHDBBNFQIBL.SetActive(true);
		}
	}

	// Token: 0x060050D6 RID: 20694 RVA: 0x002A04DC File Offset: 0x0029E6DC
	public void EHEQOGHQNMD(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[]
				{
					"--online"
				};
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[3] = CIQFCJGQEMH.ToString();
				array[6] = " [M]";
				array[8] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array[6] = "]#";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[1];
				array2[0] = "infestation";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[8] = CIQFCJGQEMH.ToString();
				array2[7] = "desolateland";
				array2[2] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[5] = " knocked off ";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050D7 RID: 20695 RVA: 0x000206CA File Offset: 0x0001E8CA
	public void HMJHQOIDBOF()
	{
		LQCPKKCJPPB.FFQQDQIBBPJ(this);
	}

	// Token: 0x060050D8 RID: 20696 RVA: 0x000206CA File Offset: 0x0001E8CA
	public void OPJEKEEKOHE()
	{
		LQCPKKCJPPB.FFQQDQIBBPJ(this);
	}

	// Token: 0x060050D9 RID: 20697 RVA: 0x002A0600 File Offset: 0x0029E800
	public void CIJLBMHEMMB(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			string[] array = new string[3];
			array[0] = "upkeep";
			array[0] = item.ID.EBGLBFKHCJD();
			array[2] = "???";
			array[0] = item.FLFQBGJQBBD();
			array[3] = "It's A Nice Day For Fishing";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050DA RID: 20698 RVA: 0x002A069C File Offset: 0x0029E89C
	public void FJDEPFKJGHE(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[4];
			array[0] = "OnClick";
			array[0] = item.ID.EBGLBFKHCJD();
			array[1] = "mindreader";
			array[6] = item.DFNQHDEDDKE();
			array[5] = "_BlendPower";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050DB RID: 20699 RVA: 0x002A0738 File Offset: 0x0029E938
	public void BGJFNEFNENE()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace(" AM", string.Empty);
		text = MBGHQMKEFKO.BBCBOIFQDBK().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[0];
				Guid guid = new Guid(text.Substring(array[0] + 0, 99));
				bool flag = true;
				int j = 1;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.LJBQIJQOPKK(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050DC RID: 20700 RVA: 0x002A0898 File Offset: 0x0029EA98
	public void EONELQGQGMH()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace("(B)", string.Empty);
		text = MBGHQMKEFKO.BBCBOIFQDBK().FQJQHQFGKOI(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i++)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 0, 39));
				bool flag = false;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j++;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.OGOIJMKCFHF(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x002A09F8 File Offset: 0x0029EBF8
	public void DPDLKQPKQLI()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			return;
		}
		text = text.Replace("F", string.Empty);
		text = MBGHQMKEFKO.KGOPJQOMMNC().LFGQJBFJMEP(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 1; i < text.Length; i++)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.KOMEFCQPPFG(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 3, -98));
				bool flag = true;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = false;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Closed,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.KKMCFJBMJQG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.None);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050DE RID: 20702 RVA: 0x002A0B58 File Offset: 0x0029ED58
	public void NGBPHGELPDJ(int HFBPHOGKGLK)
	{
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK);
		if (item != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string[] array = new string[1];
			array[1] = "o";
			array[1] = item.GMOFFIFDCGE().EBGLBFKHCJD();
			array[3] = "The [ffff00]";
			array[8] = item.NDPGCGDLEEQ();
			array[4] = "Restores HP if hit by a Water-type move, instead of taking damage.";
			string text = string.Concat(array);
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC += text;
			}
		}
	}

	// Token: 0x060050DF RID: 20703 RVA: 0x002A0BF4 File Offset: 0x0029EDF4
	public void QOQLEMMOQOI(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				string[] array = new string[7];
				array[1] = "Localization key '";
				array[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[4] = CIQFCJGQEMH.ToString();
				array[1] = "The [ffff00]";
				array[0] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[2] = "spikes";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[6];
				array2[1] = "Camera Target Position Smoothed";
				array2[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[0] = CIQFCJGQEMH.ToString();
				array2[2] = "door_1";
				array2[3] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
				array2[6] = "mimikyubusted";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.BGBMIEJJQKC.Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.BGBMIEJJQKC = ijhoqlbfiqi.HJMJDJKOILH() + text;
			}
		}
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x00020697 File Offset: 0x0001E897
	public void IEPCECPKEDD()
	{
		LQCPKKCJPPB.MKCGFQBNMOK(this);
	}

	// Token: 0x060050E1 RID: 20705 RVA: 0x002A0D18 File Offset: 0x0029EF18
	public void LMGDIMBGLOO()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1559f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1947f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1436f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.DFKQMMIQDOO;
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = 17;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 837f)
		{
			this.EHDBBNFQIBL.SetActive(true);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1657f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1339f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 7;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050E2 RID: 20706 RVA: 0x002A0E10 File Offset: 0x0029F010
	public void FJQHGJNEBNH()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.BGBMIEJJQKC);
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.BGBMIEJJQKC = string.Empty;
			this.IJHOQLBFIQI.GOIKCGNOEKP();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("#,##0", string.Empty);
		text = MBGHQMKEFKO.BBCBOIFQDBK().FQJQHQFGKOI(text, true);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i++)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[1];
				Guid guid = new Guid(text.Substring(array[1] + 2, 126));
				bool flag = true;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, true);
		this.CFGNFCOCGLO(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.GOIKCGNOEKP();
		this.IJHOQLBFIQI.GKHHCNCGLCD = false;
	}

	// Token: 0x060050E3 RID: 20707 RVA: 0x002A0F70 File Offset: 0x0029F170
	public void LQFDMHPELCJ(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.BJLGEDCPENQ().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "CombinersArgsAlphaOp2" + KCKIBFQGMPD;
		this.NKKMJICKKLB.LKPOBCBOFIC("[-] let it move first!\r\n" + KCKIBFQGMPD);
		this.QPPGQJFBPMH.OPDBQFELFQO();
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x0002069F File Offset: 0x0001E89F
	public void CPJGJNFBCNF()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x060050E5 RID: 20709 RVA: 0x000206CA File Offset: 0x0001E8CA
	public void GGJKFBOOEHJ()
	{
		LQCPKKCJPPB.FFQQDQIBBPJ(this);
	}

	// Token: 0x060050E6 RID: 20710 RVA: 0x002A1000 File Offset: 0x0029F200
	public void FBHDJONQJFG()
	{
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 572f)
		{
			this.EFFMFNGGHFI.CGHQEHCBQHB = 145f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1202f;
			this.EFFMFNGGHFI.PlayForward();
			this.LEINPFJFOBO = this.LKJLNEBMFEF.JKGBHEHKBPC();
			this.DFFOKQPBQGH.CGHQEHCBQHB = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.BKMCCCGOGOM = -85;
			this.DFFOKQPBQGH.PlayForward();
		}
		else if (this.IQDCDBCPBEN.DIIHJCJOKMP == 1618f)
		{
			this.EHDBBNFQIBL.SetActive(false);
			this.EFFMFNGGHFI.CGHQEHCBQHB = 1189f;
			this.EFFMFNGGHFI.BKMCCCGOGOM = 1581f;
			this.EFFMFNGGHFI.PlayForward();
			this.DFFOKQPBQGH.CGHQEHCBQHB = 27;
			this.DFFOKQPBQGH.BKMCCCGOGOM = this.LEINPFJFOBO;
			this.DFFOKQPBQGH.PlayForward();
		}
	}

	// Token: 0x060050E7 RID: 20711 RVA: 0x002A10F8 File Offset: 0x0029F2F8
	public void ECIIQHMEQPP()
	{
		string text = JGDHIPBGCFP.IMOMGBNIENN(this.IJHOQLBFIQI.HJMJDJKOILH());
		if (string.IsNullOrEmpty(text))
		{
			this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
			this.IJHOQLBFIQI.POPMOIOELBB();
			this.IJHOQLBFIQI.GKHHCNCGLCD = true;
			return;
		}
		text = text.Replace("Boosts the Pokémon's evasion in a sandstorm.", string.Empty);
		text = MBGHQMKEFKO.QOQONHOOLNE.FQJQHQFGKOI(text, false);
		List<Guid> list = new List<Guid>();
		for (int i = 0; i < text.Length; i += 0)
		{
			int[] array = this.IJHOQLBFIQI.KEQMEGEHFIK.QGCQQOHBILP(i, text);
			if (array != null)
			{
				i = array[0];
				Guid guid = new Guid(text.Substring(array[0] + 3, -109));
				bool flag = false;
				int j = 0;
				while (j < list.Count)
				{
					if (!(list[j] == guid))
					{
						j += 0;
					}
					else
					{
						flag = true;
						IL_C5:
						if (flag)
						{
							list.Add(guid);
							goto IL_D1;
						}
						goto IL_D1;
					}
				}
				goto IL_C5;
			}
			IL_D1:;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
		{
			Event = PSXAPI.Request.MessageEvent.Message,
			Name = this.CBJDELNFQBM,
			Text = text,
			Pokemon = list.ToArray()
		}, false);
		this.KKMCFJBMJQG(KGQECFKLKOP.HFKHODPJQOJ(), text, StaffRank.Developer);
		this.IJHOQLBFIQI.NCBFKNGMKPB(string.Empty);
		this.IJHOQLBFIQI.POPMOIOELBB();
		this.IJHOQLBFIQI.GKHHCNCGLCD = true;
	}

	// Token: 0x060050E8 RID: 20712 RVA: 0x002A1258 File Offset: 0x0029F458
	public void LEEEQKCJLPG(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.LFGQJBFJMEP(PIDLOFMIEFQ, false);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "Enabled";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != (StaffRank)4)
			{
				if (KIPNFHNKMCE == (StaffRank)7)
				{
					text = "The sunlight turned extremely harsh!";
				}
			}
			else
			{
				text = "p2";
			}
		}
		else
		{
			text = "BuffIcon_SteelIncrease";
		}
		if (IHIHHCCEDHQ == "raindance")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[3];
			array[1] = "Daily Reset\n";
			array[1] = DateTime.Now.ToString(", ignore controller");
			array[7] = "_1";
			array[6] = IHIHHCCEDHQ;
			array[2] = "item";
			array[7] = PIDLOFMIEFQ;
			array[6] = "[u][33CCFF]";
			lljmbfpfnne.BFDGBMNGBKH(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.BBCBOIFQDBK().HMLGEKPKGLL(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[78];
				array2[0] = "Btn_TabHighlighted_Normal";
				array2[1] = DateTime.Now.ToString("1");
				array2[5] = "Becomes competitive and deals more damage to Pokémon of the same gender, but deals less to Pokémon of the opposite gender.";
				array2[0] = text;
				array2[8] = "Frisk";
				array2[2] = IHIHHCCEDHQ;
				array2[4] = "mdata";
				array2[8] = IHIHHCCEDHQ;
				array2[7] = "Small/";
				array2[91] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[43];
				array3[1] = "curse";
				array3[1] = DateTime.Now.ToString("Boosts the Pokémon's Speed stat in a sandstorm.");
				array3[7] = "OnPress";
				array3[2] = text;
				array3[3] = "receiver";
				array3[0] = IHIHHCCEDHQ;
				array3[3] = "Its majesty pressures the opposing Pokémon, making it unable to attack using priority moves.";
				array3[3] = IHIHHCCEDHQ;
				array3[1] = "Discovered Area";
				array3[-63] = PIDLOFMIEFQ;
				lljmbfpfnne3.LHQECHHMOGD(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 80f)
		{
			this.EHDBBNFQIBL.SetActive(false);
		}
	}

	// Token: 0x060050E9 RID: 20713 RVA: 0x00020697 File Offset: 0x0001E897
	public void EHFFCLPCMME()
	{
		LQCPKKCJPPB.MKCGFQBNMOK(this);
	}

	// Token: 0x060050EA RID: 20714 RVA: 0x0002069F File Offset: 0x0001E89F
	public void BJDPBNOKMOD()
	{
		LQCPKKCJPPB.BQQNHEIODLJ(this);
	}

	// Token: 0x060050EB RID: 20715 RVA: 0x002A1418 File Offset: 0x0029F618
	public void OJIBNMPCFBQ(string KCKIBFQGMPD)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.NKQFQKOIBML(KCKIBFQGMPD))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		this.LLJMBFPFNNE.JMNEKDGHIIF();
		this.LLJMBFPFNNE.GetComponent<JBEFDGKLJHP>().JLCFIMNJGBB = CNCJKLNHQBH.MOGQNGEPCEO().JLCFIMNJGBB;
		this.CBJDELNFQBM = KCKIBFQGMPD.ToLowerInvariant();
		base.gameObject.name = "blank" + KCKIBFQGMPD;
		this.NKKMJICKKLB.LKPOBCBOFIC("The pointed stones disappeared from around " + KCKIBFQGMPD);
		this.QPPGQJFBPMH.OPDBQFELFQO();
	}

	// Token: 0x060050EC RID: 20716 RVA: 0x002A14A8 File Offset: 0x0029F6A8
	public void LLHINCPGLJL(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.IJHOQLBFIQI.GKHHCNCGLCD = false;
			string text;
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				string[] array = new string[0];
				array[0] = "Invalid Username or Password..";
				array[0] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array[7] = CIQFCJGQEMH.ToString();
				array[8] = "Chances of finding Pokémon with the same Nature increased 50%.\nTriggers: [2ecc71]Synchronize[-]";
				array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array[7] = "solidrock";
				text = string.Concat(array);
			}
			else
			{
				string[] array2 = new string[7];
				array2[1] = "Btn_Tab_Normal";
				array2[1] = KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString();
				array2[5] = CIQFCJGQEMH.ToString();
				array2[7] = " min";
				array2[2] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
				array2[7] = "flashfire";
				text = string.Concat(array2);
			}
			if (this.IJHOQLBFIQI.HJMJDJKOILH().Length + text.Length < this.IJHOQLBFIQI.EQJBIOMMEEP)
			{
				JIMBBPLINGI ijhoqlbfiqi = this.IJHOQLBFIQI;
				ijhoqlbfiqi.NCBFKNGMKPB(ijhoqlbfiqi.BGBMIEJJQKC + text);
			}
		}
	}

	// Token: 0x060050ED RID: 20717 RVA: 0x002A15CC File Offset: 0x0029F7CC
	public void LJBQIJQOPKK(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.FQJQHQFGKOI(PIDLOFMIEFQ, false);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG;
		}
		string text = "00CCFF";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != StaffRank.GameModerator)
			{
				if (KIPNFHNKMCE == StaffRank.Moderator)
				{
					text = "7fff49";
				}
			}
			else
			{
				text = "ffb649";
			}
		}
		else
		{
			text = "ff6649";
		}
		if (IHIHHCCEDHQ == "System")
		{
			this.LLJMBFPFNNE.LHQECHHMOGD(string.Concat(new string[]
			{
				"[FFFFFF][",
				DateTime.Now.ToString("HH:mm:ss"),
				"][-][00CCFF] ",
				IHIHHCCEDHQ,
				": ",
				PIDLOFMIEFQ,
				"[-]"
			}));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.Developer)
			{
				this.LLJMBFPFNNE.LHQECHHMOGD(string.Concat(new string[]
				{
					"[FFFFFF][",
					DateTime.Now.ToString("HH:mm:ss"),
					"][-][",
					text,
					"][urn=",
					IHIHHCCEDHQ,
					"] [u]",
					IHIHHCCEDHQ,
					"[/u][/urn][-]: ",
					PIDLOFMIEFQ
				}));
			}
			else
			{
				this.LLJMBFPFNNE.LHQECHHMOGD(string.Concat(new string[]
				{
					"[FFFFFF][",
					DateTime.Now.ToString("HH:mm:ss"),
					"][-][",
					text,
					"][urn=",
					IHIHHCCEDHQ,
					"] ",
					IHIHHCCEDHQ,
					"[/urn][-]: ",
					PIDLOFMIEFQ
				}));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 0f)
		{
			this.EHDBBNFQIBL.SetActive(true);
		}
	}

	// Token: 0x060050EE RID: 20718 RVA: 0x002A178C File Offset: 0x0029F98C
	public void OGOIJMKCFHF(string IHIHHCCEDHQ, string PIDLOFMIEFQ, StaffRank KIPNFHNKMCE)
	{
		PIDLOFMIEFQ = MBGHQMKEFKO.BBCBOIFQDBK().FQJQHQFGKOI(PIDLOFMIEFQ, true);
		if (IHIHHCCEDHQ == KGQECFKLKOP.HFKHODPJQOJ())
		{
			KIPNFHNKMCE = CNCJKLNHQBH.BJLGEDCPENQ().IBPEBDGDQLG;
		}
		string text = "Party Request";
		if (KIPNFHNKMCE != StaffRank.Developer)
		{
			if (KIPNFHNKMCE != StaffRank.Moderator)
			{
				if (KIPNFHNKMCE == (StaffRank)5)
				{
					text = "[o]";
				}
			}
			else
			{
				text = "The Pokémon can't use a move the following turn if it uses one.";
			}
		}
		else
		{
			text = "[red]";
		}
		if (IHIHHCCEDHQ == "normal")
		{
			BMLIGLPMMLG lljmbfpfnne = this.LLJMBFPFNNE;
			string[] array = new string[2];
			array[0] = "Surf";
			array[1] = DateTime.Now.ToString("301");
			array[7] = "PlayDeadAnimation";
			array[8] = IHIHHCCEDHQ;
			array[3] = "MSGBOX - Move Learning";
			array[4] = PIDLOFMIEFQ;
			array[2] = "powerofalchemy";
			lljmbfpfnne.LHQECHHMOGD(string.Concat(array));
		}
		else
		{
			PIDLOFMIEFQ = MBGHQMKEFKO.QOQONHOOLNE.JOEICKPOGNK(PIDLOFMIEFQ);
			if (KIPNFHNKMCE == StaffRank.None)
			{
				BMLIGLPMMLG lljmbfpfnne2 = this.LLJMBFPFNNE;
				string[] array2 = new string[-83];
				array2[0] = "Limit Distance";
				array2[0] = DateTime.Now.ToString("Builtin Debug Views");
				array2[1] = "]";
				array2[6] = text;
				array2[4] = "\n";
				array2[7] = IHIHHCCEDHQ;
				array2[6] = "-center";
				array2[7] = IHIHHCCEDHQ;
				array2[1] = "#,##0";
				array2[-55] = PIDLOFMIEFQ;
				lljmbfpfnne2.BFDGBMNGBKH(string.Concat(array2));
			}
			else
			{
				BMLIGLPMMLG lljmbfpfnne3 = this.LLJMBFPFNNE;
				string[] array3 = new string[-58];
				array3[0] = "attract";
				array3[1] = DateTime.Now.ToString("Stop");
				array3[5] = "ChangeBattleInventory";
				array3[1] = text;
				array3[5] = "_AllowBackwardsRays";
				array3[2] = IHIHHCCEDHQ;
				array3[0] = "HM";
				array3[4] = IHIHHCCEDHQ;
				array3[5] = "Icicle Badge";
				array3[-113] = PIDLOFMIEFQ;
				lljmbfpfnne3.BFDGBMNGBKH(string.Concat(array3));
			}
		}
		if (this.IQDCDBCPBEN.DIIHJCJOKMP == 696f)
		{
			this.EHDBBNFQIBL.SetActive(false);
		}
	}

	// Token: 0x04001155 RID: 4437
	public GameObject EHDBBNFQIBL;

	// Token: 0x04001156 RID: 4438
	public JIMBBPLINGI IJHOQLBFIQI;

	// Token: 0x04001157 RID: 4439
	public BMLIGLPMMLG LLJMBFPFNNE;

	// Token: 0x04001158 RID: 4440
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x04001159 RID: 4441
	public KIQKEMNELKN QPPGQJFBPMH;

	// Token: 0x0400115A RID: 4442
	public string CBJDELNFQBM;

	// Token: 0x0400115B RID: 4443
	public ENFMCDNLEQQ IQDCDBCPBEN;

	// Token: 0x0400115C RID: 4444
	public PLQFPBQEPJD LKJLNEBMFEF;

	// Token: 0x0400115D RID: 4445
	public CIPCDJPQQLM DFFOKQPBQGH;

	// Token: 0x0400115E RID: 4446
	public EPIJJNOIKEK EFFMFNGGHFI;

	// Token: 0x0400115F RID: 4447
	private int LEINPFJFOBO = 200;
}
