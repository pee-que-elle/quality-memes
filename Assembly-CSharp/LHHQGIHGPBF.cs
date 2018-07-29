using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200033B RID: 827
public class LHHQGIHGPBF
{
	// Token: 0x06006D5C RID: 27996 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB KQHGEFPCJJG()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D5D RID: 27997 RVA: 0x000287C6 File Offset: 0x000269C6
	public FHJJBLNPJBI JIMKEJFDLME()
	{
		return this.PGIKGPCKFJL;
	}

	// Token: 0x06006D5E RID: 27998 RVA: 0x00355CD4 File Offset: 0x00353ED4
	private void KHEKQQMHLMF(Vector3 FFENCEGBGFL, ref Vector3 DFGFEPLFEPD, ref bool EEQJLCGQDOC, ref bool BIQKIGHHJLM, float NFGJDGEGLPE, float HNKPFNHBHGK)
	{
		Vector3 vector = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition), this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition));
		Vector3 normalized = (FFENCEGBGFL - vector).normalized;
		float num = (FFENCEGBGFL - vector).magnitude + 325f + 542f;
		this.KPLPMLCQBGO(vector, normalized * num, Color.yellow, 1551f);
		if (Physics.Raycast(vector, normalized, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
		{
			if (Mathf.Abs(this.FKGNBCKJPQO(this.NHFFPIPBGMJ.normal)) > Mathf.Abs(this.JNBBJCLFFBB(this.NHFFPIPBGMJ.normal)))
			{
				EEQJLCGQDOC = BIQKIGHHJLM;
				if (this.FKGNBCKJPQO(DFGFEPLFEPD) == 1489f)
				{
					float arg = 373f * NFGJDGEGLPE;
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg, this.JNBBJCLFFBB(DFGFEPLFEPD));
					float arg2 = this.FCCGCKIJCIO(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg2, this.JNBBJCLFFBB(DFGFEPLFEPD));
				}
			}
			else
			{
				BIQKIGHHJLM = EEQJLCGQDOC;
				if (this.JNBBJCLFFBB(DFGFEPLFEPD) == 232f)
				{
					float arg3 = 1023f * HNKPFNHBHGK;
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg3);
					float arg4 = this.DENGKEOOJMM(this.JNBBJCLFFBB(DFGFEPLFEPD), true);
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg4);
				}
			}
		}
		else
		{
			EEQJLCGQDOC = false;
			BIQKIGHHJLM = false;
		}
	}

	// Token: 0x06006D5F RID: 27999 RVA: 0x00355EE0 File Offset: 0x003540E0
	private float LCQOCMLNQII(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 1489f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 1641f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = 1024f;
		bool flag2 = true;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 1; i < num3; i += 0)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 1900f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 1))
				{
					num5 -= 1872f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 600f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 1))
				{
					num4 -= 854f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.NBGKGPOKPFC(vector2, vector * num, Color.red, 879f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = true;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 627f : 940f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 1813f : 60f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.ECKEGGKEOOG(vector2, vector * num, Color.cyan, 706f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006D60 RID: 28000 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float LLFMCPGEJLK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D61 RID: 28001 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB PDJMDGFKGDD()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D62 RID: 28002 RVA: 0x000287CE File Offset: 0x000269CE
	private static Vector3 NGHCJMNEEDK(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, 952f);
	}

	// Token: 0x06006D63 RID: 28003 RVA: 0x00356284 File Offset: 0x00354484
	private void BQDIKFLIGMK(Vector3 FFENCEGBGFL, ref Vector3 DFGFEPLFEPD, ref bool EEQJLCGQDOC, ref bool BIQKIGHHJLM, float NFGJDGEGLPE, float HNKPFNHBHGK)
	{
		Vector3 vector = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition), this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition));
		Vector3 normalized = (FFENCEGBGFL - vector).normalized;
		float num = (FFENCEGBGFL - vector).magnitude + 1853f + 276f;
		this.GGLKBFQFENG(vector, normalized * num, Color.yellow, 577f);
		if (Physics.Raycast(vector, normalized, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
		{
			if (Mathf.Abs(this.FKGNBCKJPQO(this.NHFFPIPBGMJ.normal)) > Mathf.Abs(this.JNBBJCLFFBB(this.NHFFPIPBGMJ.normal)))
			{
				EEQJLCGQDOC = BIQKIGHHJLM;
				if (this.FKGNBCKJPQO(DFGFEPLFEPD) == 1338f)
				{
					float arg = 1779f * NFGJDGEGLPE;
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg, this.JNBBJCLFFBB(DFGFEPLFEPD));
					float arg2 = this.LMONQFNBHEL(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg2, this.JNBBJCLFFBB(DFGFEPLFEPD));
				}
			}
			else
			{
				BIQKIGHHJLM = !EEQJLCGQDOC;
				if (this.JNBBJCLFFBB(DFGFEPLFEPD) == 570f)
				{
					float arg3 = 195f * HNKPFNHBHGK;
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg3);
					float arg4 = this.LMONQFNBHEL(this.JNBBJCLFFBB(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg4);
				}
			}
		}
		else
		{
			EEQJLCGQDOC = true;
			BIQKIGHHJLM = false;
		}
	}

	// Token: 0x06006D64 RID: 28004 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float QLIQCKCJLBE(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D65 RID: 28005 RVA: 0x000287DC File Offset: 0x000269DC
	private void MJEJMLDNEFK(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1037f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D66 RID: 28006 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float LONPEDNNELI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D67 RID: 28007 RVA: 0x000285BD File Offset: 0x000267BD
	private static float HEJQJENGIQN(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D68 RID: 28008 RVA: 0x000285BD File Offset: 0x000267BD
	private static float BMHGMQQGMGP(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D69 RID: 28009 RVA: 0x000285E7 File Offset: 0x000267E7
	[CompilerGenerated]
	private static Vector3 HCHBEMIBEBL(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 0f, ECFKEFOFQGB);
	}

	// Token: 0x06006D6A RID: 28010 RVA: 0x00356490 File Offset: 0x00354690
	private void PBFQHQPEGOF()
	{
		this.PGIKGPCKFJL.DDFMHKCBLHK = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 1797f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 429f);
		this.PGIKGPCKFJL.INHEHFIEEDC = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 872f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 269f);
		this.PGIKGPCKFJL.IDDJBHLOGII = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 876f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 665f);
		this.PGIKGPCKFJL.HICNEJCDKPP = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 1609f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 1492f);
		this.NMFLIGCGDOG = this.GDEOGKEKCPG.x / (float)(this.HGGIDMFLFFG - 0);
		this.DKFDBQLBNCI = this.GDEOGKEKCPG.y / (float)(this.OQFBIKQMFMN - 1);
	}

	// Token: 0x06006D6B RID: 28011 RVA: 0x000287FB File Offset: 0x000269FB
	private static Vector3 GOLEPLIJCBG(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(363f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D6C RID: 28012 RVA: 0x000285BD File Offset: 0x000267BD
	private static float KBHEMMIHEQC(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D6D RID: 28013 RVA: 0x0035666C File Offset: 0x0035486C
	public Vector3 CNLKEOICCGC(Vector3 DFGFEPLFEPD)
	{
		this.PBFQHQPEGOF();
		this.HKFIBKLCIPH(this.PGIKGPCKFJL.INHEHFIEEDC, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.QBFJQOQIKEF, ref this.KNDBMCDFKJB.GDLOHNNDPNO, 438f, 518f);
		this.KHEKQQMHLMF(this.PGIKGPCKFJL.DDFMHKCBLHK, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.POFMJIEBOGK, ref this.KNDBMCDFKJB.QINPGCPDEFQ, 658f, 1209f);
		this.FCBMIEFHJQH(this.PGIKGPCKFJL.HICNEJCDKPP, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.PPOEIDHJIMQ, ref this.KNDBMCDFKJB.NEIHPFHLNNO, 764f, 1185f);
		this.FCBMIEFHJQH(this.PGIKGPCKFJL.IDDJBHLOGII, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.DCLGCQQOCBJ, ref this.KNDBMCDFKJB.DJPFPJIDOFN, 929f, 738f);
		float arg = 1996f;
		if (this.FKGNBCKJPQO(DFGFEPLFEPD) != 590f)
		{
			arg = this.LMONQFNBHEL(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
		}
		float arg2 = 1437f;
		if (this.JNBBJCLFFBB(DFGFEPLFEPD) != 1717f)
		{
			arg2 = this.FCCGCKIJCIO(this.JNBBJCLFFBB(DFGFEPLFEPD), true);
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006D6E RID: 28014 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float JGNIQNDJIHI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D6F RID: 28015 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float CPHCODQEBGB(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D70 RID: 28016 RVA: 0x00028809 File Offset: 0x00026A09
	private void BPDLLHPEJFK(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 0f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D71 RID: 28017 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB MFNGIKQFJPQ()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D72 RID: 28018 RVA: 0x00028828 File Offset: 0x00026A28
	private void NBGKGPOKPFC(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1595f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D73 RID: 28019 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float CHIDCIJQBHI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D74 RID: 28020 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB GKPJCFLGNIB()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D75 RID: 28021 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float PIJOLKDIHCQ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D76 RID: 28022 RVA: 0x000285BD File Offset: 0x000267BD
	private static float JBGEHQIJQBM(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D77 RID: 28023 RVA: 0x003567B4 File Offset: 0x003549B4
	private float CGGGGKKFDMD(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 0f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 0.2f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = float.NegativeInfinity;
		bool flag2 = false;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 0; i < num3; i++)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 0.2f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 1) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 1))
				{
					num5 -= 0.2f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 0.2f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 1) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 1))
				{
					num4 -= 0.2f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.BPDLLHPEJFK(vector2, vector * num, Color.red, 0f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = true;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 0.2f : -0.2f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 0.2f : -0.2f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.BPDLLHPEJFK(vector2, vector * num, Color.cyan, 0f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006D78 RID: 28024 RVA: 0x00028847 File Offset: 0x00026A47
	private void ECKEGGKEOOG(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1696f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D79 RID: 28025 RVA: 0x000285FF File Offset: 0x000267FF
	[CompilerGenerated]
	private static Vector3 OJFIBJDFFQF(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(0f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D7A RID: 28026 RVA: 0x000285BD File Offset: 0x000267BD
	private static float HDEFQQEEPHQ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D7B RID: 28027 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float CGKGCHMKJFK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x06006D7C RID: 28028 RVA: 0x000287C6 File Offset: 0x000269C6
	public FHJJBLNPJBI CBEHOBCNOML
	{
		get
		{
			return this.PGIKGPCKFJL;
		}
	}

	// Token: 0x06006D7D RID: 28029 RVA: 0x00356B58 File Offset: 0x00354D58
	private float FCCGCKIJCIO(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 397f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 648f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = 443f;
		bool flag2 = false;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 0; i < num3; i++)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 1573f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 1))
				{
					num5 -= 954f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 1951f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 1) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 0))
				{
					num4 -= 930f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.GGLKBFQFENG(vector2, vector * num, Color.red, 1781f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = true;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 505f : 390f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 1509f : 1659f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.MJEJMLDNEFK(vector2, vector * num, Color.cyan, 1052f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006D7E RID: 28030 RVA: 0x000285BD File Offset: 0x000267BD
	private static float FDMMNPHQELH(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D7F RID: 28031 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB ENBIFBECFDN()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D80 RID: 28032 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB QGBQPPDMDDC()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D81 RID: 28033 RVA: 0x000285BD File Offset: 0x000267BD
	private static float EJFJPMKOLQQ(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D82 RID: 28034 RVA: 0x00028866 File Offset: 0x00026A66
	private static Vector3 BHCBGQGDKKF(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(1491f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D83 RID: 28035 RVA: 0x00356EFC File Offset: 0x003550FC
	private void FCBMIEFHJQH(Vector3 FFENCEGBGFL, ref Vector3 DFGFEPLFEPD, ref bool EEQJLCGQDOC, ref bool BIQKIGHHJLM, float NFGJDGEGLPE, float HNKPFNHBHGK)
	{
		Vector3 vector = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition), this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition));
		Vector3 normalized = (FFENCEGBGFL - vector).normalized;
		float num = (FFENCEGBGFL - vector).magnitude + 1247f + 1504f;
		this.KPLPMLCQBGO(vector, normalized * num, Color.yellow, 1649f);
		if (Physics.Raycast(vector, normalized, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
		{
			if (Mathf.Abs(this.FKGNBCKJPQO(this.NHFFPIPBGMJ.normal)) > Mathf.Abs(this.JNBBJCLFFBB(this.NHFFPIPBGMJ.normal)))
			{
				EEQJLCGQDOC = BIQKIGHHJLM;
				if (this.FKGNBCKJPQO(DFGFEPLFEPD) == 1220f)
				{
					float arg = 1961f * NFGJDGEGLPE;
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg, this.JNBBJCLFFBB(DFGFEPLFEPD));
					float arg2 = this.FCCGCKIJCIO(this.FKGNBCKJPQO(DFGFEPLFEPD), true);
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg2, this.JNBBJCLFFBB(DFGFEPLFEPD));
				}
			}
			else
			{
				BIQKIGHHJLM = !EEQJLCGQDOC;
				if (this.JNBBJCLFFBB(DFGFEPLFEPD) == 945f)
				{
					float arg3 = 1568f * HNKPFNHBHGK;
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg3);
					float arg4 = this.FCCGCKIJCIO(this.JNBBJCLFFBB(DFGFEPLFEPD), true);
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg4);
				}
			}
		}
		else
		{
			EEQJLCGQDOC = true;
			BIQKIGHHJLM = false;
		}
	}

	// Token: 0x06006D84 RID: 28036 RVA: 0x00028874 File Offset: 0x00026A74
	private void EQIOCQFGHCF(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1241f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D85 RID: 28037 RVA: 0x00028893 File Offset: 0x00026A93
	private static Vector3 LQMCGPKDPGO(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, 452f);
	}

	// Token: 0x06006D86 RID: 28038 RVA: 0x000285BD File Offset: 0x000267BD
	private static float MHQNJCNMFLI(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D87 RID: 28039 RVA: 0x00357108 File Offset: 0x00355308
	private void NHEKPCBKFFE()
	{
		this.PGIKGPCKFJL.DDFMHKCBLHK = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 342f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 527f);
		this.PGIKGPCKFJL.INHEHFIEEDC = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 898f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 713f);
		this.PGIKGPCKFJL.IDDJBHLOGII = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 536f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 1604f);
		this.PGIKGPCKFJL.HICNEJCDKPP = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 181f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 1427f);
		this.NMFLIGCGDOG = this.GDEOGKEKCPG.x / (float)(this.HGGIDMFLFFG - 1);
		this.DKFDBQLBNCI = this.GDEOGKEKCPG.y / (float)(this.OQFBIKQMFMN - 1);
	}

	// Token: 0x06006D88 RID: 28040 RVA: 0x000285CF File Offset: 0x000267CF
	[CompilerGenerated]
	private static Vector3 GDMMPIJFEFN(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, ECFKEFOFQGB, 0f);
	}

	// Token: 0x06006D89 RID: 28041 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float NFJQEFDGMPK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D8A RID: 28042 RVA: 0x003572E4 File Offset: 0x003554E4
	private float DENGKEOOJMM(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 37f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 416f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = 97f;
		bool flag2 = true;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 1; i < num3; i += 0)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 802f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 1))
				{
					num5 -= 1100f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 1780f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 0))
				{
					num4 -= 559f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.BPDLLHPEJFK(vector2, vector * num, Color.red, 1741f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = true;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 1834f : 1764f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 1515f : 1020f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.KPLPMLCQBGO(vector2, vector * num, Color.cyan, 1752f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006D8B RID: 28043 RVA: 0x000288A1 File Offset: 0x00026AA1
	private static Vector3 MJJLIJBLIPD(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 1945f, ECFKEFOFQGB);
	}

	// Token: 0x06006D8C RID: 28044 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float FONLMFDCKHK(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D8D RID: 28045 RVA: 0x00357688 File Offset: 0x00355888
	public Vector3 DFMMCLFKFBH(Vector3 DFGFEPLFEPD)
	{
		this.LDDCPKQIFIO();
		this.CCEPMJKICPB(this.PGIKGPCKFJL.INHEHFIEEDC, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.QBFJQOQIKEF, ref this.KNDBMCDFKJB.GDLOHNNDPNO, -1f, -1f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.DDFMHKCBLHK, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.POFMJIEBOGK, ref this.KNDBMCDFKJB.QINPGCPDEFQ, 1f, -1f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.HICNEJCDKPP, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.PPOEIDHJIMQ, ref this.KNDBMCDFKJB.NEIHPFHLNNO, -1f, 1f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.IDDJBHLOGII, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.DCLGCQQOCBJ, ref this.KNDBMCDFKJB.DJPFPJIDOFN, 1f, 1f);
		float arg = 0f;
		if (this.FKGNBCKJPQO(DFGFEPLFEPD) != 0f)
		{
			arg = this.CGGGGKKFDMD(this.FKGNBCKJPQO(DFGFEPLFEPD), true);
		}
		float arg2 = 0f;
		if (this.JNBBJCLFFBB(DFGFEPLFEPD) != 0f)
		{
			arg2 = this.CGGGGKKFDMD(this.JNBBJCLFFBB(DFGFEPLFEPD), false);
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006D8E RID: 28046 RVA: 0x003577D0 File Offset: 0x003559D0
	private float LMONQFNBHEL(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 94f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 433f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = 1036f;
		bool flag2 = true;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 0; i < num3; i += 0)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 1658f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 0))
				{
					num5 -= 1f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 1101f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 1))
				{
					num4 -= 1334f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.HJQFQNJNGIN(vector2, vector * num, Color.red, 1305f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = false;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 150f : 1565f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 497f : 1538f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.MJEJMLDNEFK(vector2, vector * num, Color.cyan, 438f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006D8F RID: 28047 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float PNPIHQJMEQN(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D90 RID: 28048 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float PDECLGHJEMM(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D91 RID: 28049 RVA: 0x000288AF File Offset: 0x00026AAF
	private static Vector3 FEPDNJQHPJE(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(1268f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D92 RID: 28050 RVA: 0x000288BD File Offset: 0x00026ABD
	private static Vector3 FGKNMEHFFGP(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(674f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D93 RID: 28051 RVA: 0x000287C6 File Offset: 0x000269C6
	public FHJJBLNPJBI DPQFFPBFEEI()
	{
		return this.PGIKGPCKFJL;
	}

	// Token: 0x06006D94 RID: 28052 RVA: 0x00357B74 File Offset: 0x00355D74
	public LHHQGIHGPBF(GNKDCOHMFEG NMEEIDOKCHB)
	{
		this.HOJOJPJNLGK = NMEEIDOKCHB;
		CDLKIQJJHKE mllmoqqnkmc = this.HOJOJPJNLGK.MLLMOQQNKMC;
		if (mllmoqqnkmc != CDLKIQJJHKE.XY)
		{
			if (mllmoqqnkmc != CDLKIQJJHKE.XZ)
			{
				if (mllmoqqnkmc == CDLKIQJJHKE.YZ)
				{
					if (LHHQGIHGPBF.OEPCQKQDIJD == null)
					{
						LHHQGIHGPBF.OEPCQKQDIJD = new Func<Vector3, float>(LHHQGIHGPBF.CNGNGDBMGKN);
					}
					this.FKGNBCKJPQO = LHHQGIHGPBF.OEPCQKQDIJD;
					if (LHHQGIHGPBF.MMPJPDBKOOM == null)
					{
						LHHQGIHGPBF.MMPJPDBKOOM = new Func<Vector3, float>(LHHQGIHGPBF.BIHHMNNPJBO);
					}
					this.JNBBJCLFFBB = LHHQGIHGPBF.MMPJPDBKOOM;
					if (LHHQGIHGPBF.EQLOFOGBJIO == null)
					{
						LHHQGIHGPBF.EQLOFOGBJIO = new Func<float, float, Vector3>(LHHQGIHGPBF.OJFIBJDFFQF);
					}
					this.QMEMFMDBHLI = LHHQGIHGPBF.EQLOFOGBJIO;
				}
			}
			else
			{
				if (LHHQGIHGPBF.FFMGNIDNMII == null)
				{
					LHHQGIHGPBF.FFMGNIDNMII = new Func<Vector3, float>(LHHQGIHGPBF.NFJQEFDGMPK);
				}
				this.FKGNBCKJPQO = LHHQGIHGPBF.FFMGNIDNMII;
				if (LHHQGIHGPBF.MLDNMQMBDGF == null)
				{
					LHHQGIHGPBF.MLDNMQMBDGF = new Func<Vector3, float>(LHHQGIHGPBF.PDECLGHJEMM);
				}
				this.JNBBJCLFFBB = LHHQGIHGPBF.MLDNMQMBDGF;
				if (LHHQGIHGPBF.LDLHIHLGMOP == null)
				{
					LHHQGIHGPBF.LDLHIHLGMOP = new Func<float, float, Vector3>(LHHQGIHGPBF.HCHBEMIBEBL);
				}
				this.QMEMFMDBHLI = LHHQGIHGPBF.LDLHIHLGMOP;
			}
		}
		else
		{
			if (LHHQGIHGPBF.HNCJFHJNHDN == null)
			{
				LHHQGIHGPBF.HNCJFHJNHDN = new Func<Vector3, float>(LHHQGIHGPBF.JCJIHCBGQDB);
			}
			this.FKGNBCKJPQO = LHHQGIHGPBF.HNCJFHJNHDN;
			if (LHHQGIHGPBF.BIJFPHIBEDK == null)
			{
				LHHQGIHGPBF.BIJFPHIBEDK = new Func<Vector3, float>(LHHQGIHGPBF.LLFMCPGEJLK);
			}
			this.JNBBJCLFFBB = LHHQGIHGPBF.BIJFPHIBEDK;
			if (LHHQGIHGPBF.KKGPFHKPCFG == null)
			{
				LHHQGIHGPBF.KKGPFHKPCFG = new Func<float, float, Vector3>(LHHQGIHGPBF.GDMMPIJFEFN);
			}
			this.QMEMFMDBHLI = LHHQGIHGPBF.KKGPFHKPCFG;
		}
	}

	// Token: 0x06006D95 RID: 28053 RVA: 0x000285BD File Offset: 0x000267BD
	[CompilerGenerated]
	private static float BIHHMNNPJBO(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006D96 RID: 28054 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float HOGNPPBMJOH(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D97 RID: 28055 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float HPKJLFKPFOF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D98 RID: 28056 RVA: 0x00357D00 File Offset: 0x00355F00
	private void HKFIBKLCIPH(Vector3 FFENCEGBGFL, ref Vector3 DFGFEPLFEPD, ref bool EEQJLCGQDOC, ref bool BIQKIGHHJLM, float NFGJDGEGLPE, float HNKPFNHBHGK)
	{
		Vector3 vector = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition), this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition));
		Vector3 normalized = (FFENCEGBGFL - vector).normalized;
		float num = (FFENCEGBGFL - vector).magnitude + 1740f + 1239f;
		this.GGLKBFQFENG(vector, normalized * num, Color.yellow, 1619f);
		if (Physics.Raycast(vector, normalized, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
		{
			if (Mathf.Abs(this.FKGNBCKJPQO(this.NHFFPIPBGMJ.normal)) > Mathf.Abs(this.JNBBJCLFFBB(this.NHFFPIPBGMJ.normal)))
			{
				EEQJLCGQDOC = !BIQKIGHHJLM;
				if (this.FKGNBCKJPQO(DFGFEPLFEPD) == 1136f)
				{
					float arg = 241f * NFGJDGEGLPE;
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg, this.JNBBJCLFFBB(DFGFEPLFEPD));
					float arg2 = this.LCQOCMLNQII(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg2, this.JNBBJCLFFBB(DFGFEPLFEPD));
				}
			}
			else
			{
				BIQKIGHHJLM = !EEQJLCGQDOC;
				if (this.JNBBJCLFFBB(DFGFEPLFEPD) == 231f)
				{
					float arg3 = 459f * HNKPFNHBHGK;
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg3);
					float arg4 = this.LCQOCMLNQII(this.JNBBJCLFFBB(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg4);
				}
			}
		}
		else
		{
			EEQJLCGQDOC = true;
			BIQKIGHHJLM = true;
		}
	}

	// Token: 0x06006D99 RID: 28057 RVA: 0x000285B4 File Offset: 0x000267B4
	[CompilerGenerated]
	private static float JCJIHCBGQDB(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006D9A RID: 28058 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB OFCMDQIIFMJ()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006D9B RID: 28059 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float GNBKBECPHPF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006D9C RID: 28060 RVA: 0x000288CB File Offset: 0x00026ACB
	private static Vector3 CMBMPNIEGDG(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(892f, ECFKEFOFQGB, ONOGHDLFKLH);
	}

	// Token: 0x06006D9D RID: 28061 RVA: 0x000288D9 File Offset: 0x00026AD9
	private static Vector3 EIHGCLDDGFD(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 1389f, ECFKEFOFQGB);
	}

	// Token: 0x06006D9E RID: 28062 RVA: 0x000288E7 File Offset: 0x00026AE7
	private void GGLKBFQFENG(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1477f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006D9F RID: 28063 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float LEHIGBDQNLC(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006DA0 RID: 28064 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB QPKKKHJCQQC()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006DA1 RID: 28065 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB EGBLGDIHCNE()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006DA2 RID: 28066 RVA: 0x00357F0C File Offset: 0x0035610C
	private float MECPFCMMLHK(float DFGFEPLFEPD, bool LPKEDQDDCFM)
	{
		bool flag = DFGFEPLFEPD > 884f;
		float num = Mathf.Abs(DFGFEPLFEPD) + 894f;
		Vector3 vector;
		Vector3 arg;
		if (LPKEDQDDCFM)
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.right) : this.MPIJHJOLCBL.right);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.DDFMHKCBLHK);
		}
		else
		{
			vector = ((!flag) ? (-this.MPIJHJOLCBL.up) : this.MPIJHJOLCBL.up);
			arg = ((!flag) ? this.PGIKGPCKFJL.INHEHFIEEDC : this.PGIKGPCKFJL.HICNEJCDKPP);
		}
		float num2 = 1204f;
		bool flag2 = true;
		int num3 = (!LPKEDQDDCFM) ? this.HGGIDMFLFFG : this.OQFBIKQMFMN;
		for (int i = 0; i < num3; i += 0)
		{
			float num4 = (!LPKEDQDDCFM) ? (this.FKGNBCKJPQO(arg) + (float)i * this.NMFLIGCGDOG) : this.FKGNBCKJPQO(arg);
			float num5 = (!LPKEDQDDCFM) ? this.JNBBJCLFFBB(arg) : (this.JNBBJCLFFBB(arg) + (float)i * this.DKFDBQLBNCI);
			if (LPKEDQDDCFM)
			{
				if ((flag && this.KNDBMCDFKJB.QINPGCPDEFQ && i == 0) || (!flag && this.KNDBMCDFKJB.GDLOHNNDPNO && i == 0))
				{
					num5 += 1999f;
				}
				if ((flag && this.KNDBMCDFKJB.DJPFPJIDOFN && i == num3 - 1) || (!flag && this.KNDBMCDFKJB.NEIHPFHLNNO && i == num3 - 0))
				{
					num5 -= 687f;
				}
			}
			else
			{
				if ((flag && this.KNDBMCDFKJB.PPOEIDHJIMQ && i == 0) || (!flag && this.KNDBMCDFKJB.QBFJQOQIKEF && i == 0))
				{
					num4 += 1372f;
				}
				if ((flag && this.KNDBMCDFKJB.DCLGCQQOCBJ && i == num3 - 0) || (!flag && this.KNDBMCDFKJB.POFMJIEBOGK && i == num3 - 0))
				{
					num4 -= 1593f;
				}
			}
			Vector3 vector2 = this.QMEMFMDBHLI(num4, num5);
			if (Physics.Raycast(vector2, vector, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
			{
				this.EQIOCQFGHCF(vector2, vector * num, Color.red, 1118f);
				if ((!LPKEDQDDCFM || !flag2 || !flag || num2 > this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point)) && (!flag2 || !flag || num2 > this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)) && (flag || num2 < this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point)))
				{
					flag2 = false;
					DFGFEPLFEPD = ((!LPKEDQDDCFM) ? (this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) - this.JNBBJCLFFBB(vector2) + ((!flag) ? 174f : 211f)) : (this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point) - this.FKGNBCKJPQO(vector2) + ((!flag) ? 144f : 762f)));
					num2 = ((!LPKEDQDDCFM) ? this.JNBBJCLFFBB(this.NHFFPIPBGMJ.point) : this.FKGNBCKJPQO(this.NHFFPIPBGMJ.point));
				}
			}
			else
			{
				this.ECKEGGKEOOG(vector2, vector * num, Color.cyan, 592f);
			}
		}
		return DFGFEPLFEPD;
	}

	// Token: 0x06006DA3 RID: 28067 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float OPJINKCNQDH(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006DA4 RID: 28068 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float GEPFNNNCFDH(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006DA5 RID: 28069 RVA: 0x00028906 File Offset: 0x00026B06
	private static Vector3 NJBDQPEPHMJ(float ONOGHDLFKLH, float ECFKEFOFQGB)
	{
		return new Vector3(ONOGHDLFKLH, 1970f, ECFKEFOFQGB);
	}

	// Token: 0x06006DA6 RID: 28070 RVA: 0x003582B0 File Offset: 0x003564B0
	public Vector3 JDHEHHMPQOE(Vector3 DFGFEPLFEPD)
	{
		this.LDDCPKQIFIO();
		this.FCBMIEFHJQH(this.PGIKGPCKFJL.INHEHFIEEDC, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.QBFJQOQIKEF, ref this.KNDBMCDFKJB.GDLOHNNDPNO, 536f, 1699f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.DDFMHKCBLHK, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.POFMJIEBOGK, ref this.KNDBMCDFKJB.QINPGCPDEFQ, 1652f, 433f);
		this.KHEKQQMHLMF(this.PGIKGPCKFJL.HICNEJCDKPP, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.PPOEIDHJIMQ, ref this.KNDBMCDFKJB.NEIHPFHLNNO, 895f, 1060f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.IDDJBHLOGII, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.DCLGCQQOCBJ, ref this.KNDBMCDFKJB.DJPFPJIDOFN, 121f, 1625f);
		float arg = 1720f;
		if (this.FKGNBCKJPQO(DFGFEPLFEPD) != 218f)
		{
			arg = this.LMONQFNBHEL(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
		}
		float arg2 = 924f;
		if (this.JNBBJCLFFBB(DFGFEPLFEPD) != 129f)
		{
			arg2 = this.LCQOCMLNQII(this.JNBBJCLFFBB(DFGFEPLFEPD), false);
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006DA7 RID: 28071 RVA: 0x000285B4 File Offset: 0x000267B4
	private static float MHHICQPMNGH(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.x;
	}

	// Token: 0x06006DA8 RID: 28072 RVA: 0x000285BD File Offset: 0x000267BD
	private static float HEMFKBDICKL(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006DA9 RID: 28073 RVA: 0x000285C6 File Offset: 0x000267C6
	private static float HONKKHLOCGO(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006DAA RID: 28074 RVA: 0x00028914 File Offset: 0x00026B14
	private void HJQFQNJNGIN(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 268f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006DAB RID: 28075 RVA: 0x003583F8 File Offset: 0x003565F8
	private void CCEPMJKICPB(Vector3 FFENCEGBGFL, ref Vector3 DFGFEPLFEPD, ref bool EEQJLCGQDOC, ref bool BIQKIGHHJLM, float NFGJDGEGLPE, float HNKPFNHBHGK)
	{
		Vector3 vector = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition), this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition));
		Vector3 normalized = (FFENCEGBGFL - vector).normalized;
		float num = (FFENCEGBGFL - vector).magnitude + 0.01f + 0.5f;
		this.BPDLLHPEJFK(vector, normalized * num, Color.yellow, 0f);
		if (Physics.Raycast(vector, normalized, out this.NHFFPIPBGMJ, num, this.JJDJNJEMJGM))
		{
			if (Mathf.Abs(this.FKGNBCKJPQO(this.NHFFPIPBGMJ.normal)) > Mathf.Abs(this.JNBBJCLFFBB(this.NHFFPIPBGMJ.normal)))
			{
				EEQJLCGQDOC = !BIQKIGHHJLM;
				if (this.FKGNBCKJPQO(DFGFEPLFEPD) == 0f)
				{
					float arg = 0.1f * NFGJDGEGLPE;
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg, this.JNBBJCLFFBB(DFGFEPLFEPD));
					float arg2 = this.CGGGGKKFDMD(this.FKGNBCKJPQO(DFGFEPLFEPD), true);
					DFGFEPLFEPD = this.QMEMFMDBHLI(arg2, this.JNBBJCLFFBB(DFGFEPLFEPD));
				}
			}
			else
			{
				BIQKIGHHJLM = !EEQJLCGQDOC;
				if (this.JNBBJCLFFBB(DFGFEPLFEPD) == 0f)
				{
					float arg3 = 0.1f * HNKPFNHBHGK;
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg3);
					float arg4 = this.CGGGGKKFDMD(this.JNBBJCLFFBB(DFGFEPLFEPD), false);
					DFGFEPLFEPD = this.QMEMFMDBHLI(this.FKGNBCKJPQO(DFGFEPLFEPD), arg4);
				}
			}
		}
		else
		{
			EEQJLCGQDOC = false;
			BIQKIGHHJLM = false;
		}
	}

	// Token: 0x06006DAC RID: 28076 RVA: 0x000285BD File Offset: 0x000267BD
	private static float CGFLKFOHMNO(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x06006DAD RID: 28077 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB PHQEMGFQBNC
	{
		get
		{
			return this.KNDBMCDFKJB;
		}
	}

	// Token: 0x06006DAE RID: 28078 RVA: 0x000285C6 File Offset: 0x000267C6
	[CompilerGenerated]
	private static float CNGNGDBMGKN(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.z;
	}

	// Token: 0x06006DAF RID: 28079 RVA: 0x000285BD File Offset: 0x000267BD
	private static float GFQBBBILOMF(Vector3 CECLGHIJCMM)
	{
		return CECLGHIJCMM.y;
	}

	// Token: 0x06006DB0 RID: 28080 RVA: 0x00358604 File Offset: 0x00356804
	public Vector3 PBOOGHNMMLF(Vector3 DFGFEPLFEPD)
	{
		this.PBFQHQPEGOF();
		this.FCBMIEFHJQH(this.PGIKGPCKFJL.INHEHFIEEDC, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.QBFJQOQIKEF, ref this.KNDBMCDFKJB.GDLOHNNDPNO, 1265f, 297f);
		this.HKFIBKLCIPH(this.PGIKGPCKFJL.DDFMHKCBLHK, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.POFMJIEBOGK, ref this.KNDBMCDFKJB.QINPGCPDEFQ, 864f, 860f);
		this.HKFIBKLCIPH(this.PGIKGPCKFJL.HICNEJCDKPP, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.PPOEIDHJIMQ, ref this.KNDBMCDFKJB.NEIHPFHLNNO, 1825f, 1608f);
		this.CCEPMJKICPB(this.PGIKGPCKFJL.IDDJBHLOGII, ref DFGFEPLFEPD, ref this.KNDBMCDFKJB.DCLGCQQOCBJ, ref this.KNDBMCDFKJB.DJPFPJIDOFN, 1103f, 845f);
		float arg = 194f;
		if (this.FKGNBCKJPQO(DFGFEPLFEPD) != 1670f)
		{
			arg = this.LCQOCMLNQII(this.FKGNBCKJPQO(DFGFEPLFEPD), false);
		}
		float arg2 = 1914f;
		if (this.JNBBJCLFFBB(DFGFEPLFEPD) != 1832f)
		{
			arg2 = this.LMONQFNBHEL(this.JNBBJCLFFBB(DFGFEPLFEPD), true);
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006DB1 RID: 28081 RVA: 0x00028933 File Offset: 0x00026B33
	private void KPLPMLCQBGO(Vector3 GBEBKHGGPKM, Vector3 EQHFEKDMMGK, Color CEGFBBHMKOE, float CPKNEQGKQPQ = 0f)
	{
		if (CPKNEQGKQPQ != 1981f)
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE, CPKNEQGKQPQ);
		}
		else
		{
			Debug.DrawRay(GBEBKHGGPKM, EQHFEKDMMGK, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006DB2 RID: 28082 RVA: 0x000287BE File Offset: 0x000269BE
	public IMEPOBPPQBB HCDLLODDIGC()
	{
		return this.KNDBMCDFKJB;
	}

	// Token: 0x06006DB3 RID: 28083 RVA: 0x0035874C File Offset: 0x0035694C
	private void LDDCPKQIFIO()
	{
		this.PGIKGPCKFJL.DDFMHKCBLHK = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 2f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 2f);
		this.PGIKGPCKFJL.INHEHFIEEDC = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 2f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.y / 2f);
		this.PGIKGPCKFJL.IDDJBHLOGII = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.x / 2f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 2f);
		this.PGIKGPCKFJL.HICNEJCDKPP = this.QMEMFMDBHLI(this.FKGNBCKJPQO(this.MPIJHJOLCBL.localPosition) - this.GDEOGKEKCPG.x / 2f, this.JNBBJCLFFBB(this.MPIJHJOLCBL.localPosition) + this.GDEOGKEKCPG.y / 2f);
		this.NMFLIGCGDOG = this.GDEOGKEKCPG.x / (float)(this.HGGIDMFLFFG - 1);
		this.DKFDBQLBNCI = this.GDEOGKEKCPG.y / (float)(this.OQFBIKQMFMN - 1);
	}

	// Token: 0x04001713 RID: 5907
	private Func<Vector3, float> FKGNBCKJPQO;

	// Token: 0x04001714 RID: 5908
	private Func<Vector3, float> JNBBJCLFFBB;

	// Token: 0x04001715 RID: 5909
	private Func<float, float, Vector3> QMEMFMDBHLI;

	// Token: 0x04001716 RID: 5910
	private const float KDMKDDDNBGL = 0.2f;

	// Token: 0x04001717 RID: 5911
	private const float NJQGMGBBNMM = 0.2f;

	// Token: 0x04001718 RID: 5912
	public Transform MPIJHJOLCBL;

	// Token: 0x04001719 RID: 5913
	public Vector2 GDEOGKEKCPG;

	// Token: 0x0400171A RID: 5914
	public LayerMask JJDJNJEMJGM;

	// Token: 0x0400171B RID: 5915
	public int OQFBIKQMFMN = 3;

	// Token: 0x0400171C RID: 5916
	public int HGGIDMFLFFG = 3;

	// Token: 0x0400171D RID: 5917
	private FHJJBLNPJBI PGIKGPCKFJL;

	// Token: 0x0400171E RID: 5918
	private IMEPOBPPQBB KNDBMCDFKJB;

	// Token: 0x0400171F RID: 5919
	private RaycastHit NHFFPIPBGMJ;

	// Token: 0x04001720 RID: 5920
	private float DKFDBQLBNCI;

	// Token: 0x04001721 RID: 5921
	private float NMFLIGCGDOG;

	// Token: 0x04001722 RID: 5922
	private GNKDCOHMFEG HOJOJPJNLGK;

	// Token: 0x04001723 RID: 5923
	[CompilerGenerated]
	private static Func<Vector3, float> HNCJFHJNHDN;

	// Token: 0x04001724 RID: 5924
	[CompilerGenerated]
	private static Func<Vector3, float> BIJFPHIBEDK;

	// Token: 0x04001725 RID: 5925
	[CompilerGenerated]
	private static Func<float, float, Vector3> KKGPFHKPCFG;

	// Token: 0x04001726 RID: 5926
	[CompilerGenerated]
	private static Func<Vector3, float> FFMGNIDNMII;

	// Token: 0x04001727 RID: 5927
	[CompilerGenerated]
	private static Func<Vector3, float> MLDNMQMBDGF;

	// Token: 0x04001728 RID: 5928
	[CompilerGenerated]
	private static Func<float, float, Vector3> LDLHIHLGMOP;

	// Token: 0x04001729 RID: 5929
	[CompilerGenerated]
	private static Func<Vector3, float> OEPCQKQDIJD;

	// Token: 0x0400172A RID: 5930
	[CompilerGenerated]
	private static Func<Vector3, float> MMPJPDBKOOM;

	// Token: 0x0400172B RID: 5931
	[CompilerGenerated]
	private static Func<float, float, Vector3> EQLOFOGBJIO;
}
