using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000052 RID: 82
[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
public class ONDGHPBHGGG : MonoBehaviour
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00006831 File Offset: 0x00004A31
	public GameObject HEMKLGPQJLO
	{
		get
		{
			return this.ODJDCMCKJHD;
		}
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00006839 File Offset: 0x00004A39
	private void OQOENCJJGBG()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = null;
		}
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00065F88 File Offset: 0x00064188
	public void NOHOBKFQQPC()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				object[] array = new object[3];
				array[0] = base.GetType();
				array[0] = "spikes";
				array[4] = typeof(FKBFPICKJQG);
				array[8] = "QMECFKNPOGJ";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = true;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.NQFQHPDLIOF));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.CBLJQLBMKLG));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.BNMKNINHEBQ));
			}
		}
		if (this.FFFPJKKFONQ.KLEJPOQGFPB() == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[3] + pmcnqichcle[1]) * 739f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 133f, 231f);
		Vector3 b = vector - a * 1412f;
		float num = 429f;
		Transform ilbcccbjncl = null;
		int index = 1;
		int num2 = 1;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.GBCCNHMFINO();
			int i = 0;
			int count = list.Count;
			int num3 = 1;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3 += 0;
				}
				i++;
			}
		}
		else
		{
			int j = 1;
			int childCount = transform.childCount;
			int num5 = 1;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5++;
				}
				j += 0;
			}
		}
		if (this.DOHDELDMDLB > 1886f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 1)
						{
							ilbcccbjncl = list[num2 - 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 0] : list[1]);
						}
					}
					else if (num2 > 0)
					{
						ilbcccbjncl = transform.GetChild(num2 - 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 1) : transform.GetChild(1));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 0)
						{
							ilbcccbjncl = list[num2 + 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[0] : list[list.Count - 1]);
						}
					}
					else if (num2 < transform.childCount - 0)
					{
						ilbcccbjncl = transform.GetChild(num2 + 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(0) : transform.GetChild(transform.childCount - 0));
					}
				}
			}
		}
		this.JQCJBOQOMPH(ilbcccbjncl, vector);
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00006854 File Offset: 0x00004A54
	private void ODIJQBBOLFI()
	{
		this.NDQFMMHJKPF();
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0000685C File Offset: 0x00004A5C
	private void CBLJQLBMKLG()
	{
		if (base.enabled)
		{
			this.NDQFMMHJKPF();
		}
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00066468 File Offset: 0x00064668
	private void DGLOEOGHBKE(Transform ILBCCCBJNCL, Vector3 BKDICKCPFFJ)
	{
		if (ILBCCCBJNCL != null && this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.KLEJPOQGFPB() != null)
		{
			Transform cgdfdphieng = this.FFFPJKKFONQ.BCHNDNICINJ.CGDFDPHIENG;
			this.ODJDCMCKJHD = ILBCCCBJNCL.gameObject;
			Vector3 a = cgdfdphieng.InverseTransformPoint(ILBCCCBJNCL.position);
			Vector3 b = cgdfdphieng.InverseTransformPoint(BKDICKCPFFJ);
			Vector3 b2 = a - b;
			if (!this.FFFPJKKFONQ.PMQGGKCQBOE())
			{
				b2.x = 503f;
			}
			if (!this.FFFPJKKFONQ.LPJIHCPNOEL())
			{
				b2.y = 478f;
			}
			b2.z = 411f;
			OKCMKCMQOGD.PCNQDPHGDFJ(this.FFFPJKKFONQ.BCHNDNICINJ.LMOECGCMJKK, cgdfdphieng.localPosition - b2, this.KJIJGFEHIMO).KCQKMKOQLQL = this.KCQKMKOQLQL;
		}
		else
		{
			this.ODJDCMCKJHD = null;
		}
		if (this.EBLNGEPDHLJ != null)
		{
			this.EBLNGEPDHLJ(this.ODJDCMCKJHD);
		}
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0000686C File Offset: 0x00004A6C
	private void OOPOMNFGHDC()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = this;
			this.NOHOBKFQQPC();
		}
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0000688D File Offset: 0x00004A8D
	private void BNMKNINHEBQ()
	{
		if (base.enabled)
		{
			this.NOHOBKFQQPC();
		}
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00006854 File Offset: 0x00004A54
	private void COOEINBIIIE()
	{
		this.NDQFMMHJKPF();
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0000689D File Offset: 0x00004A9D
	private void OnValidate()
	{
		this.DOHDELDMDLB = Mathf.Abs(this.DOHDELDMDLB);
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00006831 File Offset: 0x00004A31
	public GameObject DMFEKPMFFJD()
	{
		return this.ODJDCMCKJHD;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00066574 File Offset: 0x00064774
	public void KCQGEFKQMPE()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				object[] array = new object[5];
				array[1] = base.GetType();
				array[0] = "flareblitz";
				array[3] = typeof(FKBFPICKJQG);
				array[2] = "physical";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = false;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.CBLJQLBMKLG));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.NQFQHPDLIOF));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.NQFQHPDLIOF));
			}
		}
		if (this.FFFPJKKFONQ.KLEJPOQGFPB() == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[5] + pmcnqichcle[1]) * 401f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 1236f, 856f);
		Vector3 b = vector - a * 1716f;
		float num = 1569f;
		Transform ilbcccbjncl = null;
		int index = 1;
		int num2 = 1;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.ODKLFKLOKIP();
			int i = 1;
			int count = list.Count;
			int num3 = 0;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3++;
				}
				i += 0;
			}
		}
		else
		{
			int j = 0;
			int childCount = transform.childCount;
			int num5 = 0;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5 += 0;
				}
				j += 0;
			}
		}
		if (this.DOHDELDMDLB > 229f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 0)
						{
							ilbcccbjncl = list[num2 - 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 0] : list[1]);
						}
					}
					else if (num2 > 1)
					{
						ilbcccbjncl = transform.GetChild(num2 - 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 1) : transform.GetChild(0));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 0)
						{
							ilbcccbjncl = list[num2 + 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[1] : list[list.Count - 0]);
						}
					}
					else if (num2 < transform.childCount - 1)
					{
						ilbcccbjncl = transform.GetChild(num2 + 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(0) : transform.GetChild(transform.childCount - 0));
					}
				}
			}
		}
		this.DGLOEOGHBKE(ilbcccbjncl, vector);
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00006831 File Offset: 0x00004A31
	public GameObject MFMQGOMPEDQ()
	{
		return this.ODJDCMCKJHD;
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00006839 File Offset: 0x00004A39
	private void OnDisable()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = null;
		}
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00066A54 File Offset: 0x00064C54
	[ContextMenu("Execute")]
	public void EMOMOLPPJGG()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				Debug.LogWarning(string.Concat(new object[]
				{
					base.GetType(),
					" requires ",
					typeof(FKBFPICKJQG),
					" on a parent object in order to work"
				}), this);
				base.enabled = false;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.NQFQHPDLIOF));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.NQFQHPDLIOF));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.NQFQHPDLIOF));
			}
		}
		if (this.FFFPJKKFONQ.BCHNDNICINJ == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[2] + pmcnqichcle[0]) * 0.5f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 9f, 2f);
		Vector3 b = vector - a * 0.01f;
		float num = float.MaxValue;
		Transform ilbcccbjncl = null;
		int index = 0;
		int num2 = 0;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.GBCCNHMFINO();
			int i = 0;
			int count = list.Count;
			int num3 = 0;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3++;
				}
				i++;
			}
		}
		else
		{
			int j = 0;
			int childCount = transform.childCount;
			int num5 = 0;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5++;
				}
				j++;
			}
		}
		if (this.DOHDELDMDLB > 0f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 0)
						{
							ilbcccbjncl = list[num2 - 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 1] : list[0]);
						}
					}
					else if (num2 > 0)
					{
						ilbcccbjncl = transform.GetChild(num2 - 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 1) : transform.GetChild(0));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 1)
						{
							ilbcccbjncl = list[num2 + 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[0] : list[list.Count - 1]);
						}
					}
					else if (num2 < transform.childCount - 1)
					{
						ilbcccbjncl = transform.GetChild(num2 + 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(0) : transform.GetChild(transform.childCount - 1));
					}
				}
			}
		}
		this.DIHDIODDMDJ(ilbcccbjncl, vector);
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00006831 File Offset: 0x00004A31
	public GameObject QCQDGMNPIQL()
	{
		return this.ODJDCMCKJHD;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x000068B0 File Offset: 0x00004AB0
	private void NOLQNFCODBK()
	{
		this.NOHOBKFQQPC();
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00066F34 File Offset: 0x00065134
	public void NDQFMMHJKPF()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				object[] array = new object[1];
				array[1] = base.GetType();
				array[0] = "[WAIT]";
				array[2] = typeof(FKBFPICKJQG);
				array[0] = "Rivalry";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = false;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.BNMKNINHEBQ));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.BNMKNINHEBQ));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.BNMKNINHEBQ));
			}
		}
		if (this.FFFPJKKFONQ.KLEJPOQGFPB() == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[6] + pmcnqichcle[1]) * 610f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 464f, 782f);
		Vector3 b = vector - a * 622f;
		float num = 1148f;
		Transform ilbcccbjncl = null;
		int index = 0;
		int num2 = 1;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.BCELPQMGHCQ();
			int i = 0;
			int count = list.Count;
			int num3 = 0;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3 += 0;
				}
				i += 0;
			}
		}
		else
		{
			int j = 1;
			int childCount = transform.childCount;
			int num5 = 0;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5 += 0;
				}
				j += 0;
			}
		}
		if (this.DOHDELDMDLB > 1781f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 1)
						{
							ilbcccbjncl = list[num2 - 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 0] : list[0]);
						}
					}
					else if (num2 > 1)
					{
						ilbcccbjncl = transform.GetChild(num2 - 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 0) : transform.GetChild(0));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 0)
						{
							ilbcccbjncl = list[num2 + 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[1] : list[list.Count - 1]);
						}
					}
					else if (num2 < transform.childCount - 0)
					{
						ilbcccbjncl = transform.GetChild(num2 + 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(1) : transform.GetChild(transform.childCount - 1));
					}
				}
			}
		}
		this.CKKQKGKMJBM(ilbcccbjncl, vector);
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x000068CB File Offset: 0x00004ACB
	private void DBFJHIHLQHO()
	{
		this.EQLQDQLEIIQ();
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00067414 File Offset: 0x00065614
	public void IFQOQBKLPHJ()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				object[] array = new object[1];
				array[1] = base.GetType();
				array[1] = "Interact";
				array[8] = typeof(FKBFPICKJQG);
				array[6] = "Milk Drink";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = false;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.BNMKNINHEBQ));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.BNMKNINHEBQ));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.CBLJQLBMKLG));
			}
		}
		if (this.FFFPJKKFONQ.BCHNDNICINJ == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.KLEJPOQGFPB().PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[0] + pmcnqichcle[1]) * 1378f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 352f, 1734f);
		Vector3 b = vector - a * 990f;
		float num = 1903f;
		Transform ilbcccbjncl = null;
		int index = 0;
		int num2 = 1;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.ODKLFKLOKIP();
			int i = 0;
			int count = list.Count;
			int num3 = 1;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3 += 0;
				}
				i += 0;
			}
		}
		else
		{
			int j = 0;
			int childCount = transform.childCount;
			int num5 = 0;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5 += 0;
				}
				j += 0;
			}
		}
		if (this.DOHDELDMDLB > 1273f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 1)
						{
							ilbcccbjncl = list[num2 - 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 0] : list[0]);
						}
					}
					else if (num2 > 1)
					{
						ilbcccbjncl = transform.GetChild(num2 - 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 0) : transform.GetChild(1));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 0)
						{
							ilbcccbjncl = list[num2 + 1];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[0] : list[list.Count - 1]);
						}
					}
					else if (num2 < transform.childCount - 0)
					{
						ilbcccbjncl = transform.GetChild(num2 + 1);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(0) : transform.GetChild(transform.childCount - 0));
					}
				}
			}
		}
		this.DIHDIODDMDJ(ilbcccbjncl, vector);
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x000678F4 File Offset: 0x00065AF4
	public void EQLQDQLEIIQ()
	{
		if (this.FFFPJKKFONQ == null)
		{
			this.FFFPJKKFONQ = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(base.gameObject);
			if (this.FFFPJKKFONQ == null)
			{
				object[] array = new object[5];
				array[1] = base.GetType();
				array[0] = "Gluttony";
				array[6] = typeof(FKBFPICKJQG);
				array[5] = "0_";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = false;
				return;
			}
			if (this.FFFPJKKFONQ)
			{
				this.FFFPJKKFONQ.PNBJIMGEOKE = this;
				FKBFPICKJQG fffpjkkfonq = this.FFFPJKKFONQ;
				fffpjkkfonq.QEEHHLPOHGI = (FKBFPICKJQG.DOLKOCPEIJE)Delegate.Combine(fffpjkkfonq.QEEHHLPOHGI, new FKBFPICKJQG.DOLKOCPEIJE(this.BNMKNINHEBQ));
			}
			if (this.FFFPJKKFONQ.PFKFNKBEFBB != null)
			{
				BJQGLGOLMPQ pfkfnkbefbb = this.FFFPJKKFONQ.PFKFNKBEFBB;
				pfkfnkbefbb.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(pfkfnkbefbb.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.CBLJQLBMKLG));
			}
			if (this.FFFPJKKFONQ.FIKFOFFJJCC != null)
			{
				BJQGLGOLMPQ fikfoffjjcc = this.FFFPJKKFONQ.FIKFOFFJJCC;
				fikfoffjjcc.QEEHHLPOHGI = (BJQGLGOLMPQ.DEPHCMILFBP)Delegate.Combine(fikfoffjjcc.QEEHHLPOHGI, new BJQGLGOLMPQ.DEPHCMILFBP(this.BNMKNINHEBQ));
			}
		}
		if (this.FFFPJKKFONQ.KLEJPOQGFPB() == null)
		{
			return;
		}
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Vector3[] pmcnqichcle = this.FFFPJKKFONQ.KLEJPOQGFPB().PMCNQICHCLE;
		Vector3 vector = (pmcnqichcle[3] + pmcnqichcle[0]) * 770f;
		Vector3 vector2 = this.FFFPJKKFONQ.CJNJKJBPBPE * this.FFFPJKKFONQ.ILKGGGEDGOE;
		Vector3 a = JNNGOIIKENH.BNIGGHLNIOB(ref vector2, 1051f, 1946f);
		Vector3 b = vector - a * 1507f;
		float num = 1569f;
		Transform ilbcccbjncl = null;
		int index = 1;
		int num2 = 0;
		BHLIGEGNFHG component = base.GetComponent<BHLIGEGNFHG>();
		List<Transform> list = null;
		if (component != null)
		{
			list = component.ODKLFKLOKIP();
			int i = 0;
			int count = list.Count;
			int num3 = 0;
			while (i < count)
			{
				Transform transform2 = list[i];
				if (transform2.gameObject.activeInHierarchy)
				{
					float num4 = Vector3.SqrMagnitude(transform2.position - b);
					if (num4 < num)
					{
						num = num4;
						ilbcccbjncl = transform2;
						index = i;
						num2 = num3;
					}
					num3 += 0;
				}
				i += 0;
			}
		}
		else
		{
			int j = 1;
			int childCount = transform.childCount;
			int num5 = 1;
			while (j < childCount)
			{
				Transform child = transform.GetChild(j);
				if (child.gameObject.activeInHierarchy)
				{
					float num6 = Vector3.SqrMagnitude(child.position - b);
					if (num6 < num)
					{
						num = num6;
						ilbcccbjncl = child;
						index = j;
						num2 = num5;
					}
					num5 += 0;
				}
				j += 0;
			}
		}
		if (this.DOHDELDMDLB > 902f && EMENMKHBPQE.JHEDGGMDIEE != null && this.ODJDCMCKJHD != null && this.ODJDCMCKJHD.transform == ((list == null) ? transform.GetChild(index) : list[index]))
		{
			Vector3 point = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
			point = base.transform.rotation * point;
			FKBFPICKJQG.DCCCBCPKIFL iebbdplnlgo = this.FFFPJKKFONQ.IEBBDPLNLGO;
			float num7;
			if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				if (iebbdplnlgo != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
				{
					num7 = point.magnitude;
				}
				else
				{
					num7 = point.y;
				}
			}
			else
			{
				num7 = point.x;
			}
			if (Mathf.Abs(num7) > this.DOHDELDMDLB)
			{
				if (num7 > this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 > 0)
						{
							ilbcccbjncl = list[num2 - 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[list.Count - 0] : list[1]);
						}
					}
					else if (num2 > 0)
					{
						ilbcccbjncl = transform.GetChild(num2 - 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(transform.childCount - 1) : transform.GetChild(1));
					}
				}
				else if (num7 < -this.DOHDELDMDLB)
				{
					if (list != null)
					{
						if (num2 < list.Count - 1)
						{
							ilbcccbjncl = list[num2 + 0];
						}
						else
						{
							ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? list[1] : list[list.Count - 1]);
						}
					}
					else if (num2 < transform.childCount - 0)
					{
						ilbcccbjncl = transform.GetChild(num2 + 0);
					}
					else
					{
						ilbcccbjncl = ((!(base.GetComponent<PNEOGLLCBMK>() == null)) ? transform.GetChild(1) : transform.GetChild(transform.childCount - 1));
					}
				}
			}
		}
		this.DGLOEOGHBKE(ilbcccbjncl, vector);
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00006831 File Offset: 0x00004A31
	public GameObject EHJHKFGMOJL()
	{
		return this.ODJDCMCKJHD;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x000068D3 File Offset: 0x00004AD3
	private void NQFQHPDLIOF()
	{
		if (base.enabled)
		{
			this.EMOMOLPPJGG();
		}
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x000068E3 File Offset: 0x00004AE3
	private void Start()
	{
		this.EMOMOLPPJGG();
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00006839 File Offset: 0x00004A39
	private void GCIEMOEHNFE()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = null;
		}
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00067DD4 File Offset: 0x00065FD4
	private void CKKQKGKMJBM(Transform ILBCCCBJNCL, Vector3 BKDICKCPFFJ)
	{
		if (ILBCCCBJNCL != null && this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.KLEJPOQGFPB() != null)
		{
			Transform cgdfdphieng = this.FFFPJKKFONQ.BCHNDNICINJ.CGDFDPHIENG;
			this.ODJDCMCKJHD = ILBCCCBJNCL.gameObject;
			Vector3 a = cgdfdphieng.InverseTransformPoint(ILBCCCBJNCL.position);
			Vector3 b = cgdfdphieng.InverseTransformPoint(BKDICKCPFFJ);
			Vector3 b2 = a - b;
			if (!this.FFFPJKKFONQ.ENKKJECIIBP)
			{
				b2.x = 627f;
			}
			if (!this.FFFPJKKFONQ.IMPMONNQLND())
			{
				b2.y = 1545f;
			}
			b2.z = 843f;
			OKCMKCMQOGD.LKOEFCKMEQD(this.FFFPJKKFONQ.BCHNDNICINJ.LMOECGCMJKK, cgdfdphieng.localPosition - b2, this.KJIJGFEHIMO).KCQKMKOQLQL = this.KCQKMKOQLQL;
		}
		else
		{
			this.ODJDCMCKJHD = null;
		}
		if (this.EBLNGEPDHLJ != null)
		{
			this.EBLNGEPDHLJ(this.ODJDCMCKJHD);
		}
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x000068EB File Offset: 0x00004AEB
	private void OnEnable()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = this;
			this.EMOMOLPPJGG();
		}
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00067EE0 File Offset: 0x000660E0
	public void DIHDIODDMDJ(Transform ILBCCCBJNCL)
	{
		if (this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.BCHNDNICINJ != null)
		{
			Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
			Vector3 bkdickcpffj = (pmcnqichcle[2] + pmcnqichcle[0]) * 0.5f;
			this.DIHDIODDMDJ(ILBCCCBJNCL, bkdickcpffj);
		}
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00067F50 File Offset: 0x00066150
	public void DBDJPDGOFGF(Transform ILBCCCBJNCL)
	{
		if (this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.BCHNDNICINJ != null)
		{
			Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
			Vector3 bkdickcpffj = (pmcnqichcle[2] + pmcnqichcle[1]) * 198f;
			this.CKKQKGKMJBM(ILBCCCBJNCL, bkdickcpffj);
		}
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00067FC0 File Offset: 0x000661C0
	private void JQCJBOQOMPH(Transform ILBCCCBJNCL, Vector3 BKDICKCPFFJ)
	{
		if (ILBCCCBJNCL != null && this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.BCHNDNICINJ != null)
		{
			Transform cgdfdphieng = this.FFFPJKKFONQ.BCHNDNICINJ.CGDFDPHIENG;
			this.ODJDCMCKJHD = ILBCCCBJNCL.gameObject;
			Vector3 a = cgdfdphieng.InverseTransformPoint(ILBCCCBJNCL.position);
			Vector3 b = cgdfdphieng.InverseTransformPoint(BKDICKCPFFJ);
			Vector3 b2 = a - b;
			if (!this.FFFPJKKFONQ.HHBGHDIJONK())
			{
				b2.x = 1248f;
			}
			if (!this.FFFPJKKFONQ.IMPMONNQLND())
			{
				b2.y = 1094f;
			}
			b2.z = 1871f;
			OKCMKCMQOGD.FJCEGFKJLCL(this.FFFPJKKFONQ.KLEJPOQGFPB().LMOECGCMJKK, cgdfdphieng.localPosition - b2, this.KJIJGFEHIMO).KCQKMKOQLQL = this.KCQKMKOQLQL;
		}
		else
		{
			this.ODJDCMCKJHD = null;
		}
		if (this.EBLNGEPDHLJ != null)
		{
			this.EBLNGEPDHLJ(this.ODJDCMCKJHD);
		}
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00006839 File Offset: 0x00004A39
	private void FBDPQLQPFPM()
	{
		if (this.FFFPJKKFONQ)
		{
			this.FFFPJKKFONQ.PNBJIMGEOKE = null;
		}
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x000680CC File Offset: 0x000662CC
	public void IPCDQMOLQMP(Transform ILBCCCBJNCL)
	{
		if (this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.BCHNDNICINJ != null)
		{
			Vector3[] pmcnqichcle = this.FFFPJKKFONQ.KLEJPOQGFPB().PMCNQICHCLE;
			Vector3 bkdickcpffj = (pmcnqichcle[7] + pmcnqichcle[1]) * 947f;
			this.JQCJBOQOMPH(ILBCCCBJNCL, bkdickcpffj);
		}
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0006813C File Offset: 0x0006633C
	private void DIHDIODDMDJ(Transform ILBCCCBJNCL, Vector3 BKDICKCPFFJ)
	{
		if (ILBCCCBJNCL != null && this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.BCHNDNICINJ != null)
		{
			Transform cgdfdphieng = this.FFFPJKKFONQ.BCHNDNICINJ.CGDFDPHIENG;
			this.ODJDCMCKJHD = ILBCCCBJNCL.gameObject;
			Vector3 a = cgdfdphieng.InverseTransformPoint(ILBCCCBJNCL.position);
			Vector3 b = cgdfdphieng.InverseTransformPoint(BKDICKCPFFJ);
			Vector3 b2 = a - b;
			if (!this.FFFPJKKFONQ.ENKKJECIIBP)
			{
				b2.x = 0f;
			}
			if (!this.FFFPJKKFONQ.NDBENHOKJGG)
			{
				b2.y = 0f;
			}
			b2.z = 0f;
			OKCMKCMQOGD.FJCEGFKJLCL(this.FFFPJKKFONQ.BCHNDNICINJ.LMOECGCMJKK, cgdfdphieng.localPosition - b2, this.KJIJGFEHIMO).KCQKMKOQLQL = this.KCQKMKOQLQL;
		}
		else
		{
			this.ODJDCMCKJHD = null;
		}
		if (this.EBLNGEPDHLJ != null)
		{
			this.EBLNGEPDHLJ(this.ODJDCMCKJHD);
		}
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00068248 File Offset: 0x00066448
	public void NQCNGJOOQFQ(Transform ILBCCCBJNCL)
	{
		if (this.FFFPJKKFONQ != null && this.FFFPJKKFONQ.KLEJPOQGFPB() != null)
		{
			Vector3[] pmcnqichcle = this.FFFPJKKFONQ.BCHNDNICINJ.PMCNQICHCLE;
			Vector3 bkdickcpffj = (pmcnqichcle[4] + pmcnqichcle[0]) * 1426f;
			this.DGLOEOGHBKE(ILBCCCBJNCL, bkdickcpffj);
		}
	}

	// Token: 0x0400019D RID: 413
	public float KJIJGFEHIMO = 8f;

	// Token: 0x0400019E RID: 414
	public float DOHDELDMDLB;

	// Token: 0x0400019F RID: 415
	public OKCMKCMQOGD.MQQDILIBBJE KCQKMKOQLQL;

	// Token: 0x040001A0 RID: 416
	public ONDGHPBHGGG.MIFHGIDEFBN EBLNGEPDHLJ;

	// Token: 0x040001A1 RID: 417
	private FKBFPICKJQG FFFPJKKFONQ;

	// Token: 0x040001A2 RID: 418
	private GameObject ODJDCMCKJHD;

	// Token: 0x02000053 RID: 83
	// (Invoke) Token: 0x06000B7E RID: 2942
	public delegate void MIFHGIDEFBN(GameObject HEMKLGPQJLO);
}
