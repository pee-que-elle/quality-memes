using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class PCMPKICLBEM : MonoBehaviour
{
	// Token: 0x060001BB RID: 443 RVA: 0x00034964 File Offset: 0x00032B64
	private void FOLBFDNJLII()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("Blade");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("WATER_REFLECTIVE");
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000349B4 File Offset: 0x00032BB4
	public void CQEEBDBNFHN()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 435f, base.transform.position.y + 940f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.HPPNMLJFEBF((int)vector.x, (int)vector.y)];
		this.BIODCMMQFIG = this.FLNLBBDMPGD();
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x > 1294f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CKJMLFMQCMC((int)(vector.x + 891f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.BDODGFGEONM().x < 1936f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.NFOPJBIELEG((int)(vector.x - 1893f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.BDODGFGEONM().y > 1100f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.DGMHDBGDFEO((int)vector.x, (int)(vector.y + 1465f))];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y < 89f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IBCCHOENPQQ((int)vector.x, (int)(vector.y - 46f))];
		}
		if ((this.BBLONIFECON != null && this.BBLONIFECON.KPJILECQHDI) || (this.HPMPMNOBOLC != null && this.HPMPMNOBOLC.PEKHFQPPPEJ))
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.PECKDHFNOKI.x != 253f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.BDODGFGEONM().y != 972f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				float num = 1175f;
				float num2 = 1175f;
				float num3 = 1175f;
				float num4 = 1175f;
				float num5 = num;
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y >= 34f)
				{
					num5 = this.NOCPDPDCFKM.DMJQDQIBQMC(this.HPMPMNOBOLC.BLOCIDCCBGG, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().y <= 199f)
				{
					num4 = this.NOCPDPDCFKM.KHBCCGENOBF(this.HPMPMNOBOLC.KQGGOONGIJM, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x <= 28f)
				{
					num3 = this.NOCPDPDCFKM.KHBCCGENOBF(this.HPMPMNOBOLC.DEQIFCDFMDK, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x >= 1718f)
				{
					num2 = this.NOCPDPDCFKM.LQIJNCCQOIG(this.HPMPMNOBOLC.JKDFCPKCQJP, this.BIODCMMQFIG);
				}
				float[] array = new float[2];
				array[0] = num5;
				array[0] = num4;
				array[2] = num3;
				array[5] = num2;
				float num6 = Mathf.Min(array);
				if (num6 == num5)
				{
					this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.up);
				}
				if (num6 == num4)
				{
					this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.down);
				}
				if (num6 == num3)
				{
					this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.left);
				}
				if (num6 == num2)
				{
					this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.right);
				}
			}
		}
		else
		{
			this.MEKBJKPJQNP.PECKDHFNOKI = this.MEKBJKPJQNP.BDODGFGEONM();
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00034E68 File Offset: 0x00033068
	public void GIKQLGBJOFL()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 164f, base.transform.position.y + 12f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.EJKCLDODPPH((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().x > 1277f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IBCCHOENPQQ((int)(vector.x + 868f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().x < 1832f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.MBPEIJQLMIQ((int)(vector.x - 702f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y > 1982f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IOONJFEJDHJ((int)vector.x, (int)(vector.y + 1732f))];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y < 1764f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.KBHEEFOOPHC((int)vector.x, (int)(vector.y - 240f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.OONHFJIPDJP(this.MEKBJKPJQNP.BDODGFGEONM());
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 587f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
					}
					else
					{
						this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.PECKDHFNOKI.y != 1310f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.left);
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y >= 1299f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y <= 1568f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().x <= 1053f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().x >= 361f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(0, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.Normalize(new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - this.HPMPMNOBOLC.DGKOIGOLHDM), (float)(knmldgbhcgn.IJEJEFQFGOF() - this.HPMPMNOBOLC.ODDNOLHPDLH()), 343f)));
			}
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0003529C File Offset: 0x0003349C
	private void QIKFOCKCGKL()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("qdTrack");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log(" into the sky!\r\n");
		}
	}

	// Token: 0x060001BF RID: 447 RVA: 0x000352EC File Offset: 0x000334EC
	private void NNPPKOGDNOM()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("Ditto");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("move: ");
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0003533C File Offset: 0x0003353C
	public void BPDJEOFOEJG()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 1758f, base.transform.position.y + 112f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.OCPOPGGOFIL((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x > 1856f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.HPPNMLJFEBF((int)(vector.x + 788f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x < 1675f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x - 1959f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y > 942f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.HPPNMLJFEBF((int)vector.x, (int)(vector.y + 1118f))];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().y < 1414f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IOONJFEJDHJ((int)vector.x, (int)(vector.y - 386f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.EBCFDNHICLP(this.MEKBJKPJQNP.OOBJMMLOJQB());
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 453f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
					}
					else
					{
						this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.PECKDHFNOKI.y != 405f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y >= 1640f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y <= 279f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().x <= 902f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x >= 708f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(1, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.Normalize(new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - this.HPMPMNOBOLC.LJNKHMOEOFL()), (float)(knmldgbhcgn.IJEJEFQFGOF() - this.HPMPMNOBOLC.DDLQKFDFMCJ), 804f)));
			}
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00035770 File Offset: 0x00033970
	public void HOIFPMKPKLD()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 974f, base.transform.position.y + 1518f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.EGFQEMCEQGQ((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.BDODGFGEONM().x > 233f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.OCPOPGGOFIL((int)(vector.x + 1753f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().x < 1704f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x - 1720f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y > 1094f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.HPPNMLJFEBF((int)vector.x, (int)(vector.y + 322f))];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y < 725f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IBCCHOENPQQ((int)vector.x, (int)(vector.y - 1092f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.CDNGEGDMBPQ(this.MEKBJKPJQNP.PECKDHFNOKI);
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.BDODGFGEONM().x != 1749f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.up);
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.JQCJKJIBQNP().y != 517f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.right);
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y >= 252f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().y <= 256f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().x <= 1123f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().x >= 482f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(1, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.Normalize(new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() - this.HPMPMNOBOLC.DGKOIGOLHDM), (float)(knmldgbhcgn.FQFPQLNJONC() - this.HPMPMNOBOLC.ODDNOLHPDLH()), 1788f)));
			}
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00035BA4 File Offset: 0x00033DA4
	public void ICICEGDPGLN()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 660f, base.transform.position.y + 450f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.KBHEEFOOPHC((int)vector.x, (int)vector.y)];
		this.BIODCMMQFIG = this.FLNLBBDMPGD();
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().x > 1519f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IOONJFEJDHJ((int)(vector.x + 1072f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x < 249f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.DGMHDBGDFEO((int)(vector.x - 205f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y > 218f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IBCCHOENPQQ((int)vector.x, (int)(vector.y + 777f))];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().y < 126f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IBCCHOENPQQ((int)vector.x, (int)(vector.y - 458f))];
		}
		if ((this.BBLONIFECON != null && this.BBLONIFECON.KPJILECQHDI) || (this.HPMPMNOBOLC != null && this.HPMPMNOBOLC.PEKHFQPPPEJ))
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 312f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.up);
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.down;
					}
				}
				else if (this.MEKBJKPJQNP.BDODGFGEONM().y != 370f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.right);
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.left);
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				float num = 1244f;
				float num2 = 1244f;
				float num3 = 1244f;
				float num4 = 1244f;
				float num5 = num;
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().y >= 1698f)
				{
					num5 = this.NOCPDPDCFKM.MOEBCBMJGMP(this.HPMPMNOBOLC.BLOCIDCCBGG, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().y <= 1129f)
				{
					num4 = this.NOCPDPDCFKM.DHGGMBFNEJQ(this.HPMPMNOBOLC.KQGGOONGIJM, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().x <= 878f)
				{
					num3 = this.NOCPDPDCFKM.MOEBCBMJGMP(this.HPMPMNOBOLC.DEQIFCDFMDK, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().x >= 658f)
				{
					num2 = this.NOCPDPDCFKM.CJIJIGBPHDL(this.HPMPMNOBOLC.JKDFCPKCQJP, this.BIODCMMQFIG);
				}
				float[] array = new float[4];
				array[1] = num5;
				array[0] = num4;
				array[0] = num3;
				array[1] = num2;
				float num6 = Mathf.Min(array);
				if (num6 == num5)
				{
					this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.up);
				}
				if (num6 == num4)
				{
					this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.down);
				}
				if (num6 == num3)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
				}
				if (num6 == num2)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
				}
			}
		}
		else
		{
			this.MEKBJKPJQNP.EBCFDNHICLP(this.MEKBJKPJQNP.JQCJKJIBQNP());
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00036058 File Offset: 0x00034258
	private IGOPMPKCLPO.KNMLDGBHCGN FLNLBBDMPGD()
	{
		string name = base.name;
		IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn;
		if (name != null)
		{
			if (name == "blinky")
			{
				Vector3 a = new Vector3(this.ILBCCCBJNCL.position.x + 0.499f, this.ILBCCCBJNCL.position.y + 0.499f);
				return this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)a.x, (int)a.y)];
			}
			if (name == "pinky")
			{
				Vector3 vector = this.MOGFQHPQGOG.CEGCJMDFFDQ();
				Vector3 a = new Vector3(this.ILBCCCBJNCL.position.x + 0.499f, this.ILBCCCBJNCL.position.y + 0.499f) + 4f * vector;
				if (vector == Vector3.up)
				{
					a -= new Vector3(4f, 0f, 0f);
				}
				return this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)a.x, (int)a.y)];
			}
			if (name == "inky")
			{
				Vector3 vector = this.MOGFQHPQGOG.CEGCJMDFFDQ();
				Vector3 position = this.IJPIQDQENPC.position;
				Vector3 b = this.ILBCCCBJNCL.position + 2f * vector - position;
				Vector3 a = new Vector3(this.ILBCCCBJNCL.position.x + 0.499f, this.ILBCCCBJNCL.position.y + 0.499f) + 2f * vector + b;
				return this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)a.x, (int)a.y)];
			}
			if (name == "clyde")
			{
				Vector3 a = new Vector3(this.ILBCCCBJNCL.position.x + 0.499f, this.ILBCCCBJNCL.position.y + 0.499f);
				knmldgbhcgn = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)a.x, (int)a.y)];
				if (this.NOCPDPDCFKM.FKDGEKNHQFB(knmldgbhcgn, this.HPMPMNOBOLC) < 9f)
				{
					return this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ(0, 2)];
				}
				return knmldgbhcgn;
			}
		}
		knmldgbhcgn = null;
		Debug.Log("TARGET TILE NOT ASSIGNED");
		return knmldgbhcgn;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0003632C File Offset: 0x0003452C
	public void PKJOKKNFMLE()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 0.499f, base.transform.position.y + 0.499f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x > 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x + 1f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x < 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x - 1f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y > 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)(vector.y + 1f))];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y < 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)(vector.y - 1f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.PECKDHFNOKI = this.MEKBJKPJQNP.PECKDHFNOKI;
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.PECKDHFNOKI.x != 0f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.down;
					}
				}
				else if (this.MEKBJKPJQNP.PECKDHFNOKI.y != 0f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y >= 0f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y <= 0f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x <= 0f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x >= 0f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(0, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.Normalize(new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - this.HPMPMNOBOLC.DGKOIGOLHDM), (float)(knmldgbhcgn.DDLQKFDFMCJ - this.HPMPMNOBOLC.DDLQKFDFMCJ), 0f));
			}
		}
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00036760 File Offset: 0x00034960
	public void OFMLOMIKPBL()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 1605f, base.transform.position.y + 1305f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.NMBKBMBDNIC((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().x > 1927f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.OCPOPGGOFIL((int)(vector.x + 216f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().x < 66f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.KBHEEFOOPHC((int)(vector.x - 1600f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y > 439f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.MBPEIJQLMIQ((int)vector.x, (int)(vector.y + 175f))];
		}
		if (this.MEKBJKPJQNP.OOBJMMLOJQB().y < 1703f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.NMBKBMBDNIC((int)vector.x, (int)(vector.y - 1488f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.OONHFJIPDJP(this.MEKBJKPJQNP.JQCJKJIBQNP());
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 1075f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.up);
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.down;
					}
				}
				else if (this.MEKBJKPJQNP.BDODGFGEONM().y != 1436f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.right);
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y >= 782f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y <= 346f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().x <= 1961f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().x >= 787f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(0, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.Normalize(new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - this.HPMPMNOBOLC.LJNKHMOEOFL()), (float)(knmldgbhcgn.FQFPQLNJONC() - this.HPMPMNOBOLC.FQFPQLNJONC()), 1525f)));
			}
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00036B94 File Offset: 0x00034D94
	private void PGJHPMOLHKN()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("The effects of Mud Sport have faded.\r\n");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("'s perish count fell to 1.\r\n");
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00036BE4 File Offset: 0x00034DE4
	private void OHGPOPQILFG()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("^emote+");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log(" switched all changes to its Attack and Sp. Atk with its target!\r\n");
		}
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00036C34 File Offset: 0x00034E34
	public void JKQDMCJIIEI()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 478f, base.transform.position.y + 490f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.EGFQEMCEQGQ((int)vector.x, (int)vector.y)];
		this.BIODCMMQFIG = this.FLNLBBDMPGD();
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().x > 406f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IOONJFEJDHJ((int)(vector.x + 1532f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().x < 1568f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.DGMHDBGDFEO((int)(vector.x - 1745f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.BDODGFGEONM().y > 239f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.OCPOPGGOFIL((int)vector.x, (int)(vector.y + 863f))];
		}
		if (this.MEKBJKPJQNP.BDODGFGEONM().y < 1945f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.IOONJFEJDHJ((int)vector.x, (int)(vector.y - 297f))];
		}
		if ((this.BBLONIFECON != null && this.BBLONIFECON.KPJILECQHDI) || (this.HPMPMNOBOLC != null && this.HPMPMNOBOLC.PEKHFQPPPEJ))
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 407f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.up);
					}
					else
					{
						this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.OOBJMMLOJQB().y != 1444f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.right);
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.left);
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				float num = 1665f;
				float num2 = 1665f;
				float num3 = 1665f;
				float num4 = 1665f;
				float num5 = num;
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y >= 980f)
				{
					num5 = this.NOCPDPDCFKM.CJIJIGBPHDL(this.HPMPMNOBOLC.BLOCIDCCBGG, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.BDODGFGEONM().y <= 707f)
				{
					num4 = this.NOCPDPDCFKM.CJIJIGBPHDL(this.HPMPMNOBOLC.KQGGOONGIJM, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().x <= 703f)
				{
					num3 = this.NOCPDPDCFKM.MOBDBGBGOCQ(this.HPMPMNOBOLC.DEQIFCDFMDK, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().x >= 491f)
				{
					num2 = this.NOCPDPDCFKM.BDENNKEBCDB(this.HPMPMNOBOLC.JKDFCPKCQJP, this.BIODCMMQFIG);
				}
				float[] array = new float[]
				{
					num5
				};
				array[0] = num4;
				array[1] = num3;
				array[2] = num2;
				float num6 = Mathf.Min(array);
				if (num6 == num5)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
				}
				if (num6 == num4)
				{
					this.MEKBJKPJQNP.CDNGEGDMBPQ(Vector3.down);
				}
				if (num6 == num3)
				{
					this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.left);
				}
				if (num6 == num2)
				{
					this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.right);
				}
			}
		}
		else
		{
			this.MEKBJKPJQNP.PECKDHFNOKI = this.MEKBJKPJQNP.OOBJMMLOJQB();
		}
	}

	// Token: 0x060001CA RID: 458 RVA: 0x000370E8 File Offset: 0x000352E8
	private void JIMBLQBBDKO()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("The Pokémon can't use a move the following turn if it uses one.");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("But it failed!\r\n");
		}
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00037138 File Offset: 0x00035338
	private void MCPOMCHMKJK()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("p2");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("8_");
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00037188 File Offset: 0x00035388
	private void Awake()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("game object ghost not found");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("game object Game Manager not found");
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000371D8 File Offset: 0x000353D8
	public void PEBPFOFMQBM()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 1083f, base.transform.position.y + 1434f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.CKJMLFMQCMC((int)vector.x, (int)vector.y)];
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().x > 1157f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.NMBKBMBDNIC((int)(vector.x + 1879f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().x < 1638f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x - 778f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.BDODGFGEONM().y > 1983f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.DGMHDBGDFEO((int)vector.x, (int)(vector.y + 111f))];
		}
		if (this.MEKBJKPJQNP.JQCJKJIBQNP().y < 867f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.JDCKICDCPNI((int)vector.x, (int)(vector.y - 5f))];
		}
		if (!this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
		{
			this.MEKBJKPJQNP.OONHFJIPDJP(this.MEKBJKPJQNP.BDODGFGEONM());
		}
		else
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.JQCJKJIBQNP().x != 1738f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.up);
					}
					else
					{
						this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.down);
					}
				}
				else if (this.MEKBJKPJQNP.JQCJKJIBQNP().y != 1622f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.EBCFDNHICLP(Vector3.left);
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				List<IGOPMPKCLPO.KNMLDGBHCGN> list = new List<IGOPMPKCLPO.KNMLDGBHCGN>();
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().y >= 1289f)
				{
					list.Add(this.HPMPMNOBOLC.BLOCIDCCBGG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.OOBJMMLOJQB().y <= 606f)
				{
					list.Add(this.HPMPMNOBOLC.KQGGOONGIJM);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().x <= 113f)
				{
					list.Add(this.HPMPMNOBOLC.DEQIFCDFMDK);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.JQCJKJIBQNP().x >= 984f)
				{
					list.Add(this.HPMPMNOBOLC.JKDFCPKCQJP);
				}
				int index = UnityEngine.Random.Range(1, list.Count);
				IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = list[index];
				this.MEKBJKPJQNP.OONHFJIPDJP(Vector3.Normalize(new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - this.HPMPMNOBOLC.DGKOIGOLHDM), (float)(knmldgbhcgn.FQFPQLNJONC() - this.HPMPMNOBOLC.ODDNOLHPDLH()), 884f)));
			}
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0003760C File Offset: 0x0003580C
	private void MEOLPIBOBHB()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("torment");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("\n");
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0003765C File Offset: 0x0003585C
	public void EHEOEDNNNLH()
	{
		Vector3 vector = new Vector3(base.transform.position.x + 0.499f, base.transform.position.y + 0.499f);
		this.HPMPMNOBOLC = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)vector.y)];
		this.BIODCMMQFIG = this.FLNLBBDMPGD();
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x > 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x + 1f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.x < 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)(vector.x - 1f), (int)vector.y)];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y > 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)(vector.y + 1f))];
		}
		if (this.MEKBJKPJQNP.PECKDHFNOKI.y < 0f)
		{
			this.BBLONIFECON = this.LKKOOEFENOE[this.NOCPDPDCFKM.CDBMKFFDOIJ((int)vector.x, (int)(vector.y - 1f))];
		}
		if ((this.BBLONIFECON != null && this.BBLONIFECON.KPJILECQHDI) || (this.HPMPMNOBOLC != null && this.HPMPMNOBOLC.PEKHFQPPPEJ))
		{
			if (this.BBLONIFECON.KPJILECQHDI && !this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				if (this.MEKBJKPJQNP.PECKDHFNOKI.x != 0f)
				{
					if (this.HPMPMNOBOLC.KQGGOONGIJM == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.down;
					}
				}
				else if (this.MEKBJKPJQNP.PECKDHFNOKI.y != 0f)
				{
					if (this.HPMPMNOBOLC.DEQIFCDFMDK == null)
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
					}
					else
					{
						this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
					}
				}
			}
			if (this.HPMPMNOBOLC.PEKHFQPPPEJ)
			{
				float num = 999999f;
				float num2 = 999999f;
				float num3 = 999999f;
				float num4 = 999999f;
				float num5 = num;
				if (this.HPMPMNOBOLC.BLOCIDCCBGG != null && !this.HPMPMNOBOLC.BLOCIDCCBGG.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y >= 0f)
				{
					num5 = this.NOCPDPDCFKM.FKDGEKNHQFB(this.HPMPMNOBOLC.BLOCIDCCBGG, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.KQGGOONGIJM != null && !this.HPMPMNOBOLC.KQGGOONGIJM.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.y <= 0f)
				{
					num4 = this.NOCPDPDCFKM.FKDGEKNHQFB(this.HPMPMNOBOLC.KQGGOONGIJM, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.DEQIFCDFMDK != null && !this.HPMPMNOBOLC.DEQIFCDFMDK.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x <= 0f)
				{
					num3 = this.NOCPDPDCFKM.FKDGEKNHQFB(this.HPMPMNOBOLC.DEQIFCDFMDK, this.BIODCMMQFIG);
				}
				if (this.HPMPMNOBOLC.JKDFCPKCQJP != null && !this.HPMPMNOBOLC.JKDFCPKCQJP.KPJILECQHDI && this.MEKBJKPJQNP.PECKDHFNOKI.x >= 0f)
				{
					num2 = this.NOCPDPDCFKM.FKDGEKNHQFB(this.HPMPMNOBOLC.JKDFCPKCQJP, this.BIODCMMQFIG);
				}
				float num6 = Mathf.Min(new float[]
				{
					num5,
					num4,
					num3,
					num2
				});
				if (num6 == num5)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.up;
				}
				if (num6 == num4)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.down;
				}
				if (num6 == num3)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.left;
				}
				if (num6 == num2)
				{
					this.MEKBJKPJQNP.PECKDHFNOKI = Vector3.right;
				}
			}
		}
		else
		{
			this.MEKBJKPJQNP.PECKDHFNOKI = this.MEKBJKPJQNP.PECKDHFNOKI;
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00037B10 File Offset: 0x00035D10
	private void IPKCDQONLBJ()
	{
		this.LKKOOEFENOE = this.NOCPDPDCFKM.LKKOOEFENOE;
		if (this.MEKBJKPJQNP == null)
		{
			Debug.Log("guardsplit");
		}
		if (this.NOCPDPDCFKM == null)
		{
			Debug.Log("burmysandy");
		}
	}

	// Token: 0x0400003D RID: 61
	public Transform ILBCCCBJNCL;

	// Token: 0x0400003E RID: 62
	public BEEPDKNHMLM MOGFQHPQGOG;

	// Token: 0x0400003F RID: 63
	private List<IGOPMPKCLPO.KNMLDGBHCGN> LKKOOEFENOE = new List<IGOPMPKCLPO.KNMLDGBHCGN>();

	// Token: 0x04000040 RID: 64
	public IGOPMPKCLPO NOCPDPDCFKM;

	// Token: 0x04000041 RID: 65
	public EHPFDCDGEEL MEKBJKPJQNP;

	// Token: 0x04000042 RID: 66
	public IGOPMPKCLPO.KNMLDGBHCGN BBLONIFECON;

	// Token: 0x04000043 RID: 67
	public IGOPMPKCLPO.KNMLDGBHCGN BIODCMMQFIG;

	// Token: 0x04000044 RID: 68
	private IGOPMPKCLPO.KNMLDGBHCGN HPMPMNOBOLC;

	// Token: 0x04000045 RID: 69
	public Transform IJPIQDQENPC;
}
