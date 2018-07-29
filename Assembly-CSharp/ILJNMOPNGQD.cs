using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
public class ILJNMOPNGQD : PHINQNMFEHC
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000B4884 File Offset: 0x000B2A84
	public override bool KKGEBNMDHLN
	{
		get
		{
			if (this.DHCCBPDMIBQ == -1)
			{
				Shader jhkghdqfqnl = this.JHKGHDQFQNL;
				this.DHCCBPDMIBQ = ((!(jhkghdqfqnl != null) || !jhkghdqfqnl.name.Contains("Premultiplied")) ? 0 : 1);
			}
			return this.DHCCBPDMIBQ == 1;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0000EC48 File Offset: 0x0000CE48
	// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000E9FC File Offset: 0x0000CBFC
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

	// Token: 0x06001B8F RID: 7055 RVA: 0x000B48D0 File Offset: 0x000B2AD0
	public override void PIEBLFFMJEH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Rect rect = (!(this.mSprite != null)) ? new Rect(0f, 0f, (float)goihjqnmmjd.width, (float)goihjqnmmjd.height) : this.mSprite.textureRect;
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

	// Token: 0x06001B90 RID: 7056 RVA: 0x0000EA33 File Offset: 0x0000CC33
	public virtual void ECMHIQOQHFK(Material BGBMIEJJQKC)
	{
		if (this.mMat != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mMat = BGBMIEJJQKC;
			this.DHCCBPDMIBQ = -1;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x000B4A50 File Offset: 0x000B2C50
	public virtual void IJMQJEIGIGH()
	{
		base.IQFQEOFBQKM();
		if (this.mType == (PHINQNMFEHC.OFPCLCEBHFL)6)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || !base.CMGIPNDQKIE) && goihjqnmmjd != null)
		{
			Rect rect = this.mSprite.rect;
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * rect.width);
			int num2 = Mathf.RoundToInt(this.FNMFIPNGENE * rect.height);
			if ((num & 1) == 0)
			{
				num += 0;
			}
			if ((num2 & 1) == 1)
			{
				num2++;
			}
			base.KJGMGPCEJJD = num;
			base.DFKQMMIQDOO = num2;
		}
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x0000EA5D File Offset: 0x0000CC5D
	public virtual void LQLGBCBFJDL(Shader BGBMIEJJQKC)
	{
		if (this.mShader != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mShader = BGBMIEJJQKC;
			if (this.mMat == null)
			{
				this.DHCCBPDMIBQ = -1;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
	public virtual void DCJPPQIQKLJ(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Rect rect = (!(this.mSprite != null)) ? new Rect(968f, 1008f, (float)goihjqnmmjd.width, (float)goihjqnmmjd.height) : this.mSprite.textureRect;
		Rect qbjkdmbfpbj = rect;
		Vector4 fmgjbhhndpc = this.FMGJBHHNDPC;
		qbjkdmbfpbj.xMin += fmgjbhhndpc.x;
		qbjkdmbfpbj.yMin += fmgjbhhndpc.y;
		qbjkdmbfpbj.xMax -= fmgjbhhndpc.z;
		qbjkdmbfpbj.yMax -= fmgjbhhndpc.w;
		float num = 75f / (float)goihjqnmmjd.width;
		float num2 = 577f / (float)goihjqnmmjd.height;
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

	// Token: 0x06001B94 RID: 7060 RVA: 0x0000EA95 File Offset: 0x0000CC95
	public void LDIHGBGMKOB(Sprite BGBMIEJJQKC)
	{
		if (this.mSprite != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mSprite = BGBMIEJJQKC;
			this.PMMJPJPEMDL = null;
			base.KJPQKFEBFDJ();
		}
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x0000EA95 File Offset: 0x0000CC95
	public void KILCCLBPLJF(Sprite BGBMIEJJQKC)
	{
		if (this.mSprite != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mSprite = BGBMIEJJQKC;
			this.PMMJPJPEMDL = null;
			base.KJPQKFEBFDJ();
		}
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x0000D05C File Offset: 0x0000B25C
	public virtual Material GOQMQFJIJCN()
	{
		return this.mMat;
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
	public virtual Shader QCQDQKIPGOE()
	{
		if (this.mMat != null)
		{
			return this.mMat.shader;
		}
		if (this.mShader == null)
		{
			this.mShader = Shader.Find("HidePanel");
		}
		return this.mShader;
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0000EB00 File Offset: 0x0000CD00
	// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000EB10 File Offset: 0x0000CD10
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

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0000EB08 File Offset: 0x0000CD08
	// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0000EA95 File Offset: 0x0000CC95
	public Sprite OILJNPIELOB
	{
		get
		{
			return this.mSprite;
		}
		set
		{
			if (this.mSprite != value)
			{
				base.QFQNGQHLFNE();
				this.mSprite = value;
				this.PMMJPJPEMDL = null;
				base.KJPQKFEBFDJ();
			}
		}
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x0000EB10 File Offset: 0x0000CD10
	public virtual void GBHGOHQDGDB(Vector4 BGBMIEJJQKC)
	{
		if (this.mBorder != BGBMIEJJQKC)
		{
			this.mBorder = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0000D05C File Offset: 0x0000B25C
	// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000EA33 File Offset: 0x0000CC33
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
				this.mMat = value;
				this.DHCCBPDMIBQ = -1;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0000EB52 File Offset: 0x0000CD52
	public override float FNMFIPNGENE
	{
		get
		{
			return this.mPixelSize;
		}
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x0000EB00 File Offset: 0x0000CD00
	public virtual Vector4 KJOGMFCCDKN()
	{
		return this.mBorder;
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000B4C78 File Offset: 0x000B2E78
	public override Vector4 BCEPPKGMNFE
	{
		get
		{
			Vector2 pfpekeldlcn = base.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float num3 = num + (float)this.mWidth;
			float num4 = num2 + (float)this.mHeight;
			if (this.mSprite != null && this.mType != PHINQNMFEHC.OFPCLCEBHFL.Tiled)
			{
				int num5 = Mathf.RoundToInt(this.mSprite.rect.width);
				int num6 = Mathf.RoundToInt(this.mSprite.rect.height);
				int num7 = Mathf.RoundToInt(this.mSprite.textureRectOffset.x);
				int num8 = Mathf.RoundToInt(this.mSprite.textureRectOffset.y);
				int num9 = Mathf.RoundToInt(this.mSprite.rect.width - this.mSprite.textureRect.width - this.mSprite.textureRectOffset.x);
				int num10 = Mathf.RoundToInt(this.mSprite.rect.height - this.mSprite.textureRect.height - this.mSprite.textureRectOffset.y);
				float num11 = 1f;
				float num12 = 1f;
				if (num5 > 0 && num6 > 0 && (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Filled))
				{
					if ((num5 & 1) != 0)
					{
						num9++;
					}
					if ((num6 & 1) != 0)
					{
						num10++;
					}
					num11 = 1f / (float)num5 * (float)this.mWidth;
					num12 = 1f / (float)num6 * (float)this.mHeight;
				}
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num += (float)num7 * num11;
						num3 -= (float)num9 * num11;
						goto IL_1F2;
					}
				}
				num += (float)num9 * num11;
				num3 -= (float)num7 * num11;
				IL_1F2:
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
				{
					if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
					{
						num2 += (float)num8 * num12;
						num4 -= (float)num10 * num12;
						goto IL_230;
					}
				}
				num2 += (float)num10 * num12;
				num4 -= (float)num8 * num12;
			}
			IL_230:
			float num13;
			float num14;
			if (this.mFixedAspect)
			{
				num13 = 0f;
				num14 = 0f;
			}
			else
			{
				Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
				num13 = vector.x + vector.z;
				num14 = vector.y + vector.w;
			}
			float x = Mathf.Lerp(num, num3 - num13, this.KQGOECJHBNK.x);
			float y = Mathf.Lerp(num2, num4 - num14, this.KQGOECJHBNK.y);
			float z = Mathf.Lerp(num + num13, num3, this.KQGOECJHBNK.z);
			float w = Mathf.Lerp(num2 + num14, num4, this.KQGOECJHBNK.w);
			return new Vector4(x, y, z, w);
		}
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x0000EA33 File Offset: 0x0000CC33
	public virtual void FHHKELHDFFJ(Material BGBMIEJJQKC)
	{
		if (this.mMat != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mMat = BGBMIEJJQKC;
			this.DHCCBPDMIBQ = -1;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x000B4F70 File Offset: 0x000B3170
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
			Rect rect = this.mSprite.rect;
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * rect.width);
			int num2 = Mathf.RoundToInt(this.FNMFIPNGENE * rect.height);
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

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0000EC50 File Offset: 0x0000CE50
	// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000EA5D File Offset: 0x0000CC5D
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
				base.QFQNGQHLFNE();
				this.mShader = value;
				if (this.mMat == null)
				{
					this.DHCCBPDMIBQ = -1;
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x0000EB10 File Offset: 0x0000CD10
	public virtual void BGKONDPENKO(Vector4 BGBMIEJJQKC)
	{
		if (this.mBorder != BGBMIEJJQKC)
		{
			this.mBorder = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x0000EB5A File Offset: 0x0000CD5A
	public void BPIOQKPCKBQ(bool BGBMIEJJQKC)
	{
		if (this.mFixedAspect != BGBMIEJJQKC)
		{
			this.mFixedAspect = BGBMIEJJQKC;
			this.KQGOECJHBNK = new Vector4(852f, 1813f, 699f, 1326f);
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000B5018 File Offset: 0x000B3218
	public virtual bool FGHJLHNMPPN()
	{
		if (this.DHCCBPDMIBQ == -1)
		{
			Shader jhkghdqfqnl = this.JHKGHDQFQNL;
			this.DHCCBPDMIBQ = ((!(jhkghdqfqnl != null) || !jhkghdqfqnl.name.Contains("[C]")) ? 0 : 0);
		}
		return this.DHCCBPDMIBQ == 1;
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000B5064 File Offset: 0x000B3264
	public virtual void ODBGJFNPMHJ()
	{
		base.IQFQEOFBQKM();
		if (this.mType == (PHINQNMFEHC.OFPCLCEBHFL)5)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == (PHINQNMFEHC.OFPCLCEBHFL)8 || !base.CMGIPNDQKIE) && goihjqnmmjd != null)
		{
			Rect rect = this.mSprite.rect;
			int kjgmgpcejjd = Mathf.RoundToInt(this.FNMFIPNGENE * rect.width);
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * rect.height);
			if ((num & 1) == 0)
			{
				num += 0;
			}
			base.KJGMGPCEJJD = kjgmgpcejjd;
			base.DFKQMMIQDOO = num;
		}
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x0000EB00 File Offset: 0x0000CD00
	public virtual Vector4 HPFGJCKCQQL()
	{
		return this.mBorder;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x0000EB52 File Offset: 0x0000CD52
	public virtual float BEPFKDLNGOL()
	{
		return this.mPixelSize;
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x000B5100 File Offset: 0x000B3300
	public virtual void NMFPPDEDKPQ()
	{
		base.IQFQEOFBQKM();
		if (this.mType == (PHINQNMFEHC.OFPCLCEBHFL)5)
		{
			return;
		}
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		if ((this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || this.mType == PHINQNMFEHC.OFPCLCEBHFL.Simple || !base.CMGIPNDQKIE) && goihjqnmmjd != null)
		{
			Rect rect = this.mSprite.rect;
			int kjgmgpcejjd = Mathf.RoundToInt(this.FNMFIPNGENE * rect.width);
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * rect.height);
			if ((num & 1) == 0)
			{
				num += 0;
			}
			base.KJGMGPCEJJD = kjgmgpcejjd;
			base.DFKQMMIQDOO = num;
		}
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x0000D05C File Offset: 0x0000B25C
	public virtual Material CQIBJNKQHBH()
	{
		return this.mMat;
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000B519C File Offset: 0x000B339C
	public virtual void KGBFCKKKLDQ()
	{
		base.IQFQEOFBQKM();
		if (this.mType == PHINQNMFEHC.OFPCLCEBHFL.Advanced)
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
			Rect rect = this.mSprite.rect;
			int num = Mathf.RoundToInt(this.FNMFIPNGENE * rect.width);
			int num2 = Mathf.RoundToInt(this.FNMFIPNGENE * rect.height);
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

	// Token: 0x06001BAF RID: 7087 RVA: 0x0000EB08 File Offset: 0x0000CD08
	public Sprite DOPPQFNFCIF()
	{
		return this.mSprite;
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x0000EB10 File Offset: 0x0000CD10
	public virtual void CGMEOHDCGLQ(Vector4 BGBMIEJJQKC)
	{
		if (this.mBorder != BGBMIEJJQKC)
		{
			this.mBorder = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x0000EB91 File Offset: 0x0000CD91
	public virtual Shader ILNNLOJNDPM()
	{
		if (this.mMat != null)
		{
			return this.mMat.shader;
		}
		if (this.mShader == null)
		{
			this.mShader = Shader.Find("\nAre you sure you want to reset its EVs?");
		}
		return this.mShader;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
	public virtual Texture JQMBLEMDOGD()
	{
		if (this.mSprite != null)
		{
			return this.mSprite.texture;
		}
		if (this.mMat != null)
		{
			return this.mMat.mainTexture;
		}
		return null;
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x0000EC08 File Offset: 0x0000CE08
	public virtual Shader DNPCLMNEQJO()
	{
		if (this.mMat != null)
		{
			return this.mMat.shader;
		}
		if (this.mShader == null)
		{
			this.mShader = Shader.Find("Daily Reset\n");
		}
		return this.mShader;
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
	public override Texture GOIHJQNMMJD
	{
		get
		{
			if (this.mSprite != null)
			{
				return this.mSprite.texture;
			}
			if (this.mMat != null)
			{
				return this.mMat.mainTexture;
			}
			return null;
		}
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x0000EA33 File Offset: 0x0000CC33
	public virtual void HFFCCJQQDLC(Material BGBMIEJJQKC)
	{
		if (this.mMat != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mMat = BGBMIEJJQKC;
			this.DHCCBPDMIBQ = -1;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x0000EA95 File Offset: 0x0000CC95
	public void EJFQDKQCLLF(Sprite BGBMIEJJQKC)
	{
		if (this.mSprite != BGBMIEJJQKC)
		{
			base.QFQNGQHLFNE();
			this.mSprite = BGBMIEJJQKC;
			this.PMMJPJPEMDL = null;
			base.KJPQKFEBFDJ();
		}
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000B5244 File Offset: 0x000B3444
	protected override void BOIOGNMBEGD()
	{
		if (this.PMMJPJPEMDL != null)
		{
			if (this.PMMJPJPEMDL != this.mSprite)
			{
				this.OILJNPIELOB = this.PMMJPJPEMDL;
			}
			this.PMMJPJPEMDL = null;
		}
		base.BOIOGNMBEGD();
		if (this.mFixedAspect)
		{
			Texture goihjqnmmjd = this.GOIHJQNMMJD;
			if (goihjqnmmjd != null)
			{
				int num = Mathf.RoundToInt(this.mSprite.rect.width);
				int num2 = Mathf.RoundToInt(this.mSprite.rect.height);
				int num3 = Mathf.RoundToInt(this.mSprite.textureRectOffset.x);
				int num4 = Mathf.RoundToInt(this.mSprite.textureRectOffset.y);
				int num5 = Mathf.RoundToInt(this.mSprite.rect.width - this.mSprite.textureRect.width - this.mSprite.textureRectOffset.x);
				int num6 = Mathf.RoundToInt(this.mSprite.rect.height - this.mSprite.textureRect.height - this.mSprite.textureRectOffset.y);
				num += num3 + num5;
				num2 += num6 + num4;
				float num7 = (float)this.mWidth;
				float num8 = (float)this.mHeight;
				float num9 = num7 / num8;
				float num10 = (float)num / (float)num2;
				if (num10 < num9)
				{
					float num11 = (num7 - num8 * num10) / num7 * 0.5f;
					base.EIMQBOICHOP = new Vector4(num11, 0f, 1f - num11, 1f);
				}
				else
				{
					float num12 = (num8 - num7 / num10) / num8 * 0.5f;
					base.EIMQBOICHOP = new Vector4(0f, num12, 1f, 1f - num12);
				}
			}
		}
	}

	// Token: 0x0400057B RID: 1403
	[SerializeField]
	[HideInInspector]
	private Sprite mSprite;

	// Token: 0x0400057C RID: 1404
	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	// Token: 0x0400057D RID: 1405
	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder = Vector4.zero;

	// Token: 0x0400057E RID: 1406
	[SerializeField]
	[HideInInspector]
	private bool mFixedAspect;

	// Token: 0x0400057F RID: 1407
	[HideInInspector]
	[SerializeField]
	private float mPixelSize = 1f;

	// Token: 0x04000580 RID: 1408
	public Sprite PMMJPJPEMDL;

	// Token: 0x04000581 RID: 1409
	[NonSerialized]
	private int DHCCBPDMIBQ = -1;
}
