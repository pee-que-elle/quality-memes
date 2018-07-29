using System;
using UnityEngine;

// Token: 0x0200012B RID: 299
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/Viewport Camera")]
public class QGOBBBMEOKO : MonoBehaviour
{
	// Token: 0x060022E3 RID: 8931 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void HMQOONLDOLQ()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x00012E90 File Offset: 0x00011090
	private void BBGHCDGEDEJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x000E4C14 File Offset: 0x000E2E14
	private void IMIQKINDQIP()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x00012E90 File Offset: 0x00011090
	private void IMGNEDCFBLL()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00012E90 File Offset: 0x00011090
	private void GNLCOJOJFBI()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void LateUpdate()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x00012E90 File Offset: 0x00011090
	private void BCGQQOFCMQJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x00012E90 File Offset: 0x00011090
	private void KHFDJHFJMDK()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void LLGDDMMIBIO()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x00012E90 File Offset: 0x00011090
	private void NOLQNFCODBK()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x00012E90 File Offset: 0x00011090
	private void LNHDODMGBKC()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x00012E90 File Offset: 0x00011090
	private void MMLKOGQFENF()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void BCBIEPHJOGG()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x00012E90 File Offset: 0x00011090
	private void DHGEJKGNHCO()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x000E4D38 File Offset: 0x000E2F38
	private void IJLBNKGDBML()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x060022F2 RID: 8946 RVA: 0x00012E90 File Offset: 0x00011090
	private void LMMGEGJCBJP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F3 RID: 8947 RVA: 0x00012E90 File Offset: 0x00011090
	private void FOPKBNIOGCP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x00012E90 File Offset: 0x00011090
	private void HQGDEKJQQDE()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x00012E90 File Offset: 0x00011090
	private void DHLGDLOKLKN()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x00012E90 File Offset: 0x00011090
	private void Start()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x00012E90 File Offset: 0x00011090
	private void IKHIQQKHILB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x000E4E5C File Offset: 0x000E305C
	private void HQKKGINMODP()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void MJGBKJICLIE()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x00012E90 File Offset: 0x00011090
	private void JPNMOLDKPQP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x000E4C14 File Offset: 0x000E2E14
	private void HMNPIDKPCPJ()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x00012E90 File Offset: 0x00011090
	private void PGFHJKDGEMJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000E4E5C File Offset: 0x000E305C
	private void LEHQJOJQECC()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000E4D38 File Offset: 0x000E2F38
	private void DFNNNMDQEPH()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x00012E90 File Offset: 0x00011090
	private void OLLNOFNEEIL()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void CBIFBMPIPIC()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x000E4D38 File Offset: 0x000E2F38
	private void KQECLIPLJNM()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x00012E90 File Offset: 0x00011090
	private void GJPGBCKQLDG()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x00012E90 File Offset: 0x00011090
	private void LODQBMMKNNM()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x000E4D38 File Offset: 0x000E2F38
	private void ILMKLDICQKK()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x00012E90 File Offset: 0x00011090
	private void LMELGHDGJMQ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	private void KMNECEKIKIH()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x000E4E5C File Offset: 0x000E305C
	private void HKJPPHFBPHE()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x00012E90 File Offset: 0x00011090
	private void HCHIDEKMEBB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x00012E90 File Offset: 0x00011090
	private void GJLLCMLLEQF()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x00012E90 File Offset: 0x00011090
	private void CNIKQOQLFFB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x00012E90 File Offset: 0x00011090
	private void GBGEGKHDQKB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		if (this.DNONPKBCBGP == null)
		{
			this.DNONPKBCBGP = Camera.main;
		}
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x000E4E5C File Offset: 0x000E305C
	private void FJGHCONLOHO()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = false;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = false;
			}
		}
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x000E4C14 File Offset: 0x000E2E14
	private void QKDQEDFIEOH()
	{
		if (this.EIECKQPECQB != null && this.FQCPHCBIFPK != null)
		{
			if (this.EIECKQPECQB.gameObject.activeInHierarchy)
			{
				Vector3 vector = this.DNONPKBCBGP.WorldToScreenPoint(this.EIECKQPECQB.position);
				Vector3 vector2 = this.DNONPKBCBGP.WorldToScreenPoint(this.FQCPHCBIFPK.position);
				Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
				float num = this.LMBCMIOMCBK * rect.height;
				if (rect != this.OJIDBLEKBBO.rect)
				{
					this.OJIDBLEKBBO.rect = rect;
				}
				if (this.OJIDBLEKBBO.orthographicSize != num)
				{
					this.OJIDBLEKBBO.orthographicSize = num;
				}
				this.OJIDBLEKBBO.enabled = true;
			}
			else
			{
				this.OJIDBLEKBBO.enabled = true;
			}
		}
	}

	// Token: 0x04000793 RID: 1939
	public Camera DNONPKBCBGP;

	// Token: 0x04000794 RID: 1940
	public Transform EIECKQPECQB;

	// Token: 0x04000795 RID: 1941
	public Transform FQCPHCBIFPK;

	// Token: 0x04000796 RID: 1942
	public float LMBCMIOMCBK = 1f;

	// Token: 0x04000797 RID: 1943
	private Camera OJIDBLEKBBO;
}
