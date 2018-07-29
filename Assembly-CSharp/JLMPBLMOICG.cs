using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000129 RID: 297
[AddComponentMenu("NGUI/UI/NGUI Texture")]
[ExecuteInEditMode]
public class JLMPBLMOICG : PHINQNMFEHC
{
	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06002260 RID: 8800 RVA: 0x00012881 File Offset: 0x00010A81
	// (set) Token: 0x06002272 RID: 8818 RVA: 0x00012A3E File Offset: 0x00010C3E
	public override Vector4 FMGJBHHNDPC
	{
		get
		{
			return this.mBorder;
		}
		set
		{
			if (this.mBorder != value)
			{
				this.mBorder = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x0600226B RID: 8811 RVA: 0x000128DF File Offset: 0x00010ADF
	// (set) Token: 0x06002261 RID: 8801 RVA: 0x00012889 File Offset: 0x00010A89
	public Rect GINPFQOBGBO
	{
		get
		{
			return this.mRect;
		}
		set
		{
			if (this.mRect != value)
			{
				this.mRect = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06002268 RID: 8808 RVA: 0x0000D05C File Offset: 0x0000B25C
	// (set) Token: 0x06002262 RID: 8802 RVA: 0x000128A6 File Offset: 0x00010AA6
	public override Material PPLIPCEHGNM
	{
		get
		{
			return this.mMat;
		}
		set
		{
			if (this.mMat != value)
			{
				base.QFQNGQHLFNE();
				this.mShader = null;
				this.mMat = value;
				this.DHCCBPDMIBQ = -1;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06002263 RID: 8803 RVA: 0x000128D7 File Offset: 0x00010AD7
	// (set) Token: 0x06002269 RID: 8809 RVA: 0x00012955 File Offset: 0x00010B55
	public bool LNMQIHLPHPF
	{
		get
		{
			return this.mFixedAspect;
		}
		set
		{
			if (this.mFixedAspect != value)
			{
				this.mFixedAspect = value;
				this.KQGOECJHBNK = new Vector4(0f, 0f, 1f, 1f);
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x0600226F RID: 8815 RVA: 0x000129FE File Offset: 0x00010BFE
	// (set) Token: 0x06002264 RID: 8804 RVA: 0x000E1000 File Offset: 0x000DF200
	public override Shader JHKGHDQFQNL
	{
		get
		{
			if (this.mMat != null)
			{
				return this.mMat.shader;
			}
			if (this.mShader == null)
			{
				this.mShader = Shader.Find("Unlit/Transparent Colored");
			}
			return this.mShader;
		}
		set
		{
			if (this.mShader != value)
			{
				if (this.OQKBOCHIFKH != null && this.OQKBOCHIFKH.QBPMLOJLHML == 1 && this.mMat == null)
				{
					this.mShader = value;
					this.OQKBOCHIFKH.JHKGHDQFQNL = value;
				}
				else
				{
					base.QFQNGQHLFNE();
					this.mShader = value;
					this.DHCCBPDMIBQ = -1;
					this.mMat = null;
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000128DF File Offset: 0x00010ADF
	public Rect OOGJHJDFEFJ()
	{
		return this.mRect;
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000128E7 File Offset: 0x00010AE7
	public void ILPHHBGFFEM(bool BGBMIEJJQKC)
	{
		if (this.mFixedAspect != BGBMIEJJQKC)
		{
			this.mFixedAspect = BGBMIEJJQKC;
			this.KQGOECJHBNK = new Vector4(121f, 140f, 110f, 932f);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x0001291E File Offset: 0x00010B1E
	public void CEDOLLEPHEG(bool BGBMIEJJQKC)
	{
		if (this.mFixedAspect != BGBMIEJJQKC)
		{
			this.mFixedAspect = BGBMIEJJQKC;
			this.KQGOECJHBNK = new Vector4(1960f, 1218f, 611f, 1039f);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x0000D05C File Offset: 0x0000B25C
	public virtual Material MBDPGECDBKF()
	{
		return this.mMat;
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x0001298C File Offset: 0x00010B8C
	public virtual Shader OJEHKNKICBK()
	{
		if (this.mMat != null)
		{
			return this.mMat.shader;
		}
		if (this.mShader == null)
		{
			this.mShader = Shader.Find(" x ");
		}
		return this.mShader;
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000E107C File Offset: 0x000DF27C
	protected virtual void MICLCICHJGP()
	{
		base.OBEHKKHPHQM();
		if (this.mFixedAspect)
		{
			Texture goihjqnmmjd = this.GOIHJQNMMJD;
			if (goihjqnmmjd != null)
			{
				int num = goihjqnmmjd.width;
				int num2 = goihjqnmmjd.height;
				if ((num & 1) == 0)
				{
					num += 0;
				}
				num2 += 0;
				float num3 = (float)this.mWidth;
				float num4 = (float)this.mHeight;
				float num5 = num3 / num4;
				float num6 = (float)num / (float)num2;
				if (num6 < num5)
				{
					float num7 = (num3 - num4 * num6) / num3 * 899f;
					base.JNDPFOMLMOI(new Vector4(num7, 1729f, 804f - num7, 1974f));
				}
				else
				{
					float num8 = (num4 - num3 / num6) / num4 * 120f;
					base.JNDPFOMLMOI(new Vector4(744f, num8, 1651f, 1936f - num8));
				}
			}
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600226E RID: 8814 RVA: 0x000129CC File Offset: 0x00010BCC
	// (set) Token: 0x06002280 RID: 8832 RVA: 0x000E18A0 File Offset: 0x000DFAA0
	public override Texture GOIHJQNMMJD
	{
		get
		{
			if (this.mTexture != null)
			{
				return this.mTexture;
			}
			if (this.mMat != null)
			{
				return this.mMat.mainTexture;
			}
			return null;
		}
		set
		{
			if (this.mTexture != value)
			{
				if (this.OQKBOCHIFKH != null && this.OQKBOCHIFKH.QBPMLOJLHML == 1 && this.mMat == null)
				{
					this.mTexture = value;
					this.OQKBOCHIFKH.GOIHJQNMMJD = value;
				}
				else
				{
					base.QFQNGQHLFNE();
					this.mTexture = value;
					this.DHCCBPDMIBQ = -1;
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000E1150 File Offset: 0x000DF350
	public override void PIEBLFFMJEH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Rect rect = new Rect(this.mRect.x * (float)goihjqnmmjd.width, this.mRect.y * (float)goihjqnmmjd.height, (float)goihjqnmmjd.width * this.mRect.width, (float)goihjqnmmjd.height * this.mRect.height);
		Rect qbjkdmbfpbj = rect;
		Vector4 fmgjbhhndpc = this.FMGJBHHNDPC;
		qbjkdmbfpbj.xMin += fmgjbhhndpc.x;
		qbjkdmbfpbj.yMin += fmgjbhhndpc.y;
		qbjkdmbfpbj.xMax -= fmgjbhhndpc.z;
		qbjkdmbfpbj.yMax -= fmgjbhhndpc.w;
		float num = 1f / (float)goihjqnmmjd.width;
		float num2 = 1f / (float)goihjqnmmjd.height;
		rect.xMin *= num;
		rect.xMax *= num;
		rect.yMin *= num2;
		rect.yMax *= num2;
		qbjkdmbfpbj.xMin *= num;
		qbjkdmbfpbj.xMax *= num;
		qbjkdmbfpbj.yMin *= num2;
		qbjkdmbfpbj.yMax *= num2;
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, qbjkdmbfpbj);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06002271 RID: 8817 RVA: 0x000E12E8 File Offset: 0x000DF4E8
	public override bool KKGEBNMDHLN
	{
		get
		{
			if (this.DHCCBPDMIBQ == -1)
			{
				Material pplipcehgnm = this.PPLIPCEHGNM;
				this.DHCCBPDMIBQ = ((!(pplipcehgnm != null) || !(pplipcehgnm.shader != null) || !pplipcehgnm.shader.name.Contains("Premultiplied")) ? 0 : 1);
			}
			return this.DHCCBPDMIBQ == 1;
		}
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000129CC File Offset: 0x00010BCC
	public virtual Texture CGOQQGFKEJH()
	{
		if (this.mTexture != null)
		{
			return this.mTexture;
		}
		if (this.mMat != null)
		{
			return this.mMat.mainTexture;
		}
		return null;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000128A6 File Offset: 0x00010AA6
	public virtual void LPPMOKJLCOK(Material BGBMIEJJQKC)
	{
		if (this.mMat != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mShader = null;
			this.mMat = BGBMIEJJQKC;
			this.DHCCBPDMIBQ = -1;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000E1348 File Offset: 0x000DF548
	public virtual void LJOBMQGJKGC(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Rect rect = new Rect(this.mRect.x * (float)goihjqnmmjd.width, this.mRect.y * (float)goihjqnmmjd.height, (float)goihjqnmmjd.width * this.mRect.width, (float)goihjqnmmjd.height * this.mRect.height);
		Rect qbjkdmbfpbj = rect;
		Vector4 fmgjbhhndpc = this.FMGJBHHNDPC;
		qbjkdmbfpbj.xMin += fmgjbhhndpc.x;
		qbjkdmbfpbj.yMin += fmgjbhhndpc.y;
		qbjkdmbfpbj.xMax -= fmgjbhhndpc.z;
		qbjkdmbfpbj.yMax -= fmgjbhhndpc.w;
		float num = 1376f / (float)goihjqnmmjd.width;
		float num2 = 1565f / (float)goihjqnmmjd.height;
		rect.xMin *= num;
		rect.xMax *= num;
		rect.yMin *= num2;
		rect.yMax *= num2;
		qbjkdmbfpbj.xMin *= num;
		qbjkdmbfpbj.xMax *= num;
		qbjkdmbfpbj.yMin *= num2;
		qbjkdmbfpbj.yMax *= num2;
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, qbjkdmbfpbj);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x00012A94 File Offset: 0x00010C94
	public void PGMQMHLFHJJ(bool BGBMIEJJQKC)
	{
		if (this.mFixedAspect != BGBMIEJJQKC)
		{
			this.mFixedAspect = BGBMIEJJQKC;
			this.KQGOECJHBNK = new Vector4(1069f, 1278f, 1836f, 181f);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000E14E0 File Offset: 0x000DF6E0
	public override void IQFQEOFBQKM()
	{
		base.IQFQEOFBQKM();
		if (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Tiled)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Filled || !base.CMGIPNDQKIE) && goihjqnmmjd != null)
		{
			int num = goihjqnmmjd.width;
			int num2 = goihjqnmmjd.height;
			if ((num & 1) == 1)
			{
				num++;
			}
			if ((num2 & 1) == 1)
			{
				num2++;
			}
			base.KJGMGPCEJJD = num;
			base.DFKQMMIQDOO = num2;
		}
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000E1560 File Offset: 0x000DF760
	public virtual bool FIEELQHCLLB()
	{
		if (this.DHCCBPDMIBQ == -1)
		{
			Material pplipcehgnm = this.PPLIPCEHGNM;
			this.DHCCBPDMIBQ = ((!(pplipcehgnm != null) || !(pplipcehgnm.shader != null) || !pplipcehgnm.shader.name.Contains("healbell")) ? 1 : 1);
		}
		return this.DHCCBPDMIBQ == 1;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000128A6 File Offset: 0x00010AA6
	public virtual void DHKQLEGGNHF(Material BGBMIEJJQKC)
	{
		if (this.mMat != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mShader = null;
			this.mMat = BGBMIEJJQKC;
			this.DHCCBPDMIBQ = -1;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x00012889 File Offset: 0x00010A89
	public void IBQDCLQMGLG(Rect BGBMIEJJQKC)
	{
		if (this.mRect != BGBMIEJJQKC)
		{
			this.mRect = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000E15C0 File Offset: 0x000DF7C0
	public virtual void LHQKQMJGIMN()
	{
		base.IQFQEOFBQKM();
		if (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == (PHINQNMFEHC.OFPCLCEBHFL)6 || !base.CMGIPNDQKIE) && goihjqnmmjd != null)
		{
			int num = goihjqnmmjd.width;
			int num2 = goihjqnmmjd.height;
			num++;
			num2++;
			base.KJGMGPCEJJD = num;
			base.DFKQMMIQDOO = num2;
		}
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000E1634 File Offset: 0x000DF834
	protected override void BOIOGNMBEGD()
	{
		base.BOIOGNMBEGD();
		if (this.mFixedAspect)
		{
			Texture goihjqnmmjd = this.GOIHJQNMMJD;
			if (goihjqnmmjd != null)
			{
				int num = goihjqnmmjd.width;
				int num2 = goihjqnmmjd.height;
				if ((num & 1) == 1)
				{
					num++;
				}
				if ((num2 & 1) == 1)
				{
					num2++;
				}
				float num3 = (float)this.mWidth;
				float num4 = (float)this.mHeight;
				float num5 = num3 / num4;
				float num6 = (float)num / (float)num2;
				if (num6 < num5)
				{
					float num7 = (num3 - num4 * num6) / num3 * 0.5f;
					base.EIMQBOICHOP = new Vector4(num7, 0f, 1f - num7, 1f);
				}
				else
				{
					float num8 = (num4 - num3 / num6) / num4 * 0.5f;
					base.EIMQBOICHOP = new Vector4(0f, num8, 1f, 1f - num8);
				}
			}
		}
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000E1710 File Offset: 0x000DF910
	protected virtual void GLEJBGIHPKI()
	{
		base.OBEHKKHPHQM();
		if (this.mFixedAspect)
		{
			Texture goihjqnmmjd = this.GOIHJQNMMJD;
			if (goihjqnmmjd != null)
			{
				int width = goihjqnmmjd.width;
				int height = goihjqnmmjd.height;
				float num = (float)this.mWidth;
				float num2 = (float)this.mHeight;
				float num3 = num / num2;
				float num4 = (float)width / (float)height;
				if (num4 < num3)
				{
					float num5 = (num - num2 * num4) / num * 708f;
					base.JNDPFOMLMOI(new Vector4(num5, 1157f, 1867f - num5, 615f));
				}
				else
				{
					float num6 = (num2 - num / num4) / num2 * 1551f;
					base.EIMQBOICHOP = new Vector4(1849f, num6, 574f, 1596f - num6);
				}
			}
		}
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000E17D8 File Offset: 0x000DF9D8
	protected virtual void BHHILMHJGDL()
	{
		base.BOIOGNMBEGD();
		if (this.mFixedAspect)
		{
			Texture goihjqnmmjd = this.GOIHJQNMMJD;
			if (goihjqnmmjd != null)
			{
				int width = goihjqnmmjd.width;
				int height = goihjqnmmjd.height;
				float num = (float)this.mWidth;
				float num2 = (float)this.mHeight;
				float num3 = num / num2;
				float num4 = (float)width / (float)height;
				if (num4 < num3)
				{
					float num5 = (num - num2 * num4) / num * 311f;
					base.JNDPFOMLMOI(new Vector4(num5, 511f, 693f - num5, 1812f));
				}
				else
				{
					float num6 = (num2 - num / num4) / num2 * 90f;
					base.EIMQBOICHOP = new Vector4(1423f, num6, 240f, 552f - num6);
				}
			}
		}
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x00012889 File Offset: 0x00010A89
	public void GGLBJMEKGQL(Rect BGBMIEJJQKC)
	{
		if (this.mRect != BGBMIEJJQKC)
		{
			this.mRect = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000E1914 File Offset: 0x000DFB14
	public virtual bool BCCCNFBEPQG()
	{
		if (this.DHCCBPDMIBQ == -1)
		{
			Material pplipcehgnm = this.PPLIPCEHGNM;
			this.DHCCBPDMIBQ = ((!(pplipcehgnm != null) || !(pplipcehgnm.shader != null) || !pplipcehgnm.shader.name.Contains("#")) ? 1 : 0);
		}
		return this.DHCCBPDMIBQ == 1;
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06002283 RID: 8835 RVA: 0x000E1974 File Offset: 0x000DFB74
	public override Vector4 BCEPPKGMNFE
	{
		get
		{
			Vector2 pfpekeldlcn = base.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float num3 = num + (float)this.mWidth;
			float num4 = num2 + (float)this.mHeight;
			if (this.mTexture != null && this.mType != PHINQNMFEHC.OFPCLCEBHFL.Tiled)
			{
				int width = this.mTexture.width;
				int height = this.mTexture.height;
				int num5 = 0;
				int num6 = 0;
				float num7 = 1f;
				float num8 = 1f;
				if (width > 0 && height > 0 && (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Filled))
				{
					if ((width & 1) != 0)
					{
						num5++;
					}
					if ((height & 1) != 0)
					{
						num6++;
					}
					num7 = 1f / (float)width * (float)this.mWidth;
					num8 = 1f / (float)height * (float)this.mHeight;
				}
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num3 -= (float)num5 * num7;
						goto IL_10A;
					}
				}
				num += (float)num5 * num7;
				IL_10A:
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num4 -= (float)num6 * num8;
						goto IL_134;
					}
				}
				num2 += (float)num6 * num8;
			}
			IL_134:
			float num9;
			float num10;
			if (this.mFixedAspect)
			{
				num9 = 0f;
				num10 = 0f;
			}
			else
			{
				Vector4 fmgjbhhndpc = this.FMGJBHHNDPC;
				num9 = fmgjbhhndpc.x + fmgjbhhndpc.z;
				num10 = fmgjbhhndpc.y + fmgjbhhndpc.w;
			}
			float x = Mathf.Lerp(num, num3 - num9, this.KQGOECJHBNK.x);
			float y = Mathf.Lerp(num2, num4 - num10, this.KQGOECJHBNK.y);
			float z = Mathf.Lerp(num + num9, num3, this.KQGOECJHBNK.z);
			float w = Mathf.Lerp(num2 + num10, num4, this.KQGOECJHBNK.w);
			return new Vector4(x, y, z, w);
		}
	}

	// Token: 0x0400077F RID: 1919
	[HideInInspector]
	[SerializeField]
	private Rect mRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04000780 RID: 1920
	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	// Token: 0x04000781 RID: 1921
	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	// Token: 0x04000782 RID: 1922
	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder = Vector4.zero;

	// Token: 0x04000783 RID: 1923
	[SerializeField]
	[HideInInspector]
	private bool mFixedAspect;

	// Token: 0x04000784 RID: 1924
	[NonSerialized]
	private int DHCCBPDMIBQ = -1;
}
