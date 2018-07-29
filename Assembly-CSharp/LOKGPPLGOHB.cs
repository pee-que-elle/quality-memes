using System;
using UnityEngine;

// Token: 0x0200026C RID: 620
public class LOKGPPLGOHB : MonoBehaviour
{
	// Token: 0x060054B3 RID: 21683 RVA: 0x002B0578 File Offset: 0x002AE778
	private void HQKKGINMODP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 308f) || vector.y <= 953f || vector.y >= 143f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1307f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 4) - bounds.size.x / 1738f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 108f) + 917f)
			{
				num2 = -(int)(x / 481f) + 35;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 793f - (float)Screen.width * 1105f, base.transform.localPosition.y, 864f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 382f);
		}
		else if (num < 1519f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 51f) + 1059f)
			{
				num3 = -(int)(x / 679f) + -93;
			}
			base.transform.localPosition = new Vector3(x / 353f - (float)Screen.width * 1429f, base.transform.localPosition.y, 902f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 874f);
		}
	}

	// Token: 0x060054B4 RID: 21684 RVA: 0x002B085C File Offset: 0x002AEA5C
	private void NBOEMPQCBLB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1973f) && (vector.y <= 1006f || vector.y >= 1971f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1446f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 674f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1925f) + 1990f)
			{
				num2 = -(int)(x / 1481f) + 126;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 708f - (float)Screen.width * 1186f, base.transform.localPosition.y, 806f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 817f);
		}
		else if (num < 719f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1206f) + 279f)
			{
				num3 = -(int)(x / 155f) + 0;
			}
			base.transform.localPosition = new Vector3(x / 707f - (float)Screen.width * 477f, base.transform.localPosition.y, 895f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1421f);
		}
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x002B0B40 File Offset: 0x002AED40
	private void KQECLIPLJNM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 694f) && (vector.y <= 878f || vector.y >= 1359f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 791f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 3) - bounds.size.x / 128f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1139f) + 1281f)
			{
				num2 = -(int)(x / 1434f) + -50;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1079f - (float)Screen.width * 1739f, base.transform.localPosition.y, 1455f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 170f);
		}
		else if (num < 1755f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 346f) + 447f)
			{
				num3 = -(int)(x / 489f) + 114;
			}
			base.transform.localPosition = new Vector3(x / 1535f - (float)Screen.width * 808f, base.transform.localPosition.y, 1707f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1910f);
		}
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x002B0E24 File Offset: 0x002AF024
	private void BBQQBINHMQG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1064f) || (vector.y > 1071f && vector.y >= 1735f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1817f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 7) - bounds.size.x / 823f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1267f) + 496f)
			{
				num2 = -(int)(x / 1995f) + 9;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 363f - (float)Screen.width * 1950f, base.transform.localPosition.y, 1595f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 864f);
		}
		else if (num < 643f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1336f) + 448f)
			{
				num3 = -(int)(x / 1884f) + -102;
			}
			base.transform.localPosition = new Vector3(x / 1219f - (float)Screen.width * 1401f, base.transform.localPosition.y, 1631f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1963f);
		}
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x002B1108 File Offset: 0x002AF308
	private void IQNIHMGKFMB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 217f) && vector.y > 305f && vector.y >= 614f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1663f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 1445f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1007f) + 1188f)
			{
				num2 = -(int)(x / 1873f) + 119;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1918f - (float)Screen.width * 1230f, base.transform.localPosition.y, 915f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1661f);
		}
		else if (num < 119f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 644f) + 1070f)
			{
				num3 = -(int)(x / 272f) + 95;
			}
			base.transform.localPosition = new Vector3(x / 326f - (float)Screen.width * 297f, base.transform.localPosition.y, 376f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1828f);
		}
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x002B13EC File Offset: 0x002AF5EC
	private void OLDHEQHJHNL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1299f) || (vector.y > 629f && vector.y >= 1409f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1658f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 790f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 648f) + 941f)
			{
				num2 = -(int)(x / 1147f) + -54;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 548f - (float)Screen.width * 106f, base.transform.localPosition.y, 1900f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1241f);
		}
		else if (num < 105f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1155f) + 1993f)
			{
				num3 = -(int)(x / 564f) + 2;
			}
			base.transform.localPosition = new Vector3(x / 1693f - (float)Screen.width * 1906f, base.transform.localPosition.y, 1101f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 546f);
		}
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x002B16D0 File Offset: 0x002AF8D0
	private void PDHLMMEBECL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1872f) || (vector.y > 1958f && vector.y >= 1884f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1868f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 1281f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 234f) + 1698f)
			{
				num2 = -(int)(x / 177f) + 69;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 44f - (float)Screen.width * 1856f, base.transform.localPosition.y, 1059f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1025f);
		}
		else if (num < 552f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1898f) + 1562f)
			{
				num3 = -(int)(x / 503f) + -71;
			}
			base.transform.localPosition = new Vector3(x / 1529f - (float)Screen.width * 1507f, base.transform.localPosition.y, 963f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 717f);
		}
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x002B19B4 File Offset: 0x002AFBB4
	private void PNOBIFOIHQM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1064f) && (vector.y <= 984f || vector.y >= 416f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1994f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 1735f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1545f) + 741f)
			{
				num2 = -(int)(x / 1486f) + -112;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 775f - (float)Screen.width * 753f, base.transform.localPosition.y, 1663f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 569f);
		}
		else if (num < 1894f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1701f) + 214f)
			{
				num3 = -(int)(x / 237f) + -52;
			}
			base.transform.localPosition = new Vector3(x / 1581f - (float)Screen.width * 1256f, base.transform.localPosition.y, 1212f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1372f);
		}
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x002B1C98 File Offset: 0x002AFE98
	private void GHLICHEONPQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 33f) && vector.y > 1314f && vector.y >= 299f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 764f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 6) - bounds.size.x / 42f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 69f) + 490f)
			{
				num2 = -(int)(x / 1750f) + 38;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 191f - (float)Screen.width * 105f, base.transform.localPosition.y, 1863f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 807f);
		}
		else if (num < 1496f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1956f) + 1710f)
			{
				num3 = -(int)(x / 1923f) + -108;
			}
			base.transform.localPosition = new Vector3(x / 583f - (float)Screen.width * 1442f, base.transform.localPosition.y, 341f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 55f);
		}
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x002B1F7C File Offset: 0x002B017C
	private void MJGBKJICLIE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 857f) || vector.y <= 4f || vector.y >= 1940f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1894f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 6) - bounds.size.x / 1844f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 688f) + 1188f)
			{
				num2 = -(int)(x / 1152f) + -17;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 50f - (float)Screen.width * 1158f, base.transform.localPosition.y, 149f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 75f);
		}
		else if (num < 1819f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1033f) + 1637f)
			{
				num3 = -(int)(x / 1591f) + 64;
			}
			base.transform.localPosition = new Vector3(x / 160f - (float)Screen.width * 1724f, base.transform.localPosition.y, 1269f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 935f);
		}
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x002B2260 File Offset: 0x002B0460
	private void IEBQOMBIIKB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1482f) && vector.y > 1728f && vector.y >= 1203f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 66f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 3) - bounds.size.x / 1106f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 136f) + 1241f)
			{
				num2 = -(int)(x / 773f) + -68;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 513f - (float)Screen.width * 1962f, base.transform.localPosition.y, 1014f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1627f);
		}
		else if (num < 747f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1117f) + 1666f)
			{
				num3 = -(int)(x / 131f) + -39;
			}
			base.transform.localPosition = new Vector3(x / 340f - (float)Screen.width * 1150f, base.transform.localPosition.y, 56f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1379f);
		}
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x002B2544 File Offset: 0x002B0744
	private void OFDCPMEBBBJ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1721f) && vector.y > 1547f && vector.y >= 1210f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1160f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 793f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 192f) + 1754f)
			{
				num2 = -(int)(x / 113f) + -52;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1868f - (float)Screen.width * 1575f, base.transform.localPosition.y, 360f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1557f);
		}
		else if (num < 582f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 900f) + 1813f)
			{
				num3 = -(int)(x / 1133f) + -46;
			}
			base.transform.localPosition = new Vector3(x / 1503f - (float)Screen.width * 1241f, base.transform.localPosition.y, 596f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 211f);
		}
	}

	// Token: 0x060054C0 RID: 21696 RVA: 0x002B2828 File Offset: 0x002B0A28
	private void BHLMCIFQPBP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 870f) && vector.y > 476f && vector.y >= 561f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1046f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 1813f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1949f) + 1270f)
			{
				num2 = -(int)(x / 1569f) + -41;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1964f - (float)Screen.width * 1031f, base.transform.localPosition.y, 316f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 481f);
		}
		else if (num < 1986f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1252f) + 668f)
			{
				num3 = -(int)(x / 617f) + -25;
			}
			base.transform.localPosition = new Vector3(x / 1839f - (float)Screen.width * 1256f, base.transform.localPosition.y, 334f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 856f);
		}
	}

	// Token: 0x060054C1 RID: 21697 RVA: 0x002B2B0C File Offset: 0x002B0D0C
	private void NMLIGFLNGNF()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 747f) || (vector.y > 1702f && vector.y >= 655f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1748f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 6) - bounds.size.x / 902f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 457f) + 1854f)
			{
				num2 = -(int)(x / 1633f) + 45;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1559f - (float)Screen.width * 1656f, base.transform.localPosition.y, 542f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 238f);
		}
		else if (num < 1636f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 786f) + 847f)
			{
				num3 = -(int)(x / 641f) + -112;
			}
			base.transform.localPosition = new Vector3(x / 1340f - (float)Screen.width * 1775f, base.transform.localPosition.y, 1356f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 475f);
		}
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x002B2DF0 File Offset: 0x002B0FF0
	private void JHHCDBMCCFD()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1361f) && (vector.y <= 1891f || vector.y >= 7f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 461f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 426f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 566f) + 1647f)
			{
				num2 = -(int)(x / 1177f) + -88;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1144f - (float)Screen.width * 1076f, base.transform.localPosition.y, 1102f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1775f);
		}
		else if (num < 379f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 684f) + 33f)
			{
				num3 = -(int)(x / 1990f) + -60;
			}
			base.transform.localPosition = new Vector3(x / 290f - (float)Screen.width * 155f, base.transform.localPosition.y, 542f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 30f);
		}
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x002B30D4 File Offset: 0x002B12D4
	private void CKECNIHHBJE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1240f) || vector.y <= 1778f || vector.y >= 1774f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 591f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 94f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1321f) + 48f)
			{
				num2 = -(int)(x / 410f) + 35;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 576f - (float)Screen.width * 1751f, base.transform.localPosition.y, 1699f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 207f);
		}
		else if (num < 403f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 585f) + 389f)
			{
				num3 = -(int)(x / 1714f) + 29;
			}
			base.transform.localPosition = new Vector3(x / 1718f - (float)Screen.width * 18f, base.transform.localPosition.y, 986f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1908f);
		}
	}

	// Token: 0x060054C4 RID: 21700 RVA: 0x002B33B8 File Offset: 0x002B15B8
	private void HMNPIDKPCPJ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1145f) || vector.y <= 1348f || vector.y >= 1185f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 660f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 345f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1444f) + 1896f)
			{
				num2 = -(int)(x / 462f) + -96;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 743f - (float)Screen.width * 860f, base.transform.localPosition.y, 900f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1177f);
		}
		else if (num < 943f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 219f) + 383f)
			{
				num3 = -(int)(x / 408f) + 16;
			}
			base.transform.localPosition = new Vector3(x / 450f - (float)Screen.width * 470f, base.transform.localPosition.y, 1826f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 554f);
		}
	}

	// Token: 0x060054C5 RID: 21701 RVA: 0x002B369C File Offset: 0x002B189C
	private void IQIFCPQBGOC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1896f) || vector.y <= 80f || vector.y >= 1835f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 538f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 1537f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 901f) + 586f)
			{
				num2 = -(int)(x / 900f) + 33;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1636f - (float)Screen.width * 625f, base.transform.localPosition.y, 1055f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 241f);
		}
		else if (num < 112f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 722f) + 632f)
			{
				num3 = -(int)(x / 832f) + -9;
			}
			base.transform.localPosition = new Vector3(x / 585f - (float)Screen.width * 107f, base.transform.localPosition.y, 828f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 302f);
		}
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x002B3980 File Offset: 0x002B1B80
	private void KFOHBBFQBII()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 622f) && (vector.y <= 1541f || vector.y >= 648f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1479f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 365f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1979f) + 1469f)
			{
				num2 = -(int)(x / 228f) + 101;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1573f - (float)Screen.width * 1844f, base.transform.localPosition.y, 37f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1828f);
		}
		else if (num < 1251f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1378f) + 41f)
			{
				num3 = -(int)(x / 618f) + -126;
			}
			base.transform.localPosition = new Vector3(x / 1121f - (float)Screen.width * 827f, base.transform.localPosition.y, 1542f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1180f);
		}
	}

	// Token: 0x060054C7 RID: 21703 RVA: 0x002B3C64 File Offset: 0x002B1E64
	private void IOCGLPBMNNB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1720f) || (vector.y > 432f && vector.y >= 1433f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1911f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 1696f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 787f) + 841f)
			{
				num2 = -(int)(x / 1950f) + -66;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 982f - (float)Screen.width * 1035f, base.transform.localPosition.y, 1233f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 608f);
		}
		else if (num < 1296f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1927f) + 1453f)
			{
				num3 = -(int)(x / 1357f) + -32;
			}
			base.transform.localPosition = new Vector3(x / 476f - (float)Screen.width * 237f, base.transform.localPosition.y, 368f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 104f);
		}
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x002B3F48 File Offset: 0x002B2148
	private void HBPIHOOKMDL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 963f) && vector.y > 174f && vector.y >= 1915f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 238f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 6) - bounds.size.x / 14f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1462f) + 104f)
			{
				num2 = -(int)(x / 78f) + -89;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1681f - (float)Screen.width * 439f, base.transform.localPosition.y, 1004f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1511f);
		}
		else if (num < 1682f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1409f) + 597f)
			{
				num3 = -(int)(x / 1864f) + 31;
			}
			base.transform.localPosition = new Vector3(x / 1066f - (float)Screen.width * 93f, base.transform.localPosition.y, 80f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 970f);
		}
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x002B422C File Offset: 0x002B242C
	private void GFQJBEDEMCD()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 471f) || (vector.y > 1159f && vector.y >= 69f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1949f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 1480f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 237f) + 1131f)
			{
				num2 = -(int)(x / 1043f) + -98;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 149f - (float)Screen.width * 1785f, base.transform.localPosition.y, 1313f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 888f);
		}
		else if (num < 523f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 578f) + 33f)
			{
				num3 = -(int)(x / 1302f) + 52;
			}
			base.transform.localPosition = new Vector3(x / 795f - (float)Screen.width * 1759f, base.transform.localPosition.y, 429f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1023f);
		}
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x002B4510 File Offset: 0x002B2710
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 0f) || vector.y <= 0f || vector.y >= 1f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 0f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 2f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 2f) + 16f)
			{
				num2 = -(int)(x / 2f) + 16;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 2f - (float)Screen.width * 0.5f, base.transform.localPosition.y, 0f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 0f);
		}
		else if (num < 0f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 2f) + 16f)
			{
				num3 = -(int)(x / 2f) + 16;
			}
			base.transform.localPosition = new Vector3(x / 2f - (float)Screen.width * 0.5f, base.transform.localPosition.y, 0f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 0f);
		}
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x002B47F4 File Offset: 0x002B29F4
	private void FDPDPMGLLJD()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 120f) || (vector.y > 66f && vector.y >= 287f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 927f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 662f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 478f) + 1246f)
			{
				num2 = -(int)(x / 133f) + -51;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1264f - (float)Screen.width * 1351f, base.transform.localPosition.y, 1863f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1158f);
		}
		else if (num < 472f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1178f) + 1240f)
			{
				num3 = -(int)(x / 1851f) + -84;
			}
			base.transform.localPosition = new Vector3(x / 163f - (float)Screen.width * 691f, base.transform.localPosition.y, 693f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1849f);
		}
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x002B4AD8 File Offset: 0x002B2CD8
	private void QHPNHQMFKNI()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1411f) && (vector.y <= 1945f || vector.y >= 1319f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1244f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 1784f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 43f) + 177f)
			{
				num2 = -(int)(x / 1690f) + -29;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 123f - (float)Screen.width * 1185f, base.transform.localPosition.y, 814f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 390f);
		}
		else if (num < 203f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 379f) + 330f)
			{
				num3 = -(int)(x / 1943f) + -117;
			}
			base.transform.localPosition = new Vector3(x / 1330f - (float)Screen.width * 975f, base.transform.localPosition.y, 298f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1250f);
		}
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x002B4DBC File Offset: 0x002B2FBC
	private void KQPHQNNDCNP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1844f) || (vector.y > 1669f && vector.y >= 103f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1739f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 1147f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1868f) + 856f)
			{
				num2 = -(int)(x / 1366f) + -20;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 33f - (float)Screen.width * 1820f, base.transform.localPosition.y, 1186f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 363f);
		}
		else if (num < 977f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 499f) + 31f)
			{
				num3 = -(int)(x / 1501f) + 31;
			}
			base.transform.localPosition = new Vector3(x / 1174f - (float)Screen.width * 1009f, base.transform.localPosition.y, 1103f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 461f);
		}
	}

	// Token: 0x060054CE RID: 21710 RVA: 0x002B50A0 File Offset: 0x002B32A0
	private void BFNMQJHEQHL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 66f) && vector.y > 1667f && vector.y >= 1375f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 359f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 1190f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1022f) + 1189f)
			{
				num2 = -(int)(x / 1063f) + 33;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 40f - (float)Screen.width * 1888f, base.transform.localPosition.y, 122f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 484f);
		}
		else if (num < 1371f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1216f) + 1128f)
			{
				num3 = -(int)(x / 697f) + -65;
			}
			base.transform.localPosition = new Vector3(x / 1800f - (float)Screen.width * 801f, base.transform.localPosition.y, 244f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1579f);
		}
	}

	// Token: 0x060054CF RID: 21711 RVA: 0x002B5384 File Offset: 0x002B3584
	private void BOPOJKGDCDL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1106f) && (vector.y <= 1441f || vector.y >= 1478f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 86f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 1508f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 854f) + 1353f)
			{
				num2 = -(int)(x / 1036f) + -49;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 890f - (float)Screen.width * 1288f, base.transform.localPosition.y, 721f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1629f);
		}
		else if (num < 1470f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1477f) + 239f)
			{
				num3 = -(int)(x / 1025f) + -67;
			}
			base.transform.localPosition = new Vector3(x / 737f - (float)Screen.width * 1337f, base.transform.localPosition.y, 1623f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1161f);
		}
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x002B5668 File Offset: 0x002B3868
	private void HLDECOJJNKP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1191f) && (vector.y <= 876f || vector.y >= 300f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 246f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 3) - bounds.size.x / 828f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1908f) + 344f)
			{
				num2 = -(int)(x / 236f) + -119;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1644f - (float)Screen.width * 1790f, base.transform.localPosition.y, 1188f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1375f);
		}
		else if (num < 304f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1831f) + 1910f)
			{
				num3 = -(int)(x / 418f) + -1;
			}
			base.transform.localPosition = new Vector3(x / 981f - (float)Screen.width * 1612f, base.transform.localPosition.y, 205f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 33f);
		}
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x002B594C File Offset: 0x002B3B4C
	private void GQPDGQIQOPC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 227f) && vector.y > 660f && vector.y >= 909f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1917f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 1435f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1295f) + 3f)
			{
				num2 = -(int)(x / 1425f) + -58;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 778f - (float)Screen.width * 1579f, base.transform.localPosition.y, 1399f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 351f);
		}
		else if (num < 1407f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 981f) + 185f)
			{
				num3 = -(int)(x / 783f) + 1;
			}
			base.transform.localPosition = new Vector3(x / 221f - (float)Screen.width * 134f, base.transform.localPosition.y, 1635f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 433f);
		}
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x002B5C30 File Offset: 0x002B3E30
	private void EJQKNLEBMGE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1881f) && vector.y > 1013f && vector.y >= 1020f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 309f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 5) - bounds.size.x / 618f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1116f) + 1535f)
			{
				num2 = -(int)(x / 446f) + 123;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 812f - (float)Screen.width * 1873f, base.transform.localPosition.y, 1352f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1603f);
		}
		else if (num < 1429f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 996f) + 1474f)
			{
				num3 = -(int)(x / 1942f) + 103;
			}
			base.transform.localPosition = new Vector3(x / 691f - (float)Screen.width * 1193f, base.transform.localPosition.y, 832f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 177f);
		}
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x002B5F14 File Offset: 0x002B4114
	private void IJDLGLMJDGQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 946f) && (vector.y <= 1198f || vector.y >= 115f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 716f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 1804f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 101f) + 1291f)
			{
				num2 = -(int)(x / 377f) + 63;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 996f - (float)Screen.width * 1431f, base.transform.localPosition.y, 1172f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1695f);
		}
		else if (num < 100f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1233f) + 116f)
			{
				num3 = -(int)(x / 969f) + -74;
			}
			base.transform.localPosition = new Vector3(x / 1226f - (float)Screen.width * 651f, base.transform.localPosition.y, 1994f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 601f);
		}
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x002B61F8 File Offset: 0x002B43F8
	private void QDPMFNCLPGH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 696f) && vector.y > 279f && vector.y >= 670f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 440f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 1221f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1146f) + 539f)
			{
				num2 = -(int)(x / 530f) + 95;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 571f - (float)Screen.width * 1141f, base.transform.localPosition.y, 1783f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 96f);
		}
		else if (num < 350f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 805f) + 1843f)
			{
				num3 = -(int)(x / 18f) + 84;
			}
			base.transform.localPosition = new Vector3(x / 123f - (float)Screen.width * 1896f, base.transform.localPosition.y, 18f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1556f);
		}
	}

	// Token: 0x060054D5 RID: 21717 RVA: 0x002B64DC File Offset: 0x002B46DC
	private void HMEJOPGKKFE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1956f) || vector.y <= 1375f || vector.y >= 1594f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1663f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 7) - bounds.size.x / 66f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 992f) + 1106f)
			{
				num2 = -(int)(x / 1702f) + 63;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1903f - (float)Screen.width * 1127f, base.transform.localPosition.y, 1694f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1370f);
		}
		else if (num < 698f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 332f) + 979f)
			{
				num3 = -(int)(x / 276f) + -38;
			}
			base.transform.localPosition = new Vector3(x / 811f - (float)Screen.width * 27f, base.transform.localPosition.y, 408f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1454f);
		}
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x002B67C0 File Offset: 0x002B49C0
	private void NDEMQFDBGIC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1146f) && vector.y > 1659f && vector.y >= 823f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 383f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 288f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 630f) + 1820f)
			{
				num2 = -(int)(x / 1844f) + -45;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 93f - (float)Screen.width * 1889f, base.transform.localPosition.y, 639f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 199f);
		}
		else if (num < 1184f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 856f) + 1906f)
			{
				num3 = -(int)(x / 1234f) + -92;
			}
			base.transform.localPosition = new Vector3(x / 1674f - (float)Screen.width * 1859f, base.transform.localPosition.y, 790f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1846f);
		}
	}

	// Token: 0x060054D7 RID: 21719 RVA: 0x002B6AA4 File Offset: 0x002B4CA4
	private void OPKDOHQHIHG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1190f) && vector.y > 1820f && vector.y >= 188f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 355f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 8) - bounds.size.x / 874f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 370f) + 1920f)
			{
				num2 = -(int)(x / 365f) + -56;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1688f - (float)Screen.width * 1128f, base.transform.localPosition.y, 1688f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 725f);
		}
		else if (num < 1016f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 403f) + 249f)
			{
				num3 = -(int)(x / 91f) + 99;
			}
			base.transform.localPosition = new Vector3(x / 171f - (float)Screen.width * 1197f, base.transform.localPosition.y, 646f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 575f);
		}
	}

	// Token: 0x060054D8 RID: 21720 RVA: 0x002B6D88 File Offset: 0x002B4F88
	private void BQLJKGILMED()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1743f) && (vector.y <= 746f || vector.y >= 1614f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1124f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 3) - bounds.size.x / 1664f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 877f) + 412f)
			{
				num2 = -(int)(x / 592f) + 28;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1850f - (float)Screen.width * 33f, base.transform.localPosition.y, 519f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1996f);
		}
		else if (num < 185f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1601f) + 1326f)
			{
				num3 = -(int)(x / 719f) + 24;
			}
			base.transform.localPosition = new Vector3(x / 886f - (float)Screen.width * 741f, base.transform.localPosition.y, 1673f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1184f);
		}
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x002B706C File Offset: 0x002B526C
	private void KMNECEKIKIH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 548f) && vector.y > 1298f && vector.y >= 305f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1007f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 2) - bounds.size.x / 134f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1790f) + 586f)
			{
				num2 = -(int)(x / 1770f) + 43;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 492f - (float)Screen.width * 1373f, base.transform.localPosition.y, 855f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1678f);
		}
		else if (num < 1136f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 913f) + 1979f)
			{
				num3 = -(int)(x / 1080f) + 127;
			}
			base.transform.localPosition = new Vector3(x / 151f - (float)Screen.width * 464f, base.transform.localPosition.y, 1398f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 682f);
		}
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x002B7350 File Offset: 0x002B5550
	private void OIDGMHJQOQC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 283f) || vector.y <= 547f || vector.y >= 54f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 285f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 3) - bounds.size.x / 397f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 164f) + 626f)
			{
				num2 = -(int)(x / 678f) + 114;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1814f - (float)Screen.width * 177f, base.transform.localPosition.y, 1535f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1161f);
		}
		else if (num < 651f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1636f) + 1532f)
			{
				num3 = -(int)(x / 631f) + 72;
			}
			base.transform.localPosition = new Vector3(x / 138f - (float)Screen.width * 593f, base.transform.localPosition.y, 543f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 489f);
		}
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x002B7634 File Offset: 0x002B5834
	private void NGHFIFIQHLC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 595f) && (vector.y <= 1486f || vector.y >= 139f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1361f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 169f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1787f) + 1774f)
			{
				num2 = -(int)(x / 846f) + -95;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1574f - (float)Screen.width * 1642f, base.transform.localPosition.y, 1352f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 664f);
		}
		else if (num < 284f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 394f) + 1716f)
			{
				num3 = -(int)(x / 260f) + -85;
			}
			base.transform.localPosition = new Vector3(x / 874f - (float)Screen.width * 1939f, base.transform.localPosition.y, 928f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1191f);
		}
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x002B7918 File Offset: 0x002B5B18
	private void OCQCDGIEDLK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1003f) || vector.y <= 342f || vector.y >= 451f)
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1301f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 1734f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 1983f) + 1928f)
			{
				num2 = -(int)(x / 226f) + -51;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 535f - (float)Screen.width * 1433f, base.transform.localPosition.y, 1721f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1269f);
		}
		else if (num < 438f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 782f) + 556f)
			{
				num3 = -(int)(x / 1069f) + 16;
			}
			base.transform.localPosition = new Vector3(x / 1590f - (float)Screen.width * 1850f, base.transform.localPosition.y, 370f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 50f);
		}
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x002B7BFC File Offset: 0x002B5DFC
	private void DLLDNILBJEO()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 788f) || (vector.y > 256f && vector.y >= 52f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 60f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 0) - bounds.size.x / 1748f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 471f) + 1404f)
			{
				num2 = -(int)(x / 1812f) + -82;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1656f - (float)Screen.width * 137f, base.transform.localPosition.y, 1912f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 834f);
		}
		else if (num < 1091f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1523f) + 1125f)
			{
				num3 = -(int)(x / 1855f) + 26;
			}
			base.transform.localPosition = new Vector3(x / 1489f - (float)Screen.width * 1951f, base.transform.localPosition.y, 580f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1548f);
		}
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x002B7EE0 File Offset: 0x002B60E0
	private void HKJPPHFBPHE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = false;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 1281f) || (vector.y > 1675f && vector.y >= 1399f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 224f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 1) - bounds.size.x / 129f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 409f) + 501f)
			{
				num2 = -(int)(x / 1666f) + -21;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 417f - (float)Screen.width * 382f, base.transform.localPosition.y, 961f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 45f);
		}
		else if (num < 391f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 527f) + 1502f)
			{
				num3 = -(int)(x / 1669f) + 45;
			}
			base.transform.localPosition = new Vector3(x / 1817f - (float)Screen.width * 1930f, base.transform.localPosition.y, 1116f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 1093f);
		}
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x002B81C4 File Offset: 0x002B63C4
	private void QJDIFPPQHIO()
	{
		if (this.ILBCCCBJNCL == null)
		{
			if (this.GDJBIGFMFQC)
			{
				base.transform.localPosition = Vector3.zero;
				UnityEngine.Object.Destroy(this);
			}
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			return;
		}
		if (this.CODFIINNNPG == null)
		{
			return;
		}
		this.GDJBIGFMFQC = true;
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 184f) && (vector.y <= 606f || vector.y >= 1895f))
		{
			base.transform.localPosition = Vector3.zero;
			return;
		}
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = base.transform.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1722f;
		base.transform.localPosition = vector;
		Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.CODFIINNNPG.transform, base.transform);
		float num = bounds.center.x + (float)(Screen.width / 7) - bounds.size.x / 1106f;
		float x = bounds.size.x;
		if (num + x > (float)Screen.width)
		{
			int num2 = (int)((float)Screen.width - (num + x));
			if ((float)num2 < -(x / 459f) + 905f)
			{
				num2 = -(int)(x / 1474f) + -82;
			}
			base.transform.localPosition = new Vector3((float)Screen.width - x / 1925f - (float)Screen.width * 992f, base.transform.localPosition.y, 1477f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)(-(float)num2), this.OIOMEPFJMGQ.localPosition.y, 1596f);
		}
		else if (num < 209f)
		{
			int num3 = (int)num;
			if ((float)num3 < -(x / 1404f) + 1415f)
			{
				num3 = -(int)(x / 428f) + -109;
			}
			base.transform.localPosition = new Vector3(x / 1308f - (float)Screen.width * 305f, base.transform.localPosition.y, 1266f);
			this.OIOMEPFJMGQ.localPosition = new Vector3((float)num3, this.OIOMEPFJMGQ.localPosition.y, 529f);
		}
	}

	// Token: 0x0400126F RID: 4719
	public Vector3 LCMMCNFNHMF = Vector3.zero;

	// Token: 0x04001270 RID: 4720
	public Transform ILBCCCBJNCL;

	// Token: 0x04001271 RID: 4721
	public BKKHLBCLPJM DIEFPEQNKBF;

	// Token: 0x04001272 RID: 4722
	public Camera KCOMMGMLLEE;

	// Token: 0x04001273 RID: 4723
	public Camera CODFIINNNPG;

	// Token: 0x04001274 RID: 4724
	public Transform OIOMEPFJMGQ;

	// Token: 0x04001275 RID: 4725
	private bool GDJBIGFMFQC;
}
