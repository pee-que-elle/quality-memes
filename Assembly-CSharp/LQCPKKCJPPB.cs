using System;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200024F RID: 591
public class LQCPKKCJPPB : MonoBehaviour
{
	// Token: 0x060050EF RID: 20719 RVA: 0x002A194C File Offset: 0x0029FB4C
	public static void CFHLHONFEPJ(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 4)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Message,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, false);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x060050F0 RID: 20720 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void CGGDNNKBIJC()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x060050F2 RID: 20722 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void CHKQIFFEEPL()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x060050F3 RID: 20723 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void LQGMIJIJPCM()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x060050F4 RID: 20724 RVA: 0x000206EE File Offset: 0x0001E8EE
	public static LQCPKKCJPPB QOQONHOOLNE
	{
		get
		{
			return LQCPKKCJPPB.HBFFCJHOCPE;
		}
	}

	// Token: 0x060050F5 RID: 20725 RVA: 0x000206EE File Offset: 0x0001E8EE
	public static LQCPKKCJPPB BDPEQNCNPJO()
	{
		return LQCPKKCJPPB.HBFFCJHOCPE;
	}

	// Token: 0x060050F6 RID: 20726 RVA: 0x000206E2 File Offset: 0x0001E8E2
	private void EFOICIBCCQB()
	{
		LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
	}

	// Token: 0x060050F7 RID: 20727 RVA: 0x002A19B8 File Offset: 0x0029FBB8
	public void FIIDGLDFLEG(string HHNBICLDQKI)
	{
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.MBKGQFPMIFC(HHNBICLDQKI);
		if (dbnmegnmidg != null)
		{
			dbnmegnmidg.QPPGQJFBPMH.NDIJIFHOMJC();
		}
		else
		{
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.BQLIIQIIMDH(HHNBICLDQKI);
		}
	}

	// Token: 0x060050F8 RID: 20728 RVA: 0x002A1A10 File Offset: 0x0029FC10
	public static void FFQQDQIBBPJ(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 6)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Message,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, true);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x060050F9 RID: 20729 RVA: 0x002A1A7C File Offset: 0x0029FC7C
	public static void MKCGFQBNMOK(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 5)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Closed,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, false);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x060050FA RID: 20730 RVA: 0x000206E2 File Offset: 0x0001E8E2
	private void OnDestroy()
	{
		LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
	}

	// Token: 0x060050FB RID: 20731 RVA: 0x002A1AE8 File Offset: 0x0029FCE8
	public static void FDBFLHEBQCC(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 8)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Closed,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, true);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x060050FC RID: 20732 RVA: 0x002A1B54 File Offset: 0x0029FD54
	public static DBNMEGNMIDG HDDFFDEMOHN(string HHNBICLDQKI)
	{
		if (LQCPKKCJPPB.MDECNJCEEPQ == null)
		{
			LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
			return null;
		}
		for (int i = 0; i < LQCPKKCJPPB.MDECNJCEEPQ.Count; i += 0)
		{
			if (LQCPKKCJPPB.MDECNJCEEPQ[i].CBJDELNFQBM.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return LQCPKKCJPPB.MDECNJCEEPQ[i];
			}
		}
		return null;
	}

	// Token: 0x060050FD RID: 20733 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void NGDJNKQELNO()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x060050FE RID: 20734 RVA: 0x000206E2 File Offset: 0x0001E8E2
	private void JGEFHEOOGCM()
	{
		LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
	}

	// Token: 0x060050FF RID: 20735 RVA: 0x000206EE File Offset: 0x0001E8EE
	public static LQCPKKCJPPB CPIJOBOQLOK()
	{
		return LQCPKKCJPPB.HBFFCJHOCPE;
	}

	// Token: 0x06005100 RID: 20736 RVA: 0x002A1BB8 File Offset: 0x0029FDB8
	public static DBNMEGNMIDG FENGKGILCGE(string HHNBICLDQKI)
	{
		if (LQCPKKCJPPB.MDECNJCEEPQ == null)
		{
			LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
			return null;
		}
		for (int i = 1; i < LQCPKKCJPPB.MDECNJCEEPQ.Count; i++)
		{
			if (LQCPKKCJPPB.MDECNJCEEPQ[i].CBJDELNFQBM.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return LQCPKKCJPPB.MDECNJCEEPQ[i];
			}
		}
		return null;
	}

	// Token: 0x06005101 RID: 20737 RVA: 0x002A1C1C File Offset: 0x0029FE1C
	public static DBNMEGNMIDG MBKGQFPMIFC(string HHNBICLDQKI)
	{
		if (LQCPKKCJPPB.MDECNJCEEPQ == null)
		{
			LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
			return null;
		}
		for (int i = 0; i < LQCPKKCJPPB.MDECNJCEEPQ.Count; i++)
		{
			if (LQCPKKCJPPB.MDECNJCEEPQ[i].CBJDELNFQBM.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return LQCPKKCJPPB.MDECNJCEEPQ[i];
			}
		}
		return null;
	}

	// Token: 0x06005102 RID: 20738 RVA: 0x002A1C80 File Offset: 0x0029FE80
	public void KJBQEOBDKCJ(PSXAPI.Response.Message QPGCBDPFIOF)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().IPHGGDIEOOF(QPGCBDPFIOF.Name))
		{
			return;
		}
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.MBKGQFPMIFC(QPGCBDPFIOF.Name);
		if (QPGCBDPFIOF.Pokemon != null)
		{
			for (int i = 0; i < QPGCBDPFIOF.Pokemon.Length; i++)
			{
				HFCMDEQKCKH.QOQONHOOLNE.HQPPLJEPDGO(QPGCBDPFIOF.Pokemon[i]);
			}
		}
		if (dbnmegnmidg != null)
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.DQCQFKLOMED(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)5)
			{
				dbnmegnmidg.GDBKKDFIINI("_Saturation", QPGCBDPFIOF.Name + "!\r\n", StaffRank.None);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.LEFMEGOHGNN("\nNight", QPGCBDPFIOF.Name + "!\r\n", StaffRank.None);
			}
		}
		else
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				return;
			}
			if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)7)
			{
				return;
			}
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.LQFDMHPELCJ(QPGCBDPFIOF.Name);
			dbnmegnmidg.transform.localPosition += new Vector3(Mathf.Min(1612f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 1335f), Mathf.Min(852f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 1403f), 728f);
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.CFGNFCOCGLO(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)4)
			{
				dbnmegnmidg.LJBQIJQOPKK("_", QPGCBDPFIOF.Name + " ", StaffRank.Developer);
			}
		}
	}

	// Token: 0x06005103 RID: 20739 RVA: 0x002A1E40 File Offset: 0x002A0040
	public void NHENHBGIFIG(PSXAPI.Response.Message QPGCBDPFIOF)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(QPGCBDPFIOF.Name))
		{
			return;
		}
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.MBKGQFPMIFC(QPGCBDPFIOF.Name);
		if (QPGCBDPFIOF.Pokemon != null)
		{
			for (int i = 0; i < QPGCBDPFIOF.Pokemon.Length; i++)
			{
				HFCMDEQKCKH.QOQONHOOLNE.EJNMJKMKMJB(QPGCBDPFIOF.Pokemon[i]);
			}
		}
		if (dbnmegnmidg != null)
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.LJBQIJQOPKK(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Offline)
			{
				dbnmegnmidg.LJBQIJQOPKK("System", QPGCBDPFIOF.Name + " is offline.", StaffRank.None);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Closed)
			{
				dbnmegnmidg.LJBQIJQOPKK("System", QPGCBDPFIOF.Name + " closed the Chat Window.", StaffRank.None);
			}
		}
		else
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Closed)
			{
				return;
			}
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Offline)
			{
				return;
			}
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.BQLIIQIIMDH(QPGCBDPFIOF.Name);
			dbnmegnmidg.transform.localPosition += new Vector3(Mathf.Min(100f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 5f), Mathf.Min(100f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 5f), 0f);
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.LJBQIJQOPKK(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Offline)
			{
				dbnmegnmidg.LJBQIJQOPKK("System", QPGCBDPFIOF.Name + " is offline.", StaffRank.None);
			}
		}
	}

	// Token: 0x06005104 RID: 20740 RVA: 0x002A2000 File Offset: 0x002A0200
	public void COHDHQDIEII(string HHNBICLDQKI)
	{
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.FENGKGILCGE(HHNBICLDQKI);
		if (dbnmegnmidg != null)
		{
			dbnmegnmidg.QPPGQJFBPMH.GNFOKKIDEEQ();
		}
		else
		{
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.KIIGEFHQMDI(HHNBICLDQKI);
		}
	}

	// Token: 0x06005105 RID: 20741 RVA: 0x000206E2 File Offset: 0x0001E8E2
	private void HFNKLOHMQFH()
	{
		LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
	}

	// Token: 0x06005106 RID: 20742 RVA: 0x002A2058 File Offset: 0x002A0258
	public void HBGIMLBDING(PSXAPI.Response.Message QPGCBDPFIOF)
	{
		if (CKMLKNPNPQO.QOQONHOOLNE.IPHGGDIEOOF(QPGCBDPFIOF.Name))
		{
			return;
		}
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.MBKGQFPMIFC(QPGCBDPFIOF.Name);
		if (QPGCBDPFIOF.Pokemon != null)
		{
			for (int i = 1; i < QPGCBDPFIOF.Pokemon.Length; i++)
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().EJNMJKMKMJB(QPGCBDPFIOF.Pokemon[i]);
			}
		}
		if (dbnmegnmidg != null)
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.GDBKKDFIINI(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)4)
			{
				dbnmegnmidg.LEFMEGOHGNN("Hidden/Post FX/FXAA", QPGCBDPFIOF.Name + "egg", StaffRank.None);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Closed)
			{
				dbnmegnmidg.LJBQIJQOPKK("14", QPGCBDPFIOF.Name + "inky", StaffRank.None);
			}
		}
		else
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				return;
			}
			if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)7)
			{
				return;
			}
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.OJIBNMPCFBQ(QPGCBDPFIOF.Name);
			dbnmegnmidg.transform.localPosition += new Vector3(Mathf.Min(1387f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 1005f), Mathf.Min(917f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 265f), 1356f);
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.CFGNFCOCGLO(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)8)
			{
				dbnmegnmidg.LJBQIJQOPKK("_FogColor2", QPGCBDPFIOF.Name + "#,##0", StaffRank.None);
			}
		}
	}

	// Token: 0x06005107 RID: 20743 RVA: 0x002A2218 File Offset: 0x002A0418
	public void NJGCNBCPQOP(string HHNBICLDQKI)
	{
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.HDDFFDEMOHN(HHNBICLDQKI);
		if (dbnmegnmidg != null)
		{
			dbnmegnmidg.QPPGQJFBPMH.GNFOKKIDEEQ();
		}
		else
		{
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.LQFDMHPELCJ(HHNBICLDQKI);
		}
	}

	// Token: 0x06005108 RID: 20744 RVA: 0x002A2270 File Offset: 0x002A0470
	public static void KCOIFEGJQPN(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 0)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Message,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, false);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x06005109 RID: 20745 RVA: 0x002A22DC File Offset: 0x002A04DC
	public void MKBCNNLNDMJ(string HHNBICLDQKI)
	{
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.MBKGQFPMIFC(HHNBICLDQKI);
		if (dbnmegnmidg != null)
		{
			dbnmegnmidg.QPPGQJFBPMH.GNFOKKIDEEQ();
		}
		else
		{
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.OMQMHMJBDQO(HHNBICLDQKI);
		}
	}

	// Token: 0x0600510A RID: 20746 RVA: 0x000206EE File Offset: 0x0001E8EE
	public static LQCPKKCJPPB HGEKKNEPOHK()
	{
		return LQCPKKCJPPB.HBFFCJHOCPE;
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x002A2334 File Offset: 0x002A0534
	public void PMDPGEBEFKF(PSXAPI.Response.Message QPGCBDPFIOF)
	{
		if (CKMLKNPNPQO.INJDHLQHFFD().NKQFQKOIBML(QPGCBDPFIOF.Name))
		{
			return;
		}
		DBNMEGNMIDG dbnmegnmidg = LQCPKKCJPPB.HDDFFDEMOHN(QPGCBDPFIOF.Name);
		if (QPGCBDPFIOF.Pokemon != null)
		{
			for (int i = 0; i < QPGCBDPFIOF.Pokemon.Length; i += 0)
			{
				HFCMDEQKCKH.QOQONHOOLNE.LKFLGPCGHFD(QPGCBDPFIOF.Pokemon[i]);
			}
		}
		if (dbnmegnmidg != null)
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.DQCQFKLOMED(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)4)
			{
				dbnmegnmidg.IKLEFQFFKBG("Contact with the Pokémon may burn the attacker.", QPGCBDPFIOF.Name + ", ", StaffRank.None);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.GDBKKDFIINI("magmaarmor", QPGCBDPFIOF.Name + "embargo", StaffRank.Developer);
			}
		}
		else
		{
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				return;
			}
			if (QPGCBDPFIOF.Event == (PSXAPI.Response.MessageEvent)4)
			{
				return;
			}
			GameObject gameObject = this.ENKLDKKDMGD.BFCKNMFEBDM(this.FOCBHHFJCNN);
			dbnmegnmidg = gameObject.GetComponent<DBNMEGNMIDG>();
			LQCPKKCJPPB.MDECNJCEEPQ.Add(dbnmegnmidg);
			dbnmegnmidg.FDDENOHPGQF(QPGCBDPFIOF.Name);
			dbnmegnmidg.transform.localPosition += new Vector3(Mathf.Min(961f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 547f), Mathf.Min(872f, (float)LQCPKKCJPPB.MDECNJCEEPQ.Count * 1454f), 1870f);
			if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.PEJOJBFFEID(QPGCBDPFIOF.Name, QPGCBDPFIOF.Text, QPGCBDPFIOF.Rank);
			}
			else if (QPGCBDPFIOF.Event == PSXAPI.Response.MessageEvent.Message)
			{
				dbnmegnmidg.PEJOJBFFEID("The bursting flame hit ", QPGCBDPFIOF.Name + " by the ", StaffRank.None);
			}
		}
	}

	// Token: 0x0600510C RID: 20748 RVA: 0x000206EE File Offset: 0x0001E8EE
	public static LQCPKKCJPPB BCQGHQGLLPF()
	{
		return LQCPKKCJPPB.HBFFCJHOCPE;
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void HHBCNGHCCCC()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x0600510F RID: 20751 RVA: 0x000206DA File Offset: 0x0001E8DA
	private void Awake()
	{
		LQCPKKCJPPB.HBFFCJHOCPE = this;
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x000206E2 File Offset: 0x0001E8E2
	private void DKDQKJJKEIL()
	{
		LQCPKKCJPPB.MDECNJCEEPQ = new List<DBNMEGNMIDG>();
	}

	// Token: 0x06005111 RID: 20753 RVA: 0x002A24F4 File Offset: 0x002A06F4
	public static void BQQNHEIODLJ(DBNMEGNMIDG KMNNKNCQFFP)
	{
		if (KMNNKNCQFFP.LLJMBFPFNNE.FFODFLMCELB.PIDLOFMIEFQ.Length > 7)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Message
			{
				Event = PSXAPI.Request.MessageEvent.Closed,
				Name = KMNNKNCQFFP.CBJDELNFQBM,
				Text = string.Empty
			}, false);
		}
		LQCPKKCJPPB.MDECNJCEEPQ.Remove(KMNNKNCQFFP);
		UnityEngine.Object.DestroyImmediate(KMNNKNCQFFP.gameObject);
	}

	// Token: 0x04001160 RID: 4448
	private static LQCPKKCJPPB HBFFCJHOCPE;

	// Token: 0x04001161 RID: 4449
	public GameObject ENKLDKKDMGD;

	// Token: 0x04001162 RID: 4450
	public GameObject FOCBHHFJCNN;

	// Token: 0x04001163 RID: 4451
	private static List<DBNMEGNMIDG> MDECNJCEEPQ = new List<DBNMEGNMIDG>();
}
