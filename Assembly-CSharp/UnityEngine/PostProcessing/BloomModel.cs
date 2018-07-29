using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020002E1 RID: 737
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x0600651C RID: 25884 RVA: 0x00027235 File Offset: 0x00025435
		public BloomModel.Settings DCBJMHJEFMG()
		{
			return this.m_Settings;
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x0002723D File Offset: 0x0002543D
		public virtual void CEPOGHLOKDQ()
		{
			this.m_Settings = BloomModel.Settings.OGDHJJODQGC();
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x0002724A File Offset: 0x0002544A
		public void EOONHGFEMDO(BloomModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x00027235 File Offset: 0x00025435
		// (set) Token: 0x06006520 RID: 25888 RVA: 0x0002724A File Offset: 0x0002544A
		public BloomModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
			}
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x00027235 File Offset: 0x00025435
		public BloomModel.Settings OILMJDEQKHM()
		{
			return this.m_Settings;
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x00027266 File Offset: 0x00025466
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = BloomModel.Settings.defaultSettings;
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x0002724A File Offset: 0x0002544A
		public void IFCNCMMGCFN(BloomModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00027235 File Offset: 0x00025435
		public BloomModel.Settings ECJPKDFIPOD()
		{
			return this.m_Settings;
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x00027273 File Offset: 0x00025473
		public virtual void BQKCLGJEPBE()
		{
			this.m_Settings = BloomModel.Settings.NKQIOFELGQF();
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x0002724A File Offset: 0x0002544A
		public void JOHIKMKJLBL(BloomModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x0002724A File Offset: 0x0002544A
		public void FBHPICJCHLD(BloomModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x00027235 File Offset: 0x00025435
		public BloomModel.Settings QKIEQHKDJEP()
		{
			return this.m_Settings;
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x00027280 File Offset: 0x00025480
		public virtual void IDHJPEODHPE()
		{
			this.m_Settings = BloomModel.Settings.HMNNEKFJMGP();
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x0002728D File Offset: 0x0002548D
		public virtual void IDBKHCEGEOD()
		{
			this.m_Settings = BloomModel.Settings.OJCLCQNDJJJ();
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x0002729A File Offset: 0x0002549A
		public virtual void FKIQMCIHFOO()
		{
			this.m_Settings = BloomModel.Settings.IMIJNPIIHEK();
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0002724A File Offset: 0x0002544A
		public void DGLGPOBMNLQ(BloomModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x04001599 RID: 5529
		[SerializeField]
		private BloomModel.Settings m_Settings = BloomModel.Settings.defaultSettings;

		// Token: 0x020002E2 RID: 738
		[Serializable]
		public struct BloomSettings
		{
			// Token: 0x0600652E RID: 25902 RVA: 0x000272A7 File Offset: 0x000254A7
			public float LJPBGEIBQJN()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x0600652F RID: 25903 RVA: 0x000272A7 File Offset: 0x000254A7
			// (set) Token: 0x06006530 RID: 25904 RVA: 0x000272B4 File Offset: 0x000254B4
			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(this.threshold);
				}
				set
				{
					this.threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			// Token: 0x06006531 RID: 25905 RVA: 0x000272A7 File Offset: 0x000254A7
			public float KFNLHNPCFQJ()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x06006532 RID: 25906 RVA: 0x000272B4 File Offset: 0x000254B4
			public void NCHPIOBOKHH(float BGBMIEJJQKC)
			{
				this.threshold = Mathf.LinearToGammaSpace(BGBMIEJJQKC);
			}

			// Token: 0x06006533 RID: 25907 RVA: 0x00332F5C File Offset: 0x0033115C
			public static BloomModel.BloomSettings HONMJCFNNGI()
			{
				return new BloomModel.BloomSettings
				{
					intensity = 544f,
					threshold = 788f,
					softKnee = 456f,
					radius = 1761f,
					antiFlicker = true
				};
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06006534 RID: 25908 RVA: 0x00332FAC File Offset: 0x003311AC
			public static BloomModel.BloomSettings defaultSettings
			{
				get
				{
					return new BloomModel.BloomSettings
					{
						intensity = 0.5f,
						threshold = 1.1f,
						softKnee = 0.5f,
						radius = 4f,
						antiFlicker = false
					};
				}
			}

			// Token: 0x06006535 RID: 25909 RVA: 0x000272A7 File Offset: 0x000254A7
			public float IDJGHCKGFMQ()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x06006536 RID: 25910 RVA: 0x00332FFC File Offset: 0x003311FC
			public static BloomModel.BloomSettings MBLKIINBGDI()
			{
				return new BloomModel.BloomSettings
				{
					intensity = 1064f,
					threshold = 327f,
					softKnee = 1382f,
					radius = 1719f,
					antiFlicker = false
				};
			}

			// Token: 0x06006537 RID: 25911 RVA: 0x000272A7 File Offset: 0x000254A7
			public float KGOBFQBKHPI()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x06006538 RID: 25912 RVA: 0x000272A7 File Offset: 0x000254A7
			public float EFLNPKQDIKM()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x06006539 RID: 25913 RVA: 0x000272A7 File Offset: 0x000254A7
			public float HLMHKKKJJIC()
			{
				return Mathf.GammaToLinearSpace(this.threshold);
			}

			// Token: 0x0600653A RID: 25914 RVA: 0x0033304C File Offset: 0x0033124C
			public static BloomModel.BloomSettings FGIOKBBLFFK()
			{
				return new BloomModel.BloomSettings
				{
					intensity = 1727f,
					threshold = 990f,
					softKnee = 162f,
					radius = 721f,
					antiFlicker = false
				};
			}

			// Token: 0x0400159A RID: 5530
			[MHLQLMPHPHO(0f)]
			[Tooltip("Strength of the bloom filter.")]
			public float intensity;

			// Token: 0x0400159B RID: 5531
			[Tooltip("Filters out pixels under this level of brightness.")]
			[MHLQLMPHPHO(0f)]
			public float threshold;

			// Token: 0x0400159C RID: 5532
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			// Token: 0x0400159D RID: 5533
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x0400159E RID: 5534
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;
		}

		// Token: 0x020002E3 RID: 739
		[Serializable]
		public struct LensDirtSettings
		{
			// Token: 0x0600653B RID: 25915 RVA: 0x0033309C File Offset: 0x0033129C
			public static BloomModel.LensDirtSettings NLKNLIGKCIL()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 328f
				};
			}

			// Token: 0x0600653C RID: 25916 RVA: 0x003330C8 File Offset: 0x003312C8
			public static BloomModel.LensDirtSettings PBBBBNIEBDK()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1089f
				};
			}

			// Token: 0x0600653D RID: 25917 RVA: 0x003330F4 File Offset: 0x003312F4
			public static BloomModel.LensDirtSettings LCELIFBDEGJ()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 18f
				};
			}

			// Token: 0x0600653E RID: 25918 RVA: 0x00333120 File Offset: 0x00331320
			public static BloomModel.LensDirtSettings FDHLMPHBGMI()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 869f
				};
			}

			// Token: 0x0600653F RID: 25919 RVA: 0x0033314C File Offset: 0x0033134C
			public static BloomModel.LensDirtSettings LNHIGCOPCGM()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1946f
				};
			}

			// Token: 0x06006540 RID: 25920 RVA: 0x00333178 File Offset: 0x00331378
			public static BloomModel.LensDirtSettings LILIBDQEIBM()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 677f
				};
			}

			// Token: 0x06006541 RID: 25921 RVA: 0x003331A4 File Offset: 0x003313A4
			public static BloomModel.LensDirtSettings EMLBMMLLCKB()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1340f
				};
			}

			// Token: 0x06006542 RID: 25922 RVA: 0x003331D0 File Offset: 0x003313D0
			public static BloomModel.LensDirtSettings LIIQFPPIEKM()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 497f
				};
			}

			// Token: 0x06006543 RID: 25923 RVA: 0x003331FC File Offset: 0x003313FC
			public static BloomModel.LensDirtSettings FGIOKBBLFFK()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1118f
				};
			}

			// Token: 0x06006544 RID: 25924 RVA: 0x00333228 File Offset: 0x00331428
			public static BloomModel.LensDirtSettings EKBHCDLLDKG()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 462f
				};
			}

			// Token: 0x06006545 RID: 25925 RVA: 0x00333254 File Offset: 0x00331454
			public static BloomModel.LensDirtSettings OGDHJJODQGC()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1160f
				};
			}

			// Token: 0x06006546 RID: 25926 RVA: 0x00333280 File Offset: 0x00331480
			public static BloomModel.LensDirtSettings HMNNEKFJMGP()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1262f
				};
			}

			// Token: 0x06006547 RID: 25927 RVA: 0x003332AC File Offset: 0x003314AC
			public static BloomModel.LensDirtSettings HONMJCFNNGI()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 523f
				};
			}

			// Token: 0x06006548 RID: 25928 RVA: 0x003332D8 File Offset: 0x003314D8
			public static BloomModel.LensDirtSettings MBLKIINBGDI()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 759f
				};
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06006549 RID: 25929 RVA: 0x00333304 File Offset: 0x00331504
			public static BloomModel.LensDirtSettings defaultSettings
			{
				get
				{
					return new BloomModel.LensDirtSettings
					{
						texture = null,
						intensity = 3f
					};
				}
			}

			// Token: 0x0600654A RID: 25930 RVA: 0x00333330 File Offset: 0x00331530
			public static BloomModel.LensDirtSettings DNGJLKJBCMP()
			{
				return new BloomModel.LensDirtSettings
				{
					texture = null,
					intensity = 1275f
				};
			}

			// Token: 0x0400159F RID: 5535
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			// Token: 0x040015A0 RID: 5536
			[MHLQLMPHPHO(0f)]
			[Tooltip("Amount of lens dirtiness.")]
			public float intensity;
		}

		// Token: 0x020002E4 RID: 740
		[Serializable]
		public struct Settings
		{
			// Token: 0x0600654B RID: 25931 RVA: 0x0033335C File Offset: 0x0033155C
			public static BloomModel.Settings LIIQFPPIEKM()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.HONMJCFNNGI()
				};
			}

			// Token: 0x0600654C RID: 25932 RVA: 0x0033338C File Offset: 0x0033158C
			public static BloomModel.Settings NLKNLIGKCIL()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.FGIOKBBLFFK()
				};
			}

			// Token: 0x0600654D RID: 25933 RVA: 0x003333BC File Offset: 0x003315BC
			public static BloomModel.Settings FEDCFQNLCBP()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.NLKNLIGKCIL()
				};
			}

			// Token: 0x0600654E RID: 25934 RVA: 0x003333EC File Offset: 0x003315EC
			public static BloomModel.Settings EMLBMMLLCKB()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.defaultSettings,
					lensDirt = BloomModel.LensDirtSettings.LNHIGCOPCGM()
				};
			}

			// Token: 0x0600654F RID: 25935 RVA: 0x0033341C File Offset: 0x0033161C
			public static BloomModel.Settings FDHLMPHBGMI()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.HMNNEKFJMGP()
				};
			}

			// Token: 0x06006550 RID: 25936 RVA: 0x0033344C File Offset: 0x0033164C
			public static BloomModel.Settings OJCLCQNDJJJ()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.LIIQFPPIEKM()
				};
			}

			// Token: 0x06006551 RID: 25937 RVA: 0x0033347C File Offset: 0x0033167C
			public static BloomModel.Settings IMIJNPIIHEK()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.NLKNLIGKCIL()
				};
			}

			// Token: 0x06006552 RID: 25938 RVA: 0x003334AC File Offset: 0x003316AC
			public static BloomModel.Settings HMNNEKFJMGP()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.LCELIFBDEGJ()
				};
			}

			// Token: 0x06006553 RID: 25939 RVA: 0x003334DC File Offset: 0x003316DC
			public static BloomModel.Settings DNGJLKJBCMP()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.EKBHCDLLDKG()
				};
			}

			// Token: 0x06006554 RID: 25940 RVA: 0x0033350C File Offset: 0x0033170C
			public static BloomModel.Settings KMKHPCKLFME()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.LILIBDQEIBM()
				};
			}

			// Token: 0x06006555 RID: 25941 RVA: 0x003334AC File Offset: 0x003316AC
			public static BloomModel.Settings EKBHCDLLDKG()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.LCELIFBDEGJ()
				};
			}

			// Token: 0x06006556 RID: 25942 RVA: 0x0033353C File Offset: 0x0033173C
			public static BloomModel.Settings PIOFBQKIQEO()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.MBLKIINBGDI()
				};
			}

			// Token: 0x06006557 RID: 25943 RVA: 0x0033356C File Offset: 0x0033176C
			public static BloomModel.Settings FGIOKBBLFFK()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.LIIQFPPIEKM()
				};
			}

			// Token: 0x06006558 RID: 25944 RVA: 0x003333BC File Offset: 0x003315BC
			public static BloomModel.Settings LNHIGCOPCGM()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.NLKNLIGKCIL()
				};
			}

			// Token: 0x06006559 RID: 25945 RVA: 0x0033359C File Offset: 0x0033179C
			public static BloomModel.Settings LILIBDQEIBM()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.defaultSettings,
					lensDirt = BloomModel.LensDirtSettings.OGDHJJODQGC()
				};
			}

			// Token: 0x0600655A RID: 25946 RVA: 0x003333EC File Offset: 0x003315EC
			public static BloomModel.Settings OGDHJJODQGC()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.defaultSettings,
					lensDirt = BloomModel.LensDirtSettings.LNHIGCOPCGM()
				};
			}

			// Token: 0x0600655B RID: 25947 RVA: 0x003335CC File Offset: 0x003317CC
			public static BloomModel.Settings PBBBBNIEBDK()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.DNGJLKJBCMP()
				};
			}

			// Token: 0x0600655C RID: 25948 RVA: 0x0033356C File Offset: 0x0033176C
			public static BloomModel.Settings JMFBQMKFLBG()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.LIIQFPPIEKM()
				};
			}

			// Token: 0x0600655D RID: 25949 RVA: 0x003335FC File Offset: 0x003317FC
			public static BloomModel.Settings HMKPKOMGPQC()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.HONMJCFNNGI()
				};
			}

			// Token: 0x0600655E RID: 25950 RVA: 0x0033362C File Offset: 0x0033182C
			public static BloomModel.Settings HONMJCFNNGI()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.MBLKIINBGDI(),
					lensDirt = BloomModel.LensDirtSettings.EMLBMMLLCKB()
				};
			}

			// Token: 0x0600655F RID: 25951 RVA: 0x0033365C File Offset: 0x0033185C
			public static BloomModel.Settings BMQKJJQPIFJ()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.MBLKIINBGDI()
				};
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06006560 RID: 25952 RVA: 0x0033368C File Offset: 0x0033188C
			public static BloomModel.Settings defaultSettings
			{
				get
				{
					return new BloomModel.Settings
					{
						bloom = BloomModel.BloomSettings.defaultSettings,
						lensDirt = BloomModel.LensDirtSettings.defaultSettings
					};
				}
			}

			// Token: 0x06006561 RID: 25953 RVA: 0x003336BC File Offset: 0x003318BC
			public static BloomModel.Settings NKQIOFELGQF()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.FGIOKBBLFFK(),
					lensDirt = BloomModel.LensDirtSettings.DNGJLKJBCMP()
				};
			}

			// Token: 0x06006562 RID: 25954 RVA: 0x003335FC File Offset: 0x003317FC
			public static BloomModel.Settings LCELIFBDEGJ()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.HONMJCFNNGI()
				};
			}

			// Token: 0x06006563 RID: 25955 RVA: 0x003336EC File Offset: 0x003318EC
			public static BloomModel.Settings MBLKIINBGDI()
			{
				return new BloomModel.Settings
				{
					bloom = BloomModel.BloomSettings.HONMJCFNNGI(),
					lensDirt = BloomModel.LensDirtSettings.FDHLMPHBGMI()
				};
			}

			// Token: 0x040015A1 RID: 5537
			public BloomModel.BloomSettings bloom;

			// Token: 0x040015A2 RID: 5538
			public BloomModel.LensDirtSettings lensDirt;
		}
	}
}
