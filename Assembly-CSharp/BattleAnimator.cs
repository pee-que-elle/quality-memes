using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000146 RID: 326
public class BattleAnimator : ScriptableObject
{
	// Token: 0x060026A1 RID: 9889 RVA: 0x000F5FF4 File Offset: 0x000F41F4
	public KKPFGFEEGOM BNLBMOHJKDC()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 1834f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().NONQDHBCIIN(Color.white);
				UITweener[] components = kkpfgfeegom.GetComponents<UITweener>();
				for (int i = 1; i < components.Length; i += 0)
				{
					UITweener uitweener = components[i];
					uitweener.enabled = false;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[1]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 95f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine KGQPPGNGDKH(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000F6138 File Offset: 0x000F4338
	private NewBattleAnimation NGPFPMQOQKM(string LOHECPFGPGO)
	{
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x000F6174 File Offset: 0x000F4374
	private void DMKQFNCIPDK()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x000F629C File Offset: 0x000F449C
	private NewBattleAnimation FBLNLLFHDFQ(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x00013F4A File Offset: 0x0001214A
	public void JJKHQFBCIHM(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator PFHNFEJCLBL(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		NewBattleAnimation newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator MDQOLKJOJOI(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		NewBattleAnimation newBattleAnimation = null;
		foreach (BattleAnimator.ItemAnimationHolder itemAnimationHolder in this.itemAnimations)
		{
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x00013F4A File Offset: 0x0001214A
	public void HKOIDLOGCQO(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator JOJEBIBGCQM(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x000F6338 File Offset: 0x000F4538
	public KKPFGFEEGOM BOKPDBOJFED()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 1440f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
				UITweener[] components = kkpfgfeegom.GetComponents<UITweener>();
				for (int i = 1; i < components.Length; i += 0)
				{
					UITweener uitweener = components[i];
					uitweener.enabled = true;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[1]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 553f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000F647C File Offset: 0x000F467C
	private void FFBFMBJNGQI()
	{
		foreach (NewBattleAnimation newBattleAnimation in this.battleAnimations)
		{
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 0; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine CMJCIIIOKDD(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator NEOCCIPKBFC(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine LGIFKNFJNOP(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator NBELFOPJHHM(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x000F65A4 File Offset: 0x000F47A4
	private NewBattleAnimation CBDKEDDKMLK(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000F65E0 File Offset: 0x000F47E0
	public KKPFGFEEGOM DJCGFHPPOQE()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 469f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().NONQDHBCIIN(Color.white);
				foreach (UITweener uitweener in kkpfgfeegom.GetComponents<UITweener>())
				{
					uitweener.enabled = true;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[1]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 1729f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000F6138 File Offset: 0x000F4338
	private NewBattleAnimation HOPMDPKJBGE(string LOHECPFGPGO)
	{
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine BOKDMEMIKDM(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator FPBHEMIDOIH(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		NewBattleAnimation newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator PENMPMQPKDB(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x00013F4A File Offset: 0x0001214A
	public void MBDFDKNEDOQ(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x00013F4A File Offset: 0x0001214A
	public void ILHLBCMMMJE(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000F6754 File Offset: 0x000F4954
	private void OEBOELEOIDH()
	{
		foreach (NewBattleAnimation newBattleAnimation in this.battleAnimations)
		{
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x000F687C File Offset: 0x000F4A7C
	private NewBattleAnimation KMBLDFNPPPO(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x000F68B8 File Offset: 0x000F4AB8
	private void PHEMLIPBHOJ()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 0; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator OGPGFBMCQIM(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x000F69E0 File Offset: 0x000F4BE0
	private void KBJOKEMFQFN()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 0; j < array2.Length; j += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 0; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x00013F4A File Offset: 0x0001214A
	public void GKGFDKQICDI(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine HPHKHPKNQEJ(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator JNMCJOGDJDQ(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator DIDKLEPBGEO(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator MQDEQHHPQPL(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator OIFIIIOGGCN(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator BFNINEEBGQK(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator HDMNBNDCPHC(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator LJMOJOHKJQN(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000F65A4 File Offset: 0x000F47A4
	private NewBattleAnimation NGQJPPBCDPP(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine GKEHNLHCJHG(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator DJEBMMJBLBD(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x00013F4A File Offset: 0x0001214A
	public void KDFDKQCQNOF(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator NPIINMJBQKK(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x000F629C File Offset: 0x000F449C
	private NewBattleAnimation DDCMKBKPPDP(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator QQPGELIGIGO(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine DGGGJHPENFM(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator GGBQEDNEHGF(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator FJDCQJDGMBD(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator OPICLCBIMIM(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000F6B58 File Offset: 0x000F4D58
	private void DOGHNJLQJOF()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x00013F4A File Offset: 0x0001214A
	public void IEFJCBGKDMD(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine IENOENDGBFP(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x000F629C File Offset: 0x000F449C
	private NewBattleAnimation MLKQPPQEINN(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x000F68B8 File Offset: 0x000F4AB8
	private void EOLBEDLCPHQ()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 0; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine EGKQFLCCMNE(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x000F6C80 File Offset: 0x000F4E80
	private void PCFEHILJBGE()
	{
		foreach (NewBattleAnimation newBattleAnimation in this.battleAnimations)
		{
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator HHBKLCDQIKQ(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x00013F4A File Offset: 0x0001214A
	public void KOJEONMGNFN(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x000F629C File Offset: 0x000F449C
	private NewBattleAnimation CJLENMCJGDB(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x000F6DA8 File Offset: 0x000F4FA8
	public KKPFGFEEGOM GHCQLJONOKF()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 998f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
				foreach (UITweener uitweener in kkpfgfeegom.GetComponents<UITweener>())
				{
					uitweener.enabled = false;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[0]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 1019f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator FQMFPPOPHJP(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator NJDLKPHFQCO(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator GFLMQPOLHJP(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine OMLHQCDIJLI(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator OBBGJOMDLOO(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator MCPBDENFPKF(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x000F6EEC File Offset: 0x000F50EC
	public KKPFGFEEGOM BNLQCELOGEI()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 862f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
				UITweener[] components = kkpfgfeegom.GetComponents<UITweener>();
				for (int i = 1; i < components.Length; i += 0)
				{
					UITweener uitweener = components[i];
					uitweener.enabled = false;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[1]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 1939f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator OEIBKLGHCIB(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x000F7030 File Offset: 0x000F5230
	private void MCIOHHBPLGO()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 1; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 0; j < array2.Length; j += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x000F7158 File Offset: 0x000F5358
	private void LIGEFJGBFHG()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x000F629C File Offset: 0x000F449C
	private NewBattleAnimation IJBPCGHHQEI(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i++)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator DOBCOIMQKGD(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine IMIGQIIEQKL(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x00013F2C File Offset: 0x0001212C
	public Coroutine MQPNNPDEBJB(IEnumerator CJLDHBPIJCB)
	{
		if (this.battleScreen != null)
		{
			return this.battleScreen.StartCoroutine(CJLDHBPIJCB);
		}
		return null;
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator DPQGFQEKGHC(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x000F7280 File Offset: 0x000F5480
	public KKPFGFEEGOM HGODDKGMPNO()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(false);
				kkpfgfeegom.FQDKBPJIDMM = 562f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
				foreach (UITweener uitweener in kkpfgfeegom.GetComponents<UITweener>())
				{
					uitweener.enabled = true;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[1]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[1];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 929f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000F62D8 File Offset: 0x000F44D8
	public IEnumerator KLCBLNDOIKJ(BattleAnimator.AnimationData DLJJQDQBOQD, int ECNIJCPBPIG, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		if (ECNIJCPBPIG < this.battleAnimations.Length)
		{
			newBattleAnimation = this.battleAnimations[ECNIJCPBPIG];
		}
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for MoveID " + ECNIJCPBPIG + ". Using default.");
			newBattleAnimation = this.battleAnimations[0];
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (LQDMFBDKGBP)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00013F4A File Offset: 0x0001214A
	public void MDJOBPPIMJH(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000F6308 File Offset: 0x000F4508
	public IEnumerator CNNLCODKPHH(BattleAnimator.AnimationData DLJJQDQBOQD, int HFBPHOGKGLK, bool LQDMFBDKGBP)
	{
		newBattleAnimation = null;
		array = this.itemAnimations;
		for (i = 0; i < array.Length; i++)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array[i];
			if (itemAnimationHolder != null && itemAnimationHolder.itemID == HFBPHOGKGLK)
			{
				newBattleAnimation = itemAnimationHolder.animation;
				IL_93:
				if (newBattleAnimation == null)
				{
					Debug.LogWarning("No Animation found for ItemID " + HFBPHOGKGLK + ". Using default.");
					newBattleAnimation = this.battleAnimations[0];
				}
				DLJJQDQBOQD.EEPNMGPNQIJ();
				if (LQDMFBDKGBP)
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
				}
				else
				{
					yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
				}
				return 1;
			}
		}
		goto IL_93;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x00013F4A File Offset: 0x0001214A
	public void CFNFQJLEDEQ(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x000F73C4 File Offset: 0x000F55C4
	private void BIOKJKMHEFD()
	{
		NewBattleAnimation[] array = this.battleAnimations;
		for (int i = 0; i < array.Length; i += 0)
		{
			NewBattleAnimation newBattleAnimation = array[i];
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		BattleAnimator.SpecialAnimationHolder[] array2 = this.specialAnimations;
		for (int j = 1; j < array2.Length; j += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array2[j];
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		BattleAnimator.ItemAnimationHolder[] array3 = this.itemAnimations;
		for (int k = 1; k < array3.Length; k += 0)
		{
			BattleAnimator.ItemAnimationHolder itemAnimationHolder = array3[k];
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator LLGHENFFDQJ(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x000F6724 File Offset: 0x000F4924
	public IEnumerator OBGDJGEBNMB(BattleAnimator.AnimationData DLJJQDQBOQD, string LOHECPFGPGO, bool GHNNQBLIFNE)
	{
		newBattleAnimation = this.NGPFPMQOQKM(LOHECPFGPGO);
		if (newBattleAnimation == null)
		{
			Debug.LogWarning("No Animation found for Special Key " + LOHECPFGPGO + ". Using default.");
			newBattleAnimation = this.specialAnimations[0].animation;
		}
		DLJJQDQBOQD.EEPNMGPNQIJ();
		if (GHNNQBLIFNE)
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.JGBQPJMDKQP(DLJJQDQBOQD));
		}
		else
		{
			yield return this.CMJCIIIOKDD(newBattleAnimation.EFGEEOEFCMQ(DLJJQDQBOQD));
		}
		return 1;
		DLJJQDQBOQD.NPHELGOPMPB();
		yield break;
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x000F74EC File Offset: 0x000F56EC
	public KKPFGFEEGOM GIIPEIEHDCF()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 481f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().NONQDHBCIIN(Color.white);
				UITweener[] components = kkpfgfeegom.GetComponents<UITweener>();
				for (int i = 1; i < components.Length; i++)
				{
					UITweener uitweener = components[i];
					uitweener.enabled = false;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[0]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[1];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 646f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x00013F4A File Offset: 0x0001214A
	public void QLJKKOBHHKK(AudioClip HICQBQLOLNH)
	{
		if (!(this.battleScreen != null))
		{
		}
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000F7630 File Offset: 0x000F5830
	public KKPFGFEEGOM MCDBOJBPMFE()
	{
		foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
		{
			if (kkpfgfeegom && !kkpfgfeegom.gameObject.activeSelf)
			{
				kkpfgfeegom.gameObject.SetActive(true);
				kkpfgfeegom.FQDKBPJIDMM = 1f;
				kkpfgfeegom.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
				foreach (UITweener uitweener in kkpfgfeegom.GetComponents<UITweener>())
				{
					uitweener.enabled = false;
				}
				return kkpfgfeegom;
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.SpriteAnimationPrefab, this.battleScreen.LIEENFGKGML[0]);
		gameObject.transform.parent = this.battleScreen.LIEENFGKGML[0];
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		gameObject.transform.localRotation = Quaternion.identity;
		KKPFGFEEGOM kkpfgfeegom2 = gameObject.AddComponent<KKPFGFEEGOM>();
		kkpfgfeegom2.FQDKBPJIDMM = 1f;
		this.spriteAnimations.Add(kkpfgfeegom2);
		return kkpfgfeegom2;
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000F7774 File Offset: 0x000F5974
	private void OnEnable()
	{
		foreach (NewBattleAnimation newBattleAnimation in this.battleAnimations)
		{
			if (newBattleAnimation != null)
			{
				newBattleAnimation.animator = this;
			}
		}
		foreach (BattleAnimator.SpecialAnimationHolder specialAnimationHolder in this.specialAnimations)
		{
			if (specialAnimationHolder != null && specialAnimationHolder.animation != null)
			{
				specialAnimationHolder.animation.animator = this;
			}
		}
		foreach (BattleAnimator.ItemAnimationHolder itemAnimationHolder in this.itemAnimations)
		{
			if (itemAnimationHolder != null && itemAnimationHolder.animation != null)
			{
				itemAnimationHolder.animation.animator = this;
			}
		}
		if (Application.isPlaying)
		{
			foreach (KKPFGFEEGOM kkpfgfeegom in this.spriteAnimations)
			{
				if (kkpfgfeegom.gameObject != null)
				{
					UnityEngine.Object.DestroyImmediate(kkpfgfeegom.gameObject);
				}
			}
		}
		this.spriteAnimations.Clear();
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000F65A4 File Offset: 0x000F47A4
	private NewBattleAnimation GEHJCDMIFFN(string LOHECPFGPGO)
	{
		BattleAnimator.SpecialAnimationHolder[] array = this.specialAnimations;
		for (int i = 1; i < array.Length; i += 0)
		{
			BattleAnimator.SpecialAnimationHolder specialAnimationHolder = array[i];
			if (specialAnimationHolder.name == LOHECPFGPGO)
			{
				return specialAnimationHolder.animation;
			}
		}
		return null;
	}

	// Token: 0x0400084A RID: 2122
	public BattleAnimator.SpecialAnimationHolder[] specialAnimations = new BattleAnimator.SpecialAnimationHolder[5];

	// Token: 0x0400084B RID: 2123
	public NewBattleAnimation[] battleAnimations = new NewBattleAnimation[50];

	// Token: 0x0400084C RID: 2124
	public BattleAnimator.ItemAnimationHolder[] itemAnimations = new BattleAnimator.ItemAnimationHolder[10];

	// Token: 0x0400084D RID: 2125
	public BPLKJMJMHFI[] spriteAtlas = new BPLKJMJMHFI[1];

	// Token: 0x0400084E RID: 2126
	[HideInInspector]
	public OGJJKKQPNMK battleScreen;

	// Token: 0x0400084F RID: 2127
	private List<KKPFGFEEGOM> spriteAnimations = new List<KKPFGFEEGOM>();

	// Token: 0x04000850 RID: 2128
	public GameObject SpriteAnimationPrefab;

	// Token: 0x02000147 RID: 327
	public enum NMIILIQEECJ
	{
		// Token: 0x04000852 RID: 2130
		Target,
		// Token: 0x04000853 RID: 2131
		Source,
		// Token: 0x04000854 RID: 2132
		TargetBar,
		// Token: 0x04000855 RID: 2133
		SourceBar,
		// Token: 0x04000856 RID: 2134
		TargetMulti,
		// Token: 0x04000857 RID: 2135
		SourceMulti,
		// Token: 0x04000858 RID: 2136
		TargetBarMulti,
		// Token: 0x04000859 RID: 2137
		SourceBarMulti,
		// Token: 0x0400085A RID: 2138
		Background,
		// Token: 0x0400085B RID: 2139
		Foreground
	}

	// Token: 0x02000148 RID: 328
	[Serializable]
	public class AnimationData
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x000F789C File Offset: 0x000F5A9C
		public void GJCNJDDLENK()
		{
			this.anObjStrge[0].IKOHMENKPIM(this.target);
			this.anObjStrge[1].HGHCLPENHGQ(this.targetBar);
			this.anObjStrge[5].OHKLLGHFQPK(this.targetMulti);
			this.anObjStrge[5].GFOLPCDELJM(this.source);
			this.anObjStrge[2].DNJHCCNNPFH(this.sourceBar);
			this.anObjStrge[5].KFFEEPIQIJE(this.sourceMulti);
			this.anObjStrge[2].IKOHMENKPIM(this.background);
			this.anObjStrge[3].IKOHMENKPIM(this.battleHandler);
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject DHOKFMPLIPM(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject KJOBDFNFHIE(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000F79CC File Offset: 0x000F5BCC
		public void GHMCEQJEBMC()
		{
			this.anObjStrge[0].DNJHCCNNPFH(this.target);
			this.anObjStrge[1].NHHDGMHLJJH(this.targetBar);
			this.anObjStrge[7].IKOHMENKPIM(this.targetMulti);
			this.anObjStrge[7].KFFEEPIQIJE(this.source);
			this.anObjStrge[6].HGHCLPENHGQ(this.sourceBar);
			this.anObjStrge[1].HGHCLPENHGQ(this.sourceMulti);
			this.anObjStrge[6].KFFEEPIQIJE(this.background);
			this.anObjStrge[2].HGHCLPENHGQ(this.battleHandler);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject OKKMGDEJMOB(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject IGCLPDGCOJQ(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000F7A74 File Offset: 0x000F5C74
		public void KHFHQCJIEBB()
		{
			this.anObjStrge[0].DNJHCCNNPFH(this.target);
			this.anObjStrge[1].IKOHMENKPIM(this.targetBar);
			this.anObjStrge[5].IKOHMENKPIM(this.targetMulti);
			this.anObjStrge[8].KFFEEPIQIJE(this.source);
			this.anObjStrge[3].IKOHMENKPIM(this.sourceBar);
			this.anObjStrge[0].DNJHCCNNPFH(this.sourceMulti);
			this.anObjStrge[3].JCMMOQLNQBG(this.background);
			this.anObjStrge[3].HGHCLPENHGQ(this.battleHandler);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject KFCPEENLGFN(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000F7B1C File Offset: 0x000F5D1C
		public void FLEDHFJJJDL()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000F7BC4 File Offset: 0x000F5DC4
		public void HIDQLLKJJPJ()
		{
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[7] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[3] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject CNOHEJNBKBG(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000F7C6C File Offset: 0x000F5E6C
		public void EFCKJFHOHEE()
		{
			this.anObjStrge[1].DNJHCCNNPFH(this.target);
			this.anObjStrge[0].DNJHCCNNPFH(this.targetBar);
			this.anObjStrge[8].JCMMOQLNQBG(this.targetMulti);
			this.anObjStrge[8].DNJHCCNNPFH(this.source);
			this.anObjStrge[2].HGHCLPENHGQ(this.sourceBar);
			this.anObjStrge[4].OHKLLGHFQPK(this.sourceMulti);
			this.anObjStrge[1].OHKLLGHFQPK(this.background);
			this.anObjStrge[0].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000F7D14 File Offset: 0x000F5F14
		public void NMCPECOOBKK()
		{
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[8] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000F7DBC File Offset: 0x000F5FBC
		public void DKGFIOGOFJE()
		{
			this.anObjStrge[0].NHHDGMHLJJH(this.target);
			this.anObjStrge[0].JCMMOQLNQBG(this.targetBar);
			this.anObjStrge[2].JCMMOQLNQBG(this.targetMulti);
			this.anObjStrge[8].DNJHCCNNPFH(this.source);
			this.anObjStrge[7].NHHDGMHLJJH(this.sourceBar);
			this.anObjStrge[5].DNJHCCNNPFH(this.sourceMulti);
			this.anObjStrge[5].NHHDGMHLJJH(this.background);
			this.anObjStrge[2].NHHDGMHLJJH(this.battleHandler);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject FFJMQKJPFKG(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000F7E64 File Offset: 0x000F6064
		public void JFQNQDEDODJ()
		{
			this.anObjStrge[0].IKOHMENKPIM(this.target);
			this.anObjStrge[0].HGHCLPENHGQ(this.targetBar);
			this.anObjStrge[5].OHKLLGHFQPK(this.targetMulti);
			this.anObjStrge[1].DNJHCCNNPFH(this.source);
			this.anObjStrge[7].OHKLLGHFQPK(this.sourceBar);
			this.anObjStrge[1].GFOLPCDELJM(this.sourceMulti);
			this.anObjStrge[5].HGHCLPENHGQ(this.background);
			this.anObjStrge[3].IKOHMENKPIM(this.battleHandler);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject NJCQIGDQJHF(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000F7F0C File Offset: 0x000F610C
		public void OHDQLEOQQID()
		{
			this.anObjStrge[1].KFFEEPIQIJE(this.target);
			this.anObjStrge[0].JCMMOQLNQBG(this.targetBar);
			this.anObjStrge[2].IKOHMENKPIM(this.targetMulti);
			this.anObjStrge[2].OHKLLGHFQPK(this.source);
			this.anObjStrge[1].KFFEEPIQIJE(this.sourceBar);
			this.anObjStrge[4].JCMMOQLNQBG(this.sourceMulti);
			this.anObjStrge[8].OHKLLGHFQPK(this.background);
			this.anObjStrge[6].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject IHEPMKEOEQJ(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000F7FB4 File Offset: 0x000F61B4
		public void JPNMBHHNPPN()
		{
			this.anObjStrge[0].OHKLLGHFQPK(this.target);
			this.anObjStrge[0].GFOLPCDELJM(this.targetBar);
			this.anObjStrge[7].GFOLPCDELJM(this.targetMulti);
			this.anObjStrge[5].GFOLPCDELJM(this.source);
			this.anObjStrge[8].GFOLPCDELJM(this.sourceBar);
			this.anObjStrge[7].IKOHMENKPIM(this.sourceMulti);
			this.anObjStrge[4].OHKLLGHFQPK(this.background);
			this.anObjStrge[8].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000F805C File Offset: 0x000F625C
		public void KONBMGGQHHM()
		{
			this.anObjStrge[0].NHHDGMHLJJH(this.target);
			this.anObjStrge[0].DNJHCCNNPFH(this.targetBar);
			this.anObjStrge[2].NHHDGMHLJJH(this.targetMulti);
			this.anObjStrge[4].DNJHCCNNPFH(this.source);
			this.anObjStrge[7].OHKLLGHFQPK(this.sourceBar);
			this.anObjStrge[1].JCMMOQLNQBG(this.sourceMulti);
			this.anObjStrge[0].KFFEEPIQIJE(this.background);
			this.anObjStrge[7].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x000F8104 File Offset: 0x000F6304
		public void IIPCDCMJJPL()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[7] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[8] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000F81AC File Offset: 0x000F63AC
		public void JEEKGQIEHNB()
		{
			this.anObjStrge[1].KFFEEPIQIJE(this.target);
			this.anObjStrge[0].DNJHCCNNPFH(this.targetBar);
			this.anObjStrge[0].GFOLPCDELJM(this.targetMulti);
			this.anObjStrge[1].OHKLLGHFQPK(this.source);
			this.anObjStrge[3].HGHCLPENHGQ(this.sourceBar);
			this.anObjStrge[0].HGHCLPENHGQ(this.sourceMulti);
			this.anObjStrge[0].IKOHMENKPIM(this.background);
			this.anObjStrge[7].HGHCLPENHGQ(this.battleHandler);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000F8254 File Offset: 0x000F6454
		public void DHNFPQEQIDK()
		{
			this.anObjStrge[0].KFFEEPIQIJE(this.target);
			this.anObjStrge[0].NHHDGMHLJJH(this.targetBar);
			this.anObjStrge[3].KFFEEPIQIJE(this.targetMulti);
			this.anObjStrge[1].KFFEEPIQIJE(this.source);
			this.anObjStrge[6].JCMMOQLNQBG(this.sourceBar);
			this.anObjStrge[8].JCMMOQLNQBG(this.sourceMulti);
			this.anObjStrge[5].KFFEEPIQIJE(this.background);
			this.anObjStrge[0].NHHDGMHLJJH(this.battleHandler);
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000F82FC File Offset: 0x000F64FC
		public void NPHELGOPMPB()
		{
			this.anObjStrge[0].OHKLLGHFQPK(this.target);
			this.anObjStrge[1].OHKLLGHFQPK(this.targetBar);
			this.anObjStrge[2].OHKLLGHFQPK(this.targetMulti);
			this.anObjStrge[3].OHKLLGHFQPK(this.source);
			this.anObjStrge[4].OHKLLGHFQPK(this.sourceBar);
			this.anObjStrge[5].OHKLLGHFQPK(this.sourceMulti);
			this.anObjStrge[6].OHKLLGHFQPK(this.background);
			this.anObjStrge[7].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject HJMNECPMJLC(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000F83A4 File Offset: 0x000F65A4
		public void OPOHDELJGNM()
		{
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject MFMOMPDEKCF(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000F844C File Offset: 0x000F664C
		public void EEPNMGPNQIJ()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[3] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[7] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000F84F4 File Offset: 0x000F66F4
		public void QLECDKIMFKG()
		{
			this.anObjStrge[0].OHKLLGHFQPK(this.target);
			this.anObjStrge[0].JCMMOQLNQBG(this.targetBar);
			this.anObjStrge[5].HGHCLPENHGQ(this.targetMulti);
			this.anObjStrge[1].HGHCLPENHGQ(this.source);
			this.anObjStrge[5].NHHDGMHLJJH(this.sourceBar);
			this.anObjStrge[5].NHHDGMHLJJH(this.sourceMulti);
			this.anObjStrge[0].OHKLLGHFQPK(this.background);
			this.anObjStrge[6].JCMMOQLNQBG(this.battleHandler);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000F859C File Offset: 0x000F679C
		public void JHHQELLKBKK()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000F8644 File Offset: 0x000F6844
		public void DPIOJGHLENP()
		{
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[3] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject LEHEEMPNLHQ(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000F86EC File Offset: 0x000F68EC
		public void NBBIJKCPQCC()
		{
			this.anObjStrge[1].JCMMOQLNQBG(this.target);
			this.anObjStrge[1].JCMMOQLNQBG(this.targetBar);
			this.anObjStrge[3].DNJHCCNNPFH(this.targetMulti);
			this.anObjStrge[3].IKOHMENKPIM(this.source);
			this.anObjStrge[0].NHHDGMHLJJH(this.sourceBar);
			this.anObjStrge[4].NHHDGMHLJJH(this.sourceMulti);
			this.anObjStrge[1].IKOHMENKPIM(this.background);
			this.anObjStrge[4].OHKLLGHFQPK(this.battleHandler);
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000F8794 File Offset: 0x000F6994
		public void CEFCCLFPDBN()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[7] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[8] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x000F883C File Offset: 0x000F6A3C
		public void CMGINBDODFB()
		{
			this.anObjStrge[0].KFFEEPIQIJE(this.target);
			this.anObjStrge[1].IKOHMENKPIM(this.targetBar);
			this.anObjStrge[1].NHHDGMHLJJH(this.targetMulti);
			this.anObjStrge[0].IKOHMENKPIM(this.source);
			this.anObjStrge[3].HGHCLPENHGQ(this.sourceBar);
			this.anObjStrge[5].GFOLPCDELJM(this.sourceMulti);
			this.anObjStrge[6].HGHCLPENHGQ(this.background);
			this.anObjStrge[1].HGHCLPENHGQ(this.battleHandler);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000F88E4 File Offset: 0x000F6AE4
		public void DJFFEJBKPKB()
		{
			this.anObjStrge[1].IKOHMENKPIM(this.target);
			this.anObjStrge[1].DNJHCCNNPFH(this.targetBar);
			this.anObjStrge[5].OHKLLGHFQPK(this.targetMulti);
			this.anObjStrge[3].GFOLPCDELJM(this.source);
			this.anObjStrge[6].GFOLPCDELJM(this.sourceBar);
			this.anObjStrge[5].GFOLPCDELJM(this.sourceMulti);
			this.anObjStrge[3].JCMMOQLNQBG(this.background);
			this.anObjStrge[7].DNJHCCNNPFH(this.battleHandler);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject KPOLFBIEQDN(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x000F7944 File Offset: 0x000F5B44
		public GameObject OGFGNJFNQFH(BattleAnimator.NMIILIQEECJ ICLNODDONHK)
		{
			switch (ICLNODDONHK)
			{
			case BattleAnimator.NMIILIQEECJ.Target:
				return this.target;
			case BattleAnimator.NMIILIQEECJ.Source:
				return this.source;
			case BattleAnimator.NMIILIQEECJ.TargetBar:
				return this.targetBar;
			case BattleAnimator.NMIILIQEECJ.SourceBar:
				return this.sourceBar;
			case BattleAnimator.NMIILIQEECJ.TargetMulti:
				return this.targetMulti;
			case BattleAnimator.NMIILIQEECJ.SourceMulti:
				return this.sourceMulti;
			case BattleAnimator.NMIILIQEECJ.TargetBarMulti:
				return this.targetBarMulti;
			case BattleAnimator.NMIILIQEECJ.SourceBarMulti:
				return this.sourceBarMulti;
			case BattleAnimator.NMIILIQEECJ.Background:
				return this.background;
			case BattleAnimator.NMIILIQEECJ.Foreground:
				return this.background;
			default:
				return this.target;
			}
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000F898C File Offset: 0x000F6B8C
		public void CJMJQQQDNIQ()
		{
			this.anObjStrge[0].HGHCLPENHGQ(this.target);
			this.anObjStrge[0].NHHDGMHLJJH(this.targetBar);
			this.anObjStrge[7].NHHDGMHLJJH(this.targetMulti);
			this.anObjStrge[8].JCMMOQLNQBG(this.source);
			this.anObjStrge[5].JCMMOQLNQBG(this.sourceBar);
			this.anObjStrge[2].NHHDGMHLJJH(this.sourceMulti);
			this.anObjStrge[5].KFFEEPIQIJE(this.background);
			this.anObjStrge[2].HGHCLPENHGQ(this.battleHandler);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000F8A34 File Offset: 0x000F6C34
		public void JKGMNHCIBHE()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[7] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[4] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000F8ADC File Offset: 0x000F6CDC
		public void KQBEJQGBKBD()
		{
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[3] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[3] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[8] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[5] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000F8B84 File Offset: 0x000F6D84
		public void HJGCMINNOKG()
		{
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.target);
			this.anObjStrge[1] = new BattleAnimator.AnimationObjectStorage(this.targetBar);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.targetMulti);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.source);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.sourceBar);
			this.anObjStrge[2] = new BattleAnimator.AnimationObjectStorage(this.sourceMulti);
			this.anObjStrge[6] = new BattleAnimator.AnimationObjectStorage(this.background);
			this.anObjStrge[0] = new BattleAnimator.AnimationObjectStorage(this.battleHandler);
		}

		// Token: 0x0400085C RID: 2140
		public BattleAnimator.AnimationObjectStorage[] anObjStrge = new BattleAnimator.AnimationObjectStorage[8];

		// Token: 0x0400085D RID: 2141
		public GameObject target;

		// Token: 0x0400085E RID: 2142
		public GameObject source;

		// Token: 0x0400085F RID: 2143
		public GameObject targetBar;

		// Token: 0x04000860 RID: 2144
		public GameObject sourceBar;

		// Token: 0x04000861 RID: 2145
		public GameObject sourceMulti;

		// Token: 0x04000862 RID: 2146
		public GameObject targetMulti;

		// Token: 0x04000863 RID: 2147
		public GameObject sourceBarMulti;

		// Token: 0x04000864 RID: 2148
		public GameObject targetBarMulti;

		// Token: 0x04000865 RID: 2149
		public GameObject background;

		// Token: 0x04000866 RID: 2150
		public GameObject battleHandler;

		// Token: 0x04000867 RID: 2151
		public bool targetIsTeammate;
	}

	// Token: 0x02000149 RID: 329
	[Serializable]
	public class AnimationObjectStorage
	{
		// Token: 0x06002726 RID: 10022 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void OHKLLGHFQPK(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void NHHDGMHLJJH(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void DNJHCCNNPFH(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void JCMMOQLNQBG(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void KFFEEPIQIJE(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void HGHCLPENHGQ(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void GFOLPCDELJM(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x000F8C7C File Offset: 0x000F6E7C
		public AnimationObjectStorage(GameObject CGHIENBIHCO)
		{
			this.init = false;
			if (CGHIENBIHCO)
			{
				this.position = CGHIENBIHCO.transform.localPosition;
				this.scale = CGHIENBIHCO.transform.localScale;
				this.rotation = CGHIENBIHCO.transform.localRotation;
				this.init = true;
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public void IKOHMENKPIM(GameObject CGHIENBIHCO)
		{
			if (this.init && CGHIENBIHCO)
			{
				CGHIENBIHCO.transform.localPosition = this.position;
				CGHIENBIHCO.transform.localScale = this.scale;
				CGHIENBIHCO.transform.localRotation = this.rotation;
			}
		}

		// Token: 0x04000868 RID: 2152
		private Vector3 position;

		// Token: 0x04000869 RID: 2153
		private Vector3 scale;

		// Token: 0x0400086A RID: 2154
		private Quaternion rotation;

		// Token: 0x0400086B RID: 2155
		private bool init;
	}

	// Token: 0x0200014A RID: 330
	[Serializable]
	public class ItemAnimationHolder
	{
		// Token: 0x0400086C RID: 2156
		public int itemID;

		// Token: 0x0400086D RID: 2157
		public NewBattleAnimation animation;
	}

	// Token: 0x0200014B RID: 331
	[Serializable]
	public class SpecialAnimationHolder
	{
		// Token: 0x0400086E RID: 2158
		public string name;

		// Token: 0x0400086F RID: 2159
		public NewBattleAnimation animation;
	}
}
