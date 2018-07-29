using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Token: 0x020000A4 RID: 164
public static class JGDHIPBGCFP
{
	// Token: 0x06001592 RID: 5522 RVA: 0x0000B544 File Offset: 0x00009744
	public static void IBQCMOEQPGF()
	{
		JGDHIPBGCFP.IBQCMOEQPGF(true);
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x0009AFD0 File Offset: 0x000991D0
	public static void IBQCMOEQPGF(bool FIHNCCGQNMK)
	{
		if (!JGDHIPBGCFP.LPEGECBMQKQ && MDBOHBDKMMM.QOQONHOOLNE)
		{
			JGDHIPBGCFP.LPEGECBMQKQ = MDBOHBDKMMM.QOQONHOOLNE;
		}
		JGDHIPBGCFP.FIDDHHCOCCD = Mathf.RoundToInt((float)JGDHIPBGCFP.HQLMJHHPHQL / JGDHIPBGCFP.OOBHQPCDCPD);
		JGDHIPBGCFP.KPKBDNNKNGB = JGDHIPBGCFP.MOQHNNIINFL * JGDHIPBGCFP.CNLNKDBIMDB;
		JGDHIPBGCFP.HHDHKPIMKNQ = ((float)JGDHIPBGCFP.HQLMJHHPHQL + JGDHIPBGCFP.MNNBBPGPNJF) * JGDHIPBGCFP.CNLNKDBIMDB;
		JGDHIPBGCFP.OPBBHFJNIPG = ((JGDHIPBGCFP.KDDNGBFFFJL != null || JGDHIPBGCFP.NFIBPOJMOCQ != null) && JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.FJPNBPJQODQ != JGDHIPBGCFP.OQGGLOQFNPE.None);
		Font kddngbfffjl = JGDHIPBGCFP.KDDNGBFFFJL;
		if (kddngbfffjl != null && FIHNCCGQNMK)
		{
			kddngbfffjl.RequestCharactersInTexture(")_-", JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE);
			if (!kddngbfffjl.GetCharacterInfo(')', out JGDHIPBGCFP.PQHKNKENHHK, JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE) || (float)JGDHIPBGCFP.PQHKNKENHHK.maxY == 0f)
			{
				kddngbfffjl.RequestCharactersInTexture("A", JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE);
				if (!kddngbfffjl.GetCharacterInfo('A', out JGDHIPBGCFP.PQHKNKENHHK, JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE))
				{
					JGDHIPBGCFP.EELNNICDOIM = 0f;
					return;
				}
			}
			float num = (float)JGDHIPBGCFP.PQHKNKENHHK.maxY;
			float num2 = (float)JGDHIPBGCFP.PQHKNKENHHK.minY;
			JGDHIPBGCFP.EELNNICDOIM = Mathf.Round(num + ((float)JGDHIPBGCFP.FIDDHHCOCCD - num + num2) * 0.5f);
		}
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0000B54C File Offset: 0x0000974C
	public static void DFLOLMMCGID(string PIDLOFMIEFQ)
	{
		if (JGDHIPBGCFP.KDDNGBFFFJL != null)
		{
			JGDHIPBGCFP.KDDNGBFFFJL.RequestCharactersInTexture(PIDLOFMIEFQ, JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE);
		}
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x0000B570 File Offset: 0x00009770
	public static BMSymbol CHLPMCCFDPP(string PIDLOFMIEFQ, int IIHDGMLHICI, int JBPDNFNEEKP)
	{
		return (!(JGDHIPBGCFP.NFIBPOJMOCQ != null)) ? null : JGDHIPBGCFP.NFIBPOJMOCQ.FHCLPQMLEIP(PIDLOFMIEFQ, IIHDGMLHICI, JBPDNFNEEKP);
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x0009B138 File Offset: 0x00099338
	public static float QFDNOHJLEBO(int BFBMOIKCELJ, int EMPHIIOPNHG)
	{
		if (JGDHIPBGCFP.NFIBPOJMOCQ != null)
		{
			bool flag = false;
			if (BFBMOIKCELJ == 8201)
			{
				flag = true;
				BFBMOIKCELJ = 32;
			}
			BMGlyph bmglyph = JGDHIPBGCFP.NFIBPOJMOCQ.ICJBMNQMGGD.GMFDPCIHHHM(BFBMOIKCELJ);
			if (bmglyph != null)
			{
				int num = bmglyph.advance;
				if (flag)
				{
					num >>= 1;
				}
				return JGDHIPBGCFP.CNLNKDBIMDB * (float)((EMPHIIOPNHG == 0) ? bmglyph.advance : (num + bmglyph.OQNPPHQECJO(EMPHIIOPNHG)));
			}
		}
		else if (JGDHIPBGCFP.KDDNGBFFFJL != null && JGDHIPBGCFP.KDDNGBFFFJL.GetCharacterInfo((char)BFBMOIKCELJ, out JGDHIPBGCFP.PQHKNKENHHK, JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE))
		{
			return (float)JGDHIPBGCFP.PQHKNKENHHK.advance * JGDHIPBGCFP.CNLNKDBIMDB * JGDHIPBGCFP.OOBHQPCDCPD;
		}
		return 0f;
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x0009B1E8 File Offset: 0x000993E8
	public static JGDHIPBGCFP.OHCGMLEQEOI GMFDPCIHHHM(int BFBMOIKCELJ, int EMPHIIOPNHG)
	{
		if (JGDHIPBGCFP.NFIBPOJMOCQ != null)
		{
			bool flag = false;
			if (BFBMOIKCELJ == 8201)
			{
				flag = true;
				BFBMOIKCELJ = 32;
			}
			BMGlyph bmglyph = JGDHIPBGCFP.NFIBPOJMOCQ.ICJBMNQMGGD.GMFDPCIHHHM(BFBMOIKCELJ);
			if (bmglyph != null)
			{
				int num = (EMPHIIOPNHG == 0) ? 0 : bmglyph.OQNPPHQECJO(EMPHIIOPNHG);
				JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.x = (float)((EMPHIIOPNHG == 0) ? bmglyph.offsetX : (bmglyph.offsetX + num));
				JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.y = (float)(-(float)bmglyph.offsetY);
				JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.x = JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.x + (float)bmglyph.width;
				JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.y = JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.y - (float)bmglyph.height;
				JGDHIPBGCFP.HCEKGHFEQQQ.BHGJLHQBEKQ.x = (float)bmglyph.x;
				JGDHIPBGCFP.HCEKGHFEQQQ.BHGJLHQBEKQ.y = (float)(bmglyph.y + bmglyph.height);
				JGDHIPBGCFP.HCEKGHFEQQQ.EFFPLIOQGCE.x = (float)(bmglyph.x + bmglyph.width);
				JGDHIPBGCFP.HCEKGHFEQQQ.EFFPLIOQGCE.y = (float)bmglyph.y;
				JGDHIPBGCFP.HCEKGHFEQQQ.OCHQODGHQCQ.x = JGDHIPBGCFP.HCEKGHFEQQQ.BHGJLHQBEKQ.x;
				JGDHIPBGCFP.HCEKGHFEQQQ.OCHQODGHQCQ.y = JGDHIPBGCFP.HCEKGHFEQQQ.EFFPLIOQGCE.y;
				JGDHIPBGCFP.HCEKGHFEQQQ.HNJHCBLKDHK.x = JGDHIPBGCFP.HCEKGHFEQQQ.EFFPLIOQGCE.x;
				JGDHIPBGCFP.HCEKGHFEQQQ.HNJHCBLKDHK.y = JGDHIPBGCFP.HCEKGHFEQQQ.BHGJLHQBEKQ.y;
				int num2 = bmglyph.advance;
				if (flag)
				{
					num2 >>= 1;
				}
				JGDHIPBGCFP.HCEKGHFEQQQ.BNEBCKEPNNM = (float)(num2 + num);
				JGDHIPBGCFP.HCEKGHFEQQQ.NHNMIFPINDL = bmglyph.channel;
				if (JGDHIPBGCFP.CNLNKDBIMDB != 1f)
				{
					JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH *= JGDHIPBGCFP.CNLNKDBIMDB;
					JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD *= JGDHIPBGCFP.CNLNKDBIMDB;
					JGDHIPBGCFP.HCEKGHFEQQQ.BNEBCKEPNNM *= JGDHIPBGCFP.CNLNKDBIMDB;
				}
				return JGDHIPBGCFP.HCEKGHFEQQQ;
			}
		}
		else if (JGDHIPBGCFP.KDDNGBFFFJL != null && JGDHIPBGCFP.KDDNGBFFFJL.GetCharacterInfo((char)BFBMOIKCELJ, out JGDHIPBGCFP.PQHKNKENHHK, JGDHIPBGCFP.FIDDHHCOCCD, JGDHIPBGCFP.GOIMOQJFMHE))
		{
			JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.x = (float)JGDHIPBGCFP.PQHKNKENHHK.minX;
			JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.x = (float)JGDHIPBGCFP.PQHKNKENHHK.maxX;
			JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.y = (float)JGDHIPBGCFP.PQHKNKENHHK.maxY - JGDHIPBGCFP.EELNNICDOIM;
			JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.y = (float)JGDHIPBGCFP.PQHKNKENHHK.minY - JGDHIPBGCFP.EELNNICDOIM;
			JGDHIPBGCFP.HCEKGHFEQQQ.BHGJLHQBEKQ = JGDHIPBGCFP.PQHKNKENHHK.uvTopLeft;
			JGDHIPBGCFP.HCEKGHFEQQQ.OCHQODGHQCQ = JGDHIPBGCFP.PQHKNKENHHK.uvBottomLeft;
			JGDHIPBGCFP.HCEKGHFEQQQ.EFFPLIOQGCE = JGDHIPBGCFP.PQHKNKENHHK.uvBottomRight;
			JGDHIPBGCFP.HCEKGHFEQQQ.HNJHCBLKDHK = JGDHIPBGCFP.PQHKNKENHHK.uvTopRight;
			JGDHIPBGCFP.HCEKGHFEQQQ.BNEBCKEPNNM = (float)JGDHIPBGCFP.PQHKNKENHHK.advance;
			JGDHIPBGCFP.HCEKGHFEQQQ.NHNMIFPINDL = 0;
			JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.x = Mathf.Round(JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.x);
			JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.y = Mathf.Round(JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH.y);
			JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.x = Mathf.Round(JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.x);
			JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.y = Mathf.Round(JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD.y);
			float num3 = JGDHIPBGCFP.CNLNKDBIMDB * JGDHIPBGCFP.OOBHQPCDCPD;
			if (num3 != 1f)
			{
				JGDHIPBGCFP.HCEKGHFEQQQ.OGBMILEIPHH *= num3;
				JGDHIPBGCFP.HCEKGHFEQQQ.EHCJCFGFJBD *= num3;
				JGDHIPBGCFP.HCEKGHFEQQQ.BNEBCKEPNNM *= num3;
			}
			return JGDHIPBGCFP.HCEKGHFEQQQ;
		}
		return null;
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x0009B624 File Offset: 0x00099824
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float EQBHKOOGGNQ(string PIDLOFMIEFQ, int IIHDGMLHICI)
	{
		int num = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[IIHDGMLHICI + 1]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[IIHDGMLHICI + 2]);
		return Mathf.Clamp01((float)num / 255f);
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x0000B58F File Offset: 0x0000978F
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color GEBCEQHNMPC(string PIDLOFMIEFQ, int LCMMCNFNHMF = 0)
	{
		return JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, LCMMCNFNHMF);
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0009B660 File Offset: 0x00099860
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color GCDNDBDFQMJ(string PIDLOFMIEFQ, int LCMMCNFNHMF = 0)
	{
		int num = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 1]);
		int num2 = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 2]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 3]);
		int num3 = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 4]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 5]);
		float num4 = 0.003921569f;
		return new Color(num4 * (float)num, num4 * (float)num2, num4 * (float)num3);
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0009B6E4 File Offset: 0x000998E4
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color NOFNFJICOLE(string PIDLOFMIEFQ, int LCMMCNFNHMF)
	{
		int num = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 1]);
		int num2 = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 2]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 3]);
		int num3 = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 4]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 5]);
		int num4 = JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 6]) << 4 | JNNGOIIKENH.FGFGLNBGBPB(PIDLOFMIEFQ[LCMMCNFNHMF + 7]);
		float num5 = 0.003921569f;
		return new Color(num5 * (float)num, num5 * (float)num2, num5 * (float)num3, num5 * (float)num4);
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0000B598 File Offset: 0x00009798
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string JPHIJCIGHPQ(Color KQFEHQEBJQB)
	{
		return JGDHIPBGCFP.PHICOHINGQE(KQFEHQEBJQB);
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x0000B5A0 File Offset: 0x000097A0
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string JPHIJCIGHPQ(string PIDLOFMIEFQ, Color KQFEHQEBJQB)
	{
		return string.Concat(new string[]
		{
			"[c][",
			JGDHIPBGCFP.PHICOHINGQE(KQFEHQEBJQB),
			"]",
			PIDLOFMIEFQ,
			"[-][/c]"
		});
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0009B790 File Offset: 0x00099990
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string KDDKFIDOGDE(float ECHMFPQNBMC)
	{
		int pkckifdbohf = Mathf.Clamp(Mathf.RoundToInt(ECHMFPQNBMC * 255f), 0, 255);
		return JNNGOIIKENH.PBPNFGLLLMF(pkckifdbohf);
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0009B7BC File Offset: 0x000999BC
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string PHICOHINGQE(Color KQFEHQEBJQB)
	{
		int pkckifdbohf = 16777215 & JNNGOIIKENH.HIHEBGODQPI(KQFEHQEBJQB) >> 8;
		return JNNGOIIKENH.FNGPCLGJDOL(pkckifdbohf);
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0009B7E0 File Offset: 0x000999E0
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string CQNLDGIIOEM(Color KQFEHQEBJQB)
	{
		int pkckifdbohf = JNNGOIIKENH.HIHEBGODQPI(KQFEHQEBJQB);
		return JNNGOIIKENH.DNPBDQJDOBQ(pkckifdbohf);
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x0009B7FC File Offset: 0x000999FC
	public static bool HPJPOIOHCFQ(string PIDLOFMIEFQ, ref int IIHDGMLHICI)
	{
		int num = 1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		return JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref IIHDGMLHICI, null, false, ref num, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6);
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0000B5D2 File Offset: 0x000097D2
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool OLPEQJFMEOE(char BFBMOIKCELJ)
	{
		return (BFBMOIKCELJ >= '0' && BFBMOIKCELJ <= '9') || (BFBMOIKCELJ >= 'a' && BFBMOIKCELJ <= 'f') || (BFBMOIKCELJ >= 'A' && BFBMOIKCELJ <= 'F');
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0009B834 File Offset: 0x00099A34
	public static bool HPJPOIOHCFQ(string PIDLOFMIEFQ, ref int IIHDGMLHICI, MHIDKMCBQEN<Color> BBCJFBHDJFP, bool NFLEOLEGPJJ, ref int HCQKHIFPLMM, ref bool LOOFIJPOQDQ, ref bool NNKFHQEOCON, ref bool GMLDEJLBICQ, ref bool QOJNLBNGKGJ, ref bool HOKNBQECEPH, ref bool DJBEDEQNEEN)
	{
		int length = PIDLOFMIEFQ.Length;
		if (IIHDGMLHICI + 3 <= length)
		{
			if (PIDLOFMIEFQ[IIHDGMLHICI] == '[')
			{
				if (PIDLOFMIEFQ[IIHDGMLHICI + 2] == ']')
				{
					if (PIDLOFMIEFQ[IIHDGMLHICI + 1] == '-')
					{
						if (BBCJFBHDJFP != null && BBCJFBHDJFP.BJGMIBBEGDQ > 1)
						{
							BBCJFBHDJFP.IBGPNNLOENC(BBCJFBHDJFP.BJGMIBBEGDQ - 1);
						}
						IIHDGMLHICI += 3;
						return true;
					}
					string text = PIDLOFMIEFQ.Substring(IIHDGMLHICI, 3);
					switch (text)
					{
					case "[b]":
					case "[B]":
						LOOFIJPOQDQ = true;
						IIHDGMLHICI += 3;
						return true;
					case "[i]":
					case "[I]":
						NNKFHQEOCON = true;
						IIHDGMLHICI += 3;
						return true;
					case "[u]":
					case "[U]":
						GMLDEJLBICQ = true;
						IIHDGMLHICI += 3;
						return true;
					case "[s]":
					case "[S]":
						QOJNLBNGKGJ = true;
						IIHDGMLHICI += 3;
						return true;
					case "[c]":
					case "[C]":
						HOKNBQECEPH = true;
						IIHDGMLHICI += 3;
						return true;
					case "[o]":
					case "[O]":
						DJBEDEQNEEN = true;
						IIHDGMLHICI += 3;
						return true;
					}
				}
				if (IIHDGMLHICI + 4 > length)
				{
					return false;
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 3] == ']')
				{
					string text2 = PIDLOFMIEFQ.Substring(IIHDGMLHICI, 4);
					switch (text2)
					{
					case "[/b]":
					case "[/B]":
						LOOFIJPOQDQ = false;
						IIHDGMLHICI += 4;
						return true;
					case "[/i]":
					case "[/I]":
						NNKFHQEOCON = false;
						IIHDGMLHICI += 4;
						return true;
					case "[/u]":
					case "[/U]":
						GMLDEJLBICQ = false;
						IIHDGMLHICI += 4;
						return true;
					case "[/s]":
					case "[/S]":
						QOJNLBNGKGJ = false;
						IIHDGMLHICI += 4;
						return true;
					case "[/c]":
					case "[/C]":
						HOKNBQECEPH = false;
						IIHDGMLHICI += 4;
						return true;
					case "[/o]":
					case "[/O]":
						DJBEDEQNEEN = false;
						IIHDGMLHICI += 4;
						return true;
					}
					char bfbmoikcelj = PIDLOFMIEFQ[IIHDGMLHICI + 1];
					char bfbmoikcelj2 = PIDLOFMIEFQ[IIHDGMLHICI + 2];
					if (JGDHIPBGCFP.OLPEQJFMEOE(bfbmoikcelj) && JGDHIPBGCFP.OLPEQJFMEOE(bfbmoikcelj2))
					{
						int num2 = JNNGOIIKENH.FGFGLNBGBPB(bfbmoikcelj) << 4 | JNNGOIIKENH.FGFGLNBGBPB(bfbmoikcelj2);
						JGDHIPBGCFP.KELMMNHOKKB = (float)num2 / 255f;
						IIHDGMLHICI += 4;
						return true;
					}
				}
				if (IIHDGMLHICI + 5 > length)
				{
					return false;
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 4] == ']')
				{
					string text3 = PIDLOFMIEFQ.Substring(IIHDGMLHICI, 5);
					if (text3 != null)
					{
						if (text3 == "[sub]" || text3 == "[SUB]")
						{
							HCQKHIFPLMM = 1;
							IIHDGMLHICI += 5;
							return true;
						}
						if (text3 == "[sup]" || text3 == "[SUP]")
						{
							HCQKHIFPLMM = 2;
							IIHDGMLHICI += 5;
							return true;
						}
					}
				}
				if (IIHDGMLHICI + 6 > length)
				{
					return false;
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == ']')
				{
					string text4 = PIDLOFMIEFQ.Substring(IIHDGMLHICI, 6);
					switch (text4)
					{
					case "[/sub]":
					case "[/SUB]":
						HCQKHIFPLMM = 0;
						IIHDGMLHICI += 6;
						return true;
					case "[/sup]":
					case "[/SUP]":
						HCQKHIFPLMM = 0;
						IIHDGMLHICI += 6;
						return true;
					case "[/url]":
					case "[/URL]":
						IIHDGMLHICI += 6;
						return true;
					case "[/urn]":
					case "[/URN]":
						IIHDGMLHICI += 6;
						return true;
					}
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 1] == 'u' && PIDLOFMIEFQ[IIHDGMLHICI + 2] == 'r' && PIDLOFMIEFQ[IIHDGMLHICI + 3] == 'n' && PIDLOFMIEFQ[IIHDGMLHICI + 4] == '=')
				{
					int num3 = PIDLOFMIEFQ.IndexOf(']', IIHDGMLHICI + 4);
					if (num3 != -1)
					{
						IIHDGMLHICI = num3 + 1;
						return true;
					}
					IIHDGMLHICI = PIDLOFMIEFQ.Length;
					return true;
				}
				else if (PIDLOFMIEFQ[IIHDGMLHICI + 1] == 'u' && PIDLOFMIEFQ[IIHDGMLHICI + 2] == 'r' && PIDLOFMIEFQ[IIHDGMLHICI + 3] == 'l' && PIDLOFMIEFQ[IIHDGMLHICI + 4] == '=')
				{
					int num4 = PIDLOFMIEFQ.IndexOf(']', IIHDGMLHICI + 4);
					if (num4 != -1)
					{
						IIHDGMLHICI = num4 + 1;
						return true;
					}
					IIHDGMLHICI = PIDLOFMIEFQ.Length;
					return true;
				}
				else
				{
					if (IIHDGMLHICI + 8 > length)
					{
						return false;
					}
					if (PIDLOFMIEFQ[IIHDGMLHICI + 7] == ']')
					{
						Color color = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, IIHDGMLHICI + 1);
						if (JGDHIPBGCFP.PHICOHINGQE(color) != PIDLOFMIEFQ.Substring(IIHDGMLHICI + 1, 6).ToUpper())
						{
							return false;
						}
						if (BBCJFBHDJFP != null)
						{
							color.a = BBCJFBHDJFP.get_KNPPMKBOGDL(BBCJFBHDJFP.BJGMIBBEGDQ - 1).a;
							if (NFLEOLEGPJJ && color.a != 1f)
							{
								color = Color.Lerp(JGDHIPBGCFP.FCFJNDNJCPP, color, color.a);
							}
							BBCJFBHDJFP.LHQECHHMOGD(color);
						}
						IIHDGMLHICI += 8;
						return true;
					}
					else
					{
						if (IIHDGMLHICI + 10 > length)
						{
							return false;
						}
						if (PIDLOFMIEFQ[IIHDGMLHICI + 9] != ']')
						{
							return false;
						}
						Color color2 = JGDHIPBGCFP.NOFNFJICOLE(PIDLOFMIEFQ, IIHDGMLHICI + 1);
						if (JGDHIPBGCFP.CQNLDGIIOEM(color2) != PIDLOFMIEFQ.Substring(IIHDGMLHICI + 1, 8).ToUpper())
						{
							return false;
						}
						if (BBCJFBHDJFP != null)
						{
							if (NFLEOLEGPJJ && color2.a != 1f)
							{
								color2 = Color.Lerp(JGDHIPBGCFP.FCFJNDNJCPP, color2, color2.a);
							}
							BBCJFBHDJFP.LHQECHHMOGD(color2);
						}
						IIHDGMLHICI += 10;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0009BEB8 File Offset: 0x0009A0B8
	public static bool JMNPJNODKLH(string PIDLOFMIEFQ, ref int IIHDGMLHICI)
	{
		int num = 1;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		return JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref IIHDGMLHICI, null, false, ref num, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6);
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0009BEF0 File Offset: 0x0009A0F0
	public static bool JMNPJNODKLH(string PIDLOFMIEFQ, ref int IIHDGMLHICI, MHIDKMCBQEN<Color> BBCJFBHDJFP, bool NFLEOLEGPJJ, ref int HCQKHIFPLMM, ref bool LOOFIJPOQDQ, ref bool NNKFHQEOCON, ref bool GMLDEJLBICQ, ref bool QOJNLBNGKGJ, ref bool HOKNBQECEPH, ref bool DJBEDEQNEEN)
	{
		int length = PIDLOFMIEFQ.Length;
		if (IIHDGMLHICI + 3 <= length)
		{
			if (PIDLOFMIEFQ[IIHDGMLHICI] == '[')
			{
				if (IIHDGMLHICI + 6 > length)
				{
					return false;
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == ']')
				{
					string text = PIDLOFMIEFQ.Substring(IIHDGMLHICI, 6);
					if (text != null)
					{
						if (text == "[/pok]")
						{
							if (BBCJFBHDJFP != null && BBCJFBHDJFP.BJGMIBBEGDQ > 1)
							{
								BBCJFBHDJFP.IBGPNNLOENC(BBCJFBHDJFP.BJGMIBBEGDQ - 1);
							}
							IIHDGMLHICI += 6;
							return true;
						}
						if (text == "[/itm]")
						{
							if (BBCJFBHDJFP != null && BBCJFBHDJFP.BJGMIBBEGDQ > 1)
							{
								BBCJFBHDJFP.IBGPNNLOENC(BBCJFBHDJFP.BJGMIBBEGDQ - 1);
							}
							IIHDGMLHICI += 6;
							return true;
						}
					}
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 1] == 'p' && PIDLOFMIEFQ[IIHDGMLHICI + 2] == 'o' && PIDLOFMIEFQ[IIHDGMLHICI + 3] == 'k' && PIDLOFMIEFQ[IIHDGMLHICI + 4] == '=')
				{
					int num = PIDLOFMIEFQ.IndexOf(']', IIHDGMLHICI + 4);
					int num2 = 0;
					if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '1')
					{
						num2 = 1;
					}
					else if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '2')
					{
						num2 = 2;
					}
					else if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '3')
					{
						num2 = 3;
					}
					else if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '4')
					{
						num2 = 4;
					}
					else if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '5')
					{
						num2 = 5;
					}
					else if (PIDLOFMIEFQ[IIHDGMLHICI + 5] == '6')
					{
						num2 = 6;
					}
					if (num != -1)
					{
						IIHDGMLHICI = num + 1;
					}
					else
					{
						IIHDGMLHICI = PIDLOFMIEFQ.Length;
					}
					if (BBCJFBHDJFP != null)
					{
						BBCJFBHDJFP.LHQECHHMOGD(JGDHIPBGCFP.LPEGECBMQKQ.EGLLCPNBQIG[num2]);
					}
					return true;
				}
				if (PIDLOFMIEFQ[IIHDGMLHICI + 1] == 'i' && PIDLOFMIEFQ[IIHDGMLHICI + 2] == 't' && PIDLOFMIEFQ[IIHDGMLHICI + 3] == 'm' && PIDLOFMIEFQ[IIHDGMLHICI + 4] == '=')
				{
					int num3 = PIDLOFMIEFQ.IndexOf(']', IIHDGMLHICI + 4);
					if (num3 != -1)
					{
						IIHDGMLHICI = num3 + 1;
					}
					else
					{
						IIHDGMLHICI = PIDLOFMIEFQ.Length;
					}
					if (BBCJFBHDJFP != null)
					{
						BBCJFBHDJFP.LHQECHHMOGD(JGDHIPBGCFP.LPEGECBMQKQ.EGLLCPNBQIG[1]);
					}
					return true;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x0009C110 File Offset: 0x0009A310
	public static string IMOMGBNIENN(string PIDLOFMIEFQ)
	{
		if (PIDLOFMIEFQ != null)
		{
			int i = 0;
			int length = PIDLOFMIEFQ.Length;
			while (i < length)
			{
				char c = PIDLOFMIEFQ[i];
				if (c == '[')
				{
					int num = 0;
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					bool flag6 = false;
					int num2 = i;
					if (JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref num2, null, false, ref num, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6))
					{
						PIDLOFMIEFQ = PIDLOFMIEFQ.Remove(i, num2 - i);
						length = PIDLOFMIEFQ.Length;
						continue;
					}
				}
				i++;
			}
		}
		return PIDLOFMIEFQ;
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x0009C188 File Offset: 0x0009A388
	public static string NDFGOJOBPCJ(string PIDLOFMIEFQ, bool QOPOGDLCHKE = false)
	{
		if (PIDLOFMIEFQ != null)
		{
			char[] array = null;
			if (QOPOGDLCHKE)
			{
				array = PIDLOFMIEFQ.ToCharArray();
			}
			int i = 0;
			int length = PIDLOFMIEFQ.Length;
			while (i < length)
			{
				char c = PIDLOFMIEFQ[i];
				if (c == '[')
				{
					int num = 0;
					bool flag = false;
					bool flag2 = false;
					bool flag3 = false;
					bool flag4 = false;
					bool flag5 = false;
					bool flag6 = false;
					int num2 = i;
					if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref num2, null, false, ref num, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6))
					{
						if (QOPOGDLCHKE)
						{
							for (int j = 0; j < num2 - i; j++)
							{
								array[i + j] = '\u0018';
							}
							i += num2 - i;
							continue;
						}
						PIDLOFMIEFQ = PIDLOFMIEFQ.Remove(i, num2 - i);
						length = PIDLOFMIEFQ.Length;
						continue;
					}
				}
				i++;
			}
			if (QOPOGDLCHKE)
			{
				PIDLOFMIEFQ = new string(array);
			}
			return PIDLOFMIEFQ;
		}
		return PIDLOFMIEFQ;
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x0009C24C File Offset: 0x0009A44C
	public static void JGEFOHEFEMB(List<Vector3> EQINHIFFOGG, int QGIIMLNCLLO, float LBMMQHHINKD, int LHMQOIHQPHI = 4)
	{
		JGDHIPBGCFP.MNMQCONMCFH pbhnpknjnjh = JGDHIPBGCFP.PBHNPKNJNJH;
		if (pbhnpknjnjh != JGDHIPBGCFP.MNMQCONMCFH.Right)
		{
			if (pbhnpknjnjh != JGDHIPBGCFP.MNMQCONMCFH.Center)
			{
				if (pbhnpknjnjh == JGDHIPBGCFP.MNMQCONMCFH.Justified)
				{
					if (LBMMQHHINKD < (float)JGDHIPBGCFP.JQGIJOFBHME * 0.65f)
					{
						return;
					}
					float num = ((float)JGDHIPBGCFP.JQGIJOFBHME - LBMMQHHINKD) * 0.5f;
					if (num < 1f)
					{
						return;
					}
					int num2 = (EQINHIFFOGG.Count - QGIIMLNCLLO) / LHMQOIHQPHI;
					if (num2 < 1)
					{
						return;
					}
					float num3 = 1f / (float)(num2 - 1);
					float num4 = (float)JGDHIPBGCFP.JQGIJOFBHME / LBMMQHHINKD;
					int i = QGIIMLNCLLO + LHMQOIHQPHI;
					int num5 = 1;
					int count = EQINHIFFOGG.Count;
					while (i < count)
					{
						float num6 = EQINHIFFOGG[i].x;
						float num7 = EQINHIFFOGG[i + LHMQOIHQPHI / 2].x;
						float num8 = num7 - num6;
						float num9 = num6 * num4;
						float a = num9 + num8;
						float num10 = num7 * num4;
						float b = num10 - num8;
						float t = (float)num5 * num3;
						num7 = Mathf.Lerp(a, num10, t);
						num6 = Mathf.Lerp(num9, b, t);
						num6 = Mathf.Round(num6);
						num7 = Mathf.Round(num7);
						if (LHMQOIHQPHI == 4)
						{
							Vector3 value = EQINHIFFOGG[i];
							value.x = num6;
							EQINHIFFOGG[i++] = value;
							value = EQINHIFFOGG[i];
							value.x = num6;
							EQINHIFFOGG[i++] = value;
							value = EQINHIFFOGG[i];
							value.x = num7;
							EQINHIFFOGG[i++] = value;
							value = EQINHIFFOGG[i];
							value.x = num7;
							EQINHIFFOGG[i++] = value;
						}
						else if (LHMQOIHQPHI == 2)
						{
							Vector3 value = EQINHIFFOGG[i];
							value.x = num6;
							EQINHIFFOGG[i++] = value;
							value = EQINHIFFOGG[i];
							value.x = num7;
							EQINHIFFOGG[i++] = value;
						}
						else if (LHMQOIHQPHI == 1)
						{
							Vector3 value = EQINHIFFOGG[i];
							value.x = num6;
							EQINHIFFOGG[i++] = value;
						}
						num5++;
					}
				}
			}
			else
			{
				float num11 = ((float)JGDHIPBGCFP.JQGIJOFBHME - LBMMQHHINKD) * 0.5f;
				if (num11 < 0f)
				{
					return;
				}
				int num12 = Mathf.RoundToInt((float)JGDHIPBGCFP.JQGIJOFBHME - LBMMQHHINKD);
				int num13 = Mathf.RoundToInt((float)JGDHIPBGCFP.JQGIJOFBHME);
				bool flag = (num12 & 1) == 1;
				bool flag2 = (num13 & 1) == 1;
				if ((flag && !flag2) || (!flag && flag2))
				{
					num11 += 0.5f * JGDHIPBGCFP.CNLNKDBIMDB;
				}
				int j = QGIIMLNCLLO;
				int count2 = EQINHIFFOGG.Count;
				while (j < count2)
				{
					Vector3 value2 = EQINHIFFOGG[j];
					value2.x += num11;
					EQINHIFFOGG[j] = value2;
					j++;
				}
			}
		}
		else
		{
			float num14 = (float)JGDHIPBGCFP.JQGIJOFBHME - LBMMQHHINKD;
			if (num14 < 0f)
			{
				return;
			}
			int k = QGIIMLNCLLO;
			int count3 = EQINHIFFOGG.Count;
			while (k < count3)
			{
				Vector3 value3 = EQINHIFFOGG[k];
				value3.x += num14;
				EQINHIFFOGG[k] = value3;
				k++;
			}
		}
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x0009C564 File Offset: 0x0009A764
	public static int DKOIDEHOHHM(List<Vector3> EQINHIFFOGG, List<int> NOGGFCDKLLJ, Vector2 NKKGPNPGDEM)
	{
		int i = 0;
		int count = NOGGFCDKLLJ.Count;
		while (i < count)
		{
			int num = i << 1;
			int index = num + 1;
			float x = EQINHIFFOGG[num].x;
			if (NKKGPNPGDEM.x >= x)
			{
				float x2 = EQINHIFFOGG[index].x;
				if (NKKGPNPGDEM.x <= x2)
				{
					float y = EQINHIFFOGG[num].y;
					if (NKKGPNPGDEM.y >= y)
					{
						float y2 = EQINHIFFOGG[index].y;
						if (NKKGPNPGDEM.y <= y2)
						{
							return NOGGFCDKLLJ[i];
						}
					}
				}
			}
			i++;
		}
		return 0;
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x0009C610 File Offset: 0x0009A810
	public static int JEJHCLIQBOM(List<Vector3> EQINHIFFOGG, List<int> NOGGFCDKLLJ, Vector2 NKKGPNPGDEM)
	{
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		int index = 0;
		int i = 0;
		int count = EQINHIFFOGG.Count;
		while (i < count)
		{
			float num3 = Mathf.Abs(NKKGPNPGDEM.y - EQINHIFFOGG[i].y);
			if (num3 <= num2)
			{
				float num4 = Mathf.Abs(NKKGPNPGDEM.x - EQINHIFFOGG[i].x);
				if (num3 < num2)
				{
					num2 = num3;
					num = num4;
					index = i;
				}
				else if (num4 < num)
				{
					num = num4;
					index = i;
				}
			}
			i++;
		}
		return NOGGFCDKLLJ[index];
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x0000B5FB File Offset: 0x000097FB
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static bool JMCIGLOFKCJ(int BFBMOIKCELJ)
	{
		return BFBMOIKCELJ == 32 || BFBMOIKCELJ == 8202 || BFBMOIKCELJ == 8203 || BFBMOIKCELJ == 8201;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0009C6A4 File Offset: 0x0009A8A4
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static void LPDHBGIHPQM(ref StringBuilder JMDLLJPEFKM)
	{
		int num = JMDLLJPEFKM.Length - 1;
		if (num > 0 && JGDHIPBGCFP.JMCIGLOFKCJ((int)JMDLLJPEFKM[num]))
		{
			JMDLLJPEFKM[num] = '\n';
		}
		else
		{
			JMDLLJPEFKM.Append('\n');
		}
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0009C6E4 File Offset: 0x0009A8E4
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void NMIBIQKOFQN(ref StringBuilder JMDLLJPEFKM)
	{
		int num = JMDLLJPEFKM.Length - 1;
		if (num > 0 && JGDHIPBGCFP.JMCIGLOFKCJ((int)JMDLLJPEFKM[num]))
		{
			JMDLLJPEFKM[num] = '\n';
		}
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0009C718 File Offset: 0x0009A918
	public static Vector2 HFFLNGCJLPD(string PIDLOFMIEFQ)
	{
		Vector2 zero = Vector2.zero;
		if (!string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			if (JGDHIPBGCFP.CKGCLBODNNJ)
			{
				PIDLOFMIEFQ = JGDHIPBGCFP.IMOMGBNIENN(PIDLOFMIEFQ);
			}
			PIDLOFMIEFQ = JGDHIPBGCFP.NDFGOJOBPCJ(PIDLOFMIEFQ, false);
			JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			int length = PIDLOFMIEFQ.Length;
			int emphiiopnhg = 0;
			for (int i = 0; i < length; i++)
			{
				int num4 = (int)PIDLOFMIEFQ[i];
				if (num4 == 10)
				{
					if (num > num3)
					{
						num3 = num;
					}
					num = 0f;
					num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
				}
				else if (num4 >= 32)
				{
					BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
					if (bmsymbol == null)
					{
						float num5 = JGDHIPBGCFP.QFDNOHJLEBO(num4, emphiiopnhg);
						if (num5 != 0f)
						{
							num5 += JGDHIPBGCFP.KPKBDNNKNGB;
							if (Mathf.RoundToInt(num + num5) > JGDHIPBGCFP.PPMHDQJHPLO)
							{
								if (num > num3)
								{
									num3 = num - JGDHIPBGCFP.KPKBDNNKNGB;
								}
								num = num5;
								num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
							}
							else
							{
								num += num5;
							}
							emphiiopnhg = num4;
						}
					}
					else
					{
						float num6 = JGDHIPBGCFP.KPKBDNNKNGB + (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB;
						if (Mathf.RoundToInt(num + num6) > JGDHIPBGCFP.PPMHDQJHPLO)
						{
							if (num > num3)
							{
								num3 = num - JGDHIPBGCFP.KPKBDNNKNGB;
							}
							num = num6;
							num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
						}
						else
						{
							num += num6;
						}
						i += bmsymbol.sequence.Length - 1;
						emphiiopnhg = 0;
					}
				}
			}
			zero.x = ((num <= num3) ? num3 : (num - JGDHIPBGCFP.KPKBDNNKNGB));
			zero.y = num2 + JGDHIPBGCFP.HHDHKPIMKNQ;
		}
		return zero;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0009C8AC File Offset: 0x0009AAAC
	public static int FJDCKEJNMKI(string PIDLOFMIEFQ, bool OOHIOGBQGGJ = false)
	{
		if (!string.IsNullOrEmpty(PIDLOFMIEFQ) && JGDHIPBGCFP.PPMHDQJHPLO >= 1)
		{
			JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
			if (OOHIOGBQGGJ)
			{
				PIDLOFMIEFQ = JGDHIPBGCFP.NDFGOJOBPCJ(PIDLOFMIEFQ, true);
			}
			int length = PIDLOFMIEFQ.Length;
			int emphiiopnhg = 0;
			int i = 0;
			int length2 = PIDLOFMIEFQ.Length;
			while (i < length2)
			{
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				if (bmsymbol == null)
				{
					int num = (int)PIDLOFMIEFQ[i];
					float num2 = JGDHIPBGCFP.QFDNOHJLEBO(num, emphiiopnhg);
					if (num == 24)
					{
						JGDHIPBGCFP.QHLHLMJDIIG.LHQECHHMOGD(0f);
					}
					else if (num2 != 0f)
					{
						JGDHIPBGCFP.QHLHLMJDIIG.LHQECHHMOGD(JGDHIPBGCFP.KPKBDNNKNGB + num2);
					}
					emphiiopnhg = num;
				}
				else
				{
					JGDHIPBGCFP.QHLHLMJDIIG.LHQECHHMOGD(JGDHIPBGCFP.KPKBDNNKNGB + (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB);
					int j = 0;
					int num3 = bmsymbol.sequence.Length - 1;
					while (j < num3)
					{
						JGDHIPBGCFP.QHLHLMJDIIG.LHQECHHMOGD(0f);
						j++;
					}
					i += bmsymbol.sequence.Length - 1;
					emphiiopnhg = 0;
				}
				i++;
			}
			float num4 = (float)JGDHIPBGCFP.PPMHDQJHPLO;
			int num5 = JGDHIPBGCFP.QHLHLMJDIIG.BJGMIBBEGDQ;
			while (num5 > 0 && num4 > 0f)
			{
				num4 -= JGDHIPBGCFP.QHLHLMJDIIG.get_KNPPMKBOGDL(--num5);
			}
			JGDHIPBGCFP.QHLHLMJDIIG.CPLBKPNNHJG();
			if (num4 < 0f)
			{
				num5++;
			}
			return num5;
		}
		return 0;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x0009CA20 File Offset: 0x0009AC20
	public static string HLHPBFGBHNL(string PIDLOFMIEFQ)
	{
		int length = PIDLOFMIEFQ.Length;
		int num = JGDHIPBGCFP.FJDCKEJNMKI(PIDLOFMIEFQ, false);
		return PIDLOFMIEFQ.Substring(num, length - num);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0000B61D File Offset: 0x0000981D
	public static bool QDHGBPQDDMQ(string PIDLOFMIEFQ, out string LENEEONCNEC, bool GELMBKNPONF = false)
	{
		return JGDHIPBGCFP.QDHGBPQDDMQ(PIDLOFMIEFQ, out LENEEONCNEC, false, GELMBKNPONF, false, 0f);
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x0009CA48 File Offset: 0x0009AC48
	public static bool QDHGBPQDDMQ(string PIDLOFMIEFQ, out string LENEEONCNEC, bool KILPCHCPJBG, bool GELMBKNPONF, bool BMIKMHIKDQN = false, float KDMKDDDNBGL = 0f)
	{
		if (JGDHIPBGCFP.PPMHDQJHPLO < 1 || JGDHIPBGCFP.NNHJHLOFKFD < 1 || JGDHIPBGCFP.HHDHKPIMKNQ < 1f)
		{
			LENEEONCNEC = string.Empty;
			return false;
		}
		float num = (JGDHIPBGCFP.BPIPFOJNJCQ <= 0) ? ((float)JGDHIPBGCFP.NNHJHLOFKFD) : Mathf.Min((float)JGDHIPBGCFP.NNHJHLOFKFD, JGDHIPBGCFP.HHDHKPIMKNQ * (float)JGDHIPBGCFP.BPIPFOJNJCQ);
		int num2 = (JGDHIPBGCFP.BPIPFOJNJCQ <= 0) ? 1000000 : JGDHIPBGCFP.BPIPFOJNJCQ;
		num2 = Mathf.FloorToInt(Mathf.Min((float)num2, num / JGDHIPBGCFP.HHDHKPIMKNQ) + 0.01f);
		if (num2 == 0)
		{
			LENEEONCNEC = string.Empty;
			return false;
		}
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			PIDLOFMIEFQ = " ";
		}
		JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
		StringBuilder stringBuilder = new StringBuilder();
		int length = PIDLOFMIEFQ.Length;
		float num3 = (float)JGDHIPBGCFP.PPMHDQJHPLO;
		int num4 = 0;
		int i = (int)KDMKDDDNBGL;
		int num5 = 1;
		int emphiiopnhg = 0;
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		Color color = JGDHIPBGCFP.BLEDJGLIIPF;
		int num6 = 0;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		if (!JGDHIPBGCFP.OPBBHFJNIPG)
		{
			GELMBKNPONF = false;
		}
		if (GELMBKNPONF)
		{
			JGDHIPBGCFP.DFDDMIJEBNH.LHQECHHMOGD(color);
			stringBuilder.Append("[");
			stringBuilder.Append(JGDHIPBGCFP.JPHIJCIGHPQ(color));
			stringBuilder.Append("]");
		}
		while (i < length)
		{
			char c = PIDLOFMIEFQ[i];
			if (c > '⿿')
			{
				flag3 = true;
			}
			if (c == '\n')
			{
				if (num5 == num2)
				{
					break;
				}
				num3 = (float)JGDHIPBGCFP.PPMHDQJHPLO;
				if (num4 < i)
				{
					stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, i - num4 + 1));
				}
				else
				{
					stringBuilder.Append(c);
				}
				if (GELMBKNPONF)
				{
					for (int j = 0; j < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; j++)
					{
						stringBuilder.Insert(stringBuilder.Length - 1, "[-]");
					}
					for (int k = 0; k < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; k++)
					{
						stringBuilder.Append("[");
						stringBuilder.Append(JGDHIPBGCFP.JPHIJCIGHPQ(JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(k)));
						stringBuilder.Append("]");
					}
				}
				flag = true;
				num5++;
				num4 = i + 1;
				emphiiopnhg = 0;
			}
			else
			{
				bool flag10 = false;
				int num7 = 0;
				if (!GELMBKNPONF)
				{
					if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i, null, false, ref num7, ref flag10, ref flag10, ref flag10, ref flag10, ref flag10, ref flag9))
					{
						i--;
						goto IL_7FB;
					}
					if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i))
					{
						i--;
						goto IL_7FB;
					}
				}
				else
				{
					if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i, JGDHIPBGCFP.DFDDMIJEBNH, JGDHIPBGCFP.NFLEOLEGPJJ, ref num6, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9))
					{
						if (flag8)
						{
							color = JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
							color.a *= JGDHIPBGCFP.KELMMNHOKKB * JGDHIPBGCFP.BLEDJGLIIPF.a;
						}
						else
						{
							color = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
							color.a *= JGDHIPBGCFP.KELMMNHOKKB;
						}
						int l = 0;
						int num8 = JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 2;
						while (l < num8)
						{
							color.a *= JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(l).a;
							l++;
						}
						i--;
						if (num4 < i)
						{
							stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, i - num4 + 1));
						}
						else
						{
							stringBuilder.Append(c);
						}
						num4 = i + 1;
						goto IL_7FB;
					}
					if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i, JGDHIPBGCFP.DFDDMIJEBNH, JGDHIPBGCFP.NFLEOLEGPJJ, ref num6, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9))
					{
						if (flag8)
						{
							color = JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
							color.a *= JGDHIPBGCFP.KELMMNHOKKB * JGDHIPBGCFP.BLEDJGLIIPF.a;
						}
						else
						{
							color = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
							color.a *= JGDHIPBGCFP.KELMMNHOKKB;
						}
						int m = 0;
						int num9 = JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 2;
						while (m < num9)
						{
							color.a *= JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(m).a;
							m++;
						}
						i--;
						if (num4 < i)
						{
							stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, i - num4 + 1));
						}
						else
						{
							stringBuilder.Append(c);
						}
						num4 = i + 1;
						goto IL_7FB;
					}
				}
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				float num11;
				if (bmsymbol == null)
				{
					float num10 = JGDHIPBGCFP.QFDNOHJLEBO((int)c, emphiiopnhg);
					if (num10 == 0f && !JGDHIPBGCFP.JMCIGLOFKCJ((int)c))
					{
						goto IL_7FB;
					}
					num11 = JGDHIPBGCFP.KPKBDNNKNGB + num10;
				}
				else
				{
					num11 = JGDHIPBGCFP.KPKBDNNKNGB + (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB;
				}
				num3 -= num11;
				if (JGDHIPBGCFP.JMCIGLOFKCJ((int)c) && !flag3 && num4 < i)
				{
					int num12 = i - num4 + 1;
					if (num5 == num2 && num3 <= 0f && i < length)
					{
						char c2 = PIDLOFMIEFQ[i];
						if (c2 < ' ' || JGDHIPBGCFP.JMCIGLOFKCJ((int)c2))
						{
							num12--;
						}
					}
					stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, num12));
					flag = false;
					num4 = i + 1;
				}
				if (Mathf.RoundToInt(num3) < 0)
				{
					if (!flag)
					{
						if (num5 != num2)
						{
							flag = true;
							num3 = (float)JGDHIPBGCFP.PPMHDQJHPLO;
							i = num4 - 1;
							emphiiopnhg = 0;
							if (num5++ == num2)
							{
								break;
							}
							if (KILPCHCPJBG)
							{
								JGDHIPBGCFP.NMIBIQKOFQN(ref stringBuilder);
							}
							else
							{
								JGDHIPBGCFP.LPDHBGIHPQM(ref stringBuilder);
							}
							if (GELMBKNPONF)
							{
								for (int n = 0; n < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; n++)
								{
									stringBuilder.Insert(stringBuilder.Length - 1, "[-]");
								}
								for (int num13 = 0; num13 < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; num13++)
								{
									stringBuilder.Append("[");
									stringBuilder.Append(JGDHIPBGCFP.JPHIJCIGHPQ(JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(num13)));
									stringBuilder.Append("]");
								}
								goto IL_7FB;
							}
							goto IL_7FB;
						}
					}
					if (BMIKMHIKDQN && num5 == num2 && i > 1)
					{
						float num14 = JGDHIPBGCFP.QFDNOHJLEBO(46, 46) * 3f;
						if (num14 < (float)JGDHIPBGCFP.PPMHDQJHPLO)
						{
							num3 += num11;
							int num15 = i;
							int num16 = 0;
							while (num15 > 1 && num3 < num14)
							{
								num15--;
								char emphiiopnhg2 = PIDLOFMIEFQ[num15 - 1];
								char bfbmoikcelj = PIDLOFMIEFQ[num15];
								bool flag11 = num3 == 0f && JGDHIPBGCFP.JMCIGLOFKCJ((int)bfbmoikcelj);
								num3 += JGDHIPBGCFP.QFDNOHJLEBO((int)bfbmoikcelj, (int)emphiiopnhg2);
								if (num15 < num4 && !flag11)
								{
									num16++;
								}
							}
							if (num3 >= num14)
							{
								if (num16 > 0)
								{
									stringBuilder.Length = Mathf.Max(0, stringBuilder.Length - num16);
								}
								stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, Mathf.Max(0, num15 - num4)));
								while (stringBuilder.Length > 0 && JGDHIPBGCFP.JMCIGLOFKCJ((int)stringBuilder[stringBuilder.Length - 1]))
								{
									stringBuilder.Length--;
								}
								stringBuilder.Append("...");
								num5++;
								i = (num4 = num15);
								break;
							}
						}
					}
					stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, Mathf.Max(0, i - num4)));
					bool flag12;
					if (!(flag12 = JGDHIPBGCFP.JMCIGLOFKCJ((int)c)) && !flag3)
					{
						flag2 = false;
					}
					if (GELMBKNPONF && JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ > 0)
					{
						stringBuilder.Append("[-]");
					}
					if (num5++ == num2)
					{
						num4 = i;
						break;
					}
					if (KILPCHCPJBG)
					{
						JGDHIPBGCFP.NMIBIQKOFQN(ref stringBuilder);
					}
					else
					{
						JGDHIPBGCFP.LPDHBGIHPQM(ref stringBuilder);
					}
					if (GELMBKNPONF)
					{
						for (int num17 = 0; num17 < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; num17++)
						{
							stringBuilder.Insert(stringBuilder.Length - 1, "[-]");
						}
						for (int num18 = 0; num18 < JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ; num18++)
						{
							stringBuilder.Append("[");
							stringBuilder.Append(JGDHIPBGCFP.JPHIJCIGHPQ(JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(num18)));
							stringBuilder.Append("]");
						}
					}
					flag = true;
					if (flag12)
					{
						num4 = i + 1;
						num3 = (float)JGDHIPBGCFP.PPMHDQJHPLO;
					}
					else
					{
						num4 = i;
						num3 = (float)JGDHIPBGCFP.PPMHDQJHPLO - num11;
					}
					emphiiopnhg = 0;
				}
				else
				{
					emphiiopnhg = (int)c;
				}
				if (bmsymbol != null)
				{
					i += bmsymbol.length - 1;
					emphiiopnhg = 0;
				}
			}
			IL_7FB:
			i++;
			continue;
			IL_88F:
			if (num4 < i)
			{
				stringBuilder.Append(PIDLOFMIEFQ.Substring(num4, i - num4));
			}
			if (GELMBKNPONF && JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ > 0)
			{
				stringBuilder.Append("[-]");
			}
			LENEEONCNEC = stringBuilder.ToString();
			JGDHIPBGCFP.DFDDMIJEBNH.CPLBKPNNHJG();
			return flag2 && (i == length || num5 <= Mathf.Min(JGDHIPBGCFP.BPIPFOJNJCQ, num2));
		}
		goto IL_88F;
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x0009D358 File Offset: 0x0009B558
	public static void JBCCFGJGOPH(string PIDLOFMIEFQ, List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			return;
		}
		int count = EQINHIFFOGG.Count;
		JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
		JGDHIPBGCFP.DFDDMIJEBNH.LHQECHHMOGD(Color.white);
		JGDHIPBGCFP.KELMMNHOKKB = 1f;
		int emphiiopnhg = 0;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = (float)JGDHIPBGCFP.FIDDHHCOCCD;
		Color a = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.QEQOQOOCEEN;
		Color b = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.MBCPMFDMEEQ;
		Color color = JGDHIPBGCFP.BLEDJGLIIPF;
		int length = PIDLOFMIEFQ.Length;
		Rect rect = default(Rect);
		float num5 = 0f;
		float num6 = 0f;
		float num7 = num4 * JGDHIPBGCFP.OOBHQPCDCPD;
		bool flag = false;
		int num8 = 0;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		if (JGDHIPBGCFP.NFIBPOJMOCQ != null)
		{
			rect = JGDHIPBGCFP.NFIBPOJMOCQ.GINPFQOBGBO;
			num5 = rect.width / (float)JGDHIPBGCFP.NFIBPOJMOCQ.EGFBNNLLKKD;
			num6 = rect.height / (float)JGDHIPBGCFP.NFIBPOJMOCQ.JMGGLEHMOIF;
		}
		for (int i = 0; i < length; i++)
		{
			int num9 = (int)PIDLOFMIEFQ[i];
			float num10 = num;
			if (num9 == 10)
			{
				if (num > num3)
				{
					num3 = num;
				}
				if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
				{
					JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 4);
					count = EQINHIFFOGG.Count;
				}
				num = 0f;
				num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
				emphiiopnhg = 0;
			}
			else if (num9 < 32)
			{
				emphiiopnhg = num9;
			}
			else if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i, JGDHIPBGCFP.DFDDMIJEBNH, JGDHIPBGCFP.NFLEOLEGPJJ, ref num8, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7))
			{
				if (flag6)
				{
					color = JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
					color.a *= JGDHIPBGCFP.KELMMNHOKKB * JGDHIPBGCFP.BLEDJGLIIPF.a;
				}
				else
				{
					color = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
					color.a *= JGDHIPBGCFP.KELMMNHOKKB;
				}
				int j = 0;
				int num11 = JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 2;
				while (j < num11)
				{
					color.a *= JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(j).a;
					j++;
				}
				if (JGDHIPBGCFP.JFQBHOFLBQG)
				{
					a = JGDHIPBGCFP.QEQOQOOCEEN * color;
					b = JGDHIPBGCFP.MBCPMFDMEEQ * color;
				}
				i--;
			}
			else if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i, JGDHIPBGCFP.DFDDMIJEBNH, JGDHIPBGCFP.NFLEOLEGPJJ, ref num8, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7))
			{
				if (flag6)
				{
					color = JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
					color.a *= JGDHIPBGCFP.KELMMNHOKKB * JGDHIPBGCFP.BLEDJGLIIPF.a;
				}
				else
				{
					color = JGDHIPBGCFP.BLEDJGLIIPF * JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 1);
					color.a *= JGDHIPBGCFP.KELMMNHOKKB;
				}
				int k = 0;
				int num12 = JGDHIPBGCFP.DFDDMIJEBNH.BJGMIBBEGDQ - 2;
				while (k < num12)
				{
					color.a *= JGDHIPBGCFP.DFDDMIJEBNH.get_KNPPMKBOGDL(k).a;
					k++;
				}
				if (JGDHIPBGCFP.JFQBHOFLBQG)
				{
					a = JGDHIPBGCFP.QEQOQOOCEEN * color;
					b = JGDHIPBGCFP.MBCPMFDMEEQ * color;
				}
				i--;
			}
			else
			{
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				if (bmsymbol != null)
				{
					float num13 = num + (float)bmsymbol.offsetX * JGDHIPBGCFP.CNLNKDBIMDB;
					float num14 = num13 + (float)bmsymbol.width * JGDHIPBGCFP.CNLNKDBIMDB;
					float num15 = -(num2 + (float)bmsymbol.offsetY * JGDHIPBGCFP.CNLNKDBIMDB);
					float num16 = num15 - (float)bmsymbol.height * JGDHIPBGCFP.CNLNKDBIMDB;
					if (Mathf.RoundToInt(num + (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB) > JGDHIPBGCFP.PPMHDQJHPLO)
					{
						if (num == 0f)
						{
							return;
						}
						if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
						{
							JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 4);
							count = EQINHIFFOGG.Count;
						}
						num13 -= num;
						num14 -= num;
						num16 -= JGDHIPBGCFP.HHDHKPIMKNQ;
						num15 -= JGDHIPBGCFP.HHDHKPIMKNQ;
						num = 0f;
						num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
					}
					EQINHIFFOGG.Add(new Vector3(num13, num16));
					EQINHIFFOGG.Add(new Vector3(num13, num15));
					EQINHIFFOGG.Add(new Vector3(num14, num15));
					EQINHIFFOGG.Add(new Vector3(num14, num16));
					num += JGDHIPBGCFP.KPKBDNNKNGB + (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB;
					i += bmsymbol.length - 1;
					emphiiopnhg = 0;
					if (PICFCJNMJMC != null)
					{
						Rect uvRect = bmsymbol.uvRect;
						float xMin = uvRect.xMin;
						float yMin = uvRect.yMin;
						float xMax = uvRect.xMax;
						float yMax = uvRect.yMax;
						PICFCJNMJMC.Add(new Vector2(xMin, yMin));
						PICFCJNMJMC.Add(new Vector2(xMin, yMax));
						PICFCJNMJMC.Add(new Vector2(xMax, yMax));
						PICFCJNMJMC.Add(new Vector2(xMax, yMin));
					}
					if (HQOONBPDFHO != null)
					{
						if (JGDHIPBGCFP.FJPNBPJQODQ == JGDHIPBGCFP.OQGGLOQFNPE.Colored)
						{
							for (int l = 0; l < 4; l++)
							{
								HQOONBPDFHO.Add(color);
							}
						}
						else
						{
							Color white = Color.white;
							white.a = color.a;
							for (int m = 0; m < 4; m++)
							{
								HQOONBPDFHO.Add(white);
							}
						}
					}
				}
				else
				{
					JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi = JGDHIPBGCFP.GMFDPCIHHHM(num9, emphiiopnhg);
					if (ohcgmleqeoi != null)
					{
						emphiiopnhg = num9;
						if (num8 != 0)
						{
							JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi2 = ohcgmleqeoi;
							ohcgmleqeoi2.OGBMILEIPHH.x = ohcgmleqeoi2.OGBMILEIPHH.x * 0.75f;
							JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi3 = ohcgmleqeoi;
							ohcgmleqeoi3.OGBMILEIPHH.y = ohcgmleqeoi3.OGBMILEIPHH.y * 0.75f;
							JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi4 = ohcgmleqeoi;
							ohcgmleqeoi4.EHCJCFGFJBD.x = ohcgmleqeoi4.EHCJCFGFJBD.x * 0.75f;
							JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi5 = ohcgmleqeoi;
							ohcgmleqeoi5.EHCJCFGFJBD.y = ohcgmleqeoi5.EHCJCFGFJBD.y * 0.75f;
							if (num8 == 1)
							{
								JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi6 = ohcgmleqeoi;
								ohcgmleqeoi6.OGBMILEIPHH.y = ohcgmleqeoi6.OGBMILEIPHH.y - JGDHIPBGCFP.CNLNKDBIMDB * (float)JGDHIPBGCFP.HQLMJHHPHQL * 0.4f;
								JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi7 = ohcgmleqeoi;
								ohcgmleqeoi7.EHCJCFGFJBD.y = ohcgmleqeoi7.EHCJCFGFJBD.y - JGDHIPBGCFP.CNLNKDBIMDB * (float)JGDHIPBGCFP.HQLMJHHPHQL * 0.4f;
							}
							else
							{
								JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi8 = ohcgmleqeoi;
								ohcgmleqeoi8.OGBMILEIPHH.y = ohcgmleqeoi8.OGBMILEIPHH.y + JGDHIPBGCFP.CNLNKDBIMDB * (float)JGDHIPBGCFP.HQLMJHHPHQL * 0.05f;
								JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi9 = ohcgmleqeoi;
								ohcgmleqeoi9.EHCJCFGFJBD.y = ohcgmleqeoi9.EHCJCFGFJBD.y + JGDHIPBGCFP.CNLNKDBIMDB * (float)JGDHIPBGCFP.HQLMJHHPHQL * 0.05f;
							}
						}
						float num13 = ohcgmleqeoi.OGBMILEIPHH.x + num;
						float num16 = ohcgmleqeoi.OGBMILEIPHH.y - num2;
						float num14 = ohcgmleqeoi.EHCJCFGFJBD.x + num;
						float num15 = ohcgmleqeoi.EHCJCFGFJBD.y - num2;
						float num17 = ohcgmleqeoi.BNEBCKEPNNM;
						if (JGDHIPBGCFP.KPKBDNNKNGB < 0f)
						{
							num17 += JGDHIPBGCFP.KPKBDNNKNGB;
						}
						if (Mathf.RoundToInt(num + num17) > JGDHIPBGCFP.PPMHDQJHPLO)
						{
							if (num == 0f)
							{
								return;
							}
							if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
							{
								JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 4);
								count = EQINHIFFOGG.Count;
							}
							num13 -= num;
							num14 -= num;
							num16 -= JGDHIPBGCFP.HHDHKPIMKNQ;
							num15 -= JGDHIPBGCFP.HHDHKPIMKNQ;
							num = 0f;
							num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
							num10 = 0f;
						}
						if (JGDHIPBGCFP.JMCIGLOFKCJ(num9))
						{
							if (flag4)
							{
								num9 = 95;
							}
							else if (flag5)
							{
								num9 = 45;
							}
						}
						num += ((num8 != 0) ? ((JGDHIPBGCFP.KPKBDNNKNGB + ohcgmleqeoi.BNEBCKEPNNM) * 0.75f) : (JGDHIPBGCFP.KPKBDNNKNGB + ohcgmleqeoi.BNEBCKEPNNM));
						if (num8 != 0)
						{
							num = Mathf.Round(num);
						}
						if (!JGDHIPBGCFP.JMCIGLOFKCJ(num9))
						{
							if (PICFCJNMJMC != null)
							{
								if (JGDHIPBGCFP.NFIBPOJMOCQ != null)
								{
									ohcgmleqeoi.BHGJLHQBEKQ.x = rect.xMin + num5 * ohcgmleqeoi.BHGJLHQBEKQ.x;
									ohcgmleqeoi.EFFPLIOQGCE.x = rect.xMin + num5 * ohcgmleqeoi.EFFPLIOQGCE.x;
									ohcgmleqeoi.BHGJLHQBEKQ.y = rect.yMax - num6 * ohcgmleqeoi.BHGJLHQBEKQ.y;
									ohcgmleqeoi.EFFPLIOQGCE.y = rect.yMax - num6 * ohcgmleqeoi.EFFPLIOQGCE.y;
									ohcgmleqeoi.OCHQODGHQCQ.x = ohcgmleqeoi.BHGJLHQBEKQ.x;
									ohcgmleqeoi.OCHQODGHQCQ.y = ohcgmleqeoi.EFFPLIOQGCE.y;
									ohcgmleqeoi.HNJHCBLKDHK.x = ohcgmleqeoi.EFFPLIOQGCE.x;
									ohcgmleqeoi.HNJHCBLKDHK.y = ohcgmleqeoi.BHGJLHQBEKQ.y;
								}
								int n = 0;
								int num18 = (!flag2) ? 1 : 4;
								while (n < num18)
								{
									PICFCJNMJMC.Add(ohcgmleqeoi.BHGJLHQBEKQ);
									PICFCJNMJMC.Add(ohcgmleqeoi.OCHQODGHQCQ);
									PICFCJNMJMC.Add(ohcgmleqeoi.EFFPLIOQGCE);
									PICFCJNMJMC.Add(ohcgmleqeoi.HNJHCBLKDHK);
									n++;
								}
							}
							if (flag7)
							{
								if (PICFCJNMJMC != null)
								{
									int num19 = 0;
									int num20 = 2;
									while (num19 < num20)
									{
										PICFCJNMJMC.Add(ohcgmleqeoi.BHGJLHQBEKQ);
										PICFCJNMJMC.Add(ohcgmleqeoi.OCHQODGHQCQ);
										PICFCJNMJMC.Add(ohcgmleqeoi.EFFPLIOQGCE);
										PICFCJNMJMC.Add(ohcgmleqeoi.HNJHCBLKDHK);
										num19++;
									}
								}
								EQINHIFFOGG.Add(new Vector3(num13 + 1f, num16));
								EQINHIFFOGG.Add(new Vector3(num13 + 1f, num15));
								EQINHIFFOGG.Add(new Vector3(num14 + 1f, num15));
								EQINHIFFOGG.Add(new Vector3(num14 + 1f, num16));
								EQINHIFFOGG.Add(new Vector3(num13 + 1f, num16 - 1f));
								EQINHIFFOGG.Add(new Vector3(num13 + 1f, num15 - 1f));
								EQINHIFFOGG.Add(new Vector3(num14 + 1f, num15 - 1f));
								EQINHIFFOGG.Add(new Vector3(num14 + 1f, num16 - 1f));
								int num21 = 0;
								int num22 = 8;
								while (num21 < num22)
								{
									HQOONBPDFHO.Add(new Color(0f, 0f, 0f, 1f));
									num21++;
								}
							}
							if (HQOONBPDFHO != null)
							{
								if (ohcgmleqeoi.NHNMIFPINDL != 0)
								{
									if (ohcgmleqeoi.NHNMIFPINDL != 15)
									{
										Color color2 = color;
										color2 *= 0.49f;
										switch (ohcgmleqeoi.NHNMIFPINDL)
										{
										case 1:
											color2.b += 0.51f;
											break;
										case 2:
											color2.g += 0.51f;
											break;
										case 4:
											color2.r += 0.51f;
											break;
										case 8:
											color2.a += 0.51f;
											break;
										}
										int num23 = 0;
										int num24 = (!flag2) ? 4 : 16;
										while (num23 < num24)
										{
											HQOONBPDFHO.Add(color2);
											num23++;
										}
										goto IL_C29;
									}
								}
								if (JGDHIPBGCFP.JFQBHOFLBQG)
								{
									float num25 = num7 + ohcgmleqeoi.OGBMILEIPHH.y / JGDHIPBGCFP.CNLNKDBIMDB;
									float num26 = num7 + ohcgmleqeoi.EHCJCFGFJBD.y / JGDHIPBGCFP.CNLNKDBIMDB;
									num25 /= num7;
									num26 /= num7;
									JGDHIPBGCFP.CMHPEMDQNBD = Color.Lerp(a, b, num25);
									JGDHIPBGCFP.FQDHGCQQIFE = Color.Lerp(a, b, num26);
									int num27 = 0;
									int num28 = (!flag2) ? 1 : 4;
									while (num27 < num28)
									{
										HQOONBPDFHO.Add(JGDHIPBGCFP.CMHPEMDQNBD);
										HQOONBPDFHO.Add(JGDHIPBGCFP.FQDHGCQQIFE);
										HQOONBPDFHO.Add(JGDHIPBGCFP.FQDHGCQQIFE);
										HQOONBPDFHO.Add(JGDHIPBGCFP.CMHPEMDQNBD);
										num27++;
									}
								}
								else
								{
									int num29 = 0;
									int num30 = (!flag2) ? 4 : 16;
									while (num29 < num30)
									{
										HQOONBPDFHO.Add(color);
										num29++;
									}
								}
							}
							IL_C29:
							if (!flag2)
							{
								if (!flag3)
								{
									EQINHIFFOGG.Add(new Vector3(num13, num16));
									EQINHIFFOGG.Add(new Vector3(num13, num15));
									EQINHIFFOGG.Add(new Vector3(num14, num15));
									EQINHIFFOGG.Add(new Vector3(num14, num16));
								}
								else
								{
									float num31 = (float)JGDHIPBGCFP.HQLMJHHPHQL * 0.1f * ((num15 - num16) / (float)JGDHIPBGCFP.HQLMJHHPHQL);
									EQINHIFFOGG.Add(new Vector3(num13 - num31, num16));
									EQINHIFFOGG.Add(new Vector3(num13 + num31, num15));
									EQINHIFFOGG.Add(new Vector3(num14 + num31, num15));
									EQINHIFFOGG.Add(new Vector3(num14 - num31, num16));
								}
							}
							else
							{
								for (int num32 = 0; num32 < 4; num32++)
								{
									float num33 = JGDHIPBGCFP.GGKMMLIFFDB[num32 * 2];
									float num34 = JGDHIPBGCFP.GGKMMLIFFDB[num32 * 2 + 1];
									float num35 = (!flag3) ? 0f : ((float)JGDHIPBGCFP.HQLMJHHPHQL * 0.1f * ((num15 - num16) / (float)JGDHIPBGCFP.HQLMJHHPHQL));
									EQINHIFFOGG.Add(new Vector3(num13 + num33 - num35, num16 + num34));
									EQINHIFFOGG.Add(new Vector3(num13 + num33 + num35, num15 + num34));
									EQINHIFFOGG.Add(new Vector3(num14 + num33 + num35, num15 + num34));
									EQINHIFFOGG.Add(new Vector3(num14 + num33 - num35, num16 + num34));
								}
							}
							if (flag4 || flag5)
							{
								JGDHIPBGCFP.OHCGMLEQEOI ohcgmleqeoi10 = JGDHIPBGCFP.GMFDPCIHHHM((!flag5) ? 95 : 45, emphiiopnhg);
								if (ohcgmleqeoi10 == null)
								{
									goto IL_10ED;
								}
								if (PICFCJNMJMC != null)
								{
									if (JGDHIPBGCFP.NFIBPOJMOCQ != null)
									{
										ohcgmleqeoi10.BHGJLHQBEKQ.x = rect.xMin + num5 * ohcgmleqeoi10.BHGJLHQBEKQ.x;
										ohcgmleqeoi10.EFFPLIOQGCE.x = rect.xMin + num5 * ohcgmleqeoi10.EFFPLIOQGCE.x;
										ohcgmleqeoi10.BHGJLHQBEKQ.y = rect.yMax - num6 * ohcgmleqeoi10.BHGJLHQBEKQ.y;
										ohcgmleqeoi10.EFFPLIOQGCE.y = rect.yMax - num6 * ohcgmleqeoi10.EFFPLIOQGCE.y;
									}
									float x = (ohcgmleqeoi10.BHGJLHQBEKQ.x + ohcgmleqeoi10.EFFPLIOQGCE.x) * 0.5f;
									int num36 = 0;
									int num37 = (!flag2) ? 1 : 4;
									while (num36 < num37)
									{
										PICFCJNMJMC.Add(new Vector2(x, ohcgmleqeoi10.BHGJLHQBEKQ.y));
										PICFCJNMJMC.Add(new Vector2(x, ohcgmleqeoi10.EFFPLIOQGCE.y));
										PICFCJNMJMC.Add(new Vector2(x, ohcgmleqeoi10.EFFPLIOQGCE.y));
										PICFCJNMJMC.Add(new Vector2(x, ohcgmleqeoi10.BHGJLHQBEKQ.y));
										num36++;
									}
								}
								if (flag && flag5)
								{
									num16 = (-num2 + ohcgmleqeoi10.OGBMILEIPHH.y) * 0.75f;
									num15 = (-num2 + ohcgmleqeoi10.EHCJCFGFJBD.y) * 0.75f;
								}
								else
								{
									num16 = -num2 + ohcgmleqeoi10.OGBMILEIPHH.y;
									num15 = -num2 + ohcgmleqeoi10.EHCJCFGFJBD.y;
								}
								if (flag2)
								{
									for (int num38 = 0; num38 < 4; num38++)
									{
										float num39 = JGDHIPBGCFP.GGKMMLIFFDB[num38 * 2];
										float num40 = JGDHIPBGCFP.GGKMMLIFFDB[num38 * 2 + 1];
										EQINHIFFOGG.Add(new Vector3(num10 + num39, num16 + num40));
										EQINHIFFOGG.Add(new Vector3(num10 + num39, num15 + num40));
										EQINHIFFOGG.Add(new Vector3(num + num39, num15 + num40));
										EQINHIFFOGG.Add(new Vector3(num + num39, num16 + num40));
									}
								}
								else
								{
									EQINHIFFOGG.Add(new Vector3(num10, num16));
									EQINHIFFOGG.Add(new Vector3(num10, num15));
									EQINHIFFOGG.Add(new Vector3(num, num15));
									EQINHIFFOGG.Add(new Vector3(num, num16));
								}
								if (JGDHIPBGCFP.JFQBHOFLBQG)
								{
									float num41 = num7 + ohcgmleqeoi10.OGBMILEIPHH.y / JGDHIPBGCFP.CNLNKDBIMDB;
									float num42 = num7 + ohcgmleqeoi10.EHCJCFGFJBD.y / JGDHIPBGCFP.CNLNKDBIMDB;
									num41 /= num7;
									num42 /= num7;
									JGDHIPBGCFP.CMHPEMDQNBD = Color.Lerp(a, b, num41);
									JGDHIPBGCFP.FQDHGCQQIFE = Color.Lerp(a, b, num42);
									int num43 = 0;
									int num44 = (!flag2) ? 1 : 4;
									while (num43 < num44)
									{
										HQOONBPDFHO.Add(JGDHIPBGCFP.CMHPEMDQNBD);
										HQOONBPDFHO.Add(JGDHIPBGCFP.FQDHGCQQIFE);
										HQOONBPDFHO.Add(JGDHIPBGCFP.FQDHGCQQIFE);
										HQOONBPDFHO.Add(JGDHIPBGCFP.CMHPEMDQNBD);
										num43++;
									}
								}
								else
								{
									int num45 = 0;
									int num46 = (!flag2) ? 4 : 16;
									while (num45 < num46)
									{
										HQOONBPDFHO.Add(color);
										num45++;
									}
								}
							}
							if (flag7)
							{
								flag2 = false;
							}
						}
					}
				}
			}
			IL_10ED:;
		}
		if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
		{
			JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 4);
			count = EQINHIFFOGG.Count;
		}
		JGDHIPBGCFP.DFDDMIJEBNH.CPLBKPNNHJG();
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0009E494 File Offset: 0x0009C694
	public static void QCQIMIPHMKG(string PIDLOFMIEFQ, List<Vector3> EQINHIFFOGG, List<int> NOGGFCDKLLJ)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			PIDLOFMIEFQ = " ";
		}
		JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = (float)JGDHIPBGCFP.HQLMJHHPHQL * JGDHIPBGCFP.CNLNKDBIMDB * 0.5f;
		int length = PIDLOFMIEFQ.Length;
		int count = EQINHIFFOGG.Count;
		int emphiiopnhg = 0;
		for (int i = 0; i < length; i++)
		{
			int num5 = (int)PIDLOFMIEFQ[i];
			EQINHIFFOGG.Add(new Vector3(num, -num2 - num4));
			NOGGFCDKLLJ.Add(i);
			if (num5 == 10)
			{
				if (num > num3)
				{
					num3 = num;
				}
				if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
				{
					JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 1);
					count = EQINHIFFOGG.Count;
				}
				num = 0f;
				num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
				emphiiopnhg = 0;
			}
			else if (num5 < 32)
			{
				emphiiopnhg = 0;
			}
			else if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else
			{
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				if (bmsymbol == null)
				{
					float num6 = JGDHIPBGCFP.QFDNOHJLEBO(num5, emphiiopnhg);
					if (num6 != 0f)
					{
						num6 += JGDHIPBGCFP.KPKBDNNKNGB;
						if (Mathf.RoundToInt(num + num6) > JGDHIPBGCFP.PPMHDQJHPLO)
						{
							if (num == 0f)
							{
								return;
							}
							if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
							{
								JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 1);
								count = EQINHIFFOGG.Count;
							}
							num = num6;
							num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
						}
						else
						{
							num += num6;
						}
						EQINHIFFOGG.Add(new Vector3(num, -num2 - num4));
						NOGGFCDKLLJ.Add(i + 1);
						emphiiopnhg = num5;
					}
				}
				else
				{
					float num7 = (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB + JGDHIPBGCFP.KPKBDNNKNGB;
					if (Mathf.RoundToInt(num + num7) > JGDHIPBGCFP.PPMHDQJHPLO)
					{
						if (num == 0f)
						{
							return;
						}
						if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
						{
							JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 1);
							count = EQINHIFFOGG.Count;
						}
						num = num7;
						num2 += JGDHIPBGCFP.HHDHKPIMKNQ;
					}
					else
					{
						num += num7;
					}
					EQINHIFFOGG.Add(new Vector3(num, -num2 - num4));
					NOGGFCDKLLJ.Add(i + 1);
					i += bmsymbol.sequence.Length - 1;
					emphiiopnhg = 0;
				}
			}
		}
		if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
		{
			JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num - JGDHIPBGCFP.KPKBDNNKNGB, 1);
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x0009E728 File Offset: 0x0009C928
	public static void KPJMMMIQDNB(string PIDLOFMIEFQ, List<Vector3> EQINHIFFOGG, List<int> NOGGFCDKLLJ)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			PIDLOFMIEFQ = " ";
		}
		JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
		float num = (float)JGDHIPBGCFP.HQLMJHHPHQL * JGDHIPBGCFP.CNLNKDBIMDB;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		int length = PIDLOFMIEFQ.Length;
		int count = EQINHIFFOGG.Count;
		int emphiiopnhg = 0;
		for (int i = 0; i < length; i++)
		{
			int num5 = (int)PIDLOFMIEFQ[i];
			if (num5 == 10)
			{
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
				{
					JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 2);
					count = EQINHIFFOGG.Count;
				}
				num2 = 0f;
				num3 += JGDHIPBGCFP.HHDHKPIMKNQ;
				emphiiopnhg = 0;
			}
			else if (num5 < 32)
			{
				emphiiopnhg = 0;
			}
			else if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else
			{
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				if (bmsymbol == null)
				{
					float num6 = JGDHIPBGCFP.QFDNOHJLEBO(num5, emphiiopnhg);
					if (num6 != 0f)
					{
						float num7 = num6 + JGDHIPBGCFP.KPKBDNNKNGB;
						if (Mathf.RoundToInt(num2 + num7) > JGDHIPBGCFP.PPMHDQJHPLO)
						{
							if (num2 == 0f)
							{
								return;
							}
							if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
							{
								JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 2);
								count = EQINHIFFOGG.Count;
							}
							num2 = 0f;
							num3 += JGDHIPBGCFP.HHDHKPIMKNQ;
							emphiiopnhg = 0;
							i--;
						}
						else
						{
							NOGGFCDKLLJ.Add(i);
							EQINHIFFOGG.Add(new Vector3(num2, -num3 - num));
							EQINHIFFOGG.Add(new Vector3(num2 + num7, -num3));
							emphiiopnhg = num5;
							num2 += num7;
						}
					}
				}
				else
				{
					float num8 = (float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB + JGDHIPBGCFP.KPKBDNNKNGB;
					if (Mathf.RoundToInt(num2 + num8) > JGDHIPBGCFP.PPMHDQJHPLO)
					{
						if (num2 == 0f)
						{
							return;
						}
						if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
						{
							JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 2);
							count = EQINHIFFOGG.Count;
						}
						num2 = 0f;
						num3 += JGDHIPBGCFP.HHDHKPIMKNQ;
						emphiiopnhg = 0;
						i--;
					}
					else
					{
						NOGGFCDKLLJ.Add(i);
						EQINHIFFOGG.Add(new Vector3(num2, -num3 - num));
						EQINHIFFOGG.Add(new Vector3(num2 + num8, -num3));
						i += bmsymbol.sequence.Length - 1;
						num2 += num8;
						emphiiopnhg = 0;
					}
				}
			}
		}
		if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && count < EQINHIFFOGG.Count)
		{
			JGDHIPBGCFP.JGEFOHEFEMB(EQINHIFFOGG, count, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 2);
		}
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x0009E9D8 File Offset: 0x0009CBD8
	public static void NCINCCJDLOM(string PIDLOFMIEFQ, int GBEBKHGGPKM, int QNDMNIDPICH, List<Vector3> GFEONCKBDBC, List<Vector3> FOGFQQEMIIB)
	{
		if (string.IsNullOrEmpty(PIDLOFMIEFQ))
		{
			PIDLOFMIEFQ = " ";
		}
		JGDHIPBGCFP.DFLOLMMCGID(PIDLOFMIEFQ);
		int num = QNDMNIDPICH;
		if (GBEBKHGGPKM > QNDMNIDPICH)
		{
			QNDMNIDPICH = GBEBKHGGPKM;
			GBEBKHGGPKM = num;
		}
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = (float)JGDHIPBGCFP.HQLMJHHPHQL * JGDHIPBGCFP.CNLNKDBIMDB;
		int qgiimlncllo = (GFEONCKBDBC == null) ? 0 : GFEONCKBDBC.Count;
		int num6 = (FOGFQQEMIIB == null) ? 0 : FOGFQQEMIIB.Count;
		int length = PIDLOFMIEFQ.Length;
		int i = 0;
		int emphiiopnhg = 0;
		bool flag = false;
		bool flag2 = false;
		Vector2 zero = Vector2.zero;
		Vector2 zero2 = Vector2.zero;
		while (i < length)
		{
			if (GFEONCKBDBC != null && !flag2 && num <= i)
			{
				flag2 = true;
				GFEONCKBDBC.Add(new Vector3(num2 - 1f, -num3 - num5));
				GFEONCKBDBC.Add(new Vector3(num2 - 1f, -num3));
				GFEONCKBDBC.Add(new Vector3(num2 + 1f, -num3));
				GFEONCKBDBC.Add(new Vector3(num2 + 1f, -num3 - num5));
			}
			int num7 = (int)PIDLOFMIEFQ[i];
			if (num7 == 10)
			{
				if (num2 > num4)
				{
					num4 = num2;
				}
				if (GFEONCKBDBC != null && flag2)
				{
					if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
					{
						JGDHIPBGCFP.JGEFOHEFEMB(GFEONCKBDBC, qgiimlncllo, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
					}
					GFEONCKBDBC = null;
				}
				if (FOGFQQEMIIB != null)
				{
					if (flag)
					{
						flag = false;
						FOGFQQEMIIB.Add(zero2);
						FOGFQQEMIIB.Add(zero);
					}
					else if (GBEBKHGGPKM <= i && QNDMNIDPICH > i)
					{
						FOGFQQEMIIB.Add(new Vector3(num2, -num3 - num5));
						FOGFQQEMIIB.Add(new Vector3(num2, -num3));
						FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3));
						FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3 - num5));
					}
					if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && num6 < FOGFQQEMIIB.Count)
					{
						JGDHIPBGCFP.JGEFOHEFEMB(FOGFQQEMIIB, num6, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
						num6 = FOGFQQEMIIB.Count;
					}
				}
				num2 = 0f;
				num3 += JGDHIPBGCFP.HHDHKPIMKNQ;
				emphiiopnhg = 0;
			}
			else if (num7 < 32)
			{
				emphiiopnhg = 0;
			}
			else if (JGDHIPBGCFP.CKGCLBODNNJ && JGDHIPBGCFP.HPJPOIOHCFQ(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else if (JGDHIPBGCFP.JMNPJNODKLH(PIDLOFMIEFQ, ref i))
			{
				i--;
			}
			else
			{
				BMSymbol bmsymbol = (!JGDHIPBGCFP.OPBBHFJNIPG) ? null : JGDHIPBGCFP.CHLPMCCFDPP(PIDLOFMIEFQ, i, length);
				float num8 = (bmsymbol == null) ? JGDHIPBGCFP.QFDNOHJLEBO(num7, emphiiopnhg) : ((float)bmsymbol.advance * JGDHIPBGCFP.CNLNKDBIMDB);
				if (num8 != 0f)
				{
					float num9 = num2;
					float num10 = num2 + num8;
					float num11 = -num3 - num5;
					float num12 = -num3;
					if (Mathf.RoundToInt(num10 + JGDHIPBGCFP.KPKBDNNKNGB) > JGDHIPBGCFP.PPMHDQJHPLO)
					{
						if (num2 == 0f)
						{
							return;
						}
						if (num2 > num4)
						{
							num4 = num2;
						}
						if (GFEONCKBDBC != null && flag2)
						{
							if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
							{
								JGDHIPBGCFP.JGEFOHEFEMB(GFEONCKBDBC, qgiimlncllo, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
							}
							GFEONCKBDBC = null;
						}
						if (FOGFQQEMIIB != null)
						{
							if (flag)
							{
								flag = false;
								FOGFQQEMIIB.Add(zero2);
								FOGFQQEMIIB.Add(zero);
							}
							else if (GBEBKHGGPKM <= i && QNDMNIDPICH > i)
							{
								FOGFQQEMIIB.Add(new Vector3(num2, -num3 - num5));
								FOGFQQEMIIB.Add(new Vector3(num2, -num3));
								FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3));
								FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3 - num5));
							}
							if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && num6 < FOGFQQEMIIB.Count)
							{
								JGDHIPBGCFP.JGEFOHEFEMB(FOGFQQEMIIB, num6, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
								num6 = FOGFQQEMIIB.Count;
							}
						}
						num9 -= num2;
						num10 -= num2;
						num11 -= JGDHIPBGCFP.HHDHKPIMKNQ;
						num12 -= JGDHIPBGCFP.HHDHKPIMKNQ;
						num2 = 0f;
						num3 += JGDHIPBGCFP.HHDHKPIMKNQ;
					}
					num2 += num8 + JGDHIPBGCFP.KPKBDNNKNGB;
					if (FOGFQQEMIIB != null)
					{
						if (GBEBKHGGPKM <= i && QNDMNIDPICH > i)
						{
							if (!flag)
							{
								flag = true;
								FOGFQQEMIIB.Add(new Vector3(num9, num11));
								FOGFQQEMIIB.Add(new Vector3(num9, num12));
							}
						}
						else if (flag)
						{
							flag = false;
							FOGFQQEMIIB.Add(zero2);
							FOGFQQEMIIB.Add(zero);
						}
					}
					zero = new Vector2(num10, num11);
					zero2 = new Vector2(num10, num12);
					emphiiopnhg = num7;
				}
			}
			i++;
		}
		if (GFEONCKBDBC != null)
		{
			if (!flag2)
			{
				GFEONCKBDBC.Add(new Vector3(num2 - 1f, -num3 - num5));
				GFEONCKBDBC.Add(new Vector3(num2 - 1f, -num3));
				GFEONCKBDBC.Add(new Vector3(num2 + 1f, -num3));
				GFEONCKBDBC.Add(new Vector3(num2 + 1f, -num3 - num5));
			}
			if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left)
			{
				JGDHIPBGCFP.JGEFOHEFEMB(GFEONCKBDBC, qgiimlncllo, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
			}
		}
		if (FOGFQQEMIIB != null)
		{
			if (flag)
			{
				FOGFQQEMIIB.Add(zero2);
				FOGFQQEMIIB.Add(zero);
			}
			else if (GBEBKHGGPKM < i && QNDMNIDPICH == i)
			{
				FOGFQQEMIIB.Add(new Vector3(num2, -num3 - num5));
				FOGFQQEMIIB.Add(new Vector3(num2, -num3));
				FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3));
				FOGFQQEMIIB.Add(new Vector3(num2 + 2f, -num3 - num5));
			}
			if (JGDHIPBGCFP.PBHNPKNJNJH != JGDHIPBGCFP.MNMQCONMCFH.Left && num6 < FOGFQQEMIIB.Count)
			{
				JGDHIPBGCFP.JGEFOHEFEMB(FOGFQQEMIIB, num6, num2 - JGDHIPBGCFP.KPKBDNNKNGB, 4);
			}
		}
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x0009EF40 File Offset: 0x0009D140
	public static bool PEBDCBIEDDB(ref string PIDLOFMIEFQ, ref int IIHDGMLHICI, string LHLDLMKJLKE)
	{
		if (IIHDGMLHICI == -1)
		{
			return false;
		}
		IIHDGMLHICI = PIDLOFMIEFQ.IndexOf(LHLDLMKJLKE, IIHDGMLHICI);
		if (IIHDGMLHICI == -1)
		{
			return false;
		}
		int num = IIHDGMLHICI + LHLDLMKJLKE.Length;
		int num2 = PIDLOFMIEFQ.IndexOf(' ', num);
		if (num2 == -1)
		{
			num2 = PIDLOFMIEFQ.Length;
		}
		int num3 = PIDLOFMIEFQ.IndexOfAny(new char[]
		{
			'/',
			' '
		}, num);
		if (num3 != -1)
		{
			if (num3 != num)
			{
				string text = PIDLOFMIEFQ.Substring(0, IIHDGMLHICI);
				string text2 = PIDLOFMIEFQ.Substring(IIHDGMLHICI, num2 - IIHDGMLHICI);
				string str = PIDLOFMIEFQ.Substring(num2);
				string text3 = PIDLOFMIEFQ.Substring(num, num3 - num);
				PIDLOFMIEFQ = string.Concat(new string[]
				{
					text,
					"[url=",
					text2,
					"][u]",
					text3,
					"[/u][/url]"
				});
				IIHDGMLHICI = PIDLOFMIEFQ.Length;
				PIDLOFMIEFQ += str;
				return true;
			}
		}
		IIHDGMLHICI += 7;
		return true;
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x0009F030 File Offset: 0x0009D230
	public static bool MOLJMGQKIJM(ref string PIDLOFMIEFQ, ref int IIHDGMLHICI, string JEQHLJDJEJJ, string KBPPOQHQGBG)
	{
		int num = PIDLOFMIEFQ.IndexOf(JEQHLJDJEJJ, IIHDGMLHICI, StringComparison.CurrentCultureIgnoreCase);
		if (num == -1)
		{
			return false;
		}
		string str = PIDLOFMIEFQ.Substring(0, num);
		string str2 = "[url=" + KBPPOQHQGBG + "][u]";
		string str3 = PIDLOFMIEFQ.Substring(num, JEQHLJDJEJJ.Length) + "[/u][/url]";
		string str4 = PIDLOFMIEFQ.Substring(num + JEQHLJDJEJJ.Length);
		PIDLOFMIEFQ = str + str2 + str3;
		IIHDGMLHICI = PIDLOFMIEFQ.Length;
		PIDLOFMIEFQ += str4;
		return true;
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x0009F0B4 File Offset: 0x0009D2B4
	public static void BDKHHNMMPCP(ref string PIDLOFMIEFQ)
	{
		int num = 0;
		while (num < PIDLOFMIEFQ.Length && JGDHIPBGCFP.PEBDCBIEDDB(ref PIDLOFMIEFQ, ref num, "http://"))
		{
		}
		int num2 = 0;
		while (num2 < PIDLOFMIEFQ.Length && JGDHIPBGCFP.PEBDCBIEDDB(ref PIDLOFMIEFQ, ref num2, "https://"))
		{
		}
	}

	// Token: 0x040003D5 RID: 981
	public static KGKLCNDOLMP NFIBPOJMOCQ;

	// Token: 0x040003D6 RID: 982
	public static Font KDDNGBFFFJL;

	// Token: 0x040003D7 RID: 983
	public static JGDHIPBGCFP.OHCGMLEQEOI HCEKGHFEQQQ = new JGDHIPBGCFP.OHCGMLEQEOI();

	// Token: 0x040003D8 RID: 984
	public static int HQLMJHHPHQL = 16;

	// Token: 0x040003D9 RID: 985
	public static float CNLNKDBIMDB = 1f;

	// Token: 0x040003DA RID: 986
	public static float OOBHQPCDCPD = 1f;

	// Token: 0x040003DB RID: 987
	public static FontStyle GOIMOQJFMHE = FontStyle.Normal;

	// Token: 0x040003DC RID: 988
	public static JGDHIPBGCFP.MNMQCONMCFH PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;

	// Token: 0x040003DD RID: 989
	public static Color BLEDJGLIIPF = Color.white;

	// Token: 0x040003DE RID: 990
	public static int JQGIJOFBHME = 1000000;

	// Token: 0x040003DF RID: 991
	public static int ECQBIIGPJQO = 1000000;

	// Token: 0x040003E0 RID: 992
	public static int PPMHDQJHPLO = 1000000;

	// Token: 0x040003E1 RID: 993
	public static int NNHJHLOFKFD = 1000000;

	// Token: 0x040003E2 RID: 994
	public static int BPIPFOJNJCQ = 0;

	// Token: 0x040003E3 RID: 995
	public static bool JFQBHOFLBQG = false;

	// Token: 0x040003E4 RID: 996
	public static Color QEQOQOOCEEN = Color.white;

	// Token: 0x040003E5 RID: 997
	public static Color MBCPMFDMEEQ = Color.white;

	// Token: 0x040003E6 RID: 998
	public static bool CKGCLBODNNJ = false;

	// Token: 0x040003E7 RID: 999
	public static float MOQHNNIINFL = 0f;

	// Token: 0x040003E8 RID: 1000
	public static float MNNBBPGPNJF = 0f;

	// Token: 0x040003E9 RID: 1001
	public static bool NFLEOLEGPJJ = false;

	// Token: 0x040003EA RID: 1002
	public static JGDHIPBGCFP.OQGGLOQFNPE FJPNBPJQODQ;

	// Token: 0x040003EB RID: 1003
	public static int FIDDHHCOCCD = 0;

	// Token: 0x040003EC RID: 1004
	public static float KPKBDNNKNGB = 0f;

	// Token: 0x040003ED RID: 1005
	public static float HHDHKPIMKNQ = 0f;

	// Token: 0x040003EE RID: 1006
	public static float EELNNICDOIM = 0f;

	// Token: 0x040003EF RID: 1007
	public static bool OPBBHFJNIPG = false;

	// Token: 0x040003F0 RID: 1008
	private static MDBOHBDKMMM LPEGECBMQKQ;

	// Token: 0x040003F1 RID: 1009
	private static Color FCFJNDNJCPP = new Color(0f, 0f, 0f, 0f);

	// Token: 0x040003F2 RID: 1010
	private static MHIDKMCBQEN<Color> DFDDMIJEBNH = new MHIDKMCBQEN<Color>();

	// Token: 0x040003F3 RID: 1011
	private static float KELMMNHOKKB = 1f;

	// Token: 0x040003F4 RID: 1012
	private static CharacterInfo PQHKNKENHHK;

	// Token: 0x040003F5 RID: 1013
	private static MHIDKMCBQEN<float> QHLHLMJDIIG = new MHIDKMCBQEN<float>();

	// Token: 0x040003F6 RID: 1014
	private static Color CMHPEMDQNBD;

	// Token: 0x040003F7 RID: 1015
	private static Color FQDHGCQQIFE;

	// Token: 0x040003F8 RID: 1016
	private static float[] GGKMMLIFFDB = new float[]
	{
		-0.25f,
		0f,
		0.25f,
		0f,
		0f,
		-0.25f,
		0f,
		0.25f
	};

	// Token: 0x040003F9 RID: 1017
	[CompilerGenerated]
	private static Dictionary<string, int> EKLGQDCMGFK;

	// Token: 0x040003FA RID: 1018
	[CompilerGenerated]
	private static Dictionary<string, int> HNLQCOGOBBL;

	// Token: 0x040003FB RID: 1019
	[CompilerGenerated]
	private static Dictionary<string, int> NELNICFNMIJ;

	// Token: 0x020000A5 RID: 165
	public enum MNMQCONMCFH
	{
		// Token: 0x040003FD RID: 1021
		Automatic,
		// Token: 0x040003FE RID: 1022
		Left,
		// Token: 0x040003FF RID: 1023
		Center,
		// Token: 0x04000400 RID: 1024
		Right,
		// Token: 0x04000401 RID: 1025
		Justified
	}

	// Token: 0x020000A6 RID: 166
	public enum OQGGLOQFNPE
	{
		// Token: 0x04000403 RID: 1027
		None,
		// Token: 0x04000404 RID: 1028
		Normal,
		// Token: 0x04000405 RID: 1029
		Colored
	}

	// Token: 0x020000A7 RID: 167
	public class OHCGMLEQEOI
	{
		// Token: 0x04000406 RID: 1030
		public Vector2 OGBMILEIPHH;

		// Token: 0x04000407 RID: 1031
		public Vector2 EHCJCFGFJBD;

		// Token: 0x04000408 RID: 1032
		public Vector2 BHGJLHQBEKQ;

		// Token: 0x04000409 RID: 1033
		public Vector2 OCHQODGHQCQ;

		// Token: 0x0400040A RID: 1034
		public Vector2 EFFPLIOQGCE;

		// Token: 0x0400040B RID: 1035
		public Vector2 HNJHCBLKDHK;

		// Token: 0x0400040C RID: 1036
		public float BNEBCKEPNNM;

		// Token: 0x0400040D RID: 1037
		public int NHNMIFPINDL;
	}
}
