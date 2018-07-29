using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200008D RID: 141
[AddComponentMenu("NGUI/Interaction/Wrap Content")]
public class PNEOGLLCBMK : MonoBehaviour
{
	// Token: 0x0600124D RID: 4685 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void IQIONFKHFCG()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void OHCMJFNIFIK()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00088E1C File Offset: 0x0008701C
	protected virtual void QIBIPNENEBK(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00088E1C File Offset: 0x0008701C
	protected virtual void BGMBDQBPQJO(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00088E1C File Offset: 0x0008701C
	protected virtual void BOKCFNOJLQD(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00088E8C File Offset: 0x0008708C
	protected virtual void GKQHQLOOFCF()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(674f, (float)(-(float)i * this.IKBKOKGHEFH), 1315f) : new Vector3((float)(i * this.IKBKOKGHEFH), 608f, 1764f));
			this.BOKCFNOJLQD(transform, i);
			i++;
		}
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void JHLLNLGMMNQ()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x0000A730 File Offset: 0x00008930
	protected virtual void EEHOLEJCKHH(KQHJOLQLQBJ BCHNDNICINJ)
	{
		this.NIEKMCKBMKP();
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00088F08 File Offset: 0x00087108
	public virtual void HHBMQLFJBQP()
	{
		if (!this.DPGCPOKGOON())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.BIKBLJNHNOB();
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00088FD0 File Offset: 0x000871D0
	public virtual void NIQDOHEDCED()
	{
		if (!this.DDEIJFGOFBD())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.GPFFIENFMNK();
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00088E1C File Offset: 0x0008701C
	protected virtual void DGLDQPLFMEF(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x00089098 File Offset: 0x00087298
	public virtual void DIOJPKBBLNK()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 0.5f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 0; i < 4; i++)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[0], pmcnqichcle[2], 0.5f);
		bool flag = true;
		float num2 = num * 2f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[0].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[2].x + (float)this.IKBKOKGHEFH;
			int j = 0;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition;
						this.DGLDQPLFMEF(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.DGLDQPLFMEF(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.DGLDQPLFMEF(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.PIJJJMKLMIO.x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 > num3 && num5 < num4, false);
					}
				}
				j++;
			}
		}
		else
		{
			float num8 = pmcnqichcle[0].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[2].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.DGLDQPLFMEF(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.DGLDQPLFMEF(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.DGLDQPLFMEF(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.PIJJJMKLMIO.y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, false);
					}
				}
				k++;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = !flag;
		this.HCLBPEMQFBO.DGJGBMFMMFJ();
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x0000A738 File Offset: 0x00008938
	protected virtual void DHLGDLOKLKN()
	{
		this.KDFLHPJQNLL();
		this.MOKGQCEPMJJ();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.EDMJBOOGMFQ);
		}
		this.DLHIGPBNBNB = true;
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00089548 File Offset: 0x00087748
	protected virtual void IELPBEOCEJN()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1152f, (float)(-(float)i * this.IKBKOKGHEFH), 1629f) : new Vector3((float)(i * this.IKBKOKGHEFH), 79f, 1757f));
			this.QIBIPNENEBK(transform, i);
			i++;
		}
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x000895C4 File Offset: 0x000877C4
	protected bool DDEIJFGOFBD()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return true;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = true;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				return false;
			}
			this.NJJLNOQOJJC = true;
		}
		return true;
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x00089640 File Offset: 0x00087840
	protected virtual void PGMMOKIOIBJ()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(0f, (float)(-(float)i * this.IKBKOKGHEFH), 0f) : new Vector3((float)(i * this.IKBKOKGHEFH), 0f, 0f));
			this.DGLDQPLFMEF(transform, i);
			i++;
		}
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x000896BC File Offset: 0x000878BC
	protected virtual void CGBFHLEKDJK(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x0008972C File Offset: 0x0008792C
	[ContextMenu("Sort Alphabetically")]
	public virtual void JGIIMFJEDQC()
	{
		if (!this.BBJBPIEPIKF())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.PGMMOKIOIBJ();
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x000897C0 File Offset: 0x000879C0
	public virtual void NIEKMCKBMKP()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 590f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 1; i < 3; i++)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[0], pmcnqichcle[3], 1537f);
		bool flag = true;
		float num2 = num * 86f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[0].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[1].x + (float)this.IKBKOKGHEFH;
			int j = 1;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition;
						this.JODLGPEJGIP(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.JODLGPEJGIP(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.QIBIPNENEBK(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.JQCLCPFLDOK().x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 > num3 && num5 < num4, true);
					}
				}
				j++;
			}
		}
		else
		{
			float num8 = pmcnqichcle[0].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[5].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.QIBIPNENEBK(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.DGLDQPLFMEF(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.JODLGPEJGIP(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.PIJJJMKLMIO.y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 <= num8 || num10 < num9, true);
					}
				}
				k++;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = flag;
		this.HCLBPEMQFBO.DGJGBMFMMFJ();
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x00089C70 File Offset: 0x00087E70
	protected bool BBJBPIEPIKF()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return false;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = true;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
			{
				return false;
			}
			this.NJJLNOQOJJC = false;
		}
		return true;
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x00089CEC File Offset: 0x00087EEC
	protected virtual void GPFFIENFMNK()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1932f, (float)(-(float)i * this.IKBKOKGHEFH), 150f) : new Vector3((float)(i * this.IKBKOKGHEFH), 1349f, 369f));
			this.DOFLMNQFFJG(transform, i);
			i += 0;
		}
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x00089D68 File Offset: 0x00087F68
	public virtual void JJMOKJDLCCO()
	{
		if (!this.CLCLDDNNJJN())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.CFGOEKCDOKD();
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00089DFC File Offset: 0x00087FFC
	public virtual void KDFLHPJQNLL()
	{
		if (!this.CLCLDDNNJJN())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.CFGOEKCDOKD();
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00089EC4 File Offset: 0x000880C4
	protected bool JGLGPHJPJQK()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return false;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = false;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				return true;
			}
			this.NJJLNOQOJJC = false;
		}
		return true;
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00089F40 File Offset: 0x00088140
	public virtual void OOHFKMIMOHN()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 1663f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 1; i < 7; i++)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[1], pmcnqichcle[6], 425f);
		bool flag = false;
		float num2 = num * 1856f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[1].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[3].x + (float)this.IKBKOKGHEFH;
			int j = 1;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition;
						this.DGLDQPLFMEF(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.JODLGPEJGIP(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.JODLGPEJGIP(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.JQCLCPFLDOK().x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 <= num3 || num5 < num4, true);
					}
				}
				j += 0;
			}
		}
		else
		{
			float num8 = pmcnqichcle[1].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[0].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.QIBIPNENEBK(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.DOFLMNQFFJG(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.PIJJJMKLMIO.y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, true);
					}
				}
				k += 0;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = flag;
		this.HCLBPEMQFBO.GOEBCPBJEGE();
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x0008A3F0 File Offset: 0x000885F0
	protected bool MQNBMPHLMDB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return false;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = true;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				return false;
			}
			this.NJJLNOQOJJC = false;
		}
		return true;
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x0008A46C File Offset: 0x0008866C
	public virtual void MMFBPNJFHDK()
	{
		if (!this.BBJBPIEPIKF())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.BIKBLJNHNOB();
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x0000A778 File Offset: 0x00008978
	protected virtual void EDMJBOOGMFQ(KQHJOLQLQBJ BCHNDNICINJ)
	{
		this.DIOJPKBBLNK();
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x0008A500 File Offset: 0x00088700
	public virtual void DHCLCJCLMJF()
	{
		if (!this.JGLGPHJPJQK())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.BIKBLJNHNOB();
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x0000A778 File Offset: 0x00008978
	protected virtual void KMFJGQOQPJN(KQHJOLQLQBJ BCHNDNICINJ)
	{
		this.DIOJPKBBLNK();
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void EIHPPNOPBFI()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x0000A7A9 File Offset: 0x000089A9
	protected virtual void Start()
	{
		this.CCHNEGGEMLO();
		this.DIOJPKBBLNK();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.KMFJGQOQPJN);
		}
		this.DLHIGPBNBNB = false;
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x0008A5C8 File Offset: 0x000887C8
	public virtual void FMFCCKBBCFI()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 63f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 0; i < 7; i += 0)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[0], pmcnqichcle[2], 1027f);
		bool flag = false;
		float num2 = num * 359f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[1].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[1].x + (float)this.IKBKOKGHEFH;
			int j = 0;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition;
						this.DGLDQPLFMEF(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.CGBFHLEKDJK(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.BOKCFNOJLQD(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.PIJJJMKLMIO.x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 > num3 && num5 < num4, false);
					}
				}
				j++;
			}
		}
		else
		{
			float num8 = pmcnqichcle[0].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[6].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.BGMBDQBPQJO(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.BOKCFNOJLQD(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.JQCLCPFLDOK().y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, true);
					}
				}
				k += 0;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = flag;
		this.HCLBPEMQFBO.GOEBCPBJEGE();
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x000896BC File Offset: 0x000878BC
	protected virtual void JODLGPEJGIP(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x0008AA78 File Offset: 0x00088C78
	protected virtual void KDMQOOEHKDI()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1733f, (float)(-(float)i * this.IKBKOKGHEFH), 789f) : new Vector3((float)(i * this.IKBKOKGHEFH), 1160f, 89f));
			this.QIBIPNENEBK(transform, i);
			i++;
		}
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x0008AAF4 File Offset: 0x00088CF4
	public virtual void MOKGQCEPMJJ()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 1390f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 0; i < 5; i += 0)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[0], pmcnqichcle[5], 1488f);
		bool flag = true;
		float num2 = num * 1780f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[1].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[6].x + (float)this.IKBKOKGHEFH;
			int j = 1;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition;
						this.QIBIPNENEBK(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.DOFLMNQFFJG(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.JQCLCPFLDOK().x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 > num3 && num5 < num4, true);
					}
				}
				j += 0;
			}
		}
		else
		{
			float num8 = pmcnqichcle[0].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[3].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.BOKCFNOJLQD(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.DOFLMNQFFJG(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.JQCLCPFLDOK().y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, false);
					}
				}
				k++;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = !flag;
		this.HCLBPEMQFBO.DGJGBMFMMFJ();
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void NGNDGHHKMQQ()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0008AFA4 File Offset: 0x000891A4
	protected virtual void INLMBBQDEPN()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1904f, (float)(-(float)i * this.IKBKOKGHEFH), 1197f) : new Vector3((float)(i * this.IKBKOKGHEFH), 314f, 974f));
			this.CGBFHLEKDJK(transform, i);
			i++;
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0008B020 File Offset: 0x00089220
	public virtual void GFDNBFMCDNP()
	{
		if (!this.DDEIJFGOFBD())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.GKQHQLOOFCF();
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void BOBJNOMCDBM()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x0000A7E9 File Offset: 0x000089E9
	protected virtual void MHOKPDFOEDP()
	{
		this.OQJNNGLHBII();
		this.FMFCCKBBCFI();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.OFGNCKNJKOD);
		}
		this.DLHIGPBNBNB = true;
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x0008B0B4 File Offset: 0x000892B4
	public virtual void OGIKLMFQMMD()
	{
		if (!this.DDEIJFGOFBD())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.KLEMLIJDKDM();
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void OIJDCFHOKOD()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void DFMMFGKFEPO()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void LPJQBGJFOLB()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x0008B148 File Offset: 0x00089348
	public virtual void PGFCCMNHEKO()
	{
		if (!this.DPGCPOKGOON())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.IELPBEOCEJN();
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void OnValidate()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x0008B210 File Offset: 0x00089410
	public virtual void QBLLCDBMLPG()
	{
		if (!this.BBJBPIEPIKF())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.KLEMLIJDKDM();
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x0000A829 File Offset: 0x00008A29
	protected virtual void DQDJHNPNQHB(KQHJOLQLQBJ BCHNDNICINJ)
	{
		this.FMFCCKBBCFI();
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x0000A831 File Offset: 0x00008A31
	protected virtual void NOLQNFCODBK()
	{
		this.JJGBHQOHELI();
		this.CCBPBEDOIGD();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.OFGNCKNJKOD);
		}
		this.DLHIGPBNBNB = false;
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00088E1C File Offset: 0x0008701C
	protected virtual void DOFLMNQFFJG(Transform PDIBIIKFBDH, int IIHDGMLHICI)
	{
		if (this.QMDBIPOQFGI != null)
		{
			int hgjejlfobbn = (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical) ? Mathf.RoundToInt(PDIBIIKFBDH.localPosition.x / (float)this.IKBKOKGHEFH) : Mathf.RoundToInt(PDIBIIKFBDH.localPosition.y / (float)this.IKBKOKGHEFH);
			this.QMDBIPOQFGI(PDIBIIKFBDH.gameObject, IIHDGMLHICI, hgjejlfobbn);
		}
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x0008B2D8 File Offset: 0x000894D8
	[ContextMenu("Sort Based on Scroll Movement")]
	public virtual void CCHNEGGEMLO()
	{
		if (!this.BBJBPIEPIKF())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.PGMMOKIOIBJ();
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x0008B3A0 File Offset: 0x000895A0
	public virtual void JJGBHQOHELI()
	{
		if (!this.MQNBMPHLMDB())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.KDMQOOEHKDI();
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x0008B468 File Offset: 0x00089668
	protected virtual void BIKBLJNHNOB()
	{
		int i = 1;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1794f, (float)(-(float)i * this.IKBKOKGHEFH), 1615f) : new Vector3((float)(i * this.IKBKOKGHEFH), 1914f, 1818f));
			this.QIBIPNENEBK(transform, i);
			i++;
		}
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x0008B2D8 File Offset: 0x000894D8
	public virtual void OQJNNGLHBII()
	{
		if (!this.BBJBPIEPIKF())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.PGMMOKIOIBJ();
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x0008B4E4 File Offset: 0x000896E4
	protected bool DPGCPOKGOON()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return true;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = true;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Vertical)
			{
				return true;
			}
			this.NJJLNOQOJJC = true;
		}
		return true;
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x0008B560 File Offset: 0x00089760
	public virtual void EHCEBOOFIIO()
	{
		if (!this.MQNBMPHLMDB())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.GPFFIENFMNK();
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x0008B5F4 File Offset: 0x000897F4
	public virtual void CCBPBEDOIGD()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 1658f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 1; i < 0; i++)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[0], pmcnqichcle[2], 928f);
		bool flag = true;
		float num2 = num * 1088f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[0].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[0].x + (float)this.IKBKOKGHEFH;
			int j = 1;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform.localPosition = localPosition;
						this.DGLDQPLFMEF(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.QIBIPNENEBK(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.PIJJJMKLMIO.x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 <= num3 || num5 < num4, false);
					}
				}
				j++;
			}
		}
		else
		{
			float num8 = pmcnqichcle[1].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[7].y + (float)this.IKBKOKGHEFH;
			int k = 1;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.BOKCFNOJLQD(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.JODLGPEJGIP(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.BGMBDQBPQJO(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.PIJJJMKLMIO.y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, true);
					}
				}
				k++;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = flag;
		this.HCLBPEMQFBO.DGJGBMFMMFJ();
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x0008BAA4 File Offset: 0x00089CA4
	public virtual void INLGPQNDIMN()
	{
		if (!this.JGLGPHJPJQK())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 1; i < this.BLLEFKOLKLP.childCount; i++)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
		if (PNEOGLLCBMK.DDBELLFQDQO == null)
		{
			PNEOGLLCBMK.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		hkdqqhlcnpp.Sort(PNEOGLLCBMK.DDBELLFQDQO);
		this.INLMBBQDEPN();
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x0000A871 File Offset: 0x00008A71
	protected virtual void OFGNCKNJKOD(KQHJOLQLQBJ BCHNDNICINJ)
	{
		this.CCBPBEDOIGD();
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x0008BB38 File Offset: 0x00089D38
	protected bool CLCLDDNNJJN()
	{
		this.BLLEFKOLKLP = base.transform;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
		this.HCLBPEMQFBO = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
		if (this.HCLBPEMQFBO == null)
		{
			return false;
		}
		if (this.HCLBPEMQFBO.IEBBDPLNLGO == FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
		{
			this.NJJLNOQOJJC = false;
		}
		else
		{
			if (this.HCLBPEMQFBO.IEBBDPLNLGO != FKBFPICKJQG.DCCCBCPKIFL.Horizontal)
			{
				return false;
			}
			this.NJJLNOQOJJC = false;
		}
		return false;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x0008BBB4 File Offset: 0x00089DB4
	protected virtual void CFGOEKCDOKD()
	{
		int i = 1;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(612f, (float)(-(float)i * this.IKBKOKGHEFH), 655f) : new Vector3((float)(i * this.IKBKOKGHEFH), 1347f, 1443f));
			this.DOFLMNQFFJG(transform, i);
			i += 0;
		}
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x0008BC30 File Offset: 0x00089E30
	public virtual void BDCFODJMLIB()
	{
		if (!this.MQNBMPHLMDB())
		{
			return;
		}
		this.HKDQQHLCNPP.Clear();
		for (int i = 0; i < this.BLLEFKOLKLP.childCount; i += 0)
		{
			Transform child = this.BLLEFKOLKLP.GetChild(i);
			if (!this.FKFNCFMDKNB || child.gameObject.activeInHierarchy)
			{
				this.HKDQQHLCNPP.Add(child);
			}
		}
		if (this.NJJLNOQOJJC)
		{
			List<Transform> hkdqqhlcnpp = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.BQIOGOCBKKB == null)
			{
				PNEOGLLCBMK.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
			}
			hkdqqhlcnpp.Sort(PNEOGLLCBMK.BQIOGOCBKKB);
		}
		else
		{
			List<Transform> hkdqqhlcnpp2 = this.HKDQQHLCNPP;
			if (PNEOGLLCBMK.OMPIQDIBPKI == null)
			{
				PNEOGLLCBMK.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
			}
			hkdqqhlcnpp2.Sort(PNEOGLLCBMK.OMPIQDIBPKI);
		}
		this.CFGOEKCDOKD();
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x0000A879 File Offset: 0x00008A79
	protected virtual void MBKJBIQKPGF()
	{
		this.HHBMQLFJBQP();
		this.CCBPBEDOIGD();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.OFGNCKNJKOD);
		}
		this.DLHIGPBNBNB = false;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x0000A8B9 File Offset: 0x00008AB9
	protected virtual void HQGDEKJQQDE()
	{
		this.DHCLCJCLMJF();
		this.OOHFKMIMOHN();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.OFGNCKNJKOD);
		}
		this.DLHIGPBNBNB = true;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x0000A8F9 File Offset: 0x00008AF9
	protected virtual void HBOFMLLODDM()
	{
		this.HHBMQLFJBQP();
		this.DIOJPKBBLNK();
		if (this.HCLBPEMQFBO != null)
		{
			this.HCLBPEMQFBO.GetComponent<KQHJOLQLQBJ>().KKDIGKKJBNM = new KQHJOLQLQBJ.QPKNJHBKHOQ(this.KMFJGQOQPJN);
		}
		this.DLHIGPBNBNB = true;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0000A6FA File Offset: 0x000088FA
	private void DCJHGEFEJCG()
	{
		if (this.FPJGDKLIMKD < this.QFPQEPHBKOK)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
		if (this.QFPQEPHBKOK > this.FPJGDKLIMKD)
		{
			this.FPJGDKLIMKD = this.QFPQEPHBKOK;
		}
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0008BCF8 File Offset: 0x00089EF8
	protected virtual void KLEMLIJDKDM()
	{
		int i = 0;
		int count = this.HKDQQHLCNPP.Count;
		while (i < count)
		{
			Transform transform = this.HKDQQHLCNPP[i];
			transform.localPosition = ((!this.NJJLNOQOJJC) ? new Vector3(1198f, (float)(-(float)i * this.IKBKOKGHEFH), 879f) : new Vector3((float)(i * this.IKBKOKGHEFH), 1568f, 415f));
			this.CGBFHLEKDJK(transform, i);
			i += 0;
		}
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x0008BD74 File Offset: 0x00089F74
	public virtual void ENCKNGPGKGD()
	{
		float num = (float)(this.IKBKOKGHEFH * this.HKDQQHLCNPP.Count) * 755f;
		Vector3[] pmcnqichcle = this.CNJGKKDHPOG.PMCNQICHCLE;
		for (int i = 0; i < 3; i++)
		{
			Vector3 vector = pmcnqichcle[i];
			vector = this.BLLEFKOLKLP.InverseTransformPoint(vector);
			pmcnqichcle[i] = vector;
		}
		Vector3 vector2 = Vector3.Lerp(pmcnqichcle[1], pmcnqichcle[5], 1811f);
		bool flag = false;
		float num2 = num * 1496f;
		if (this.NJJLNOQOJJC)
		{
			float num3 = pmcnqichcle[0].x - (float)this.IKBKOKGHEFH;
			float num4 = pmcnqichcle[2].x + (float)this.IKBKOKGHEFH;
			int j = 1;
			int count = this.HKDQQHLCNPP.Count;
			while (j < count)
			{
				Transform transform = this.HKDQQHLCNPP[j];
				float num5 = transform.localPosition.x - vector2.x;
				if (num5 < -num)
				{
					Vector3 localPosition = transform.localPosition;
					localPosition.x += num2;
					num5 = localPosition.x - vector2.x;
					int num6 = Mathf.RoundToInt(localPosition.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num6 || num6 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition;
						this.DOFLMNQFFJG(transform, j);
					}
				}
				else if (num5 > num)
				{
					Vector3 localPosition2 = transform.localPosition;
					localPosition2.x -= num2;
					num5 = localPosition2.x - vector2.x;
					int num7 = Mathf.RoundToInt(localPosition2.x / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num7 || num7 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform.localPosition = localPosition2;
						this.BOKCFNOJLQD(transform, j);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.DOFLMNQFFJG(transform, j);
				}
				if (this.PHQDQBJDBME)
				{
					num5 += this.CNJGKKDHPOG.BNIINQIELIC().x - this.BLLEFKOLKLP.localPosition.x;
					if (!EMENMKHBPQE.ENGHNBBQQIB(transform.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform.gameObject, num5 > num3 && num5 < num4, false);
					}
				}
				j++;
			}
		}
		else
		{
			float num8 = pmcnqichcle[1].y - (float)this.IKBKOKGHEFH;
			float num9 = pmcnqichcle[1].y + (float)this.IKBKOKGHEFH;
			int k = 0;
			int count2 = this.HKDQQHLCNPP.Count;
			while (k < count2)
			{
				Transform transform2 = this.HKDQQHLCNPP[k];
				float num10 = transform2.localPosition.y - vector2.y;
				if (num10 < -num)
				{
					Vector3 localPosition3 = transform2.localPosition;
					localPosition3.y += num2;
					num10 = localPosition3.y - vector2.y;
					int num11 = Mathf.RoundToInt(localPosition3.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num11 || num11 > this.FPJGDKLIMKD))
					{
						flag = false;
					}
					else
					{
						transform2.localPosition = localPosition3;
						this.QIBIPNENEBK(transform2, k);
					}
				}
				else if (num10 > num)
				{
					Vector3 localPosition4 = transform2.localPosition;
					localPosition4.y -= num2;
					num10 = localPosition4.y - vector2.y;
					int num12 = Mathf.RoundToInt(localPosition4.y / (float)this.IKBKOKGHEFH);
					if (this.QFPQEPHBKOK != this.FPJGDKLIMKD && (this.QFPQEPHBKOK > num12 || num12 > this.FPJGDKLIMKD))
					{
						flag = true;
					}
					else
					{
						transform2.localPosition = localPosition4;
						this.QIBIPNENEBK(transform2, k);
					}
				}
				else if (this.DLHIGPBNBNB)
				{
					this.CGBFHLEKDJK(transform2, k);
				}
				if (this.PHQDQBJDBME)
				{
					num10 += this.CNJGKKDHPOG.CJLPKHNPDID().y - this.BLLEFKOLKLP.localPosition.y;
					if (!EMENMKHBPQE.LGONODEHPMQ(transform2.gameObject))
					{
						IKBQNBHOJJB.IFPIGKGKFEQ(transform2.gameObject, num10 > num8 && num10 < num9, true);
					}
				}
				k += 0;
			}
		}
		this.HCLBPEMQFBO.OGQEPEGLEPO = !flag;
		this.HCLBPEMQFBO.DGJGBMFMMFJ();
	}

	// Token: 0x0400035A RID: 858
	public int IKBKOKGHEFH = 100;

	// Token: 0x0400035B RID: 859
	public bool PHQDQBJDBME = true;

	// Token: 0x0400035C RID: 860
	public int QFPQEPHBKOK;

	// Token: 0x0400035D RID: 861
	public int FPJGDKLIMKD;

	// Token: 0x0400035E RID: 862
	public bool FKFNCFMDKNB;

	// Token: 0x0400035F RID: 863
	public PNEOGLLCBMK.DIPIGJDFJNQ QMDBIPOQFGI;

	// Token: 0x04000360 RID: 864
	protected Transform BLLEFKOLKLP;

	// Token: 0x04000361 RID: 865
	protected KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x04000362 RID: 866
	protected FKBFPICKJQG HCLBPEMQFBO;

	// Token: 0x04000363 RID: 867
	protected bool NJJLNOQOJJC;

	// Token: 0x04000364 RID: 868
	protected bool DLHIGPBNBNB = true;

	// Token: 0x04000365 RID: 869
	protected List<Transform> HKDQQHLCNPP = new List<Transform>();

	// Token: 0x04000366 RID: 870
	[CompilerGenerated]
	private static Comparison<Transform> BQIOGOCBKKB;

	// Token: 0x04000367 RID: 871
	[CompilerGenerated]
	private static Comparison<Transform> OMPIQDIBPKI;

	// Token: 0x04000368 RID: 872
	[CompilerGenerated]
	private static Comparison<Transform> DDBELLFQDQO;

	// Token: 0x0200008E RID: 142
	// (Invoke) Token: 0x06001294 RID: 4756
	public delegate void DIPIGJDFJNQ(GameObject CGHIENBIHCO, int GPOBOPDMBIK, int HGJEJLFOBBN);
}
