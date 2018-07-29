using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020002A9 RID: 681
public class FENGGFKHMOE : MonoBehaviour
{
	// Token: 0x06005F91 RID: 24465 RVA: 0x00025773 File Offset: 0x00023973
	public static void FMFIOIHDFDC(GameObject FHEPDJIDMNM)
	{
		FENGGFKHMOE.HBFFCJHOCPE.OFFOGICDENL(FHEPDJIDMNM);
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x00025780 File Offset: 0x00023980
	private void LFJEJGOMLPI()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("It looks as though this Egg will take a long time yet to hatch.", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x003085B8 File Offset: 0x003067B8
	private void IKHIQQKHILB()
	{
		this.QOHFGJPJGQJ = true;
		for (int i = 0; i < this.LLQDOILCBQH.Length; i += 0)
		{
			FENGGFKHMOE.IBPNPLKCJHH(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = false;
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool LHPCKJCDCJK()
	{
		return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
	}

	// Token: 0x06005F95 RID: 24469 RVA: 0x003085FC File Offset: 0x003067FC
	private void LCLDLKGECCK(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 0;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 0;
		}
	}

	// Token: 0x06005F96 RID: 24470 RVA: 0x000257B1 File Offset: 0x000239B1
	public static void NCBDMPEFOHF(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.JDCQQQOBCHB(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005F97 RID: 24471 RVA: 0x00308660 File Offset: 0x00306860
	private void BPJFLCDMFDE(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 0;
		}
	}

	// Token: 0x06005F98 RID: 24472 RVA: 0x003086C4 File Offset: 0x003068C4
	private void IDOEGDLOKCF(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[1] = "The Tailwind blew from behind ";
			array[1] = CNFGGJGBLHD.name;
			array[5] = "#,##0";
			array[4] = instanceID;
			array[5] = "!\r\n";
			Debug.LogWarning(string.Concat(array), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 0; i >= 1; i -= 0)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x06005F99 RID: 24473 RVA: 0x000257BF File Offset: 0x000239BF
	public static void IBPNPLKCJHH(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.HLEMQDLHOEM(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005F9A RID: 24474 RVA: 0x000257CD File Offset: 0x000239CD
	private void DCJQFJOICGQ()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("primordialsea", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005F9B RID: 24475 RVA: 0x000257F2 File Offset: 0x000239F2
	private void LKDKBNOBIPK()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("'s ", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x0030878C File Offset: 0x0030698C
	public static GameObject HNCLQFOKEJN(GameObject FHEPDJIDMNM, bool NMILHJFKPFB = true)
	{
		int instanceID = FHEPDJIDMNM.GetInstanceID();
		if (!FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[1] = "Water";
			array[1] = FHEPDJIDMNM.name;
			array[1] = "3";
			array[7] = instanceID;
			array[3] = "~";
			Debug.LogError(string.Concat(array), FENGGFKHMOE.HBFFCJHOCPE);
			return null;
		}
		int num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
		GameObject gameObject;
		if (FENGGFKHMOE.HBFFCJHOCPE.IMQBDOJKIBE)
		{
			int num2 = num;
			do
			{
				gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
				FENGGFKHMOE.HBFFCJHOCPE.BPJFLCDMFDE(instanceID);
				num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
				if (gameObject != null && !gameObject.activeSelf)
				{
					goto Block_4;
				}
			}
			while (num != num2);
			if (!FENGGFKHMOE.HBFFCJHOCPE.FDGNIQFNJGO)
			{
				Debug.LogWarning("mudsport" + FHEPDJIDMNM.name + "--catch", FENGGFKHMOE.HBFFCJHOCPE);
				return null;
			}
			Debug.Log("inven " + FHEPDJIDMNM.name + "_ClipToWorld", FENGGFKHMOE.HBFFCJHOCPE);
			FENGGFKHMOE.NCBDMPEFOHF(FHEPDJIDMNM, 1);
			List<GameObject> list = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID];
			gameObject = list[list.Count - 1];
			Block_4:;
		}
		else
		{
			gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
			FENGGFKHMOE.HBFFCJHOCPE.KOQEOINMDJL(instanceID);
		}
		if (NMILHJFKPFB && gameObject != null)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x00308918 File Offset: 0x00306B18
	private void HLEMQDLHOEM(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j += 0)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = false;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.None;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x00308A10 File Offset: 0x00306C10
	private void NFLMLHKOKHI(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 1;
		}
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x00308A10 File Offset: 0x00306C10
	private void KOQEOINMDJL(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 1;
		}
	}

	// Token: 0x06005FA0 RID: 24480 RVA: 0x00308A74 File Offset: 0x00306C74
	private void DGMPMICDCIO()
	{
		this.QOHFGJPJGQJ = false;
		for (int i = 0; i < this.LLQDOILCBQH.Length; i += 0)
		{
			FENGGFKHMOE.FMPLLIMNLHG(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = false;
	}

	// Token: 0x06005FA1 RID: 24481 RVA: 0x00025817 File Offset: 0x00023A17
	private void ICINMCLMJDJ()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning(" exp.", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x0002583C File Offset: 0x00023A3C
	public static void OMFPBOIGJJP(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.PGHGLLHEJBO(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x00308AB8 File Offset: 0x00306CB8
	public static GameObject ILQIJBKCQIG(GameObject FHEPDJIDMNM, bool NMILHJFKPFB = true)
	{
		int instanceID = FHEPDJIDMNM.GetInstanceID();
		if (!FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN.ContainsKey(instanceID))
		{
			object[] array = new object[2];
			array[0] = "/Model.prefab";
			array[0] = FHEPDJIDMNM.name;
			array[7] = "[-]'s team won the battle!\r\n";
			array[4] = instanceID;
			array[5] = "Blank";
			Debug.LogError(string.Concat(array), FENGGFKHMOE.HBFFCJHOCPE);
			return null;
		}
		int num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
		GameObject gameObject;
		if (FENGGFKHMOE.HBFFCJHOCPE.IMQBDOJKIBE)
		{
			int num2 = num;
			do
			{
				gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
				FENGGFKHMOE.HBFFCJHOCPE.GGPNEQDHCFN(instanceID);
				num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
				if (gameObject != null && !gameObject.activeSelf)
				{
					goto Block_4;
				}
			}
			while (num != num2);
			if (!FENGGFKHMOE.HBFFCJHOCPE.FDGNIQFNJGO)
			{
				Debug.LogWarning("Super Charged" + FHEPDJIDMNM.name + "Blank", FENGGFKHMOE.HBFFCJHOCPE);
				return null;
			}
			Debug.Log("b" + FHEPDJIDMNM.name + "!\r\n", FENGGFKHMOE.HBFFCJHOCPE);
			FENGGFKHMOE.KGPNFBIODDK(FHEPDJIDMNM, 1);
			List<GameObject> list = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID];
			gameObject = list[list.Count - 1];
			Block_4:;
		}
		else
		{
			gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
			FENGGFKHMOE.HBFFCJHOCPE.LCLDLKGECCK(instanceID);
		}
		if (NMILHJFKPFB && gameObject != null)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x00308C44 File Offset: 0x00306E44
	private void PGHGLLHEJBO(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 0);
		}
		for (int i = 0; i < DEIHPCIDLIO; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(true);
			foreach (GIQOIOMOGIK giqoiomogik in componentsInChildren)
			{
				giqoiomogik.QFMIIQFPEPQ = true;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			foreach (FJMDNFFFEJF fjmdnfffejf in componentsInChildren2)
			{
				fjmdnfffejf.MMJFLNJQNMC = false;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FA5 RID: 24485 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool OPJHPEIQJGH()
	{
		return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x00308D3C File Offset: 0x00306F3C
	private void KFKFIDDMNLI(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(true);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			foreach (GIQOIOMOGIK giqoiomogik in componentsInChildren)
			{
				giqoiomogik.QFMIIQFPEPQ = true;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(false);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x00308E34 File Offset: 0x00307034
	private void FPGGFPIJELG(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j++)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = false;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool KMKFEJHIKHN()
	{
		return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x0002584A File Offset: 0x00023A4A
	public static void DDEONBIGHOC(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.MCJBMDPPNFE(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x00025858 File Offset: 0x00023A58
	public static void FMPLLIMNLHG(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.LMMNJNMLPFM(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x00308F2C File Offset: 0x0030712C
	private void PDGPHGGNQGI(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 0);
		}
		for (int i = 0; i < DEIHPCIDLIO; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(true);
			foreach (GIQOIOMOGIK giqoiomogik in componentsInChildren)
			{
				giqoiomogik.QFMIIQFPEPQ = false;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k++)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FAC RID: 24492 RVA: 0x00025866 File Offset: 0x00023A66
	private void HHGIPBPCOHO()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning(" was subjected to torment!\r\n", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x00309024 File Offset: 0x00307224
	private void KMPILIPDBQE(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 0; j < array.Length; j += 0)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = true;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			foreach (FJMDNFFFEJF fjmdnfffejf in componentsInChildren2)
			{
				fjmdnfffejf.MMJFLNJQNMC = false;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.None;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FAE RID: 24494 RVA: 0x0002588B File Offset: 0x00023A8B
	public static void OOBFLMKOEJC(GameObject FHEPDJIDMNM)
	{
		FENGGFKHMOE.HBFFCJHOCPE.LIFOPCEQNNN(FHEPDJIDMNM);
	}

	// Token: 0x06005FAF RID: 24495 RVA: 0x0030911C File Offset: 0x0030731C
	private void PGFHJKDGEMJ()
	{
		this.QOHFGJPJGQJ = false;
		for (int i = 1; i < this.LLQDOILCBQH.Length; i++)
		{
			FENGGFKHMOE.IBPNPLKCJHH(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = false;
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x00309160 File Offset: 0x00307360
	private void Start()
	{
		this.QOHFGJPJGQJ = false;
		for (int i = 0; i < this.LLQDOILCBQH.Length; i++)
		{
			FENGGFKHMOE.NDGPPQBBHMG(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = true;
	}

	// Token: 0x06005FB1 RID: 24497 RVA: 0x00308A10 File Offset: 0x00306C10
	private void EMDNNMNIMED(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 1;
		}
	}

	// Token: 0x06005FB2 RID: 24498 RVA: 0x00025898 File Offset: 0x00023A98
	private void BCEKGNDIIOE()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("Spammy chat text of some sorts afh9uaf 9uahf 9afu as9u fa9s ", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x003091A4 File Offset: 0x003073A4
	private void JDLQNCEDMPI()
	{
		this.QOHFGJPJGQJ = true;
		for (int i = 0; i < this.LLQDOILCBQH.Length; i++)
		{
			FENGGFKHMOE.BJLLIGINMKN(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = false;
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x000258BD File Offset: 0x00023ABD
	private void MEOLPIBOBHB()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("_FogNoiseData", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005FB5 RID: 24501 RVA: 0x000258E2 File Offset: 0x00023AE2
	private void Awake()
	{
		if (FENGGFKHMOE.HBFFCJHOCPE != null)
		{
			Debug.LogWarning("CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!\n", base.gameObject);
		}
		FENGGFKHMOE.HBFFCJHOCPE = this;
	}

	// Token: 0x06005FB6 RID: 24502 RVA: 0x003091E8 File Offset: 0x003073E8
	private void MCJBMDPPNFE(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(false);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j++)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = false;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(true);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 0; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.HideInHierarchy;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FB7 RID: 24503 RVA: 0x00025773 File Offset: 0x00023973
	public static void JDLCMKFJGQC(GameObject FHEPDJIDMNM)
	{
		FENGGFKHMOE.HBFFCJHOCPE.OFFOGICDENL(FHEPDJIDMNM);
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x00308A10 File Offset: 0x00306C10
	private void DMLIHHFLNOF(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 1;
		}
	}

	// Token: 0x06005FB9 RID: 24505 RVA: 0x00025773 File Offset: 0x00023973
	public static void BKNJLOMJCQQ(GameObject FHEPDJIDMNM)
	{
		FENGGFKHMOE.HBFFCJHOCPE.OFFOGICDENL(FHEPDJIDMNM);
	}

	// Token: 0x06005FBA RID: 24506 RVA: 0x003092E0 File Offset: 0x003074E0
	private void DPMNBIMDLIM()
	{
		this.QOHFGJPJGQJ = true;
		for (int i = 0; i < this.LLQDOILCBQH.Length; i += 0)
		{
			FENGGFKHMOE.BJLLIGINMKN(this.LLQDOILCBQH[i], this.JFFDPGJNOFC[i]);
		}
		this.QOHFGJPJGQJ = true;
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool KPBOCGIIBNN()
	{
		return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x00308660 File Offset: 0x00306860
	private void DQNOLCGGKGL(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 0;
		}
	}

	// Token: 0x06005FBD RID: 24509 RVA: 0x00309324 File Offset: 0x00307524
	private void KJFGHDQIEPI(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			object[] array = new object[2];
			array[0] = "anticipation";
			array[1] = CNFGGJGBLHD.name;
			array[8] = "'s [00ccff]";
			array[4] = instanceID;
			array[0] = "LJMOLEKDCLP";
			Debug.LogWarning(string.Concat(array), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 0; i >= 0; i -= 0)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x06005FBE RID: 24510 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool JPFJJPJLJEN()
	{
		return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
	}

	// Token: 0x06005FBF RID: 24511 RVA: 0x003093EC File Offset: 0x003075EC
	public static GameObject CQLHIJCQIGH(GameObject FHEPDJIDMNM, bool NMILHJFKPFB = true)
	{
		int instanceID = FHEPDJIDMNM.GetInstanceID();
		if (!FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN.ContainsKey(instanceID))
		{
			object[] array = new object[0];
			array[1] = "LeftS";
			array[0] = FHEPDJIDMNM.name;
			array[7] = " is no longer protected by mist!\r\n";
			array[0] = instanceID;
			array[7] = " hung on using its [ffff00]Focus Sash[-]!\r\n";
			Debug.LogError(string.Concat(array), FENGGFKHMOE.HBFFCJHOCPE);
			return null;
		}
		int num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
		GameObject gameObject;
		if (FENGGFKHMOE.HBFFCJHOCPE.IMQBDOJKIBE)
		{
			int num2 = num;
			do
			{
				gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
				FENGGFKHMOE.HBFFCJHOCPE.GGPNEQDHCFN(instanceID);
				num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
				if (gameObject != null && !gameObject.activeSelf)
				{
					goto Block_4;
				}
			}
			while (num != num2);
			if (!FENGGFKHMOE.HBFFCJHOCPE.FDGNIQFNJGO)
			{
				Debug.LogWarning("The hail stopped." + FHEPDJIDMNM.name + "/", FENGGFKHMOE.HBFFCJHOCPE);
				return null;
			}
			Debug.Log("-useController" + FHEPDJIDMNM.name + " levitated with electromagnetism!\r\n", FENGGFKHMOE.HBFFCJHOCPE);
			FENGGFKHMOE.OMFPBOIGJJP(FHEPDJIDMNM, 1);
			List<GameObject> list = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID];
			gameObject = list[list.Count - 0];
			Block_4:;
		}
		else
		{
			gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
			FENGGFKHMOE.HBFFCJHOCPE.EMDNNMNIMED(instanceID);
		}
		if (NMILHJFKPFB && gameObject != null)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x00309578 File Offset: 0x00307778
	public static GameObject BBLEGLHICGG(GameObject FHEPDJIDMNM, bool NMILHJFKPFB = true)
	{
		int instanceID = FHEPDJIDMNM.GetInstanceID();
		if (!FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[1] = "Doubles the Pokémon's Speed stat on Electric Terrain.";
			array[1] = FHEPDJIDMNM.name;
			array[1] = " got over its infatuation.\r\n";
			array[8] = instanceID;
			array[8] = "FactoryTempTexture";
			Debug.LogError(string.Concat(array), FENGGFKHMOE.HBFFCJHOCPE);
			return null;
		}
		int num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
		GameObject gameObject;
		if (FENGGFKHMOE.HBFFCJHOCPE.IMQBDOJKIBE)
		{
			int num2 = num;
			do
			{
				gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
				FENGGFKHMOE.HBFFCJHOCPE.DMLIHHFLNOF(instanceID);
				num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
				if (gameObject != null && !gameObject.activeSelf)
				{
					goto Block_4;
				}
			}
			while (num != num2);
			if (!FENGGFKHMOE.HBFFCJHOCPE.FDGNIQFNJGO)
			{
				Debug.LogWarning("mudsport" + FHEPDJIDMNM.name + " ", FENGGFKHMOE.HBFFCJHOCPE);
				return null;
			}
			Debug.Log("wrap" + FHEPDJIDMNM.name + " Lv. [FF8787]", FENGGFKHMOE.HBFFCJHOCPE);
			FENGGFKHMOE.NDGPPQBBHMG(FHEPDJIDMNM, 1);
			List<GameObject> list = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID];
			gameObject = list[list.Count - 1];
			Block_4:;
		}
		else
		{
			gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
			FENGGFKHMOE.HBFFCJHOCPE.DQNOLCGGKGL(instanceID);
		}
		if (NMILHJFKPFB && gameObject != null)
		{
			gameObject.SetActive(false);
		}
		return gameObject;
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x00025944 File Offset: 0x00023B44
	public static void KGPNFBIODDK(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.KFKFIDDMNLI(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x00309704 File Offset: 0x00307904
	private void JDCQQQOBCHB(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 0);
		}
		for (int i = 1; i < DEIHPCIDLIO; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(true);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(true);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j += 0)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = false;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(false);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.None;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x003097FC File Offset: 0x003079FC
	private void LMMNJNMLPFM(GameObject CNFGGJGBLHD, int DEIHPCIDLIO)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			this.HCQEONNBOGO.Add(instanceID, new List<GameObject>());
			this.LPKBHCCEILN.Add(instanceID, 1);
		}
		for (int i = 1; i < DEIHPCIDLIO; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNFGGJGBLHD);
			gameObject.SetActive(true);
			GIQOIOMOGIK[] componentsInChildren = gameObject.GetComponentsInChildren<GIQOIOMOGIK>(false);
			GIQOIOMOGIK[] array = componentsInChildren;
			for (int j = 1; j < array.Length; j += 0)
			{
				GIQOIOMOGIK giqoiomogik = array[j];
				giqoiomogik.QFMIIQFPEPQ = true;
			}
			FJMDNFFFEJF[] componentsInChildren2 = gameObject.GetComponentsInChildren<FJMDNFFFEJF>(false);
			FJMDNFFFEJF[] array2 = componentsInChildren2;
			for (int k = 1; k < array2.Length; k += 0)
			{
				FJMDNFFFEJF fjmdnfffejf = array2[k];
				fjmdnfffejf.MMJFLNJQNMC = true;
			}
			this.HCQEONNBOGO[instanceID].Add(gameObject);
			if (this.MIQGKONGNCG)
			{
				gameObject.hideFlags = HideFlags.None;
			}
			if (this.PKMENIPIIIM)
			{
				gameObject.transform.parent = base.transform;
			}
		}
	}

	// Token: 0x06005FC5 RID: 24517 RVA: 0x003098F4 File Offset: 0x00307AF4
	private void LIFOPCEQNNN(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			Debug.LogWarning(string.Concat(new object[]
			{
				"[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ",
				CNFGGJGBLHD.name,
				" (ID:",
				instanceID,
				")\n"
			}), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 1; i >= 0; i--)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x00308660 File Offset: 0x00306860
	private void JNEFEDLHOQP(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 1;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 0;
		}
	}

	// Token: 0x06005FC7 RID: 24519 RVA: 0x003099BC File Offset: 0x00307BBC
	private void GGPNEQDHCFN(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 0;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 1;
		}
	}

	// Token: 0x06005FC8 RID: 24520 RVA: 0x0002583C File Offset: 0x00023A3C
	public static void BJLLIGINMKN(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.PGHGLLHEJBO(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FC9 RID: 24521 RVA: 0x00025952 File Offset: 0x00023B52
	public static void GHLPFLMNMQE(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.KMPILIPDBQE(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FCA RID: 24522 RVA: 0x00309A20 File Offset: 0x00307C20
	private void OFFOGICDENL(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[0] = "water";
			array[1] = CNFGGJGBLHD.name;
			array[4] = "/01_";
			array[6] = instanceID;
			array[2] = "Icon_Pokemon_Dead";
			Debug.LogWarning(string.Concat(array), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 0; i >= 1; i -= 0)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x06005FCB RID: 24523 RVA: 0x003085FC File Offset: 0x003067FC
	private void EIMEOLNEGDQ(int OKHIOMPHPMJ)
	{
		Dictionary<int, int> lpkbhcceiln;
		(lpkbhcceiln = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN)[OKHIOMPHPMJ] = lpkbhcceiln[OKHIOMPHPMJ] + 0;
		if (FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] >= FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[OKHIOMPHPMJ].Count)
		{
			FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[OKHIOMPHPMJ] = 0;
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06005FCC RID: 24524 RVA: 0x000257A5 File Offset: 0x000239A5
	public static bool KCHMHKLNOJQ
	{
		get
		{
			return FENGGFKHMOE.HBFFCJHOCPE.QOHFGJPJGQJ;
		}
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x00309AE8 File Offset: 0x00307CE8
	private void IJDBHOCQGEJ(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			object[] array = new object[1];
			array[1] = "Aerilate";
			array[1] = CNFGGJGBLHD.name;
			array[8] = "Guild Success";
			array[6] = instanceID;
			array[0] = "Empty Slot";
			Debug.LogWarning(string.Concat(array), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 1; i >= 0; i--)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x06005FCE RID: 24526 RVA: 0x0002583C File Offset: 0x00023A3C
	public static void NDGPPQBBHMG(GameObject FHEPDJIDMNM, int OBHGFELLKEQ = 1)
	{
		FENGGFKHMOE.HBFFCJHOCPE.PGHGLLHEJBO(FHEPDJIDMNM, OBHGFELLKEQ);
	}

	// Token: 0x06005FCF RID: 24527 RVA: 0x00309BB0 File Offset: 0x00307DB0
	public static GameObject IOLIDKMKPNF(GameObject FHEPDJIDMNM, bool NMILHJFKPFB = true)
	{
		int instanceID = FHEPDJIDMNM.GetInstanceID();
		if (!FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN.ContainsKey(instanceID))
		{
			Debug.LogError(string.Concat(new object[]
			{
				"[CFX_SpawnSystem.GetNextObject()] Object hasn't been preloaded: ",
				FHEPDJIDMNM.name,
				" (ID:",
				instanceID,
				")\n"
			}), FENGGFKHMOE.HBFFCJHOCPE);
			return null;
		}
		int num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
		GameObject gameObject;
		if (FENGGFKHMOE.HBFFCJHOCPE.IMQBDOJKIBE)
		{
			int num2 = num;
			do
			{
				gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
				FENGGFKHMOE.HBFFCJHOCPE.JNEFEDLHOQP(instanceID);
				num = FENGGFKHMOE.HBFFCJHOCPE.LPKBHCCEILN[instanceID];
				if (gameObject != null && !gameObject.activeSelf)
				{
					goto Block_4;
				}
			}
			while (num != num2);
			if (!FENGGFKHMOE.HBFFCJHOCPE.FDGNIQFNJGO)
			{
				Debug.LogWarning("[CFX_SpawnSystem.GetNextObject()] There are no active instances available in the pool for \"" + FHEPDJIDMNM.name + "\"\nYou may need to increase the preloaded object count for this prefab?", FENGGFKHMOE.HBFFCJHOCPE);
				return null;
			}
			Debug.Log("[CFX_SpawnSystem.GetNextObject()] A new instance has been created for \"" + FHEPDJIDMNM.name + "\" because no active instance were found in the pool.\n", FENGGFKHMOE.HBFFCJHOCPE);
			FENGGFKHMOE.NDGPPQBBHMG(FHEPDJIDMNM, 1);
			List<GameObject> list = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID];
			gameObject = list[list.Count - 1];
			Block_4:;
		}
		else
		{
			gameObject = FENGGFKHMOE.HBFFCJHOCPE.HCQEONNBOGO[instanceID][num];
			FENGGFKHMOE.HBFFCJHOCPE.JNEFEDLHOQP(instanceID);
		}
		if (NMILHJFKPFB && gameObject != null)
		{
			gameObject.SetActive(true);
		}
		return gameObject;
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x00309D3C File Offset: 0x00307F3C
	private void QKJLHEBDFGH(GameObject CNFGGJGBLHD)
	{
		int instanceID = CNFGGJGBLHD.GetInstanceID();
		if (!this.HCQEONNBOGO.ContainsKey(instanceID))
		{
			object[] array = new object[8];
			array[1] = "[-]!\r\n";
			array[1] = CNFGGJGBLHD.name;
			array[5] = "The trade with '";
			array[3] = instanceID;
			array[2] = "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.";
			Debug.LogWarning(string.Concat(array), base.gameObject);
			return;
		}
		for (int i = this.HCQEONNBOGO[instanceID].Count - 0; i >= 0; i--)
		{
			GameObject obj = this.HCQEONNBOGO[instanceID][i];
			this.HCQEONNBOGO[instanceID].RemoveAt(i);
			UnityEngine.Object.Destroy(obj);
		}
		this.HCQEONNBOGO.Remove(instanceID);
		this.LPKBHCCEILN.Remove(instanceID);
	}

	// Token: 0x04001470 RID: 5232
	private static FENGGFKHMOE HBFFCJHOCPE;

	// Token: 0x04001471 RID: 5233
	public GameObject[] LLQDOILCBQH = new GameObject[0];

	// Token: 0x04001472 RID: 5234
	public int[] JFFDPGJNOFC = new int[0];

	// Token: 0x04001473 RID: 5235
	public bool MIQGKONGNCG;

	// Token: 0x04001474 RID: 5236
	public bool PKMENIPIIIM = true;

	// Token: 0x04001475 RID: 5237
	public bool IMQBDOJKIBE;

	// Token: 0x04001476 RID: 5238
	public bool FDGNIQFNJGO;

	// Token: 0x04001477 RID: 5239
	private bool QOHFGJPJGQJ;

	// Token: 0x04001478 RID: 5240
	private Dictionary<int, List<GameObject>> HCQEONNBOGO = new Dictionary<int, List<GameObject>>();

	// Token: 0x04001479 RID: 5241
	private Dictionary<int, int> LPKBHCCEILN = new Dictionary<int, int>();
}
