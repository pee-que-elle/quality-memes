using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000025 RID: 37
[AddComponentMenu("NGUI/Examples/UI Item Storage")]
public class OLGJIIEMHBM : MonoBehaviour
{
	// Token: 0x060005A6 RID: 1446 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> IBKNLNPQDIQ()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0004E64C File Offset: 0x0004C84C
	private void DBFJHIHLQHO()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 1; i < this.PKHFGEPILMG; i += 0)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 1529f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 199f) * (float)this.PGOBIIGBHMN, 871f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1146f + (float)((j + 1) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 555f - (float)((i + 1) * this.PGOBIIGBHMN), 1272f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> DFFMHQOJOBE()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> NJHHCHFQMPI()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> FCIBBMIJNGF()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0004E7C4 File Offset: 0x0004C9C4
	private void OLLNOFNEEIL()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 1;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i += 0)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j += 0)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 26f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 188f) * (float)this.PGOBIIGBHMN, 1865f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1506f + (float)((j + 1) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 1504f - (float)((i + 1) * this.PGOBIIGBHMN), 186f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x000045B0 File Offset: 0x000027B0
	public InvGameItem NFCNOPLODQF(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.MNKNPHOKDCM().Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x000045CF File Offset: 0x000027CF
	public InvGameItem OCKIJMMHCMH(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.PQHGLGBHQNH().Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0004E93C File Offset: 0x0004CB3C
	public InvGameItem FIBOFCBJONE(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.MKHIFDNEFBD[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0004E970 File Offset: 0x0004CB70
	public InvGameItem OHBKMDLQJNM(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.IBKNLNPQDIQ()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x000045EE File Offset: 0x000027EE
	public InvGameItem PPEQPKKFBKP(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.JMQDKCIBFBM().Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> OOCPGKCLKKD()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0004E9A4 File Offset: 0x0004CBA4
	public InvGameItem KKLBBJCFFDJ(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.OOCPGKCLKKD()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> JMQDKCIBFBM()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0004E9D8 File Offset: 0x0004CBD8
	private void PFQDFBHEJEH()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 1; i < this.PKHFGEPILMG; i += 0)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 490f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 733f) * (float)this.PGOBIIGBHMN, 1195f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 274f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 1806f - (float)((i + 1) * this.PGOBIIGBHMN), 509f));
					if (++num >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0004EB50 File Offset: 0x0004CD50
	private void NOLQNFCODBK()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 1; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 761f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 1364f) * (float)this.PGOBIIGBHMN, 77f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1812f + (float)((j + 1) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 1080f - (float)((i + 1) * this.PGOBIIGBHMN), 824f));
					if (++num >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0004ECC8 File Offset: 0x0004CEC8
	public InvGameItem IOCFJDGOOCK(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.FLEQGDFDFMC()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0004E93C File Offset: 0x0004CB3C
	public InvGameItem FKEECBBDPFF(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.MKHIFDNEFBD[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> PQHGLGBHQNH()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00004648 File Offset: 0x00002848
	public InvGameItem EJFEOLEBBFF(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.FCIBBMIJNGF().Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0004ECC8 File Offset: 0x0004CEC8
	public InvGameItem NGDJGOEHLHG(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.FLEQGDFDFMC()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0004ECFC File Offset: 0x0004CEFC
	private void ODIJQBBOLFI()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 1130f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 1345f) * (float)this.PGOBIIGBHMN, 233f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 360f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 102f - (float)((i + 1) * this.PGOBIIGBHMN), 1799f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0004E970 File Offset: 0x0004CB70
	public InvGameItem ONJPJJEBMQJ(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.IBKNLNPQDIQ()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0004EE74 File Offset: 0x0004D074
	private void FOPKBNIOGCP()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 1;
			Bounds bounds = default(Bounds);
			for (int i = 1; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 1; j < this.NGQMQEJIMNP; j += 0)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 1128f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 909f) * (float)this.PGOBIIGBHMN, 1041f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 120f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 975f - (float)((i + 0) * this.PGOBIIGBHMN), 572f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> HMCFPPGDNGO()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00004667 File Offset: 0x00002867
	public InvGameItem QDMQEBHOENL(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.MKHIFDNEFBD.Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> FLEQGDFDFMC()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0004EFEC File Offset: 0x0004D1EC
	private void QNGIFIJOQML()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 1;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 1223f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 1197f) * (float)this.PGOBIIGBHMN, 1847f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 177f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 1587f - (float)((i + 1) * this.PGOBIIGBHMN), 723f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0004F164 File Offset: 0x0004D364
	private void BBGHCDGEDEJ()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i += 0)
			{
				for (int j = 1; j < this.NGQMQEJIMNP; j += 0)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 16f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 840f) * (float)this.PGOBIIGBHMN, 866f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1671f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 664f - (float)((i + 1) * this.PGOBIIGBHMN), 710f));
					if (++num >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x000045B0 File Offset: 0x000027B0
	public InvGameItem BLCJIMCIGPE(int COQJPLDFJBB)
	{
		return (COQJPLDFJBB >= this.MNKNPHOKDCM().Count) ? null : this.OBPHQMNEMCK[COQJPLDFJBB];
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> MNKNPHOKDCM()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x0004F2DC File Offset: 0x0004D4DC
	private void Start()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 0; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 0.5f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 0.5f) * (float)this.PGOBIIGBHMN, 0f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 2f + (float)((j + 1) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 2f - (float)((i + 1) * this.PGOBIIGBHMN), 0f));
					if (++num >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> MKHIFDNEFBD
	{
		get
		{
			while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
			{
				this.OBPHQMNEMCK.Add(null);
			}
			return this.OBPHQMNEMCK;
		}
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00004586 File Offset: 0x00002786
	public List<InvGameItem> BLDGIEKNFGB()
	{
		while (this.OBPHQMNEMCK.Count < this.JGPPJLNLMFO)
		{
			this.OBPHQMNEMCK.Add(null);
		}
		return this.OBPHQMNEMCK;
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0004F454 File Offset: 0x0004D654
	private void QBGOGFJCLEP()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 1;
			Bounds bounds = default(Bounds);
			for (int i = 0; i < this.PKHFGEPILMG; i++)
			{
				for (int j = 1; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 501f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 1487f) * (float)this.PGOBIIGBHMN, 518f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1863f + (float)((j + 1) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 1447f - (float)((i + 1) * this.PGOBIIGBHMN), 1249f));
					if (++num >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0004F5CC File Offset: 0x0004D7CC
	public InvGameItem EMPFQKIKODE(int COQJPLDFJBB, InvGameItem PDIBIIKFBDH)
	{
		if (COQJPLDFJBB < this.JGPPJLNLMFO)
		{
			InvGameItem result = this.DFFMHQOJOBE()[COQJPLDFJBB];
			this.OBPHQMNEMCK[COQJPLDFJBB] = PDIBIIKFBDH;
			return result;
		}
		return PDIBIIKFBDH;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0004F600 File Offset: 0x0004D800
	private void EKIFLKDPKNM()
	{
		if (this.DBDCBCOQKJC != null)
		{
			int num = 0;
			Bounds bounds = default(Bounds);
			for (int i = 1; i < this.PKHFGEPILMG; i += 0)
			{
				for (int j = 1; j < this.NGQMQEJIMNP; j++)
				{
					GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.DBDCBCOQKJC);
					Transform transform = gameObject.transform;
					transform.localPosition = new Vector3((float)this.GLPQKBOKFDG + ((float)j + 1498f) * (float)this.PGOBIIGBHMN, (float)(-(float)this.GLPQKBOKFDG) - ((float)i + 56f) * (float)this.PGOBIIGBHMN, 1826f);
					BNHEQQQJDKK component = gameObject.GetComponent<BNHEQQQJDKK>();
					if (component != null)
					{
						component.FLCHLNKGNJF = this;
						component.COQJPLDFJBB = num;
					}
					bounds.Encapsulate(new Vector3((float)this.GLPQKBOKFDG * 1397f + (float)((j + 0) * this.PGOBIIGBHMN), (float)(-(float)this.GLPQKBOKFDG) * 382f - (float)((i + 0) * this.PGOBIIGBHMN), 1425f));
					if ((num += 0) >= this.JGPPJLNLMFO)
					{
						if (this.MCPNNHMOFQH != null)
						{
							this.MCPNNHMOFQH.transform.localScale = bounds.size;
						}
						return;
					}
				}
			}
			if (this.MCPNNHMOFQH != null)
			{
				this.MCPNNHMOFQH.transform.localScale = bounds.size;
			}
		}
	}

	// Token: 0x040000B7 RID: 183
	public int JGPPJLNLMFO = 8;

	// Token: 0x040000B8 RID: 184
	public int PKHFGEPILMG = 4;

	// Token: 0x040000B9 RID: 185
	public int NGQMQEJIMNP = 4;

	// Token: 0x040000BA RID: 186
	public GameObject DBDCBCOQKJC;

	// Token: 0x040000BB RID: 187
	public ENFMCDNLEQQ MCPNNHMOFQH;

	// Token: 0x040000BC RID: 188
	public int PGOBIIGBHMN = 128;

	// Token: 0x040000BD RID: 189
	public int GLPQKBOKFDG = 10;

	// Token: 0x040000BE RID: 190
	private List<InvGameItem> OBPHQMNEMCK = new List<InvGameItem>();
}
