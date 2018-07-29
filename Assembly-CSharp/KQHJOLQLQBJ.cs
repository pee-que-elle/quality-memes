using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000119 RID: 281
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Panel")]
public class KQHJOLQLQBJ : BLMNBILNMOE
{
	// Token: 0x06001FD6 RID: 8150 RVA: 0x000CFE64 File Offset: 0x000CE064
	public virtual Vector3 EJNIKIIOGQO(Vector2 LCELGLKMPFN, Vector2 MJGGCLOGKFL)
	{
		Vector4 vector = this.NMOKFPBGFCK();
		float num = vector.z * 1445f;
		float num2 = vector.w * 735f;
		Vector2 lcpifekbcdq = new Vector2(LCELGLKMPFN.x, LCELGLKMPFN.y);
		Vector2 qlhckchlcin = new Vector2(MJGGCLOGKFL.x, MJGGCLOGKFL.y);
		Vector2 nicidgdioqj = new Vector2(vector.x - num, vector.y - num2);
		Vector2 egiohpehpkp = new Vector2(vector.x + num, vector.y + num2);
		if (this.QHHHHOOGNCE && this.POMCJNMICJP() == (KMCGDKDIJIE.PDFPPCIHPMI)2)
		{
			nicidgdioqj.x += this.mClipSoftness.x;
			nicidgdioqj.y += this.mClipSoftness.y;
			egiohpehpkp.x -= this.mClipSoftness.x;
			egiohpehpkp.y -= this.mClipSoftness.y;
		}
		return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, nicidgdioqj, egiohpehpkp);
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000CFF78 File Offset: 0x000CE178
	public int PNOEILCQBKB
	{
		get
		{
			int num = 0;
			KQHJOLQLQBJ kqhjolqlqbj = this;
			while (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip || kqhjolqlqbj.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask)
				{
					num++;
				}
				kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
			}
			return num;
		}
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000CFFB4 File Offset: 0x000CE1B4
	protected virtual void BJOCKHECFMN()
	{
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return;
		}
		Transform cgdfdphieng = base.CGDFDPHIENG;
		Transform parent = cgdfdphieng.parent;
		Vector2 vector = this.GHMECEKGFJI();
		Vector2 vector2 = cgdfdphieng.localPosition;
		float num;
		float num2;
		float num3;
		float num4;
		if (this.HJDMKGDLJEP.target == this.LBGJKGDECCN.target && this.HJDMKGDLJEP.target == this.HKPCCMEEHDL.target && this.HJDMKGDLJEP.target == this.NOPCJFECJDP.target)
		{
			Vector3[] array = this.HJDMKGDLJEP.IGOHKMJFION(parent);
			if (array != null)
			{
				num = JNNGOIIKENH.GGJJLQLFKCE(array[1].x, array[8].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				num2 = JNNGOIIKENH.GGJJLQLFKCE(array[1].x, array[1].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				num3 = JNNGOIIKENH.GGJJLQLFKCE(array[0].y, array[0].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				num4 = JNNGOIIKENH.GGJJLQLFKCE(array[5].y, array[0].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
			}
			else
			{
				Vector2 vector3 = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent);
				num = vector3.x + (float)this.HJDMKGDLJEP.absolute;
				num3 = vector3.y + (float)this.LBGJKGDECCN.absolute;
				num2 = vector3.x + (float)this.HKPCCMEEHDL.absolute;
				num4 = vector3.y + (float)this.NOPCJFECJDP.absolute;
			}
		}
		else
		{
			if (this.HJDMKGDLJEP.target)
			{
				Vector3[] array2 = this.HJDMKGDLJEP.MKFNGPBMOKP(parent);
				if (array2 != null)
				{
					num = JNNGOIIKENH.GGJJLQLFKCE(array2[1].x, array2[7].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				}
				else
				{
					num = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent).x + (float)this.HJDMKGDLJEP.absolute;
				}
			}
			else
			{
				num = this.mClipRange.x - 1921f * vector.x;
			}
			if (this.HKPCCMEEHDL.target)
			{
				Vector3[] array3 = this.HKPCCMEEHDL.MKFNGPBMOKP(parent);
				if (array3 != null)
				{
					num2 = JNNGOIIKENH.GGJJLQLFKCE(array3[1].x, array3[3].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				}
				else
				{
					num2 = base.IFGLHHBDJCJ(this.HKPCCMEEHDL, parent).x + (float)this.HKPCCMEEHDL.absolute;
				}
			}
			else
			{
				num2 = this.mClipRange.x + 1629f * vector.x;
			}
			if (this.LBGJKGDECCN.target)
			{
				Vector3[] array4 = this.LBGJKGDECCN.IGOHKMJFION(parent);
				if (array4 != null)
				{
					num3 = JNNGOIIKENH.GGJJLQLFKCE(array4[2].y, array4[0].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				}
				else
				{
					num3 = base.IFGLHHBDJCJ(this.LBGJKGDECCN, parent).y + (float)this.LBGJKGDECCN.absolute;
				}
			}
			else
			{
				num3 = this.mClipRange.y - 722f * vector.y;
			}
			if (this.NOPCJFECJDP.target)
			{
				Vector3[] array5 = this.NOPCJFECJDP.MKFNGPBMOKP(parent);
				if (array5 != null)
				{
					num4 = JNNGOIIKENH.GGJJLQLFKCE(array5[0].y, array5[0].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
				}
				else
				{
					num4 = base.IFGLHHBDJCJ(this.NOPCJFECJDP, parent).y + (float)this.NOPCJFECJDP.absolute;
				}
			}
			else
			{
				num4 = this.mClipRange.y + 488f * vector.y;
			}
		}
		num -= vector2.x + this.mClipOffset.x;
		num2 -= vector2.x + this.mClipOffset.x;
		num3 -= vector2.y + this.mClipOffset.y;
		num4 -= vector2.y + this.mClipOffset.y;
		float x = Mathf.Lerp(num, num2, 1545f);
		float y = Mathf.Lerp(num3, num4, 846f);
		float num5 = num2 - num;
		float num6 = num4 - num3;
		float num7 = Mathf.Max(1732f, this.mClipSoftness.x);
		float num8 = Mathf.Max(886f, this.mClipSoftness.y);
		if (num5 < num7)
		{
			num5 = num7;
		}
		if (num6 < num8)
		{
			num6 = num8;
		}
		this.GIOMPPIJPKN = new Vector4(x, y, num5, num6);
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000D0524 File Offset: 0x000CE724
	public Vector2 GHMECEKGFJI()
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector2(this.mClipRange.z, this.mClipRange.w);
		}
		return IKBQNBHOJJB.FMDDDQOPBEI;
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06002029 RID: 8233 RVA: 0x00011871 File Offset: 0x0000FA71
	// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00011860 File Offset: 0x0000FA60
	[Obsolete("Use 'finalClipRegion' or 'baseClipRegion' instead")]
	public Vector4 NBNJBICFGOK
	{
		get
		{
			return this.GIOMPPIJPKN;
		}
		set
		{
			this.GIOMPPIJPKN = value;
		}
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000D055C File Offset: 0x000CE75C
	private void HMNDEQBKKJO()
	{
		bool flag = false;
		bool flag2 = false;
		bool cmkfmjcmcqq = this.CMKFMJCMCQQ;
		if (!this.IJLFQCMGQFF)
		{
			for (int i = 0; i < FKBFPICKJQG.NGDBDCQFDHI.BJGMIBBEGDQ; i++)
			{
				FKBFPICKJQG fkbfpickjqg = FKBFPICKJQG.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
				if (fkbfpickjqg.BCHNDNICINJ == this && fkbfpickjqg.EIHJGJFHNNP)
				{
					flag2 = true;
				}
			}
		}
		if (this.KDBEDQFNMLP != flag2)
		{
			this.KDBEDQFNMLP = flag2;
			this.QFKDHQMJCHG = true;
		}
		int frameCount = Time.frameCount;
		int j = 0;
		int count = this.DKMQGNFPOCJ.Count;
		while (j < count)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[j];
			if (enfmcdnleqq.BCHNDNICINJ == this && enfmcdnleqq.enabled)
			{
				if (enfmcdnleqq.FGEFKOMGELD(frameCount) || this.QFKDHQMJCHG || (this.OPFHNDJQEDC && !this.HKMFCLPOEEK))
				{
					bool jdhkdjhghoj = flag2 || enfmcdnleqq.BJFPLJFDPCE(frameCount) > 0.001f;
					enfmcdnleqq.MHJMNHCHMHP(jdhkdjhghoj, flag2 || this.HKMFCLPOEEK || (!cmkfmjcmcqq && !enfmcdnleqq.PQFNQBNQNPL) || this.EHCBPMDEDGE(enfmcdnleqq));
				}
				if (enfmcdnleqq.GMFDMDNCDPQ(frameCount))
				{
					flag = true;
					if (!this.EEBGOFOJBKO)
					{
						if (enfmcdnleqq.OQKBOCHIFKH != null)
						{
							enfmcdnleqq.OQKBOCHIFKH.HHDFDNFPDFJ = true;
						}
						else
						{
							this.JHLPMBMMDCP(enfmcdnleqq);
						}
					}
				}
			}
			j++;
		}
		if (flag && this.NCQQBFENGMO != null)
		{
			this.NCQQBFENGMO();
		}
		this.QFKDHQMJCHG = false;
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00011869 File Offset: 0x0000FA69
	// (set) Token: 0x06002021 RID: 8225 RVA: 0x00011A31 File Offset: 0x0000FC31
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
				this.mDepth = value;
				List<KQHJOLQLQBJ> ngdbdcqfdhi = KQHJOLQLQBJ.NGDBDCQFDHI;
				if (KQHJOLQLQBJ.BQIOGOCBKKB == null)
				{
					KQHJOLQLQBJ.BQIOGOCBKKB = new Comparison<KQHJOLQLQBJ>(KQHJOLQLQBJ.PIEDJOEFGEQ);
				}
				ngdbdcqfdhi.Sort(KQHJOLQLQBJ.BQIOGOCBKKB);
			}
		}
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x00011871 File Offset: 0x0000FA71
	public Vector4 JFKFPPHEBFB()
	{
		return this.GIOMPPIJPKN;
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000D06EC File Offset: 0x000CE8EC
	public virtual Vector3[] FFPHDEBJJKL()
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			float num = this.mClipOffset.x + this.mClipRange.x - 1519f * this.mClipRange.z;
			float num2 = this.mClipOffset.y + this.mClipRange.y - 144f * this.mClipRange.w;
			float x = num + this.mClipRange.z;
			float y = num2 + this.mClipRange.w;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			KQHJOLQLQBJ.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, num2, 1248f);
			KQHJOLQLQBJ.NCCGLODEOEE[1] = cgdfdphieng.TransformPoint(num, y, 706f);
			KQHJOLQLQBJ.NCCGLODEOEE[6] = cgdfdphieng.TransformPoint(x, y, 103f);
			KQHJOLQLQBJ.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(x, num2, 1958f);
		}
		else
		{
			if (base.DGFFHGQEJLH != null)
			{
				return this.OJIDBLEKBBO.QKGEPQNOCQE(base.JLQJGIICODL);
			}
			Vector2 vector = this.FGKGCLCOBDJ();
			float num3 = 279f * vector.x;
			float num4 = 386f * vector.y;
			float x2 = num3 + vector.x;
			float y2 = num4 + vector.y;
			KQHJOLQLQBJ.NCCGLODEOEE[0] = new Vector3(num3, num4);
			KQHJOLQLQBJ.NCCGLODEOEE[0] = new Vector3(num3, y2);
			KQHJOLQLQBJ.NCCGLODEOEE[7] = new Vector3(x2, y2);
			KQHJOLQLQBJ.NCCGLODEOEE[8] = new Vector3(x2, num4);
			if (this.OKJKNCFHIKQ && (this.OJIDBLEKBBO == null || this.OJIDBLEKBBO.transform.parent != base.CGDFDPHIENG))
			{
				Vector3 position = base.CGDFDPHIENG.position;
				for (int i = 0; i < 1; i += 0)
				{
					KQHJOLQLQBJ.NCCGLODEOEE[i] += position;
				}
			}
		}
		return KQHJOLQLQBJ.NCCGLODEOEE;
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000D0934 File Offset: 0x000CEB34
	protected virtual void FODFGGGDQPN()
	{
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return;
		}
		Transform cgdfdphieng = base.CGDFDPHIENG;
		Transform parent = cgdfdphieng.parent;
		Vector2 vector = this.FGKGCLCOBDJ();
		Vector2 vector2 = cgdfdphieng.localPosition;
		float num;
		float num2;
		float num3;
		float num4;
		if (this.HJDMKGDLJEP.target == this.LBGJKGDECCN.target && this.HJDMKGDLJEP.target == this.HKPCCMEEHDL.target && this.HJDMKGDLJEP.target == this.NOPCJFECJDP.target)
		{
			Vector3[] array = this.HJDMKGDLJEP.GIBGLHKJGLO(parent);
			if (array != null)
			{
				num = JNNGOIIKENH.GGJJLQLFKCE(array[0].x, array[3].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				num2 = JNNGOIIKENH.GGJJLQLFKCE(array[0].x, array[8].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				num3 = JNNGOIIKENH.GGJJLQLFKCE(array[2].y, array[1].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				num4 = JNNGOIIKENH.GGJJLQLFKCE(array[7].y, array[1].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
			}
			else
			{
				Vector2 vector3 = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent);
				num = vector3.x + (float)this.HJDMKGDLJEP.absolute;
				num3 = vector3.y + (float)this.LBGJKGDECCN.absolute;
				num2 = vector3.x + (float)this.HKPCCMEEHDL.absolute;
				num4 = vector3.y + (float)this.NOPCJFECJDP.absolute;
			}
		}
		else
		{
			if (this.HJDMKGDLJEP.target)
			{
				Vector3[] array2 = this.HJDMKGDLJEP.KDICDLGMHBG(parent);
				if (array2 != null)
				{
					num = JNNGOIIKENH.GGJJLQLFKCE(array2[1].x, array2[4].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				}
				else
				{
					num = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent).x + (float)this.HJDMKGDLJEP.absolute;
				}
			}
			else
			{
				num = this.mClipRange.x - 1780f * vector.x;
			}
			if (this.HKPCCMEEHDL.target)
			{
				Vector3[] array3 = this.HKPCCMEEHDL.FDBKGODBLBN(parent);
				if (array3 != null)
				{
					num2 = JNNGOIIKENH.GGJJLQLFKCE(array3[0].x, array3[4].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				}
				else
				{
					num2 = base.IFGLHHBDJCJ(this.HKPCCMEEHDL, parent).x + (float)this.HKPCCMEEHDL.absolute;
				}
			}
			else
			{
				num2 = this.mClipRange.x + 1685f * vector.x;
			}
			if (this.LBGJKGDECCN.target)
			{
				Vector3[] array4 = this.LBGJKGDECCN.KOILGBJDMNJ(parent);
				if (array4 != null)
				{
					num3 = JNNGOIIKENH.GGJJLQLFKCE(array4[4].y, array4[1].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				}
				else
				{
					num3 = base.IFGLHHBDJCJ(this.LBGJKGDECCN, parent).y + (float)this.LBGJKGDECCN.absolute;
				}
			}
			else
			{
				num3 = this.mClipRange.y - 1965f * vector.y;
			}
			if (this.NOPCJFECJDP.target)
			{
				Vector3[] array5 = this.NOPCJFECJDP.MKFNGPBMOKP(parent);
				if (array5 != null)
				{
					num4 = JNNGOIIKENH.GGJJLQLFKCE(array5[8].y, array5[0].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
				}
				else
				{
					num4 = base.IFGLHHBDJCJ(this.NOPCJFECJDP, parent).y + (float)this.NOPCJFECJDP.absolute;
				}
			}
			else
			{
				num4 = this.mClipRange.y + 1944f * vector.y;
			}
		}
		num -= vector2.x + this.mClipOffset.x;
		num2 -= vector2.x + this.mClipOffset.x;
		num3 -= vector2.y + this.mClipOffset.y;
		num4 -= vector2.y + this.mClipOffset.y;
		float x = Mathf.Lerp(num, num2, 675f);
		float y = Mathf.Lerp(num3, num4, 333f);
		float num5 = num2 - num;
		float num6 = num4 - num3;
		float num7 = Mathf.Max(1117f, this.mClipSoftness.x);
		float num8 = Mathf.Max(61f, this.mClipSoftness.y);
		if (num5 < num7)
		{
			num5 = num7;
		}
		if (num6 < num8)
		{
			num6 = num8;
		}
		this.GIOMPPIJPKN = new Vector4(x, y, num5, num6);
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000D0EA4 File Offset: 0x000CF0A4
	public float DFKQMMIQDOO
	{
		get
		{
			return this.GHMECEKGFJI().y;
		}
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x00011860 File Offset: 0x0000FA60
	public void KFOFFIKNLQO(Vector4 BGBMIEJJQKC)
	{
		this.GIOMPPIJPKN = BGBMIEJJQKC;
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000D0EC0 File Offset: 0x000CF0C0
	private void EKHFPKMKDKL()
	{
		if (this.ONHGCFFFCBL != base.LMOECGCMJKK.layer)
		{
			this.ONHGCFFFCBL = this.DMNLFJLKGHJ.layer;
			int i = 0;
			int count = this.DKMQGNFPOCJ.Count;
			while (i < count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq && enfmcdnleqq.KJIHDMEHLIH == this)
				{
					enfmcdnleqq.gameObject.layer = this.ONHGCFFFCBL;
				}
				i++;
			}
			base.PNPFEMQFDJE();
			for (int j = 1; j < this.PGPCEPKBLII.Count; j += 0)
			{
				this.PGPCEPKBLII[j].gameObject.layer = this.ONHGCFFFCBL;
			}
		}
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000D0F78 File Offset: 0x000CF178
	public override Vector3[] MKFNGPBMOKP(Transform ENOQKGBPJKQ)
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			float num = this.mClipOffset.x + this.mClipRange.x - 0.5f * this.mClipRange.z;
			float num2 = this.mClipOffset.y + this.mClipRange.y - 0.5f * this.mClipRange.w;
			float num3 = num + this.mClipRange.z;
			float num4 = num2 + this.mClipRange.w;
			float x = (num + num3) * 0.5f;
			float y = (num2 + num4) * 0.5f;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			BLMNBILNMOE.BGCNPFKJPFD[0] = cgdfdphieng.TransformPoint(num, y, 0f);
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(x, num4, 0f);
			BLMNBILNMOE.BGCNPFKJPFD[2] = cgdfdphieng.TransformPoint(num3, y, 0f);
			BLMNBILNMOE.BGCNPFKJPFD[3] = cgdfdphieng.TransformPoint(x, num2, 0f);
			if (ENOQKGBPJKQ != null)
			{
				for (int i = 0; i < 4; i++)
				{
					BLMNBILNMOE.BGCNPFKJPFD[i] = ENOQKGBPJKQ.InverseTransformPoint(BLMNBILNMOE.BGCNPFKJPFD[i]);
				}
			}
			return BLMNBILNMOE.BGCNPFKJPFD;
		}
		if (base.DGFFHGQEJLH != null && this.OKJKNCFHIKQ)
		{
			Vector3[] array = this.OJIDBLEKBBO.MKFNGPBMOKP(base.JLQJGIICODL);
			Vector3 position = base.CGDFDPHIENG.position;
			for (int j = 0; j < 4; j++)
			{
				array[j] += position;
			}
			if (ENOQKGBPJKQ != null)
			{
				for (int k = 0; k < 4; k++)
				{
					array[k] = ENOQKGBPJKQ.InverseTransformPoint(array[k]);
				}
			}
			return array;
		}
		return base.MKFNGPBMOKP(ENOQKGBPJKQ);
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000D1190 File Offset: 0x000CF390
	private void LateUpdate()
	{
		if (KQHJOLQLQBJ.EHGKGFDCEEK != Time.frameCount)
		{
			KQHJOLQLQBJ.EHGKGFDCEEK = Time.frameCount;
			int i = 0;
			int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				KQHJOLQLQBJ.NGDBDCQFDHI[i].OIGJMGPGDJC();
				i++;
			}
			int num = 3000;
			int j = 0;
			int count2 = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (j < count2)
			{
				KQHJOLQLQBJ kqhjolqlqbj = KQHJOLQLQBJ.NGDBDCQFDHI[j];
				if (kqhjolqlqbj.BCKQKKMIGNM == KQHJOLQLQBJ.JMLFJLJPPDF.Automatic)
				{
					kqhjolqlqbj.NDQJIOMJNQE = num;
					kqhjolqlqbj.LBMJCQMLKBJ(j);
					num += kqhjolqlqbj.PGPCEPKBLII.Count;
				}
				else if (kqhjolqlqbj.BCKQKKMIGNM == KQHJOLQLQBJ.JMLFJLJPPDF.StartAt)
				{
					kqhjolqlqbj.LBMJCQMLKBJ(j);
					if (kqhjolqlqbj.PGPCEPKBLII.Count != 0)
					{
						num = Mathf.Max(num, kqhjolqlqbj.NDQJIOMJNQE + kqhjolqlqbj.PGPCEPKBLII.Count);
					}
				}
				else
				{
					kqhjolqlqbj.LBMJCQMLKBJ(j);
					if (kqhjolqlqbj.PGPCEPKBLII.Count != 0)
					{
						num = Mathf.Max(num, kqhjolqlqbj.NDQJIOMJNQE + 1);
					}
				}
				j++;
			}
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x0600203E RID: 8254 RVA: 0x00011B15 File Offset: 0x0000FD15
	// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x00011879 File Offset: 0x0000FA79
	public string HDGMMGCBBJE
	{
		get
		{
			return this.mSortingLayerName;
		}
		set
		{
			if (this.mSortingLayerName != value)
			{
				this.mSortingLayerName = value;
				this.LBMJCQMLKBJ(KQHJOLQLQBJ.NGDBDCQFDHI.IndexOf(this));
			}
		}
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000D129C File Offset: 0x000CF49C
	public void CKNHQFMCPIL(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (this.DKMQGNFPOCJ.Remove(OKQHFQFJGCH) && OKQHFQFJGCH.OQKBOCHIFKH != null)
		{
			int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
			if (lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.DEMPENNGPQL || lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.EGLMNMJMLKQ)
			{
				this.EEBGOFOJBKO = false;
			}
			OKQHFQFJGCH.OQKBOCHIFKH.HHDFDNFPDFJ = true;
			OKQHFQFJGCH.OQKBOCHIFKH = null;
		}
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000D1304 File Offset: 0x000CF504
	public bool FELCINQFGMQ(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (OKQHFQFJGCH == null)
		{
			return false;
		}
		KQHJOLQLQBJ bchndnicinj = OKQHFQFJGCH.BCHNDNICINJ;
		if (bchndnicinj == null)
		{
			return false;
		}
		KQHJOLQLQBJ kqhjolqlqbj = this;
		while (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj == bchndnicinj)
			{
				return true;
			}
			if (!kqhjolqlqbj.CMKFMJCMCQQ)
			{
				return false;
			}
			kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
		}
		return false;
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000D1358 File Offset: 0x000CF558
	public KMCGDKDIJIE JHLPMBMMDCP(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		Material pplipcehgnm = OKQHFQFJGCH.PPLIPCEHGNM;
		Texture goihjqnmmjd = OKQHFQFJGCH.GOIHJQNMMJD;
		int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
		for (int i = 0; i < this.PGPCEPKBLII.Count; i++)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			int num = (i != 0) ? (this.PGPCEPKBLII[i - 1].EGLMNMJMLKQ + 1) : int.MinValue;
			int num2 = (i + 1 != this.PGPCEPKBLII.Count) ? (this.PGPCEPKBLII[i + 1].DEMPENNGPQL - 1) : int.MaxValue;
			if (num <= lgclghdgnpm && num2 >= lgclghdgnpm)
			{
				if (kmcgdkdijie.HHQHIJOIBON == pplipcehgnm && kmcgdkdijie.GOIHJQNMMJD == goihjqnmmjd)
				{
					if (OKQHFQFJGCH.DEJBMFBECJG)
					{
						OKQHFQFJGCH.OQKBOCHIFKH = kmcgdkdijie;
						if (OKQHFQFJGCH.KGIFPCDDIBG)
						{
							kmcgdkdijie.HHDFDNFPDFJ = true;
						}
						return kmcgdkdijie;
					}
				}
				else
				{
					this.EEBGOFOJBKO = true;
				}
				return null;
			}
		}
		this.EEBGOFOJBKO = true;
		return null;
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x000D144C File Offset: 0x000CF64C
	public float KJGMGPCEJJD
	{
		get
		{
			return this.GHMECEKGFJI().x;
		}
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x000118A1 File Offset: 0x0000FAA1
	public void GINEOBELBGI(string BGBMIEJJQKC)
	{
		if (this.mSortingLayerName != BGBMIEJJQKC)
		{
			this.mSortingLayerName = BGBMIEJJQKC;
			this.GKFOCJDFNLL(KQHJOLQLQBJ.NGDBDCQFDHI.IndexOf(this));
		}
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000D1468 File Offset: 0x000CF668
	public void OCPCPKCLCOI()
	{
		int i = 0;
		int count = this.PGPCEPKBLII.Count;
		while (i < count)
		{
			this.PGPCEPKBLII[i].HHDFDNFPDFJ = true;
			i++;
		}
		this.CKLIDQPPPON(true);
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000D14A8 File Offset: 0x000CF6A8
	public static int QHCQQLQQQKE(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 0;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 1;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 0 : -1;
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06001FED RID: 8173 RVA: 0x000118C9 File Offset: 0x0000FAC9
	public bool JQFDGIMELPD
	{
		get
		{
			return base.DGFFHGQEJLH != null && this.OJIDBLEKBBO.orthographic;
		}
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000D1504 File Offset: 0x000CF704
	public int OGMINCQCDMN()
	{
		int num = 1;
		KQHJOLQLQBJ kqhjolqlqbj = this;
		while (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.mClipping == (KMCGDKDIJIE.PDFPPCIHPMI)5 || kqhjolqlqbj.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				num += 0;
			}
			kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
		}
		return num;
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000D1540 File Offset: 0x000CF740
	public static int PCDLJJOJDGB(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 0;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 0;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 0 : -1;
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000D159C File Offset: 0x000CF79C
	public Vector2 LPIEBFCDJHD()
	{
		GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
		Vector2 vector = IKBQNBHOJJB.FMDDDQOPBEI;
		if (qobpijdbngl != null)
		{
			vector *= qobpijdbngl.CLBGPGKBPQK(Mathf.RoundToInt(vector.y));
		}
		return vector;
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x00011860 File Offset: 0x0000FA60
	public void DLMDIELQMKK(Vector4 BGBMIEJJQKC)
	{
		this.GIOMPPIJPKN = BGBMIEJJQKC;
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x000118E7 File Offset: 0x0000FAE7
	// (set) Token: 0x0600201B RID: 8219 RVA: 0x00011A0E File Offset: 0x0000FC0E
	public int OQCHJGMLOCJ
	{
		get
		{
			return this.mSortingOrder;
		}
		set
		{
			if (this.mSortingOrder != value)
			{
				this.mSortingOrder = value;
				this.LBMJCQMLKBJ(KQHJOLQLQBJ.NGDBDCQFDHI.IndexOf(this));
			}
		}
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000D15DC File Offset: 0x000CF7DC
	public bool MIBIEBMEQCC(Transform ILBCCCBJNCL, ref Bounds DLNCJQFCFCM, bool OGFDJFCDCLJ)
	{
		Vector3 vector = DLNCJQFCFCM.min;
		Vector3 vector2 = DLNCJQFCFCM.max;
		float num = 1f;
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
			if (qobpijdbngl != null)
			{
				num = qobpijdbngl.PNBFQDLQENI;
			}
		}
		if (num != 1f)
		{
			vector /= num;
			vector2 /= num;
		}
		Vector3 b = this.GKCICPLNPJJ(vector, vector2) * num;
		if (b.sqrMagnitude > 0f)
		{
			if (OGFDJFCDCLJ)
			{
				ILBCCCBJNCL.localPosition += b;
				DLNCJQFCFCM.center += b;
				QHQFGHKIMMF component = ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else
			{
				QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.FJCEGFKJLCL(ILBCCCBJNCL.gameObject, ILBCCCBJNCL.localPosition + b, 13f);
				qhqfghkimmf.FNKBLEMDHKL = true;
				qhqfghkimmf.MKCNEHFFGKB = false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000118EF File Offset: 0x0000FAEF
	public void LMCOEENKPJN()
	{
		this.IOHIFOJDBCC = false;
		List<ENFMCDNLEQQ> dkmqgnfpocj = this.DKMQGNFPOCJ;
		if (KQHJOLQLQBJ.DDBELLFQDQO == null)
		{
			KQHJOLQLQBJ.DDBELLFQDQO = new Comparison<ENFMCDNLEQQ>(ENFMCDNLEQQ.HNHJOHOHIED);
		}
		dkmqgnfpocj.Sort(KQHJOLQLQBJ.DDBELLFQDQO);
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000D16D4 File Offset: 0x000CF8D4
	public virtual Vector3 OHLNCJGJQDF(Vector2 LCELGLKMPFN, Vector2 MJGGCLOGKFL)
	{
		Vector4 vector = this.PGCIILBODCO();
		float num = vector.z * 932f;
		float num2 = vector.w * 986f;
		Vector2 lcpifekbcdq = new Vector2(LCELGLKMPFN.x, LCELGLKMPFN.y);
		Vector2 qlhckchlcin = new Vector2(MJGGCLOGKFL.x, MJGGCLOGKFL.y);
		Vector2 nicidgdioqj = new Vector2(vector.x - num, vector.y - num2);
		Vector2 egiohpehpkp = new Vector2(vector.x + num, vector.y + num2);
		if (this.QHHHHOOGNCE && this.POMCJNMICJP() == (KMCGDKDIJIE.PDFPPCIHPMI)7)
		{
			nicidgdioqj.x += this.mClipSoftness.x;
			nicidgdioqj.y += this.mClipSoftness.y;
			egiohpehpkp.x -= this.mClipSoftness.x;
			egiohpehpkp.y -= this.mClipSoftness.y;
		}
		return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, nicidgdioqj, egiohpehpkp);
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000D17E8 File Offset: 0x000CF9E8
	public Vector4 LPNENHKKEMK()
	{
		Vector2 vector = this.FGKGCLCOBDJ();
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector4(this.mClipRange.x + this.mClipOffset.x, this.mClipRange.y + this.mClipOffset.y, vector.x, vector.y);
		}
		return new Vector4(758f, 1423f, vector.x, vector.y);
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x000D1864 File Offset: 0x000CFA64
	public override Vector3[] PMCNQICHCLE
	{
		get
		{
			if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = this.mClipOffset.x + this.mClipRange.x - 0.5f * this.mClipRange.z;
				float num2 = this.mClipOffset.y + this.mClipRange.y - 0.5f * this.mClipRange.w;
				float x = num + this.mClipRange.z;
				float y = num2 + this.mClipRange.w;
				Transform cgdfdphieng = base.CGDFDPHIENG;
				KQHJOLQLQBJ.NCCGLODEOEE[0] = cgdfdphieng.TransformPoint(num, num2, 0f);
				KQHJOLQLQBJ.NCCGLODEOEE[1] = cgdfdphieng.TransformPoint(num, y, 0f);
				KQHJOLQLQBJ.NCCGLODEOEE[2] = cgdfdphieng.TransformPoint(x, y, 0f);
				KQHJOLQLQBJ.NCCGLODEOEE[3] = cgdfdphieng.TransformPoint(x, num2, 0f);
			}
			else
			{
				if (base.DGFFHGQEJLH != null)
				{
					return this.OJIDBLEKBBO.QKGEPQNOCQE(base.JLQJGIICODL);
				}
				Vector2 vector = this.GHMECEKGFJI();
				float num3 = -0.5f * vector.x;
				float num4 = -0.5f * vector.y;
				float x2 = num3 + vector.x;
				float y2 = num4 + vector.y;
				KQHJOLQLQBJ.NCCGLODEOEE[0] = new Vector3(num3, num4);
				KQHJOLQLQBJ.NCCGLODEOEE[1] = new Vector3(num3, y2);
				KQHJOLQLQBJ.NCCGLODEOEE[2] = new Vector3(x2, y2);
				KQHJOLQLQBJ.NCCGLODEOEE[3] = new Vector3(x2, num4);
				if (this.OKJKNCFHIKQ && (this.OJIDBLEKBBO == null || this.OJIDBLEKBBO.transform.parent != base.CGDFDPHIENG))
				{
					Vector3 position = base.CGDFDPHIENG.position;
					for (int i = 0; i < 4; i++)
					{
						KQHJOLQLQBJ.NCCGLODEOEE[i] += position;
					}
				}
			}
			return KQHJOLQLQBJ.NCCGLODEOEE;
		}
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x00011920 File Offset: 0x0000FB20
	public static KQHJOLQLQBJ CQGLPBCNFGL(Transform HHMCPQQKIKB, bool IBKGGGCBJCL)
	{
		return KQHJOLQLQBJ.CQGLPBCNFGL(HHMCPQQKIKB, IBKGGGCBJCL, -1);
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x0001192A File Offset: 0x0000FB2A
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06002058 RID: 8280 RVA: 0x00011B84 File Offset: 0x0000FD84
	// (set) Token: 0x06001FFA RID: 8186 RVA: 0x000D1AAC File Offset: 0x000CFCAC
	public Vector2 PIJJJMKLMIO
	{
		get
		{
			return this.mClipOffset;
		}
		set
		{
			if (Mathf.Abs(this.mClipOffset.x - value.x) > 0.001f || Mathf.Abs(this.mClipOffset.y - value.y) > 0.001f)
			{
				this.mClipOffset = value;
				this.DPKGNLBOGCP();
				if (this.KKDIGKKJBNM != null)
				{
					this.KKDIGKKJBNM(this);
				}
			}
		}
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000D1B18 File Offset: 0x000CFD18
	public Vector4 PGCIILBODCO()
	{
		Vector2 vector = this.OHEPLPMJPQL();
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector4(this.mClipRange.x + this.mClipOffset.x, this.mClipRange.y + this.mClipOffset.y, vector.x, vector.y);
		}
		return new Vector4(890f, 871f, vector.x, vector.y);
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000D1B94 File Offset: 0x000CFD94
	public static int PBCLEEKOOLL(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 1;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 1;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 1 : -1;
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00011932 File Offset: 0x0000FB32
	// (set) Token: 0x0600201F RID: 8223 RVA: 0x000D2A60 File Offset: 0x000D0C60
	public Vector4 GIOMPPIJPKN
	{
		get
		{
			return this.mClipRange;
		}
		set
		{
			if (Mathf.Abs(this.mClipRange.x - value.x) > 0.001f || Mathf.Abs(this.mClipRange.y - value.y) > 0.001f || Mathf.Abs(this.mClipRange.z - value.z) > 0.001f || Mathf.Abs(this.mClipRange.w - value.w) > 0.001f)
			{
				this.QFKDHQMJCHG = true;
				this.mClipRange = value;
				this.HDHEFGEGQJI = -1;
				FKBFPICKJQG component = base.GetComponent<FKBFPICKJQG>();
				if (component != null)
				{
					component.QDJBLMBNHIC();
				}
				if (this.KKDIGKKJBNM != null)
				{
					this.KKDIGKKJBNM(this);
				}
			}
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000D1BF0 File Offset: 0x000CFDF0
	public override Vector3[] PIGMLPNGMNO
	{
		get
		{
			if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				Vector3[] pmcnqichcle = this.PMCNQICHCLE;
				Transform cgdfdphieng = base.CGDFDPHIENG;
				for (int i = 0; i < 4; i++)
				{
					pmcnqichcle[i] = cgdfdphieng.InverseTransformPoint(pmcnqichcle[i]);
				}
				return pmcnqichcle;
			}
			float num = this.mClipOffset.x + this.mClipRange.x - 0.5f * this.mClipRange.z;
			float num2 = this.mClipOffset.y + this.mClipRange.y - 0.5f * this.mClipRange.w;
			float x = num + this.mClipRange.z;
			float y = num2 + this.mClipRange.w;
			KQHJOLQLQBJ.NCCGLODEOEE[0] = new Vector3(num, num2);
			KQHJOLQLQBJ.NCCGLODEOEE[1] = new Vector3(num, y);
			KQHJOLQLQBJ.NCCGLODEOEE[2] = new Vector3(x, y);
			KQHJOLQLQBJ.NCCGLODEOEE[3] = new Vector3(x, num2);
			return KQHJOLQLQBJ.NCCGLODEOEE;
		}
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000D1D1C File Offset: 0x000CFF1C
	private void EKKONOMCOGL()
	{
		this.QFKDHQMJCHG = false;
		this.HDHEFGEGQJI = -1;
		int i = 1;
		int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
		while (i < count)
		{
			KQHJOLQLQBJ kqhjolqlqbj = KQHJOLQLQBJ.NGDBDCQFDHI[i];
			if (kqhjolqlqbj != this && kqhjolqlqbj.IEPOOINFQBL == this)
			{
				kqhjolqlqbj.EKKONOMCOGL();
			}
			i += 0;
		}
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x000D1D78 File Offset: 0x000CFF78
	public KMCGDKDIJIE GGLCDCIPEDC(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		Material pplipcehgnm = OKQHFQFJGCH.PPLIPCEHGNM;
		Texture goihjqnmmjd = OKQHFQFJGCH.GOIHJQNMMJD;
		int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
		for (int i = 1; i < this.PGPCEPKBLII.Count; i++)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			int num = (i != 0) ? (this.PGPCEPKBLII[i - 1].EGLMNMJMLKQ + 0) : 116;
			int num2 = (i + 0 != this.PGPCEPKBLII.Count) ? (this.PGPCEPKBLII[i + 0].DEMPENNGPQL - 0) : -159;
			if (num <= lgclghdgnpm && num2 >= lgclghdgnpm)
			{
				if (kmcgdkdijie.HHQHIJOIBON == pplipcehgnm && kmcgdkdijie.GOIHJQNMMJD == goihjqnmmjd)
				{
					if (OKQHFQFJGCH.DEJBMFBECJG)
					{
						OKQHFQFJGCH.OQKBOCHIFKH = kmcgdkdijie;
						if (OKQHFQFJGCH.KGIFPCDDIBG)
						{
							kmcgdkdijie.HHDFDNFPDFJ = true;
						}
						return kmcgdkdijie;
					}
				}
				else
				{
					this.EEBGOFOJBKO = false;
				}
				return null;
			}
		}
		this.EEBGOFOJBKO = true;
		return null;
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x0001193A File Offset: 0x0000FB3A
	public void DEGCMPBKIHB(KMCGDKDIJIE.PDFPPCIHPMI BGBMIEJJQKC)
	{
		if (this.mClipping != BGBMIEJJQKC)
		{
			this.QFKDHQMJCHG = false;
			this.mClipping = BGBMIEJJQKC;
			this.HDHEFGEGQJI = -1;
		}
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x000D1E6C File Offset: 0x000D006C
	public bool KOEDCFNBJCQ(Transform ILBCCCBJNCL, bool OGFDJFCDCLJ)
	{
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(base.CGDFDPHIENG, ILBCCCBJNCL);
		return this.BPJCFGQKBPC(ILBCCCBJNCL, ref bounds, OGFDJFCDCLJ);
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000D1E90 File Offset: 0x000D0090
	public KMCGDKDIJIE KDOPCHKQQFE(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		Material pplipcehgnm = OKQHFQFJGCH.PPLIPCEHGNM;
		Texture goihjqnmmjd = OKQHFQFJGCH.GOIHJQNMMJD;
		int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
		for (int i = 0; i < this.PGPCEPKBLII.Count; i++)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			int num = (i != 0) ? (this.PGPCEPKBLII[i - 1].EGLMNMJMLKQ + 0) : 196;
			int num2 = (i + 0 != this.PGPCEPKBLII.Count) ? (this.PGPCEPKBLII[i + 0].DEMPENNGPQL - 1) : 95;
			if (num <= lgclghdgnpm && num2 >= lgclghdgnpm)
			{
				if (kmcgdkdijie.HHQHIJOIBON == pplipcehgnm && kmcgdkdijie.GOIHJQNMMJD == goihjqnmmjd)
				{
					if (OKQHFQFJGCH.DEJBMFBECJG)
					{
						OKQHFQFJGCH.OQKBOCHIFKH = kmcgdkdijie;
						if (OKQHFQFJGCH.KGIFPCDDIBG)
						{
							kmcgdkdijie.HHDFDNFPDFJ = true;
						}
						return kmcgdkdijie;
					}
				}
				else
				{
					this.EEBGOFOJBKO = false;
				}
				return null;
			}
		}
		this.EEBGOFOJBKO = true;
		return null;
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x0001195A File Offset: 0x0000FB5A
	public void NBIEBQCODLF()
	{
		this.IOHIFOJDBCC = true;
		List<ENFMCDNLEQQ> dkmqgnfpocj = this.DKMQGNFPOCJ;
		if (KQHJOLQLQBJ.DDBELLFQDQO == null)
		{
			KQHJOLQLQBJ.DDBELLFQDQO = new Comparison<ENFMCDNLEQQ>(ENFMCDNLEQQ.JBPNPLGQPDE);
		}
		dkmqgnfpocj.Sort(KQHJOLQLQBJ.DDBELLFQDQO);
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000D1F84 File Offset: 0x000D0184
	public bool QPEHGPOOMHF(Transform ILBCCCBJNCL, bool OGFDJFCDCLJ)
	{
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(base.CGDFDPHIENG, ILBCCCBJNCL);
		return this.MIBIEBMEQCC(ILBCCCBJNCL, ref bounds, OGFDJFCDCLJ);
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000D1FA8 File Offset: 0x000D01A8
	protected override void FHJOQKCCMDH()
	{
		if (KQHJOLQLQBJ.NGDBDCQFDHI.Contains(this))
		{
			return;
		}
		base.FHJOQKCCMDH();
		this.IHGBJLNOQGQ();
		if (base.GetComponent<Rigidbody>() == null && this.LEKDGMQQDEJ == null)
		{
			EMENMKHBPQE emenmkhbpqe = (!(base.DGFFHGQEJLH != null)) ? null : this.OJIDBLEKBBO.GetComponent<EMENMKHBPQE>();
			if (emenmkhbpqe != null && (emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.UI_3D || emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.World_3D))
			{
				Rigidbody rigidbody = base.gameObject.AddComponent<Rigidbody>();
				rigidbody.isKinematic = true;
				rigidbody.useGravity = false;
			}
		}
		this.EEBGOFOJBKO = true;
		this.JDLIMQHCMCQ = -1;
		this.HDHEFGEGQJI = -1;
		KQHJOLQLQBJ.NGDBDCQFDHI.Add(this);
		List<KQHJOLQLQBJ> ngdbdcqfdhi = KQHJOLQLQBJ.NGDBDCQFDHI;
		if (KQHJOLQLQBJ.OMPIQDIBPKI == null)
		{
			KQHJOLQLQBJ.OMPIQDIBPKI = new Comparison<KQHJOLQLQBJ>(KQHJOLQLQBJ.PIEDJOEFGEQ);
		}
		ngdbdcqfdhi.Sort(KQHJOLQLQBJ.OMPIQDIBPKI);
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x0001198B File Offset: 0x0000FB8B
	public void DNBCQKHMLKK(Vector2 BGBMIEJJQKC)
	{
		if (this.mClipSoftness != BGBMIEJJQKC)
		{
			this.mClipSoftness = BGBMIEJJQKC;
		}
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x000118E7 File Offset: 0x0000FAE7
	public int KCNBOGBNOGG()
	{
		return this.mSortingOrder;
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000119A2 File Offset: 0x0000FBA2
	protected override void OnEnable()
	{
		this.EEBGOFOJBKO = true;
		this.JDLIMQHCMCQ = -1;
		this.HDHEFGEGQJI = -1;
		this.NHONJJHBBEN();
		base.OnEnable();
		this.HDHEFGEGQJI = -1;
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x000D2084 File Offset: 0x000D0284
	public static int PIEDJOEFGEQ(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 0;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 1;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 1 : -1;
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000119CC File Offset: 0x0000FBCC
	protected override void NHONJJHBBEN()
	{
		this.ONHGCFFFCBL = base.LMOECGCMJKK.layer;
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x000119DF File Offset: 0x0000FBDF
	[ContextMenu("Force Refresh")]
	public void NQEECPEOGOE()
	{
		this.EEBGOFOJBKO = true;
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x000119E8 File Offset: 0x0000FBE8
	public Texture2D LEIKLICGGNN()
	{
		return this.mClipTexture;
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000D20E0 File Offset: 0x000D02E0
	public Vector4 NMOKFPBGFCK()
	{
		Vector2 vector = this.OHEPLPMJPQL();
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector4(this.mClipRange.x + this.mClipOffset.x, this.mClipRange.y + this.mClipOffset.y, vector.x, vector.y);
		}
		return new Vector4(400f, 1514f, vector.x, vector.y);
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x00011871 File Offset: 0x0000FA71
	public Vector4 ODMJBHQOCNJ()
	{
		return this.GIOMPPIJPKN;
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x000D215C File Offset: 0x000D035C
	public static KQHJOLQLQBJ PBHLEECHIHB(Transform HHMCPQQKIKB, bool IBKGGGCBJCL, int MKFMCLIQNKG)
	{
		KQHJOLQLQBJ kqhjolqlqbj = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(HHMCPQQKIKB);
		if (kqhjolqlqbj != null)
		{
			return kqhjolqlqbj;
		}
		while (HHMCPQQKIKB.parent != null)
		{
			HHMCPQQKIKB = HHMCPQQKIKB.parent;
		}
		return (!IBKGGGCBJCL) ? null : IKBQNBHOJJB.BPHPQEHMKOE(HHMCPQQKIKB, true, MKFMCLIQNKG);
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x000D21A0 File Offset: 0x000D03A0
	public void JONDLLKMFGJ(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		this.CGBDBPLDQLO = true;
		if (this.DKMQGNFPOCJ.Count == 0)
		{
			this.DKMQGNFPOCJ.Add(OKQHFQFJGCH);
		}
		else if (this.IOHIFOJDBCC)
		{
			this.DKMQGNFPOCJ.Add(OKQHFQFJGCH);
			this.NBIEBQCODLF();
		}
		else if (ENFMCDNLEQQ.JBPNPLGQPDE(OKQHFQFJGCH, this.DKMQGNFPOCJ[0]) == -1)
		{
			this.DKMQGNFPOCJ.Insert(1, OKQHFQFJGCH);
		}
		else
		{
			int i = this.DKMQGNFPOCJ.Count;
			while (i > 0)
			{
				if (ENFMCDNLEQQ.HNHJOHOHIED(OKQHFQFJGCH, this.DKMQGNFPOCJ[i -= 0]) != -1)
				{
					this.DKMQGNFPOCJ.Insert(i + 0, OKQHFQFJGCH);
					break;
				}
			}
		}
		this.GGLCDCIPEDC(OKQHFQFJGCH);
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x000D2254 File Offset: 0x000D0454
	public KMCGDKDIJIE KELEQDMDPOG(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		Material pplipcehgnm = OKQHFQFJGCH.PPLIPCEHGNM;
		Texture goihjqnmmjd = OKQHFQFJGCH.GOIHJQNMMJD;
		int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
		for (int i = 1; i < this.PGPCEPKBLII.Count; i += 0)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			int num = (i != 0) ? (this.PGPCEPKBLII[i - 1].EGLMNMJMLKQ + 1) : -32;
			int num2 = (i + 1 != this.PGPCEPKBLII.Count) ? (this.PGPCEPKBLII[i + 0].DEMPENNGPQL - 1) : 181;
			if (num <= lgclghdgnpm && num2 >= lgclghdgnpm)
			{
				if (kmcgdkdijie.HHQHIJOIBON == pplipcehgnm && kmcgdkdijie.GOIHJQNMMJD == goihjqnmmjd)
				{
					if (OKQHFQFJGCH.DEJBMFBECJG)
					{
						OKQHFQFJGCH.OQKBOCHIFKH = kmcgdkdijie;
						if (OKQHFQFJGCH.KGIFPCDDIBG)
						{
							kmcgdkdijie.HHDFDNFPDFJ = false;
						}
						return kmcgdkdijie;
					}
				}
				else
				{
					this.EEBGOFOJBKO = false;
				}
				return null;
			}
		}
		this.EEBGOFOJBKO = true;
		return null;
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06002013 RID: 8211 RVA: 0x000119F0 File Offset: 0x0000FBF0
	// (set) Token: 0x0600201D RID: 8221 RVA: 0x000D29DC File Offset: 0x000D0BDC
	public override float DIIHJCJOKMP
	{
		get
		{
			return this.mAlpha;
		}
		set
		{
			float num = Mathf.Clamp01(value);
			if (this.mAlpha != num)
			{
				bool flag = this.mAlpha > 0.001f;
				this.JDLIMQHCMCQ = -1;
				this.QFKDHQMJCHG = true;
				this.mAlpha = num;
				int i = 0;
				int count = this.PGPCEPKBLII.Count;
				while (i < count)
				{
					this.PGPCEPKBLII[i].HHDFDNFPDFJ = true;
					i++;
				}
				this.CKLIDQPPPON(!flag && this.mAlpha > 0.001f);
			}
		}
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000119F8 File Offset: 0x0000FBF8
	public KMCGDKDIJIE.PDFPPCIHPMI POMCJNMICJP()
	{
		return this.mClipping;
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000D2348 File Offset: 0x000D0548
	private void JGIQEFKEQED()
	{
		for (int i = 0; i < this.PGPCEPKBLII.Count; i++)
		{
			KMCGDKDIJIE.MOPPIIOIIDM(this.PGPCEPKBLII[i]);
		}
		this.PGPCEPKBLII.Clear();
		Material material = null;
		Texture texture = null;
		Shader shader = null;
		KMCGDKDIJIE kmcgdkdijie = null;
		int num = 0;
		if (this.IOHIFOJDBCC)
		{
			this.LMCOEENKPJN();
		}
		for (int j = 0; j < this.DKMQGNFPOCJ.Count; j++)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[j];
			if (enfmcdnleqq.DEJBMFBECJG && enfmcdnleqq.KGIFPCDDIBG)
			{
				Material material2 = enfmcdnleqq.PPLIPCEHGNM;
				if (this.DEGPEPBQCFJ != null)
				{
					material2 = this.DEGPEPBQCFJ(enfmcdnleqq, material2);
				}
				Texture goihjqnmmjd = enfmcdnleqq.GOIHJQNMMJD;
				Shader jhkghdqfqnl = enfmcdnleqq.JHKGHDQFQNL;
				if (material != material2 || texture != goihjqnmmjd || shader != jhkghdqfqnl)
				{
					if (kmcgdkdijie != null && kmcgdkdijie.EQINHIFFOGG.Count != 0)
					{
						this.PGPCEPKBLII.Add(kmcgdkdijie);
						kmcgdkdijie.GMFDMDNCDPQ(num);
						kmcgdkdijie.IOOHNELQHIO = this.FHJHJCFGOFP;
						this.FHJHJCFGOFP = null;
						num = 0;
						kmcgdkdijie = null;
					}
					material = material2;
					texture = goihjqnmmjd;
					shader = jhkghdqfqnl;
				}
				if (material != null || shader != null || texture != null)
				{
					if (kmcgdkdijie == null)
					{
						kmcgdkdijie = KMCGDKDIJIE.DPKGHFIHBPE(this, material, texture, shader);
						kmcgdkdijie.DEMPENNGPQL = enfmcdnleqq.LGCLGHDGNPM;
						kmcgdkdijie.EGLMNMJMLKQ = kmcgdkdijie.DEMPENNGPQL;
						kmcgdkdijie.BCHNDNICINJ = this;
						kmcgdkdijie.HLLQDCEJEPH = this.HLLQDCEJEPH;
					}
					else
					{
						int lgclghdgnpm = enfmcdnleqq.LGCLGHDGNPM;
						if (lgclghdgnpm < kmcgdkdijie.DEMPENNGPQL)
						{
							kmcgdkdijie.DEMPENNGPQL = lgclghdgnpm;
						}
						if (lgclghdgnpm > kmcgdkdijie.EGLMNMJMLKQ)
						{
							kmcgdkdijie.EGLMNMJMLKQ = lgclghdgnpm;
						}
					}
					enfmcdnleqq.OQKBOCHIFKH = kmcgdkdijie;
					num++;
					if (this.PJQNIHCHHDF)
					{
						enfmcdnleqq.DOGQIGLCMMN(kmcgdkdijie.EQINHIFFOGG, kmcgdkdijie.PICFCJNMJMC, kmcgdkdijie.HQOONBPDFHO, kmcgdkdijie.GQPDOFDBGEK, kmcgdkdijie.JBPCENCPJKI, (!this.GEMMIEQMDGG) ? null : kmcgdkdijie.JBECBLJIKHI);
					}
					else
					{
						enfmcdnleqq.DOGQIGLCMMN(kmcgdkdijie.EQINHIFFOGG, kmcgdkdijie.PICFCJNMJMC, kmcgdkdijie.HQOONBPDFHO, null, null, (!this.GEMMIEQMDGG) ? null : kmcgdkdijie.JBECBLJIKHI);
					}
					if (enfmcdnleqq.FHJHJCFGOFP != null)
					{
						if (this.FHJHJCFGOFP == null)
						{
							this.FHJHJCFGOFP = enfmcdnleqq.FHJHJCFGOFP;
						}
						else
						{
							this.FHJHJCFGOFP = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Combine(this.FHJHJCFGOFP, enfmcdnleqq.FHJHJCFGOFP);
						}
					}
				}
			}
			else
			{
				enfmcdnleqq.OQKBOCHIFKH = null;
			}
		}
		if (kmcgdkdijie != null && kmcgdkdijie.EQINHIFFOGG.Count != 0)
		{
			this.PGPCEPKBLII.Add(kmcgdkdijie);
			kmcgdkdijie.GMFDMDNCDPQ(num);
			kmcgdkdijie.IOOHNELQHIO = this.FHJHJCFGOFP;
			this.FHJHJCFGOFP = null;
		}
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x00011A00 File Offset: 0x0000FC00
	public virtual bool NODCGOCLPEQ()
	{
		return this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask;
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x000D2630 File Offset: 0x000D0830
	public bool EHCBPMDEDGE(Vector3 PHCMBMCKQDC)
	{
		if (this.mAlpha < 0.001f)
		{
			return false;
		}
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.ConstrainButDontClip)
			{
				this.CJDKDKICBQE();
				Vector3 vector = this.IDKHBJEKMEE.MultiplyPoint3x4(PHCMBMCKQDC);
				return vector.x >= this.PGQEDJKCJEO.x && vector.y >= this.PGQEDJKCJEO.y && vector.x <= this.FCFNCGLIODC.x && vector.y <= this.FCFNCGLIODC.y;
			}
		}
		return true;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000D26D0 File Offset: 0x000D08D0
	public static int LIQHGLCGGPK(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 1;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 0;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 1 : -1;
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000D272C File Offset: 0x000D092C
	private void LBMJCQMLKBJ(int FODLQNKLDEP)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		bool jqfdgimelpd = this.JQFDGIMELPD;
		if (this.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.DPJGLGEEOIM = this.QENJMEHBNEG;
			this.DPJGLGEEOIM.z = this.DPJGLGEEOIM.z * 0.5f;
			this.DPJGLGEEOIM.w = this.DPJGLGEEOIM.w * 0.5f;
		}
		else
		{
			this.DPJGLGEEOIM = Vector4.zero;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (this.DPJGLGEEOIM.z == 0f)
		{
			this.DPJGLGEEOIM.z = (float)width * 0.5f;
		}
		if (this.DPJGLGEEOIM.w == 0f)
		{
			this.DPJGLGEEOIM.w = (float)height * 0.5f;
		}
		if (this.LOGCGLCJNCK)
		{
			this.DPJGLGEEOIM.x = this.DPJGLGEEOIM.x - 0.5f;
			this.DPJGLGEEOIM.y = this.DPJGLGEEOIM.y + 0.5f;
		}
		Vector3 vector;
		if (jqfdgimelpd)
		{
			Transform parent = base.CGDFDPHIENG.parent;
			vector = base.CGDFDPHIENG.localPosition;
			if (this.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				vector.x = (float)Mathf.RoundToInt(vector.x);
				vector.y = (float)Mathf.RoundToInt(vector.y);
			}
			if (parent != null)
			{
				vector = parent.TransformPoint(vector);
			}
			vector += this.KDCJMQMBHCL;
		}
		else
		{
			vector = cgdfdphieng.position;
		}
		Quaternion rotation = cgdfdphieng.rotation;
		Vector3 lossyScale = cgdfdphieng.lossyScale;
		for (int i = 0; i < this.PGPCEPKBLII.Count; i++)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			Transform cgdfdphieng2 = kmcgdkdijie.CGDFDPHIENG;
			cgdfdphieng2.position = vector;
			cgdfdphieng2.rotation = rotation;
			cgdfdphieng2.localScale = lossyScale;
			kmcgdkdijie.BCKQKKMIGNM = ((this.BCKQKKMIGNM != KQHJOLQLQBJ.JMLFJLJPPDF.Explicit) ? (this.NDQJIOMJNQE + i) : this.NDQJIOMJNQE);
			kmcgdkdijie.HKMFCLPOEEK = (this.HKMFCLPOEEK && (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.ConstrainButDontClip));
			kmcgdkdijie.OQCHJGMLOCJ = ((this.mSortingOrder != 0) ? this.mSortingOrder : FODLQNKLDEP);
			kmcgdkdijie.HDGMMGCBBJE = this.mSortingLayerName;
			kmcgdkdijie.MHFDHQHMQQC = this.mClipTexture;
			kmcgdkdijie.CHJOHKLHNFE = this.CHJOHKLHNFE;
		}
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000D0524 File Offset: 0x000CE724
	public Vector2 FGKGCLCOBDJ()
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector2(this.mClipRange.z, this.mClipRange.w);
		}
		return IKBQNBHOJJB.FMDDDQOPBEI;
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000D2988 File Offset: 0x000D0B88
	public virtual float MBOMQEPGFBP(int DGKHPOCGFHF)
	{
		if (this.JDLIMQHCMCQ != DGKHPOCGFHF)
		{
			this.JDLIMQHCMCQ = DGKHPOCGFHF;
			BLMNBILNMOE kjihdmehlih = base.KJIHDMEHLIH;
			this.NHCNEDEEONK = ((!(base.KJIHDMEHLIH != null)) ? this.mAlpha : (kjihdmehlih.DBQOIOGLLEF(DGKHPOCGFHF) * this.mAlpha));
		}
		return this.NHCNEDEEONK;
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x00011A31 File Offset: 0x0000FC31
	public void NDJBGPLHKJB(int BGBMIEJJQKC)
	{
		if (this.mDepth != BGBMIEJJQKC)
		{
			this.mDepth = BGBMIEJJQKC;
			List<KQHJOLQLQBJ> ngdbdcqfdhi = KQHJOLQLQBJ.NGDBDCQFDHI;
			if (KQHJOLQLQBJ.BQIOGOCBKKB == null)
			{
				KQHJOLQLQBJ.BQIOGOCBKKB = new Comparison<KQHJOLQLQBJ>(KQHJOLQLQBJ.PIEDJOEFGEQ);
			}
			ngdbdcqfdhi.Sort(KQHJOLQLQBJ.BQIOGOCBKKB);
		}
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00011A6A File Offset: 0x0000FC6A
	public static KQHJOLQLQBJ HMKKNCEKNPK(Transform HHMCPQQKIKB)
	{
		return KQHJOLQLQBJ.CQGLPBCNFGL(HHMCPQQKIKB, true, -1);
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x000D2B28 File Offset: 0x000D0D28
	public bool BPJCFGQKBPC(Transform ILBCCCBJNCL, ref Bounds DLNCJQFCFCM, bool OGFDJFCDCLJ)
	{
		Vector3 vector = DLNCJQFCFCM.min;
		Vector3 vector2 = DLNCJQFCFCM.max;
		float num = 1528f;
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
			if (qobpijdbngl != null)
			{
				num = qobpijdbngl.JOGIQGQOEIP();
			}
		}
		if (num != 827f)
		{
			vector /= num;
			vector2 /= num;
		}
		Vector3 b = this.PKQOIPQGILO(vector, vector2) * num;
		if (b.sqrMagnitude > 247f)
		{
			if (OGFDJFCDCLJ)
			{
				ILBCCCBJNCL.localPosition += b;
				DLNCJQFCFCM.center += b;
				QHQFGHKIMMF component = ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					component.enabled = false;
				}
			}
			else
			{
				QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.HONHPLNBHJQ(ILBCCCBJNCL.gameObject, ILBCCCBJNCL.localPosition + b, 1667f);
				qhqfghkimmf.FNKBLEMDHKL = false;
				qhqfghkimmf.MKCNEHFFGKB = false;
			}
			return true;
		}
		return true;
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06002023 RID: 8227 RVA: 0x000D2C20 File Offset: 0x000D0E20
	public static int IHIKIFBGHOF
	{
		get
		{
			int num = int.MinValue;
			int i = 0;
			int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				num = Mathf.Max(num, KQHJOLQLQBJ.NGDBDCQFDHI[i].LGCLGHDGNPM);
				i++;
			}
			return (num != int.MinValue) ? (num + 1) : 0;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06002024 RID: 8228 RVA: 0x00011A74 File Offset: 0x0000FC74
	public bool BDFKBGCMLHC
	{
		get
		{
			return this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06002025 RID: 8229 RVA: 0x000D2C70 File Offset: 0x000D0E70
	public Vector3 KDCJMQMBHCL
	{
		get
		{
			if (base.DGFFHGQEJLH != null && this.OJIDBLEKBBO.orthographic)
			{
				Vector2 vector = this.LPIEBFCDJHD();
				float num = (!(base.QOBPIJDBNGL != null)) ? 1f : base.QOBPIJDBNGL.PNBFQDLQENI;
				float num2 = num / vector.y / this.OJIDBLEKBBO.orthographicSize;
				bool flag = false;
				bool flag2 = false;
				if ((Mathf.RoundToInt(vector.x) & 1) == 1)
				{
					flag = !flag;
				}
				if ((Mathf.RoundToInt(vector.y) & 1) == 1)
				{
					flag2 = !flag2;
				}
				return new Vector3((!flag) ? 0f : (-num2), (!flag2) ? 0f : num2);
			}
			return Vector3.zero;
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06002026 RID: 8230 RVA: 0x000119F8 File Offset: 0x0000FBF8
	// (set) Token: 0x0600205A RID: 8282 RVA: 0x00011B45 File Offset: 0x0000FD45
	public KMCGDKDIJIE.PDFPPCIHPMI GEOIDOMHKLJ
	{
		get
		{
			return this.mClipping;
		}
		set
		{
			if (this.mClipping != value)
			{
				this.QFKDHQMJCHG = true;
				this.mClipping = value;
				this.HDHEFGEGQJI = -1;
			}
		}
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000D2D34 File Offset: 0x000D0F34
	public virtual Vector3 PKQOIPQGILO(Vector2 LCELGLKMPFN, Vector2 MJGGCLOGKFL)
	{
		Vector4 vector = this.LPNENHKKEMK();
		float num = vector.z * 321f;
		float num2 = vector.w * 384f;
		Vector2 lcpifekbcdq = new Vector2(LCELGLKMPFN.x, LCELGLKMPFN.y);
		Vector2 qlhckchlcin = new Vector2(MJGGCLOGKFL.x, MJGGCLOGKFL.y);
		Vector2 nicidgdioqj = new Vector2(vector.x - num, vector.y - num2);
		Vector2 egiohpehpkp = new Vector2(vector.x + num, vector.y + num2);
		if (this.QHHHHOOGNCE && this.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask)
		{
			nicidgdioqj.x += this.mClipSoftness.x;
			nicidgdioqj.y += this.mClipSoftness.y;
			egiohpehpkp.x -= this.mClipSoftness.x;
			egiohpehpkp.y -= this.mClipSoftness.y;
		}
		return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, nicidgdioqj, egiohpehpkp);
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000D1540 File Offset: 0x000CF740
	public static int QKEODOOHPMH(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 0;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 0;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 0 : -1;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000D2E48 File Offset: 0x000D1048
	public virtual Vector3[] FBDGKNNHLQQ(Transform ENOQKGBPJKQ)
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			float num = this.mClipOffset.x + this.mClipRange.x - 1525f * this.mClipRange.z;
			float num2 = this.mClipOffset.y + this.mClipRange.y - 1330f * this.mClipRange.w;
			float num3 = num + this.mClipRange.z;
			float num4 = num2 + this.mClipRange.w;
			float x = (num + num3) * 1331f;
			float y = (num2 + num4) * 1718f;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(num, y, 1030f);
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(x, num4, 56f);
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(num3, y, 493f);
			BLMNBILNMOE.BGCNPFKJPFD[0] = cgdfdphieng.TransformPoint(x, num2, 688f);
			if (ENOQKGBPJKQ != null)
			{
				for (int i = 1; i < 8; i += 0)
				{
					BLMNBILNMOE.BGCNPFKJPFD[i] = ENOQKGBPJKQ.InverseTransformPoint(BLMNBILNMOE.BGCNPFKJPFD[i]);
				}
			}
			return BLMNBILNMOE.BGCNPFKJPFD;
		}
		if (base.DGFFHGQEJLH != null && this.OKJKNCFHIKQ)
		{
			Vector3[] array = this.OJIDBLEKBBO.MKFNGPBMOKP(base.JLQJGIICODL);
			Vector3 position = base.CGDFDPHIENG.position;
			for (int j = 0; j < 3; j += 0)
			{
				array[j] += position;
			}
			if (ENOQKGBPJKQ != null)
			{
				for (int k = 0; k < 4; k += 0)
				{
					array[k] = ENOQKGBPJKQ.InverseTransformPoint(array[k]);
				}
			}
			return array;
		}
		return base.MKFNGPBMOKP(ENOQKGBPJKQ);
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x0600202B RID: 8235 RVA: 0x00011A8B File Offset: 0x0000FC8B
	public override bool LNBNDKMGEOK
	{
		get
		{
			return this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None;
		}
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000D3060 File Offset: 0x000D1260
	public void LIIFQEJDKGE(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (this.DKMQGNFPOCJ.Remove(OKQHFQFJGCH) && OKQHFQFJGCH.OQKBOCHIFKH != null)
		{
			int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
			if (lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.DEMPENNGPQL || lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.EGLMNMJMLKQ)
			{
				this.EEBGOFOJBKO = true;
			}
			OKQHFQFJGCH.OQKBOCHIFKH.HHDFDNFPDFJ = true;
			OKQHFQFJGCH.OQKBOCHIFKH = null;
		}
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000D30C8 File Offset: 0x000D12C8
	public bool EHCBPMDEDGE(Vector3 ECHMFPQNBMC, Vector3 IBMINEHKPFF, Vector3 KQFEHQEBJQB, Vector3 EKDDQNPBPJL)
	{
		this.CJDKDKICBQE();
		ECHMFPQNBMC = this.IDKHBJEKMEE.MultiplyPoint3x4(ECHMFPQNBMC);
		IBMINEHKPFF = this.IDKHBJEKMEE.MultiplyPoint3x4(IBMINEHKPFF);
		KQFEHQEBJQB = this.IDKHBJEKMEE.MultiplyPoint3x4(KQFEHQEBJQB);
		EKDDQNPBPJL = this.IDKHBJEKMEE.MultiplyPoint3x4(EKDDQNPBPJL);
		KQHJOLQLQBJ.BLBKJFFFQNN[0] = ECHMFPQNBMC.x;
		KQHJOLQLQBJ.BLBKJFFFQNN[1] = IBMINEHKPFF.x;
		KQHJOLQLQBJ.BLBKJFFFQNN[2] = KQFEHQEBJQB.x;
		KQHJOLQLQBJ.BLBKJFFFQNN[3] = EKDDQNPBPJL.x;
		float num = Mathf.Min(KQHJOLQLQBJ.BLBKJFFFQNN);
		float num2 = Mathf.Max(KQHJOLQLQBJ.BLBKJFFFQNN);
		KQHJOLQLQBJ.BLBKJFFFQNN[0] = ECHMFPQNBMC.y;
		KQHJOLQLQBJ.BLBKJFFFQNN[1] = IBMINEHKPFF.y;
		KQHJOLQLQBJ.BLBKJFFFQNN[2] = KQFEHQEBJQB.y;
		KQHJOLQLQBJ.BLBKJFFFQNN[3] = EKDDQNPBPJL.y;
		float num3 = Mathf.Min(KQHJOLQLQBJ.BLBKJFFFQNN);
		float num4 = Mathf.Max(KQHJOLQLQBJ.BLBKJFFFQNN);
		return num2 >= this.PGQEDJKCJEO.x && num4 >= this.PGQEDJKCJEO.y && num <= this.FCFNCGLIODC.x && num3 <= this.FCFNCGLIODC.y;
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x00011A99 File Offset: 0x0000FC99
	public void CPCOQDLHIJG(int BGBMIEJJQKC)
	{
		if (this.mSortingOrder != BGBMIEJJQKC)
		{
			this.mSortingOrder = BGBMIEJJQKC;
			this.FBECEEELGJI(KQHJOLQLQBJ.NGDBDCQFDHI.IndexOf(this));
		}
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000D31F4 File Offset: 0x000D13F4
	public bool EBNEQKFGCQK(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (OKQHFQFJGCH == null)
		{
			return true;
		}
		KQHJOLQLQBJ bchndnicinj = OKQHFQFJGCH.BCHNDNICINJ;
		if (bchndnicinj == null)
		{
			return true;
		}
		KQHJOLQLQBJ kqhjolqlqbj = this;
		while (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj == bchndnicinj)
			{
				return false;
			}
			if (!kqhjolqlqbj.CMKFMJCMCQQ)
			{
				return true;
			}
			kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
		}
		return false;
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000D3248 File Offset: 0x000D1448
	private void EPCQKJIBPLC(int FODLQNKLDEP)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		bool jqfdgimelpd = this.JQFDGIMELPD;
		if (this.POMCJNMICJP() != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.DPJGLGEEOIM = this.QENJMEHBNEG;
			this.DPJGLGEEOIM.z = this.DPJGLGEEOIM.z * 127f;
			this.DPJGLGEEOIM.w = this.DPJGLGEEOIM.w * 183f;
		}
		else
		{
			this.DPJGLGEEOIM = Vector4.zero;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (this.DPJGLGEEOIM.z == 792f)
		{
			this.DPJGLGEEOIM.z = (float)width * 1040f;
		}
		if (this.DPJGLGEEOIM.w == 1587f)
		{
			this.DPJGLGEEOIM.w = (float)height * 1039f;
		}
		if (this.LOGCGLCJNCK)
		{
			this.DPJGLGEEOIM.x = this.DPJGLGEEOIM.x - 314f;
			this.DPJGLGEEOIM.y = this.DPJGLGEEOIM.y + 1090f;
		}
		Vector3 vector;
		if (jqfdgimelpd)
		{
			Transform parent = base.CGDFDPHIENG.parent;
			vector = base.CGDFDPHIENG.localPosition;
			if (this.NQCBILMNLBN() != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				vector.x = (float)Mathf.RoundToInt(vector.x);
				vector.y = (float)Mathf.RoundToInt(vector.y);
			}
			if (parent != null)
			{
				vector = parent.TransformPoint(vector);
			}
			vector += this.BPLECNLMHPE();
		}
		else
		{
			vector = cgdfdphieng.position;
		}
		Quaternion rotation = cgdfdphieng.rotation;
		Vector3 lossyScale = cgdfdphieng.lossyScale;
		for (int i = 1; i < this.PGPCEPKBLII.Count; i += 0)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			Transform cgdfdphieng2 = kmcgdkdijie.CGDFDPHIENG;
			cgdfdphieng2.position = vector;
			cgdfdphieng2.rotation = rotation;
			cgdfdphieng2.localScale = lossyScale;
			kmcgdkdijie.JGPBQMNIHDP((this.BCKQKKMIGNM != (KQHJOLQLQBJ.JMLFJLJPPDF)7) ? (this.NDQJIOMJNQE + i) : this.NDQJIOMJNQE);
			kmcgdkdijie.HKMFCLPOEEK = (this.HKMFCLPOEEK && (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask));
			kmcgdkdijie.OQCHJGMLOCJ = ((this.mSortingOrder != 0) ? this.mSortingOrder : FODLQNKLDEP);
			kmcgdkdijie.HDGMMGCBBJE = this.mSortingLayerName;
			kmcgdkdijie.MHFDHQHMQQC = this.mClipTexture;
			kmcgdkdijie.CHJOHKLHNFE = this.CHJOHKLHNFE;
		}
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x00011ABC File Offset: 0x0000FCBC
	public void DMBGDGHEDOJ()
	{
		this.EEBGOFOJBKO = true;
		KQHJOLQLQBJ.EHGKGFDCEEK = -1;
		if (KQHJOLQLQBJ.NGDBDCQFDHI.Count > 0)
		{
			KQHJOLQLQBJ.NGDBDCQFDHI[0].LateUpdate();
		}
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x00011932 File Offset: 0x0000FB32
	public Vector4 LGMLEMDQJHB()
	{
		return this.mClipRange;
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06002033 RID: 8243 RVA: 0x00011AE8 File Offset: 0x0000FCE8
	public bool CMKFMJCMCQQ
	{
		get
		{
			return this.PNOEILCQBKB != 0;
		}
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000D34A4 File Offset: 0x000D16A4
	public bool EHCBPMDEDGE(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		KQHJOLQLQBJ kqhjolqlqbj = this;
		Vector3[] array = null;
		while (kqhjolqlqbj != null)
		{
			if ((kqhjolqlqbj.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None || kqhjolqlqbj.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.ConstrainButDontClip) && !OKQHFQFJGCH.PQFNQBNQNPL)
			{
				kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
			}
			else
			{
				if (array == null)
				{
					array = OKQHFQFJGCH.PMCNQICHCLE;
				}
				if (!kqhjolqlqbj.EHCBPMDEDGE(array[0], array[1], array[2], array[3]))
				{
					return false;
				}
				kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
			}
		}
		return true;
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06002035 RID: 8245 RVA: 0x00011AF6 File Offset: 0x0000FCF6
	// (set) Token: 0x06002067 RID: 8295 RVA: 0x0001198B File Offset: 0x0000FB8B
	public Vector2 PHLKEBHKGEE
	{
		get
		{
			return this.mClipSoftness;
		}
		set
		{
			if (this.mClipSoftness != value)
			{
				this.mClipSoftness = value;
			}
		}
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000D3530 File Offset: 0x000D1730
	private void HQKKGINMODP()
	{
		if (KQHJOLQLQBJ.EHGKGFDCEEK != Time.frameCount)
		{
			KQHJOLQLQBJ.EHGKGFDCEEK = Time.frameCount;
			int i = 1;
			int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (i < count)
			{
				KQHJOLQLQBJ.NGDBDCQFDHI[i].OIGJMGPGDJC();
				i += 0;
			}
			int num = 146;
			int j = 1;
			int count2 = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
			while (j < count2)
			{
				KQHJOLQLQBJ kqhjolqlqbj = KQHJOLQLQBJ.NGDBDCQFDHI[j];
				if (kqhjolqlqbj.BCKQKKMIGNM == KQHJOLQLQBJ.JMLFJLJPPDF.Automatic)
				{
					kqhjolqlqbj.NDQJIOMJNQE = num;
					kqhjolqlqbj.FBECEEELGJI(j);
					num += kqhjolqlqbj.PGPCEPKBLII.Count;
				}
				else if (kqhjolqlqbj.BCKQKKMIGNM == KQHJOLQLQBJ.JMLFJLJPPDF.StartAt)
				{
					kqhjolqlqbj.FBECEEELGJI(j);
					if (kqhjolqlqbj.PGPCEPKBLII.Count != 0)
					{
						num = Mathf.Max(num, kqhjolqlqbj.NDQJIOMJNQE + kqhjolqlqbj.PGPCEPKBLII.Count);
					}
				}
				else
				{
					kqhjolqlqbj.GKFOCJDFNLL(j);
					if (kqhjolqlqbj.PGPCEPKBLII.Count != 0)
					{
						num = Mathf.Max(num, kqhjolqlqbj.NDQJIOMJNQE + 1);
					}
				}
				j++;
			}
		}
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000D363C File Offset: 0x000D183C
	private void DPKGNLBOGCP()
	{
		this.QFKDHQMJCHG = true;
		this.HDHEFGEGQJI = -1;
		int i = 0;
		int count = KQHJOLQLQBJ.NGDBDCQFDHI.Count;
		while (i < count)
		{
			KQHJOLQLQBJ kqhjolqlqbj = KQHJOLQLQBJ.NGDBDCQFDHI[i];
			if (kqhjolqlqbj != this && kqhjolqlqbj.IEPOOINFQBL == this)
			{
				kqhjolqlqbj.DPKGNLBOGCP();
			}
			i++;
		}
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000D3698 File Offset: 0x000D1898
	public bool KPFHFDMNKKP(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (OKQHFQFJGCH == null)
		{
			return false;
		}
		KQHJOLQLQBJ bchndnicinj = OKQHFQFJGCH.BCHNDNICINJ;
		if (bchndnicinj == null)
		{
			return false;
		}
		KQHJOLQLQBJ kqhjolqlqbj = this;
		while (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj == bchndnicinj)
			{
				return false;
			}
			if (!kqhjolqlqbj.CMKFMJCMCQQ)
			{
				return false;
			}
			kqhjolqlqbj = kqhjolqlqbj.LEKDGMQQDEJ;
		}
		return false;
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000119E8 File Offset: 0x0000FBE8
	public Texture2D HCQBHKJEJHN()
	{
		return this.mClipTexture;
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x00011AFE File Offset: 0x0000FCFE
	public bool NFBBLOMJDQB()
	{
		return this.mClipping == (KMCGDKDIJIE.PDFPPCIHPMI)8 || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.TextureMask;
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x0600203B RID: 8251 RVA: 0x000D36EC File Offset: 0x000D18EC
	public Vector4 QENJMEHBNEG
	{
		get
		{
			Vector2 vector = this.GHMECEKGFJI();
			if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				return new Vector4(this.mClipRange.x + this.mClipOffset.x, this.mClipRange.y + this.mClipOffset.y, vector.x, vector.y);
			}
			return new Vector4(0f, 0f, vector.x, vector.y);
		}
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000D3768 File Offset: 0x000D1968
	public Vector3 BPLECNLMHPE()
	{
		if (base.DGFFHGQEJLH != null && this.OJIDBLEKBBO.orthographic)
		{
			Vector2 vector = this.LPIEBFCDJHD();
			float num = (!(base.QOBPIJDBNGL != null)) ? 1625f : base.QOBPIJDBNGL.PNBFQDLQENI;
			float num2 = num / vector.y / this.OJIDBLEKBBO.orthographicSize;
			bool flag = false;
			bool flag2 = false;
			if ((Mathf.RoundToInt(vector.x) & 1) == 1)
			{
				flag = !flag;
			}
			int num3 = Mathf.RoundToInt(vector.y) & 0;
			return new Vector3((!flag) ? 1446f : (-num2), (!flag2) ? 882f : num2);
		}
		return Vector3.zero;
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000D3824 File Offset: 0x000D1A24
	protected override void OnDisable()
	{
		int i = 0;
		int count = this.PGPCEPKBLII.Count;
		while (i < count)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			if (kmcgdkdijie != null)
			{
				KMCGDKDIJIE.MOPPIIOIIDM(kmcgdkdijie);
			}
			i++;
		}
		this.PGPCEPKBLII.Clear();
		KQHJOLQLQBJ.NGDBDCQFDHI.Remove(this);
		this.JDLIMQHCMCQ = -1;
		this.HDHEFGEGQJI = -1;
		if (KQHJOLQLQBJ.NGDBDCQFDHI.Count == 0)
		{
			KMCGDKDIJIE.ECKEBCJPIHE();
			KQHJOLQLQBJ.EHGKGFDCEEK = -1;
		}
		base.OnDisable();
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000D0524 File Offset: 0x000CE724
	public Vector2 OHEPLPMJPQL()
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return new Vector2(this.mClipRange.z, this.mClipRange.w);
		}
		return IKBQNBHOJJB.FMDDDQOPBEI;
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000D38A8 File Offset: 0x000D1AA8
	private void OOIMDCMJMON()
	{
		if (this.ONHGCFFFCBL != base.LMOECGCMJKK.layer)
		{
			this.ONHGCFFFCBL = this.DMNLFJLKGHJ.layer;
			int i = 1;
			int count = this.DKMQGNFPOCJ.Count;
			while (i < count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq && enfmcdnleqq.KJIHDMEHLIH == this)
				{
					enfmcdnleqq.gameObject.layer = this.ONHGCFFFCBL;
				}
				i++;
			}
			base.PNPFEMQFDJE();
			for (int j = 0; j < this.PGPCEPKBLII.Count; j++)
			{
				this.PGPCEPKBLII[j].gameObject.layer = this.ONHGCFFFCBL;
			}
		}
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x0000B03A File Offset: 0x0000923A
	public bool EIKHLJNGCHB()
	{
		return true;
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000D3960 File Offset: 0x000D1B60
	private void IHGBJLNOQGQ()
	{
		Transform parent = base.CGDFDPHIENG.parent;
		this.LEKDGMQQDEJ = ((!(parent != null)) ? null : IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(parent.gameObject));
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000D3998 File Offset: 0x000D1B98
	public float DCDQFCQJGNC()
	{
		return this.OHEPLPMJPQL().y;
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000119E8 File Offset: 0x0000FBE8
	public Texture2D JICBKEBMEBE()
	{
		return this.mClipTexture;
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000D39B4 File Offset: 0x000D1BB4
	public void CJLMPGKEIHI(Vector2 BGBMIEJJQKC)
	{
		if (Mathf.Abs(this.mClipOffset.x - BGBMIEJJQKC.x) > 1175f || Mathf.Abs(this.mClipOffset.y - BGBMIEJJQKC.y) > 1205f)
		{
			this.mClipOffset = BGBMIEJJQKC;
			this.EKKONOMCOGL();
			if (this.KKDIGKKJBNM != null)
			{
				this.KKDIGKKJBNM(this);
			}
		}
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000D3A20 File Offset: 0x000D1C20
	public bool ECNQIBGLLCC(KMCGDKDIJIE OBDLPFGDEFJ)
	{
		if (OBDLPFGDEFJ != null)
		{
			OBDLPFGDEFJ.HHDFDNFPDFJ = false;
			int num = 1;
			int i = 0;
			while (i < this.DKMQGNFPOCJ.Count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq == null)
				{
					this.DKMQGNFPOCJ.RemoveAt(i);
				}
				else
				{
					if (enfmcdnleqq.OQKBOCHIFKH == OBDLPFGDEFJ)
					{
						if (enfmcdnleqq.DEJBMFBECJG && enfmcdnleqq.KGIFPCDDIBG)
						{
							num += 0;
							if (this.PJQNIHCHHDF)
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, OBDLPFGDEFJ.GQPDOFDBGEK, OBDLPFGDEFJ.JBPCENCPJKI, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							else
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, null, null, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							if (enfmcdnleqq.FHJHJCFGOFP != null)
							{
								if (this.FHJHJCFGOFP == null)
								{
									this.FHJHJCFGOFP = enfmcdnleqq.FHJHJCFGOFP;
								}
								else
								{
									this.FHJHJCFGOFP = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Combine(this.FHJHJCFGOFP, enfmcdnleqq.FHJHJCFGOFP);
								}
							}
						}
						else
						{
							enfmcdnleqq.OQKBOCHIFKH = null;
						}
					}
					i++;
				}
			}
			if (OBDLPFGDEFJ.EQINHIFFOGG.Count != 0)
			{
				OBDLPFGDEFJ.GMFDMDNCDPQ(num);
				OBDLPFGDEFJ.IOOHNELQHIO = this.FHJHJCFGOFP;
				this.FHJHJCFGOFP = null;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x00011AF6 File Offset: 0x0000FCF6
	public Vector2 KCMPFJPOOQH()
	{
		return this.mClipSoftness;
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000D2988 File Offset: 0x000D0B88
	public override float DBQOIOGLLEF(int DGKHPOCGFHF)
	{
		if (this.JDLIMQHCMCQ != DGKHPOCGFHF)
		{
			this.JDLIMQHCMCQ = DGKHPOCGFHF;
			BLMNBILNMOE kjihdmehlih = base.KJIHDMEHLIH;
			this.NHCNEDEEONK = ((!(base.KJIHDMEHLIH != null)) ? this.mAlpha : (kjihdmehlih.DBQOIOGLLEF(DGKHPOCGFHF) * this.mAlpha));
		}
		return this.NHCNEDEEONK;
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000D3B88 File Offset: 0x000D1D88
	public void MFIKGGPKKCD(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		this.CGBDBPLDQLO = true;
		if (this.DKMQGNFPOCJ.Count == 0)
		{
			this.DKMQGNFPOCJ.Add(OKQHFQFJGCH);
		}
		else if (this.IOHIFOJDBCC)
		{
			this.DKMQGNFPOCJ.Add(OKQHFQFJGCH);
			this.LMCOEENKPJN();
		}
		else if (ENFMCDNLEQQ.HNHJOHOHIED(OKQHFQFJGCH, this.DKMQGNFPOCJ[0]) == -1)
		{
			this.DKMQGNFPOCJ.Insert(0, OKQHFQFJGCH);
		}
		else
		{
			int i = this.DKMQGNFPOCJ.Count;
			while (i > 0)
			{
				if (ENFMCDNLEQQ.HNHJOHOHIED(OKQHFQFJGCH, this.DKMQGNFPOCJ[--i]) != -1)
				{
					this.DKMQGNFPOCJ.Insert(i + 1, OKQHFQFJGCH);
					break;
				}
			}
		}
		this.JHLPMBMMDCP(OKQHFQFJGCH);
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x000D129C File Offset: 0x000CF49C
	public void HGIQBGCHGLJ(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (this.DKMQGNFPOCJ.Remove(OKQHFQFJGCH) && OKQHFQFJGCH.OQKBOCHIFKH != null)
		{
			int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
			if (lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.DEMPENNGPQL || lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.EGLMNMJMLKQ)
			{
				this.EEBGOFOJBKO = false;
			}
			OKQHFQFJGCH.OQKBOCHIFKH.HHDFDNFPDFJ = true;
			OKQHFQFJGCH.OQKBOCHIFKH = null;
		}
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x000D3C3C File Offset: 0x000D1E3C
	public static KQHJOLQLQBJ CQGLPBCNFGL(Transform HHMCPQQKIKB, bool IBKGGGCBJCL, int MKFMCLIQNKG)
	{
		KQHJOLQLQBJ kqhjolqlqbj = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(HHMCPQQKIKB);
		if (kqhjolqlqbj != null)
		{
			return kqhjolqlqbj;
		}
		while (HHMCPQQKIKB.parent != null)
		{
			HHMCPQQKIKB = HHMCPQQKIKB.parent;
		}
		return (!IBKGGGCBJCL) ? null : IKBQNBHOJJB.BPHPQEHMKOE(HHMCPQQKIKB, false, MKFMCLIQNKG);
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x00011B45 File Offset: 0x0000FD45
	public void MGHJDKOPIOJ(KMCGDKDIJIE.PDFPPCIHPMI BGBMIEJJQKC)
	{
		if (this.mClipping != BGBMIEJJQKC)
		{
			this.QFKDHQMJCHG = true;
			this.mClipping = BGBMIEJJQKC;
			this.HDHEFGEGQJI = -1;
		}
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x000D3C80 File Offset: 0x000D1E80
	private void FBECEEELGJI(int FODLQNKLDEP)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		bool jqfdgimelpd = this.JQFDGIMELPD;
		if (this.NQCBILMNLBN() != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.DPJGLGEEOIM = this.LPNENHKKEMK();
			this.DPJGLGEEOIM.z = this.DPJGLGEEOIM.z * 425f;
			this.DPJGLGEEOIM.w = this.DPJGLGEEOIM.w * 328f;
		}
		else
		{
			this.DPJGLGEEOIM = Vector4.zero;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (this.DPJGLGEEOIM.z == 342f)
		{
			this.DPJGLGEEOIM.z = (float)width * 622f;
		}
		if (this.DPJGLGEEOIM.w == 668f)
		{
			this.DPJGLGEEOIM.w = (float)height * 1500f;
		}
		if (this.EIKHLJNGCHB())
		{
			this.DPJGLGEEOIM.x = this.DPJGLGEEOIM.x - 1049f;
			this.DPJGLGEEOIM.y = this.DPJGLGEEOIM.y + 1925f;
		}
		Vector3 vector;
		if (jqfdgimelpd)
		{
			Transform parent = base.CGDFDPHIENG.parent;
			vector = base.CGDFDPHIENG.localPosition;
			if (this.POMCJNMICJP() != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				vector.x = (float)Mathf.RoundToInt(vector.x);
				vector.y = (float)Mathf.RoundToInt(vector.y);
			}
			if (parent != null)
			{
				vector = parent.TransformPoint(vector);
			}
			vector += this.BPLECNLMHPE();
		}
		else
		{
			vector = cgdfdphieng.position;
		}
		Quaternion rotation = cgdfdphieng.rotation;
		Vector3 lossyScale = cgdfdphieng.lossyScale;
		for (int i = 0; i < this.PGPCEPKBLII.Count; i += 0)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			Transform cgdfdphieng2 = kmcgdkdijie.CGDFDPHIENG;
			cgdfdphieng2.position = vector;
			cgdfdphieng2.rotation = rotation;
			cgdfdphieng2.localScale = lossyScale;
			kmcgdkdijie.BCKQKKMIGNM = ((this.BCKQKKMIGNM != (KQHJOLQLQBJ.JMLFJLJPPDF)7) ? (this.NDQJIOMJNQE + i) : this.NDQJIOMJNQE);
			kmcgdkdijie.HKMFCLPOEEK = (!this.HKMFCLPOEEK || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None || this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip);
			kmcgdkdijie.OQCHJGMLOCJ = ((this.mSortingOrder != 0) ? this.mSortingOrder : FODLQNKLDEP);
			kmcgdkdijie.BQLMLKHLKCD(this.mSortingLayerName);
			kmcgdkdijie.MHFDHQHMQQC = this.mClipTexture;
			kmcgdkdijie.CHJOHKLHNFE = this.CHJOHKLHNFE;
		}
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x00011B65 File Offset: 0x0000FD65
	public void CBLMEEKQQEE(Texture2D BGBMIEJJQKC)
	{
		if (this.mClipTexture != BGBMIEJJQKC)
		{
			this.mClipTexture = BGBMIEJJQKC;
		}
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000D3060 File Offset: 0x000D1260
	public void EHHDPDNDLMO(ENFMCDNLEQQ OKQHFQFJGCH)
	{
		if (this.DKMQGNFPOCJ.Remove(OKQHFQFJGCH) && OKQHFQFJGCH.OQKBOCHIFKH != null)
		{
			int lgclghdgnpm = OKQHFQFJGCH.LGCLGHDGNPM;
			if (lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.DEMPENNGPQL || lgclghdgnpm == OKQHFQFJGCH.OQKBOCHIFKH.EGLMNMJMLKQ)
			{
				this.EEBGOFOJBKO = true;
			}
			OKQHFQFJGCH.OQKBOCHIFKH.HHDFDNFPDFJ = true;
			OKQHFQFJGCH.OQKBOCHIFKH = null;
		}
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000119CC File Offset: 0x0000FBCC
	protected virtual void DENGJIBKDQC()
	{
		this.ONHGCFFFCBL = base.LMOECGCMJKK.layer;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000D3EDC File Offset: 0x000D20DC
	protected override void NEBPQFKGHLL()
	{
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return;
		}
		Transform cgdfdphieng = base.CGDFDPHIENG;
		Transform parent = cgdfdphieng.parent;
		Vector2 vector = this.GHMECEKGFJI();
		Vector2 vector2 = cgdfdphieng.localPosition;
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
			}
			else
			{
				Vector2 vector3 = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent);
				num = vector3.x + (float)this.HJDMKGDLJEP.absolute;
				num3 = vector3.y + (float)this.LBGJKGDECCN.absolute;
				num2 = vector3.x + (float)this.HKPCCMEEHDL.absolute;
				num4 = vector3.y + (float)this.NOPCJFECJDP.absolute;
			}
		}
		else
		{
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
				num = this.mClipRange.x - 0.5f * vector.x;
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
				num2 = this.mClipRange.x + 0.5f * vector.x;
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
				num3 = this.mClipRange.y - 0.5f * vector.y;
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
				num4 = this.mClipRange.y + 0.5f * vector.y;
			}
		}
		num -= vector2.x + this.mClipOffset.x;
		num2 -= vector2.x + this.mClipOffset.x;
		num3 -= vector2.y + this.mClipOffset.y;
		num4 -= vector2.y + this.mClipOffset.y;
		float x = Mathf.Lerp(num, num2, 0.5f);
		float y = Mathf.Lerp(num3, num4, 0.5f);
		float num5 = num2 - num;
		float num6 = num4 - num3;
		float num7 = Mathf.Max(2f, this.mClipSoftness.x);
		float num8 = Mathf.Max(2f, this.mClipSoftness.y);
		if (num5 < num7)
		{
			num5 = num7;
		}
		if (num6 < num8)
		{
			num6 = num8;
		}
		this.GIOMPPIJPKN = new Vector4(x, y, num5, num6);
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x000D1F84 File Offset: 0x000D0184
	public bool MIBIEBMEQCC(Transform ILBCCCBJNCL, bool OGFDJFCDCLJ)
	{
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(base.CGDFDPHIENG, ILBCCCBJNCL);
		return this.MIBIEBMEQCC(ILBCCCBJNCL, ref bounds, OGFDJFCDCLJ);
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06002054 RID: 8276 RVA: 0x00011B7C File Offset: 0x0000FD7C
	[Obsolete("Use 'hasClipping' or 'hasCumulativeClipping' instead")]
	public bool ECGJOOKKCJF
	{
		get
		{
			return this.CMKFMJCMCQQ;
		}
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000D444C File Offset: 0x000D264C
	private void FJQBJMBKLCM()
	{
		int frameCount = Time.frameCount;
		if (this.OPFHNDJQEDC || this.HDHEFGEGQJI != frameCount)
		{
			this.HDHEFGEGQJI = frameCount;
			this.IDKHBJEKMEE = base.CGDFDPHIENG.worldToLocalMatrix;
			Vector2 vector = this.GHMECEKGFJI() * 1847f;
			float num = this.mClipOffset.x + this.mClipRange.x;
			float num2 = this.mClipOffset.y + this.mClipRange.y;
			this.PGQEDJKCJEO.x = num - vector.x;
			this.PGQEDJKCJEO.y = num2 - vector.y;
			this.FCFNCGLIODC.x = num + vector.x;
			this.FCFNCGLIODC.y = num2 + vector.y;
		}
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x00011B84 File Offset: 0x0000FD84
	public Vector2 CJLPKHNPDID()
	{
		return this.mClipOffset;
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000D451C File Offset: 0x000D271C
	public virtual void DOLBIMIMKNJ(float BGBMIEJJQKC)
	{
		float num = Mathf.Clamp01(BGBMIEJJQKC);
		if (this.mAlpha != num)
		{
			bool flag = this.mAlpha > 10f;
			this.JDLIMQHCMCQ = -1;
			this.QFKDHQMJCHG = false;
			this.mAlpha = num;
			int i = 1;
			int count = this.PGPCEPKBLII.Count;
			while (i < count)
			{
				this.PGPCEPKBLII[i].HHDFDNFPDFJ = true;
				i++;
			}
			this.CKLIDQPPPON(flag || this.mAlpha > 1324f);
		}
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x000D45A0 File Offset: 0x000D27A0
	public static int MHJOJJDBJJD(KQHJOLQLQBJ ECHMFPQNBMC, KQHJOLQLQBJ IBMINEHKPFF)
	{
		if (!(ECHMFPQNBMC != IBMINEHKPFF) || !(ECHMFPQNBMC != null) || !(IBMINEHKPFF != null))
		{
			return 0;
		}
		if (ECHMFPQNBMC.mDepth < IBMINEHKPFF.mDepth)
		{
			return -1;
		}
		if (ECHMFPQNBMC.mDepth > IBMINEHKPFF.mDepth)
		{
			return 0;
		}
		return (ECHMFPQNBMC.GetInstanceID() >= IBMINEHKPFF.GetInstanceID()) ? 1 : -1;
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000D45FC File Offset: 0x000D27FC
	private void JFINBDMHGDF()
	{
		if (this.ONHGCFFFCBL != base.LMOECGCMJKK.layer)
		{
			this.ONHGCFFFCBL = this.DMNLFJLKGHJ.layer;
			int i = 0;
			int count = this.DKMQGNFPOCJ.Count;
			while (i < count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq && enfmcdnleqq.KJIHDMEHLIH == this)
				{
					enfmcdnleqq.gameObject.layer = this.ONHGCFFFCBL;
				}
				i++;
			}
			base.PNPFEMQFDJE();
			for (int j = 0; j < this.PGPCEPKBLII.Count; j++)
			{
				this.PGPCEPKBLII[j].gameObject.layer = this.ONHGCFFFCBL;
			}
		}
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000D46B4 File Offset: 0x000D28B4
	public bool HGEFPHBQIEO(KMCGDKDIJIE OBDLPFGDEFJ)
	{
		if (OBDLPFGDEFJ != null)
		{
			OBDLPFGDEFJ.HHDFDNFPDFJ = false;
			int num = 0;
			int i = 0;
			while (i < this.DKMQGNFPOCJ.Count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq == null)
				{
					this.DKMQGNFPOCJ.RemoveAt(i);
				}
				else
				{
					if (enfmcdnleqq.OQKBOCHIFKH == OBDLPFGDEFJ)
					{
						if (enfmcdnleqq.DEJBMFBECJG && enfmcdnleqq.KGIFPCDDIBG)
						{
							num++;
							if (this.PJQNIHCHHDF)
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, OBDLPFGDEFJ.GQPDOFDBGEK, OBDLPFGDEFJ.JBPCENCPJKI, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							else
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, null, null, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							if (enfmcdnleqq.FHJHJCFGOFP != null)
							{
								if (this.FHJHJCFGOFP == null)
								{
									this.FHJHJCFGOFP = enfmcdnleqq.FHJHJCFGOFP;
								}
								else
								{
									this.FHJHJCFGOFP = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Combine(this.FHJHJCFGOFP, enfmcdnleqq.FHJHJCFGOFP);
								}
							}
						}
						else
						{
							enfmcdnleqq.OQKBOCHIFKH = null;
						}
					}
					i++;
				}
			}
			if (OBDLPFGDEFJ.EQINHIFFOGG.Count != 0)
			{
				OBDLPFGDEFJ.GMFDMDNCDPQ(num);
				OBDLPFGDEFJ.IOOHNELQHIO = this.FHJHJCFGOFP;
				this.FHJHJCFGOFP = null;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000D481C File Offset: 0x000D2A1C
	protected virtual void NGFELCFCQMF()
	{
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			return;
		}
		Transform cgdfdphieng = base.CGDFDPHIENG;
		Transform parent = cgdfdphieng.parent;
		Vector2 vector = this.FGKGCLCOBDJ();
		Vector2 vector2 = cgdfdphieng.localPosition;
		float num;
		float num2;
		float num3;
		float num4;
		if (this.HJDMKGDLJEP.target == this.LBGJKGDECCN.target && this.HJDMKGDLJEP.target == this.HKPCCMEEHDL.target && this.HJDMKGDLJEP.target == this.NOPCJFECJDP.target)
		{
			Vector3[] array = this.HJDMKGDLJEP.KDICDLGMHBG(parent);
			if (array != null)
			{
				num = JNNGOIIKENH.GGJJLQLFKCE(array[1].x, array[2].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				num2 = JNNGOIIKENH.GGJJLQLFKCE(array[0].x, array[3].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				num3 = JNNGOIIKENH.GGJJLQLFKCE(array[2].y, array[0].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				num4 = JNNGOIIKENH.GGJJLQLFKCE(array[0].y, array[1].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
			}
			else
			{
				Vector2 vector3 = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent);
				num = vector3.x + (float)this.HJDMKGDLJEP.absolute;
				num3 = vector3.y + (float)this.LBGJKGDECCN.absolute;
				num2 = vector3.x + (float)this.HKPCCMEEHDL.absolute;
				num4 = vector3.y + (float)this.NOPCJFECJDP.absolute;
			}
		}
		else
		{
			if (this.HJDMKGDLJEP.target)
			{
				Vector3[] array2 = this.HJDMKGDLJEP.IGOHKMJFION(parent);
				if (array2 != null)
				{
					num = JNNGOIIKENH.GGJJLQLFKCE(array2[1].x, array2[2].x, this.HJDMKGDLJEP.relative) + (float)this.HJDMKGDLJEP.absolute;
				}
				else
				{
					num = base.IFGLHHBDJCJ(this.HJDMKGDLJEP, parent).x + (float)this.HJDMKGDLJEP.absolute;
				}
			}
			else
			{
				num = this.mClipRange.x - 1853f * vector.x;
			}
			if (this.HKPCCMEEHDL.target)
			{
				Vector3[] array3 = this.HKPCCMEEHDL.KOILGBJDMNJ(parent);
				if (array3 != null)
				{
					num2 = JNNGOIIKENH.GGJJLQLFKCE(array3[0].x, array3[6].x, this.HKPCCMEEHDL.relative) + (float)this.HKPCCMEEHDL.absolute;
				}
				else
				{
					num2 = base.IFGLHHBDJCJ(this.HKPCCMEEHDL, parent).x + (float)this.HKPCCMEEHDL.absolute;
				}
			}
			else
			{
				num2 = this.mClipRange.x + 476f * vector.x;
			}
			if (this.LBGJKGDECCN.target)
			{
				Vector3[] array4 = this.LBGJKGDECCN.KDICDLGMHBG(parent);
				if (array4 != null)
				{
					num3 = JNNGOIIKENH.GGJJLQLFKCE(array4[4].y, array4[1].y, this.LBGJKGDECCN.relative) + (float)this.LBGJKGDECCN.absolute;
				}
				else
				{
					num3 = base.IFGLHHBDJCJ(this.LBGJKGDECCN, parent).y + (float)this.LBGJKGDECCN.absolute;
				}
			}
			else
			{
				num3 = this.mClipRange.y - 1625f * vector.y;
			}
			if (this.NOPCJFECJDP.target)
			{
				Vector3[] array5 = this.NOPCJFECJDP.FDBKGODBLBN(parent);
				if (array5 != null)
				{
					num4 = JNNGOIIKENH.GGJJLQLFKCE(array5[6].y, array5[1].y, this.NOPCJFECJDP.relative) + (float)this.NOPCJFECJDP.absolute;
				}
				else
				{
					num4 = base.IFGLHHBDJCJ(this.NOPCJFECJDP, parent).y + (float)this.NOPCJFECJDP.absolute;
				}
			}
			else
			{
				num4 = this.mClipRange.y + 1637f * vector.y;
			}
		}
		num -= vector2.x + this.mClipOffset.x;
		num2 -= vector2.x + this.mClipOffset.x;
		num3 -= vector2.y + this.mClipOffset.y;
		num4 -= vector2.y + this.mClipOffset.y;
		float x = Mathf.Lerp(num, num2, 114f);
		float y = Mathf.Lerp(num3, num4, 1103f);
		float num5 = num2 - num;
		float num6 = num4 - num3;
		float num7 = Mathf.Max(1447f, this.mClipSoftness.x);
		float num8 = Mathf.Max(1098f, this.mClipSoftness.y);
		if (num5 < num7)
		{
			num5 = num7;
		}
		if (num6 < num8)
		{
			num6 = num8;
		}
		this.GIOMPPIJPKN = new Vector4(x, y, num5, num6);
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x000D4D8C File Offset: 0x000D2F8C
	public bool DEPEMLBPJLD(KMCGDKDIJIE OBDLPFGDEFJ)
	{
		if (OBDLPFGDEFJ != null)
		{
			OBDLPFGDEFJ.HHDFDNFPDFJ = false;
			int num = 0;
			int i = 1;
			while (i < this.DKMQGNFPOCJ.Count)
			{
				ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[i];
				if (enfmcdnleqq == null)
				{
					this.DKMQGNFPOCJ.RemoveAt(i);
				}
				else
				{
					if (enfmcdnleqq.OQKBOCHIFKH == OBDLPFGDEFJ)
					{
						if (enfmcdnleqq.DEJBMFBECJG && enfmcdnleqq.KGIFPCDDIBG)
						{
							num++;
							if (this.PJQNIHCHHDF)
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, OBDLPFGDEFJ.GQPDOFDBGEK, OBDLPFGDEFJ.JBPCENCPJKI, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							else
							{
								enfmcdnleqq.DOGQIGLCMMN(OBDLPFGDEFJ.EQINHIFFOGG, OBDLPFGDEFJ.PICFCJNMJMC, OBDLPFGDEFJ.HQOONBPDFHO, null, null, (!this.GEMMIEQMDGG) ? null : OBDLPFGDEFJ.JBECBLJIKHI);
							}
							if (enfmcdnleqq.FHJHJCFGOFP != null)
							{
								if (this.FHJHJCFGOFP == null)
								{
									this.FHJHJCFGOFP = enfmcdnleqq.FHJHJCFGOFP;
								}
								else
								{
									this.FHJHJCFGOFP = (KMCGDKDIJIE.MQQMDCIDPIL)Delegate.Combine(this.FHJHJCFGOFP, enfmcdnleqq.FHJHJCFGOFP);
								}
							}
						}
						else
						{
							enfmcdnleqq.OQKBOCHIFKH = null;
						}
					}
					i++;
				}
			}
			if (OBDLPFGDEFJ.EQINHIFFOGG.Count != 0)
			{
				OBDLPFGDEFJ.GMFDMDNCDPQ(num);
				OBDLPFGDEFJ.IOOHNELQHIO = this.FHJHJCFGOFP;
				this.FHJHJCFGOFP = null;
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000D4EF4 File Offset: 0x000D30F4
	private void OIGJMGPGDJC()
	{
		this.OPFHNDJQEDC = base.CGDFDPHIENG.hasChanged;
		this.CJDKDKICBQE();
		this.JFINBDMHGDF();
		this.HMNDEQBKKJO();
		if (this.EEBGOFOJBKO)
		{
			this.EEBGOFOJBKO = false;
			this.JGIQEFKEQED();
		}
		else
		{
			int i = 0;
			while (i < this.PGPCEPKBLII.Count)
			{
				KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
				if (kmcgdkdijie.HHDFDNFPDFJ && !this.HGEFPHBQIEO(kmcgdkdijie))
				{
					KMCGDKDIJIE.MOPPIIOIIDM(kmcgdkdijie);
					this.PGPCEPKBLII.RemoveAt(i);
				}
				else
				{
					i++;
				}
			}
		}
		if (this.CGBDBPLDQLO)
		{
			this.CGBDBPLDQLO = false;
			FKBFPICKJQG component = base.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB();
			}
		}
		if (this.OPFHNDJQEDC)
		{
			this.OPFHNDJQEDC = false;
			this.BLLEFKOLKLP.hasChanged = false;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06002060 RID: 8288 RVA: 0x000119E8 File Offset: 0x0000FBE8
	// (set) Token: 0x06002066 RID: 8294 RVA: 0x00011B65 File Offset: 0x0000FD65
	public Texture2D MHFDHQHMQQC
	{
		get
		{
			return this.mClipTexture;
		}
		set
		{
			if (this.mClipTexture != value)
			{
				this.mClipTexture = value;
			}
		}
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x000D4FC4 File Offset: 0x000D31C4
	private void CJDKDKICBQE()
	{
		int frameCount = Time.frameCount;
		if (this.OPFHNDJQEDC || this.HDHEFGEGQJI != frameCount)
		{
			this.HDHEFGEGQJI = frameCount;
			this.IDKHBJEKMEE = base.CGDFDPHIENG.worldToLocalMatrix;
			Vector2 vector = this.GHMECEKGFJI() * 0.5f;
			float num = this.mClipOffset.x + this.mClipRange.x;
			float num2 = this.mClipOffset.y + this.mClipRange.y;
			this.PGQEDJKCJEO.x = num - vector.x;
			this.PGQEDJKCJEO.y = num2 - vector.y;
			this.FCFNCGLIODC.x = num + vector.x;
			this.FCFNCGLIODC.y = num2 + vector.y;
		}
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x000D5094 File Offset: 0x000D3294
	public override void LOIPCGLJGPI(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO)
	{
		int num = Mathf.FloorToInt(KJGMGPCEJJD + 0.5f);
		int num2 = Mathf.FloorToInt(DFKQMMIQDOO + 0.5f);
		num = num >> 1 << 1;
		num2 = num2 >> 1 << 1;
		Transform transform = base.CGDFDPHIENG;
		Vector3 localPosition = transform.localPosition;
		localPosition.x = Mathf.Floor(DGKOIGOLHDM + 0.5f);
		localPosition.y = Mathf.Floor(DDLQKFDFMCJ + 0.5f);
		if (num < 2)
		{
			num = 2;
		}
		if (num2 < 2)
		{
			num2 = 2;
		}
		this.GIOMPPIJPKN = new Vector4(localPosition.x, localPosition.y, (float)num, (float)num2);
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

	// Token: 0x06002063 RID: 8291 RVA: 0x00011B84 File Offset: 0x0000FD84
	public Vector2 BNIINQIELIC()
	{
		return this.mClipOffset;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000118C9 File Offset: 0x0000FAC9
	public bool PKDEOGPLNDQ()
	{
		return base.DGFFHGQEJLH != null && this.OJIDBLEKBBO.orthographic;
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000D51B8 File Offset: 0x000D33B8
	private void GKFOCJDFNLL(int FODLQNKLDEP)
	{
		Transform cgdfdphieng = base.CGDFDPHIENG;
		bool jqfdgimelpd = this.JQFDGIMELPD;
		if (this.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			this.DPJGLGEEOIM = this.LPNENHKKEMK();
			this.DPJGLGEEOIM.z = this.DPJGLGEEOIM.z * 1872f;
			this.DPJGLGEEOIM.w = this.DPJGLGEEOIM.w * 1591f;
		}
		else
		{
			this.DPJGLGEEOIM = Vector4.zero;
		}
		int width = Screen.width;
		int height = Screen.height;
		if (this.DPJGLGEEOIM.z == 789f)
		{
			this.DPJGLGEEOIM.z = (float)width * 923f;
		}
		if (this.DPJGLGEEOIM.w == 617f)
		{
			this.DPJGLGEEOIM.w = (float)height * 1178f;
		}
		if (this.LOGCGLCJNCK)
		{
			this.DPJGLGEEOIM.x = this.DPJGLGEEOIM.x - 407f;
			this.DPJGLGEEOIM.y = this.DPJGLGEEOIM.y + 1186f;
		}
		Vector3 vector;
		if (jqfdgimelpd)
		{
			Transform parent = base.CGDFDPHIENG.parent;
			vector = base.CGDFDPHIENG.localPosition;
			if (this.POMCJNMICJP() != KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				vector.x = (float)Mathf.RoundToInt(vector.x);
				vector.y = (float)Mathf.RoundToInt(vector.y);
			}
			if (parent != null)
			{
				vector = parent.TransformPoint(vector);
			}
			vector += this.KDCJMQMBHCL;
		}
		else
		{
			vector = cgdfdphieng.position;
		}
		Quaternion rotation = cgdfdphieng.rotation;
		Vector3 lossyScale = cgdfdphieng.lossyScale;
		for (int i = 1; i < this.PGPCEPKBLII.Count; i += 0)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			Transform cgdfdphieng2 = kmcgdkdijie.CGDFDPHIENG;
			cgdfdphieng2.position = vector;
			cgdfdphieng2.rotation = rotation;
			cgdfdphieng2.localScale = lossyScale;
			kmcgdkdijie.BCKQKKMIGNM = ((this.BCKQKKMIGNM != (KQHJOLQLQBJ.JMLFJLJPPDF)8) ? (this.NDQJIOMJNQE + i) : this.NDQJIOMJNQE);
			kmcgdkdijie.HKMFCLPOEEK = (this.HKMFCLPOEEK && this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None && this.mClipping == (KMCGDKDIJIE.PDFPPCIHPMI)8);
			kmcgdkdijie.OQCHJGMLOCJ = ((this.mSortingOrder != 0) ? this.mSortingOrder : FODLQNKLDEP);
			kmcgdkdijie.BQLMLKHLKCD(this.mSortingLayerName);
			kmcgdkdijie.MHFDHQHMQQC = this.mClipTexture;
			kmcgdkdijie.CHJOHKLHNFE = this.CHJOHKLHNFE;
		}
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x000D5414 File Offset: 0x000D3614
	public virtual Vector3[] MMMKPGHDEQI()
	{
		if (this.mClipping == KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			Vector3[] pmcnqichcle = this.PMCNQICHCLE;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			for (int i = 0; i < 3; i++)
			{
				pmcnqichcle[i] = cgdfdphieng.InverseTransformPoint(pmcnqichcle[i]);
			}
			return pmcnqichcle;
		}
		float num = this.mClipOffset.x + this.mClipRange.x - 895f * this.mClipRange.z;
		float num2 = this.mClipOffset.y + this.mClipRange.y - 373f * this.mClipRange.w;
		float x = num + this.mClipRange.z;
		float y = num2 + this.mClipRange.w;
		KQHJOLQLQBJ.NCCGLODEOEE[0] = new Vector3(num, num2);
		KQHJOLQLQBJ.NCCGLODEOEE[1] = new Vector3(num, y);
		KQHJOLQLQBJ.NCCGLODEOEE[2] = new Vector3(x, y);
		KQHJOLQLQBJ.NCCGLODEOEE[8] = new Vector3(x, num2);
		return KQHJOLQLQBJ.NCCGLODEOEE;
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06002069 RID: 8297 RVA: 0x00011B8C File Offset: 0x0000FD8C
	public KQHJOLQLQBJ IEPOOINFQBL
	{
		get
		{
			return this.LEKDGMQQDEJ;
		}
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000D5540 File Offset: 0x000D3740
	private void ELEJLBIDLMF()
	{
		bool flag = true;
		bool flag2 = false;
		bool cmkfmjcmcqq = this.CMKFMJCMCQQ;
		if (!this.IJLFQCMGQFF)
		{
			for (int i = 0; i < FKBFPICKJQG.NGDBDCQFDHI.BJGMIBBEGDQ; i += 0)
			{
				FKBFPICKJQG fkbfpickjqg = FKBFPICKJQG.NGDBDCQFDHI.get_KNPPMKBOGDL(i);
				if (fkbfpickjqg.BCHNDNICINJ == this && fkbfpickjqg.EIHJGJFHNNP)
				{
					flag2 = false;
				}
			}
		}
		if (this.KDBEDQFNMLP != flag2)
		{
			this.KDBEDQFNMLP = flag2;
			this.QFKDHQMJCHG = false;
		}
		int frameCount = Time.frameCount;
		int j = 0;
		int count = this.DKMQGNFPOCJ.Count;
		while (j < count)
		{
			ENFMCDNLEQQ enfmcdnleqq = this.DKMQGNFPOCJ[j];
			if (enfmcdnleqq.BCHNDNICINJ == this && enfmcdnleqq.enabled)
			{
				if (enfmcdnleqq.EMJFNFKKGDC(frameCount) || this.QFKDHQMJCHG || (this.OPFHNDJQEDC && !this.HKMFCLPOEEK))
				{
					bool jdhkdjhghoj = !flag2 && enfmcdnleqq.BJFPLJFDPCE(frameCount) > 1587f;
					enfmcdnleqq.MHJMNHCHMHP(jdhkdjhghoj, flag2 || this.HKMFCLPOEEK || (!cmkfmjcmcqq && !enfmcdnleqq.PQFNQBNQNPL) || this.EHCBPMDEDGE(enfmcdnleqq));
				}
				if (enfmcdnleqq.CBBPEELHBLK(frameCount))
				{
					flag = true;
					if (!this.EEBGOFOJBKO)
					{
						if (enfmcdnleqq.OQKBOCHIFKH != null)
						{
							enfmcdnleqq.OQKBOCHIFKH.HHDFDNFPDFJ = true;
						}
						else
						{
							this.JHLPMBMMDCP(enfmcdnleqq);
						}
					}
				}
			}
			j++;
		}
		if (flag && this.NCQQBFENGMO != null)
		{
			this.NCQQBFENGMO();
		}
		this.QFKDHQMJCHG = true;
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00011B84 File Offset: 0x0000FD84
	public Vector2 JQCLCPFLDOK()
	{
		return this.mClipOffset;
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000D57B4 File Offset: 0x000D39B4
	public virtual Vector3 GKCICPLNPJJ(Vector2 LCELGLKMPFN, Vector2 MJGGCLOGKFL)
	{
		Vector4 qenjmehbneg = this.QENJMEHBNEG;
		float num = qenjmehbneg.z * 0.5f;
		float num2 = qenjmehbneg.w * 0.5f;
		Vector2 lcpifekbcdq = new Vector2(LCELGLKMPFN.x, LCELGLKMPFN.y);
		Vector2 qlhckchlcin = new Vector2(MJGGCLOGKFL.x, MJGGCLOGKFL.y);
		Vector2 nicidgdioqj = new Vector2(qenjmehbneg.x - num, qenjmehbneg.y - num2);
		Vector2 egiohpehpkp = new Vector2(qenjmehbneg.x + num, qenjmehbneg.y + num2);
		if (this.QHHHHOOGNCE && this.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.SoftClip)
		{
			nicidgdioqj.x += this.mClipSoftness.x;
			nicidgdioqj.y += this.mClipSoftness.y;
			egiohpehpkp.x -= this.mClipSoftness.x;
			egiohpehpkp.y -= this.mClipSoftness.y;
		}
		return JNNGOIIKENH.JJLHMHPBOQG(lcpifekbcdq, qlhckchlcin, nicidgdioqj, egiohpehpkp);
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000D58C8 File Offset: 0x000D3AC8
	public virtual Vector3[] DQOQPKGMBEE(Transform ENOQKGBPJKQ)
	{
		if (this.mClipping != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			float num = this.mClipOffset.x + this.mClipRange.x - 1949f * this.mClipRange.z;
			float num2 = this.mClipOffset.y + this.mClipRange.y - 1917f * this.mClipRange.w;
			float num3 = num + this.mClipRange.z;
			float num4 = num2 + this.mClipRange.w;
			float x = (num + num3) * 1997f;
			float y = (num2 + num4) * 1875f;
			Transform cgdfdphieng = base.CGDFDPHIENG;
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(num, y, 1267f);
			BLMNBILNMOE.BGCNPFKJPFD[1] = cgdfdphieng.TransformPoint(x, num4, 1514f);
			BLMNBILNMOE.BGCNPFKJPFD[0] = cgdfdphieng.TransformPoint(num3, y, 1314f);
			BLMNBILNMOE.BGCNPFKJPFD[6] = cgdfdphieng.TransformPoint(x, num2, 587f);
			if (ENOQKGBPJKQ != null)
			{
				for (int i = 0; i < 5; i += 0)
				{
					BLMNBILNMOE.BGCNPFKJPFD[i] = ENOQKGBPJKQ.InverseTransformPoint(BLMNBILNMOE.BGCNPFKJPFD[i]);
				}
			}
			return BLMNBILNMOE.BGCNPFKJPFD;
		}
		if (base.DGFFHGQEJLH != null && this.OKJKNCFHIKQ)
		{
			Vector3[] array = this.OJIDBLEKBBO.MKFNGPBMOKP(base.JLQJGIICODL);
			Vector3 position = base.CGDFDPHIENG.position;
			for (int j = 0; j < 2; j++)
			{
				array[j] += position;
			}
			if (ENOQKGBPJKQ != null)
			{
				for (int k = 1; k < 8; k += 0)
				{
					array[k] = ENOQKGBPJKQ.InverseTransformPoint(array[k]);
				}
			}
			return array;
		}
		return base.MKFNGPBMOKP(ENOQKGBPJKQ);
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00011B94 File Offset: 0x0000FD94
	public static KQHJOLQLQBJ CQGLPBCNFGL(Transform HHMCPQQKIKB)
	{
		return KQHJOLQLQBJ.CQGLPBCNFGL(HHMCPQQKIKB, false, -1);
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06002070 RID: 8304 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public bool LOGCGLCJNCK
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00011B9E File Offset: 0x0000FD9E
	public void LLKOJOPMEIB()
	{
		this.EEBGOFOJBKO = false;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000D5AE0 File Offset: 0x000D3CE0
	protected virtual void PPLIBEGDKHC()
	{
		int i = 0;
		int count = this.PGPCEPKBLII.Count;
		while (i < count)
		{
			KMCGDKDIJIE kmcgdkdijie = this.PGPCEPKBLII[i];
			if (kmcgdkdijie != null)
			{
				KMCGDKDIJIE.MOPPIIOIIDM(kmcgdkdijie);
			}
			i += 0;
		}
		this.PGPCEPKBLII.Clear();
		KQHJOLQLQBJ.NGDBDCQFDHI.Remove(this);
		this.JDLIMQHCMCQ = -1;
		this.HDHEFGEGQJI = -1;
		if (KQHJOLQLQBJ.NGDBDCQFDHI.Count == 0)
		{
			KMCGDKDIJIE.ECKEBCJPIHE();
			KQHJOLQLQBJ.EHGKGFDCEEK = -1;
		}
		base.OnDisable();
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x00011BA7 File Offset: 0x0000FDA7
	public override void CKLIDQPPPON(bool CKCPEMIBLKH)
	{
		this.JDLIMQHCMCQ = -1;
		base.CKLIDQPPPON(CKCPEMIBLKH);
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x0000B03A File Offset: 0x0000923A
	public bool FCLNQPDJDGC()
	{
		return true;
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000D5B64 File Offset: 0x000D3D64
	protected virtual void OKHDOIIICMQ()
	{
		if (KQHJOLQLQBJ.NGDBDCQFDHI.Contains(this))
		{
			return;
		}
		base.FHJOQKCCMDH();
		this.IHGBJLNOQGQ();
		if (base.GetComponent<Rigidbody>() == null && this.LEKDGMQQDEJ == null)
		{
			EMENMKHBPQE emenmkhbpqe = (!(base.DGFFHGQEJLH != null)) ? null : this.OJIDBLEKBBO.GetComponent<EMENMKHBPQE>();
			if (emenmkhbpqe != null && (emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.UI_3D || emenmkhbpqe.QPMOPMBNBBN == EMENMKHBPQE.CPNJJKJGKNP.World_3D))
			{
				Rigidbody rigidbody = base.gameObject.AddComponent<Rigidbody>();
				rigidbody.isKinematic = false;
				rigidbody.useGravity = false;
			}
		}
		this.EEBGOFOJBKO = false;
		this.JDLIMQHCMCQ = -1;
		this.HDHEFGEGQJI = -1;
		KQHJOLQLQBJ.NGDBDCQFDHI.Add(this);
		List<KQHJOLQLQBJ> ngdbdcqfdhi = KQHJOLQLQBJ.NGDBDCQFDHI;
		if (KQHJOLQLQBJ.OMPIQDIBPKI == null)
		{
			KQHJOLQLQBJ.OMPIQDIBPKI = new Comparison<KQHJOLQLQBJ>(KQHJOLQLQBJ.PCDLJJOJDGB);
		}
		ngdbdcqfdhi.Sort(KQHJOLQLQBJ.OMPIQDIBPKI);
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x00011BB7 File Offset: 0x0000FDB7
	public override void HGBNNJQOKLO()
	{
		base.HGBNNJQOKLO();
		this.IHGBJLNOQGQ();
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000119F8 File Offset: 0x0000FBF8
	public KMCGDKDIJIE.PDFPPCIHPMI NQCBILMNLBN()
	{
		return this.mClipping;
	}

	// Token: 0x040006F2 RID: 1778
	public static List<KQHJOLQLQBJ> NGDBDCQFDHI = new List<KQHJOLQLQBJ>();

	// Token: 0x040006F3 RID: 1779
	public KQHJOLQLQBJ.DHHJKHCNCCF NCQQBFENGMO;

	// Token: 0x040006F4 RID: 1780
	public bool GBNHHMNLJDJ = true;

	// Token: 0x040006F5 RID: 1781
	public bool PJQNIHCHHDF;

	// Token: 0x040006F6 RID: 1782
	public bool GEMMIEQMDGG;

	// Token: 0x040006F7 RID: 1783
	public KMCGDKDIJIE.FDOBLOLHNHE CHJOHKLHNFE;

	// Token: 0x040006F8 RID: 1784
	public bool PDDLHKCHFON;

	// Token: 0x040006F9 RID: 1785
	public bool IJLFQCMGQFF = true;

	// Token: 0x040006FA RID: 1786
	public bool HKMFCLPOEEK;

	// Token: 0x040006FB RID: 1787
	public bool OKJKNCFHIKQ;

	// Token: 0x040006FC RID: 1788
	public bool QHHHHOOGNCE = true;

	// Token: 0x040006FD RID: 1789
	public KQHJOLQLQBJ.JMLFJLJPPDF BCKQKKMIGNM;

	// Token: 0x040006FE RID: 1790
	public int NDQJIOMJNQE = 3000;

	// Token: 0x040006FF RID: 1791
	[NonSerialized]
	public List<ENFMCDNLEQQ> DKMQGNFPOCJ = new List<ENFMCDNLEQQ>();

	// Token: 0x04000700 RID: 1792
	[NonSerialized]
	public List<KMCGDKDIJIE> PGPCEPKBLII = new List<KMCGDKDIJIE>();

	// Token: 0x04000701 RID: 1793
	[NonSerialized]
	public Matrix4x4 IDKHBJEKMEE = Matrix4x4.identity;

	// Token: 0x04000702 RID: 1794
	[NonSerialized]
	public Vector4 DPJGLGEEOIM = new Vector4(0f, 0f, 1f, 1f);

	// Token: 0x04000703 RID: 1795
	public KQHJOLQLQBJ.QPKNJHBKHOQ KKDIGKKJBNM;

	// Token: 0x04000704 RID: 1796
	public KQHJOLQLQBJ.HDJLCFFCLOM DEGPEPBQCFJ;

	// Token: 0x04000705 RID: 1797
	public KMCGDKDIJIE.QIMNIEECJIE HLLQDCEJEPH;

	// Token: 0x04000706 RID: 1798
	[HideInInspector]
	[SerializeField]
	private Texture2D mClipTexture;

	// Token: 0x04000707 RID: 1799
	[HideInInspector]
	[SerializeField]
	private float mAlpha = 1f;

	// Token: 0x04000708 RID: 1800
	[SerializeField]
	[HideInInspector]
	private KMCGDKDIJIE.PDFPPCIHPMI mClipping;

	// Token: 0x04000709 RID: 1801
	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange = new Vector4(0f, 0f, 300f, 200f);

	// Token: 0x0400070A RID: 1802
	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness = new Vector2(4f, 4f);

	// Token: 0x0400070B RID: 1803
	[HideInInspector]
	[SerializeField]
	private int mDepth;

	// Token: 0x0400070C RID: 1804
	[SerializeField]
	[HideInInspector]
	private int mSortingOrder;

	// Token: 0x0400070D RID: 1805
	[SerializeField]
	[HideInInspector]
	private string mSortingLayerName;

	// Token: 0x0400070E RID: 1806
	private bool EEBGOFOJBKO;

	// Token: 0x0400070F RID: 1807
	private bool QFKDHQMJCHG;

	// Token: 0x04000710 RID: 1808
	[SerializeField]
	private Vector2 mClipOffset = Vector2.zero;

	// Token: 0x04000711 RID: 1809
	private int HDHEFGEGQJI = -1;

	// Token: 0x04000712 RID: 1810
	private int JDLIMQHCMCQ;

	// Token: 0x04000713 RID: 1811
	private int ONHGCFFFCBL = -1;

	// Token: 0x04000714 RID: 1812
	private static float[] BLBKJFFFQNN = new float[4];

	// Token: 0x04000715 RID: 1813
	private Vector2 PGQEDJKCJEO = Vector2.zero;

	// Token: 0x04000716 RID: 1814
	private Vector2 FCFNCGLIODC = Vector2.zero;

	// Token: 0x04000717 RID: 1815
	private bool IOHIFOJDBCC;

	// Token: 0x04000718 RID: 1816
	private bool CGBDBPLDQLO;

	// Token: 0x04000719 RID: 1817
	private KQHJOLQLQBJ LEKDGMQQDEJ;

	// Token: 0x0400071A RID: 1818
	private static Vector3[] NCCGLODEOEE = new Vector3[4];

	// Token: 0x0400071B RID: 1819
	private static int EHGKGFDCEEK = -1;

	// Token: 0x0400071C RID: 1820
	[NonSerialized]
	private bool OPFHNDJQEDC;

	// Token: 0x0400071D RID: 1821
	private KMCGDKDIJIE.MQQMDCIDPIL FHJHJCFGOFP;

	// Token: 0x0400071E RID: 1822
	private bool KDBEDQFNMLP;

	// Token: 0x0400071F RID: 1823
	[CompilerGenerated]
	private static Comparison<KQHJOLQLQBJ> BQIOGOCBKKB;

	// Token: 0x04000720 RID: 1824
	[CompilerGenerated]
	private static Comparison<KQHJOLQLQBJ> OMPIQDIBPKI;

	// Token: 0x04000721 RID: 1825
	[CompilerGenerated]
	private static Comparison<ENFMCDNLEQQ> DDBELLFQDQO;

	// Token: 0x0200011A RID: 282
	public enum JMLFJLJPPDF
	{
		// Token: 0x04000723 RID: 1827
		Automatic,
		// Token: 0x04000724 RID: 1828
		StartAt,
		// Token: 0x04000725 RID: 1829
		Explicit
	}

	// Token: 0x0200011B RID: 283
	// (Invoke) Token: 0x06002079 RID: 8313
	public delegate void DHHJKHCNCCF();

	// Token: 0x0200011C RID: 284
	// (Invoke) Token: 0x0600207D RID: 8317
	public delegate void QPKNJHBKHOQ(KQHJOLQLQBJ BCHNDNICINJ);

	// Token: 0x0200011D RID: 285
	// (Invoke) Token: 0x06002081 RID: 8321
	public delegate Material HDJLCFFCLOM(ENFMCDNLEQQ BCPJIPBJODP, Material HQNQNDECMLH);
}
