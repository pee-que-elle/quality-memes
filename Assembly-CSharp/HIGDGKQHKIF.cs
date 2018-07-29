using System;
using UnityEngine;

// Token: 0x02000281 RID: 641
public class HIGDGKQHKIF : MonoBehaviour
{
	// Token: 0x06005889 RID: 22665 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void DHLGDLOKLKN()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600588A RID: 22666 RVA: 0x002DF85C File Offset: 0x002DDA5C
	private void GCEDFPKOEMN()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 1; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 1815f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 358f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 1721f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1364f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 584f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 868f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1738f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 1959f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0600588B RID: 22667 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void QNGIFIJOQML()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600588C RID: 22668 RVA: 0x002DFB20 File Offset: 0x002DDD20
	private void HGKPKMMIPLG()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 733f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1731f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 547f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1636f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 846f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1796f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1229f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 1600f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0600588D RID: 22669 RVA: 0x002DFDE4 File Offset: 0x002DDFE4
	private void CBICBMGFHCP()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i++)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 785f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1452f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 166f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1527f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 1404f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 811f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1785f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 571f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0600588E RID: 22670 RVA: 0x002E00A8 File Offset: 0x002DE2A8
	private void FLNFKFECNFJ()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 1; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 1334f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1775f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 799f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1584f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 1540f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1914f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1515f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 1108f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0600588F RID: 22671 RVA: 0x002E036C File Offset: 0x002DE56C
	private void CLNOPBFEBID()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 1; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 506f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1831f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 106f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1450f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 112f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1868f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 462f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 10f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005890 RID: 22672 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void NOLQNFCODBK()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x06005891 RID: 22673 RVA: 0x002E0630 File Offset: 0x002DE830
	private void Update()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i++)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 10f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 10f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 10f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 10f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 12f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 12f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 12f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 12f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005892 RID: 22674 RVA: 0x002E08F4 File Offset: 0x002DEAF4
	private void JLBMOKHNDBI()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i++)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 158f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1878f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 1795f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1086f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 381f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 725f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 195f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 950f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005893 RID: 22675 RVA: 0x002E0BB8 File Offset: 0x002DEDB8
	private void QDIKKLMCIJK()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 155f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 556f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 1721f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 259f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 817f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1996f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 390f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 729f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005894 RID: 22676 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void LNHDODMGBKC()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x002E0E7C File Offset: 0x002DF07C
	private void NPQEGOIJHIL()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 1168f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1634f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 1710f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1556f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 518f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 377f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1364f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 277f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void Start()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x06005897 RID: 22679 RVA: 0x002E1140 File Offset: 0x002DF340
	private void GKBQDQKLPIM()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 215f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1665f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 818f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1980f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 1421f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 129f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 1568f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 820f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x002E1404 File Offset: 0x002DF604
	private void MOLCLOMMJNQ()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i += 0)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 1403f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1046f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 949f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 1396f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 1365f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1617f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 267f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 1926f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x06005899 RID: 22681 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void MGBMNEQCEBJ()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x002E16C8 File Offset: 0x002DF8C8
	private void PLCCHDMMBKF()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 1; i < particles; i++)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 1244f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1144f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 589f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 246f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 1404f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1411f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 883f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 1171f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0600589C RID: 22684 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void IMGNEDCFBLL()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600589D RID: 22685 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void LBIFHHFMPHD()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600589E RID: 22686 RVA: 0x00022AC1 File Offset: 0x00020CC1
	private void LMMGEGJCBJP()
	{
		this.FPKMBBBFDEF = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x0600589F RID: 22687 RVA: 0x002E198C File Offset: 0x002DFB8C
	private void HDMNIKNDNGQ()
	{
		if (this.FPKMBBBFDEF != null)
		{
			int particles = this.FPKMBBBFDEF.GetParticles(this.QKPCGGPPQCB);
			for (int i = 0; i < particles; i++)
			{
				if (this.QKPCGGPPQCB[i].position.x > base.transform.position.x + 801f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x - 1661f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				else if (this.QKPCGGPPQCB[i].position.x < base.transform.position.x - 423f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(base.transform.position.x + 430f, this.QKPCGGPPQCB[i].position.y, this.QKPCGGPPQCB[i].position.z);
				}
				if (this.QKPCGGPPQCB[i].position.z > base.transform.position.z + 88f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z - 1324f);
				}
				else if (this.QKPCGGPPQCB[i].position.z < base.transform.position.z - 930f)
				{
					this.QKPCGGPPQCB[i].position = new Vector3(this.QKPCGGPPQCB[i].position.x, this.QKPCGGPPQCB[i].position.y, base.transform.position.z + 46f);
				}
			}
			this.FPKMBBBFDEF.SetParticles(this.QKPCGGPPQCB, particles);
		}
	}

	// Token: 0x0400135C RID: 4956
	private ParticleSystem FPKMBBBFDEF;

	// Token: 0x0400135D RID: 4957
	private ParticleSystem.Particle[] QKPCGGPPQCB = new ParticleSystem.Particle[400];
}
