using System;
using UnityEngine;

// Token: 0x02000079 RID: 121
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
public class KDIEKDCQIHM : HLEKPGPJOOK
{
	// Token: 0x06001052 RID: 4178 RVA: 0x0000996D File Offset: 0x00007B6D
	public float KPLODONDCJF()
	{
		return this.mSize;
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0007AE58 File Offset: 0x00079058
	protected override void PJGIJLDLIFJ()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Upgraded)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom : BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop);
			}
			this.mDir = KDIEKDCQIHM.GGEIGCNGFIO.Upgraded;
		}
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00009975 File Offset: 0x00007B75
	public float CLENMEELFFO()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0007AEB0 File Offset: 0x000790B0
	protected virtual float EGMJDDBFOGP(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 197f;
		float num2 = num;
		float num3 = 548f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LJEBHBGMGKJ())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[0].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[4].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1473f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[3].y, num3);
			float num5 = num3 - num2;
			if (num5 == 153f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x0000997D File Offset: 0x00007B7D
	public float JKPGMKFKHNO()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06001057 RID: 4183 RVA: 0x0000996D File Offset: 0x00007B6D
	// (set) Token: 0x06001074 RID: 4212 RVA: 0x0007BCC8 File Offset: 0x00079EC8
	public float HMMKKHPFENE
	{
		get
		{
			return this.mSize;
		}
		set
		{
			float num = Mathf.Clamp01(value);
			if (this.mSize != num)
			{
				this.mSize = num;
				this.ICINPMOHKLF = true;
				if (IKBQNBHOJJB.PBBDNDMELHQ(this))
				{
					if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
					{
						BJQGLGOLMPQ.OMQCQCBLQGJ = this;
						EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
						BJQGLGOLMPQ.OMQCQCBLQGJ = null;
					}
					this.JPBONGIEJCN();
				}
			}
		}
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x0000997D File Offset: 0x00007B7D
	public float CMOFQIOKIQJ()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x0007AFF4 File Offset: 0x000791F4
	protected virtual void PFLDQJLBEOI()
	{
		if (this.mDir != (KDIEKDCQIHM.GGEIGCNGFIO)8)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)7) : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)5;
		}
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x0007B04C File Offset: 0x0007924C
	protected virtual float QDOJCCJLKQI(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 1138f;
		float num2 = num;
		float num3 = 951f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.DGNFKNEFIPC())
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[8].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[1].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1616f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[0].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[2].y, pigmlpngmno[0].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1742f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x0007B190 File Offset: 0x00079390
	protected virtual void GCCFKFFIBKB()
	{
		base.NHONJJHBBEN();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.KBFFHOLEMFN));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.PMOBCPEGIHP));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x0007B25C File Offset: 0x0007945C
	protected virtual float IMPNEHGQMKD(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 1102f;
		float num2 = num;
		float num3 = 463f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LPKEDQDDCFM)
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[4].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[8].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1890f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[3].y, pigmlpngmno[7].y, num3);
			float num5 = num3 - num2;
			if (num5 == 506f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x0007B3A0 File Offset: 0x000795A0
	public void BDIGICPIQJI(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x0007B408 File Offset: 0x00079608
	protected virtual float QCGIONNOQHD(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 188f;
		float num2 = num;
		float num3 = 447f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LJEBHBGMGKJ())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[2].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[3].x, num3);
			float num4 = num3 - num2;
			if (num4 == 111f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[6].y, pigmlpngmno[7].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1887f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x0007B54C File Offset: 0x0007974C
	protected override void NHONJJHBBEN()
	{
		base.NHONJJHBBEN();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (!(this.mFG.GetComponent<Collider>() != null) && !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.KBFFHOLEMFN));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.ONLHJHDFIJP));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x0000996D File Offset: 0x00007B6D
	public float CNELMGPLPOF()
	{
		return this.mSize;
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600107E RID: 4222 RVA: 0x00009975 File Offset: 0x00007B75
	// (set) Token: 0x06001061 RID: 4193 RVA: 0x00009985 File Offset: 0x00007B85
	[Obsolete("Use 'value' instead")]
	public float PCHGMPEPFEM
	{
		get
		{
			return base.BGBMIEJJQKC;
		}
		set
		{
			base.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x0007B618 File Offset: 0x00079818
	public virtual void HBICKFBKFJJ()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mSize) * 170f;
			float num2 = Mathf.Lerp(num, 969f - num, base.BGBMIEJJQKC);
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.LJEBHBGMGKJ())
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(num3, 1929f, num4, 1450f) : new Vector4(1016f - num4, 1630f, 182f - num3, 1775f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(85f, num3, 727f, num4) : new Vector4(763f, 1001f - num4, 1805f, 324f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 389f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 1236f));
				base.QIGBEBFFLNO(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00009975 File Offset: 0x00007B75
	public float HFPENMDDGDD()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x0000996D File Offset: 0x00007B6D
	public float GNPFDHFBFQH()
	{
		return this.mSize;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0000998E File Offset: 0x00007B8E
	public void BBHOIMFOMBL(float BGBMIEJJQKC)
	{
		base.PLLQOHPCBOP(BGBMIEJJQKC);
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x0007B770 File Offset: 0x00079970
	protected virtual void FHOECJQFLGM()
	{
		base.ICEQNEJCGOQ();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.DCMFQKFFBIQ(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.FIEFGKHIDHK));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00009997 File Offset: 0x00007B97
	public void BBNHFCDEGHH(float BGBMIEJJQKC)
	{
		base.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x0000996D File Offset: 0x00007B6D
	public float QOCLHFGGNEK()
	{
		return this.mSize;
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x0007B83C File Offset: 0x00079A3C
	protected virtual float IBJMLMPGQPQ(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 1742f;
		float num2 = num;
		float num3 = 1951f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LJEBHBGMGKJ())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[2].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[7].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1192f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[3].y, pigmlpngmno[4].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1131f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00009975 File Offset: 0x00007B75
	public float FEPMEHMGKFH()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x0000996D File Offset: 0x00007B6D
	public float QKFLEEMBCJP()
	{
		return this.mSize;
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0007B3A0 File Offset: 0x000795A0
	public void DLFQJJFOCOC(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x0007B980 File Offset: 0x00079B80
	public override void JPBONGIEJCN()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mSize) * 0.5f;
			float num2 = Mathf.Lerp(num, 1f - num, base.BGBMIEJJQKC);
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.LPKEDQDDCFM)
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(num3, 0f, num4, 1f) : new Vector4(1f - num4, 0f, 1f - num3, 1f));
			}
			else
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(0f, num3, 1f, num4) : new Vector4(0f, 1f - num4, 1f, 1f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 0.5f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 0.5f));
				base.QIGBEBFFLNO(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00009997 File Offset: 0x00007B97
	public void DCJQNKMDJGI(float BGBMIEJJQKC)
	{
		base.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x0007BAD8 File Offset: 0x00079CD8
	protected virtual void KQHEHPMKNON()
	{
		base.OMGNHQDNDPJ();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (!(this.mFG.GetComponent<Collider>() != null) && !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.QMJKDCINICP(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.GLPDJCLFFHF));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.PMOBCPEGIHP));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0000998E File Offset: 0x00007B8E
	public void DINJJMGMOPL(float BGBMIEJJQKC)
	{
		base.PLLQOHPCBOP(BGBMIEJJQKC);
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x0007BBA4 File Offset: 0x00079DA4
	protected virtual void JFGDQOFKLCB()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)4) : BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight);
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)6;
		}
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0007BBFC File Offset: 0x00079DFC
	protected virtual void OHDBEGIOEQF()
	{
		base.GLCJQBKMHEE();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (!(this.mFG.GetComponent<Collider>() != null) && !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.DCMFQKFFBIQ(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.MMCPIHJHIII));
			this.mFG.DENNQPBGNNH = false;
		}
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x0000996D File Offset: 0x00007B6D
	public float FBHNKLQCBOM()
	{
		return this.mSize;
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x0007BD30 File Offset: 0x00079F30
	protected virtual void FMDMLIOEHMC()
	{
		if (this.mDir != (KDIEKDCQIHM.GGEIGCNGFIO)7)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)6) : ((BJQGLGOLMPQ.CGLEFJOIIND)5));
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)4;
		}
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x0007BD88 File Offset: 0x00079F88
	public virtual void LILMBQBQLFB()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mSize) * 876f;
			float num2 = Mathf.Lerp(num, 1072f - num, base.BGBMIEJJQKC);
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(num3, 669f, num4, 433f) : new Vector4(781f - num4, 1775f, 251f - num3, 1312f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(1947f, num3, 714f, num4) : new Vector4(481f, 669f - num4, 1760f, 261f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 1229f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 689f));
				base.QIGBEBFFLNO(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
	protected virtual float MEENIKLPIFO(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 161f;
		float num2 = num;
		float num3 = 637f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LPKEDQDDCFM)
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[7].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[3].x, num3);
			float num4 = num3 - num2;
			if (num4 == 287f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[4].y, pigmlpngmno[3].y, num3);
			float num5 = num3 - num2;
			if (num5 == 780f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x0007C024 File Offset: 0x0007A224
	protected virtual void IDMBNCDMQEK()
	{
		if (this.mDir != (KDIEKDCQIHM.GGEIGCNGFIO)5)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)6) : ((BJQGLGOLMPQ.CGLEFJOIIND)4));
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)8;
		}
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x0007C07C File Offset: 0x0007A27C
	public void BNGKMMFGDFH(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x0000997D File Offset: 0x00007B7D
	public float OKGIKBEFJHD()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x0000998E File Offset: 0x00007B8E
	public void BLFCLKKDLQI(float BGBMIEJJQKC)
	{
		base.PLLQOHPCBOP(BGBMIEJJQKC);
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x0007BCC8 File Offset: 0x00079EC8
	public void HBCQDHIFOLJ(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0007C0E4 File Offset: 0x0007A2E4
	public void DLPFNIEOHFE(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = false;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0007C14C File Offset: 0x0007A34C
	public virtual void PCKOOCDFFKP()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mSize) * 967f;
			float num2 = Mathf.Lerp(num, 1638f - num, base.HKDJGHOHBFQ());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.EIMQBOICHOP = ((!base.HCODIHFPMKG()) ? new Vector4(num3, 1169f, num4, 1978f) : new Vector4(827f - num4, 551f, 1075f - num3, 1865f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.HCODIHFPMKG()) ? new Vector4(194f, num3, 625f, num4) : new Vector4(913f, 1991f - num4, 190f, 335f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 1839f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 353f));
				base.NOFJKFODCBN(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x0007C2A4 File Offset: 0x0007A4A4
	protected virtual float PENJGQHCBQE(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 365f;
		float num2 = num;
		float num3 = 606f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LPKEDQDDCFM)
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[5].x, num3);
			float num4 = num3 - num2;
			if (num4 == 358f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[7].y, pigmlpngmno[0].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1653f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0007C3E8 File Offset: 0x0007A5E8
	protected virtual float BBMDLBMELLG(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 1752f;
		float num2 = num;
		float num3 = 1329f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LPKEDQDDCFM)
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[6].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[1].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1406f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[0].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[4].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1142f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x0007C52C File Offset: 0x0007A72C
	protected virtual void KMHINOIILQF()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Vertical)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)5) : BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop);
			}
			this.mDir = KDIEKDCQIHM.GGEIGCNGFIO.Upgraded;
		}
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x0000996D File Offset: 0x00007B6D
	public float IHNLIDKKJGE()
	{
		return this.mSize;
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x0000998E File Offset: 0x00007B8E
	public void FOLONFKOEEM(float BGBMIEJJQKC)
	{
		base.PLLQOHPCBOP(BGBMIEJJQKC);
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x0007C584 File Offset: 0x0007A784
	protected virtual void PLDJMBGCNPJ()
	{
		base.KKGINFDMEJF();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.NJLOHQMOHIB(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.EFKLBIOBPCD));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x0007C650 File Offset: 0x0007A850
	public virtual void ECHKOECEONQ()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mSize) * 1142f;
			float num2 = Mathf.Lerp(num, 1885f - num, base.HKDJGHOHBFQ());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(num3, 696f, num4, 1745f) : new Vector4(415f - num4, 1133f, 1906f - num3, 1475f));
			}
			else
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(311f, num3, 533f, num4) : new Vector4(151f, 706f - num4, 1966f, 1995f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 301f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 1589f));
				base.QIGBEBFFLNO(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x0007C7A8 File Offset: 0x0007A9A8
	protected virtual void JHFKNPQOJNH()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Upgraded)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)8;
		}
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x0007C07C File Offset: 0x0007A27C
	public void EFDBKPKEFIQ(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.PCQQOFMPKCG(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0007C800 File Offset: 0x0007AA00
	protected virtual void LFCBIEKJNKF()
	{
		base.OMGNHQDNDPJ();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.NJLOHQMOHIB(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.KBFFHOLEMFN));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.ONLHJHDFIJP));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0007C8CC File Offset: 0x0007AACC
	public virtual void PEJOCCMQDDN()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mSize) * 1694f;
			float num2 = Mathf.Lerp(num, 709f - num, base.HKDJGHOHBFQ());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(num3, 290f, num4, 1717f) : new Vector4(819f - num4, 150f, 105f - num3, 1005f));
			}
			else
			{
				this.mFG.EIMQBOICHOP = ((!base.HCODIHFPMKG()) ? new Vector4(1376f, num3, 1616f, num4) : new Vector4(1216f, 1595f - num4, 1515f, 1112f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 540f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 1646f));
				base.NOFJKFODCBN(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00009997 File Offset: 0x00007B97
	public void QHJNCJMNKOF(float BGBMIEJJQKC)
	{
		base.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x0000998E File Offset: 0x00007B8E
	public void CGPJLPCEOMO(float BGBMIEJJQKC)
	{
		base.PLLQOHPCBOP(BGBMIEJJQKC);
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0007CA24 File Offset: 0x0007AC24
	protected override float NNFMMLECPQL(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 0.5f;
		float num2 = num;
		float num3 = 1f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LPKEDQDDCFM)
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, num3);
			float num4 = num3 - num2;
			if (num4 == 0f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[3].y, pigmlpngmno[2].y, num3);
			float num5 = num3 - num2;
			if (num5 == 0f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x0007CB68 File Offset: 0x0007AD68
	protected virtual void PBGJOOHMQLC()
	{
		base.NDCEDEHKMIM();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.BLLDJPCIOLM));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.FIEFGKHIDHK));
			this.mFG.DENNQPBGNNH = true;
		}
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x0007CC34 File Offset: 0x0007AE34
	protected virtual void PNICIMEGKMQ()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)4) : ((BJQGLGOLMPQ.CGLEFJOIIND)5));
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)3;
		}
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x0007BCC8 File Offset: 0x00079EC8
	public void DQKCKCJECLH(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x0007CC8C File Offset: 0x0007AE8C
	protected virtual void FCEDDOBGIBN()
	{
		if (this.mDir != KDIEKDCQIHM.GGEIGCNGFIO.Upgraded)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)5) : ((BJQGLGOLMPQ.CGLEFJOIIND)7));
			}
			this.mDir = (KDIEKDCQIHM.GGEIGCNGFIO)4;
		}
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x0000997D File Offset: 0x00007B7D
	public float HMMGBBQOKJG()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
	protected virtual float GDHLGBJHDHL(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 711f;
		float num2 = num;
		float num3 = 1873f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.DGNFKNEFIPC())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[8].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1559f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[0].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[7].y, pigmlpngmno[6].y, num3);
			float num5 = num3 - num2;
			if (num5 == 399f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x0000996D File Offset: 0x00007B6D
	public float DOOHOMIHFHC()
	{
		return this.mSize;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x0007CE28 File Offset: 0x0007B028
	public virtual void GMCJOIGQKKN()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = false;
			float num = Mathf.Clamp01(this.mSize) * 584f;
			float num2 = Mathf.Lerp(num, 1794f - num, base.HKDJGHOHBFQ());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.LPKEDQDDCFM)
			{
				this.mFG.EIMQBOICHOP = ((!base.IGJHCJQEOLN) ? new Vector4(num3, 1092f, num4, 1488f) : new Vector4(832f - num4, 1598f, 515f - num3, 793f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(793f, num3, 338f, num4) : new Vector4(988f, 1311f - num4, 1246f, 1118f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 1731f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 225f));
				base.IBQQPKOLJJB(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x0007CF80 File Offset: 0x0007B180
	protected virtual void PKDCOHEMDIL()
	{
		base.NDCEDEHKMIM();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.DCMFQKFFBIQ(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.FIEFGKHIDHK));
			this.mFG.DENNQPBGNNH = false;
		}
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x0007D04C File Offset: 0x0007B24C
	protected virtual float POFBMPJGKIJ(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 674f;
		float num2 = num;
		float num3 = 920f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.DGNFKNEFIPC())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[4].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[7].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1412f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[0].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[3].y, pigmlpngmno[1].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1367f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x0007D190 File Offset: 0x0007B390
	protected virtual float EILEPQJLBHO(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 351f;
		float num2 = num;
		float num3 = 1822f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.LJEBHBGMGKJ())
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[6].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[3].x, num3);
			float num4 = num3 - num2;
			if (num4 == 690f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[6].y, pigmlpngmno[0].y, num3);
			float num5 = num3 - num2;
			if (num5 == 1141f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00009997 File Offset: 0x00007B97
	public void DMNCEFHNJCC(float BGBMIEJJQKC)
	{
		base.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x0000997D File Offset: 0x00007B7D
	public float FLEBMMEGNIK()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x00009985 File Offset: 0x00007B85
	public void BQKMJKMHOQC(float BGBMIEJJQKC)
	{
		base.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x00009975 File Offset: 0x00007B75
	public float IPPLDMDPEII()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0000996D File Offset: 0x00007B6D
	public float EFMEIBLQJCQ()
	{
		return this.mSize;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x0007D2D4 File Offset: 0x0007B4D4
	protected virtual float FHNMGLCCKIC(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 16f;
		float num2 = num;
		float num3 = 1575f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.DGNFKNEFIPC())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[0].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[0].x, pigmlpngmno[2].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1749f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[4].y, pigmlpngmno[0].y, num3);
			float num5 = num3 - num2;
			if (num5 == 848f)
			{
				return base.HKDJGHOHBFQ();
			}
			return (!base.HCODIHFPMKG()) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x0007D418 File Offset: 0x0007B618
	public void GOPNBFGPPOL(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = false;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.CDGHNJLPFKN(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0007D480 File Offset: 0x0007B680
	public void BBQOQEONLDC(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = false;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
	public virtual void BLDILNMELFN()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mSize) * 895f;
			float num2 = Mathf.Lerp(num, 1797f - num, base.HKDJGHOHBFQ());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.JNDPFOMLMOI((!base.HCODIHFPMKG()) ? new Vector4(num3, 431f, num4, 1542f) : new Vector4(887f - num4, 1422f, 154f - num3, 1648f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(1197f, num3, 493f, num4) : new Vector4(526f, 307f - num4, 1334f, 943f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 1279f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 1028f));
				base.IBQQPKOLJJB(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0007D640 File Offset: 0x0007B840
	protected virtual void KGCBHCFFMFE()
	{
		if (this.mDir != (KDIEKDCQIHM.GGEIGCNGFIO)8)
		{
			this.mValue = this.mScroll;
			if (this.mDir == KDIEKDCQIHM.GGEIGCNGFIO.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)7) : ((BJQGLGOLMPQ.CGLEFJOIIND)4));
			}
			this.mDir = KDIEKDCQIHM.GGEIGCNGFIO.Upgraded;
		}
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0007D698 File Offset: 0x0007B898
	protected virtual void PJHEKCLGECO()
	{
		base.IINCDBGQHMD();
		if (this.mFG != null && this.mFG.gameObject != base.gameObject)
		{
			if (this.mFG.GetComponent<Collider>() != null || !(this.mFG.GetComponent<Collider2D>() != null))
			{
				return;
			}
			HDLEIMONFCK hdleimonfck = HDLEIMONFCK.QMJKDCINICP(this.mFG.gameObject);
			HDLEIMONFCK hdleimonfck2 = hdleimonfck;
			hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(base.KKKLKEQOKDO));
			HDLEIMONFCK hdleimonfck3 = hdleimonfck;
			hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(base.FIEFGKHIDHK));
			this.mFG.DENNQPBGNNH = false;
		}
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0007D764 File Offset: 0x0007B964
	public void JHFGEPNBGGP(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x0007B3A0 File Offset: 0x000795A0
	public void HMFPMKQJINP(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mSize != num)
		{
			this.mSize = num;
			this.ICINPMOHKLF = true;
			if (IKBQNBHOJJB.PBBDNDMELHQ(this))
			{
				if (BJQGLGOLMPQ.OMQCQCBLQGJ == null && this.OHEFEKMMIFL != null)
				{
					BJQGLGOLMPQ.OMQCQCBLQGJ = this;
					EventDelegate.QGFODQOJBOE(this.OHEFEKMMIFL);
					BJQGLGOLMPQ.OMQCQCBLQGJ = null;
				}
				this.JPBONGIEJCN();
			}
		}
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0007D7CC File Offset: 0x0007B9CC
	protected virtual float LCDNONEGJOK(Vector2 PNNOLPKBHNQ)
	{
		if (!(this.mFG != null))
		{
			return base.NNFMMLECPQL(PNNOLPKBHNQ);
		}
		float num = Mathf.Clamp01(this.mSize) * 558f;
		float num2 = num;
		float num3 = 471f - num;
		Vector3[] pigmlpngmno = this.mFG.PIGMLPNGMNO;
		if (base.DGNFKNEFIPC())
		{
			num2 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[3].x, num2);
			num3 = Mathf.Lerp(pigmlpngmno[1].x, pigmlpngmno[0].x, num3);
			float num4 = num3 - num2;
			if (num4 == 1259f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.x - num2) / num4) : ((num3 - PNNOLPKBHNQ.x) / num4);
		}
		else
		{
			num2 = Mathf.Lerp(pigmlpngmno[0].y, pigmlpngmno[1].y, num2);
			num3 = Mathf.Lerp(pigmlpngmno[3].y, pigmlpngmno[8].y, num3);
			float num5 = num3 - num2;
			if (num5 == 666f)
			{
				return base.BGBMIEJJQKC;
			}
			return (!base.IGJHCJQEOLN) ? ((PNNOLPKBHNQ.y - num2) / num5) : ((num3 - PNNOLPKBHNQ.y) / num5);
		}
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0000997D File Offset: 0x00007B7D
	public float CLQBCHHGCIE()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0007D910 File Offset: 0x0007BB10
	public virtual void DCEPHJCKGQO()
	{
		if (this.mFG != null)
		{
			this.ICINPMOHKLF = true;
			float num = Mathf.Clamp01(this.mSize) * 518f;
			float num2 = Mathf.Lerp(num, 1070f - num, base.BGBMIEJJQKC);
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (base.DGNFKNEFIPC())
			{
				this.mFG.JNDPFOMLMOI((!base.IGJHCJQEOLN) ? new Vector4(num3, 1955f, num4, 105f) : new Vector4(176f - num4, 1703f, 279f - num3, 502f));
			}
			else
			{
				this.mFG.JNDPFOMLMOI((!base.HCODIHFPMKG()) ? new Vector4(604f, num3, 1953f, num4) : new Vector4(1212f, 1267f - num4, 1406f, 1614f - num3));
			}
			if (this.BNELEGPJDGK != null)
			{
				Vector4 bceppkgmnfe = this.mFG.BCEPPKGMNFE;
				Vector3 position = new Vector3(Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, 1585f), Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, 14f));
				base.QIGBEBFFLNO(this.mFG.CGDFDPHIENG.TransformPoint(position));
			}
		}
		else
		{
			base.JPBONGIEJCN();
		}
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0000996D File Offset: 0x00007B6D
	public float JQODIQGMJQB()
	{
		return this.mSize;
	}

	// Token: 0x040002DE RID: 734
	[SerializeField]
	[HideInInspector]
	protected float mSize = 1f;

	// Token: 0x040002DF RID: 735
	[HideInInspector]
	[SerializeField]
	private float mScroll;

	// Token: 0x040002E0 RID: 736
	[HideInInspector]
	[SerializeField]
	private KDIEKDCQIHM.GGEIGCNGFIO mDir = KDIEKDCQIHM.GGEIGCNGFIO.Upgraded;

	// Token: 0x0200007A RID: 122
	private enum GGEIGCNGFIO
	{
		// Token: 0x040002E2 RID: 738
		Horizontal,
		// Token: 0x040002E3 RID: 739
		Vertical,
		// Token: 0x040002E4 RID: 740
		Upgraded
	}
}
