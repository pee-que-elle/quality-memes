using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020002FF RID: 767
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x0600681C RID: 26652 RVA: 0x00027A33 File Offset: 0x00025C33
		public void EOONHGFEMDO(FogModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x00027A3C File Offset: 0x00025C3C
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = FogModel.Settings.defaultSettings;
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x00027A33 File Offset: 0x00025C33
		public void KMDFEEPLPIH(FogModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x00027A5C File Offset: 0x00025C5C
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x00027A33 File Offset: 0x00025C33
		public FogModel.Settings settings
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

		// Token: 0x06006821 RID: 26657 RVA: 0x00027A33 File Offset: 0x00025C33
		public void GJOHNHLCMID(FogModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x00027A5C File Offset: 0x00025C5C
		public FogModel.Settings EQLDMPKOGEL()
		{
			return this.m_Settings;
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x00027A33 File Offset: 0x00025C33
		public void LEMOMMDPLKK(FogModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x00027A5C File Offset: 0x00025C5C
		public FogModel.Settings DNDPKMIFFDJ()
		{
			return this.m_Settings;
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x00027A5C File Offset: 0x00025C5C
		public FogModel.Settings IEDQPECKQDN()
		{
			return this.m_Settings;
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x00027A5C File Offset: 0x00025C5C
		public FogModel.Settings DCPMJDLDNMM()
		{
			return this.m_Settings;
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00027A5C File Offset: 0x00025C5C
		public FogModel.Settings OILMJDEQKHM()
		{
			return this.m_Settings;
		}

		// Token: 0x0400160D RID: 5645
		[SerializeField]
		private FogModel.Settings m_Settings = FogModel.Settings.defaultSettings;

		// Token: 0x02000300 RID: 768
		[Serializable]
		public struct Settings
		{
			// Token: 0x06006829 RID: 26665 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings PBBBBNIEBDK()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600682A RID: 26666 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings HFNIOJMPHNK()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600682B RID: 26667 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings QFDEQMDDPLQ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600682C RID: 26668 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings KLCDJPIPPOH()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600682D RID: 26669 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings JMFBQMKFLBG()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600682E RID: 26670 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings CBJQDBIFBCI()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600682F RID: 26671 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings GPLMBDJIQKP()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006830 RID: 26672 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings OJCLCQNDJJJ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006831 RID: 26673 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings MBLKIINBGDI()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006832 RID: 26674 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings GBGFECLLPHF()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006833 RID: 26675 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings COQJIFMPEJN()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006834 RID: 26676 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings PIOFBQKIQEO()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006835 RID: 26677 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings HMNNEKFJMGP()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006836 RID: 26678 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings FEDCFQNLCBP()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006837 RID: 26679 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings BMQKJJQPIFJ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006838 RID: 26680 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings CBPCHEBOBNI()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006839 RID: 26681 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings OKIFIQLFJMM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600683A RID: 26682 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings ECDEKIGEPNC()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600683B RID: 26683 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings CIDEBEBPECJ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600683C RID: 26684 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings LIIQFPPIEKM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600683D RID: 26685 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings EMLBMMLLCKB()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600683E RID: 26686 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings NFKHBQEOIJF()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600683F RID: 26687 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings FGIOKBBLFFK()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006840 RID: 26688 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings OGDHJJODQGC()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006841 RID: 26689 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings BKOQOBFCMNJ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006842 RID: 26690 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings LCELIFBDEGJ()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006843 RID: 26691 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings HQDCCODHLJM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006844 RID: 26692 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings KMKHPCKLFME()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006845 RID: 26693 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings NLKNLIGKCIL()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006846 RID: 26694 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings IQKKKIJHEOC()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006847 RID: 26695 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings HONMJCFNNGI()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006848 RID: 26696 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings NKQIOFELGQF()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006849 RID: 26697 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings GODFBEDNBDB()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600684A RID: 26698 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings LILIBDQEIBM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600684B RID: 26699 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings HFQJNGQQPDD()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600684C RID: 26700 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings FDHLMPHBGMI()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0600684D RID: 26701 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings LNHIGCOPCGM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600684E RID: 26702 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings DNGJLKJBCMP()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x0600684F RID: 26703 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings EKBHCDLLDKG()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006850 RID: 26704 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings BMDHMEEIQQM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06006851 RID: 26705 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings defaultSettings
			{
				get
				{
					return new FogModel.Settings
					{
						excludeSkybox = true
					};
				}
			}

			// Token: 0x06006852 RID: 26706 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings DMCILLEKOON()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006853 RID: 26707 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings GJCLCJLQNBK()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006854 RID: 26708 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings BEFFHCCDODM()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006855 RID: 26709 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings LNQMILQOBHP()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006856 RID: 26710 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings OQGIEDOFKDG()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006857 RID: 26711 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings HMKPKOMGPQC()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x06006858 RID: 26712 RVA: 0x0033FF20 File Offset: 0x0033E120
			public static FogModel.Settings BPCCKBQPMGL()
			{
				return new FogModel.Settings
				{
					excludeSkybox = true
				};
			}

			// Token: 0x06006859 RID: 26713 RVA: 0x0033FF00 File Offset: 0x0033E100
			public static FogModel.Settings IMIJNPIIHEK()
			{
				return new FogModel.Settings
				{
					excludeSkybox = false
				};
			}

			// Token: 0x0400160E RID: 5646
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;
		}
	}
}
