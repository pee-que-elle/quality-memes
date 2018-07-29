using System;
using UnityEngine;

// Token: 0x02000216 RID: 534
public class BDEJHNHLLOL : MonoBehaviour
{
	// Token: 0x060047E2 RID: 18402 RVA: 0x00238478 File Offset: 0x00236678
	public void DDNIEHHGFNN(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void GLLCQQCCGOG()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047E4 RID: 18404 RVA: 0x002384CC File Offset: 0x002366CC
	private void DLLDNILBJEO()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 948f && (vector.x <= 878f || vector.x >= 109f || vector.y <= 648f || vector.y < 1989f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.FLJIJDLJDFB(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1992f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x002385D0 File Offset: 0x002367D0
	private void CPNQCCCNPMM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1450f || vector.x <= 1882f || vector.x >= 850f || vector.y <= 337f || vector.y < 342f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.FLJIJDLJDFB(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1284f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x0001E429 File Offset: 0x0001C629
	private void ICOCDKECGIE()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x0001E429 File Offset: 0x0001C629
	private void HPMKHDFJMNQ()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047E8 RID: 18408 RVA: 0x002386D4 File Offset: 0x002368D4
	private void IMNOPLFJCGB()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1292f || vector.x <= 1865f || vector.x >= 1000f || vector.y <= 1984f || vector.y < 1227f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.MLFHPMFQGHM(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 886f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x0001E429 File Offset: 0x0001C629
	private void OJQHKOJJNCP()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047EA RID: 18410 RVA: 0x0001E429 File Offset: 0x0001C629
	private void COGJQEEGCFB()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x002387D8 File Offset: 0x002369D8
	public void KODPHCBBNEL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1860f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x0023887C File Offset: 0x00236A7C
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 0f && (vector.x > 0f && vector.x < 1f && vector.y > 0f) && vector.y < 1f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.PGIDCBGCGMP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 0f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x00238478 File Offset: 0x00236678
	public void EGIHGPLCBCF(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x00238980 File Offset: 0x00236B80
	private void GQPDGQIQOPC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1684f || (vector.x > 1172f && vector.x < 238f && vector.y > 1628f && vector.y < 754f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.DDNIEHHGFNN(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1601f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047F0 RID: 18416 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void PIQJPNIKGJP()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047F1 RID: 18417 RVA: 0x00238A84 File Offset: 0x00236C84
	public void ILKPMFIOFPH(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
	}

	// Token: 0x060047F2 RID: 18418 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void FBDGLDFKODD()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x00238AD8 File Offset: 0x00236CD8
	public void KNIONGJMPBD()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 958f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void GMFQFQQQFKC()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047F5 RID: 18421 RVA: 0x00238B7C File Offset: 0x00236D7C
	public void ODJKOHGMQKG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 920f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047F6 RID: 18422 RVA: 0x00238C20 File Offset: 0x00236E20
	private void MJGBKJICLIE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1242f || vector.x <= 89f || vector.x >= 1754f || vector.y <= 1762f || vector.y < 1369f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.MLFHPMFQGHM(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 65f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047F7 RID: 18423 RVA: 0x00238D24 File Offset: 0x00236F24
	public void MNKMNMDDMKN()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1085f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void KLFJOJOOECI()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047F9 RID: 18425 RVA: 0x00238478 File Offset: 0x00236678
	public void NNPELKKBQBL(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x00238DC8 File Offset: 0x00236FC8
	public void HPIPPMGGKIC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1140f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void PBENCICMMLI()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void NJPBKPKNDLD()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x00238E6C File Offset: 0x0023706C
	public void BFQNBODJLLJ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1511f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x060047FE RID: 18430 RVA: 0x00238F10 File Offset: 0x00237110
	private void IMIQKINDQIP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 366f && (vector.x <= 615f || vector.x >= 1712f || vector.y <= 692f || vector.y < 863f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.CCCCGFPMLFK(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 923f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void ICINMCLMJDJ()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void BMIIKIKIKIK()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x00239014 File Offset: 0x00237214
	public void MOGQJDFECBD()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 737f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004802 RID: 18434 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void NMPQODOHHCC()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004803 RID: 18435 RVA: 0x002390B8 File Offset: 0x002372B8
	public void BCHILGCDEFP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 895f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x0023915C File Offset: 0x0023735C
	private void DFNNNMDQEPH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1007f && (vector.x <= 351f || vector.x >= 1338f || vector.y <= 1878f || vector.y < 1246f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.FBGIPBJFKOO(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1291f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void MBFJOLHMDPC()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void PKKKQBOGGPK()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x00238478 File Offset: 0x00236678
	public void MLFHPMFQGHM(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x06004808 RID: 18440 RVA: 0x00239260 File Offset: 0x00237460
	public void MHMMLIIFKIH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 516f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x00239304 File Offset: 0x00237504
	public void PEODGOQIQIN(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x00239358 File Offset: 0x00237558
	private void BBQQBINHMQG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1423f || vector.x <= 150f || vector.x >= 908f || vector.y <= 635f || vector.y < 1682f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.ILKPMFIOFPH(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1864f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x0600480B RID: 18443 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void HFBHKNOCLOE()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x0023945C File Offset: 0x0023765C
	private void GHLICHEONPQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1936f && (vector.x <= 1784f || vector.x >= 1596f || vector.y <= 1664f || vector.y < 59f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.ILKPMFIOFPH(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 116f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x00239560 File Offset: 0x00237760
	private void OCQCDGIEDLK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1493f && (vector.x <= 1195f || vector.x >= 795f || vector.y <= 21f || vector.y < 469f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.FLJIJDLJDFB(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 789f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x00239664 File Offset: 0x00237864
	public void JEBKEDLCDEK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 693f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x0600480F RID: 18447 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void IHGDMCFDINH()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void MOFFLFJFOKF()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x00239708 File Offset: 0x00237908
	public void MPPFQIGPPOI()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 932f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x002397AC File Offset: 0x002379AC
	private void FMEFHLOBNHQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 639f || vector.x <= 1704f || vector.x >= 944f || vector.y <= 1752f || vector.y < 1434f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.NNPELKKBQBL(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1766f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x002398B0 File Offset: 0x00237AB0
	private void KMNECEKIKIH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1403f && (vector.x <= 1696f || vector.x >= 825f || vector.y <= 1282f || vector.y < 1950f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.FLJIJDLJDFB(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1673f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x0001E429 File Offset: 0x0001C629
	private void NKFQOJPEFKD()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x002399B4 File Offset: 0x00237BB4
	public void IHKQEMMMCDI()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1128f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x00239A58 File Offset: 0x00237C58
	public void PJMKLHKFBJM()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 0f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x00239AFC File Offset: 0x00237CFC
	private void BQLJKGILMED()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1296f && (vector.x <= 1915f || vector.x >= 1240f || vector.y <= 1397f || vector.y < 1843f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.MLFHPMFQGHM(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 640f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void COFPBILHHNO()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x0001E429 File Offset: 0x0001C629
	private void PCHJHFGCOCK()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void ENOBPJMDNEG()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x00239C00 File Offset: 0x00237E00
	private void IJDLGLMJDGQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 636f && (vector.x <= 331f || vector.x >= 1982f || vector.y <= 283f || vector.y < 1892f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.NNPELKKBQBL(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 281f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x00238A84 File Offset: 0x00236C84
	public void PGIDCBGCGMP(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x00238478 File Offset: 0x00236678
	public void LQFQPDPQMLJ(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void KMQPMGPDPEC()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void GICOCJQPMCN()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004820 RID: 18464 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void Awake()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void CBLIFECCHIC()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x00239304 File Offset: 0x00237504
	public void FLJIJDLJDFB(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x00239D04 File Offset: 0x00237F04
	private void QDPMFNCLPGH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 770f || vector.x <= 681f || vector.x >= 1144f || vector.y <= 368f || vector.y < 1994f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.PGIDCBGCGMP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1370f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x00238478 File Offset: 0x00236678
	public void CCCCGFPMLFK(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x0001E4A2 File Offset: 0x0001C6A2
	private void MLDGCPIEMJJ()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.JLLBKOOQKGO().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x00239E08 File Offset: 0x00238008
	public void DOLEBGELPLH()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1035f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x00239EAC File Offset: 0x002380AC
	private void BOPOJKGDCDL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1591f && (vector.x <= 865f || vector.x >= 1807f || vector.y <= 1077f || vector.y < 1450f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.FBGIPBJFKOO(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1451f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x00239FB0 File Offset: 0x002381B0
	private void MILKJOMEEQL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z > 1894f && (vector.x > 1473f && vector.x < 107f && vector.y > 288f) && vector.y < 1337f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.EGIHGPLCBCF(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1465f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x06004829 RID: 18473 RVA: 0x0023A0B4 File Offset: 0x002382B4
	private void GNLCGJHBKDI()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = vector.z <= 1401f || vector.x <= 488f || vector.x >= 1218f || vector.y <= 1446f || vector.y < 824f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.PEODGOQIQIN(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.PDDEIHNJOGE.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 971f;
			this.PDDEIHNJOGE.localPosition = vector;
		}
	}

	// Token: 0x0600482A RID: 18474 RVA: 0x0023A1B8 File Offset: 0x002383B8
	public void FBGIPBJFKOO(bool QJFQOMOIOOI)
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.PDDEIHNJOGE.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.PDDEIHNJOGE.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
	}

	// Token: 0x0600482B RID: 18475 RVA: 0x0023A20C File Offset: 0x0023840C
	public void MKIKLGGDGDQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 1926f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void DDBBNJKJCKG()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x0001E3F6 File Offset: 0x0001C5F6
	private void BEHGFNEDJDF()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QOQONHOOLNE.OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x0023A2B0 File Offset: 0x002384B0
	public void DPPOLNJEMIP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 423f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x0600482F RID: 18479 RVA: 0x0023A354 File Offset: 0x00238554
	public void EPKQINFHPHP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		Vector3 vector = this.MIMDEMCOCKP.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
		vector = this.PDDEIHNJOGE.localPosition;
		vector.x = (float)Mathf.FloorToInt(vector.x);
		vector.y = (float)Mathf.FloorToInt(vector.y);
		vector.z = 740f;
		this.PDDEIHNJOGE.localPosition = vector;
	}

	// Token: 0x06004830 RID: 18480 RVA: 0x0001E46F File Offset: 0x0001C66F
	private void PEOBQCMFLML()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.CNIMIQKQJJJ().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x06004831 RID: 18481 RVA: 0x0001E429 File Offset: 0x0001C629
	private void OEOJDKBDNMJ()
	{
		this.PDDEIHNJOGE = base.transform;
		this.CODFIINNNPG = QOHCEBMQKMB.QQCNCIQQPIG().OJQMEBDJDHB;
		this.MIMDEMCOCKP = GGQKBGDGNJN.QOQONHOOLNE.OLLOFNEJEFC.GetComponent<Camera>();
	}

	// Token: 0x04000F3F RID: 3903
	public Vector3 LCMMCNFNHMF = Vector3.zero;

	// Token: 0x04000F40 RID: 3904
	public Transform ILBCCCBJNCL;

	// Token: 0x04000F41 RID: 3905
	public Camera MIMDEMCOCKP;

	// Token: 0x04000F42 RID: 3906
	public Camera CODFIINNNPG;

	// Token: 0x04000F43 RID: 3907
	private Transform PDDEIHNJOGE;

	// Token: 0x04000F44 RID: 3908
	public JLMPBLMOICG PHMFEMBPQLN;

	// Token: 0x04000F45 RID: 3909
	private bool DIEMCOMFBIN;
}
