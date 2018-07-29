using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200014F RID: 335
public class NewBattleAnimation : ScriptableObject
{
	// Token: 0x060027AC RID: 10156 RVA: 0x000FA61C File Offset: 0x000F881C
	private IEnumerator MLFIDQCONEF(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Vector3 BDBBEMKFGPI, bool KQBOEOCCQQL, bool BIJEGPCCQKB, bool MHMGKPQEEQN, bool MMPBBFNFICC, bool FKHPMFLQFJP = true)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		Vector3 vector = BDBBEMKFGPI;
		if (KQBOEOCCQQL)
		{
			vector.x = -vector.x;
		}
		if (BIJEGPCCQKB)
		{
			vector.y = -vector.y;
		}
		if (MHMGKPQEEQN)
		{
			vector.z = -vector.z;
		}
		Vector3 cghqehcbqhb = new Vector3(ILBCCCBJNCL.transform.localPosition.x, ILBCCCBJNCL.transform.localPosition.y, ILBCCCBJNCL.transform.localPosition.z);
		Vector3 vector2;
		if (FKHPMFLQFJP)
		{
			vector2 = new Vector3(cghqehcbqhb.x + vector.x, cghqehcbqhb.y + vector.y, cghqehcbqhb.z + vector.z);
		}
		else
		{
			vector2 = new Vector3(vector.x, vector.y);
		}
		JDMOPNEKJII jdmopnekjii = JDMOPNEKJII.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, vector2);
		jdmopnekjii.CGHQEHCBQHB = cghqehcbqhb;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		ILBCCCBJNCL.transform.localPosition = vector2;
		if (!MMPBBFNFICC)
		{
			goto IL_212;
		}
		jdmopnekjii.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_212:
		yield break;
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x000FA670 File Offset: 0x000F8870
	public IEnumerator IHCHDKFELDG(BattleAnimator.AnimationData DLJJQDQBOQD)
	{
		NewBattleAnimation.GLHEEDJKMMD glheedjkmmd = new NewBattleAnimation.GLHEEDJKMMD();
		glheedjkmmd.DLJJQDQBOQD = DLJJQDQBOQD;
		glheedjkmmd.QNDQJMNKFNN = this;
		return glheedjkmmd;
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator LOGNKHJBCEB(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		QMBJOMBDDCI qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x000FA6D0 File Offset: 0x000F88D0
	private IEnumerator DDQKHKQPFCJ(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float IMGINFQFDLB, float GFJIKBQOKMG, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		LPBJBOHMPBI lpbjbohmpbi = LPBJBOHMPBI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GFJIKBQOKMG);
		lpbjbohmpbi.CGHQEHCBQHB = IMGINFQFDLB;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_C5;
		}
		lpbjbohmpbi.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_C5:
		yield break;
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x000FA70C File Offset: 0x000F890C
	private IEnumerator PGEEJNODOGC(OGJJKKQPNMK IBMINEHKPFF, KGQECFKLKOP.NHDNHHGJDHG MCBJIQPPKJF, float CPKNEQGKQPQ)
	{
		IBMINEHKPFF.JBLCJCLQGCJ = MCBJIQPPKJF;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		yield break;
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator QPHBKINBLHO(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x000FA738 File Offset: 0x000F8938
	private IEnumerator NOCCHPCMHBJ(GameObject ILBCCCBJNCL, BPLKJMJMHFI QKGJDCFCPMO, KKPFGFEEGOM JPPHKPEJDCL, int BBLHGEMJJCM, string BDQBNGHQJKG, Vector3 BCNECCIBMGD, bool HFDFIILFGBL, bool JHEEBKGBMPJ = false, bool LEHIBFLLLJN = false)
	{
		NewBattleAnimation.PBGKGJBHIFF pbgkgjbhiff = new NewBattleAnimation.PBGKGJBHIFF();
		pbgkgjbhiff.ILBCCCBJNCL = ILBCCCBJNCL;
		pbgkgjbhiff.BCNECCIBMGD = BCNECCIBMGD;
		pbgkgjbhiff.JPPHKPEJDCL = JPPHKPEJDCL;
		pbgkgjbhiff.QKGJDCFCPMO = QKGJDCFCPMO;
		pbgkgjbhiff.JHEEBKGBMPJ = JHEEBKGBMPJ;
		pbgkgjbhiff.LEHIBFLLLJN = LEHIBFLLLJN;
		pbgkgjbhiff.BBLHGEMJJCM = BBLHGEMJJCM;
		pbgkgjbhiff.HFDFIILFGBL = HFDFIILFGBL;
		pbgkgjbhiff.BDQBNGHQJKG = BDQBNGHQJKG;
		return pbgkgjbhiff;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000FA794 File Offset: 0x000F8994
	private IEnumerator FMCJFDHIQEC(GameObject ILBCCCBJNCL, float BIJKIKIDKIP, NewBattleAnimation.AnimationStep.DMNPKKENJDG KDEMMJKGDJM)
	{
		float cpkneqgkqpq = 0.02f;
		if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Fast)
		{
			cpkneqgkqpq = 0.001f;
		}
		else if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Slow)
		{
			cpkneqgkqpq = 0.1f;
		}
		Vector3 vector = new Vector3(ILBCCCBJNCL.transform.localPosition.x, ILBCCCBJNCL.transform.localPosition.y);
		JDMOPNEKJII jdmopnekjii = JDMOPNEKJII.FJCEGFKJLCL(ILBCCCBJNCL, cpkneqgkqpq, new Vector3(vector.x + 5f, vector.y));
		jdmopnekjii.CGHQEHCBQHB = vector;
		jdmopnekjii.style = UITweener.DGIBNCIOKJJ.PingPong;
		yield return new WaitForSeconds(BIJKIKIDKIP);
		return 1;
		jdmopnekjii.enabled = false;
		ILBCCCBJNCL.transform.localPosition = vector;
		yield break;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator BCMMLHOEPMC(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x000FA7C0 File Offset: 0x000F89C0
	private IEnumerator HHGMQNQIJQN(NewBattleAnimation.AnimationStep BKGOEHEHPNP, BattleAnimator.AnimationData DLJJQDQBOQD)
	{
		GameObject gameObject = DLJJQDQBOQD.NJCQIGDQJHF(BKGOEHEHPNP.target);
		GameObject gameObject2 = DLJJQDQBOQD.NJCQIGDQJHF(BKGOEHEHPNP.target2);
		if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.Shake)
		{
			this.animator.CMJCIIIOKDD(this.FMCJFDHIQEC(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.speed));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteAnimation)
		{
			KKPFGFEEGOM jpphkpejdcl = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, jpphkpejdcl, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, false, false));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenPosition)
		{
			bool kqboeoccqql = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseXonEnemies;
			bool bijegpccqkb = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseYonEnemies;
			bool mhmgkpqeeqn = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseZonEnemies;
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position, kqboeoccqql, bijegpccqkb, mhmgkpqeeqn, BKGOEHEHPNP.tweenBack, true));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.ChangeBattleCamera)
		{
			if (DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseZonEnemies)
			{
				if (BKGOEHEHPNP.cameraState == KGQECFKLKOP.NHDNHHGJDHG.HitFoe)
				{
					this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), KGQECFKLKOP.NHDNHHGJDHG.HitUser, BKGOEHEHPNP.duration));
				}
				else if (BKGOEHEHPNP.cameraState == KGQECFKLKOP.NHDNHHGJDHG.HitUser)
				{
					this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), KGQECFKLKOP.NHDNHHGJDHG.HitFoe, BKGOEHEHPNP.duration));
				}
			}
			else
			{
				this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), BKGOEHEHPNP.cameraState, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenScale)
		{
			this.animator.CMJCIIIOKDD(this.JKFCLJGMMFN(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenColor)
		{
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenSaturation)
		{
			this.animator.CMJCIIIOKDD(this.QBECFENOQJL(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenContrast)
		{
			this.animator.CMJCIIIOKDD(this.BKNPDCKJOCN(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenDistortion)
		{
			this.animator.CMJCIIIOKDD(this.HKKCIHEQCLK(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenFullColorCon)
		{
			this.animator.CMJCIIIOKDD(this.BKNPDCKJOCN(gameObject, BKGOEHEHPNP.duration, 2f, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, gameObject.GetComponent<ENFMCDNLEQQ>().CEGFBBHMKOE, BKGOEHEHPNP.color, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenFullColorSat)
		{
			this.animator.CMJCIIIOKDD(this.QBECFENOQJL(gameObject, BKGOEHEHPNP.duration, 0f, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, gameObject.GetComponent<ENFMCDNLEQQ>().CEGFBBHMKOE, BKGOEHEHPNP.color, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenScale)
		{
			KKPFGFEEGOM kkpfgfeegom = this.animator.MCDBOJBPMFE();
			kkpfgfeegom.FQDKBPJIDMM = BKGOEHEHPNP.fvalue;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.DDQKHKQPFCJ(kkpfgfeegom.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.fvalue2, BKGOEHEHPNP.tweenBack));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenPos)
		{
			bool kqboeoccqql2 = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseXonEnemies;
			bool bijegpccqkb2 = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseYonEnemies;
			KKPFGFEEGOM kkpfgfeegom2 = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom2, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(kkpfgfeegom2.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position2, kqboeoccqql2, bijegpccqkb2, false, BKGOEHEHPNP.tweenBack, true));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom2.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTween2Pos)
		{
			Vector2 v = new Vector2(gameObject2.transform.localPosition.x + BKGOEHEHPNP.position2.x, gameObject2.transform.localPosition.y + BKGOEHEHPNP.position2.y);
			KKPFGFEEGOM kkpfgfeegom3 = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom3, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(kkpfgfeegom3.gameObject, BKGOEHEHPNP.duration, v, false, false, false, BKGOEHEHPNP.tweenBack, false));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom3.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.Tween2Position)
		{
			Vector2 v2 = new Vector2(gameObject2.transform.localPosition.x + BKGOEHEHPNP.position2.x, gameObject2.transform.localPosition.y + BKGOEHEHPNP.position2.y);
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(gameObject, BKGOEHEHPNP.duration, v2, false, false, false, BKGOEHEHPNP.tweenBack, false));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenColor)
		{
			KKPFGFEEGOM kkpfgfeegom4 = this.animator.MCDBOJBPMFE();
			kkpfgfeegom4.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = BKGOEHEHPNP.color;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom4, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(kkpfgfeegom4.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenColorScale)
		{
			KKPFGFEEGOM kkpfgfeegom5 = this.animator.MCDBOJBPMFE();
			kkpfgfeegom5.FQDKBPJIDMM = BKGOEHEHPNP.fvalue;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom5, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.DDQKHKQPFCJ(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.fvalue2, BKGOEHEHPNP.tweenBack));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SoundEffect && BKGOEHEHPNP.audioClip)
		{
			this.animator.KOJEONMGNFN(BKGOEHEHPNP.audioClip);
		}
		yield return new WaitForSeconds(BKGOEHEHPNP.delayUntilNext);
		return 1;
		yield break;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000FA7EC File Offset: 0x000F89EC
	private IEnumerator HGDBGNKFNKP(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float MKIDHHIKPOD, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		DLLHHQIIIMQ dllhhqiiimq = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().LDBMOOIEBHP = 0.05f;
			dllhhqiiimq = DLLHHQIIIMQ.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, MKIDHHIKPOD);
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EE;
		}
		dllhhqiiimq.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EE:
		yield break;
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x000FA820 File Offset: 0x000F8A20
	private IEnumerator NPLJFMOCHFF(GameObject CGHIENBIHCO, float GCIJNEIIPIM)
	{
		yield return new WaitForSeconds(GCIJNEIIPIM);
		return 1;
		CGHIENBIHCO.SetActive(false);
		yield break;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x000FA6D0 File Offset: 0x000F88D0
	private IEnumerator NHQINJQKEPG(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float IMGINFQFDLB, float GFJIKBQOKMG, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		lpbjbohmpbi = LPBJBOHMPBI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GFJIKBQOKMG);
		lpbjbohmpbi.CGHQEHCBQHB = IMGINFQFDLB;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_C5;
		}
		lpbjbohmpbi.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_C5:
		yield break;
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x000FA844 File Offset: 0x000F8A44
	private IEnumerator FPBQOGBDFEM(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float QNBFBLJCHDC, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		CKHCPIJINBC ckhcpijinbc = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ckhcpijinbc = CKHCPIJINBC.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, QNBFBLJCHDC);
			ckhcpijinbc.CGHQEHCBQHB = ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBFBLJCHDC;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_F4;
		}
		ckhcpijinbc.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_F4:
		yield break;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x000FA670 File Offset: 0x000F8870
	[DebuggerHidden]
	public IEnumerator JGBQPJMDKQP(BattleAnimator.AnimationData DLJJQDQBOQD)
	{
		NewBattleAnimation.GLHEEDJKMMD glheedjkmmd = new NewBattleAnimation.GLHEEDJKMMD();
		glheedjkmmd.DLJJQDQBOQD = DLJJQDQBOQD;
		glheedjkmmd.QNDQJMNKFNN = this;
		return glheedjkmmd;
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x000FA7EC File Offset: 0x000F89EC
	private IEnumerator HKKCIHEQCLK(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float MKIDHHIKPOD, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		dllhhqiiimq = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().LDBMOOIEBHP = 0.05f;
			dllhhqiiimq = DLLHHQIIIMQ.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, MKIDHHIKPOD);
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EE;
		}
		dllhhqiiimq.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EE:
		yield break;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x000FA794 File Offset: 0x000F8994
	private IEnumerator GGCEOGOKLJG(GameObject ILBCCCBJNCL, float BIJKIKIDKIP, NewBattleAnimation.AnimationStep.DMNPKKENJDG KDEMMJKGDJM)
	{
		cpkneqgkqpq = 0.02f;
		if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Fast)
		{
			cpkneqgkqpq = 0.001f;
		}
		else if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Slow)
		{
			cpkneqgkqpq = 0.1f;
		}
		vector = new Vector3(ILBCCCBJNCL.transform.localPosition.x, ILBCCCBJNCL.transform.localPosition.y);
		jdmopnekjii = JDMOPNEKJII.FJCEGFKJLCL(ILBCCCBJNCL, cpkneqgkqpq, new Vector3(vector.x + 5f, vector.y));
		jdmopnekjii.CGHQEHCBQHB = vector;
		jdmopnekjii.style = UITweener.DGIBNCIOKJJ.PingPong;
		yield return new WaitForSeconds(BIJKIKIDKIP);
		return 1;
		jdmopnekjii.enabled = false;
		ILBCCCBJNCL.transform.localPosition = vector;
		yield break;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000FA6D0 File Offset: 0x000F88D0
	private IEnumerator NBKFEMPPDLB(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float IMGINFQFDLB, float GFJIKBQOKMG, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		lpbjbohmpbi = LPBJBOHMPBI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GFJIKBQOKMG);
		lpbjbohmpbi.CGHQEHCBQHB = IMGINFQFDLB;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_C5;
		}
		lpbjbohmpbi.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_C5:
		yield break;
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x000FA61C File Offset: 0x000F881C
	private IEnumerator GFDNQDJJGLJ(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Vector3 BDBBEMKFGPI, bool KQBOEOCCQQL, bool BIJEGPCCQKB, bool MHMGKPQEEQN, bool MMPBBFNFICC, bool FKHPMFLQFJP = true)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		vector = BDBBEMKFGPI;
		if (KQBOEOCCQQL)
		{
			vector.x = -vector.x;
		}
		if (BIJEGPCCQKB)
		{
			vector.y = -vector.y;
		}
		if (MHMGKPQEEQN)
		{
			vector.z = -vector.z;
		}
		cghqehcbqhb = new Vector3(ILBCCCBJNCL.transform.localPosition.x, ILBCCCBJNCL.transform.localPosition.y, ILBCCCBJNCL.transform.localPosition.z);
		if (FKHPMFLQFJP)
		{
			vector2 = new Vector3(cghqehcbqhb.x + vector.x, cghqehcbqhb.y + vector.y, cghqehcbqhb.z + vector.z);
		}
		else
		{
			vector2 = new Vector3(vector.x, vector.y);
		}
		jdmopnekjii = JDMOPNEKJII.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, vector2);
		jdmopnekjii.CGHQEHCBQHB = cghqehcbqhb;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		ILBCCCBJNCL.transform.localPosition = vector2;
		if (!MMPBBFNFICC)
		{
			goto IL_212;
		}
		jdmopnekjii.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_212:
		yield break;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x000FA878 File Offset: 0x000F8A78
	[DebuggerHidden]
	public IEnumerator EFGEEOEFCMQ(BattleAnimator.AnimationData DLJJQDQBOQD)
	{
		NewBattleAnimation.QQBQELDBEHD qqbqeldbehd = new NewBattleAnimation.QQBQELDBEHD();
		qqbqeldbehd.DLJJQDQBOQD = DLJJQDQBOQD;
		qqbqeldbehd.QNDQJMNKFNN = this;
		return qqbqeldbehd;
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x000FA820 File Offset: 0x000F8A20
	private IEnumerator PCFENFIHFGE(GameObject CGHIENBIHCO, float GCIJNEIIPIM)
	{
		yield return new WaitForSeconds(GCIJNEIIPIM);
		return 1;
		CGHIENBIHCO.SetActive(false);
		yield break;
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000FA89C File Offset: 0x000F8A9C
	private IEnumerator BKNPDCKJOCN(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float NBJPJBEQKPI, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		OJNJKONDHBB ojnjkondhbb = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ojnjkondhbb = OJNJKONDHBB.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, NBJPJBEQKPI);
			ojnjkondhbb.CGHQEHCBQHB = ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().NBJPJBEQKPI;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_F4;
		}
		ojnjkondhbb.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_F4:
		yield break;
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x000FA738 File Offset: 0x000F8938
	[DebuggerHidden]
	private IEnumerator DFJFPKCDOKK(GameObject ILBCCCBJNCL, BPLKJMJMHFI QKGJDCFCPMO, KKPFGFEEGOM JPPHKPEJDCL, int BBLHGEMJJCM, string BDQBNGHQJKG, Vector3 BCNECCIBMGD, bool HFDFIILFGBL, bool JHEEBKGBMPJ = false, bool LEHIBFLLLJN = false)
	{
		NewBattleAnimation.PBGKGJBHIFF pbgkgjbhiff = new NewBattleAnimation.PBGKGJBHIFF();
		pbgkgjbhiff.ILBCCCBJNCL = ILBCCCBJNCL;
		pbgkgjbhiff.BCNECCIBMGD = BCNECCIBMGD;
		pbgkgjbhiff.JPPHKPEJDCL = JPPHKPEJDCL;
		pbgkgjbhiff.QKGJDCFCPMO = QKGJDCFCPMO;
		pbgkgjbhiff.JHEEBKGBMPJ = JHEEBKGBMPJ;
		pbgkgjbhiff.LEHIBFLLLJN = LEHIBFLLLJN;
		pbgkgjbhiff.BBLHGEMJJCM = BBLHGEMJJCM;
		pbgkgjbhiff.HFDFIILFGBL = HFDFIILFGBL;
		pbgkgjbhiff.BDQBNGHQJKG = BDQBNGHQJKG;
		return pbgkgjbhiff;
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x000FA7C0 File Offset: 0x000F89C0
	private IEnumerator IKDLGNJGKQB(NewBattleAnimation.AnimationStep BKGOEHEHPNP, BattleAnimator.AnimationData DLJJQDQBOQD)
	{
		gameObject = DLJJQDQBOQD.NJCQIGDQJHF(BKGOEHEHPNP.target);
		gameObject2 = DLJJQDQBOQD.NJCQIGDQJHF(BKGOEHEHPNP.target2);
		if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.Shake)
		{
			this.animator.CMJCIIIOKDD(this.FMCJFDHIQEC(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.speed));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteAnimation)
		{
			KKPFGFEEGOM jpphkpejdcl = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, jpphkpejdcl, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, false, false));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenPosition)
		{
			bool kqboeoccqql = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseXonEnemies;
			bool bijegpccqkb = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseYonEnemies;
			bool mhmgkpqeeqn = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseZonEnemies;
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position, kqboeoccqql, bijegpccqkb, mhmgkpqeeqn, BKGOEHEHPNP.tweenBack, true));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.ChangeBattleCamera)
		{
			if (DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseZonEnemies)
			{
				if (BKGOEHEHPNP.cameraState == KGQECFKLKOP.NHDNHHGJDHG.HitFoe)
				{
					this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), KGQECFKLKOP.NHDNHHGJDHG.HitUser, BKGOEHEHPNP.duration));
				}
				else if (BKGOEHEHPNP.cameraState == KGQECFKLKOP.NHDNHHGJDHG.HitUser)
				{
					this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), KGQECFKLKOP.NHDNHHGJDHG.HitFoe, BKGOEHEHPNP.duration));
				}
			}
			else
			{
				this.animator.CMJCIIIOKDD(this.PGEEJNODOGC(DLJJQDQBOQD.battleHandler.GetComponent<OGJJKKQPNMK>(), BKGOEHEHPNP.cameraState, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenScale)
		{
			this.animator.CMJCIIIOKDD(this.JKFCLJGMMFN(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenColor)
		{
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenSaturation)
		{
			this.animator.CMJCIIIOKDD(this.QBECFENOQJL(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenContrast)
		{
			this.animator.CMJCIIIOKDD(this.BKNPDCKJOCN(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenDistortion)
		{
			this.animator.CMJCIIIOKDD(this.HKKCIHEQCLK(gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenFullColorCon)
		{
			this.animator.CMJCIIIOKDD(this.BKNPDCKJOCN(gameObject, BKGOEHEHPNP.duration, 2f, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, gameObject.GetComponent<ENFMCDNLEQQ>().CEGFBBHMKOE, BKGOEHEHPNP.color, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.TweenFullColorSat)
		{
			this.animator.CMJCIIIOKDD(this.QBECFENOQJL(gameObject, BKGOEHEHPNP.duration, 0f, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(gameObject, BKGOEHEHPNP.duration, gameObject.GetComponent<ENFMCDNLEQQ>().CEGFBBHMKOE, BKGOEHEHPNP.color, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenScale)
		{
			KKPFGFEEGOM kkpfgfeegom = this.animator.MCDBOJBPMFE();
			kkpfgfeegom.FQDKBPJIDMM = BKGOEHEHPNP.fvalue;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.DDQKHKQPFCJ(kkpfgfeegom.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.fvalue2, BKGOEHEHPNP.tweenBack));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenPos)
		{
			bool kqboeoccqql2 = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseXonEnemies;
			bool bijegpccqkb2 = DLJJQDQBOQD.targetIsTeammate && BKGOEHEHPNP.reverseYonEnemies;
			KKPFGFEEGOM kkpfgfeegom2 = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom2, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(kkpfgfeegom2.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.position2, kqboeoccqql2, bijegpccqkb2, false, BKGOEHEHPNP.tweenBack, true));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom2.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTween2Pos)
		{
			Vector2 v = new Vector2(gameObject2.transform.localPosition.x + BKGOEHEHPNP.position2.x, gameObject2.transform.localPosition.y + BKGOEHEHPNP.position2.y);
			KKPFGFEEGOM kkpfgfeegom3 = this.animator.MCDBOJBPMFE();
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom3, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(kkpfgfeegom3.gameObject, BKGOEHEHPNP.duration, v, false, false, false, BKGOEHEHPNP.tweenBack, false));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom3.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.Tween2Position)
		{
			Vector2 v2 = new Vector2(gameObject2.transform.localPosition.x + BKGOEHEHPNP.position2.x, gameObject2.transform.localPosition.y + BKGOEHEHPNP.position2.y);
			this.animator.CMJCIIIOKDD(this.MLFIDQCONEF(gameObject, BKGOEHEHPNP.duration, v2, false, false, false, BKGOEHEHPNP.tweenBack, false));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenColor)
		{
			KKPFGFEEGOM kkpfgfeegom4 = this.animator.MCDBOJBPMFE();
			kkpfgfeegom4.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = BKGOEHEHPNP.color;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom4, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(kkpfgfeegom4.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SpriteTweenColorScale)
		{
			KKPFGFEEGOM kkpfgfeegom5 = this.animator.MCDBOJBPMFE();
			kkpfgfeegom5.FQDKBPJIDMM = BKGOEHEHPNP.fvalue;
			this.animator.CMJCIIIOKDD(this.DFJFPKCDOKK(gameObject, BKGOEHEHPNP.atlas, kkpfgfeegom5, BKGOEHEHPNP.framerate, BKGOEHEHPNP.spritePrefix, BKGOEHEHPNP.position, BKGOEHEHPNP.reversed, BKGOEHEHPNP.loop, BKGOEHEHPNP.keepLastFrame));
			this.animator.CMJCIIIOKDD(this.PQHEDECKPQK(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.color, BKGOEHEHPNP.color2, BKGOEHEHPNP.tweenBack));
			this.animator.CMJCIIIOKDD(this.DDQKHKQPFCJ(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration, BKGOEHEHPNP.fvalue, BKGOEHEHPNP.fvalue2, BKGOEHEHPNP.tweenBack));
			if (BKGOEHEHPNP.loop || BKGOEHEHPNP.keepLastFrame)
			{
				this.animator.CMJCIIIOKDD(this.EIQQBCDFGDE(kkpfgfeegom5.gameObject, BKGOEHEHPNP.duration));
			}
		}
		else if (BKGOEHEHPNP.type == NewBattleAnimation.AnimationStep.OHEJIBOBJPP.SoundEffect && BKGOEHEHPNP.audioClip)
		{
			this.animator.KOJEONMGNFN(BKGOEHEHPNP.audioClip);
		}
		yield return new WaitForSeconds(BKGOEHEHPNP.delayUntilNext);
		return 1;
		yield break;
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator PQHEDECKPQK(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000FA8D0 File Offset: 0x000F8AD0
	private IEnumerator JKFCLJGMMFN(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		Vector3 cghqehcbqhb = new Vector3(ILBCCCBJNCL.transform.localScale.x, ILBCCCBJNCL.transform.localScale.y, ILBCCCBJNCL.transform.localScale.z);
		FPMCQNCDOIP fpmcqncdoip = FPMCQNCDOIP.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, LCHODFNJNBH);
		fpmcqncdoip.CGHQEHCBQHB = cghqehcbqhb;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_11C;
		}
		fpmcqncdoip.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_11C:
		ILBCCCBJNCL.transform.localScale = LCHODFNJNBH;
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000FA820 File Offset: 0x000F8A20
	private IEnumerator HIDDIIHGFOE(GameObject CGHIENBIHCO, float GCIJNEIIPIM)
	{
		yield return new WaitForSeconds(GCIJNEIIPIM);
		return 1;
		CGHIENBIHCO.SetActive(false);
		yield break;
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000FA738 File Offset: 0x000F8938
	private IEnumerator DOFBICCBOPP(GameObject ILBCCCBJNCL, BPLKJMJMHFI QKGJDCFCPMO, KKPFGFEEGOM JPPHKPEJDCL, int BBLHGEMJJCM, string BDQBNGHQJKG, Vector3 BCNECCIBMGD, bool HFDFIILFGBL, bool JHEEBKGBMPJ = false, bool LEHIBFLLLJN = false)
	{
		NewBattleAnimation.PBGKGJBHIFF pbgkgjbhiff = new NewBattleAnimation.PBGKGJBHIFF();
		pbgkgjbhiff.ILBCCCBJNCL = ILBCCCBJNCL;
		pbgkgjbhiff.BCNECCIBMGD = BCNECCIBMGD;
		pbgkgjbhiff.JPPHKPEJDCL = JPPHKPEJDCL;
		pbgkgjbhiff.QKGJDCFCPMO = QKGJDCFCPMO;
		pbgkgjbhiff.JHEEBKGBMPJ = JHEEBKGBMPJ;
		pbgkgjbhiff.LEHIBFLLLJN = LEHIBFLLLJN;
		pbgkgjbhiff.BBLHGEMJJCM = BBLHGEMJJCM;
		pbgkgjbhiff.HFDFIILFGBL = HFDFIILFGBL;
		pbgkgjbhiff.BDQBNGHQJKG = BDQBNGHQJKG;
		return pbgkgjbhiff;
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x000FA70C File Offset: 0x000F890C
	private IEnumerator PQKMBCDIMEO(OGJJKKQPNMK IBMINEHKPFF, KGQECFKLKOP.NHDNHHGJDHG MCBJIQPPKJF, float CPKNEQGKQPQ)
	{
		IBMINEHKPFF.JBLCJCLQGCJ = MCBJIQPPKJF;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		yield break;
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x000FA820 File Offset: 0x000F8A20
	private IEnumerator EIQQBCDFGDE(GameObject CGHIENBIHCO, float GCIJNEIIPIM)
	{
		yield return new WaitForSeconds(GCIJNEIIPIM);
		return 1;
		CGHIENBIHCO.SetActive(false);
		yield break;
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000FA7EC File Offset: 0x000F89EC
	private IEnumerator JQIBGNOLLPD(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float MKIDHHIKPOD, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		dllhhqiiimq = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().LDBMOOIEBHP = 0.05f;
			dllhhqiiimq = DLLHHQIIIMQ.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, MKIDHHIKPOD);
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EE;
		}
		dllhhqiiimq.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EE:
		yield break;
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x000FA844 File Offset: 0x000F8A44
	private IEnumerator QBECFENOQJL(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float QNBFBLJCHDC, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		ckhcpijinbc = null;
		if (ILBCCCBJNCL.GetComponent<OELLFMKIMFH>())
		{
			ckhcpijinbc = CKHCPIJINBC.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, QNBFBLJCHDC);
			ckhcpijinbc.CGHQEHCBQHB = ILBCCCBJNCL.GetComponent<OELLFMKIMFH>().QNBFBLJCHDC;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween MonsterTextures!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_F4;
		}
		ckhcpijinbc.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_F4:
		yield break;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator ONKHPLLKNLN(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000FA794 File Offset: 0x000F8994
	private IEnumerator BOKFLKDJCDE(GameObject ILBCCCBJNCL, float BIJKIKIDKIP, NewBattleAnimation.AnimationStep.DMNPKKENJDG KDEMMJKGDJM)
	{
		cpkneqgkqpq = 0.02f;
		if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Fast)
		{
			cpkneqgkqpq = 0.001f;
		}
		else if (KDEMMJKGDJM == NewBattleAnimation.AnimationStep.DMNPKKENJDG.Slow)
		{
			cpkneqgkqpq = 0.1f;
		}
		vector = new Vector3(ILBCCCBJNCL.transform.localPosition.x, ILBCCCBJNCL.transform.localPosition.y);
		jdmopnekjii = JDMOPNEKJII.FJCEGFKJLCL(ILBCCCBJNCL, cpkneqgkqpq, new Vector3(vector.x + 5f, vector.y));
		jdmopnekjii.CGHQEHCBQHB = vector;
		jdmopnekjii.style = UITweener.DGIBNCIOKJJ.PingPong;
		yield return new WaitForSeconds(BIJKIKIDKIP);
		return 1;
		jdmopnekjii.enabled = false;
		ILBCCCBJNCL.transform.localPosition = vector;
		yield break;
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x000FA694 File Offset: 0x000F8894
	private IEnumerator QCCEEDGNBOE(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, Color CEGFBBHMKOE, Color GNBPCEIDMJH, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		qmbjombddci = null;
		if (ILBCCCBJNCL.GetComponent<MeshRenderer>())
		{
			qmbjombddci = QMBJOMBDDCI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GNBPCEIDMJH);
			qmbjombddci.CGHQEHCBQHB = CEGFBBHMKOE;
		}
		else
		{
			UnityEngine.Debug.LogError("Can only tween UIWidgets!");
		}
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_EA;
		}
		qmbjombddci.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_EA:
		yield break;
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000FA738 File Offset: 0x000F8938
	private IEnumerator PEHLFGBBLKD(GameObject ILBCCCBJNCL, BPLKJMJMHFI QKGJDCFCPMO, KKPFGFEEGOM JPPHKPEJDCL, int BBLHGEMJJCM, string BDQBNGHQJKG, Vector3 BCNECCIBMGD, bool HFDFIILFGBL, bool JHEEBKGBMPJ = false, bool LEHIBFLLLJN = false)
	{
		NewBattleAnimation.PBGKGJBHIFF pbgkgjbhiff = new NewBattleAnimation.PBGKGJBHIFF();
		pbgkgjbhiff.ILBCCCBJNCL = ILBCCCBJNCL;
		pbgkgjbhiff.BCNECCIBMGD = BCNECCIBMGD;
		pbgkgjbhiff.JPPHKPEJDCL = JPPHKPEJDCL;
		pbgkgjbhiff.QKGJDCFCPMO = QKGJDCFCPMO;
		pbgkgjbhiff.JHEEBKGBMPJ = JHEEBKGBMPJ;
		pbgkgjbhiff.LEHIBFLLLJN = LEHIBFLLLJN;
		pbgkgjbhiff.BBLHGEMJJCM = BBLHGEMJJCM;
		pbgkgjbhiff.HFDFIILFGBL = HFDFIILFGBL;
		pbgkgjbhiff.BDQBNGHQJKG = BDQBNGHQJKG;
		return pbgkgjbhiff;
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000FA6D0 File Offset: 0x000F88D0
	private IEnumerator PEHIMHFHLJN(GameObject ILBCCCBJNCL, float CPKNEQGKQPQ, float IMGINFQFDLB, float GFJIKBQOKMG, bool MMPBBFNFICC)
	{
		if (MMPBBFNFICC)
		{
			CPKNEQGKQPQ /= 2f;
		}
		lpbjbohmpbi = LPBJBOHMPBI.FJCEGFKJLCL(ILBCCCBJNCL, CPKNEQGKQPQ, GFJIKBQOKMG);
		lpbjbohmpbi.CGHQEHCBQHB = IMGINFQFDLB;
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		if (!MMPBBFNFICC)
		{
			goto IL_C5;
		}
		lpbjbohmpbi.Play(false);
		yield return new WaitForSeconds(CPKNEQGKQPQ);
		return 1;
		IL_C5:
		yield break;
	}

	// Token: 0x0400088A RID: 2186
	[HideInInspector]
	public BattleAnimator animator;

	// Token: 0x0400088B RID: 2187
	public List<NewBattleAnimation.AnimationStep> attackSteps = new List<NewBattleAnimation.AnimationStep>();

	// Token: 0x0400088C RID: 2188
	public List<NewBattleAnimation.AnimationStep> hitSteps = new List<NewBattleAnimation.AnimationStep>();

	// Token: 0x02000150 RID: 336
	[Serializable]
	public class AnimationStep
	{
		// Token: 0x0400088D RID: 2189
		public KGQECFKLKOP.NHDNHHGJDHG cameraState;

		// Token: 0x0400088E RID: 2190
		public NewBattleAnimation.AnimationStep.OHEJIBOBJPP type;

		// Token: 0x0400088F RID: 2191
		public float delayUntilNext;

		// Token: 0x04000890 RID: 2192
		public BattleAnimator.NMIILIQEECJ target;

		// Token: 0x04000891 RID: 2193
		public BattleAnimator.NMIILIQEECJ target2;

		// Token: 0x04000892 RID: 2194
		public BPLKJMJMHFI atlas;

		// Token: 0x04000893 RID: 2195
		public string spritePrefix;

		// Token: 0x04000894 RID: 2196
		public int framerate;

		// Token: 0x04000895 RID: 2197
		public Vector3 position;

		// Token: 0x04000896 RID: 2198
		public Vector3 position2;

		// Token: 0x04000897 RID: 2199
		public Color color = Color.white;

		// Token: 0x04000898 RID: 2200
		public Color color2 = Color.white;

		// Token: 0x04000899 RID: 2201
		public float fvalue;

		// Token: 0x0400089A RID: 2202
		public float fvalue2;

		// Token: 0x0400089B RID: 2203
		public AudioClip audioClip;

		// Token: 0x0400089C RID: 2204
		public NewBattleAnimation.AnimationStep.DMNPKKENJDG speed;

		// Token: 0x0400089D RID: 2205
		public bool reverseYonEnemies;

		// Token: 0x0400089E RID: 2206
		public bool reverseXonEnemies;

		// Token: 0x0400089F RID: 2207
		public bool reverseZonEnemies;

		// Token: 0x040008A0 RID: 2208
		public bool tweenBack;

		// Token: 0x040008A1 RID: 2209
		public bool loop;

		// Token: 0x040008A2 RID: 2210
		public bool keepLastFrame;

		// Token: 0x040008A3 RID: 2211
		public bool reversed;

		// Token: 0x040008A4 RID: 2212
		public float duration;

		// Token: 0x02000151 RID: 337
		public enum OHEJIBOBJPP
		{
			// Token: 0x040008A6 RID: 2214
			Wait,
			// Token: 0x040008A7 RID: 2215
			SpriteAnimation,
			// Token: 0x040008A8 RID: 2216
			Shake,
			// Token: 0x040008A9 RID: 2217
			TweenPosition,
			// Token: 0x040008AA RID: 2218
			Tween2Position,
			// Token: 0x040008AB RID: 2219
			TweenScale,
			// Token: 0x040008AC RID: 2220
			SpriteTweenPos,
			// Token: 0x040008AD RID: 2221
			SpriteTweenScale,
			// Token: 0x040008AE RID: 2222
			SpriteTween2Pos,
			// Token: 0x040008AF RID: 2223
			TweenColor,
			// Token: 0x040008B0 RID: 2224
			TweenSaturation,
			// Token: 0x040008B1 RID: 2225
			TweenContrast,
			// Token: 0x040008B2 RID: 2226
			TweenDistortion,
			// Token: 0x040008B3 RID: 2227
			TweenFullColorSat,
			// Token: 0x040008B4 RID: 2228
			TweenFullColorCon,
			// Token: 0x040008B5 RID: 2229
			SpriteTweenColor,
			// Token: 0x040008B6 RID: 2230
			SpriteTweenColorScale,
			// Token: 0x040008B7 RID: 2231
			SoundEffect,
			// Token: 0x040008B8 RID: 2232
			ChangeBattleCamera
		}

		// Token: 0x02000152 RID: 338
		public enum DMNPKKENJDG
		{
			// Token: 0x040008BA RID: 2234
			Slow = -1,
			// Token: 0x040008BB RID: 2235
			Normal,
			// Token: 0x040008BC RID: 2236
			Fast
		}
	}
}
