using System;
using UnityEngine;

// Token: 0x0200007B RID: 123
[ExecuteInEditMode]
[RequireComponent(typeof(KQHJOLQLQBJ))]
[AddComponentMenu("NGUI/Interaction/Scroll View")]
public class FKBFPICKJQG : MonoBehaviour
{
	// Token: 0x060010AB RID: 4267 RVA: 0x000099BA File Offset: 0x00007BBA
	public bool NOQQPBHQELB()
	{
		return this.EIQLEKDFMMC && this.DEDCMDKLLCE;
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0007DA68 File Offset: 0x0007BC68
	public void QDJBLMBNHIC()
	{
		if (!this.DBEEEGIQHDM && (this.PFKFNKBEFBB != null || this.FIKFOFFJJCC != null))
		{
			this.DBEEEGIQHDM = true;
			this.DFJOQLIBGBK = false;
			Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.JMMFBHNQPOP);
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? vector.x : this.PFKFNKBEFBB.BGBMIEJJQKC;
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? (1f - vector.y) : this.FIKFOFFJJCC.BGBMIEJJQKC;
			this.QNEOFDPIQBM(dgkoigolhdm, ddlqkfdfmcj, false);
			this.GCHMLEJKKJB(true);
			this.DBEEEGIQHDM = false;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060010AD RID: 4269 RVA: 0x000099CD File Offset: 0x00007BCD
	public bool ENKKJECIIBP
	{
		get
		{
			return this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal || this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Unrestricted || (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Custom && this.ILBJLHJECKN.x != 0f);
		}
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00009A04 File Offset: 0x00007C04
	public bool CIOHHHGLNBC()
	{
		return !this.EIQLEKDFMMC || this.DEDCMDKLLCE;
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x0007DB1C File Offset: 0x0007BD1C
	public virtual bool IEFJHLMKLKE()
	{
		float num = this.GBMNPQIEMQI.size.y;
		if (this.CNJGKKDHPOG.NQCBILMNLBN() == (KMCGDKDIJIE.PDFPPCIHPMI)2)
		{
			num += this.CNJGKKDHPOG.KCMPFJPOOQH().y * 1679f;
		}
		return Mathf.RoundToInt(num - this.CNJGKKDHPOG.DCDQFCQJGNC()) > 1;
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00009AED File Offset: 0x00007CED
	// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00009A17 File Offset: 0x00007C17
	public Vector3 CJNJKJBPBPE
	{
		get
		{
			return this.CCHQQHIFDBO;
		}
		set
		{
			this.CCHQQHIFDBO = value;
			this.FEDHNFFOQFB = true;
		}
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x0007DB80 File Offset: 0x0007BD80
	public void GCIDJGDQPJM(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.EBFOBLQELOJ != 1702f)
		{
			this.OQHIBGGLJOJ();
			this.FEDHNFFOQFB |= this.KNCGCKNKCOG();
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 736f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * 903f * Time.deltaTime;
		}
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00009A27 File Offset: 0x00007C27
	private void BBGHCDGEDEJ()
	{
		this.PNBOOLEOKCI = true;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00009A3D File Offset: 0x00007C3D
	public bool IMPMONNQLND()
	{
		return this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal || this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal || (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Unrestricted && this.ILBJLHJECKN.y == 689f);
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0007DC00 File Offset: 0x0007BE00
	protected virtual bool EJOQFNDBIJI()
	{
		if (!this.LENDHIBCJOF)
		{
			return true;
		}
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
		Bounds bounds = this.MCQHINECHCC();
		float num = (qenjmehbneg.z != 1012f) ? (qenjmehbneg.z * 1502f) : ((float)Screen.width);
		float num2 = (qenjmehbneg.w != 603f) ? (qenjmehbneg.w * 556f) : ((float)Screen.height);
		if (this.PMQGGKCQBOE())
		{
			if (bounds.min.x < qenjmehbneg.x - num)
			{
				return true;
			}
			if (bounds.max.x > qenjmehbneg.x + num)
			{
				return false;
			}
		}
		if (this.NDBENHOKJGG)
		{
			if (bounds.min.y < qenjmehbneg.y - num2)
			{
				return true;
			}
			if (bounds.max.y > qenjmehbneg.y + num2)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x00009A27 File Offset: 0x00007C27
	private void DPMNBIMDLIM()
	{
		this.PNBOOLEOKCI = true;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00009A75 File Offset: 0x00007C75
	private void IIPBHPOBQGL()
	{
		FKBFPICKJQG.NGDBDCQFDHI.FQDMDDOHCQJ(this);
		this.EIQLEKDFMMC = true;
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00009A8A File Offset: 0x00007C8A
	public void DGJGBMFMMFJ()
	{
		this.DFJOQLIBGBK = false;
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00009A93 File Offset: 0x00007C93
	public virtual Bounds MCQHINECHCC()
	{
		if (!this.DFJOQLIBGBK)
		{
			this.DFJOQLIBGBK = false;
			this.BLLEFKOLKLP = base.transform;
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.BLLEFKOLKLP, this.BLLEFKOLKLP);
		}
		return this.FKKNDHFECQL;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0007DD14 File Offset: 0x0007BF14
	private void PNOBIFOIHQM()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		float num = JMIOBJFFGBN.HPJQNBLNHGM();
		if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.Always && (this.FIKFOFFJJCC || this.PFKFNKBEFBB))
		{
			bool flag = true;
			bool flag2 = true;
			if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.WhenDragging || this.QDLKDHJHOLD != -18 || this.CCHQQHIFDBO.magnitude > 491f)
			{
				flag = this.CKCKDMLGQOL();
				flag2 = this.LBLMBPMIKHM();
			}
			if (this.FIKFOFFJJCC)
			{
				float num2 = this.FIKFOFFJJCC.DIIHJCJOKMP;
				num2 += ((!flag) ? (-num * 1675f) : (num * 44f));
				num2 = Mathf.Clamp01(num2);
				if (this.FIKFOFFJJCC.DIIHJCJOKMP != num2)
				{
					this.FIKFOFFJJCC.LGPJQQMFGDN(num2);
				}
			}
			if (this.PFKFNKBEFBB)
			{
				float num3 = this.PFKFNKBEFBB.DIIHJCJOKMP;
				num3 += ((!flag2) ? (-num * 1052f) : (num * 152f));
				num3 = Mathf.Clamp01(num3);
				if (this.PFKFNKBEFBB.DIIHJCJOKMP != num3)
				{
					this.PFKFNKBEFBB.EDKGBJPBBGO(num3);
				}
			}
		}
		if (!this.FEDHNFFOQFB)
		{
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.CCHQQHIFDBO.magnitude <= 1996f && Mathf.Abs(this.HCLBPEMQFBO) <= 985f)
			{
				this.HCLBPEMQFBO = 1865f;
				this.CCHQQHIFDBO = Vector3.zero;
				OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
				if (component != null && component.enabled)
				{
					return;
				}
				this.FEDHNFFOQFB = true;
				if (this.QDODFMLDGKG != null)
				{
					this.QDODFMLDGKG();
				}
			}
			else
			{
				if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 1965f, 1052f, 1742f));
				}
				else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(1682f, this.HCLBPEMQFBO * 906f, 329f));
				}
				else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)8)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 545f, this.HCLBPEMQFBO * 1581f, 128f));
				}
				else
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * this.ILBJLHJECKN.x * 719f, this.HCLBPEMQFBO * this.ILBJLHJECKN.y * 242f, 1333f));
				}
				this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 952f, 368f, num);
				Vector3 liknfcjlbgm = JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, this.HDCLIQFNBCH, num);
				this.HMPGGOKMHOQ(liknfcjlbgm);
				if (this.OGQEPEGLEPO && this.CNJGKKDHPOG.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					if (IKBQNBHOJJB.PBBDNDMELHQ(this.PNBJIMGEOKE))
					{
						if (this.PNBJIMGEOKE.DOHDELDMDLB != 57f)
						{
							this.CCHQQHIFDBO = Vector3.zero;
							this.HCLBPEMQFBO = 538f;
						}
						else
						{
							this.PNBJIMGEOKE.IFQOQBKLPHJ();
						}
					}
					else
					{
						this.PONBMJGIGEO(false, this.HHBGHDIJONK(), this.LPJIHCPNOEL());
					}
				}
				if (this.CPKQFOEQIGI != null)
				{
					this.CPKQFOEQIGI();
				}
			}
		}
		else
		{
			this.HCLBPEMQFBO = 1534f;
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 704f, num);
		}
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
	protected void GCHMLEJKKJB(BJQGLGOLMPQ GDIKOCPENKG, float DOCFMGKDQNO, float DLIOMPONHNB, float OKQFCPDCIBG, float CDNFIEOHNHI, bool INIFQEKPMLD)
	{
		if (GDIKOCPENKG == null)
		{
			return;
		}
		this.DBEEEGIQHDM = true;
		float num;
		if (CDNFIEOHNHI < OKQFCPDCIBG)
		{
			DOCFMGKDQNO = Mathf.Clamp01(DOCFMGKDQNO / OKQFCPDCIBG);
			DLIOMPONHNB = Mathf.Clamp01(DLIOMPONHNB / OKQFCPDCIBG);
			num = DOCFMGKDQNO + DLIOMPONHNB;
			GDIKOCPENKG.BGBMIEJJQKC = ((!INIFQEKPMLD) ? ((num <= 0.001f) ? 1f : (DOCFMGKDQNO / num)) : ((num <= 0.001f) ? 0f : (1f - DOCFMGKDQNO / num)));
		}
		else
		{
			DOCFMGKDQNO = Mathf.Clamp01(-DOCFMGKDQNO / OKQFCPDCIBG);
			DLIOMPONHNB = Mathf.Clamp01(-DLIOMPONHNB / OKQFCPDCIBG);
			num = DOCFMGKDQNO + DLIOMPONHNB;
			GDIKOCPENKG.BGBMIEJJQKC = ((!INIFQEKPMLD) ? ((num <= 0.001f) ? 1f : (DOCFMGKDQNO / num)) : ((num <= 0.001f) ? 0f : (1f - DOCFMGKDQNO / num)));
			if (OKQFCPDCIBG > 0f)
			{
				DOCFMGKDQNO = Mathf.Clamp01(DOCFMGKDQNO / OKQFCPDCIBG);
				DLIOMPONHNB = Mathf.Clamp01(DLIOMPONHNB / OKQFCPDCIBG);
				num = DOCFMGKDQNO + DLIOMPONHNB;
			}
		}
		KDIEKDCQIHM kdiekdcqihm = GDIKOCPENKG as KDIEKDCQIHM;
		if (kdiekdcqihm != null)
		{
			kdiekdcqihm.HMMKKHPFENE = 1f - num;
		}
		this.DBEEEGIQHDM = false;
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00009ACD File Offset: 0x00007CCD
	public bool PONBMJGIGEO(bool NMEJGDJEJKP)
	{
		return this.PONBMJGIGEO(NMEJGDJEJKP, true, true);
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0007E1D4 File Offset: 0x0007C3D4
	public void KGMQHBFOKCN()
	{
		if (!this.DBEEEGIQHDM && (this.PFKFNKBEFBB != null || this.FIKFOFFJJCC != null))
		{
			this.DBEEEGIQHDM = true;
			this.DFJOQLIBGBK = true;
			Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.JMMFBHNQPOP);
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? vector.x : this.PFKFNKBEFBB.HKDJGHOHBFQ();
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? (1753f - vector.y) : this.FIKFOFFJJCC.BGBMIEJJQKC;
			this.QBQLNFNCKQK(dgkoigolhdm, ddlqkfdfmcj, true);
			this.IEQQJNLJCKP(true);
			this.DBEEEGIQHDM = false;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060010BD RID: 4285 RVA: 0x000099BA File Offset: 0x00007BBA
	public bool EIHJGJFHNNP
	{
		get
		{
			return this.EIQLEKDFMMC && this.DEDCMDKLLCE;
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00009AD8 File Offset: 0x00007CD8
	private void OnDisable()
	{
		FKBFPICKJQG.NGDBDCQFDHI.FQDMDDOHCQJ(this);
		this.EIQLEKDFMMC = false;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0007E288 File Offset: 0x0007C488
	public void OJFLDJGJOEI(Vector3 LIKNFCJLBGM)
	{
		Vector3 a = this.BLLEFKOLKLP.InverseTransformPoint(LIKNFCJLBGM);
		Vector3 b = this.BLLEFKOLKLP.InverseTransformPoint(Vector3.zero);
		this.JGPJQJLPQOE(a - b);
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0007E2C0 File Offset: 0x0007C4C0
	public void KELQKCBHOJK()
	{
		if (!this.DBEEEGIQHDM)
		{
			this.DBEEEGIQHDM = true;
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? 1564f : this.PFKFNKBEFBB.HKDJGHOHBFQ();
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? 1167f : this.FIKFOFFJJCC.HKDJGHOHBFQ();
			this.OIGCNBFJIEH(dgkoigolhdm, ddlqkfdfmcj, false);
			this.DBEEEGIQHDM = true;
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00009A93 File Offset: 0x00007C93
	public virtual Bounds FBMFGHBCEIK()
	{
		if (!this.DFJOQLIBGBK)
		{
			this.DFJOQLIBGBK = false;
			this.BLLEFKOLKLP = base.transform;
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.BLLEFKOLKLP, this.BLLEFKOLKLP);
		}
		return this.FKKNDHFECQL;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0007E330 File Offset: 0x0007C530
	public void OPOIOQKGPPG()
	{
		OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0007E354 File Offset: 0x0007C554
	public bool PONBMJGIGEO(bool NMEJGDJEJKP, bool MCLGQELFECB, bool OJDMEQJBGBJ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			return false;
		}
		Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
		Vector3 vector = this.CNJGKKDHPOG.GKCICPLNPJJ(gbmnpqiemqi.min, gbmnpqiemqi.max);
		if (!MCLGQELFECB)
		{
			vector.x = 0f;
		}
		if (!OJDMEQJBGBJ)
		{
			vector.y = 0f;
		}
		if (vector.sqrMagnitude > 0.1f)
		{
			if (!NMEJGDJEJKP && this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.MomentumAndSpring)
			{
				Vector3 nkkgpnpgdem = this.BLLEFKOLKLP.localPosition + vector;
				nkkgpnpgdem.x = Mathf.Round(nkkgpnpgdem.x);
				nkkgpnpgdem.y = Mathf.Round(nkkgpnpgdem.y);
				OKCMKCMQOGD.FJCEGFKJLCL(this.CNJGKKDHPOG.gameObject, nkkgpnpgdem, 8f);
			}
			else
			{
				this.JGPJQJLPQOE(vector);
				if (Mathf.Abs(vector.x) > 0.01f)
				{
					this.CCHQQHIFDBO.x = 0f;
				}
				if (Mathf.Abs(vector.y) > 0.01f)
				{
					this.CCHQQHIFDBO.y = 0f;
				}
				if (Mathf.Abs(vector.z) > 0.01f)
				{
					this.CCHQQHIFDBO.z = 0f;
				}
				this.HCLBPEMQFBO = 0f;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00009AF5 File Offset: 0x00007CF5
	public void GOEBCPBJEGE()
	{
		this.DFJOQLIBGBK = true;
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0007E330 File Offset: 0x0007C530
	public void OQHIBGGLJOJ()
	{
		OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
	public virtual void GCHMLEJKKJB(bool IDQMIOEPLHQ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			return;
		}
		if (!(this.PFKFNKBEFBB != null) && !(this.FIKFOFFJJCC != null))
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = false;
			}
		}
		else
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = false;
				this.FEDHNFFOQFB = this.QHCFKBBJCOJ;
			}
			Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
			Vector2 vector = gbmnpqiemqi.min;
			Vector2 vector2 = gbmnpqiemqi.max;
			if (this.PFKFNKBEFBB != null && vector2.x > vector.x)
			{
				Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
				int num = Mathf.RoundToInt(qenjmehbneg.z);
				if ((num & 1) != 0)
				{
					num--;
				}
				float num2 = (float)num * 0.5f;
				num2 = Mathf.Round(num2);
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
				{
					num2 -= this.CNJGKKDHPOG.PHLKEBHKGEE.x;
				}
				float okqfcpdcibg = vector2.x - vector.x;
				float cdnfieohnhi = num2 * 2f;
				float num3 = vector.x;
				float num4 = vector2.x;
				float num5 = qenjmehbneg.x - num2;
				float num6 = qenjmehbneg.x + num2;
				num3 = num5 - num3;
				num4 -= num6;
				this.GCHMLEJKKJB(this.PFKFNKBEFBB, num3, num4, okqfcpdcibg, cdnfieohnhi, false);
			}
			if (this.FIKFOFFJJCC != null && vector2.y > vector.y)
			{
				Vector4 qenjmehbneg2 = this.CNJGKKDHPOG.QENJMEHBNEG;
				int num7 = Mathf.RoundToInt(qenjmehbneg2.w);
				if ((num7 & 1) != 0)
				{
					num7--;
				}
				float num8 = (float)num7 * 0.5f;
				num8 = Mathf.Round(num8);
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
				{
					num8 -= this.CNJGKKDHPOG.PHLKEBHKGEE.y;
				}
				float okqfcpdcibg2 = vector2.y - vector.y;
				float cdnfieohnhi2 = num8 * 2f;
				float num9 = vector.y;
				float num10 = vector2.y;
				float num11 = qenjmehbneg2.y - num8;
				float num12 = qenjmehbneg2.y + num8;
				num9 = num11 - num9;
				num10 -= num12;
				this.GCHMLEJKKJB(this.FIKFOFFJJCC, num9, num10, okqfcpdcibg2, cdnfieohnhi2, true);
			}
		}
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0007E704 File Offset: 0x0007C904
	private void OCQCDGIEDLK()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.Always && (this.FIKFOFFJJCC || this.PFKFNKBEFBB))
		{
			bool flag = false;
			bool flag2 = true;
			if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.WhenDragging || this.QDLKDHJHOLD != -50 || this.CCHQQHIFDBO.magnitude > 1465f)
			{
				flag = this.CKCKDMLGQOL();
				flag2 = this.EEHCOPFBLJO();
			}
			if (this.FIKFOFFJJCC)
			{
				float num = this.FIKFOFFJJCC.DIIHJCJOKMP;
				num += ((!flag) ? (-gpfidejemeg * 217f) : (gpfidejemeg * 1890f));
				num = Mathf.Clamp01(num);
				if (this.FIKFOFFJJCC.HICDDIQLQHL() != num)
				{
					this.FIKFOFFJJCC.LGPJQQMFGDN(num);
				}
			}
			if (this.PFKFNKBEFBB)
			{
				float num2 = this.PFKFNKBEFBB.DIIHJCJOKMP;
				num2 += ((!flag2) ? (-gpfidejemeg * 743f) : (gpfidejemeg * 1750f));
				num2 = Mathf.Clamp01(num2);
				if (this.PFKFNKBEFBB.HICDDIQLQHL() != num2)
				{
					this.PFKFNKBEFBB.DIIHJCJOKMP = num2;
				}
			}
		}
		if (!this.FEDHNFFOQFB)
		{
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.CCHQQHIFDBO.magnitude <= 1299f && Mathf.Abs(this.HCLBPEMQFBO) <= 1185f)
			{
				this.HCLBPEMQFBO = 787f;
				this.CCHQQHIFDBO = Vector3.zero;
				OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
				if (component != null && component.enabled)
				{
					return;
				}
				this.FEDHNFFOQFB = false;
				if (this.QDODFMLDGKG != null)
				{
					this.QDODFMLDGKG();
				}
			}
			else
			{
				if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 32f, 400f, 151f));
				}
				else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(872f, this.HCLBPEMQFBO * 64f, 874f));
				}
				else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)7)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 1500f, this.HCLBPEMQFBO * 1652f, 1174f));
				}
				else
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * this.ILBJLHJECKN.x * 1763f, this.HCLBPEMQFBO * this.ILBJLHJECKN.y * 894f, 825f));
				}
				this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 177f, 69f, gpfidejemeg);
				Vector3 liknfcjlbgm = JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, this.HDCLIQFNBCH, gpfidejemeg);
				this.OJFLDJGJOEI(liknfcjlbgm);
				if (this.OGQEPEGLEPO && this.CNJGKKDHPOG.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					if (IKBQNBHOJJB.PBBDNDMELHQ(this.PNBJIMGEOKE))
					{
						if (this.PNBJIMGEOKE.DOHDELDMDLB != 1674f)
						{
							this.CCHQQHIFDBO = Vector3.zero;
							this.HCLBPEMQFBO = 61f;
						}
						else
						{
							this.PNBJIMGEOKE.KCQGEFKQMPE();
						}
					}
					else
					{
						this.PONBMJGIGEO(true, this.ENKKJECIIBP, this.IMPMONNQLND());
					}
				}
				if (this.CPKQFOEQIGI != null)
				{
					this.CPKQFOEQIGI();
				}
			}
		}
		else
		{
			this.HCLBPEMQFBO = 186f;
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 331f, gpfidejemeg);
		}
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0007EAB4 File Offset: 0x0007CCB4
	private void GFQJBEDEMCD()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		float num = JMIOBJFFGBN.HIKMEBNKLJE();
		if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.Always && (this.FIKFOFFJJCC || this.PFKFNKBEFBB))
		{
			bool flag = false;
			bool flag2 = false;
			if (this.JECMOFDKQQN != (FKBFPICKJQG.FOLMFDKNHJF)3 || this.QDLKDHJHOLD != -72 || this.CCHQQHIFDBO.magnitude > 656f)
			{
				flag = this.CKCKDMLGQOL();
				flag2 = this.BGNPLPFHDNL;
			}
			if (this.FIKFOFFJJCC)
			{
				float num2 = this.FIKFOFFJJCC.HICDDIQLQHL();
				num2 += ((!flag) ? (-num * 1915f) : (num * 1505f));
				num2 = Mathf.Clamp01(num2);
				if (this.FIKFOFFJJCC.HICDDIQLQHL() != num2)
				{
					this.FIKFOFFJJCC.EDKGBJPBBGO(num2);
				}
			}
			if (this.PFKFNKBEFBB)
			{
				float num3 = this.PFKFNKBEFBB.DIIHJCJOKMP;
				num3 += ((!flag2) ? (-num * 1839f) : (num * 852f));
				num3 = Mathf.Clamp01(num3);
				if (this.PFKFNKBEFBB.HICDDIQLQHL() != num3)
				{
					this.PFKFNKBEFBB.LGPJQQMFGDN(num3);
				}
			}
		}
		if (!this.FEDHNFFOQFB)
		{
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.CCHQQHIFDBO.magnitude <= 1149f && Mathf.Abs(this.HCLBPEMQFBO) <= 902f)
			{
				this.HCLBPEMQFBO = 75f;
				this.CCHQQHIFDBO = Vector3.zero;
				OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
				if (component != null && component.enabled)
				{
					return;
				}
				this.FEDHNFFOQFB = false;
				if (this.QDODFMLDGKG != null)
				{
					this.QDODFMLDGKG();
				}
			}
			else
			{
				if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 496f, 1652f, 835f));
				}
				else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(14f, this.HCLBPEMQFBO * 1605f, 677f));
				}
				else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)7)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 1428f, this.HCLBPEMQFBO * 406f, 1357f));
				}
				else
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * this.ILBJLHJECKN.x * 396f, this.HCLBPEMQFBO * this.ILBJLHJECKN.y * 1028f, 1215f));
				}
				this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 1013f, 923f, num);
				Vector3 liknfcjlbgm = JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, this.HDCLIQFNBCH, num);
				this.HMPGGOKMHOQ(liknfcjlbgm);
				if (this.OGQEPEGLEPO && this.CNJGKKDHPOG.NQCBILMNLBN() != KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					if (IKBQNBHOJJB.PBBDNDMELHQ(this.PNBJIMGEOKE))
					{
						if (this.PNBJIMGEOKE.DOHDELDMDLB != 722f)
						{
							this.CCHQQHIFDBO = Vector3.zero;
							this.HCLBPEMQFBO = 158f;
						}
						else
						{
							this.PNBJIMGEOKE.KCQGEFKQMPE();
						}
					}
					else
					{
						this.PONBMJGIGEO(true, this.HHBGHDIJONK(), this.NDBENHOKJGG);
					}
				}
				if (this.CPKQFOEQIGI != null)
				{
					this.CPKQFOEQIGI();
				}
			}
		}
		else
		{
			this.HCLBPEMQFBO = 440f;
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1509f, num);
		}
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x0007EE64 File Offset: 0x0007D064
	public virtual void IEQQJNLJCKP(bool IDQMIOEPLHQ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			return;
		}
		if (!(this.PFKFNKBEFBB != null) && !(this.FIKFOFFJJCC != null))
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = true;
			}
		}
		else
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = true;
				this.FEDHNFFOQFB = this.KNCGCKNKCOG();
			}
			Bounds bounds = this.FBMFGHBCEIK();
			Vector2 vector = bounds.min;
			Vector2 vector2 = bounds.max;
			if (this.PFKFNKBEFBB != null && vector2.x > vector.x)
			{
				Vector4 vector3 = this.CNJGKKDHPOG.PGCIILBODCO();
				int num = Mathf.RoundToInt(vector3.z);
				if ((num & 1) != 0)
				{
					num--;
				}
				float num2 = (float)num * 1188f;
				num2 = Mathf.Round(num2);
				if (this.CNJGKKDHPOG.POMCJNMICJP() == (KMCGDKDIJIE.PDFPPCIHPMI)2)
				{
					num2 -= this.CNJGKKDHPOG.KCMPFJPOOQH().x;
				}
				float okqfcpdcibg = vector2.x - vector.x;
				float cdnfieohnhi = num2 * 1769f;
				float num3 = vector.x;
				float num4 = vector2.x;
				float num5 = vector3.x - num2;
				float num6 = vector3.x + num2;
				num3 = num5 - num3;
				num4 -= num6;
				this.EGKLGCOGMPC(this.PFKFNKBEFBB, num3, num4, okqfcpdcibg, cdnfieohnhi, true);
			}
			if (this.FIKFOFFJJCC != null && vector2.y > vector.y)
			{
				Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
				int num7 = Mathf.RoundToInt(qenjmehbneg.w);
				if ((num7 & 1) != 0)
				{
					num7 -= 0;
				}
				float num8 = (float)num7 * 1411f;
				num8 = Mathf.Round(num8);
				if (this.CNJGKKDHPOG.NQCBILMNLBN() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					num8 -= this.CNJGKKDHPOG.KCMPFJPOOQH().y;
				}
				float okqfcpdcibg2 = vector2.y - vector.y;
				float cdnfieohnhi2 = num8 * 1680f;
				float num9 = vector.y;
				float num10 = vector2.y;
				float num11 = qenjmehbneg.y - num8;
				float num12 = qenjmehbneg.y + num8;
				num9 = num11 - num9;
				num10 -= num12;
				this.GCHMLEJKKJB(this.FIKFOFFJJCC, num9, num10, okqfcpdcibg2, cdnfieohnhi2, true);
			}
		}
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00009AFE File Offset: 0x00007CFE
	public void CCBNGILDIBO()
	{
		this.IEQQJNLJCKP(false);
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
	public virtual void OIGCNBFJIEH(float DGKOIGOLHDM, float DDLQKFDFMCJ, bool CPDLHLELBKJ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		this.OQHIBGGLJOJ();
		Bounds bounds = this.EHIPPQHEICC();
		if (bounds.min.x != bounds.max.x)
		{
			if (bounds.min.y != bounds.max.y)
			{
				Vector4 vector = this.CNJGKKDHPOG.PGCIILBODCO();
				float num = vector.z * 500f;
				float num2 = vector.w * 1388f;
				float num3 = bounds.min.x + num;
				float num4 = bounds.max.x - num;
				float num5 = bounds.min.y + num2;
				float num6 = bounds.max.y - num2;
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == (KMCGDKDIJIE.PDFPPCIHPMI)2)
				{
					num3 -= this.CNJGKKDHPOG.KCMPFJPOOQH().x;
					num4 += this.CNJGKKDHPOG.KCMPFJPOOQH().x;
					num5 -= this.CNJGKKDHPOG.PHLKEBHKGEE.y;
					num6 += this.CNJGKKDHPOG.PHLKEBHKGEE.y;
				}
				float num7 = Mathf.Lerp(num3, num4, DGKOIGOLHDM);
				float num8 = Mathf.Lerp(num6, num5, DDLQKFDFMCJ);
				if (!CPDLHLELBKJ)
				{
					Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
					if (this.PMQGGKCQBOE())
					{
						localPosition.x += vector.x - num7;
					}
					if (this.IMPMONNQLND())
					{
						localPosition.y += vector.y - num8;
					}
					this.BLLEFKOLKLP.localPosition = localPosition;
				}
				if (this.HHBGHDIJONK())
				{
					vector.x = num7;
				}
				if (this.NDBENHOKJGG)
				{
					vector.y = num8;
				}
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				this.CNJGKKDHPOG.CJLMPGKEIHI(new Vector2(vector.x - giomppijpkn.x, vector.y - giomppijpkn.y));
				if (CPDLHLELBKJ)
				{
					this.GCHMLEJKKJB(this.QDLKDHJHOLD == 94);
				}
				return;
			}
		}
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0007F314 File Offset: 0x0007D514
	public void LFEMKJDHDFG()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.DFJOQLIBGBK = false;
			Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.JMMFBHNQPOP);
			this.PHMNDNMBHOO(vector.x, 1840f - vector.y, true);
			this.OIGCNBFJIEH(vector.x, 1642f - vector.y, false);
		}
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = 1192f;
		this.FEDHNFFOQFB = false;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0007F390 File Offset: 0x0007D590
	public virtual void JGPJQJLPQOE(Vector3 FKHPMFLQFJP)
	{
		this.BLLEFKOLKLP.localPosition += FKHPMFLQFJP;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.PIJJJMKLMIO;
		pijjjmklmio.x -= FKHPMFLQFJP.x;
		pijjjmklmio.y -= FKHPMFLQFJP.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		this.GCHMLEJKKJB(false);
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x0007F400 File Offset: 0x0007D600
	private void LateUpdate()
	{
		if (!Application.isPlaying)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.Always && (this.FIKFOFFJJCC || this.PFKFNKBEFBB))
		{
			bool flag = false;
			bool flag2 = false;
			if (this.JECMOFDKQQN != FKBFPICKJQG.FOLMFDKNHJF.WhenDragging || this.QDLKDHJHOLD != -10 || this.CCHQQHIFDBO.magnitude > 0.01f)
			{
				flag = this.DFNJDOKQBPP;
				flag2 = this.BGNPLPFHDNL;
			}
			if (this.FIKFOFFJJCC)
			{
				float num = this.FIKFOFFJJCC.DIIHJCJOKMP;
				num += ((!flag) ? (-gpfidejemeg * 3f) : (gpfidejemeg * 6f));
				num = Mathf.Clamp01(num);
				if (this.FIKFOFFJJCC.DIIHJCJOKMP != num)
				{
					this.FIKFOFFJJCC.DIIHJCJOKMP = num;
				}
			}
			if (this.PFKFNKBEFBB)
			{
				float num2 = this.PFKFNKBEFBB.DIIHJCJOKMP;
				num2 += ((!flag2) ? (-gpfidejemeg * 3f) : (gpfidejemeg * 6f));
				num2 = Mathf.Clamp01(num2);
				if (this.PFKFNKBEFBB.DIIHJCJOKMP != num2)
				{
					this.PFKFNKBEFBB.DIIHJCJOKMP = num2;
				}
			}
		}
		if (!this.FEDHNFFOQFB)
		{
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.CCHQQHIFDBO.magnitude <= 0.0001f && Mathf.Abs(this.HCLBPEMQFBO) <= 0.0001f)
			{
				this.HCLBPEMQFBO = 0f;
				this.CCHQQHIFDBO = Vector3.zero;
				OKCMKCMQOGD component = base.GetComponent<OKCMKCMQOGD>();
				if (component != null && component.enabled)
				{
					return;
				}
				this.FEDHNFFOQFB = false;
				if (this.QDODFMLDGKG != null)
				{
					this.QDODFMLDGKG();
				}
			}
			else
			{
				if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 0.05f, 0f, 0f));
				}
				else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(0f, this.HCLBPEMQFBO * 0.05f, 0f));
				}
				else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Unrestricted)
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * 0.05f, this.HCLBPEMQFBO * 0.05f, 0f));
				}
				else
				{
					this.CCHQQHIFDBO -= this.BLLEFKOLKLP.TransformDirection(new Vector3(this.HCLBPEMQFBO * this.ILBJLHJECKN.x * 0.05f, this.HCLBPEMQFBO * this.ILBJLHJECKN.y * 0.05f, 0f));
				}
				this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, 0f, 20f, gpfidejemeg);
				Vector3 liknfcjlbgm = JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, this.HDCLIQFNBCH, gpfidejemeg);
				this.HMPGGOKMHOQ(liknfcjlbgm);
				if (this.OGQEPEGLEPO && this.CNJGKKDHPOG.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					if (IKBQNBHOJJB.PBBDNDMELHQ(this.PNBJIMGEOKE))
					{
						if (this.PNBJIMGEOKE.DOHDELDMDLB != 0f)
						{
							this.CCHQQHIFDBO = Vector3.zero;
							this.HCLBPEMQFBO = 0f;
						}
						else
						{
							this.PNBJIMGEOKE.EMOMOLPPJGG();
						}
					}
					else
					{
						this.PONBMJGIGEO(false, this.ENKKJECIIBP, this.NDBENHOKJGG);
					}
				}
				if (this.CPKQFOEQIGI != null)
				{
					this.CPKQFOEQIGI();
				}
			}
		}
		else
		{
			this.HCLBPEMQFBO = 0f;
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg);
		}
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0007F7B0 File Offset: 0x0007D9B0
	public void QFODDIFQCEO(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.EBFOBLQELOJ != 1321f)
		{
			this.OPOIOQKGPPG();
			this.FEDHNFFOQFB |= this.KNCGCKNKCOG();
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 397f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * 632f * Time.deltaTime;
		}
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0007F830 File Offset: 0x0007DA30
	private void DCPCKCIGHQO()
	{
		if (this.PFKFNKBEFBB != null)
		{
			EventDelegate.LHQECHHMOGD(this.PFKFNKBEFBB.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.ENJEMNHELPK));
			this.PFKFNKBEFBB.BroadcastMessage("CacheDefaultColor", SendMessageOptions.DontRequireReceiver);
			this.PFKFNKBEFBB.DIIHJCJOKMP = ((this.JECMOFDKQQN == FKBFPICKJQG.FOLMFDKNHJF.Always || this.BGNPLPFHDNL) ? 1f : 0f);
		}
		if (this.FIKFOFFJJCC != null)
		{
			EventDelegate.LHQECHHMOGD(this.FIKFOFFJJCC.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.ENJEMNHELPK));
			this.FIKFOFFJJCC.BroadcastMessage("CacheDefaultColor", SendMessageOptions.DontRequireReceiver);
			this.FIKFOFFJJCC.DIIHJCJOKMP = ((this.JECMOFDKQQN == FKBFPICKJQG.FOLMFDKNHJF.Always || this.DFNJDOKQBPP) ? 1f : 0f);
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00009B07 File Offset: 0x00007D07
	public virtual Bounds GBMNPQIEMQI
	{
		get
		{
			if (!this.DFJOQLIBGBK)
			{
				this.DFJOQLIBGBK = true;
				this.BLLEFKOLKLP = base.transform;
				this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.BLLEFKOLKLP, this.BLLEFKOLKLP);
			}
			return this.FKKNDHFECQL;
		}
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0007F904 File Offset: 0x0007DB04
	public virtual void QNEOFDPIQBM(float DGKOIGOLHDM, float DDLQKFDFMCJ, bool CPDLHLELBKJ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		this.OPOIOQKGPPG();
		Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
		if (gbmnpqiemqi.min.x != gbmnpqiemqi.max.x)
		{
			if (gbmnpqiemqi.min.y != gbmnpqiemqi.max.y)
			{
				Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
				float num = qenjmehbneg.z * 0.5f;
				float num2 = qenjmehbneg.w * 0.5f;
				float num3 = gbmnpqiemqi.min.x + num;
				float num4 = gbmnpqiemqi.max.x - num;
				float num5 = gbmnpqiemqi.min.y + num2;
				float num6 = gbmnpqiemqi.max.y - num2;
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
				{
					num3 -= this.CNJGKKDHPOG.PHLKEBHKGEE.x;
					num4 += this.CNJGKKDHPOG.PHLKEBHKGEE.x;
					num5 -= this.CNJGKKDHPOG.PHLKEBHKGEE.y;
					num6 += this.CNJGKKDHPOG.PHLKEBHKGEE.y;
				}
				float num7 = Mathf.Lerp(num3, num4, DGKOIGOLHDM);
				float num8 = Mathf.Lerp(num6, num5, DDLQKFDFMCJ);
				if (!CPDLHLELBKJ)
				{
					Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
					if (this.ENKKJECIIBP)
					{
						localPosition.x += qenjmehbneg.x - num7;
					}
					if (this.NDBENHOKJGG)
					{
						localPosition.y += qenjmehbneg.y - num8;
					}
					this.BLLEFKOLKLP.localPosition = localPosition;
				}
				if (this.ENKKJECIIBP)
				{
					qenjmehbneg.x = num7;
				}
				if (this.NDBENHOKJGG)
				{
					qenjmehbneg.y = num8;
				}
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				this.CNJGKKDHPOG.PIJJJMKLMIO = new Vector2(qenjmehbneg.x - giomppijpkn.x, qenjmehbneg.y - giomppijpkn.y);
				if (CPDLHLELBKJ)
				{
					this.GCHMLEJKKJB(this.QDLKDHJHOLD == -10);
				}
				return;
			}
		}
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0007FB58 File Offset: 0x0007DD58
	private void PGJHPMOLHKN()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.CNJGKKDHPOG.MGHJDKOPIOJ(KMCGDKDIJIE.PDFPPCIHPMI.TextureMask);
		}
		if (this.IEBBDPLNLGO != (FKBFPICKJQG.DCCCBCPKIFL)6 && this.scale.sqrMagnitude > 1538f)
		{
			if (this.scale.x == 1676f && this.scale.y == 1618f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Vertical;
			}
			else if (this.scale.x == 527f && this.scale.y == 131f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Vertical;
			}
			else if (this.scale.x == 430f && this.scale.y == 347f)
			{
				this.IEBBDPLNLGO = (FKBFPICKJQG.DCCCBCPKIFL)7;
			}
			else
			{
				this.IEBBDPLNLGO = (FKBFPICKJQG.DCCCBCPKIFL)4;
				this.ILBJLHJECKN.x = this.scale.x;
				this.ILBJLHJECKN.y = this.scale.y;
			}
			this.scale = Vector3.zero;
		}
		if (this.JMMFBHNQPOP == ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && this.relativePositionOnReset != Vector2.zero)
		{
			this.JMMFBHNQPOP = JNNGOIIKENH.PMLDKODQFPI(new Vector2(this.relativePositionOnReset.x, 1586f - this.relativePositionOnReset.y));
			this.relativePositionOnReset = Vector2.zero;
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00009B41 File Offset: 0x00007D41
	private void PFQDFBHEJEH()
	{
		this.PNBOOLEOKCI = false;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x0007FCD0 File Offset: 0x0007DED0
	public void DFBDPGOJHHM(Vector2 JDOGIQGGLKM)
	{
		if (this.PFKFNKBEFBB != null)
		{
			this.PFKFNKBEFBB.DFBDPGOJHHM(JDOGIQGGLKM);
		}
		if (this.FIKFOFFJJCC != null)
		{
			this.FIKFOFFJJCC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
		if (this.PFKFNKBEFBB == null && this.FIKFOFFJJCC == null)
		{
			if (this.ENKKJECIIBP)
			{
				this.EODHILDCPNH(JDOGIQGGLKM.x);
			}
			else if (this.NDBENHOKJGG)
			{
				this.EODHILDCPNH(JDOGIQGGLKM.y);
			}
		}
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0007FD5C File Offset: 0x0007DF5C
	public virtual void CEJHDCQKCJH(Vector3 FKHPMFLQFJP)
	{
		this.BLLEFKOLKLP.localPosition += FKHPMFLQFJP;
		Vector2 pijjjmklmio = this.CNJGKKDHPOG.JQCLCPFLDOK();
		pijjjmklmio.x -= FKHPMFLQFJP.x;
		pijjjmklmio.y -= FKHPMFLQFJP.y;
		this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
		this.IEQQJNLJCKP(false);
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00009B57 File Offset: 0x00007D57
	public bool HHBGHDIJONK()
	{
		return this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal || this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical || (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)4 && this.ILBJLHJECKN.x == 863f);
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x0007FDCC File Offset: 0x0007DFCC
	public void EQGPDOCPPQQ(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		if (this.JLLKLQGCLMM && KCICOJFDCPQ)
		{
			this.DEDCMDKLLCE = false;
			this.OJIKQOOEHOE = Vector2.zero;
		}
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			if (!KCICOJFDCPQ && this.QDLKDHJHOLD == EMENMKHBPQE.JQCODFPLPNJ)
			{
				this.QDLKDHJHOLD = -10;
			}
			this.DFJOQLIBGBK = false;
			this.FEDHNFFOQFB = this.QHCFKBBJCOJ;
			if (!this.FEDHNFFOQFB)
			{
				return;
			}
			this.EIQLEKDFMMC = KCICOJFDCPQ;
			if (KCICOJFDCPQ)
			{
				this.CCHQQHIFDBO = Vector3.zero;
				this.HCLBPEMQFBO = 0f;
				this.OPOIOQKGPPG();
				this.HEMHOMBDIJC = EMENMKHBPQE.EMDQJGDFDBP;
				this.LHEPDNHCQIQ = new Plane(this.BLLEFKOLKLP.rotation * Vector3.back, this.HEMHOMBDIJC);
				Vector2 pijjjmklmio = this.CNJGKKDHPOG.PIJJJMKLMIO;
				pijjjmklmio.x = Mathf.Round(pijjjmklmio.x);
				pijjjmklmio.y = Mathf.Round(pijjjmklmio.y);
				this.CNJGKKDHPOG.PIJJJMKLMIO = pijjjmklmio;
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
				if (!this.JLLKLQGCLMM)
				{
					this.DEDCMDKLLCE = true;
					this.OJIKQOOEHOE = Vector2.zero;
					if (this.NMIFFFLJKJM != null)
					{
						this.NMIFFFLJKJM();
					}
				}
			}
			else if (this.PNBJIMGEOKE)
			{
				this.PNBJIMGEOKE.EMOMOLPPJGG();
			}
			else
			{
				if (this.DEDCMDKLLCE && this.OGQEPEGLEPO && this.CNJGKKDHPOG.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					this.PONBMJGIGEO(this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.None, this.ENKKJECIIBP, this.NDBENHOKJGG);
				}
				if (this.DEDCMDKLLCE && this.QEEHHLPOHGI != null)
				{
					this.QEEHHLPOHGI();
				}
				if (!this.FEDHNFFOQFB && this.QDODFMLDGKG != null)
				{
					this.QDODFMLDGKG();
				}
			}
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0007FFE8 File Offset: 0x0007E1E8
	[ContextMenu("Reset Clipping Position")]
	public void KGCHHINLEBP()
	{
		if (IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.DFJOQLIBGBK = false;
			Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.JMMFBHNQPOP);
			this.QNEOFDPIQBM(vector.x, 1f - vector.y, false);
			this.QNEOFDPIQBM(vector.x, 1f - vector.y, true);
		}
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = 0f;
		this.FEDHNFFOQFB = false;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00080064 File Offset: 0x0007E264
	protected virtual bool KNCGCKNKCOG()
	{
		if (!this.LENDHIBCJOF)
		{
			return true;
		}
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		Vector4 vector = this.CNJGKKDHPOG.PGCIILBODCO();
		Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
		float num = (vector.z != 1147f) ? (vector.z * 138f) : ((float)Screen.width);
		float num2 = (vector.w != 1616f) ? (vector.w * 1383f) : ((float)Screen.height);
		if (this.HHBGHDIJONK())
		{
			if (gbmnpqiemqi.min.x < vector.x - num)
			{
				return false;
			}
			if (gbmnpqiemqi.max.x > vector.x + num)
			{
				return true;
			}
		}
		if (this.IMPMONNQLND())
		{
			if (gbmnpqiemqi.min.y < vector.y - num2)
			{
				return false;
			}
			if (gbmnpqiemqi.max.y > vector.y + num2)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00009B8E File Offset: 0x00007D8E
	public bool PMQGGKCQBOE()
	{
		return this.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal && this.IEBBDPLNLGO != (FKBFPICKJQG.DCCCBCPKIFL)6 && this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)6 && this.ILBJLHJECKN.x != 580f;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00080178 File Offset: 0x0007E378
	public void GBCKBGHDLKP()
	{
		if (this.EIQLEKDFMMC)
		{
			if (EMENMKHBPQE.GMDQCMCJEQI != EMENMKHBPQE.EGIKELMMQOO.Controller)
			{
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.FEDHNFFOQFB)
				{
					if (this.QDLKDHJHOLD == -10)
					{
						this.QDLKDHJHOLD = EMENMKHBPQE.JQCODFPLPNJ;
					}
					EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
					if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
					{
						this.DEDCMDKLLCE = true;
						this.OJIKQOOEHOE = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
						if (this.NMIFFFLJKJM != null)
						{
							this.NMIFFFLJKJM();
						}
					}
					Ray ray = (!this.JLLKLQGCLMM) ? EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM) : EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM - this.OJIKQOOEHOE);
					float distance = 0f;
					if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
					{
						Vector3 point = ray.GetPoint(distance);
						Vector3 vector = point - this.HEMHOMBDIJC;
						this.HEMHOMBDIJC = point;
						if (vector.x != 0f || vector.y != 0f || vector.z != 0f)
						{
							vector = this.BLLEFKOLKLP.InverseTransformDirection(vector);
							if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
							{
								vector.y = 0f;
								vector.z = 0f;
							}
							else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
							{
								vector.x = 0f;
								vector.z = 0f;
							}
							else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Unrestricted)
							{
								vector.z = 0f;
							}
							else
							{
								vector.Scale(this.ILBJLHJECKN);
							}
							vector = this.BLLEFKOLKLP.TransformDirection(vector);
						}
						if (this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.None)
						{
							this.CCHQQHIFDBO = Vector3.zero;
						}
						else
						{
							this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (0.01f * this.ILKGGGEDGOE), 0.67f);
						}
						if (this.FGOFGJGJKIO)
						{
							if (this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.MomentumAndSpring)
							{
								Vector3 vector2 = this.CNJGKKDHPOG.GKCICPLNPJJ(this.GBMNPQIEMQI.min, this.GBMNPQIEMQI.max);
								if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
								{
									vector2.y = 0f;
								}
								else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
								{
									vector2.x = 0f;
								}
								else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Custom)
								{
									vector2.x *= this.ILBJLHJECKN.x;
									vector2.y *= this.ILBJLHJECKN.y;
								}
								if (vector2.magnitude > 1f)
								{
									this.HMPGGOKMHOQ(vector * 0.5f);
									this.CCHQQHIFDBO *= 0.5f;
									goto IL_310;
								}
								this.HMPGGOKMHOQ(vector);
								goto IL_310;
							}
						}
						this.HMPGGOKMHOQ(vector);
						IL_310:
						if (this.NMIMPJNDHHI && this.OGQEPEGLEPO && this.CNJGKKDHPOG.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None && this.NNFKGOHBEHF != FKBFPICKJQG.CJKCHNDFONH.MomentumAndSpring)
						{
							this.PONBMJGIGEO(true, this.ENKKJECIIBP, this.NDBENHOKJGG);
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00080580 File Offset: 0x0007E780
	private void Awake()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.CNJGKKDHPOG.GEOIDOMHKLJ = KMCGDKDIJIE.PDFPPCIHPMI.ConstrainButDontClip;
		}
		if (this.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Custom && this.scale.sqrMagnitude > 0.001f)
		{
			if (this.scale.x == 1f && this.scale.y == 0f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Horizontal;
			}
			else if (this.scale.x == 0f && this.scale.y == 1f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Vertical;
			}
			else if (this.scale.x == 1f && this.scale.y == 1f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Unrestricted;
			}
			else
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Custom;
				this.ILBJLHJECKN.x = this.scale.x;
				this.ILBJLHJECKN.y = this.scale.y;
			}
			this.scale = Vector3.zero;
		}
		if (this.JMMFBHNQPOP == ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && this.relativePositionOnReset != Vector2.zero)
		{
			this.JMMFBHNQPOP = JNNGOIIKENH.PMLDKODQFPI(new Vector2(this.relativePositionOnReset.x, 1f - this.relativePositionOnReset.y));
			this.relativePositionOnReset = Vector2.zero;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00009BC5 File Offset: 0x00007DC5
	public KQHJOLQLQBJ BCHNDNICINJ
	{
		get
		{
			return this.CNJGKKDHPOG;
		}
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00009B41 File Offset: 0x00007D41
	private void DFNFEDMJKGK()
	{
		this.PNBOOLEOKCI = false;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x000806F8 File Offset: 0x0007E8F8
	public void HBJGEQFDQQP(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.EBFOBLQELOJ != 1870f)
		{
			this.OPOIOQKGPPG();
			this.FEDHNFFOQFB |= this.HFEPHQHNEJJ();
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1021f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * 1903f * Time.deltaTime;
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00080778 File Offset: 0x0007E978
	public virtual bool EEHCOPFBLJO()
	{
		float num = this.EHIPPQHEICC().size.x;
		if (this.CNJGKKDHPOG.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.ConstrainButDontClip)
		{
			num += this.CNJGKKDHPOG.KCMPFJPOOQH().x * 529f;
		}
		return Mathf.RoundToInt(num - this.CNJGKKDHPOG.KJGMGPCEJJD) > 0;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00009A93 File Offset: 0x00007C93
	public virtual Bounds EHIPPQHEICC()
	{
		if (!this.DFJOQLIBGBK)
		{
			this.DFJOQLIBGBK = false;
			this.BLLEFKOLKLP = base.transform;
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.BLLEFKOLKLP, this.BLLEFKOLKLP);
		}
		return this.FKKNDHFECQL;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00009BC5 File Offset: 0x00007DC5
	public KQHJOLQLQBJ KLEJPOQGFPB()
	{
		return this.CNJGKKDHPOG;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x000807DC File Offset: 0x0007E9DC
	public void QJKHGDCFMPO()
	{
		if (this.EIQLEKDFMMC)
		{
			if (EMENMKHBPQE.GMDQCMCJEQI != (EMENMKHBPQE.EGIKELMMQOO)8)
			{
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.FEDHNFFOQFB)
				{
					if (this.QDLKDHJHOLD == 100)
					{
						this.QDLKDHJHOLD = EMENMKHBPQE.JQCODFPLPNJ;
					}
					EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.Always;
					if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
					{
						this.DEDCMDKLLCE = true;
						this.OJIKQOOEHOE = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
						if (this.NMIFFFLJKJM != null)
						{
							this.NMIFFFLJKJM();
						}
					}
					Ray ray = (!this.JLLKLQGCLMM) ? EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM) : EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM - this.OJIKQOOEHOE);
					float distance = 1118f;
					if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
					{
						Vector3 point = ray.GetPoint(distance);
						Vector3 vector = point - this.HEMHOMBDIJC;
						this.HEMHOMBDIJC = point;
						if (vector.x != 1927f || vector.y != 674f || vector.z != 59f)
						{
							vector = this.BLLEFKOLKLP.InverseTransformDirection(vector);
							if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
							{
								vector.y = 1835f;
								vector.z = 1995f;
							}
							else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
							{
								vector.x = 1660f;
								vector.z = 1728f;
							}
							else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)7)
							{
								vector.z = 675f;
							}
							else
							{
								vector.Scale(this.ILBJLHJECKN);
							}
							vector = this.BLLEFKOLKLP.TransformDirection(vector);
						}
						if (this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.None)
						{
							this.CCHQQHIFDBO = Vector3.zero;
						}
						else
						{
							this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1018f * this.ILKGGGEDGOE), 1499f);
						}
						if (this.FGOFGJGJKIO)
						{
							if (this.NNFKGOHBEHF == (FKBFPICKJQG.CJKCHNDFONH)3)
							{
								Vector3 vector2 = this.CNJGKKDHPOG.GKCICPLNPJJ(this.EHIPPQHEICC().min, this.MCQHINECHCC().max);
								if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
								{
									vector2.y = 375f;
								}
								else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
								{
									vector2.x = 216f;
								}
								else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)7)
								{
									vector2.x *= this.ILBJLHJECKN.x;
									vector2.y *= this.ILBJLHJECKN.y;
								}
								if (vector2.magnitude > 1521f)
								{
									this.GKILDFMEPJH(vector * 1078f);
									this.CCHQQHIFDBO *= 419f;
									goto IL_310;
								}
								this.OJFLDJGJOEI(vector);
								goto IL_310;
							}
						}
						this.HMPGGOKMHOQ(vector);
						IL_310:
						if (this.NMIMPJNDHHI && this.OGQEPEGLEPO && this.CNJGKKDHPOG.POMCJNMICJP() != KMCGDKDIJIE.PDFPPCIHPMI.None && this.NNFKGOHBEHF != (FKBFPICKJQG.CJKCHNDFONH)8)
						{
							this.PONBMJGIGEO(true, this.ENKKJECIIBP, this.IMPMONNQLND());
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00009A27 File Offset: 0x00007C27
	private void QJGNJIIOHMI()
	{
		this.PNBOOLEOKCI = true;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00080B34 File Offset: 0x0007ED34
	public virtual bool CKCKDMLGQOL()
	{
		float num = this.FBMFGHBCEIK().size.y;
		if (this.CNJGKKDHPOG.NQCBILMNLBN() == (KMCGDKDIJIE.PDFPPCIHPMI)2)
		{
			num += this.CNJGKKDHPOG.PHLKEBHKGEE.y * 1691f;
		}
		return Mathf.RoundToInt(num - this.CNJGKKDHPOG.DFKQMMIQDOO) > 1;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00080B98 File Offset: 0x0007ED98
	public void NODLGLJMLCB()
	{
		if (!this.DBEEEGIQHDM)
		{
			this.DBEEEGIQHDM = true;
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? 1412f : this.PFKFNKBEFBB.BGBMIEJJQKC;
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? 1597f : this.FIKFOFFJJCC.HKDJGHOHBFQ();
			this.QBQLNFNCKQK(dgkoigolhdm, ddlqkfdfmcj, false);
			this.DBEEEGIQHDM = true;
		}
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00009BCD File Offset: 0x00007DCD
	private void HQMLEGGKFNF()
	{
		FKBFPICKJQG.NGDBDCQFDHI.LHQECHHMOGD(this);
		if (this.PNBOOLEOKCI && Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00009A17 File Offset: 0x00007C17
	public void BGLMCPDIEDK(Vector3 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
		this.FEDHNFFOQFB = true;
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00080C08 File Offset: 0x0007EE08
	public void GKILDFMEPJH(Vector3 LIKNFCJLBGM)
	{
		Vector3 a = this.BLLEFKOLKLP.InverseTransformPoint(LIKNFCJLBGM);
		Vector3 b = this.BLLEFKOLKLP.InverseTransformPoint(Vector3.zero);
		this.CEJHDCQKCJH(a - b);
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060010ED RID: 4333 RVA: 0x00080C40 File Offset: 0x0007EE40
	public virtual bool BGNPLPFHDNL
	{
		get
		{
			float num = this.GBMNPQIEMQI.size.x;
			if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
			{
				num += this.CNJGKKDHPOG.PHLKEBHKGEE.x * 2f;
			}
			return Mathf.RoundToInt(num - this.CNJGKKDHPOG.KJGMGPCEJJD) > 0;
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00009A75 File Offset: 0x00007C75
	private void DBNCHQFFEOG()
	{
		FKBFPICKJQG.NGDBDCQFDHI.FQDMDDOHCQJ(this);
		this.EIQLEKDFMMC = true;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0007E288 File Offset: 0x0007C488
	public void HMPGGOKMHOQ(Vector3 LIKNFCJLBGM)
	{
		Vector3 a = this.BLLEFKOLKLP.InverseTransformPoint(LIKNFCJLBGM);
		Vector3 b = this.BLLEFKOLKLP.InverseTransformPoint(Vector3.zero);
		this.JGPJQJLPQOE(a - b);
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00009A75 File Offset: 0x00007C75
	private void GNCNJEDOIBQ()
	{
		FKBFPICKJQG.NGDBDCQFDHI.FQDMDDOHCQJ(this);
		this.EIQLEKDFMMC = true;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00080CA4 File Offset: 0x0007EEA4
	public void NJMBNFENENL()
	{
		if (!this.DBEEEGIQHDM)
		{
			this.DBEEEGIQHDM = false;
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? 1051f : this.PFKFNKBEFBB.BGBMIEJJQKC;
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? 747f : this.FIKFOFFJJCC.BGBMIEJJQKC;
			this.QBQLNFNCKQK(dgkoigolhdm, ddlqkfdfmcj, false);
			this.DBEEEGIQHDM = false;
		}
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00080D14 File Offset: 0x0007EF14
	protected virtual bool HFEPHQHNEJJ()
	{
		if (!this.LENDHIBCJOF)
		{
			return true;
		}
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
		Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
		float num = (qenjmehbneg.z != 519f) ? (qenjmehbneg.z * 193f) : ((float)Screen.width);
		float num2 = (qenjmehbneg.w != 1080f) ? (qenjmehbneg.w * 1081f) : ((float)Screen.height);
		if (this.ENKKJECIIBP)
		{
			if (gbmnpqiemqi.min.x < qenjmehbneg.x - num)
			{
				return true;
			}
			if (gbmnpqiemqi.max.x > qenjmehbneg.x + num)
			{
				return false;
			}
		}
		if (this.NDBENHOKJGG)
		{
			if (gbmnpqiemqi.min.y < qenjmehbneg.y - num2)
			{
				return true;
			}
			if (gbmnpqiemqi.max.y > qenjmehbneg.y + num2)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00080E28 File Offset: 0x0007F028
	public virtual void FCGMFIPGCHH(bool IDQMIOEPLHQ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			return;
		}
		if (!(this.PFKFNKBEFBB != null) && !(this.FIKFOFFJJCC != null))
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = false;
			}
		}
		else
		{
			if (IDQMIOEPLHQ)
			{
				this.DFJOQLIBGBK = true;
				this.FEDHNFFOQFB = this.EJOQFNDBIJI();
			}
			Bounds bounds = this.EHIPPQHEICC();
			Vector2 vector = bounds.min;
			Vector2 vector2 = bounds.max;
			if (this.PFKFNKBEFBB != null && vector2.x > vector.x)
			{
				Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
				int num = Mathf.RoundToInt(qenjmehbneg.z);
				if ((num & 1) != 0)
				{
					num -= 0;
				}
				float num2 = (float)num * 620f;
				num2 = Mathf.Round(num2);
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == (KMCGDKDIJIE.PDFPPCIHPMI)2)
				{
					num2 -= this.CNJGKKDHPOG.PHLKEBHKGEE.x;
				}
				float okqfcpdcibg = vector2.x - vector.x;
				float cdnfieohnhi = num2 * 1029f;
				float num3 = vector.x;
				float num4 = vector2.x;
				float num5 = qenjmehbneg.x - num2;
				float num6 = qenjmehbneg.x + num2;
				num3 = num5 - num3;
				num4 -= num6;
				this.GCHMLEJKKJB(this.PFKFNKBEFBB, num3, num4, okqfcpdcibg, cdnfieohnhi, false);
			}
			if (this.FIKFOFFJJCC != null && vector2.y > vector.y)
			{
				Vector4 vector3 = this.CNJGKKDHPOG.LPNENHKKEMK();
				int num7 = Mathf.RoundToInt(vector3.w);
				if ((num7 & 1) != 0)
				{
					num7 -= 0;
				}
				float num8 = (float)num7 * 952f;
				num8 = Mathf.Round(num8);
				if (this.CNJGKKDHPOG.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask)
				{
					num8 -= this.CNJGKKDHPOG.PHLKEBHKGEE.y;
				}
				float okqfcpdcibg2 = vector2.y - vector.y;
				float cdnfieohnhi2 = num8 * 513f;
				float num9 = vector.y;
				float num10 = vector2.y;
				float num11 = vector3.y - num8;
				float num12 = vector3.y + num8;
				num9 = num11 - num9;
				num10 -= num12;
				this.GCHMLEJKKJB(this.FIKFOFFJJCC, num9, num10, okqfcpdcibg2, cdnfieohnhi2, false);
			}
		}
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00081084 File Offset: 0x0007F284
	public void CQCJQPBIFMN(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.EBFOBLQELOJ != 1216f)
		{
			this.OQHIBGGLJOJ();
			this.FEDHNFFOQFB |= this.QHCFKBBJCOJ;
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 1207f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * 455f * Time.deltaTime;
		}
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00081104 File Offset: 0x0007F304
	protected void EGKLGCOGMPC(BJQGLGOLMPQ GDIKOCPENKG, float DOCFMGKDQNO, float DLIOMPONHNB, float OKQFCPDCIBG, float CDNFIEOHNHI, bool INIFQEKPMLD)
	{
		if (GDIKOCPENKG == null)
		{
			return;
		}
		this.DBEEEGIQHDM = true;
		float num;
		if (CDNFIEOHNHI < OKQFCPDCIBG)
		{
			DOCFMGKDQNO = Mathf.Clamp01(DOCFMGKDQNO / OKQFCPDCIBG);
			DLIOMPONHNB = Mathf.Clamp01(DLIOMPONHNB / OKQFCPDCIBG);
			num = DOCFMGKDQNO + DLIOMPONHNB;
			GDIKOCPENKG.PLLQOHPCBOP((!INIFQEKPMLD) ? ((num <= 157f) ? 1922f : (DOCFMGKDQNO / num)) : ((num <= 1888f) ? 683f : (360f - DOCFMGKDQNO / num)));
		}
		else
		{
			DOCFMGKDQNO = Mathf.Clamp01(-DOCFMGKDQNO / OKQFCPDCIBG);
			DLIOMPONHNB = Mathf.Clamp01(-DLIOMPONHNB / OKQFCPDCIBG);
			num = DOCFMGKDQNO + DLIOMPONHNB;
			GDIKOCPENKG.BGBMIEJJQKC = ((!INIFQEKPMLD) ? ((num <= 1886f) ? 635f : (DOCFMGKDQNO / num)) : ((num <= 760f) ? 1788f : (487f - DOCFMGKDQNO / num)));
			if (OKQFCPDCIBG > 966f)
			{
				DOCFMGKDQNO = Mathf.Clamp01(DOCFMGKDQNO / OKQFCPDCIBG);
				DLIOMPONHNB = Mathf.Clamp01(DLIOMPONHNB / OKQFCPDCIBG);
				num = DOCFMGKDQNO + DLIOMPONHNB;
			}
		}
		KDIEKDCQIHM kdiekdcqihm = GDIKOCPENKG as KDIEKDCQIHM;
		if (kdiekdcqihm != null)
		{
			kdiekdcqihm.DLPFNIEOHFE(1022f - num);
		}
		this.DBEEEGIQHDM = true;
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00081214 File Offset: 0x0007F414
	public virtual void QBQLNFNCKQK(float DGKOIGOLHDM, float DDLQKFDFMCJ, bool CPDLHLELBKJ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		this.OQHIBGGLJOJ();
		Bounds bounds = this.MCQHINECHCC();
		if (bounds.min.x != bounds.max.x)
		{
			if (bounds.min.y != bounds.max.y)
			{
				Vector4 vector = this.CNJGKKDHPOG.PGCIILBODCO();
				float num = vector.z * 808f;
				float num2 = vector.w * 1308f;
				float num3 = bounds.min.x + num;
				float num4 = bounds.max.x - num;
				float num5 = bounds.min.y + num2;
				float num6 = bounds.max.y - num2;
				if (this.CNJGKKDHPOG.POMCJNMICJP() == (KMCGDKDIJIE.PDFPPCIHPMI)2)
				{
					num3 -= this.CNJGKKDHPOG.KCMPFJPOOQH().x;
					num4 += this.CNJGKKDHPOG.PHLKEBHKGEE.x;
					num5 -= this.CNJGKKDHPOG.KCMPFJPOOQH().y;
					num6 += this.CNJGKKDHPOG.KCMPFJPOOQH().y;
				}
				float num7 = Mathf.Lerp(num3, num4, DGKOIGOLHDM);
				float num8 = Mathf.Lerp(num6, num5, DDLQKFDFMCJ);
				if (!CPDLHLELBKJ)
				{
					Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
					if (this.ENKKJECIIBP)
					{
						localPosition.x += vector.x - num7;
					}
					if (this.LPJIHCPNOEL())
					{
						localPosition.y += vector.y - num8;
					}
					this.BLLEFKOLKLP.localPosition = localPosition;
				}
				if (this.HHBGHDIJONK())
				{
					vector.x = num7;
				}
				if (this.IMPMONNQLND())
				{
					vector.y = num8;
				}
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				this.CNJGKKDHPOG.CJLMPGKEIHI(new Vector2(vector.x - giomppijpkn.x, vector.y - giomppijpkn.y));
				if (CPDLHLELBKJ)
				{
					this.FCGMFIPGCHH(this.QDLKDHJHOLD == -118);
				}
				return;
			}
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00009BEF File Offset: 0x00007DEF
	public bool NDBENHOKJGG
	{
		get
		{
			return this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical || this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Unrestricted || (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Custom && this.ILBJLHJECKN.y != 0f);
		}
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00009C33 File Offset: 0x00007E33
	public bool LPJIHCPNOEL()
	{
		return this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal || this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)6 || this.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical || this.ILBJLHJECKN.y != 1539f;
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00009C6B File Offset: 0x00007E6B
	public void GCHMLEJKKJB()
	{
		this.GCHMLEJKKJB(true);
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00009A17 File Offset: 0x00007C17
	public void KEQFFBKNFCB(Vector3 BGBMIEJJQKC)
	{
		this.CCHQQHIFDBO = BGBMIEJJQKC;
		this.FEDHNFFOQFB = true;
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00081468 File Offset: 0x0007F668
	public void EODHILDCPNH(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.EBFOBLQELOJ != 0f)
		{
			this.OPOIOQKGPPG();
			this.FEDHNFFOQFB |= this.QHCFKBBJCOJ;
			if (Mathf.Sign(this.HCLBPEMQFBO) != Mathf.Sign(JDOGIQGGLKM))
			{
				this.HCLBPEMQFBO = 0f;
			}
			this.HCLBPEMQFBO += JDOGIQGGLKM * 70f * Time.deltaTime;
		}
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x000814E8 File Offset: 0x0007F6E8
	private void LJBKGHHLMFB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		if (this.CNJGKKDHPOG.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.CNJGKKDHPOG.GEOIDOMHKLJ = (KMCGDKDIJIE.PDFPPCIHPMI)5;
		}
		if (this.IEBBDPLNLGO != (FKBFPICKJQG.DCCCBCPKIFL)7 && this.scale.sqrMagnitude > 1281f)
		{
			if (this.scale.x == 1770f && this.scale.y == 281f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Horizontal;
			}
			else if (this.scale.x == 692f && this.scale.y == 1089f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Horizontal;
			}
			else if (this.scale.x == 74f && this.scale.y == 1838f)
			{
				this.IEBBDPLNLGO = FKBFPICKJQG.DCCCBCPKIFL.Custom;
			}
			else
			{
				this.IEBBDPLNLGO = (FKBFPICKJQG.DCCCBCPKIFL)6;
				this.ILBJLHJECKN.x = this.scale.x;
				this.ILBJLHJECKN.y = this.scale.y;
			}
			this.scale = Vector3.zero;
		}
		if (this.JMMFBHNQPOP == ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && this.relativePositionOnReset != Vector2.zero)
		{
			this.JMMFBHNQPOP = JNNGOIIKENH.PMLDKODQFPI(new Vector2(this.relativePositionOnReset.x, 528f - this.relativePositionOnReset.y));
			this.relativePositionOnReset = Vector2.zero;
		}
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00081660 File Offset: 0x0007F860
	public void OHPHCINGFGI()
	{
		if (this.EIQLEKDFMMC)
		{
			if (EMENMKHBPQE.GMDQCMCJEQI != EMENMKHBPQE.EGIKELMMQOO.Mouse)
			{
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.FEDHNFFOQFB)
				{
					if (this.QDLKDHJHOLD == -34)
					{
						this.QDLKDHJHOLD = EMENMKHBPQE.JQCODFPLPNJ;
					}
					EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)7;
					if (this.JLLKLQGCLMM && !this.DEDCMDKLLCE)
					{
						this.DEDCMDKLLCE = false;
						this.OJIKQOOEHOE = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
						if (this.NMIFFFLJKJM != null)
						{
							this.NMIFFFLJKJM();
						}
					}
					Ray ray = (!this.JLLKLQGCLMM) ? EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM) : EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM - this.OJIKQOOEHOE);
					float distance = 950f;
					if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
					{
						Vector3 point = ray.GetPoint(distance);
						Vector3 vector = point - this.HEMHOMBDIJC;
						this.HEMHOMBDIJC = point;
						if (vector.x != 1492f || vector.y != 468f || vector.z != 619f)
						{
							vector = this.BLLEFKOLKLP.InverseTransformDirection(vector);
							if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
							{
								vector.y = 513f;
								vector.z = 392f;
							}
							else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Vertical)
							{
								vector.x = 1527f;
								vector.z = 81f;
							}
							else if (this.IEBBDPLNLGO == (FKBFPICKJQG.DCCCBCPKIFL)4)
							{
								vector.z = 1091f;
							}
							else
							{
								vector.Scale(this.ILBJLHJECKN);
							}
							vector = this.BLLEFKOLKLP.TransformDirection(vector);
						}
						if (this.NNFKGOHBEHF == FKBFPICKJQG.CJKCHNDFONH.None)
						{
							this.CCHQQHIFDBO = Vector3.zero;
						}
						else
						{
							this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (678f * this.ILKGGGEDGOE), 970f);
						}
						if (this.FGOFGJGJKIO)
						{
							if (this.NNFKGOHBEHF == (FKBFPICKJQG.CJKCHNDFONH)6)
							{
								Vector3 vector2 = this.CNJGKKDHPOG.GKCICPLNPJJ(this.FBMFGHBCEIK().min, this.EHIPPQHEICC().max);
								if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
								{
									vector2.y = 499f;
								}
								else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
								{
									vector2.x = 1944f;
								}
								else if (this.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Custom)
								{
									vector2.x *= this.ILBJLHJECKN.x;
									vector2.y *= this.ILBJLHJECKN.y;
								}
								if (vector2.magnitude > 585f)
								{
									this.HMPGGOKMHOQ(vector * 938f);
									this.CCHQQHIFDBO *= 274f;
									goto IL_310;
								}
								this.GKILDFMEPJH(vector);
								goto IL_310;
							}
						}
						this.OJFLDJGJOEI(vector);
						IL_310:
						if (this.NMIMPJNDHHI && this.OGQEPEGLEPO && this.CNJGKKDHPOG.POMCJNMICJP() != KMCGDKDIJIE.PDFPPCIHPMI.None && this.NNFKGOHBEHF != (FKBFPICKJQG.CJKCHNDFONH)8)
						{
							this.PONBMJGIGEO(true, this.PMQGGKCQBOE(), this.LPJIHCPNOEL());
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x000819B8 File Offset: 0x0007FBB8
	public void NNOBJHDLDPB()
	{
		if (!this.DBEEEGIQHDM)
		{
			this.DBEEEGIQHDM = true;
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? 809f : this.PFKFNKBEFBB.BGBMIEJJQKC;
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? 370f : this.FIKFOFFJJCC.HKDJGHOHBFQ();
			this.QBQLNFNCKQK(dgkoigolhdm, ddlqkfdfmcj, false);
			this.DBEEEGIQHDM = true;
		}
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00009A27 File Offset: 0x00007C27
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		if (Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00081A28 File Offset: 0x0007FC28
	public virtual void PHMNDNMBHOO(float DGKOIGOLHDM, float DDLQKFDFMCJ, bool CPDLHLELBKJ)
	{
		if (this.CNJGKKDHPOG == null)
		{
			this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		}
		this.OPOIOQKGPPG();
		Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
		if (gbmnpqiemqi.min.x != gbmnpqiemqi.max.x)
		{
			if (gbmnpqiemqi.min.y != gbmnpqiemqi.max.y)
			{
				Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
				float num = qenjmehbneg.z * 399f;
				float num2 = qenjmehbneg.w * 816f;
				float num3 = gbmnpqiemqi.min.x + num;
				float num4 = gbmnpqiemqi.max.x - num;
				float num5 = gbmnpqiemqi.min.y + num2;
				float num6 = gbmnpqiemqi.max.y - num2;
				if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask)
				{
					num3 -= this.CNJGKKDHPOG.PHLKEBHKGEE.x;
					num4 += this.CNJGKKDHPOG.PHLKEBHKGEE.x;
					num5 -= this.CNJGKKDHPOG.KCMPFJPOOQH().y;
					num6 += this.CNJGKKDHPOG.KCMPFJPOOQH().y;
				}
				float num7 = Mathf.Lerp(num3, num4, DGKOIGOLHDM);
				float num8 = Mathf.Lerp(num6, num5, DDLQKFDFMCJ);
				if (!CPDLHLELBKJ)
				{
					Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
					if (this.PMQGGKCQBOE())
					{
						localPosition.x += qenjmehbneg.x - num7;
					}
					if (this.NDBENHOKJGG)
					{
						localPosition.y += qenjmehbneg.y - num8;
					}
					this.BLLEFKOLKLP.localPosition = localPosition;
				}
				if (this.HHBGHDIJONK())
				{
					qenjmehbneg.x = num7;
				}
				if (this.NDBENHOKJGG)
				{
					qenjmehbneg.y = num8;
				}
				Vector4 vector = this.CNJGKKDHPOG.LGMLEMDQJHB();
				this.CNJGKKDHPOG.CJLMPGKEIHI(new Vector2(qenjmehbneg.x - vector.x, qenjmehbneg.y - vector.y));
				if (CPDLHLELBKJ)
				{
					this.GCHMLEJKKJB(this.QDLKDHJHOLD == -108);
				}
				return;
			}
		}
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00081C7C File Offset: 0x0007FE7C
	public virtual bool LBLMBPMIKHM()
	{
		float num = this.EHIPPQHEICC().size.x;
		if (this.CNJGKKDHPOG.GEOIDOMHKLJ == (KMCGDKDIJIE.PDFPPCIHPMI)8)
		{
			num += this.CNJGKKDHPOG.KCMPFJPOOQH().x * 251f;
		}
		return Mathf.RoundToInt(num - this.CNJGKKDHPOG.KJGMGPCEJJD) > 0;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00081CE0 File Offset: 0x0007FEE0
	public void ENJEMNHELPK()
	{
		if (!this.DBEEEGIQHDM)
		{
			this.DBEEEGIQHDM = true;
			float dgkoigolhdm = (!(this.PFKFNKBEFBB != null)) ? 0f : this.PFKFNKBEFBB.BGBMIEJJQKC;
			float ddlqkfdfmcj = (!(this.FIKFOFFJJCC != null)) ? 0f : this.FIKFOFFJJCC.BGBMIEJJQKC;
			this.QNEOFDPIQBM(dgkoigolhdm, ddlqkfdfmcj, false);
			this.DBEEEGIQHDM = false;
		}
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00009BCD File Offset: 0x00007DCD
	private void OnEnable()
	{
		FKBFPICKJQG.NGDBDCQFDHI.LHQECHHMOGD(this);
		if (this.PNBOOLEOKCI && Application.isPlaying)
		{
			this.DCPCKCIGHQO();
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06001105 RID: 4357 RVA: 0x00081D50 File Offset: 0x0007FF50
	protected virtual bool QHCFKBBJCOJ
	{
		get
		{
			if (!this.LENDHIBCJOF)
			{
				return true;
			}
			if (this.CNJGKKDHPOG == null)
			{
				this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
			}
			Vector4 qenjmehbneg = this.CNJGKKDHPOG.QENJMEHBNEG;
			Bounds gbmnpqiemqi = this.GBMNPQIEMQI;
			float num = (qenjmehbneg.z != 0f) ? (qenjmehbneg.z * 0.5f) : ((float)Screen.width);
			float num2 = (qenjmehbneg.w != 0f) ? (qenjmehbneg.w * 0.5f) : ((float)Screen.height);
			if (this.ENKKJECIIBP)
			{
				if (gbmnpqiemqi.min.x < qenjmehbneg.x - num)
				{
					return true;
				}
				if (gbmnpqiemqi.max.x > qenjmehbneg.x + num)
				{
					return true;
				}
			}
			if (this.NDBENHOKJGG)
			{
				if (gbmnpqiemqi.min.y < qenjmehbneg.y - num2)
				{
					return true;
				}
				if (gbmnpqiemqi.max.y > qenjmehbneg.y + num2)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06001106 RID: 4358 RVA: 0x00081E64 File Offset: 0x00080064
	public virtual bool DFNJDOKQBPP
	{
		get
		{
			float num = this.GBMNPQIEMQI.size.y;
			if (this.CNJGKKDHPOG.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
			{
				num += this.CNJGKKDHPOG.PHLKEBHKGEE.y * 2f;
			}
			return Mathf.RoundToInt(num - this.CNJGKKDHPOG.DFKQMMIQDOO) > 0;
		}
	}

	// Token: 0x040002E5 RID: 741
	public static MHIDKMCBQEN<FKBFPICKJQG> NGDBDCQFDHI = new MHIDKMCBQEN<FKBFPICKJQG>();

	// Token: 0x040002E6 RID: 742
	public FKBFPICKJQG.DCCCBCPKIFL IEBBDPLNLGO;

	// Token: 0x040002E7 RID: 743
	public FKBFPICKJQG.CJKCHNDFONH NNFKGOHBEHF = FKBFPICKJQG.CJKCHNDFONH.MomentumAndSpring;

	// Token: 0x040002E8 RID: 744
	public bool OGQEPEGLEPO = true;

	// Token: 0x040002E9 RID: 745
	[Tooltip("Whether the scroll view will execute its constrain within bounds logic on every drag operation")]
	public bool NMIMPJNDHHI;

	// Token: 0x040002EA RID: 746
	public bool LENDHIBCJOF;

	// Token: 0x040002EB RID: 747
	public bool JLLKLQGCLMM = true;

	// Token: 0x040002EC RID: 748
	public bool FGOFGJGJKIO = true;

	// Token: 0x040002ED RID: 749
	public float EBFOBLQELOJ = 0.25f;

	// Token: 0x040002EE RID: 750
	public float ILKGGGEDGOE = 35f;

	// Token: 0x040002EF RID: 751
	public float HDCLIQFNBCH = 9f;

	// Token: 0x040002F0 RID: 752
	public BJQGLGOLMPQ PFKFNKBEFBB;

	// Token: 0x040002F1 RID: 753
	public BJQGLGOLMPQ FIKFOFFJJCC;

	// Token: 0x040002F2 RID: 754
	public FKBFPICKJQG.FOLMFDKNHJF JECMOFDKQQN = FKBFPICKJQG.FOLMFDKNHJF.OnlyIfNeeded;

	// Token: 0x040002F3 RID: 755
	public Vector2 ILBJLHJECKN = new Vector2(1f, 0f);

	// Token: 0x040002F4 RID: 756
	public ENFMCDNLEQQ.GGBIQFIQQCM JMMFBHNQPOP;

	// Token: 0x040002F5 RID: 757
	public FKBFPICKJQG.DOLKOCPEIJE NMIFFFLJKJM;

	// Token: 0x040002F6 RID: 758
	public FKBFPICKJQG.DOLKOCPEIJE QEEHHLPOHGI;

	// Token: 0x040002F7 RID: 759
	public FKBFPICKJQG.DOLKOCPEIJE CPKQFOEQIGI;

	// Token: 0x040002F8 RID: 760
	public FKBFPICKJQG.DOLKOCPEIJE QDODFMLDGKG;

	// Token: 0x040002F9 RID: 761
	[HideInInspector]
	[SerializeField]
	private Vector3 scale = new Vector3(1f, 0f, 0f);

	// Token: 0x040002FA RID: 762
	[SerializeField]
	[HideInInspector]
	private Vector2 relativePositionOnReset = Vector2.zero;

	// Token: 0x040002FB RID: 763
	protected Transform BLLEFKOLKLP;

	// Token: 0x040002FC RID: 764
	protected KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x040002FD RID: 765
	protected Plane LHEPDNHCQIQ;

	// Token: 0x040002FE RID: 766
	protected Vector3 HEMHOMBDIJC;

	// Token: 0x040002FF RID: 767
	protected bool EIQLEKDFMMC;

	// Token: 0x04000300 RID: 768
	protected Vector3 CCHQQHIFDBO = Vector3.zero;

	// Token: 0x04000301 RID: 769
	protected float HCLBPEMQFBO;

	// Token: 0x04000302 RID: 770
	protected Bounds FKKNDHFECQL;

	// Token: 0x04000303 RID: 771
	protected bool DFJOQLIBGBK;

	// Token: 0x04000304 RID: 772
	protected bool FEDHNFFOQFB;

	// Token: 0x04000305 RID: 773
	protected bool DBEEEGIQHDM;

	// Token: 0x04000306 RID: 774
	protected int QDLKDHJHOLD = -10;

	// Token: 0x04000307 RID: 775
	protected Vector2 OJIKQOOEHOE = Vector2.zero;

	// Token: 0x04000308 RID: 776
	protected bool DEDCMDKLLCE;

	// Token: 0x04000309 RID: 777
	[NonSerialized]
	private bool PNBOOLEOKCI;

	// Token: 0x0400030A RID: 778
	[HideInInspector]
	public ONDGHPBHGGG PNBJIMGEOKE;

	// Token: 0x0200007C RID: 124
	public enum DCCCBCPKIFL
	{
		// Token: 0x0400030C RID: 780
		Horizontal,
		// Token: 0x0400030D RID: 781
		Vertical,
		// Token: 0x0400030E RID: 782
		Unrestricted,
		// Token: 0x0400030F RID: 783
		Custom
	}

	// Token: 0x0200007D RID: 125
	public enum CJKCHNDFONH
	{
		// Token: 0x04000311 RID: 785
		None,
		// Token: 0x04000312 RID: 786
		Momentum,
		// Token: 0x04000313 RID: 787
		MomentumAndSpring
	}

	// Token: 0x0200007E RID: 126
	public enum FOLMFDKNHJF
	{
		// Token: 0x04000315 RID: 789
		Always,
		// Token: 0x04000316 RID: 790
		OnlyIfNeeded,
		// Token: 0x04000317 RID: 791
		WhenDragging
	}

	// Token: 0x0200007F RID: 127
	// (Invoke) Token: 0x06001108 RID: 4360
	public delegate void DOLKOCPEIJE();
}
