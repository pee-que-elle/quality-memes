using System;
using System.Collections;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200026D RID: 621
public class QOHCEBMQKMB : MonoBehaviour
{
	// Token: 0x060054E0 RID: 21728 RVA: 0x002B84A8 File Offset: 0x002B66A8
	public void LOELCBDKJNO(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			this.FHHKNDPDDPQ = PDIBIIKFBDH.DBPKNCDGGEP;
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(PDIBIIKFBDH.DBCHHNGOKGD()).QCQPPPFPCQH().ToString());
			this.LMEDQMIDFBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.FHHKNDPDDPQ = 0;
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.PINEJNIDONB("Forest Badge");
			this.LMEDQMIDFBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x002B8558 File Offset: 0x002B6758
	public void CKIOPFCKLCJ()
	{
		LOKGPPLGOHB component = this.HLINLLBMHGM.transform.parent.gameObject.GetComponent<LOKGPPLGOHB>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
		this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1245f;
		this.HLINLLBMHGM.transform.parent.localPosition = new Vector3(58f, 1270f, 1594f);
		this.HLINLLBMHGM.PMGPMBIBOJB();
		this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
		this.HLINLLBMHGM.LKPOBCBOFIC(string.Empty);
		this.HLINLLBMHGM.DIIHJCJOKMP = 1278f;
		this.LJCIHKCBIDE.DIIHJCJOKMP = 1457f;
		this.QPPGQJFBPMH.SetActive(true);
		this.MCEOKJNPNKN.SetActive(true);
		this.CJMELFQFOCB.SetActive(true);
		this.HBECCLKEFKK.SetActive(false);
		this.CIPQDMPQDCD.SetActive(false);
		this.QOOEMQECGEJ.HCCMPDQPKQN();
		this.QOOEMQECGEJ.JHOMJPKNBLE();
		this.NNQMIKEKBOJ.SetActive(false);
		this.KBICCNPFFGQ.enabled = false;
		this.KBICCNPFFGQ.transform.localScale = new Vector3(1704f, 1710f, 521f);
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator HGIFPJNHBOB()
	{
		foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
		{
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		bool flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					QOHCEBMQKMB.KHJIEDCDGIH idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x00021602 File Offset: 0x0001F802
	public bool EKEKMCMJEOC()
	{
		return this.FCNBFEBQIGB.Count > 0 || this.LGPENKDMNOJ != null || this.GQLDIMEFNIO || this.FCPGHPDHCLP || this.QCEGHHPDQLF.Count > 0;
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x002B86C4 File Offset: 0x002B68C4
	public void DILFBDPIENJ(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == 187 && fekoiojqnkh.CCMOCLMEKJN() % 55 > 0)
			{
				str = "Disguise" + (fekoiojqnkh.QKNEIJQHGCB % 116).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("Enabled" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("16", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.DPJNHIPJMDP.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x002B87CC File Offset: 0x002B69CC
	public void KPQDPMJPMFD(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		if (this.QOOEMQECGEJ.NCGIPKNCKDL())
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBCHHNGOKGD()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("0", 798f);
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x002B886C File Offset: 0x002B6A6C
	public void ClickSelect(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		if (this.QOOEMQECGEJ.CPOJBKCQPHK)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.3f);
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x00002300 File Offset: 0x00000500
	private void NPNODHCEGKM()
	{
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x002B890C File Offset: 0x002B6B0C
	public IEnumerator QENNFONBNDI(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC = null)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		if (IDFOEJEGNOC != null)
		{
			this.LGPENKDMNOJ = IDFOEJEGNOC;
		}
		else
		{
			IDFOEJEGNOC = this.LGPENKDMNOJ;
		}
		KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj2;
		if (IDFOEJEGNOC != null && IDFOEJEGNOC.EOBCNIDDIPE.Count > 0)
		{
			if (!this.QCEGHHPDQLF.Contains(IDFOEJEGNOC.DBPKNCDGGEP))
			{
				this.QCEGHHPDQLF.Add(IDFOEJEGNOC.DBPKNCDGGEP);
			}
			this.QKKQHILJMMO = true;
			this.JGIFFIBHHDE = IDFOEJEGNOC.EOBCNIDDIPE[0];
			this.OGKDPMKJLFC();
			switch (IDFOEJEGNOC.EOBCNIDDIPE[0].BBKKHIDMQIQ)
			{
			case QOHCEBMQKMB.OMGJJGGOCOJ.Text:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 0;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj != null)
					{
						LOKGPPLGOHB lokgpplgohb = this.HLINLLBMHGM.transform.parent.gameObject.AddComponent<LOKGPPLGOHB>();
						lokgpplgohb.OIOMEPFJMGQ = this.CIPQDMPQDCD.transform;
						lokgpplgohb.DIEFPEQNKBF = this.HLINLLBMHGM;
						lokgpplgohb.KCOMMGMLLEE = this.PGHJQNJLJKG;
						lokgpplgohb.CODFIINNNPG = this.OJQMEBDJDHB;
						lokgpplgohb.ILBCCCBJNCL = nhgkgbgjefj.JDKLKGQNKKB.transform;
						lokgpplgohb.LCMMCNFNHMF = new Vector3(0.5f, 1f, 0f);
						this.CIPQDMPQDCD.SetActive(true);
					}
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Select:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 380;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon:
				this.QPPGQJFBPMH.SetActive(true);
				this.DGCENEPBNFF(default(Guid));
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem:
				this.QPPGQJFBPMH.SetActive(true);
				this.ECJPBBFIQEC(null);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC:
				this.QPPGQJFBPMH.SetActive(false);
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
					{
						Response = string.Empty,
						ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
					}, false);
					this.JGIFFIBHHDE = null;
					this.LGPENKDMNOJ = null;
					this.QPPGQJFBPMH.SetActive(false);
					this.GQLDIMEFNIO = false;
					yield break;
				}
				nhgkgbgjefj2 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj2 != null)
				{
					nhgkgbgjefj2.DNECDEOQKLP.EHCDCCNJBDC = false;
					nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = false;
					bool flag = true;
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM != null && IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Contains("$"))
					{
						flag = false;
					}
					if (flag)
					{
						for (int i = 0; i < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; i++)
						{
							nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[i].ToString());
						}
						nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
						yield return base.StartCoroutine(nhgkgbgjefj2.DNECDEOQKLP.BGQBCLGHHMG());
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Replace("$", string.Empty);
					for (int j = 0; j < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; j++)
					{
						nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[j].ToString());
					}
					nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer:
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				this.QPPGQJFBPMH.SetActive(false);
				for (int k = 0; k < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; k++)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[k].ToString());
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
				yield return base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BGQBCLGHHMG());
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText:
			{
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj3 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj3 != null)
				{
					nhgkgbgjefj3.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				yield return new WaitForSeconds(1.5f);
				return 1;
			}
			case QOHCEBMQKMB.OMGJJGGOCOJ.Emote:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj4 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj4 != null)
					{
						nhgkgbgjefj4.DNECDEOQKLP.OPILOFIJJDF.ONOOKCBOPEF(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), 4f);
						yield return new WaitForSeconds(2f);
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Wait:
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
				{
					Response = string.Empty,
					ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
				}, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze:
				this.QCEGHHPDQLF.Remove(IDFOEJEGNOC.DBPKNCDGGEP);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				this.QKKQHILJMMO = false;
				if (this.QCEGHHPDQLF.Count == 0)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EPGFNQMLNBP();
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
					CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
					foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
					{
						enfmcdnleqq.DIIHJCJOKMP = 1f;
					}
				}
				this.DKQGFPEGMME = UnityEngine.Time.time;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj5 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj5 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj5.DNECDEOQKLP.EJHFEJCLMOB(true);
						}
						else
						{
							nhgkgbgjefj5.DNECDEOQKLP.EJHFEJCLMOB(false);
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj6 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj6 != null)
					{
						nhgkgbgjefj6.DNECDEOQKLP.QMBIHEHNIGC = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj6.DNECDEOQKLP.DKMBJOHMDNJ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Customization:
				this.QPPGQJFBPMH.SetActive(false);
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1] != "-1")
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(false);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(false);
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0].ToLowerInvariant() == "true")
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 0;
					}
					else
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 1;
					}
					this.KDPLKCLJOQI.QHEJPNJNMCI[0].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[3];
					this.KDPLKCLJOQI.QHEJPNJNMCI[1].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[4];
					this.KDPLKCLJOQI.QHEJPNJNMCI[2].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
					this.KDPLKCLJOQI.QHEJPNJNMCI[3].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[2];
					this.KDPLKCLJOQI.HMNJGEPNNFI();
				}
				else
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(true);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(true);
				}
				this.KDPLKCLJOQI.Open();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Shop:
				this.QPPGQJFBPMH.SetActive(false);
				JICJEENBPEO.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect:
				if (this.BKGHEHPPPMH.Count > 0 && Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM) == 12)
				{
					foreach (AnimateHealing animateHealing in this.BKGHEHPPPMH)
					{
						animateHealing.Heal(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count);
					}
				}
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect:
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC:
				JJGLMJNELOK.QOQONHOOLNE.Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange:
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, false);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.HideLink:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, true);
					}
					else
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, false);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait:
			{
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj7 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj7 != null)
				{
					nhgkgbgjefj7.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj8 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj8 != null)
					{
						nhgkgbgjefj8.DNECDEOQKLP.NQJHJNQFKKC();
						nhgkgbgjefj8.DNECDEOQKLP.ODGQNNEDJIF = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj8.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj8.DNECDEOQKLP.JDPCHGPENBD = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj8.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj8.DNECDEOQKLP.PJMKLHKFBJM(new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj8.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1]))), PSXAPI.Response.PlayerDirection.Default);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Slots:
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().FJEGMHHNGGO.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DBPKNCDGGEP = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]);
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Snake:
				CNCJKLNHQBH.QOQONHOOLNE.KLBKGJQONIL.GetComponent<EDKGFBQJPEP>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Tutor:
				this.QPPGQJFBPMH.SetActive(false);
				QLKJQPNKPBC.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Pacman:
				CNCJKLNHQBH.QOQONHOOLNE.JOHBOJLFCQF.GetComponent<GDNBFQGCHQQ>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj9 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj9 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj9.DNECDEOQKLP.FDINMJHGLQB = true;
							nhgkgbgjefj9.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
							nhgkgbgjefj9.DNECDEOQKLP.BHQOFDQCCCG = true;
						}
						else
						{
							nhgkgbgjefj9.DNECDEOQKLP.FDINMJHGLQB = false;
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj10 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj10 != null)
					{
						nhgkgbgjefj10.DNECDEOQKLP.MFJBPKBNBNO = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj10.DNECDEOQKLP.KKJPFIBDNJI.gameObject.SetActive(true);
						nhgkgbgjefj10.DNECDEOQKLP.MEDHFDLDNEI();
						nhgkgbgjefj10.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj11 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj11 != null)
					{
						nhgkgbgjefj11.DNECDEOQKLP.BEQHNFFEHMQ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj11.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetTag:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj12 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj12 != null)
					{
						nhgkgbgjefj12.DNECDEOQKLP.ICHKBBMBPGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
						nhgkgbgjefj12.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		}
		else
		{
			this.JGIFFIBHHDE = null;
			this.LGPENKDMNOJ = null;
			this.QPPGQJFBPMH.SetActive(false);
			this.GQLDIMEFNIO = false;
		}
		yield break;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = true;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x002B8930 File Offset: 0x002B6B30
	public void GHPBQLHFHCL()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = "Gale Wings",
			ScriptID = this.LGPENKDMNOJ.LBPHOPIJENP()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("Influence Trigger", 859f);
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x0002163B File Offset: 0x0001F83B
	private void NHMMEMBMNCD()
	{
		this.JJDHNMEHBLJ = true;
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x00021644 File Offset: 0x0001F844
	public static void MQKILFNHDCD(QOHCEBMQKMB BGBMIEJJQKC)
	{
		QOHCEBMQKMB.HBFFCJHOCPE = null;
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x0002164C File Offset: 0x0001F84C
	private void ENOBPJMDNEG()
	{
		QOHCEBMQKMB.HBFFCJHOCPE = this;
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x002B89C8 File Offset: 0x002B6BC8
	public void JDGPIDGCIMJ()
	{
		this.DKQGFPEGMME = UnityEngine.Time.time;
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.JGIFFIBHHDE.IDPPPPDHEDG() != QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.NNQMIKEKBOJ.SetActive(true);
		}
		else
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
		{
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -44;
			for (int i = 0; i < this.JGIFFIBHHDE.PGBLHMLDGOJ.Count; i++)
			{
				GameObject gameObject = this.FQQQEGDLPMB.BFCKNMFEBDM(this.EFIMEPJCFNP);
				gameObject.transform.localPosition = new Vector3(669f, (float)(96 - i * -68), 1715f);
				gameObject.GetComponent<BKKHLBCLPJM>().PIDLOFMIEFQ = (i + 0).ToString() + "F4" + this.JGIFFIBHHDE.PGBLHMLDGOJ[i];
				gameObject.GetComponent<FBJQLFQPGDE>().BGBMIEJJQKC = i;
				gameObject.GetComponent<FBJQLFQPGDE>().IEBJNKKJPEC = this;
				PLQFPBQEPJD component = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
				component.MGQIGGNBBBD(component.DFKQMMIQDOO + -105);
			}
			float num = (float)this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().JKGBHEHKBPC();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1282f, 813f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 843f, 1129f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.KDBPHMJLPLI(780f, 1407f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 390f, -num);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
			PLQFPBQEPJD component2 = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
			component2.MGQIGGNBBBD(component2.JKGBHEHKBPC() + 73);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1091f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
		}
		if (this.JGIFFIBHHDE.DOHOECOFMCI() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.MCEOKJNPNKN.SetActive(false);
			this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -167;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 987f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 291f, 910f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 1088f, 532f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.KDJODMLBQEB(1326f, 1822f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 263f, 319f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon)
		{
			this.CJMELFQFOCB.SetActive(false);
			this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -185;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1747f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1147f, 113f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 1997f, 304f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.MLEHNJBCBGD(405f, 1906f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 533f, 310f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.InputAlpha)
		{
			this.JNJFEGJBBJK(this.JGIFFIBHHDE.NGCLGFMBMHL);
			this.HBECCLKEFKK.SetActive(true);
			this.HBECCLKEFKK.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().MGQIGGNBBBD(-74);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1304f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 393f, 1937f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 822f, 1459f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(464f, 649f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 1682f, 731f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x002B8F8C File Offset: 0x002B718C
	public void QNJNOEFKJQC(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		PSXAPI.Request.Script script = new PSXAPI.Request.Script();
		PSXAPI.Request.Script script2 = script;
		string[] array = new string[-38];
		array[0] = GFFQFOFDBGE.ToString();
		array[1] = "Username is too short";
		array[6] = NIGMFFGPIJQ.ToString();
		array[8] = "/";
		array[6] = KCGLLHHNJCH.ToString();
		array[8] = "Egg";
		array[0] = KGFKFIDFDGC.ToString();
		array[8] = "]#";
		array[3] = IBOGIJNFDBM.ToString();
		script2.Response = string.Concat(array);
		script.ScriptID = this.LGPENKDMNOJ.DBCHHNGOKGD();
		qoqonhoolne.KNFHIKIONMF(script, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x00002300 File Offset: 0x00000500
	private void KDFOLQJDJQJ()
	{
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x002B9060 File Offset: 0x002B7260
	public void CancelItemClick()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = "-1",
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.4f);
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x060054FE RID: 21758 RVA: 0x00021685 File Offset: 0x0001F885
	// (set) Token: 0x060054F1 RID: 21745 RVA: 0x00021644 File Offset: 0x0001F844
	public static QOHCEBMQKMB QOQONHOOLNE
	{
		get
		{
			return QOHCEBMQKMB.HBFFCJHOCPE;
		}
		set
		{
			QOHCEBMQKMB.HBFFCJHOCPE = null;
		}
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x002B90F8 File Offset: 0x002B72F8
	public void QEDGFJKMNHC()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = " restored a little HP using its [ffff00]",
			ScriptID = this.LGPENKDMNOJ.CMOFLCMMJMP()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("vitalspirit", 1966f);
	}

	// Token: 0x060054F3 RID: 21747 RVA: 0x00021654 File Offset: 0x0001F854
	public void Hide()
	{
		this.QPPGQJFBPMH.SetActive(false);
	}

	// Token: 0x060054F4 RID: 21748 RVA: 0x002B9190 File Offset: 0x002B7390
	public void SelectMove(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.3f);
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x002B9220 File Offset: 0x002B7420
	public void OIKPMPFMJGL(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			this.FHHKNDPDDPQ = PDIBIIKFBDH.DBCHHNGOKGD();
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(PDIBIIKFBDH.HLMQODIHBIG()).QCQPPPFPCQH().ToString());
			this.LMEDQMIDFBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.FHHKNDPDDPQ = 0;
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(" is radiating a fairy aura!\r\n");
			this.LMEDQMIDFBB.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x002B92D0 File Offset: 0x002B74D0
	public void NGLPPLCCEDC()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = this.GONLHGLKJJF.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("[-]?", 1924f);
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator LLLDFJMOKQL(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x00021662 File Offset: 0x0001F862
	public void FinishScript()
	{
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x002B9398 File Offset: 0x002B7598
	public void FEEIIMPDBJI(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		if (this.QOOEMQECGEJ.NCGIPKNCKDL())
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.CEQBILCPIGQ()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("[00FF00]+", 228f);
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x002B890C File Offset: 0x002B6B0C
	public IEnumerator PKNCQBFJLLK(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC = null)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		if (IDFOEJEGNOC != null)
		{
			this.LGPENKDMNOJ = IDFOEJEGNOC;
		}
		else
		{
			IDFOEJEGNOC = this.LGPENKDMNOJ;
		}
		if (IDFOEJEGNOC != null && IDFOEJEGNOC.EOBCNIDDIPE.Count > 0)
		{
			if (!this.QCEGHHPDQLF.Contains(IDFOEJEGNOC.DBPKNCDGGEP))
			{
				this.QCEGHHPDQLF.Add(IDFOEJEGNOC.DBPKNCDGGEP);
			}
			this.QKKQHILJMMO = true;
			this.JGIFFIBHHDE = IDFOEJEGNOC.EOBCNIDDIPE[0];
			this.OGKDPMKJLFC();
			switch (IDFOEJEGNOC.EOBCNIDDIPE[0].BBKKHIDMQIQ)
			{
			case QOHCEBMQKMB.OMGJJGGOCOJ.Text:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 0;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj8 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj8 != null)
					{
						LOKGPPLGOHB lokgpplgohb = this.HLINLLBMHGM.transform.parent.gameObject.AddComponent<LOKGPPLGOHB>();
						lokgpplgohb.OIOMEPFJMGQ = this.CIPQDMPQDCD.transform;
						lokgpplgohb.DIEFPEQNKBF = this.HLINLLBMHGM;
						lokgpplgohb.KCOMMGMLLEE = this.PGHJQNJLJKG;
						lokgpplgohb.CODFIINNNPG = this.OJQMEBDJDHB;
						lokgpplgohb.ILBCCCBJNCL = nhgkgbgjefj8.JDKLKGQNKKB.transform;
						lokgpplgohb.LCMMCNFNHMF = new Vector3(0.5f, 1f, 0f);
						this.CIPQDMPQDCD.SetActive(true);
					}
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Select:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 380;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon:
				this.QPPGQJFBPMH.SetActive(true);
				this.DGCENEPBNFF(default(Guid));
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem:
				this.QPPGQJFBPMH.SetActive(true);
				this.ECJPBBFIQEC(null);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC:
				this.QPPGQJFBPMH.SetActive(false);
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
					{
						Response = string.Empty,
						ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
					}, false);
					this.JGIFFIBHHDE = null;
					this.LGPENKDMNOJ = null;
					this.QPPGQJFBPMH.SetActive(false);
					this.GQLDIMEFNIO = false;
					yield break;
				}
				nhgkgbgjefj2 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj2 != null)
				{
					nhgkgbgjefj2.DNECDEOQKLP.EHCDCCNJBDC = false;
					nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = false;
					flag = true;
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM != null && IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Contains("$"))
					{
						flag = false;
					}
					if (flag)
					{
						for (int i = 0; i < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; i++)
						{
							nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[i].ToString());
						}
						nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
						yield return base.StartCoroutine(nhgkgbgjefj2.DNECDEOQKLP.BGQBCLGHHMG());
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Replace("$", string.Empty);
					for (int j = 0; j < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; j++)
					{
						nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[j].ToString());
					}
					nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer:
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				this.QPPGQJFBPMH.SetActive(false);
				for (int k = 0; k < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; k++)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[k].ToString());
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
				yield return base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BGQBCLGHHMG());
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				nhgkgbgjefj3 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj3 != null)
				{
					nhgkgbgjefj3.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Emote:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					nhgkgbgjefj4 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj4 != null)
					{
						nhgkgbgjefj4.DNECDEOQKLP.OPILOFIJJDF.ONOOKCBOPEF(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), 4f);
						yield return new WaitForSeconds(2f);
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Wait:
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
				{
					Response = string.Empty,
					ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
				}, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze:
				this.QCEGHHPDQLF.Remove(IDFOEJEGNOC.DBPKNCDGGEP);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				this.QKKQHILJMMO = false;
				if (this.QCEGHHPDQLF.Count == 0)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EPGFNQMLNBP();
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
					CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
					foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
					{
						enfmcdnleqq.DIIHJCJOKMP = 1f;
					}
				}
				this.DKQGFPEGMME = UnityEngine.Time.time;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj9 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj9 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(true);
						}
						else
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(false);
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj10 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj10 != null)
					{
						nhgkgbgjefj10.DNECDEOQKLP.QMBIHEHNIGC = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj10.DNECDEOQKLP.DKMBJOHMDNJ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Customization:
				this.QPPGQJFBPMH.SetActive(false);
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1] != "-1")
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(false);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(false);
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0].ToLowerInvariant() == "true")
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 0;
					}
					else
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 1;
					}
					this.KDPLKCLJOQI.QHEJPNJNMCI[0].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[3];
					this.KDPLKCLJOQI.QHEJPNJNMCI[1].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[4];
					this.KDPLKCLJOQI.QHEJPNJNMCI[2].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
					this.KDPLKCLJOQI.QHEJPNJNMCI[3].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[2];
					this.KDPLKCLJOQI.HMNJGEPNNFI();
				}
				else
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(true);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(true);
				}
				this.KDPLKCLJOQI.Open();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Shop:
				this.QPPGQJFBPMH.SetActive(false);
				JICJEENBPEO.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect:
				if (this.BKGHEHPPPMH.Count > 0 && Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM) == 12)
				{
					foreach (AnimateHealing animateHealing in this.BKGHEHPPPMH)
					{
						animateHealing.Heal(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count);
					}
				}
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect:
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC:
				JJGLMJNELOK.QOQONHOOLNE.Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange:
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, false);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.HideLink:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, true);
					}
					else
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, false);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				nhgkgbgjefj7 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj7 != null)
				{
					nhgkgbgjefj7.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj11 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj11 != null)
					{
						nhgkgbgjefj11.DNECDEOQKLP.NQJHJNQFKKC();
						nhgkgbgjefj11.DNECDEOQKLP.ODGQNNEDJIF = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.JDPCHGPENBD = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.PJMKLHKFBJM(new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1]))), PSXAPI.Response.PlayerDirection.Default);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Slots:
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().FJEGMHHNGGO.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DBPKNCDGGEP = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]);
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Snake:
				CNCJKLNHQBH.QOQONHOOLNE.KLBKGJQONIL.GetComponent<EDKGFBQJPEP>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Tutor:
				this.QPPGQJFBPMH.SetActive(false);
				QLKJQPNKPBC.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Pacman:
				CNCJKLNHQBH.QOQONHOOLNE.JOHBOJLFCQF.GetComponent<GDNBFQGCHQQ>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj12 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj12 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = true;
							nhgkgbgjefj12.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
							nhgkgbgjefj12.DNECDEOQKLP.BHQOFDQCCCG = true;
						}
						else
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = false;
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj13 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj13 != null)
					{
						nhgkgbgjefj13.DNECDEOQKLP.MFJBPKBNBNO = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj13.DNECDEOQKLP.KKJPFIBDNJI.gameObject.SetActive(true);
						nhgkgbgjefj13.DNECDEOQKLP.MEDHFDLDNEI();
						nhgkgbgjefj13.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj14 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj14 != null)
					{
						nhgkgbgjefj14.DNECDEOQKLP.BEQHNFFEHMQ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj14.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetTag:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj15 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj15 != null)
					{
						nhgkgbgjefj15.DNECDEOQKLP.ICHKBBMBPGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
						nhgkgbgjefj15.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		}
		else
		{
			this.JGIFFIBHHDE = null;
			this.LGPENKDMNOJ = null;
			this.QPPGQJFBPMH.SetActive(false);
			this.GQLDIMEFNIO = false;
		}
		yield break;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = true;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator JGGGIIMONDF(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x060054FD RID: 21757 RVA: 0x002B9438 File Offset: 0x002B7638
	public void SelectItemClick()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = this.FHHKNDPDDPQ.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.4f);
	}

	// Token: 0x060054FF RID: 21759 RVA: 0x0002168C File Offset: 0x0001F88C
	public bool PDOKGMLDIGL()
	{
		return this.FCNBFEBQIGB.Count <= 0 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 1 && false;
	}

	// Token: 0x06005500 RID: 21760 RVA: 0x00021685 File Offset: 0x0001F885
	public static QOHCEBMQKMB CNIMIQKQJJJ()
	{
		return QOHCEBMQKMB.HBFFCJHOCPE;
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x002B94DC File Offset: 0x002B76DC
	public void OGKDPMKJLFC()
	{
		LOKGPPLGOHB component = this.HLINLLBMHGM.transform.parent.gameObject.GetComponent<LOKGPPLGOHB>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
		this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		this.HLINLLBMHGM.transform.parent.localPosition = new Vector3(0f, 200f, 0f);
		this.HLINLLBMHGM.PMGPMBIBOJB();
		this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
		this.HLINLLBMHGM.PIDLOFMIEFQ = string.Empty;
		this.HLINLLBMHGM.DIIHJCJOKMP = 0f;
		this.LJCIHKCBIDE.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.SetActive(false);
		this.MCEOKJNPNKN.SetActive(false);
		this.CJMELFQFOCB.SetActive(false);
		this.HBECCLKEFKK.SetActive(false);
		this.CIPQDMPQDCD.SetActive(false);
		this.QOOEMQECGEJ.JQLDDBDJOBO();
		this.QOOEMQECGEJ.KJQIBJOKNLK();
		this.NNQMIKEKBOJ.SetActive(false);
		this.KBICCNPFFGQ.enabled = false;
		this.KBICCNPFFGQ.transform.localScale = new Vector3(1f, 0f, 1f);
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x002B962C File Offset: 0x002B782C
	public void HMIQBPCCDGQ(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 42 && fekoiojqnkh.CCMOCLMEKJN() % 30 > 0)
			{
				str = "Reflects status moves, instead of getting hit by them." + (fekoiojqnkh.CCMOCLMEKJN() % 101).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD(" has chosen to shift." + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("flowerveil", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator EOHMQMDFGKL()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x0002164C File Offset: 0x0001F84C
	private void QHQEBPKMNLD()
	{
		QOHCEBMQKMB.HBFFCJHOCPE = this;
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x002B9734 File Offset: 0x002B7934
	public void MMPLLNGLIFK()
	{
		LOKGPPLGOHB component = this.HLINLLBMHGM.transform.parent.gameObject.GetComponent<LOKGPPLGOHB>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
		this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1110f;
		this.HLINLLBMHGM.transform.parent.localPosition = new Vector3(1913f, 821f, 854f);
		this.HLINLLBMHGM.PMGPMBIBOJB();
		this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
		this.HLINLLBMHGM.PIDLOFMIEFQ = string.Empty;
		this.HLINLLBMHGM.DIIHJCJOKMP = 248f;
		this.LJCIHKCBIDE.DIIHJCJOKMP = 1924f;
		this.QPPGQJFBPMH.SetActive(true);
		this.MCEOKJNPNKN.SetActive(false);
		this.CJMELFQFOCB.SetActive(false);
		this.HBECCLKEFKK.SetActive(true);
		this.CIPQDMPQDCD.SetActive(false);
		this.QOOEMQECGEJ.LPMOMPFIPKF();
		this.QOOEMQECGEJ.JHOMJPKNBLE();
		this.NNQMIKEKBOJ.SetActive(true);
		this.KBICCNPFFGQ.enabled = true;
		this.KBICCNPFFGQ.transform.localScale = new Vector3(996f, 1943f, 223f);
	}

	// Token: 0x06005506 RID: 21766 RVA: 0x002B9884 File Offset: 0x002B7A84
	public void BOHGPMELQQD(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		PSXAPI.Request.Script script = new PSXAPI.Request.Script();
		PSXAPI.Request.Script script2 = script;
		string[] array = new string[113];
		array[1] = GFFQFOFDBGE.ToString();
		array[0] = "flash";
		array[5] = NIGMFFGPIJQ.ToString();
		array[8] = " days";
		array[3] = KCGLLHHNJCH.ToString();
		array[1] = "Water";
		array[5] = KGFKFIDFDGC.ToString();
		array[6] = "Admin";
		array[2] = IBOGIJNFDBM.ToString();
		script2.Response = string.Concat(array);
		script.ScriptID = this.LGPENKDMNOJ.BEMEICKBCPI();
		qoqonhoolne.HLIOFPONLLE(script, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x000216C5 File Offset: 0x0001F8C5
	public void QGGBIBFNFGD()
	{
		this.QPPGQJFBPMH.SetActive(true);
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x002B9958 File Offset: 0x002B7B58
	private List<QOHCEBMQKMB.DBJHLHDBBQD> HCEOIOEKEBE(ref string QPGCBDPFIOF, Guid QKKBECNOKMB)
	{
		List<QOHCEBMQKMB.DBJHLHDBBQD> list = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		int num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("50% more chance to encounter a Steel-type Pokémon.\nTriggers: [2ecc71]Magnet Pull[-]");
			if (num != -1)
			{
				int num2 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("No camera found for layer ", num + 8);
				if (num2 != -1)
				{
					int num3 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 0, num2 - (num + 6)));
					string text = QPGCBDPFIOF.Substring(0, num);
					text += QPGCBDPFIOF.Substring(num2 + 1);
					QPGCBDPFIOF = text;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Tutor;
					dbjhlhdbbqd.MJHOQQOHLBD(num3.ToString());
					dbjhlhdbbqd.QKKBECNOKMB = QKKBECNOKMB;
					list.Add(dbjhlhdbbqd);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Power: -");
			if (num != -1)
			{
				int num4 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("@", num + 4);
				if (num4 != -1)
				{
					string text2 = QPGCBDPFIOF.Substring(num + 8, num4 - (num + 3));
					char[] array = new char[0];
					array[0] = 'v';
					string[] array2 = text2.Split(array);
					string text3 = QPGCBDPFIOF.Substring(0, num);
					text3 += QPGCBDPFIOF.Substring(num4 + 1);
					QPGCBDPFIOF = text3;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd2.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)116;
					dbjhlhdbbqd2.OBPGMMLFFMC(array2[0]);
					dbjhlhdbbqd2.QKKBECNOKMB = new Guid(array2[1]);
					list.Add(dbjhlhdbbqd2);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Slots_0");
			if (num != -1)
			{
				int num5 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("M0", num + 0);
				if (num5 != -1)
				{
					string text4 = QPGCBDPFIOF.Substring(num + 84, num5 - (num + -119));
					char[] array3 = new char[0];
					array3[1] = '1';
					string[] array4 = text4.Split(array3);
					string text5 = QPGCBDPFIOF.Substring(1, num);
					text5 += QPGCBDPFIOF.Substring(num5 + 1);
					QPGCBDPFIOF = text5;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-98),
						COBOLMJMOGM = array4[1],
						QKKBECNOKMB = new Guid(array4[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("_");
			if (num != -1)
			{
				int num6 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" shared its guard with ", num + 3);
				if (num6 != -1)
				{
					string text6 = QPGCBDPFIOF.Substring(num + 124, num6 - (num + 61));
					char[] array5 = new char[0];
					array5[0] = (char)-73;
					string[] array6 = text6.Split(array5);
					string text7 = QPGCBDPFIOF.Substring(1, num);
					text7 += QPGCBDPFIOF.Substring(num6 + 1);
					QPGCBDPFIOF = text7;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd3 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd3.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-113);
					dbjhlhdbbqd3.PNIFMCHONOI(array6[1]);
					dbjhlhdbbqd3.QKKBECNOKMB = new Guid(array6[0]);
					list.Add(dbjhlhdbbqd3);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" severely");
			if (num != -1)
			{
				int num7 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("aftermath", num + 2);
				if (num7 != -1)
				{
					string text8 = QPGCBDPFIOF.Substring(num + 8, num7 - (num + 7));
					char[] array7 = new char[0];
					array7[0] = (char)-122;
					string[] array8 = text8.Split(array7);
					string text9 = QPGCBDPFIOF.Substring(1, num);
					text9 += QPGCBDPFIOF.Substring(num7 + 0);
					QPGCBDPFIOF = text9;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd4 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd4.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.HideLink;
					dbjhlhdbbqd4.OBPGMMLFFMC(array8[0]);
					dbjhlhdbbqd4.QKKBECNOKMB = new Guid(array8[0]);
					list.Add(dbjhlhdbbqd4);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[/pok]");
			if (num != -1)
			{
				int num8 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Trade Error", num + 7);
				if (num8 != -1)
				{
					string text10 = QPGCBDPFIOF.Substring(num + -33, num8 - (num + 67));
					char[] array9 = new char[0];
					array9[0] = '5';
					string[] array10 = text10.Split(array9);
					string text11 = QPGCBDPFIOF.Substring(0, num);
					text11 += QPGCBDPFIOF.Substring(num8 + 1);
					QPGCBDPFIOF = text11;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd5 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd5.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-21);
					dbjhlhdbbqd5.MJHOQQOHLBD(array10[0]);
					dbjhlhdbbqd5.HPMNLCJIBNF(new Guid(array10[0]));
					list.Add(dbjhlhdbbqd5);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("17");
			if (num != -1)
			{
				int num9 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("It's super effective", num + 6);
				if (num9 != -1)
				{
					string text12 = QPGCBDPFIOF.Substring(num + -8, num9 - (num + 105));
					char[] array11 = new char[0];
					array11[0] = (char)-66;
					string[] array12 = text12.Split(array11);
					string text13 = QPGCBDPFIOF.Substring(0, num);
					text13 += QPGCBDPFIOF.Substring(num9 + 0);
					QPGCBDPFIOF = text13;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd6 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd6.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-88);
					dbjhlhdbbqd6.HKPBOGHEHJN(array12[1]);
					dbjhlhdbbqd6.QCMCJBKLJPJ(new Guid(array12[1]));
					list.Add(dbjhlhdbbqd6);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("CombinersUpColorBuff");
			if (num != -1)
			{
				int num10 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("HidePanel", num + 3);
				if (num10 != -1)
				{
					string text14 = QPGCBDPFIOF.Substring(num + 3, num10 - (num + 1));
					char[] array13 = new char[0];
					array13[0] = (char)-120;
					string[] array14 = text14.Split(array13);
					string text15 = QPGCBDPFIOF.Substring(1, num);
					text15 += QPGCBDPFIOF.Substring(num10 + 1);
					QPGCBDPFIOF = text15;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd7 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd7.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)76;
					dbjhlhdbbqd7.LJCJCFLOFHB(new string[8]);
					dbjhlhdbbqd7.NPNKKNBJMNC[0] = array14[1];
					dbjhlhdbbqd7.OPDDCBCKEBO()[1] = array14[0];
					list.Add(dbjhlhdbbqd7);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("#");
			if (num != -1)
			{
				int num11 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("_TempRT", num + 3);
				if (num11 != -1)
				{
					string text16 = QPGCBDPFIOF.Substring(1, num);
					text16 += QPGCBDPFIOF.Substring(num11 + 0);
					QPGCBDPFIOF = text16;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)58
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("System");
			if (num != -1)
			{
				int num12 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[", num + 3);
				if (num12 != -1)
				{
					string text17 = QPGCBDPFIOF.Substring(1, num);
					text17 += QPGCBDPFIOF.Substring(num12 + 1);
					QPGCBDPFIOF = text17;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("pacman(");
			if (num != -1)
			{
				int num13 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("BuffIcon_HailstormEncounterDecreased", num + 2);
				if (num13 != -1)
				{
					string[] array15 = QPGCBDPFIOF.Substring(num + -124, num13 - (num + -60)).Split(new char[]
					{
						(char)-78
					});
					string text18 = QPGCBDPFIOF.Substring(0, num);
					text18 += QPGCBDPFIOF.Substring(num13 + 1);
					QPGCBDPFIOF = text18;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd8 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd8.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-103);
					dbjhlhdbbqd8.MJHOQQOHLBD(array15[0]);
					dbjhlhdbbqd8.HPMNLCJIBNF(new Guid(array15[0]));
					list.Add(dbjhlhdbbqd8);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("money=");
			if (num != -1)
			{
				int num14 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("But it failed! ", num + 8);
				if (num14 != -1)
				{
					string text19 = QPGCBDPFIOF.Substring(num + 48, num14 - (num + -119));
					char[] array16 = new char[1];
					array16[1] = 'y';
					string[] array17 = text19.Split(array16);
					string text20 = QPGCBDPFIOF.Substring(1, num);
					text20 += QPGCBDPFIOF.Substring(num14 + 1);
					QPGCBDPFIOF = text20;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd9 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd9.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-58);
					dbjhlhdbbqd9.MJHOQQOHLBD(string.Empty);
					dbjhlhdbbqd9.MJHOQQOHLBD(string.Empty);
					dbjhlhdbbqd9.DCBKPGPGBIQ(new string[1]);
					dbjhlhdbbqd9.CFCKIKGHCCL()[0] = array17[1];
					dbjhlhdbbqd9.EBMMBECOEQQ()[1] = array17[7];
					dbjhlhdbbqd9.QCMCJBKLJPJ(new Guid(array17[0]));
					list.Add(dbjhlhdbbqd9);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("berry_7");
			if (num != -1)
			{
				int num15 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("' tab?", num + 8);
				if (num15 != -1)
				{
					int num16 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 5, num15 - (num + 8)));
					string text21 = QPGCBDPFIOF.Substring(0, num);
					text21 += QPGCBDPFIOF.Substring(num15 + 0);
					QPGCBDPFIOF = text21;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd10 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd10.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)63;
					dbjhlhdbbqd10.COBOLMJMOGM = num16.ToString();
					dbjhlhdbbqd10.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd10);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[-]!\r\n");
			if (num != -1)
			{
				int num17 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[FF0000]", num + 7);
				if (num17 != -1)
				{
					string cobolmjmogm = QPGCBDPFIOF.Substring(num + 7, num17 - (num + 1));
					string text22 = QPGCBDPFIOF.Substring(1, num);
					text22 += QPGCBDPFIOF.Substring(num17 + 0);
					QPGCBDPFIOF = text22;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd11 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd11.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox;
					dbjhlhdbbqd11.COBOLMJMOGM = cobolmjmogm;
					dbjhlhdbbqd11.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd11);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("]");
			if (num != -1)
			{
				int num18 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[ATK]", num + 4);
				if (num18 != -1)
				{
					int num19 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 7, num18 - (num + 4)));
					string text23 = QPGCBDPFIOF.Substring(1, num);
					text23 += QPGCBDPFIOF.Substring(num18 + 1);
					QPGCBDPFIOF = text23;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd12 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd12.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-56);
					dbjhlhdbbqd12.PNIFMCHONOI(num19.ToString());
					dbjhlhdbbqd12.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd12);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Passwords do not match");
			if (num != -1)
			{
				int num20 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" became the center of attention!\r\n", num + 1);
				if (num20 != -1)
				{
					string text24 = QPGCBDPFIOF.Substring(1, num);
					text24 += QPGCBDPFIOF.Substring(num20 + 0);
					QPGCBDPFIOF = text24;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd13 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd13.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-56);
					dbjhlhdbbqd13.PNIFMCHONOI(string.Empty);
					dbjhlhdbbqd13.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd13);
				}
			}
		}
		QPGCBDPFIOF = KGQECFKLKOP.LGGPFIJQHOM(QPGCBDPFIOF);
		if (list.Count > 1)
		{
			return list;
		}
		return null;
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x002B890C File Offset: 0x002B6B0C
	public IEnumerator JIJIQIPGPLL(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC = null)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		if (IDFOEJEGNOC != null)
		{
			this.LGPENKDMNOJ = IDFOEJEGNOC;
		}
		else
		{
			IDFOEJEGNOC = this.LGPENKDMNOJ;
		}
		if (IDFOEJEGNOC != null && IDFOEJEGNOC.EOBCNIDDIPE.Count > 0)
		{
			if (!this.QCEGHHPDQLF.Contains(IDFOEJEGNOC.DBPKNCDGGEP))
			{
				this.QCEGHHPDQLF.Add(IDFOEJEGNOC.DBPKNCDGGEP);
			}
			this.QKKQHILJMMO = true;
			this.JGIFFIBHHDE = IDFOEJEGNOC.EOBCNIDDIPE[0];
			this.OGKDPMKJLFC();
			switch (IDFOEJEGNOC.EOBCNIDDIPE[0].BBKKHIDMQIQ)
			{
			case QOHCEBMQKMB.OMGJJGGOCOJ.Text:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 0;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj8 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj8 != null)
					{
						LOKGPPLGOHB lokgpplgohb = this.HLINLLBMHGM.transform.parent.gameObject.AddComponent<LOKGPPLGOHB>();
						lokgpplgohb.OIOMEPFJMGQ = this.CIPQDMPQDCD.transform;
						lokgpplgohb.DIEFPEQNKBF = this.HLINLLBMHGM;
						lokgpplgohb.KCOMMGMLLEE = this.PGHJQNJLJKG;
						lokgpplgohb.CODFIINNNPG = this.OJQMEBDJDHB;
						lokgpplgohb.ILBCCCBJNCL = nhgkgbgjefj8.JDKLKGQNKKB.transform;
						lokgpplgohb.LCMMCNFNHMF = new Vector3(0.5f, 1f, 0f);
						this.CIPQDMPQDCD.SetActive(true);
					}
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Select:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 380;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon:
				this.QPPGQJFBPMH.SetActive(true);
				this.DGCENEPBNFF(default(Guid));
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem:
				this.QPPGQJFBPMH.SetActive(true);
				this.ECJPBBFIQEC(null);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC:
				this.QPPGQJFBPMH.SetActive(false);
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
					{
						Response = string.Empty,
						ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
					}, false);
					this.JGIFFIBHHDE = null;
					this.LGPENKDMNOJ = null;
					this.QPPGQJFBPMH.SetActive(false);
					this.GQLDIMEFNIO = false;
					yield break;
				}
				nhgkgbgjefj2 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj2 != null)
				{
					nhgkgbgjefj2.DNECDEOQKLP.EHCDCCNJBDC = false;
					nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = false;
					flag = true;
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM != null && IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Contains("$"))
					{
						flag = false;
					}
					if (flag)
					{
						for (int i = 0; i < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; i++)
						{
							nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[i].ToString());
						}
						nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
						yield return base.StartCoroutine(nhgkgbgjefj2.DNECDEOQKLP.BGQBCLGHHMG());
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Replace("$", string.Empty);
					for (int j = 0; j < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; j++)
					{
						nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[j].ToString());
					}
					nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer:
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				this.QPPGQJFBPMH.SetActive(false);
				for (int k = 0; k < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; k++)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[k].ToString());
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
				yield return base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BGQBCLGHHMG());
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				nhgkgbgjefj3 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj3 != null)
				{
					nhgkgbgjefj3.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Emote:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					nhgkgbgjefj4 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj4 != null)
					{
						nhgkgbgjefj4.DNECDEOQKLP.OPILOFIJJDF.ONOOKCBOPEF(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), 4f);
						yield return new WaitForSeconds(2f);
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Wait:
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
				{
					Response = string.Empty,
					ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
				}, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze:
				this.QCEGHHPDQLF.Remove(IDFOEJEGNOC.DBPKNCDGGEP);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				this.QKKQHILJMMO = false;
				if (this.QCEGHHPDQLF.Count == 0)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EPGFNQMLNBP();
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
					CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
					foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
					{
						enfmcdnleqq.DIIHJCJOKMP = 1f;
					}
				}
				this.DKQGFPEGMME = UnityEngine.Time.time;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj9 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj9 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(true);
						}
						else
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(false);
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj10 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj10 != null)
					{
						nhgkgbgjefj10.DNECDEOQKLP.QMBIHEHNIGC = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj10.DNECDEOQKLP.DKMBJOHMDNJ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Customization:
				this.QPPGQJFBPMH.SetActive(false);
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1] != "-1")
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(false);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(false);
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0].ToLowerInvariant() == "true")
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 0;
					}
					else
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 1;
					}
					this.KDPLKCLJOQI.QHEJPNJNMCI[0].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[3];
					this.KDPLKCLJOQI.QHEJPNJNMCI[1].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[4];
					this.KDPLKCLJOQI.QHEJPNJNMCI[2].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
					this.KDPLKCLJOQI.QHEJPNJNMCI[3].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[2];
					this.KDPLKCLJOQI.HMNJGEPNNFI();
				}
				else
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(true);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(true);
				}
				this.KDPLKCLJOQI.Open();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Shop:
				this.QPPGQJFBPMH.SetActive(false);
				JICJEENBPEO.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect:
				if (this.BKGHEHPPPMH.Count > 0 && Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM) == 12)
				{
					foreach (AnimateHealing animateHealing in this.BKGHEHPPPMH)
					{
						animateHealing.Heal(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count);
					}
				}
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect:
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC:
				JJGLMJNELOK.QOQONHOOLNE.Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange:
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, false);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.HideLink:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, true);
					}
					else
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, false);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				nhgkgbgjefj7 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj7 != null)
				{
					nhgkgbgjefj7.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj11 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj11 != null)
					{
						nhgkgbgjefj11.DNECDEOQKLP.NQJHJNQFKKC();
						nhgkgbgjefj11.DNECDEOQKLP.ODGQNNEDJIF = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.JDPCHGPENBD = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.PJMKLHKFBJM(new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1]))), PSXAPI.Response.PlayerDirection.Default);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Slots:
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().FJEGMHHNGGO.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DBPKNCDGGEP = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]);
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Snake:
				CNCJKLNHQBH.QOQONHOOLNE.KLBKGJQONIL.GetComponent<EDKGFBQJPEP>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Tutor:
				this.QPPGQJFBPMH.SetActive(false);
				QLKJQPNKPBC.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Pacman:
				CNCJKLNHQBH.QOQONHOOLNE.JOHBOJLFCQF.GetComponent<GDNBFQGCHQQ>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj12 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj12 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = true;
							nhgkgbgjefj12.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
							nhgkgbgjefj12.DNECDEOQKLP.BHQOFDQCCCG = true;
						}
						else
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = false;
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj13 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj13 != null)
					{
						nhgkgbgjefj13.DNECDEOQKLP.MFJBPKBNBNO = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj13.DNECDEOQKLP.KKJPFIBDNJI.gameObject.SetActive(true);
						nhgkgbgjefj13.DNECDEOQKLP.MEDHFDLDNEI();
						nhgkgbgjefj13.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj14 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj14 != null)
					{
						nhgkgbgjefj14.DNECDEOQKLP.BEQHNFFEHMQ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj14.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetTag:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj15 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj15 != null)
					{
						nhgkgbgjefj15.DNECDEOQKLP.ICHKBBMBPGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
						nhgkgbgjefj15.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		}
		else
		{
			this.JGIFFIBHHDE = null;
			this.LGPENKDMNOJ = null;
			this.QPPGQJFBPMH.SetActive(false);
			this.GQLDIMEFNIO = false;
		}
		yield break;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = true;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x002BA47C File Offset: 0x002B867C
	public void OPIJIBIHFIO()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = this.FHHKNDPDDPQ.ToString(),
			ScriptID = this.LGPENKDMNOJ.BFMPLLJBPQM()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("_HighlightSuppression", 1711f);
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x002BA520 File Offset: 0x002B8720
	private void HGNQPEJQKGE(string CIQFCJGQEMH)
	{
		for (int i = 0; i < 8; i += 0)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, false);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(new Guid(CIQFCJGQEMH));
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[3];
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK;
			array[1] = "'s [ffff00]";
			array[4] = fekoiojqnkh.EEILBMOOJHJ[j].EIQJMIMCEGE().ToString();
			array[6] = "berry_6";
			array[6] = fekoiojqnkh.EEILBMOOJHJ[j].PPPDMFPGPDD().ToString();
			bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		}
	}

	// Token: 0x0600550C RID: 21772 RVA: 0x002BA630 File Offset: 0x002B8830
	public void ECJPBBFIQEC(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH)
	{
		if (PDIBIIKFBDH != null)
		{
			this.FHHKNDPDDPQ = PDIBIIKFBDH.DBPKNCDGGEP;
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(PDIBIIKFBDH.DBPKNCDGGEP).ItemImage.ToString());
			this.LMEDQMIDFBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.FHHKNDPDDPQ = 0;
			this.JEDFFGHOHPJ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL("blank");
			this.LMEDQMIDFBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.LMEDQMIDFBB.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x000216D3 File Offset: 0x0001F8D3
	public bool KFFFKLBMGKD()
	{
		return this.FCNBFEBQIGB.Count <= 0 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 1;
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x000216C5 File Offset: 0x0001F8C5
	public void JDPOLGKKHND()
	{
		this.QPPGQJFBPMH.SetActive(true);
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x002BA6E0 File Offset: 0x002B88E0
	public void EHLCLMBBMJL()
	{
		this.DKQGFPEGMME = UnityEngine.Time.time;
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.JGIFFIBHHDE.DDCEONMOFEM() != QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		else
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		if (this.JGIFFIBHHDE.DOHOECOFMCI() == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
		{
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 49;
			for (int i = 1; i < this.JGIFFIBHHDE.PGBLHMLDGOJ.Count; i++)
			{
				GameObject gameObject = this.FQQQEGDLPMB.BFCKNMFEBDM(this.EFIMEPJCFNP);
				gameObject.transform.localPosition = new Vector3(1505f, (float)(-92 - i * 94), 1249f);
				gameObject.GetComponent<BKKHLBCLPJM>().LKPOBCBOFIC((i + 1).ToString() + "symbiosis" + this.JGIFFIBHHDE.PGBLHMLDGOJ[i]);
				gameObject.GetComponent<FBJQLFQPGDE>().BGBMIEJJQKC = i;
				gameObject.GetComponent<FBJQLFQPGDE>().IEBJNKKJPEC = this;
				PLQFPBQEPJD component = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
				component.MGQIGGNBBBD(component.JKGBHEHKBPC() + -15);
			}
			float num = (float)this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().JKGBHEHKBPC();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 1785f, 1023f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 1916f, 97f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(374f, 699f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 1459f, -num);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO += -64;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 819f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
		}
		if (this.JGIFFIBHHDE.DOHOECOFMCI() == QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC)
		{
			this.MCEOKJNPNKN.SetActive(false);
			this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 28;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1589f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1253f, 204f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 319f, 1002f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.KODHLLDFKGO(364f, 1607f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 392f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.InputAlpha)
		{
			this.CJMELFQFOCB.SetActive(false);
			this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 15;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1096f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1094f, 1362f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 149f, 1603f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.MLEHNJBCBGD(759f, 508f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 614f, 291f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.DOHOECOFMCI() == QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer)
		{
			this.HGNQPEJQKGE(this.JGIFFIBHHDE.NGCLGFMBMHL);
			this.HBECCLKEFKK.SetActive(true);
			this.HBECCLKEFKK.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 17;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1961f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 735f, 1182f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 1958f, 1878f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(1046f, 537f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 1916f, 531f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x00021685 File Offset: 0x0001F885
	public static QOHCEBMQKMB JLLBKOOQKGO()
	{
		return QOHCEBMQKMB.HBFFCJHOCPE;
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x0002170C File Offset: 0x0001F90C
	public bool HKQNOMKNEFO()
	{
		return this.FCNBFEBQIGB.Count <= 1 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 0;
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator JHOLDCHBFMQ(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x06005513 RID: 21779 RVA: 0x00021745 File Offset: 0x0001F945
	public bool DLNELFIPOHB()
	{
		return this.FCNBFEBQIGB.Count <= 1 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 0 && false;
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x00021654 File Offset: 0x0001F854
	public void DBLFCKCBBLK()
	{
		this.QPPGQJFBPMH.SetActive(false);
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x002BACA4 File Offset: 0x002B8EA4
	public void SelectPokemon()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = this.GONLHGLKJJF.ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.4f);
	}

	// Token: 0x06005516 RID: 21782 RVA: 0x002BAD48 File Offset: 0x002B8F48
	public void PKMOFMIDBBO()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = "Camera Target Position",
			ScriptID = this.LGPENKDMNOJ.CPCEJHLHILG()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("_Female", 1285f);
	}

	// Token: 0x06005517 RID: 21783 RVA: 0x002BADE0 File Offset: 0x002B8FE0
	public void OFMFCHLGDFM(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 11 && fekoiojqnkh.QKNEIJQHGCB % 18 > 1)
			{
				str = "Gravity returned to normal!\r\n" + (fekoiojqnkh.QKNEIJQHGCB % 107).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("'s Pokémon" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x0002164C File Offset: 0x0001F84C
	private void Awake()
	{
		QOHCEBMQKMB.HBFFCJHOCPE = this;
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x002BAEE8 File Offset: 0x002B90E8
	private List<QOHCEBMQKMB.DBJHLHDBBQD> QIEGDHLCOJN(ref string QPGCBDPFIOF, Guid QKKBECNOKMB)
	{
		List<QOHCEBMQKMB.DBJHLHDBBQD> list = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		int num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("emote(");
			if (num != -1)
			{
				int num2 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num2 != -1)
				{
					int num3 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 6, num2 - (num + 6)));
					string text = QPGCBDPFIOF.Substring(0, num);
					text += QPGCBDPFIOF.Substring(num2 + 1);
					QPGCBDPFIOF = text;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Emote,
						COBOLMJMOGM = num3.ToString(),
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("setlos(");
			if (num != -1)
			{
				int num4 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num4 != -1)
				{
					string[] array = QPGCBDPFIOF.Substring(num + 7, num4 - (num + 7)).Split(new char[]
					{
						','
					});
					string text2 = QPGCBDPFIOF.Substring(0, num);
					text2 += QPGCBDPFIOF.Substring(num4 + 1);
					QPGCBDPFIOF = text2;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS,
						COBOLMJMOGM = array[1],
						QKKBECNOKMB = new Guid(array[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("setsprite(");
			if (num != -1)
			{
				int num5 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num5 != -1)
				{
					string[] array2 = QPGCBDPFIOF.Substring(num + 10, num5 - (num + 10)).Split(new char[]
					{
						','
					});
					string text3 = QPGCBDPFIOF.Substring(0, num);
					text3 += QPGCBDPFIOF.Substring(num5 + 1);
					QPGCBDPFIOF = text3;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite,
						COBOLMJMOGM = array2[1],
						QKKBECNOKMB = new Guid(array2[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("setpokemon(");
			if (num != -1)
			{
				int num6 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num6 != -1)
				{
					string[] array3 = QPGCBDPFIOF.Substring(num + 11, num6 - (num + 11)).Split(new char[]
					{
						','
					});
					string text4 = QPGCBDPFIOF.Substring(0, num);
					text4 += QPGCBDPFIOF.Substring(num6 + 1);
					QPGCBDPFIOF = text4;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon,
						COBOLMJMOGM = array3[1],
						QKKBECNOKMB = new Guid(array3[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("settag(");
			if (num != -1)
			{
				int num7 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num7 != -1)
				{
					string[] array4 = QPGCBDPFIOF.Substring(num + 7, num7 - (num + 7)).Split(new char[]
					{
						','
					});
					string text5 = QPGCBDPFIOF.Substring(0, num);
					text5 += QPGCBDPFIOF.Substring(num7 + 1);
					QPGCBDPFIOF = text5;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetTag,
						COBOLMJMOGM = array4[1],
						QKKBECNOKMB = new Guid(array4[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("enablenpc(");
			if (num != -1)
			{
				int num8 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num8 != -1)
				{
					string[] array5 = QPGCBDPFIOF.Substring(num + 10, num8 - (num + 10)).Split(new char[]
					{
						','
					});
					string text6 = QPGCBDPFIOF.Substring(0, num);
					text6 += QPGCBDPFIOF.Substring(num8 + 1);
					QPGCBDPFIOF = text6;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC,
						COBOLMJMOGM = array5[1],
						QKKBECNOKMB = new Guid(array5[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("setrandom(");
			if (num != -1)
			{
				int num9 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num9 != -1)
				{
					string[] array6 = QPGCBDPFIOF.Substring(num + 10, num9 - (num + 10)).Split(new char[]
					{
						','
					});
					string text7 = QPGCBDPFIOF.Substring(0, num);
					text7 += QPGCBDPFIOF.Substring(num9 + 1);
					QPGCBDPFIOF = text7;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook,
						COBOLMJMOGM = array6[1],
						QKKBECNOKMB = new Guid(array6[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("slots(");
			if (num != -1)
			{
				int num10 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num10 != -1)
				{
					string[] array7 = QPGCBDPFIOF.Substring(num + 6, num10 - (num + 6)).Split(new char[]
					{
						','
					});
					string text8 = QPGCBDPFIOF.Substring(0, num);
					text8 += QPGCBDPFIOF.Substring(num10 + 1);
					QPGCBDPFIOF = text8;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Slots;
					dbjhlhdbbqd.NPNKKNBJMNC = new string[2];
					dbjhlhdbbqd.NPNKKNBJMNC[0] = array7[0];
					dbjhlhdbbqd.NPNKKNBJMNC[1] = array7[1];
					list.Add(dbjhlhdbbqd);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("snake(");
			if (num != -1)
			{
				int num11 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num11 != -1)
				{
					string text9 = QPGCBDPFIOF.Substring(0, num);
					text9 += QPGCBDPFIOF.Substring(num11 + 1);
					QPGCBDPFIOF = text9;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Snake
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("pacman(");
			if (num != -1)
			{
				int num12 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num12 != -1)
				{
					string text10 = QPGCBDPFIOF.Substring(0, num);
					text10 += QPGCBDPFIOF.Substring(num12 + 1);
					QPGCBDPFIOF = text10;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Pacman
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("enablelink(");
			if (num != -1)
			{
				int num13 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num13 != -1)
				{
					string[] array8 = QPGCBDPFIOF.Substring(num + 11, num13 - (num + 11)).Split(new char[]
					{
						','
					});
					string text11 = QPGCBDPFIOF.Substring(0, num);
					text11 += QPGCBDPFIOF.Substring(num13 + 1);
					QPGCBDPFIOF = text11;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.HideLink,
						COBOLMJMOGM = array8[1],
						QKKBECNOKMB = new Guid(array8[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("setnpcpos(");
			if (num != -1)
			{
				int num14 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num14 != -1)
				{
					string[] array9 = QPGCBDPFIOF.Substring(num + 10, num14 - (num + 10)).Split(new char[]
					{
						','
					});
					string text12 = QPGCBDPFIOF.Substring(0, num);
					text12 += QPGCBDPFIOF.Substring(num14 + 1);
					QPGCBDPFIOF = text12;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd2.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos;
					dbjhlhdbbqd2.COBOLMJMOGM = string.Empty;
					dbjhlhdbbqd2.COBOLMJMOGM = string.Empty;
					dbjhlhdbbqd2.NPNKKNBJMNC = new string[2];
					dbjhlhdbbqd2.NPNKKNBJMNC[0] = array9[1];
					dbjhlhdbbqd2.NPNKKNBJMNC[1] = array9[2];
					dbjhlhdbbqd2.QKKBECNOKMB = new Guid(array9[0]);
					list.Add(dbjhlhdbbqd2);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("sound(");
			if (num != -1)
			{
				int num15 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num15 != -1)
				{
					int num16 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 6, num15 - (num + 6)));
					string text13 = QPGCBDPFIOF.Substring(0, num);
					text13 += QPGCBDPFIOF.Substring(num15 + 1);
					QPGCBDPFIOF = text13;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect,
						COBOLMJMOGM = num16.ToString(),
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("music(");
			if (num != -1)
			{
				int num17 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num17 != -1)
				{
					string cobolmjmogm = QPGCBDPFIOF.Substring(num + 6, num17 - (num + 6));
					string text14 = QPGCBDPFIOF.Substring(0, num);
					text14 += QPGCBDPFIOF.Substring(num17 + 1);
					QPGCBDPFIOF = text14;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange,
						COBOLMJMOGM = cobolmjmogm,
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("playcry(");
			if (num != -1)
			{
				int num18 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 6);
				if (num18 != -1)
				{
					int num19 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 8, num18 - (num + 8)));
					string text15 = QPGCBDPFIOF.Substring(0, num);
					text15 += QPGCBDPFIOF.Substring(num18 + 1);
					QPGCBDPFIOF = text15;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect,
						COBOLMJMOGM = num19.ToString(),
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("openpc(");
			if (num != -1)
			{
				int num20 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(")", num + 4);
				if (num20 != -1)
				{
					string text16 = QPGCBDPFIOF.Substring(0, num);
					text16 += QPGCBDPFIOF.Substring(num20 + 1);
					QPGCBDPFIOF = text16;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC,
						COBOLMJMOGM = string.Empty,
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		QPGCBDPFIOF = KGQECFKLKOP.LGGPFIJQHOM(QPGCBDPFIOF);
		if (list.Count > 0)
		{
			return list;
		}
		return null;
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x00021654 File Offset: 0x0001F854
	public void QFPIMMBQNMG()
	{
		this.QPPGQJFBPMH.SetActive(false);
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x002BBA0C File Offset: 0x002B9C0C
	public void BEDHPOCGQOM()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = this.FHHKNDPDDPQ.ToString(),
			ScriptID = this.LGPENKDMNOJ.NIFMKBOPFMQ()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("substitute", 1970f);
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x002BBAB0 File Offset: 0x002B9CB0
	public void ECNDOMDPFOF(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		if (this.QOOEMQECGEJ.NCGIPKNCKDL())
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.GMOFFIFDCGE()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("Base Stats\n[d9b38c]ATK:[-] ", 1463f);
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x002B890C File Offset: 0x002B6B0C
	public IEnumerator MLGCBBKDHEB(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC = null)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		if (IDFOEJEGNOC != null)
		{
			this.LGPENKDMNOJ = IDFOEJEGNOC;
		}
		else
		{
			IDFOEJEGNOC = this.LGPENKDMNOJ;
		}
		if (IDFOEJEGNOC != null && IDFOEJEGNOC.EOBCNIDDIPE.Count > 0)
		{
			if (!this.QCEGHHPDQLF.Contains(IDFOEJEGNOC.DBPKNCDGGEP))
			{
				this.QCEGHHPDQLF.Add(IDFOEJEGNOC.DBPKNCDGGEP);
			}
			this.QKKQHILJMMO = true;
			this.JGIFFIBHHDE = IDFOEJEGNOC.EOBCNIDDIPE[0];
			this.OGKDPMKJLFC();
			switch (IDFOEJEGNOC.EOBCNIDDIPE[0].BBKKHIDMQIQ)
			{
			case QOHCEBMQKMB.OMGJJGGOCOJ.Text:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 0;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj8 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj8 != null)
					{
						LOKGPPLGOHB lokgpplgohb = this.HLINLLBMHGM.transform.parent.gameObject.AddComponent<LOKGPPLGOHB>();
						lokgpplgohb.OIOMEPFJMGQ = this.CIPQDMPQDCD.transform;
						lokgpplgohb.DIEFPEQNKBF = this.HLINLLBMHGM;
						lokgpplgohb.KCOMMGMLLEE = this.PGHJQNJLJKG;
						lokgpplgohb.CODFIINNNPG = this.OJQMEBDJDHB;
						lokgpplgohb.ILBCCCBJNCL = nhgkgbgjefj8.JDKLKGQNKKB.transform;
						lokgpplgohb.LCMMCNFNHMF = new Vector3(0.5f, 1f, 0f);
						this.CIPQDMPQDCD.SetActive(true);
					}
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Select:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 380;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon:
				this.QPPGQJFBPMH.SetActive(true);
				this.DGCENEPBNFF(default(Guid));
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem:
				this.QPPGQJFBPMH.SetActive(true);
				this.ECJPBBFIQEC(null);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC:
				this.QPPGQJFBPMH.SetActive(false);
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
					{
						Response = string.Empty,
						ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
					}, false);
					this.JGIFFIBHHDE = null;
					this.LGPENKDMNOJ = null;
					this.QPPGQJFBPMH.SetActive(false);
					this.GQLDIMEFNIO = false;
					yield break;
				}
				nhgkgbgjefj2 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj2 != null)
				{
					nhgkgbgjefj2.DNECDEOQKLP.EHCDCCNJBDC = false;
					nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = false;
					flag = true;
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM != null && IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Contains("$"))
					{
						flag = false;
					}
					if (flag)
					{
						for (int i = 0; i < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; i++)
						{
							nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[i].ToString());
						}
						nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
						yield return base.StartCoroutine(nhgkgbgjefj2.DNECDEOQKLP.BGQBCLGHHMG());
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Replace("$", string.Empty);
					for (int j = 0; j < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; j++)
					{
						nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[j].ToString());
					}
					nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer:
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				this.QPPGQJFBPMH.SetActive(false);
				for (int k = 0; k < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; k++)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[k].ToString());
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
				yield return base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BGQBCLGHHMG());
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				nhgkgbgjefj3 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj3 != null)
				{
					nhgkgbgjefj3.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Emote:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					nhgkgbgjefj4 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj4 != null)
					{
						nhgkgbgjefj4.DNECDEOQKLP.OPILOFIJJDF.ONOOKCBOPEF(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), 4f);
						yield return new WaitForSeconds(2f);
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Wait:
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
				{
					Response = string.Empty,
					ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
				}, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze:
				this.QCEGHHPDQLF.Remove(IDFOEJEGNOC.DBPKNCDGGEP);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				this.QKKQHILJMMO = false;
				if (this.QCEGHHPDQLF.Count == 0)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EPGFNQMLNBP();
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
					CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
					foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
					{
						enfmcdnleqq.DIIHJCJOKMP = 1f;
					}
				}
				this.DKQGFPEGMME = UnityEngine.Time.time;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj9 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj9 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(true);
						}
						else
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(false);
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj10 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj10 != null)
					{
						nhgkgbgjefj10.DNECDEOQKLP.QMBIHEHNIGC = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj10.DNECDEOQKLP.DKMBJOHMDNJ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Customization:
				this.QPPGQJFBPMH.SetActive(false);
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1] != "-1")
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(false);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(false);
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0].ToLowerInvariant() == "true")
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 0;
					}
					else
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 1;
					}
					this.KDPLKCLJOQI.QHEJPNJNMCI[0].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[3];
					this.KDPLKCLJOQI.QHEJPNJNMCI[1].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[4];
					this.KDPLKCLJOQI.QHEJPNJNMCI[2].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
					this.KDPLKCLJOQI.QHEJPNJNMCI[3].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[2];
					this.KDPLKCLJOQI.HMNJGEPNNFI();
				}
				else
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(true);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(true);
				}
				this.KDPLKCLJOQI.Open();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Shop:
				this.QPPGQJFBPMH.SetActive(false);
				JICJEENBPEO.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect:
				if (this.BKGHEHPPPMH.Count > 0 && Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM) == 12)
				{
					foreach (AnimateHealing animateHealing in this.BKGHEHPPPMH)
					{
						animateHealing.Heal(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count);
					}
				}
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect:
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC:
				JJGLMJNELOK.QOQONHOOLNE.Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange:
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, false);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.HideLink:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, true);
					}
					else
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, false);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				nhgkgbgjefj7 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj7 != null)
				{
					nhgkgbgjefj7.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj11 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj11 != null)
					{
						nhgkgbgjefj11.DNECDEOQKLP.NQJHJNQFKKC();
						nhgkgbgjefj11.DNECDEOQKLP.ODGQNNEDJIF = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.JDPCHGPENBD = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.PJMKLHKFBJM(new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1]))), PSXAPI.Response.PlayerDirection.Default);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Slots:
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().FJEGMHHNGGO.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DBPKNCDGGEP = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]);
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Snake:
				CNCJKLNHQBH.QOQONHOOLNE.KLBKGJQONIL.GetComponent<EDKGFBQJPEP>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Tutor:
				this.QPPGQJFBPMH.SetActive(false);
				QLKJQPNKPBC.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Pacman:
				CNCJKLNHQBH.QOQONHOOLNE.JOHBOJLFCQF.GetComponent<GDNBFQGCHQQ>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj12 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj12 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = true;
							nhgkgbgjefj12.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
							nhgkgbgjefj12.DNECDEOQKLP.BHQOFDQCCCG = true;
						}
						else
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = false;
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj13 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj13 != null)
					{
						nhgkgbgjefj13.DNECDEOQKLP.MFJBPKBNBNO = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj13.DNECDEOQKLP.KKJPFIBDNJI.gameObject.SetActive(true);
						nhgkgbgjefj13.DNECDEOQKLP.MEDHFDLDNEI();
						nhgkgbgjefj13.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj14 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj14 != null)
					{
						nhgkgbgjefj14.DNECDEOQKLP.BEQHNFFEHMQ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj14.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetTag:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj15 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj15 != null)
					{
						nhgkgbgjefj15.DNECDEOQKLP.ICHKBBMBPGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
						nhgkgbgjefj15.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		}
		else
		{
			this.JGIFFIBHHDE = null;
			this.LGPENKDMNOJ = null;
			this.QPPGQJFBPMH.SetActive(false);
			this.GQLDIMEFNIO = false;
		}
		yield break;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = true;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x002BBB50 File Offset: 0x002B9D50
	public void HBKEFHOELOG(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		PSXAPI.Request.Script script = new PSXAPI.Request.Script();
		PSXAPI.Request.Script script2 = script;
		string[] array = new string[77];
		array[0] = GFFQFOFDBGE.ToString();
		array[1] = "Friend Request";
		array[2] = NIGMFFGPIJQ.ToString();
		array[1] = "-sidestart";
		array[3] = KCGLLHHNJCH.ToString();
		array[7] = " go!\r\n";
		array[1] = KGFKFIDFDGC.ToString();
		array[4] = "VolumetricFogAndMist/Blur";
		array[7] = IBOGIJNFDBM.ToString();
		script2.Response = string.Concat(array);
		script.ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP;
		qoqonhoolne.HLIOFPONLLE(script, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x002BBC24 File Offset: 0x002B9E24
	public void JCQLNQKOBPE(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		if (this.QOOEMQECGEJ.BNNFOFFJPIO())
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.NNKDGMIDHIG()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("spectatorleave", 459f);
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x002BBCC4 File Offset: 0x002B9EC4
	public void CancelPokemon()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = default(Guid).ToString(),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("FinishSelect", 0.4f);
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x002BBD70 File Offset: 0x002B9F70
	public void DHQFGQBGQOC(int DBPKNCDGGEP)
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = DBPKNCDGGEP.ToString(),
			ScriptID = this.LGPENKDMNOJ.GMOFFIFDCGE()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("'s ", 1289f);
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x00021644 File Offset: 0x0001F844
	public static void GPEHBGGGNOE(QOHCEBMQKMB BGBMIEJJQKC)
	{
		QOHCEBMQKMB.HBFFCJHOCPE = null;
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator QHDEPLQDIQN(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x002BBE00 File Offset: 0x002BA000
	private List<QOHCEBMQKMB.DBJHLHDBBQD> QPBQLMNCOQJ(ref string QPGCBDPFIOF, Guid QKKBECNOKMB)
	{
		List<QOHCEBMQKMB.DBJHLHDBBQD> list = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		int num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Dark-, Ghost-, and Bug-type moves scare the Pokémon and boost its Speed stat.");
			if (num != -1)
			{
				int num2 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("-school", num + 2);
				if (num2 != -1)
				{
					int num3 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 8, num2 - (num + 8)));
					string text = QPGCBDPFIOF.Substring(0, num);
					text += QPGCBDPFIOF.Substring(num2 + 0);
					QPGCBDPFIOF = text;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Snake;
					dbjhlhdbbqd.MJHOQQOHLBD(num3.ToString());
					dbjhlhdbbqd.QKKBECNOKMB = QKKBECNOKMB;
					list.Add(dbjhlhdbbqd);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("The Pokémon is charged with static electricity, so contact with it may cause paralysis.");
			if (num != -1)
			{
				int num4 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("flashfire", num + 6);
				if (num4 != -1)
				{
					string text2 = QPGCBDPFIOF.Substring(num + 6, num4 - (num + 2));
					char[] array = new char[0];
					array[1] = (char)-47;
					string[] array2 = text2.Split(array);
					string text3 = QPGCBDPFIOF.Substring(0, num);
					text3 += QPGCBDPFIOF.Substring(num4 + 1);
					QPGCBDPFIOF = text3;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd2.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)42;
					dbjhlhdbbqd2.OBPGMMLFFMC(array2[1]);
					dbjhlhdbbqd2.HPMNLCJIBNF(new Guid(array2[1]));
					list.Add(dbjhlhdbbqd2);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("berry_");
			if (num != -1)
			{
				int num5 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("l", num + 3);
				if (num5 != -1)
				{
					string[] array3 = QPGCBDPFIOF.Substring(num + -73, num5 - (num + 80)).Split(new char[]
					{
						'\u0017'
					});
					string text4 = QPGCBDPFIOF.Substring(0, num);
					text4 += QPGCBDPFIOF.Substring(num5 + 0);
					QPGCBDPFIOF = text4;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd3 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd3.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-88);
					dbjhlhdbbqd3.HKPBOGHEHJN(array3[0]);
					dbjhlhdbbqd3.QCMCJBKLJPJ(new Guid(array3[1]));
					list.Add(dbjhlhdbbqd3);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("It broke through ");
			if (num != -1)
			{
				int num6 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("berry_12", num + 7);
				if (num6 != -1)
				{
					string[] array4 = QPGCBDPFIOF.Substring(num + 64, num6 - (num + 123)).Split(new char[]
					{
						(char)-4
					});
					string text5 = QPGCBDPFIOF.Substring(1, num);
					text5 += QPGCBDPFIOF.Substring(num6 + 1);
					QPGCBDPFIOF = text5;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd4 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd4.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)51;
					dbjhlhdbbqd4.HKPBOGHEHJN(array4[1]);
					dbjhlhdbbqd4.HPMNLCJIBNF(new Guid(array4[1]));
					list.Add(dbjhlhdbbqd4);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("general");
			if (num != -1)
			{
				int num7 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("h:mm tt", num + 5);
				if (num7 != -1)
				{
					string text6 = QPGCBDPFIOF.Substring(num + 0, num7 - (num + 1));
					char[] array5 = new char[0];
					array5[1] = (char)-4;
					string[] array6 = text6.Split(array5);
					string text7 = QPGCBDPFIOF.Substring(0, num);
					text7 += QPGCBDPFIOF.Substring(num7 + 0);
					QPGCBDPFIOF = text7;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd5 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd5.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-28);
					dbjhlhdbbqd5.COBOLMJMOGM = array6[1];
					dbjhlhdbbqd5.QCMCJBKLJPJ(new Guid(array6[0]));
					list.Add(dbjhlhdbbqd5);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$");
			if (num != -1)
			{
				int num8 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Purchasing", num + 5);
				if (num8 != -1)
				{
					string text8 = QPGCBDPFIOF.Substring(num + 124, num8 - (num + -109));
					char[] array7 = new char[1];
					array7[1] = (char)-110;
					string[] array8 = text8.Split(array7);
					string text9 = QPGCBDPFIOF.Substring(1, num);
					text9 += QPGCBDPFIOF.Substring(num8 + 1);
					QPGCBDPFIOF = text9;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd6 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd6.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC;
					dbjhlhdbbqd6.HKPBOGHEHJN(array8[1]);
					dbjhlhdbbqd6.QKKBECNOKMB = new Guid(array8[0]);
					list.Add(dbjhlhdbbqd6);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Pickup");
			if (num != -1)
			{
				int num9 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("#,##0", num + 4);
				if (num9 != -1)
				{
					string text10 = QPGCBDPFIOF.Substring(num + 109, num9 - (num + -81));
					char[] array9 = new char[0];
					array9[0] = '%';
					string[] array10 = text10.Split(array9);
					string text11 = QPGCBDPFIOF.Substring(1, num);
					text11 += QPGCBDPFIOF.Substring(num9 + 0);
					QPGCBDPFIOF = text11;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd7 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd7.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-97);
					dbjhlhdbbqd7.MJHOQQOHLBD(array10[1]);
					dbjhlhdbbqd7.QKKBECNOKMB = new Guid(array10[0]);
					list.Add(dbjhlhdbbqd7);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Hidden/Post FX/Builtin Debug Views");
			if (num != -1)
			{
				int num10 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("The Pokémon can poison the target even if it's a Steel or Poison type.", num + 3);
				if (num10 != -1)
				{
					string[] array11 = QPGCBDPFIOF.Substring(num + 2, num10 - (num + 4)).Split(new char[]
					{
						(char)-62
					});
					string text12 = QPGCBDPFIOF.Substring(0, num);
					text12 += QPGCBDPFIOF.Substring(num10 + 1);
					QPGCBDPFIOF = text12;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd8 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd8.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)79;
					dbjhlhdbbqd8.OOLHEPMPCQC(new string[0]);
					dbjhlhdbbqd8.FDKDDBKDKJF()[1] = array11[0];
					dbjhlhdbbqd8.JKPPKFDMMQK()[1] = array11[1];
					list.Add(dbjhlhdbbqd8);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("]");
			if (num != -1)
			{
				int num11 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Camera Window", num + 8);
				if (num11 != -1)
				{
					string text13 = QPGCBDPFIOF.Substring(1, num);
					text13 += QPGCBDPFIOF.Substring(num11 + 1);
					QPGCBDPFIOF = text13;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Chat Box");
			if (num != -1)
			{
				int num12 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("S", num + 0);
				if (num12 != -1)
				{
					string text14 = QPGCBDPFIOF.Substring(0, num);
					text14 += QPGCBDPFIOF.Substring(num12 + 1);
					QPGCBDPFIOF = text14;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-20)
					});
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Fly");
			if (num != -1)
			{
				int num13 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Surf can be used outside of battle to travel over bodies of water.\n\n[2ecc71]Left Click to use this.[-]", num + 1);
				if (num13 != -1)
				{
					string[] array12 = QPGCBDPFIOF.Substring(num + -92, num13 - (num + -85)).Split(new char[]
					{
						(char)-77
					});
					string text15 = QPGCBDPFIOF.Substring(0, num);
					text15 += QPGCBDPFIOF.Substring(num13 + 1);
					QPGCBDPFIOF = text15;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd9 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd9.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove;
					dbjhlhdbbqd9.OBPGMMLFFMC(array12[0]);
					dbjhlhdbbqd9.QKKBECNOKMB = new Guid(array12[1]);
					list.Add(dbjhlhdbbqd9);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("runaway");
			if (num != -1)
			{
				int num14 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("luckychant", num + 6);
				if (num14 != -1)
				{
					string text16 = QPGCBDPFIOF.Substring(num + -124, num14 - (num + -112));
					char[] array13 = new char[1];
					array13[1] = '6';
					string[] array14 = text16.Split(array13);
					string text17 = QPGCBDPFIOF.Substring(0, num);
					text17 += QPGCBDPFIOF.Substring(num14 + 0);
					QPGCBDPFIOF = text17;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd10 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd10.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)126;
					dbjhlhdbbqd10.PNIFMCHONOI(string.Empty);
					dbjhlhdbbqd10.MJHOQQOHLBD(string.Empty);
					dbjhlhdbbqd10.LJCJCFLOFHB(new string[1]);
					dbjhlhdbbqd10.JKPPKFDMMQK()[1] = array14[1];
					dbjhlhdbbqd10.JQODJENNMLF()[0] = array14[7];
					dbjhlhdbbqd10.QKKBECNOKMB = new Guid(array14[1]);
					list.Add(dbjhlhdbbqd10);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("#,##0");
			if (num != -1)
			{
				int num15 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("~", num + 3);
				if (num15 != -1)
				{
					int num16 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 6, num15 - (num + 7)));
					string text18 = QPGCBDPFIOF.Substring(0, num);
					text18 += QPGCBDPFIOF.Substring(num15 + 0);
					QPGCBDPFIOF = text18;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-101),
						COBOLMJMOGM = num16.ToString(),
						QKKBECNOKMB = QKKBECNOKMB
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" tucked in its head!\r\n");
			if (num != -1)
			{
				int num17 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Assets/AssetBundles/MapAssets/Model Materials/Light_Gym_Inner_Light.mat", num + 3);
				if (num17 != -1)
				{
					string cobolmjmogm = QPGCBDPFIOF.Substring(num + 1, num17 - (num + 6));
					string text19 = QPGCBDPFIOF.Substring(1, num);
					text19 += QPGCBDPFIOF.Substring(num17 + 0);
					QPGCBDPFIOF = text19;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd11 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd11.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-31);
					dbjhlhdbbqd11.COBOLMJMOGM = cobolmjmogm;
					dbjhlhdbbqd11.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd11);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("switch");
			if (num != -1)
			{
				int num18 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("u", num + 5);
				if (num18 != -1)
				{
					int num19 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 6, num18 - (num + 1)));
					string text20 = QPGCBDPFIOF.Substring(1, num);
					text20 += QPGCBDPFIOF.Substring(num18 + 0);
					QPGCBDPFIOF = text20;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd12 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd12.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-127);
					dbjhlhdbbqd12.MJHOQQOHLBD(num19.ToString());
					dbjhlhdbbqd12.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd12);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Mana increases the number of spells that can be cast");
			if (num != -1)
			{
				int num20 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("(X)", num + 3);
				if (num20 != -1)
				{
					string text21 = QPGCBDPFIOF.Substring(1, num);
					text21 += QPGCBDPFIOF.Substring(num20 + 0);
					QPGCBDPFIOF = text21;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd13 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd13.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Slots;
					dbjhlhdbbqd13.PNIFMCHONOI(string.Empty);
					dbjhlhdbbqd13.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd13);
				}
			}
		}
		QPGCBDPFIOF = KGQECFKLKOP.LGGPFIJQHOM(QPGCBDPFIOF);
		if (list.Count > 1)
		{
			return list;
		}
		return null;
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x002BC924 File Offset: 0x002BAB24
	public void DDEFNFICJFO()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = default(Guid).ToString(),
			ScriptID = this.LGPENKDMNOJ.CMOFLCMMJMP()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("bind", 186f);
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x000217AE File Offset: 0x0001F9AE
	public bool HEFMIKCHCJF()
	{
		return this.FCNBFEBQIGB.Count > 0 || this.LGPENKDMNOJ != null || this.GQLDIMEFNIO || this.FCPGHPDHCLP || this.QCEGHHPDQLF.Count > 1;
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x000216D3 File Offset: 0x0001F8D3
	public bool OCFGFJMJIGP()
	{
		return this.FCNBFEBQIGB.Count <= 0 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 1;
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x002BC9D0 File Offset: 0x002BABD0
	public void IMFOGKLOBCD()
	{
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.QOOEMQECGEJ.CPOJBKCQPHK)
		{
			this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QOOEMQECGEJ.JJQMDHIQBBC();
			this.HLINLLBMHGM.DIIHJCJOKMP = 1858f;
		}
		else if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			base.StartCoroutine(this.MLGCBBKDHEB(null));
		}
		this.DKQGFPEGMME = UnityEngine.Time.time;
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator IFIDCDKEFNL(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x0600552B RID: 21803 RVA: 0x002BCA48 File Offset: 0x002BAC48
	public void DGCENEPBNFF(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 201 && fekoiojqnkh.QKNEIJQHGCB % 28 > 0)
			{
				str = "_" + (fekoiojqnkh.QKNEIJQHGCB % 28).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x0600552C RID: 21804 RVA: 0x002BCB50 File Offset: 0x002BAD50
	public void LFPNDNQGFQK(PSXAPI.Response.Script JMDLLJPEFKM)
	{
		QOHCEBMQKMB.KHJIEDCDGIH khjiedcdgih = new QOHCEBMQKMB.KHJIEDCDGIH();
		khjiedcdgih.DBPKNCDGGEP = JMDLLJPEFKM.ScriptID;
		khjiedcdgih.CGBHHGJMFDM = JMDLLJPEFKM.Type;
		khjiedcdgih.EOBCNIDDIPE = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		switch (JMDLLJPEFKM.Type)
		{
		case ScriptRequestType.None:
			if (JMDLLJPEFKM.Text != null)
			{
				for (int i = 0; i < JMDLLJPEFKM.Text.Length; i++)
				{
					string text = JMDLLJPEFKM.Text[i].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[i].NpcID);
					if (list != null)
					{
						for (int j = 0; j < list.Count; j++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[j]);
						}
					}
					JMDLLJPEFKM.Text[i].Text = text;
					if (JMDLLJPEFKM.Text[i].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[i].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[i].Text = JMDLLJPEFKM.Text[i].Text.Substring(1);
							dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[i].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[i].Text = JMDLLJPEFKM.Text[i].Text.Substring(1);
							dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd.COBOLMJMOGM = JMDLLJPEFKM.Text[i].Text;
						dbjhlhdbbqd.QKKBECNOKMB = JMDLLJPEFKM.Text[i].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd);
					}
				}
			}
			break;
		case ScriptRequestType.Choice:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int k = 0; k < JMDLLJPEFKM.Text.Length - 1; k++)
				{
					string text = JMDLLJPEFKM.Text[k].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[k].NpcID);
					if (list != null)
					{
						for (int l = 0; l < list.Count; l++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[l]);
						}
					}
					JMDLLJPEFKM.Text[k].Text = text;
					if (JMDLLJPEFKM.Text[k].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[k].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[k].Text = JMDLLJPEFKM.Text[k].Text.Substring(1);
							dbjhlhdbbqd2.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[k].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[k].Text = JMDLLJPEFKM.Text[k].Text.Substring(1);
							dbjhlhdbbqd2.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd2.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd2.COBOLMJMOGM = JMDLLJPEFKM.Text[k].Text;
						dbjhlhdbbqd2.QKKBECNOKMB = JMDLLJPEFKM.Text[k].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd2);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd3 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd3.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Select;
			if (JMDLLJPEFKM.Text != null)
			{
				string text = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
				List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].NpcID);
				if (list != null)
				{
					for (int m = 0; m < list.Count; m++)
					{
						khjiedcdgih.EOBCNIDDIPE.Add(list[m]);
					}
				}
				JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text = text;
				dbjhlhdbbqd3.COBOLMJMOGM = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
			}
			dbjhlhdbbqd3.PGBLHMLDGOJ = new List<string>();
			for (int n = 0; n < JMDLLJPEFKM.Data.Length; n++)
			{
				string text = JMDLLJPEFKM.Data[n];
				List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, Guid.Empty);
				JMDLLJPEFKM.Data[n] = text;
				dbjhlhdbbqd3.PGBLHMLDGOJ.Add(JMDLLJPEFKM.Data[n]);
			}
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd3);
			break;
		}
		case ScriptRequestType.SelectPokemon:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num = 0; num < JMDLLJPEFKM.Text.Length - 1; num++)
				{
					string text = JMDLLJPEFKM.Text[num].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num].NpcID);
					if (list != null)
					{
						for (int num2 = 0; num2 < list.Count; num2++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num2]);
						}
					}
					JMDLLJPEFKM.Text[num].Text = text;
					if (JMDLLJPEFKM.Text[num].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd4 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num].Text = JMDLLJPEFKM.Text[num].Text.Substring(1);
							dbjhlhdbbqd4.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num].Text = JMDLLJPEFKM.Text[num].Text.Substring(1);
							dbjhlhdbbqd4.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd4.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd4.COBOLMJMOGM = JMDLLJPEFKM.Text[num].Text;
						dbjhlhdbbqd4.QKKBECNOKMB = JMDLLJPEFKM.Text[num].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd4);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd5 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd5.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon;
			if (JMDLLJPEFKM.Text != null)
			{
				string text = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
				List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].NpcID);
				if (list != null)
				{
					for (int num3 = 0; num3 < list.Count; num3++)
					{
						khjiedcdgih.EOBCNIDDIPE.Add(list[num3]);
					}
				}
				JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text = text;
				dbjhlhdbbqd5.COBOLMJMOGM = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
			}
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd5);
			break;
		}
		case ScriptRequestType.SelectMove:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num4 = 0; num4 < JMDLLJPEFKM.Text.Length - 1; num4++)
				{
					string text = JMDLLJPEFKM.Text[num4].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num4].NpcID);
					if (list != null)
					{
						for (int num5 = 0; num5 < list.Count; num5++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num5]);
						}
					}
					JMDLLJPEFKM.Text[num4].Text = text;
					if (JMDLLJPEFKM.Text[num4].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd6 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num4].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num4].Text = JMDLLJPEFKM.Text[num4].Text.Substring(1);
							dbjhlhdbbqd6.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num4].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num4].Text = JMDLLJPEFKM.Text[num4].Text.Substring(1);
							dbjhlhdbbqd6.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd6.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd6.COBOLMJMOGM = JMDLLJPEFKM.Text[num4].Text;
						dbjhlhdbbqd6.QKKBECNOKMB = JMDLLJPEFKM.Text[num4].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd6);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd7 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd7.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove;
			if (JMDLLJPEFKM.Text != null)
			{
				string text = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
				List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].NpcID);
				if (list != null)
				{
					for (int num6 = 0; num6 < list.Count; num6++)
					{
						khjiedcdgih.EOBCNIDDIPE.Add(list[num6]);
					}
				}
				JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text = text;
				dbjhlhdbbqd7.COBOLMJMOGM = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
			}
			dbjhlhdbbqd7.NGCLGFMBMHL = JMDLLJPEFKM.Data[0];
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd7);
			break;
		}
		case ScriptRequestType.MessageBox:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num7 = 0; num7 < JMDLLJPEFKM.Text.Length; num7++)
				{
					string text = JMDLLJPEFKM.Text[num7].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num7].NpcID);
					if (list != null)
					{
						for (int num8 = 0; num8 < list.Count; num8++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num8]);
						}
					}
					JMDLLJPEFKM.Text[num7].Text = text;
					if (JMDLLJPEFKM.Text[num7].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd8 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num7].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num7].Text = JMDLLJPEFKM.Text[num7].Text.Substring(1);
							dbjhlhdbbqd8.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num7].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num7].Text = JMDLLJPEFKM.Text[num7].Text.Substring(1);
							dbjhlhdbbqd8.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd8.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd8.COBOLMJMOGM = JMDLLJPEFKM.Text[num7].Text;
						dbjhlhdbbqd8.QKKBECNOKMB = JMDLLJPEFKM.Text[num7].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd8);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd9 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd9.DHBBBGDFHCQ = JMDLLJPEFKM.Data[0];
			dbjhlhdbbqd9.COBOLMJMOGM = JMDLLJPEFKM.Data[1];
			dbjhlhdbbqd9.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd9);
			break;
		}
		case ScriptRequestType.MessageBoxYesNo:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num9 = 0; num9 < JMDLLJPEFKM.Text.Length; num9++)
				{
					string text = JMDLLJPEFKM.Text[num9].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num9].NpcID);
					if (list != null)
					{
						for (int num10 = 0; num10 < list.Count; num10++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num10]);
						}
					}
					JMDLLJPEFKM.Text[num9].Text = text;
					if (JMDLLJPEFKM.Text[num9].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd10 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num9].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num9].Text = JMDLLJPEFKM.Text[num9].Text.Substring(1);
							dbjhlhdbbqd10.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num9].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num9].Text = JMDLLJPEFKM.Text[num9].Text.Substring(1);
							dbjhlhdbbqd10.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd10.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd10.COBOLMJMOGM = JMDLLJPEFKM.Text[num9].Text;
						dbjhlhdbbqd10.QKKBECNOKMB = JMDLLJPEFKM.Text[num9].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd10);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd11 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd11.DHBBBGDFHCQ = JMDLLJPEFKM.Data[0];
			dbjhlhdbbqd11.COBOLMJMOGM = JMDLLJPEFKM.Data[1];
			dbjhlhdbbqd11.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd11);
			break;
		}
		case ScriptRequestType.WaitForInput:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num11 = 0; num11 < JMDLLJPEFKM.Text.Length; num11++)
				{
					string text = JMDLLJPEFKM.Text[num11].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num11].NpcID);
					if (list != null)
					{
						for (int num12 = 0; num12 < list.Count; num12++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num12]);
						}
					}
					JMDLLJPEFKM.Text[num11].Text = text;
					if (JMDLLJPEFKM.Text[num11].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd12 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num11].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num11].Text = JMDLLJPEFKM.Text[num11].Text.Substring(1);
							dbjhlhdbbqd12.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num11].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num11].Text = JMDLLJPEFKM.Text[num11].Text.Substring(1);
							dbjhlhdbbqd12.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd12.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd12.COBOLMJMOGM = JMDLLJPEFKM.Text[num11].Text;
						dbjhlhdbbqd12.QKKBECNOKMB = JMDLLJPEFKM.Text[num11].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd12);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd13 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd13.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Wait;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd13);
			break;
		}
		case ScriptRequestType.Unfreeze:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num13 = 0; num13 < JMDLLJPEFKM.Text.Length; num13++)
				{
					string text = JMDLLJPEFKM.Text[num13].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num13].NpcID);
					if (list != null)
					{
						for (int num14 = 0; num14 < list.Count; num14++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num14]);
						}
					}
					JMDLLJPEFKM.Text[num13].Text = text;
					if (JMDLLJPEFKM.Text[num13].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd14 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num13].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num13].Text = JMDLLJPEFKM.Text[num13].Text.Substring(1);
							dbjhlhdbbqd14.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num13].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num13].Text = JMDLLJPEFKM.Text[num13].Text.Substring(1);
							dbjhlhdbbqd14.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd14.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd14.COBOLMJMOGM = JMDLLJPEFKM.Text[num13].Text;
						dbjhlhdbbqd14.QKKBECNOKMB = JMDLLJPEFKM.Text[num13].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd14);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd15 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd15.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd15);
			break;
		}
		case ScriptRequestType.SelectItem:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num15 = 0; num15 < JMDLLJPEFKM.Text.Length - 1; num15++)
				{
					string text = JMDLLJPEFKM.Text[num15].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num15].NpcID);
					if (list != null)
					{
						for (int num16 = 0; num16 < list.Count; num16++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num16]);
						}
					}
					JMDLLJPEFKM.Text[num15].Text = text;
					if (JMDLLJPEFKM.Text[num15].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd16 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num15].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num15].Text = JMDLLJPEFKM.Text[num15].Text.Substring(1);
							dbjhlhdbbqd16.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num15].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num15].Text = JMDLLJPEFKM.Text[num15].Text.Substring(1);
							dbjhlhdbbqd16.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd16.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd16.COBOLMJMOGM = JMDLLJPEFKM.Text[num15].Text;
						dbjhlhdbbqd16.QKKBECNOKMB = JMDLLJPEFKM.Text[num15].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd16);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd17 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd17.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem;
			if (JMDLLJPEFKM.Text != null)
			{
				string text = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
				List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].NpcID);
				if (list != null)
				{
					for (int num17 = 0; num17 < list.Count; num17++)
					{
						khjiedcdgih.EOBCNIDDIPE.Add(list[num17]);
					}
				}
				JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text = text;
				dbjhlhdbbqd17.COBOLMJMOGM = JMDLLJPEFKM.Text[JMDLLJPEFKM.Text.Length - 1].Text;
			}
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd17);
			break;
		}
		case ScriptRequestType.WalkUser:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num18 = 0; num18 < JMDLLJPEFKM.Text.Length; num18++)
				{
					string text = JMDLLJPEFKM.Text[num18].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num18].NpcID);
					if (list != null)
					{
						for (int num19 = 0; num19 < list.Count; num19++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num19]);
						}
					}
					JMDLLJPEFKM.Text[num18].Text = text;
					if (JMDLLJPEFKM.Text[num18].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd18 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num18].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num18].Text = JMDLLJPEFKM.Text[num18].Text.Substring(1);
							dbjhlhdbbqd18.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num18].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num18].Text = JMDLLJPEFKM.Text[num18].Text.Substring(1);
							dbjhlhdbbqd18.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd18.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd18.COBOLMJMOGM = JMDLLJPEFKM.Text[num18].Text;
						dbjhlhdbbqd18.QKKBECNOKMB = JMDLLJPEFKM.Text[num18].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd18);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd19 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd19.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer;
			dbjhlhdbbqd19.COBOLMJMOGM = JMDLLJPEFKM.Data[0].ToLowerInvariant();
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd19);
			break;
		}
		case ScriptRequestType.WalkNpc:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num20 = 0; num20 < JMDLLJPEFKM.Text.Length; num20++)
				{
					string text = JMDLLJPEFKM.Text[num20].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num20].NpcID);
					if (list != null)
					{
						for (int num21 = 0; num21 < list.Count; num21++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num21]);
						}
					}
					JMDLLJPEFKM.Text[num20].Text = text;
					if (JMDLLJPEFKM.Text[num20].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd20 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num20].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num20].Text = JMDLLJPEFKM.Text[num20].Text.Substring(1);
							dbjhlhdbbqd20.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num20].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num20].Text = JMDLLJPEFKM.Text[num20].Text.Substring(1);
							dbjhlhdbbqd20.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd20.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd20.COBOLMJMOGM = JMDLLJPEFKM.Text[num20].Text;
						dbjhlhdbbqd20.QKKBECNOKMB = JMDLLJPEFKM.Text[num20].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd20);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd21 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd21.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC;
			dbjhlhdbbqd21.QKKBECNOKMB = new Guid(JMDLLJPEFKM.Data[0]);
			dbjhlhdbbqd21.COBOLMJMOGM = JMDLLJPEFKM.Data[1].ToLowerInvariant();
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd21);
			if (dbjhlhdbbqd21.COBOLMJMOGM != null && dbjhlhdbbqd21.COBOLMJMOGM.Contains("$"))
			{
				QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd22 = new QOHCEBMQKMB.DBJHLHDBBQD();
				dbjhlhdbbqd22.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze;
				khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd22);
			}
			break;
		}
		case ScriptRequestType.EnableNpc:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num22 = 0; num22 < JMDLLJPEFKM.Text.Length; num22++)
				{
					string text = JMDLLJPEFKM.Text[num22].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num22].NpcID);
					if (list != null)
					{
						for (int num23 = 0; num23 < list.Count; num23++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num23]);
						}
					}
					JMDLLJPEFKM.Text[num22].Text = text;
					if (JMDLLJPEFKM.Text[num22].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd23 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num22].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num22].Text = JMDLLJPEFKM.Text[num22].Text.Substring(1);
							dbjhlhdbbqd23.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num22].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num22].Text = JMDLLJPEFKM.Text[num22].Text.Substring(1);
							dbjhlhdbbqd23.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd23.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd23.COBOLMJMOGM = JMDLLJPEFKM.Text[num22].Text;
						dbjhlhdbbqd23.QKKBECNOKMB = JMDLLJPEFKM.Text[num22].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd23);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd24 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd24.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC;
			dbjhlhdbbqd24.COBOLMJMOGM = JMDLLJPEFKM.Data[1];
			dbjhlhdbbqd24.QKKBECNOKMB = new Guid(JMDLLJPEFKM.Data[0]);
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd24);
			break;
		}
		case ScriptRequestType.SetNpcLos:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num24 = 0; num24 < JMDLLJPEFKM.Text.Length; num24++)
				{
					string text = JMDLLJPEFKM.Text[num24].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num24].NpcID);
					if (list != null)
					{
						for (int num25 = 0; num25 < list.Count; num25++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num25]);
						}
					}
					JMDLLJPEFKM.Text[num24].Text = text;
					if (JMDLLJPEFKM.Text[num24].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd25 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num24].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num24].Text = JMDLLJPEFKM.Text[num24].Text.Substring(1);
							dbjhlhdbbqd25.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num24].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num24].Text = JMDLLJPEFKM.Text[num24].Text.Substring(1);
							dbjhlhdbbqd25.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd25.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd25.COBOLMJMOGM = JMDLLJPEFKM.Text[num24].Text;
						dbjhlhdbbqd25.QKKBECNOKMB = JMDLLJPEFKM.Text[num24].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd25);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd26 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd26.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS;
			dbjhlhdbbqd26.COBOLMJMOGM = JMDLLJPEFKM.Data[1];
			dbjhlhdbbqd26.QKKBECNOKMB = new Guid(JMDLLJPEFKM.Data[0]);
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd26);
			break;
		}
		case ScriptRequestType.Customize:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num26 = 0; num26 < JMDLLJPEFKM.Text.Length; num26++)
				{
					string text = JMDLLJPEFKM.Text[num26].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num26].NpcID);
					if (list != null)
					{
						for (int num27 = 0; num27 < list.Count; num27++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num27]);
						}
					}
					JMDLLJPEFKM.Text[num26].Text = text;
					if (JMDLLJPEFKM.Text[num26].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd27 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num26].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num26].Text = JMDLLJPEFKM.Text[num26].Text.Substring(1);
							dbjhlhdbbqd27.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num26].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num26].Text = JMDLLJPEFKM.Text[num26].Text.Substring(1);
							dbjhlhdbbqd27.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd27.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd27.COBOLMJMOGM = JMDLLJPEFKM.Text[num26].Text;
						dbjhlhdbbqd27.QKKBECNOKMB = JMDLLJPEFKM.Text[num26].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd27);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd28 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd28.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Customization;
			dbjhlhdbbqd28.NPNKKNBJMNC = JMDLLJPEFKM.Data;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd28);
			break;
		}
		case ScriptRequestType.Shop:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num28 = 0; num28 < JMDLLJPEFKM.Text.Length; num28++)
				{
					string text = JMDLLJPEFKM.Text[num28].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num28].NpcID);
					if (list != null)
					{
						for (int num29 = 0; num29 < list.Count; num29++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num29]);
						}
					}
					JMDLLJPEFKM.Text[num28].Text = text;
					if (JMDLLJPEFKM.Text[num28].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd29 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num28].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num28].Text = JMDLLJPEFKM.Text[num28].Text.Substring(1);
							dbjhlhdbbqd29.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num28].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num28].Text = JMDLLJPEFKM.Text[num28].Text.Substring(1);
							dbjhlhdbbqd29.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd29.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd29.COBOLMJMOGM = JMDLLJPEFKM.Text[num28].Text;
						dbjhlhdbbqd29.QKKBECNOKMB = JMDLLJPEFKM.Text[num28].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd29);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd30 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd30.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Shop;
			dbjhlhdbbqd30.NPNKKNBJMNC = JMDLLJPEFKM.Data;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd30);
			break;
		}
		case ScriptRequestType.PC:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num30 = 0; num30 < JMDLLJPEFKM.Text.Length; num30++)
				{
					string text = JMDLLJPEFKM.Text[num30].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num30].NpcID);
					if (list != null)
					{
						for (int num31 = 0; num31 < list.Count; num31++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num31]);
						}
					}
					JMDLLJPEFKM.Text[num30].Text = text;
					if (JMDLLJPEFKM.Text[num30].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd31 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num30].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num30].Text = JMDLLJPEFKM.Text[num30].Text.Substring(1);
							dbjhlhdbbqd31.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num30].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num30].Text = JMDLLJPEFKM.Text[num30].Text.Substring(1);
							dbjhlhdbbqd31.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd31.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd31.COBOLMJMOGM = JMDLLJPEFKM.Text[num30].Text;
						dbjhlhdbbqd31.QKKBECNOKMB = JMDLLJPEFKM.Text[num30].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd31);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd32 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd32.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.HideLink;
			dbjhlhdbbqd32.COBOLMJMOGM = JMDLLJPEFKM.Data[1];
			dbjhlhdbbqd32.QKKBECNOKMB = new Guid(JMDLLJPEFKM.Data[0]);
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd32);
			break;
		}
		case ScriptRequestType.Tutor:
		{
			if (JMDLLJPEFKM.Text != null)
			{
				for (int num32 = 0; num32 < JMDLLJPEFKM.Text.Length; num32++)
				{
					string text = JMDLLJPEFKM.Text[num32].Text;
					List<QOHCEBMQKMB.DBJHLHDBBQD> list = this.QIEGDHLCOJN(ref text, JMDLLJPEFKM.Text[num32].NpcID);
					if (list != null)
					{
						for (int num33 = 0; num33 < list.Count; num33++)
						{
							khjiedcdgih.EOBCNIDDIPE.Add(list[num33]);
						}
					}
					JMDLLJPEFKM.Text[num32].Text = text;
					if (JMDLLJPEFKM.Text[num32].Text.Length > 0)
					{
						QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd33 = new QOHCEBMQKMB.DBJHLHDBBQD();
						if (JMDLLJPEFKM.Text[num32].Text.Substring(0, 1) == "´")
						{
							JMDLLJPEFKM.Text[num32].Text = JMDLLJPEFKM.Text[num32].Text.Substring(1);
							dbjhlhdbbqd33.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText;
						}
						else if (JMDLLJPEFKM.Text[num32].Text.Substring(0, 1) == "~")
						{
							JMDLLJPEFKM.Text[num32].Text = JMDLLJPEFKM.Text[num32].Text.Substring(1);
							dbjhlhdbbqd33.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
						}
						else
						{
							dbjhlhdbbqd33.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Text;
						}
						dbjhlhdbbqd33.COBOLMJMOGM = JMDLLJPEFKM.Text[num32].Text;
						dbjhlhdbbqd33.QKKBECNOKMB = JMDLLJPEFKM.Text[num32].NpcID;
						khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd33);
					}
				}
			}
			QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd34 = new QOHCEBMQKMB.DBJHLHDBBQD();
			dbjhlhdbbqd34.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Tutor;
			dbjhlhdbbqd34.NPNKKNBJMNC = JMDLLJPEFKM.Data;
			khjiedcdgih.EOBCNIDDIPE.Add(dbjhlhdbbqd34);
			break;
		}
		}
		base.StartCoroutine(this.QFQHNLPOLIE(khjiedcdgih));
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x000217E7 File Offset: 0x0001F9E7
	public void KMPBMIHNOQM()
	{
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x002BEBFC File Offset: 0x002BCDFC
	public void MHIGGQFGILG()
	{
		LOKGPPLGOHB component = this.HLINLLBMHGM.transform.parent.gameObject.GetComponent<LOKGPPLGOHB>();
		if (component != null)
		{
			UnityEngine.Object.Destroy(component);
		}
		this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1192f;
		this.HLINLLBMHGM.transform.parent.localPosition = new Vector3(1023f, 208f, 1222f);
		this.HLINLLBMHGM.PMGPMBIBOJB();
		this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
		this.HLINLLBMHGM.PIDLOFMIEFQ = string.Empty;
		this.HLINLLBMHGM.DIIHJCJOKMP = 1942f;
		this.LJCIHKCBIDE.DIIHJCJOKMP = 877f;
		this.QPPGQJFBPMH.SetActive(false);
		this.MCEOKJNPNKN.SetActive(false);
		this.CJMELFQFOCB.SetActive(false);
		this.HBECCLKEFKK.SetActive(true);
		this.CIPQDMPQDCD.SetActive(false);
		this.QOOEMQECGEJ.GONEKKJHICE();
		this.QOOEMQECGEJ.QQQLNBGLFMQ();
		this.NNQMIKEKBOJ.SetActive(false);
		this.KBICCNPFFGQ.enabled = false;
		this.KBICCNPFFGQ.transform.localScale = new Vector3(1358f, 775f, 665f);
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x00021662 File Offset: 0x0001F862
	public void CCQPKOGODQB()
	{
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x002BED4C File Offset: 0x002BCF4C
	public void GBHIHGLBFLF()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = this.FHHKNDPDDPQ.ToString(),
			ScriptID = this.LGPENKDMNOJ.CEQBILCPIGQ()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke(" began having a nightmare!\r\n", 1184f);
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x002BEDF0 File Offset: 0x002BCFF0
	public void PFDOFEIMKOQ()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = true;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = this.FHHKNDPDDPQ.ToString(),
			ScriptID = this.LGPENKDMNOJ.HLDLDBPCNLQ()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("aegislashblade", 243f);
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x0002180A File Offset: 0x0001FA0A
	public bool KQIQNOMJCDB()
	{
		return this.FCNBFEBQIGB.Count <= 0 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 0;
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x002BEE94 File Offset: 0x002BD094
	public void BCHEBQKCIIF(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 164 && fekoiojqnkh.CCMOCLMEKJN() % 84 > 0)
			{
				str = "adjacentAllyOrSelf" + (fekoiojqnkh.QKNEIJQHGCB % 117).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("ability: " + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x002BEF9C File Offset: 0x002BD19C
	public void HJODIQPQPQC()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = this.GONLHGLKJJF.ToString(),
			ScriptID = this.LGPENKDMNOJ.NNKDGMIDHIG()
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = false;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("[00]", 243f);
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x002BF040 File Offset: 0x002BD240
	public void EPQBNOEDEEO(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		PSXAPI.Request.Script script = new PSXAPI.Request.Script();
		PSXAPI.Request.Script script2 = script;
		string[] array = new string[14];
		array[0] = GFFQFOFDBGE.ToString();
		array[1] = "/force right";
		array[1] = NIGMFFGPIJQ.ToString();
		array[7] = "tangledfeet";
		array[8] = KCGLLHHNJCH.ToString();
		array[1] = "!\r\n";
		array[2] = KGFKFIDFDGC.ToString();
		array[6] = "Item: ";
		array[5] = IBOGIJNFDBM.ToString();
		script2.Response = string.Concat(array);
		script.ScriptID = this.LGPENKDMNOJ.BFMPLLJBPQM();
		qoqonhoolne.HLIOFPONLLE(script, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x002BF114 File Offset: 0x002BD314
	public void FinishText()
	{
		this.DKQGFPEGMME = UnityEngine.Time.time;
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ != QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		else
		{
			this.NNQMIKEKBOJ.SetActive(true);
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
		{
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 17;
			for (int i = 0; i < this.JGIFFIBHHDE.PGBLHMLDGOJ.Count; i++)
			{
				GameObject gameObject = this.FQQQEGDLPMB.BFCKNMFEBDM(this.EFIMEPJCFNP);
				gameObject.transform.localPosition = new Vector3(-190f, (float)(-26 - i * 34), 0f);
				gameObject.GetComponent<BKKHLBCLPJM>().PIDLOFMIEFQ = (i + 1).ToString() + ". " + this.JGIFFIBHHDE.PGBLHMLDGOJ[i];
				gameObject.GetComponent<FBJQLFQPGDE>().BGBMIEJJQKC = i;
				gameObject.GetComponent<FBJQLFQPGDE>().IEBJNKKJPEC = this;
				this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO += 34;
			}
			float num = (float)this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, -10f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 416f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(0f, 0f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, -num);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO += -2;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon)
		{
			this.MCEOKJNPNKN.SetActive(true);
			this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 280;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 5f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 421f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(0f, 0f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, -280f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem)
		{
			this.CJMELFQFOCB.SetActive(true);
			this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 168;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 5f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 421f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(0f, 0f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, -168f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove)
		{
			this.GHNKIDFIHIM(this.JGIFFIBHHDE.NGCLGFMBMHL);
			this.HBECCLKEFKK.SetActive(true);
			this.HBECCLKEFKK.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 140;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 5f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, 421f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(0f, 0f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 0f, -140f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator BNLNNLCNIJO()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x00021685 File Offset: 0x0001F885
	public static QOHCEBMQKMB QQCNCIQQPIG()
	{
		return QOHCEBMQKMB.HBFFCJHOCPE;
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x002BF6D8 File Offset: 0x002BD8D8
	private List<QOHCEBMQKMB.DBJHLHDBBQD> GCFMMOEGBIB(ref string QPGCBDPFIOF, Guid QKKBECNOKMB)
	{
		List<QOHCEBMQKMB.DBJHLHDBBQD> list = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		int num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Purchasing");
			if (num != -1)
			{
				int num2 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("'s protection!\r\n", num + 5);
				if (num2 != -1)
				{
					int num3 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 0, num2 - (num + 0)));
					string text = QPGCBDPFIOF.Substring(1, num);
					text += QPGCBDPFIOF.Substring(num2 + 0);
					QPGCBDPFIOF = text;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-106);
					dbjhlhdbbqd.OBPGMMLFFMC(num3.ToString());
					dbjhlhdbbqd.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Egg");
			if (num != -1)
			{
				int num4 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Tangled Feet", num + 2);
				if (num4 != -1)
				{
					string text2 = QPGCBDPFIOF.Substring(num + 5, num4 - (num + 0));
					char[] array = new char[1];
					array[1] = '$';
					string[] array2 = text2.Split(array);
					string text3 = QPGCBDPFIOF.Substring(1, num);
					text3 += QPGCBDPFIOF.Substring(num4 + 1);
					QPGCBDPFIOF = text3;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd2.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)65;
					dbjhlhdbbqd2.OBPGMMLFFMC(array2[0]);
					dbjhlhdbbqd2.HPMNLCJIBNF(new Guid(array2[0]));
					list.Add(dbjhlhdbbqd2);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("snatch");
			if (num != -1)
			{
				int num5 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[FF9900]", num + 5);
				if (num5 != -1)
				{
					string text4 = QPGCBDPFIOF.Substring(num + 27, num5 - (num + 3));
					char[] array3 = new char[0];
					array3[1] = 'k';
					string[] array4 = text4.Split(array3);
					string text5 = QPGCBDPFIOF.Substring(1, num);
					text5 += QPGCBDPFIOF.Substring(num5 + 1);
					QPGCBDPFIOF = text5;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd3 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd3.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-98);
					dbjhlhdbbqd3.MJHOQQOHLBD(array4[0]);
					dbjhlhdbbqd3.QKKBECNOKMB = new Guid(array4[0]);
					list.Add(dbjhlhdbbqd3);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("o");
			if (num != -1)
			{
				int num6 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("The mysterious strong winds blow on regardless!\r\n", num + 7);
				if (num6 != -1)
				{
					string[] array5 = QPGCBDPFIOF.Substring(num + -61, num6 - (num + -80)).Split(new char[]
					{
						(char)-122
					});
					string text6 = QPGCBDPFIOF.Substring(1, num);
					text6 += QPGCBDPFIOF.Substring(num6 + 0);
					QPGCBDPFIOF = text6;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd4 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd4.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)67;
					dbjhlhdbbqd4.PNIFMCHONOI(array5[1]);
					dbjhlhdbbqd4.HPMNLCJIBNF(new Guid(array5[0]));
					list.Add(dbjhlhdbbqd4);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("afteryou");
			if (num != -1)
			{
				int num7 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[00FF00]", num + 4);
				if (num7 != -1)
				{
					string text7 = QPGCBDPFIOF.Substring(num + 4, num7 - (num + 3));
					char[] array6 = new char[0];
					array6[0] = (char)-81;
					string[] array7 = text7.Split(array6);
					string text8 = QPGCBDPFIOF.Substring(0, num);
					text8 += QPGCBDPFIOF.Substring(num7 + 0);
					QPGCBDPFIOF = text8;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd5 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd5.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC;
					dbjhlhdbbqd5.MJHOQQOHLBD(array7[1]);
					dbjhlhdbbqd5.HPMNLCJIBNF(new Guid(array7[1]));
					list.Add(dbjhlhdbbqd5);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("]");
			if (num != -1)
			{
				int num8 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Pokemons", num + 4);
				if (num8 != -1)
				{
					string text9 = QPGCBDPFIOF.Substring(num + 47, num8 - (num + 74));
					char[] array8 = new char[0];
					array8[0] = (char)-28;
					string[] array9 = text9.Split(array8);
					string text10 = QPGCBDPFIOF.Substring(1, num);
					text10 += QPGCBDPFIOF.Substring(num8 + 0);
					QPGCBDPFIOF = text10;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd6 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd6.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)106;
					dbjhlhdbbqd6.PNIFMCHONOI(array9[1]);
					dbjhlhdbbqd6.QKKBECNOKMB = new Guid(array9[1]);
					list.Add(dbjhlhdbbqd6);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[-]!\r\n");
			if (num != -1)
			{
				int num9 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(":", num + 7);
				if (num9 != -1)
				{
					string text11 = QPGCBDPFIOF.Substring(num + 98, num9 - (num + -81));
					char[] array10 = new char[0];
					array10[1] = '_';
					string[] array11 = text11.Split(array10);
					string text12 = QPGCBDPFIOF.Substring(0, num);
					text12 += QPGCBDPFIOF.Substring(num9 + 1);
					QPGCBDPFIOF = text12;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd7 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd7.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-128);
					dbjhlhdbbqd7.HKPBOGHEHJN(array11[1]);
					dbjhlhdbbqd7.HPMNLCJIBNF(new Guid(array11[1]));
					list.Add(dbjhlhdbbqd7);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("AFK");
			if (num != -1)
			{
				int num10 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("You were kicked from the Party.", num + 6);
				if (num10 != -1)
				{
					string text13 = QPGCBDPFIOF.Substring(num + 3, num10 - (num + 7));
					char[] array12 = new char[0];
					array12[1] = (char)-119;
					string[] array13 = text13.Split(array12);
					string text14 = QPGCBDPFIOF.Substring(1, num);
					text14 += QPGCBDPFIOF.Substring(num10 + 0);
					QPGCBDPFIOF = text14;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd8 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd8.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)85;
					dbjhlhdbbqd8.OOLHEPMPCQC(new string[8]);
					dbjhlhdbbqd8.OPDDCBCKEBO()[0] = array13[1];
					dbjhlhdbbqd8.NPNKKNBJMNC[0] = array13[1];
					list.Add(dbjhlhdbbqd8);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("_");
			if (num != -1)
			{
				int num11 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("DATA ERROR", num + 2);
				if (num11 != -1)
				{
					string text15 = QPGCBDPFIOF.Substring(1, num);
					text15 += QPGCBDPFIOF.Substring(num11 + 0);
					QPGCBDPFIOF = text15;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-43)
					});
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Assets/AssetBundles/MapAssets/Models/Mansion/Materials/com_chip_mado1.mat");
			if (num != -1)
			{
				int num12 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("InteractS", num + 3);
				if (num12 != -1)
				{
					string text16 = QPGCBDPFIOF.Substring(0, num);
					text16 += QPGCBDPFIOF.Substring(num12 + 0);
					QPGCBDPFIOF = text16;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)112
					});
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("OnDrag");
			if (num != -1)
			{
				int num13 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("par", num + 8);
				if (num13 != -1)
				{
					string text17 = QPGCBDPFIOF.Substring(num + 16, num13 - (num + -80));
					char[] array14 = new char[1];
					array14[1] = '7';
					string[] array15 = text17.Split(array14);
					string text18 = QPGCBDPFIOF.Substring(1, num);
					text18 += QPGCBDPFIOF.Substring(num13 + 0);
					QPGCBDPFIOF = text18;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd9 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd9.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-46);
					dbjhlhdbbqd9.PNIFMCHONOI(array15[1]);
					dbjhlhdbbqd9.QCMCJBKLJPJ(new Guid(array15[1]));
					list.Add(dbjhlhdbbqd9);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[-]!\r\n");
			if (num != -1)
			{
				int num14 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Leave Guild", num + 6);
				if (num14 != -1)
				{
					string[] array16 = QPGCBDPFIOF.Substring(num + 89, num14 - (num + -56)).Split(new char[]
					{
						(char)-105
					});
					string text19 = QPGCBDPFIOF.Substring(1, num);
					text19 += QPGCBDPFIOF.Substring(num14 + 0);
					QPGCBDPFIOF = text19;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd10 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd10.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)82;
					dbjhlhdbbqd10.COBOLMJMOGM = string.Empty;
					dbjhlhdbbqd10.COBOLMJMOGM = string.Empty;
					dbjhlhdbbqd10.LJCJCFLOFHB(new string[2]);
					dbjhlhdbbqd10.EBMMBECOEQQ()[1] = array16[1];
					dbjhlhdbbqd10.FDKDDBKDKJF()[0] = array16[6];
					dbjhlhdbbqd10.HPMNLCJIBNF(new Guid(array16[1]));
					list.Add(dbjhlhdbbqd10);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" will cost\n");
			if (num != -1)
			{
				int num15 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("BuffIcon_EncounterRateIncrease", num + 6);
				if (num15 != -1)
				{
					int num16 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 6, num15 - (num + 3)));
					string text20 = QPGCBDPFIOF.Substring(0, num);
					text20 += QPGCBDPFIOF.Substring(num15 + 1);
					QPGCBDPFIOF = text20;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd11 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd11.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-89);
					dbjhlhdbbqd11.HKPBOGHEHJN(num16.ToString());
					dbjhlhdbbqd11.QKKBECNOKMB = QKKBECNOKMB;
					list.Add(dbjhlhdbbqd11);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("c");
			if (num != -1)
			{
				int num17 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" day ago", num + 0);
				if (num17 != -1)
				{
					string bgbmiejjqkc = QPGCBDPFIOF.Substring(num + 4, num17 - (num + 1));
					string text21 = QPGCBDPFIOF.Substring(1, num);
					text21 += QPGCBDPFIOF.Substring(num17 + 1);
					QPGCBDPFIOF = text21;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd12 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd12.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-46);
					dbjhlhdbbqd12.HKPBOGHEHJN(bgbmiejjqkc);
					dbjhlhdbbqd12.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd12);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Fen Badge");
			if (num != -1)
			{
				int num18 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("-mega-x", num + 8);
				if (num18 != -1)
				{
					int num19 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 8, num18 - (num + 4)));
					string text22 = QPGCBDPFIOF.Substring(1, num);
					text22 += QPGCBDPFIOF.Substring(num18 + 1);
					QPGCBDPFIOF = text22;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd13 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd13.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Wait;
					dbjhlhdbbqd13.PNIFMCHONOI(num19.ToString());
					dbjhlhdbbqd13.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd13);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Take 001");
			if (num != -1)
			{
				int num20 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[FF8888]Admin", num + 6);
				if (num20 != -1)
				{
					string text23 = QPGCBDPFIOF.Substring(0, num);
					text23 += QPGCBDPFIOF.Substring(num20 + 0);
					QPGCBDPFIOF = text23;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd14 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd14.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC;
					dbjhlhdbbqd14.HKPBOGHEHJN(string.Empty);
					dbjhlhdbbqd14.QCMCJBKLJPJ(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd14);
				}
			}
		}
		QPGCBDPFIOF = KGQECFKLKOP.LGGPFIJQHOM(QPGCBDPFIOF);
		if (list.Count > 1)
		{
			return list;
		}
		return null;
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator CHLNNPGEBLE()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x002C01FC File Offset: 0x002BE3FC
	public void IGCIGOHDQDL(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
		PSXAPI.Request.Script script = new PSXAPI.Request.Script();
		PSXAPI.Request.Script script2 = script;
		string[] array = new string[58];
		array[1] = GFFQFOFDBGE.ToString();
		array[1] = ". Using default.";
		array[3] = NIGMFFGPIJQ.ToString();
		array[4] = "[33ccff]Lv. ";
		array[4] = KCGLLHHNJCH.ToString();
		array[0] = "Rain Dish";
		array[2] = KGFKFIDFDGC.ToString();
		array[2] = "learnset";
		array[5] = IBOGIJNFDBM.ToString();
		script2.Response = string.Concat(array);
		script.ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP;
		qoqonhoolne.HLIOFPONLLE(script, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x002C02D0 File Offset: 0x002BE4D0
	private void JNJFEGJBBJK(string CIQFCJGQEMH)
	{
		for (int i = 0; i < 7; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, false);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(new Guid(CIQFCJGQEMH));
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j += 0)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[5];
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].DHFJQINPMBH();
			array[0] = "-transform";
			array[6] = fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString();
			array[0] = "You can not create a guild with this name.";
			array[7] = fekoiojqnkh.EEILBMOOJHJ[j].PPPDMFPGPDD().ToString();
			bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		}
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x002C03E0 File Offset: 0x002BE5E0
	public void IJPEMBCGKPI(int GFFQFOFDBGE, int NIGMFFGPIJQ, int KGFKFIDFDGC, int IBOGIJNFDBM, int KCGLLHHNJCH)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Concat(new string[]
			{
				GFFQFOFDBGE.ToString(),
				",",
				NIGMFFGPIJQ.ToString(),
				",",
				KCGLLHHNJCH.ToString(),
				",",
				KGFKFIDFDGC.ToString(),
				",",
				IBOGIJNFDBM.ToString()
			}),
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x0002163B File Offset: 0x0001F83B
	private void PNMENBOBLBL()
	{
		this.JJDHNMEHBLJ = true;
	}

	// Token: 0x0600553F RID: 21823 RVA: 0x002C04B4 File Offset: 0x002BE6B4
	public void LOFEGGHHCHK()
	{
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.QOOEMQECGEJ.BBJEJNHJGLL())
		{
			this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QOOEMQECGEJ.OHLBQEIFQCL();
			this.HLINLLBMHGM.DIIHJCJOKMP = 1244f;
		}
		else if (this.JGIFFIBHHDE.IDPPPPDHEDG() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			base.StartCoroutine(this.JIJIQIPGPLL(null));
		}
		this.DKQGFPEGMME = UnityEngine.Time.time;
	}

	// Token: 0x06005540 RID: 21824 RVA: 0x002B890C File Offset: 0x002B6B0C
	public IEnumerator PFDMKFBFJPC(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC = null)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		if (IDFOEJEGNOC != null)
		{
			this.LGPENKDMNOJ = IDFOEJEGNOC;
		}
		else
		{
			IDFOEJEGNOC = this.LGPENKDMNOJ;
		}
		if (IDFOEJEGNOC != null && IDFOEJEGNOC.EOBCNIDDIPE.Count > 0)
		{
			if (!this.QCEGHHPDQLF.Contains(IDFOEJEGNOC.DBPKNCDGGEP))
			{
				this.QCEGHHPDQLF.Add(IDFOEJEGNOC.DBPKNCDGGEP);
			}
			this.QKKQHILJMMO = true;
			this.JGIFFIBHHDE = IDFOEJEGNOC.EOBCNIDDIPE[0];
			this.OGKDPMKJLFC();
			switch (IDFOEJEGNOC.EOBCNIDDIPE[0].BBKKHIDMQIQ)
			{
			case QOHCEBMQKMB.OMGJJGGOCOJ.Text:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 0;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj8 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj8 != null)
					{
						LOKGPPLGOHB lokgpplgohb = this.HLINLLBMHGM.transform.parent.gameObject.AddComponent<LOKGPPLGOHB>();
						lokgpplgohb.OIOMEPFJMGQ = this.CIPQDMPQDCD.transform;
						lokgpplgohb.DIEFPEQNKBF = this.HLINLLBMHGM;
						lokgpplgohb.KCOMMGMLLEE = this.PGHJQNJLJKG;
						lokgpplgohb.CODFIINNNPG = this.OJQMEBDJDHB;
						lokgpplgohb.ILBCCCBJNCL = nhgkgbgjefj8.JDKLKGQNKKB.transform;
						lokgpplgohb.LCMMCNFNHMF = new Vector3(0.5f, 1f, 0f);
						this.CIPQDMPQDCD.SetActive(true);
					}
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Select:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 380;
				this.HLINLLBMHGM.FQPCHEGNMMO = 380;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectPokemon:
				this.QPPGQJFBPMH.SetActive(true);
				this.DGCENEPBNFF(default(Guid));
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectItem:
				this.QPPGQJFBPMH.SetActive(true);
				this.ECJPBBFIQEC(null);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SelectMove:
				this.QPPGQJFBPMH.SetActive(true);
				this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().PlayForward();
				this.HLINLLBMHGM.DJBGEBNJKLK = 400;
				this.HLINLLBMHGM.FQPCHEGNMMO = 400;
				this.HLINLLBMHGM.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
				this.QOOEMQECGEJ.enabled = true;
				this.LJCIHKCBIDE.GetComponent<EPIJJNOIKEK>().PlayForward();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MoveNPC:
				this.QPPGQJFBPMH.SetActive(false);
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
					{
						Response = string.Empty,
						ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
					}, false);
					this.JGIFFIBHHDE = null;
					this.LGPENKDMNOJ = null;
					this.QPPGQJFBPMH.SetActive(false);
					this.GQLDIMEFNIO = false;
					yield break;
				}
				nhgkgbgjefj2 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj2 != null)
				{
					nhgkgbgjefj2.DNECDEOQKLP.EHCDCCNJBDC = false;
					nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = false;
					flag = true;
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM != null && IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Contains("$"))
					{
						flag = false;
					}
					if (flag)
					{
						for (int i = 0; i < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; i++)
						{
							nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[i].ToString());
						}
						nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
						yield return base.StartCoroutine(nhgkgbgjefj2.DNECDEOQKLP.BGQBCLGHHMG());
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Replace("$", string.Empty);
					for (int j = 0; j < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; j++)
					{
						nhgkgbgjefj2.DNECDEOQKLP.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[j].ToString());
					}
					nhgkgbgjefj2.DNECDEOQKLP.BHQOFDQCCCG = true;
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MovePlayer:
				CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
				this.QPPGQJFBPMH.SetActive(false);
				for (int k = 0; k < IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM.Length; k++)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.OPJIONMHFMQ(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM[k].ToString());
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BHQOFDQCCCG = true;
				yield return base.StartCoroutine(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.BGQBCLGHHMG());
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleText:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				nhgkgbgjefj3 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj3 != null)
				{
					nhgkgbgjefj3.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					yield return new WaitForSeconds(1.5f);
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Emote:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					nhgkgbgjefj4 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj4 != null)
					{
						nhgkgbgjefj4.DNECDEOQKLP.OPILOFIJJDF.ONOOKCBOPEF(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), 4f);
						yield return new WaitForSeconds(2f);
						return 1;
					}
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Wait:
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
				{
					Response = string.Empty,
					ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
				}, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBox:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MessageBoxYesNo:
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(IDFOEJEGNOC.EOBCNIDDIPE[0].DHBBBGDFHCQ, IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, "Script:" + this.LGPENKDMNOJ.DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Unfreeze:
				this.QCEGHHPDQLF.Remove(IDFOEJEGNOC.DBPKNCDGGEP);
				this.JGIFFIBHHDE = null;
				this.LGPENKDMNOJ = null;
				this.QPPGQJFBPMH.SetActive(false);
				this.GQLDIMEFNIO = false;
				this.QKKQHILJMMO = false;
				if (this.QCEGHHPDQLF.Count == 0)
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EPGFNQMLNBP();
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
					CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
					foreach (ENFMCDNLEQQ enfmcdnleqq in this.BQBCCBPLMDN)
					{
						enfmcdnleqq.DIIHJCJOKMP = 1f;
					}
				}
				this.DKQGFPEGMME = UnityEngine.Time.time;
				yield break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.EnableNPC:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj9 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj9 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(true);
						}
						else
						{
							nhgkgbgjefj9.DNECDEOQKLP.EJHFEJCLMOB(false);
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetLOS:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj10 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj10 != null)
					{
						nhgkgbgjefj10.DNECDEOQKLP.QMBIHEHNIGC = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj10.DNECDEOQKLP.DKMBJOHMDNJ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Customization:
				this.QPPGQJFBPMH.SetActive(false);
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1] != "-1")
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(false);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(false);
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0].ToLowerInvariant() == "true")
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 0;
					}
					else
					{
						this.KDPLKCLJOQI.OQDOCCGPJDQ = 1;
					}
					this.KDPLKCLJOQI.QHEJPNJNMCI[0].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[3];
					this.KDPLKCLJOQI.QHEJPNJNMCI[1].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[4];
					this.KDPLKCLJOQI.QHEJPNJNMCI[2].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
					this.KDPLKCLJOQI.QHEJPNJNMCI[3].PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[2];
					this.KDPLKCLJOQI.HMNJGEPNNFI();
				}
				else
				{
					this.KDPLKCLJOQI.LDGMKMJQQEF[0].SetActive(true);
					this.KDPLKCLJOQI.LDGMKMJQQEF[1].SetActive(true);
				}
				this.KDPLKCLJOQI.Open();
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Shop:
				this.QPPGQJFBPMH.SetActive(false);
				JICJEENBPEO.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SoundEffect:
				if (this.BKGHEHPPPMH.Count > 0 && Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM) == 12)
				{
					foreach (AnimateHealing animateHealing in this.BKGHEHPPPMH)
					{
						animateHealing.Heal(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count);
					}
				}
				DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.CryEffect:
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM), true);
				yield return new WaitForSeconds(1.5f);
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.OpenPC:
				JJGLMJNELOK.QOQONHOOLNE.Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.MusicChange:
				DCCFQPDFBFO.QOQONHOOLNE.COHKNGNJOGD(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM, false);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.HideLink:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, true);
					}
					else
					{
						this.IQQHLBKEMGN.INHDHOGPJCF(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB, false);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait:
				if (!(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid)))
				{
					CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				nhgkgbgjefj7 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
				if (nhgkgbgjefj7 != null)
				{
					nhgkgbgjefj7.DNECDEOQKLP.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
					IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
					yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
					return 1;
				}
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.EIPDNECIJHN(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetNPCPos:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj11 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj11 != null)
					{
						nhgkgbgjefj11.DNECDEOQKLP.NQJHJNQFKKC();
						nhgkgbgjefj11.DNECDEOQKLP.ODGQNNEDJIF = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.JDPCHGPENBD = new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1])));
						nhgkgbgjefj11.DNECDEOQKLP.PJMKLHKFBJM(new Vector3((float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]), nhgkgbgjefj11.DNECDEOQKLP.OHPIPBHKEGC, (float)(-(float)Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1]))), PSXAPI.Response.PlayerDirection.Default);
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Slots:
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().FJEGMHHNGGO.PIDLOFMIEFQ = IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[1];
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().DBPKNCDGGEP = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC[0]);
				CNCJKLNHQBH.QOQONHOOLNE.LHNQPPEQIOE.GetComponent<GQFGBNEHHPC>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Snake:
				CNCJKLNHQBH.QOQONHOOLNE.KLBKGJQONIL.GetComponent<EDKGFBQJPEP>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Tutor:
				this.QPPGQJFBPMH.SetActive(false);
				QLKJQPNKPBC.QOQONHOOLNE.BQLIIQIIMDH(IDFOEJEGNOC.EOBCNIDDIPE[0].NPNKKNBJMNC, IDFOEJEGNOC.DBPKNCDGGEP);
				break;
			case QOHCEBMQKMB.OMGJJGGOCOJ.Pacman:
				CNCJKLNHQBH.QOQONHOOLNE.JOHBOJLFCQF.GetComponent<GDNBFQGCHQQ>().Open();
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetRandomLook:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj12 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj12 != null)
					{
						if (IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM == "1")
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = true;
							nhgkgbgjefj12.DNECDEOQKLP.QJCBOEFQPGF("p", false, false, 0, 0, false);
							nhgkgbgjefj12.DNECDEOQKLP.BHQOFDQCCCG = true;
						}
						else
						{
							nhgkgbgjefj12.DNECDEOQKLP.FDINMJHGLQB = false;
						}
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.ChangeSprite:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj13 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj13 != null)
					{
						nhgkgbgjefj13.DNECDEOQKLP.MFJBPKBNBNO = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj13.DNECDEOQKLP.KKJPFIBDNJI.gameObject.SetActive(true);
						nhgkgbgjefj13.DNECDEOQKLP.MEDHFDLDNEI();
						nhgkgbgjefj13.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetPokemon:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj14 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj14 != null)
					{
						nhgkgbgjefj14.DNECDEOQKLP.BEQHNFFEHMQ = Convert.ToInt32(IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM);
						nhgkgbgjefj14.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			case QOHCEBMQKMB.OMGJJGGOCOJ.SetTag:
				if (IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB != default(Guid))
				{
					KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj15 = KJBDMOCFMCM.QOQONHOOLNE.DICEQCOPLGP(IDFOEJEGNOC.EOBCNIDDIPE[0].QKKBECNOKMB);
					if (nhgkgbgjefj15 != null)
					{
						nhgkgbgjefj15.DNECDEOQKLP.ICHKBBMBPGM = IDFOEJEGNOC.EOBCNIDDIPE[0].COBOLMJMOGM;
						nhgkgbgjefj15.DNECDEOQKLP.NBDBHLEKENM();
					}
				}
				IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
				yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
				return 1;
			}
			IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		}
		else
		{
			this.JGIFFIBHHDE = null;
			this.LGPENKDMNOJ = null;
			this.QPPGQJFBPMH.SetActive(false);
			this.GQLDIMEFNIO = false;
		}
		yield break;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		IDFOEJEGNOC.EOBCNIDDIPE.RemoveAt(0);
		yield return base.StartCoroutine(this.JIJIQIPGPLL(null));
		return 1;
		nhgkgbgjefj2.DNECDEOQKLP.EKEKMCMJEOC = true;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
		yield return new WaitForSeconds(0.5f);
		return 1;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Script
		{
			Response = string.Empty,
			ScriptID = this.LGPENKDMNOJ.DBPKNCDGGEP
		}, false);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = false;
		yield break;
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x0002164C File Offset: 0x0001F84C
	private void CBLIFECCHIC()
	{
		QOHCEBMQKMB.HBFFCJHOCPE = this;
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x000216D3 File Offset: 0x0001F8D3
	public bool MGKFOIKFJDD()
	{
		return this.FCNBFEBQIGB.Count <= 0 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 1;
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x000216C5 File Offset: 0x0001F8C5
	public void MFONIPHOFGF()
	{
		this.QPPGQJFBPMH.SetActive(true);
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator QFQHNLPOLIE()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator PNLEEIPDGQN()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005546 RID: 21830 RVA: 0x002C052C File Offset: 0x002BE72C
	private void GHNKIDFIHIM(string CIQFCJGQEMH)
	{
		for (int i = 0; i < 4; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(new Guid(CIQFCJGQEMH));
		for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			this.CMLGJIEIDBC[j].PIDLOFMIEFQ = string.Concat(new string[]
			{
				fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK,
				"\r\nPP ",
				fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString(),
				"/",
				fekoiojqnkh.EEILBMOOJHJ[j].JPLIFCNPICK.ToString()
			});
		}
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x002C063C File Offset: 0x002BE83C
	public void FBIJDLQENKH()
	{
		this.DKQGFPEGMME = UnityEngine.Time.time;
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.JGIFFIBHHDE.IDPPPPDHEDG() != QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		else
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
		{
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 68;
			for (int i = 0; i < this.JGIFFIBHHDE.PGBLHMLDGOJ.Count; i += 0)
			{
				GameObject gameObject = this.FQQQEGDLPMB.BFCKNMFEBDM(this.EFIMEPJCFNP);
				gameObject.transform.localPosition = new Vector3(1518f, (float)(85 - i * 7), 1814f);
				gameObject.GetComponent<BKKHLBCLPJM>().LKPOBCBOFIC((i + 0).ToString() + "learnset" + this.JGIFFIBHHDE.PGBLHMLDGOJ[i]);
				gameObject.GetComponent<FBJQLFQPGDE>().BGBMIEJJQKC = i;
				gameObject.GetComponent<FBJQLFQPGDE>().IEBJNKKJPEC = this;
				PLQFPBQEPJD component = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
				component.DFKQMMIQDOO = component.JKGBHEHKBPC() + -103;
			}
			float num = (float)this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().JKGBHEHKBPC();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1045f, 903f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 764f, 975f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.KODHLLDFKGO(1289f, 1017f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 804f, -num);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
			PLQFPBQEPJD component2 = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
			component2.MGQIGGNBBBD(component2.JKGBHEHKBPC() + 79);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 609f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
		}
		if (this.JGIFFIBHHDE.DOHOECOFMCI() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.MCEOKJNPNKN.SetActive(false);
			this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -126;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1561f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 1853f, 1005f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 751f, 1975f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.MLEHNJBCBGD(49f, 421f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 801f, 142f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.CJMELFQFOCB.SetActive(true);
			this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -131;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 9f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 1270f, 1247f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 709f, 903f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(1382f, 183f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 570f, 79f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.IDPPPPDHEDG() == QOHCEBMQKMB.OMGJJGGOCOJ.InputAlpha)
		{
			this.HGNQPEJQKGE(this.JGIFFIBHHDE.NGCLGFMBMHL);
			this.HBECCLKEFKK.SetActive(false);
			this.HBECCLKEFKK.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 62;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1033f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1737f, 1571f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 1054f, 917f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(886f, 1918f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 1956f, 790f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
	}

	// Token: 0x06005548 RID: 21832 RVA: 0x002C0C00 File Offset: 0x002BEE00
	public void OLKCDCMFQCN(Guid CIQFCJGQEMH)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CIQFCJGQEMH);
		if (fekoiojqnkh != null)
		{
			this.GONLHGLKJJF = CIQFCJGQEMH;
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == -43 && fekoiojqnkh.QKNEIJQHGCB % -23 > 0)
			{
				str = "/01_" + (fekoiojqnkh.CCMOCLMEKJN() % -122).ToString();
			}
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("p2" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.GONLHGLKJJF = default(Guid);
			this.LMOBKNLIJNP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("[-]\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.DPJNHIPJMDP.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
			this.DPJNHIPJMDP.GetComponent<BoxCollider>().enabled = false;
		}
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x00021843 File Offset: 0x0001FA43
	public bool GQQIDDEIQPO()
	{
		return this.FCNBFEBQIGB.Count <= 1 && this.LGPENKDMNOJ == null && !this.GQLDIMEFNIO && !this.FCPGHPDHCLP && this.QCEGHHPDQLF.Count <= 1;
	}

	// Token: 0x0600554A RID: 21834 RVA: 0x00002300 File Offset: 0x00000500
	private void OLLNOFNEEIL()
	{
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x002B9374 File Offset: 0x002B7574
	public IEnumerator QFQHNLPOLIE(QOHCEBMQKMB.KHJIEDCDGIH IDFOEJEGNOC)
	{
		this.FCNBFEBQIGB.Add(IDFOEJEGNOC);
		if (!this.FCPGHPDHCLP)
		{
			yield return base.StartCoroutine(this.QFQHNLPOLIE());
			return 1;
		}
		yield break;
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator OBKOQHGPPCG()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x0600554D RID: 21837 RVA: 0x002C0D08 File Offset: 0x002BEF08
	private List<QOHCEBMQKMB.DBJHLHDBBQD> PLQOGKEQEJL(ref string QPGCBDPFIOF, Guid QKKBECNOKMB)
	{
		List<QOHCEBMQKMB.DBJHLHDBBQD> list = new List<QOHCEBMQKMB.DBJHLHDBBQD>();
		int num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("intimidate");
			if (num != -1)
			{
				int num2 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[^a-zA-Z0-9]", num + 1);
				if (num2 != -1)
				{
					int num3 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 2, num2 - (num + 3)));
					string text = QPGCBDPFIOF.Substring(1, num);
					text += QPGCBDPFIOF.Substring(num2 + 0);
					QPGCBDPFIOF = text;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)38;
					dbjhlhdbbqd.COBOLMJMOGM = num3.ToString();
					dbjhlhdbbqd.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("BuffIcon_Dig");
			if (num != -1)
			{
				int num4 = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" endured the hit!\r\n", num + 3);
				if (num4 != -1)
				{
					string[] array = QPGCBDPFIOF.Substring(num + 7, num4 - (num + 1)).Split(new char[]
					{
						'<'
					});
					string text2 = QPGCBDPFIOF.Substring(1, num);
					text2 += QPGCBDPFIOF.Substring(num4 + 0);
					QPGCBDPFIOF = text2;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd2 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd2.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)105;
					dbjhlhdbbqd2.PNIFMCHONOI(array[0]);
					dbjhlhdbbqd2.QCMCJBKLJPJ(new Guid(array[0]));
					list.Add(dbjhlhdbbqd2);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("mist");
			if (num != -1)
			{
				int num5 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("suctioncups", num + 0);
				if (num5 != -1)
				{
					string text3 = QPGCBDPFIOF.Substring(num + -63, num5 - (num + -40));
					char[] array2 = new char[0];
					array2[0] = '\u0010';
					string[] array3 = text3.Split(array2);
					string text4 = QPGCBDPFIOF.Substring(0, num);
					text4 += QPGCBDPFIOF.Substring(num5 + 0);
					QPGCBDPFIOF = text4;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.Shop,
						COBOLMJMOGM = array3[1],
						QKKBECNOKMB = new Guid(array3[0])
					});
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("BuffIcon_SuperRepel");
			if (num != -1)
			{
				int num6 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("-clearallboost", num + 3);
				if (num6 != -1)
				{
					string text5 = QPGCBDPFIOF.Substring(num + 80, num6 - (num + -48));
					char[] array4 = new char[0];
					array4[1] = ' ';
					string[] array5 = text5.Split(array4);
					string text6 = QPGCBDPFIOF.Substring(1, num);
					text6 += QPGCBDPFIOF.Substring(num6 + 1);
					QPGCBDPFIOF = text6;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd3 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd3.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.BubbleTextNoWait;
					dbjhlhdbbqd3.MJHOQQOHLBD(array5[0]);
					dbjhlhdbbqd3.QKKBECNOKMB = new Guid(array5[1]);
					list.Add(dbjhlhdbbqd3);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("angerpoint");
			if (num != -1)
			{
				int num7 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("'s ", num + 2);
				if (num7 != -1)
				{
					string text7 = QPGCBDPFIOF.Substring(num + 4, num7 - (num + 2));
					char[] array6 = new char[1];
					array6[1] = '\u0006';
					string[] array7 = text7.Split(array6);
					string text8 = QPGCBDPFIOF.Substring(0, num);
					text8 += QPGCBDPFIOF.Substring(num7 + 1);
					QPGCBDPFIOF = text8;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd4 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd4.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)64;
					dbjhlhdbbqd4.OBPGMMLFFMC(array7[0]);
					dbjhlhdbbqd4.HPMNLCJIBNF(new Guid(array7[0]));
					list.Add(dbjhlhdbbqd4);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" minute ago");
			if (num != -1)
			{
				int num8 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("OnClick", num + 2);
				if (num8 != -1)
				{
					string[] array8 = QPGCBDPFIOF.Substring(num + -67, num8 - (num + 48)).Split(new char[]
					{
						(char)-9
					});
					string text9 = QPGCBDPFIOF.Substring(1, num);
					text9 += QPGCBDPFIOF.Substring(num8 + 0);
					QPGCBDPFIOF = text9;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd5 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd5.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)92;
					dbjhlhdbbqd5.HKPBOGHEHJN(array8[0]);
					dbjhlhdbbqd5.QCMCJBKLJPJ(new Guid(array8[1]));
					list.Add(dbjhlhdbbqd5);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("PostFX - {0}");
			if (num != -1)
			{
				int num9 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("x ", num + 5);
				if (num9 != -1)
				{
					string text10 = QPGCBDPFIOF.Substring(num + 89, num9 - (num + 2));
					char[] array9 = new char[0];
					array9[0] = (char)-81;
					string[] array10 = text10.Split(array9);
					string text11 = QPGCBDPFIOF.Substring(0, num);
					text11 += QPGCBDPFIOF.Substring(num9 + 0);
					QPGCBDPFIOF = text11;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd6 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd6.BBKKHIDMQIQ = QOHCEBMQKMB.OMGJJGGOCOJ.SetTag;
					dbjhlhdbbqd6.OBPGMMLFFMC(array10[0]);
					dbjhlhdbbqd6.HPMNLCJIBNF(new Guid(array10[1]));
					list.Add(dbjhlhdbbqd6);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Move Learning");
			if (num != -1)
			{
				int num10 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("The Pokémon boosts its most proficient stat each time it knocks out a Pokémon.", num + 0);
				if (num10 != -1)
				{
					string text12 = QPGCBDPFIOF.Substring(num + 7, num10 - (num + 0));
					char[] array11 = new char[0];
					array11[1] = 'Q';
					string[] array12 = text12.Split(array11);
					string text13 = QPGCBDPFIOF.Substring(0, num);
					text13 += QPGCBDPFIOF.Substring(num10 + 0);
					QPGCBDPFIOF = text13;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd7 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd7.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)78;
					dbjhlhdbbqd7.DCBKPGPGBIQ(new string[6]);
					dbjhlhdbbqd7.NPNKKNBJMNC[1] = array12[1];
					dbjhlhdbbqd7.FDKDDBKDKJF()[0] = array12[0];
					list.Add(dbjhlhdbbqd7);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[weaken]");
			if (num != -1)
			{
				int num11 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[^0-9.-]", num + 0);
				if (num11 != -1)
				{
					string text14 = QPGCBDPFIOF.Substring(1, num);
					text14 += QPGCBDPFIOF.Substring(num11 + 1);
					QPGCBDPFIOF = text14;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-125)
					});
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("_VelocityScale");
			if (num != -1)
			{
				int num12 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("inky", num + 4);
				if (num12 != -1)
				{
					string text15 = QPGCBDPFIOF.Substring(1, num);
					text15 += QPGCBDPFIOF.Substring(num12 + 1);
					QPGCBDPFIOF = text15;
					list.Add(new QOHCEBMQKMB.DBJHLHDBBQD
					{
						BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-64)
					});
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" caused an uproar!\r\n");
			if (num != -1)
			{
				int num13 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("i", num + 4);
				if (num13 != -1)
				{
					string text16 = QPGCBDPFIOF.Substring(num + 14, num13 - (num + -61));
					char[] array13 = new char[0];
					array13[0] = (char)-97;
					string[] array14 = text16.Split(array13);
					string text17 = QPGCBDPFIOF.Substring(0, num);
					text17 += QPGCBDPFIOF.Substring(num13 + 1);
					QPGCBDPFIOF = text17;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd8 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd8.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-93);
					dbjhlhdbbqd8.COBOLMJMOGM = array14[0];
					dbjhlhdbbqd8.HPMNLCJIBNF(new Guid(array14[0]));
					list.Add(dbjhlhdbbqd8);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Egg");
			if (num != -1)
			{
				int num14 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("[00EE07]", num + 5);
				if (num14 != -1)
				{
					string text18 = QPGCBDPFIOF.Substring(num + 107, num14 - (num + 93));
					char[] array15 = new char[0];
					array15[0] = (char)-64;
					string[] array16 = text18.Split(array15);
					string text19 = QPGCBDPFIOF.Substring(0, num);
					text19 += QPGCBDPFIOF.Substring(num14 + 0);
					QPGCBDPFIOF = text19;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd9 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd9.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-76);
					dbjhlhdbbqd9.COBOLMJMOGM = string.Empty;
					dbjhlhdbbqd9.HKPBOGHEHJN(string.Empty);
					dbjhlhdbbqd9.NPNKKNBJMNC = new string[6];
					dbjhlhdbbqd9.EBMMBECOEQQ()[0] = array16[1];
					dbjhlhdbbqd9.NPNKKNBJMNC[0] = array16[5];
					dbjhlhdbbqd9.QCMCJBKLJPJ(new Guid(array16[0]));
					list.Add(dbjhlhdbbqd9);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("_CameraClipInfo");
			if (num != -1)
			{
				int num15 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("galewings", num + 4);
				if (num15 != -1)
				{
					int num16 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 2, num15 - (num + 1)));
					string text20 = QPGCBDPFIOF.Substring(0, num);
					text20 += QPGCBDPFIOF.Substring(num15 + 0);
					QPGCBDPFIOF = text20;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd10 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd10.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-82);
					dbjhlhdbbqd10.OBPGMMLFFMC(num16.ToString());
					dbjhlhdbbqd10.QKKBECNOKMB = QKKBECNOKMB;
					list.Add(dbjhlhdbbqd10);
				}
			}
		}
		num = 1;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf(" ");
			if (num != -1)
			{
				int num17 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("(H)", num + 0);
				if (num17 != -1)
				{
					string bgbmiejjqkc = QPGCBDPFIOF.Substring(num + 3, num17 - (num + 3));
					string text21 = QPGCBDPFIOF.Substring(1, num);
					text21 += QPGCBDPFIOF.Substring(num17 + 1);
					QPGCBDPFIOF = text21;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd11 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd11.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-97);
					dbjhlhdbbqd11.OBPGMMLFFMC(bgbmiejjqkc);
					dbjhlhdbbqd11.QKKBECNOKMB = QKKBECNOKMB;
					list.Add(dbjhlhdbbqd11);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("FOG_LINEAR");
			if (num != -1)
			{
				int num18 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("This Pokémon inflicts damage with its rough skin to the attacker on contact.", num + 0);
				if (num18 != -1)
				{
					int num19 = Convert.ToInt32(QPGCBDPFIOF.Substring(num + 7, num18 - (num + 1)));
					string text22 = QPGCBDPFIOF.Substring(0, num);
					text22 += QPGCBDPFIOF.Substring(num18 + 1);
					QPGCBDPFIOF = text22;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd12 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd12.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)(-77);
					dbjhlhdbbqd12.HKPBOGHEHJN(num19.ToString());
					dbjhlhdbbqd12.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd12);
				}
			}
		}
		num = 0;
		while (num != -1)
		{
			num = QPGCBDPFIOF.ToLowerInvariant().IndexOf("TM");
			if (num != -1)
			{
				int num20 = QPGCBDPFIOF.ToLowerInvariant().IndexOf("Player/Clothe", num + 0);
				if (num20 != -1)
				{
					string text23 = QPGCBDPFIOF.Substring(0, num);
					text23 += QPGCBDPFIOF.Substring(num20 + 1);
					QPGCBDPFIOF = text23;
					QOHCEBMQKMB.DBJHLHDBBQD dbjhlhdbbqd13 = new QOHCEBMQKMB.DBJHLHDBBQD();
					dbjhlhdbbqd13.BBKKHIDMQIQ = (QOHCEBMQKMB.OMGJJGGOCOJ)118;
					dbjhlhdbbqd13.MJHOQQOHLBD(string.Empty);
					dbjhlhdbbqd13.HPMNLCJIBNF(QKKBECNOKMB);
					list.Add(dbjhlhdbbqd13);
				}
			}
		}
		QPGCBDPFIOF = KGQECFKLKOP.LGGPFIJQHOM(QPGCBDPFIOF);
		if (list.Count > 0)
		{
			return list;
		}
		return null;
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x002C182C File Offset: 0x002BFA2C
	public void ClickText()
	{
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.QOOEMQECGEJ.CPOJBKCQPHK)
		{
			this.HLINLLBMHGM.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QOOEMQECGEJ.INNQKLOKBFL();
			this.HLINLLBMHGM.DIIHJCJOKMP = 1f;
		}
		else if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			base.StartCoroutine(this.JIJIQIPGPLL(null));
		}
		this.DKQGFPEGMME = UnityEngine.Time.time;
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x002C18A4 File Offset: 0x002BFAA4
	public void QQMCHQFPBEJ()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = "May disable a move used on the Pokémon.",
			ScriptID = this.LGPENKDMNOJ.PPBQHEFMOBI()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(false);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke("When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.", 1042f);
	}

	// Token: 0x06005550 RID: 21840 RVA: 0x002C193C File Offset: 0x002BFB3C
	public void GIIFJCNMIEP()
	{
		this.DKQGFPEGMME = UnityEngine.Time.time;
		if (this.JGIFFIBHHDE == null)
		{
			return;
		}
		if (this.JGIFFIBHHDE.DDCEONMOFEM() != QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		else
		{
			this.NNQMIKEKBOJ.SetActive(false);
		}
		if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().MGQIGGNBBBD(-101);
			for (int i = 1; i < this.JGIFFIBHHDE.PGBLHMLDGOJ.Count; i += 0)
			{
				GameObject gameObject = this.FQQQEGDLPMB.BFCKNMFEBDM(this.EFIMEPJCFNP);
				gameObject.transform.localPosition = new Vector3(1171f, (float)(114 - i * -107), 1507f);
				gameObject.GetComponent<BKKHLBCLPJM>().PIDLOFMIEFQ = (i + 1).ToString() + "The Pokémon's proud of its powerful pincers. They prevent other Pokémon from lowering its Attack stat." + this.JGIFFIBHHDE.PGBLHMLDGOJ[i];
				gameObject.GetComponent<FBJQLFQPGDE>().BGBMIEJJQKC = i;
				gameObject.GetComponent<FBJQLFQPGDE>().IEBJNKKJPEC = this;
				this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO += -80;
			}
			float num = (float)this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 509f, 1183f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 517f, 1122f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.PJMIKDIEGMB(346f, 711f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 63f, -num);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
			PLQFPBQEPJD component = this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>();
			component.DFKQMMIQDOO = component.JKGBHEHKBPC() + 60;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 474f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
		}
		if (this.JGIFFIBHHDE.BBKKHIDMQIQ == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.MCEOKJNPNKN.SetActive(true);
			this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = -108;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 984f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 1190f, 315f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 245f, 1298f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.MLEHNJBCBGD(1155f, 958f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 1631f, 1092f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.DDCEONMOFEM() == QOHCEBMQKMB.OMGJJGGOCOJ.Select)
		{
			this.CJMELFQFOCB.SetActive(false);
			this.CJMELFQFOCB.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DFKQMMIQDOO = 64;
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 474f;
			this.KBICCNPFFGQ.enabled = true;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.PJMIKDIEGMB(this.MIFBNLLNKBH, 1259f, 1115f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.PJMIKDIEGMB(this.MIFBNLLNKBH, 1378f, 1401f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.KDJODMLBQEB(420f, 1674f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.PJMIKDIEGMB(this.MIFBNLLNKBH, 162f, 1689f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
		if (this.JGIFFIBHHDE.QJEHDCJHHEN() == QOHCEBMQKMB.OMGJJGGOCOJ.Text)
		{
			this.JNJFEGJBBJK(this.JGIFFIBHHDE.NGCLGFMBMHL);
			this.HBECCLKEFKK.SetActive(false);
			this.HBECCLKEFKK.GetComponent<EPIJJNOIKEK>().PlayForward();
			this.FQQQEGDLPMB.transform.NMBPDMIIHJB();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().MGQIGGNBBBD(195);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1480f;
			this.KBICCNPFFGQ.enabled = false;
			this.KBICCNPFFGQ.ResetToBeginning();
			this.KBICCNPFFGQ.PlayForward();
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HJDMKGDLJEP.CEQNIBMEKQN(this.MIFBNLLNKBH, 162f, 218f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().HKPCCMEEHDL.CEQNIBMEKQN(this.MIFBNLLNKBH, 94f, 554f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().NOPCJFECJDP.MLEHNJBCBGD(691f, 1458f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().LBGJKGDECCN.CEQNIBMEKQN(this.MIFBNLLNKBH, 187f, 1731f);
			this.KBICCNPFFGQ.GetComponent<PLQFPBQEPJD>().UpdateAnchors();
		}
	}

	// Token: 0x06005551 RID: 21841 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator CNHEHHHBOBB()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005552 RID: 21842 RVA: 0x0002187C File Offset: 0x0001FA7C
	public void FOCOHPNMBMG()
	{
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
	}

	// Token: 0x06005553 RID: 21843 RVA: 0x002B86A8 File Offset: 0x002B68A8
	public IEnumerator FOGIKLJGKND()
	{
		bqbccbplmdn = this.BQBCCBPLMDN;
		for (i = 0; i < bqbccbplmdn.Length; i++)
		{
			ENFMCDNLEQQ enfmcdnleqq = bqbccbplmdn[i];
			enfmcdnleqq.DIIHJCJOKMP = 0f;
		}
		this.FCPGHPDHCLP = true;
		flag = true;
		if (flag)
		{
			if (this.IQQHLBKEMGN == null)
			{
				this.IQQHLBKEMGN = MCNLIHMMLCF.QOQONHOOLNE;
			}
			if (this.IQQHLBKEMGN != null && !this.IQQHLBKEMGN.HCQINBCDGNO)
			{
				flag = false;
			}
			yield return null;
		}
		else if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
		{
			yield return null;
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			yield return null;
		}
		else if (this.GQLDIMEFNIO)
		{
			yield return null;
		}
		else if (this.LGPENKDMNOJ != null)
		{
			yield return null;
		}
		else if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			yield return null;
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
		{
			yield return null;
		}
		else
		{
			if (this.KQGLCNGHJLM)
			{
				yield return null;
				return 1;
			}
			while (this.FCNBFEBQIGB.Count > 0)
			{
				if (CNCJKLNHQBH.QOQONHOOLNE.IDHBJBKFFON)
				{
					yield return null;
					return 1;
				}
				if (this.GQLDIMEFNIO)
				{
					yield return null;
					return 1;
				}
				if (this.LGPENKDMNOJ != null)
				{
					yield return null;
					return 1;
				}
				if (OGJJKKQPNMK.QOQONHOOLNE != null)
				{
					yield return null;
					return 1;
				}
				if (DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP)
				{
					yield return null;
					return 1;
				}
				if (this.FCNBFEBQIGB.Count > 0)
				{
					this.GQLDIMEFNIO = true;
					idfoejegnoc = this.FCNBFEBQIGB[0];
					GGQKBGDGNJN.QOQONHOOLNE.ExitFly();
					yield return base.StartCoroutine(this.JIJIQIPGPLL(idfoejegnoc));
					return 1;
				}
				IL_2E6:
				this.GQLDIMEFNIO = false;
			}
			this.FCPGHPDHCLP = false;
			if (!this.EKEKMCMJEOC())
			{
				CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
				CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
				foreach (ENFMCDNLEQQ enfmcdnleqq2 in this.BQBCCBPLMDN)
				{
					enfmcdnleqq2.DIIHJCJOKMP = 1f;
				}
			}
			yield return null;
		}
		return 1;
		this.FCNBFEBQIGB.RemoveAt(0);
		goto IL_2E6;
		yield break;
	}

	// Token: 0x06005554 RID: 21844 RVA: 0x0002163B File Offset: 0x0001F83B
	private void FinishSelect()
	{
		this.JJDHNMEHBLJ = true;
	}

	// Token: 0x06005555 RID: 21845 RVA: 0x002C1F00 File Offset: 0x002C0100
	public void GJNGMBFQIDP()
	{
		if (!this.JJDHNMEHBLJ)
		{
			return;
		}
		this.JJDHNMEHBLJ = false;
		this.MCEOKJNPNKN.GetComponent<EPIJJNOIKEK>().PlayReverse();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Script
		{
			Response = this.GONLHGLKJJF.ToString(),
			ScriptID = this.LGPENKDMNOJ.DNKQCLPKPED()
		}, true);
		this.JGIFFIBHHDE = null;
		this.LGPENKDMNOJ = null;
		this.QPPGQJFBPMH.SetActive(true);
		this.GQLDIMEFNIO = true;
		this.KBICCNPFFGQ.PlayReverse();
		base.Invoke(" caused an uproar!\r\n", 847f);
	}

	// Token: 0x04001276 RID: 4726
	private static QOHCEBMQKMB HBFFCJHOCPE;

	// Token: 0x04001277 RID: 4727
	public bool QKKQHILJMMO;

	// Token: 0x04001278 RID: 4728
	public List<AnimateHealing> BKGHEHPPPMH = new List<AnimateHealing>();

	// Token: 0x04001279 RID: 4729
	public ENFMCDNLEQQ[] BQBCCBPLMDN;

	// Token: 0x0400127A RID: 4730
	public List<QOHCEBMQKMB.KHJIEDCDGIH> FCNBFEBQIGB = new List<QOHCEBMQKMB.KHJIEDCDGIH>();

	// Token: 0x0400127B RID: 4731
	public List<Guid> QCEGHHPDQLF = new List<Guid>();

	// Token: 0x0400127C RID: 4732
	public QOHCEBMQKMB.KHJIEDCDGIH LGPENKDMNOJ;

	// Token: 0x0400127D RID: 4733
	public bool GQLDIMEFNIO;

	// Token: 0x0400127E RID: 4734
	private MCNLIHMMLCF IQQHLBKEMGN;

	// Token: 0x0400127F RID: 4735
	private bool FCPGHPDHCLP;

	// Token: 0x04001280 RID: 4736
	public bool KQGLCNGHJLM;

	// Token: 0x04001281 RID: 4737
	public QOHCEBMQKMB.DBJHLHDBBQD JGIFFIBHHDE;

	// Token: 0x04001282 RID: 4738
	public Camera PGHJQNJLJKG;

	// Token: 0x04001283 RID: 4739
	public Camera OJQMEBDJDHB;

	// Token: 0x04001284 RID: 4740
	public GameObject QPPGQJFBPMH;

	// Token: 0x04001285 RID: 4741
	public BKIDEFQEKGK QOOEMQECGEJ;

	// Token: 0x04001286 RID: 4742
	public GameObject NNQMIKEKBOJ;

	// Token: 0x04001287 RID: 4743
	public BKKHLBCLPJM HLINLLBMHGM;

	// Token: 0x04001288 RID: 4744
	public PLQFPBQEPJD LJCIHKCBIDE;

	// Token: 0x04001289 RID: 4745
	public NLDFFJFQJBI HFFFEDCGPBD;

	// Token: 0x0400128A RID: 4746
	public Transform FQLIOJQIKME;

	// Token: 0x0400128B RID: 4747
	public FPMCQNCDOIP KBICCNPFFGQ;

	// Token: 0x0400128C RID: 4748
	public GameObject FQQQEGDLPMB;

	// Token: 0x0400128D RID: 4749
	public GameObject EFIMEPJCFNP;

	// Token: 0x0400128E RID: 4750
	public GameObject CIPQDMPQDCD;

	// Token: 0x0400128F RID: 4751
	public Transform MIFBNLLNKBH;

	// Token: 0x04001290 RID: 4752
	private bool JJDHNMEHBLJ = true;

	// Token: 0x04001291 RID: 4753
	public BNIJKFJBFBG KDPLKCLJOQI;

	// Token: 0x04001292 RID: 4754
	public GameObject MCEOKJNPNKN;

	// Token: 0x04001293 RID: 4755
	public CFDMNELIJLO DPJNHIPJMDP;

	// Token: 0x04001294 RID: 4756
	public JLMPBLMOICG LMOBKNLIJNP;

	// Token: 0x04001295 RID: 4757
	private Guid GONLHGLKJJF;

	// Token: 0x04001296 RID: 4758
	public GameObject CJMELFQFOCB;

	// Token: 0x04001297 RID: 4759
	public CFDMNELIJLO LMEDQMIDFBB;

	// Token: 0x04001298 RID: 4760
	public JLMPBLMOICG JEDFFGHOHPJ;

	// Token: 0x04001299 RID: 4761
	private int FHHKNDPDDPQ;

	// Token: 0x0400129A RID: 4762
	public GameObject HBECCLKEFKK;

	// Token: 0x0400129B RID: 4763
	public CFDMNELIJLO[] PDFOJLELNHP;

	// Token: 0x0400129C RID: 4764
	public BKKHLBCLPJM[] CMLGJIEIDBC;

	// Token: 0x0400129D RID: 4765
	public float DKQGFPEGMME;

	// Token: 0x0200026E RID: 622
	public enum OMGJJGGOCOJ
	{
		// Token: 0x0400129F RID: 4767
		Text,
		// Token: 0x040012A0 RID: 4768
		Select,
		// Token: 0x040012A1 RID: 4769
		SelectPokemon,
		// Token: 0x040012A2 RID: 4770
		SelectItem,
		// Token: 0x040012A3 RID: 4771
		SelectMove,
		// Token: 0x040012A4 RID: 4772
		InputNumeric,
		// Token: 0x040012A5 RID: 4773
		InputAlpha,
		// Token: 0x040012A6 RID: 4774
		MoveNPC,
		// Token: 0x040012A7 RID: 4775
		MovePlayer,
		// Token: 0x040012A8 RID: 4776
		BubbleText,
		// Token: 0x040012A9 RID: 4777
		Emote,
		// Token: 0x040012AA RID: 4778
		Wait,
		// Token: 0x040012AB RID: 4779
		MessageBox,
		// Token: 0x040012AC RID: 4780
		MessageBoxYesNo,
		// Token: 0x040012AD RID: 4781
		Unfreeze,
		// Token: 0x040012AE RID: 4782
		EnableNPC,
		// Token: 0x040012AF RID: 4783
		SetLOS,
		// Token: 0x040012B0 RID: 4784
		Customization,
		// Token: 0x040012B1 RID: 4785
		Shop,
		// Token: 0x040012B2 RID: 4786
		SoundEffect,
		// Token: 0x040012B3 RID: 4787
		CryEffect,
		// Token: 0x040012B4 RID: 4788
		OpenPC,
		// Token: 0x040012B5 RID: 4789
		MusicChange,
		// Token: 0x040012B6 RID: 4790
		HideLink,
		// Token: 0x040012B7 RID: 4791
		BubbleTextNoWait,
		// Token: 0x040012B8 RID: 4792
		SetNPCPos,
		// Token: 0x040012B9 RID: 4793
		Slots,
		// Token: 0x040012BA RID: 4794
		Snake,
		// Token: 0x040012BB RID: 4795
		Tutor,
		// Token: 0x040012BC RID: 4796
		Pacman,
		// Token: 0x040012BD RID: 4797
		SetRandomLook,
		// Token: 0x040012BE RID: 4798
		ChangeSprite,
		// Token: 0x040012BF RID: 4799
		SetPokemon,
		// Token: 0x040012C0 RID: 4800
		SetTag
	}

	// Token: 0x0200026F RID: 623
	public class DBJHLHDBBQD
	{
		// Token: 0x06005556 RID: 21846 RVA: 0x0002189F File Offset: 0x0001FA9F
		public void BOCFDKPFCGO(List<string> BGBMIEJJQKC)
		{
			this.<NMPLBEFKBQL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x000218A8 File Offset: 0x0001FAA8
		public string GQPBPMKGDEB()
		{
			return this.<ILLELOKIIBF>k__BackingField;
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public Guid JOPHNHPHIFP()
		{
			return this.<QCJOOLLIJDE>k__BackingField;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x000218A8 File Offset: 0x0001FAA8
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x000218B8 File Offset: 0x0001FAB8
		public string DHBBBGDFHCQ { get; set; }

		// Token: 0x0600555A RID: 21850 RVA: 0x000218C1 File Offset: 0x0001FAC1
		public void OBPGMMLFFMC(string BGBMIEJJQKC)
		{
			this.<FMPEHBQOJGI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x000218A8 File Offset: 0x0001FAA8
		public string BIHJOEELPIC()
		{
			return this.<ILLELOKIIBF>k__BackingField;
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public Guid CQCOIHCGEQQ()
		{
			return this.<QCJOOLLIJDE>k__BackingField;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x000218B0 File Offset: 0x0001FAB0
		// (set) Token: 0x0600556F RID: 21871 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public Guid QKKBECNOKMB { get; set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x000218DC File Offset: 0x0001FADC
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x000218CA File Offset: 0x0001FACA
		public QOHCEBMQKMB.OMGJJGGOCOJ BBKKHIDMQIQ { get; set; }

		// Token: 0x0600555F RID: 21855 RVA: 0x000218C1 File Offset: 0x0001FAC1
		public void PNIFMCHONOI(string BGBMIEJJQKC)
		{
			this.<FMPEHBQOJGI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public void DCBKPGPGBIQ(string[] BGBMIEJJQKC)
		{
			this.<HPEBDQDQONH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x000218DC File Offset: 0x0001FADC
		public QOHCEBMQKMB.OMGJJGGOCOJ DOHOECOFMCI()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06005566 RID: 21862 RVA: 0x000218ED File Offset: 0x0001FAED
		// (set) Token: 0x06005562 RID: 21858 RVA: 0x0002189F File Offset: 0x0001FA9F
		public List<string> PGBLHMLDGOJ { get; set; }

		// Token: 0x06005563 RID: 21859 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public void OOLHEPMPCQC(string[] BGBMIEJJQKC)
		{
			this.<HPEBDQDQONH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x00021906 File Offset: 0x0001FB06
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x000218C1 File Offset: 0x0001FAC1
		public string COBOLMJMOGM { get; set; }

		// Token: 0x06005565 RID: 21861 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public void HPMNLCJIBNF(Guid BGBMIEJJQKC)
		{
			this.<QCJOOLLIJDE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] FDKDDBKDKJF()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public void LOFHEGDOQGH(string[] BGBMIEJJQKC)
		{
			this.<HPEBDQDQONH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public void LJCJCFLOFHB(string[] BGBMIEJJQKC)
		{
			this.<HPEBDQDQONH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] JQODJENNMLF()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public Guid EBQPBPPFGOF()
		{
			return this.<QCJOOLLIJDE>k__BackingField;
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x000218FD File Offset: 0x0001FAFD
		public void GKNMPMFJBMK(string BGBMIEJJQKC)
		{
			this.<LFGEKCFCIPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x000218A8 File Offset: 0x0001FAA8
		public string NBMJLOJKDNN()
		{
			return this.<ILLELOKIIBF>k__BackingField;
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x000218DC File Offset: 0x0001FADC
		public QOHCEBMQKMB.OMGJJGGOCOJ QJEHDCJHHEN()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] JKPPKFDMMQK()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x000218F5 File Offset: 0x0001FAF5
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public string[] NPNKKNBJMNC { get; set; }

		// Token: 0x06005573 RID: 21875 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] OPDDCBCKEBO()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x000218DC File Offset: 0x0001FADC
		public QOHCEBMQKMB.OMGJJGGOCOJ DDCEONMOFEM()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] HBBMJGQIMML()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x000218DC File Offset: 0x0001FADC
		public QOHCEBMQKMB.OMGJJGGOCOJ IDPPPPDHEDG()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x0002190E File Offset: 0x0001FB0E
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x000218FD File Offset: 0x0001FAFD
		public string NGCLGFMBMHL { get; set; }

		// Token: 0x0600557A RID: 21882 RVA: 0x00021906 File Offset: 0x0001FB06
		public string JFHNCIPJLQO()
		{
			return this.<FMPEHBQOJGI>k__BackingField;
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x000218B0 File Offset: 0x0001FAB0
		public Guid BQBJQNBNHHO()
		{
			return this.<QCJOOLLIJDE>k__BackingField;
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00021906 File Offset: 0x0001FB06
		public string NOJCLIELQKF()
		{
			return this.<FMPEHBQOJGI>k__BackingField;
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] CFCKIKGHCCL()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x000218C1 File Offset: 0x0001FAC1
		public void HKPBOGHEHJN(string BGBMIEJJQKC)
		{
			this.<FMPEHBQOJGI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public void QCMCJBKLJPJ(Guid BGBMIEJJQKC)
		{
			this.<QCJOOLLIJDE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x000218C1 File Offset: 0x0001FAC1
		public void MJHOQQOHLBD(string BGBMIEJJQKC)
		{
			this.<FMPEHBQOJGI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public string[] EBMMBECOEQQ()
		{
			return this.<HPEBDQDQONH>k__BackingField;
		}
	}

	// Token: 0x02000270 RID: 624
	public class KHJIEDCDGIH
	{
		// Token: 0x06005585 RID: 21893 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType OIBQDFFCHGM()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType KQKLLQIMCEK()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void GMODMEHGLJH(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType INCQQNFHJEG()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid MMIGPFEOHEJ()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> QGDKIPFGFBC()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid NNKDGMIDHIG()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> BIEGCJHEENO()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00021937 File Offset: 0x0001FB37
		public void CKBNKFHMKCH(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> NMPILNDFOOB()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00021940 File Offset: 0x0001FB40
		public void GJJOLCIGNFG(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType MMEGLELLKLO()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00021937 File Offset: 0x0001FB37
		public void FKIQPIHOENB(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> CCKMGCIPDHL()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> FJPFKNBKBCJ()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType JNIDGMKJODL()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00021940 File Offset: 0x0001FB40
		public void QLCCEELKFBI(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00021937 File Offset: 0x0001FB37
		public void JCJKHDPHBED(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00021940 File Offset: 0x0001FB40
		public void QHCNLMNKQMQ(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> CMIBLKPLGDD()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType CDBIHCNOLJH()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00021937 File Offset: 0x0001FB37
		public void DJMFOBMDHFL(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType CHFDLMGIICB()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType MKFOBIMJEMB()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00021940 File Offset: 0x0001FB40
		public void JHDGJFOGHND(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00021937 File Offset: 0x0001FB37
		public void DJNOECJBBFE(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType JJQDEJMIFOC()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00021940 File Offset: 0x0001FB40
		public void LNCICECBHOG(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00021937 File Offset: 0x0001FB37
		public void KJCNLKBQPDF(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x00021937 File Offset: 0x0001FB37
		public void HMBQJPLOBLM(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> PJMMPIMPEFL()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00021940 File Offset: 0x0001FB40
		public void OJOOENIOIEF(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00021937 File Offset: 0x0001FB37
		public void EKHJBFQKQEM(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid NIFMKBOPFMQ()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00021940 File Offset: 0x0001FB40
		public void GQMLHPKNNMQ(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00021937 File Offset: 0x0001FB37
		public void DGMGNNQNIDL(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x0002192F File Offset: 0x0001FB2F
		// (set) Token: 0x060055BC RID: 21948 RVA: 0x00021940 File Offset: 0x0001FB40
		public List<QOHCEBMQKMB.DBJHLHDBBQD> EOBCNIDDIPE { get; set; }

		// Token: 0x060055AB RID: 21931 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid BFMPLLJBPQM()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00021940 File Offset: 0x0001FB40
		public void KNKQFOMBHDE(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00021940 File Offset: 0x0001FB40
		public void PCDBIKKPNLP(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid HLDLDBPCNLQ()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType DEGJIODBHEC()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00021940 File Offset: 0x0001FB40
		public void JGQHHPPENFB(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00021937 File Offset: 0x0001FB37
		public void KGDLNOMOOHK(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid LBPHOPIJENP()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType NJEONNBHLNL()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060055BA RID: 21946 RVA: 0x00021916 File Offset: 0x0001FB16
		// (set) Token: 0x060055B4 RID: 21940 RVA: 0x00021937 File Offset: 0x0001FB37
		public ScriptRequestType CGBHHGJMFDM { get; set; }

		// Token: 0x060055B5 RID: 21941 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType JKHPJCFJKMG()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType HLCHBDDKEJP()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void EJLJMJQQOMI(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType NHBBIQFJMJC()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid CMOFLCMMJMP()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void HQLCHKKHFHE(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00021937 File Offset: 0x0001FB37
		public void IGLIFNCJHIC(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00021937 File Offset: 0x0001FB37
		public void IIHBKHDEOMJ(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid CPCEJHLHILG()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060055C7 RID: 21959 RVA: 0x00021927 File Offset: 0x0001FB27
		// (set) Token: 0x060055C0 RID: 21952 RVA: 0x0002191E File Offset: 0x0001FB1E
		public Guid DBPKNCDGGEP { get; set; }

		// Token: 0x060055C1 RID: 21953 RVA: 0x00021940 File Offset: 0x0001FB40
		public void NDMEDBEFOOQ(List<QOHCEBMQKMB.DBJHLHDBBQD> BGBMIEJJQKC)
		{
			this.<KMCONIFNOPH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid CEQBILCPIGQ()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> MPDFMKPEDKP()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> GPFEBMJOILP()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType EOGDGCOICII()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType DGMLMNGDDJG()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid DNKQCLPKPED()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid GMOFFIFDCGE()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> LQGDLEFDNDB()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void GIQJNJLEHDF(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType OKEMIIOJCOI()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> IEBEHFLMIGC()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType QBCNCGIGCCE()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void BKIFQHODHEM(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void MJJPLJOKMMH(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid GQMPDBKIEBK()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid LFGKJLIPLHP()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00021937 File Offset: 0x0001FB37
		public void LHBQCGEDBJC(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00021937 File Offset: 0x0001FB37
		public void HIDBEEFEBBQ(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid PPBQHEFMOBI()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid BEMEICKBCPI()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid NEHHLGHJKLK()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00021937 File Offset: 0x0001FB37
		public void KGOEGCCLMHD(ScriptRequestType BGBMIEJJQKC)
		{
			this.<KNOLLCFOEOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00021927 File Offset: 0x0001FB27
		public Guid DBCHHNGOKGD()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x0002191E File Offset: 0x0001FB1E
		public void FINBFLKIPFL(Guid BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x0002192F File Offset: 0x0001FB2F
		public List<QOHCEBMQKMB.DBJHLHDBBQD> LBJIPDNLEIC()
		{
			return this.<KMCONIFNOPH>k__BackingField;
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00021916 File Offset: 0x0001FB16
		public ScriptRequestType IONMNLFKJJQ()
		{
			return this.<KNOLLCFOEOC>k__BackingField;
		}

		// Token: 0x040012CB RID: 4811
		public bool QOKLPJKJFNQ;
	}
}
