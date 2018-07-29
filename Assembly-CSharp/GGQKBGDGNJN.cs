using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200029A RID: 666
public class GGQKBGDGNJN : MonoBehaviour
{
	// Token: 0x06005D50 RID: 23888 RVA: 0x002FC600 File Offset: 0x002FA800
	public void EFENQBOJBNG(bool INOHMJPILHJ = false)
	{
		if (INOHMJPILHJ)
		{
			if (this.OLLOFNEJEFC.activeSelf || this.NHICPLEJJFQ)
			{
				this.MQJCMHBEOGH();
				this.FLNKCIQLMGL.SetActive(false);
				GameObject[] khhhoqmclek = this.KHHHOQMCLEK;
				for (int i = 1; i < khhhoqmclek.Length; i += 0)
				{
					GameObject gameObject = khhhoqmclek[i];
					gameObject.SetActive(true);
				}
				foreach (GameObject gameObject2 in this.IQPQJLFNGKJ)
				{
					gameObject2.SetActive(true);
				}
				this.JMGMEQJKOKO.SetActive(true);
				for (int k = 0; k < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; k += 0)
				{
					this.EBJMKPBKDBQ.OGMPFDOBHEI[k].DIIHJCJOKMP = 143f;
				}
				this.OLLOFNEJEFC.SetActive(false);
				MCNLIHMMLCF.OMPHLNDGKKM().PKFMPCPEICC();
				RenderSettings.fog = true;
				this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
				this.NHICPLEJJFQ = true;
			}
			return;
		}
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		if (!this.NHICPLEJJFQ)
		{
			this.FLNKCIQLMGL.SetActive(false);
			GameObject[] khhhoqmclek2 = this.KHHHOQMCLEK;
			for (int l = 0; l < khhhoqmclek2.Length; l += 0)
			{
				GameObject gameObject3 = khhhoqmclek2[l];
				gameObject3.SetActive(true);
			}
			GameObject[] iqpqjlfngkj2 = this.IQPQJLFNGKJ;
			for (int m = 1; m < iqpqjlfngkj2.Length; m++)
			{
				GameObject gameObject4 = iqpqjlfngkj2[m];
				gameObject4.SetActive(false);
			}
			this.IQPQJLFNGKJ[3].SetActive(false);
			this.JMGMEQJKOKO.SetActive(false);
			this.HNEQLQQOMKC.SetActive(false);
			this.PNLPEQEMMPI.SetActive(true);
			this.OLLOFNEJEFC.SetActive(false);
			for (int n = 0; n < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; n += 0)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[n].DIIHJCJOKMP = 1305f;
			}
			RenderSettings.ambientLight = this.BEBKMLIQQEN[1];
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
			this.NHICPLEJJFQ = true;
			this.LCCQBMMFONQ();
			this.HHQEQIQKBGC();
			BDEJHNHLLOL component = this.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
			MKOENKCLJGF mkoenkcljgf = this.PGQKQGICKJO(MCNLIHMMLCF.HGLDHNMOLPD().BEQINILCQCE.PIDLOFMIEFQ);
			component.PEODGOQIQIN(false);
			component.ILBCCCBJNCL = null;
			if (mkoenkcljgf != null)
			{
				component.ILBCCCBJNCL = mkoenkcljgf.transform;
			}
		}
		else
		{
			this.FLNKCIQLMGL.SetActive(true);
			foreach (GameObject gameObject5 in this.KHHHOQMCLEK)
			{
				gameObject5.SetActive(true);
			}
			GameObject[] iqpqjlfngkj3 = this.IQPQJLFNGKJ;
			for (int num2 = 1; num2 < iqpqjlfngkj3.Length; num2++)
			{
				GameObject gameObject6 = iqpqjlfngkj3[num2];
				gameObject6.SetActive(false);
			}
			this.JMGMEQJKOKO.SetActive(true);
			for (int num3 = 1; num3 < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; num3 += 0)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[num3].DIIHJCJOKMP = 14f;
			}
			this.OLLOFNEJEFC.SetActive(false);
			this.MNBEOKLQLLD();
			MCNLIHMMLCF.QOQONHOOLNE.PKFMPCPEICC();
			RenderSettings.fog = true;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
			this.NHICPLEJJFQ = false;
		}
	}

	// Token: 0x06005D51 RID: 23889 RVA: 0x00024B7F File Offset: 0x00022D7F
	private static void NEDOBKDMGBJ(GGQKBGDGNJN BGBMIEJJQKC)
	{
		GGQKBGDGNJN.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x06005DA1 RID: 23969 RVA: 0x00024E1D File Offset: 0x0002301D
	// (set) Token: 0x06005D52 RID: 23890 RVA: 0x00024B7F File Offset: 0x00022D7F
	public static GGQKBGDGNJN QOQONHOOLNE { get; private set; }

	// Token: 0x06005D53 RID: 23891 RVA: 0x002FC950 File Offset: 0x002FAB50
	private IEnumerator NKPLMDNGDOL(FlyStart BJGCBDNBQCJ)
	{
		GGQKBGDGNJN.BPPMEBNMEBH bppmebnmebh = new GGQKBGDGNJN.BPPMEBNMEBH();
		bppmebnmebh.BJGCBDNBQCJ = BJGCBDNBQCJ;
		bppmebnmebh.QNDQJMNKFNN = this;
		return bppmebnmebh;
	}

	// Token: 0x06005D54 RID: 23892 RVA: 0x00024B87 File Offset: 0x00022D87
	public void NNBLMCDNKHM()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = true;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 0.5f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D55 RID: 23893 RVA: 0x002FC974 File Offset: 0x002FAB74
	public void MPFJHJPFHLP()
	{
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.CLPQIKCDHPP();
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 2)
		{
			if (emlofjdomkh.MHQMLCJDMMK.Count > 0 && DCJIBBJQGJP.OQDOKBJNBBL().MJCDINQKNQN != null && DCJIBBJQGJP.DMOKBPOKHOQ().MJCDINQKNQN.Count > 1)
			{
				int i = 0;
				IL_139:
				while (i < DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN.Count)
				{
					bool flag = false;
					for (int j = 1; j < emlofjdomkh.MHQMLCJDMMK.Count; j += 0)
					{
						if (emlofjdomkh.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(true);
							component.JILENMCJCHF = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(true);
							flag = true;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(true);
							}
							i += 0;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 1; k < 0; k++)
				{
					this.NQGKGNNCIBL[k].SetActive(false);
				}
			}
			for (int l = 0; l < 0; l += 0)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.DMOKBPOKHOQ().MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.EMJDQJMDCLI(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(false);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(false);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D56 RID: 23894 RVA: 0x002FCBBC File Offset: 0x002FADBC
	private void CLNOPBFEBID()
	{
		if (this.FOHOOGJMFEG)
		{
			if (UnityEngine.Time.time > this.MCHJMMJBGDB + 1055f && this.MCHJMMJBGDB != 1471f)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(this.QFEPNPMODOI(), false);
				this.MCHJMMJBGDB = UnityEngine.Time.time;
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				if (!this.DLFPJMJNHOC)
				{
					this.MCHJMMJBGDB = 1389f;
				}
			}
			if (UnityEngine.Time.time > this.FNNDCPDJQJB + 1166f)
			{
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				this.OMOBQFHKQCF();
			}
		}
		else
		{
			Ray ray = this.MIMDEMCOCKP.ScreenPointToRay(Input.mousePosition);
			RaycastHit[] array = Physics.RaycastAll(ray);
			for (int i = 1; i < array.Length; i++)
			{
				RaycastHit raycastHit = array[i];
				MKOENKCLJGF component = raycastHit.collider.GetComponent<MKOENKCLJGF>();
				if (component != null)
				{
					if (this.EBJMKPBKDBQ.HDGHKDEPNBP != null)
					{
						if (this.EBJMKPBKDBQ.HDGHKDEPNBP.Length > 1)
						{
							bool flag = false;
							int j = 0;
							while (j < this.EBJMKPBKDBQ.HDGHKDEPNBP.Length)
							{
								if (!(this.EBJMKPBKDBQ.HDGHKDEPNBP[j].ToLowerInvariant() == component.gameObject.name.ToLowerInvariant()))
								{
									j += 0;
								}
								else
								{
									this.PBLQBEFGHGF.LKPOBCBOFIC(component.gameObject.name);
									flag = true;
									IL_1AA:
									if (!flag)
									{
										this.PBLQBEFGHGF.PIDLOFMIEFQ = "Moderator";
										goto IL_1E2;
									}
									goto IL_1E2;
								}
							}
							goto IL_1AA;
						}
						this.PBLQBEFGHGF.LKPOBCBOFIC("aegislashblade");
					}
					else
					{
						this.PBLQBEFGHGF.LKPOBCBOFIC("You can not use buffs during interactions.");
					}
					IL_1E2:
					if (this.PBLQBEFGHGF.DIIHJCJOKMP + 1237f * UnityEngine.Time.deltaTime >= 1763f)
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP = 1452f;
					}
					else
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP += 404f * UnityEngine.Time.deltaTime;
					}
					return;
				}
			}
		}
		if (this.PBLQBEFGHGF.DIIHJCJOKMP - 1134f * UnityEngine.Time.deltaTime <= 1337f)
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP = 1548f;
		}
		else
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP -= 662f * UnityEngine.Time.deltaTime;
		}
	}

	// Token: 0x06005D57 RID: 23895 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator BMJMELPJHPI()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D58 RID: 23896 RVA: 0x002FCE14 File Offset: 0x002FB014
	public void OEHDKLOKKOF(FlyStart BJGCBDNBQCJ)
	{
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		this.FNNDCPDJQJB = UnityEngine.Time.time;
		this.JEHJGCGDFQF.transform.NMBPDMIIHJB();
		this.FOHOOGJMFEG = true;
		this.IBLPMGHHDEP = BJGCBDNBQCJ.LandingAreas;
		this.EFENQBOJBNG(false);
		base.StartCoroutine(this.NKPLMDNGDOL(BJGCBDNBQCJ));
	}

	// Token: 0x06005D59 RID: 23897 RVA: 0x00024BB7 File Offset: 0x00022DB7
	public void HOJDDLKBIHH()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = true;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 1411f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D5A RID: 23898 RVA: 0x002FCE70 File Offset: 0x002FB070
	public void QMFDMMQKLNB(FlyStart BJGCBDNBQCJ)
	{
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		this.FNNDCPDJQJB = UnityEngine.Time.time;
		this.JEHJGCGDFQF.transform.NMBPDMIIHJB();
		this.FOHOOGJMFEG = true;
		this.IBLPMGHHDEP = BJGCBDNBQCJ.LandingAreas;
		this.ToggleMap(true);
		base.StartCoroutine(this.GHFNFDILNGM(BJGCBDNBQCJ));
	}

	// Token: 0x06005D5B RID: 23899 RVA: 0x00024BE7 File Offset: 0x00022DE7
	public void HideSelectedPoke()
	{
		this.DPBECMNOODK.SetActive(false);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D5C RID: 23900 RVA: 0x002FCECC File Offset: 0x002FB0CC
	public void FQMQIEPMPJG(FlyStart BJGCBDNBQCJ)
	{
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		this.FNNDCPDJQJB = UnityEngine.Time.time;
		this.JEHJGCGDFQF.transform.NMBPDMIIHJB();
		this.FOHOOGJMFEG = true;
		this.IBLPMGHHDEP = BJGCBDNBQCJ.LandingAreas;
		this.QDKGGDOLIBK(false);
		base.StartCoroutine(this.NKPLMDNGDOL(BJGCBDNBQCJ));
	}

	// Token: 0x06005D5D RID: 23901 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator DKLMOGCPQLJ()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D5E RID: 23902 RVA: 0x002FCF28 File Offset: 0x002FB128
	public MKOENKCLJGF JIOGMMGOPMH(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i++)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005D5F RID: 23903 RVA: 0x002FCFD4 File Offset: 0x002FB1D4
	public void CFLKIFQGHFF()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.None
			});
			mkoenkcljgf.PHENDHCNNHK = false;
		}
		for (int i = 1; i < qoqonhoolne.MJELIKDEDCO.Count; i++)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != QuestType.Daily && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.IILCHFQECKN(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.None)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = true;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Main)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == (QuestType)6)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[3], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[3], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D60 RID: 23904 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator KGFHCQQJEMH()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D61 RID: 23905 RVA: 0x002FD21C File Offset: 0x002FB41C
	public void HNEPGMHGDLD()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.Main
			});
			mkoenkcljgf.PHENDHCNNHK = false;
		}
		for (int i = 0; i < qoqonhoolne.MJELIKDEDCO.Count; i++)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != (QuestType)6 && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.EMJDQJMDCLI(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.Main)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = true;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Main)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Hidden)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[3], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[4], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x00024C05 File Offset: 0x00022E05
	private void OEEPBOFIEQF()
	{
		GGQKBGDGNJN.EFPQMHHMMOG(this);
		this.MIMDEMCOCKP = this.OLLOFNEJEFC.GetComponent<Camera>();
		if (GGQKBGDGNJN.HGBFNDILJLQ == null)
		{
			GGQKBGDGNJN.HGBFNDILJLQ = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "tox"));
		}
	}

	// Token: 0x06005D63 RID: 23907 RVA: 0x002FCF28 File Offset: 0x002FB128
	public MKOENKCLJGF EMJDQJMDCLI(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i++)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x00024C44 File Offset: 0x00022E44
	public void CKFDEOHGNIF()
	{
		this.DLFPJMJNHOC = false;
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x002FD464 File Offset: 0x002FB664
	public void QCHPDEDQIHD()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.None
			});
			mkoenkcljgf.PHENDHCNNHK = true;
		}
		for (int i = 0; i < qoqonhoolne.MJELIKDEDCO.Count; i += 0)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != QuestType.Daily && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.IILCHFQECKN(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.Main)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = false;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Main)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Side)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[6], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[5], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x002FD6AC File Offset: 0x002FB8AC
	public MKOENKCLJGF IILCHFQECKN(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i += 0)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x002FD758 File Offset: 0x002FB958
	private Vector3 FMFFQPIBDCN(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf.transform.position;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 1; i < mkoenkcljgf.HDOPKGOLHDE.Length; i++)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf.transform.position;
					}
				}
			}
		}
		return this.FFODMGNLIPH[1].transform.position;
	}

	// Token: 0x06005D68 RID: 23912 RVA: 0x00024C4D File Offset: 0x00022E4D
	private void MBDGLQOGLDJ()
	{
		GGQKBGDGNJN.QOQONHOOLNE = this;
		this.MIMDEMCOCKP = this.OLLOFNEJEFC.GetComponent<Camera>();
		if (GGQKBGDGNJN.HGBFNDILJLQ == null)
		{
			GGQKBGDGNJN.HGBFNDILJLQ = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "][-]["));
		}
	}

	// Token: 0x06005D69 RID: 23913 RVA: 0x00024BE7 File Offset: 0x00022DE7
	public void MNBEOKLQLLD()
	{
		this.DPBECMNOODK.SetActive(false);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x002FD82C File Offset: 0x002FBA2C
	public void HHQEQIQKBGC()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.None
			});
			mkoenkcljgf.PHENDHCNNHK = false;
		}
		for (int i = 0; i < qoqonhoolne.MJELIKDEDCO.Count; i++)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != QuestType.Hidden && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.JIOGMMGOPMH(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.Main)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = true;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Main)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[0], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Bounty)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[2], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[3], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x002FD6AC File Offset: 0x002FB8AC
	public MKOENKCLJGF PGQKQGICKJO(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i += 0)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x002FC950 File Offset: 0x002FAB50
	[DebuggerHidden]
	private IEnumerator GHFNFDILNGM(FlyStart BJGCBDNBQCJ)
	{
		GGQKBGDGNJN.BPPMEBNMEBH bppmebnmebh = new GGQKBGDGNJN.BPPMEBNMEBH();
		bppmebnmebh.BJGCBDNBQCJ = BJGCBDNBQCJ;
		bppmebnmebh.QNDQJMNKFNN = this;
		return bppmebnmebh;
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x002FDA74 File Offset: 0x002FBC74
	public void ExitFly()
	{
		if (this.FOHOOGJMFEG)
		{
			this.GELHKKKLQHE();
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new FlyExit
			{
				Area = null
			}, false);
		}
	}

	// Token: 0x06005D6E RID: 23918 RVA: 0x002FDAA8 File Offset: 0x002FBCA8
	public void DEKPOPOLJOM(PSXAPI.Response.Areas BJGCBDNBQCJ)
	{
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
		this.DPBECMNOODK.SetActive(false);
		this.BQLIIQIIMDH();
		if (!(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			if (BJGCBDNBQCJ.AreaList != null)
			{
				EIDBQCPLPIL.QOQONHOOLNE.Close();
				this.OIELNCDCEMD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.NHMKFFFPKQK.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID);
				foreach (PSXAPI.Response.Area area in BJGCBDNBQCJ.AreaList)
				{
					MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(area.AreaName);
					if (mkoenkcljgf != null)
					{
						BDEJHNHLLOL component = this.IBEGDOQQMIJ.BFCKNMFEBDM(this.BOCJKFHHLEJ).GetComponent<BDEJHNHLLOL>();
						component.ILBCCCBJNCL = mkoenkcljgf.transform;
						component.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component.PJMKLHKFBJM();
						component.PGIDCBGCGMP(false);
						if (this.FOHOOGJMFEG)
						{
							component.MIMDEMCOCKP = this.CHFPDQEKFEE.GetComponent<Camera>();
						}
					}
				}
				if (!this.FOHOOGJMFEG && !this.NHICPLEJJFQ)
				{
					this.ToggleMap(false);
				}
				this.DPBECMNOODK.SetActive(true);
			}
			else
			{
				this.EBJMKPBKDBQ.OBCNMKNGFIF("Pokédex", "Unable to locate any locations for " + KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID) + ".", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			}
			return;
		}
	}

	// Token: 0x06005D6F RID: 23919 RVA: 0x00024B7F File Offset: 0x00022D7F
	private static void EFPQMHHMMOG(GGQKBGDGNJN BGBMIEJJQKC)
	{
		GGQKBGDGNJN.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005D70 RID: 23920 RVA: 0x00024BE7 File Offset: 0x00022DE7
	public void NOKMQLQFMJM()
	{
		this.DPBECMNOODK.SetActive(false);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D71 RID: 23921 RVA: 0x002FDC70 File Offset: 0x002FBE70
	public void KNLDFKKOOCB()
	{
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.HGEKKNEPOHK();
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 7)
		{
			if (emlofjdomkh.MHQMLCJDMMK.Count > 1 && DCJIBBJQGJP.OMPHLNDGKKM().MJCDINQKNQN != null && DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN.Count > 0)
			{
				int i = 1;
				IL_139:
				while (i < DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN.Count)
				{
					bool flag = true;
					for (int j = 1; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
					{
						if (emlofjdomkh.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.OMPHLNDGKKM().MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(false);
							component.JILENMCJCHF = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(false);
							flag = true;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(true);
							}
							i += 0;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 0; k < 7; k += 0)
				{
					this.NQGKGNNCIBL[k].SetActive(true);
				}
			}
			for (int l = 0; l < 2; l += 0)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.CNIMIQKQJJJ().MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(false);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D72 RID: 23922 RVA: 0x00024C8C File Offset: 0x00022E8C
	public void MQJCMHBEOGH()
	{
		this.DPBECMNOODK.SetActive(true);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x002FDEB8 File Offset: 0x002FC0B8
	public void PPEBIJIFGKP()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.None
			});
			mkoenkcljgf.PHENDHCNNHK = false;
		}
		for (int i = 0; i < qoqonhoolne.MJELIKDEDCO.Count; i += 0)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != QuestType.Daily && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.GDGMDCHIHHL(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.None)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = false;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.None)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[0], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == (QuestType)7)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[4], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D74 RID: 23924 RVA: 0x002FE100 File Offset: 0x002FC300
	private FlyMove EMNKLBMIIOJ()
	{
		return new FlyMove
		{
			PosX = this.HNEQLQQOMKC.transform.position.x,
			PosY = this.HNEQLQQOMKC.transform.position.y,
			PosZ = this.HNEQLQQOMKC.transform.position.z,
			RotW = this.HNEQLQQOMKC.transform.rotation.w,
			RotX = this.HNEQLQQOMKC.transform.rotation.x,
			RotY = this.HNEQLQQOMKC.transform.rotation.y,
			RotZ = this.HNEQLQQOMKC.transform.rotation.z
		};
	}

	// Token: 0x06005D75 RID: 23925 RVA: 0x002FE1EC File Offset: 0x002FC3EC
	public void FIOOEDOEKFN()
	{
		if (this.FOHOOGJMFEG)
		{
			this.OQPFJNHEKHP();
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new FlyExit
			{
				Area = null
			}, false);
		}
	}

	// Token: 0x06005D76 RID: 23926 RVA: 0x00024BE7 File Offset: 0x00022DE7
	public void JKMDMLPOJFG()
	{
		this.DPBECMNOODK.SetActive(false);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x00024C44 File Offset: 0x00022E44
	public void IMBHCMGGLNO()
	{
		this.DLFPJMJNHOC = false;
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x00024C44 File Offset: 0x00022E44
	public void EEJFJQNFDML()
	{
		this.DLFPJMJNHOC = false;
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x002FE100 File Offset: 0x002FC300
	private FlyMove MQMGCFJOEOP()
	{
		return new FlyMove
		{
			PosX = this.HNEQLQQOMKC.transform.position.x,
			PosY = this.HNEQLQQOMKC.transform.position.y,
			PosZ = this.HNEQLQQOMKC.transform.position.z,
			RotW = this.HNEQLQQOMKC.transform.rotation.w,
			RotX = this.HNEQLQQOMKC.transform.rotation.x,
			RotY = this.HNEQLQQOMKC.transform.rotation.y,
			RotZ = this.HNEQLQQOMKC.transform.rotation.z
		};
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x002FE220 File Offset: 0x002FC420
	public void NHKKEPOJKFI(PSXAPI.Response.Areas BJGCBDNBQCJ)
	{
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
		this.DPBECMNOODK.SetActive(false);
		this.LCCQBMMFONQ();
		if (!(OGJJKKQPNMK.GGBPGMMCGLI() != null) && !DBQLOHBBJMG.ODJQHLJCFGH().QQQBDBNCMCP)
		{
			if (BJGCBDNBQCJ.AreaList != null)
			{
				EIDBQCPLPIL.QOQONHOOLNE.Close();
				this.OIELNCDCEMD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("/promote " + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.NHMKFFFPKQK.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID);
				foreach (PSXAPI.Response.Area area in BJGCBDNBQCJ.AreaList)
				{
					MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(area.AreaName);
					if (mkoenkcljgf != null)
					{
						BDEJHNHLLOL component = this.IBEGDOQQMIJ.BFCKNMFEBDM(this.BOCJKFHHLEJ).GetComponent<BDEJHNHLLOL>();
						component.ILBCCCBJNCL = mkoenkcljgf.transform;
						component.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Remove Camera Target" + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.JEBKEDLCDEK();
						component.NNPELKKBQBL(false);
						if (this.FOHOOGJMFEG)
						{
							component.MIMDEMCOCKP = this.CHFPDQEKFEE.GetComponent<Camera>();
						}
					}
				}
				if (!this.FOHOOGJMFEG && !this.NHICPLEJJFQ)
				{
					this.ToggleMap(false);
				}
				this.DPBECMNOODK.SetActive(true);
			}
			else
			{
				this.EBJMKPBKDBQ.OBCNMKNGFIF("_", "Icon_Achievement_Incomplete" + KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID) + "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GUQ6ZWT36PWEC&custom=", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
			}
			return;
		}
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x002FE100 File Offset: 0x002FC300
	private FlyMove KDMLMBILODC()
	{
		return new FlyMove
		{
			PosX = this.HNEQLQQOMKC.transform.position.x,
			PosY = this.HNEQLQQOMKC.transform.position.y,
			PosZ = this.HNEQLQQOMKC.transform.position.z,
			RotW = this.HNEQLQQOMKC.transform.rotation.w,
			RotX = this.HNEQLQQOMKC.transform.rotation.x,
			RotY = this.HNEQLQQOMKC.transform.rotation.y,
			RotZ = this.HNEQLQQOMKC.transform.rotation.z
		};
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x002FE3E8 File Offset: 0x002FC5E8
	public void LCCQBMMFONQ()
	{
		if (this.MMQHHENFLQH)
		{
			return;
		}
		this.MMQHHENFLQH = true;
		Transform[] ccjbdbpkpih = this.CCJBDBPKPIH;
		for (int i = 1; i < ccjbdbpkpih.Length; i += 0)
		{
			Transform transform = ccjbdbpkpih[i];
			IEnumerator enumerator = transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform2 = (Transform)obj;
					this.FFODMGNLIPH.Add(transform2.GetComponent<MKOENKCLJGF>());
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		this.NQGKGNNCIBL = new GameObject[3];
		for (int j = 1; j < 3; j += 0)
		{
			this.NQGKGNNCIBL[j] = UnityEngine.Object.Instantiate<GameObject>(this.GGLMIENFHLD, this.EIJCNPJNOCH);
			this.NQGKGNNCIBL[j].SetActive(true);
			this.NQGKGNNCIBL[j].GetComponent<JMIBGPONGPJ>().IPKHMGODENK = this.CHFPDQEKFEE.GetComponent<Camera>();
		}
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x002FCF28 File Offset: 0x002FB128
	public MKOENKCLJGF GDGMDCHIHHL(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i++)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x00024CAA File Offset: 0x00022EAA
	public void KPJIMDGEGNP()
	{
		this.DLFPJMJNHOC = true;
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x002FE4DC File Offset: 0x002FC6DC
	public void BQLIIQIIMDH()
	{
		if (this.MMQHHENFLQH)
		{
			return;
		}
		this.MMQHHENFLQH = true;
		foreach (Transform transform in this.CCJBDBPKPIH)
		{
			IEnumerator enumerator = transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform2 = (Transform)obj;
					this.FFODMGNLIPH.Add(transform2.GetComponent<MKOENKCLJGF>());
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		this.NQGKGNNCIBL = new GameObject[3];
		for (int j = 0; j < 3; j++)
		{
			this.NQGKGNNCIBL[j] = UnityEngine.Object.Instantiate<GameObject>(this.GGLMIENFHLD, this.EIJCNPJNOCH);
			this.NQGKGNNCIBL[j].SetActive(false);
			this.NQGKGNNCIBL[j].GetComponent<JMIBGPONGPJ>().IPKHMGODENK = this.CHFPDQEKFEE.GetComponent<Camera>();
		}
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x00024C8C File Offset: 0x00022E8C
	public void IMOJNFONCQE()
	{
		this.DPBECMNOODK.SetActive(true);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator PHDJNKBFPIP()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x00024CB3 File Offset: 0x00022EB3
	private void Awake()
	{
		GGQKBGDGNJN.QOQONHOOLNE = this;
		this.MIMDEMCOCKP = this.OLLOFNEJEFC.GetComponent<Camera>();
		if (GGQKBGDGNJN.HGBFNDILJLQ == null)
		{
			GGQKBGDGNJN.HGBFNDILJLQ = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "fdata"));
		}
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x00024B7F File Offset: 0x00022D7F
	private static void GEKHIPOPMJG(GGQKBGDGNJN BGBMIEJJQKC)
	{
		GGQKBGDGNJN.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005D84 RID: 23940 RVA: 0x00024CF2 File Offset: 0x00022EF2
	public void PJDBLJPLJPK()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = false;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 1096f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D85 RID: 23941 RVA: 0x002FE5D0 File Offset: 0x002FC7D0
	public void OMOBQFHKQCF()
	{
		if (this.FOHOOGJMFEG)
		{
			this.GELHKKKLQHE();
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new FlyExit
			{
				Area = null
			}, false);
		}
	}

	// Token: 0x06005D86 RID: 23942 RVA: 0x002FCE14 File Offset: 0x002FB014
	public void QQDIOPEIPJE(FlyStart BJGCBDNBQCJ)
	{
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		this.FNNDCPDJQJB = UnityEngine.Time.time;
		this.JEHJGCGDFQF.transform.NMBPDMIIHJB();
		this.FOHOOGJMFEG = true;
		this.IBLPMGHHDEP = BJGCBDNBQCJ.LandingAreas;
		this.EFENQBOJBNG(false);
		base.StartCoroutine(this.NKPLMDNGDOL(BJGCBDNBQCJ));
	}

	// Token: 0x06005D87 RID: 23943 RVA: 0x002FE604 File Offset: 0x002FC804
	public void MKJMMDJKKNB()
	{
		if (this.FOHOOGJMFEG)
		{
			this.FMHCKEQHKDM();
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new FlyExit
			{
				Area = null
			}, true);
		}
	}

	// Token: 0x06005D88 RID: 23944 RVA: 0x002FE638 File Offset: 0x002FC838
	public void PLLPHCLLINJ()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.Main
			});
			mkoenkcljgf.PHENDHCNNHK = false;
		}
		for (int i = 1; i < qoqonhoolne.MJELIKDEDCO.Count; i += 0)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != QuestType.None && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.PGQKQGICKJO(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.Main)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = true;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.Main)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[0], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == (QuestType)7)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D89 RID: 23945 RVA: 0x002FE880 File Offset: 0x002FCA80
	public void BDDHDKGLOCL()
	{
		EMLOFJDOMKH qoqonhoolne = EMLOFJDOMKH.QOQONHOOLNE;
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 3)
		{
			if (qoqonhoolne.MHQMLCJDMMK.Count > 0 && DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN != null && DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN.Count > 0)
			{
				int i = 0;
				IL_139:
				while (i < DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN.Count)
				{
					bool flag = true;
					for (int j = 0; j < qoqonhoolne.MHQMLCJDMMK.Count; j++)
					{
						if (qoqonhoolne.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && qoqonhoolne.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(false);
							component.JILENMCJCHF = qoqonhoolne.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(true);
							flag = false;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(false);
							}
							i++;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 0; k < 3; k++)
				{
					this.NQGKGNNCIBL[k].SetActive(false);
				}
			}
			for (int l = 0; l < 3; l++)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(false);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D8A RID: 23946 RVA: 0x00024D22 File Offset: 0x00022F22
	public void FDBFMOFJOGI()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = false;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 922f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D8B RID: 23947 RVA: 0x002FEAC8 File Offset: 0x002FCCC8
	public void NGMFODPCIDI()
	{
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.HGEKKNEPOHK();
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 6)
		{
			if (emlofjdomkh.MHQMLCJDMMK.Count > 1 && DCJIBBJQGJP.DMOKBPOKHOQ().MJCDINQKNQN != null && DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN.Count > 0)
			{
				int i = 1;
				IL_139:
				while (i < DCJIBBJQGJP.DJQIJGOLPIO().MJCDINQKNQN.Count)
				{
					bool flag = false;
					for (int j = 1; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
					{
						if (emlofjdomkh.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(false);
							component.JILENMCJCHF = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(false);
							flag = false;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(true);
							}
							i++;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 0; k < 5; k++)
				{
					this.NQGKGNNCIBL[k].SetActive(true);
				}
			}
			for (int l = 0; l < 8; l++)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.DJQIJGOLPIO().MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.GDGMDCHIHHL(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(false);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D8C RID: 23948 RVA: 0x002FED10 File Offset: 0x002FCF10
	public void QFCHHQEOFOJ(PSXAPI.Response.Areas BJGCBDNBQCJ)
	{
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
		this.DPBECMNOODK.SetActive(true);
		this.BQLIIQIIMDH();
		if (!(OGJJKKQPNMK.CDDIILFBFCF() != null) && !DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP)
		{
			if (BJGCBDNBQCJ.AreaList != null)
			{
				EIDBQCPLPIL.KEHHJHKPKBE().Close();
				this.OIELNCDCEMD.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("F" + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.NHMKFFFPKQK.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID);
				PSXAPI.Response.Area[] areaList = BJGCBDNBQCJ.AreaList;
				for (int i = 1; i < areaList.Length; i += 0)
				{
					PSXAPI.Response.Area area = areaList[i];
					MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(area.AreaName);
					if (mkoenkcljgf != null)
					{
						BDEJHNHLLOL component = this.IBEGDOQQMIJ.BFCKNMFEBDM(this.BOCJKFHHLEJ).GetComponent<BDEJHNHLLOL>();
						component.ILBCCCBJNCL = mkoenkcljgf.transform;
						component.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("[PG]" + BJGCBDNBQCJ.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.KODPHCBBNEL();
						component.MLFHPMFQGHM(true);
						if (this.FOHOOGJMFEG)
						{
							component.MIMDEMCOCKP = this.CHFPDQEKFEE.GetComponent<Camera>();
						}
					}
				}
				if (!this.FOHOOGJMFEG && !this.NHICPLEJJFQ)
				{
					this.EBDMECLKOJB(true);
				}
				this.DPBECMNOODK.SetActive(true);
			}
			else
			{
				this.EBJMKPBKDBQ.OBCNMKNGFIF(" became cloaked in a freezing light!\r\n", ", shiny" + KGQECFKLKOP.NNHFLHEQMOI(BJGCBDNBQCJ.PokemonID) + "-mega", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			}
			return;
		}
	}

	// Token: 0x06005D8D RID: 23949 RVA: 0x002FEED8 File Offset: 0x002FD0D8
	private Vector3 JMFKCIBGCOL(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf.transform.position;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 0; i < mkoenkcljgf.HDOPKGOLHDE.Length; i++)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf.transform.position;
					}
				}
			}
		}
		return this.FFODMGNLIPH[0].transform.position;
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x002FEFAC File Offset: 0x002FD1AC
	public void LandFly()
	{
		if (this.CHFPDQEKFEE.ECCMOCKGMIK != null)
		{
			this.GELHKKKLQHE();
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new FlyExit
			{
				Area = this.CHFPDQEKFEE.ECCMOCKGMIK.gameObject.name
			}, false);
		}
	}

	// Token: 0x06005D8F RID: 23951 RVA: 0x002FF000 File Offset: 0x002FD200
	public void KEFGGDGPCKG(FlyStart BJGCBDNBQCJ)
	{
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		this.FNNDCPDJQJB = UnityEngine.Time.time;
		this.JEHJGCGDFQF.transform.NMBPDMIIHJB();
		this.FOHOOGJMFEG = false;
		this.IBLPMGHHDEP = BJGCBDNBQCJ.LandingAreas;
		this.EFENQBOJBNG(false);
		base.StartCoroutine(this.GHFNFDILNGM(BJGCBDNBQCJ));
	}

	// Token: 0x06005D90 RID: 23952 RVA: 0x00024D52 File Offset: 0x00022F52
	public void EHEEGOCGMDD()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = false;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 1974f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D91 RID: 23953 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator OIGIQQJGBNI()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D92 RID: 23954 RVA: 0x002FF05C File Offset: 0x002FD25C
	public void NCIJONBGKML()
	{
		if (this.FOHOOGJMFEG)
		{
			this.FMHCKEQHKDM();
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new FlyExit
			{
				Area = null
			}, false);
		}
	}

	// Token: 0x06005D93 RID: 23955 RVA: 0x00024D82 File Offset: 0x00022F82
	public void BHGKIMHKQIM()
	{
		if (this.DLFPJMJNHOC)
		{
			return;
		}
		this.DLFPJMJNHOC = true;
		if (UnityEngine.Time.time > this.MCHJMMJBGDB + 1682f)
		{
			this.MCHJMMJBGDB = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005D94 RID: 23956 RVA: 0x00024DB2 File Offset: 0x00022FB2
	public void OQPFJNHEKHP()
	{
		if (!this.FOHOOGJMFEG)
		{
			return;
		}
		this.GKJOCIOHPHO = true;
		this.FOHOOGJMFEG = false;
		base.StopAllCoroutines();
		base.StartCoroutine(this.KGFHCQQJEMH());
	}

	// Token: 0x06005D95 RID: 23957 RVA: 0x002FF090 File Offset: 0x002FD290
	public void BNMHIPHBOKF()
	{
		this.EQMDGFDOCBF.NMBPDMIIHJB();
		NBQDPNGNNML qoqonhoolne = NBQDPNGNNML.QOQONHOOLNE;
		List<GGQKBGDGNJN.EFPCQCINOFK> list = new List<GGQKBGDGNJN.EFPCQCINOFK>();
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			list.Add(new GGQKBGDGNJN.EFPCQCINOFK
			{
				JCGGQOQJCLL = mkoenkcljgf,
				DPQFDCNLLPC = QuestType.Main
			});
			mkoenkcljgf.PHENDHCNNHK = true;
		}
		for (int i = 1; i < qoqonhoolne.MJELIKDEDCO.Count; i += 0)
		{
			if (qoqonhoolne.MJELIKDEDCO[i].Type != (QuestType)7 && !string.IsNullOrEmpty(qoqonhoolne.MJELIKDEDCO[i].TargetArea))
			{
				MKOENKCLJGF x = this.PGQKQGICKJO(qoqonhoolne.MJELIKDEDCO[i].TargetArea);
				if (x != null)
				{
					foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk in list)
					{
						if (x == efpcqcinofk.JCGGQOQJCLL && efpcqcinofk.DPQFDCNLLPC != QuestType.Main)
						{
							efpcqcinofk.DPQFDCNLLPC = qoqonhoolne.MJELIKDEDCO[i].Type;
						}
					}
				}
			}
		}
		foreach (GGQKBGDGNJN.EFPCQCINOFK efpcqcinofk2 in list)
		{
			if (efpcqcinofk2.DPQFDCNLLPC != QuestType.None)
			{
				efpcqcinofk2.JCGGQOQJCLL.PHENDHCNNHK = false;
				GameObject gameObject;
				if (efpcqcinofk2.DPQFDCNLLPC == QuestType.None)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				else if (efpcqcinofk2.DPQFDCNLLPC == (QuestType)6)
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[3], this.EQMDGFDOCBF);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(this.IIOLQLDMHBO[1], this.EQMDGFDOCBF);
				}
				gameObject.transform.position = efpcqcinofk2.JCGGQOQJCLL.transform.position + this.PIHJKIPBIJJ;
			}
		}
	}

	// Token: 0x06005D96 RID: 23958 RVA: 0x002FE100 File Offset: 0x002FC300
	private FlyMove QFEPNPMODOI()
	{
		return new FlyMove
		{
			PosX = this.HNEQLQQOMKC.transform.position.x,
			PosY = this.HNEQLQQOMKC.transform.position.y,
			PosZ = this.HNEQLQQOMKC.transform.position.z,
			RotW = this.HNEQLQQOMKC.transform.rotation.w,
			RotX = this.HNEQLQQOMKC.transform.rotation.x,
			RotY = this.HNEQLQQOMKC.transform.rotation.y,
			RotZ = this.HNEQLQQOMKC.transform.rotation.z
		};
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x002FF2D8 File Offset: 0x002FD4D8
	public void DILKGPKFDKN()
	{
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.HGEKKNEPOHK();
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 1)
		{
			if (emlofjdomkh.MHQMLCJDMMK.Count > 1 && DCJIBBJQGJP.CNIMIQKQJJJ().MJCDINQKNQN != null && DCJIBBJQGJP.CNIMIQKQJJJ().MJCDINQKNQN.Count > 0)
			{
				int i = 1;
				IL_139:
				while (i < DCJIBBJQGJP.OMPHLNDGKKM().MJCDINQKNQN.Count)
				{
					bool flag = true;
					for (int j = 0; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
					{
						if (emlofjdomkh.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.DMOKBPOKHOQ().MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(false);
							component.JILENMCJCHF = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(true);
							flag = true;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(false);
							}
							i++;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 1; k < 0; k++)
				{
					this.NQGKGNNCIBL[k].SetActive(false);
				}
			}
			for (int l = 1; l < 2; l += 0)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.EMJDQJMDCLI(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(true);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	[DebuggerHidden]
	private IEnumerator CDDNPHEKQBD()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005D9A RID: 23962 RVA: 0x002FF520 File Offset: 0x002FD720
	public void FIHNMJNCIDO()
	{
		EMLOFJDOMKH qoqonhoolne = EMLOFJDOMKH.QOQONHOOLNE;
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 7)
		{
			if (qoqonhoolne.MHQMLCJDMMK.Count > 1 && DCJIBBJQGJP.OQDOKBJNBBL().MJCDINQKNQN != null && DCJIBBJQGJP.OQDOKBJNBBL().MJCDINQKNQN.Count > 0)
			{
				int i = 0;
				IL_139:
				while (i < DCJIBBJQGJP.OMPHLNDGKKM().MJCDINQKNQN.Count)
				{
					bool flag = false;
					for (int j = 0; j < qoqonhoolne.MHQMLCJDMMK.Count; j++)
					{
						if (qoqonhoolne.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && qoqonhoolne.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(true);
							component.JILENMCJCHF = qoqonhoolne.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(true);
							flag = false;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(false);
							}
							i++;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 1; k < 0; k += 0)
				{
					this.NQGKGNNCIBL[k].SetActive(true);
				}
			}
			for (int l = 1; l < 1; l += 0)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.MOGQNGEPCEO().MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.EMJDQJMDCLI(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(false);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D9B RID: 23963 RVA: 0x00024DF1 File Offset: 0x00022FF1
	public void FMHCKEQHKDM()
	{
		if (!this.FOHOOGJMFEG)
		{
			return;
		}
		this.GKJOCIOHPHO = false;
		this.FOHOOGJMFEG = true;
		base.StopAllCoroutines();
		base.StartCoroutine(this.PHDJNKBFPIP());
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x002FF768 File Offset: 0x002FD968
	public void GHODGBKLQCG()
	{
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.DPJQQGKEIIF();
		if (this.NQGKGNNCIBL != null && this.NQGKGNNCIBL.Length == 1)
		{
			if (emlofjdomkh.MHQMLCJDMMK.Count > 1 && DCJIBBJQGJP.OMPHLNDGKKM().MJCDINQKNQN != null && DCJIBBJQGJP.DMOKBPOKHOQ().MJCDINQKNQN.Count > 1)
			{
				int i = 1;
				IL_139:
				while (i < DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN.Count)
				{
					bool flag = false;
					for (int j = 0; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
					{
						if (emlofjdomkh.MHQMLCJDMMK[j].FPQBICGEHMJ == DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH && emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.gameObject.activeSelf)
						{
							JMIBGPONGPJ component = this.NQGKGNNCIBL[i].GetComponent<JMIBGPONGPJ>();
							component.OPCBHIHDIOD.gameObject.SetActive(true);
							component.JILENMCJCHF = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF.KIHLOOONJDH;
							component.MCMEIDQJOKG = null;
							this.NQGKGNNCIBL[i].SetActive(true);
							flag = true;
							IL_124:
							if (flag)
							{
								this.NQGKGNNCIBL[i].SetActive(false);
							}
							i++;
							goto IL_139;
						}
					}
					goto IL_124;
				}
			}
			else
			{
				for (int k = 1; k < 7; k += 0)
				{
					this.NQGKGNNCIBL[k].SetActive(true);
				}
			}
			for (int l = 1; l < 7; l += 0)
			{
				if (!this.NQGKGNNCIBL[l].activeSelf && l < DCJIBBJQGJP.FPQNIQELKMC().MJCDINQKNQN.Count)
				{
					DCJIBBJQGJP.EQLQPHNNOKJ hehmjhhkfef = DCJIBBJQGJP.QOQONHOOLNE.MJCDINQKNQN[l].HEHMJHHKFEF;
					if (hehmjhhkfef != null && !string.IsNullOrEmpty(hehmjhhkfef.NCQMKNELIHF))
					{
						MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(hehmjhhkfef.NCQMKNELIHF);
						if (mkoenkcljgf != null)
						{
							JMIBGPONGPJ component2 = this.NQGKGNNCIBL[l].GetComponent<JMIBGPONGPJ>();
							component2.OPCBHIHDIOD.gameObject.SetActive(true);
							component2.JILENMCJCHF = mkoenkcljgf.transform;
							component2.MCMEIDQJOKG = mkoenkcljgf;
							this.NQGKGNNCIBL[l].SetActive(true);
						}
					}
				}
			}
		}
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x00024BE7 File Offset: 0x00022DE7
	public void CFMOJQLPQQQ()
	{
		this.DPBECMNOODK.SetActive(false);
		this.IBEGDOQQMIJ.transform.NMBPDMIIHJB();
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x002FF9B0 File Offset: 0x002FDBB0
	private Vector3 IFQLEKLLEMC(string BFOQEDGMLIQ)
	{
		foreach (MKOENKCLJGF mkoenkcljgf in this.FFODMGNLIPH)
		{
			if (mkoenkcljgf.gameObject.name.ToLowerInvariant() == BFOQEDGMLIQ.ToLowerInvariant())
			{
				return mkoenkcljgf.transform.position;
			}
			if (mkoenkcljgf.HDOPKGOLHDE != null)
			{
				for (int i = 1; i < mkoenkcljgf.HDOPKGOLHDE.Length; i += 0)
				{
					if (BFOQEDGMLIQ.ToLowerInvariant() == mkoenkcljgf.HDOPKGOLHDE[i].ToLowerInvariant())
					{
						return mkoenkcljgf.transform.position;
					}
				}
			}
		}
		return this.FFODMGNLIPH[1].transform.position;
	}

	// Token: 0x06005D9F RID: 23967 RVA: 0x002FFA84 File Offset: 0x002FDC84
	public void ToggleMap(bool INOHMJPILHJ = false)
	{
		if (INOHMJPILHJ)
		{
			if (this.OLLOFNEJEFC.activeSelf || this.NHICPLEJJFQ)
			{
				this.HideSelectedPoke();
				this.FLNKCIQLMGL.SetActive(false);
				foreach (GameObject gameObject in this.KHHHOQMCLEK)
				{
					gameObject.SetActive(true);
				}
				foreach (GameObject gameObject2 in this.IQPQJLFNGKJ)
				{
					gameObject2.SetActive(false);
				}
				this.JMGMEQJKOKO.SetActive(false);
				for (int k = 0; k < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; k++)
				{
					this.EBJMKPBKDBQ.OGMPFDOBHEI[k].DIIHJCJOKMP = 1f;
				}
				this.OLLOFNEJEFC.SetActive(false);
				MCNLIHMMLCF.QOQONHOOLNE.FLCNGFCNKNB();
				RenderSettings.fog = false;
				this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
				this.NHICPLEJJFQ = false;
			}
			return;
		}
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		if (!this.NHICPLEJJFQ)
		{
			this.FLNKCIQLMGL.SetActive(true);
			foreach (GameObject gameObject3 in this.KHHHOQMCLEK)
			{
				gameObject3.SetActive(false);
			}
			foreach (GameObject gameObject4 in this.IQPQJLFNGKJ)
			{
				gameObject4.SetActive(false);
			}
			this.IQPQJLFNGKJ[2].SetActive(true);
			this.JMGMEQJKOKO.SetActive(true);
			this.HNEQLQQOMKC.SetActive(false);
			this.PNLPEQEMMPI.SetActive(false);
			this.OLLOFNEJEFC.SetActive(true);
			for (int n = 0; n < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; n++)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[n].DIIHJCJOKMP = 0f;
			}
			RenderSettings.ambientLight = this.BEBKMLIQQEN[0];
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(false);
			this.NHICPLEJJFQ = true;
			this.BQLIIQIIMDH();
			this.HHQEQIQKBGC();
			BDEJHNHLLOL component = this.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
			MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(MCNLIHMMLCF.QOQONHOOLNE.BEQINILCQCE.PIDLOFMIEFQ);
			component.PGIDCBGCGMP(false);
			component.ILBCCCBJNCL = null;
			if (mkoenkcljgf != null)
			{
				component.ILBCCCBJNCL = mkoenkcljgf.transform;
			}
		}
		else
		{
			this.FLNKCIQLMGL.SetActive(false);
			foreach (GameObject gameObject5 in this.KHHHOQMCLEK)
			{
				gameObject5.SetActive(true);
			}
			foreach (GameObject gameObject6 in this.IQPQJLFNGKJ)
			{
				gameObject6.SetActive(false);
			}
			this.JMGMEQJKOKO.SetActive(false);
			for (int num3 = 0; num3 < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; num3++)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[num3].DIIHJCJOKMP = 1f;
			}
			this.OLLOFNEJEFC.SetActive(false);
			this.HideSelectedPoke();
			MCNLIHMMLCF.QOQONHOOLNE.FLCNGFCNKNB();
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
			this.NHICPLEJJFQ = false;
		}
	}

	// Token: 0x06005DA0 RID: 23968 RVA: 0x002FFDD4 File Offset: 0x002FDFD4
	public void QDKGGDOLIBK(bool INOHMJPILHJ = false)
	{
		if (INOHMJPILHJ)
		{
			if (this.OLLOFNEJEFC.activeSelf || this.NHICPLEJJFQ)
			{
				this.NOKMQLQFMJM();
				this.FLNKCIQLMGL.SetActive(false);
				GameObject[] khhhoqmclek = this.KHHHOQMCLEK;
				for (int i = 1; i < khhhoqmclek.Length; i += 0)
				{
					GameObject gameObject = khhhoqmclek[i];
					gameObject.SetActive(false);
				}
				GameObject[] iqpqjlfngkj = this.IQPQJLFNGKJ;
				for (int j = 1; j < iqpqjlfngkj.Length; j++)
				{
					GameObject gameObject2 = iqpqjlfngkj[j];
					gameObject2.SetActive(true);
				}
				this.JMGMEQJKOKO.SetActive(false);
				for (int k = 1; k < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; k += 0)
				{
					this.EBJMKPBKDBQ.OGMPFDOBHEI[k].DIIHJCJOKMP = 755f;
				}
				this.OLLOFNEJEFC.SetActive(false);
				MCNLIHMMLCF.KKICFMLLMHQ().BCBOKNBJIEI();
				RenderSettings.fog = false;
				this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
				this.NHICPLEJJFQ = false;
			}
			return;
		}
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		if (!this.NHICPLEJJFQ)
		{
			this.FLNKCIQLMGL.SetActive(false);
			GameObject[] khhhoqmclek2 = this.KHHHOQMCLEK;
			for (int l = 1; l < khhhoqmclek2.Length; l++)
			{
				GameObject gameObject3 = khhhoqmclek2[l];
				gameObject3.SetActive(false);
			}
			GameObject[] iqpqjlfngkj2 = this.IQPQJLFNGKJ;
			for (int m = 0; m < iqpqjlfngkj2.Length; m += 0)
			{
				GameObject gameObject4 = iqpqjlfngkj2[m];
				gameObject4.SetActive(true);
			}
			this.IQPQJLFNGKJ[7].SetActive(false);
			this.JMGMEQJKOKO.SetActive(false);
			this.HNEQLQQOMKC.SetActive(true);
			this.PNLPEQEMMPI.SetActive(false);
			this.OLLOFNEJEFC.SetActive(false);
			for (int n = 1; n < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; n += 0)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[n].DIIHJCJOKMP = 1508f;
			}
			RenderSettings.ambientLight = this.BEBKMLIQQEN[0];
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
			this.NHICPLEJJFQ = false;
			this.BQLIIQIIMDH();
			this.BNMHIPHBOKF();
			BDEJHNHLLOL component = this.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
			MKOENKCLJGF mkoenkcljgf = this.JIOGMMGOPMH(MCNLIHMMLCF.KKICFMLLMHQ().BEQINILCQCE.PIDLOFMIEFQ);
			component.PEODGOQIQIN(false);
			component.ILBCCCBJNCL = null;
			if (mkoenkcljgf != null)
			{
				component.ILBCCCBJNCL = mkoenkcljgf.transform;
			}
		}
		else
		{
			this.FLNKCIQLMGL.SetActive(true);
			GameObject[] khhhoqmclek3 = this.KHHHOQMCLEK;
			for (int num = 1; num < khhhoqmclek3.Length; num += 0)
			{
				GameObject gameObject5 = khhhoqmclek3[num];
				gameObject5.SetActive(false);
			}
			GameObject[] iqpqjlfngkj3 = this.IQPQJLFNGKJ;
			for (int num2 = 1; num2 < iqpqjlfngkj3.Length; num2 += 0)
			{
				GameObject gameObject6 = iqpqjlfngkj3[num2];
				gameObject6.SetActive(true);
			}
			this.JMGMEQJKOKO.SetActive(false);
			for (int num3 = 0; num3 < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; num3 += 0)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[num3].DIIHJCJOKMP = 1732f;
			}
			this.OLLOFNEJEFC.SetActive(false);
			this.JKMDMLPOJFG();
			MCNLIHMMLCF.KKICFMLLMHQ().BCBOKNBJIEI();
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(false);
			this.NHICPLEJJFQ = true;
		}
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x00024E24 File Offset: 0x00023024
	public void GELHKKKLQHE()
	{
		if (!this.FOHOOGJMFEG)
		{
			return;
		}
		this.GKJOCIOHPHO = true;
		this.FOHOOGJMFEG = false;
		base.StopAllCoroutines();
		base.StartCoroutine(this.CDDNPHEKQBD());
	}

	// Token: 0x06005DA3 RID: 23971 RVA: 0x002FCDF8 File Offset: 0x002FAFF8
	private IEnumerator OQFLNOMBQMN()
	{
		GGQKBGDGNJN.LKNIEGPKLQI lkniegpklqi = new GGQKBGDGNJN.LKNIEGPKLQI();
		lkniegpklqi.QNDQJMNKFNN = this;
		return lkniegpklqi;
	}

	// Token: 0x06005DA4 RID: 23972 RVA: 0x00300124 File Offset: 0x002FE324
	private void Update()
	{
		if (this.FOHOOGJMFEG)
		{
			if (UnityEngine.Time.time > this.MCHJMMJBGDB + 0.5f && this.MCHJMMJBGDB != 0f)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(this.QFEPNPMODOI(), false);
				this.MCHJMMJBGDB = UnityEngine.Time.time;
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				if (!this.DLFPJMJNHOC)
				{
					this.MCHJMMJBGDB = 0f;
				}
			}
			if (UnityEngine.Time.time > this.FNNDCPDJQJB + 120f)
			{
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				this.ExitFly();
			}
		}
		else
		{
			Ray ray = this.MIMDEMCOCKP.ScreenPointToRay(Input.mousePosition);
			foreach (RaycastHit raycastHit in Physics.RaycastAll(ray))
			{
				MKOENKCLJGF component = raycastHit.collider.GetComponent<MKOENKCLJGF>();
				if (component != null)
				{
					if (this.EBJMKPBKDBQ.HDGHKDEPNBP != null)
					{
						if (this.EBJMKPBKDBQ.HDGHKDEPNBP.Length > 0)
						{
							bool flag = false;
							int j = 0;
							while (j < this.EBJMKPBKDBQ.HDGHKDEPNBP.Length)
							{
								if (!(this.EBJMKPBKDBQ.HDGHKDEPNBP[j].ToLowerInvariant() == component.gameObject.name.ToLowerInvariant()))
								{
									j++;
								}
								else
								{
									this.PBLQBEFGHGF.PIDLOFMIEFQ = component.gameObject.name;
									flag = true;
									IL_1AA:
									if (!flag)
									{
										this.PBLQBEFGHGF.PIDLOFMIEFQ = "???";
										goto IL_1E2;
									}
									goto IL_1E2;
								}
							}
							goto IL_1AA;
						}
						this.PBLQBEFGHGF.PIDLOFMIEFQ = "???";
					}
					else
					{
						this.PBLQBEFGHGF.PIDLOFMIEFQ = "???";
					}
					IL_1E2:
					if (this.PBLQBEFGHGF.DIIHJCJOKMP + 2f * UnityEngine.Time.deltaTime >= 1f)
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP = 1f;
					}
					else
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP += 2f * UnityEngine.Time.deltaTime;
					}
					return;
				}
			}
		}
		if (this.PBLQBEFGHGF.DIIHJCJOKMP - 2f * UnityEngine.Time.deltaTime <= 0f)
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP = 0f;
		}
		else
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP -= 2f * UnityEngine.Time.deltaTime;
		}
	}

	// Token: 0x06005DA5 RID: 23973 RVA: 0x00024CAA File Offset: 0x00022EAA
	public void DMDJFOJGKPI()
	{
		this.DLFPJMJNHOC = true;
	}

	// Token: 0x06005DA6 RID: 23974 RVA: 0x00300360 File Offset: 0x002FE560
	public void EBDMECLKOJB(bool INOHMJPILHJ = false)
	{
		if (INOHMJPILHJ)
		{
			if (this.OLLOFNEJEFC.activeSelf || this.NHICPLEJJFQ)
			{
				this.MQJCMHBEOGH();
				this.FLNKCIQLMGL.SetActive(true);
				GameObject[] khhhoqmclek = this.KHHHOQMCLEK;
				for (int i = 1; i < khhhoqmclek.Length; i++)
				{
					GameObject gameObject = khhhoqmclek[i];
					gameObject.SetActive(false);
				}
				GameObject[] iqpqjlfngkj = this.IQPQJLFNGKJ;
				for (int j = 1; j < iqpqjlfngkj.Length; j++)
				{
					GameObject gameObject2 = iqpqjlfngkj[j];
					gameObject2.SetActive(false);
				}
				this.JMGMEQJKOKO.SetActive(true);
				for (int k = 1; k < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; k++)
				{
					this.EBJMKPBKDBQ.OGMPFDOBHEI[k].DIIHJCJOKMP = 1831f;
				}
				this.OLLOFNEJEFC.SetActive(true);
				MCNLIHMMLCF.OMPHLNDGKKM().FLCNGFCNKNB();
				RenderSettings.fog = true;
				this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(true);
				this.NHICPLEJJFQ = false;
			}
			return;
		}
		if (this.FOHOOGJMFEG)
		{
			return;
		}
		if (!this.NHICPLEJJFQ)
		{
			this.FLNKCIQLMGL.SetActive(false);
			foreach (GameObject gameObject3 in this.KHHHOQMCLEK)
			{
				gameObject3.SetActive(true);
			}
			GameObject[] iqpqjlfngkj2 = this.IQPQJLFNGKJ;
			for (int m = 0; m < iqpqjlfngkj2.Length; m += 0)
			{
				GameObject gameObject4 = iqpqjlfngkj2[m];
				gameObject4.SetActive(true);
			}
			this.IQPQJLFNGKJ[6].SetActive(true);
			this.JMGMEQJKOKO.SetActive(false);
			this.HNEQLQQOMKC.SetActive(false);
			this.PNLPEQEMMPI.SetActive(false);
			this.OLLOFNEJEFC.SetActive(true);
			for (int n = 1; n < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; n += 0)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[n].DIIHJCJOKMP = 504f;
			}
			RenderSettings.ambientLight = this.BEBKMLIQQEN[1];
			RenderSettings.fog = true;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(false);
			this.NHICPLEJJFQ = false;
			this.BQLIIQIIMDH();
			this.CFLKIFQGHFF();
			BDEJHNHLLOL component = this.FLCMDBKPJKC.GetComponent<BDEJHNHLLOL>();
			MKOENKCLJGF mkoenkcljgf = this.GDGMDCHIHHL(MCNLIHMMLCF.IECKOKEPENM().BEQINILCQCE.PIDLOFMIEFQ);
			component.FBGIPBJFKOO(false);
			component.ILBCCCBJNCL = null;
			if (mkoenkcljgf != null)
			{
				component.ILBCCCBJNCL = mkoenkcljgf.transform;
			}
		}
		else
		{
			this.FLNKCIQLMGL.SetActive(true);
			GameObject[] khhhoqmclek3 = this.KHHHOQMCLEK;
			for (int num = 1; num < khhhoqmclek3.Length; num++)
			{
				GameObject gameObject5 = khhhoqmclek3[num];
				gameObject5.SetActive(true);
			}
			GameObject[] iqpqjlfngkj3 = this.IQPQJLFNGKJ;
			for (int num2 = 1; num2 < iqpqjlfngkj3.Length; num2 += 0)
			{
				GameObject gameObject6 = iqpqjlfngkj3[num2];
				gameObject6.SetActive(false);
			}
			this.JMGMEQJKOKO.SetActive(true);
			for (int num3 = 1; num3 < this.EBJMKPBKDBQ.OGMPFDOBHEI.Length; num3++)
			{
				this.EBJMKPBKDBQ.OGMPFDOBHEI[num3].DIIHJCJOKMP = 1441f;
			}
			this.OLLOFNEJEFC.SetActive(false);
			this.IMOJNFONCQE();
			MCNLIHMMLCF.HGLDHNMOLPD().FLCNGFCNKNB();
			RenderSettings.fog = false;
			this.EBJMKPBKDBQ.PGHJQNJLJKG.SetActive(false);
			this.NHICPLEJJFQ = true;
		}
	}

	// Token: 0x06005DA7 RID: 23975 RVA: 0x002FE100 File Offset: 0x002FC300
	private FlyMove HFDEGMBJDJP()
	{
		return new FlyMove
		{
			PosX = this.HNEQLQQOMKC.transform.position.x,
			PosY = this.HNEQLQQOMKC.transform.position.y,
			PosZ = this.HNEQLQQOMKC.transform.position.z,
			RotW = this.HNEQLQQOMKC.transform.rotation.w,
			RotX = this.HNEQLQQOMKC.transform.rotation.x,
			RotY = this.HNEQLQQOMKC.transform.rotation.y,
			RotZ = this.HNEQLQQOMKC.transform.rotation.z
		};
	}

	// Token: 0x06005DA8 RID: 23976 RVA: 0x003006B0 File Offset: 0x002FE8B0
	private void BLEHFIJGOHG()
	{
		if (this.FOHOOGJMFEG)
		{
			if (UnityEngine.Time.time > this.MCHJMMJBGDB + 676f && this.MCHJMMJBGDB != 691f)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(this.EMNKLBMIIOJ(), false);
				this.MCHJMMJBGDB = UnityEngine.Time.time;
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				if (!this.DLFPJMJNHOC)
				{
					this.MCHJMMJBGDB = 1721f;
				}
			}
			if (UnityEngine.Time.time > this.FNNDCPDJQJB + 453f)
			{
				this.FNNDCPDJQJB = UnityEngine.Time.time;
				this.ExitFly();
			}
		}
		else
		{
			Ray ray = this.MIMDEMCOCKP.ScreenPointToRay(Input.mousePosition);
			foreach (RaycastHit raycastHit in Physics.RaycastAll(ray))
			{
				MKOENKCLJGF component = raycastHit.collider.GetComponent<MKOENKCLJGF>();
				if (component != null)
				{
					if (this.EBJMKPBKDBQ.HDGHKDEPNBP != null)
					{
						if (this.EBJMKPBKDBQ.HDGHKDEPNBP.Length > 1)
						{
							bool flag = false;
							int j = 0;
							while (j < this.EBJMKPBKDBQ.HDGHKDEPNBP.Length)
							{
								if (!(this.EBJMKPBKDBQ.HDGHKDEPNBP[j].ToLowerInvariant() == component.gameObject.name.ToLowerInvariant()))
								{
									j++;
								}
								else
								{
									this.PBLQBEFGHGF.PIDLOFMIEFQ = component.gameObject.name;
									flag = false;
									IL_1AA:
									if (!flag)
									{
										this.PBLQBEFGHGF.PIDLOFMIEFQ = "slp";
										goto IL_1E2;
									}
									goto IL_1E2;
								}
							}
							goto IL_1AA;
						}
						this.PBLQBEFGHGF.LKPOBCBOFIC("_Distance");
					}
					else
					{
						this.PBLQBEFGHGF.LKPOBCBOFIC("[00FF00]You received ");
					}
					IL_1E2:
					if (this.PBLQBEFGHGF.DIIHJCJOKMP + 1342f * UnityEngine.Time.deltaTime >= 14f)
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP = 260f;
					}
					else
					{
						this.PBLQBEFGHGF.DIIHJCJOKMP += 613f * UnityEngine.Time.deltaTime;
					}
					return;
				}
			}
		}
		if (this.PBLQBEFGHGF.DIIHJCJOKMP - 405f * UnityEngine.Time.deltaTime <= 1987f)
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP = 1887f;
		}
		else
		{
			this.PBLQBEFGHGF.DIIHJCJOKMP -= 711f * UnityEngine.Time.deltaTime;
		}
	}

	// Token: 0x04001418 RID: 5144
	public MCMHEQDOMOI FLCMDBKPJKC;

	// Token: 0x04001419 RID: 5145
	public static AssetBundle HGBFNDILJLQ;

	// Token: 0x0400141A RID: 5146
	public GameObject JEHJGCGDFQF;

	// Token: 0x0400141B RID: 5147
	public GameObject[] KHHHOQMCLEK;

	// Token: 0x0400141C RID: 5148
	public GameObject[] IQPQJLFNGKJ;

	// Token: 0x0400141D RID: 5149
	public GameObject JMGMEQJKOKO;

	// Token: 0x0400141E RID: 5150
	public Color[] BEBKMLIQQEN;

	// Token: 0x0400141F RID: 5151
	private bool NHICPLEJJFQ;

	// Token: 0x04001420 RID: 5152
	public GameObject FLNKCIQLMGL;

	// Token: 0x04001421 RID: 5153
	public GameObject OLLOFNEJEFC;

	// Token: 0x04001422 RID: 5154
	private Camera MIMDEMCOCKP;

	// Token: 0x04001423 RID: 5155
	public CHFPDQEKFEE CHFPDQEKFEE;

	// Token: 0x04001424 RID: 5156
	public GameObject DPBECMNOODK;

	// Token: 0x04001425 RID: 5157
	public JLMPBLMOICG OIELNCDCEMD;

	// Token: 0x04001426 RID: 5158
	public BKKHLBCLPJM NHMKFFFPKQK;

	// Token: 0x04001427 RID: 5159
	public KQHJOLQLQBJ JBDNILCCQOC;

	// Token: 0x04001428 RID: 5160
	public GameObject BKHGDHQKELP;

	// Token: 0x04001429 RID: 5161
	public GameObject HNEQLQQOMKC;

	// Token: 0x0400142A RID: 5162
	public GameObject PNLPEQEMMPI;

	// Token: 0x0400142B RID: 5163
	public bool FOHOOGJMFEG;

	// Token: 0x0400142C RID: 5164
	public string[] IBLPMGHHDEP;

	// Token: 0x0400142D RID: 5165
	private float MCHJMMJBGDB;

	// Token: 0x0400142E RID: 5166
	private bool DLFPJMJNHOC;

	// Token: 0x0400142F RID: 5167
	private float FNNDCPDJQJB;

	// Token: 0x04001430 RID: 5168
	public CNCJKLNHQBH EBJMKPBKDBQ;

	// Token: 0x04001431 RID: 5169
	public BKKHLBCLPJM PBLQBEFGHGF;

	// Token: 0x04001432 RID: 5170
	public bool GKJOCIOHPHO;

	// Token: 0x04001433 RID: 5171
	public List<MKOENKCLJGF> FFODMGNLIPH = new List<MKOENKCLJGF>();

	// Token: 0x04001434 RID: 5172
	public Transform[] CCJBDBPKPIH;

	// Token: 0x04001435 RID: 5173
	public GameObject BOCJKFHHLEJ;

	// Token: 0x04001436 RID: 5174
	public GameObject IBEGDOQQMIJ;

	// Token: 0x04001437 RID: 5175
	private bool MMQHHENFLQH;

	// Token: 0x04001438 RID: 5176
	public Transform EIJCNPJNOCH;

	// Token: 0x04001439 RID: 5177
	public GameObject GGLMIENFHLD;

	// Token: 0x0400143A RID: 5178
	public GameObject[] NQGKGNNCIBL;

	// Token: 0x0400143B RID: 5179
	public Transform EQMDGFDOCBF;

	// Token: 0x0400143C RID: 5180
	public GameObject[] IIOLQLDMHBO;

	// Token: 0x0400143D RID: 5181
	public Vector3 PIHJKIPBIJJ;

	// Token: 0x0200029B RID: 667
	public class EFPCQCINOFK
	{
		// Token: 0x0400143E RID: 5182
		public MKOENKCLJGF JCGGQOQJCLL;

		// Token: 0x0400143F RID: 5183
		public QuestType DPQFDCNLLPC;
	}
}
