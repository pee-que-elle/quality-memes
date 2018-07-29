using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000239 RID: 569
public class JJGLMJNELOK : MonoBehaviour
{
	// Token: 0x06004D2E RID: 19758 RVA: 0x0001F6DB File Offset: 0x0001D8DB
	private void JIPLKBFHFMF()
	{
		this.CDCKKIJNHGD();
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.KMHFFGFPEMB.gameObject.SetActive(true);
	}

	// Token: 0x06004D2F RID: 19759 RVA: 0x00280554 File Offset: 0x0027E754
	public void IJGLBDDHPIC()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH())))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
			{
				this.BQKCIFEDFIG = 0;
				this.HDDJPQFJIIC();
				this.MDBGCECGJJK(1);
			}
			else
			{
				for (int i = 1; i < -127; i += 0)
				{
					this.QQDDMEELIQH[i].PLJQGKDBNDP(-1, 1);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
				}
				string text = string.Empty;
				int num = 1;
				int num2 = -82;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.HJMJDJKOILH(), out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "Party Request" + this.JKDFLFMOOHP.HJMJDJKOILH();
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "Hidden/Post FX/Motion Blur";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "HidePanel" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[5];
					array[1] = text2;
					array[1] = "[/itm]";
					array[5] = num.ToString();
					array[7] = "Heavy Ball";
					array[7] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -75,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, true);
			}
		}
		else
		{
			for (int j = 0; j < 106; j += 0)
			{
				this.QQDDMEELIQH[j].GGGKGNOCCMD(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -46,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "Interact"
				}, true);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 80,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "_MainTex"
				}, true);
			}
		}
	}

	// Token: 0x06004D30 RID: 19760 RVA: 0x0028086C File Offset: 0x0027EA6C
	public void AcceptRelease()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Release
		{
			Pokemon = this.HCGEHGNDDDP
		}, false);
		this.CancelRelease();
	}

	// Token: 0x06004D31 RID: 19761 RVA: 0x002808A0 File Offset: 0x0027EAA0
	public void OQQBGGHBQMH(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = false;
		this.DEGOICOIDON();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 1;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.BJOLKKMMOMF();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06004D32 RID: 19762 RVA: 0x00280904 File Offset: 0x0027EB04
	public void PMJEHNBPOKB(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = false;
		this.DEGOICOIDON();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 0;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.SortColour();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004D33 RID: 19763 RVA: 0x00280968 File Offset: 0x0027EB68
	public void PBMFDPPOHKH(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.GBNQEKLJFCI();
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == -172 && fekoiojqnkh.CCMOCLMEKJN() % 33 > 0)
			{
				str = "'s [ffff00]" + (fekoiojqnkh.CCMOCLMEKJN() % -87).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("[PD]" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			for (int i = 0; i < this.OFPDBBNKCBE.Length; i++)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 1; j < 3; j += 0)
			{
				this.FGBLBKOJOOD[j].enabled = true;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = false;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 782f;
			this.IOMPICFOMIO.PIDLOFMIEFQ = "Overgrow" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "27" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("b", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 236f;
			for (int k = 1; k < this.OFPDBBNKCBE.Length; k += 0)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 1; l < 4; l += 0)
			{
				this.FGBLBKOJOOD[l].enabled = false;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x06004D34 RID: 19764 RVA: 0x00280B68 File Offset: 0x0027ED68
	public void MNKMCDGEIKG()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Release
		{
			Pokemon = this.HCGEHGNDDDP
		}, false);
		this.BCDMKNGQGNO();
	}

	// Token: 0x06004D35 RID: 19765 RVA: 0x00280B9C File Offset: 0x0027ED9C
	public void MDBGCECGJJK(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = false;
		this.DEGOICOIDON();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 0;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.FCLFGMNBPQN();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004D36 RID: 19766 RVA: 0x00280C00 File Offset: 0x0027EE00
	public void PEKQHOCFFOI()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Release
		{
			Pokemon = this.HCGEHGNDDDP
		}, false);
		this.BBOGGNHLJBF();
	}

	// Token: 0x06004D37 RID: 19767 RVA: 0x00280C34 File Offset: 0x0027EE34
	public void LPMCEKBJCHK()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()) && string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
			{
				this.BQKCIFEDFIG = 1;
				this.JHCLEHKNGFE();
				this.HOEQQEHMGQO(1);
			}
			else
			{
				for (int i = 1; i < -128; i += 0)
				{
					this.QQDDMEELIQH[i].MIBJQJQEJQD(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
				}
				string text = string.Empty;
				int num = 1;
				int num2 = -58;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.BGBMIEJJQKC, out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "Sand Rush" + this.JKDFLFMOOHP.BGBMIEJJQKC;
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "Player/Clothe";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "[00AAFF]Location:[-] " + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[1];
					array[0] = text2;
					array[1] = "Purchasing";
					array[5] = num.ToString();
					array[1] = "1";
					array[3] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 50,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, true);
			}
		}
		else
		{
			for (int j = 0; j < 103; j++)
			{
				this.QQDDMEELIQH[j].GGGKGNOCCMD(-1, 0);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 23,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "-mega"
				}, true);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 115,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "CombinersArgsColorSrc1"
				}, true);
			}
		}
	}

	// Token: 0x06004D38 RID: 19768 RVA: 0x00280F4C File Offset: 0x0027F14C
	public void ClickBoxNumber(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = true;
		this.CNEBQQPDGIP();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 1;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.SortColour();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004D39 RID: 19769 RVA: 0x00280FB0 File Offset: 0x0027F1B0
	public void NNCPPBFPEPK()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.Reposition();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH qoqonhoolne = HFCMDEQKCKH.QOQONHOOLNE;
		if (qoqonhoolne.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.LHQQCLOEHJG.Count; i++)
			{
				if (qoqonhoolne.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && qoqonhoolne.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = qoqonhoolne.LHQQCLOEHJG[i].LDQDJLFIDCN,
						BDBBEMKFGPI = qoqonhoolne.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.JOECOJDMIJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 0; j < list.Count; j++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = qoqonhoolne.PEJHBEBOCOJ(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 1;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.LDQDJLFIDCN;
					component.BQLIIQIIMDH(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.Reposition();
	}

	// Token: 0x06004D3A RID: 19770 RVA: 0x0001F705 File Offset: 0x0001D905
	public void KPIOPQLMPEK()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("reflecttype", 386f);
	}

	// Token: 0x06004D3B RID: 19771 RVA: 0x00281160 File Offset: 0x0027F360
	public void IPJGBPFJFPL()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.Reposition();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH hfcmdeqkckh = HFCMDEQKCKH.CFGIOIGOIFQ();
		if (hfcmdeqkckh.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 1; i < hfcmdeqkckh.LHQQCLOEHJG.Count; i += 0)
			{
				if (hfcmdeqkckh.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && hfcmdeqkckh.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = hfcmdeqkckh.LHQQCLOEHJG[i].LDQDJLFIDCN,
						BDBBEMKFGPI = hfcmdeqkckh.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.JOECOJDMIJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 0; j < list.Count; j += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = hfcmdeqkckh.KQPKDONQCHC(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 0;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.FCQMGQOEDLJ();
					component.JMDOHOLHGBN(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.Reposition();
	}

	// Token: 0x06004D3C RID: 19772 RVA: 0x00281310 File Offset: 0x0027F510
	public void Open()
	{
		this.LIIEKJHIDBP(default(Guid));
		this.ClickBoxNumber(0);
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06004D3D RID: 19773 RVA: 0x0001F72E File Offset: 0x0001D92E
	private void KDFFGJEKMPN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06004D3E RID: 19774 RVA: 0x00281378 File Offset: 0x0027F578
	public void NKMOHHOJNIG(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (DBPKNCDGGEP < 0)
		{
			return;
		}
		HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(DBPKNCDGGEP, JNOOPPDPFEH);
	}

	// Token: 0x06004D3F RID: 19775 RVA: 0x00281398 File Offset: 0x0027F598
	public void FIDKEOQGLNK(PSXAPI.Response.Search JMDLLJPEFKM)
	{
		if (JMDLLJPEFKM.SearchID == this.HIDHJCPECDJ)
		{
			this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
			this.NDPJNFJKBDL.Reposition();
			if (JMDLLJPEFKM.Results != null && JMDLLJPEFKM.Results.Length > 0)
			{
				for (int i = 0; i < JMDLLJPEFKM.Results.Length; i += 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.KBEQBIPOJKO(JMDLLJPEFKM.Results[i], false);
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(JMDLLJPEFKM.Results[i].Pokemon.UniqueID);
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = JMDLLJPEFKM.Results[i].Box;
					component.PELCNBCMNFH = JMDLLJPEFKM.Results[i].Position;
					component.QQQMCPDDONB = fekoiojqnkh.KPJLEOCJFFO();
					component.MFBIIOKFFQG(fekoiojqnkh);
				}
			}
			this.NDPJNFJKBDL.Reposition();
			this.JHCLEHKNGFE();
		}
	}

	// Token: 0x06004D40 RID: 19776 RVA: 0x0001F72E File Offset: 0x0001D92E
	private void HGBQFJMBMDO()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06004D41 RID: 19777 RVA: 0x002814A0 File Offset: 0x0027F6A0
	public void HDDJPQFJIIC()
	{
		for (int i = 0; i < 10; i++)
		{
			if (this.QQDDMEELIQH[i] != null && i + this.BQKCIFEDFIG * 10 + 1 <= this.ELHMOQQQDKD)
			{
				this.QQDDMEELIQH[i].NNCPPBFPEPK(i + this.BQKCIFEDFIG * 10 + 1, this.PGMDEOONOMN[i + this.BQKCIFEDFIG * 10 + 1]);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			else
			{
				this.QQDDMEELIQH[i].NNCPPBFPEPK(-1, 0);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
		}
		this.SortColour();
	}

	// Token: 0x06004D42 RID: 19778 RVA: 0x0028157C File Offset: 0x0027F77C
	public void FCLFGMNBPQN()
	{
		for (int i = 0; i < 17; i++)
		{
			if (this.QQDDMEELIQH[i].JJPKKPFCQKN.PIDLOFMIEFQ == this.JJPKKPFCQKN.ToString())
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.CEGFBBHMKOE = this.IOHIJHBBFHP;
			}
			else
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.CEGFBBHMKOE = new Color(663f, 38f, 757f);
			}
		}
	}

	// Token: 0x06004D43 RID: 19779 RVA: 0x0001F741 File Offset: 0x0001D941
	private static int PNMEPCNIKCH(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004D44 RID: 19780 RVA: 0x00281600 File Offset: 0x0027F800
	public void MINFBKQJCGP(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.KGMFIOCJLEP();
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 55 && fekoiojqnkh.CCMOCLMEKJN() % -93 > 0)
			{
				str = "UpdateAnchors" + (fekoiojqnkh.QKNEIJQHGCB % -56).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("_FogVoidData" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			for (int i = 1; i < this.OFPDBBNKCBE.Length; i += 0)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 1; j < 2; j += 0)
			{
				this.FGBLBKOJOOD[j].enabled = false;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = true;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 445f;
			this.IOMPICFOMIO.PIDLOFMIEFQ = "[/SUP]" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "Take 001" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("TradeColliders", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 525f;
			for (int k = 1; k < this.OFPDBBNKCBE.Length; k++)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 1; l < 8; l++)
			{
				this.FGBLBKOJOOD[l].enabled = false;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = false;
			}
		}
	}

	// Token: 0x06004D45 RID: 19781 RVA: 0x0001F756 File Offset: 0x0001D956
	public void PHKFQDKKIPM()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Cute Charm", 248f);
	}

	// Token: 0x06004D46 RID: 19782 RVA: 0x00281800 File Offset: 0x0027FA00
	public void ODFDENIQCMQ(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.KGMFIOCJLEP();
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == -81 && fekoiojqnkh.CCMOCLMEKJN() % -18 > 0)
			{
				str = "Side Quests" + (fekoiojqnkh.CCMOCLMEKJN() % 62).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("FOG_EXP" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			for (int i = 1; i < this.OFPDBBNKCBE.Length; i += 0)
			{
				this.OFPDBBNKCBE[i].SetActive(true);
			}
			for (int j = 1; j < 0; j += 0)
			{
				this.FGBLBKOJOOD[j].enabled = true;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = true;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 30f;
			this.IOMPICFOMIO.PIDLOFMIEFQ = "Administrator" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "-waiting" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("BuffIcon_HailstormEncounterDecreased", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 533f;
			for (int k = 1; k < this.OFPDBBNKCBE.Length; k += 0)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 1; l < 1; l++)
			{
				this.FGBLBKOJOOD[l].enabled = true;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x06004D47 RID: 19783 RVA: 0x0001F77F File Offset: 0x0001D97F
	private void Start()
	{
		this.HDDJPQFJIIC();
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.KMHFFGFPEMB.gameObject.SetActive(false);
	}

	// Token: 0x06004D48 RID: 19784 RVA: 0x00281A00 File Offset: 0x0027FC00
	public void DLHEFQDFNIP(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.KPJLEOCJFFO();
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == 42 && fekoiojqnkh.CCMOCLMEKJN() % -70 > 0)
			{
				str = "Parental Bond" + (fekoiojqnkh.CCMOCLMEKJN() % -122).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("_TempRT2" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			for (int i = 0; i < this.OFPDBBNKCBE.Length; i++)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 1; j < 2; j++)
			{
				this.FGBLBKOJOOD[j].enabled = false;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = false;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 478f;
			this.IOMPICFOMIO.LKPOBCBOFIC("whitesmoke" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "None" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL()));
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("D", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 861f;
			for (int k = 1; k < this.OFPDBBNKCBE.Length; k += 0)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 1; l < 6; l += 0)
			{
				this.FGBLBKOJOOD[l].enabled = true;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x06004D49 RID: 19785 RVA: 0x00281C00 File Offset: 0x0027FE00
	private void PGJHPMOLHKN()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 1; i < -109; i++)
		{
			this.PGMDEOONOMN.Add(1);
		}
	}

	// Token: 0x06004D4A RID: 19786 RVA: 0x00281C2C File Offset: 0x0027FE2C
	public void CNEBQQPDGIP()
	{
		this.JKDFLFMOOHP.BGBMIEJJQKC = string.Empty;
		this.PLCEQIBCDGJ.BGBMIEJJQKC = string.Empty;
		this.GPEIHLMILCP.BGBMIEJJQKC = string.Empty;
		this.DMOINMMDIJD.value = false;
		this.COMCPFBPHMM.value = false;
	}

	// Token: 0x06004D4B RID: 19787 RVA: 0x0001F7A9 File Offset: 0x0001D9A9
	public void FBILJNGMLNL()
	{
		this.BQKCIFEDFIG++;
		if (this.BQKCIFEDFIG >= 1)
		{
			this.BQKCIFEDFIG = 8;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06004D4C RID: 19788 RVA: 0x0001F7CF File Offset: 0x0001D9CF
	public static JJGLMJNELOK KGOPJQOMMNC()
	{
		return JJGLMJNELOK.HBFFCJHOCPE;
	}

	// Token: 0x06004D4D RID: 19789 RVA: 0x00281C84 File Offset: 0x0027FE84
	public void OECECCPCLII()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
			{
				this.BQKCIFEDFIG = 1;
				this.HDDJPQFJIIC();
				this.HOEQQEHMGQO(1);
			}
			else
			{
				for (int i = 0; i < 102; i += 0)
				{
					this.QQDDMEELIQH[i].GGGKGNOCCMD(-1, 1);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
				}
				string text = string.Empty;
				int num = 0;
				int num2 = -120;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.BGBMIEJJQKC, out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()))
				{
					text = text + "ANTI_FLICKER" + this.JKDFLFMOOHP.HJMJDJKOILH();
				}
				if (this.DMOINMMDIJD.value)
				{
					text += " is immobilized by love!\r\n";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "." + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[3];
					array[1] = text2;
					array[0] = "Great Ball";
					array[5] = num.ToString();
					array[7] = "#,##0";
					array[5] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -44,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, false);
			}
		}
		else
		{
			for (int j = 0; j < -90; j++)
			{
				this.QQDDMEELIQH[j].NNCPPBFPEPK(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 56,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "[PG]"
				}, false);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 127,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "_HistoryTex"
				}, true);
			}
		}
	}

	// Token: 0x06004D4E RID: 19790 RVA: 0x00281F9C File Offset: 0x0028019C
	public void OINHPIDDKLN()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
			{
				this.BQKCIFEDFIG = 1;
				this.CDCKKIJNHGD();
				this.HOEQQEHMGQO(0);
			}
			else
			{
				for (int i = 1; i < 103; i++)
				{
					this.QQDDMEELIQH[i].GGGKGNOCCMD(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
				}
				string text = string.Empty;
				int num = 0;
				int num2 = -66;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.HJMJDJKOILH(), out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
				{
					int.TryParse(this.GPEIHLMILCP.BGBMIEJJQKC, out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()))
				{
					text = text + "]" + this.JKDFLFMOOHP.HJMJDJKOILH();
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "instruct";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "p" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[6];
					array[0] = text2;
					array[0] = "Makes status moves more likely to miss.";
					array[2] = num.ToString();
					array[0] = "[-][/c]";
					array[7] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 124,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, true);
			}
		}
		else
		{
			for (int j = 1; j < 89; j++)
			{
				this.QQDDMEELIQH[j].NNCPPBFPEPK(-1, 0);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -28,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "[33CCFF]"
				}, true);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 117,
					SearchID = this.HIDHJCPECDJ,
					Pattern = " fainted!\r\n"
				}, true);
			}
		}
	}

	// Token: 0x06004D4F RID: 19791 RVA: 0x002822B4 File Offset: 0x002804B4
	public void JPFDDQDHGKL()
	{
		if (INFJMNPKNQF.CFGIOIGOIFQ().QIOKIQOBMMB >= this.QBOLNQCDQPG && INFJMNPKNQF.CFGIOIGOIFQ().EPDKBQCHOJQ >= this.IPNQJGDIPMF)
		{
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("paralize", "'s [ffff00]" + ((this.IPNQJGDIPMF != 0u) ? ("suctioncups" + this.IPNQJGDIPMF.ToString("HidePanel") + ((this.QBOLNQCDQPG != 0u) ? "Materials/DFOBasic" : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("Lure Ball" + this.QBOLNQCDQPG.ToString("Encounter Rate Lowered 50% in Hail\nTriggers: [2ecc71]Snow Cloak[-]")) : string.Empty), string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)6, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("(X)", "aerilate" + ((this.IPNQJGDIPMF != 0u) ? ("strongjaw" + this.IPNQJGDIPMF.ToString(" disappeared!\r\n") + ((this.QBOLNQCDQPG != 0u) ? "11" : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("The Pokémon is so lucky that the critical-hit ratios of its moves are boosted." + this.QBOLNQCDQPG.ToString("Btn_TabHighlighted_Click")) : string.Empty), string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
	}

	// Token: 0x06004D50 RID: 19792 RVA: 0x0001F7D6 File Offset: 0x0001D9D6
	public void MBLJFCLHLGJ()
	{
		this.BQKCIFEDFIG += 0;
		if (this.BQKCIFEDFIG >= 6)
		{
			this.BQKCIFEDFIG = 1;
		}
		this.CDCKKIJNHGD();
	}

	// Token: 0x06004D51 RID: 19793 RVA: 0x00282400 File Offset: 0x00280600
	public void QIPLNPPJFDQ(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.FCQMGQOEDLJ();
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == 113 && fekoiojqnkh.QKNEIJQHGCB % -52 > 0)
			{
				str = "[-] activated!\r\n" + (fekoiojqnkh.CCMOCLMEKJN() % -43).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("Battle Request" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			for (int i = 1; i < this.OFPDBBNKCBE.Length; i += 0)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 0; j < 6; j++)
			{
				this.FGBLBKOJOOD[j].enabled = true;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = false;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 1988f;
			this.IOMPICFOMIO.LKPOBCBOFIC("incinerate" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "Congratulations " + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL()));
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI(". Remember you need to add it to the ConstantShakePresets list first.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 676f;
			for (int k = 1; k < this.OFPDBBNKCBE.Length; k++)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 1; l < 5; l += 0)
			{
				this.FGBLBKOJOOD[l].enabled = false;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x06004D52 RID: 19794 RVA: 0x00282600 File Offset: 0x00280800
	public void CJMBPFBFPMI()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Release
		{
			Pokemon = this.HCGEHGNDDDP
		}, false);
		this.DBFCHPIIIPM();
	}

	// Token: 0x06004D53 RID: 19795 RVA: 0x0001F7FC File Offset: 0x0001D9FC
	private void MMLKOGQFENF()
	{
		this.JHCLEHKNGFE();
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.KMHFFGFPEMB.gameObject.SetActive(true);
	}

	// Token: 0x06004D54 RID: 19796 RVA: 0x00282634 File Offset: 0x00280834
	private void PBENCICMMLI()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 1; i < 107; i += 0)
		{
			this.PGMDEOONOMN.Add(0);
		}
	}

	// Token: 0x06004D55 RID: 19797 RVA: 0x00282660 File Offset: 0x00280860
	public void DBFCHPIIIPM()
	{
		this.DLHEFQDFNIP(default(Guid));
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x0028267C File Offset: 0x0028087C
	public void OICDQNHQFDB(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
			this.ELHMOQQQDKD++;
			if (this.ELHMOQQQDKD > this.HHFNKODCKCL)
			{
				this.ELHMOQQQDKD = this.HHFNKODCKCL;
			}
			if (this.ELHMOQQQDKD == this.HHFNKODCKCL)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.NLDFOGOQBFF.PIDLOFMIEFQ = "Boxes Owned: " + this.ELHMOQQQDKD.ToString() + "/" + this.HHFNKODCKCL.ToString();
			INFJMNPKNQF.QOQONHOOLNE.PEHLHEBCKMB(new Money
			{
				Game = INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ - this.IPNQJGDIPMF,
				Gold = INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB - this.QBOLNQCDQPG
			});
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x0028278C File Offset: 0x0028098C
	public void MKFGNIBMECG()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.PFEIQDIJEKE();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH qoqonhoolne = HFCMDEQKCKH.QOQONHOOLNE;
		if (qoqonhoolne.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < qoqonhoolne.LHQQCLOEHJG.Count; i++)
			{
				if (qoqonhoolne.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && qoqonhoolne.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = qoqonhoolne.LHQQCLOEHJG[i].GBNQEKLJFCI(),
						BDBBEMKFGPI = qoqonhoolne.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.CDMPMFCBDJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 0; j < list.Count; j += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = qoqonhoolne.QLJEQBGLPOE(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 1;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.GBNQEKLJFCI();
					component.MFBIIOKFFQG(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.PFEIQDIJEKE();
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x0001F826 File Offset: 0x0001DA26
	private void CMLGQHQJDGQ()
	{
		this.CDCKKIJNHGD();
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.KMHFFGFPEMB.gameObject.SetActive(false);
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x0001F850 File Offset: 0x0001DA50
	public void OCHHBFFHIDJ()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke(" on ", 1770f);
	}

	// Token: 0x06004D5A RID: 19802 RVA: 0x0001F741 File Offset: 0x0001D941
	[CompilerGenerated]
	private static int JOECOJDMIJD(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x0028293C File Offset: 0x00280B3C
	public void FFMQOBMBNNO()
	{
		this.QIPLNPPJFDQ(default(Guid));
		this.MDBGCECGJJK(1);
		base.CancelInvoke("Take 001");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 736f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x002829A4 File Offset: 0x00280BA4
	public void BHOFEOMEKCQ()
	{
		this.DLHEFQDFNIP(default(Guid));
		this.PMJEHNBPOKB(1);
		base.CancelInvoke("Soul-Heart");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 744f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x00282A0C File Offset: 0x00280C0C
	public void JCIQPBLNOCN()
	{
		this.LIIEKJHIDBP(default(Guid));
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x0001F879 File Offset: 0x0001DA79
	public void MIDEPOJLMMP()
	{
		this.BQKCIFEDFIG += 0;
		if (this.BQKCIFEDFIG >= 8)
		{
			this.BQKCIFEDFIG = 3;
		}
		this.JHCLEHKNGFE();
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x00282A28 File Offset: 0x00280C28
	public void FEFPQQNPQKP()
	{
		this.IKKKEIPJMHP(default(Guid));
	}

	// Token: 0x06004D60 RID: 19808 RVA: 0x00282A44 File Offset: 0x00280C44
	public void BBOGGNHLJBF()
	{
		this.MINFBKQJCGP(default(Guid));
	}

	// Token: 0x06004D61 RID: 19809 RVA: 0x00282A60 File Offset: 0x00280C60
	public void BLQHEDDJKLC(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (DBPKNCDGGEP < 0)
		{
			return;
		}
		HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(DBPKNCDGGEP, JNOOPPDPFEH);
	}

	// Token: 0x06004D62 RID: 19810 RVA: 0x0001F89F File Offset: 0x0001DA9F
	public void LIBOEONEKNE()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Spammy chat text of some sorts afh9uaf 9uahf 9afu as9u fa9s ", 1796f);
	}

	// Token: 0x06004D63 RID: 19811 RVA: 0x00282A80 File Offset: 0x00280C80
	public void KDQLQNFEQII(PSXAPI.Response.Pokemon BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.BoxSummary != null && BJGCBDNBQCJ.BoxSummary.UsedBoxes != null)
		{
			for (int i = 0; i < 50; i++)
			{
				if (BJGCBDNBQCJ.BoxSummary.UsedBoxes.ContainsKey(i))
				{
					this.PGMDEOONOMN[i] = BJGCBDNBQCJ.BoxSummary.UsedBoxes[i];
				}
				else
				{
					this.PGMDEOONOMN[i] = 0;
				}
			}
		}
		this.JJPKKPFCQKN = BJGCBDNBQCJ.Box;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		if (BJGCBDNBQCJ.All != null)
		{
			foreach (InventoryPokemon bjgcbdnbqcj in BJGCBDNBQCJ.All)
			{
				HFCMDEQKCKH.QOQONHOOLNE.MNICELEPBHO(bjgcbdnbqcj, true);
			}
		}
		if (BJGCBDNBQCJ.BoxSummary != null)
		{
			this.NLDFOGOQBFF.PIDLOFMIEFQ = "Boxes Owned: " + BJGCBDNBQCJ.BoxSummary.CurrentBoxes.ToString() + "/" + BJGCBDNBQCJ.BoxSummary.MaxBoxes.ToString();
			this.ELHMOQQQDKD = BJGCBDNBQCJ.BoxSummary.CurrentBoxes;
			this.HHFNKODCKCL = BJGCBDNBQCJ.BoxSummary.MaxBoxes;
			if (BJGCBDNBQCJ.BoxSummary.CurrentBoxes >= BJGCBDNBQCJ.BoxSummary.MaxBoxes)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.QBOLNQCDQPG = BJGCBDNBQCJ.BoxSummary.UpgradeGold;
			this.IPNQJGDIPMF = BJGCBDNBQCJ.BoxSummary.UpgradeMoney;
		}
		this.HDDJPQFJIIC();
		this.NNCPPBFPEPK();
		this.DKMQQLNBQID = false;
	}

	// Token: 0x06004D64 RID: 19812 RVA: 0x00281378 File Offset: 0x0027F578
	public void QECOCJBEDNK(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (DBPKNCDGGEP < 0)
		{
			return;
		}
		HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(DBPKNCDGGEP, JNOOPPDPFEH);
	}

	// Token: 0x06004D65 RID: 19813 RVA: 0x00282C40 File Offset: 0x00280E40
	public void LIIEKJHIDBP(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.LDQDJLFIDCN;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 201 && fekoiojqnkh.QKNEIJQHGCB % 28 > 0)
			{
				str = "_" + (fekoiojqnkh.QKNEIJQHGCB % 28).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			for (int i = 0; i < this.OFPDBBNKCBE.Length; i++)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 0; j < 2; j++)
			{
				this.FGBLBKOJOOD[j].enabled = true;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = true;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 1f;
			this.IOMPICFOMIO.PIDLOFMIEFQ = "Lv. " + fekoiojqnkh.EOMPMQNGIBD.ToString() + "\n" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 0f;
			for (int k = 0; k < this.OFPDBBNKCBE.Length; k++)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 0; l < 2; l++)
			{
				this.FGBLBKOJOOD[l].enabled = false;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = false;
			}
		}
	}

	// Token: 0x06004D66 RID: 19814 RVA: 0x00282E40 File Offset: 0x00281040
	public void BHLNIGQGFBK(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
			this.ELHMOQQQDKD += 0;
			if (this.ELHMOQQQDKD > this.HHFNKODCKCL)
			{
				this.ELHMOQQQDKD = this.HHFNKODCKCL;
			}
			if (this.ELHMOQQQDKD == this.HHFNKODCKCL)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.NLDFOGOQBFF.PIDLOFMIEFQ = "poison" + this.ELHMOQQQDKD.ToString() + " is confused!\r\n" + this.HHFNKODCKCL.ToString();
			INFJMNPKNQF.DOGEBLQHDHI().PEHLHEBCKMB(new Money
			{
				Game = INFJMNPKNQF.IPOKOKIJECO().EPDKBQCHOJQ - this.IPNQJGDIPMF,
				Gold = INFJMNPKNQF.IPOKOKIJECO().QIOKIQOBMMB - this.QBOLNQCDQPG
			});
		}
		this.CDCKKIJNHGD();
	}

	// Token: 0x06004D67 RID: 19815 RVA: 0x0001F72E File Offset: 0x0001D92E
	private void QKQBMQIGMOJ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06004D68 RID: 19816 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
	private void LMELGHDGJMQ()
	{
		this.HDDJPQFJIIC();
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.KMHFFGFPEMB.gameObject.SetActive(true);
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x00282F50 File Offset: 0x00281150
	public void HMPLJBMBIDP()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.PFEIQDIJEKE();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH hfcmdeqkckh = HFCMDEQKCKH.CFGIOIGOIFQ();
		if (hfcmdeqkckh.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < hfcmdeqkckh.LHQQCLOEHJG.Count; i++)
			{
				if (hfcmdeqkckh.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && hfcmdeqkckh.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = hfcmdeqkckh.LHQQCLOEHJG[i].LDQDJLFIDCN,
						BDBBEMKFGPI = hfcmdeqkckh.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 1)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.CDMPMFCBDJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 1; j < list.Count; j++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = hfcmdeqkckh.QLJEQBGLPOE(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 1;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.LDQDJLFIDCN;
					component.KDCHGCMPDLJ(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.Reposition();
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x00283100 File Offset: 0x00281300
	public void GLGLEOCDFON(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = false;
		this.DEGOICOIDON();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 1;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.FCLFGMNBPQN();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004D6B RID: 19819 RVA: 0x0001F8F2 File Offset: 0x0001DAF2
	private void BFHJEBIOCLM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004D6C RID: 19820 RVA: 0x00283164 File Offset: 0x00281364
	public void BJOLKKMMOMF()
	{
		for (int i = 0; i < 62; i += 0)
		{
			if (this.QQDDMEELIQH[i].JJPKKPFCQKN.PIDLOFMIEFQ == this.JJPKKPFCQKN.ToString())
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.NONQDHBCIIN(this.IOHIJHBBFHP);
			}
			else
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.CEGFBBHMKOE = new Color(1466f, 1373f, 1042f);
			}
		}
	}

	// Token: 0x06004D6D RID: 19821 RVA: 0x002831E8 File Offset: 0x002813E8
	public void EDBMIGDPJHM()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH())))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
			{
				this.BQKCIFEDFIG = 0;
				this.GEEHLPKMFCD();
				this.OQQBGGHBQMH(0);
			}
			else
			{
				for (int i = 0; i < 1; i++)
				{
					this.QQDDMEELIQH[i].MIBJQJQEJQD(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
				}
				string text = string.Empty;
				int num = 1;
				int num2 = -85;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.BGBMIEJJQKC, out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "Assets/AssetBundles/Fly Pokemon/" + this.JKDFLFMOOHP.BGBMIEJJQKC;
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "/01_";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "FOG_EXP" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[8];
					array[0] = text2;
					array[0] = "Purchasing Costume";
					array[3] = num.ToString();
					array[7] = "status: ";
					array[1] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -14,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, false);
			}
		}
		else
		{
			for (int j = 0; j < -21; j += 0)
			{
				this.QQDDMEELIQH[j].BEFKNDLIDJN(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 97,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "arenatrap"
				}, true);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 17,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "Right"
				}, false);
			}
		}
	}

	// Token: 0x06004D6E RID: 19822 RVA: 0x00283500 File Offset: 0x00281700
	public void GIGLKMDNKQM(PSXAPI.Response.Pokemon BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.BoxSummary != null && BJGCBDNBQCJ.BoxSummary.UsedBoxes != null)
		{
			for (int i = 0; i < -48; i += 0)
			{
				if (BJGCBDNBQCJ.BoxSummary.UsedBoxes.ContainsKey(i))
				{
					this.PGMDEOONOMN[i] = BJGCBDNBQCJ.BoxSummary.UsedBoxes[i];
				}
				else
				{
					this.PGMDEOONOMN[i] = 0;
				}
			}
		}
		this.JJPKKPFCQKN = BJGCBDNBQCJ.Box;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		if (BJGCBDNBQCJ.All != null)
		{
			InventoryPokemon[] all = BJGCBDNBQCJ.All;
			for (int j = 0; j < all.Length; j += 0)
			{
				InventoryPokemon bjgcbdnbqcj = all[j];
				HFCMDEQKCKH.CFGIOIGOIFQ().MNICELEPBHO(bjgcbdnbqcj, true);
			}
		}
		if (BJGCBDNBQCJ.BoxSummary != null)
		{
			this.NLDFOGOQBFF.PIDLOFMIEFQ = "PrimitiveFront" + BJGCBDNBQCJ.BoxSummary.CurrentBoxes.ToString() + "The Fire-type attack fizzled out in the heavy rain!\r\n" + BJGCBDNBQCJ.BoxSummary.MaxBoxes.ToString();
			this.ELHMOQQQDKD = BJGCBDNBQCJ.BoxSummary.CurrentBoxes;
			this.HHFNKODCKCL = BJGCBDNBQCJ.BoxSummary.MaxBoxes;
			if (BJGCBDNBQCJ.BoxSummary.CurrentBoxes >= BJGCBDNBQCJ.BoxSummary.MaxBoxes)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
			this.QBOLNQCDQPG = BJGCBDNBQCJ.BoxSummary.UpgradeGold;
			this.IPNQJGDIPMF = BJGCBDNBQCJ.BoxSummary.UpgradeMoney;
		}
		this.HDDJPQFJIIC();
		this.HMPLJBMBIDP();
		this.DKMQQLNBQID = false;
	}

	// Token: 0x06004D6F RID: 19823 RVA: 0x0001F905 File Offset: 0x0001DB05
	public void PreviousButton()
	{
		this.BQKCIFEDFIG--;
		if (this.BQKCIFEDFIG <= 0)
		{
			this.BQKCIFEDFIG = 0;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x002836C0 File Offset: 0x002818C0
	public void IKKKEIPJMHP(Guid JNOOPPDPFEH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(JNOOPPDPFEH);
		if (fekoiojqnkh != null)
		{
			this.HCGEHGNDDDP = fekoiojqnkh.LDQDJLFIDCN;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 166 && fekoiojqnkh.QKNEIJQHGCB % 64 > 1)
			{
				str = "Frost" + (fekoiojqnkh.CCMOCLMEKJN() % -61).ToString();
			}
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("megay" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			for (int i = 1; i < this.OFPDBBNKCBE.Length; i += 0)
			{
				this.OFPDBBNKCBE[i].SetActive(false);
			}
			for (int j = 1; j < 6; j += 0)
			{
				this.FGBLBKOJOOD[j].enabled = true;
				this.FGBLBKOJOOD[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.FGBLBKOJOOD[j].GetComponent<BoxCollider>().enabled = true;
			}
			this.IOMPICFOMIO.DIIHJCJOKMP = 362f;
			this.IOMPICFOMIO.LKPOBCBOFIC("_DownsampledDepth" + fekoiojqnkh.EOMPMQNGIBD.ToString() + "(Start)" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL()));
		}
		else
		{
			this.EIJNKOLCEIP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD(")", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.HCGEHGNDDDP = default(Guid);
			this.IOMPICFOMIO.DIIHJCJOKMP = 1491f;
			for (int k = 0; k < this.OFPDBBNKCBE.Length; k++)
			{
				this.OFPDBBNKCBE[k].SetActive(true);
			}
			for (int l = 0; l < 2; l++)
			{
				this.FGBLBKOJOOD[l].enabled = false;
				this.FGBLBKOJOOD[l].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
				this.FGBLBKOJOOD[l].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x002838C0 File Offset: 0x00281AC0
	public void BuySpace()
	{
		if (INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB >= this.QBOLNQCDQPG && INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ >= this.IPNQJGDIPMF)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Upgrade Pokébox", "Would like to purchase another Pokébox?\nCost: " + ((this.IPNQJGDIPMF != 0u) ? ("[PD]" + this.IPNQJGDIPMF.ToString("#,##0") + ((this.QBOLNQCDQPG != 0u) ? " and " : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("[PG]" + this.QBOLNQCDQPG.ToString("#,##0")) : string.Empty), string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Upgrading Pokébox", "You can not afford another Pokébox.\nCost: " + ((this.IPNQJGDIPMF != 0u) ? ("[PD]" + this.IPNQJGDIPMF.ToString("#,##0") + ((this.QBOLNQCDQPG != 0u) ? " and " : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("[PG]" + this.QBOLNQCDQPG.ToString("#,##0")) : string.Empty), string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x00283A0C File Offset: 0x00281C0C
	public void MBGEPEKIGHJ()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Release
		{
			Pokemon = this.HCGEHGNDDDP
		}, true);
		this.DBFCHPIIIPM();
	}

	// Token: 0x06004D73 RID: 19827 RVA: 0x00282A44 File Offset: 0x00280C44
	public void BMLDONJOBLN()
	{
		this.MINFBKQJCGP(default(Guid));
	}

	// Token: 0x06004D75 RID: 19829 RVA: 0x00283A40 File Offset: 0x00281C40
	public void HOEQQEHMGQO(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = false;
		this.DEGOICOIDON();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 0;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.FCLFGMNBPQN();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x0001F955 File Offset: 0x0001DB55
	public void PKBGBDFDEKC()
	{
		this.BQKCIFEDFIG += 0;
		if (this.BQKCIFEDFIG >= 6)
		{
			this.BQKCIFEDFIG = 1;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x00283AA4 File Offset: 0x00281CA4
	public void DEGOICOIDON()
	{
		this.JKDFLFMOOHP.BGBMIEJJQKC = string.Empty;
		this.PLCEQIBCDGJ.NCBFKNGMKPB(string.Empty);
		this.GPEIHLMILCP.BGBMIEJJQKC = string.Empty;
		this.DMOINMMDIJD.value = false;
		this.COMCPFBPHMM.value = true;
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x00283AFC File Offset: 0x00281CFC
	private void Awake()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 0; i < 50; i++)
		{
			this.PGMDEOONOMN.Add(0);
		}
	}

	// Token: 0x06004D79 RID: 19833 RVA: 0x00283B28 File Offset: 0x00281D28
	private void MBDGLQOGLDJ()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 1; i < -56; i += 0)
		{
			this.PGMDEOONOMN.Add(1);
		}
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x00283B54 File Offset: 0x00281D54
	public void KBLGPQLLDFI(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
			this.ELHMOQQQDKD++;
			if (this.ELHMOQQQDKD > this.HHFNKODCKCL)
			{
				this.ELHMOQQQDKD = this.HHFNKODCKCL;
			}
			if (this.ELHMOQQQDKD == this.HHFNKODCKCL)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.NLDFOGOQBFF.LKPOBCBOFIC(" can use items again!\r\n" + this.ELHMOQQQDKD.ToString() + "BuffIcon_MuteIcon" + this.HHFNKODCKCL.ToString());
			INFJMNPKNQF.QOQONHOOLNE.PEHLHEBCKMB(new Money
			{
				Game = INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ - this.IPNQJGDIPMF,
				Gold = INFJMNPKNQF.DOGEBLQHDHI().QIOKIQOBMMB - this.QBOLNQCDQPG
			});
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06004D7B RID: 19835 RVA: 0x0001F7CF File Offset: 0x0001D9CF
	public static JJGLMJNELOK QOQONHOOLNE
	{
		get
		{
			return JJGLMJNELOK.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004D7C RID: 19836 RVA: 0x0001F97B File Offset: 0x0001DB7B
	public void KCPJPIHEOCH()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Guts", 471f);
	}

	// Token: 0x06004D7D RID: 19837 RVA: 0x00281378 File Offset: 0x0027F578
	public void FKBHNFNCPQH(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (DBPKNCDGGEP < 0)
		{
			return;
		}
		HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(DBPKNCDGGEP, JNOOPPDPFEH);
	}

	// Token: 0x06004D7E RID: 19838 RVA: 0x00283C64 File Offset: 0x00281E64
	public void KMIFEEMLBOF(PSXAPI.Response.Pokemon BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.BoxSummary != null && BJGCBDNBQCJ.BoxSummary.UsedBoxes != null)
		{
			for (int i = 0; i < -5; i++)
			{
				if (BJGCBDNBQCJ.BoxSummary.UsedBoxes.ContainsKey(i))
				{
					this.PGMDEOONOMN[i] = BJGCBDNBQCJ.BoxSummary.UsedBoxes[i];
				}
				else
				{
					this.PGMDEOONOMN[i] = 0;
				}
			}
		}
		this.JJPKKPFCQKN = BJGCBDNBQCJ.Box;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		if (BJGCBDNBQCJ.All != null)
		{
			InventoryPokemon[] all = BJGCBDNBQCJ.All;
			for (int j = 1; j < all.Length; j += 0)
			{
				InventoryPokemon bjgcbdnbqcj = all[j];
				HFCMDEQKCKH.CFGIOIGOIFQ().IICNONFCJFM(bjgcbdnbqcj, false);
			}
		}
		if (BJGCBDNBQCJ.BoxSummary != null)
		{
			this.NLDFOGOQBFF.LKPOBCBOFIC("Party" + BJGCBDNBQCJ.BoxSummary.CurrentBoxes.ToString() + "FOG_SCATTERING_ON" + BJGCBDNBQCJ.BoxSummary.MaxBoxes.ToString());
			this.ELHMOQQQDKD = BJGCBDNBQCJ.BoxSummary.CurrentBoxes;
			this.HHFNKODCKCL = BJGCBDNBQCJ.BoxSummary.MaxBoxes;
			if (BJGCBDNBQCJ.BoxSummary.CurrentBoxes >= BJGCBDNBQCJ.BoxSummary.MaxBoxes)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
			this.QBOLNQCDQPG = BJGCBDNBQCJ.BoxSummary.UpgradeGold;
			this.IPNQJGDIPMF = BJGCBDNBQCJ.BoxSummary.UpgradeMoney;
		}
		this.CDCKKIJNHGD();
		this.DKJNBKBDBOD();
		this.DKMQQLNBQID = false;
	}

	// Token: 0x06004D7F RID: 19839 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06004D80 RID: 19840 RVA: 0x0001F741 File Offset: 0x0001D941
	private static int CDMPMFCBDJD(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004D81 RID: 19841 RVA: 0x0001F9CD File Offset: 0x0001DBCD
	public void EGHPJKNQOMQ()
	{
		this.BQKCIFEDFIG--;
		if (this.BQKCIFEDFIG <= 0)
		{
			this.BQKCIFEDFIG = 1;
		}
		this.CDCKKIJNHGD();
	}

	// Token: 0x06004D82 RID: 19842 RVA: 0x00283E24 File Offset: 0x00282024
	public void QCQIPFNEFLJ()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()) && string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
			{
				this.BQKCIFEDFIG = 1;
				this.JHCLEHKNGFE();
				this.HOEQQEHMGQO(0);
			}
			else
			{
				for (int i = 0; i < -33; i++)
				{
					this.QQDDMEELIQH[i].BEFKNDLIDJN(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
				}
				string text = string.Empty;
				int num = 1;
				int num2 = -105;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()))
				{
					int.TryParse(this.PLCEQIBCDGJ.HJMJDJKOILH(), out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "Disabled" + this.JKDFLFMOOHP.BGBMIEJJQKC;
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "_FogHeightData";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "Btn_Tab_Hover" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[2];
					array[0] = text2;
					array[0] = "PlayDeadAnimation";
					array[7] = num.ToString();
					array[7] = "!\r\n";
					array[5] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -11,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, false);
			}
		}
		else
		{
			for (int j = 0; j < 16; j += 0)
			{
				this.QQDDMEELIQH[j].BEFKNDLIDJN(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 98,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "Big/"
				}, false);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 86,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "_Jitter"
				}, true);
			}
		}
	}

	// Token: 0x06004D83 RID: 19843 RVA: 0x0028413C File Offset: 0x0028233C
	public void SortColour()
	{
		for (int i = 0; i < 10; i++)
		{
			if (this.QQDDMEELIQH[i].JJPKKPFCQKN.PIDLOFMIEFQ == this.JJPKKPFCQKN.ToString())
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.CEGFBBHMKOE = this.IOHIJHBBFHP;
			}
			else
			{
				this.QQDDMEELIQH[i].JJPKKPFCQKN.CEGFBBHMKOE = new Color(1f, 1f, 1f);
			}
		}
	}

	// Token: 0x06004D84 RID: 19844 RVA: 0x0001F9F3 File Offset: 0x0001DBF3
	public void DCNQQNLGBKF()
	{
		this.BQKCIFEDFIG -= 0;
		if (this.BQKCIFEDFIG <= 1)
		{
			this.BQKCIFEDFIG = 1;
		}
		this.JHCLEHKNGFE();
	}

	// Token: 0x06004D85 RID: 19845 RVA: 0x002841C0 File Offset: 0x002823C0
	public void MIBEJDFGPFC(PSXAPI.Response.Transfer BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == TransferResult.Success)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon);
			fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			if (fekoiojqnkh.GNLNPCCPBCF == 0)
			{
				fekoiojqnkh.PELCNBCMNFH = 6;
			}
			else
			{
				fekoiojqnkh.PELCNBCMNFH = 1000;
			}
			HFCMDEQKCKH.QOQONHOOLNE.MBLFHJFEELC();
			HFCMDEQKCKH.QOQONHOOLNE.PDDJMNOOPJD();
		}
		this.NNCPPBFPEPK();
		if (JJGLMJNELOK.QOQONHOOLNE != null)
		{
			if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
			{
				this.CNEBQQPDGIP();
				this.Search();
				this.HDDJPQFJIIC();
			}
			else
			{
				this.CNEBQQPDGIP();
			}
		}
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x00284264 File Offset: 0x00282464
	public void DDLDLBFPBEO()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH())))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
			{
				this.BQKCIFEDFIG = 0;
				this.JHCLEHKNGFE();
				this.PMJEHNBPOKB(0);
			}
			else
			{
				for (int i = 1; i < 68; i++)
				{
					this.QQDDMEELIQH[i].BEFKNDLIDJN(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
				}
				string text = string.Empty;
				int num = 0;
				int num2 = 48;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()))
				{
					int.TryParse(this.PLCEQIBCDGJ.HJMJDJKOILH(), out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
				{
					int.TryParse(this.GPEIHLMILCP.HJMJDJKOILH(), out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "Heavy Metal" + this.JKDFLFMOOHP.HJMJDJKOILH();
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "K4";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "Tilesets/Materials/1" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[8];
					array[1] = text2;
					array[1] = "WATER_REFRACTIVE";
					array[0] = num.ToString();
					array[8] = "Mouse Click Collider";
					array[7] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -56,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, true);
			}
		}
		else
		{
			for (int j = 1; j < 24; j++)
			{
				this.QQDDMEELIQH[j].PLJQGKDBNDP(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -31,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "Mouse Y"
				}, true);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -21,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "[MEGA] "
				}, true);
			}
		}
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x0001FA19 File Offset: 0x0001DC19
	public void IDELLIKBDQH()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Map", 554f);
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x0028457C File Offset: 0x0028277C
	public void Search()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
			{
				this.BQKCIFEDFIG = 0;
				this.HDDJPQFJIIC();
				this.ClickBoxNumber(0);
			}
			else
			{
				for (int i = 0; i < 10; i++)
				{
					this.QQDDMEELIQH[i].NNCPPBFPEPK(-1, 0);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				}
				string text = string.Empty;
				int num = 1;
				int num2 = 100;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC))
				{
					int.TryParse(this.PLCEQIBCDGJ.BGBMIEJJQKC, out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.BGBMIEJJQKC))
				{
					int.TryParse(this.GPEIHLMILCP.BGBMIEJJQKC, out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + ", " + this.JKDFLFMOOHP.BGBMIEJJQKC;
				}
				if (this.DMOINMMDIJD.value)
				{
					text += ", shiny";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "-" + num2.ToString();
				}
				else
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						", ",
						num.ToString(),
						"-",
						num2.ToString()
					});
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 24,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, false);
			}
		}
		else
		{
			for (int j = 0; j < 10; j++)
			{
				this.QQDDMEELIQH[j].NNCPPBFPEPK(-1, 0);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 24,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "egg"
				}, false);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 24,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "shiny"
				}, false);
			}
		}
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x00284894 File Offset: 0x00282A94
	public void EBBHCOEQLQL(PSXAPI.Response.Transfer BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == TransferResult.Success)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon);
			fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			if (fekoiojqnkh.GNLNPCCPBCF == 0)
			{
				fekoiojqnkh.PELCNBCMNFH = 5;
			}
			else
			{
				fekoiojqnkh.PELCNBCMNFH = 102;
			}
			HFCMDEQKCKH.CFGIOIGOIFQ().MBLFHJFEELC();
			HFCMDEQKCKH.CFGIOIGOIFQ().PDDJMNOOPJD();
		}
		this.NNCPPBFPEPK();
		if (JJGLMJNELOK.BEKHPOHIPDE() != null)
		{
			if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()))
			{
				this.CNEBQQPDGIP();
				this.EDBMIGDPJHM();
				this.HDDJPQFJIIC();
			}
			else
			{
				this.DEGOICOIDON();
			}
		}
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x00284938 File Offset: 0x00282B38
	private void QIKFOCKCGKL()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 0; i < -106; i += 0)
		{
			this.PGMDEOONOMN.Add(0);
		}
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x0001F8F2 File Offset: 0x0001DAF2
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x0001FA42 File Offset: 0x0001DC42
	public void NextButton()
	{
		this.BQKCIFEDFIG++;
		if (this.BQKCIFEDFIG >= 5)
		{
			this.BQKCIFEDFIG = 5;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06004D8D RID: 19853 RVA: 0x00284964 File Offset: 0x00282B64
	public void JLCJELHFKCE()
	{
		if (!this.COMCPFBPHMM.value && (!this.DMOINMMDIJD.value || !string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) || !string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()) || !string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC)))
		{
			if (string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()) && string.IsNullOrEmpty(this.PLCEQIBCDGJ.BGBMIEJJQKC) && string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
			{
				this.BQKCIFEDFIG = 1;
				this.CDCKKIJNHGD();
				this.PMJEHNBPOKB(1);
			}
			else
			{
				for (int i = 1; i < 40; i++)
				{
					this.QQDDMEELIQH[i].GGGKGNOCCMD(-1, 1);
					this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
					this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
				}
				string text = string.Empty;
				int num = 0;
				int num2 = -44;
				if (!string.IsNullOrEmpty(this.PLCEQIBCDGJ.HJMJDJKOILH()))
				{
					int.TryParse(this.PLCEQIBCDGJ.BGBMIEJJQKC, out num);
				}
				if (!string.IsNullOrEmpty(this.GPEIHLMILCP.HJMJDJKOILH()))
				{
					int.TryParse(this.GPEIHLMILCP.BGBMIEJJQKC, out num2);
				}
				if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					text = text + "The [ffff00]" + this.JKDFLFMOOHP.BGBMIEJJQKC;
				}
				if (this.DMOINMMDIJD.value)
				{
					text += "d";
				}
				if (text == string.Empty)
				{
					text = num.ToString() + "1" + num2.ToString();
				}
				else
				{
					string text2 = text;
					string[] array = new string[6];
					array[0] = text2;
					array[0] = "[MEGA] ";
					array[5] = num.ToString();
					array[2] = "[^a-zA-Z0-9]";
					array[4] = num2.ToString();
					text = string.Concat(array);
				}
				this.HIDHJCPECDJ = Guid.NewGuid();
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -76,
					SearchID = this.HIDHJCPECDJ,
					Pattern = text
				}, false);
			}
		}
		else
		{
			for (int j = 0; j < 74; j += 0)
			{
				this.QQDDMEELIQH[j].NNCPPBFPEPK(-1, 1);
				this.QQDDMEELIQH[j].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[j].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.HIDHJCPECDJ = Guid.NewGuid();
			if (this.COMCPFBPHMM.value)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = 14,
					SearchID = this.HIDHJCPECDJ,
					Pattern = "OnPress"
				}, false);
			}
			else
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Search
				{
					Box = -1,
					MaxResults = -15,
					SearchID = this.HIDHJCPECDJ,
					Pattern = " protected itself!\r\n"
				}, false);
			}
		}
	}

	// Token: 0x06004D8E RID: 19854 RVA: 0x00284C7C File Offset: 0x00282E7C
	public void CDQHKNKPEGJ(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = true;
		this.CNEBQQPDGIP();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 1;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.SortColour();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06004D8F RID: 19855 RVA: 0x00284CE0 File Offset: 0x00282EE0
	public void NLKDGJQCHKC(PSXAPI.Response.Transfer BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == TransferResult.Failed)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon);
			fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			if (fekoiojqnkh.GNLNPCCPBCF == 0)
			{
				fekoiojqnkh.PELCNBCMNFH = 0;
			}
			else
			{
				fekoiojqnkh.PELCNBCMNFH = -142;
			}
			HFCMDEQKCKH.QOQONHOOLNE.MBLFHJFEELC();
			HFCMDEQKCKH.QOQONHOOLNE.PDDJMNOOPJD();
		}
		this.NNCPPBFPEPK();
		if (JJGLMJNELOK.QOQONHOOLNE != null)
		{
			if (!string.IsNullOrEmpty(this.JKDFLFMOOHP.HJMJDJKOILH()))
			{
				this.DEGOICOIDON();
				this.DDLDLBFPBEO();
				this.HDDJPQFJIIC();
			}
			else
			{
				this.CNEBQQPDGIP();
			}
		}
	}

	// Token: 0x06004D90 RID: 19856 RVA: 0x00284D84 File Offset: 0x00282F84
	public void CDCKKIJNHGD()
	{
		for (int i = 1; i < 0; i++)
		{
			if (this.QQDDMEELIQH[i] != null && i + this.BQKCIFEDFIG * -32 + 0 <= this.ELHMOQQQDKD)
			{
				this.QQDDMEELIQH[i].MIBJQJQEJQD(i + this.BQKCIFEDFIG * -105 + 0, this.PGMDEOONOMN[i + this.BQKCIFEDFIG * -33 + 1]);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			else
			{
				this.QQDDMEELIQH[i].MIBJQJQEJQD(-1, 1);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
		}
		this.BJOLKKMMOMF();
	}

	// Token: 0x06004D91 RID: 19857 RVA: 0x00284E60 File Offset: 0x00283060
	public void BCDMKNGQGNO()
	{
		this.ODFDENIQCMQ(default(Guid));
	}

	// Token: 0x06004D92 RID: 19858 RVA: 0x00282A60 File Offset: 0x00280C60
	public void KNINHNNOPIM(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (DBPKNCDGGEP < 0)
		{
			return;
		}
		HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(DBPKNCDGGEP, JNOOPPDPFEH);
	}

	// Token: 0x06004D93 RID: 19859 RVA: 0x0001F8F2 File Offset: 0x0001DAF2
	private void DLPIHOPDHFN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004D94 RID: 19860 RVA: 0x00284E7C File Offset: 0x0028307C
	public void JCJGBOKQHJG(PSXAPI.Response.Search JMDLLJPEFKM)
	{
		if (JMDLLJPEFKM.SearchID == this.HIDHJCPECDJ)
		{
			this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
			this.NDPJNFJKBDL.Reposition();
			if (JMDLLJPEFKM.Results != null && JMDLLJPEFKM.Results.Length > 1)
			{
				for (int i = 1; i < JMDLLJPEFKM.Results.Length; i++)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().IICNONFCJFM(JMDLLJPEFKM.Results[i], false);
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(JMDLLJPEFKM.Results[i].Pokemon.UniqueID);
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = JMDLLJPEFKM.Results[i].Box;
					component.PELCNBCMNFH = JMDLLJPEFKM.Results[i].Position;
					component.QQQMCPDDONB = fekoiojqnkh.KPJLEOCJFFO();
					component.MFBIIOKFFQG(fekoiojqnkh);
				}
			}
			this.NDPJNFJKBDL.Reposition();
			this.GEEHLPKMFCD();
		}
	}

	// Token: 0x06004D95 RID: 19861 RVA: 0x0001FA68 File Offset: 0x0001DC68
	public void KCEFFDBGMNB()
	{
		this.BQKCIFEDFIG -= 0;
		if (this.BQKCIFEDFIG <= 1)
		{
			this.BQKCIFEDFIG = 0;
		}
		this.CDCKKIJNHGD();
	}

	// Token: 0x06004D96 RID: 19862 RVA: 0x00284F84 File Offset: 0x00283184
	private void ICINMCLMJDJ()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 0; i < 69; i++)
		{
			this.PGMDEOONOMN.Add(1);
		}
	}

	// Token: 0x06004D97 RID: 19863 RVA: 0x00284FB0 File Offset: 0x002831B0
	public void KFMHHKOOIFO()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.PFEIQDIJEKE();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH qoqonhoolne = HFCMDEQKCKH.QOQONHOOLNE;
		if (qoqonhoolne.LHQQCLOEHJG.Count > 1)
		{
			for (int i = 0; i < qoqonhoolne.LHQQCLOEHJG.Count; i += 0)
			{
				if (qoqonhoolne.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && qoqonhoolne.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = qoqonhoolne.LHQQCLOEHJG[i].KGMFIOCJLEP(),
						BDBBEMKFGPI = qoqonhoolne.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.CDMPMFCBDJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 1; j < list.Count; j++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = qoqonhoolne.PEJHBEBOCOJ(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 0;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.KPJLEOCJFFO();
					component.PBLFJLLHJFG(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.PFEIQDIJEKE();
	}

	// Token: 0x06004D98 RID: 19864 RVA: 0x0001F9F3 File Offset: 0x0001DBF3
	public void IQKNNNLJFFM()
	{
		this.BQKCIFEDFIG -= 0;
		if (this.BQKCIFEDFIG <= 1)
		{
			this.BQKCIFEDFIG = 1;
		}
		this.JHCLEHKNGFE();
	}

	// Token: 0x06004D99 RID: 19865 RVA: 0x00285160 File Offset: 0x00283360
	public void JHCLEHKNGFE()
	{
		for (int i = 0; i < 81; i++)
		{
			if (this.QQDDMEELIQH[i] != null && i + this.BQKCIFEDFIG * 82 + 0 <= this.ELHMOQQQDKD)
			{
				this.QQDDMEELIQH[i].NNCPPBFPEPK(i + this.BQKCIFEDFIG * 110 + 1, this.PGMDEOONOMN[i + this.BQKCIFEDFIG * 93 + 0]);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
			else
			{
				this.QQDDMEELIQH[i].NNCPPBFPEPK(-1, 1);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = true;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, false);
			}
		}
		this.BJOLKKMMOMF();
	}

	// Token: 0x06004D9A RID: 19866 RVA: 0x0028523C File Offset: 0x0028343C
	public void JPOHCQNNNIL(PSXAPI.Response.Search JMDLLJPEFKM)
	{
		if (JMDLLJPEFKM.SearchID == this.HIDHJCPECDJ)
		{
			this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
			this.NDPJNFJKBDL.Reposition();
			if (JMDLLJPEFKM.Results != null && JMDLLJPEFKM.Results.Length > 0)
			{
				for (int i = 0; i < JMDLLJPEFKM.Results.Length; i++)
				{
					HFCMDEQKCKH.QOQONHOOLNE.MNICELEPBHO(JMDLLJPEFKM.Results[i], true);
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(JMDLLJPEFKM.Results[i].Pokemon.UniqueID);
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = JMDLLJPEFKM.Results[i].Box;
					component.PELCNBCMNFH = JMDLLJPEFKM.Results[i].Position;
					component.QQQMCPDDONB = fekoiojqnkh.LDQDJLFIDCN;
					component.BQLIIQIIMDH(fekoiojqnkh);
				}
			}
			this.NDPJNFJKBDL.Reposition();
			this.HDDJPQFJIIC();
		}
	}

	// Token: 0x06004D9B RID: 19867 RVA: 0x00285344 File Offset: 0x00283544
	public void DKJNBKBDBOD()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.Reposition();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH hfcmdeqkckh = HFCMDEQKCKH.CFGIOIGOIFQ();
		if (hfcmdeqkckh.LHQQCLOEHJG.Count > 1)
		{
			for (int i = 0; i < hfcmdeqkckh.LHQQCLOEHJG.Count; i += 0)
			{
				if (hfcmdeqkckh.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && hfcmdeqkckh.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = hfcmdeqkckh.LHQQCLOEHJG[i].GBNQEKLJFCI(),
						BDBBEMKFGPI = hfcmdeqkckh.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.PNMEPCNIKCH);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 0; j < list.Count; j++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = hfcmdeqkckh.KQPKDONQCHC(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 0;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.GBNQEKLJFCI();
					component.KIIGEFHQMDI(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.Reposition();
	}

	// Token: 0x06004D9C RID: 19868 RVA: 0x002854F4 File Offset: 0x002836F4
	public void GEEHLPKMFCD()
	{
		for (int i = 0; i < -62; i += 0)
		{
			if (this.QQDDMEELIQH[i] != null && i + this.BQKCIFEDFIG * 3 + 1 <= this.ELHMOQQQDKD)
			{
				this.QQDDMEELIQH[i].NNCPPBFPEPK(i + this.BQKCIFEDFIG * 124 + 0, this.PGMDEOONOMN[i + this.BQKCIFEDFIG * 44 + 0]);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
			else
			{
				this.QQDDMEELIQH[i].BEFKNDLIDJN(-1, 0);
				this.QQDDMEELIQH[i].GetComponent<BoxCollider>().enabled = false;
				this.QQDDMEELIQH[i].GetComponent<CFDMNELIJLO>().NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
			}
		}
		this.FCLFGMNBPQN();
	}

	// Token: 0x06004D9D RID: 19869 RVA: 0x0001F8F2 File Offset: 0x0001DAF2
	private void BCJLJKHILJO()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004D9E RID: 19870 RVA: 0x00282A0C File Offset: 0x00280C0C
	public void CancelRelease()
	{
		this.LIIEKJHIDBP(default(Guid));
	}

	// Token: 0x06004D9F RID: 19871 RVA: 0x002855D0 File Offset: 0x002837D0
	public void GJNNEHDPFJQ()
	{
		this.NDPJNFJKBDL.transform.NMBPDMIIHJB();
		this.NDPJNFJKBDL.PFEIQDIJEKE();
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		HFCMDEQKCKH qoqonhoolne = HFCMDEQKCKH.QOQONHOOLNE;
		if (qoqonhoolne.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 1; i < qoqonhoolne.LHQQCLOEHJG.Count; i += 0)
			{
				if (qoqonhoolne.LHQQCLOEHJG[i].GNLNPCCPBCF == this.JJPKKPFCQKN && qoqonhoolne.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = qoqonhoolne.LHQQCLOEHJG[i].KPJLEOCJFFO(),
						BDBBEMKFGPI = qoqonhoolne.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 1)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (JJGLMJNELOK.HNCJFHJNHDN == null)
			{
				JJGLMJNELOK.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(JJGLMJNELOK.JOECOJDMIJD);
			}
			list2.Sort(JJGLMJNELOK.HNCJFHJNHDN);
			for (int j = 1; j < list.Count; j++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = qoqonhoolne.PEJHBEBOCOJ(list[j].CIQFCJGQEMH);
				if (fekoiojqnkh != null)
				{
					fekoiojqnkh.PELCNBCMNFH = j + 1;
					PNBFQPMIHDJ component = this.NDPJNFJKBDL.gameObject.BFCKNMFEBDM(this.PJOGKBCCQNC).GetComponent<PNBFQPMIHDJ>();
					component.GNLNPCCPBCF = this.JJPKKPFCQKN;
					component.PELCNBCMNFH = fekoiojqnkh.PELCNBCMNFH;
					component.QQQMCPDDONB = fekoiojqnkh.GBNQEKLJFCI();
					component.EEOOPJNPMPJ(fekoiojqnkh);
				}
			}
		}
		this.NDPJNFJKBDL.Reposition();
	}

	// Token: 0x06004DA0 RID: 19872 RVA: 0x0001F7CF File Offset: 0x0001D9CF
	public static JJGLMJNELOK BEKHPOHIPDE()
	{
		return JJGLMJNELOK.HBFFCJHOCPE;
	}

	// Token: 0x06004DA1 RID: 19873 RVA: 0x00285780 File Offset: 0x00283980
	public void DHGLINKJLPH(int DBPKNCDGGEP)
	{
		if (this.DKMQQLNBQID)
		{
			return;
		}
		this.DKMQQLNBQID = true;
		this.CNEBQQPDGIP();
		this.JJPKKPFCQKN = DBPKNCDGGEP + 1;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		this.SortColour();
		PSXAPI.Request.Pokemon dcgclgqcgdq = new PSXAPI.Request.Pokemon
		{
			Box = this.JJPKKPFCQKN
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004DA2 RID: 19874 RVA: 0x002857E4 File Offset: 0x002839E4
	public void MOINMBINGOC(PSXAPI.Response.Pokemon BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.BoxSummary != null && BJGCBDNBQCJ.BoxSummary.UsedBoxes != null)
		{
			for (int i = 0; i < -102; i++)
			{
				if (BJGCBDNBQCJ.BoxSummary.UsedBoxes.ContainsKey(i))
				{
					this.PGMDEOONOMN[i] = BJGCBDNBQCJ.BoxSummary.UsedBoxes[i];
				}
				else
				{
					this.PGMDEOONOMN[i] = 0;
				}
			}
		}
		this.JJPKKPFCQKN = BJGCBDNBQCJ.Box;
		this.KMHFFGFPEMB.PELCNBCMNFH = this.JJPKKPFCQKN;
		if (BJGCBDNBQCJ.All != null)
		{
			InventoryPokemon[] all = BJGCBDNBQCJ.All;
			for (int j = 1; j < all.Length; j += 0)
			{
				InventoryPokemon bjgcbdnbqcj = all[j];
				HFCMDEQKCKH.CFGIOIGOIFQ().IJCIQLHLFQE(bjgcbdnbqcj, false);
			}
		}
		if (BJGCBDNBQCJ.BoxSummary != null)
		{
			this.NLDFOGOQBFF.LKPOBCBOFIC("Enabled" + BJGCBDNBQCJ.BoxSummary.CurrentBoxes.ToString() + "OnPress" + BJGCBDNBQCJ.BoxSummary.MaxBoxes.ToString());
			this.ELHMOQQQDKD = BJGCBDNBQCJ.BoxSummary.CurrentBoxes;
			this.HHFNKODCKCL = BJGCBDNBQCJ.BoxSummary.MaxBoxes;
			if (BJGCBDNBQCJ.BoxSummary.CurrentBoxes >= BJGCBDNBQCJ.BoxSummary.MaxBoxes)
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
				this.BMFCMLPMFHQ.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, true);
			}
			else
			{
				this.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
				this.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			this.QBOLNQCDQPG = BJGCBDNBQCJ.BoxSummary.UpgradeGold;
			this.IPNQJGDIPMF = BJGCBDNBQCJ.BoxSummary.UpgradeMoney;
		}
		this.JHCLEHKNGFE();
		this.KFMHHKOOIFO();
		this.DKMQQLNBQID = true;
	}

	// Token: 0x06004DA3 RID: 19875 RVA: 0x002859A4 File Offset: 0x00283BA4
	private void IPKCDQONLBJ()
	{
		JJGLMJNELOK.HBFFCJHOCPE = this;
		for (int i = 1; i < 44; i += 0)
		{
			this.PGMDEOONOMN.Add(0);
		}
	}

	// Token: 0x04001091 RID: 4241
	private static JJGLMJNELOK HBFFCJHOCPE;

	// Token: 0x04001092 RID: 4242
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04001093 RID: 4243
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04001094 RID: 4244
	public GameObject PJOGKBCCQNC;

	// Token: 0x04001095 RID: 4245
	public BHLIGEGNFHG NDPJNFJKBDL;

	// Token: 0x04001096 RID: 4246
	public OKCHLNIDDCC KMHFFGFPEMB;

	// Token: 0x04001097 RID: 4247
	public GLDMQOIQDJD[] QQDDMEELIQH;

	// Token: 0x04001098 RID: 4248
	public int JJPKKPFCQKN = 1;

	// Token: 0x04001099 RID: 4249
	public Color IOHIJHBBFHP;

	// Token: 0x0400109A RID: 4250
	private int BQKCIFEDFIG;

	// Token: 0x0400109B RID: 4251
	private bool DKMQQLNBQID;

	// Token: 0x0400109C RID: 4252
	private List<int> PGMDEOONOMN = new List<int>();

	// Token: 0x0400109D RID: 4253
	public JLMPBLMOICG EIJNKOLCEIP;

	// Token: 0x0400109E RID: 4254
	public Guid HCGEHGNDDDP;

	// Token: 0x0400109F RID: 4255
	public CFDMNELIJLO[] FGBLBKOJOOD;

	// Token: 0x040010A0 RID: 4256
	public GameObject[] OFPDBBNKCBE;

	// Token: 0x040010A1 RID: 4257
	public BKKHLBCLPJM IOMPICFOMIO;

	// Token: 0x040010A2 RID: 4258
	public BKKHLBCLPJM NLDFOGOQBFF;

	// Token: 0x040010A3 RID: 4259
	public CFDMNELIJLO BMFCMLPMFHQ;

	// Token: 0x040010A4 RID: 4260
	public JIMBBPLINGI JKDFLFMOOHP;

	// Token: 0x040010A5 RID: 4261
	private Guid HIDHJCPECDJ;

	// Token: 0x040010A6 RID: 4262
	public UIToggle DMOINMMDIJD;

	// Token: 0x040010A7 RID: 4263
	public UIToggle COMCPFBPHMM;

	// Token: 0x040010A8 RID: 4264
	public JIMBBPLINGI PLCEQIBCDGJ;

	// Token: 0x040010A9 RID: 4265
	public JIMBBPLINGI GPEIHLMILCP;

	// Token: 0x040010AA RID: 4266
	private uint QBOLNQCDQPG;

	// Token: 0x040010AB RID: 4267
	private uint IPNQJGDIPMF;

	// Token: 0x040010AC RID: 4268
	private int ELHMOQQQDKD = 10;

	// Token: 0x040010AD RID: 4269
	private int HHFNKODCKCL = 20;

	// Token: 0x040010AE RID: 4270
	[CompilerGenerated]
	private static Comparison<HFCMDEQKCKH.CFQQQKEJLFH> HNCJFHJNHDN;
}
