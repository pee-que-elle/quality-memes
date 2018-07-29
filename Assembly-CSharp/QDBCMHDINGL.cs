using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200008F RID: 143
[AddComponentMenu("NGUI/Internal/Active Animation")]
public class QDBCMHDINGL : MonoBehaviour
{
	// Token: 0x06001297 RID: 4759 RVA: 0x0000A939 File Offset: 0x00008B39
	public static QDBCMHDINGL BQDKKDPGGJQ(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.FDDNMMEJCPF(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DisableAfterForward);
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x0008C224 File Offset: 0x0008A424
	private float FJCNGNMQCLB()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x0008C24C File Offset: 0x0008A44C
	private void Update()
	{
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		if (gpfidejemeg == 0f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? gpfidejemeg : (-gpfidejemeg));
			if (this.BPBPHLQGEBM)
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = false;
			base.enabled = false;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = false;
				return;
			}
			bool flag = false;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num = animationState.speed * gpfidejemeg;
						animationState.time += num;
						if (num < 0f)
						{
							if (animationState.time > 0f)
							{
								flag = true;
							}
							else
							{
								animationState.time = 0f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = true;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = false;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.DontRequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, false);
			}
		}
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x0008C224 File Offset: 0x0008A424
	private float JMDDQDPQFKJ()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x0008C424 File Offset: 0x0008A624
	private void LPCMEJJIQIB(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 1911f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 543f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.BPBPHLQGEBM && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = true;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 877f : 13f);
		}
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x0000A945 File Offset: 0x00008B45
	private void LNHDODMGBKC()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x0008C5E4 File Offset: 0x0008A7E4
	public static QDBCMHDINGL ELNOFBDJHPE(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (!IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, false);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.DBJQBEKGFHP = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.GGPGPJKENDL(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(320f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x0000A970 File Offset: 0x00008B70
	public static QDBCMHDINGL MLOIHHQMFBN(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.MLOIHHQMFBN(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x0008C6AC File Offset: 0x0008A8AC
	public void BDJOIHIIDGB()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 40f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 870f : 1075f);
		}
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x0008C77C File Offset: 0x0008A97C
	private void FOEEMLIKDQG(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Forward) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = true;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 1023f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 1804f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = false;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.MQLNBNNFEFI() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = true;
			this.BEONEOODMOO = false;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 1867f : 170f);
		}
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x0008C93C File Offset: 0x0008AB3C
	public void INNQKLOKBFL()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 0f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 0f : 1f);
		}
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x0008C224 File Offset: 0x0008A424
	private float LEECCMMMJHM()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x0008CA0C File Offset: 0x0008AC0C
	public static QDBCMHDINGL FDDNMMEJCPF(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (!IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, false);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.DBJQBEKGFHP = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.LLLGLIDBJNI(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(1995f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0008CAD4 File Offset: 0x0008ACD4
	public void HFHEFHMQMFD()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 1982f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 678f : 510f);
		}
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0008CBA4 File Offset: 0x0008ADA4
	private void QDIKKLMCIJK()
	{
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		if (gpfidejemeg == 241f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? gpfidejemeg : (-gpfidejemeg));
			if (this.BPBPHLQGEBM)
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = true;
			base.enabled = false;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = true;
				return;
			}
			bool flag = true;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num = animationState.speed * gpfidejemeg;
						animationState.time += num;
						if (num < 1354f)
						{
							if (animationState.time > 1102f)
							{
								flag = true;
							}
							else
							{
								animationState.time = 1915f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = true;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = false;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.RequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, true);
			}
		}
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x0008CD7C File Offset: 0x0008AF7C
	public bool CKGHEFGDNLK()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return false;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return true;
							}
							if (animationState.time > 1807f)
							{
								return true;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.EHOCQKMMBCQ() == 270f)
				{
					return false;
				}
			}
			else if (this.KMBBFCCOLCF() == 703f)
			{
				return true;
			}
			return true;
		}
		return false;
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0008CE6C File Offset: 0x0008B06C
	public bool BPBPHLQGEBM
	{
		get
		{
			if (!(this.DBJQBEKGFHP == null))
			{
				IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						AnimationState animationState = (AnimationState)obj;
						if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
						{
							if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
							{
								if (animationState.time < animationState.length)
								{
									return true;
								}
							}
							else
							{
								if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
								{
									return true;
								}
								if (animationState.time > 0f)
								{
									return true;
								}
							}
						}
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
				return false;
			}
			if (this.LLFHPJGODLJ != null)
			{
				if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
				{
					if (this.QGLEHMIIIEC == 0f)
					{
						return false;
					}
				}
				else if (this.QGLEHMIIIEC == 1f)
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x0008CF5C File Offset: 0x0008B15C
	public bool LBODQDJCQNN()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
						{
							if (animationState.time < animationState.length)
							{
								return false;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return false;
							}
							if (animationState.time > 850f)
							{
								return false;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.EHOCQKMMBCQ() == 1749f)
				{
					return true;
				}
			}
			else if (this.LEECCMMMJHM() == 1185f)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x0008D04C File Offset: 0x0008B24C
	public bool DJMEKEPLBIP()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return false;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return false;
							}
							if (animationState.time > 651f)
							{
								return true;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.FBKKMONEICC() == 687f)
				{
					return true;
				}
			}
			else if (this.HCIKMEDBGLP() == 1188f)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x0008D13C File Offset: 0x0008B33C
	private void JENGGFLPCDQ()
	{
		float num = JMIOBJFFGBN.EDEPQCIGFOL();
		if (num == 147f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? num : (-num));
			if (this.JKHPOQEMCME())
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = false;
			base.enabled = false;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = false;
				return;
			}
			bool flag = true;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num2 = animationState.speed * num;
						animationState.time += num2;
						if (num2 < 1273f)
						{
							if (animationState.time > 823f)
							{
								flag = true;
							}
							else
							{
								animationState.time = 1596f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = false;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = true;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.PCQQOFMPKCG(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.RequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, false);
			}
		}
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0008D314 File Offset: 0x0008B514
	public bool OQOCJFQFHLM()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
						{
							if (animationState.time < animationState.length)
							{
								return false;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return true;
							}
							if (animationState.time > 1665f)
							{
								return false;
							}
						}
					}
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
			return true;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.KMBBFCCOLCF() == 26f)
				{
					return false;
				}
			}
			else if (this.CBLEBIQKDGJ() == 385f)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x0008D404 File Offset: 0x0008B604
	public bool EFGILNPPFPD()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return true;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return false;
							}
							if (animationState.time > 1049f)
							{
								return false;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.JMDDQDPQFKJ() == 478f)
				{
					return false;
				}
			}
			else if (this.JMDDQDPQFKJ() == 1693f)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x0008D4F4 File Offset: 0x0008B6F4
	public void FKIQMCIHFOO()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = 256f;
					}
				}
				return;
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
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? 740f : 1866f);
		}
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x0000A945 File Offset: 0x00008B45
	private void LIFJCBMQELJ()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x0008D5B8 File Offset: 0x0008B7B8
	public static QDBCMHDINGL MLOIHHQMFBN(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != GKKIEDPNJIF.IgnoreDisabledState && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.MLOIHHQMFBN(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(0f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x0008D684 File Offset: 0x0008B884
	public void OFLBKBDOIOC()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 1791f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 503f : 1259f);
		}
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x0008D754 File Offset: 0x0008B954
	public void GQEBICLPOOD()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 1005f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Toggle) ? 286f : 1266f);
		}
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x0000A945 File Offset: 0x00008B45
	private void GBGEGKHDQKB()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x0000A99A File Offset: 0x00008B9A
	public static QDBCMHDINGL IGMLLCFCHBM(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.FDDNMMEJCPF(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x0000A945 File Offset: 0x00008B45
	private void MGBMNEQCEBJ()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0008D824 File Offset: 0x0008BA24
	private float QGLEHMIIIEC
	{
		get
		{
			return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(0).normalizedTime);
		}
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x0008D84C File Offset: 0x0008BA4C
	public void PEMGDPDNPQQ()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 429f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Toggle) ? 1095f : 518f);
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x0008D91C File Offset: 0x0008BB1C
	public static QDBCMHDINGL GEJQDJOBFEM(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (!IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.DBJQBEKGFHP = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.IJJHNMKCIKJ(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(1270f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x0000A945 File Offset: 0x00008B45
	private void MMLKOGQFENF()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x0000A945 File Offset: 0x00008B45
	private void Start()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
	public static QDBCMHDINGL OHEMMLHOLKP(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != (GKKIEDPNJIF)4 && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.KINBDOQNPCE(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(394f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0008DAB0 File Offset: 0x0008BCB0
	private void MLOIHHQMFBN(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Forward) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 0f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Forward && animationState.time == animationState.length)
						{
							animationState.time = 0f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.BPBPHLQGEBM && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = true;
			this.BEONEOODMOO = true;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 1f : 0f);
		}
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0000A945 File Offset: 0x00008B45
	private void NOLQNFCODBK()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0000A945 File Offset: 0x00008B45
	private void DFNFEDMJKGK()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x0008DC70 File Offset: 0x0008BE70
	public bool DBHNMEHIFOJ()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return true;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return true;
							}
							if (animationState.time > 1952f)
							{
								return true;
							}
						}
					}
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
			return true;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.CBLEBIQKDGJ() == 1243f)
				{
					return false;
				}
			}
			else if (this.KMBBFCCOLCF() == 1717f)
			{
				return false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x0008DD60 File Offset: 0x0008BF60
	public void QFILIQNPLQD()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 745f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 1415f : 1109f);
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x0008DE30 File Offset: 0x0008C030
	public static QDBCMHDINGL HHMBCIGJKLO(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != (GKKIEDPNJIF)8 && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.DoNothing)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i += 0;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.JJDDNPMJGKE(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(1795f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x0008C224 File Offset: 0x0008A424
	private float CBLEBIQKDGJ()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0000A9A6 File Offset: 0x00008BA6
	public static QDBCMHDINGL OIKDEIBEPNP(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.GEJQDJOBFEM(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x0008D824 File Offset: 0x0008BA24
	private float HCIKMEDBGLP()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(0).normalizedTime);
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0008DEFC File Offset: 0x0008C0FC
	public void KNLJNQBFQPC()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 1333f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 1935f : 777f);
		}
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x0008DFCC File Offset: 0x0008C1CC
	private void LLLGLIDBJNI(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Toggle);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = false;
			this.DBJQBEKGFHP.enabled = true;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 1949f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Forward && animationState.time == animationState.length)
						{
							animationState.time = 32f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.CKGHEFGDNLK() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = false;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Toggle) ? 649f : 803f);
		}
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x0000A9B2 File Offset: 0x00008BB2
	public static QDBCMHDINGL EMCKKEKHINF(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.KGCQEGKOJNN(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DisableAfterForward);
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x0008E18C File Offset: 0x0008C38C
	public bool JKHPOQEMCME()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return true;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return false;
							}
							if (animationState.time > 1650f)
							{
								return true;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.QGLEHMIIIEC == 443f)
				{
					return true;
				}
			}
			else if (this.HCIKMEDBGLP() == 1937f)
			{
				return false;
			}
			return false;
		}
		return true;
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x0000A9BE File Offset: 0x00008BBE
	public static QDBCMHDINGL QHLKIQMGKDN(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.MLOIHHQMFBN(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x0008E27C File Offset: 0x0008C47C
	private void GHBFIQFIBKP()
	{
		float num = JMIOBJFFGBN.DEHFGOQHJCP();
		if (num == 992f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? num : (-num));
			if (this.EFGILNPPFPD())
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = false;
			base.enabled = true;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = false;
				return;
			}
			bool flag = true;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num2 = animationState.speed * num;
						animationState.time += num2;
						if (num2 < 315f)
						{
							if (animationState.time > 509f)
							{
								flag = false;
							}
							else
							{
								animationState.time = 323f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = true;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = true;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = false;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.CDGHNJLPFKN(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.DontRequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, false);
			}
		}
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x0008E454 File Offset: 0x0008C654
	public void HOKHQPGJDQC()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 738f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 346f : 1379f);
		}
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x0000A9CA File Offset: 0x00008BCA
	public static QDBCMHDINGL PPICDLHECBG(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.MLOIHHQMFBN(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x0000A9D6 File Offset: 0x00008BD6
	public static QDBCMHDINGL MFFFOEMOKBK(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.ELNOFBDJHPE(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DisableAfterForward);
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x0000A945 File Offset: 0x00008B45
	private void KHFDJHFJMDK()
	{
		if (this.KIGMDNGLIQI != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.KIGMDNGLIQI = null;
			this.LLOLLKQOBFD = null;
		}
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x0000A9E2 File Offset: 0x00008BE2
	public static QDBCMHDINGL LIIEQPICJDG(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.ELNOFBDJHPE(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DisableAfterForward);
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x0008E524 File Offset: 0x0008C724
	private void EPKGNIPJOEF()
	{
		float num = JMIOBJFFGBN.FCPBKHJFGJO();
		if (num == 1237f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? num : (-num));
			if (this.CKGHEFGDNLK())
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = true;
			base.enabled = false;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = true;
				return;
			}
			bool flag = false;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num2 = animationState.speed * num;
						animationState.time += num2;
						if (num2 < 497f)
						{
							if (animationState.time > 575f)
							{
								flag = false;
							}
							else
							{
								animationState.time = 1264f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = true;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = true;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = true;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.PCQQOFMPKCG(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.DontRequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, false);
			}
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x0008E6FC File Offset: 0x0008C8FC
	public static QDBCMHDINGL KGCQEGKOJNN(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (!IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.DoNothing)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, false);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.DBJQBEKGFHP = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.IJJHNMKCIKJ(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(203f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x0008E7C4 File Offset: 0x0008C9C4
	private void IJJHNMKCIKJ(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 1531f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 577f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = false;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.MQLNBNNFEFI() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = true;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Toggle) ? 873f : 137f);
		}
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x0008E984 File Offset: 0x0008CB84
	public void MQHDHCDFJLI()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = 1865f;
					}
				}
				return;
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
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? 680f : 1848f);
		}
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x0008EA48 File Offset: 0x0008CC48
	public static QDBCMHDINGL PICHJOPCPEK(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != (GKKIEDPNJIF)8 && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.DoNothing)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, false);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i += 0;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.IJJHNMKCIKJ(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(285f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0008EB14 File Offset: 0x0008CD14
	public void DNPLLLHQGJC()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = 793f;
					}
				}
				return;
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
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? 917f : 1517f);
		}
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
	public void Reset()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = 0f;
					}
				}
				return;
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
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? 0f : 1f);
		}
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0008EC9C File Offset: 0x0008CE9C
	public void JEMKBGLNODN()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 104f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 1706f : 1532f);
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0000A9BE File Offset: 0x00008BBE
	public static QDBCMHDINGL MLOIHHQMFBN(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.MLOIHHQMFBN(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.DoNothing, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0008ED6C File Offset: 0x0008CF6C
	public static QDBCMHDINGL OPHDIHIFOJK(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != (GKKIEDPNJIF)8 && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.DoNothing)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, false);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i += 0;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.GGPGPJKENDL(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(167f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0008EE38 File Offset: 0x0008D038
	private void JBJBPIBCBQO()
	{
		float num = JMIOBJFFGBN.HLMOIFMQOGH();
		if (num == 1413f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? num : (-num));
			if (this.CKGHEFGDNLK())
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = false;
			base.enabled = true;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = false;
				return;
			}
			bool flag = true;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num2 = animationState.speed * num;
						animationState.time += num2;
						if (num2 < 1358f)
						{
							if (animationState.time > 168f)
							{
								flag = true;
							}
							else
							{
								animationState.time = 1389f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = false;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = false;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.PCQQOFMPKCG(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.DontRequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, true);
			}
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0008F010 File Offset: 0x0008D210
	private void GCBBJNPKHPQ(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Forward);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = false;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 354f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Forward && animationState.time == animationState.length)
						{
							animationState.time = 1915f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = false;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.NKIQNDEIKIK() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = true;
			this.BEONEOODMOO = false;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Toggle) ? 1384f : 1554f);
		}
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0008C224 File Offset: 0x0008A424
	private float KMBBFCCOLCF()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x0008F1D0 File Offset: 0x0008D3D0
	public void QNEMIOCJMMG()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 271f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 1282f : 372f);
		}
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0008F2A0 File Offset: 0x0008D4A0
	public static QDBCMHDINGL MLOIHHQMFBN(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (!IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.EnableThenPlay)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i++;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.DBJQBEKGFHP = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.MLOIHHQMFBN(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(0f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0008F368 File Offset: 0x0008D568
	public void DIMGBOBKNJB()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = 502f;
					}
				}
				return;
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
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? 856f : 439f);
		}
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0008F42C File Offset: 0x0008D62C
	private void JJDDNPMJGKE(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Forward) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Toggle);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = false;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 1676f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 1902f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.DBHNMEHIFOJ() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = true;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Toggle) ? 1386f : 382f);
		}
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0000A9EE File Offset: 0x00008BEE
	public static QDBCMHDINGL HGEOMKIPHKQ(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.ELNOFBDJHPE(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0008F5EC File Offset: 0x0008D7EC
	private void DLJBLCDQJJE(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Forward) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Toggle);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 301f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 731f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.JKHPOQEMCME() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = true;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 1282f : 1392f);
		}
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0008C224 File Offset: 0x0008A424
	private float FBKKMONEICC()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(1).normalizedTime);
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0000A9FA File Offset: 0x00008BFA
	public static QDBCMHDINGL BPCLKGBFBCK(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.KGCQEGKOJNN(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0008F7AC File Offset: 0x0008D9AC
	private void GGPGPJKENDL(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Toggle);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = false;
			this.DBJQBEKGFHP.enabled = false;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 686f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Forward && animationState.time == animationState.length)
						{
							animationState.time = 1667f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = false;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.LBODQDJCQNN() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = false;
			this.BEONEOODMOO = false;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 1722f : 1869f);
		}
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0008F96C File Offset: 0x0008DB6C
	public void GPHOQCPKHGM()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 1856f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 0, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 1849f : 1473f);
		}
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0000AA06 File Offset: 0x00008C06
	public static QDBCMHDINGL JMCLEDJFEGQ(Animation CNJFFIPCNHM, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.GEJQDJOBFEM(CNJFFIPCNHM, null, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DisableAfterForward);
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0008FA3C File Offset: 0x0008DC3C
	private void CLNOPBFEBID()
	{
		float num = JMIOBJFFGBN.PFEELKIHJDG();
		if (num == 102f)
		{
			return;
		}
		if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Update((this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse) ? num : (-num));
			if (this.CKGHEFGDNLK())
			{
				return;
			}
			this.LLFHPJGODLJ.enabled = false;
			base.enabled = true;
		}
		else
		{
			if (!(this.DBJQBEKGFHP != null))
			{
				base.enabled = true;
				return;
			}
			bool flag = true;
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						float num2 = animationState.speed * num;
						animationState.time += num2;
						if (num2 < 1004f)
						{
							if (animationState.time > 932f)
							{
								flag = false;
							}
							else
							{
								animationState.time = 638f;
							}
						}
						else if (animationState.time < animationState.length)
						{
							flag = true;
						}
						else
						{
							animationState.time = animationState.length;
						}
					}
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
			this.DBJQBEKGFHP.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (this.BEONEOODMOO)
		{
			this.BEONEOODMOO = false;
			if (QDBCMHDINGL.OMQCQCBLQGJ == null)
			{
				QDBCMHDINGL.OMQCQCBLQGJ = this;
				EventDelegate.PPNLGOMQOPH(this.KCQKMKOQLQL);
				if (this.KIGMDNGLIQI != null && !string.IsNullOrEmpty(this.LLOLLKQOBFD))
				{
					this.KIGMDNGLIQI.SendMessage(this.LLOLLKQOBFD, SendMessageOptions.RequireReceiver);
				}
				QDBCMHDINGL.OMQCQCBLQGJ = null;
			}
			if (this.ENEEDGCPMFF != QMDFDJEIEMO.Toggle && this.BKHNLBOOLDK == this.ENEEDGCPMFF)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(base.gameObject, false);
			}
		}
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0008FC14 File Offset: 0x0008DE14
	public void CFEICKIIIIG()
	{
		if (this.DBJQBEKGFHP != null)
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
					{
						animationState.time = animationState.length;
					}
					else if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
					{
						animationState.time = 728f;
					}
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
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (this.BKHNLBOOLDK != QMDFDJEIEMO.Forward) ? 445f : 1491f);
		}
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0008FCE4 File Offset: 0x0008DEE4
	public bool MQLNBNNFEFI()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Toggle)
						{
							if (animationState.time < animationState.length)
							{
								return true;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return false;
							}
							if (animationState.time > 1342f)
							{
								return true;
							}
						}
					}
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
			return true;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.LEECCMMMJHM() == 651f)
				{
					return true;
				}
			}
			else if (this.JMDDQDPQFKJ() == 101f)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0008FDD4 File Offset: 0x0008DFD4
	private void KINBDOQNPCE(string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
		{
			BFHKGNKMDCQ = ((this.BKHNLBOOLDK == QMDFDJEIEMO.Forward) ? QMDFDJEIEMO.Reverse : QMDFDJEIEMO.Toggle);
		}
		if (this.DBJQBEKGFHP != null)
		{
			base.enabled = true;
			this.DBJQBEKGFHP.enabled = true;
			if (string.IsNullOrEmpty(QEFJCNPDLEE))
			{
				if (!this.DBJQBEKGFHP.isPlaying)
				{
					this.DBJQBEKGFHP.Play();
				}
			}
			else if (!this.DBJQBEKGFHP.IsPlaying(QEFJCNPDLEE))
			{
				this.DBJQBEKGFHP.Play(QEFJCNPDLEE);
			}
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (string.IsNullOrEmpty(QEFJCNPDLEE) || animationState.name == QEFJCNPDLEE)
					{
						float num = Mathf.Abs(animationState.speed);
						animationState.speed = num * (float)BFHKGNKMDCQ;
						if (BFHKGNKMDCQ == QMDFDJEIEMO.Reverse && animationState.time == 361f)
						{
							animationState.time = animationState.length;
						}
						else if (BFHKGNKMDCQ == QMDFDJEIEMO.Toggle && animationState.time == animationState.length)
						{
							animationState.time = 1451f;
						}
					}
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
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.BEONEOODMOO = true;
			this.DBJQBEKGFHP.Sample();
		}
		else if (this.LLFHPJGODLJ != null)
		{
			if (base.enabled && this.DBHNMEHIFOJ() && this.INQBLICPHQC == QEFJCNPDLEE)
			{
				this.BKHNLBOOLDK = BFHKGNKMDCQ;
				return;
			}
			base.enabled = true;
			this.BEONEOODMOO = false;
			this.BKHNLBOOLDK = BFHKGNKMDCQ;
			this.INQBLICPHQC = QEFJCNPDLEE;
			this.LLFHPJGODLJ.Play(this.INQBLICPHQC, 1, (BFHKGNKMDCQ != QMDFDJEIEMO.Forward) ? 88f : 1031f);
		}
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x0000AA12 File Offset: 0x00008C12
	public static QDBCMHDINGL OCQFFNGQJPJ(Animation CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ)
	{
		return QDBCMHDINGL.GEJQDJOBFEM(CNJFFIPCNHM, QEFJCNPDLEE, BFHKGNKMDCQ, GKKIEDPNJIF.EnableThenPlay, PNDJHKBEPNM.DoNotDisable);
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0008D824 File Offset: 0x0008BA24
	private float EHOCQKMMBCQ()
	{
		return Mathf.Clamp01(this.LLFHPJGODLJ.GetCurrentAnimatorStateInfo(0).normalizedTime);
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x0008FF94 File Offset: 0x0008E194
	public static QDBCMHDINGL FGLKEPDKJMN(Animator CNJFFIPCNHM, string QEFJCNPDLEE, QMDFDJEIEMO BFHKGNKMDCQ, GKKIEDPNJIF FDCFMICLHHO, PNDJHKBEPNM QINGLKICGKO)
	{
		if (FDCFMICLHHO != (GKKIEDPNJIF)5 && !IKBQNBHOJJB.PBBDNDMELHQ(CNJFFIPCNHM.gameObject))
		{
			if (FDCFMICLHHO != GKKIEDPNJIF.DoNothing)
			{
				return null;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(CNJFFIPCNHM.gameObject, true);
			KQHJOLQLQBJ[] componentsInChildren = CNJFFIPCNHM.gameObject.GetComponentsInChildren<KQHJOLQLQBJ>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				componentsInChildren[i].DMBGDGHEDOJ();
				i += 0;
			}
		}
		QDBCMHDINGL qdbcmhdingl = CNJFFIPCNHM.GetComponent<QDBCMHDINGL>();
		if (qdbcmhdingl == null)
		{
			qdbcmhdingl = CNJFFIPCNHM.gameObject.AddComponent<QDBCMHDINGL>();
		}
		qdbcmhdingl.LLFHPJGODLJ = CNJFFIPCNHM;
		qdbcmhdingl.ENEEDGCPMFF = (QMDFDJEIEMO)QINGLKICGKO;
		qdbcmhdingl.KCQKMKOQLQL.Clear();
		qdbcmhdingl.JJDDNPMJGKE(QEFJCNPDLEE, BFHKGNKMDCQ);
		if (qdbcmhdingl.DBJQBEKGFHP != null)
		{
			qdbcmhdingl.DBJQBEKGFHP.Sample();
		}
		else if (qdbcmhdingl.LLFHPJGODLJ != null)
		{
			qdbcmhdingl.LLFHPJGODLJ.Update(765f);
		}
		return qdbcmhdingl;
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00090060 File Offset: 0x0008E260
	public bool NKIQNDEIKIK()
	{
		if (!(this.DBJQBEKGFHP == null))
		{
			IEnumerator enumerator = this.DBJQBEKGFHP.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					AnimationState animationState = (AnimationState)obj;
					if (this.DBJQBEKGFHP.IsPlaying(animationState.name))
					{
						if (this.BKHNLBOOLDK == QMDFDJEIEMO.Forward)
						{
							if (animationState.time < animationState.length)
							{
								return true;
							}
						}
						else
						{
							if (this.BKHNLBOOLDK != QMDFDJEIEMO.Reverse)
							{
								return true;
							}
							if (animationState.time > 1498f)
							{
								return true;
							}
						}
					}
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
			return false;
		}
		if (this.LLFHPJGODLJ != null)
		{
			if (this.BKHNLBOOLDK == QMDFDJEIEMO.Reverse)
			{
				if (this.JMDDQDPQFKJ() == 1317f)
				{
					return false;
				}
			}
			else if (this.FBKKMONEICC() == 1368f)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x04000369 RID: 873
	public static QDBCMHDINGL OMQCQCBLQGJ;

	// Token: 0x0400036A RID: 874
	public List<EventDelegate> KCQKMKOQLQL = new List<EventDelegate>();

	// Token: 0x0400036B RID: 875
	[HideInInspector]
	public GameObject KIGMDNGLIQI;

	// Token: 0x0400036C RID: 876
	[HideInInspector]
	public string LLOLLKQOBFD;

	// Token: 0x0400036D RID: 877
	private Animation DBJQBEKGFHP;

	// Token: 0x0400036E RID: 878
	private QMDFDJEIEMO BKHNLBOOLDK;

	// Token: 0x0400036F RID: 879
	private QMDFDJEIEMO ENEEDGCPMFF;

	// Token: 0x04000370 RID: 880
	private bool BEONEOODMOO;

	// Token: 0x04000371 RID: 881
	private Animator LLFHPJGODLJ;

	// Token: 0x04000372 RID: 882
	private string INQBLICPHQC = string.Empty;
}
