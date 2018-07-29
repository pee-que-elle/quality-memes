using System;
using UnityEngine;

// Token: 0x020000E8 RID: 232
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Anchor")]
public class KQECKBOKHHE : MonoBehaviour
{
	// Token: 0x06001BFA RID: 7162 RVA: 0x0000EE2D File Offset: 0x0000D02D
	private void IBINBCIKIQF()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.EGFFPGCMFOO();
		}
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x000B63F0 File Offset: 0x000B45F0
	private void PEJKGQEGPMM()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.CIHJOEIFMQE();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x0000EE45 File Offset: 0x0000D045
	private void GLJIGNDFIQH()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x000B6474 File Offset: 0x000B4674
	private void Update()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 0.5f : ((float)this.KLLHOMMGBLK.IINCKPHJGPC / (float)Screen.height * 0.5f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
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
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 0.5f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 0.5f;
		Vector3 vector = new Vector3(x, y, 0f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
						{
							vector.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector.x = x;
					goto IL_3D0;
				}
			}
			vector.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
						{
							vector.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector.y = y;
					goto IL_43B;
				}
			}
			vector.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector = this.CODFIINNNPG.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (kqhjolqlqbj != null)
			{
				vector = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector);
			vector.x = (float)Mathf.RoundToInt(vector.x);
			vector.y = (float)Mathf.RoundToInt(vector.y);
			if (this.BLLEFKOLKLP.localPosition != vector)
			{
				this.BLLEFKOLKLP.localPosition = vector;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector)
		{
			this.BLLEFKOLKLP.position = vector;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x0000EE5D File Offset: 0x0000D05D
	private void HOQHKBCMPEK()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x000B6AE0 File Offset: 0x000B4CE0
	private void PFQDFBHEJEH()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.KCBFHOIENIQ();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x0000EE97 File Offset: 0x0000D097
	private void BKFIOMQPHHK()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.QIHJCOLPLBQ();
		}
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x0000EEAF File Offset: 0x0000D0AF
	private void OJHIFOCCJJP()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.BKFIOMQPHHK));
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x000B6B64 File Offset: 0x000B4D64
	private void MHOKPDFOEDP()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.Update();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
	private void FOLCIGMKBPL()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.KCBFHOIENIQ();
		}
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x0000EF01 File Offset: 0x0000D101
	private void OnEnable()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x000B63F0 File Offset: 0x000B45F0
	private void KCFPNFCPPCC()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.CIHJOEIFMQE();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x000B6BE8 File Offset: 0x000B4DE8
	private void JCQCNFLNMNP()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.NIIPIECJPOL();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x000B6C6C File Offset: 0x000B4E6C
	private void LBIFHHFMPHD()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.Update();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x000B6CF0 File Offset: 0x000B4EF0
	private void EHBDNIOCHNO()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = true;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 676f : ((float)this.KLLHOMMGBLK.QNGBNNMFGFQ() / (float)Screen.height * 1512f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 612f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 534f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1491f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 709f;
		Vector3 vector2 = new Vector3(x, y, 456f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x0000EF3B File Offset: 0x0000D13B
	private void FBDJGOQCLMI()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.NIIPIECJPOL();
		}
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000B735C File Offset: 0x000B555C
	private void KDFOLQJDJQJ()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.EGFFPGCMFOO();
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x0000EF53 File Offset: 0x0000D153
	private void PHHBHLQOINH()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x000B73E0 File Offset: 0x000B55E0
	private void CIHJOEIFMQE()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = true;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.NQCBILMNLBN() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 1711f : ((float)this.KLLHOMMGBLK.CBFBCDJGHBN() / (float)Screen.height * 413f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
				this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 1308f;
				this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 1716f;
				this.FBPOKBEMCEL.width = qenjmehbneg.z;
				this.FBPOKBEMCEL.height = qenjmehbneg.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = false;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1847f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 1497f;
		Vector3 vector = new Vector3(x, y, 1232f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left)
						{
							vector.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector.x = x;
					goto IL_3D0;
				}
			}
			vector.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
						{
							vector.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector.y = y;
					goto IL_43B;
				}
			}
			vector.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector = this.CODFIINNNPG.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (kqhjolqlqbj != null)
			{
				vector = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector);
			vector.x = (float)Mathf.RoundToInt(vector.x);
			vector.y = (float)Mathf.RoundToInt(vector.y);
			if (this.BLLEFKOLKLP.localPosition != vector)
			{
				this.BLLEFKOLKLP.localPosition = vector;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector)
		{
			this.BLLEFKOLKLP.position = vector;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x000B6B64 File Offset: 0x000B4D64
	private void Start()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.Update();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x000B7A4C File Offset: 0x000B5C4C
	private void GKBQDQKLPIM()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.NQCBILMNLBN() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 1479f : ((float)this.KLLHOMMGBLK.CBFBCDJGHBN() / (float)Screen.height * 346f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.LPNENHKKEMK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1391f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 1623f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = false;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 696f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 307f;
		Vector3 vector2 = new Vector3(x, y, 1292f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x0000EF75 File Offset: 0x0000D175
	private void NEBJBQOMHDI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DHBDMLQCEND));
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x0000EFAF File Offset: 0x0000D1AF
	private void FDFPIPELOOD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.GKBQDQKLPIM();
		}
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x000B80B8 File Offset: 0x000B62B8
	private void GJPGBCKQLDG()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.NIIPIECJPOL();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x000B813C File Offset: 0x000B633C
	private void OODKHHIPKFC()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = true;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 295f : ((float)this.KLLHOMMGBLK.IINCKPHJGPC / (float)Screen.height * 496f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.PGCIILBODCO();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1946f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 83f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1855f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 7f;
		Vector3 vector2 = new Vector3(x, y, 1820f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x0000EFC7 File Offset: 0x0000D1C7
	private void JPGLIDEBQKM()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.NDNIIIODHIQ));
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x000B87A8 File Offset: 0x000B69A8
	private void FLNFKFECNFJ()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.NQCBILMNLBN() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 623f : ((float)this.KLLHOMMGBLK.JDMPLGBGNFB() / (float)Screen.height * 1489f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1090f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 1989f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = false;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1007f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 86f;
		Vector3 vector2 = new Vector3(x, y, 1826f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x0000EE2D File Offset: 0x0000D02D
	private void IPFPCBJFGGB()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.EGFFPGCMFOO();
		}
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x0000EFAF File Offset: 0x0000D1AF
	private void JOFLQBQNIFD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.GKBQDQKLPIM();
		}
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x0000EF53 File Offset: 0x0000D153
	private void HMJBLNGEQFO()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IBINBCIKIQF));
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x0000EFE9 File Offset: 0x0000D1E9
	private void PCQDDGIICJG()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FJOBPBQKONI));
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x0000F023 File Offset: 0x0000D223
	private void QNGLBFDQQCK()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FBDJGOQCLMI));
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x0000EE97 File Offset: 0x0000D097
	private void MOEOQNEGNFP()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.QIHJCOLPLBQ();
		}
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x0000F045 File Offset: 0x0000D245
	private void CJFHQQNKKCB()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.EHQENOILMPL));
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x0000EF3B File Offset: 0x0000D13B
	private void DHBDMLQCEND()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.NIIPIECJPOL();
		}
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x0000F067 File Offset: 0x0000D267
	private void FBDPQLQPFPM()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPLJBLMEKJJ));
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x0000F089 File Offset: 0x0000D289
	private void OQOENCJJGBG()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DOFEMMNDDOL));
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x0000F0AB File Offset: 0x0000D2AB
	private void DOFEMMNDDOL()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.EHBDNIOCHNO();
		}
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x0000EFC7 File Offset: 0x0000D1C7
	private void IPOJIEGOQFN()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.NDNIIIODHIQ));
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x0000F0C3 File Offset: 0x0000D2C3
	private void NDNIIIODHIQ()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.IGJKHIMGLFH();
		}
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x000B8E5C File Offset: 0x000B705C
	private void NIIPIECJPOL()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = true;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 1194f : ((float)this.KLLHOMMGBLK.MBHLPLLDDNJ() / (float)Screen.height * 1074f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1928f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 944f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = false;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 847f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 430f;
		Vector3 vector2 = new Vector3(x, y, 918f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x000B94C8 File Offset: 0x000B76C8
	private void IGJKHIMGLFH()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 320f : ((float)this.KLLHOMMGBLK.CBENPIBLJLQ() / (float)Screen.height * 131f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.LPNENHKKEMK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1388f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 738f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1293f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 1487f;
		Vector3 vector2 = new Vector3(x, y, 905f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x000B9B34 File Offset: 0x000B7D34
	private void EGFFPGCMFOO()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = true;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 76f : ((float)this.KLLHOMMGBLK.MDCMIKCOHMQ() / (float)Screen.height * 1711f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 vector = kqhjolqlqbj.NMOKFPBGFCK();
				this.FBPOKBEMCEL.x = vector.x - vector.z * 1889f;
				this.FBPOKBEMCEL.y = vector.y - vector.w * 871f;
				this.FBPOKBEMCEL.width = vector.z;
				this.FBPOKBEMCEL.height = vector.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = false;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 192f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 1956f;
		Vector3 vector2 = new Vector3(x, y, 1714f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Left)
						{
							vector2.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector2.x = x;
					goto IL_3D0;
				}
			}
			vector2.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
						{
							vector2.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector2.y = y;
					goto IL_43B;
				}
			}
			vector2.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector2.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector2.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector2.x = Mathf.Round(vector2.x);
				vector2.y = Mathf.Round(vector2.y);
			}
			vector2.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector2 = this.CODFIINNNPG.ScreenToWorldPoint(vector2);
		}
		else
		{
			vector2.x = Mathf.Round(vector2.x);
			vector2.y = Mathf.Round(vector2.y);
			if (kqhjolqlqbj != null)
			{
				vector2 = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector2);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector2 = parent2.TransformPoint(vector2);
				}
			}
			vector2.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector2 = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector2);
			vector2.x = (float)Mathf.RoundToInt(vector2.x);
			vector2.y = (float)Mathf.RoundToInt(vector2.y);
			if (this.BLLEFKOLKLP.localPosition != vector2)
			{
				this.BLLEFKOLKLP.localPosition = vector2;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector2)
		{
			this.BLLEFKOLKLP.position = vector2;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x0000F0DB File Offset: 0x0000D2DB
	private void OBFBEPJEPLO()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MOEOQNEGNFP));
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x0000F115 File Offset: 0x0000D315
	private void BIOKJKMHEFD()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.GLJIGNDFIQH));
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x0000F14F File Offset: 0x0000D34F
	private void NGNFOLIIOCI()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.GLJIGNDFIQH));
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000BA1A0 File Offset: 0x000B83A0
	private void QIHJCOLPLBQ()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.POMCJNMICJP() == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 1779f : ((float)this.KLLHOMMGBLK.ILQIODGPBCD() / (float)Screen.height * 1557f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
				this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 1345f;
				this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 1885f;
				this.FBPOKBEMCEL.width = qenjmehbneg.z;
				this.FBPOKBEMCEL.height = qenjmehbneg.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1275f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 1376f;
		Vector3 vector = new Vector3(x, y, 320f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Bottom)
						{
							vector.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector.x = x;
					goto IL_3D0;
				}
			}
			vector.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomRight)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopRight)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft)
						{
							vector.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector.y = y;
					goto IL_43B;
				}
			}
			vector.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector = this.CODFIINNNPG.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (kqhjolqlqbj != null)
			{
				vector = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector);
			vector.x = (float)Mathf.RoundToInt(vector.x);
			vector.y = (float)Mathf.RoundToInt(vector.y);
			if (this.BLLEFKOLKLP.localPosition != vector)
			{
				this.BLLEFKOLKLP.localPosition = vector;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector)
		{
			this.BLLEFKOLKLP.position = vector;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x000B6B64 File Offset: 0x000B4D64
	private void NOLQNFCODBK()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.Update();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x000BA80C File Offset: 0x000B8A0C
	private void KHFDJHFJMDK()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.EGFFPGCMFOO();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x0000F171 File Offset: 0x0000D371
	private void FKOQKFHIONM()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.IPFPCBJFGGB));
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000BA890 File Offset: 0x000B8A90
	private void CMLGQHQJDGQ()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.GKBQDQKLPIM();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x0000EE45 File Offset: 0x0000D045
	private void JPFKEEQOKMD()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.Update();
		}
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x000BA80C File Offset: 0x000B8A0C
	private void QBGOGFJCLEP()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.EGFFPGCMFOO();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x0000F1AB File Offset: 0x0000D3AB
	private void NLHGFQHJODK()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DOFEMMNDDOL));
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x0000F1E5 File Offset: 0x0000D3E5
	private void IIPBHPOBQGL()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.MOEOQNEGNFP));
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x0000F207 File Offset: 0x0000D407
	private void OnDisable()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.JPFKEEQOKMD));
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x0000EFAF File Offset: 0x0000D1AF
	private void EHQENOILMPL()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.GKBQDQKLPIM();
		}
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x0000F1AB File Offset: 0x0000D3AB
	private void CNQCKGMFEJI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.DBJQBEKGFHP = base.GetComponent<Animation>();
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Combine(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.DOFEMMNDDOL));
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x0000EFAF File Offset: 0x0000D1AF
	private void FJOBPBQKONI()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.GKBQDQKLPIM();
		}
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x0000F023 File Offset: 0x0000D223
	private void PJOJNIOQBLM()
	{
		EMENMKHBPQE.NQHJONQILBP = (EMENMKHBPQE.MLPNICKQPCN)Delegate.Remove(EMENMKHBPQE.NQHJONQILBP, new EMENMKHBPQE.MLPNICKQPCN(this.FBDJGOQCLMI));
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x0000F229 File Offset: 0x0000D429
	private void JPLJBLMEKJJ()
	{
		if (this.PNBOOLEOKCI && this.MLKEHIGBQOC)
		{
			this.OODKHHIPKFC();
		}
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x000BA914 File Offset: 0x000B8B14
	private void LMELGHDGJMQ()
	{
		if (this.PCJQOFOMCNF == null && this.widgetContainer != null)
		{
			this.PCJQOFOMCNF = this.widgetContainer.gameObject;
			this.widgetContainer = null;
		}
		this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(base.gameObject);
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		this.OODKHHIPKFC();
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x000BA998 File Offset: 0x000B8B98
	private void KCBFHOIENIQ()
	{
		if (this.DBJQBEKGFHP != null && this.DBJQBEKGFHP.enabled && this.DBJQBEKGFHP.isPlaying)
		{
			return;
		}
		if (this.BLLEFKOLKLP == null)
		{
			return;
		}
		bool flag = false;
		ENFMCDNLEQQ enfmcdnleqq = (!(this.PCJQOFOMCNF == null)) ? this.PCJQOFOMCNF.GetComponent<ENFMCDNLEQQ>() : null;
		KQHJOLQLQBJ kqhjolqlqbj = (!(this.PCJQOFOMCNF == null) || !(enfmcdnleqq == null)) ? this.PCJQOFOMCNF.GetComponent<KQHJOLQLQBJ>() : null;
		if (enfmcdnleqq != null)
		{
			Bounds bounds = enfmcdnleqq.BOLJCJNFOJH(this.PCJQOFOMCNF.transform.parent);
			this.FBPOKBEMCEL.x = bounds.min.x;
			this.FBPOKBEMCEL.y = bounds.min.y;
			this.FBPOKBEMCEL.width = bounds.size.x;
			this.FBPOKBEMCEL.height = bounds.size.y;
		}
		else if (kqhjolqlqbj != null)
		{
			if (kqhjolqlqbj.GEOIDOMHKLJ == KMCGDKDIJIE.PDFPPCIHPMI.None)
			{
				float num = (!(this.KLLHOMMGBLK != null)) ? 1142f : ((float)this.KLLHOMMGBLK.CBFBCDJGHBN() / (float)Screen.height * 1143f);
				this.FBPOKBEMCEL.xMin = (float)(-(float)Screen.width) * num;
				this.FBPOKBEMCEL.yMin = (float)(-(float)Screen.height) * num;
				this.FBPOKBEMCEL.xMax = -this.FBPOKBEMCEL.xMin;
				this.FBPOKBEMCEL.yMax = -this.FBPOKBEMCEL.yMin;
			}
			else
			{
				Vector4 qenjmehbneg = kqhjolqlqbj.QENJMEHBNEG;
				this.FBPOKBEMCEL.x = qenjmehbneg.x - qenjmehbneg.z * 86f;
				this.FBPOKBEMCEL.y = qenjmehbneg.y - qenjmehbneg.w * 340f;
				this.FBPOKBEMCEL.width = qenjmehbneg.z;
				this.FBPOKBEMCEL.height = qenjmehbneg.w;
			}
		}
		else if (this.PCJQOFOMCNF != null)
		{
			Transform parent = this.PCJQOFOMCNF.transform.parent;
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
			flag = true;
			this.FBPOKBEMCEL = this.CODFIINNNPG.pixelRect;
		}
		float x = (this.FBPOKBEMCEL.xMin + this.FBPOKBEMCEL.xMax) * 1513f;
		float y = (this.FBPOKBEMCEL.yMin + this.FBPOKBEMCEL.yMax) * 1698f;
		Vector3 vector = new Vector3(x, y, 664f);
		if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
		{
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Top)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
						{
							vector.x = this.FBPOKBEMCEL.xMin;
							goto IL_3D0;
						}
					}
					vector.x = x;
					goto IL_3D0;
				}
			}
			vector.x = this.FBPOKBEMCEL.xMax;
			IL_3D0:
			if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.TopLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Right)
			{
				if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
				{
					if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.BottomLeft && this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
					{
						if (this.QONOKDQLJNG != KQECKBOKHHE.JJBOCNCQLIF.Center)
						{
							vector.y = this.FBPOKBEMCEL.yMin;
							goto IL_43B;
						}
					}
					vector.y = y;
					goto IL_43B;
				}
			}
			vector.y = this.FBPOKBEMCEL.yMax;
		}
		IL_43B:
		float width = this.FBPOKBEMCEL.width;
		float height = this.FBPOKBEMCEL.height;
		vector.x += this.GIHHBJEGOPJ.x + this.BBFOHEPQBBQ.x * width;
		vector.y += this.GIHHBJEGOPJ.y + this.BBFOHEPQBBQ.y * height;
		if (flag)
		{
			if (this.CODFIINNNPG.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = this.CODFIINNNPG.WorldToScreenPoint(this.BLLEFKOLKLP.position).z;
			vector = this.CODFIINNNPG.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (kqhjolqlqbj != null)
			{
				vector = kqhjolqlqbj.CGDFDPHIENG.TransformPoint(vector);
			}
			else if (this.PCJQOFOMCNF != null)
			{
				Transform parent2 = this.PCJQOFOMCNF.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = this.BLLEFKOLKLP.position.z;
		}
		if (flag && this.CODFIINNNPG.orthographic && this.BLLEFKOLKLP.parent != null)
		{
			vector = this.BLLEFKOLKLP.parent.InverseTransformPoint(vector);
			vector.x = (float)Mathf.RoundToInt(vector.x);
			vector.y = (float)Mathf.RoundToInt(vector.y);
			if (this.BLLEFKOLKLP.localPosition != vector)
			{
				this.BLLEFKOLKLP.localPosition = vector;
			}
		}
		else if (this.BLLEFKOLKLP.position != vector)
		{
			this.BLLEFKOLKLP.position = vector;
		}
		if (this.MLKEHIGBQOC && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	// Token: 0x0400058A RID: 1418
	public Camera CODFIINNNPG;

	// Token: 0x0400058B RID: 1419
	public GameObject PCJQOFOMCNF;

	// Token: 0x0400058C RID: 1420
	public KQECKBOKHHE.JJBOCNCQLIF QONOKDQLJNG = KQECKBOKHHE.JJBOCNCQLIF.Center;

	// Token: 0x0400058D RID: 1421
	public bool MLKEHIGBQOC = true;

	// Token: 0x0400058E RID: 1422
	public Vector2 BBFOHEPQBBQ = Vector2.zero;

	// Token: 0x0400058F RID: 1423
	public Vector2 GIHHBJEGOPJ = Vector2.zero;

	// Token: 0x04000590 RID: 1424
	[SerializeField]
	[HideInInspector]
	private ENFMCDNLEQQ widgetContainer;

	// Token: 0x04000591 RID: 1425
	private Transform BLLEFKOLKLP;

	// Token: 0x04000592 RID: 1426
	private Animation DBJQBEKGFHP;

	// Token: 0x04000593 RID: 1427
	private Rect FBPOKBEMCEL = default(Rect);

	// Token: 0x04000594 RID: 1428
	private GKDCBJPLQLQ KLLHOMMGBLK;

	// Token: 0x04000595 RID: 1429
	private bool PNBOOLEOKCI;

	// Token: 0x020000E9 RID: 233
	public enum JJBOCNCQLIF
	{
		// Token: 0x04000597 RID: 1431
		BottomLeft,
		// Token: 0x04000598 RID: 1432
		Left,
		// Token: 0x04000599 RID: 1433
		TopLeft,
		// Token: 0x0400059A RID: 1434
		Top,
		// Token: 0x0400059B RID: 1435
		TopRight,
		// Token: 0x0400059C RID: 1436
		Right,
		// Token: 0x0400059D RID: 1437
		BottomRight,
		// Token: 0x0400059E RID: 1438
		Bottom,
		// Token: 0x0400059F RID: 1439
		Center
	}
}
