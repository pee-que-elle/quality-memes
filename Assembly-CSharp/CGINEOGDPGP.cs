using System;
using UnityEngine;

// Token: 0x0200005B RID: 91
[AddComponentMenu("NGUI/Interaction/Drag Object")]
[ExecuteInEditMode]
public class CGINEOGDPGP : MonoBehaviour
{
	// Token: 0x06000C91 RID: 3217 RVA: 0x0006BA08 File Offset: 0x00069C08
	private void QIGGFPHFQOI()
	{
		this.KOGFJFBCIFN = ((!(this.ILBCCCBJNCL != null)) ? null : KQHJOLQLQBJ.CQGLPBCNFGL(this.ILBCCCBJNCL.transform.parent));
		if (this.KOGFJFBCIFN == null)
		{
			this.OGQEPEGLEPO = true;
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0006BA58 File Offset: 0x00069C58
	private void HBPIHOOKMDL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.FCHGFPDIGLN();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1455f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 1764f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.NBHGIOIFCDK(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 902f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.QEQGPGBNPPE();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.PEPIOKBLHJO();
				}
				else
				{
					this.PHOOKQFPPHB();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 62f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 421f)
			{
				this.QBEKCEPIFLO();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 31f, gpfidejemeg);
		}
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void PEPIOKBLHJO()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0006BCF4 File Offset: 0x00069EF4
	private void BJFPBMHIEOF(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)7;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1446f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = true;
					vector = Vector3.zero;
				}
				if (vector.x != 475f || vector.y != 1545f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (984f * this.ILKGGGEDGOE), 1048f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.GDDCELDNLOG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)6 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.KEBCJFMFNOP();
					}
				}
			}
		}
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0006BEA8 File Offset: 0x0006A0A8
	private void OCQCDGIEDLK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.HPJQNBLNHGM();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1772f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 1315f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.LLNDKCJPEFJ();
			}
			this.DFMMCLFKFBH(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 585f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.EDIELLJMCKN();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.HNCLGJKBCBI();
				}
				else
				{
					this.DJPNLNQDOGJ();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 952f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 460f)
			{
				this.HNCLGJKBCBI();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1157f, gpfidejemeg);
		}
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x00007011 File Offset: 0x00005211
	private void GJDLGQMHFLI()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0000701A File Offset: 0x0000521A
	private void QDLPEFBPLKP(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 1039f);
		}
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0006C038 File Offset: 0x0006A238
	private void QEQGPGBNPPE()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 0; i < 3; i += 0)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[1], Vector3.zero);
			for (int j = 1; j < 6; j++)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00007054 File Offset: 0x00005254
	public void BKHJGKHDOEL(Vector3 BGBMIEJJQKC)
	{
		this.scale = BGBMIEJJQKC;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00007011 File Offset: 0x00005211
	private void QNEFMCQQGNH()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void QBEKCEPIFLO()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0006C104 File Offset: 0x0006A304
	private void IBNLMNJKPDO(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1517f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = true;
					vector = Vector3.zero;
				}
				if (vector.x != 1801f || vector.y != 1582f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (982f * this.ILKGGGEDGOE), 763f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.DFMMCLFKFBH(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)5 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.PEPIOKBLHJO();
					}
				}
			}
		}
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 MFCFHOLOQIP()
	{
		return this.scale;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
	private void QQKGGJENKPI(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)5;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 818f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = true;
					vector = Vector3.zero;
				}
				if (vector.x != 712f || vector.y != 1965f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (161f * this.ILKGGGEDGOE), 587f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.HEJPNBPGIHG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)3 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.PEPIOKBLHJO();
					}
				}
			}
		}
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0006C46C File Offset: 0x0006A66C
	private void EOFOQLNKNCN()
	{
		this.KOGFJFBCIFN = ((!(this.ILBCCCBJNCL != null)) ? null : KQHJOLQLQBJ.CQGLPBCNFGL(this.ILBCCCBJNCL.transform.parent));
		if (this.KOGFJFBCIFN == null)
		{
			this.OGQEPEGLEPO = false;
		}
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0006C4BC File Offset: 0x0006A6BC
	private void JCJEGELCIQL(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.FCGMFIPGCHH(false);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0006C5DC File Offset: 0x0006A7DC
	private void BOPOJKGDCDL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.QCDDBMBNQLO();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 792f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 213f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.GDDCELDNLOG(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 489f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.QEQGPGBNPPE();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.DEGJCGCMBHB();
				}
				else
				{
					this.DBDCOHCCLHB();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1538f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 207f)
			{
				this.HNCLGJKBCBI();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 822f, gpfidejemeg);
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0006C76C File Offset: 0x0006A96C
	private void CGOFBHQPHQH(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)7;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 494f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 1906f || vector.y != 435f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1901f * this.ILKGGGEDGOE), 571f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.QHFDLHFIDLL(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
					{
						this.DEGJCGCMBHB();
					}
				}
			}
		}
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x0006C920 File Offset: 0x0006AB20
	public void FGIOGDNHQOQ()
	{
		if (this.KOGFJFBCIFN == null)
		{
			this.EOFOQLNKNCN();
		}
		if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
		{
			this.EDIELLJMCKN();
			if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
			{
				this.HLEIQCCCFHK();
			}
			else
			{
				this.BMDKMHGMFDN();
			}
		}
		if (this.CCHQQHIFDBO.magnitude < 1600f)
		{
			this.PEPIOKBLHJO();
		}
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x0006C9A8 File Offset: 0x0006ABA8
	private void NBHGIOIFCDK(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.FCGMFIPGCHH(true);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
	private void HMQOONLDOLQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.KQPPFINIJDG();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1007f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 758f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.GDDCELDNLOG(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1654f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.QEQGPGBNPPE();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.HLEIQCCCFHK();
				}
				else
				{
					this.BMDKMHGMFDN();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1383f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 828f)
			{
				this.HCILLIGDHDP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1630f, gpfidejemeg);
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x0006CC58 File Offset: 0x0006AE58
	private void GDDCELDNLOG(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.GCHMLEJKKJB(true);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x0006CD78 File Offset: 0x0006AF78
	private void EDIELLJMCKN()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 0; i < 7; i++)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[1], Vector3.zero);
			for (int j = 0; j < 5; j += 0)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x0006CE44 File Offset: 0x0006B044
	private void HJCCEHMKHQC()
	{
		if (this.scrollWheelFactor != 20f)
		{
			this.IBPKONNQLFB = this.scale * this.scrollWheelFactor;
			this.scrollWheelFactor = 988f;
		}
		if (this.PCOHPOONNME == null && this.ILBCCCBJNCL != null && Application.isPlaying)
		{
			ENFMCDNLEQQ component = this.ILBCCCBJNCL.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				this.PCOHPOONNME = component;
			}
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00007054 File Offset: 0x00005254
	public void EHMMCFFCBOI(Vector3 BGBMIEJJQKC)
	{
		this.scale = BGBMIEJJQKC;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0006C46C File Offset: 0x0006A66C
	private void KFQOPMOEQOP()
	{
		this.KOGFJFBCIFN = ((!(this.ILBCCCBJNCL != null)) ? null : KQHJOLQLQBJ.CQGLPBCNFGL(this.ILBCCCBJNCL.transform.parent));
		if (this.KOGFJFBCIFN == null)
		{
			this.OGQEPEGLEPO = false;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0000705D File Offset: 0x0000525D
	// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00007054 File Offset: 0x00005254
	public Vector3 FJCLLOHOIEN
	{
		get
		{
			return this.scale;
		}
		set
		{
			this.scale = value;
		}
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x0006CEE8 File Offset: 0x0006B0E8
	public void HEMBFJCMQNE()
	{
		if (this.KOGFJFBCIFN == null)
		{
			this.KFQOPMOEQOP();
		}
		if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
		{
			this.EBOQBBFIKEB();
			if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
			{
				this.KEBCJFMFNOP();
			}
			else
			{
				this.NKMCQHHQIQP();
			}
		}
		if (this.CCHQQHIFDBO.magnitude < 0.0001f)
		{
			this.KEBCJFMFNOP();
		}
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00007011 File Offset: 0x00005211
	private void PELQDGFIJDH()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00007065 File Offset: 0x00005265
	private void EDLJMBBIEQN(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 1971f);
		}
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x0000709F File Offset: 0x0000529F
	private void JIMEQOOGFEG(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 856f);
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x0006CF70 File Offset: 0x0006B170
	private void DDHGKDDQEFP(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)6;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1779f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 1735f || vector.y != 865f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (360f * this.ILKGGGEDGOE), 1144f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.JCJEGELCIQL(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)4 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
					{
						this.PEPIOKBLHJO();
					}
				}
			}
		}
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 IBEHQFPGQCL()
	{
		return this.scale;
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 OFMFBKBCDDD()
	{
		return this.scale;
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x000070D9 File Offset: 0x000052D9
	private void MKQFKMQDGPE()
	{
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x0006D124 File Offset: 0x0006B324
	private void OECIHLQONNE(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -25)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -26)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 534f && timeScale != 1877f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = true;
							this.PNBOOLEOKCI = true;
							this.HCILLIGDHDP();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.LLNDKCJPEFJ();
							}
							if (this.OGQEPEGLEPO)
							{
								this.QEQGPGBNPPE();
							}
							this.DBDCOHCCLHB();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = false;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)4 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
						{
							this.HNCLGJKBCBI();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x0006D28C File Offset: 0x0006B48C
	private void LMPGLQDFFKB()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 1; i < 3; i += 0)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[0], Vector3.zero);
			for (int j = 0; j < 8; j++)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x0006D358 File Offset: 0x0006B558
	public void DJPNLNQDOGJ()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = true;
		}
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x0006D384 File Offset: 0x0006B584
	public void BPOPBCEDDJL()
	{
		if (this.KOGFJFBCIFN == null)
		{
			this.LLNDKCJPEFJ();
		}
		if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
		{
			this.QEQGPGBNPPE();
			if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
			{
				this.HNCLGJKBCBI();
			}
			else
			{
				this.PHOOKQFPPHB();
			}
		}
		if (this.CCHQQHIFDBO.magnitude < 39f)
		{
			this.HCILLIGDHDP();
		}
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x0006D40C File Offset: 0x0006B60C
	private void KMNECEKIKIH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.FOPBGFNNLMJ();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 98f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 158f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.LLNDKCJPEFJ();
			}
			this.GDDCELDNLOG(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1563f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.EDIELLJMCKN();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.HLEIQCCCFHK();
				}
				else
				{
					this.DJPNLNQDOGJ();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1697f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 429f)
			{
				this.HCILLIGDHDP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 578f, gpfidejemeg);
		}
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x0006D59C File Offset: 0x0006B79C
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 20f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 0.0001f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.DFMMCLFKFBH(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.EBOQBBFIKEB();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.KEBCJFMFNOP();
				}
				else
				{
					this.NKMCQHHQIQP();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 0.0001f)
			{
				this.KEBCJFMFNOP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 9f, gpfidejemeg);
		}
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x0006D72C File Offset: 0x0006B92C
	private void FFMOLDQLBEE(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != 51)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != 28)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 1501f && timeScale != 1694f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = true;
							this.PNBOOLEOKCI = false;
							this.HCILLIGDHDP();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.KFQOPMOEQOP();
							}
							if (this.OGQEPEGLEPO)
							{
								this.LMPGLQDFFKB();
							}
							this.NLPEDILLNJI();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = true;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
						{
							this.HNCLGJKBCBI();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x000070E2 File Offset: 0x000052E2
	private void FONJKQEGHNJ(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 1102f);
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x0006D894 File Offset: 0x0006BA94
	private void HEJPNBPGIHG(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.IEQQJNLJCKP(true);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00007011 File Offset: 0x00005211
	private void OnDisable()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 QEFKFBJBPCM()
	{
		return this.scale;
	}

	// Token: 0x06000CC0 RID: 3264 RVA: 0x0006D9B4 File Offset: 0x0006BBB4
	private void QMJJHBLFLDP()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 1; i < 5; i += 0)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[0], Vector3.zero);
			for (int j = 0; j < 0; j++)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void HCILLIGDHDP()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00007011 File Offset: 0x00005211
	private void DEJLQNOFBDG()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0006DA80 File Offset: 0x0006BC80
	private void GCCGPFLIEBH(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)4;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 362f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 520f || vector.y != 1296f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1531f * this.ILKGGGEDGOE), 285f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.HEJPNBPGIHG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)4 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.DEGJCGCMBHB();
					}
				}
			}
		}
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x0006DC34 File Offset: 0x0006BE34
	private void IEBQOMBIIKB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.QCDDBMBNQLO();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 885f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 1841f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.LLNDKCJPEFJ();
			}
			this.JNEEDGLHMHP(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1145f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.KPMEGPNLELK();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.PEPIOKBLHJO();
				}
				else
				{
					this.NLPEDILLNJI();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1615f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 30f)
			{
				this.HCILLIGDHDP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 53f, gpfidejemeg);
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x0006DDC4 File Offset: 0x0006BFC4
	private void NHNPFBBEPPJ(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -58)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -111)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 1280f && timeScale != 1100f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = true;
							this.PNBOOLEOKCI = false;
							this.QBEKCEPIFLO();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.EOFOQLNKNCN();
							}
							if (this.OGQEPEGLEPO)
							{
								this.MDKIQJKHEEE();
							}
							this.PHOOKQFPPHB();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = true;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)3 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
						{
							this.QBEKCEPIFLO();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x0006DF2C File Offset: 0x0006C12C
	private void NOLJPIMNCBC(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)8;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 660f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 1929f || vector.y != 1566f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1107f * this.ILKGGGEDGOE), 1899f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.HEJPNBPGIHG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)5 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.KEBCJFMFNOP();
					}
				}
			}
		}
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0000711C File Offset: 0x0000531C
	private void JQQGMGIEHEQ(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 497f);
		}
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0006E0E0 File Offset: 0x0006C2E0
	private void EJQKNLEBMGE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.QPEECHQDHFG();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1505f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 178f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.QIGGFPHFQOI();
			}
			this.JCJEGELCIQL(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 650f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.KPMEGPNLELK();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.DEGJCGCMBHB();
				}
				else
				{
					this.NLPEDILLNJI();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 311f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 1656f)
			{
				this.QBEKCEPIFLO();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1635f, gpfidejemeg);
		}
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void HLEIQCCCFHK()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 ICMBKEMQGHH()
	{
		return this.scale;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void KEBCJFMFNOP()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x0006E270 File Offset: 0x0006C470
	private void MDKIQJKHEEE()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 0; i < 3; i++)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[1], Vector3.zero);
			for (int j = 0; j < 2; j += 0)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x0006E33C File Offset: 0x0006C53C
	private void BIQLBDMMDFK()
	{
		if (this.scrollWheelFactor != 988f)
		{
			this.IBPKONNQLFB = this.scale * this.scrollWheelFactor;
			this.scrollWheelFactor = 676f;
		}
		if (this.PCOHPOONNME == null && this.ILBCCCBJNCL != null && Application.isPlaying)
		{
			ENFMCDNLEQQ component = this.ILBCCCBJNCL.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				this.PCOHPOONNME = component;
			}
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
	public void DBDCOHCCLHB()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00007054 File Offset: 0x00005254
	public void PQMGOPBNJHD(Vector3 BGBMIEJJQKC)
	{
		this.scale = BGBMIEJJQKC;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x0006C46C File Offset: 0x0006A66C
	private void LLNDKCJPEFJ()
	{
		this.KOGFJFBCIFN = ((!(this.ILBCCCBJNCL != null)) ? null : KQHJOLQLQBJ.CQGLPBCNFGL(this.ILBCCCBJNCL.transform.parent));
		if (this.KOGFJFBCIFN == null)
		{
			this.OGQEPEGLEPO = false;
		}
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0006E40C File Offset: 0x0006C60C
	private void OnPress(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -3)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 0.01f && timeScale != 0f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = true;
							this.PNBOOLEOKCI = false;
							this.KEBCJFMFNOP();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.KFQOPMOEQOP();
							}
							if (this.OGQEPEGLEPO)
							{
								this.EBOQBBFIKEB();
							}
							this.NKMCQHHQIQP();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = false;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
						{
							this.KEBCJFMFNOP();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0006E574 File Offset: 0x0006C774
	private void HKJPPHFBPHE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.KFJQLEKKMOD();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1864f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 683f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.JCJEGELCIQL(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 35f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.KPMEGPNLELK();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.HNCLGJKBCBI();
				}
				else
				{
					this.DBDCOHCCLHB();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 838f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 1058f)
			{
				this.QBEKCEPIFLO();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 148f, gpfidejemeg);
		}
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0006E704 File Offset: 0x0006C904
	private void BCBIEPHJOGG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.QMLMHDJFJOP();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 179f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 1114f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.QHFDLHFIDLL(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1568f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.EBOQBBFIKEB();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.QBEKCEPIFLO();
				}
				else
				{
					this.DBDCOHCCLHB();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 86f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 334f)
			{
				this.HNCLGJKBCBI();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 937f, gpfidejemeg);
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x0006E894 File Offset: 0x0006CA94
	private void FNIKECEBHDD(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)7;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1523f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 1110f || vector.y != 250f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1629f * this.ILKGGGEDGOE), 1817f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.JNEEDGLHMHP(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)7 && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
					{
						this.DEGJCGCMBHB();
					}
				}
			}
		}
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
	public void PHOOKQFPPHB()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x0006EA48 File Offset: 0x0006CC48
	public void LPEINOIQBBN()
	{
		if (this.KOGFJFBCIFN == null)
		{
			this.QIGGFPHFQOI();
		}
		if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
		{
			this.LMPGLQDFFKB();
			if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
			{
				this.DEGJCGCMBHB();
			}
			else
			{
				this.NLPEDILLNJI();
			}
		}
		if (this.CCHQQHIFDBO.magnitude < 1585f)
		{
			this.HNCLGJKBCBI();
		}
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
	private void JNEEDGLHMHP(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.IEQQJNLJCKP(false);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x0006EBF0 File Offset: 0x0006CDF0
	private void LOEPGBEFDED(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)6;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 982f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 361f || vector.y != 1384f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1293f * this.ILKGGGEDGOE), 1018f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.GDDCELDNLOG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.HLEIQCCCFHK();
					}
				}
			}
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00007156 File Offset: 0x00005356
	private void OnScroll(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 0.05f);
		}
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x0006CC58 File Offset: 0x0006AE58
	private void DFMMCLFKFBH(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.GCHMLEJKKJB(true);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x0006D358 File Offset: 0x0006B558
	public void NLPEDILLNJI()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = true;
		}
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x0006D358 File Offset: 0x0006B558
	public void BMDKMHGMFDN()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = true;
		}
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x0006EDA4 File Offset: 0x0006CFA4
	private void MPKFNCKLFLK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.DEHFGOQHJCP();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 1898f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 1727f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.EOFOQLNKNCN();
			}
			this.JCJEGELCIQL(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 798f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.CIDEPEJHQCN();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
				{
					this.PEPIOKBLHJO();
				}
				else
				{
					this.NLPEDILLNJI();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 819f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 533f)
			{
				this.HCILLIGDHDP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 269f, gpfidejemeg);
		}
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x0006EF34 File Offset: 0x0006D134
	private void OJHIFOCCJJP()
	{
		if (this.scrollWheelFactor != 1084f)
		{
			this.IBPKONNQLFB = this.scale * this.scrollWheelFactor;
			this.scrollWheelFactor = 1016f;
		}
		if (this.PCOHPOONNME == null && this.ILBCCCBJNCL != null && Application.isPlaying)
		{
			ENFMCDNLEQQ component = this.ILBCCCBJNCL.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				this.PCOHPOONNME = component;
			}
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
	private void NBNLIDGGLNH(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -76)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != 125)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 613f && timeScale != 1098f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = false;
							this.PNBOOLEOKCI = false;
							this.KEBCJFMFNOP();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.KFQOPMOEQOP();
							}
							if (this.OGQEPEGLEPO)
							{
								this.QEQGPGBNPPE();
							}
							this.ENONINDCPLQ();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = true;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)8 && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
						{
							this.HLEIQCCCFHK();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x0006F140 File Offset: 0x0006D340
	private void MGNCJDGGKGH()
	{
		if (this.scrollWheelFactor != 1281f)
		{
			this.IBPKONNQLFB = this.scale * this.scrollWheelFactor;
			this.scrollWheelFactor = 141f;
		}
		if (this.PCOHPOONNME == null && this.ILBCCCBJNCL != null && Application.isPlaying)
		{
			ENFMCDNLEQQ component = this.ILBCCCBJNCL.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				this.PCOHPOONNME = component;
			}
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
	private void IGHIEPMQPHB(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.Always;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1851f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 1654f || vector.y != 1917f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (748f * this.ILKGGGEDGOE), 1995f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.HEJPNBPGIHG(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)8 && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.HCILLIGDHDP();
					}
				}
			}
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x0006F398 File Offset: 0x0006D598
	private void FLMKQCEQKLN()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 1; i < 8; i += 0)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[1], Vector3.zero);
			for (int j = 1; j < 5; j += 0)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0006F464 File Offset: 0x0006D664
	private void FJGHCONLOHO()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.FCHGFPDIGLN();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 251f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 285f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.EOFOQLNKNCN();
			}
			this.QHFDLHFIDLL(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 699f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.MDKIQJKHEEE();
				if (this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.QBEKCEPIFLO();
				}
				else
				{
					this.NLPEDILLNJI();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1298f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 1726f)
			{
				this.HCILLIGDHDP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1039f, gpfidejemeg);
		}
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 CPIGDFQFEPC()
	{
		return this.scale;
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x00007011 File Offset: 0x00005211
	private void QODNBPPJCCJ()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
	public void ENONINDCPLQ()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
	private void OnEnable()
	{
		if (this.scrollWheelFactor != 0f)
		{
			this.IBPKONNQLFB = this.scale * this.scrollWheelFactor;
			this.scrollWheelFactor = 0f;
		}
		if (this.PCOHPOONNME == null && this.ILBCCCBJNCL != null && Application.isPlaying)
		{
			ENFMCDNLEQQ component = this.ILBCCCBJNCL.GetComponent<ENFMCDNLEQQ>();
			if (component != null)
			{
				this.PCOHPOONNME = component;
			}
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x0006F698 File Offset: 0x0006D898
	private void OnDrag(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = EMENMKHBPQE.BPHEELOICGK.BasedOnDelta;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 0f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = true;
					vector = Vector3.zero;
				}
				if (vector.x != 0f || vector.y != 0f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (0.01f * this.ILKGGGEDGOE), 0.67f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.DFMMCLFKFBH(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.KEBCJFMFNOP();
					}
				}
			}
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00007190 File Offset: 0x00005390
	private void HJIQKQKGOCF(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 1941f);
		}
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x0006F84C File Offset: 0x0006DA4C
	private void BBLKHJONIGC(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)5;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 841f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 228f || vector.y != 1506f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1064f * this.ILKGGGEDGOE), 465f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.DFMMCLFKFBH(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.HLEIQCCCFHK();
					}
				}
			}
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
	public void NKMCQHHQIQP()
	{
		QHQFGHKIMMF component = this.ILBCCCBJNCL.GetComponent<QHQFGHKIMMF>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x06000CEC RID: 3308 RVA: 0x0006FA00 File Offset: 0x0006DC00
	private void OHLQKMKEOPF(bool KCICOJFDCPQ)
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != 86)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != 87)
			{
				float timeScale = Time.timeScale;
				if (timeScale < 1102f && timeScale != 627f)
				{
					return;
				}
				if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
				{
					if (KCICOJFDCPQ)
					{
						if (!this.EIQLEKDFMMC)
						{
							this.POLHMLCDHLI = EMENMKHBPQE.JQCODFPLPNJ;
							this.EIQLEKDFMMC = true;
							this.PNBOOLEOKCI = true;
							this.KEBCJFMFNOP();
							if (this.OGQEPEGLEPO && this.KOGFJFBCIFN == null)
							{
								this.KFQOPMOEQOP();
							}
							if (this.OGQEPEGLEPO)
							{
								this.LMPGLQDFFKB();
							}
							this.ENONINDCPLQ();
							Transform transform = EMENMKHBPQE.EBNOGGPBLNC.transform;
							this.LHEPDNHCQIQ = new Plane(((!(this.KOGFJFBCIFN != null)) ? transform.rotation : this.KOGFJFBCIFN.CGDFDPHIENG.rotation) * Vector3.back, EMENMKHBPQE.EMDQJGDFDBP);
						}
					}
					else if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ)
					{
						this.EIQLEKDFMMC = false;
						if (this.OGQEPEGLEPO && this.NNFKGOHBEHF == (CGINEOGDPGP.DHDOBNJKEPM)7 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
						{
							this.DEGJCGCMBHB();
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0006FB68 File Offset: 0x0006DD68
	private void NGDQQJLLEPG(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)6;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 1165f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = false;
					vector = Vector3.zero;
				}
				if (vector.x != 20f || vector.y != 1565f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1496f * this.ILKGGGEDGOE), 443f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.NBHGIOIFCDK(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != (CGINEOGDPGP.DHDOBNJKEPM)3 && this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, true))
					{
						this.HCILLIGDHDP();
					}
				}
			}
		}
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0006FD1C File Offset: 0x0006DF1C
	public void MBLLPFQIPPF()
	{
		if (this.KOGFJFBCIFN == null)
		{
			this.QIGGFPHFQOI();
		}
		if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
		{
			this.QEQGPGBNPPE();
			if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.None))
			{
				this.PEPIOKBLHJO();
			}
			else
			{
				this.PHOOKQFPPHB();
			}
		}
		if (this.CCHQQHIFDBO.magnitude < 149f)
		{
			this.HLEIQCCCFHK();
		}
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x0006CC58 File Offset: 0x0006AE58
	private void QHFDLHFIDLL(Vector3 BMBHKIDFBEJ)
	{
		if (this.KOGFJFBCIFN != null)
		{
			this.ONILBEGGHMC += BMBHKIDFBEJ;
			Transform parent = this.ILBCCCBJNCL.parent;
			Rigidbody component = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
			if (parent != null)
			{
				Vector3 vector = parent.worldToLocalMatrix.MultiplyPoint3x4(this.ONILBEGGHMC);
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
				if (component != null)
				{
					vector = parent.localToWorldMatrix.MultiplyPoint3x4(vector);
					component.position = vector;
				}
				else
				{
					this.ILBCCCBJNCL.localPosition = vector;
				}
			}
			else if (component != null)
			{
				component.position = this.ONILBEGGHMC;
			}
			else
			{
				this.ILBCCCBJNCL.position = this.ONILBEGGHMC;
			}
			FKBFPICKJQG component2 = this.KOGFJFBCIFN.GetComponent<FKBFPICKJQG>();
			if (component2 != null)
			{
				component2.GCHMLEJKKJB(true);
			}
		}
		else
		{
			this.ILBCCCBJNCL.position += BMBHKIDFBEJ;
		}
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
	private void CIDEPEJHQCN()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 1; i < 3; i += 0)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[1], Vector3.zero);
			for (int j = 0; j < 6; j++)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00007054 File Offset: 0x00005254
	public void HKENHCBMFBI(Vector3 BGBMIEJJQKC)
	{
		this.scale = BGBMIEJJQKC;
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00007054 File Offset: 0x00005254
	public void GCGCEHEBJGI(Vector3 BGBMIEJJQKC)
	{
		this.scale = BGBMIEJJQKC;
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x0000705D File Offset: 0x0000525D
	public Vector3 QEGBHKPOIDH()
	{
		return this.scale;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x0006FE70 File Offset: 0x0006E070
	private void OOELGMKGQPO(Vector2 JDOGIQGGLKM)
	{
		if (this.EIQLEKDFMMC && this.POLHMLCDHLI == EMENMKHBPQE.JQCODFPLPNJ && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && this.ILBCCCBJNCL != null)
		{
			EMENMKHBPQE.JHEDGGMDIEE.DQJIOQQLEEB = (EMENMKHBPQE.BPHEELOICGK)5;
			Ray ray = EMENMKHBPQE.EBNOGGPBLNC.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			float distance = 110f;
			if (this.LHEPDNHCQIQ.Raycast(ray, out distance))
			{
				Vector3 point = ray.GetPoint(distance);
				Vector3 vector = point - this.HEMHOMBDIJC;
				this.HEMHOMBDIJC = point;
				if (!this.PNBOOLEOKCI)
				{
					this.PNBOOLEOKCI = true;
					vector = Vector3.zero;
				}
				if (vector.x != 896f || vector.y != 814f)
				{
					vector = this.ILBCCCBJNCL.InverseTransformDirection(vector);
					vector.Scale(this.scale);
					vector = this.ILBCCCBJNCL.TransformDirection(vector);
				}
				if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.None)
				{
					this.CCHQQHIFDBO = Vector3.Lerp(this.CCHQQHIFDBO, this.CCHQQHIFDBO + vector * (1291f * this.ILKGGGEDGOE), 1770f);
				}
				Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
				this.JCJEGELCIQL(vector);
				if (this.OGQEPEGLEPO)
				{
					this.FKKNDHFECQL.center = this.FKKNDHFECQL.center + (this.ILBCCCBJNCL.localPosition - localPosition);
					if (this.NNFKGOHBEHF != CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring && this.KOGFJFBCIFN.MIBIEBMEQCC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, false))
					{
						this.DEGJCGCMBHB();
					}
				}
			}
		}
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x000071CA File Offset: 0x000053CA
	private void QECBDFBHQED(float JDOGIQGGLKM)
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.HCLBPEMQFBO -= this.IBPKONNQLFB * (JDOGIQGGLKM * 1790f);
		}
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void DEGJCGCMBHB()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	public void HNCLGJKBCBI()
	{
		if (this.ILBCCCBJNCL != null)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			this.ILBCCCBJNCL.localPosition = localPosition;
		}
		this.ONILBEGGHMC = ((!(this.ILBCCCBJNCL != null)) ? Vector3.zero : this.ILBCCCBJNCL.position);
		this.CCHQQHIFDBO = Vector3.zero;
		this.HCLBPEMQFBO = Vector3.zero;
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00070024 File Offset: 0x0006E224
	private void KPMEGPNLELK()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 1; i < 5; i++)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[0], Vector3.zero);
			for (int j = 1; j < 7; j += 0)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x000700F0 File Offset: 0x0006E2F0
	private void CPNQCCCNPMM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		float gpfidejemeg = JMIOBJFFGBN.PPIKCLHKEIH();
		this.CCHQQHIFDBO -= this.HCLBPEMQFBO;
		this.HCLBPEMQFBO = JNNGOIIKENH.IKCQOQFIENL(this.HCLBPEMQFBO, Vector3.zero, 555f, gpfidejemeg);
		if (this.CCHQQHIFDBO.magnitude < 15f)
		{
			Vector3 localPosition = this.ILBCCCBJNCL.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			if (this.ILBCCCBJNCL.localPosition != localPosition)
			{
				this.ILBCCCBJNCL.localPosition = localPosition;
			}
			return;
		}
		if (!this.EIQLEKDFMMC)
		{
			if (this.KOGFJFBCIFN == null)
			{
				this.KFQOPMOEQOP();
			}
			this.GDDCELDNLOG(JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1886f, gpfidejemeg));
			if (this.OGQEPEGLEPO && this.KOGFJFBCIFN != null)
			{
				this.KPMEGPNLELK();
				if (this.KOGFJFBCIFN.BPJCFGQKBPC(this.ILBCCCBJNCL, ref this.FKKNDHFECQL, this.NNFKGOHBEHF == CGINEOGDPGP.DHDOBNJKEPM.Momentum))
				{
					this.DEGJCGCMBHB();
				}
				else
				{
					this.BMDKMHGMFDN();
				}
			}
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 1701f, gpfidejemeg);
			if (this.CCHQQHIFDBO.magnitude < 1395f)
			{
				this.KEBCJFMFNOP();
			}
		}
		else
		{
			JNNGOIIKENH.BNIGGHLNIOB(ref this.CCHQQHIFDBO, 324f, gpfidejemeg);
		}
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00007011 File Offset: 0x00005211
	private void BKNILFIBHIF()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00070280 File Offset: 0x0006E480
	private void EBOQBBFIKEB()
	{
		if (this.PCOHPOONNME)
		{
			Transform cgdfdphieng = this.KOGFJFBCIFN.CGDFDPHIENG;
			Matrix4x4 worldToLocalMatrix = cgdfdphieng.worldToLocalMatrix;
			Vector3[] pmcnqichcle = this.PCOHPOONNME.PMCNQICHCLE;
			for (int i = 0; i < 4; i++)
			{
				pmcnqichcle[i] = worldToLocalMatrix.MultiplyPoint3x4(pmcnqichcle[i]);
			}
			this.FKKNDHFECQL = new Bounds(pmcnqichcle[0], Vector3.zero);
			for (int j = 1; j < 4; j++)
			{
				this.FKKNDHFECQL.Encapsulate(pmcnqichcle[j]);
			}
		}
		else
		{
			this.FKKNDHFECQL = JNNGOIIKENH.HFMJNILQCMK(this.KOGFJFBCIFN.CGDFDPHIENG, this.ILBCCCBJNCL);
		}
	}

	// Token: 0x040001CD RID: 461
	public Transform ILBCCCBJNCL;

	// Token: 0x040001CE RID: 462
	public KQHJOLQLQBJ KOGFJFBCIFN;

	// Token: 0x040001CF RID: 463
	public Vector3 IBPKONNQLFB = Vector3.zero;

	// Token: 0x040001D0 RID: 464
	public bool OGQEPEGLEPO;

	// Token: 0x040001D1 RID: 465
	public BLMNBILNMOE PCOHPOONNME;

	// Token: 0x040001D2 RID: 466
	public CGINEOGDPGP.DHDOBNJKEPM NNFKGOHBEHF = CGINEOGDPGP.DHDOBNJKEPM.MomentumAndSpring;

	// Token: 0x040001D3 RID: 467
	public float ILKGGGEDGOE = 35f;

	// Token: 0x040001D4 RID: 468
	[SerializeField]
	protected Vector3 scale = new Vector3(1f, 1f, 0f);

	// Token: 0x040001D5 RID: 469
	[SerializeField]
	[HideInInspector]
	private float scrollWheelFactor;

	// Token: 0x040001D6 RID: 470
	private Plane LHEPDNHCQIQ;

	// Token: 0x040001D7 RID: 471
	private Vector3 ONILBEGGHMC;

	// Token: 0x040001D8 RID: 472
	private Vector3 HEMHOMBDIJC;

	// Token: 0x040001D9 RID: 473
	private Vector3 CCHQQHIFDBO = Vector3.zero;

	// Token: 0x040001DA RID: 474
	private Vector3 HCLBPEMQFBO = Vector3.zero;

	// Token: 0x040001DB RID: 475
	private Bounds FKKNDHFECQL;

	// Token: 0x040001DC RID: 476
	private int POLHMLCDHLI;

	// Token: 0x040001DD RID: 477
	private bool PNBOOLEOKCI;

	// Token: 0x040001DE RID: 478
	private bool EIQLEKDFMMC;

	// Token: 0x0200005C RID: 92
	public enum DHDOBNJKEPM
	{
		// Token: 0x040001E0 RID: 480
		None,
		// Token: 0x040001E1 RID: 481
		Momentum,
		// Token: 0x040001E2 RID: 482
		MomentumAndSpring
	}
}
