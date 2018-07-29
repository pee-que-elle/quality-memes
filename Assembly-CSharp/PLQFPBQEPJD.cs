using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000121 RID: 289
[AddComponentMenu("NGUI/UI/NGUI Sprite")]
[ExecuteInEditMode]
public class PLQFPBQEPJD : PHINQNMFEHC
{
	// Token: 0x060020E1 RID: 8417 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public virtual void MGDPKCIEOBD(Material BGBMIEJJQKC)
	{
		base.PPLIPCEHGNM = BGBMIEJJQKC;
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x00011CE6 File Offset: 0x0000FEE6
	public virtual bool QEDDMNJBHHE()
	{
		return this.mAtlas != null && this.mAtlas.KKGEBNMDHLN;
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void CICOPKGIQJG(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00011DB5 File Offset: 0x0000FFB5
	// (set) Token: 0x060020E4 RID: 8420 RVA: 0x00011D04 File Offset: 0x0000FF04
	public bool JPKFNEQCQCP
	{
		get
		{
			return this.mApplyGradient;
		}
		set
		{
			if (this.mApplyGradient != value)
			{
				this.mApplyGradient = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06002111 RID: 8465 RVA: 0x000D8654 File Offset: 0x000D6854
	// (set) Token: 0x060020E5 RID: 8421 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public override Texture GOIHJQNMMJD
	{
		get
		{
			Material material = (!(this.mAtlas != null)) ? null : this.mAtlas.MPGCGDBECHM;
			return (!(material != null)) ? null : material.mainTexture;
		}
		set
		{
			base.GOIHJQNMMJD = value;
		}
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000D7BAC File Offset: 0x000D5DAC
	protected void JLBBINBFQCG(UISpriteData QNLEJECLMHB)
	{
		this.LHQDFLPFGME = true;
		this.EJFODFJJCMD = false;
		if (QNLEJECLMHB != null)
		{
			this.LNMJLFLDCML = QNLEJECLMHB;
			this.mSpriteName = this.LNMJLFLDCML.name;
		}
		else
		{
			this.mSpriteName = ((this.LNMJLFLDCML == null) ? string.Empty : this.LNMJLFLDCML.name);
			this.LNMJLFLDCML = QNLEJECLMHB;
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x00011D1C File Offset: 0x0000FF1C
	public virtual float IMOEBPBMIDH()
	{
		return (!(this.mAtlas != null)) ? 21f : this.mAtlas.MMGGEOGQJDL();
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06002139 RID: 8505 RVA: 0x00011D63 File Offset: 0x0000FF63
	// (set) Token: 0x060020E8 RID: 8424 RVA: 0x00011D3E File Offset: 0x0000FF3E
	public Color MBCPMFDMEEQ
	{
		get
		{
			return this.mGradientTop;
		}
		set
		{
			if (this.mGradientTop != value)
			{
				this.mGradientTop = value;
				if (this.mApplyGradient)
				{
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x00011D63 File Offset: 0x0000FF63
	public Color GBNDLKKGCLB()
	{
		return this.mGradientTop;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public virtual void ECMHIQOQHFK(Material BGBMIEJJQKC)
	{
		base.PPLIPCEHGNM = BGBMIEJJQKC;
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000D7C0C File Offset: 0x000D5E0C
	public virtual Vector4 HBMBFGNQCLC()
	{
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData == null)
		{
			return base.FMGJBHHNDPC;
		}
		return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000D7C4C File Offset: 0x000D5E4C
	public UISpriteData GEMEQGBOLIP()
	{
		if (!this.EJFODFJJCMD)
		{
			this.LNMJLFLDCML = null;
		}
		if (this.LNMJLFLDCML == null && this.mAtlas != null)
		{
			if (!string.IsNullOrEmpty(this.mSpriteName))
			{
				UISpriteData uispriteData = this.mAtlas.GMEDHEOGFMB(this.mSpriteName);
				if (uispriteData == null)
				{
					return null;
				}
				this.JKCICCGEFKF(uispriteData);
			}
			if (this.LNMJLFLDCML == null && this.mAtlas.ILDJPQCFIFH.Count > 0)
			{
				UISpriteData uispriteData2 = this.mAtlas.ILDJPQCFIFH[0];
				if (uispriteData2 == null)
				{
					return null;
				}
				this.JKCICCGEFKF(uispriteData2);
				if (this.LNMJLFLDCML == null)
				{
					Debug.LogError(this.mAtlas.name + " seems to have a null sprite!");
					return null;
				}
				this.mSpriteName = this.LNMJLFLDCML.name;
			}
		}
		return this.LNMJLFLDCML;
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void MQOJDPFKILQ(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060020EE RID: 8430 RVA: 0x00011D6B File Offset: 0x0000FF6B
	public bool INEMKLPCLOP
	{
		get
		{
			return this.GEMEQGBOLIP() != null;
		}
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public virtual void CDDDOKPCNJK(Material BGBMIEJJQKC)
	{
		base.PPLIPCEHGNM = BGBMIEJJQKC;
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x00011D79 File Offset: 0x0000FF79
	protected override void FHJOQKCCMDH()
	{
		if (!this.mFillCenter)
		{
			this.mFillCenter = true;
			this.MMNMEHKBLOH = PHINQNMFEHC.OGEQPBCECPM.Invisible;
		}
		base.FHJOQKCCMDH();
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public virtual void HOMHLKDBJQM(Material BGBMIEJJQKC)
	{
		base.PPLIPCEHGNM = BGBMIEJJQKC;
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x00011D04 File Offset: 0x0000FF04
	public void CJOCIEOOQCC(bool BGBMIEJJQKC)
	{
		if (this.mApplyGradient != BGBMIEJJQKC)
		{
			this.mApplyGradient = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x00011D97 File Offset: 0x0000FF97
	public virtual bool EHKKPKQBJLJ()
	{
		return !(this.mAtlas != null) || this.mAtlas.DLBIDCKFOMQ();
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x00011DBD File Offset: 0x0000FFBD
	protected virtual void KIIOFLMKKFQ()
	{
		if (!this.mFillCenter)
		{
			this.mFillCenter = false;
			this.MMNMEHKBLOH = PHINQNMFEHC.OGEQPBCECPM.Sliced;
		}
		base.FHJOQKCCMDH();
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000D7D24 File Offset: 0x000D5F24
	public virtual int DNQOJKFGODP()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Simple)
		{
			if (this.DPQFDCNLLPC != (PHINQNMFEHC.OFPCLCEBHFL)8)
			{
				return base.IPGGCHLFDCF;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.y + vector.w);
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingTop + uispriteData.paddingBottom));
		}
		return Mathf.Max(base.IPGGCHLFDCF, ((num & 1) != 0) ? num : (num + 1));
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000D7DB4 File Offset: 0x000D5FB4
	public virtual int HPLOKPGGCMI()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Filled)
			{
				return base.IPGGCHLFDCF;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.y + vector.w);
		UISpriteData uispriteData = this.GEMEQGBOLIP();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingTop + uispriteData.paddingBottom));
		}
		return Mathf.Max(base.IPGGCHLFDCF, ((num & 1) != 0) ? num : (num + 0));
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x00011DDB File Offset: 0x0000FFDB
	public bool EBJBFDQOJDM()
	{
		return this.DNDHIMFCIQD() == null;
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x00011D63 File Offset: 0x0000FF63
	public Color OQEDFNMNHBK()
	{
		return this.mGradientTop;
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000D7E44 File Offset: 0x000D6044
	public virtual void ODBGJFNPMHJ()
	{
		if (!this.MCJIODQGQJE())
		{
			return;
		}
		base.IQFQEOFBQKM();
		if (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			return;
		}
		UISpriteData uispriteData = this.JNCLIGQMCIQ();
		if (uispriteData == null)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || !uispriteData.CHKJKDCNGNE()) && goihjqnmmjd != null)
		{
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * (float)(uispriteData.width + uispriteData.paddingLeft + uispriteData.paddingRight));
			int num2 = Mathf.RoundToInt(this.FNMFIPNGENE * (float)(uispriteData.height + uispriteData.paddingTop + uispriteData.paddingBottom));
			num++;
			if ((num2 & 1) == 1)
			{
				num2++;
			}
			base.KJGMGPCEJJD = num;
			base.DFKQMMIQDOO = num2;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060020FE RID: 8446 RVA: 0x00011E2F File Offset: 0x0001002F
	// (set) Token: 0x060020FB RID: 8443 RVA: 0x000D7F08 File Offset: 0x000D6108
	public string KCLBMPFIPNQ
	{
		get
		{
			return this.mSpriteName;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				if (string.IsNullOrEmpty(this.mSpriteName))
				{
					return;
				}
				this.mSpriteName = string.Empty;
				this.LNMJLFLDCML = null;
				this.LHQDFLPFGME = true;
				this.EJFODFJJCMD = false;
			}
			else if (this.mSpriteName != value)
			{
				this.mSpriteName = value;
				this.LNMJLFLDCML = null;
				this.LHQDFLPFGME = true;
				this.EJFODFJJCMD = false;
			}
		}
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x00011DE9 File Offset: 0x0000FFE9
	public virtual float MMGGEOGQJDL()
	{
		return (!(this.mAtlas != null)) ? 323f : this.mAtlas.FNMFIPNGENE;
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x00011E0B File Offset: 0x0001000B
	public void MCNJMDBHFLH(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != (this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Sliced))
		{
			this.MMNMEHKBLOH = ((!BGBMIEJJQKC) ? PHINQNMFEHC.OGEQPBCECPM.Invisible : PHINQNMFEHC.OGEQPBCECPM.Sliced);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000D7F78 File Offset: 0x000D6178
	public void OKDFHDLPQEM(BPLKJMJMHFI BGBMIEJJQKC)
	{
		if (this.mAtlas != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mAtlas = BGBMIEJJQKC;
			this.EJFODFJJCMD = false;
			this.LNMJLFLDCML = null;
			if (string.IsNullOrEmpty(this.mSpriteName) && this.mAtlas != null && this.mAtlas.ILDJPQCFIFH.Count > 0)
			{
				this.JLBBINBFQCG(this.mAtlas.ILDJPQCFIFH[0]);
				this.mSpriteName = this.LNMJLFLDCML.name;
			}
			if (!string.IsNullOrEmpty(this.mSpriteName))
			{
				string bgbmiejjqkc = this.mSpriteName;
				this.mSpriteName = string.Empty;
				this.JOHBNEHCEJH(bgbmiejjqkc);
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000D8034 File Offset: 0x000D6234
	public virtual Vector4 LPNKNMOPMKP()
	{
		Vector2 pfpekeldlcn = base.PFPEKELDLCN;
		float num = -pfpekeldlcn.x * (float)this.mWidth;
		float num2 = -pfpekeldlcn.y * (float)this.mHeight;
		float num3 = num + (float)this.mWidth;
		float num4 = num2 + (float)this.mHeight;
		if (this.DNDHIMFCIQD() != null && this.mType != PHINQNMFEHC.OFPCLCEBHFL.Simple)
		{
			int num5 = this.LNMJLFLDCML.paddingLeft;
			int num6 = this.LNMJLFLDCML.paddingBottom;
			int num7 = this.LNMJLFLDCML.paddingRight;
			int num8 = this.LNMJLFLDCML.paddingTop;
			if (this.mType != PHINQNMFEHC.OFPCLCEBHFL.Simple)
			{
				float fnmfipngene = this.FNMFIPNGENE;
				if (fnmfipngene != 396f)
				{
					num5 = Mathf.RoundToInt(fnmfipngene * (float)num5);
					num6 = Mathf.RoundToInt(fnmfipngene * (float)num6);
					num7 = Mathf.RoundToInt(fnmfipngene * (float)num7);
					num8 = Mathf.RoundToInt(fnmfipngene * (float)num8);
				}
			}
			int num9 = this.LNMJLFLDCML.width + num5 + num7;
			int num10 = this.LNMJLFLDCML.height + num6 + num8;
			float num11 = 26f;
			float num12 = 543f;
			if (num9 > 0 && num10 > 1 && (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == (PHINQNMFEHC.OFPCLCEBHFL)5))
			{
				if ((num9 & 1) != 0)
				{
					num7++;
				}
				if ((num10 & 1) != 0)
				{
					num8++;
				}
				num11 = 836f / (float)num9 * (float)this.mWidth;
				num12 = 1073f / (float)num10 * (float)this.mHeight;
			}
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Nothing)
			{
				if (this.mFlip != (PHINQNMFEHC.OOPCCQKNGOC)8)
				{
					num += (float)num5 * num11;
					num3 -= (float)num7 * num11;
					goto IL_19D;
				}
			}
			num += (float)num7 * num11;
			num3 -= (float)num5 * num11;
			IL_19D:
			if (this.mFlip != (PHINQNMFEHC.OOPCCQKNGOC)7)
			{
				if (this.mFlip != (PHINQNMFEHC.OOPCCQKNGOC)6)
				{
					num2 += (float)num6 * num12;
					num4 -= (float)num8 * num12;
					goto IL_1DB;
				}
			}
			num2 += (float)num8 * num12;
			num4 -= (float)num6 * num12;
		}
		IL_1DB:
		Vector4 vector = (!(this.mAtlas != null)) ? Vector4.zero : (this.FMGJBHHNDPC * this.FNMFIPNGENE);
		float num13 = vector.x + vector.z;
		float num14 = vector.y + vector.w;
		float x = Mathf.Lerp(num, num3 - num13, this.KQGOECJHBNK.x);
		float y = Mathf.Lerp(num2, num4 - num14, this.KQGOECJHBNK.y);
		float z = Mathf.Lerp(num + num13, num3, this.KQGOECJHBNK.z);
		float w = Mathf.Lerp(num2 + num14, num4, this.KQGOECJHBNK.w);
		return new Vector4(x, y, z, w);
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000D82D4 File Offset: 0x000D64D4
	public void DPBGHDMHKNC(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = true;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000D8344 File Offset: 0x000D6544
	public void LGJOOQIBQDC(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = false;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x00011E2F File Offset: 0x0001002F
	public string MHQDJEHIOOL()
	{
		return this.mSpriteName;
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06002104 RID: 8452 RVA: 0x000D83B4 File Offset: 0x000D65B4
	public override Vector4 BCEPPKGMNFE
	{
		get
		{
			Vector2 pfpekeldlcn = base.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float num3 = num + (float)this.mWidth;
			float num4 = num2 + (float)this.mHeight;
			if (this.GEMEQGBOLIP() != null && this.mType != PHINQNMFEHC.OFPCLCEBHFL.Tiled)
			{
				int num5 = this.LNMJLFLDCML.paddingLeft;
				int num6 = this.LNMJLFLDCML.paddingBottom;
				int num7 = this.LNMJLFLDCML.paddingRight;
				int num8 = this.LNMJLFLDCML.paddingTop;
				if (this.mType != PHINQNMFEHC.OFPCLCEBHFL.Simple)
				{
					float fnmfipngene = this.FNMFIPNGENE;
					if (fnmfipngene != 1f)
					{
						num5 = Mathf.RoundToInt(fnmfipngene * (float)num5);
						num6 = Mathf.RoundToInt(fnmfipngene * (float)num6);
						num7 = Mathf.RoundToInt(fnmfipngene * (float)num7);
						num8 = Mathf.RoundToInt(fnmfipngene * (float)num8);
					}
				}
				int num9 = this.LNMJLFLDCML.width + num5 + num7;
				int num10 = this.LNMJLFLDCML.height + num6 + num8;
				float num11 = 1f;
				float num12 = 1f;
				if (num9 > 0 && num10 > 0 && (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Filled))
				{
					if ((num9 & 1) != 0)
					{
						num7++;
					}
					if ((num10 & 1) != 0)
					{
						num8++;
					}
					num11 = 1f / (float)num9 * (float)this.mWidth;
					num12 = 1f / (float)num10 * (float)this.mHeight;
				}
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num += (float)num5 * num11;
						num3 -= (float)num7 * num11;
						goto IL_19D;
					}
				}
				num += (float)num7 * num11;
				num3 -= (float)num5 * num11;
				IL_19D:
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num2 += (float)num6 * num12;
						num4 -= (float)num8 * num12;
						goto IL_1DB;
					}
				}
				num2 += (float)num8 * num12;
				num4 -= (float)num6 * num12;
			}
			IL_1DB:
			Vector4 vector = (!(this.mAtlas != null)) ? Vector4.zero : (this.FMGJBHHNDPC * this.FNMFIPNGENE);
			float num13 = vector.x + vector.z;
			float num14 = vector.y + vector.w;
			float x = Mathf.Lerp(num, num3 - num13, this.KQGOECJHBNK.x);
			float y = Mathf.Lerp(num2, num4 - num14, this.KQGOECJHBNK.y);
			float z = Mathf.Lerp(num + num13, num3, this.KQGOECJHBNK.z);
			float w = Mathf.Lerp(num2 + num14, num4, this.KQGOECJHBNK.w);
			return new Vector4(x, y, z, w);
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000D8654 File Offset: 0x000D6854
	public virtual Texture GNQEQPMPKDN()
	{
		Material material = (!(this.mAtlas != null)) ? null : this.mAtlas.MPGCGDBECHM;
		return (!(material != null)) ? null : material.mainTexture;
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x00011D63 File Offset: 0x0000FF63
	public Color JCBIIGHLOLG()
	{
		return this.mGradientTop;
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x0600211A RID: 8474 RVA: 0x000D8B2C File Offset: 0x000D6D2C
	// (set) Token: 0x06002107 RID: 8455 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public override Material PPLIPCEHGNM
	{
		get
		{
			Material pplipcehgnm = base.PPLIPCEHGNM;
			if (pplipcehgnm != null)
			{
				return pplipcehgnm;
			}
			return (!(this.mAtlas != null)) ? null : this.mAtlas.MPGCGDBECHM;
		}
		set
		{
			base.PPLIPCEHGNM = value;
		}
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x00011E37 File Offset: 0x00010037
	public void OJDKOFBHNBP(Color BGBMIEJJQKC)
	{
		if (this.mGradientBottom != BGBMIEJJQKC)
		{
			this.mGradientBottom = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void CPQPCQCNMIM(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x00011E37 File Offset: 0x00010037
	public void GHEQDIPKLGE(Color BGBMIEJJQKC)
	{
		if (this.mGradientBottom != BGBMIEJJQKC)
		{
			this.mGradientBottom = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x00011D04 File Offset: 0x0000FF04
	public void JECCIIHQNNF(bool BGBMIEJJQKC)
	{
		if (this.mApplyGradient != BGBMIEJJQKC)
		{
			this.mApplyGradient = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000D8690 File Offset: 0x000D6890
	public virtual Vector4 LCNPCFJDGJH()
	{
		Vector2 pfpekeldlcn = base.PFPEKELDLCN;
		float num = -pfpekeldlcn.x * (float)this.mWidth;
		float num2 = -pfpekeldlcn.y * (float)this.mHeight;
		float num3 = num + (float)this.mWidth;
		float num4 = num2 + (float)this.mHeight;
		if (this.JNCLIGQMCIQ() != null && this.mType != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			int num5 = this.LNMJLFLDCML.paddingLeft;
			int num6 = this.LNMJLFLDCML.paddingBottom;
			int num7 = this.LNMJLFLDCML.paddingRight;
			int num8 = this.LNMJLFLDCML.paddingTop;
			if (this.mType != PHINQNMFEHC.OFPCLCEBHFL.Simple)
			{
				float fnmfipngene = this.FNMFIPNGENE;
				if (fnmfipngene != 222f)
				{
					num5 = Mathf.RoundToInt(fnmfipngene * (float)num5);
					num6 = Mathf.RoundToInt(fnmfipngene * (float)num6);
					num7 = Mathf.RoundToInt(fnmfipngene * (float)num7);
					num8 = Mathf.RoundToInt(fnmfipngene * (float)num8);
				}
			}
			int num9 = this.LNMJLFLDCML.width + num5 + num7;
			int num10 = this.LNMJLFLDCML.height + num6 + num8;
			float num11 = 140f;
			float num12 = 232f;
			if (num9 > 1 && num10 > 1 && (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Tiled))
			{
				if ((num10 & 1) != 0)
				{
					num8 += 0;
				}
				num11 = 702f / (float)num9 * (float)this.mWidth;
				num12 = 1076f / (float)num10 * (float)this.mHeight;
			}
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
			{
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
				{
					num += (float)num5 * num11;
					num3 -= (float)num7 * num11;
					goto IL_191;
				}
			}
			num += (float)num7 * num11;
			num3 -= (float)num5 * num11;
			IL_191:
			if (this.mFlip != (PHINQNMFEHC.OOPCCQKNGOC)8)
			{
				if (this.mFlip != (PHINQNMFEHC.OOPCCQKNGOC)5)
				{
					num2 += (float)num6 * num12;
					num4 -= (float)num8 * num12;
					goto IL_1CF;
				}
			}
			num2 += (float)num8 * num12;
			num4 -= (float)num6 * num12;
		}
		IL_1CF:
		Vector4 vector = (!(this.mAtlas != null)) ? Vector4.zero : (this.FMGJBHHNDPC * this.FNMFIPNGENE);
		float num13 = vector.x + vector.z;
		float num14 = vector.y + vector.w;
		float x = Mathf.Lerp(num, num3 - num13, this.KQGOECJHBNK.x);
		float y = Mathf.Lerp(num2, num4 - num14, this.KQGOECJHBNK.y);
		float z = Mathf.Lerp(num + num13, num3, this.KQGOECJHBNK.z);
		float w = Mathf.Lerp(num2 + num14, num4, this.KQGOECJHBNK.w);
		return new Vector4(x, y, z, w);
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000D8924 File Offset: 0x000D6B24
	public virtual int MGEBENFLBEB()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			if (this.DPQFDCNLLPC != (PHINQNMFEHC.OFPCLCEBHFL)8)
			{
				return base.QPKCPBJINBK;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.x + vector.z);
		UISpriteData uispriteData = this.JNCLIGQMCIQ();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingLeft + uispriteData.paddingRight));
		}
		return Mathf.Max(base.QPKCPBJINBK, ((num & 1) != 0) ? num : (num + 0));
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000D89B4 File Offset: 0x000D6BB4
	public virtual Vector4 GJHKMJHCPNK()
	{
		UISpriteData uispriteData = this.JNCLIGQMCIQ();
		if (uispriteData == null)
		{
			return base.FMGJBHHNDPC;
		}
		return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void CCEHLBLKGQM(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x00011E6B File Offset: 0x0001006B
	public virtual bool FPLLKIJLEJF()
	{
		return this.mAtlas != null && this.mAtlas.JBKFNQHLLGK();
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x000D89F4 File Offset: 0x000D6BF4
	protected void PPKJJPFHQBP(UISpriteData QNLEJECLMHB)
	{
		this.LHQDFLPFGME = true;
		this.EJFODFJJCMD = true;
		if (QNLEJECLMHB != null)
		{
			this.LNMJLFLDCML = QNLEJECLMHB;
			this.mSpriteName = this.LNMJLFLDCML.name;
		}
		else
		{
			this.mSpriteName = ((this.LNMJLFLDCML == null) ? string.Empty : this.LNMJLFLDCML.name);
			this.LNMJLFLDCML = QNLEJECLMHB;
		}
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000D8654 File Offset: 0x000D6854
	public virtual Texture OIDBLQMGQMF()
	{
		Material material = (!(this.mAtlas != null)) ? null : this.mAtlas.MPGCGDBECHM;
		return (!(material != null)) ? null : material.mainTexture;
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x00011E2F File Offset: 0x0001002F
	public string GDNKLMDBLEO()
	{
		return this.mSpriteName;
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x00011D04 File Offset: 0x0000FF04
	public void EHCEGPFDNPO(bool BGBMIEJJQKC)
	{
		if (this.mApplyGradient != BGBMIEJJQKC)
		{
			this.mApplyGradient = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x000D8A54 File Offset: 0x000D6C54
	public UISpriteData JNCLIGQMCIQ()
	{
		if (!this.EJFODFJJCMD)
		{
			this.LNMJLFLDCML = null;
		}
		if (this.LNMJLFLDCML == null && this.mAtlas != null)
		{
			if (!string.IsNullOrEmpty(this.mSpriteName))
			{
				UISpriteData uispriteData = this.mAtlas.KPQNNOJJKDO(this.mSpriteName);
				if (uispriteData == null)
				{
					return null;
				}
				this.JLBBINBFQCG(uispriteData);
			}
			if (this.LNMJLFLDCML == null && this.mAtlas.ILDJPQCFIFH.Count > 0)
			{
				UISpriteData uispriteData2 = this.mAtlas.ILDJPQCFIFH[0];
				if (uispriteData2 == null)
				{
					return null;
				}
				this.PPKJJPFHQBP(uispriteData2);
				if (this.LNMJLFLDCML == null)
				{
					Debug.LogError(this.mAtlas.name + "BuffIcon_SuperRepel");
					return null;
				}
				this.mSpriteName = this.LNMJLFLDCML.name;
			}
		}
		return this.LNMJLFLDCML;
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x00011D3E File Offset: 0x0000FF3E
	public void QKJIJGCQGPI(Color BGBMIEJJQKC)
	{
		if (this.mGradientTop != BGBMIEJJQKC)
		{
			this.mGradientTop = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000D89F4 File Offset: 0x000D6BF4
	protected void JKCICCGEFKF(UISpriteData QNLEJECLMHB)
	{
		this.LHQDFLPFGME = true;
		this.EJFODFJJCMD = true;
		if (QNLEJECLMHB != null)
		{
			this.LNMJLFLDCML = QNLEJECLMHB;
			this.mSpriteName = this.LNMJLFLDCML.name;
		}
		else
		{
			this.mSpriteName = ((this.LNMJLFLDCML == null) ? string.Empty : this.LNMJLFLDCML.name);
			this.LNMJLFLDCML = QNLEJECLMHB;
		}
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00011E2F File Offset: 0x0001002F
	public string MHINCMBDLCB()
	{
		return this.mSpriteName;
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x0600214B RID: 8523 RVA: 0x00011F06 File Offset: 0x00010106
	// (set) Token: 0x0600211C RID: 8476 RVA: 0x00011E89 File Offset: 0x00010089
	[Obsolete("Use 'centerType' instead")]
	public bool MPLMHFPEFIN
	{
		get
		{
			return this.MMNMEHKBLOH != PHINQNMFEHC.OGEQPBCECPM.Invisible;
		}
		set
		{
			if (value != (this.MMNMEHKBLOH != PHINQNMFEHC.OGEQPBCECPM.Invisible))
			{
				this.MMNMEHKBLOH = ((!value) ? PHINQNMFEHC.OGEQPBCECPM.Invisible : PHINQNMFEHC.OGEQPBCECPM.Sliced);
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x00011E2F File Offset: 0x0001002F
	public string HQDQLOQPCOD()
	{
		return this.mSpriteName;
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x0600214A RID: 8522 RVA: 0x00012002 File Offset: 0x00010202
	// (set) Token: 0x0600211E RID: 8478 RVA: 0x000D8B68 File Offset: 0x000D6D68
	public BPLKJMJMHFI QKGJDCFCPMO
	{
		get
		{
			return this.mAtlas;
		}
		set
		{
			if (this.mAtlas != value)
			{
				base.QFQNGQHLFNE();
				this.mAtlas = value;
				this.EJFODFJJCMD = false;
				this.LNMJLFLDCML = null;
				if (string.IsNullOrEmpty(this.mSpriteName) && this.mAtlas != null && this.mAtlas.ILDJPQCFIFH.Count > 0)
				{
					this.JKCICCGEFKF(this.mAtlas.ILDJPQCFIFH[0]);
					this.mSpriteName = this.LNMJLFLDCML.name;
				}
				if (!string.IsNullOrEmpty(this.mSpriteName))
				{
					string kclbmpfipnq = this.mSpriteName;
					this.mSpriteName = string.Empty;
					this.KCLBMPFIPNQ = kclbmpfipnq;
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000D8C24 File Offset: 0x000D6E24
	public override void IQFQEOFBQKM()
	{
		if (!this.INEMKLPCLOP)
		{
			return;
		}
		base.IQFQEOFBQKM();
		if (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Tiled)
		{
			return;
		}
		UISpriteData uispriteData = this.GEMEQGBOLIP();
		if (uispriteData == null)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Filled || !uispriteData.hasBorder) && goihjqnmmjd != null)
		{
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * (float)(uispriteData.width + uispriteData.paddingLeft + uispriteData.paddingRight));
			int num2 = Mathf.RoundToInt(this.FNMFIPNGENE * (float)(uispriteData.height + uispriteData.paddingTop + uispriteData.paddingBottom));
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

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06002120 RID: 8480 RVA: 0x000D8CF0 File Offset: 0x000D6EF0
	public override int IPGGCHLFDCF
	{
		get
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
			{
				if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Advanced)
				{
					return base.IPGGCHLFDCF;
				}
			}
			float fnmfipngene = this.FNMFIPNGENE;
			Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
			int num = Mathf.RoundToInt(vector.y + vector.w);
			UISpriteData uispriteData = this.GEMEQGBOLIP();
			if (uispriteData != null)
			{
				num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingTop + uispriteData.paddingBottom));
			}
			return Mathf.Max(base.IPGGCHLFDCF, ((num & 1) != 1) ? num : (num + 1));
		}
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x00011EAD File Offset: 0x000100AD
	protected virtual void NPDIBOKHDQJ()
	{
		if (!this.mFillCenter)
		{
			this.mFillCenter = false;
			this.MMNMEHKBLOH = PHINQNMFEHC.OGEQPBCECPM.Invisible;
		}
		base.NGFIIINICEC();
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x00011ECB File Offset: 0x000100CB
	protected virtual void OKKFQEJJKPI()
	{
		base.OBEHKKHPHQM();
		if (this.LHQDFLPFGME || !this.EJFODFJJCMD)
		{
			this.EJFODFJJCMD = false;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
		}
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x00011D63 File Offset: 0x0000FF63
	public Color QCPCMCPNLEO()
	{
		return this.mGradientTop;
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000D8D80 File Offset: 0x000D6F80
	public virtual int MMQOGFKKQIC()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Simple)
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Tiled)
			{
				return base.IPGGCHLFDCF;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.y + vector.w);
		UISpriteData uispriteData = this.GEMEQGBOLIP();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingTop + uispriteData.paddingBottom));
		}
		return Mathf.Max(base.IPGGCHLFDCF, num + 1);
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06002125 RID: 8485 RVA: 0x00011CE6 File Offset: 0x0000FEE6
	public override bool KKGEBNMDHLN
	{
		get
		{
			return this.mAtlas != null && this.mAtlas.KKGEBNMDHLN;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06002126 RID: 8486 RVA: 0x000D8E08 File Offset: 0x000D7008
	public override int QPKCPBJINBK
	{
		get
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
			{
				if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Advanced)
				{
					return base.QPKCPBJINBK;
				}
			}
			float fnmfipngene = this.FNMFIPNGENE;
			Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
			int num = Mathf.RoundToInt(vector.x + vector.z);
			UISpriteData uispriteData = this.GEMEQGBOLIP();
			if (uispriteData != null)
			{
				num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingLeft + uispriteData.paddingRight));
			}
			return Mathf.Max(base.QPKCPBJINBK, ((num & 1) != 1) ? num : (num + 1));
		}
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x00011EF8 File Offset: 0x000100F8
	public bool GODHLFCLELM()
	{
		return this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Sliced;
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000D8E98 File Offset: 0x000D7098
	public virtual void FNJJPPJBCIE(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = this.QKGJDCFCPMO.KPQNNOJJKDO(this.KCLBMPFIPNQ);
		}
		if (this.LNMJLFLDCML == null)
		{
			return;
		}
		Rect rect = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
		Rect rect2 = new Rect((float)(this.LNMJLFLDCML.x + this.LNMJLFLDCML.borderLeft), (float)(this.LNMJLFLDCML.y + this.LNMJLFLDCML.borderTop), (float)(this.LNMJLFLDCML.width - this.LNMJLFLDCML.borderLeft - this.LNMJLFLDCML.borderRight), (float)(this.LNMJLFLDCML.height - this.LNMJLFLDCML.borderBottom - this.LNMJLFLDCML.borderTop));
		rect = JNNGOIIKENH.NFBOPKDICDF(rect, goihjqnmmjd.width, goihjqnmmjd.height);
		rect2 = JNNGOIIKENH.NFBOPKDICDF(rect2, goihjqnmmjd.width, goihjqnmmjd.height);
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, rect2);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x00011F06 File Offset: 0x00010106
	public bool PDKNKDDQJCB()
	{
		return this.MMNMEHKBLOH != PHINQNMFEHC.OGEQPBCECPM.Invisible;
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void BMLHHFKDEOQ(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x0600212B RID: 8491 RVA: 0x00011F14 File Offset: 0x00010114
	// (set) Token: 0x06002147 RID: 8519 RVA: 0x00011E37 File Offset: 0x00010037
	public Color QEQOQOOCEEN
	{
		get
		{
			return this.mGradientBottom;
		}
		set
		{
			if (this.mGradientBottom != value)
			{
				this.mGradientBottom = value;
				if (this.mApplyGradient)
				{
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x00011F1C File Offset: 0x0001011C
	public virtual float GPDBMDJNMGC()
	{
		return (!(this.mAtlas != null)) ? 439f : this.mAtlas.FNMFIPNGENE;
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000D8FE4 File Offset: 0x000D71E4
	public void JLENFJGDNFN(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = false;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000D9054 File Offset: 0x000D7254
	public virtual int IPLJINNMEKE()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
		{
			if (this.DPQFDCNLLPC != (PHINQNMFEHC.OFPCLCEBHFL)8)
			{
				return base.QPKCPBJINBK;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.x + vector.z);
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingLeft + uispriteData.paddingRight));
		}
		return Mathf.Max(base.QPKCPBJINBK, num);
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x00011F14 File Offset: 0x00010114
	public Color QBHQJHPHFCL()
	{
		return this.mGradientBottom;
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x00011F3E File Offset: 0x0001013E
	public void NPPKBFDIBCD(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != (this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Sliced))
		{
			this.MMNMEHKBLOH = ((!BGBMIEJJQKC) ? PHINQNMFEHC.OGEQPBCECPM.Sliced : PHINQNMFEHC.OGEQPBCECPM.Invisible);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public virtual void EEOKPKEBGHI(Material BGBMIEJJQKC)
	{
		base.PPLIPCEHGNM = BGBMIEJJQKC;
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x000D90D8 File Offset: 0x000D72D8
	public virtual void NNJKCKGIMEL(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = this.QKGJDCFCPMO.KPQNNOJJKDO(this.GQKEMOHHIMK());
		}
		if (this.LNMJLFLDCML == null)
		{
			return;
		}
		Rect rect = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
		Rect rect2 = new Rect((float)(this.LNMJLFLDCML.x + this.LNMJLFLDCML.borderLeft), (float)(this.LNMJLFLDCML.y + this.LNMJLFLDCML.borderTop), (float)(this.LNMJLFLDCML.width - this.LNMJLFLDCML.borderLeft - this.LNMJLFLDCML.borderRight), (float)(this.LNMJLFLDCML.height - this.LNMJLFLDCML.borderBottom - this.LNMJLFLDCML.borderTop));
		rect = JNNGOIIKENH.NFBOPKDICDF(rect, goihjqnmmjd.width, goihjqnmmjd.height);
		rect2 = JNNGOIIKENH.NFBOPKDICDF(rect2, goihjqnmmjd.width, goihjqnmmjd.height);
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, rect2);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public virtual void IONGLGJFJEE(Texture BGBMIEJJQKC)
	{
		base.GOIHJQNMMJD = BGBMIEJJQKC;
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000D9224 File Offset: 0x000D7424
	public virtual Vector4 FOIJHGPBKOO()
	{
		UISpriteData uispriteData = this.GEMEQGBOLIP();
		if (uispriteData == null)
		{
			return base.FMGJBHHNDPC;
		}
		return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x00011DDB File Offset: 0x0000FFDB
	public bool MCJIODQGQJE()
	{
		return this.DNDHIMFCIQD() == null;
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x000D9264 File Offset: 0x000D7464
	public void IQBBDKFDGGP(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = true;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x00011E2F File Offset: 0x0001002F
	public string GQKEMOHHIMK()
	{
		return this.mSpriteName;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000D92D4 File Offset: 0x000D74D4
	public virtual void EQLGBDEJGHK(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = this.QKGJDCFCPMO.GMEDHEOGFMB(this.HQDQLOQPCOD());
		}
		if (this.LNMJLFLDCML == null)
		{
			return;
		}
		Rect rect = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
		Rect rect2 = new Rect((float)(this.LNMJLFLDCML.x + this.LNMJLFLDCML.borderLeft), (float)(this.LNMJLFLDCML.y + this.LNMJLFLDCML.borderTop), (float)(this.LNMJLFLDCML.width - this.LNMJLFLDCML.borderLeft - this.LNMJLFLDCML.borderRight), (float)(this.LNMJLFLDCML.height - this.LNMJLFLDCML.borderBottom - this.LNMJLFLDCML.borderTop));
		rect = JNNGOIIKENH.NFBOPKDICDF(rect, goihjqnmmjd.width, goihjqnmmjd.height);
		rect2 = JNNGOIIKENH.NFBOPKDICDF(rect2, goihjqnmmjd.width, goihjqnmmjd.height);
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, rect2);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x0600213A RID: 8506 RVA: 0x00011F62 File Offset: 0x00010162
	public override float FNMFIPNGENE
	{
		get
		{
			return (!(this.mAtlas != null)) ? 1f : this.mAtlas.FNMFIPNGENE;
		}
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000D9420 File Offset: 0x000D7620
	public void JOHBNEHCEJH(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = true;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000D7C0C File Offset: 0x000D5E0C
	public virtual Vector4 CICECIKPBIF()
	{
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData == null)
		{
			return base.FMGJBHHNDPC;
		}
		return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x000D9490 File Offset: 0x000D7690
	public virtual Texture DBHQBQGBFEL()
	{
		Material material = (!(this.mAtlas != null)) ? null : this.mAtlas.DDQOOEJDMDG();
		return (!(material != null)) ? null : material.mainTexture;
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x000D8654 File Offset: 0x000D6854
	public virtual Texture GNGNKKNPNIB()
	{
		Material material = (!(this.mAtlas != null)) ? null : this.mAtlas.MPGCGDBECHM;
		return (!(material != null)) ? null : material.mainTexture;
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00011F84 File Offset: 0x00010184
	protected virtual void MICLCICHJGP()
	{
		base.BOIOGNMBEGD();
		if (this.LHQDFLPFGME || !this.EJFODFJJCMD)
		{
			this.EJFODFJJCMD = false;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
		}
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x00011F14 File Offset: 0x00010114
	public Color BNQLCMOHKHF()
	{
		return this.mGradientBottom;
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x00011ECB File Offset: 0x000100CB
	protected virtual void EHMMIDNLENF()
	{
		base.OBEHKKHPHQM();
		if (this.LHQDFLPFGME || !this.EJFODFJJCMD)
		{
			this.EJFODFJJCMD = false;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
		}
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x00011D97 File Offset: 0x0000FF97
	public virtual bool JCKNHCJHFGC()
	{
		return !(this.mAtlas != null) || this.mAtlas.DLBIDCKFOMQ();
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x00011E37 File Offset: 0x00010037
	public void HCDJHLHQDEI(Color BGBMIEJJQKC)
	{
		if (this.mGradientBottom != BGBMIEJJQKC)
		{
			this.mGradientBottom = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000D7C0C File Offset: 0x000D5E0C
	public virtual Vector4 IMPIOELIDPP()
	{
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData == null)
		{
			return base.FMGJBHHNDPC;
		}
		return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x00011FB1 File Offset: 0x000101B1
	protected override void BOIOGNMBEGD()
	{
		base.BOIOGNMBEGD();
		if (this.LHQDFLPFGME || !this.EJFODFJJCMD)
		{
			this.EJFODFJJCMD = true;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
		}
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000D94CC File Offset: 0x000D76CC
	public override void PIEBLFFMJEH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if (this.LNMJLFLDCML == null)
		{
			this.LNMJLFLDCML = this.QKGJDCFCPMO.GMEDHEOGFMB(this.KCLBMPFIPNQ);
		}
		if (this.LNMJLFLDCML == null)
		{
			return;
		}
		Rect rect = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
		Rect rect2 = new Rect((float)(this.LNMJLFLDCML.x + this.LNMJLFLDCML.borderLeft), (float)(this.LNMJLFLDCML.y + this.LNMJLFLDCML.borderTop), (float)(this.LNMJLFLDCML.width - this.LNMJLFLDCML.borderLeft - this.LNMJLFLDCML.borderRight), (float)(this.LNMJLFLDCML.height - this.LNMJLFLDCML.borderBottom - this.LNMJLFLDCML.borderTop));
		rect = JNNGOIIKENH.NFBOPKDICDF(rect, goihjqnmmjd.width, goihjqnmmjd.height);
		rect2 = JNNGOIIKENH.NFBOPKDICDF(rect2, goihjqnmmjd.width, goihjqnmmjd.height);
		int count = EQINHIFFOGG.Count;
		base.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, rect, rect2);
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, count, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x00011FDE File Offset: 0x000101DE
	public void NFIOEEQPJMO(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC != (this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Invisible))
		{
			this.MMNMEHKBLOH = ((!BGBMIEJJQKC) ? PHINQNMFEHC.OGEQPBCECPM.Invisible : PHINQNMFEHC.OGEQPBCECPM.Sliced);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000D9618 File Offset: 0x000D7818
	public UISpriteData DNDHIMFCIQD()
	{
		if (!this.EJFODFJJCMD)
		{
			this.LNMJLFLDCML = null;
		}
		if (this.LNMJLFLDCML == null && this.mAtlas != null)
		{
			if (!string.IsNullOrEmpty(this.mSpriteName))
			{
				UISpriteData uispriteData = this.mAtlas.GMEDHEOGFMB(this.mSpriteName);
				if (uispriteData == null)
				{
					return null;
				}
				this.PPKJJPFHQBP(uispriteData);
			}
			if (this.LNMJLFLDCML == null && this.mAtlas.ILDJPQCFIFH.Count > 0)
			{
				UISpriteData uispriteData2 = this.mAtlas.ILDJPQCFIFH[1];
				if (uispriteData2 == null)
				{
					return null;
				}
				this.JKCICCGEFKF(uispriteData2);
				if (this.LNMJLFLDCML == null)
				{
					Debug.LogError(this.mAtlas.name + "NPC");
					return null;
				}
				this.mSpriteName = this.LNMJLFLDCML.name;
			}
		}
		return this.LNMJLFLDCML;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x000D9264 File Offset: 0x000D7464
	public void OGQLCMOFLLQ(string BGBMIEJJQKC)
	{
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (string.IsNullOrEmpty(this.mSpriteName))
			{
				return;
			}
			this.mSpriteName = string.Empty;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = true;
			this.EJFODFJJCMD = true;
		}
		else if (this.mSpriteName != BGBMIEJJQKC)
		{
			this.mSpriteName = BGBMIEJJQKC;
			this.LNMJLFLDCML = null;
			this.LHQDFLPFGME = false;
			this.EJFODFJJCMD = false;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x0600214D RID: 8525 RVA: 0x000D9224 File Offset: 0x000D7424
	public override Vector4 FMGJBHHNDPC
	{
		get
		{
			UISpriteData uispriteData = this.GEMEQGBOLIP();
			if (uispriteData == null)
			{
				return base.FMGJBHHNDPC;
			}
			return new Vector4((float)uispriteData.borderLeft, (float)uispriteData.borderBottom, (float)uispriteData.borderRight, (float)uispriteData.borderTop);
		}
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x00011EF8 File Offset: 0x000100F8
	public bool BNDMINLBFQB()
	{
		return this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Sliced;
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x000D96F0 File Offset: 0x000D78F0
	public virtual int OMMILEQFQGO()
	{
		if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Simple)
		{
			if (this.DPQFDCNLLPC != (PHINQNMFEHC.OFPCLCEBHFL)8)
			{
				return base.IPGGCHLFDCF;
			}
		}
		float fnmfipngene = this.FNMFIPNGENE;
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		int num = Mathf.RoundToInt(vector.y + vector.w);
		UISpriteData uispriteData = this.DNDHIMFCIQD();
		if (uispriteData != null)
		{
			num += Mathf.RoundToInt(fnmfipngene * (float)(uispriteData.paddingTop + uispriteData.paddingBottom));
		}
		return Mathf.Max(base.IPGGCHLFDCF, num);
	}

	// Token: 0x0400073A RID: 1850
	[SerializeField]
	[HideInInspector]
	private BPLKJMJMHFI mAtlas;

	// Token: 0x0400073B RID: 1851
	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	// Token: 0x0400073C RID: 1852
	[HideInInspector]
	[SerializeField]
	private bool mFillCenter = true;

	// Token: 0x0400073D RID: 1853
	[NonSerialized]
	protected UISpriteData LNMJLFLDCML;

	// Token: 0x0400073E RID: 1854
	[NonSerialized]
	private bool EJFODFJJCMD;
}
