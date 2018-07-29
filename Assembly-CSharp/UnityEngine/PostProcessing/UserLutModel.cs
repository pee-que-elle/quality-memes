using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200030C RID: 780
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x0600693E RID: 26942 RVA: 0x00027C97 File Offset: 0x00025E97
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = UserLutModel.Settings.defaultSettings;
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00027CA4 File Offset: 0x00025EA4
		public void CJFBEEEEGPQ(UserLutModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00027CAD File Offset: 0x00025EAD
		public virtual void MEGGNILIHIN()
		{
			this.m_Settings = UserLutModel.Settings.GODFBEDNBDB();
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00027CBA File Offset: 0x00025EBA
		public virtual void IDBKHCEGEOD()
		{
			this.m_Settings = UserLutModel.Settings.HMNNEKFJMGP();
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00027CC7 File Offset: 0x00025EC7
		public virtual void BQKCLGJEPBE()
		{
			this.m_Settings = UserLutModel.Settings.OGDHJJODQGC();
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x00027CD4 File Offset: 0x00025ED4
		public virtual void KBHJOBPONEN()
		{
			this.m_Settings = UserLutModel.Settings.EMLBMMLLCKB();
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings LPNEBDNLDDB()
		{
			return this.m_Settings;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06006945 RID: 26949 RVA: 0x00027CE1 File Offset: 0x00025EE1
		// (set) Token: 0x06006948 RID: 26952 RVA: 0x00027CA4 File Offset: 0x00025EA4
		public UserLutModel.Settings settings
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

		// Token: 0x06006947 RID: 26951 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings HKOKEQMOINC()
		{
			return this.m_Settings;
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00027CA4 File Offset: 0x00025EA4
		public void EOONHGFEMDO(UserLutModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x00027CA4 File Offset: 0x00025EA4
		public void PKPPHCBPDQL(UserLutModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x00027CFC File Offset: 0x00025EFC
		public virtual void NLQMHFFCHDI()
		{
			this.m_Settings = UserLutModel.Settings.OQGIEDOFKDG();
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings OILMJDEQKHM()
		{
			return this.m_Settings;
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x00027D09 File Offset: 0x00025F09
		public virtual void DPFCMCGJBIQ()
		{
			this.m_Settings = UserLutModel.Settings.FEDCFQNLCBP();
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings POHNNDKPEDF()
		{
			return this.m_Settings;
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x00027D16 File Offset: 0x00025F16
		public virtual void QOMKBIQNHPD()
		{
			this.m_Settings = UserLutModel.Settings.BKOQOBFCMNJ();
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings QLIGQMEDNJC()
		{
			return this.m_Settings;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x00027CA4 File Offset: 0x00025EA4
		public void CGGJFJNBDJC(UserLutModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public UserLutModel.Settings KNBMBCNPNLF()
		{
			return this.m_Settings;
		}

		// Token: 0x0400162F RID: 5679
		[SerializeField]
		private UserLutModel.Settings m_Settings = UserLutModel.Settings.defaultSettings;

		// Token: 0x0200030D RID: 781
		[Serializable]
		public struct Settings
		{
			// Token: 0x06006953 RID: 26963 RVA: 0x00342F88 File Offset: 0x00341188
			public static UserLutModel.Settings BMQKJJQPIFJ()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 482f
				};
			}

			// Token: 0x06006954 RID: 26964 RVA: 0x00342FB4 File Offset: 0x003411B4
			public static UserLutModel.Settings NKQIOFELGQF()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 150f
				};
			}

			// Token: 0x06006955 RID: 26965 RVA: 0x00342FE0 File Offset: 0x003411E0
			public static UserLutModel.Settings KLCDJPIPPOH()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 50f
				};
			}

			// Token: 0x06006956 RID: 26966 RVA: 0x0034300C File Offset: 0x0034120C
			public static UserLutModel.Settings EMLBMMLLCKB()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 598f
				};
			}

			// Token: 0x06006957 RID: 26967 RVA: 0x00343038 File Offset: 0x00341238
			public static UserLutModel.Settings IQKKKIJHEOC()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 714f
				};
			}

			// Token: 0x06006958 RID: 26968 RVA: 0x00343064 File Offset: 0x00341264
			public static UserLutModel.Settings LNQMILQOBHP()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 955f
				};
			}

			// Token: 0x06006959 RID: 26969 RVA: 0x00343090 File Offset: 0x00341290
			public static UserLutModel.Settings PBBBBNIEBDK()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1627f
				};
			}

			// Token: 0x0600695A RID: 26970 RVA: 0x003430BC File Offset: 0x003412BC
			public static UserLutModel.Settings DNGJLKJBCMP()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 902f
				};
			}

			// Token: 0x0600695B RID: 26971 RVA: 0x003430E8 File Offset: 0x003412E8
			public static UserLutModel.Settings EKBHCDLLDKG()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1852f
				};
			}

			// Token: 0x0600695C RID: 26972 RVA: 0x00343114 File Offset: 0x00341314
			public static UserLutModel.Settings OKIFIQLFJMM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 819f
				};
			}

			// Token: 0x0600695D RID: 26973 RVA: 0x00343140 File Offset: 0x00341340
			public static UserLutModel.Settings OGDHJJODQGC()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 766f
				};
			}

			// Token: 0x0600695E RID: 26974 RVA: 0x0034316C File Offset: 0x0034136C
			public static UserLutModel.Settings QFDEQMDDPLQ()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 7f
				};
			}

			// Token: 0x0600695F RID: 26975 RVA: 0x00343198 File Offset: 0x00341398
			public static UserLutModel.Settings HMNNEKFJMGP()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1534f
				};
			}

			// Token: 0x06006960 RID: 26976 RVA: 0x003431C4 File Offset: 0x003413C4
			public static UserLutModel.Settings ECDEKIGEPNC()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1051f
				};
			}

			// Token: 0x06006961 RID: 26977 RVA: 0x003431F0 File Offset: 0x003413F0
			public static UserLutModel.Settings PIOFBQKIQEO()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1875f
				};
			}

			// Token: 0x06006962 RID: 26978 RVA: 0x0034321C File Offset: 0x0034141C
			public static UserLutModel.Settings LIIQFPPIEKM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 444f
				};
			}

			// Token: 0x06006963 RID: 26979 RVA: 0x00343248 File Offset: 0x00341448
			public static UserLutModel.Settings MBLKIINBGDI()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1473f
				};
			}

			// Token: 0x06006964 RID: 26980 RVA: 0x00343274 File Offset: 0x00341474
			public static UserLutModel.Settings FGIOKBBLFFK()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 190f
				};
			}

			// Token: 0x06006965 RID: 26981 RVA: 0x003432A0 File Offset: 0x003414A0
			public static UserLutModel.Settings FEDCFQNLCBP()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 378f
				};
			}

			// Token: 0x06006966 RID: 26982 RVA: 0x003432CC File Offset: 0x003414CC
			public static UserLutModel.Settings BMDHMEEIQQM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 423f
				};
			}

			// Token: 0x06006967 RID: 26983 RVA: 0x003432F8 File Offset: 0x003414F8
			public static UserLutModel.Settings OJCLCQNDJJJ()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 834f
				};
			}

			// Token: 0x06006968 RID: 26984 RVA: 0x00343324 File Offset: 0x00341524
			public static UserLutModel.Settings LILIBDQEIBM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 477f
				};
			}

			// Token: 0x06006969 RID: 26985 RVA: 0x00343350 File Offset: 0x00341550
			public static UserLutModel.Settings OQGIEDOFKDG()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1063f
				};
			}

			// Token: 0x0600696A RID: 26986 RVA: 0x0034337C File Offset: 0x0034157C
			public static UserLutModel.Settings BKOQOBFCMNJ()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1037f
				};
			}

			// Token: 0x0600696B RID: 26987 RVA: 0x003433A8 File Offset: 0x003415A8
			public static UserLutModel.Settings GBGFECLLPHF()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1295f
				};
			}

			// Token: 0x0600696C RID: 26988 RVA: 0x003433D4 File Offset: 0x003415D4
			public static UserLutModel.Settings FDHLMPHBGMI()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 36f
				};
			}

			// Token: 0x0600696D RID: 26989 RVA: 0x00343400 File Offset: 0x00341600
			public static UserLutModel.Settings HQDCCODHLJM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1154f
				};
			}

			// Token: 0x0600696E RID: 26990 RVA: 0x0034342C File Offset: 0x0034162C
			public static UserLutModel.Settings LNHIGCOPCGM()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 646f
				};
			}

			// Token: 0x0600696F RID: 26991 RVA: 0x00343458 File Offset: 0x00341658
			public static UserLutModel.Settings IMIJNPIIHEK()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1872f
				};
			}

			// Token: 0x06006970 RID: 26992 RVA: 0x00343484 File Offset: 0x00341684
			public static UserLutModel.Settings HONMJCFNNGI()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 15f
				};
			}

			// Token: 0x06006971 RID: 26993 RVA: 0x003434B0 File Offset: 0x003416B0
			public static UserLutModel.Settings CBPCHEBOBNI()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1821f
				};
			}

			// Token: 0x06006972 RID: 26994 RVA: 0x003434DC File Offset: 0x003416DC
			public static UserLutModel.Settings NLKNLIGKCIL()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 333f
				};
			}

			// Token: 0x06006973 RID: 26995 RVA: 0x00343508 File Offset: 0x00341708
			public static UserLutModel.Settings JMFBQMKFLBG()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 195f
				};
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06006974 RID: 26996 RVA: 0x00343534 File Offset: 0x00341734
			public static UserLutModel.Settings defaultSettings
			{
				get
				{
					return new UserLutModel.Settings
					{
						lut = null,
						contribution = 1f
					};
				}
			}

			// Token: 0x06006975 RID: 26997 RVA: 0x00343560 File Offset: 0x00341760
			public static UserLutModel.Settings BPCCKBQPMGL()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 134f
				};
			}

			// Token: 0x06006976 RID: 26998 RVA: 0x0034358C File Offset: 0x0034178C
			public static UserLutModel.Settings HFQJNGQQPDD()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1284f
				};
			}

			// Token: 0x06006977 RID: 26999 RVA: 0x003435B8 File Offset: 0x003417B8
			public static UserLutModel.Settings NFKHBQEOIJF()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1263f
				};
			}

			// Token: 0x06006978 RID: 27000 RVA: 0x003435E4 File Offset: 0x003417E4
			public static UserLutModel.Settings GODFBEDNBDB()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 49f
				};
			}

			// Token: 0x06006979 RID: 27001 RVA: 0x00343610 File Offset: 0x00341810
			public static UserLutModel.Settings HMKPKOMGPQC()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1121f
				};
			}

			// Token: 0x0600697A RID: 27002 RVA: 0x0034363C File Offset: 0x0034183C
			public static UserLutModel.Settings KMKHPCKLFME()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 904f
				};
			}

			// Token: 0x0600697B RID: 27003 RVA: 0x00343668 File Offset: 0x00341868
			public static UserLutModel.Settings GJCLCJLQNBK()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 1783f
				};
			}

			// Token: 0x0600697C RID: 27004 RVA: 0x00343694 File Offset: 0x00341894
			public static UserLutModel.Settings LCELIFBDEGJ()
			{
				return new UserLutModel.Settings
				{
					lut = null,
					contribution = 268f
				};
			}

			// Token: 0x04001630 RID: 5680
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			// Token: 0x04001631 RID: 5681
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;
		}
	}
}
