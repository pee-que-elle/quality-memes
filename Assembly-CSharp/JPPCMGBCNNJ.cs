using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000131 RID: 305
public class JPPCMGBCNNJ : MonoBehaviour
{
	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060023BE RID: 9150 RVA: 0x0001337D File Offset: 0x0001157D
	public static JPPCMGBCNNJ QOQONHOOLNE
	{
		get
		{
			return JPPCMGBCNNJ.HBFFCJHOCPE;
		}
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x00013384 File Offset: 0x00011584
	private void Start()
	{
		this.JBLQIEPJLPN = LPEQICNMHIL.QOQONHOOLNE;
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000EA894 File Offset: 0x000E8A94
	public void NKEGOKKFLCE()
	{
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		this.JJCEJMHHCDL = 1;
		this.BMIIEIIHQQQ();
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x00013391 File Offset: 0x00011591
	private void PFHLIFGFICQ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x00013391 File Offset: 0x00011591
	private void GDEHFIDDLOJ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000133A4 File Offset: 0x000115A4
	public void IEHBFCPMOPL(PSXAPI.Response.Achievements ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC.Username == null)
		{
			this.HLHKMMNMDNC = ECHMFPQNBMC.List.ToList<Achievement>();
			this.NLCDBDMHMJL = ECHMFPQNBMC.Points;
			this.PDDJMNOOPJD();
		}
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000133D1 File Offset: 0x000115D1
	public void ONDLGFGCNDP(Achievement ECHMFPQNBMC)
	{
		base.StartCoroutine(this.BMLCKJFGPGQ(ECHMFPQNBMC));
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x000EA914 File Offset: 0x000E8B14
	private void MGEIJGGNHKD()
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IBDJHCDDHNF.PIDLOFMIEFQ = this.NLCDBDMHMJL.ToString("speedswap");
			this.JBLQIEPJLPN.BLBBJJPDLDC("-", 0);
			this.JHDGENGBPQF.PFEIQDIJEKE();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(18f, true);
			this.JHDGENGBPQF.gameObject.SetActive(true);
			for (int i = 1; i < this.HLHKMMNMDNC.Count; i += 0)
			{
				if (this.HLHKMMNMDNC[i].Payload.Length > 0)
				{
					int j = 1;
					while (j < this.HLHKMMNMDNC[i].Payload.Length)
					{
						if (this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[j].Required)
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component = this.JBLQIEPJLPN.JPODNGNQBKQ("afteryou", 1).GetComponent<POOPQGNNKLF>();
								component.transform.parent = this.JHDGENGBPQF.transform;
								component.transform.localScale = new Vector3(1245f, 512f, 776f);
								component.gameObject.SetActive(false);
								component.PHJCHPCPLCJ(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject = component.gameObject;
								gameObject.name += this.HLHKMMNMDNC[i].ID;
							}
							j += 0;
						}
						else
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component2 = this.JBLQIEPJLPN.QIQPJQFDBCP(" was freed from ", 1).GetComponent<POOPQGNNKLF>();
								component2.transform.parent = this.JHDGENGBPQF.transform;
								component2.transform.localScale = new Vector3(750f, 1759f, 1263f);
								component2.gameObject.SetActive(true);
								component2.CLMGPMLLIDN(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject2 = component2.gameObject;
								gameObject2.name += this.HLHKMMNMDNC[i].ID;
								break;
							}
							break;
						}
					}
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component3 = this.JBLQIEPJLPN.FCIIBFEGBML(")", 0).GetComponent<POOPQGNNKLF>();
					component3.transform.parent = this.JHDGENGBPQF.transform;
					component3.transform.localScale = new Vector3(172f, 940f, 309f);
					component3.gameObject.SetActive(false);
					component3.MIEHJOOLEHC(this.HLHKMMNMDNC[i].Payload[0], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject3 = component3.gameObject;
					gameObject3.name += this.HLHKMMNMDNC[i].ID;
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress < this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component4 = this.JBLQIEPJLPN.PEJIFGJPCGD("RightS", 1).GetComponent<POOPQGNNKLF>();
					component4.transform.parent = this.JHDGENGBPQF.transform;
					component4.transform.localScale = new Vector3(1124f, 1106f, 360f);
					component4.gameObject.SetActive(false);
					component4.LBIHDCQJNGB(this.HLHKMMNMDNC[i].Payload[0], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject4 = component4.gameObject;
					gameObject4.name += this.HLHKMMNMDNC[i].ID;
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(false);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.CLQFFBMLIQH = true;
		}
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000133E1 File Offset: 0x000115E1
	public void JJGDOJKGNOL(PSXAPI.Response.Achievements ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC.Username == null)
		{
			this.HLHKMMNMDNC = ECHMFPQNBMC.List.ToList<Achievement>();
			this.NLCDBDMHMJL = ECHMFPQNBMC.Points;
			this.GFIEGHQBGEG();
		}
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x0001340E File Offset: 0x0001160E
	public void DDIPQLJBMGM(PSXAPI.Response.Achievements ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC.Username == null)
		{
			this.HLHKMMNMDNC = ECHMFPQNBMC.List.ToList<Achievement>();
			this.NLCDBDMHMJL = ECHMFPQNBMC.Points;
			this.MGEIJGGNHKD();
		}
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x0001343B File Offset: 0x0001163B
	public void EDBFBBHNJNI(Achievement ECHMFPQNBMC)
	{
		base.StartCoroutine(this.CNCIJLNIKMD(ECHMFPQNBMC));
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x000EADD0 File Offset: 0x000E8FD0
	private IEnumerator DEECDDPGNOO(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		JPPCMGBCNNJ.OHBIMCOEIOM ohbimcoeiom = new JPPCMGBCNNJ.OHBIMCOEIOM();
		ohbimcoeiom.PPBCNEKQMON = PPBCNEKQMON;
		ohbimcoeiom.HIEFQEEDHGG = HIEFQEEDHGG;
		ohbimcoeiom.GGNFJBMFLQH = GGNFJBMFLQH;
		ohbimcoeiom.QNDQJMNKFNN = this;
		return ohbimcoeiom;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x0001344B File Offset: 0x0001164B
	private void JIMBLQBBDKO()
	{
		JPPCMGBCNNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x00013453 File Offset: 0x00011653
	public void OCHHBFFHIDJ()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("_MainTex", 1571f);
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x000EADD0 File Offset: 0x000E8FD0
	[DebuggerHidden]
	private IEnumerator LQJQEBPDBJG(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		JPPCMGBCNNJ.OHBIMCOEIOM ohbimcoeiom = new JPPCMGBCNNJ.OHBIMCOEIOM();
		ohbimcoeiom.PPBCNEKQMON = PPBCNEKQMON;
		ohbimcoeiom.HIEFQEEDHGG = HIEFQEEDHGG;
		ohbimcoeiom.GGNFJBMFLQH = GGNFJBMFLQH;
		ohbimcoeiom.QNDQJMNKFNN = this;
		return ohbimcoeiom;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x0001347C File Offset: 0x0001167C
	public void PCENEKQNHLM()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.OCHHBFFHIDJ();
		}
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000134AE File Offset: 0x000116AE
	public void BKDQNGPOPDE()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("General", 1958f);
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x000EAE00 File Offset: 0x000E9000
	private void GFIEGHQBGEG()
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IBDJHCDDHNF.PIDLOFMIEFQ = this.NLCDBDMHMJL.ToString("Big/");
			this.JBLQIEPJLPN.PDBGQNOLMBG("0", 0);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(529f, true);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			for (int i = 0; i < this.HLHKMMNMDNC.Count; i++)
			{
				if (this.HLHKMMNMDNC[i].Payload.Length > 1)
				{
					int j = 0;
					while (j < this.HLHKMMNMDNC[i].Payload.Length)
					{
						if (this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[j].Required)
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component = this.JBLQIEPJLPN.FIGMKCDNCJM(" hour ago", 1).GetComponent<POOPQGNNKLF>();
								component.transform.parent = this.JHDGENGBPQF.transform;
								component.transform.localScale = new Vector3(70f, 1277f, 630f);
								component.gameObject.SetActive(true);
								component.LBIHDCQJNGB(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject = component.gameObject;
								gameObject.name += this.HLHKMMNMDNC[i].ID;
							}
							j++;
						}
						else
						{
							if (this.JJCEJMHHCDL != 1)
							{
								POOPQGNNKLF component2 = this.JBLQIEPJLPN.GKNLQNEMKKF("less than 1 minute ago", 0).GetComponent<POOPQGNNKLF>();
								component2.transform.parent = this.JHDGENGBPQF.transform;
								component2.transform.localScale = new Vector3(1975f, 1800f, 487f);
								component2.gameObject.SetActive(true);
								component2.PJJFGOKNQMJ(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject2 = component2.gameObject;
								gameObject2.name += this.HLHKMMNMDNC[i].ID;
								break;
							}
							break;
						}
					}
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component3 = this.JBLQIEPJLPN.FCIIBFEGBML("[PD]", 0).GetComponent<POOPQGNNKLF>();
					component3.transform.parent = this.JHDGENGBPQF.transform;
					component3.transform.localScale = new Vector3(1914f, 378f, 145f);
					component3.gameObject.SetActive(false);
					component3.DLEDQFJCPDJ(this.HLHKMMNMDNC[i].Payload[0], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject3 = component3.gameObject;
					gameObject3.name += this.HLHKMMNMDNC[i].ID;
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress < this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component4 = this.JBLQIEPJLPN.PEJIFGJPCGD("_1", 1).GetComponent<POOPQGNNKLF>();
					component4.transform.parent = this.JHDGENGBPQF.transform;
					component4.transform.localScale = new Vector3(1572f, 989f, 1616f);
					component4.gameObject.SetActive(true);
					component4.LCCLHQMCGNB(this.HLHKMMNMDNC[i].Payload[1], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject4 = component4.gameObject;
					gameObject4.name += this.HLHKMMNMDNC[i].ID;
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(true);
			this.JHDGENGBPQF.PFEIQDIJEKE();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.CLQFFBMLIQH = true;
		}
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x000EB2BC File Offset: 0x000E94BC
	private IEnumerator CNCIJLNIKMD(Achievement ECHMFPQNBMC)
	{
		JPPCMGBCNNJ.CNJHPLMDEQJ cnjhplmdeqj = new JPPCMGBCNNJ.CNJHPLMDEQJ();
		cnjhplmdeqj.ECHMFPQNBMC = ECHMFPQNBMC;
		cnjhplmdeqj.QNDQJMNKFNN = this;
		return cnjhplmdeqj;
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x000EB2BC File Offset: 0x000E94BC
	[DebuggerHidden]
	private IEnumerator BMLCKJFGPGQ(Achievement ECHMFPQNBMC)
	{
		JPPCMGBCNNJ.CNJHPLMDEQJ cnjhplmdeqj = new JPPCMGBCNNJ.CNJHPLMDEQJ();
		cnjhplmdeqj.ECHMFPQNBMC = ECHMFPQNBMC;
		cnjhplmdeqj.QNDQJMNKFNN = this;
		return cnjhplmdeqj;
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000134D7 File Offset: 0x000116D7
	public void MKIFEDGELEQ()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Achievements(), true);
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x000134E9 File Offset: 0x000116E9
	public void HPIDFKPBFLM()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.BKDQNGPOPDE();
		}
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x000EADD0 File Offset: 0x000E8FD0
	private IEnumerator CGGMDKQGHHD(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		JPPCMGBCNNJ.OHBIMCOEIOM ohbimcoeiom = new JPPCMGBCNNJ.OHBIMCOEIOM();
		ohbimcoeiom.PPBCNEKQMON = PPBCNEKQMON;
		ohbimcoeiom.HIEFQEEDHGG = HIEFQEEDHGG;
		ohbimcoeiom.GGNFJBMFLQH = GGNFJBMFLQH;
		ohbimcoeiom.QNDQJMNKFNN = this;
		return ohbimcoeiom;
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x000133A4 File Offset: 0x000115A4
	public void MCPHPECGQNI(PSXAPI.Response.Achievements ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC.Username == null)
		{
			this.HLHKMMNMDNC = ECHMFPQNBMC.List.ToList<Achievement>();
			this.NLCDBDMHMJL = ECHMFPQNBMC.Points;
			this.PDDJMNOOPJD();
		}
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x000EB2E0 File Offset: 0x000E94E0
	public void DLCQHHPIGLN()
	{
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.JJCEJMHHCDL = 0;
		this.PDDJMNOOPJD();
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x000EB360 File Offset: 0x000E9560
	public void Open()
	{
		if (!this.EIFJDMHNJJH)
		{
			this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
			this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
			this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = true;
			this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.JJCEJMHHCDL = 1;
			this.KEPMGBKEKQJ();
			this.EIFJDMHNJJH = true;
		}
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.PDDJMNOOPJD();
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x0001351B File Offset: 0x0001171B
	public void MDGDPNPPBLG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
		}
		else
		{
			this.OCHHBFFHIDJ();
		}
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x0001354D File Offset: 0x0001174D
	public void NLPCILIPELK(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		base.StartCoroutine(this.LQJQEBPDBJG(HIEFQEEDHGG, PPBCNEKQMON, GGNFJBMFLQH));
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x000EB438 File Offset: 0x000E9638
	public void EPPBGOMKDQP()
	{
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[7].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.JJCEJMHHCDL = 1;
		this.BMIIEIIHQQQ();
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x0001355F File Offset: 0x0001175F
	private void BFCKONJGFFB()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x000EADD0 File Offset: 0x000E8FD0
	private IEnumerator KINKKDDEPCJ(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		JPPCMGBCNNJ.OHBIMCOEIOM ohbimcoeiom = new JPPCMGBCNNJ.OHBIMCOEIOM();
		ohbimcoeiom.PPBCNEKQMON = PPBCNEKQMON;
		ohbimcoeiom.HIEFQEEDHGG = HIEFQEEDHGG;
		ohbimcoeiom.GGNFJBMFLQH = GGNFJBMFLQH;
		ohbimcoeiom.QNDQJMNKFNN = this;
		return ohbimcoeiom;
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x00013572 File Offset: 0x00011772
	public void HMMBIICFNMJ()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("item", 1244f);
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x0001344B File Offset: 0x0001164B
	private void Awake()
	{
		JPPCMGBCNNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x0001359B File Offset: 0x0001179B
	public void KEPMGBKEKQJ()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Achievements(), false);
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x000135AD File Offset: 0x000117AD
	private void LNHDODMGBKC()
	{
		this.JBLQIEPJLPN = LPEQICNMHIL.GGBPGMMCGLI();
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x0001344B File Offset: 0x0001164B
	private void NGDJNKQELNO()
	{
		JPPCMGBCNNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x000135CD File Offset: 0x000117CD
	public void IHLFMKGQLOD(Achievement ECHMFPQNBMC)
	{
		base.StartCoroutine(this.HBNLQBBIMQN(ECHMFPQNBMC));
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x0001337D File Offset: 0x0001157D
	public static JPPCMGBCNNJ QBNCFLKLLKC()
	{
		return JPPCMGBCNNJ.HBFFCJHOCPE;
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x000EB4B8 File Offset: 0x000E96B8
	public void ShowCompleted()
	{
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.JJCEJMHHCDL = 1;
		this.PDDJMNOOPJD();
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000EB538 File Offset: 0x000E9738
	private void BMIIEIIHQQQ()
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IBDJHCDDHNF.LKPOBCBOFIC(this.NLCDBDMHMJL.ToString("watersport"));
			this.JBLQIEPJLPN.ENQLFNNNDPO("[FF8F00]", 0);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(546f, false);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			for (int i = 0; i < this.HLHKMMNMDNC.Count; i += 0)
			{
				if (this.HLHKMMNMDNC[i].Payload.Length > 0)
				{
					int j = 1;
					while (j < this.HLHKMMNMDNC[i].Payload.Length)
					{
						if (this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[j].Required)
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component = this.JBLQIEPJLPN.JPODNGNQBKQ("Hi-Score: ", 0).GetComponent<POOPQGNNKLF>();
								component.transform.parent = this.JHDGENGBPQF.transform;
								component.transform.localScale = new Vector3(812f, 918f, 1031f);
								component.gameObject.SetActive(true);
								component.KFFBQPOCHHE(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject = component.gameObject;
								gameObject.name += this.HLHKMMNMDNC[i].ID;
							}
							j++;
						}
						else
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component2 = this.JBLQIEPJLPN.PEJIFGJPCGD("3", 0).GetComponent<POOPQGNNKLF>();
								component2.transform.parent = this.JHDGENGBPQF.transform;
								component2.transform.localScale = new Vector3(1744f, 1707f, 995f);
								component2.gameObject.SetActive(false);
								component2.PLBJKOILHJN(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject2 = component2.gameObject;
								gameObject2.name += this.HLHKMMNMDNC[i].ID;
								break;
							}
							break;
						}
					}
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("Rainy", 1).GetComponent<POOPQGNNKLF>();
					component3.transform.parent = this.JHDGENGBPQF.transform;
					component3.transform.localScale = new Vector3(47f, 1798f, 1304f);
					component3.gameObject.SetActive(true);
					component3.IQMKEHHHQKG(this.HLHKMMNMDNC[i].Payload[1], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject3 = component3.gameObject;
					gameObject3.name += this.HLHKMMNMDNC[i].ID;
				}
				else if (this.JJCEJMHHCDL != 1 && this.HLHKMMNMDNC[i].Progress < this.HLHKMMNMDNC[i].Payload[1].Required)
				{
					POOPQGNNKLF component4 = this.JBLQIEPJLPN.FIGMKCDNCJM("ProCamera2D does not have a Shake extension.", 0).GetComponent<POOPQGNNKLF>();
					component4.transform.parent = this.JHDGENGBPQF.transform;
					component4.transform.localScale = new Vector3(1809f, 1861f, 1741f);
					component4.gameObject.SetActive(true);
					component4.OEJDMOMEKGC(this.HLHKMMNMDNC[i].Payload[1], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject4 = component4.gameObject;
					gameObject4.name += this.HLHKMMNMDNC[i].ID;
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(false);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
			this.JHDGENGBPQF.CLQFFBMLIQH = false;
		}
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x000135DD File Offset: 0x000117DD
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000EB9F4 File Offset: 0x000E9BF4
	private void PDDJMNOOPJD()
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IBDJHCDDHNF.PIDLOFMIEFQ = this.NLCDBDMHMJL.ToString("#,##0");
			this.JBLQIEPJLPN.PDBGQNOLMBG("achievement", 0);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			for (int i = 0; i < this.HLHKMMNMDNC.Count; i++)
			{
				if (this.HLHKMMNMDNC[i].Payload.Length > 1)
				{
					int j = 0;
					while (j < this.HLHKMMNMDNC[i].Payload.Length)
					{
						if (this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[j].Required)
						{
							if (this.JJCEJMHHCDL != 0)
							{
								POOPQGNNKLF component = this.JBLQIEPJLPN.JPODNGNQBKQ("achievement", 0).GetComponent<POOPQGNNKLF>();
								component.transform.parent = this.JHDGENGBPQF.transform;
								component.transform.localScale = new Vector3(1f, 1f, 1f);
								component.gameObject.SetActive(true);
								component.BQLIIQIIMDH(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject = component.gameObject;
								gameObject.name += this.HLHKMMNMDNC[i].ID;
							}
							j++;
						}
						else
						{
							if (this.JJCEJMHHCDL != 1)
							{
								POOPQGNNKLF component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("achievement", 0).GetComponent<POOPQGNNKLF>();
								component2.transform.parent = this.JHDGENGBPQF.transform;
								component2.transform.localScale = new Vector3(1f, 1f, 1f);
								component2.gameObject.SetActive(true);
								component2.BQLIIQIIMDH(this.HLHKMMNMDNC[i].Payload[j], this.HLHKMMNMDNC[i].Progress);
								GameObject gameObject2 = component2.gameObject;
								gameObject2.name += this.HLHKMMNMDNC[i].ID;
								break;
							}
							break;
						}
					}
				}
				else if (this.JJCEJMHHCDL != 0 && this.HLHKMMNMDNC[i].Progress >= this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("achievement", 0).GetComponent<POOPQGNNKLF>();
					component3.transform.parent = this.JHDGENGBPQF.transform;
					component3.transform.localScale = new Vector3(1f, 1f, 1f);
					component3.gameObject.SetActive(true);
					component3.BQLIIQIIMDH(this.HLHKMMNMDNC[i].Payload[0], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject3 = component3.gameObject;
					gameObject3.name += this.HLHKMMNMDNC[i].ID;
				}
				else if (this.JJCEJMHHCDL != 1 && this.HLHKMMNMDNC[i].Progress < this.HLHKMMNMDNC[i].Payload[0].Required)
				{
					POOPQGNNKLF component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("achievement", 0).GetComponent<POOPQGNNKLF>();
					component4.transform.parent = this.JHDGENGBPQF.transform;
					component4.transform.localScale = new Vector3(1f, 1f, 1f);
					component4.gameObject.SetActive(true);
					component4.BQLIIQIIMDH(this.HLHKMMNMDNC[i].Payload[0], this.HLHKMMNMDNC[i].Progress);
					GameObject gameObject4 = component4.gameObject;
					gameObject4.name += this.HLHKMMNMDNC[i].ID;
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(true);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.CLQFFBMLIQH = true;
		}
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000EB2BC File Offset: 0x000E94BC
	private IEnumerator HBNLQBBIMQN(Achievement ECHMFPQNBMC)
	{
		JPPCMGBCNNJ.CNJHPLMDEQJ cnjhplmdeqj = new JPPCMGBCNNJ.CNJHPLMDEQJ();
		cnjhplmdeqj.ECHMFPQNBMC = ECHMFPQNBMC;
		cnjhplmdeqj.QNDQJMNKFNN = this;
		return cnjhplmdeqj;
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00013606 File Offset: 0x00011806
	public void CKHGMLFNDOJ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x0001340E File Offset: 0x0001160E
	public void PBOLHDKHNGB(PSXAPI.Response.Achievements ECHMFPQNBMC)
	{
		if (ECHMFPQNBMC.Username == null)
		{
			this.HLHKMMNMDNC = ECHMFPQNBMC.List.ToList<Achievement>();
			this.NLCDBDMHMJL = ECHMFPQNBMC.Points;
			this.MGEIJGGNHKD();
		}
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x000EBEB0 File Offset: 0x000EA0B0
	public void ShowAll()
	{
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.JJCEJMHHCDL = 2;
		this.PDDJMNOOPJD();
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x00013606 File Offset: 0x00011806
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x00013391 File Offset: 0x00011591
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x00013638 File Offset: 0x00011838
	public void KCPJJEJFOHQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x0001366A File Offset: 0x0001186A
	public void MNONJONFLIE()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.OCHHBFFHIDJ();
		}
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x0001369C File Offset: 0x0001189C
	public void QGMLJNKDQNG()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Achievements(), true);
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x000136AE File Offset: 0x000118AE
	public void LQOCKHBKNPL(string HIEFQEEDHGG, string PPBCNEKQMON, int GGNFJBMFLQH = 17)
	{
		base.StartCoroutine(this.CGGMDKQGHHD(HIEFQEEDHGG, PPBCNEKQMON, GGNFJBMFLQH));
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x000EB2BC File Offset: 0x000E94BC
	private IEnumerator CQHOBEPMBBO(Achievement ECHMFPQNBMC)
	{
		JPPCMGBCNNJ.CNJHPLMDEQJ cnjhplmdeqj = new JPPCMGBCNNJ.CNJHPLMDEQJ();
		cnjhplmdeqj.ECHMFPQNBMC = ECHMFPQNBMC;
		cnjhplmdeqj.QNDQJMNKFNN = this;
		return cnjhplmdeqj;
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x000136C0 File Offset: 0x000118C0
	private void KPKQNOCFGIB()
	{
		this.JBLQIEPJLPN = LPEQICNMHIL.FPQNIQELKMC();
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x000EBF30 File Offset: 0x000EA130
	public void ShowIncomplete()
	{
		this.PGBLHMLDGOJ[0].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PGBLHMLDGOJ[1].GetComponent<BoxCollider>().enabled = false;
		this.PGBLHMLDGOJ[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PGBLHMLDGOJ[2].GetComponent<BoxCollider>().enabled = true;
		this.PGBLHMLDGOJ[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.JJCEJMHHCDL = 0;
		this.PDDJMNOOPJD();
	}

	// Token: 0x040007BD RID: 1981
	private static JPPCMGBCNNJ HBFFCJHOCPE;

	// Token: 0x040007BE RID: 1982
	public List<Achievement> HLHKMMNMDNC = new List<Achievement>();

	// Token: 0x040007BF RID: 1983
	public GameObject DPHIGGKHLFH;

	// Token: 0x040007C0 RID: 1984
	public GameObject HQNKIQNFJKE;

	// Token: 0x040007C1 RID: 1985
	public BHLIGEGNFHG DMQNQBMGHKE;

	// Token: 0x040007C2 RID: 1986
	public BKKHLBCLPJM IBDJHCDDHNF;

	// Token: 0x040007C3 RID: 1987
	public GameObject FDKOBBIBCQB;

	// Token: 0x040007C4 RID: 1988
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x040007C5 RID: 1989
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x040007C6 RID: 1990
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x040007C7 RID: 1991
	private uint NLCDBDMHMJL;

	// Token: 0x040007C8 RID: 1992
	private LPEQICNMHIL JBLQIEPJLPN;

	// Token: 0x040007C9 RID: 1993
	private bool EIFJDMHNJJH;

	// Token: 0x040007CA RID: 1994
	public CFDMNELIJLO[] PGBLHMLDGOJ;

	// Token: 0x040007CB RID: 1995
	private int JJCEJMHHCDL;
}
