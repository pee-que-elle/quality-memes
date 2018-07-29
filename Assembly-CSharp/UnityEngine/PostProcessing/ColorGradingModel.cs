using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020002EC RID: 748
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x0600668F RID: 26255 RVA: 0x00027814 File Offset: 0x00025A14
		internal void ILINQNCIEJL(bool BGBMIEJJQKC)
		{
			this.<isDirty>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00027830 File Offset: 0x00025A30
		public virtual void IKMKELIDQKE()
		{
			this.isDirty = true;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06006693 RID: 26259 RVA: 0x00027848 File Offset: 0x00025A48
		// (set) Token: 0x06006692 RID: 26258 RVA: 0x00027839 File Offset: 0x00025A39
		public ColorGradingModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
				this.GPNDOOOMBCH();
			}
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00027850 File Offset: 0x00025A50
		public bool NMLCHGDGMHF()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x00027858 File Offset: 0x00025A58
		internal void BIGMHMLBCLK(RenderTexture BGBMIEJJQKC)
		{
			this.<bakedLut>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00027861 File Offset: 0x00025A61
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = ColorGradingModel.Settings.defaultSettings;
			this.GPNDOOOMBCH();
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00027858 File Offset: 0x00025A58
		internal void LLCEOIBCLBO(RenderTexture BGBMIEJJQKC)
		{
			this.<bakedLut>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x00027850 File Offset: 0x00025A50
		// (set) Token: 0x060066A0 RID: 26272 RVA: 0x00027814 File Offset: 0x00025A14
		public bool isDirty { get; internal set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06006699 RID: 26265 RVA: 0x00027874 File Offset: 0x00025A74
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x00027858 File Offset: 0x00025A58
		public RenderTexture bakedLut { get; internal set; }

		// Token: 0x0600669A RID: 26266 RVA: 0x00027814 File Offset: 0x00025A14
		internal void HPMQMQCBHNJ(bool BGBMIEJJQKC)
		{
			this.<isDirty>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x0002787C File Offset: 0x00025A7C
		public virtual void PCFIHDHPOKC()
		{
			this.m_Settings = ColorGradingModel.Settings.FEDCFQNLCBP();
			this.GPNDOOOMBCH();
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x00027850 File Offset: 0x00025A50
		public bool OPDJMMKOCJO()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00027839 File Offset: 0x00025A39
		public void LEMOMMDPLKK(ColorGradingModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
			this.GPNDOOOMBCH();
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x00027858 File Offset: 0x00025A58
		internal void JNMJCNFEDPK(RenderTexture BGBMIEJJQKC)
		{
			this.<bakedLut>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00027830 File Offset: 0x00025A30
		public virtual void EILLOQDLBGM()
		{
			this.isDirty = true;
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x00027830 File Offset: 0x00025A30
		public override void GPNDOOOMBCH()
		{
			this.isDirty = true;
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x00027874 File Offset: 0x00025A74
		public RenderTexture ECLJFFJFBLN()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x00027874 File Offset: 0x00025A74
		public RenderTexture NPMIOBHMMDF()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x040015BC RID: 5564
		[SerializeField]
		private ColorGradingModel.Settings m_Settings = ColorGradingModel.Settings.defaultSettings;

		// Token: 0x020002ED RID: 749
		public enum BCNQPKMNIJM
		{
			// Token: 0x040015C0 RID: 5568
			None,
			// Token: 0x040015C1 RID: 5569
			ACES,
			// Token: 0x040015C2 RID: 5570
			Neutral
		}

		// Token: 0x020002EE RID: 750
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x060066A5 RID: 26277 RVA: 0x00335BE0 File Offset: 0x00333DE0
			public static ColorGradingModel.TonemappingSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.ACES,
					neutralBlackIn = 1626f,
					neutralWhiteIn = 364f,
					neutralBlackOut = 1535f,
					neutralWhiteOut = 851f,
					neutralWhiteLevel = 1470f,
					neutralWhiteClip = 572f
				};
			}

			// Token: 0x060066A6 RID: 26278 RVA: 0x00335C48 File Offset: 0x00333E48
			public static ColorGradingModel.TonemappingSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)7,
					neutralBlackIn = 1175f,
					neutralWhiteIn = 1143f,
					neutralBlackOut = 1203f,
					neutralWhiteOut = 1880f,
					neutralWhiteLevel = 109f,
					neutralWhiteClip = 1072f
				};
			}

			// Token: 0x060066A7 RID: 26279 RVA: 0x00335CB0 File Offset: 0x00333EB0
			public static ColorGradingModel.TonemappingSettings NKQIOFELGQF()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)4,
					neutralBlackIn = 1303f,
					neutralWhiteIn = 1520f,
					neutralBlackOut = 1012f,
					neutralWhiteOut = 1305f,
					neutralWhiteLevel = 1812f,
					neutralWhiteClip = 891f
				};
			}

			// Token: 0x060066A8 RID: 26280 RVA: 0x00335D18 File Offset: 0x00333F18
			public static ColorGradingModel.TonemappingSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)8,
					neutralBlackIn = 1140f,
					neutralWhiteIn = 789f,
					neutralBlackOut = 1466f,
					neutralWhiteOut = 1586f,
					neutralWhiteLevel = 1693f,
					neutralWhiteClip = 347f
				};
			}

			// Token: 0x060066A9 RID: 26281 RVA: 0x00335D80 File Offset: 0x00333F80
			public static ColorGradingModel.TonemappingSettings HMKPKOMGPQC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.ACES,
					neutralBlackIn = 1601f,
					neutralWhiteIn = 786f,
					neutralBlackOut = 1420f,
					neutralWhiteOut = 1529f,
					neutralWhiteLevel = 552f,
					neutralWhiteClip = 64f
				};
			}

			// Token: 0x060066AA RID: 26282 RVA: 0x00335DE8 File Offset: 0x00333FE8
			public static ColorGradingModel.TonemappingSettings IMIJNPIIHEK()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)6,
					neutralBlackIn = 143f,
					neutralWhiteIn = 46f,
					neutralBlackOut = 1483f,
					neutralWhiteOut = 1724f,
					neutralWhiteLevel = 1214f,
					neutralWhiteClip = 72f
				};
			}

			// Token: 0x060066AB RID: 26283 RVA: 0x00335E50 File Offset: 0x00334050
			public static ColorGradingModel.TonemappingSettings PIOFBQKIQEO()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 752f,
					neutralWhiteIn = 311f,
					neutralBlackOut = 225f,
					neutralWhiteOut = 1031f,
					neutralWhiteLevel = 1051f,
					neutralWhiteClip = 572f
				};
			}

			// Token: 0x060066AC RID: 26284 RVA: 0x00335EB8 File Offset: 0x003340B8
			public static ColorGradingModel.TonemappingSettings KMKHPCKLFME()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 281f,
					neutralWhiteIn = 741f,
					neutralBlackOut = 1699f,
					neutralWhiteOut = 1923f,
					neutralWhiteLevel = 606f,
					neutralWhiteClip = 881f
				};
			}

			// Token: 0x060066AD RID: 26285 RVA: 0x00335F20 File Offset: 0x00334120
			public static ColorGradingModel.TonemappingSettings HFQJNGQQPDD()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 1962f,
					neutralWhiteIn = 644f,
					neutralBlackOut = 975f,
					neutralWhiteOut = 1585f,
					neutralWhiteLevel = 445f,
					neutralWhiteClip = 1706f
				};
			}

			// Token: 0x060066AE RID: 26286 RVA: 0x00335F88 File Offset: 0x00334188
			public static ColorGradingModel.TonemappingSettings GODFBEDNBDB()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.None,
					neutralBlackIn = 1861f,
					neutralWhiteIn = 1899f,
					neutralBlackOut = 1140f,
					neutralWhiteOut = 1243f,
					neutralWhiteLevel = 182f,
					neutralWhiteClip = 1632f
				};
			}

			// Token: 0x060066AF RID: 26287 RVA: 0x00335FF0 File Offset: 0x003341F0
			public static ColorGradingModel.TonemappingSettings BPCCKBQPMGL()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 1084f,
					neutralWhiteIn = 1887f,
					neutralBlackOut = 534f,
					neutralWhiteOut = 981f,
					neutralWhiteLevel = 1516f,
					neutralWhiteClip = 1720f
				};
			}

			// Token: 0x060066B0 RID: 26288 RVA: 0x00336058 File Offset: 0x00334258
			public static ColorGradingModel.TonemappingSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)4,
					neutralBlackIn = 432f,
					neutralWhiteIn = 547f,
					neutralBlackOut = 1856f,
					neutralWhiteOut = 1908f,
					neutralWhiteLevel = 1368f,
					neutralWhiteClip = 1844f
				};
			}

			// Token: 0x060066B1 RID: 26289 RVA: 0x003360C0 File Offset: 0x003342C0
			public static ColorGradingModel.TonemappingSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)7,
					neutralBlackIn = 1972f,
					neutralWhiteIn = 69f,
					neutralBlackOut = 929f,
					neutralWhiteOut = 1445f,
					neutralWhiteLevel = 397f,
					neutralWhiteClip = 504f
				};
			}

			// Token: 0x060066B2 RID: 26290 RVA: 0x00336128 File Offset: 0x00334328
			public static ColorGradingModel.TonemappingSettings LILIBDQEIBM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 1841f,
					neutralWhiteIn = 894f,
					neutralBlackOut = 70f,
					neutralWhiteOut = 1173f,
					neutralWhiteLevel = 1607f,
					neutralWhiteClip = 1762f
				};
			}

			// Token: 0x060066B3 RID: 26291 RVA: 0x00336190 File Offset: 0x00334390
			public static ColorGradingModel.TonemappingSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)8,
					neutralBlackIn = 878f,
					neutralWhiteIn = 937f,
					neutralBlackOut = 1277f,
					neutralWhiteOut = 1139f,
					neutralWhiteLevel = 949f,
					neutralWhiteClip = 93f
				};
			}

			// Token: 0x060066B4 RID: 26292 RVA: 0x003361F8 File Offset: 0x003343F8
			public static ColorGradingModel.TonemappingSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 1707f,
					neutralWhiteIn = 21f,
					neutralBlackOut = 68f,
					neutralWhiteOut = 1531f,
					neutralWhiteLevel = 1710f,
					neutralWhiteClip = 34f
				};
			}

			// Token: 0x060066B5 RID: 26293 RVA: 0x00336260 File Offset: 0x00334460
			public static ColorGradingModel.TonemappingSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 1197f,
					neutralWhiteIn = 1310f,
					neutralBlackOut = 27f,
					neutralWhiteOut = 796f,
					neutralWhiteLevel = 12f,
					neutralWhiteClip = 1845f
				};
			}

			// Token: 0x060066B6 RID: 26294 RVA: 0x003362C8 File Offset: 0x003344C8
			public static ColorGradingModel.TonemappingSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 316f,
					neutralWhiteIn = 1564f,
					neutralBlackOut = 1908f,
					neutralWhiteOut = 39f,
					neutralWhiteLevel = 142f,
					neutralWhiteClip = 1999f
				};
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x060066B7 RID: 26295 RVA: 0x00336330 File Offset: 0x00334530
			public static ColorGradingModel.TonemappingSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.TonemappingSettings
					{
						tonemapper = ColorGradingModel.BCNQPKMNIJM.Neutral,
						neutralBlackIn = 0.02f,
						neutralWhiteIn = 10f,
						neutralBlackOut = 0f,
						neutralWhiteOut = 10f,
						neutralWhiteLevel = 5.3f,
						neutralWhiteClip = 10f
					};
				}
			}

			// Token: 0x060066B8 RID: 26296 RVA: 0x00336398 File Offset: 0x00334598
			public static ColorGradingModel.TonemappingSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.None,
					neutralBlackIn = 579f,
					neutralWhiteIn = 714f,
					neutralBlackOut = 1592f,
					neutralWhiteOut = 1804f,
					neutralWhiteLevel = 1935f,
					neutralWhiteClip = 1103f
				};
			}

			// Token: 0x060066B9 RID: 26297 RVA: 0x00336400 File Offset: 0x00334600
			public static ColorGradingModel.TonemappingSettings OKIFIQLFJMM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)6,
					neutralBlackIn = 923f,
					neutralWhiteIn = 1380f,
					neutralBlackOut = 193f,
					neutralWhiteOut = 569f,
					neutralWhiteLevel = 1654f,
					neutralWhiteClip = 1576f
				};
			}

			// Token: 0x060066BA RID: 26298 RVA: 0x00336468 File Offset: 0x00334668
			public static ColorGradingModel.TonemappingSettings BMQKJJQPIFJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)8,
					neutralBlackIn = 102f,
					neutralWhiteIn = 1931f,
					neutralBlackOut = 782f,
					neutralWhiteOut = 770f,
					neutralWhiteLevel = 339f,
					neutralWhiteClip = 467f
				};
			}

			// Token: 0x060066BB RID: 26299 RVA: 0x003364D0 File Offset: 0x003346D0
			public static ColorGradingModel.TonemappingSettings BKOQOBFCMNJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.ACES,
					neutralBlackIn = 1822f,
					neutralWhiteIn = 653f,
					neutralBlackOut = 1080f,
					neutralWhiteOut = 954f,
					neutralWhiteLevel = 924f,
					neutralWhiteClip = 474f
				};
			}

			// Token: 0x060066BC RID: 26300 RVA: 0x00336538 File Offset: 0x00334738
			public static ColorGradingModel.TonemappingSettings GJCLCJLQNBK()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 11f,
					neutralWhiteIn = 99f,
					neutralBlackOut = 1401f,
					neutralWhiteOut = 1307f,
					neutralWhiteLevel = 1926f,
					neutralWhiteClip = 403f
				};
			}

			// Token: 0x060066BD RID: 26301 RVA: 0x003365A0 File Offset: 0x003347A0
			public static ColorGradingModel.TonemappingSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.BCNQPKMNIJM.Neutral,
					neutralBlackIn = 700f,
					neutralWhiteIn = 957f,
					neutralBlackOut = 304f,
					neutralWhiteOut = 1608f,
					neutralWhiteLevel = 1038f,
					neutralWhiteClip = 1525f
				};
			}

			// Token: 0x060066BE RID: 26302 RVA: 0x00336608 File Offset: 0x00334808
			public static ColorGradingModel.TonemappingSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 253f,
					neutralWhiteIn = 571f,
					neutralBlackOut = 1085f,
					neutralWhiteOut = 733f,
					neutralWhiteLevel = 162f,
					neutralWhiteClip = 1498f
				};
			}

			// Token: 0x060066BF RID: 26303 RVA: 0x00336670 File Offset: 0x00334870
			public static ColorGradingModel.TonemappingSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)6,
					neutralBlackIn = 1225f,
					neutralWhiteIn = 309f,
					neutralBlackOut = 300f,
					neutralWhiteOut = 460f,
					neutralWhiteLevel = 1343f,
					neutralWhiteClip = 1868f
				};
			}

			// Token: 0x060066C0 RID: 26304 RVA: 0x003366D8 File Offset: 0x003348D8
			public static ColorGradingModel.TonemappingSettings OJCLCQNDJJJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)8,
					neutralBlackIn = 1810f,
					neutralWhiteIn = 903f,
					neutralBlackOut = 1029f,
					neutralWhiteOut = 1053f,
					neutralWhiteLevel = 771f,
					neutralWhiteClip = 1569f
				};
			}

			// Token: 0x060066C1 RID: 26305 RVA: 0x00336740 File Offset: 0x00334940
			public static ColorGradingModel.TonemappingSettings JMFBQMKFLBG()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)3,
					neutralBlackIn = 1852f,
					neutralWhiteIn = 1432f,
					neutralBlackOut = 1273f,
					neutralWhiteOut = 272f,
					neutralWhiteLevel = 1229f,
					neutralWhiteClip = 1624f
				};
			}

			// Token: 0x060066C2 RID: 26306 RVA: 0x003367A8 File Offset: 0x003349A8
			public static ColorGradingModel.TonemappingSettings LNQMILQOBHP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)6,
					neutralBlackIn = 869f,
					neutralWhiteIn = 1731f,
					neutralBlackOut = 969f,
					neutralWhiteOut = 1417f,
					neutralWhiteLevel = 319f,
					neutralWhiteClip = 713f
				};
			}

			// Token: 0x060066C3 RID: 26307 RVA: 0x00336810 File Offset: 0x00334A10
			public static ColorGradingModel.TonemappingSettings CBPCHEBOBNI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)6,
					neutralBlackIn = 1824f,
					neutralWhiteIn = 201f,
					neutralBlackOut = 1188f,
					neutralWhiteOut = 630f,
					neutralWhiteLevel = 1839f,
					neutralWhiteClip = 192f
				};
			}

			// Token: 0x060066C4 RID: 26308 RVA: 0x00336878 File Offset: 0x00334A78
			public static ColorGradingModel.TonemappingSettings FEDCFQNLCBP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)7,
					neutralBlackIn = 1941f,
					neutralWhiteIn = 1618f,
					neutralBlackOut = 661f,
					neutralWhiteOut = 1064f,
					neutralWhiteLevel = 1512f,
					neutralWhiteClip = 39f
				};
			}

			// Token: 0x060066C5 RID: 26309 RVA: 0x003368E0 File Offset: 0x00334AE0
			public static ColorGradingModel.TonemappingSettings LNHIGCOPCGM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.BCNQPKMNIJM)5,
					neutralBlackIn = 203f,
					neutralWhiteIn = 1698f,
					neutralBlackOut = 1914f,
					neutralWhiteOut = 310f,
					neutralWhiteLevel = 1042f,
					neutralWhiteClip = 463f
				};
			}

			// Token: 0x040015C3 RID: 5571
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public ColorGradingModel.BCNQPKMNIJM tonemapper;

			// Token: 0x040015C4 RID: 5572
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x040015C5 RID: 5573
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x040015C6 RID: 5574
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x040015C7 RID: 5575
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x040015C8 RID: 5576
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x040015C9 RID: 5577
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x020002EF RID: 751
		[Serializable]
		public struct BasicSettings
		{
			// Token: 0x060066C6 RID: 26310 RVA: 0x00336948 File Offset: 0x00334B48
			public static ColorGradingModel.BasicSettings HFQJNGQQPDD()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1919f,
					temperature = 1072f,
					tint = 1346f,
					hueShift = 1651f,
					saturation = 457f,
					contrast = 488f
				};
			}

			// Token: 0x060066C7 RID: 26311 RVA: 0x003369A8 File Offset: 0x00334BA8
			public static ColorGradingModel.BasicSettings KMKHPCKLFME()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 225f,
					temperature = 373f,
					tint = 371f,
					hueShift = 1556f,
					saturation = 1461f,
					contrast = 1094f
				};
			}

			// Token: 0x060066C8 RID: 26312 RVA: 0x00336A08 File Offset: 0x00334C08
			public static ColorGradingModel.BasicSettings IMIJNPIIHEK()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 600f,
					temperature = 780f,
					tint = 756f,
					hueShift = 1078f,
					saturation = 691f,
					contrast = 769f
				};
			}

			// Token: 0x060066C9 RID: 26313 RVA: 0x00336A68 File Offset: 0x00334C68
			public static ColorGradingModel.BasicSettings OJCLCQNDJJJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 507f,
					temperature = 1847f,
					tint = 824f,
					hueShift = 1521f,
					saturation = 116f,
					contrast = 31f
				};
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x060066CA RID: 26314 RVA: 0x00336AC8 File Offset: 0x00334CC8
			public static ColorGradingModel.BasicSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.BasicSettings
					{
						postExposure = 0f,
						temperature = 0f,
						tint = 0f,
						hueShift = 0f,
						saturation = 1f,
						contrast = 1f
					};
				}
			}

			// Token: 0x060066CB RID: 26315 RVA: 0x00336B28 File Offset: 0x00334D28
			public static ColorGradingModel.BasicSettings FEDCFQNLCBP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 651f,
					temperature = 1668f,
					tint = 1338f,
					hueShift = 1486f,
					saturation = 386f,
					contrast = 61f
				};
			}

			// Token: 0x060066CC RID: 26316 RVA: 0x00336B88 File Offset: 0x00334D88
			public static ColorGradingModel.BasicSettings HMKPKOMGPQC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1436f,
					temperature = 606f,
					tint = 1877f,
					hueShift = 1162f,
					saturation = 686f,
					contrast = 471f
				};
			}

			// Token: 0x060066CD RID: 26317 RVA: 0x00336BE8 File Offset: 0x00334DE8
			public static ColorGradingModel.BasicSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1499f,
					temperature = 480f,
					tint = 1469f,
					hueShift = 245f,
					saturation = 194f,
					contrast = 521f
				};
			}

			// Token: 0x060066CE RID: 26318 RVA: 0x00336C48 File Offset: 0x00334E48
			public static ColorGradingModel.BasicSettings OKIFIQLFJMM()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1266f,
					temperature = 1635f,
					tint = 739f,
					hueShift = 1773f,
					saturation = 1294f,
					contrast = 1801f
				};
			}

			// Token: 0x060066CF RID: 26319 RVA: 0x00336CA8 File Offset: 0x00334EA8
			public static ColorGradingModel.BasicSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1488f,
					temperature = 1133f,
					tint = 92f,
					hueShift = 1913f,
					saturation = 75f,
					contrast = 8f
				};
			}

			// Token: 0x060066D0 RID: 26320 RVA: 0x00336D08 File Offset: 0x00334F08
			public static ColorGradingModel.BasicSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 880f,
					temperature = 893f,
					tint = 596f,
					hueShift = 1149f,
					saturation = 1127f,
					contrast = 25f
				};
			}

			// Token: 0x060066D1 RID: 26321 RVA: 0x00336D68 File Offset: 0x00334F68
			public static ColorGradingModel.BasicSettings CBPCHEBOBNI()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 138f,
					temperature = 1879f,
					tint = 1645f,
					hueShift = 54f,
					saturation = 1446f,
					contrast = 1101f
				};
			}

			// Token: 0x060066D2 RID: 26322 RVA: 0x00336DC8 File Offset: 0x00334FC8
			public static ColorGradingModel.BasicSettings LNQMILQOBHP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1518f,
					temperature = 874f,
					tint = 713f,
					hueShift = 662f,
					saturation = 923f,
					contrast = 1535f
				};
			}

			// Token: 0x060066D3 RID: 26323 RVA: 0x00336E28 File Offset: 0x00335028
			public static ColorGradingModel.BasicSettings PIOFBQKIQEO()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1295f,
					temperature = 967f,
					tint = 1930f,
					hueShift = 924f,
					saturation = 966f,
					contrast = 904f
				};
			}

			// Token: 0x060066D4 RID: 26324 RVA: 0x00336E88 File Offset: 0x00335088
			public static ColorGradingModel.BasicSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 23f,
					temperature = 27f,
					tint = 1658f,
					hueShift = 29f,
					saturation = 1547f,
					contrast = 1473f
				};
			}

			// Token: 0x060066D5 RID: 26325 RVA: 0x00336EE8 File Offset: 0x003350E8
			public static ColorGradingModel.BasicSettings NKQIOFELGQF()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 761f,
					temperature = 26f,
					tint = 1110f,
					hueShift = 370f,
					saturation = 265f,
					contrast = 1199f
				};
			}

			// Token: 0x060066D6 RID: 26326 RVA: 0x00336F48 File Offset: 0x00335148
			public static ColorGradingModel.BasicSettings GJCLCJLQNBK()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 697f,
					temperature = 105f,
					tint = 18f,
					hueShift = 426f,
					saturation = 1002f,
					contrast = 562f
				};
			}

			// Token: 0x060066D7 RID: 26327 RVA: 0x00336FA8 File Offset: 0x003351A8
			public static ColorGradingModel.BasicSettings LNHIGCOPCGM()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 579f,
					temperature = 766f,
					tint = 791f,
					hueShift = 421f,
					saturation = 1272f,
					contrast = 198f
				};
			}

			// Token: 0x060066D8 RID: 26328 RVA: 0x00337008 File Offset: 0x00335208
			public static ColorGradingModel.BasicSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1448f,
					temperature = 1415f,
					tint = 1877f,
					hueShift = 1311f,
					saturation = 1944f,
					contrast = 1106f
				};
			}

			// Token: 0x060066D9 RID: 26329 RVA: 0x00337068 File Offset: 0x00335268
			public static ColorGradingModel.BasicSettings GODFBEDNBDB()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1037f,
					temperature = 776f,
					tint = 1966f,
					hueShift = 1067f,
					saturation = 986f,
					contrast = 869f
				};
			}

			// Token: 0x060066DA RID: 26330 RVA: 0x003370C8 File Offset: 0x003352C8
			public static ColorGradingModel.BasicSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1066f,
					temperature = 233f,
					tint = 419f,
					hueShift = 1715f,
					saturation = 1214f,
					contrast = 1085f
				};
			}

			// Token: 0x060066DB RID: 26331 RVA: 0x00337128 File Offset: 0x00335328
			public static ColorGradingModel.BasicSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1760f,
					temperature = 504f,
					tint = 1236f,
					hueShift = 1052f,
					saturation = 17f,
					contrast = 184f
				};
			}

			// Token: 0x060066DC RID: 26332 RVA: 0x00337188 File Offset: 0x00335388
			public static ColorGradingModel.BasicSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 70f,
					temperature = 1526f,
					tint = 138f,
					hueShift = 1498f,
					saturation = 1793f,
					contrast = 1667f
				};
			}

			// Token: 0x060066DD RID: 26333 RVA: 0x003371E8 File Offset: 0x003353E8
			public static ColorGradingModel.BasicSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1038f,
					temperature = 961f,
					tint = 1424f,
					hueShift = 1610f,
					saturation = 1832f,
					contrast = 258f
				};
			}

			// Token: 0x060066DE RID: 26334 RVA: 0x00337248 File Offset: 0x00335448
			public static ColorGradingModel.BasicSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1377f,
					temperature = 458f,
					tint = 1475f,
					hueShift = 1211f,
					saturation = 4f,
					contrast = 1507f
				};
			}

			// Token: 0x060066DF RID: 26335 RVA: 0x003372A8 File Offset: 0x003354A8
			public static ColorGradingModel.BasicSettings BKOQOBFCMNJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 745f,
					temperature = 176f,
					tint = 1185f,
					hueShift = 310f,
					saturation = 1907f,
					contrast = 178f
				};
			}

			// Token: 0x060066E0 RID: 26336 RVA: 0x00337308 File Offset: 0x00335508
			public static ColorGradingModel.BasicSettings BMQKJJQPIFJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 93f,
					temperature = 1956f,
					tint = 1584f,
					hueShift = 232f,
					saturation = 766f,
					contrast = 1405f
				};
			}

			// Token: 0x060066E1 RID: 26337 RVA: 0x00337368 File Offset: 0x00335568
			public static ColorGradingModel.BasicSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 605f,
					temperature = 1478f,
					tint = 796f,
					hueShift = 832f,
					saturation = 1053f,
					contrast = 829f
				};
			}

			// Token: 0x060066E2 RID: 26338 RVA: 0x003373C8 File Offset: 0x003355C8
			public static ColorGradingModel.BasicSettings JMFBQMKFLBG()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1273f,
					temperature = 1767f,
					tint = 892f,
					hueShift = 759f,
					saturation = 629f,
					contrast = 41f
				};
			}

			// Token: 0x060066E3 RID: 26339 RVA: 0x00337428 File Offset: 0x00335628
			public static ColorGradingModel.BasicSettings LILIBDQEIBM()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 933f,
					temperature = 1932f,
					tint = 1557f,
					hueShift = 574f,
					saturation = 737f,
					contrast = 1857f
				};
			}

			// Token: 0x060066E4 RID: 26340 RVA: 0x00337488 File Offset: 0x00335688
			public static ColorGradingModel.BasicSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1240f,
					temperature = 652f,
					tint = 922f,
					hueShift = 1479f,
					saturation = 530f,
					contrast = 881f
				};
			}

			// Token: 0x060066E5 RID: 26341 RVA: 0x003374E8 File Offset: 0x003356E8
			public static ColorGradingModel.BasicSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1001f,
					temperature = 101f,
					tint = 338f,
					hueShift = 1356f,
					saturation = 1842f,
					contrast = 825f
				};
			}

			// Token: 0x040015CA RID: 5578
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			// Token: 0x040015CB RID: 5579
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			// Token: 0x040015CC RID: 5580
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x040015CD RID: 5581
			[Tooltip("Shift the hue of all colors.")]
			[Range(-180f, 180f)]
			public float hueShift;

			// Token: 0x040015CE RID: 5582
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x040015CF RID: 5583
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Range(0f, 2f)]
			public float contrast;
		}

		// Token: 0x020002F0 RID: 752
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x060066E6 RID: 26342 RVA: 0x00337548 File Offset: 0x00335748
			public static ColorGradingModel.ChannelMixerSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1863f, 951f, 800f),
					green = new Vector3(856f, 1668f, 604f),
					blue = new Vector3(1210f, 1226f, 1296f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x060066E7 RID: 26343 RVA: 0x003375B8 File Offset: 0x003357B8
			public static ColorGradingModel.ChannelMixerSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(56f, 42f, 440f),
					green = new Vector3(330f, 1743f, 440f),
					blue = new Vector3(827f, 1195f, 1235f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x060066E8 RID: 26344 RVA: 0x00337628 File Offset: 0x00335828
			public static ColorGradingModel.ChannelMixerSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(198f, 1911f, 935f),
					green = new Vector3(1758f, 1649f, 1491f),
					blue = new Vector3(331f, 1049f, 569f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x060066E9 RID: 26345 RVA: 0x00337698 File Offset: 0x00335898
			public static ColorGradingModel.ChannelMixerSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(236f, 1057f, 1928f),
					green = new Vector3(1897f, 1801f, 1457f),
					blue = new Vector3(212f, 1205f, 1556f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x060066EA RID: 26346 RVA: 0x00337708 File Offset: 0x00335908
			public static ColorGradingModel.ChannelMixerSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(131f, 1505f, 572f),
					green = new Vector3(94f, 948f, 496f),
					blue = new Vector3(146f, 665f, 425f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066EB RID: 26347 RVA: 0x00337778 File Offset: 0x00335978
			public static ColorGradingModel.ChannelMixerSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(936f, 1299f, 800f),
					green = new Vector3(1562f, 475f, 521f),
					blue = new Vector3(1422f, 1088f, 791f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066EC RID: 26348 RVA: 0x003377E8 File Offset: 0x003359E8
			public static ColorGradingModel.ChannelMixerSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(704f, 1426f, 248f),
					green = new Vector3(290f, 1482f, 1547f),
					blue = new Vector3(1867f, 1073f, 1545f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066ED RID: 26349 RVA: 0x00337858 File Offset: 0x00335A58
			public static ColorGradingModel.ChannelMixerSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(539f, 639f, 917f),
					green = new Vector3(1867f, 1842f, 537f),
					blue = new Vector3(59f, 1907f, 1331f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066EE RID: 26350 RVA: 0x003378C8 File Offset: 0x00335AC8
			public static ColorGradingModel.ChannelMixerSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1552f, 1355f, 1803f),
					green = new Vector3(852f, 960f, 66f),
					blue = new Vector3(539f, 1131f, 357f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066EF RID: 26351 RVA: 0x00337938 File Offset: 0x00335B38
			public static ColorGradingModel.ChannelMixerSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(486f, 1555f, 754f),
					green = new Vector3(937f, 564f, 1913f),
					blue = new Vector3(1354f, 247f, 1036f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066F0 RID: 26352 RVA: 0x003379A8 File Offset: 0x00335BA8
			public static ColorGradingModel.ChannelMixerSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1700f, 1577f, 1747f),
					green = new Vector3(1001f, 1979f, 1781f),
					blue = new Vector3(37f, 1988f, 965f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x060066F1 RID: 26353 RVA: 0x00337A18 File Offset: 0x00335C18
			public static ColorGradingModel.ChannelMixerSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(865f, 1655f, 226f),
					green = new Vector3(1105f, 1958f, 87f),
					blue = new Vector3(758f, 1093f, 369f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x060066F2 RID: 26354 RVA: 0x00337A88 File Offset: 0x00335C88
			public static ColorGradingModel.ChannelMixerSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(151f, 1498f, 711f),
					green = new Vector3(497f, 233f, 170f),
					blue = new Vector3(914f, 1419f, 1840f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x060066F3 RID: 26355 RVA: 0x00337AF8 File Offset: 0x00335CF8
			public static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ChannelMixerSettings
					{
						red = new Vector3(1f, 0f, 0f),
						green = new Vector3(0f, 1f, 0f),
						blue = new Vector3(0f, 0f, 1f),
						currentEditingChannel = 0
					};
				}
			}

			// Token: 0x040015D0 RID: 5584
			public Vector3 red;

			// Token: 0x040015D1 RID: 5585
			public Vector3 green;

			// Token: 0x040015D2 RID: 5586
			public Vector3 blue;

			// Token: 0x040015D3 RID: 5587
			[HideInInspector]
			public int currentEditingChannel;
		}

		// Token: 0x020002F1 RID: 753
		[Serializable]
		public struct LogWheelsSettings
		{
			// Token: 0x060066F4 RID: 26356 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066F5 RID: 26357 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066F6 RID: 26358 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x060066F7 RID: 26359 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LogWheelsSettings
					{
						slope = Color.clear,
						power = Color.clear,
						offset = Color.clear
					};
				}
			}

			// Token: 0x060066F8 RID: 26360 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066F9 RID: 26361 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FA RID: 26362 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FB RID: 26363 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FC RID: 26364 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FD RID: 26365 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FE RID: 26366 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x060066FF RID: 26367 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06006700 RID: 26368 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06006701 RID: 26369 RVA: 0x00337B68 File Offset: 0x00335D68
			public static ColorGradingModel.LogWheelsSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x040015D4 RID: 5588
			[QNFGLIHQQCD("GetSlopeValue")]
			public Color slope;

			// Token: 0x040015D5 RID: 5589
			[QNFGLIHQQCD("GetPowerValue")]
			public Color power;

			// Token: 0x040015D6 RID: 5590
			[QNFGLIHQQCD("GetOffsetValue")]
			public Color offset;
		}

		// Token: 0x020002F2 RID: 754
		[Serializable]
		public struct LinearWheelsSettings
		{
			// Token: 0x06006702 RID: 26370 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006703 RID: 26371 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings LILIBDQEIBM()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006704 RID: 26372 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006705 RID: 26373 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings OJCLCQNDJJJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006706 RID: 26374 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006707 RID: 26375 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings FEDCFQNLCBP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006708 RID: 26376 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006709 RID: 26377 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings BKOQOBFCMNJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670A RID: 26378 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670B RID: 26379 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings JMFBQMKFLBG()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670C RID: 26380 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670D RID: 26381 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670E RID: 26382 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings HFQJNGQQPDD()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600670F RID: 26383 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings PIOFBQKIQEO()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06006710 RID: 26384 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LinearWheelsSettings
					{
						lift = Color.clear,
						gamma = Color.clear,
						gain = Color.clear
					};
				}
			}

			// Token: 0x06006711 RID: 26385 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings HMKPKOMGPQC()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006712 RID: 26386 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006713 RID: 26387 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings GJCLCJLQNBK()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006714 RID: 26388 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings NKQIOFELGQF()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006715 RID: 26389 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings LNHIGCOPCGM()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006716 RID: 26390 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings BMQKJJQPIFJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006717 RID: 26391 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings CBPCHEBOBNI()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006718 RID: 26392 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings KMKHPCKLFME()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006719 RID: 26393 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671A RID: 26394 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671B RID: 26395 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings OKIFIQLFJMM()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671C RID: 26396 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings LNQMILQOBHP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671D RID: 26397 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings GODFBEDNBDB()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671E RID: 26398 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings IMIJNPIIHEK()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0600671F RID: 26399 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006720 RID: 26400 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06006721 RID: 26401 RVA: 0x00337BA4 File Offset: 0x00335DA4
			public static ColorGradingModel.LinearWheelsSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x040015D7 RID: 5591
			[QNFGLIHQQCD("GetLiftValue")]
			public Color lift;

			// Token: 0x040015D8 RID: 5592
			[QNFGLIHQQCD("GetGammaValue")]
			public Color gamma;

			// Token: 0x040015D9 RID: 5593
			[QNFGLIHQQCD("GetGainValue")]
			public Color gain;
		}

		// Token: 0x020002F3 RID: 755
		public enum MNJFHJLDMOE
		{
			// Token: 0x040015DB RID: 5595
			Linear,
			// Token: 0x040015DC RID: 5596
			Log
		}

		// Token: 0x020002F4 RID: 756
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x06006722 RID: 26402 RVA: 0x00337BE0 File Offset: 0x00335DE0
			public static ColorGradingModel.ColorWheelsSettings DNGJLKJBCMP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.LCELIFBDEGJ(),
					linear = ColorGradingModel.LinearWheelsSettings.OKIFIQLFJMM()
				};
			}

			// Token: 0x06006723 RID: 26403 RVA: 0x00337C18 File Offset: 0x00335E18
			public static ColorGradingModel.ColorWheelsSettings JMFBQMKFLBG()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.HONMJCFNNGI(),
					linear = ColorGradingModel.LinearWheelsSettings.LILIBDQEIBM()
				};
			}

			// Token: 0x06006724 RID: 26404 RVA: 0x00337C50 File Offset: 0x00335E50
			public static ColorGradingModel.ColorWheelsSettings LILIBDQEIBM()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.OGDHJJODQGC(),
					linear = ColorGradingModel.LinearWheelsSettings.BMQKJJQPIFJ()
				};
			}

			// Token: 0x06006725 RID: 26405 RVA: 0x00337C88 File Offset: 0x00335E88
			public static ColorGradingModel.ColorWheelsSettings LCELIFBDEGJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.LCELIFBDEGJ(),
					linear = ColorGradingModel.LinearWheelsSettings.PIOFBQKIQEO()
				};
			}

			// Token: 0x06006726 RID: 26406 RVA: 0x00337CC0 File Offset: 0x00335EC0
			public static ColorGradingModel.ColorWheelsSettings MBLKIINBGDI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.EMLBMMLLCKB(),
					linear = ColorGradingModel.LinearWheelsSettings.PIOFBQKIQEO()
				};
			}

			// Token: 0x06006727 RID: 26407 RVA: 0x00337CF8 File Offset: 0x00335EF8
			public static ColorGradingModel.ColorWheelsSettings KMKHPCKLFME()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.LCELIFBDEGJ(),
					linear = ColorGradingModel.LinearWheelsSettings.defaultSettings
				};
			}

			// Token: 0x06006728 RID: 26408 RVA: 0x00337D30 File Offset: 0x00335F30
			public static ColorGradingModel.ColorWheelsSettings FDHLMPHBGMI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.MBLKIINBGDI(),
					linear = ColorGradingModel.LinearWheelsSettings.NKQIOFELGQF()
				};
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06006729 RID: 26409 RVA: 0x00337D68 File Offset: 0x00335F68
			public static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ColorWheelsSettings
					{
						mode = ColorGradingModel.MNJFHJLDMOE.Log,
						log = ColorGradingModel.LogWheelsSettings.defaultSettings,
						linear = ColorGradingModel.LinearWheelsSettings.defaultSettings
					};
				}
			}

			// Token: 0x0600672A RID: 26410 RVA: 0x00337DA0 File Offset: 0x00335FA0
			public static ColorGradingModel.ColorWheelsSettings NKQIOFELGQF()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.defaultSettings,
					linear = ColorGradingModel.LinearWheelsSettings.EMLBMMLLCKB()
				};
			}

			// Token: 0x0600672B RID: 26411 RVA: 0x00337DD8 File Offset: 0x00335FD8
			public static ColorGradingModel.ColorWheelsSettings OGDHJJODQGC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.MBLKIINBGDI(),
					linear = ColorGradingModel.LinearWheelsSettings.LIIQFPPIEKM()
				};
			}

			// Token: 0x0600672C RID: 26412 RVA: 0x00337E10 File Offset: 0x00336010
			public static ColorGradingModel.ColorWheelsSettings LNHIGCOPCGM()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.NLKNLIGKCIL(),
					linear = ColorGradingModel.LinearWheelsSettings.LNHIGCOPCGM()
				};
			}

			// Token: 0x0600672D RID: 26413 RVA: 0x00337E48 File Offset: 0x00336048
			public static ColorGradingModel.ColorWheelsSettings PBBBBNIEBDK()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.EMLBMMLLCKB(),
					linear = ColorGradingModel.LinearWheelsSettings.LNQMILQOBHP()
				};
			}

			// Token: 0x0600672E RID: 26414 RVA: 0x00337E80 File Offset: 0x00336080
			public static ColorGradingModel.ColorWheelsSettings EKBHCDLLDKG()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.OGDHJJODQGC(),
					linear = ColorGradingModel.LinearWheelsSettings.LNQMILQOBHP()
				};
			}

			// Token: 0x0600672F RID: 26415 RVA: 0x00337EB8 File Offset: 0x003360B8
			public static ColorGradingModel.ColorWheelsSettings OJCLCQNDJJJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.EMLBMMLLCKB(),
					linear = ColorGradingModel.LinearWheelsSettings.JMFBQMKFLBG()
				};
			}

			// Token: 0x06006730 RID: 26416 RVA: 0x00337EF0 File Offset: 0x003360F0
			public static ColorGradingModel.ColorWheelsSettings NLKNLIGKCIL()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.EKBHCDLLDKG(),
					linear = ColorGradingModel.LinearWheelsSettings.CBPCHEBOBNI()
				};
			}

			// Token: 0x06006731 RID: 26417 RVA: 0x00337F28 File Offset: 0x00336128
			public static ColorGradingModel.ColorWheelsSettings PIOFBQKIQEO()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.LCELIFBDEGJ(),
					linear = ColorGradingModel.LinearWheelsSettings.FGIOKBBLFFK()
				};
			}

			// Token: 0x06006732 RID: 26418 RVA: 0x00337F60 File Offset: 0x00336160
			public static ColorGradingModel.ColorWheelsSettings BMQKJJQPIFJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.HMNNEKFJMGP(),
					linear = ColorGradingModel.LinearWheelsSettings.HFQJNGQQPDD()
				};
			}

			// Token: 0x06006733 RID: 26419 RVA: 0x00337F98 File Offset: 0x00336198
			public static ColorGradingModel.ColorWheelsSettings HMNNEKFJMGP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.FDHLMPHBGMI(),
					linear = ColorGradingModel.LinearWheelsSettings.DNGJLKJBCMP()
				};
			}

			// Token: 0x06006734 RID: 26420 RVA: 0x00337FD0 File Offset: 0x003361D0
			public static ColorGradingModel.ColorWheelsSettings LIIQFPPIEKM()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Log,
					log = ColorGradingModel.LogWheelsSettings.NLKNLIGKCIL(),
					linear = ColorGradingModel.LinearWheelsSettings.EKBHCDLLDKG()
				};
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x00338008 File Offset: 0x00336208
			public static ColorGradingModel.ColorWheelsSettings FGIOKBBLFFK()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.PBBBBNIEBDK(),
					linear = ColorGradingModel.LinearWheelsSettings.PBBBBNIEBDK()
				};
			}

			// Token: 0x06006736 RID: 26422 RVA: 0x00338040 File Offset: 0x00336240
			public static ColorGradingModel.ColorWheelsSettings EMLBMMLLCKB()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.OGDHJJODQGC(),
					linear = ColorGradingModel.LinearWheelsSettings.OJCLCQNDJJJ()
				};
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x00338078 File Offset: 0x00336278
			public static ColorGradingModel.ColorWheelsSettings HONMJCFNNGI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.MNJFHJLDMOE.Linear,
					log = ColorGradingModel.LogWheelsSettings.DNGJLKJBCMP(),
					linear = ColorGradingModel.LinearWheelsSettings.PIOFBQKIQEO()
				};
			}

			// Token: 0x040015DD RID: 5597
			public ColorGradingModel.MNJFHJLDMOE mode;

			// Token: 0x040015DE RID: 5598
			[EHQLQQGFDKD]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x040015DF RID: 5599
			[EHQLQQGFDKD]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x020002F5 RID: 757
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x06006738 RID: 26424 RVA: 0x003380B0 File Offset: 0x003362B0
			public static ColorGradingModel.CurvesSettings ECDEKIGEPNC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(354f, 258f, 62f, 1980f);
				array[0] = new Keyframe(1629f, 180f, 631f, 1991f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1103f, false, new Vector2(1844f, 1513f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(548f, 749f, 1199f, 1300f);
				array2[1] = new Keyframe(1606f, 733f, 1826f, 1531f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1546f, true, new Vector2(1655f, 265f));
				result.green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1910f, 1015f, 441f, 1226f),
					new Keyframe(736f, 1650f, 1740f, 1014f)
				}), 765f, true, new Vector2(607f, 1454f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(57f, 1433f, 1191f, 848f);
				array3[0] = new Keyframe(1155f, 985f, 117f, 1047f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 1031f, true, new Vector2(432f, 530f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 434f, false, new Vector2(1974f, 1915f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 50f, true, new Vector2(1192f, 1532f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1403f, false, new Vector2(1925f, 1908f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 898f, true, new Vector2(184f, 535f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006739 RID: 26425 RVA: 0x00338360 File Offset: 0x00336560
			public static ColorGradingModel.CurvesSettings GODFBEDNBDB()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(110f, 981f, 893f, 422f);
				array[1] = new Keyframe(1429f, 1892f, 1094f, 1774f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 742f, true, new Vector2(171f, 1915f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(665f, 226f, 545f, 1327f);
				array2[0] = new Keyframe(1544f, 39f, 379f, 351f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 847f, false, new Vector2(1889f, 41f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1857f, 468f, 397f, 1637f)
				};
				array3[1] = new Keyframe(1581f, 527f, 567f, 1171f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 797f, false, new Vector2(524f, 1712f));
				Keyframe[] array4 = new Keyframe[1];
				array4[1] = new Keyframe(961f, 401f, 850f, 1554f);
				array4[0] = new Keyframe(1367f, 346f, 1319f, 501f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 588f, false, new Vector2(602f, 542f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1574f, false, new Vector2(1540f, 1851f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 443f, false, new Vector2(884f, 1051f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1774f, false, new Vector2(412f, 172f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 138f, true, new Vector2(1373f, 530f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600673A RID: 26426 RVA: 0x00338610 File Offset: 0x00336810
			public static ColorGradingModel.CurvesSettings PBBBBNIEBDK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(93f, 589f, 651f, 432f);
				array[1] = new Keyframe(1299f, 175f, 1876f, 1658f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 143f, true, new Vector2(230f, 13f));
				Keyframe[] array2 = new Keyframe[7];
				array2[0] = new Keyframe(1537f, 930f, 406f, 1644f);
				array2[0] = new Keyframe(1267f, 700f, 111f, 858f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 15f, false, new Vector2(306f, 642f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(456f, 1753f, 1964f, 149f)
				};
				array3[1] = new Keyframe(188f, 1884f, 1142f, 290f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1958f, false, new Vector2(1192f, 1588f));
				Keyframe[] array4 = new Keyframe[4];
				array4[1] = new Keyframe(1481f, 117f, 734f, 1308f);
				array4[0] = new Keyframe(1888f, 1324f, 841f, 1101f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1636f, true, new Vector2(477f, 1792f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 416f, true, new Vector2(992f, 1533f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1413f, false, new Vector2(1687f, 1303f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 266f, true, new Vector2(1994f, 607f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1652f, true, new Vector2(116f, 1685f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600673B RID: 26427 RVA: 0x003388C0 File Offset: 0x00336AC0
			public static ColorGradingModel.CurvesSettings LNHIGCOPCGM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(385f, 1695f, 211f, 1050f);
				array[1] = new Keyframe(37f, 1861f, 503f, 105f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 5f, true, new Vector2(1039f, 1532f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(1511f, 1482f, 1076f, 1774f);
				array2[1] = new Keyframe(485f, 1900f, 496f, 585f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1643f, true, new Vector2(175f, 1348f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(1631f, 202f, 671f, 767f)
				};
				array3[0] = new Keyframe(1100f, 128f, 338f, 106f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1440f, false, new Vector2(1642f, 1387f));
				result.blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1308f, 1399f, 970f, 679f),
					new Keyframe(424f, 1220f, 192f, 1045f)
				}), 336f, false, new Vector2(1198f, 1625f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1406f, false, new Vector2(1862f, 513f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 171f, true, new Vector2(374f, 1146f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 368f, false, new Vector2(147f, 954f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1383f, true, new Vector2(970f, 333f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600673C RID: 26428 RVA: 0x00338B70 File Offset: 0x00336D70
			public static ColorGradingModel.CurvesSettings OQGIEDOFKDG()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					new Keyframe(1417f, 1752f, 1625f, 924f)
				};
				array[0] = new Keyframe(1394f, 194f, 1928f, 304f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1119f, true, new Vector2(399f, 791f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(243f, 208f, 1727f, 654f);
				array2[1] = new Keyframe(1265f, 939f, 1930f, 146f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 801f, true, new Vector2(180f, 32f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(258f, 944f, 320f, 1510f)
				};
				array3[0] = new Keyframe(297f, 1585f, 267f, 634f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 8f, false, new Vector2(1997f, 1604f));
				Keyframe[] array4 = new Keyframe[8];
				array4[1] = new Keyframe(1784f, 1743f, 1733f, 441f);
				array4[1] = new Keyframe(216f, 544f, 835f, 1148f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1198f, false, new Vector2(1821f, 1478f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 123f, true, new Vector2(1214f, 162f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1586f, false, new Vector2(860f, 361f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 79f, true, new Vector2(635f, 260f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 658f, true, new Vector2(1093f, 645f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600673D RID: 26429 RVA: 0x00338E20 File Offset: 0x00337020
			public static ColorGradingModel.CurvesSettings EKBHCDLLDKG()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(362f, 1043f, 1562f, 115f);
				array[0] = new Keyframe(1649f, 61f, 205f, 1910f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1377f, true, new Vector2(36f, 667f));
				Keyframe[] array2 = new Keyframe[7];
				array2[0] = new Keyframe(1290f, 1342f, 1617f, 116f);
				array2[0] = new Keyframe(339f, 98f, 75f, 1372f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 104f, true, new Vector2(1588f, 740f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(338f, 689f, 1772f, 330f)
				};
				array3[0] = new Keyframe(656f, 236f, 855f, 256f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1729f, true, new Vector2(1415f, 686f));
				Keyframe[] array4 = new Keyframe[0];
				array4[0] = new Keyframe(1280f, 1193f, 134f, 903f);
				array4[1] = new Keyframe(1842f, 1763f, 1411f, 61f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 941f, false, new Vector2(968f, 189f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 11f, true, new Vector2(60f, 1321f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1638f, false, new Vector2(1039f, 738f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 263f, false, new Vector2(1539f, 1858f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1054f, false, new Vector2(1360f, 387f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600673E RID: 26430 RVA: 0x003390D0 File Offset: 0x003372D0
			public static ColorGradingModel.CurvesSettings FGIOKBBLFFK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1333f, 1835f, 1255f, 1132f);
				array[0] = new Keyframe(863f, 513f, 219f, 1710f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 92f, false, new Vector2(1131f, 966f));
				Keyframe[] array2 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1073f, 1385f, 429f, 1215f)
				};
				array2[0] = new Keyframe(739f, 701f, 974f, 100f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1207f, true, new Vector2(232f, 1561f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(666f, 1881f, 759f, 1420f);
				array3[0] = new Keyframe(1578f, 1259f, 554f, 391f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1402f, true, new Vector2(1774f, 896f));
				Keyframe[] array4 = new Keyframe[7];
				array4[1] = new Keyframe(985f, 718f, 294f, 295f);
				array4[0] = new Keyframe(1654f, 696f, 1319f, 145f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 832f, false, new Vector2(860f, 1155f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1924f, true, new Vector2(630f, 951f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1939f, false, new Vector2(1426f, 844f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 371f, true, new Vector2(375f, 200f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1814f, false, new Vector2(38f, 1812f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600673F RID: 26431 RVA: 0x00339380 File Offset: 0x00337580
			public static ColorGradingModel.CurvesSettings OKIFIQLFJMM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(628f, 544f, 1846f, 1879f);
				array[0] = new Keyframe(1502f, 1899f, 258f, 1076f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 645f, false, new Vector2(1543f, 487f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(732f, 55f, 1361f, 1860f);
				array2[0] = new Keyframe(287f, 674f, 831f, 635f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1265f, true, new Vector2(1519f, 1495f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1072f, 222f, 841f, 349f);
				array3[0] = new Keyframe(791f, 614f, 217f, 314f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1295f, false, new Vector2(914f, 1188f));
				Keyframe[] array4 = new Keyframe[7];
				array4[1] = new Keyframe(1199f, 820f, 1147f, 1109f);
				array4[1] = new Keyframe(1677f, 1680f, 454f, 1000f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 755f, true, new Vector2(1713f, 1210f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 614f, true, new Vector2(1983f, 404f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1342f, false, new Vector2(1573f, 615f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 702f, false, new Vector2(894f, 1204f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 117f, true, new Vector2(1046f, 565f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006740 RID: 26432 RVA: 0x00339630 File Offset: 0x00337830
			public static ColorGradingModel.CurvesSettings CBPCHEBOBNI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[2];
				array[0] = new Keyframe(1581f, 98f, 1644f, 921f);
				array[0] = new Keyframe(1141f, 1493f, 1536f, 1762f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1250f, true, new Vector2(970f, 361f));
				Keyframe[] array2 = new Keyframe[1];
				array2[1] = new Keyframe(1652f, 1084f, 1179f, 642f);
				array2[1] = new Keyframe(773f, 111f, 1989f, 994f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1115f, true, new Vector2(1747f, 1860f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(1884f, 453f, 1240f, 366f);
				array3[0] = new Keyframe(333f, 829f, 707f, 77f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 546f, false, new Vector2(897f, 1926f));
				Keyframe[] array4 = new Keyframe[5];
				array4[0] = new Keyframe(765f, 1274f, 1807f, 694f);
				array4[0] = new Keyframe(1540f, 425f, 1661f, 1083f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1359f, true, new Vector2(109f, 649f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1805f, true, new Vector2(1393f, 1632f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 834f, false, new Vector2(1365f, 971f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1730f, true, new Vector2(1700f, 1229f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 823f, false, new Vector2(1101f, 95f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006741 RID: 26433 RVA: 0x003398E0 File Offset: 0x00337AE0
			public static ColorGradingModel.CurvesSettings BKOQOBFCMNJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				result.master = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(386f, 1459f, 1329f, 1391f),
					new Keyframe(1840f, 1594f, 899f, 1078f)
				}), 1403f, true, new Vector2(716f, 1311f));
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1118f, 148f, 584f, 496f)
				};
				array[0] = new Keyframe(253f, 1905f, 1339f, 1839f);
				result.red = new ColorGradingCurve(new AnimationCurve(array), 634f, true, new Vector2(1341f, 1381f));
				Keyframe[] array2 = new Keyframe[2];
				array2[0] = new Keyframe(1774f, 547f, 1028f, 1611f);
				array2[0] = new Keyframe(1883f, 740f, 182f, 847f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 861f, false, new Vector2(1995f, 126f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(330f, 1253f, 1207f, 1800f);
				array3[0] = new Keyframe(960f, 852f, 1569f, 1886f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 118f, false, new Vector2(120f, 1489f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 757f, true, new Vector2(499f, 212f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 432f, false, new Vector2(1629f, 1055f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1688f, true, new Vector2(434f, 1689f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 378f, true, new Vector2(1736f, 1635f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006742 RID: 26434 RVA: 0x00339B90 File Offset: 0x00337D90
			public static ColorGradingModel.CurvesSettings LIIQFPPIEKM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(26f, 224f, 225f, 904f);
				array[1] = new Keyframe(926f, 1964f, 534f, 478f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1479f, false, new Vector2(518f, 803f));
				Keyframe[] array2 = new Keyframe[]
				{
					new Keyframe(382f, 1505f, 948f, 1396f)
				};
				array2[0] = new Keyframe(474f, 1498f, 217f, 1670f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1728f, false, new Vector2(1864f, 470f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(1889f, 1995f, 580f, 266f);
				array3[0] = new Keyframe(762f, 1307f, 330f, 575f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 917f, false, new Vector2(1454f, 776f));
				Keyframe[] array4 = new Keyframe[5];
				array4[0] = new Keyframe(1110f, 1757f, 1935f, 1496f);
				array4[0] = new Keyframe(1034f, 1621f, 1138f, 662f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 782f, false, new Vector2(6f, 554f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1175f, false, new Vector2(1062f, 1493f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1119f, true, new Vector2(1590f, 626f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1938f, false, new Vector2(209f, 1566f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1075f, true, new Vector2(373f, 479f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006743 RID: 26435 RVA: 0x00339E40 File Offset: 0x00338040
			public static ColorGradingModel.CurvesSettings HMKPKOMGPQC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1357f, 813f, 613f, 1445f);
				array[1] = new Keyframe(1222f, 1148f, 193f, 1546f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1915f, false, new Vector2(1016f, 1725f));
				Keyframe[] array2 = new Keyframe[3];
				array2[1] = new Keyframe(443f, 1407f, 1197f, 85f);
				array2[0] = new Keyframe(1213f, 1368f, 1222f, 15f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 934f, false, new Vector2(216f, 979f));
				result.green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1754f, 751f, 743f, 1656f),
					new Keyframe(710f, 1759f, 971f, 1844f)
				}), 1127f, false, new Vector2(1419f, 1992f));
				Keyframe[] array3 = new Keyframe[5];
				array3[1] = new Keyframe(1707f, 50f, 441f, 1506f);
				array3[0] = new Keyframe(1949f, 1957f, 975f, 940f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 1047f, true, new Vector2(1590f, 598f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 511f, false, new Vector2(1006f, 168f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1727f, true, new Vector2(161f, 109f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 272f, false, new Vector2(724f, 1105f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 684f, false, new Vector2(1352f, 958f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006744 RID: 26436 RVA: 0x0033A0F0 File Offset: 0x003382F0
			public static ColorGradingModel.CurvesSettings HQDCCODHLJM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(1176f, 322f, 301f, 1828f);
				array[0] = new Keyframe(137f, 1074f, 592f, 1370f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1886f, false, new Vector2(1234f, 1278f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(331f, 1977f, 1908f, 332f);
				array2[1] = new Keyframe(679f, 1315f, 801f, 1748f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1152f, false, new Vector2(1850f, 469f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1419f, 1711f, 1140f, 453f);
				array3[0] = new Keyframe(75f, 1783f, 1370f, 614f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1380f, false, new Vector2(1643f, 516f));
				Keyframe[] array4 = new Keyframe[8];
				array4[1] = new Keyframe(412f, 1523f, 840f, 71f);
				array4[1] = new Keyframe(1116f, 1347f, 1174f, 1050f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1649f, true, new Vector2(1521f, 553f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 675f, false, new Vector2(287f, 605f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1621f, true, new Vector2(466f, 1195f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 93f, false, new Vector2(669f, 295f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 547f, false, new Vector2(1293f, 952f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006745 RID: 26437 RVA: 0x0033A3A0 File Offset: 0x003385A0
			public static ColorGradingModel.CurvesSettings FEDCFQNLCBP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[2];
				array[0] = new Keyframe(1670f, 756f, 150f, 1309f);
				array[0] = new Keyframe(1005f, 1620f, 766f, 986f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1520f, true, new Vector2(953f, 1154f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(30f, 659f, 29f, 1419f);
				array2[1] = new Keyframe(664f, 10f, 1181f, 1241f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1496f, true, new Vector2(1087f, 264f));
				Keyframe[] array3 = new Keyframe[5];
				array3[0] = new Keyframe(1104f, 880f, 603f, 1451f);
				array3[1] = new Keyframe(1121f, 824f, 674f, 1305f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1643f, false, new Vector2(1340f, 816f));
				Keyframe[] array4 = new Keyframe[8];
				array4[0] = new Keyframe(435f, 307f, 826f, 907f);
				array4[0] = new Keyframe(0f, 1658f, 1835f, 1380f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 302f, true, new Vector2(1575f, 908f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1813f, false, new Vector2(1917f, 1355f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1524f, false, new Vector2(416f, 889f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 349f, true, new Vector2(1612f, 1538f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1205f, true, new Vector2(724f, 1776f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006746 RID: 26438 RVA: 0x0033A650 File Offset: 0x00338850
			public static ColorGradingModel.CurvesSettings LNQMILQOBHP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1165f, 575f, 1954f, 1459f)
				};
				array[0] = new Keyframe(156f, 1006f, 1161f, 223f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 179f, false, new Vector2(1033f, 1153f));
				result.red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1658f, 1762f, 1568f, 1035f),
					new Keyframe(106f, 1464f, 1302f, 1163f)
				}), 1323f, true, new Vector2(1738f, 1483f));
				Keyframe[] array2 = new Keyframe[5];
				array2[1] = new Keyframe(195f, 1455f, 384f, 1453f);
				array2[0] = new Keyframe(259f, 312f, 1906f, 179f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 1573f, false, new Vector2(538f, 1005f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(68f, 942f, 771f, 1813f)
				};
				array3[0] = new Keyframe(1098f, 885f, 1314f, 1379f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 1833f, true, new Vector2(1272f, 791f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 136f, true, new Vector2(418f, 1522f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1878f, false, new Vector2(1984f, 1446f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 648f, true, new Vector2(107f, 1803f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1345f, true, new Vector2(1388f, 1462f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006747 RID: 26439 RVA: 0x0033A900 File Offset: 0x00338B00
			public static ColorGradingModel.CurvesSettings NKQIOFELGQF()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1368f, 765f, 628f, 486f);
				array[1] = new Keyframe(1348f, 435f, 1474f, 709f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1799f, false, new Vector2(1013f, 1485f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(54f, 220f, 1499f, 112f);
				array2[1] = new Keyframe(511f, 1872f, 1978f, 37f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1614f, true, new Vector2(1000f, 1344f));
				Keyframe[] array3 = new Keyframe[7];
				array3[0] = new Keyframe(358f, 1537f, 1252f, 355f);
				array3[0] = new Keyframe(201f, 631f, 595f, 506f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 645f, true, new Vector2(429f, 1105f));
				Keyframe[] array4 = new Keyframe[0];
				array4[1] = new Keyframe(105f, 195f, 629f, 806f);
				array4[1] = new Keyframe(1584f, 952f, 979f, 1872f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 579f, true, new Vector2(786f, 590f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 871f, true, new Vector2(347f, 1090f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1855f, true, new Vector2(1440f, 1461f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1761f, true, new Vector2(853f, 899f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1422f, true, new Vector2(993f, 1466f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006748 RID: 26440 RVA: 0x0033ABB0 File Offset: 0x00338DB0
			public static ColorGradingModel.CurvesSettings BPCCKBQPMGL()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(1073f, 1112f, 436f, 1931f);
				array[1] = new Keyframe(100f, 1419f, 1162f, 1351f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 991f, false, new Vector2(333f, 1830f));
				Keyframe[] array2 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(978f, 1479f, 759f, 1931f)
				};
				array2[1] = new Keyframe(1765f, 726f, 1229f, 1460f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 15f, false, new Vector2(1882f, 865f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1037f, 585f, 1580f, 105f);
				array3[1] = new Keyframe(1766f, 369f, 1140f, 1242f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1741f, false, new Vector2(195f, 779f));
				Keyframe[] array4 = new Keyframe[8];
				array4[0] = new Keyframe(754f, 967f, 905f, 747f);
				array4[1] = new Keyframe(346f, 1718f, 1745f, 513f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1206f, false, new Vector2(1883f, 975f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1915f, true, new Vector2(218f, 553f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 151f, false, new Vector2(1954f, 297f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 752f, true, new Vector2(1279f, 1969f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 609f, false, new Vector2(1516f, 190f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x0033AE60 File Offset: 0x00339060
			public static ColorGradingModel.CurvesSettings MBLKIINBGDI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1836f, 771f, 1229f, 574f);
				array[1] = new Keyframe(1711f, 1389f, 1761f, 1688f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 46f, false, new Vector2(803f, 1668f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(1848f, 1131f, 1568f, 1017f);
				array2[0] = new Keyframe(595f, 1045f, 740f, 1355f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 402f, true, new Vector2(366f, 16f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(1123f, 1188f, 1444f, 606f);
				array3[1] = new Keyframe(866f, 1608f, 464f, 1460f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 551f, false, new Vector2(1778f, 170f));
				Keyframe[] array4 = new Keyframe[4];
				array4[1] = new Keyframe(556f, 718f, 1943f, 1148f);
				array4[1] = new Keyframe(772f, 1496f, 1805f, 1150f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 858f, false, new Vector2(31f, 1873f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 171f, false, new Vector2(1345f, 1372f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 909f, false, new Vector2(922f, 1656f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1359f, true, new Vector2(266f, 909f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 239f, false, new Vector2(108f, 466f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600674A RID: 26442 RVA: 0x0033B110 File Offset: 0x00339310
			public static ColorGradingModel.CurvesSettings IMIJNPIIHEK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1473f, 1714f, 269f, 1796f);
				array[1] = new Keyframe(1803f, 608f, 10f, 1120f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1161f, false, new Vector2(858f, 120f));
				Keyframe[] array2 = new Keyframe[1];
				array2[1] = new Keyframe(663f, 1127f, 1013f, 1434f);
				array2[1] = new Keyframe(1716f, 400f, 66f, 1512f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 604f, false, new Vector2(890f, 1254f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1705f, 1284f, 977f, 1231f)
				};
				array3[0] = new Keyframe(13f, 1059f, 365f, 333f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 468f, true, new Vector2(714f, 1985f));
				Keyframe[] array4 = new Keyframe[6];
				array4[1] = new Keyframe(494f, 837f, 1664f, 102f);
				array4[0] = new Keyframe(805f, 1878f, 1791f, 26f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 58f, true, new Vector2(1648f, 756f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1192f, true, new Vector2(913f, 1354f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1398f, true, new Vector2(1455f, 1174f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1881f, false, new Vector2(1690f, 1678f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1604f, false, new Vector2(680f, 966f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x0033B3C0 File Offset: 0x003395C0
			public static ColorGradingModel.CurvesSettings QFDEQMDDPLQ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(398f, 976f, 537f, 71f);
				array[0] = new Keyframe(90f, 803f, 803f, 554f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1229f, false, new Vector2(240f, 1093f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(800f, 1328f, 699f, 318f);
				array2[0] = new Keyframe(170f, 1775f, 1446f, 510f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 53f, false, new Vector2(1255f, 613f));
				Keyframe[] array3 = new Keyframe[4];
				array3[0] = new Keyframe(700f, 1934f, 1512f, 1277f);
				array3[0] = new Keyframe(645f, 1178f, 394f, 658f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 3f, false, new Vector2(1865f, 1741f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(1053f, 1858f, 361f, 1015f);
				array4[1] = new Keyframe(1676f, 1153f, 422f, 162f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 839f, false, new Vector2(1530f, 27f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 18f, false, new Vector2(834f, 190f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1741f, false, new Vector2(528f, 760f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 728f, true, new Vector2(1225f, 1376f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1622f, false, new Vector2(40f, 314f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600674C RID: 26444 RVA: 0x0033B670 File Offset: 0x00339870
			public static ColorGradingModel.CurvesSettings BMDHMEEIQQM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(1590f, 1306f, 1790f, 1714f);
				array[0] = new Keyframe(1171f, 311f, 20f, 475f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 106f, false, new Vector2(1318f, 794f));
				Keyframe[] array2 = new Keyframe[8];
				array2[0] = new Keyframe(1306f, 918f, 1340f, 1705f);
				array2[0] = new Keyframe(1097f, 181f, 377f, 275f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1451f, false, new Vector2(95f, 1930f));
				Keyframe[] array3 = new Keyframe[5];
				array3[1] = new Keyframe(1034f, 1106f, 1476f, 767f);
				array3[0] = new Keyframe(280f, 506f, 1146f, 252f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 907f, false, new Vector2(614f, 1784f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1774f, 1851f, 1123f, 857f)
				};
				array4[0] = new Keyframe(1233f, 1103f, 1311f, 1375f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1348f, true, new Vector2(928f, 1515f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 262f, true, new Vector2(1076f, 381f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 878f, false, new Vector2(1071f, 1037f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1842f, false, new Vector2(1358f, 130f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 799f, true, new Vector2(1088f, 797f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600674D RID: 26445 RVA: 0x0033B920 File Offset: 0x00339B20
			public static ColorGradingModel.CurvesSettings OJCLCQNDJJJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(537f, 562f, 1400f, 1406f);
				array[0] = new Keyframe(1379f, 1776f, 1250f, 1414f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 41f, true, new Vector2(738f, 298f));
				Keyframe[] array2 = new Keyframe[1];
				array2[0] = new Keyframe(1380f, 673f, 1978f, 344f);
				array2[1] = new Keyframe(1776f, 1907f, 1633f, 1959f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1958f, true, new Vector2(1763f, 497f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(1992f, 1363f, 146f, 1976f);
				array3[0] = new Keyframe(1293f, 324f, 34f, 903f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 381f, true, new Vector2(1602f, 1484f));
				Keyframe[] array4 = new Keyframe[6];
				array4[1] = new Keyframe(254f, 1168f, 1766f, 1507f);
				array4[1] = new Keyframe(1191f, 619f, 1163f, 556f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 594f, false, new Vector2(929f, 1440f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1447f, true, new Vector2(1615f, 1278f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 520f, false, new Vector2(48f, 360f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 592f, false, new Vector2(1790f, 1280f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1055f, false, new Vector2(1075f, 1963f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600674E RID: 26446 RVA: 0x0033BBD0 File Offset: 0x00339DD0
			public static ColorGradingModel.CurvesSettings LCELIFBDEGJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(119f, 1427f, 1332f, 1939f);
				array[1] = new Keyframe(1617f, 276f, 900f, 252f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 175f, true, new Vector2(984f, 1346f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(352f, 295f, 349f, 345f);
				array2[1] = new Keyframe(601f, 1118f, 1730f, 1706f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1383f, true, new Vector2(1592f, 179f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(1909f, 814f, 1048f, 1951f);
				array3[0] = new Keyframe(124f, 1366f, 646f, 184f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 939f, false, new Vector2(1284f, 1f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(1610f, 851f, 906f, 1130f);
				array4[0] = new Keyframe(815f, 720f, 1001f, 1269f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 843f, true, new Vector2(1697f, 1626f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 555f, false, new Vector2(24f, 96f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 628f, false, new Vector2(265f, 987f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1936f, true, new Vector2(574f, 945f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 986f, true, new Vector2(165f, 1406f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600674F RID: 26447 RVA: 0x0033BE80 File Offset: 0x0033A080
			public static ColorGradingModel.CurvesSettings EMLBMMLLCKB()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(867f, 1287f, 292f, 1627f);
				array[1] = new Keyframe(293f, 1748f, 693f, 835f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1734f, false, new Vector2(1206f, 1205f));
				Keyframe[] array2 = new Keyframe[7];
				array2[0] = new Keyframe(1546f, 84f, 1985f, 1197f);
				array2[1] = new Keyframe(1676f, 239f, 1324f, 104f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1388f, true, new Vector2(1240f, 41f));
				Keyframe[] array3 = new Keyframe[8];
				array3[0] = new Keyframe(160f, 325f, 1948f, 922f);
				array3[0] = new Keyframe(1621f, 331f, 1295f, 273f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1066f, true, new Vector2(1572f, 73f));
				result.blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(902f, 1260f, 336f, 1947f),
					new Keyframe(1647f, 1727f, 648f, 649f)
				}), 746f, false, new Vector2(1963f, 187f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 239f, false, new Vector2(1053f, 1706f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 777f, false, new Vector2(1574f, 1967f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1257f, false, new Vector2(1069f, 1247f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1215f, false, new Vector2(1711f, 131f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06006750 RID: 26448 RVA: 0x0033C130 File Offset: 0x0033A330
			public static ColorGradingModel.CurvesSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.CurvesSettings
					{
						master = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						hueVShue = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						hueVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						satVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						lumVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						e_CurrentEditingCurve = 0,
						e_CurveY = true,
						e_CurveR = false,
						e_CurveG = false,
						e_CurveB = false
					};
				}
			}

			// Token: 0x06006751 RID: 26449 RVA: 0x0033C3E0 File Offset: 0x0033A5E0
			public static ColorGradingModel.CurvesSettings HFQJNGQQPDD()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(118f, 1593f, 756f, 1318f);
				array[0] = new Keyframe(1066f, 898f, 961f, 1882f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1393f, true, new Vector2(1961f, 1523f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(530f, 1853f, 590f, 2f);
				array2[1] = new Keyframe(1626f, 777f, 809f, 6f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 202f, true, new Vector2(1296f, 1636f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(403f, 655f, 1734f, 1242f)
				};
				array3[0] = new Keyframe(557f, 1492f, 636f, 1457f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1685f, false, new Vector2(317f, 87f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(1554f, 667f, 1163f, 1525f);
				array4[1] = new Keyframe(1568f, 1981f, 1257f, 304f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1349f, true, new Vector2(783f, 749f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1116f, true, new Vector2(1770f, 1262f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 563f, true, new Vector2(989f, 569f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 227f, false, new Vector2(1618f, 1486f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1038f, true, new Vector2(1133f, 317f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006752 RID: 26450 RVA: 0x0033C690 File Offset: 0x0033A890
			public static ColorGradingModel.CurvesSettings PIOFBQKIQEO()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1959f, 1372f, 1371f, 1388f);
				array[1] = new Keyframe(1043f, 172f, 1493f, 1362f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 431f, false, new Vector2(818f, 346f));
				Keyframe[] array2 = new Keyframe[8];
				array2[0] = new Keyframe(439f, 1742f, 461f, 54f);
				array2[1] = new Keyframe(1583f, 739f, 778f, 1443f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1219f, false, new Vector2(1453f, 1778f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(1042f, 823f, 1340f, 1943f);
				array3[1] = new Keyframe(699f, 1933f, 1517f, 112f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1122f, false, new Vector2(850f, 1851f));
				Keyframe[] array4 = new Keyframe[3];
				array4[1] = new Keyframe(1252f, 1759f, 631f, 1392f);
				array4[1] = new Keyframe(811f, 1992f, 858f, 1302f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 81f, true, new Vector2(594f, 1927f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 168f, true, new Vector2(1589f, 394f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 795f, false, new Vector2(1388f, 70f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1478f, false, new Vector2(145f, 1492f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 506f, false, new Vector2(348f, 931f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006753 RID: 26451 RVA: 0x0033C940 File Offset: 0x0033AB40
			public static ColorGradingModel.CurvesSettings JMFBQMKFLBG()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(990f, 1344f, 1730f, 1372f);
				array[0] = new Keyframe(1589f, 1382f, 1922f, 364f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 883f, false, new Vector2(1857f, 765f));
				Keyframe[] array2 = new Keyframe[0];
				array2[1] = new Keyframe(992f, 1332f, 1542f, 1662f);
				array2[0] = new Keyframe(1975f, 226f, 329f, 552f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1544f, true, new Vector2(845f, 420f));
				Keyframe[] array3 = new Keyframe[0];
				array3[0] = new Keyframe(1384f, 1744f, 700f, 1618f);
				array3[0] = new Keyframe(1176f, 761f, 676f, 160f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1002f, false, new Vector2(1868f, 916f));
				Keyframe[] array4 = new Keyframe[0];
				array4[0] = new Keyframe(1217f, 1197f, 1635f, 1092f);
				array4[1] = new Keyframe(919f, 514f, 41f, 1498f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 21f, false, new Vector2(1014f, 1178f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1828f, false, new Vector2(744f, 961f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1714f, true, new Vector2(1499f, 842f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1156f, true, new Vector2(1787f, 1905f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 230f, false, new Vector2(1381f, 659f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006754 RID: 26452 RVA: 0x0033CBF0 File Offset: 0x0033ADF0
			public static ColorGradingModel.CurvesSettings NLKNLIGKCIL()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(1079f, 1931f, 1809f, 614f);
				array[1] = new Keyframe(122f, 931f, 1476f, 368f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 764f, false, new Vector2(1571f, 139f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(1119f, 464f, 1423f, 379f);
				array2[1] = new Keyframe(1666f, 439f, 1447f, 894f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 665f, false, new Vector2(1500f, 1036f));
				Keyframe[] array3 = new Keyframe[8];
				array3[0] = new Keyframe(1813f, 250f, 163f, 1730f);
				array3[0] = new Keyframe(1912f, 1881f, 1243f, 1484f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1977f, true, new Vector2(742f, 1876f));
				Keyframe[] array4 = new Keyframe[7];
				array4[0] = new Keyframe(41f, 1011f, 837f, 449f);
				array4[0] = new Keyframe(521f, 415f, 388f, 130f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 484f, false, new Vector2(484f, 914f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1948f, false, new Vector2(622f, 1895f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1553f, true, new Vector2(950f, 54f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1407f, false, new Vector2(689f, 803f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1238f, true, new Vector2(1939f, 402f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006755 RID: 26453 RVA: 0x0033CEA0 File Offset: 0x0033B0A0
			public static ColorGradingModel.CurvesSettings HMNNEKFJMGP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(865f, 368f, 1883f, 306f);
				array[0] = new Keyframe(1244f, 983f, 183f, 61f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1495f, false, new Vector2(957f, 458f));
				Keyframe[] array2 = new Keyframe[3];
				array2[0] = new Keyframe(694f, 1785f, 251f, 887f);
				array2[0] = new Keyframe(1142f, 683f, 1280f, 1424f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1775f, false, new Vector2(1720f, 779f));
				Keyframe[] array3 = new Keyframe[5];
				array3[0] = new Keyframe(261f, 537f, 1114f, 260f);
				array3[0] = new Keyframe(1566f, 1939f, 1153f, 622f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 327f, false, new Vector2(1316f, 1916f));
				Keyframe[] array4 = new Keyframe[3];
				array4[0] = new Keyframe(1240f, 1058f, 463f, 753f);
				array4[0] = new Keyframe(302f, 1356f, 1208f, 187f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 296f, false, new Vector2(1087f, 459f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 531f, false, new Vector2(1523f, 204f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 986f, true, new Vector2(1234f, 1904f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1843f, false, new Vector2(1989f, 1255f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 755f, false, new Vector2(1628f, 560f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006756 RID: 26454 RVA: 0x0033D150 File Offset: 0x0033B350
			public static ColorGradingModel.CurvesSettings HONMJCFNNGI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1827f, 1756f, 1630f, 1242f);
				array[1] = new Keyframe(853f, 1443f, 368f, 469f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 508f, false, new Vector2(315f, 1356f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(646f, 1382f, 1954f, 139f);
				array2[1] = new Keyframe(1635f, 175f, 1498f, 1910f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1024f, false, new Vector2(1241f, 1056f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(1536f, 1718f, 937f, 221f);
				array3[1] = new Keyframe(167f, 1097f, 1646f, 637f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 278f, true, new Vector2(216f, 1089f));
				Keyframe[] array4 = new Keyframe[1];
				array4[0] = new Keyframe(1495f, 1902f, 1960f, 694f);
				array4[1] = new Keyframe(1108f, 1421f, 1063f, 1288f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 159f, true, new Vector2(257f, 1719f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 218f, false, new Vector2(1611f, 387f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1700f, true, new Vector2(971f, 911f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1378f, true, new Vector2(1620f, 596f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1549f, true, new Vector2(1316f, 1860f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006757 RID: 26455 RVA: 0x0033D400 File Offset: 0x0033B600
			public static ColorGradingModel.CurvesSettings BMQKJJQPIFJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1327f, 776f, 1758f, 869f);
				array[1] = new Keyframe(1201f, 1596f, 1524f, 161f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1583f, false, new Vector2(1161f, 258f));
				Keyframe[] array2 = new Keyframe[8];
				array2[0] = new Keyframe(1230f, 672f, 1210f, 60f);
				array2[0] = new Keyframe(1847f, 1186f, 1200f, 262f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1133f, true, new Vector2(1593f, 1914f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(678f, 1500f, 995f, 1534f);
				array3[1] = new Keyframe(938f, 1927f, 630f, 1139f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1954f, true, new Vector2(263f, 1744f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(220f, 401f, 1927f, 1954f)
				};
				array4[0] = new Keyframe(1485f, 1290f, 266f, 1952f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1362f, false, new Vector2(1575f, 1496f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1736f, false, new Vector2(1608f, 1682f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 71f, true, new Vector2(905f, 1347f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 165f, false, new Vector2(343f, 1214f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1302f, false, new Vector2(70f, 105f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06006758 RID: 26456 RVA: 0x0033D6B0 File Offset: 0x0033B8B0
			public static ColorGradingModel.CurvesSettings DNGJLKJBCMP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(973f, 1029f, 1512f, 267f);
				array[0] = new Keyframe(1917f, 1484f, 1650f, 755f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 752f, true, new Vector2(1892f, 1854f));
				Keyframe[] array2 = new Keyframe[3];
				array2[0] = new Keyframe(846f, 1685f, 1382f, 1171f);
				array2[1] = new Keyframe(1725f, 1930f, 1308f, 1859f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1248f, false, new Vector2(36f, 1763f));
				Keyframe[] array3 = new Keyframe[8];
				array3[1] = new Keyframe(893f, 558f, 1792f, 1134f);
				array3[0] = new Keyframe(89f, 417f, 1323f, 1769f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 20f, true, new Vector2(559f, 810f));
				Keyframe[] array4 = new Keyframe[1];
				array4[0] = new Keyframe(480f, 624f, 1886f, 684f);
				array4[1] = new Keyframe(1256f, 278f, 1445f, 1669f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 202f, true, new Vector2(1720f, 1653f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1018f, false, new Vector2(1880f, 1720f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1843f, true, new Vector2(1858f, 596f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 100f, false, new Vector2(219f, 245f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 428f, false, new Vector2(1612f, 1151f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06006759 RID: 26457 RVA: 0x0033D960 File Offset: 0x0033BB60
			public static ColorGradingModel.CurvesSettings GBGFECLLPHF()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(1598f, 1063f, 839f, 1547f);
				array[1] = new Keyframe(1349f, 437f, 1584f, 1114f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1150f, false, new Vector2(345f, 1169f));
				Keyframe[] array2 = new Keyframe[8];
				array2[0] = new Keyframe(1703f, 789f, 1150f, 325f);
				array2[0] = new Keyframe(1135f, 1639f, 376f, 742f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1113f, false, new Vector2(1485f, 534f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1429f, 1018f, 1950f, 1939f)
				};
				array3[0] = new Keyframe(678f, 1199f, 981f, 1248f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1378f, true, new Vector2(1641f, 261f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(1695f, 1145f, 846f, 180f);
				array4[0] = new Keyframe(1339f, 1448f, 674f, 320f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1759f, true, new Vector2(686f, 96f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 433f, true, new Vector2(1864f, 1903f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 995f, true, new Vector2(1721f, 1358f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 394f, true, new Vector2(1239f, 1446f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 504f, true, new Vector2(1901f, 946f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600675A RID: 26458 RVA: 0x0033DC10 File Offset: 0x0033BE10
			public static ColorGradingModel.CurvesSettings FDHLMPHBGMI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[5];
				array[0] = new Keyframe(586f, 1923f, 213f, 1398f);
				array[1] = new Keyframe(33f, 1245f, 1f, 1428f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 966f, true, new Vector2(666f, 1355f));
				Keyframe[] array2 = new Keyframe[8];
				array2[1] = new Keyframe(242f, 712f, 2f, 633f);
				array2[0] = new Keyframe(147f, 1646f, 761f, 1301f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 475f, true, new Vector2(16f, 1561f));
				Keyframe[] array3 = new Keyframe[0];
				array3[0] = new Keyframe(77f, 1324f, 1534f, 1959f);
				array3[1] = new Keyframe(1630f, 1420f, 1552f, 191f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1374f, true, new Vector2(688f, 1374f));
				Keyframe[] array4 = new Keyframe[1];
				array4[1] = new Keyframe(1272f, 1046f, 220f, 1733f);
				array4[0] = new Keyframe(1070f, 834f, 1991f, 680f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 515f, false, new Vector2(1161f, 912f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 922f, true, new Vector2(17f, 1684f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1924f, false, new Vector2(889f, 1970f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1132f, true, new Vector2(584f, 1558f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 821f, true, new Vector2(1810f, 1259f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600675B RID: 26459 RVA: 0x0033DEC0 File Offset: 0x0033C0C0
			public static ColorGradingModel.CurvesSettings LILIBDQEIBM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(669f, 955f, 262f, 411f)
				};
				array[0] = new Keyframe(1626f, 431f, 1524f, 1902f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 502f, false, new Vector2(67f, 1578f));
				Keyframe[] array2 = new Keyframe[0];
				array2[1] = new Keyframe(1969f, 126f, 1730f, 940f);
				array2[0] = new Keyframe(823f, 1725f, 1992f, 1281f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 249f, true, new Vector2(230f, 1492f));
				Keyframe[] array3 = new Keyframe[8];
				array3[1] = new Keyframe(1916f, 1071f, 1510f, 657f);
				array3[1] = new Keyframe(1215f, 1155f, 1963f, 1136f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 742f, false, new Vector2(622f, 1052f));
				Keyframe[] array4 = new Keyframe[3];
				array4[0] = new Keyframe(902f, 755f, 786f, 1373f);
				array4[0] = new Keyframe(1869f, 1977f, 1394f, 1893f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 380f, false, new Vector2(963f, 980f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 161f, false, new Vector2(1395f, 938f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1552f, false, new Vector2(585f, 1861f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 556f, false, new Vector2(184f, 254f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 813f, false, new Vector2(594f, 197f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600675C RID: 26460 RVA: 0x0033E170 File Offset: 0x0033C370
			public static ColorGradingModel.CurvesSettings KMKHPCKLFME()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(1151f, 1898f, 852f, 1827f);
				array[1] = new Keyframe(950f, 1172f, 1623f, 364f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 302f, true, new Vector2(573f, 1555f));
				Keyframe[] array2 = new Keyframe[0];
				array2[1] = new Keyframe(523f, 67f, 801f, 612f);
				array2[1] = new Keyframe(1974f, 423f, 1108f, 42f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1198f, false, new Vector2(1505f, 1056f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1220f, 1082f, 579f, 1687f)
				};
				array3[0] = new Keyframe(1500f, 609f, 1628f, 1681f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 931f, true, new Vector2(66f, 1313f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(106f, 1410f, 415f, 1687f);
				array4[1] = new Keyframe(476f, 734f, 1497f, 1231f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1252f, false, new Vector2(790f, 810f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 629f, false, new Vector2(1445f, 116f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 966f, true, new Vector2(1081f, 90f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1994f, true, new Vector2(1903f, 1815f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1913f, false, new Vector2(1119f, 1681f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x0600675D RID: 26461 RVA: 0x0033E420 File Offset: 0x0033C620
			public static ColorGradingModel.CurvesSettings OGDHJJODQGC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(1049f, 1950f, 1036f, 1189f);
				array[1] = new Keyframe(1778f, 1108f, 1818f, 427f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1740f, false, new Vector2(1705f, 914f));
				result.red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1600f, 372f, 1372f, 1674f),
					new Keyframe(331f, 185f, 1334f, 1166f)
				}), 555f, true, new Vector2(80f, 1526f));
				Keyframe[] array2 = new Keyframe[8];
				array2[0] = new Keyframe(280f, 783f, 133f, 1338f);
				array2[1] = new Keyframe(678f, 1365f, 1076f, 1175f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 157f, false, new Vector2(756f, 517f));
				Keyframe[] array3 = new Keyframe[5];
				array3[1] = new Keyframe(459f, 491f, 641f, 661f);
				array3[1] = new Keyframe(720f, 1973f, 98f, 889f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 354f, false, new Vector2(616f, 1869f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 633f, false, new Vector2(1698f, 1581f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1934f, true, new Vector2(1460f, 1307f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1571f, true, new Vector2(1499f, 1977f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 235f, true, new Vector2(197f, 1516f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x0600675E RID: 26462 RVA: 0x0033E6D0 File Offset: 0x0033C8D0
			public static ColorGradingModel.CurvesSettings GJCLCJLQNBK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(487f, 626f, 1823f, 1510f)
				};
				array[1] = new Keyframe(1895f, 1049f, 1080f, 979f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1985f, false, new Vector2(715f, 1257f));
				Keyframe[] array2 = new Keyframe[2];
				array2[0] = new Keyframe(1128f, 1410f, 645f, 1186f);
				array2[0] = new Keyframe(437f, 1381f, 1886f, 1708f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 973f, false, new Vector2(503f, 1567f));
				Keyframe[] array3 = new Keyframe[7];
				array3[0] = new Keyframe(1888f, 1688f, 1917f, 501f);
				array3[1] = new Keyframe(1816f, 760f, 1374f, 1902f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1878f, true, new Vector2(1332f, 1192f));
				Keyframe[] array4 = new Keyframe[0];
				array4[0] = new Keyframe(658f, 1272f, 1460f, 939f);
				array4[1] = new Keyframe(672f, 8f, 699f, 414f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 601f, true, new Vector2(740f, 114f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 537f, false, new Vector2(1391f, 1481f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1336f, false, new Vector2(97f, 1304f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 797f, false, new Vector2(1173f, 264f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 367f, false, new Vector2(742f, 1308f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x040015E0 RID: 5600
			public ColorGradingCurve master;

			// Token: 0x040015E1 RID: 5601
			public ColorGradingCurve red;

			// Token: 0x040015E2 RID: 5602
			public ColorGradingCurve green;

			// Token: 0x040015E3 RID: 5603
			public ColorGradingCurve blue;

			// Token: 0x040015E4 RID: 5604
			public ColorGradingCurve hueVShue;

			// Token: 0x040015E5 RID: 5605
			public ColorGradingCurve hueVSsat;

			// Token: 0x040015E6 RID: 5606
			public ColorGradingCurve satVSsat;

			// Token: 0x040015E7 RID: 5607
			public ColorGradingCurve lumVSsat;

			// Token: 0x040015E8 RID: 5608
			[HideInInspector]
			public int e_CurrentEditingCurve;

			// Token: 0x040015E9 RID: 5609
			[HideInInspector]
			public bool e_CurveY;

			// Token: 0x040015EA RID: 5610
			[HideInInspector]
			public bool e_CurveR;

			// Token: 0x040015EB RID: 5611
			[HideInInspector]
			public bool e_CurveG;

			// Token: 0x040015EC RID: 5612
			[HideInInspector]
			public bool e_CurveB;
		}

		// Token: 0x020002F6 RID: 758
		[Serializable]
		public struct Settings
		{
			// Token: 0x0600675F RID: 26463 RVA: 0x0033E980 File Offset: 0x0033CB80
			public static ColorGradingModel.Settings OGDHJJODQGC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.JMFBQMKFLBG(),
					basic = ColorGradingModel.BasicSettings.OKIFIQLFJMM(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.PBBBBNIEBDK(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OJCLCQNDJJJ(),
					curves = ColorGradingModel.CurvesSettings.FDHLMPHBGMI()
				};
			}

			// Token: 0x06006760 RID: 26464 RVA: 0x0033E9D4 File Offset: 0x0033CBD4
			public static ColorGradingModel.Settings FEDCFQNLCBP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.CBPCHEBOBNI(),
					basic = ColorGradingModel.BasicSettings.EMLBMMLLCKB(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMNNEKFJMGP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NKQIOFELGQF(),
					curves = ColorGradingModel.CurvesSettings.MBLKIINBGDI()
				};
			}

			// Token: 0x06006761 RID: 26465 RVA: 0x0033EA28 File Offset: 0x0033CC28
			public static ColorGradingModel.Settings IMIJNPIIHEK()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LIIQFPPIEKM(),
					basic = ColorGradingModel.BasicSettings.GJCLCJLQNBK(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMNNEKFJMGP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.LCELIFBDEGJ(),
					curves = ColorGradingModel.CurvesSettings.HMNNEKFJMGP()
				};
			}

			// Token: 0x06006762 RID: 26466 RVA: 0x0033EA7C File Offset: 0x0033CC7C
			public static ColorGradingModel.Settings JMFBQMKFLBG()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.OGDHJJODQGC(),
					basic = ColorGradingModel.BasicSettings.HFQJNGQQPDD(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
					colorWheels = ColorGradingModel.ColorWheelsSettings.EMLBMMLLCKB(),
					curves = ColorGradingModel.CurvesSettings.OGDHJJODQGC()
				};
			}

			// Token: 0x06006763 RID: 26467 RVA: 0x0033EAD0 File Offset: 0x0033CCD0
			public static ColorGradingModel.Settings HMNNEKFJMGP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.HMNNEKFJMGP(),
					basic = ColorGradingModel.BasicSettings.HFQJNGQQPDD(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.DNGJLKJBCMP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.HONMJCFNNGI(),
					curves = ColorGradingModel.CurvesSettings.HQDCCODHLJM()
				};
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06006764 RID: 26468 RVA: 0x0033EB24 File Offset: 0x0033CD24
			public static ColorGradingModel.Settings defaultSettings
			{
				get
				{
					return new ColorGradingModel.Settings
					{
						tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
						basic = ColorGradingModel.BasicSettings.defaultSettings,
						channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
						colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
						curves = ColorGradingModel.CurvesSettings.defaultSettings
					};
				}
			}

			// Token: 0x06006765 RID: 26469 RVA: 0x0033EB78 File Offset: 0x0033CD78
			public static ColorGradingModel.Settings PIOFBQKIQEO()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.PIOFBQKIQEO(),
					basic = ColorGradingModel.BasicSettings.MBLKIINBGDI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMNNEKFJMGP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.EMLBMMLLCKB(),
					curves = ColorGradingModel.CurvesSettings.BMQKJJQPIFJ()
				};
			}

			// Token: 0x06006766 RID: 26470 RVA: 0x0033EBCC File Offset: 0x0033CDCC
			public static ColorGradingModel.Settings DNGJLKJBCMP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.HFQJNGQQPDD(),
					basic = ColorGradingModel.BasicSettings.GJCLCJLQNBK(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NLKNLIGKCIL(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OGDHJJODQGC(),
					curves = ColorGradingModel.CurvesSettings.LCELIFBDEGJ()
				};
			}

			// Token: 0x06006767 RID: 26471 RVA: 0x0033EC20 File Offset: 0x0033CE20
			public static ColorGradingModel.Settings OJCLCQNDJJJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.IMIJNPIIHEK(),
					basic = ColorGradingModel.BasicSettings.LNHIGCOPCGM(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.EMLBMMLLCKB(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
					curves = ColorGradingModel.CurvesSettings.LCELIFBDEGJ()
				};
			}

			// Token: 0x06006768 RID: 26472 RVA: 0x0033EC74 File Offset: 0x0033CE74
			public static ColorGradingModel.Settings NKQIOFELGQF()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.FGIOKBBLFFK(),
					basic = ColorGradingModel.BasicSettings.KMKHPCKLFME(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.DNGJLKJBCMP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.KMKHPCKLFME(),
					curves = ColorGradingModel.CurvesSettings.GJCLCJLQNBK()
				};
			}

			// Token: 0x06006769 RID: 26473 RVA: 0x0033ECC8 File Offset: 0x0033CEC8
			public static ColorGradingModel.Settings NLKNLIGKCIL()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.DNGJLKJBCMP(),
					basic = ColorGradingModel.BasicSettings.JMFBQMKFLBG(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.OGDHJJODQGC(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OGDHJJODQGC(),
					curves = ColorGradingModel.CurvesSettings.HFQJNGQQPDD()
				};
			}

			// Token: 0x0600676A RID: 26474 RVA: 0x0033ED1C File Offset: 0x0033CF1C
			public static ColorGradingModel.Settings GJCLCJLQNBK()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.PIOFBQKIQEO(),
					basic = ColorGradingModel.BasicSettings.HFQJNGQQPDD(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
					colorWheels = ColorGradingModel.ColorWheelsSettings.LCELIFBDEGJ(),
					curves = ColorGradingModel.CurvesSettings.MBLKIINBGDI()
				};
			}

			// Token: 0x0600676B RID: 26475 RVA: 0x0033ED70 File Offset: 0x0033CF70
			public static ColorGradingModel.Settings LNHIGCOPCGM()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LILIBDQEIBM(),
					basic = ColorGradingModel.BasicSettings.LCELIFBDEGJ(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LCELIFBDEGJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NLKNLIGKCIL(),
					curves = ColorGradingModel.CurvesSettings.JMFBQMKFLBG()
				};
			}

			// Token: 0x0600676C RID: 26476 RVA: 0x0033EDC4 File Offset: 0x0033CFC4
			public static ColorGradingModel.Settings PBBBBNIEBDK()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.NLKNLIGKCIL(),
					basic = ColorGradingModel.BasicSettings.HFQJNGQQPDD(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.EKBHCDLLDKG(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OJCLCQNDJJJ(),
					curves = ColorGradingModel.CurvesSettings.NLKNLIGKCIL()
				};
			}

			// Token: 0x0600676D RID: 26477 RVA: 0x0033EE18 File Offset: 0x0033D018
			public static ColorGradingModel.Settings LNQMILQOBHP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LNHIGCOPCGM(),
					basic = ColorGradingModel.BasicSettings.EKBHCDLLDKG(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FGIOKBBLFFK(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.FGIOKBBLFFK(),
					curves = ColorGradingModel.CurvesSettings.JMFBQMKFLBG()
				};
			}

			// Token: 0x0600676E RID: 26478 RVA: 0x0033EE6C File Offset: 0x0033D06C
			public static ColorGradingModel.Settings OKIFIQLFJMM()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LCELIFBDEGJ(),
					basic = ColorGradingModel.BasicSettings.FDHLMPHBGMI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMNNEKFJMGP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.FGIOKBBLFFK(),
					curves = ColorGradingModel.CurvesSettings.FDHLMPHBGMI()
				};
			}

			// Token: 0x0600676F RID: 26479 RVA: 0x0033EEC0 File Offset: 0x0033D0C0
			public static ColorGradingModel.Settings FDHLMPHBGMI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
					basic = ColorGradingModel.BasicSettings.LILIBDQEIBM(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
					colorWheels = ColorGradingModel.ColorWheelsSettings.LNHIGCOPCGM(),
					curves = ColorGradingModel.CurvesSettings.FDHLMPHBGMI()
				};
			}

			// Token: 0x06006770 RID: 26480 RVA: 0x0033EF14 File Offset: 0x0033D114
			public static ColorGradingModel.Settings HONMJCFNNGI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.OKIFIQLFJMM(),
					basic = ColorGradingModel.BasicSettings.NKQIOFELGQF(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LIIQFPPIEKM(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.LIIQFPPIEKM(),
					curves = ColorGradingModel.CurvesSettings.FEDCFQNLCBP()
				};
			}

			// Token: 0x06006771 RID: 26481 RVA: 0x0033EF68 File Offset: 0x0033D168
			public static ColorGradingModel.Settings MBLKIINBGDI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.PIOFBQKIQEO(),
					basic = ColorGradingModel.BasicSettings.LNQMILQOBHP(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LIIQFPPIEKM(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NLKNLIGKCIL(),
					curves = ColorGradingModel.CurvesSettings.OGDHJJODQGC()
				};
			}

			// Token: 0x06006772 RID: 26482 RVA: 0x0033EFBC File Offset: 0x0033D1BC
			public static ColorGradingModel.Settings LCELIFBDEGJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.EKBHCDLLDKG(),
					basic = ColorGradingModel.BasicSettings.PIOFBQKIQEO(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.OGDHJJODQGC(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MBLKIINBGDI(),
					curves = ColorGradingModel.CurvesSettings.JMFBQMKFLBG()
				};
			}

			// Token: 0x06006773 RID: 26483 RVA: 0x0033F010 File Offset: 0x0033D210
			public static ColorGradingModel.Settings CBPCHEBOBNI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.HMNNEKFJMGP(),
					basic = ColorGradingModel.BasicSettings.MBLKIINBGDI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FDHLMPHBGMI(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.LILIBDQEIBM(),
					curves = ColorGradingModel.CurvesSettings.FGIOKBBLFFK()
				};
			}

			// Token: 0x06006774 RID: 26484 RVA: 0x0033F064 File Offset: 0x0033D264
			public static ColorGradingModel.Settings FGIOKBBLFFK()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
					basic = ColorGradingModel.BasicSettings.FGIOKBBLFFK(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NLKNLIGKCIL(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.PBBBBNIEBDK(),
					curves = ColorGradingModel.CurvesSettings.FDHLMPHBGMI()
				};
			}

			// Token: 0x06006775 RID: 26485 RVA: 0x0033F0B8 File Offset: 0x0033D2B8
			public static ColorGradingModel.Settings EKBHCDLLDKG()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.KMKHPCKLFME(),
					basic = ColorGradingModel.BasicSettings.FGIOKBBLFFK(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LCELIFBDEGJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.KMKHPCKLFME(),
					curves = ColorGradingModel.CurvesSettings.MBLKIINBGDI()
				};
			}

			// Token: 0x06006776 RID: 26486 RVA: 0x0033F10C File Offset: 0x0033D30C
			public static ColorGradingModel.Settings KMKHPCKLFME()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.OJCLCQNDJJJ(),
					basic = ColorGradingModel.BasicSettings.GODFBEDNBDB(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMNNEKFJMGP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OGDHJJODQGC(),
					curves = ColorGradingModel.CurvesSettings.PBBBBNIEBDK()
				};
			}

			// Token: 0x06006777 RID: 26487 RVA: 0x0033F160 File Offset: 0x0033D360
			public static ColorGradingModel.Settings LIIQFPPIEKM()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.EKBHCDLLDKG(),
					basic = ColorGradingModel.BasicSettings.EMLBMMLLCKB(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LCELIFBDEGJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NLKNLIGKCIL(),
					curves = ColorGradingModel.CurvesSettings.IMIJNPIIHEK()
				};
			}

			// Token: 0x06006778 RID: 26488 RVA: 0x0033F1B4 File Offset: 0x0033D3B4
			public static ColorGradingModel.Settings BMQKJJQPIFJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LIIQFPPIEKM(),
					basic = ColorGradingModel.BasicSettings.LILIBDQEIBM(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.OGDHJJODQGC(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NKQIOFELGQF(),
					curves = ColorGradingModel.CurvesSettings.HONMJCFNNGI()
				};
			}

			// Token: 0x06006779 RID: 26489 RVA: 0x0033F208 File Offset: 0x0033D408
			public static ColorGradingModel.Settings BKOQOBFCMNJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.PIOFBQKIQEO(),
					basic = ColorGradingModel.BasicSettings.EKBHCDLLDKG(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.LCELIFBDEGJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.LILIBDQEIBM(),
					curves = ColorGradingModel.CurvesSettings.BKOQOBFCMNJ()
				};
			}

			// Token: 0x0600677A RID: 26490 RVA: 0x0033F25C File Offset: 0x0033D45C
			public static ColorGradingModel.Settings HMKPKOMGPQC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.FGIOKBBLFFK(),
					basic = ColorGradingModel.BasicSettings.FGIOKBBLFFK(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FGIOKBBLFFK(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MBLKIINBGDI(),
					curves = ColorGradingModel.CurvesSettings.NKQIOFELGQF()
				};
			}

			// Token: 0x0600677B RID: 26491 RVA: 0x0033F2B0 File Offset: 0x0033D4B0
			public static ColorGradingModel.Settings LILIBDQEIBM()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.JMFBQMKFLBG(),
					basic = ColorGradingModel.BasicSettings.OGDHJJODQGC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NLKNLIGKCIL(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
					curves = ColorGradingModel.CurvesSettings.BMQKJJQPIFJ()
				};
			}

			// Token: 0x0600677C RID: 26492 RVA: 0x0033F304 File Offset: 0x0033D504
			public static ColorGradingModel.Settings EMLBMMLLCKB()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.PIOFBQKIQEO(),
					basic = ColorGradingModel.BasicSettings.PIOFBQKIQEO(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.EMLBMMLLCKB(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.DNGJLKJBCMP(),
					curves = ColorGradingModel.CurvesSettings.KMKHPCKLFME()
				};
			}

			// Token: 0x040015ED RID: 5613
			public ColorGradingModel.TonemappingSettings tonemapping;

			// Token: 0x040015EE RID: 5614
			public ColorGradingModel.BasicSettings basic;

			// Token: 0x040015EF RID: 5615
			public ColorGradingModel.ChannelMixerSettings channelMixer;

			// Token: 0x040015F0 RID: 5616
			public ColorGradingModel.ColorWheelsSettings colorWheels;

			// Token: 0x040015F1 RID: 5617
			public ColorGradingModel.CurvesSettings curves;
		}
	}
}
