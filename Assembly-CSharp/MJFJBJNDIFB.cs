using System;
using UnityEngine;

// Token: 0x02000124 RID: 292
[AddComponentMenu("NGUI/UI/Stretch")]
[ExecuteInEditMode]
public class MJFJBJNDIFB : MonoBehaviour
{
	// Token: 0x060021C1 RID: 8641 RVA: 0x000DA018 File Offset: 0x000D8218
	private void OBNDQJFDQEK()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1151f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 525f : ((float)this.KLLHOMMGBLK.PJKMJPJJJJP() / (float)Screen.height * 1310f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 373f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 1392f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.PNBFQDLQENI;
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 304f && num4 > 406f)
			{
				float num5 = (float)this.KLLHOMMGBLK.CBENPIBLJLQ() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.JKGBHEHKBPC());
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.BasedOnHeight)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)7)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1992f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Both)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.MGQIGGNBBBD(Mathf.RoundToInt(vector2.y));
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.LGMLEMDQJHB();
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.BasedOnHeight)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = true;
			}
		}
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x00012289 File Offset: 0x00010489
	private void DGJDQDOFNFP()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FDFPIPELOOD));
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x000122AB File Offset: 0x000104AB
	private void HLQJEFKDDGC()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.PIQDBCGQDCH();
		}
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000122C3 File Offset: 0x000104C3
	private void IBINBCIKIQF()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.OBNDQJFDQEK();
		}
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x000DA77C File Offset: 0x000D897C
	private void GGGNJNNQMED()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.EOPHMKGPNNE();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x000DA800 File Offset: 0x000D8A00
	private void HBOFMLLODDM()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.OBNDQJFDQEK();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000DA884 File Offset: 0x000D8A84
	private void GMFQFQQQFKC()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MNGHNJNCICC));
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x0001230B File Offset: 0x0001050B
	private void JPFKEEQOKMD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000DA8FC File Offset: 0x000D8AFC
	private void QHQEBPKMNLD()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FDFPIPELOOD));
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000DA8FC File Offset: 0x000D8AFC
	private void PBENCICMMLI()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FDFPIPELOOD));
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000DA974 File Offset: 0x000D8B74
	private void IHGDMCFDINH()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000DA9EC File Offset: 0x000D8BEC
	private void LMELGHDGJMQ()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.PIQDBCGQDCH();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000DAA70 File Offset: 0x000D8C70
	private void QQMLFMFEKNH()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.HLQJEFKDDGC));
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000DAAE8 File Offset: 0x000D8CE8
	private void FGPKHMKNGCO()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 179f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 1154f : ((float)this.KLLHOMMGBLK.JDMPLGBGNFB() / (float)Screen.height * 131f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
					this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 1341f;
					this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 371f;
					this.FBPOKBEMCEL.width = qenjmehbneg.z;
					this.FBPOKBEMCEL.height = qenjmehbneg.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.JOGIQGQOEIP();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 124f && num4 > 153f)
			{
				float num5 = (float)this.KLLHOMMGBLK.BEBHMIFIFGC() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.JKGBHEHKBPC());
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
			{
				vector.x = this.FILKEDHIFBL.x * num4;
				vector.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.BasedOnHeight)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num9;
					vector.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.None)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num13;
					vector.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 413f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector.x -= this.BEHGIPBGIGN.x * num14;
				vector.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector.y);
				}
				vector = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Both)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector.y - this.BEHGIPBGIGN.y);
				}
				vector = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.z = vector.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.w = vector.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector)
			{
				this.BLLEFKOLKLP.localScale = vector;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000122AB File Offset: 0x000104AB
	private void MKCNQOJMGDK()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.PIQDBCGQDCH();
		}
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000DB24C File Offset: 0x000D944C
	private void PFQDFBHEJEH()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.IBPJIOLMDLE();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x00012323 File Offset: 0x00010523
	private void FDFPIPELOOD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.PNHPFOHOGMC();
		}
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x0001233B File Offset: 0x0001053B
	private void FBDJGOQCLMI()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.JQPKDIBJHHF();
		}
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x00012353 File Offset: 0x00010553
	private void LCGIHNGPJGF()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JOFLQBQNIFD));
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000DA974 File Offset: 0x000D8B74
	private void Awake()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x00012375 File Offset: 0x00010575
	private void JIFPOIEIQKI()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000DB2D0 File Offset: 0x000D94D0
	private void DCJQFJOICGQ()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.BNQGHGNKEEE));
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x00012397 File Offset: 0x00010597
	private void KMCIPOCHKHQ()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.CIHJOEIFMQE();
		}
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000123AF File Offset: 0x000105AF
	private void LECFHFQQHLC()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.EHBDNIOCHNO();
		}
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x000DB348 File Offset: 0x000D9548
	private void LEJQMIECFCH()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000DB3C0 File Offset: 0x000D95C0
	private void EHBDNIOCHNO()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1359f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 651f : ((float)this.KLLHOMMGBLK.LKGMHOOFCCQ() / (float)Screen.height * 1215f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
					this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 273f;
					this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 197f;
					this.FBPOKBEMCEL.width = qenjmehbneg.z;
					this.FBPOKBEMCEL.height = qenjmehbneg.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.PNBFQDLQENI;
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 486f && num4 > 1786f)
			{
				float num5 = (float)this.KLLHOMMGBLK.ILQIODGPBCD() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.JKGBHEHKBPC());
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
			{
				vector.x = this.FILKEDHIFBL.x * num4;
				vector.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num9;
					vector.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num13;
					vector.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)7)
				{
					vector.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 39f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector.x -= this.BEHGIPBGIGN.x * num14;
				vector.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.LNMJLFLDCML.MGQIGGNBBBD(Mathf.RoundToInt(vector.y));
				}
				vector = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.MGQIGGNBBBD(Mathf.RoundToInt(vector.y - this.BEHGIPBGIGN.y));
				}
				vector = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					giomppijpkn.z = vector.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector)
			{
				this.BLLEFKOLKLP.localScale = vector;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = true;
			}
		}
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000DBB24 File Offset: 0x000D9D24
	private void HPCICOEMKGF()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.FGPKHMKNGCO();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000123C7 File Offset: 0x000105C7
	private void JGEFHEOOGCM()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.KMCIPOCHKHQ));
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000DB24C File Offset: 0x000D944C
	private void KCFPNFCPPCC()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.IBPJIOLMDLE();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000DBBA8 File Offset: 0x000D9DA8
	private void NDFNCDDDJPN()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.IBPJIOLMDLE();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000DBC2C File Offset: 0x000D9E2C
	private void PIQDBCGQDCH()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1944f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 874f : ((float)this.KLLHOMMGBLK.CBFBCDJGHBN() / (float)Screen.height * 1772f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
					this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 780f;
					this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 1225f;
					this.FBPOKBEMCEL.width = qenjmehbneg.z;
					this.FBPOKBEMCEL.height = qenjmehbneg.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.KFLGCIPQMGJ();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 129f && num4 > 506f)
			{
				float num5 = (float)this.KLLHOMMGBLK.IINCKPHJGPC / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
			{
				vector.x = this.FILKEDHIFBL.x * num4;
				vector.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.None)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num9;
					vector.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num13;
					vector.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1805f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector.x -= this.BEHGIPBGIGN.x * num14;
				vector.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector.y);
				}
				vector = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector.y - this.BEHGIPBGIGN.y);
				}
				vector = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					giomppijpkn.z = vector.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
				{
					vector.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector)
			{
				this.BLLEFKOLKLP.localScale = vector;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000DC390 File Offset: 0x000DA590
	private void Start()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.Update();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x00012375 File Offset: 0x00010575
	private void EFDMKMLENGN()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x00012375 File Offset: 0x00010575
	private void DFDIKBGJIPK()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000DB2D0 File Offset: 0x000D94D0
	private void BBFBCBMEJEN()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.BNQGHGNKEEE));
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x00012375 File Offset: 0x00010575
	private void DQPLIHHGNKM()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000DC414 File Offset: 0x000DA614
	private void EOPHMKGPNNE()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1496f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 322f : ((float)this.KLLHOMMGBLK.PJKMJPJJJJP() / (float)Screen.height * 769f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.PGCIILBODCO();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 1571f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 191f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.KFLGCIPQMGJ();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 367f && num4 > 658f)
			{
				float num5 = (float)this.KLLHOMMGBLK.PJKMJPJJJJP() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)7)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1994f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000DCB78 File Offset: 0x000DAD78
	private void PNJGKKPBDEB()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MKCNQOJMGDK));
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x0001230B File Offset: 0x0001050B
	private void JOFLQBQNIFD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000123E9 File Offset: 0x000105E9
	private void PONLQNDQMEQ()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MNGHNJNCICC));
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000DCBF0 File Offset: 0x000DADF0
	private void GBGEGKHDQKB()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.PNHPFOHOGMC();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000DAA70 File Offset: 0x000D8C70
	private void MBDGLQOGLDJ()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.HLQJEFKDDGC));
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000DAA70 File Offset: 0x000D8C70
	private void LQGMIJIJPCM()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.HLQJEFKDDGC));
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x0001240B File Offset: 0x0001060B
	private void ONKEDLLOMCE()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DOFEMMNDDOL));
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000DCC74 File Offset: 0x000DAE74
	private void BBKNQONEBJB()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FBDJGOQCLMI));
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000DCB78 File Offset: 0x000DAD78
	private void ENOBPJMDNEG()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MKCNQOJMGDK));
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000DA9EC File Offset: 0x000D8BEC
	private void NOLQNFCODBK()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.PIQDBCGQDCH();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00012397 File Offset: 0x00010597
	private void DOFEMMNDDOL()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.CIHJOEIFMQE();
		}
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x0001242D File Offset: 0x0001062D
	private void FGONNFBLJDD()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.BNQGHGNKEEE));
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x0001244F File Offset: 0x0001064F
	private void OnDestroy()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000DCCEC File Offset: 0x000DAEEC
	private void Update()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 0.5f : ((float)this.KLLHOMMGBLK.IINCKPHJGPC / (float)Screen.height * 0.5f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
					this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 0.5f;
					this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 0.5f;
					this.FBPOKBEMCEL.width = qenjmehbneg.z;
					this.FBPOKBEMCEL.height = qenjmehbneg.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.PNBFQDLQENI;
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 1f && num4 > 1f)
			{
				float num5 = (float)this.KLLHOMMGBLK.IINCKPHJGPC / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.BasedOnHeight)
			{
				vector.x = this.FILKEDHIFBL.x * num4;
				vector.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num9;
					vector.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num13;
					vector.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector.x -= this.BEHGIPBGIGN.x * num14;
				vector.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector.y);
				}
				vector = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector.y - this.BEHGIPBGIGN.y);
				}
				vector = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					giomppijpkn.z = vector.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.w = vector.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector)
			{
				this.BLLEFKOLKLP.localScale = vector;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x0001230B File Offset: 0x0001050B
	private void BNQGHGNKEEE()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x00012353 File Offset: 0x00010553
	private void ILJNLCBQHPO()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JOFLQBQNIFD));
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000DD450 File Offset: 0x000DB650
	private void CIHJOEIFMQE()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1078f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 1658f : ((float)this.KLLHOMMGBLK.QIEKBBQKDCN() / (float)Screen.height * 1844f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 1492f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 872f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.PNBFQDLQENI;
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 316f && num4 > 1908f)
			{
				float num5 = (float)this.KLLHOMMGBLK.PJKMJPJJJJP() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.None)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.None)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1863f : this.LNMJLFLDCML.QKGJDCFCPMO.MMGGEOGQJDL();
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Both)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.MGQIGGNBBBD(Mathf.RoundToInt(vector2.y));
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.MGQIGGNBBBD(Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y));
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.LGMLEMDQJHB();
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000DDBB4 File Offset: 0x000DBDB4
	private void IBPJIOLMDLE()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 931f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.NQCBILMNLBN() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 1463f : ((float)this.KLLHOMMGBLK.BEBHMIFIFGC() / (float)Screen.height * 494f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
					this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 1416f;
					this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 782f;
					this.FBPOKBEMCEL.width = qenjmehbneg.z;
					this.FBPOKBEMCEL.height = qenjmehbneg.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.JOGIQGQOEIP();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 14f && num4 > 112f)
			{
				float num5 = (float)this.KLLHOMMGBLK.PJKMJPJJJJP() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
			{
				vector.x = this.FILKEDHIFBL.x * num4;
				vector.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num9;
					vector.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.BasedOnHeight)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector.x = num3;
					vector.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector.x = this.MOMPBPKKPBB.x * num13;
					vector.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 957f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector.x -= this.BEHGIPBGIGN.x * num14;
				vector.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.LNMJLFLDCML.MGQIGGNBBBD(Mathf.RoundToInt(vector.y));
				}
				vector = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FitInternalKeepingRatio)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector.y - this.BEHGIPBGIGN.y);
				}
				vector = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.GIOMPPIJPKN;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					giomppijpkn.z = vector.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					vector.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector)
			{
				this.BLLEFKOLKLP.localScale = vector;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000DA974 File Offset: 0x000D8B74
	private void EMMIHJIFJFM()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x0001230B File Offset: 0x0001050B
	private void MNGHNJNCICC()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x000122C3 File Offset: 0x000104C3
	private void BKFIOMQPHHK()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.OBNDQJFDQEK();
		}
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000DE318 File Offset: 0x000DC518
	private void JQPKDIBJHHF()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 457f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 1827f : ((float)this.KLLHOMMGBLK.QIEKBBQKDCN() / (float)Screen.height * 1435f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.PGCIILBODCO();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 363f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 90f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.KFLGCIPQMGJ();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 113f && num4 > 1015f)
			{
				float num5 = (float)this.KLLHOMMGBLK.MDCMIKCOHMQ() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)7)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1913f : this.LNMJLFLDCML.QKGJDCFCPMO.MMGGEOGQJDL();
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.MGQIGGNBBBD(Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y));
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.LGMLEMDQJHB();
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = true;
			}
		}
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000DCBF0 File Offset: 0x000DADF0
	private void GJPGBCKQLDG()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.PNHPFOHOGMC();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000DEA7C File Offset: 0x000DCC7C
	private void PNHPFOHOGMC()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 1557f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 450f : ((float)this.KLLHOMMGBLK.CBFBCDJGHBN() / (float)Screen.height * 1782f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.LPNENHKKEMK();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 1874f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 365f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.JCGLMKGEJQG();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 616f && num4 > 1998f)
			{
				float num5 = (float)this.KLLHOMMGBLK.LKGMHOOFCCQ() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.DFKQMMIQDOO);
			if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)7)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)7)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Both)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1397f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Both)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.LNMJLFLDCML.MGQIGGNBBBD(Mathf.RoundToInt(vector2.y));
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.LGMLEMDQJHB();
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000DF1E0 File Offset: 0x000DD3E0
	private void QOLNLDBHGJL()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DOFEMMNDDOL));
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000DCB78 File Offset: 0x000DAD78
	private void CBLIFECCHIC()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MKCNQOJMGDK));
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000DCB78 File Offset: 0x000DAD78
	private void OJQHKOJJNCP()
	{
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		this.FBPOKBEMCEL = default(Rect);
		this.BLLEFKOLKLP = base.transform;
		this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
		this.CNJGKKDHPOG = base.GetComponent<KQHJOLQLQBJ>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MKCNQOJMGDK));
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000DF258 File Offset: 0x000DD458
	private void HHIBFNMNEBJ()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
		{
			ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
			KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
			float num = 71f;
			if (enfmcdnleqq != null)
			{
				Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(base.transform.parent);
				this.FBPOKBEMCEL.x = bounds.min.x;
				this.FBPOKBEMCEL.y = bounds.min.y;
				this.FBPOKBEMCEL.width = bounds.size.x;
				this.FBPOKBEMCEL.height = bounds.size.y;
			}
			else if (kqhjolqlqbj != null)
			{
				if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
				{
					float num2 = (!(this.KLLHOMMGBLK != null)) ? 1021f : ((float)this.KLLHOMMGBLK.LKGMHOOFCCQ() / (float)Screen.height * 294f);
					this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num2;
					this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num2;
					this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
					this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
				}
				else
				{
					Vector4 vector = kqhjolqlqbj.PGCIILBODCO();
					this.FBPOKBEMCEL.x = vector.x - vector.z * 608f;
					this.FBPOKBEMCEL.y = vector.y - vector.w * 478f;
					this.FBPOKBEMCEL.width = vector.z;
					this.FBPOKBEMCEL.height = vector.w;
				}
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent = base.transform.parent;
				Bounds bounds2 = (!(parent != null)) ? JNNGOIIKENH.HFMJNILQCMK(this.PCJQOFOMCNF.transform) : JNNGOIIKENH.HFMJNILQCMK(parent, this.PCJQOFOMCNF.transform);
				this.FBPOKBEMCEL.x = bounds2.min.x;
				this.FBPOKBEMCEL.y = bounds2.min.y;
				this.FBPOKBEMCEL.width = bounds2.size.x;
				this.FBPOKBEMCEL.height = bounds2.size.y;
			}
			else
			{
				if (!(this.CODFIINNNPG != null))
				{
					return;
				}
				this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
				if (this.KLLHOMMGBLK != null)
				{
					num = this.KLLHOMMGBLK.JOGIQGQOEIP();
				}
			}
			float num3 = this.FBPOKBEMCEL.width;
			float num4 = this.FBPOKBEMCEL.height;
			if (num != 1263f && num4 > 506f)
			{
				float num5 = (float)this.KLLHOMMGBLK.ILQIODGPBCD() / num4;
				num3 *= num5;
				num4 *= num5;
			}
			Vector3 vector2 = (!(this.DLQMOLJPEMO != null)) ? this.BLLEFKOLKLP.localScale : new Vector3((float)this.DLQMOLJPEMO.KJGMGPCEJJD, (float)this.DLQMOLJPEMO.JKGBHEHKBPC());
			if (this.EKDEDJHBGIK == (MJFJBJNDIFB.FKIGIJNOKMK)8)
			{
				vector2.x = this.FILKEDHIFBL.x * num4;
				vector2.y = this.FILKEDHIFBL.y * num4;
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.Both)
			{
				float num6 = num3 / num4;
				float num7 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num7 < num6)
				{
					float num8 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num8;
				}
				else
				{
					float num9 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num9;
					vector2.y = num4;
				}
			}
			else if (this.EKDEDJHBGIK == MJFJBJNDIFB.FKIGIJNOKMK.None)
			{
				float num10 = num3 / num4;
				float num11 = this.MOMPBPKKPBB.x / this.MOMPBPKKPBB.y;
				if (num11 > num10)
				{
					float num12 = num3 / this.MOMPBPKKPBB.x;
					vector2.x = num3;
					vector2.y = this.MOMPBPKKPBB.y * num12;
				}
				else
				{
					float num13 = num4 / this.MOMPBPKKPBB.y;
					vector2.x = this.MOMPBPKKPBB.x * num13;
					vector2.y = num4;
				}
			}
			else
			{
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					vector2.x = this.FILKEDHIFBL.x * num3;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Horizontal)
				{
					vector2.y = this.FILKEDHIFBL.y * num4;
				}
			}
			if (this.LNMJLFLDCML != null)
			{
				float num14 = (!(this.LNMJLFLDCML.QKGJDCFCPMO != null)) ? 1817f : this.LNMJLFLDCML.QKGJDCFCPMO.FNMFIPNGENE;
				vector2.x -= this.BEHGIPBGIGN.x * num14;
				vector2.y -= this.BEHGIPBGIGN.y * num14;
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.FillKeepingRatio)
				{
					this.LNMJLFLDCML.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.LNMJLFLDCML.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.DLQMOLJPEMO != null)
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.Vertical)
				{
					this.DLQMOLJPEMO.KJGMGPCEJJD = Mathf.RoundToInt(vector2.x - this.BEHGIPBGIGN.x);
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					this.DLQMOLJPEMO.DFKQMMIQDOO = Mathf.RoundToInt(vector2.y - this.BEHGIPBGIGN.y);
				}
				vector2 = Vector3.one;
			}
			else if (this.CNJGKKDHPOG != null)
			{
				Vector4 giomppijpkn = this.CNJGKKDHPOG.LGMLEMDQJHB();
				if (this.EKDEDJHBGIK != (MJFJBJNDIFB.FKIGIJNOKMK)8)
				{
					giomppijpkn.z = vector2.x - this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					giomppijpkn.w = vector2.y - this.BEHGIPBGIGN.y;
				}
				this.CNJGKKDHPOG.GIOMPPIJPKN = giomppijpkn;
				vector2 = Vector3.one;
			}
			else
			{
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.x -= this.BEHGIPBGIGN.x;
				}
				if (this.EKDEDJHBGIK != MJFJBJNDIFB.FKIGIJNOKMK.None)
				{
					vector2.y -= this.BEHGIPBGIGN.y;
				}
			}
			if (this.BLLEFKOLKLP.localScale != vector2)
			{
				this.BLLEFKOLKLP.localScale = vector2;
			}
			if (this.MLKEHIGBQOC && Application.isPlaying)
			{
				base.enabled = false;
			}
		}
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000DCBF0 File Offset: 0x000DADF0
	private void MGBMNEQCEBJ()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		this.PNHPFOHOGMC();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x04000755 RID: 1877
	public Camera CODFIINNNPG;

	// Token: 0x04000756 RID: 1878
	public GameObject PCJQOFOMCNF;

	// Token: 0x04000757 RID: 1879
	public MJFJBJNDIFB.FKIGIJNOKMK EKDEDJHBGIK;

	// Token: 0x04000758 RID: 1880
	public bool MLKEHIGBQOC = true;

	// Token: 0x04000759 RID: 1881
	public Vector2 FILKEDHIFBL = Vector2.one;

	// Token: 0x0400075A RID: 1882
	public Vector2 MOMPBPKKPBB = Vector2.one;

	// Token: 0x0400075B RID: 1883
	public Vector2 BEHGIPBGIGN = Vector2.zero;

	// Token: 0x0400075C RID: 1884
	[HideInInspector]
	[SerializeField]
	private ENFMCDNLEQQ widgetContainer;

	// Token: 0x0400075D RID: 1885
	private Transform BLLEFKOLKLP;

	// Token: 0x0400075E RID: 1886
	private ENFMCDNLEQQ DLQMOLJPEMO;

	// Token: 0x0400075F RID: 1887
	private PLQFPBQEPJD LNMJLFLDCML;

	// Token: 0x04000760 RID: 1888
	private KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x04000761 RID: 1889
	private GKDCBJPLQLQ KLLHOMMGBLK;

	// Token: 0x04000762 RID: 1890
	private Animation DBJQBEKGFHP;

	// Token: 0x04000763 RID: 1891
	private Rect FBPOKBEMCEL;

	// Token: 0x04000764 RID: 1892
	private bool PNBOOLEOKCI;

	// Token: 0x02000125 RID: 293
	public enum FKIGIJNOKMK
	{
		// Token: 0x04000766 RID: 1894
		None,
		// Token: 0x04000767 RID: 1895
		Horizontal,
		// Token: 0x04000768 RID: 1896
		Vertical,
		// Token: 0x04000769 RID: 1897
		Both,
		// Token: 0x0400076A RID: 1898
		BasedOnHeight,
		// Token: 0x0400076B RID: 1899
		FillKeepingRatio,
		// Token: 0x0400076C RID: 1900
		FitInternalKeepingRatio
	}
}
