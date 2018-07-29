using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000075 RID: 117
[AddComponentMenu("NGUI/Interaction/NGUI Progress Bar")]
[ExecuteInEditMode]
public class BJQGLGOLMPQ : GJGCJNOICOM
{
	// Token: 0x06000FE0 RID: 4064 RVA: 0x00078E78 File Offset: 0x00077078
	public void EDKGBJPBBGO(float BGBMIEJJQKC)
	{
		if (this.mFG != null)
		{
			this.mFG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mFG.GetComponent<Collider>() != null)
			{
				this.mFG.GetComponent<Collider>().enabled = (this.mFG.DIIHJCJOKMP > 170f);
			}
			else if (this.mFG.GetComponent<Collider2D>() != null)
			{
				this.mFG.GetComponent<Collider2D>().enabled = (this.mFG.DIIHJCJOKMP > 1674f);
			}
		}
		if (this.mBG != null)
		{
			this.mBG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mBG.GetComponent<Collider>() != null)
			{
				this.mBG.GetComponent<Collider>().enabled = (this.mBG.DIIHJCJOKMP > 495f);
			}
			else if (this.mBG.GetComponent<Collider2D>() != null)
			{
				this.mBG.GetComponent<Collider2D>().enabled = (this.mBG.DIIHJCJOKMP > 928f);
			}
		}
		if (this.BNELEGPJDGK != null)
		{
			ENFMCDNLEQQ component = this.BNELEGPJDGK.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				component.DIIHJCJOKMP = BGBMIEJJQKC;
				if (component.GetComponent<Collider>() != null)
				{
					component.GetComponent<Collider>().enabled = (component.DIIHJCJOKMP > 1042f);
				}
				else if (component.GetComponent<Collider2D>() != null)
				{
					component.GetComponent<Collider2D>().enabled = (component.DIIHJCJOKMP > 1412f);
				}
			}
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00009639 File Offset: 0x00007839
	// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00009538 File Offset: 0x00007738
	public BJQGLGOLMPQ.CGLEFJOIIND JOGPPPPKFNC
	{
		get
		{
			return this.mFill;
		}
		set
		{
			if (this.mFill != value)
			{
				this.mFill = value;
				if (this.PNBOOLEOKCI)
				{
					this.JPBONGIEJCN();
				}
			}
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00009558 File Offset: 0x00007758
	protected bool IGJHCJQEOLN
	{
		get
		{
			return this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft || this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom;
		}
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0000956F File Offset: 0x0000776F
	public void HMMPGMMLFIO(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mFG != BGBMIEJJQKC)
		{
			this.mFG = BGBMIEJJQKC;
			this.ICINPMOHKLF = false;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000095C3 File Offset: 0x000077C3
	// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0000958D File Offset: 0x0000778D
	public float BGBMIEJJQKC
	{
		get
		{
			if (this.BJQOPIEIGDK > 1)
			{
				return Mathf.Round(this.mValue * (float)(this.BJQOPIEIGDK - 1)) / (float)(this.BJQOPIEIGDK - 1);
			}
			return this.mValue;
		}
		set
		{
			this.PJMIKDIEGMB(value, true);
		}
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OOGNLQBOLKB()
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00009597 File Offset: 0x00007797
	public Camera EBCOELFDNLG()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x000095F4 File Offset: 0x000077F4
	public ENFMCDNLEQQ HCKDGNQKDQP()
	{
		return this.mBG;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x000095FC File Offset: 0x000077FC
	protected bool HCODIHFPMKG()
	{
		return this.mFill != BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight && this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00009613 File Offset: 0x00007813
	public void DCDCBBHIFPN(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mFG != BGBMIEJJQKC)
		{
			this.mFG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void GQQBNGCHNEB()
	{
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00009631 File Offset: 0x00007831
	// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00009613 File Offset: 0x00007813
	public ENFMCDNLEQQ LPFDCEEJPIP
	{
		get
		{
			return this.mFG;
		}
		set
		{
			if (this.mFG != value)
			{
				this.mFG = value;
				this.ICINPMOHKLF = true;
			}
		}
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0007900C File Offset: 0x0007720C
	public virtual void JBQCQHMNCHG(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			switch (this.mFill)
			{
			case BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight:
			{
				float bgbmiejjqkc = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.x);
				this.FONJFPIKGEP(bgbmiejjqkc);
				this.mValue = bgbmiejjqkc;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft:
			{
				float bgbmiejjqkc2 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.x);
				this.PLLQOHPCBOP(bgbmiejjqkc2);
				this.mValue = bgbmiejjqkc2;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop:
			{
				float bgbmiejjqkc3 = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.y);
				this.BGBMIEJJQKC = bgbmiejjqkc3;
				this.mValue = bgbmiejjqkc3;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom:
			{
				float bgbmiejjqkc4 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.y);
				this.GIPBBFDPCKG(bgbmiejjqkc4);
				this.mValue = bgbmiejjqkc4;
				break;
			}
			}
		}
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x000790D8 File Offset: 0x000772D8
	public void LODQBMMKNNM()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		this.OOGNLQBOLKB();
		if (Application.isPlaying)
		{
			if (this.mBG != null)
			{
				this.mBG.DENNQPBGNNH = false;
			}
			this.NHONJJHBBEN();
			if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
			{
				BJQGLGOLMPQ.OMQCQCBLQGJ = this;
				EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
				BJQGLGOLMPQ.OMQCQCBLQGJ = null;
			}
		}
		this.JPBONGIEJCN();
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00079154 File Offset: 0x00077354
	public void DQFCDPMMLOO(float QJFQOMOIOOI, bool CKFOHPDLNJK = true)
	{
		QJFQOMOIOOI = Mathf.Clamp01(QJFQOMOIOOI);
		if (this.mValue != QJFQOMOIOOI)
		{
			float bgbmiejjqkc = this.BGBMIEJJQKC;
			this.mValue = QJFQOMOIOOI;
			if (this.PNBOOLEOKCI && bgbmiejjqkc != this.BGBMIEJJQKC)
			{
				if (CKFOHPDLNJK && IKBQNBHOJJB.PBBDNDMELHQ(this) && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00009639 File Offset: 0x00007839
	public BJQGLGOLMPQ.CGLEFJOIIND KQLINDKCLCN()
	{
		return this.mFill;
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x000791C8 File Offset: 0x000773C8
	protected float FQOIFJQGEIN(Vector2 FKGNBOOHNQQ)
	{
		Transform transform = this.BJCQOIEPJDH();
		Plane plane = new Plane(transform.rotation * Vector3.back, transform.position);
		Ray ray = this.NJBGPKPCCEI().ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.HKDJGHOHBFQ();
		}
		return this.NNFMMLECPQL(transform.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00009538 File Offset: 0x00007738
	public void PPJKIOKCQJE(BJQGLGOLMPQ.CGLEFJOIIND BGBMIEJJQKC)
	{
		if (this.mFill != BGBMIEJJQKC)
		{
			this.mFill = BGBMIEJJQKC;
			if (this.PNBOOLEOKCI)
			{
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00079238 File Offset: 0x00077438
	protected void IBQQPKOLJJB(Vector3 PHCMBMCKQDC)
	{
		Transform parent = this.BNELEGPJDGK.parent;
		if (parent != null)
		{
			PHCMBMCKQDC = parent.InverseTransformPoint(PHCMBMCKQDC);
			PHCMBMCKQDC.x = Mathf.Round(PHCMBMCKQDC.x);
			PHCMBMCKQDC.y = Mathf.Round(PHCMBMCKQDC.y);
			PHCMBMCKQDC.z = 1513f;
			if (Vector3.Distance(this.BNELEGPJDGK.localPosition, PHCMBMCKQDC) > 242f)
			{
				this.BNELEGPJDGK.localPosition = PHCMBMCKQDC;
			}
		}
		else if (Vector3.Distance(this.BNELEGPJDGK.position, PHCMBMCKQDC) > 906f)
		{
			this.BNELEGPJDGK.position = PHCMBMCKQDC;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00009641 File Offset: 0x00007841
	public Transform CGDFDPHIENG
	{
		get
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
			}
			return this.BLLEFKOLKLP;
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x000792E0 File Offset: 0x000774E0
	protected void HOGPOQHILGQ()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.GQQBNGCHNEB();
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mValue);
			if (this.mValue != num)
			{
				this.mValue = num;
			}
			if (this.BJQOPIEIGDK < 1)
			{
				this.BJQOPIEIGDK = 1;
			}
			else if (this.BJQOPIEIGDK > -78)
			{
				this.BJQOPIEIGDK = 12;
			}
			this.JPBONGIEJCN();
		}
		else
		{
			float num2 = Mathf.Clamp01(this.mValue);
			if (this.mValue != num2)
			{
				this.mValue = num2;
			}
			if (this.BJQOPIEIGDK < 1)
			{
				this.BJQOPIEIGDK = 1;
			}
			else if (this.BJQOPIEIGDK > 108)
			{
				this.BJQOPIEIGDK = -97;
			}
		}
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0007938C File Offset: 0x0007758C
	protected void NOFJKFODCBN(Vector3 PHCMBMCKQDC)
	{
		Transform parent = this.BNELEGPJDGK.parent;
		if (parent != null)
		{
			PHCMBMCKQDC = parent.InverseTransformPoint(PHCMBMCKQDC);
			PHCMBMCKQDC.x = Mathf.Round(PHCMBMCKQDC.x);
			PHCMBMCKQDC.y = Mathf.Round(PHCMBMCKQDC.y);
			PHCMBMCKQDC.z = 1797f;
			if (Vector3.Distance(this.BNELEGPJDGK.localPosition, PHCMBMCKQDC) > 63f)
			{
				this.BNELEGPJDGK.localPosition = PHCMBMCKQDC;
			}
		}
		else if (Vector3.Distance(this.BNELEGPJDGK.position, PHCMBMCKQDC) > 1235f)
		{
			this.BNELEGPJDGK.position = PHCMBMCKQDC;
		}
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00079434 File Offset: 0x00077634
	protected virtual float NNFMMLECPQL(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return this.BGBMIEJJQKC;
		}
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		Vector3 vector = pigmlpngmno[2] - pigmlpngmno[0];
		if (this.LPKEDQDDCFM)
		{
			float num = (PNNOLPKBHNQ.x - pigmlpngmno[0].x) / vector.x;
			return (!this.IGJHCJQEOLN) ? num : (1f - num);
		}
		float num2 = (PNNOLPKBHNQ.y - pigmlpngmno[0].y) / vector.y;
		return (!this.IGJHCJQEOLN) ? num2 : (1f - num2);
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00009663 File Offset: 0x00007863
	public void EDFPHLCHCHL(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mBG != BGBMIEJJQKC)
		{
			this.mBG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x000794EC File Offset: 0x000776EC
	protected float LGBCIHNJCBF(Vector2 FKGNBOOHNQQ)
	{
		Transform cgdfdphieng = this.CGDFDPHIENG;
		Plane plane = new Plane(cgdfdphieng.rotation * Vector3.back, cgdfdphieng.position);
		Ray ray = this.NJBGPKPCCEI().ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.HKDJGHOHBFQ();
		}
		return this.NNFMMLECPQL(cgdfdphieng.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0007955C File Offset: 0x0007775C
	protected float EOHHNOOCOLJ(Vector2 FKGNBOOHNQQ)
	{
		Transform transform = this.BJCQOIEPJDH();
		Plane plane = new Plane(transform.rotation * Vector3.back, transform.position);
		Ray ray = this.EBCOELFDNLG().ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.BGBMIEJJQKC;
		}
		return this.NNFMMLECPQL(transform.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00009681 File Offset: 0x00007881
	protected bool LPKEDQDDCFM
	{
		get
		{
			return this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight || this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft;
		}
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x000795CC File Offset: 0x000777CC
	protected float EMDNKIONKLN(Vector2 FKGNBOOHNQQ)
	{
		Transform transform = this.BJCQOIEPJDH();
		Plane plane = new Plane(transform.rotation * Vector3.back, transform.position);
		Ray ray = this.DQIHINGNLPN().ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.BGBMIEJJQKC;
		}
		return this.NNFMMLECPQL(transform.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x0007963C File Offset: 0x0007783C
	public void PJMIKDIEGMB(float QJFQOMOIOOI, bool CKFOHPDLNJK = true)
	{
		QJFQOMOIOOI = Mathf.Clamp01(QJFQOMOIOOI);
		if (this.mValue != QJFQOMOIOOI)
		{
			float bgbmiejjqkc = this.BGBMIEJJQKC;
			this.mValue = QJFQOMOIOOI;
			if (this.PNBOOLEOKCI && bgbmiejjqkc != this.BGBMIEJJQKC)
			{
				if (CKFOHPDLNJK && IKBQNBHOJJB.PBBDNDMELHQ(this) && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00009697 File Offset: 0x00007897
	public float HICDDIQLQHL()
	{
		if (this.mFG != null)
		{
			return this.mFG.DIIHJCJOKMP;
		}
		if (this.mBG != null)
		{
			return this.mBG.DIIHJCJOKMP;
		}
		return 1894f;
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x000096D2 File Offset: 0x000078D2
	protected void IGJKHIMGLFH()
	{
		if (this.ICINPMOHKLF)
		{
			this.JPBONGIEJCN();
		}
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x000096E2 File Offset: 0x000078E2
	public void FEEHQHPELMH(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mBG != BGBMIEJJQKC)
		{
			this.mBG = BGBMIEJJQKC;
			this.ICINPMOHKLF = false;
		}
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x000796B0 File Offset: 0x000778B0
	public void HNIJKCKHOFK(float QJFQOMOIOOI, bool CKFOHPDLNJK = true)
	{
		QJFQOMOIOOI = Mathf.Clamp01(QJFQOMOIOOI);
		if (this.mValue != QJFQOMOIOOI)
		{
			float num = this.HKDJGHOHBFQ();
			this.mValue = QJFQOMOIOOI;
			if (this.PNBOOLEOKCI && num != this.BGBMIEJJQKC)
			{
				if (CKFOHPDLNJK && IKBQNBHOJJB.PBBDNDMELHQ(this) && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00009538 File Offset: 0x00007738
	public void KBKLBHBGDGI(BJQGLGOLMPQ.CGLEFJOIIND BGBMIEJJQKC)
	{
		if (this.mFill != BGBMIEJJQKC)
		{
			this.mFill = BGBMIEJJQKC;
			if (this.PNBOOLEOKCI)
			{
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BCJJMIJJLCG()
	{
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x000096D2 File Offset: 0x000078D2
	protected void Update()
	{
		if (this.ICINPMOHKLF)
		{
			this.JPBONGIEJCN();
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06001007 RID: 4103 RVA: 0x000095F4 File Offset: 0x000077F4
	// (set) Token: 0x06001009 RID: 4105 RVA: 0x00009663 File Offset: 0x00007863
	public ENFMCDNLEQQ EQDQQFDQLHH
	{
		get
		{
			return this.mBG;
		}
		set
		{
			if (this.mBG != value)
			{
				this.mBG = value;
				this.ICINPMOHKLF = true;
			}
		}
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x000096D2 File Offset: 0x000078D2
	protected void GKMKINDKNPJ()
	{
		if (this.ICINPMOHKLF)
		{
			this.JPBONGIEJCN();
		}
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00079724 File Offset: 0x00077924
	protected void BMDELFJOGBH()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LJMLKQGKQMN();
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mValue);
			if (this.mValue != num)
			{
				this.mValue = num;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 1;
			}
			else if (this.BJQOPIEIGDK > 109)
			{
				this.BJQOPIEIGDK = -70;
			}
			this.JPBONGIEJCN();
		}
		else
		{
			float num2 = Mathf.Clamp01(this.mValue);
			if (this.mValue != num2)
			{
				this.mValue = num2;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 1;
			}
			else if (this.BJQOPIEIGDK > 120)
			{
				this.BJQOPIEIGDK = -11;
			}
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600100B RID: 4107 RVA: 0x00009597 File Offset: 0x00007797
	public Camera EQOOPGKHOFB
	{
		get
		{
			if (this.OJIDBLEKBBO == null)
			{
				this.OJIDBLEKBBO = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			return this.OJIDBLEKBBO;
		}
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00009700 File Offset: 0x00007900
	protected bool DGNFKNEFIPC()
	{
		return this.mFill != BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight && this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft;
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x000797D0 File Offset: 0x000779D0
	protected float DQMEFFMNQPJ(Vector2 FKGNBOOHNQQ)
	{
		Transform transform = this.BJCQOIEPJDH();
		Plane plane = new Plane(transform.rotation * Vector3.back, transform.position);
		Ray ray = this.EBCOELFDNLG().ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.HKDJGHOHBFQ();
		}
		return this.NNFMMLECPQL(transform.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00009597 File Offset: 0x00007797
	public Camera DQIHINGNLPN()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00009613 File Offset: 0x00007813
	public void BLNKCJGNPEM(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mFG != BGBMIEJJQKC)
		{
			this.mFG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOCKGGGNFKO()
	{
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00009613 File Offset: 0x00007813
	public void FMNQLQCCQEG(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mFG != BGBMIEJJQKC)
		{
			this.mFG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00079840 File Offset: 0x00077A40
	public void JCQCNFLNMNP()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		this.PJGIJLDLIFJ();
		if (Application.isPlaying)
		{
			if (this.mBG != null)
			{
				this.mBG.DENNQPBGNNH = true;
			}
			this.BCJJMIJJLCG();
			if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
			{
				BJQGLGOLMPQ.OMQCQCBLQGJ = this;
				EventDelegate.CDGHNJLPFKN(this.OHEFEKMMIFL);
				BJQGLGOLMPQ.OMQCQCBLQGJ = null;
			}
		}
		this.JPBONGIEJCN();
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x000798BC File Offset: 0x00077ABC
	protected float NKJQMGHFLPG(Vector2 FKGNBOOHNQQ)
	{
		Transform cgdfdphieng = this.CGDFDPHIENG;
		Plane plane = new Plane(cgdfdphieng.rotation * Vector3.back, cgdfdphieng.position);
		Ray ray = this.EQOOPGKHOFB.ScreenPointToRay(FKGNBOOHNQQ);
		float distance;
		if (!plane.Raycast(ray, out distance))
		{
			return this.BGBMIEJJQKC;
		}
		return this.NNFMMLECPQL(cgdfdphieng.InverseTransformPoint(ray.GetPoint(distance)));
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0007992C File Offset: 0x00077B2C
	public virtual void DFBDPGOJHHM(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			switch (this.mFill)
			{
			case BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight:
			{
				float bgbmiejjqkc = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.x);
				this.BGBMIEJJQKC = bgbmiejjqkc;
				this.mValue = bgbmiejjqkc;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft:
			{
				float bgbmiejjqkc2 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.x);
				this.BGBMIEJJQKC = bgbmiejjqkc2;
				this.mValue = bgbmiejjqkc2;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop:
			{
				float bgbmiejjqkc3 = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.y);
				this.BGBMIEJJQKC = bgbmiejjqkc3;
				this.mValue = bgbmiejjqkc3;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom:
			{
				float bgbmiejjqkc4 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.y);
				this.BGBMIEJJQKC = bgbmiejjqkc4;
				this.mValue = bgbmiejjqkc4;
				break;
			}
			}
		}
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void LJMLKQGKQMN()
	{
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600101E RID: 4126 RVA: 0x0000973E File Offset: 0x0000793E
	// (set) Token: 0x06001017 RID: 4119 RVA: 0x000799F8 File Offset: 0x00077BF8
	public float DIIHJCJOKMP
	{
		get
		{
			if (this.mFG != null)
			{
				return this.mFG.DIIHJCJOKMP;
			}
			if (this.mBG != null)
			{
				return this.mBG.DIIHJCJOKMP;
			}
			return 1f;
		}
		set
		{
			if (this.mFG != null)
			{
				this.mFG.DIIHJCJOKMP = value;
				if (this.mFG.GetComponent<Collider>() != null)
				{
					this.mFG.GetComponent<Collider>().enabled = (this.mFG.DIIHJCJOKMP > 0.001f);
				}
				else if (this.mFG.GetComponent<Collider2D>() != null)
				{
					this.mFG.GetComponent<Collider2D>().enabled = (this.mFG.DIIHJCJOKMP > 0.001f);
				}
			}
			if (this.mBG != null)
			{
				this.mBG.DIIHJCJOKMP = value;
				if (this.mBG.GetComponent<Collider>() != null)
				{
					this.mBG.GetComponent<Collider>().enabled = (this.mBG.DIIHJCJOKMP > 0.001f);
				}
				else if (this.mBG.GetComponent<Collider2D>() != null)
				{
					this.mBG.GetComponent<Collider2D>().enabled = (this.mBG.DIIHJCJOKMP > 0.001f);
				}
			}
			if (this.BNELEGPJDGK != null)
			{
				ENFMCDNLEQQ component = this.BNELEGPJDGK.GetComponent<ENFMCDNLEQQ>();
				if (component != null)
				{
					component.DIIHJCJOKMP = value;
					if (component.GetComponent<Collider>() != null)
					{
						component.GetComponent<Collider>().enabled = (component.DIIHJCJOKMP > 0.001f);
					}
					else if (component.GetComponent<Collider2D>() != null)
					{
						component.GetComponent<Collider2D>().enabled = (component.DIIHJCJOKMP > 0.001f);
					}
				}
			}
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00079B8C File Offset: 0x00077D8C
	public void Start()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		this.PJGIJLDLIFJ();
		if (Application.isPlaying)
		{
			if (this.mBG != null)
			{
				this.mBG.DENNQPBGNNH = true;
			}
			this.NHONJJHBBEN();
			if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
			{
				BJQGLGOLMPQ.OMQCQCBLQGJ = this;
				EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
				BJQGLGOLMPQ.OMQCQCBLQGJ = null;
			}
		}
		this.JPBONGIEJCN();
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00079C08 File Offset: 0x00077E08
	public virtual void NEQLNOKMEKM(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled)
		{
			switch (this.mFill)
			{
			case BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight:
			{
				float bgbmiejjqkc = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.x);
				this.BGBMIEJJQKC = bgbmiejjqkc;
				this.mValue = bgbmiejjqkc;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft:
			{
				float bgbmiejjqkc2 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.x);
				this.BGBMIEJJQKC = bgbmiejjqkc2;
				this.mValue = bgbmiejjqkc2;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop:
			{
				float bgbmiejjqkc3 = Mathf.Clamp01(this.mValue + JDOGIQGGLKM.y);
				this.GIPBBFDPCKG(bgbmiejjqkc3);
				this.mValue = bgbmiejjqkc3;
				break;
			}
			case BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom:
			{
				float bgbmiejjqkc4 = Mathf.Clamp01(this.mValue - JDOGIQGGLKM.y);
				this.BGBMIEJJQKC = bgbmiejjqkc4;
				this.mValue = bgbmiejjqkc4;
				break;
			}
			}
		}
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00079CD4 File Offset: 0x00077ED4
	public void GJPGBCKQLDG()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		this.PJGIJLDLIFJ();
		if (Application.isPlaying)
		{
			if (this.mBG != null)
			{
				this.mBG.DENNQPBGNNH = true;
			}
			this.NHONJJHBBEN();
			if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
			{
				BJQGLGOLMPQ.OMQCQCBLQGJ = this;
				EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
				BJQGLGOLMPQ.OMQCQCBLQGJ = null;
			}
		}
		this.JPBONGIEJCN();
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00009597 File Offset: 0x00007797
	public Camera NJBGPKPCCEI()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00009663 File Offset: 0x00007863
	public void IHKEMEPEKCL(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mBG != BGBMIEJJQKC)
		{
			this.mBG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00009734 File Offset: 0x00007934
	public void PLLQOHPCBOP(float BGBMIEJJQKC)
	{
		this.HNIJKCKHOFK(BGBMIEJJQKC, true);
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x000096D2 File Offset: 0x000078D2
	protected void OEFEKHJBGPN()
	{
		if (this.ICINPMOHKLF)
		{
			this.JPBONGIEJCN();
		}
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x00009538 File Offset: 0x00007738
	public void QODNLGDJIGN(BJQGLGOLMPQ.CGLEFJOIIND BGBMIEJJQKC)
	{
		if (this.mFill != BGBMIEJJQKC)
		{
			this.mFill = BGBMIEJJQKC;
			if (this.PNBOOLEOKCI)
			{
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x00009613 File Offset: 0x00007813
	public void PBIJGHJBGHE(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mFG != BGBMIEJJQKC)
		{
			this.mFG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x00009779 File Offset: 0x00007979
	public float HKDJGHOHBFQ()
	{
		if (this.BJQOPIEIGDK > 0)
		{
			return Mathf.Round(this.mValue * (float)(this.BJQOPIEIGDK - 1)) / (float)(this.BJQOPIEIGDK - 0);
		}
		return this.mValue;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x00009641 File Offset: 0x00007841
	public Transform BJCQOIEPJDH()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00009663 File Offset: 0x00007863
	public void JIIEOIIFFNP(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mBG != BGBMIEJJQKC)
		{
			this.mBG = BGBMIEJJQKC;
			this.ICINPMOHKLF = true;
		}
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x000097AA File Offset: 0x000079AA
	public void GIPBBFDPCKG(float BGBMIEJJQKC)
	{
		this.JHLDJFJMIFG(BGBMIEJJQKC, true);
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x000096E2 File Offset: 0x000078E2
	public void JCHOGOLECOF(ENFMCDNLEQQ BGBMIEJJQKC)
	{
		if (this.mBG != BGBMIEJJQKC)
		{
			this.mBG = BGBMIEJJQKC;
			this.ICINPMOHKLF = false;
		}
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x000097B4 File Offset: 0x000079B4
	protected bool LJEBHBGMGKJ()
	{
		return this.mFill != BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight && this.mFill == BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight;
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00079D50 File Offset: 0x00077F50
	public void JHLDJFJMIFG(float QJFQOMOIOOI, bool CKFOHPDLNJK = true)
	{
		QJFQOMOIOOI = Mathf.Clamp01(QJFQOMOIOOI);
		if (this.mValue != QJFQOMOIOOI)
		{
			float num = this.HKDJGHOHBFQ();
			this.mValue = QJFQOMOIOOI;
			if (this.PNBOOLEOKCI && num != this.BGBMIEJJQKC)
			{
				if (CKFOHPDLNJK && IKBQNBHOJJB.PBBDNDMELHQ(this) && EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00079DC4 File Offset: 0x00077FC4
	protected void QIGBEBFFLNO(Vector3 PHCMBMCKQDC)
	{
		Transform parent = this.BNELEGPJDGK.parent;
		if (parent != null)
		{
			PHCMBMCKQDC = parent.InverseTransformPoint(PHCMBMCKQDC);
			PHCMBMCKQDC.x = Mathf.Round(PHCMBMCKQDC.x);
			PHCMBMCKQDC.y = Mathf.Round(PHCMBMCKQDC.y);
			PHCMBMCKQDC.z = 0f;
			if (Vector3.Distance(this.BNELEGPJDGK.localPosition, PHCMBMCKQDC) > 0.001f)
			{
				this.BNELEGPJDGK.localPosition = PHCMBMCKQDC;
			}
		}
		else if (Vector3.Distance(this.BNELEGPJDGK.position, PHCMBMCKQDC) > 1E-05f)
		{
			this.BNELEGPJDGK.position = PHCMBMCKQDC;
		}
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00079E6C File Offset: 0x0007806C
	protected void JINENJHPCLE()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.GQQBNGCHNEB();
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mValue);
			if (this.mValue != num)
			{
				this.mValue = num;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 1;
			}
			else if (this.BJQOPIEIGDK > 57)
			{
				this.BJQOPIEIGDK = 105;
			}
			this.JPBONGIEJCN();
		}
		else
		{
			float num2 = Mathf.Clamp01(this.mValue);
			if (this.mValue != num2)
			{
				this.mValue = num2;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 0;
			}
			else if (this.BJQOPIEIGDK > -71)
			{
				this.BJQOPIEIGDK = 53;
			}
		}
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00009538 File Offset: 0x00007738
	public void JDEOFDNNGQL(BJQGLGOLMPQ.CGLEFJOIIND BGBMIEJJQKC)
	{
		if (this.mFill != BGBMIEJJQKC)
		{
			this.mFill = BGBMIEJJQKC;
			if (this.PNBOOLEOKCI)
			{
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void PJGIJLDLIFJ()
	{
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void NHONJJHBBEN()
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00079F18 File Offset: 0x00078118
	protected void OnValidate()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.PJGIJLDLIFJ();
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mValue);
			if (this.mValue != num)
			{
				this.mValue = num;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 0;
			}
			else if (this.BJQOPIEIGDK > 21)
			{
				this.BJQOPIEIGDK = 21;
			}
			this.JPBONGIEJCN();
		}
		else
		{
			float num2 = Mathf.Clamp01(this.mValue);
			if (this.mValue != num2)
			{
				this.mValue = num2;
			}
			if (this.BJQOPIEIGDK < 0)
			{
				this.BJQOPIEIGDK = 0;
			}
			else if (this.BJQOPIEIGDK > 21)
			{
				this.BJQOPIEIGDK = 21;
			}
		}
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00079FC4 File Offset: 0x000781C4
	public void ODIJQBBOLFI()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = false;
		this.LJMLKQGKQMN();
		if (Application.isPlaying)
		{
			if (this.mBG != null)
			{
				this.mBG.DENNQPBGNNH = true;
			}
			this.BOCKGGGNFKO();
			if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
			{
				BJQGLGOLMPQ.OMQCQCBLQGJ = this;
				EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
				BJQGLGOLMPQ.OMQCQCBLQGJ = null;
			}
		}
		this.JPBONGIEJCN();
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x0000958D File Offset: 0x0000778D
	public void FONJFPIKGEP(float BGBMIEJJQKC)
	{
		this.PJMIKDIEGMB(BGBMIEJJQKC, true);
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0007A040 File Offset: 0x00078240
	public void KIDKPCHILMM(float BGBMIEJJQKC)
	{
		if (this.mFG != null)
		{
			this.mFG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mFG.GetComponent<Collider>() != null)
			{
				this.mFG.GetComponent<Collider>().enabled = (this.mFG.DIIHJCJOKMP > 1568f);
			}
			else if (this.mFG.GetComponent<Collider2D>() != null)
			{
				this.mFG.GetComponent<Collider2D>().enabled = (this.mFG.DIIHJCJOKMP > 318f);
			}
		}
		if (this.mBG != null)
		{
			this.mBG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mBG.GetComponent<Collider>() != null)
			{
				this.mBG.GetComponent<Collider>().enabled = (this.mBG.DIIHJCJOKMP > 945f);
			}
			else if (this.mBG.GetComponent<Collider2D>() != null)
			{
				this.mBG.GetComponent<Collider2D>().enabled = (this.mBG.DIIHJCJOKMP > 534f);
			}
		}
		if (this.BNELEGPJDGK != null)
		{
			ENFMCDNLEQQ component = this.BNELEGPJDGK.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				component.DIIHJCJOKMP = BGBMIEJJQKC;
				if (component.GetComponent<Collider>() != null)
				{
					component.GetComponent<Collider>().enabled = (component.DIIHJCJOKMP > 937f);
				}
				else if (component.GetComponent<Collider2D>() != null)
				{
					component.GetComponent<Collider2D>().enabled = (component.DIIHJCJOKMP > 94f);
				}
			}
		}
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0007A1D4 File Offset: 0x000783D4
	public virtual void JPBONGIEJCN()
	{
		this.ICINPMOHKLF = false;
		bool flag = false;
		if (this.mFG != null)
		{
			PHINQNMFEHC phinqnmfehc = this.mFG as PHINQNMFEHC;
			if (this.LPKEDQDDCFM)
			{
				if (phinqnmfehc != null && phinqnmfehc.DPQFDCNLLPC == PHINQNMFEHC.OFPCLCEBHFL.Filled)
				{
					if (phinqnmfehc.JOGPPPPKFNC == PHINQNMFEHC.MQIMDDINNEQ.Horizontal || phinqnmfehc.JOGPPPPKFNC == PHINQNMFEHC.MQIMDDINNEQ.Vertical)
					{
						phinqnmfehc.JOGPPPPKFNC = PHINQNMFEHC.MQIMDDINNEQ.Horizontal;
						phinqnmfehc.DELNOHEFELI = this.IGJHCJQEOLN;
					}
					phinqnmfehc.KJNJQMLJELI = this.BGBMIEJJQKC;
				}
				else
				{
					this.mFG.EIMQBOICHOP = ((!this.IGJHCJQEOLN) ? new Vector4(0f, 0f, this.BGBMIEJJQKC, 1f) : new Vector4(1f - this.BGBMIEJJQKC, 0f, 1f, 1f));
					this.mFG.enabled = true;
					flag = (this.BGBMIEJJQKC < 0.001f);
				}
			}
			else if (phinqnmfehc != null && phinqnmfehc.DPQFDCNLLPC == PHINQNMFEHC.OFPCLCEBHFL.Filled)
			{
				if (phinqnmfehc.JOGPPPPKFNC == PHINQNMFEHC.MQIMDDINNEQ.Horizontal || phinqnmfehc.JOGPPPPKFNC == PHINQNMFEHC.MQIMDDINNEQ.Vertical)
				{
					phinqnmfehc.JOGPPPPKFNC = PHINQNMFEHC.MQIMDDINNEQ.Vertical;
					phinqnmfehc.DELNOHEFELI = this.IGJHCJQEOLN;
				}
				phinqnmfehc.KJNJQMLJELI = this.BGBMIEJJQKC;
			}
			else
			{
				this.mFG.EIMQBOICHOP = ((!this.IGJHCJQEOLN) ? new Vector4(0f, 0f, 1f, this.BGBMIEJJQKC) : new Vector4(0f, 1f - this.BGBMIEJJQKC, 1f, 1f));
				this.mFG.enabled = true;
				flag = (this.BGBMIEJJQKC < 0.001f);
			}
		}
		if (this.BNELEGPJDGK != null && (this.mFG != null || this.mBG != null))
		{
			Vector3[] array = (!(this.mFG != null)) ? this.mBG.PIGMLPNGMNO : this.mFG.PIGMLPNGMNO;
			Vector4 vector = (!(this.mFG != null)) ? this.mBG.FMGJBHHNDPC : this.mFG.FMGJBHHNDPC;
			Vector3[] array2 = array;
			int num = 0;
			array2[num].x = array2[num].x + vector.x;
			Vector3[] array3 = array;
			int num2 = 1;
			array3[num2].x = array3[num2].x + vector.x;
			Vector3[] array4 = array;
			int num3 = 2;
			array4[num3].x = array4[num3].x - vector.z;
			Vector3[] array5 = array;
			int num4 = 3;
			array5[num4].x = array5[num4].x - vector.z;
			Vector3[] array6 = array;
			int num5 = 0;
			array6[num5].y = array6[num5].y + vector.y;
			Vector3[] array7 = array;
			int num6 = 1;
			array7[num6].y = array7[num6].y - vector.w;
			Vector3[] array8 = array;
			int num7 = 2;
			array8[num7].y = array8[num7].y - vector.w;
			Vector3[] array9 = array;
			int num8 = 3;
			array9[num8].y = array9[num8].y + vector.y;
			Transform transform = (!(this.mFG != null)) ? this.mBG.CGDFDPHIENG : this.mFG.CGDFDPHIENG;
			for (int i = 0; i < 4; i++)
			{
				array[i] = transform.TransformPoint(array[i]);
			}
			if (this.LPKEDQDDCFM)
			{
				Vector3 a = Vector3.Lerp(array[0], array[1], 0.5f);
				Vector3 b = Vector3.Lerp(array[2], array[3], 0.5f);
				this.QIGBEBFFLNO(Vector3.Lerp(a, b, (!this.IGJHCJQEOLN) ? this.BGBMIEJJQKC : (1f - this.BGBMIEJJQKC)));
			}
			else
			{
				Vector3 a2 = Vector3.Lerp(array[0], array[3], 0.5f);
				Vector3 b2 = Vector3.Lerp(array[1], array[2], 0.5f);
				this.QIGBEBFFLNO(Vector3.Lerp(a2, b2, (!this.IGJHCJQEOLN) ? this.BGBMIEJJQKC : (1f - this.BGBMIEJJQKC)));
			}
		}
		if (flag)
		{
			this.mFG.enabled = false;
		}
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0007A61C File Offset: 0x0007881C
	public void LGPJQQMFGDN(float BGBMIEJJQKC)
	{
		if (this.mFG != null)
		{
			this.mFG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mFG.GetComponent<Collider>() != null)
			{
				this.mFG.GetComponent<Collider>().enabled = (this.mFG.DIIHJCJOKMP > 557f);
			}
			else if (this.mFG.GetComponent<Collider2D>() != null)
			{
				this.mFG.GetComponent<Collider2D>().enabled = (this.mFG.DIIHJCJOKMP > 195f);
			}
		}
		if (this.mBG != null)
		{
			this.mBG.DIIHJCJOKMP = BGBMIEJJQKC;
			if (this.mBG.GetComponent<Collider>() != null)
			{
				this.mBG.GetComponent<Collider>().enabled = (this.mBG.DIIHJCJOKMP > 1508f);
			}
			else if (this.mBG.GetComponent<Collider2D>() != null)
			{
				this.mBG.GetComponent<Collider2D>().enabled = (this.mBG.DIIHJCJOKMP > 1237f);
			}
		}
		if (this.BNELEGPJDGK != null)
		{
			ENFMCDNLEQQ component = this.BNELEGPJDGK.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				component.DIIHJCJOKMP = BGBMIEJJQKC;
				if (component.GetComponent<Collider>() != null)
				{
					component.GetComponent<Collider>().enabled = (component.DIIHJCJOKMP > 1755f);
				}
				else if (component.GetComponent<Collider2D>() != null)
				{
					component.GetComponent<Collider2D>().enabled = (component.DIIHJCJOKMP > 193f);
				}
			}
		}
	}

	// Token: 0x040002C7 RID: 711
	public static BJQGLGOLMPQ OMQCQCBLQGJ;

	// Token: 0x040002C8 RID: 712
	public BJQGLGOLMPQ.DEPHCMILFBP QEEHHLPOHGI;

	// Token: 0x040002C9 RID: 713
	public Transform BNELEGPJDGK;

	// Token: 0x040002CA RID: 714
	[SerializeField]
	[HideInInspector]
	protected ENFMCDNLEQQ mBG;

	// Token: 0x040002CB RID: 715
	[HideInInspector]
	[SerializeField]
	protected ENFMCDNLEQQ mFG;

	// Token: 0x040002CC RID: 716
	[SerializeField]
	[HideInInspector]
	protected float mValue = 1f;

	// Token: 0x040002CD RID: 717
	[SerializeField]
	[HideInInspector]
	protected BJQGLGOLMPQ.CGLEFJOIIND mFill;

	// Token: 0x040002CE RID: 718
	[NonSerialized]
	protected bool PNBOOLEOKCI;

	// Token: 0x040002CF RID: 719
	[NonSerialized]
	protected Transform BLLEFKOLKLP;

	// Token: 0x040002D0 RID: 720
	[NonSerialized]
	protected bool ICINPMOHKLF;

	// Token: 0x040002D1 RID: 721
	[NonSerialized]
	protected Camera OJIDBLEKBBO;

	// Token: 0x040002D2 RID: 722
	[NonSerialized]
	protected float ECCFHDNFOGB;

	// Token: 0x040002D3 RID: 723
	public int BJQOPIEIGDK;

	// Token: 0x040002D4 RID: 724
	public List<EventDelegate> OHEFEKMMIFL = new List<EventDelegate>();

	// Token: 0x02000076 RID: 118
	public enum CGLEFJOIIND
	{
		// Token: 0x040002D6 RID: 726
		LeftToRight,
		// Token: 0x040002D7 RID: 727
		RightToLeft,
		// Token: 0x040002D8 RID: 728
		BottomToTop,
		// Token: 0x040002D9 RID: 729
		TopToBottom
	}

	// Token: 0x02000077 RID: 119
	// (Invoke) Token: 0x06001035 RID: 4149
	public delegate void DEPHCMILFBP();
}
