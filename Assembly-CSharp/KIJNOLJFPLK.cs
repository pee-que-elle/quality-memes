using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001A3 RID: 419
public class KIJNOLJFPLK : MonoBehaviour
{
	// Token: 0x060034B9 RID: 13497 RVA: 0x0019622C File Offset: 0x0019442C
	private int JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.Right && OIKFBLNFPNC != 10) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.UpIce && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			}
			if (KFJFFEEJIJF == KIJNOLJFPLK.HLCOIPECIEL.UpJump || KFJFFEEJIJF == KIJNOLJFPLK.HLCOIPECIEL.DownJump || KFJFFEEJIJF == KIJNOLJFPLK.HLCOIPECIEL.LeftJump || KFJFFEEJIJF == KIJNOLJFPLK.HLCOIPECIEL.RightJump)
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			}
		}
		switch (CELHPOHKIBG)
		{
		case 16:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			break;
		case 17:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			break;
		case 18:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			break;
		case 19:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			break;
		case 20:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			break;
		case 21:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Down || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			break;
		case 22:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			break;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
				{
					break;
				}
			}
			return 0;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.DownJump;
			return 1;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.LeftJump;
			return 1;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.RightJump;
			return 1;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.UpJump;
			return 1;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 4;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 11:
			LNPIMKLBOPN = true;
			return 1;
		case 12:
			LNPIMKLBOPN = false;
			return 1;
		case 13:
			return 1;
		case 14:
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 5 : 1;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			return 0;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 1;
			}
			return 0;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			return 0;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			return 0;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			return 0;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			return 0;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			return 0;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			return 0;
		case 24:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Down;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Down;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 5 : 0;
		}
		return 0;
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x000175CC File Offset: 0x000157CC
	private void LBIJFCFPKNM()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x000175CC File Offset: 0x000157CC
	private void HFBHKNOCLOE()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034BC RID: 13500 RVA: 0x000175CC File Offset: 0x000157CC
	private void OHGPOPQILFG()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x001964F8 File Offset: 0x001946F8
	public List<Vector2> EEDKFEPNKDH(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width; i += 0)
		{
			for (int j = 0; j < MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.QOQONHOOLNE.POMQCKOIKQJ[i, j];
			}
		}
		return this.GCCKFGHJFPO(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.height, EKEIIODHQFF, true);
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x001965A4 File Offset: 0x001947A4
	public List<Vector2> GCCKFGHJFPO(int MCHINMGBJBP, int HIFJJBLPGPQ, int BLQGKHGGNOC, int OIEIGDOCPLL, int[,] FNEDFIDLMBJ, int KJGMGPCEJJD, int DFKQMMIQDOO, bool JNMCJNIQOOQ = false, bool LENCHCHQQGG = false)
	{
		try
		{
			foreach (Vector2 vector in CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC)
			{
				FNEDFIDLMBJ[(int)vector.x, (int)vector.y] = 1;
			}
		}
		catch
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC.Clear();
		}
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq = null;
		KIJNOLJFPLK.IKMHFECLOOQ item = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = MCHINMGBJBP,
			IGNHJOPJDIO = HIFJJBLPGPQ,
			KBKKMQNFJIG = JNMCJNIQOOQ
		};
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq2 = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = BLQGKHGGNOC,
			IGNHJOPJDIO = OIEIGDOCPLL,
			KBKKMQNFJIG = LENCHCHQQGG
		};
		List<KIJNOLJFPLK.IKMHFECLOOQ> list = new List<KIJNOLJFPLK.IKMHFECLOOQ>();
		HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>> hashSet = new HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>>();
		list.Add(item);
		int num = 0;
		Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> obj = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq2.FDICGOKLNLM, ikmhfeclooq2.IGNHJOPJDIO, ikmhfeclooq2.KBKKMQNFJIG, ikmhfeclooq2.LCGDMMNIGQP);
		while (list.Count > 0)
		{
			int num2 = int.MaxValue;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].DFLGIJIMNMH < num2)
				{
					num2 = list[i].DFLGIJIMNMH;
					ikmhfeclooq = list[i];
				}
			}
			Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> tuple = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, ikmhfeclooq.LCGDMMNIGQP);
			hashSet.Add(tuple);
			if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				switch (ikmhfeclooq.LCGDMMNIGQP)
				{
				case KIJNOLJFPLK.HLCOIPECIEL.Up:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Down));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Down:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Left:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Right));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Right:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Left));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.UpIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.DownIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.DownIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.UpIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.LeftIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.RightIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.RightIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				}
			}
			list.Remove(ikmhfeclooq);
			if (tuple.Equals(obj))
			{
				List<Vector2> list2 = new List<Vector2>();
				while (ikmhfeclooq != null)
				{
					list2.Add(new Vector2((float)ikmhfeclooq.FDICGOKLNLM, (float)ikmhfeclooq.IGNHJOPJDIO));
					ikmhfeclooq = ikmhfeclooq.PQQEJQHDCPK;
				}
				return list2;
			}
			KIJNOLJFPLK.IKMHFECLOOQ[] array = new KIJNOLJFPLK.IKMHFECLOOQ[4];
			bool flag = false;
			if (ikmhfeclooq.IGNHJOPJDIO > 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Up || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpJump))
			{
				bool kbkkmqnfjig = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp = ikmhfeclooq.LCGDMMNIGQP;
				int num3 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Up, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 1], ref kbkkmqnfjig, ref lcgdmmnigqp);
				if (num3 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 1, kbkkmqnfjig, lcgdmmnigqp)))
				{
					array[0] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO - 1,
						KBKKMQNFJIG = kbkkmqnfjig,
						JHFPOPEJENB = num3,
						LCGDMMNIGQP = lcgdmmnigqp
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num3 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.IGNHJOPJDIO < DFKQMMIQDOO - 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Down || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownJump))
			{
				bool kbkkmqnfjig2 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp2 = ikmhfeclooq.LCGDMMNIGQP;
				int num4 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Down, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1], ref kbkkmqnfjig2, ref lcgdmmnigqp2);
				if (num4 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1, kbkkmqnfjig2, lcgdmmnigqp2)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO + 1,
						KBKKMQNFJIG = kbkkmqnfjig2,
						JHFPOPEJENB = num4,
						LCGDMMNIGQP = lcgdmmnigqp2
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num4 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM > 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Left || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.LeftIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.LeftJump))
			{
				bool kbkkmqnfjig3 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp3 = ikmhfeclooq.LCGDMMNIGQP;
				int num5 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Left, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig3, ref lcgdmmnigqp3);
				if (num5 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig3, lcgdmmnigqp3)))
				{
					array[2] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM - 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig3,
						JHFPOPEJENB = num5,
						LCGDMMNIGQP = lcgdmmnigqp3
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num5 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM < KJGMGPCEJJD - 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Right || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.RightIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.RightJump))
			{
				bool kbkkmqnfjig4 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp4 = ikmhfeclooq.LCGDMMNIGQP;
				int num6 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Right, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM + 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig4, ref lcgdmmnigqp4);
				if (num6 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM + 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig4, lcgdmmnigqp4)))
				{
					array[3] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM + 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig4,
						JHFPOPEJENB = num6,
						LCGDMMNIGQP = lcgdmmnigqp4
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num6 == 0)
				{
					flag = true;
				}
			}
			if (flag && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.None)))
			{
				ikmhfeclooq.LCGDMMNIGQP = KIJNOLJFPLK.HLCOIPECIEL.None;
				list.Add(ikmhfeclooq);
			}
			else
			{
				num++;
				foreach (KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq3 in array)
				{
					if (ikmhfeclooq3 != null)
					{
						bool flag2 = false;
						for (int k = 0; k < list.Count; k++)
						{
							KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq4 = list[k];
							if (ikmhfeclooq4.FDICGOKLNLM == ikmhfeclooq3.FDICGOKLNLM && ikmhfeclooq4.IGNHJOPJDIO == ikmhfeclooq3.IGNHJOPJDIO && ikmhfeclooq4.KBKKMQNFJIG == ikmhfeclooq3.KBKKMQNFJIG && ikmhfeclooq4.LCGDMMNIGQP == ikmhfeclooq3.LCGDMMNIGQP)
							{
								int num7 = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
								if (num7 + num + ikmhfeclooq4.DPIQMBNDHGG < ikmhfeclooq4.DFLGIJIMNMH)
								{
									ikmhfeclooq4.LCKFFKGLJFC = num7;
									ikmhfeclooq4.DFLGIJIMNMH = ikmhfeclooq4.LCKFFKGLJFC + ikmhfeclooq4.DPIQMBNDHGG + num;
									ikmhfeclooq4.PQQEJQHDCPK = ikmhfeclooq;
								}
								flag2 = true;
							}
						}
						if (!flag2)
						{
							ikmhfeclooq3.LCKFFKGLJFC = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
							ikmhfeclooq3.DPIQMBNDHGG = Math.Abs(ikmhfeclooq2.FDICGOKLNLM - ikmhfeclooq3.FDICGOKLNLM) + Math.Abs(ikmhfeclooq2.IGNHJOPJDIO - ikmhfeclooq3.IGNHJOPJDIO);
							ikmhfeclooq3.DFLGIJIMNMH = ikmhfeclooq3.LCKFFKGLJFC + ikmhfeclooq3.DPIQMBNDHGG + num;
							ikmhfeclooq3.PQQEJQHDCPK = ikmhfeclooq;
							list.Add(ikmhfeclooq3);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00196E50 File Offset: 0x00195050
	public List<Vector2> COHLGPNIDQC(int MCHINMGBJBP, int HIFJJBLPGPQ, int BLQGKHGGNOC, int OIEIGDOCPLL, int[,] FNEDFIDLMBJ, int KJGMGPCEJJD, int DFKQMMIQDOO, bool JNMCJNIQOOQ = false, bool LENCHCHQQGG = false)
	{
		try
		{
			foreach (Vector2 vector in CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.INMILPKMQIC)
			{
				FNEDFIDLMBJ[(int)vector.x, (int)vector.y] = 0;
			}
		}
		catch
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC.Clear();
		}
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq = null;
		KIJNOLJFPLK.IKMHFECLOOQ item = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = MCHINMGBJBP,
			IGNHJOPJDIO = HIFJJBLPGPQ,
			KBKKMQNFJIG = JNMCJNIQOOQ
		};
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq2 = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = BLQGKHGGNOC,
			IGNHJOPJDIO = OIEIGDOCPLL,
			KBKKMQNFJIG = LENCHCHQQGG
		};
		List<KIJNOLJFPLK.IKMHFECLOOQ> list = new List<KIJNOLJFPLK.IKMHFECLOOQ>();
		HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>> hashSet = new HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>>();
		list.Add(item);
		int num = 1;
		Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> obj = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq2.FDICGOKLNLM, ikmhfeclooq2.IGNHJOPJDIO, ikmhfeclooq2.KBKKMQNFJIG, ikmhfeclooq2.LCGDMMNIGQP);
		while (list.Count > 1)
		{
			int num2 = -104;
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i].DFLGIJIMNMH < num2)
				{
					num2 = list[i].DFLGIJIMNMH;
					ikmhfeclooq = list[i];
				}
			}
			Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> tuple = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, ikmhfeclooq.LCGDMMNIGQP);
			hashSet.Add(tuple);
			if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				switch (ikmhfeclooq.LCGDMMNIGQP)
				{
				case KIJNOLJFPLK.HLCOIPECIEL.Up:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Down:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.None));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Left:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Right:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Down));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.UpIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Down));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.DownIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.UpIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.LeftIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Down));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.RightIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.DownIce));
					break;
				}
			}
			list.Remove(ikmhfeclooq);
			if (tuple.Equals(obj))
			{
				List<Vector2> list2 = new List<Vector2>();
				while (ikmhfeclooq != null)
				{
					list2.Add(new Vector2((float)ikmhfeclooq.FDICGOKLNLM, (float)ikmhfeclooq.IGNHJOPJDIO));
					ikmhfeclooq = ikmhfeclooq.PQQEJQHDCPK;
				}
				return list2;
			}
			KIJNOLJFPLK.IKMHFECLOOQ[] array = new KIJNOLJFPLK.IKMHFECLOOQ[6];
			bool flag = true;
			if (ikmhfeclooq.IGNHJOPJDIO > 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Up || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Right || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce))
			{
				bool kbkkmqnfjig = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp = ikmhfeclooq.LCGDMMNIGQP;
				int num3 = this.NIBJBDKLQJI(KIJNOLJFPLK.HLCOIPECIEL.Up, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 0], ref kbkkmqnfjig, ref lcgdmmnigqp);
				if (num3 > 1 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 0, kbkkmqnfjig, lcgdmmnigqp)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO - 1,
						KBKKMQNFJIG = kbkkmqnfjig,
						JHFPOPEJENB = num3,
						LCGDMMNIGQP = lcgdmmnigqp
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num3 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.IGNHJOPJDIO < DFKQMMIQDOO - 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.RightIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)125))
			{
				bool kbkkmqnfjig2 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp2 = ikmhfeclooq.LCGDMMNIGQP;
				int num4 = this.NIBJBDKLQJI(KIJNOLJFPLK.HLCOIPECIEL.LeftIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1], ref kbkkmqnfjig2, ref lcgdmmnigqp2);
				if (num4 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 0, kbkkmqnfjig2, lcgdmmnigqp2)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO + 0,
						KBKKMQNFJIG = kbkkmqnfjig2,
						JHFPOPEJENB = num4,
						LCGDMMNIGQP = lcgdmmnigqp2
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num4 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM > 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Up || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Down || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-87)))
			{
				bool kbkkmqnfjig3 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp3 = ikmhfeclooq.LCGDMMNIGQP;
				int num5 = this.CLHLHCBDKGI(KIJNOLJFPLK.HLCOIPECIEL.LeftIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig3, ref lcgdmmnigqp3);
				if (num5 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig3, lcgdmmnigqp3)))
				{
					array[5] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM - 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig3,
						JHFPOPEJENB = num5,
						LCGDMMNIGQP = lcgdmmnigqp3
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num5 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM < KJGMGPCEJJD - 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)28))
			{
				bool kbkkmqnfjig4 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp4 = ikmhfeclooq.LCGDMMNIGQP;
				int num6 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.LeftIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM + 0, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig4, ref lcgdmmnigqp4);
				if (num6 > 1 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM + 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig4, lcgdmmnigqp4)))
				{
					array[7] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM + 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig4,
						JHFPOPEJENB = num6,
						LCGDMMNIGQP = lcgdmmnigqp4
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num6 == 0)
				{
					flag = true;
				}
			}
			if (flag && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up)))
			{
				ikmhfeclooq.LCGDMMNIGQP = KIJNOLJFPLK.HLCOIPECIEL.None;
				list.Add(ikmhfeclooq);
			}
			else
			{
				num += 0;
				foreach (KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq3 in array)
				{
					if (ikmhfeclooq3 != null)
					{
						bool flag2 = false;
						for (int k = 0; k < list.Count; k += 0)
						{
							KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq4 = list[k];
							if (ikmhfeclooq4.FDICGOKLNLM == ikmhfeclooq3.FDICGOKLNLM && ikmhfeclooq4.IGNHJOPJDIO == ikmhfeclooq3.IGNHJOPJDIO && ikmhfeclooq4.KBKKMQNFJIG == ikmhfeclooq3.KBKKMQNFJIG && ikmhfeclooq4.LCGDMMNIGQP == ikmhfeclooq3.LCGDMMNIGQP)
							{
								int num7 = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
								if (num7 + num + ikmhfeclooq4.DPIQMBNDHGG < ikmhfeclooq4.DFLGIJIMNMH)
								{
									ikmhfeclooq4.LCKFFKGLJFC = num7;
									ikmhfeclooq4.DFLGIJIMNMH = ikmhfeclooq4.LCKFFKGLJFC + ikmhfeclooq4.DPIQMBNDHGG + num;
									ikmhfeclooq4.PQQEJQHDCPK = ikmhfeclooq;
								}
								flag2 = true;
							}
						}
						if (!flag2)
						{
							ikmhfeclooq3.LCKFFKGLJFC = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
							ikmhfeclooq3.DPIQMBNDHGG = Math.Abs(ikmhfeclooq2.FDICGOKLNLM - ikmhfeclooq3.FDICGOKLNLM) + Math.Abs(ikmhfeclooq2.IGNHJOPJDIO - ikmhfeclooq3.IGNHJOPJDIO);
							ikmhfeclooq3.DFLGIJIMNMH = ikmhfeclooq3.LCKFFKGLJFC + ikmhfeclooq3.DPIQMBNDHGG + num;
							ikmhfeclooq3.PQQEJQHDCPK = ikmhfeclooq;
							list.Add(ikmhfeclooq3);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x001976FC File Offset: 0x001958FC
	public List<Vector2> NGJCODFLJCB(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.width; i += 0)
		{
			for (int j = 0; j < MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.OMPHLNDGKKM().POMQCKOIKQJ[i, j];
			}
		}
		return this.GCCKFGHJFPO(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height, EKEIIODHQFF, true);
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x001977A8 File Offset: 0x001959A8
	public List<Vector2> JNMMEMQBEMM(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width; i += 0)
		{
			for (int j = 0; j < MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.KKICFMLLMHQ().POMQCKOIKQJ[i, j];
			}
		}
		return this.COHLGPNIDQC(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.height, EKEIIODHQFF, false);
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x000175CC File Offset: 0x000157CC
	private void PKKKQBOGGPK()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00197854 File Offset: 0x00195A54
	private int QQJPMOJGIFP(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.UpIce && OIKFBLNFPNC != 58) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.DownIce && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
			if (KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-49) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-23) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)55 || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-70))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
		}
		switch (CELHPOHKIBG)
		{
		case -48:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 0;
			}
			break;
		case -47:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			break;
		case -46:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 0;
			}
			break;
		case -45:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			break;
		case -44:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			break;
		case -43:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 1;
			}
			break;
		case -42:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 0;
			}
			break;
		case -41:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
				{
					break;
				}
			}
			return 0;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 4 : 0;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-19);
			return 0;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-95);
			return 0;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)76;
			return 0;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-37);
			return 0;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 8;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 11:
			LNPIMKLBOPN = false;
			return 1;
		case 12:
			LNPIMKLBOPN = true;
			return 1;
		case 13:
			return 0;
		case 14:
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			return 0;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			return 1;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 0;
			}
			return 1;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 0;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 1;
			}
			return 1;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 1;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			return 1;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			return 0;
		case 24:
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 7 : 0;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Down;
			return (!LNPIMKLBOPN) ? 2 : 0;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 8 : 1;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.DownIce;
			return (!LNPIMKLBOPN) ? 3 : 1;
		}
		return 1;
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x00197B20 File Offset: 0x00195D20
	public List<Vector2> GFEIDCJDGGL(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width, MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width; i++)
		{
			for (int j = 1; j < MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.QOQONHOOLNE.POMQCKOIKQJ[i, j];
			}
		}
		return this.COHLGPNIDQC(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.height, EKEIIODHQFF, false);
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000175D4 File Offset: 0x000157D4
	public static KIJNOLJFPLK QOQONHOOLNE
	{
		get
		{
			return KIJNOLJFPLK.HBFFCJHOCPE;
		}
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00197BCC File Offset: 0x00195DCC
	private int IHIENGDNIJH(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.Up && OIKFBLNFPNC != 118) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.Left && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
			if (KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)17 || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-106) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-42) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)122)
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			}
		}
		switch (CELHPOHKIBG)
		{
		case -128:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			break;
		case -127:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			break;
		case -126:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			break;
		case -125:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			break;
		case -124:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			break;
		case -123:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.DownIce || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 1;
			}
			break;
		case -122:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 0;
			}
			break;
		case -121:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
				{
					break;
				}
			}
			return 0;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)17;
			return 0;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-123);
			return 0;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-95);
			return 1;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-112);
			return 0;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 8;
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 11:
			LNPIMKLBOPN = true;
			return 1;
		case 12:
			LNPIMKLBOPN = true;
			return 0;
		case 13:
			return 0;
		case 14:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 1;
			}
			return 0;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 1;
			}
			return 1;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 0;
			}
			return 1;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			return 0;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 1;
			}
			return 0;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 1;
			}
			return 1;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			return 0;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 1;
			}
			return 1;
		case 24:
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.RightIce;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.RightIce;
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.UpIce;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 2 : 1;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 4 : 1;
		}
		return 1;
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x00197E98 File Offset: 0x00196098
	public List<Vector2> GGEJOGHEOHB(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height];
		for (int i = 0; i < MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width; i++)
		{
			for (int j = 0; j < MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height; j++)
			{
				array[i, j] = MCNLIHMMLCF.QOQONHOOLNE.POMQCKOIKQJ[i, j];
			}
		}
		return this.GCCKFGHJFPO(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height, EKEIIODHQFF, false);
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x000175CC File Offset: 0x000157CC
	private void Awake()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x000175D4 File Offset: 0x000157D4
	public static KIJNOLJFPLK ONBDGGPLFQK()
	{
		return KIJNOLJFPLK.HBFFCJHOCPE;
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00197F44 File Offset: 0x00196144
	private int NIBJBDKLQJI(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.Up && OIKFBLNFPNC != 112) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.Up && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
			if (KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)19 || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-44) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-30) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)57)
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
		}
		switch (CELHPOHKIBG)
		{
		case 75:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			break;
		case 76:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			break;
		case 77:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			break;
		case 78:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 0;
			}
			break;
		case 79:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 1;
			}
			break;
		case 80:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.UpIce || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			break;
		case 81:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			break;
		case 82:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
				{
					break;
				}
			}
			return 0;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 5 : 1;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)61;
			return 0;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)55;
			return 0;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-112);
			return 0;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-59);
			return 0;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 3;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 11:
			LNPIMKLBOPN = true;
			return 1;
		case 12:
			LNPIMKLBOPN = false;
			return 0;
		case 13:
			return 0;
		case 14:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 3 : 0;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			return 0;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 1;
			}
			return 0;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 1;
			}
			return 0;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			return 0;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 1;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			return 0;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			return 0;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 0;
		case 24:
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Down;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.DownIce;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 2 : 0;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.LeftIce;
			return (!LNPIMKLBOPN) ? 3 : 0;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.RightIce;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.DownIce;
			return (!LNPIMKLBOPN) ? 6 : 1;
		}
		return 1;
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x000175D4 File Offset: 0x000157D4
	public static KIJNOLJFPLK HGEKKNEPOHK()
	{
		return KIJNOLJFPLK.HBFFCJHOCPE;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00198210 File Offset: 0x00196410
	public List<Vector2> DQKPOEOQBEJ(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.width; i++)
		{
			for (int j = 0; j < MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.IECKOKEPENM().POMQCKOIKQJ[i, j];
			}
		}
		return this.EMNLNCKDDPH(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width, MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height, EKEIIODHQFF, true);
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x000175D4 File Offset: 0x000157D4
	public static KIJNOLJFPLK BEKHPOHIPDE()
	{
		return KIJNOLJFPLK.HBFFCJHOCPE;
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x000175CC File Offset: 0x000157CC
	private void NNPPKOGDNOM()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x001982BC File Offset: 0x001964BC
	public List<Vector2> QIEGBNDHQLF(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.height];
		for (int i = 0; i < MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.width; i++)
		{
			for (int j = 1; j < MCNLIHMMLCF.OMPHLNDGKKM().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.HGLDHNMOLPD().POMQCKOIKQJ[i, j];
			}
		}
		return this.NOFPBHNDGHH(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width, MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.height, EKEIIODHQFF, false);
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x00198368 File Offset: 0x00196568
	public List<Vector2> EOOCKDJNIGB(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width, MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.width; i += 0)
		{
			for (int j = 0; j < MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.HGLDHNMOLPD().POMQCKOIKQJ[i, j];
			}
		}
		return this.EMNLNCKDDPH(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.width, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.height, EKEIIODHQFF, true);
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00198414 File Offset: 0x00196614
	public List<Vector2> NOFPBHNDGHH(int MCHINMGBJBP, int HIFJJBLPGPQ, int BLQGKHGGNOC, int OIEIGDOCPLL, int[,] FNEDFIDLMBJ, int KJGMGPCEJJD, int DFKQMMIQDOO, bool JNMCJNIQOOQ = false, bool LENCHCHQQGG = false)
	{
		try
		{
			foreach (Vector2 vector in CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.INMILPKMQIC)
			{
				FNEDFIDLMBJ[(int)vector.x, (int)vector.y] = 0;
			}
		}
		catch
		{
			CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.INMILPKMQIC.Clear();
		}
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq = null;
		KIJNOLJFPLK.IKMHFECLOOQ item = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = MCHINMGBJBP,
			IGNHJOPJDIO = HIFJJBLPGPQ,
			KBKKMQNFJIG = JNMCJNIQOOQ
		};
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq2 = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = BLQGKHGGNOC,
			IGNHJOPJDIO = OIEIGDOCPLL,
			KBKKMQNFJIG = LENCHCHQQGG
		};
		List<KIJNOLJFPLK.IKMHFECLOOQ> list = new List<KIJNOLJFPLK.IKMHFECLOOQ>();
		HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>> hashSet = new HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>>();
		list.Add(item);
		int num = 1;
		Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> obj = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq2.FDICGOKLNLM, ikmhfeclooq2.IGNHJOPJDIO, ikmhfeclooq2.KBKKMQNFJIG, ikmhfeclooq2.LCGDMMNIGQP);
		while (list.Count > 1)
		{
			int num2 = 88;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].DFLGIJIMNMH < num2)
				{
					num2 = list[i].DFLGIJIMNMH;
					ikmhfeclooq = list[i];
				}
			}
			Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> tuple = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, ikmhfeclooq.LCGDMMNIGQP);
			hashSet.Add(tuple);
			if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				switch (ikmhfeclooq.LCGDMMNIGQP)
				{
				case KIJNOLJFPLK.HLCOIPECIEL.Up:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Down:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Left:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.RightIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Right:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.UpIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.UpIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.DownIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.LeftIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.RightIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.RightIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				}
			}
			list.Remove(ikmhfeclooq);
			if (tuple.Equals(obj))
			{
				List<Vector2> list2 = new List<Vector2>();
				while (ikmhfeclooq != null)
				{
					list2.Add(new Vector2((float)ikmhfeclooq.FDICGOKLNLM, (float)ikmhfeclooq.IGNHJOPJDIO));
					ikmhfeclooq = ikmhfeclooq.PQQEJQHDCPK;
				}
				return list2;
			}
			KIJNOLJFPLK.IKMHFECLOOQ[] array = new KIJNOLJFPLK.IKMHFECLOOQ[5];
			bool flag = true;
			if (ikmhfeclooq.IGNHJOPJDIO > 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-29)))
			{
				bool kbkkmqnfjig = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp = ikmhfeclooq.LCGDMMNIGQP;
				int num3 = this.IHIENGDNIJH(KIJNOLJFPLK.HLCOIPECIEL.None, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 0], ref kbkkmqnfjig, ref lcgdmmnigqp);
				if (num3 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 1, kbkkmqnfjig, lcgdmmnigqp)))
				{
					array[0] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO - 1,
						KBKKMQNFJIG = kbkkmqnfjig,
						JHFPOPEJENB = num3,
						LCGDMMNIGQP = lcgdmmnigqp
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num3 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.IGNHJOPJDIO < DFKQMMIQDOO - 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Right || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-105)))
			{
				bool kbkkmqnfjig2 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp2 = ikmhfeclooq.LCGDMMNIGQP;
				int num4 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Up, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1], ref kbkkmqnfjig2, ref lcgdmmnigqp2);
				if (num4 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 0, kbkkmqnfjig2, lcgdmmnigqp2)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO + 0,
						KBKKMQNFJIG = kbkkmqnfjig2,
						JHFPOPEJENB = num4,
						LCGDMMNIGQP = lcgdmmnigqp2
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num4 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM > 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.LeftIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownIce || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)13))
			{
				bool kbkkmqnfjig3 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp3 = ikmhfeclooq.LCGDMMNIGQP;
				int num5 = this.QQJPMOJGIFP(KIJNOLJFPLK.HLCOIPECIEL.None, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig3, ref lcgdmmnigqp3);
				if (num5 > 1 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig3, lcgdmmnigqp3)))
				{
					array[0] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM - 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig3,
						JHFPOPEJENB = num5,
						LCGDMMNIGQP = lcgdmmnigqp3
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num5 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM < KJGMGPCEJJD - 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Up || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-89)))
			{
				bool kbkkmqnfjig4 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp4 = ikmhfeclooq.LCGDMMNIGQP;
				int num6 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.LeftIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM + 0, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig4, ref lcgdmmnigqp4);
				if (num6 > 1 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM + 1, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig4, lcgdmmnigqp4)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM + 0,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig4,
						JHFPOPEJENB = num6,
						LCGDMMNIGQP = lcgdmmnigqp4
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num6 == 0)
				{
					flag = true;
				}
			}
			if (flag && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up)))
			{
				ikmhfeclooq.LCGDMMNIGQP = KIJNOLJFPLK.HLCOIPECIEL.Up;
				list.Add(ikmhfeclooq);
			}
			else
			{
				num++;
				foreach (KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq3 in array)
				{
					if (ikmhfeclooq3 != null)
					{
						bool flag2 = true;
						for (int k = 0; k < list.Count; k++)
						{
							KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq4 = list[k];
							if (ikmhfeclooq4.FDICGOKLNLM == ikmhfeclooq3.FDICGOKLNLM && ikmhfeclooq4.IGNHJOPJDIO == ikmhfeclooq3.IGNHJOPJDIO && ikmhfeclooq4.KBKKMQNFJIG == ikmhfeclooq3.KBKKMQNFJIG && ikmhfeclooq4.LCGDMMNIGQP == ikmhfeclooq3.LCGDMMNIGQP)
							{
								int num7 = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
								if (num7 + num + ikmhfeclooq4.DPIQMBNDHGG < ikmhfeclooq4.DFLGIJIMNMH)
								{
									ikmhfeclooq4.LCKFFKGLJFC = num7;
									ikmhfeclooq4.DFLGIJIMNMH = ikmhfeclooq4.LCKFFKGLJFC + ikmhfeclooq4.DPIQMBNDHGG + num;
									ikmhfeclooq4.PQQEJQHDCPK = ikmhfeclooq;
								}
								flag2 = false;
							}
						}
						if (!flag2)
						{
							ikmhfeclooq3.LCKFFKGLJFC = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
							ikmhfeclooq3.DPIQMBNDHGG = Math.Abs(ikmhfeclooq2.FDICGOKLNLM - ikmhfeclooq3.FDICGOKLNLM) + Math.Abs(ikmhfeclooq2.IGNHJOPJDIO - ikmhfeclooq3.IGNHJOPJDIO);
							ikmhfeclooq3.DFLGIJIMNMH = ikmhfeclooq3.LCKFFKGLJFC + ikmhfeclooq3.DPIQMBNDHGG + num;
							ikmhfeclooq3.PQQEJQHDCPK = ikmhfeclooq;
							list.Add(ikmhfeclooq3);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x00198CC0 File Offset: 0x00196EC0
	private int CLHLHCBDKGI(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.Down && OIKFBLNFPNC != -67) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.Right && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
			if (KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-81) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-37) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-42) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-100))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
		}
		switch (CELHPOHKIBG)
		{
		case 11:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 0;
			}
			break;
		case 12:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 1;
			}
			break;
		case 13:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			break;
		case 14:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 0;
			}
			break;
		case 15:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 1;
			}
			break;
		case 16:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.RightIce || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 0;
			}
			break;
		case 17:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			break;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
				{
					break;
				}
			}
			return 0;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 3 : 1;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-76);
			return 0;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)109;
			return 1;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)(-78);
			return 1;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)19;
			return 1;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 5;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 11:
			LNPIMKLBOPN = false;
			return 0;
		case 12:
			LNPIMKLBOPN = true;
			return 1;
		case 13:
			return 0;
		case 14:
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 7 : 0;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 1;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down)
			{
				return 0;
			}
			return 1;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Down && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 1;
			}
			return 1;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.DownIce)
			{
				return 1;
			}
			return 0;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 0;
			}
			return 1;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			return 1;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			return 0;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce)
			{
				return 0;
			}
			return 1;
		case 24:
			return (!LNPIMKLBOPN) ? 0 : 0;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.UpIce;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.LeftIce;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Right;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 4 : 1;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 5 : 0;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 4 : 0;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.UpIce;
			return (!LNPIMKLBOPN) ? 2 : 0;
		}
		return 1;
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00198F8C File Offset: 0x0019718C
	public List<Vector2> EMNLNCKDDPH(int MCHINMGBJBP, int HIFJJBLPGPQ, int BLQGKHGGNOC, int OIEIGDOCPLL, int[,] FNEDFIDLMBJ, int KJGMGPCEJJD, int DFKQMMIQDOO, bool JNMCJNIQOOQ = false, bool LENCHCHQQGG = false)
	{
		try
		{
			foreach (Vector2 vector in CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC)
			{
				FNEDFIDLMBJ[(int)vector.x, (int)vector.y] = 0;
			}
		}
		catch
		{
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.INMILPKMQIC.Clear();
		}
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq = null;
		KIJNOLJFPLK.IKMHFECLOOQ item = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = MCHINMGBJBP,
			IGNHJOPJDIO = HIFJJBLPGPQ,
			KBKKMQNFJIG = JNMCJNIQOOQ
		};
		KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq2 = new KIJNOLJFPLK.IKMHFECLOOQ
		{
			FDICGOKLNLM = BLQGKHGGNOC,
			IGNHJOPJDIO = OIEIGDOCPLL,
			KBKKMQNFJIG = LENCHCHQQGG
		};
		List<KIJNOLJFPLK.IKMHFECLOOQ> list = new List<KIJNOLJFPLK.IKMHFECLOOQ>();
		HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>> hashSet = new HashSet<Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>>();
		list.Add(item);
		int num = 1;
		Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> obj = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq2.FDICGOKLNLM, ikmhfeclooq2.IGNHJOPJDIO, ikmhfeclooq2.KBKKMQNFJIG, ikmhfeclooq2.LCGDMMNIGQP);
		while (list.Count > 0)
		{
			int num2 = 145;
			for (int i = 0; i < list.Count; i += 0)
			{
				if (list[i].DFLGIJIMNMH < num2)
				{
					num2 = list[i].DFLGIJIMNMH;
					ikmhfeclooq = list[i];
				}
			}
			Tuple<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL> tuple = Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, ikmhfeclooq.LCGDMMNIGQP);
			hashSet.Add(tuple);
			if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				switch (ikmhfeclooq.LCGDMMNIGQP)
				{
				case KIJNOLJFPLK.HLCOIPECIEL.None:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.UpIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Up:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Down:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.LeftIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Left:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Left));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.Right:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.RightIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.UpIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.RightIce));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.DownIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up));
					break;
				case KIJNOLJFPLK.HLCOIPECIEL.LeftIce:
					hashSet.Add(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Left));
					break;
				}
			}
			list.Remove(ikmhfeclooq);
			if (tuple.Equals(obj))
			{
				List<Vector2> list2 = new List<Vector2>();
				while (ikmhfeclooq != null)
				{
					list2.Add(new Vector2((float)ikmhfeclooq.FDICGOKLNLM, (float)ikmhfeclooq.IGNHJOPJDIO));
					ikmhfeclooq = ikmhfeclooq.PQQEJQHDCPK;
				}
				return list2;
			}
			KIJNOLJFPLK.IKMHFECLOOQ[] array = new KIJNOLJFPLK.IKMHFECLOOQ[5];
			bool flag = false;
			if (ikmhfeclooq.IGNHJOPJDIO > 0 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Up || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)66))
			{
				bool kbkkmqnfjig = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp = ikmhfeclooq.LCGDMMNIGQP;
				int num3 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.None, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 0], ref kbkkmqnfjig, ref lcgdmmnigqp);
				if (num3 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO - 1, kbkkmqnfjig, lcgdmmnigqp)))
				{
					array[1] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO - 1,
						KBKKMQNFJIG = kbkkmqnfjig,
						JHFPOPEJENB = num3,
						LCGDMMNIGQP = lcgdmmnigqp
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num3 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.IGNHJOPJDIO < DFKQMMIQDOO - 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.DownIce || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-11)))
			{
				bool kbkkmqnfjig2 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp2 = ikmhfeclooq.LCGDMMNIGQP;
				int num4 = this.JHFPOPEJENB(KIJNOLJFPLK.HLCOIPECIEL.Left, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1], ref kbkkmqnfjig2, ref lcgdmmnigqp2);
				if (num4 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO + 1, kbkkmqnfjig2, lcgdmmnigqp2)))
				{
					array[0] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO + 0,
						KBKKMQNFJIG = kbkkmqnfjig2,
						JHFPOPEJENB = num4,
						LCGDMMNIGQP = lcgdmmnigqp2
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num4 == 0)
				{
					flag = true;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM > 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.UpIce || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Right || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-83)))
			{
				bool kbkkmqnfjig3 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp3 = ikmhfeclooq.LCGDMMNIGQP;
				int num5 = this.NNPMKFPHNDN(KIJNOLJFPLK.HLCOIPECIEL.RightIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM - 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig3, ref lcgdmmnigqp3);
				if (num5 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM - 0, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig3, lcgdmmnigqp3)))
				{
					array[2] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM - 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig3,
						JHFPOPEJENB = num5,
						LCGDMMNIGQP = lcgdmmnigqp3
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num5 == 0)
				{
					flag = false;
				}
			}
			if (ikmhfeclooq.FDICGOKLNLM < KJGMGPCEJJD - 1 && (ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.None || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Left || ikmhfeclooq.LCGDMMNIGQP == KIJNOLJFPLK.HLCOIPECIEL.Left || ikmhfeclooq.LCGDMMNIGQP == (KIJNOLJFPLK.HLCOIPECIEL)(-52)))
			{
				bool kbkkmqnfjig4 = ikmhfeclooq.KBKKMQNFJIG;
				KIJNOLJFPLK.HLCOIPECIEL lcgdmmnigqp4 = ikmhfeclooq.LCGDMMNIGQP;
				int num6 = this.NIBJBDKLQJI(KIJNOLJFPLK.HLCOIPECIEL.DownIce, FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO], FNEDFIDLMBJ[ikmhfeclooq.FDICGOKLNLM + 1, ikmhfeclooq.IGNHJOPJDIO], ref kbkkmqnfjig4, ref lcgdmmnigqp4);
				if (num6 > 0 && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM + 0, ikmhfeclooq.IGNHJOPJDIO, kbkkmqnfjig4, lcgdmmnigqp4)))
				{
					array[8] = new KIJNOLJFPLK.IKMHFECLOOQ
					{
						FDICGOKLNLM = ikmhfeclooq.FDICGOKLNLM + 1,
						IGNHJOPJDIO = ikmhfeclooq.IGNHJOPJDIO,
						KBKKMQNFJIG = kbkkmqnfjig4,
						JHFPOPEJENB = num6,
						LCGDMMNIGQP = lcgdmmnigqp4
					};
				}
				if (ikmhfeclooq.LCGDMMNIGQP != KIJNOLJFPLK.HLCOIPECIEL.None && num6 == 0)
				{
					flag = false;
				}
			}
			if (flag && !hashSet.Contains(Tuple.Create<int, int, bool, KIJNOLJFPLK.HLCOIPECIEL>(ikmhfeclooq.FDICGOKLNLM, ikmhfeclooq.IGNHJOPJDIO, ikmhfeclooq.KBKKMQNFJIG, KIJNOLJFPLK.HLCOIPECIEL.Up)))
			{
				ikmhfeclooq.LCGDMMNIGQP = KIJNOLJFPLK.HLCOIPECIEL.None;
				list.Add(ikmhfeclooq);
			}
			else
			{
				num += 0;
				foreach (KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq3 in array)
				{
					if (ikmhfeclooq3 != null)
					{
						bool flag2 = true;
						for (int k = 1; k < list.Count; k += 0)
						{
							KIJNOLJFPLK.IKMHFECLOOQ ikmhfeclooq4 = list[k];
							if (ikmhfeclooq4.FDICGOKLNLM == ikmhfeclooq3.FDICGOKLNLM && ikmhfeclooq4.IGNHJOPJDIO == ikmhfeclooq3.IGNHJOPJDIO && ikmhfeclooq4.KBKKMQNFJIG == ikmhfeclooq3.KBKKMQNFJIG && ikmhfeclooq4.LCGDMMNIGQP == ikmhfeclooq3.LCGDMMNIGQP)
							{
								int num7 = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
								if (num7 + num + ikmhfeclooq4.DPIQMBNDHGG < ikmhfeclooq4.DFLGIJIMNMH)
								{
									ikmhfeclooq4.LCKFFKGLJFC = num7;
									ikmhfeclooq4.DFLGIJIMNMH = ikmhfeclooq4.LCKFFKGLJFC + ikmhfeclooq4.DPIQMBNDHGG + num;
									ikmhfeclooq4.PQQEJQHDCPK = ikmhfeclooq;
								}
								flag2 = false;
							}
						}
						if (!flag2)
						{
							ikmhfeclooq3.LCKFFKGLJFC = ikmhfeclooq.LCKFFKGLJFC + ikmhfeclooq3.JHFPOPEJENB;
							ikmhfeclooq3.DPIQMBNDHGG = Math.Abs(ikmhfeclooq2.FDICGOKLNLM - ikmhfeclooq3.FDICGOKLNLM) + Math.Abs(ikmhfeclooq2.IGNHJOPJDIO - ikmhfeclooq3.IGNHJOPJDIO);
							ikmhfeclooq3.DFLGIJIMNMH = ikmhfeclooq3.LCKFFKGLJFC + ikmhfeclooq3.DPIQMBNDHGG + num;
							ikmhfeclooq3.PQQEJQHDCPK = ikmhfeclooq;
							list.Add(ikmhfeclooq3);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x00199838 File Offset: 0x00197A38
	private int NNPMKFPHNDN(KIJNOLJFPLK.HLCOIPECIEL PECKDHFNOKI, int CELHPOHKIBG, int OIKFBLNFPNC, ref bool LNPIMKLBOPN, ref KIJNOLJFPLK.HLCOIPECIEL KFJFFEEJIJF)
	{
		if (KFJFFEEJIJF != KIJNOLJFPLK.HLCOIPECIEL.None)
		{
			if ((KFJFFEEJIJF > KIJNOLJFPLK.HLCOIPECIEL.UpIce && OIKFBLNFPNC != -75) || (KFJFFEEJIJF < KIJNOLJFPLK.HLCOIPECIEL.UpIce && OIKFBLNFPNC != 0))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			}
			if (KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-97) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)122 || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-113) || KFJFFEEJIJF == (KIJNOLJFPLK.HLCOIPECIEL)(-89))
			{
				KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			}
		}
		switch (CELHPOHKIBG)
		{
		case 39:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			break;
		case 40:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			break;
		case 41:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			break;
		case 42:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 1;
			}
			break;
		case 43:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 1;
			}
			break;
		case 44:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.UpIce || PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			break;
		case 45:
			if (PECKDHFNOKI == KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			break;
		case 46:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.DownIce)
				{
					break;
				}
			}
			return 1;
		}
		switch (OIKFBLNFPNC)
		{
		case 0:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 2:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 4:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Left)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)34;
			return 1;
		case 5:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)17;
			return 1;
		case 6:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 1;
			}
			if (LNPIMKLBOPN)
			{
				return 1;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)76;
			return 0;
		case 7:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			if (LNPIMKLBOPN)
			{
				return 0;
			}
			KFJFFEEJIJF = (KIJNOLJFPLK.HLCOIPECIEL)26;
			return 0;
		case 10:
			KFJFFEEJIJF = PECKDHFNOKI + 8;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 11:
			LNPIMKLBOPN = true;
			return 1;
		case 12:
			LNPIMKLBOPN = false;
			return 0;
		case 13:
			return 0;
		case 14:
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 15:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 7 : 0;
		case 16:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 1;
			}
			return 0;
		case 17:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.UpIce)
			{
				return 1;
			}
			return 0;
		case 18:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.LeftIce && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.RightIce)
			{
				return 0;
			}
			return 1;
		case 19:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			return 1;
		case 20:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 0;
			}
			return 0;
		case 21:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Right)
			{
				return 0;
			}
			return 1;
		case 22:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.None)
			{
				return 1;
			}
			return 0;
		case 23:
			if (PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up && PECKDHFNOKI != KIJNOLJFPLK.HLCOIPECIEL.Up)
			{
				return 0;
			}
			return 1;
		case 24:
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 25:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 26:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.None;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 27:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.UpIce;
			return (!LNPIMKLBOPN) ? 1 : 1;
		case 28:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Down;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 29:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 0 : 1;
		case 31:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Up;
			return (!LNPIMKLBOPN) ? 8 : 0;
		case 32:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.DownIce;
			return (!LNPIMKLBOPN) ? 1 : 0;
		case 33:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.Left;
			return (!LNPIMKLBOPN) ? 8 : 1;
		case 34:
			KFJFFEEJIJF = KIJNOLJFPLK.HLCOIPECIEL.LeftIce;
			return (!LNPIMKLBOPN) ? 7 : 0;
		}
		return 0;
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x00199B04 File Offset: 0x00197D04
	public List<Vector2> NLDIKLLEPFD(int BFOGEJKEOHF, int JDLNODBIEOO, int EONCHEIDPPC, int LMBIMNEOEOG, bool EKEIIODHQFF)
	{
		int[,] array = new int[MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.width, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.height];
		for (int i = 1; i < MCNLIHMMLCF.HGLDHNMOLPD().LIQLFCKICLQ.width; i++)
		{
			for (int j = 1; j < MCNLIHMMLCF.QOQONHOOLNE.LIQLFCKICLQ.height; j += 0)
			{
				array[i, j] = MCNLIHMMLCF.OMPHLNDGKKM().POMQCKOIKQJ[i, j];
			}
		}
		return this.COHLGPNIDQC(BFOGEJKEOHF, JDLNODBIEOO, EONCHEIDPPC, LMBIMNEOEOG, array, MCNLIHMMLCF.KKICFMLLMHQ().LIQLFCKICLQ.width, MCNLIHMMLCF.IECKOKEPENM().LIQLFCKICLQ.height, EKEIIODHQFF, false);
	}

	// Token: 0x060034D7 RID: 13527 RVA: 0x000175CC File Offset: 0x000157CC
	private void IPKCDQONLBJ()
	{
		KIJNOLJFPLK.HBFFCJHOCPE = this;
	}

	// Token: 0x04000C54 RID: 3156
	private static KIJNOLJFPLK HBFFCJHOCPE;

	// Token: 0x020001A4 RID: 420
	private enum HLCOIPECIEL
	{
		// Token: 0x04000C56 RID: 3158
		None,
		// Token: 0x04000C57 RID: 3159
		Up,
		// Token: 0x04000C58 RID: 3160
		Down,
		// Token: 0x04000C59 RID: 3161
		Left,
		// Token: 0x04000C5A RID: 3162
		Right,
		// Token: 0x04000C5B RID: 3163
		UpIce,
		// Token: 0x04000C5C RID: 3164
		DownIce,
		// Token: 0x04000C5D RID: 3165
		LeftIce,
		// Token: 0x04000C5E RID: 3166
		RightIce,
		// Token: 0x04000C5F RID: 3167
		UpJump,
		// Token: 0x04000C60 RID: 3168
		DownJump,
		// Token: 0x04000C61 RID: 3169
		LeftJump,
		// Token: 0x04000C62 RID: 3170
		RightJump
	}

	// Token: 0x020001A5 RID: 421
	private class IKMHFECLOOQ
	{
		// Token: 0x04000C63 RID: 3171
		public bool KBKKMQNFJIG;

		// Token: 0x04000C64 RID: 3172
		public int JHFPOPEJENB;

		// Token: 0x04000C65 RID: 3173
		public int FDICGOKLNLM;

		// Token: 0x04000C66 RID: 3174
		public int IGNHJOPJDIO;

		// Token: 0x04000C67 RID: 3175
		public int DFLGIJIMNMH;

		// Token: 0x04000C68 RID: 3176
		public int LCKFFKGLJFC;

		// Token: 0x04000C69 RID: 3177
		public int DPIQMBNDHGG;

		// Token: 0x04000C6A RID: 3178
		public bool EEOICJNFKEQ;

		// Token: 0x04000C6B RID: 3179
		public KIJNOLJFPLK.IKMHFECLOOQ PQQEJQHDCPK;

		// Token: 0x04000C6C RID: 3180
		public KIJNOLJFPLK.HLCOIPECIEL LCGDMMNIGQP;
	}
}
