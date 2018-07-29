using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000319 RID: 793
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x06006A4E RID: 27214 RVA: 0x00348110 File Offset: 0x00346310
		public void NJOIMOJOBQG()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x003481C0 File Offset: 0x003463C0
		public float HODPGJCMBJQ(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00348214 File Offset: 0x00346414
		public void FCOBIHPIQFF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 6)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x003482C4 File Offset: 0x003464C4
		public void CCIMLKPPCMP()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 8)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x00348374 File Offset: 0x00346574
		public float EBIMFPGBGHD(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x003483C8 File Offset: 0x003465C8
		public void KNJMPLLKICN()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 1)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x003481C0 File Offset: 0x003463C0
		public float QGEIKBLIHIJ(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x003481C0 File Offset: 0x003463C0
		public float EBQEDKBJPLQ(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x00348374 File Offset: 0x00346574
		public float IPEEDCLLHFK(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x00348374 File Offset: 0x00346574
		public float BDKHQGCLNJD(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x00348478 File Offset: 0x00346678
		public void GCGLQMHGLJG()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 0)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x003481C0 File Offset: 0x003463C0
		public float EPCIOQEEOED(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00348528 File Offset: 0x00346728
		public void HBHIEJNHDEP()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 7)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00348374 File Offset: 0x00346574
		public float PGIEDDMJJIB(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x003481C0 File Offset: 0x003463C0
		public float EDEPHINEGIO(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x00348374 File Offset: 0x00346574
		public float PNGOQBQEQHC(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x003481C0 File Offset: 0x003463C0
		public float NIPNJGOLCOJ(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x000280AE File Offset: 0x000262AE
		public ColorGradingCurve(AnimationCurve MGOKONEDIJI, float IGHDLFPNHPQ, bool JHEEBKGBMPJ, Vector2 GBMNPQIEMQI)
		{
			this.curve = MGOKONEDIJI;
			this.m_ZeroValue = IGHDLFPNHPQ;
			this.m_Loop = JHEEBKGBMPJ;
			this.m_Range = GBMNPQIEMQI.magnitude;
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x003481C0 File Offset: 0x003463C0
		public float HEHHCGCLKNH(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x003485D8 File Offset: 0x003467D8
		public void IGLGCFNDDGI()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 8)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00348688 File Offset: 0x00346888
		public void QNEBDGPFLDH()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00348374 File Offset: 0x00346574
		public float KFQLHFIBHKL(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x00348374 File Offset: 0x00346574
		public float PKCIJEJECBC(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x00348738 File Offset: 0x00346938
		public void NEMMDNLLFLG()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 6)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x003487E8 File Offset: 0x003469E8
		public void MDKEQEPIOEF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00348374 File Offset: 0x00346574
		public float LMPPQBBGNDB(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00348374 File Offset: 0x00346574
		public float JJBJQQLLIFK(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x003481C0 File Offset: 0x003463C0
		public float PQDNHLHKEME(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00348374 File Offset: 0x00346574
		public float GQKQOBPLJOC(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x00348374 File Offset: 0x00346574
		public float HQDMDDDIGBG(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x00348898 File Offset: 0x00346A98
		public void IMIKCLCHGPB()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 5)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x003481C0 File Offset: 0x003463C0
		public float IDKDINCDDCC(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00348948 File Offset: 0x00346B48
		public void FDMEBNCJLHF()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 3)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00348374 File Offset: 0x00346574
		public float KPDEEQNEKGF(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x003481C0 File Offset: 0x003463C0
		public float NKNJKQMLHHQ(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x003489F8 File Offset: 0x00346BF8
		public void ENBFPMPPHPP()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 4)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 0];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[1];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00348AA8 File Offset: 0x00346CA8
		public void OBELQKJBQGD()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 3)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00348374 File Offset: 0x00346574
		public float LBGLKJJHBQH(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00348374 File Offset: 0x00346574
		public float HEDCIPDOJOO(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x003481C0 File Offset: 0x003463C0
		public float BEQBLPJHCQK(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x00348374 File Offset: 0x00346574
		public float NNGFJOLPCEF(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00348374 File Offset: 0x00346574
		public float CCGQEFMPGNP(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 0)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x003481C0 File Offset: 0x003463C0
		public float BLJJEDIBDGH(float OQJFBJQJEFG)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (this.m_Loop)
			{
				if (this.curve.length != 1)
				{
					return this.m_InternalLoopingCurve.Evaluate(OQJFBJQJEFG);
				}
			}
			return this.curve.Evaluate(OQJFBJQJEFG);
		}

		// Token: 0x04001673 RID: 5747
		public AnimationCurve curve;

		// Token: 0x04001674 RID: 5748
		[SerializeField]
		private bool m_Loop;

		// Token: 0x04001675 RID: 5749
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x04001676 RID: 5750
		[SerializeField]
		private float m_Range;

		// Token: 0x04001677 RID: 5751
		private AnimationCurve m_InternalLoopingCurve;
	}
}
