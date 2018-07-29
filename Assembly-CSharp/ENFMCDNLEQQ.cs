using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Widget")]
public class ENFMCDNLEQQ : BLMNBILNMOE
{
	// Token: 0x06001820 RID: 6176 RVA: 0x0000CF43 File Offset: 0x0000B143
	public void GGBDQIMHMID()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			IKBQNBHOJJB.DDHFKDFHCQB(base.gameObject);
		}
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x000A8A28 File Offset: 0x000A6C28
	public bool GMFDMDNCDPQ(int DQLNIPIGLHK)
	{
		float num = this.DBQOIOGLLEF(DQLNIPIGLHK);
		if (this.LKJJKDODNED && this.DPDJNDDDEID != num)
		{
			this.LHQDFLPFGME = true;
		}
		this.DPDJNDDDEID = num;
		if (this.LHQDFLPFGME)
		{
			if (this.LKJJKDODNED && num > 0.001f && this.JHKGHDQFQNL != null)
			{
				bool kgifpcddibg = this.BPDNIHLBLOI.KGIFPCDDIBG;
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.CPLBKPNNHJG();
					this.PIEBLFFMJEH(this.BPDNIHLBLOI.EQINHIFFOGG, this.BPDNIHLBLOI.PICFCJNMJMC, this.BPDNIHLBLOI.HQOONBPDFHO);
				}
				if (this.BPDNIHLBLOI.KGIFPCDDIBG)
				{
					if (this.HDHEFGEGQJI != DQLNIPIGLHK)
					{
						this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
						this.HDHEFGEGQJI = DQLNIPIGLHK;
					}
					this.BPDNIHLBLOI.IKCIPIQDPMI(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
					this.POBHIFPCEEJ = false;
					this.LHQDFLPFGME = false;
					return true;
				}
				this.LHQDFLPFGME = false;
				return kgifpcddibg;
			}
			else if (this.BPDNIHLBLOI.KGIFPCDDIBG)
			{
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.CPLBKPNNHJG();
				}
				this.POBHIFPCEEJ = false;
				this.LHQDFLPFGME = false;
				return true;
			}
		}
		else if (this.POBHIFPCEEJ && this.BPDNIHLBLOI.KGIFPCDDIBG)
		{
			if (this.HDHEFGEGQJI != DQLNIPIGLHK)
			{
				this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
				this.HDHEFGEGQJI = DQLNIPIGLHK;
			}
			this.BPDNIHLBLOI.IKCIPIQDPMI(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
			this.POBHIFPCEEJ = false;
			this.LHQDFLPFGME = false;
			return true;
		}
		this.POBHIFPCEEJ = false;
		this.LHQDFLPFGME = false;
		return false;
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x000A8BFC File Offset: 0x000A6DFC
	public void MGQIGGNBBBD(int BGBMIEJJQKC)
	{
		int ipggchlfdcf = this.IPGGCHLFDCF;
		if (BGBMIEJJQKC < ipggchlfdcf)
		{
			BGBMIEJJQKC = ipggchlfdcf;
		}
		if (this.mHeight != BGBMIEJJQKC && this.BPKBNCGBEDK != ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnWidth)
		{
			if (this.MQKHMKGCJLC)
			{
				if (this.LBGJKGDECCN.target != null && this.NOPCJFECJDP.target != null)
				{
					if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Top)
					{
						if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight)
						{
							if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
							{
								if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Top)
								{
									int num = BGBMIEJJQKC - this.mHeight;
									num -= (num & 0);
									if (num != 0)
									{
										JNNGOIIKENH.EBNIMDGIINO(this, 914f, (float)(-(float)num) * 25f, 1978f, (float)num * 735f);
										return;
									}
									return;
								}
							}
							JNNGOIIKENH.EBNIMDGIINO(this, 197f, (float)(this.mHeight - BGBMIEJJQKC), 21f, 317f);
							return;
						}
					}
					JNNGOIIKENH.EBNIMDGIINO(this, 47f, 633f, 993f, (float)(BGBMIEJJQKC - this.mHeight));
				}
				else if (this.LBGJKGDECCN.target != null)
				{
					JNNGOIIKENH.EBNIMDGIINO(this, 1936f, 979f, 1757f, (float)(BGBMIEJJQKC - this.mHeight));
				}
				else
				{
					JNNGOIIKENH.EBNIMDGIINO(this, 1863f, (float)(this.mHeight - BGBMIEJJQKC), 1796f, 936f);
				}
			}
			else
			{
				this.MJCOMHHDPGG(this.mWidth, BGBMIEJJQKC);
			}
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06001843 RID: 6211 RVA: 0x0000D05C File Offset: 0x0000B25C
	// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000CF58 File Offset: 0x0000B158
	public virtual Material PPLIPCEHGNM
	{
		get
		{
			return this.mMat;
		}
		set
		{
			if (this.mMat != value)
			{
				this.QFQNGQHLFNE();
				this.mMat = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06001824 RID: 6180 RVA: 0x000A8D84 File Offset: 0x000A6F84
	public override Vector3[] PIGMLPNGMNO
	{
		get
		{
			Vector2 pfpekeldlcn = this.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float x = num + (float)this.mWidth;
			float y = num2 + (float)this.mHeight;
			this.NCCGLODEOEE[0] = new Vector3(num, num2);
			this.NCCGLODEOEE[1] = new Vector3(num, y);
			this.NCCGLODEOEE[2] = new Vector3(x, y);
			this.NCCGLODEOEE[3] = new Vector3(x, num2);
			return this.NCCGLODEOEE;
		}
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x000A8E38 File Offset: 0x000A7038
	public override void LOIPCGLJGPI(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO)
	{
		Vector2 pfpekeldlcn = this.PFPEKELDLCN;
		float num = Mathf.Lerp(DGKOIGOLHDM, DGKOIGOLHDM + KJGMGPCEJJD, pfpekeldlcn.x);
		float num2 = Mathf.Lerp(DDLQKFDFMCJ, DDLQKFDFMCJ + DFKQMMIQDOO, pfpekeldlcn.y);
		int num3 = Mathf.FloorToInt(KJGMGPCEJJD + 0.5f);
		int num4 = Mathf.FloorToInt(DFKQMMIQDOO + 0.5f);
		if (pfpekeldlcn.x == 0.5f)
		{
			num3 = num3 >> 1 << 1;
		}
		if (pfpekeldlcn.y == 0.5f)
		{
			num4 = num4 >> 1 << 1;
		}
		Transform transform = base.CGDFDPHIENG;
		Vector3 localPosition = transform.localPosition;
		localPosition.x = Mathf.Floor(num + 0.5f);
		localPosition.y = Mathf.Floor(num2 + 0.5f);
		if (num3 < this.QPKCPBJINBK)
		{
			num3 = this.QPKCPBJINBK;
		}
		if (num4 < this.IPGGCHLFDCF)
		{
			num4 = this.IPGGCHLFDCF;
		}
		transform.localPosition = localPosition;
		this.KJGMGPCEJJD = num3;
		this.DFKQMMIQDOO = num4;
		if (base.IEEHOJCLFDJ)
		{
			transform = transform.parent;
			if (this.HJDMKGDLJEP.target)
			{
				this.HJDMKGDLJEP.JHOBHJMCDIO(transform, DGKOIGOLHDM);
			}
			if (this.HKPCCMEEHDL.target)
			{
				this.HKPCCMEEHDL.JHOBHJMCDIO(transform, DGKOIGOLHDM + KJGMGPCEJJD);
			}
			if (this.LBGJKGDECCN.target)
			{
				this.LBGJKGDECCN.QLDIPJFBNGC(transform, DDLQKFDFMCJ);
			}
			if (this.NOPCJFECJDP.target)
			{
				this.NOPCJFECJDP.QLDIPJFBNGC(transform, DDLQKFDFMCJ + DFKQMMIQDOO);
			}
		}
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x000A8FC0 File Offset: 0x000A71C0
	public virtual Vector2 JHPQQBMGNQM()
	{
		Vector3[] pigmlpngmno = this.PIGMLPNGMNO;
		return pigmlpngmno[8] - pigmlpngmno[0];
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x0000CF7B File Offset: 0x0000B17B
	private void OnDestroy()
	{
		this.QFQNGQHLFNE();
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06001828 RID: 6184 RVA: 0x000A8FF8 File Offset: 0x000A71F8
	// (set) Token: 0x06001872 RID: 6258 RVA: 0x0000D1F3 File Offset: 0x0000B3F3
	public virtual Texture GOIHJQNMMJD
	{
		get
		{
			Material pplipcehgnm = this.PPLIPCEHGNM;
			return (!(pplipcehgnm != null)) ? null : pplipcehgnm.mainTexture;
		}
		set
		{
			throw new NotImplementedException(base.GetType() + " has no mainTexture setter");
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06001835 RID: 6197 RVA: 0x0000CFF2 File Offset: 0x0000B1F2
	// (set) Token: 0x06001829 RID: 6185 RVA: 0x00002300 File Offset: 0x00000500
	public virtual Vector4 FMGJBHHNDPC
	{
		get
		{
			return Vector4.zero;
		}
		set
		{
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06001878 RID: 6264 RVA: 0x0000CFAE File Offset: 0x0000B1AE
	// (set) Token: 0x0600182A RID: 6186 RVA: 0x000A9020 File Offset: 0x000A7220
	public int DFKQMMIQDOO
	{
		get
		{
			return this.mHeight;
		}
		set
		{
			int ipggchlfdcf = this.IPGGCHLFDCF;
			if (value < ipggchlfdcf)
			{
				value = ipggchlfdcf;
			}
			if (this.mHeight != value && this.BPKBNCGBEDK != ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnWidth)
			{
				if (this.MQKHMKGCJLC)
				{
					if (this.LBGJKGDECCN.target != null && this.NOPCJFECJDP.target != null)
					{
						if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Bottom)
						{
							if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight)
							{
								if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Top)
								{
									if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight)
									{
										int num = value - this.mHeight;
										num -= (num & 1);
										if (num != 0)
										{
											JNNGOIIKENH.EBNIMDGIINO(this, 0f, (float)(-(float)num) * 0.5f, 0f, (float)num * 0.5f);
											return;
										}
										return;
									}
								}
								JNNGOIIKENH.EBNIMDGIINO(this, 0f, (float)(this.mHeight - value), 0f, 0f);
								return;
							}
						}
						JNNGOIIKENH.EBNIMDGIINO(this, 0f, 0f, 0f, (float)(value - this.mHeight));
					}
					else if (this.LBGJKGDECCN.target != null)
					{
						JNNGOIIKENH.EBNIMDGIINO(this, 0f, 0f, 0f, (float)(value - this.mHeight));
					}
					else
					{
						JNNGOIIKENH.EBNIMDGIINO(this, 0f, (float)(this.mHeight - value), 0f, 0f);
					}
				}
				else
				{
					this.MJCOMHHDPGG(this.mWidth, value);
				}
			}
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06001831 RID: 6193 RVA: 0x0000CFC9 File Offset: 0x0000B1C9
	// (set) Token: 0x0600182B RID: 6187 RVA: 0x000A91A8 File Offset: 0x000A73A8
	public ENFMCDNLEQQ.GGBIQFIQQCM OEJCHHFIQDC
	{
		get
		{
			return this.mPivot;
		}
		set
		{
			if (this.mPivot != value)
			{
				Vector3 vector = this.PMCNQICHCLE[0];
				this.mPivot = value;
				this.LHQDFLPFGME = true;
				Vector3 vector2 = this.PMCNQICHCLE[0];
				Transform cgdfdphieng = base.CGDFDPHIENG;
				Vector3 vector3 = cgdfdphieng.position;
				float z = cgdfdphieng.localPosition.z;
				vector3.x += vector.x - vector2.x;
				vector3.y += vector.y - vector2.y;
				base.CGDFDPHIENG.position = vector3;
				vector3 = base.CGDFDPHIENG.localPosition;
				vector3.x = Mathf.Round(vector3.x);
				vector3.y = Mathf.Round(vector3.y);
				vector3.z = z;
				base.CGDFDPHIENG.localPosition = vector3;
			}
		}
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x0000CF83 File Offset: 0x0000B183
	public void JNDPFOMLMOI(Vector4 BGBMIEJJQKC)
	{
		if (this.KQGOECJHBNK != BGBMIEJJQKC)
		{
			this.KQGOECJHBNK = BGBMIEJJQKC;
			if (this.DENNQPBGNNH)
			{
				this.KOJBOOBNCHM();
			}
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x000A92A0 File Offset: 0x000A74A0
	public bool LNJENQDNOOD()
	{
		BoxCollider x = base.GetComponent<Collider>() as BoxCollider;
		return x != null || base.GetComponent<BoxCollider2D>() != null;
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x0000CFAE File Offset: 0x0000B1AE
	public int JKGBHEHKBPC()
	{
		return this.mHeight;
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x0600182F RID: 6191 RVA: 0x0000CFB6 File Offset: 0x0000B1B6
	public Vector3 BHOBEDOHIBH
	{
		get
		{
			return base.CGDFDPHIENG.TransformPoint(this.LGEQLMBOIBH);
		}
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x000A92D0 File Offset: 0x000A74D0
	public void MJCOMHHDPGG(int OKQHFQFJGCH, int ONOGHDLFKLH)
	{
		if (this.mWidth != OKQHFQFJGCH || this.mHeight != ONOGHDLFKLH)
		{
			this.mWidth = OKQHFQFJGCH;
			this.mHeight = ONOGHDLFKLH;
			if (this.BPKBNCGBEDK == ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnWidth)
			{
				this.mHeight = Mathf.RoundToInt((float)this.mWidth / this.FHNFGMNKCCP);
			}
			else if (this.BPKBNCGBEDK == ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnHeight)
			{
				this.mWidth = Mathf.RoundToInt((float)this.mHeight * this.FHNFGMNKCCP);
			}
			else if (this.BPKBNCGBEDK == ENFMCDNLEQQ.EHKJPCIJNJG.Free)
			{
				this.FHNFGMNKCCP = (float)this.mWidth / (float)this.mHeight;
			}
			this.POBHIFPCEEJ = true;
			if (this.DENNQPBGNNH)
			{
				this.KOJBOOBNCHM();
			}
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x0000CFD1 File Offset: 0x0000B1D1
	protected override void NHONJJHBBEN()
	{
		this.KJPQKFEBFDJ();
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x000A9380 File Offset: 0x000A7580
	public virtual void MEQPFOLBKIF(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO)
	{
		Vector2 pfpekeldlcn = this.PFPEKELDLCN;
		float num = Mathf.Lerp(DGKOIGOLHDM, DGKOIGOLHDM + KJGMGPCEJJD, pfpekeldlcn.x);
		float num2 = Mathf.Lerp(DDLQKFDFMCJ, DDLQKFDFMCJ + DFKQMMIQDOO, pfpekeldlcn.y);
		int num3 = Mathf.FloorToInt(KJGMGPCEJJD + 1946f);
		int num4 = Mathf.FloorToInt(DFKQMMIQDOO + 1310f);
		if (pfpekeldlcn.x == 1049f)
		{
			num3 = num3 >> 0 << 1;
		}
		if (pfpekeldlcn.y == 1895f)
		{
			num4 = num4 >> 1 << 1;
		}
		Transform transform = base.CGDFDPHIENG;
		Vector3 localPosition = transform.localPosition;
		localPosition.x = Mathf.Floor(num + 996f);
		localPosition.y = Mathf.Floor(num2 + 1425f);
		if (num3 < this.QPKCPBJINBK)
		{
			num3 = this.QPKCPBJINBK;
		}
		if (num4 < this.IPGGCHLFDCF)
		{
			num4 = this.IPGGCHLFDCF;
		}
		transform.localPosition = localPosition;
		this.KJGMGPCEJJD = num3;
		this.DFKQMMIQDOO = num4;
		if (base.IEEHOJCLFDJ)
		{
			transform = transform.parent;
			if (this.HJDMKGDLJEP.target)
			{
				this.HJDMKGDLJEP.JHOBHJMCDIO(transform, DGKOIGOLHDM);
			}
			if (this.HKPCCMEEHDL.target)
			{
				this.HKPCCMEEHDL.JHOBHJMCDIO(transform, DGKOIGOLHDM + KJGMGPCEJJD);
			}
			if (this.LBGJKGDECCN.target)
			{
				this.LBGJKGDECCN.JPCQOJEKMLO(transform, DDLQKFDFMCJ);
			}
			if (this.NOPCJFECJDP.target)
			{
				this.NOPCJFECJDP.FEEHLJLLFJB(transform, DDLQKFDFMCJ + DFKQMMIQDOO);
			}
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06001834 RID: 6196 RVA: 0x0000CFDA File Offset: 0x0000B1DA
	public bool KGIFPCDDIBG
	{
		get
		{
			return this.BPDNIHLBLOI != null && this.BPDNIHLBLOI.KGIFPCDDIBG;
		}
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x0000CFF9 File Offset: 0x0000B1F9
	protected virtual void OBEHKKHPHQM()
	{
		if (this.BCHNDNICINJ == null)
		{
			this.KJPQKFEBFDJ();
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06001837 RID: 6199 RVA: 0x0000D010 File Offset: 0x0000B210
	// (set) Token: 0x06001857 RID: 6231 RVA: 0x000AA37C File Offset: 0x000A857C
	public override float DIIHJCJOKMP
	{
		get
		{
			return this.mColor.a;
		}
		set
		{
			if (value < 0f)
			{
				value = 0f;
			}
			if (value > 1f)
			{
				value = 1f;
			}
			if (this.mColor.a != value)
			{
				this.mColor.a = value;
				this.CKLIDQPPPON(true);
			}
		}
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x0000D01D File Offset: 0x0000B21D
	protected override void FHJOQKCCMDH()
	{
		base.FHJOQKCCMDH();
		this.QFQNGQHLFNE();
		this.POBHIFPCEEJ = true;
		base.Update();
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06001839 RID: 6201 RVA: 0x0000D038 File Offset: 0x0000B238
	// (set) Token: 0x0600183D RID: 6205 RVA: 0x000A95A4 File Offset: 0x000A77A4
	public KMCGDKDIJIE.MQQMDCIDPIL IOOHNELQHIO
	{
		get
		{
			return this.FHJHJCFGOFP;
		}
		set
		{
			if (this.FHJHJCFGOFP != value)
			{
				if (this.OQKBOCHIFKH != null && this.OQKBOCHIFKH.IOOHNELQHIO != null && this.FHJHJCFGOFP != null)
				{
					KMCGDKDIJIE oqkbochifkh = this.OQKBOCHIFKH;
					oqkbochifkh.IOOHNELQHIO = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Remove(oqkbochifkh.IOOHNELQHIO, this.FHJHJCFGOFP);
				}
				this.FHJHJCFGOFP = value;
				if (this.OQKBOCHIFKH != null)
				{
					KMCGDKDIJIE oqkbochifkh2 = this.OQKBOCHIFKH;
					oqkbochifkh2.IOOHNELQHIO = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Combine(oqkbochifkh2.IOOHNELQHIO, value);
				}
			}
		}
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x000A9508 File Offset: 0x000A7708
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int FKLCFGQBLPH(ENFMCDNLEQQ DEQIFCDFMDK, ENFMCDNLEQQ JKDFCPKCQJP)
	{
		int num = KQHJOLQLQBJ.PIEDJOEFGEQ(DEQIFCDFMDK.BCHNDNICINJ, JKDFCPKCQJP.BCHNDNICINJ);
		return (num != 0) ? num : ENFMCDNLEQQ.HNHJOHOHIED(DEQIFCDFMDK, JKDFCPKCQJP);
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x000A9534 File Offset: 0x000A7734
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int HNHJOHOHIED(ENFMCDNLEQQ DEQIFCDFMDK, ENFMCDNLEQQ JKDFCPKCQJP)
	{
		if (DEQIFCDFMDK.mDepth < JKDFCPKCQJP.mDepth)
		{
			return -1;
		}
		if (DEQIFCDFMDK.mDepth > JKDFCPKCQJP.mDepth)
		{
			return 1;
		}
		Material pplipcehgnm = DEQIFCDFMDK.PPLIPCEHGNM;
		Material pplipcehgnm2 = JKDFCPKCQJP.PPLIPCEHGNM;
		if (pplipcehgnm == pplipcehgnm2)
		{
			return 0;
		}
		if (pplipcehgnm == null)
		{
			return 1;
		}
		if (pplipcehgnm2 == null)
		{
			return -1;
		}
		return (pplipcehgnm.GetInstanceID() >= pplipcehgnm2.GetInstanceID()) ? 1 : -1;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void PMGHLFCNBLQ(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x0000D040 File Offset: 0x0000B240
	public Bounds BOLJCJNFOJH()
	{
		return this.BOLJCJNFOJH(null);
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600183F RID: 6207 RVA: 0x0000D049 File Offset: 0x0000B249
	// (set) Token: 0x06001850 RID: 6224 RVA: 0x000AA0F8 File Offset: 0x000A82F8
	public int KJGMGPCEJJD
	{
		get
		{
			return this.mWidth;
		}
		set
		{
			int qpkcpbjinbk = this.QPKCPBJINBK;
			if (value < qpkcpbjinbk)
			{
				value = qpkcpbjinbk;
			}
			if (this.mWidth != value && this.BPKBNCGBEDK != ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnHeight)
			{
				if (this.GHLPPQOBKLN)
				{
					if (this.HJDMKGDLJEP.target != null && this.HKPCCMEEHDL.target != null)
					{
						if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Left && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
						{
							if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight && this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.Right)
							{
								if (this.mPivot != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight)
								{
									int num = value - this.mWidth;
									num -= (num & 1);
									if (num != 0)
									{
										JNNGOIIKENH.EBNIMDGIINO(this, (float)(-(float)num) * 0.5f, 0f, (float)num * 0.5f, 0f);
										return;
									}
									return;
								}
							}
							JNNGOIIKENH.EBNIMDGIINO(this, (float)(this.mWidth - value), 0f, 0f, 0f);
						}
						else
						{
							JNNGOIIKENH.EBNIMDGIINO(this, 0f, 0f, (float)(value - this.mWidth), 0f);
						}
					}
					else if (this.HJDMKGDLJEP.target != null)
					{
						JNNGOIIKENH.EBNIMDGIINO(this, 0f, 0f, (float)(value - this.mWidth), 0f);
					}
					else
					{
						JNNGOIIKENH.EBNIMDGIINO(this, (float)(this.mWidth - value), 0f, 0f, 0f);
					}
				}
				else
				{
					this.MJCOMHHDPGG(value, this.mHeight);
				}
			}
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06001840 RID: 6208 RVA: 0x0000D051 File Offset: 0x0000B251
	public virtual int QPKCPBJINBK
	{
		get
		{
			return 2;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06001841 RID: 6209 RVA: 0x0000D054 File Offset: 0x0000B254
	// (set) Token: 0x0600184E RID: 6222 RVA: 0x000AA0B4 File Offset: 0x000A82B4
	public Color CEGFBBHMKOE
	{
		get
		{
			return this.mColor;
		}
		set
		{
			if (this.mColor != value)
			{
				bool ckcpemiblkh = this.mColor.a != value.a;
				this.mColor = value;
				this.CKLIDQPPPON(ckcpemiblkh);
			}
		}
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x000A9634 File Offset: 0x000A7834
	public override void CKLIDQPPPON(bool CKCPEMIBLKH)
	{
		this.LHQDFLPFGME = true;
		this.JDLIMQHCMCQ = -1;
		if (this.BCHNDNICINJ != null)
		{
			bool imppkklihen = (!this.PQFNQBNQNPL && !this.BCHNDNICINJ.CMKFMJCMCQQ) || this.BCHNDNICINJ.EHCBPMDEDGE(this);
			this.MHJMNHCHMHP(this.BJFPLJFDPCE(Time.frameCount) > 0.001f, imppkklihen);
			this.FINMKMMKJID(Time.frameCount);
			if (CKCPEMIBLKH)
			{
				base.CKLIDQPPPON(true);
			}
		}
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x000A96B4 File Offset: 0x000A78B4
	public override Vector3[] MKFNGPBMOKP(Transform ENOQKGBPJKQ)
	{
		Vector2 pfpekeldlcn = this.PFPEKELDLCN;
		float num = -pfpekeldlcn.x * (float)this.mWidth;
		float num2 = -pfpekeldlcn.y * (float)this.mHeight;
		float num3 = num + (float)this.mWidth;
		float num4 = num2 + (float)this.mHeight;
		float x = (num + num3) * 0.5f;
		float y = (num2 + num4) * 0.5f;
		Transform cgdfdphieng = base.CGDFDPHIENG;
		this.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, y, 0f);
		this.NCCGLODEOEE[1] = cgdfdphieng.TransformPoint(x, num4, 0f);
		this.NCCGLODEOEE[2] = cgdfdphieng.TransformPoint(num3, y, 0f);
		this.NCCGLODEOEE[3] = cgdfdphieng.TransformPoint(x, num2, 0f);
		if (ENOQKGBPJKQ != null)
		{
			for (int i = 0; i < 4; i++)
			{
				this.NCCGLODEOEE[i] = ENOQKGBPJKQ.InverseTransformPoint(this.NCCGLODEOEE[i]);
			}
		}
		return this.NCCGLODEOEE;
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x0000D064 File Offset: 0x0000B264
	public bool MHJMNHCHMHP(bool JDHKDJHGHOJ, bool IMPPKKLIHEN)
	{
		if (this.LKJJKDODNED == JDHKDJHGHOJ)
		{
			if (this.HGQCHKDMDOM == IMPPKKLIHEN)
			{
				return false;
			}
		}
		this.LHQDFLPFGME = true;
		this.LKJJKDODNED = JDHKDJHGHOJ;
		this.HGQCHKDMDOM = IMPPKKLIHEN;
		return true;
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x0000D092 File Offset: 0x0000B292
	private void OnApplicationPause(bool IGKFNOFJOOI)
	{
		if (!IGKFNOFJOOI)
		{
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x000A97E8 File Offset: 0x000A79E8
	public float BJFPLJFDPCE(int DGKHPOCGFHF)
	{
		BLMNBILNMOE kjihdmehlih = base.KJIHDMEHLIH;
		return (!(kjihdmehlih != null)) ? this.mColor.a : (kjihdmehlih.DBQOIOGLLEF(DGKHPOCGFHF) * this.mColor.a);
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x000A9828 File Offset: 0x000A7A28
	public virtual void NPCECPIOPCB()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LHQDFLPFGME = true;
			if (this.BCHNDNICINJ != null && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && !this.NGFPCDHHCOC)
			{
				this.OCPCPKCLCOI();
				this.BKKQOBNBPHO();
			}
		}
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x0000D09D File Offset: 0x0000B29D
	protected override void Awake()
	{
		base.Awake();
		this.NGFPCDHHCOC = Application.isPlaying;
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x000A987C File Offset: 0x000A7A7C
	protected override void NEBPQFKGHLL()
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		Transform parent = cgdfdphieng.parent;
		Vector3 localPosition = cgdfdphieng.localPosition;
		Vector2 pfpekeldlcn = this.PFPEKELDLCN;
		float num;
		float num2;
		float num3;
		float num4;
		if (this.HJDMKGDLJEP.target == this.LBGJKGDECCN.target && this.HJDMKGDLJEP.target == this.HKPCCMEEHDL.target && this.HJDMKGDLJEP.target == this.NOPCJFECJDP.target)
		{
			Vector3[] array = this.HJDMKGDLJEP.MKFNGPBMOKP(parent);
			if (array != null)
			{
				num = JNNGOIIKENH.GGJJLQLFKCE(array[0].x, array[2].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				num2 = JNNGOIIKENH.GGJJLQLFKCE(array[0].x, array[2].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				num3 = JNNGOIIKENH.GGJJLQLFKCE(array[3].y, array[1].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				num4 = JNNGOIIKENH.GGJJLQLFKCE(array[3].y, array[1].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
				this.LIGLJECDKCC = true;
			}
			else
			{
				Vector3 vector = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent);
				num = vector.x + (float)this.HJDMKGDLJEP.absolute;
				num3 = vector.y + (float)this.LBGJKGDECCN.absolute;
				num2 = vector.x + (float)this.HKPCCMEEHDL.absolute;
				num4 = vector.y + (float)this.NOPCJFECJDP.absolute;
				this.LIGLJECDKCC = (!this.PQFNQBNQNPL || vector.z >= 0f);
			}
		}
		else
		{
			this.LIGLJECDKCC = true;
			if (this.HJDMKGDLJEP.target)
			{
				Vector3[] array2 = this.HJDMKGDLJEP.MKFNGPBMOKP(parent);
				if (array2 != null)
				{
					num = JNNGOIIKENH.GGJJLQLFKCE(array2[0].x, array2[2].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				}
				else
				{
					num = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent).x + (float)this.HJDMKGDLJEP.absolute;
				}
			}
			else
			{
				num = localPosition.x - pfpekeldlcn.x * (float)this.mWidth;
			}
			if (this.HKPCCMEEHDL.target)
			{
				Vector3[] array3 = this.HKPCCMEEHDL.MKFNGPBMOKP(parent);
				if (array3 != null)
				{
					num2 = JNNGOIIKENH.GGJJLQLFKCE(array3[0].x, array3[2].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				}
				else
				{
					num2 = base.IFGLHHBDJCJ(this.HKPCCMEEHDL, parent).x + (float)this.HKPCCMEEHDL.absolute;
				}
			}
			else
			{
				num2 = localPosition.x - pfpekeldlcn.x * (float)this.mWidth + (float)this.mWidth;
			}
			if (this.LBGJKGDECCN.target)
			{
				Vector3[] array4 = this.LBGJKGDECCN.MKFNGPBMOKP(parent);
				if (array4 != null)
				{
					num3 = JNNGOIIKENH.GGJJLQLFKCE(array4[3].y, array4[1].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				}
				else
				{
					num3 = base.IFGLHHBDJCJ(this.LBGJKGDECCN, parent).y + (float)this.LBGJKGDECCN.absolute;
				}
			}
			else
			{
				num3 = localPosition.y - pfpekeldlcn.y * (float)this.mHeight;
			}
			if (this.NOPCJFECJDP.target)
			{
				Vector3[] array5 = this.NOPCJFECJDP.MKFNGPBMOKP(parent);
				if (array5 != null)
				{
					num4 = JNNGOIIKENH.GGJJLQLFKCE(array5[3].y, array5[1].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
				}
				else
				{
					num4 = base.IFGLHHBDJCJ(this.NOPCJFECJDP, parent).y + (float)this.NOPCJFECJDP.absolute;
				}
			}
			else
			{
				num4 = localPosition.y - pfpekeldlcn.y * (float)this.mHeight + (float)this.mHeight;
			}
		}
		Vector3 vector2 = new Vector3(Mathf.Lerp(num, num2, pfpekeldlcn.x), Mathf.Lerp(num3, num4, pfpekeldlcn.y), localPosition.z);
		vector2.x = Mathf.Round(vector2.x);
		vector2.y = Mathf.Round(vector2.y);
		int num5 = Mathf.FloorToInt(num2 - num + 0.5f);
		int num6 = Mathf.FloorToInt(num4 - num3 + 0.5f);
		if (this.BPKBNCGBEDK != ENFMCDNLEQQ.EHKJPCIJNJG.Free && this.FHNFGMNKCCP != 0f)
		{
			if (this.BPKBNCGBEDK == ENFMCDNLEQQ.EHKJPCIJNJG.BasedOnHeight)
			{
				num5 = Mathf.RoundToInt((float)num6 * this.FHNFGMNKCCP);
			}
			else
			{
				num6 = Mathf.RoundToInt((float)num5 / this.FHNFGMNKCCP);
			}
		}
		if (num5 < this.QPKCPBJINBK)
		{
			num5 = this.QPKCPBJINBK;
		}
		if (num6 < this.IPGGCHLFDCF)
		{
			num6 = this.IPGGCHLFDCF;
		}
		if (Vector3.SqrMagnitude(localPosition - vector2) > 0.001f)
		{
			base.CGDFDPHIENG.localPosition = vector2;
			if (this.LIGLJECDKCC)
			{
				this.LHQDFLPFGME = true;
			}
		}
		if (this.mWidth != num5 || this.mHeight != num6)
		{
			this.mWidth = num5;
			this.mHeight = num6;
			if (this.LIGLJECDKCC)
			{
				this.LHQDFLPFGME = true;
			}
			if (this.DENNQPBGNNH)
			{
				this.KOJBOOBNCHM();
			}
		}
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x000A9E70 File Offset: 0x000A8070
	protected virtual void HFODGDLHGJL()
	{
		Vector3 localScale = base.CGDFDPHIENG.localScale;
		this.mWidth = Mathf.Abs(Mathf.RoundToInt(localScale.x));
		this.mHeight = Mathf.Abs(Mathf.RoundToInt(localScale.y));
		IKBQNBHOJJB.DDHFKDFHCQB(base.gameObject, true);
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06001869 RID: 6249 RVA: 0x0000CFC9 File Offset: 0x0000B1C9
	// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
	public ENFMCDNLEQQ.GGBIQFIQQCM GOMIKGIHLPE
	{
		get
		{
			return this.mPivot;
		}
		set
		{
			if (this.mPivot != value)
			{
				this.mPivot = value;
				if (this.DENNQPBGNNH)
				{
					this.KOJBOOBNCHM();
				}
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x000A9EC4 File Offset: 0x000A80C4
	public bool FGEFKOMGELD(int DQLNIPIGLHK)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		this.NGFPCDHHCOC = Application.isPlaying;
		if (this.POBHIFPCEEJ)
		{
			this.POBHIFPCEEJ = true;
			this.HDHEFGEGQJI = -1;
			cgdfdphieng.hasChanged = false;
			Vector2 pfpekeldlcn = this.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float x = num + (float)this.mWidth;
			float y = num2 + (float)this.mHeight;
			this.LQEEHCPNJCH = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(num, num2, 0f));
			this.LDEIOIDCNBB = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(x, y, 0f));
		}
		else if (!this.BCHNDNICINJ.PDDLHKCHFON && cgdfdphieng.hasChanged)
		{
			this.HDHEFGEGQJI = -1;
			cgdfdphieng.hasChanged = false;
			Vector2 pfpekeldlcn2 = this.PFPEKELDLCN;
			float num3 = -pfpekeldlcn2.x * (float)this.mWidth;
			float num4 = -pfpekeldlcn2.y * (float)this.mHeight;
			float x2 = num3 + (float)this.mWidth;
			float y2 = num4 + (float)this.mHeight;
			Vector3 vector = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(num3, num4, 0f));
			Vector3 vector2 = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(x2, y2, 0f));
			if (Vector3.SqrMagnitude(this.LQEEHCPNJCH - vector) > 1E-06f || Vector3.SqrMagnitude(this.LDEIOIDCNBB - vector2) > 1E-06f)
			{
				this.POBHIFPCEEJ = true;
				this.LQEEHCPNJCH = vector;
				this.LDEIOIDCNBB = vector2;
			}
		}
		if (this.POBHIFPCEEJ && this.OHEFEKMMIFL != null)
		{
			this.OHEFEKMMIFL();
		}
		return this.POBHIFPCEEJ || this.LHQDFLPFGME;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x0000D010 File Offset: 0x0000B210
	public virtual float MHNCLHIOQFC()
	{
		return this.mColor.a;
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06001851 RID: 6225 RVA: 0x0000D0D6 File Offset: 0x0000B2D6
	public Vector2 PFPEKELDLCN
	{
		get
		{
			return JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
		}
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
	public virtual float GHLFKDCKQIC(int DGKHPOCGFHF)
	{
		if (this.JDLIMQHCMCQ != DGKHPOCGFHF)
		{
			this.JDLIMQHCMCQ = DGKHPOCGFHF;
			this.FINMKMMKJID(DGKHPOCGFHF);
		}
		return this.NHCNEDEEONK;
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06001853 RID: 6227 RVA: 0x0000D102 File Offset: 0x0000B302
	// (set) Token: 0x0600187D RID: 6269 RVA: 0x000AAF48 File Offset: 0x000A9148
	public int LGCLGHDGNPM
	{
		get
		{
			return this.mDepth;
		}
		set
		{
			if (this.mDepth != value)
			{
				if (this.BCHNDNICINJ != null)
				{
					this.BCHNDNICINJ.EHHDPDNDLMO(this);
				}
				this.mDepth = value;
				if (this.BCHNDNICINJ != null)
				{
					this.BCHNDNICINJ.MFIKGGPKKCD(this);
					if (!Application.isPlaying)
					{
						this.BCHNDNICINJ.LMCOEENKPJN();
						this.BCHNDNICINJ.NQEECPEOGOE();
					}
				}
			}
		}
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x000AA280 File Offset: 0x000A8480
	public KQHJOLQLQBJ KJPQKFEBFDJ()
	{
		if (this.PNBOOLEOKCI && this.BCHNDNICINJ == null && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.BCHNDNICINJ = KQHJOLQLQBJ.CQGLPBCNFGL(base.CGDFDPHIENG, true, base.LMOECGCMJKK.layer);
			if (this.BCHNDNICINJ != null)
			{
				this.PCKBJCKICEL = false;
				this.BCHNDNICINJ.MFIKGGPKKCD(this);
				this.BKKQOBNBPHO();
				this.CKLIDQPPPON(true);
			}
		}
		return this.BCHNDNICINJ;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x000AA30C File Offset: 0x000A850C
	public static int JBPNPLGQPDE(ENFMCDNLEQQ DEQIFCDFMDK, ENFMCDNLEQQ JKDFCPKCQJP)
	{
		if (DEQIFCDFMDK.mDepth < JKDFCPKCQJP.mDepth)
		{
			return -1;
		}
		if (DEQIFCDFMDK.mDepth > JKDFCPKCQJP.mDepth)
		{
			return 1;
		}
		Material pplipcehgnm = DEQIFCDFMDK.PPLIPCEHGNM;
		Material pplipcehgnm2 = JKDFCPKCQJP.PPLIPCEHGNM;
		if (pplipcehgnm == pplipcehgnm2)
		{
			return 0;
		}
		if (pplipcehgnm == null)
		{
			return 0;
		}
		if (pplipcehgnm2 == null)
		{
			return -1;
		}
		return (pplipcehgnm.GetInstanceID() >= pplipcehgnm2.GetInstanceID()) ? 0 : -1;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x0000D010 File Offset: 0x0000B210
	public virtual float BMFGKKGIMFQ()
	{
		return this.mColor.a;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x0000D10A File Offset: 0x0000B30A
	public Vector4 DNKHOPILGCE()
	{
		return this.KQGOECJHBNK;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x0000D112 File Offset: 0x0000B312
	protected override void OnDisable()
	{
		this.QFQNGQHLFNE();
		base.OnDisable();
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x000AA3C8 File Offset: 0x000A85C8
	public virtual void IQFQEOFBQKM()
	{
		Vector3 localPosition = base.CGDFDPHIENG.localPosition;
		localPosition.z = Mathf.Round(localPosition.z);
		localPosition.x = Mathf.Round(localPosition.x);
		localPosition.y = Mathf.Round(localPosition.y);
		base.CGDFDPHIENG.localPosition = localPosition;
		Vector3 localScale = base.CGDFDPHIENG.localScale;
		base.CGDFDPHIENG.localScale = new Vector3(Mathf.Sign(localScale.x), Mathf.Sign(localScale.y), 1f);
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600185B RID: 6235 RVA: 0x000AA460 File Offset: 0x000A8660
	public virtual Vector2 CHIFKHKGOMD
	{
		get
		{
			Vector3[] pigmlpngmno = this.PIGMLPNGMNO;
			return pigmlpngmno[2] - pigmlpngmno[0];
		}
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x000AA498 File Offset: 0x000A8698
	public bool CBBPEELHBLK(int DQLNIPIGLHK)
	{
		float num = this.DBQOIOGLLEF(DQLNIPIGLHK);
		if (this.LKJJKDODNED && this.DPDJNDDDEID != num)
		{
			this.LHQDFLPFGME = true;
		}
		this.DPDJNDDDEID = num;
		if (this.LHQDFLPFGME)
		{
			if (this.LKJJKDODNED && num > 961f && this.JHKGHDQFQNL != null)
			{
				bool result = this.BPDNIHLBLOI.QCBQQCIIGEG();
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.FMPLDJKPIEP();
					this.PIEBLFFMJEH(this.BPDNIHLBLOI.EQINHIFFOGG, this.BPDNIHLBLOI.PICFCJNMJMC, this.BPDNIHLBLOI.HQOONBPDFHO);
				}
				if (this.BPDNIHLBLOI.QCBQQCIIGEG())
				{
					if (this.HDHEFGEGQJI != DQLNIPIGLHK)
					{
						this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
						this.HDHEFGEGQJI = DQLNIPIGLHK;
					}
					this.BPDNIHLBLOI.ILHDNNEQCKI(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
					this.POBHIFPCEEJ = false;
					this.LHQDFLPFGME = true;
					return false;
				}
				this.LHQDFLPFGME = false;
				return result;
			}
			else if (this.BPDNIHLBLOI.MOJKIQJIGBP())
			{
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.DPHBLOPNNGO();
				}
				this.POBHIFPCEEJ = true;
				this.LHQDFLPFGME = true;
				return true;
			}
		}
		else if (this.POBHIFPCEEJ && this.BPDNIHLBLOI.HCQPQJEQPMP())
		{
			if (this.HDHEFGEGQJI != DQLNIPIGLHK)
			{
				this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
				this.HDHEFGEGQJI = DQLNIPIGLHK;
			}
			this.BPDNIHLBLOI.ILHDNNEQCKI(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
			this.POBHIFPCEEJ = false;
			this.LHQDFLPFGME = false;
			return false;
		}
		this.POBHIFPCEEJ = false;
		this.LHQDFLPFGME = false;
		return true;
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x000AA66C File Offset: 0x000A886C
	protected void FINMKMMKJID(int DGKHPOCGFHF)
	{
		if (this.LKJJKDODNED && this.LIGLJECDKCC)
		{
			BLMNBILNMOE kjihdmehlih = base.KJIHDMEHLIH;
			this.NHCNEDEEONK = ((!(kjihdmehlih != null)) ? this.mColor.a : (kjihdmehlih.DBQOIOGLLEF(DGKHPOCGFHF) * this.mColor.a));
		}
		else
		{
			this.NHCNEDEEONK = 0f;
		}
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x0000CF43 File Offset: 0x0000B143
	public void MDEGPIPQDIL()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			IKBQNBHOJJB.DDHFKDFHCQB(base.gameObject);
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x0600185F RID: 6239 RVA: 0x000AA6CC File Offset: 0x000A88CC
	public virtual Vector4 BCEPPKGMNFE
	{
		get
		{
			Vector2 pfpekeldlcn = this.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float num3 = num + (float)this.mWidth;
			float num4 = num2 + (float)this.mHeight;
			return new Vector4((this.KQGOECJHBNK.x != 0f) ? Mathf.Lerp(num, num3, this.KQGOECJHBNK.x) : num, (this.KQGOECJHBNK.y != 0f) ? Mathf.Lerp(num2, num4, this.KQGOECJHBNK.y) : num2, (this.KQGOECJHBNK.z != 1f) ? Mathf.Lerp(num, num3, this.KQGOECJHBNK.z) : num3, (this.KQGOECJHBNK.w != 1f) ? Mathf.Lerp(num2, num4, this.KQGOECJHBNK.w) : num4);
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06001860 RID: 6240 RVA: 0x000AA7BC File Offset: 0x000A89BC
	public Vector3 LGEQLMBOIBH
	{
		get
		{
			Vector3[] pigmlpngmno = this.PIGMLPNGMNO;
			return Vector3.Lerp(pigmlpngmno[0], pigmlpngmno[2], 0.5f);
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06001861 RID: 6241 RVA: 0x0000D10A File Offset: 0x0000B30A
	// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000CF83 File Offset: 0x0000B183
	public Vector4 EIMQBOICHOP
	{
		get
		{
			return this.KQGOECJHBNK;
		}
		set
		{
			if (this.KQGOECJHBNK != value)
			{
				this.KQGOECJHBNK = value;
				if (this.DENNQPBGNNH)
				{
					this.KOJBOOBNCHM();
				}
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x0000CF43 File Offset: 0x0000B143
	public void KOJBOOBNCHM()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			IKBQNBHOJJB.DDHFKDFHCQB(base.gameObject);
		}
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00002300 File Offset: 0x00000500
	public virtual void PIEBLFFMJEH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06001864 RID: 6244 RVA: 0x000A92A0 File Offset: 0x000A74A0
	public bool KMCCENFJDMG
	{
		get
		{
			BoxCollider x = base.GetComponent<Collider>() as BoxCollider;
			return x != null || base.GetComponent<BoxCollider2D>() != null;
		}
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x000AA7F4 File Offset: 0x000A89F4
	public override void HGBNNJQOKLO()
	{
		base.HGBNNJQOKLO();
		if (this.BCHNDNICINJ != null)
		{
			KQHJOLQLQBJ y = KQHJOLQLQBJ.CQGLPBCNFGL(base.CGDFDPHIENG, true, base.LMOECGCMJKK.layer);
			if (this.BCHNDNICINJ != y)
			{
				this.QFQNGQHLFNE();
				this.KJPQKFEBFDJ();
			}
		}
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x000AA848 File Offset: 0x000A8A48
	public virtual Vector3[] FHEFPCLHOHH()
	{
		Vector2 pfpekeldlcn = this.PFPEKELDLCN;
		float num = -pfpekeldlcn.x * (float)this.mWidth;
		float num2 = -pfpekeldlcn.y * (float)this.mHeight;
		float x = num + (float)this.mWidth;
		float y = num2 + (float)this.mHeight;
		Transform cgdfdphieng = base.CGDFDPHIENG;
		this.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, num2, 1433f);
		this.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, y, 887f);
		this.NCCGLODEOEE[4] = cgdfdphieng.TransformPoint(x, y, 35f);
		this.NCCGLODEOEE[1] = cgdfdphieng.TransformPoint(x, num2, 1019f);
		return this.NCCGLODEOEE;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x0000D120 File Offset: 0x0000B320
	public void DOGQIGLCMMN(List<Vector3> ECFKEFOFQGB, List<Vector2> EMJDDENOMBP, List<Color> KQFEHQEBJQB, List<Vector3> HEBFPQJPJIL, List<Vector4> OQJFBJQJEFG, List<Vector4> EFFPLIOQGCE)
	{
		this.BPDNIHLBLOI.DOGQIGLCMMN(ECFKEFOFQGB, EMJDDENOMBP, KQFEHQEBJQB, HEBFPQJPJIL, OQJFBJQJEFG, EFFPLIOQGCE);
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x0000D136 File Offset: 0x0000B336
	public void OCPCPKCLCOI()
	{
		if (this.OQKBOCHIFKH != null)
		{
			this.OQKBOCHIFKH.HHDFDNFPDFJ = true;
		}
		else if (this.DEJBMFBECJG && this.KGIFPCDDIBG)
		{
			this.KJPQKFEBFDJ();
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600186A RID: 6250 RVA: 0x000AA920 File Offset: 0x000A8B20
	// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000D20A File Offset: 0x0000B40A
	public virtual Shader JHKGHDQFQNL
	{
		get
		{
			Material pplipcehgnm = this.PPLIPCEHGNM;
			return (!(pplipcehgnm != null)) ? null : pplipcehgnm.shader;
		}
		set
		{
			throw new NotImplementedException(base.GetType() + " has no shader setter");
		}
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x000AA948 File Offset: 0x000A8B48
	public void BKKQOBNBPHO()
	{
		if (this.BCHNDNICINJ != null && this.BCHNDNICINJ.gameObject.layer != base.gameObject.layer)
		{
			UnityEngine.Debug.LogWarning("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.", this);
			base.gameObject.layer = this.BCHNDNICINJ.gameObject.layer;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600186C RID: 6252 RVA: 0x0000D16B File Offset: 0x0000B36B
	public bool DEJBMFBECJG
	{
		get
		{
			return this.HGQCHKDMDOM && this.LKJJKDODNED && this.LIGLJECDKCC && this.NHCNEDEEONK > 0.001f && IKBQNBHOJJB.PBBDNDMELHQ(this);
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x0600186D RID: 6253 RVA: 0x000AA9A8 File Offset: 0x000A8BA8
	public override Vector3[] PMCNQICHCLE
	{
		get
		{
			Vector2 pfpekeldlcn = this.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float x = num + (float)this.mWidth;
			float y = num2 + (float)this.mHeight;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			this.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, num2, 0f);
			this.NCCGLODEOEE[1] = cgdfdphieng.TransformPoint(num, y, 0f);
			this.NCCGLODEOEE[2] = cgdfdphieng.TransformPoint(x, y, 0f);
			this.NCCGLODEOEE[3] = cgdfdphieng.TransformPoint(x, num2, 0f);
			return this.NCCGLODEOEE;
		}
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x0000D19B File Offset: 0x0000B39B
	public bool KLBIMEBFGLP(bool JDHKDJHGHOJ, bool IMPPKKLIHEN)
	{
		if (this.LKJJKDODNED == JDHKDJHGHOJ)
		{
			if (this.HGQCHKDMDOM == IMPPKKLIHEN)
			{
				return false;
			}
		}
		this.LHQDFLPFGME = false;
		this.LKJJKDODNED = JDHKDJHGHOJ;
		this.HGQCHKDMDOM = IMPPKKLIHEN;
		return false;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x000AA0B4 File Offset: 0x000A82B4
	public void NONQDHBCIIN(Color BGBMIEJJQKC)
	{
		if (this.mColor != BGBMIEJJQKC)
		{
			bool ckcpemiblkh = this.mColor.a != BGBMIEJJQKC.a;
			this.mColor = BGBMIEJJQKC;
			this.CKLIDQPPPON(ckcpemiblkh);
		}
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0000D092 File Offset: 0x0000B292
	private void PCDPQQQMJJD(bool IGKFNOFJOOI)
	{
		if (!IGKFNOFJOOI)
		{
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x0000D1C9 File Offset: 0x0000B3C9
	public void QFQNGQHLFNE()
	{
		if (this.BCHNDNICINJ != null)
		{
			this.BCHNDNICINJ.EHHDPDNDLMO(this);
			this.BCHNDNICINJ = null;
		}
		this.OQKBOCHIFKH = null;
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06001873 RID: 6259 RVA: 0x0000D051 File Offset: 0x0000B251
	public virtual int IPGGCHLFDCF
	{
		get
		{
			return 2;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06001875 RID: 6261 RVA: 0x000AAA80 File Offset: 0x000A8C80
	public int KJJJFEQLMDN
	{
		get
		{
			if (this.BCHNDNICINJ == null)
			{
				this.KJPQKFEBFDJ();
			}
			return (!(this.BCHNDNICINJ != null)) ? this.mDepth : (this.mDepth + this.BCHNDNICINJ.LGCLGHDGNPM * 1000);
		}
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
	public override float DBQOIOGLLEF(int DGKHPOCGFHF)
	{
		if (this.JDLIMQHCMCQ != DGKHPOCGFHF)
		{
			this.JDLIMQHCMCQ = DGKHPOCGFHF;
			this.FINMKMMKJID(DGKHPOCGFHF);
		}
		return this.NHCNEDEEONK;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x000AAAD0 File Offset: 0x000A8CD0
	public bool LKFBPFIDDGE(int DQLNIPIGLHK)
	{
		float num = this.DBQOIOGLLEF(DQLNIPIGLHK);
		if (this.LKJJKDODNED && this.DPDJNDDDEID != num)
		{
			this.LHQDFLPFGME = false;
		}
		this.DPDJNDDDEID = num;
		if (this.LHQDFLPFGME)
		{
			if (this.LKJJKDODNED && num > 1621f && this.JHKGHDQFQNL != null)
			{
				bool result = this.BPDNIHLBLOI.HCQPQJEQPMP();
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.DPHBLOPNNGO();
					this.PMGHLFCNBLQ(this.BPDNIHLBLOI.EQINHIFFOGG, this.BPDNIHLBLOI.PICFCJNMJMC, this.BPDNIHLBLOI.HQOONBPDFHO);
				}
				if (this.BPDNIHLBLOI.KGIFPCDDIBG)
				{
					if (this.HDHEFGEGQJI != DQLNIPIGLHK)
					{
						this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
						this.HDHEFGEGQJI = DQLNIPIGLHK;
					}
					this.BPDNIHLBLOI.DLPPMDLNEKE(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
					this.POBHIFPCEEJ = false;
					this.LHQDFLPFGME = true;
					return false;
				}
				this.LHQDFLPFGME = true;
				return result;
			}
			else if (this.BPDNIHLBLOI.QCBQQCIIGEG())
			{
				if (this.HPPHMEHKBHO)
				{
					this.BPDNIHLBLOI.FQIMQLKCNGM();
				}
				this.POBHIFPCEEJ = true;
				this.LHQDFLPFGME = true;
				return false;
			}
		}
		else if (this.POBHIFPCEEJ && this.BPDNIHLBLOI.QCBQQCIIGEG())
		{
			if (this.HDHEFGEGQJI != DQLNIPIGLHK)
			{
				this.HLBPNIQGQFD = this.BCHNDNICINJ.IDKHBJEKMEE * base.CGDFDPHIENG.localToWorldMatrix;
				this.HDHEFGEGQJI = DQLNIPIGLHK;
			}
			this.BPDNIHLBLOI.HNQNBIQKBPK(this.HLBPNIQGQFD, this.BCHNDNICINJ.PJQNIHCHHDF);
			this.POBHIFPCEEJ = true;
			this.LHQDFLPFGME = false;
			return false;
		}
		this.POBHIFPCEEJ = true;
		this.LHQDFLPFGME = false;
		return false;
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x000AACA4 File Offset: 0x000A8EA4
	public Bounds BOLJCJNFOJH(Transform BFBKJBIELNG)
	{
		if (BFBKJBIELNG == null)
		{
			Vector3[] pigmlpngmno = this.PIGMLPNGMNO;
			Bounds result = new Bounds(pigmlpngmno[0], Vector3.zero);
			for (int i = 1; i < 4; i++)
			{
				result.Encapsulate(pigmlpngmno[i]);
			}
			return result;
		}
		Matrix4x4 worldToLocalMatrix = BFBKJBIELNG.worldToLocalMatrix;
		Vector3[] pmcnqichcle = this.PMCNQICHCLE;
		Bounds result2 = new Bounds(worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[0]), Vector3.zero);
		for (int j = 1; j < 4; j++)
		{
			result2.Encapsulate(worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[j]));
		}
		return result2;
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x0000D01D File Offset: 0x0000B21D
	protected virtual void NGFIIINICEC()
	{
		base.FHJOQKCCMDH();
		this.QFQNGQHLFNE();
		this.POBHIFPCEEJ = true;
		base.Update();
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x000AAD58 File Offset: 0x000A8F58
	public bool EMJFNFKKGDC(int DQLNIPIGLHK)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		this.NGFPCDHHCOC = Application.isPlaying;
		if (this.POBHIFPCEEJ)
		{
			this.POBHIFPCEEJ = true;
			this.HDHEFGEGQJI = -1;
			cgdfdphieng.hasChanged = true;
			Vector2 pfpekeldlcn = this.PFPEKELDLCN;
			float num = -pfpekeldlcn.x * (float)this.mWidth;
			float num2 = -pfpekeldlcn.y * (float)this.mHeight;
			float x = num + (float)this.mWidth;
			float y = num2 + (float)this.mHeight;
			this.LQEEHCPNJCH = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(num, num2, 726f));
			this.LDEIOIDCNBB = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(x, y, 200f));
		}
		else if (!this.BCHNDNICINJ.PDDLHKCHFON && cgdfdphieng.hasChanged)
		{
			this.HDHEFGEGQJI = -1;
			cgdfdphieng.hasChanged = true;
			Vector2 pfpekeldlcn2 = this.PFPEKELDLCN;
			float num3 = -pfpekeldlcn2.x * (float)this.mWidth;
			float num4 = -pfpekeldlcn2.y * (float)this.mHeight;
			float x2 = num3 + (float)this.mWidth;
			float y2 = num4 + (float)this.mHeight;
			Vector3 vector = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(num3, num4, 173f));
			Vector3 vector2 = this.BCHNDNICINJ.IDKHBJEKMEE.MultiplyPoint3x4(cgdfdphieng.TransformPoint(x2, y2, 731f));
			if (Vector3.SqrMagnitude(this.LQEEHCPNJCH - vector) > 1642f || Vector3.SqrMagnitude(this.LDEIOIDCNBB - vector2) > 851f)
			{
				this.POBHIFPCEEJ = true;
				this.LQEEHCPNJCH = vector;
				this.LDEIOIDCNBB = vector2;
			}
		}
		if (this.POBHIFPCEEJ && this.OHEFEKMMIFL != null)
		{
			this.OHEFEKMMIFL();
		}
		return this.POBHIFPCEEJ || this.LHQDFLPFGME;
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x0600187E RID: 6270 RVA: 0x0000D221 File Offset: 0x0000B421
	[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
	public Vector2 FILKEDHIFBL
	{
		get
		{
			return Vector2.one;
		}
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x0000CFF9 File Offset: 0x0000B1F9
	protected override void BOIOGNMBEGD()
	{
		if (this.BCHNDNICINJ == null)
		{
			this.KJPQKFEBFDJ();
		}
	}

	// Token: 0x040004CC RID: 1228
	[HideInInspector]
	[SerializeField]
	protected Color mColor = Color.white;

	// Token: 0x040004CD RID: 1229
	[SerializeField]
	[HideInInspector]
	protected ENFMCDNLEQQ.GGBIQFIQQCM mPivot = ENFMCDNLEQQ.GGBIQFIQQCM.Center;

	// Token: 0x040004CE RID: 1230
	[SerializeField]
	[HideInInspector]
	protected int mWidth = 100;

	// Token: 0x040004CF RID: 1231
	[HideInInspector]
	[SerializeField]
	protected int mHeight = 100;

	// Token: 0x040004D0 RID: 1232
	[SerializeField]
	[HideInInspector]
	protected int mDepth;

	// Token: 0x040004D1 RID: 1233
	[Tooltip("Custom material, if desired")]
	[SerializeField]
	[HideInInspector]
	protected Material mMat;

	// Token: 0x040004D2 RID: 1234
	public ENFMCDNLEQQ.DLKHBQJGMKQ OHEFEKMMIFL;

	// Token: 0x040004D3 RID: 1235
	public ENFMCDNLEQQ.OPEPBGCHOEI GOFBKEHQPDK;

	// Token: 0x040004D4 RID: 1236
	public KMCGDKDIJIE.MQQMDCIDPIL FHJHJCFGOFP;

	// Token: 0x040004D5 RID: 1237
	public bool DENNQPBGNNH;

	// Token: 0x040004D6 RID: 1238
	public bool PQFNQBNQNPL;

	// Token: 0x040004D7 RID: 1239
	public ENFMCDNLEQQ.EHKJPCIJNJG BPKBNCGBEDK;

	// Token: 0x040004D8 RID: 1240
	public float FHNFGMNKCCP = 1f;

	// Token: 0x040004D9 RID: 1241
	public ENFMCDNLEQQ.PFPNQQGELND PCHNEGPCJPC;

	// Token: 0x040004DA RID: 1242
	[NonSerialized]
	public KQHJOLQLQBJ BCHNDNICINJ;

	// Token: 0x040004DB RID: 1243
	[NonSerialized]
	public QDHDQQEKMGO BPDNIHLBLOI = new QDHDQQEKMGO();

	// Token: 0x040004DC RID: 1244
	[NonSerialized]
	public bool HPPHMEHKBHO = true;

	// Token: 0x040004DD RID: 1245
	[NonSerialized]
	protected bool NGFPCDHHCOC = true;

	// Token: 0x040004DE RID: 1246
	[NonSerialized]
	protected Vector4 KQGOECJHBNK = new Vector4(0f, 0f, 1f, 1f);

	// Token: 0x040004DF RID: 1247
	[NonSerialized]
	private Matrix4x4 HLBPNIQGQFD;

	// Token: 0x040004E0 RID: 1248
	[NonSerialized]
	private bool LKJJKDODNED = true;

	// Token: 0x040004E1 RID: 1249
	[NonSerialized]
	private bool HGQCHKDMDOM = true;

	// Token: 0x040004E2 RID: 1250
	[NonSerialized]
	private bool LIGLJECDKCC = true;

	// Token: 0x040004E3 RID: 1251
	[NonSerialized]
	private float DPDJNDDDEID;

	// Token: 0x040004E4 RID: 1252
	[NonSerialized]
	private bool POBHIFPCEEJ;

	// Token: 0x040004E5 RID: 1253
	[NonSerialized]
	public KMCGDKDIJIE OQKBOCHIFKH;

	// Token: 0x040004E6 RID: 1254
	[NonSerialized]
	protected Vector3[] NCCGLODEOEE = new Vector3[4];

	// Token: 0x040004E7 RID: 1255
	[NonSerialized]
	private int JDLIMQHCMCQ = -1;

	// Token: 0x040004E8 RID: 1256
	private int HDHEFGEGQJI = -1;

	// Token: 0x040004E9 RID: 1257
	private Vector3 LQEEHCPNJCH;

	// Token: 0x040004EA RID: 1258
	private Vector3 LDEIOIDCNBB;

	// Token: 0x020000C9 RID: 201
	public enum GGBIQFIQQCM
	{
		// Token: 0x040004EC RID: 1260
		TopLeft,
		// Token: 0x040004ED RID: 1261
		Top,
		// Token: 0x040004EE RID: 1262
		TopRight,
		// Token: 0x040004EF RID: 1263
		Left,
		// Token: 0x040004F0 RID: 1264
		Center,
		// Token: 0x040004F1 RID: 1265
		Right,
		// Token: 0x040004F2 RID: 1266
		BottomLeft,
		// Token: 0x040004F3 RID: 1267
		Bottom,
		// Token: 0x040004F4 RID: 1268
		BottomRight
	}

	// Token: 0x020000CA RID: 202
	// (Invoke) Token: 0x06001882 RID: 6274
	public delegate void DLKHBQJGMKQ();

	// Token: 0x020000CB RID: 203
	// (Invoke) Token: 0x06001886 RID: 6278
	public delegate void OPEPBGCHOEI(ENFMCDNLEQQ BCPJIPBJODP, int COLFGBBNEBL, List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO);

	// Token: 0x020000CC RID: 204
	public enum EHKJPCIJNJG
	{
		// Token: 0x040004F6 RID: 1270
		Free,
		// Token: 0x040004F7 RID: 1271
		BasedOnWidth,
		// Token: 0x040004F8 RID: 1272
		BasedOnHeight
	}

	// Token: 0x020000CD RID: 205
	// (Invoke) Token: 0x0600188A RID: 6282
	public delegate bool PFPNQQGELND(Vector3 PHCMBMCKQDC);
}
