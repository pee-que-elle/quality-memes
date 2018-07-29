using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class IGOPMPKCLPO : MonoBehaviour
{
	// Token: 0x060002C2 RID: 706 RVA: 0x00002300 File Offset: 0x00000500
	private void FHFMKHDMDDI()
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0003B394 File Offset: 0x00039594
	private void OPHJOKCLKCI()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM, (float)knmldgbhcgn.ODDNOLHPDLH(), 728f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 1644f, (float)(knmldgbhcgn.IJEJEFQFGOF() + 0), 850f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 1576f, (float)(knmldgbhcgn.DDLQKFDFMCJ - 1), 924f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - 1), (float)knmldgbhcgn.DDLQKFDFMCJ + 1307f, 1787f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() + 0), (float)knmldgbhcgn.IJEJEFQFGOF() - 1775f, 342f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0003B4C8 File Offset: 0x000396C8
	public int IOONJFEJDHJ(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= 25 && IGNHJOPJDIO <= 100 && IGNHJOPJDIO >= 0)
		{
			return (125 - IGNHJOPJDIO) * 49 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > -65)
		{
			FDICGOKLNLM = -11;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > -33)
		{
			IGNHJOPJDIO = 65;
		}
		return (104 - IGNHJOPJDIO) * 101 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0003B520 File Offset: 0x00039720
	public int NFOPJBIELEG(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= -17 && IGNHJOPJDIO <= -113 && IGNHJOPJDIO >= 0)
		{
			return (-51 - IGNHJOPJDIO) * 37 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > 87)
		{
			FDICGOKLNLM = 63;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > 21)
		{
			IGNHJOPJDIO = 115;
		}
		return (-18 - IGNHJOPJDIO) * 103 + FDICGOKLNLM - 0;
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00003092 File Offset: 0x00001292
	public float MOEBCBMJGMP(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 696f) + Mathf.Pow((float)(DQKGCKJDGJF.FQFPQLNJONC() - HMIPBKLKGLF.ODDNOLHPDLH()), 836f));
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0003B578 File Offset: 0x00039778
	public int MBPEIJQLMIQ(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= 78 && IGNHJOPJDIO <= -97 && IGNHJOPJDIO >= 1)
		{
			return (-103 - IGNHJOPJDIO) * 19 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > 92)
		{
			FDICGOKLNLM = -101;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > 124)
		{
			IGNHJOPJDIO = 94;
		}
		return (-35 - IGNHJOPJDIO) * 37 + FDICGOKLNLM - 0;
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x000030CA File Offset: 0x000012CA
	private void KEGBCBGIHHJ()
	{
		this.CLGGDHGIJKO();
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x000030D2 File Offset: 0x000012D2
	public int FPGQMHDGPJD(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (-114 - HJHHBNEPOGD.IJEJEFQFGOF()) * -23 + HJHHBNEPOGD.DGKOIGOLHDM - 0;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000030E9 File Offset: 0x000012E9
	private void NOBDHBBKKHN()
	{
		this.MPMJIPECOCK();
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002300 File Offset: 0x00000500
	private void QFFJMIOJENJ()
	{
	}

	// Token: 0x060002CC RID: 716 RVA: 0x000030F1 File Offset: 0x000012F1
	public float PFQGDPPDGIH(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.LJNKHMOEOFL() - HMIPBKLKGLF.DGKOIGOLHDM), 1364f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.DDLQKFDFMCJ), 349f));
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002300 File Offset: 0x00000500
	private void JQPKDIBJHHF()
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00003129 File Offset: 0x00001329
	public float MOBDBGBGOCQ(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.LJNKHMOEOFL() - HMIPBKLKGLF.LJNKHMOEOFL()), 1383f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.FQFPQLNJONC()), 298f));
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0003B5D0 File Offset: 0x000397D0
	private void IFHMNMECNQB()
	{
		string s = "MusicManager";
		int num = 41;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 1;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == '\u001b')
					{
						if (i != 0 && text[i - 0] == '\u000f')
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.NHOJKDGJCLL = knmldgbhcgn2.BNPCGFEQMHD() + 1;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							knmldgbhcgn3.MIEEKPLHMPQ(knmldgbhcgn3.NHOJKDGJCLL + 1);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = false;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < 91 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.EBFKOJQQQHO(knmldgbhcgn4.NHOJKDGJCLL + 1);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.NHOJKDGJCLL = knmldgbhcgn5.BNPCGFEQMHD() + 0;
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num -= 0;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.JDKLIOQQHKK() > 0)
			{
				knmldgbhcgn6.PEKHFQPPPEJ = false;
			}
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0003B7F0 File Offset: 0x000399F0
	private void MPMJIPECOCK()
	{
		string s = "_Vignette_Opacity";
		int num = -84;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 0;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == 'i')
					{
						if (i != 0 && (int)text[i - 0] == -34)
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.MIEEKPLHMPQ(knmldgbhcgn2.JDKLIOQQHKK() + 0);
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							knmldgbhcgn3.MNJHJDMEQDG(knmldgbhcgn3.JDKLIOQQHKK() + 0);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < -114 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.MNJHJDMEQDG(knmldgbhcgn4.JDKLIOQQHKK() + 0);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.MNJHJDMEQDG(knmldgbhcgn5.NHOJKDGJCLL + 1);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.NHOJKDGJCLL > 3)
			{
				knmldgbhcgn6.KOJQDFHNCDO(true);
			}
		}
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0003BA10 File Offset: 0x00039C10
	public int CKJMLFMQCMC(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= 115 && IGNHJOPJDIO <= 95 && IGNHJOPJDIO >= 0)
		{
			return (71 - IGNHJOPJDIO) * -13 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > 109)
		{
			FDICGOKLNLM = 60;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > 120)
		{
			IGNHJOPJDIO = -83;
		}
		return (-53 - IGNHJOPJDIO) * 39 + FDICGOKLNLM - 0;
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0003BA68 File Offset: 0x00039C68
	private void IMNKLFIFNJQ()
	{
		string s = "[PD]";
		int num = -124;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 0;
				for (int i = 1; i < text.Length; i += 0)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if ((int)text[i] == -34)
					{
						if (i != 0 && (int)text[i - 0] == -109)
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.EBFKOJQQQHO(knmldgbhcgn2.NHOJKDGJCLL + 1);
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							knmldgbhcgn3.EBFKOJQQQHO(knmldgbhcgn3.JDKLIOQQHKK() + 1);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = false;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < -17 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.NHOJKDGJCLL = knmldgbhcgn4.JDKLIOQQHKK() + 1;
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.NHOJKDGJCLL = knmldgbhcgn5.JDKLIOQQHKK() + 0;
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.NHOJKDGJCLL > 0)
			{
				knmldgbhcgn6.BCBMHFIDBLG(false);
			}
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00003161 File Offset: 0x00001361
	public int QCHDGGBHNQG(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (111 - HJHHBNEPOGD.FQFPQLNJONC()) * 79 + HJHHBNEPOGD.DGKOIGOLHDM - 1;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00003178 File Offset: 0x00001378
	public float CJIJIGBPHDL(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.LJNKHMOEOFL()), 1477f) + Mathf.Pow((float)(DQKGCKJDGJF.ODDNOLHPDLH() - HMIPBKLKGLF.DDLQKFDFMCJ), 36f));
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x000031B0 File Offset: 0x000013B0
	private void MBKJBIQKPGF()
	{
		this.IJFKHCQIGLC();
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0003BC88 File Offset: 0x00039E88
	public int CDBMKFFDOIJ(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= 28 && IGNHJOPJDIO <= 31 && IGNHJOPJDIO >= 1)
		{
			return (31 - IGNHJOPJDIO) * 28 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > 28)
		{
			FDICGOKLNLM = 28;
		}
		if (IGNHJOPJDIO < 1)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > 31)
		{
			IGNHJOPJDIO = 31;
		}
		return (31 - IGNHJOPJDIO) * 28 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0003BCE0 File Offset: 0x00039EE0
	private void ECDFBMOOGDE()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL(), (float)knmldgbhcgn.DDLQKFDFMCJ, 528f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 1242f, (float)(knmldgbhcgn.ODDNOLHPDLH() + 1), 813f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 1811f, (float)(knmldgbhcgn.FQFPQLNJONC() - 1), 1466f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - 0), (float)knmldgbhcgn.FQFPQLNJONC() + 1594f, 1775f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM + 1), (float)knmldgbhcgn.ODDNOLHPDLH() - 472f, 280f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000031B8 File Offset: 0x000013B8
	private void Start()
	{
		this.FCOQIEBDLEL();
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0003BE14 File Offset: 0x0003A014
	private void CGJNHGOHHNG()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM, (float)knmldgbhcgn.FQFPQLNJONC(), 1818f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 1844f, (float)(knmldgbhcgn.IJEJEFQFGOF() + 1), 439f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL() - 99f, (float)(knmldgbhcgn.FQFPQLNJONC() - 0), 1996f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() - 0), (float)knmldgbhcgn.DDLQKFDFMCJ + 1107f, 192f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() + 0), (float)knmldgbhcgn.ODDNOLHPDLH() - 635f, 1160f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002DA RID: 730 RVA: 0x000031C0 File Offset: 0x000013C0
	public float BDENNKEBCDB(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.LJNKHMOEOFL()), 792f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.ODDNOLHPDLH()), 139f));
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0003BF48 File Offset: 0x0003A148
	public int GJJHHNLPHIM(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= 53 && IGNHJOPJDIO <= -40 && IGNHJOPJDIO >= 0)
		{
			return (-120 - IGNHJOPJDIO) * 2 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > -92)
		{
			FDICGOKLNLM = 2;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > -124)
		{
			IGNHJOPJDIO = 43;
		}
		return (-78 - IGNHJOPJDIO) * 56 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x000031F8 File Offset: 0x000013F8
	public int QOOGCKHPGCD(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (-108 - HJHHBNEPOGD.IJEJEFQFGOF()) * -39 + HJHHBNEPOGD.LJNKHMOEOFL() - 1;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00002300 File Offset: 0x00000500
	private void Update()
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
	private void HJLLIFPIJJL()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM, (float)knmldgbhcgn.DDLQKFDFMCJ, 0f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 0.1f, (float)(knmldgbhcgn.DDLQKFDFMCJ + 1), 0f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 0.1f, (float)(knmldgbhcgn.DDLQKFDFMCJ - 1), 0f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - 1), (float)knmldgbhcgn.DDLQKFDFMCJ + 0.1f, 0f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM + 1), (float)knmldgbhcgn.DDLQKFDFMCJ - 0.1f, 0f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0000320F File Offset: 0x0000140F
	public float KHBCCGENOBF(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 969f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.IJEJEFQFGOF()), 635f));
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
	public int OCPOPGGOFIL(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= 74 && IGNHJOPJDIO <= -96 && IGNHJOPJDIO >= 1)
		{
			return (-5 - IGNHJOPJDIO) * 70 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > 102)
		{
			FDICGOKLNLM = 58;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > 88)
		{
			IGNHJOPJDIO = 29;
		}
		return (-54 - IGNHJOPJDIO) * -69 + FDICGOKLNLM - 0;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00003247 File Offset: 0x00001447
	public int LKIJENICBFQ(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (32 - HJHHBNEPOGD.DDLQKFDFMCJ) * -22 + HJHHBNEPOGD.LJNKHMOEOFL() - 1;
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0000325E File Offset: 0x0000145E
	public int NKQHECFKEKE(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (-2 - HJHHBNEPOGD.ODDNOLHPDLH()) * -36 + HJHHBNEPOGD.DGKOIGOLHDM - 1;
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0003C12C File Offset: 0x0003A32C
	private void CLGGDHGIJKO()
	{
		string s = "desolateland";
		int num = -67;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 0;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == 'U')
					{
						if (i != 0 && text[i - 0] == '\u0006')
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.MNJHJDMEQDG(knmldgbhcgn2.NHOJKDGJCLL + 0);
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							knmldgbhcgn3.EBFKOJQQQHO(knmldgbhcgn3.NHOJKDGJCLL + 0);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < 17 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						knmldgbhcgn.NHOJKDGJCLL++;
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = this.LKKOOEFENOE[index];
						knmldgbhcgn4.MIEEKPLHMPQ(knmldgbhcgn4.JDKLIOQQHKK() + 1);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2++;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn5.BNPCGFEQMHD() > 6)
			{
				knmldgbhcgn5.KOJQDFHNCDO(true);
			}
		}
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x000031B8 File Offset: 0x000013B8
	private void IMGNEDCFBLL()
	{
		this.FCOQIEBDLEL();
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00003275 File Offset: 0x00001475
	public float DMJQDQIBQMC(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 484f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.IJEJEFQFGOF()), 187f));
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002300 File Offset: 0x00000500
	private void FLNFKFECNFJ()
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0003C34C File Offset: 0x0003A54C
	private void IJFKHCQIGLC()
	{
		string s = "SSAO";
		int num = -6;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 0;
				for (int i = 0; i < text.Length; i += 0)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if ((int)text[i] == -6)
					{
						if (i != 0 && (int)text[i - 1] == -71)
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.NHOJKDGJCLL = knmldgbhcgn2.JDKLIOQQHKK() + 0;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							knmldgbhcgn3.MNJHJDMEQDG(knmldgbhcgn3.NHOJKDGJCLL + 0);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = false;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < 70 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.MNJHJDMEQDG(knmldgbhcgn4.NHOJKDGJCLL + 0);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.MIEEKPLHMPQ(knmldgbhcgn5.BNPCGFEQMHD() + 0);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.NHOJKDGJCLL > 6)
			{
				knmldgbhcgn6.PEKHFQPPPEJ = true;
			}
		}
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0003C56C File Offset: 0x0003A76C
	private void FCOQIEBDLEL()
	{
		string s = "0000000000000000000000000000\n0111111111111001111111111110\n0100001000001001000001000010\n0100001000001111000001000010\n0100001000001001000001000010\n0111111111111001111111111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001111001111001111110\n0001001000001001000001001000\n0001001000001001000001001000\n0111001111111111111111001110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001000000001001111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111001001111111111001001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111111111111111111111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111001111111001111111001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111001111001111001111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111111111111111111111111110\n0000000000000000000000000000";
		int num = 31;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 1;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == '1')
					{
						if (i != 0 && text[i - 1] == '1')
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							knmldgbhcgn.NHOJKDGJCLL++;
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].NHOJKDGJCLL++;
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < 30 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						knmldgbhcgn.NHOJKDGJCLL++;
						this.LKKOOEFENOE[index].NHOJKDGJCLL++;
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2++;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn2.NHOJKDGJCLL > 2)
			{
				knmldgbhcgn2.PEKHFQPPPEJ = true;
			}
		}
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002300 File Offset: 0x00000500
	private void EPOCMHBMHGC()
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002300 File Offset: 0x00000500
	private void MEDIPECIDQP()
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x000032C0 File Offset: 0x000014C0
	public int KKNDJMGDFPL(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (104 - HJHHBNEPOGD.FQFPQLNJONC()) * -109 + HJHHBNEPOGD.LJNKHMOEOFL() - 0;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x0003C78C File Offset: 0x0003A98C
	private void NFIDHHGKBLJ()
	{
		string s = "_RcpMaxCoC";
		int num = 97;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 1;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == '*')
					{
						if (i != 0 && text[i - 1] == '\u007f')
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.MIEEKPLHMPQ(knmldgbhcgn2.JDKLIOQQHKK() + 1);
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0].NHOJKDGJCLL++;
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < -128 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = knmldgbhcgn;
						knmldgbhcgn3.NHOJKDGJCLL = knmldgbhcgn3.JDKLIOQQHKK() + 1;
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = this.LKKOOEFENOE[index];
						knmldgbhcgn4.NHOJKDGJCLL = knmldgbhcgn4.JDKLIOQQHKK() + 1;
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn5.NHOJKDGJCLL > 4)
			{
				knmldgbhcgn5.KOJQDFHNCDO(true);
			}
		}
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0003C9AC File Offset: 0x0003ABAC
	public int EJKCLDODPPH(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= -25 && IGNHJOPJDIO <= -86 && IGNHJOPJDIO >= 0)
		{
			return (113 - IGNHJOPJDIO) * 115 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > 126)
		{
			FDICGOKLNLM = -121;
		}
		if (IGNHJOPJDIO < 1)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > 117)
		{
			IGNHJOPJDIO = -52;
		}
		return (-64 - IGNHJOPJDIO) * 126 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0003CA04 File Offset: 0x0003AC04
	public int KBHEEFOOPHC(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= -111 && IGNHJOPJDIO <= 110 && IGNHJOPJDIO >= 0)
		{
			return (-41 - IGNHJOPJDIO) * 125 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > 13)
		{
			FDICGOKLNLM = -49;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > 117)
		{
			IGNHJOPJDIO = 36;
		}
		return (-77 - IGNHJOPJDIO) * -37 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0003CA5C File Offset: 0x0003AC5C
	public int EGFQEMCEQGQ(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= -67 && IGNHJOPJDIO <= 20 && IGNHJOPJDIO >= 1)
		{
			return (27 - IGNHJOPJDIO) * -42 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > 52)
		{
			FDICGOKLNLM = 16;
		}
		if (IGNHJOPJDIO < 1)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > 126)
		{
			IGNHJOPJDIO = -3;
		}
		return (55 - IGNHJOPJDIO) * 9 + FDICGOKLNLM - 0;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
	private void HMHBPPQGGBQ()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL(), (float)knmldgbhcgn.ODDNOLHPDLH(), 1844f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 839f, (float)(knmldgbhcgn.FQFPQLNJONC() + 1), 51f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 1833f, (float)(knmldgbhcgn.ODDNOLHPDLH() - 1), 459f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() - 1), (float)knmldgbhcgn.IJEJEFQFGOF() + 860f, 1384f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM + 1), (float)knmldgbhcgn.FQFPQLNJONC() - 587f, 1607f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000032D7 File Offset: 0x000014D7
	public float FKDGEKNHQFB(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 2f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.DDLQKFDFMCJ), 2f));
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000330F File Offset: 0x0000150F
	public float LQIJNCCQOIG(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 1816f) + Mathf.Pow((float)(DQKGCKJDGJF.DDLQKFDFMCJ - HMIPBKLKGLF.IJEJEFQFGOF()), 557f));
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00003347 File Offset: 0x00001547
	public int LCENEJJOQOF(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (43 - HJHHBNEPOGD.ODDNOLHPDLH()) * 104 + HJHHBNEPOGD.DGKOIGOLHDM - 0;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0000335E File Offset: 0x0000155E
	public int CDBMKFFDOIJ(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (31 - HJHHBNEPOGD.DDLQKFDFMCJ) * 28 + HJHHBNEPOGD.DGKOIGOLHDM - 1;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002300 File Offset: 0x00000500
	private void EBCOLLDGMOQ()
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002300 File Offset: 0x00000500
	private void EPKGNIPJOEF()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x000030E9 File Offset: 0x000012E9
	private void COOEINBIIIE()
	{
		this.MPMJIPECOCK();
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
	public int IBCCHOENPQQ(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= 71 && IGNHJOPJDIO <= -58 && IGNHJOPJDIO >= 0)
		{
			return (-36 - IGNHJOPJDIO) * 127 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 1)
		{
			FDICGOKLNLM = 1;
		}
		if (FDICGOKLNLM > -104)
		{
			FDICGOKLNLM = 90;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > -116)
		{
			IGNHJOPJDIO = -66;
		}
		return (123 - IGNHJOPJDIO) * 103 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0003CC40 File Offset: 0x0003AE40
	public int NMBKBMBDNIC(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= 10 && IGNHJOPJDIO <= 127 && IGNHJOPJDIO >= 0)
		{
			return (-4 - IGNHJOPJDIO) * 6 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > -48)
		{
			FDICGOKLNLM = 21;
		}
		if (IGNHJOPJDIO < 1)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > -52)
		{
			IGNHJOPJDIO = -13;
		}
		return (-15 - IGNHJOPJDIO) * 116 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0003CC98 File Offset: 0x0003AE98
	public int JDCKICDCPNI(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= 34 && IGNHJOPJDIO <= -79 && IGNHJOPJDIO >= 1)
		{
			return (50 - IGNHJOPJDIO) * 40 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > -59)
		{
			FDICGOKLNLM = 3;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 0;
		}
		if (IGNHJOPJDIO > -83)
		{
			IGNHJOPJDIO = -84;
		}
		return (110 - IGNHJOPJDIO) * -113 + FDICGOKLNLM - 1;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00003375 File Offset: 0x00001575
	public int GBBCBBMQQNC(IGOPMPKCLPO.KNMLDGBHCGN HJHHBNEPOGD)
	{
		return (86 - HJHHBNEPOGD.DDLQKFDFMCJ) * 34 + HJHHBNEPOGD.LJNKHMOEOFL() - 1;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002300 File Offset: 0x00000500
	private void NLNIQPOMOGM()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
	private void QIJBJOLJJIJ()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM, (float)knmldgbhcgn.DDLQKFDFMCJ, 1073f);
			Vector3 end = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL() + 7f, (float)(knmldgbhcgn.FQFPQLNJONC() + 1), 527f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL() - 268f, (float)(knmldgbhcgn.FQFPQLNJONC() - 1), 630f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() - 1), (float)knmldgbhcgn.ODDNOLHPDLH() + 1129f, 9f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM + 1), (float)knmldgbhcgn.ODDNOLHPDLH() - 201f, 295f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000338C File Offset: 0x0000158C
	private void BCGQQOFCMQJ()
	{
		this.IMNKLFIFNJQ();
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0003CE24 File Offset: 0x0003B024
	private void PMCKPFIKQLJ()
	{
		string s = "Party";
		int num = 59;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 1;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == '^')
					{
						if (i != 0 && (int)text[i - 1] == -101)
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0].JKDFCPKCQJP = knmldgbhcgn;
							knmldgbhcgn.NHOJKDGJCLL++;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							knmldgbhcgn2.MIEEKPLHMPQ(knmldgbhcgn2.BNPCGFEQMHD() + 1);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < -59 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = knmldgbhcgn;
						knmldgbhcgn3.EBFKOJQQQHO(knmldgbhcgn3.NHOJKDGJCLL + 1);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = this.LKKOOEFENOE[index];
						knmldgbhcgn4.MIEEKPLHMPQ(knmldgbhcgn4.BNPCGFEQMHD() + 1);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2++;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn5.JDKLIOQQHKK() > 0)
			{
				knmldgbhcgn5.PEKHFQPPPEJ = true;
			}
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0003D044 File Offset: 0x0003B244
	private void OQLHPEPFFJC()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL(), (float)knmldgbhcgn.ODDNOLHPDLH(), 916f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 501f, (float)(knmldgbhcgn.IJEJEFQFGOF() + 0), 1652f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 1538f, (float)(knmldgbhcgn.DDLQKFDFMCJ - 0), 1573f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() - 1), (float)knmldgbhcgn.DDLQKFDFMCJ + 1613f, 1014f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM + 1), (float)knmldgbhcgn.FQFPQLNJONC() - 736f, 1827f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0003D178 File Offset: 0x0003B378
	public int HPPNMLJFEBF(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 0 && FDICGOKLNLM <= 73 && IGNHJOPJDIO <= 22 && IGNHJOPJDIO >= 0)
		{
			return (93 - IGNHJOPJDIO) * -102 + FDICGOKLNLM - 1;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > 41)
		{
			FDICGOKLNLM = 50;
		}
		if (IGNHJOPJDIO < 1)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > -94)
		{
			IGNHJOPJDIO = -68;
		}
		return (100 - IGNHJOPJDIO) * 48 + FDICGOKLNLM - 0;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
	private void NIBQDJKDLCE()
	{
		string s = "!\r\n";
		int num = 89;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 1;
				for (int i = 0; i < text.Length; i++)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if ((int)text[i] == -116)
					{
						if (i != 0 && text[i - 1] == '6')
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.NHOJKDGJCLL = knmldgbhcgn2.BNPCGFEQMHD() + 0;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							knmldgbhcgn3.NHOJKDGJCLL = knmldgbhcgn3.BNPCGFEQMHD() + 0;
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = true;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < 5 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.MIEEKPLHMPQ(knmldgbhcgn4.JDKLIOQQHKK() + 1);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.MIEEKPLHMPQ(knmldgbhcgn5.JDKLIOQQHKK() + 1);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num--;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.NHOJKDGJCLL > 0)
			{
				knmldgbhcgn6.BCBMHFIDBLG(false);
			}
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
	public int DGMHDBGDFEO(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (FDICGOKLNLM >= 1 && FDICGOKLNLM <= -20 && IGNHJOPJDIO <= 72 && IGNHJOPJDIO >= 1)
		{
			return (-60 - IGNHJOPJDIO) * -36 + FDICGOKLNLM - 0;
		}
		if (FDICGOKLNLM < 0)
		{
			FDICGOKLNLM = 0;
		}
		if (FDICGOKLNLM > -7)
		{
			FDICGOKLNLM = -37;
		}
		if (IGNHJOPJDIO < 0)
		{
			IGNHJOPJDIO = 1;
		}
		if (IGNHJOPJDIO > 8)
		{
			IGNHJOPJDIO = 24;
		}
		return (-27 - IGNHJOPJDIO) * 58 + FDICGOKLNLM - 1;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0003D448 File Offset: 0x0003B648
	private void PMILNDPEPLI()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL(), (float)knmldgbhcgn.DDLQKFDFMCJ, 294f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 1028f, (float)(knmldgbhcgn.ODDNOLHPDLH() + 0), 1639f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL() - 432f, (float)(knmldgbhcgn.IJEJEFQFGOF() - 1), 78f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - 0), (float)knmldgbhcgn.ODDNOLHPDLH() + 269f, 624f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() + 1), (float)knmldgbhcgn.FQFPQLNJONC() - 166f, 211f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0003D57C File Offset: 0x0003B77C
	private void JQHKOEKHLGI()
	{
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn in this.LKKOOEFENOE)
		{
			Vector3 start = new Vector3((float)knmldgbhcgn.LJNKHMOEOFL(), (float)knmldgbhcgn.DDLQKFDFMCJ, 88f);
			Vector3 end = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM + 41f, (float)(knmldgbhcgn.ODDNOLHPDLH() + 1), 1844f);
			Vector3 end2 = new Vector3((float)knmldgbhcgn.DGKOIGOLHDM - 1441f, (float)(knmldgbhcgn.FQFPQLNJONC() - 0), 1760f);
			Vector3 end3 = new Vector3((float)(knmldgbhcgn.DGKOIGOLHDM - 0), (float)knmldgbhcgn.DDLQKFDFMCJ + 1831f, 1633f);
			Vector3 end4 = new Vector3((float)(knmldgbhcgn.LJNKHMOEOFL() + 0), (float)knmldgbhcgn.IJEJEFQFGOF() - 1983f, 746f);
			if (knmldgbhcgn.BLOCIDCCBGG != null)
			{
				Debug.DrawLine(start, end);
			}
			if (knmldgbhcgn.KQGGOONGIJM != null)
			{
				Debug.DrawLine(start, end2);
			}
			if (knmldgbhcgn.DEQIFCDFMDK != null)
			{
				Debug.DrawLine(start, end3);
			}
			if (knmldgbhcgn.JKDFCPKCQJP != null)
			{
				Debug.DrawLine(start, end4);
			}
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00003394 File Offset: 0x00001594
	public float EBEPFNJKOMF(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.DGKOIGOLHDM - HMIPBKLKGLF.DGKOIGOLHDM), 12f) + Mathf.Pow((float)(DQKGCKJDGJF.ODDNOLHPDLH() - HMIPBKLKGLF.ODDNOLHPDLH()), 1615f));
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0003D6B0 File Offset: 0x0003B8B0
	private void COHNLEDKIHD()
	{
		string s = "CombinersArgsColorOp1";
		int num = 42;
		using (StringReader stringReader = new StringReader(s))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				int num2 = 0;
				for (int i = 1; i < text.Length; i += 0)
				{
					IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn = new IGOPMPKCLPO.KNMLDGBHCGN(num2, num);
					if (text[i] == 'Y')
					{
						if (i != 0 && (int)text[i - 1] == -87)
						{
							knmldgbhcgn.DEQIFCDFMDK = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 0];
							this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1].JKDFCPKCQJP = knmldgbhcgn;
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn2 = knmldgbhcgn;
							knmldgbhcgn2.MIEEKPLHMPQ(knmldgbhcgn2.NHOJKDGJCLL + 1);
							IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn3 = this.LKKOOEFENOE[this.LKKOOEFENOE.Count - 1];
							knmldgbhcgn3.EBFKOJQQQHO(knmldgbhcgn3.JDKLIOQQHKK() + 1);
						}
					}
					else
					{
						knmldgbhcgn.KPJILECQHDI = false;
					}
					int index = this.LKKOOEFENOE.Count - text.Length;
					if (num < -95 && !knmldgbhcgn.KPJILECQHDI && !this.LKKOOEFENOE[index].KPJILECQHDI)
					{
						this.LKKOOEFENOE[index].KQGGOONGIJM = knmldgbhcgn;
						knmldgbhcgn.BLOCIDCCBGG = this.LKKOOEFENOE[index];
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn4 = knmldgbhcgn;
						knmldgbhcgn4.EBFKOJQQQHO(knmldgbhcgn4.JDKLIOQQHKK() + 0);
						IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn5 = this.LKKOOEFENOE[index];
						knmldgbhcgn5.MNJHJDMEQDG(knmldgbhcgn5.JDKLIOQQHKK() + 0);
					}
					this.LKKOOEFENOE.Add(knmldgbhcgn);
					num2 += 0;
				}
				num -= 0;
			}
		}
		foreach (IGOPMPKCLPO.KNMLDGBHCGN knmldgbhcgn6 in this.LKKOOEFENOE)
		{
			if (knmldgbhcgn6.NHOJKDGJCLL > 0)
			{
				knmldgbhcgn6.PEKHFQPPPEJ = false;
			}
		}
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002300 File Offset: 0x00000500
	private void HCHNCCPGFCB()
	{
	}

	// Token: 0x0600030A RID: 778 RVA: 0x000031B8 File Offset: 0x000013B8
	private void HCHIDEKMEBB()
	{
		this.FCOQIEBDLEL();
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002300 File Offset: 0x00000500
	private void KMFJINCMCJC()
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x000033CC File Offset: 0x000015CC
	private void LIFJCBMQELJ()
	{
		this.IFHMNMECNQB();
	}

	// Token: 0x0600030D RID: 781 RVA: 0x000033D4 File Offset: 0x000015D4
	public float DHGGMBFNEJQ(IGOPMPKCLPO.KNMLDGBHCGN DQKGCKJDGJF, IGOPMPKCLPO.KNMLDGBHCGN HMIPBKLKGLF)
	{
		return Mathf.Sqrt(Mathf.Pow((float)(DQKGCKJDGJF.LJNKHMOEOFL() - HMIPBKLKGLF.DGKOIGOLHDM), 1360f) + Mathf.Pow((float)(DQKGCKJDGJF.ODDNOLHPDLH() - HMIPBKLKGLF.IJEJEFQFGOF()), 834f));
	}

	// Token: 0x0400006C RID: 108
	public List<IGOPMPKCLPO.KNMLDGBHCGN> LKKOOEFENOE = new List<IGOPMPKCLPO.KNMLDGBHCGN>();

	// Token: 0x02000012 RID: 18
	public class KNMLDGBHCGN
	{
		// Token: 0x0600030E RID: 782 RVA: 0x0000340C File Offset: 0x0000160C
		public void BCBMHFIDBLG(bool BGBMIEJJQKC)
		{
			this.<LQEKMEEIEPM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000340C File Offset: 0x0000160C
		public void KOJQDFHNCDO(bool BGBMIEJJQKC)
		{
			this.<LQEKMEEIEPM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003415 File Offset: 0x00001615
		public void NKNQJKEOFLE(int BGBMIEJJQKC)
		{
			this.<FBQOCEDLBGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000341E File Offset: 0x0000161E
		public int ODDNOLHPDLH()
		{
			return this.<FBQOCEDLBGF>k__BackingField;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003426 File Offset: 0x00001626
		public void EBFKOJQQQHO(int BGBMIEJJQKC)
		{
			this.<PBQJFBFHOLD>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000342F File Offset: 0x0000162F
		public void CPIKLQJKCJD(int BGBMIEJJQKC)
		{
			this.<IGJPDKLDNII>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0003D8D0 File Offset: 0x0003BAD0
		public KNMLDGBHCGN(int CBNPBEIOFLH, int BMPFKJDNQGQ)
		{
			this.DGKOIGOLHDM = CBNPBEIOFLH;
			this.DDLQKFDFMCJ = BMPFKJDNQGQ;
			this.KPJILECQHDI = false;
			this.DEQIFCDFMDK = (this.JKDFCPKCQJP = (this.BLOCIDCCBGG = (this.KQGGOONGIJM = null)));
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000342F File Offset: 0x0000162F
		public int DGKOIGOLHDM { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00003440 File Offset: 0x00001640
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003426 File Offset: 0x00001626
		public int NHOJKDGJCLL { get; set; }

		// Token: 0x06000317 RID: 791 RVA: 0x00003440 File Offset: 0x00001640
		public int JDKLIOQQHKK()
		{
			return this.<PBQJFBFHOLD>k__BackingField;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003426 File Offset: 0x00001626
		public void MNJHJDMEQDG(int BGBMIEJJQKC)
		{
			this.<PBQJFBFHOLD>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00003448 File Offset: 0x00001648
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000340C File Offset: 0x0000160C
		public bool PEKHFQPPPEJ { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000341E File Offset: 0x0000161E
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003415 File Offset: 0x00001615
		public int DDLQKFDFMCJ { get; set; }

		// Token: 0x0600031B RID: 795 RVA: 0x00003440 File Offset: 0x00001640
		public int BNPCGFEQMHD()
		{
			return this.<PBQJFBFHOLD>k__BackingField;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000341E File Offset: 0x0000161E
		public int IJEJEFQFGOF()
		{
			return this.<FBQOCEDLBGF>k__BackingField;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003426 File Offset: 0x00001626
		public void MIEEKPLHMPQ(int BGBMIEJJQKC)
		{
			this.<PBQJFBFHOLD>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000341E File Offset: 0x0000161E
		public int FQFPQLNJONC()
		{
			return this.<FBQOCEDLBGF>k__BackingField;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00003459 File Offset: 0x00001659
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003450 File Offset: 0x00001650
		public bool KPJILECQHDI { get; set; }

		// Token: 0x06000323 RID: 803 RVA: 0x00003415 File Offset: 0x00001615
		public void OENBQELOCBQ(int BGBMIEJJQKC)
		{
			this.<FBQOCEDLBGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000340C File Offset: 0x0000160C
		public void DIBDIFPLMGF(bool BGBMIEJJQKC)
		{
			this.<LQEKMEEIEPM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003438 File Offset: 0x00001638
		public int LJNKHMOEOFL()
		{
			return this.<IGJPDKLDNII>k__BackingField;
		}

		// Token: 0x04000072 RID: 114
		public IGOPMPKCLPO.KNMLDGBHCGN DEQIFCDFMDK;

		// Token: 0x04000073 RID: 115
		public IGOPMPKCLPO.KNMLDGBHCGN JKDFCPKCQJP;

		// Token: 0x04000074 RID: 116
		public IGOPMPKCLPO.KNMLDGBHCGN BLOCIDCCBGG;

		// Token: 0x04000075 RID: 117
		public IGOPMPKCLPO.KNMLDGBHCGN KQGGOONGIJM;
	}
}
