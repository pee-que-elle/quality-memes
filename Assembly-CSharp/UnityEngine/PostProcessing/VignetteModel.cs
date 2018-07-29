using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200030E RID: 782
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x0600697D RID: 27005 RVA: 0x00027D23 File Offset: 0x00025F23
		public void IFCNCMMGCFN(VignetteModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x00027D2C File Offset: 0x00025F2C
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = VignetteModel.Settings.defaultSettings;
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00027D23 File Offset: 0x00025F23
		public void FGIGNOHHBHB(VignetteModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00027D23 File Offset: 0x00025F23
		public void CGGJFJNBDJC(VignetteModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00027D39 File Offset: 0x00025F39
		public virtual void JELPJIDHQIJ()
		{
			this.m_Settings = VignetteModel.Settings.BKOQOBFCMNJ();
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00027D46 File Offset: 0x00025F46
		public VignetteModel.Settings HKOKEQMOINC()
		{
			return this.m_Settings;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x00027D46 File Offset: 0x00025F46
		// (set) Token: 0x06006983 RID: 27011 RVA: 0x00027D23 File Offset: 0x00025F23
		public VignetteModel.Settings settings
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

		// Token: 0x06006984 RID: 27012 RVA: 0x00027D46 File Offset: 0x00025F46
		public VignetteModel.Settings ICEIQHLLNEL()
		{
			return this.m_Settings;
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00027D23 File Offset: 0x00025F23
		public void FBHPICJCHLD(VignetteModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00027D4E File Offset: 0x00025F4E
		public virtual void JIBIHGJKKKL()
		{
			this.m_Settings = VignetteModel.Settings.OGDHJJODQGC();
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00027D23 File Offset: 0x00025F23
		public void GJOHNHLCMID(VignetteModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x00027D46 File Offset: 0x00025F46
		public VignetteModel.Settings DNDPKMIFFDJ()
		{
			return this.m_Settings;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00027D46 File Offset: 0x00025F46
		public VignetteModel.Settings EQLDMPKOGEL()
		{
			return this.m_Settings;
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x00027D6E File Offset: 0x00025F6E
		public virtual void BIJQJNDPFDG()
		{
			this.m_Settings = VignetteModel.Settings.CBPCHEBOBNI();
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x00027D46 File Offset: 0x00025F46
		public VignetteModel.Settings DCBJMHJEFMG()
		{
			return this.m_Settings;
		}

		// Token: 0x04001632 RID: 5682
		[SerializeField]
		private VignetteModel.Settings m_Settings = VignetteModel.Settings.defaultSettings;

		// Token: 0x0200030F RID: 783
		public enum HLFPMMMLBPH
		{
			// Token: 0x04001634 RID: 5684
			Classic,
			// Token: 0x04001635 RID: 5685
			Masked
		}

		// Token: 0x02000310 RID: 784
		[Serializable]
		public struct Settings
		{
			// Token: 0x0600698E RID: 27022 RVA: 0x003436C0 File Offset: 0x003418C0
			public static VignetteModel.Settings HMKPKOMGPQC()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1328f, 1375f, 615f, 985f),
					center = new Vector2(618f, 821f),
					intensity = 1254f,
					smoothness = 1525f,
					roundness = 1879f,
					mask = null,
					opacity = 1078f,
					rounded = true
				};
			}

			// Token: 0x0600698F RID: 27023 RVA: 0x00343754 File Offset: 0x00341954
			public static VignetteModel.Settings LNHIGCOPCGM()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(765f, 1289f, 1615f, 1135f),
					center = new Vector2(1905f, 1254f),
					intensity = 1140f,
					smoothness = 1690f,
					roundness = 761f,
					mask = null,
					opacity = 688f,
					rounded = false
				};
			}

			// Token: 0x06006990 RID: 27024 RVA: 0x003437E8 File Offset: 0x003419E8
			public static VignetteModel.Settings ECDEKIGEPNC()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1532f, 362f, 1390f, 1601f),
					center = new Vector2(1225f, 1945f),
					intensity = 1356f,
					smoothness = 1194f,
					roundness = 1220f,
					mask = null,
					opacity = 735f,
					rounded = true
				};
			}

			// Token: 0x06006991 RID: 27025 RVA: 0x0034387C File Offset: 0x00341A7C
			public static VignetteModel.Settings FGIOKBBLFFK()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1454f, 1812f, 204f, 1358f),
					center = new Vector2(1242f, 1804f),
					intensity = 1186f,
					smoothness = 1463f,
					roundness = 344f,
					mask = null,
					opacity = 1037f,
					rounded = true
				};
			}

			// Token: 0x06006992 RID: 27026 RVA: 0x00343910 File Offset: 0x00341B10
			public static VignetteModel.Settings BPCCKBQPMGL()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1692f, 215f, 1252f, 186f),
					center = new Vector2(1228f, 969f),
					intensity = 211f,
					smoothness = 662f,
					roundness = 725f,
					mask = null,
					opacity = 1561f,
					rounded = false
				};
			}

			// Token: 0x06006993 RID: 27027 RVA: 0x003439A4 File Offset: 0x00341BA4
			public static VignetteModel.Settings NKQIOFELGQF()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(486f, 1246f, 997f, 1165f),
					center = new Vector2(1128f, 817f),
					intensity = 1304f,
					smoothness = 1503f,
					roundness = 1831f,
					mask = null,
					opacity = 400f,
					rounded = true
				};
			}

			// Token: 0x06006994 RID: 27028 RVA: 0x00343A38 File Offset: 0x00341C38
			public static VignetteModel.Settings FDHLMPHBGMI()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(923f, 630f, 731f, 225f),
					center = new Vector2(746f, 374f),
					intensity = 1049f,
					smoothness = 758f,
					roundness = 289f,
					mask = null,
					opacity = 1197f,
					rounded = true
				};
			}

			// Token: 0x06006995 RID: 27029 RVA: 0x00343ACC File Offset: 0x00341CCC
			public static VignetteModel.Settings MBLKIINBGDI()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1877f, 1425f, 1701f, 901f),
					center = new Vector2(868f, 653f),
					intensity = 92f,
					smoothness = 343f,
					roundness = 1980f,
					mask = null,
					opacity = 23f,
					rounded = true
				};
			}

			// Token: 0x06006996 RID: 27030 RVA: 0x00343B60 File Offset: 0x00341D60
			public static VignetteModel.Settings LCELIFBDEGJ()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(251f, 632f, 726f, 1143f),
					center = new Vector2(705f, 848f),
					intensity = 275f,
					smoothness = 202f,
					roundness = 1313f,
					mask = null,
					opacity = 1695f,
					rounded = false
				};
			}

			// Token: 0x06006997 RID: 27031 RVA: 0x00343BF4 File Offset: 0x00341DF4
			public static VignetteModel.Settings LIIQFPPIEKM()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1193f, 685f, 785f, 459f),
					center = new Vector2(607f, 1098f),
					intensity = 1393f,
					smoothness = 503f,
					roundness = 121f,
					mask = null,
					opacity = 344f,
					rounded = true
				};
			}

			// Token: 0x06006998 RID: 27032 RVA: 0x00343C88 File Offset: 0x00341E88
			public static VignetteModel.Settings HFQJNGQQPDD()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1484f, 1499f, 388f, 630f),
					center = new Vector2(337f, 56f),
					intensity = 1252f,
					smoothness = 88f,
					roundness = 1993f,
					mask = null,
					opacity = 801f,
					rounded = false
				};
			}

			// Token: 0x06006999 RID: 27033 RVA: 0x00343D1C File Offset: 0x00341F1C
			public static VignetteModel.Settings PBBBBNIEBDK()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(380f, 157f, 1363f, 475f),
					center = new Vector2(8f, 1774f),
					intensity = 417f,
					smoothness = 1063f,
					roundness = 656f,
					mask = null,
					opacity = 558f,
					rounded = false
				};
			}

			// Token: 0x0600699A RID: 27034 RVA: 0x00343DB0 File Offset: 0x00341FB0
			public static VignetteModel.Settings KMKHPCKLFME()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1846f, 1333f, 1673f, 592f),
					center = new Vector2(1501f, 983f),
					intensity = 1437f,
					smoothness = 1126f,
					roundness = 1096f,
					mask = null,
					opacity = 860f,
					rounded = true
				};
			}

			// Token: 0x0600699B RID: 27035 RVA: 0x00343E44 File Offset: 0x00342044
			public static VignetteModel.Settings HMNNEKFJMGP()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(347f, 1091f, 1951f, 837f),
					center = new Vector2(1235f, 1241f),
					intensity = 891f,
					smoothness = 655f,
					roundness = 1003f,
					mask = null,
					opacity = 508f,
					rounded = false
				};
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x0600699C RID: 27036 RVA: 0x00343ED8 File Offset: 0x003420D8
			public static VignetteModel.Settings defaultSettings
			{
				get
				{
					return new VignetteModel.Settings
					{
						mode = VignetteModel.HLFPMMMLBPH.Classic,
						color = new Color(0f, 0f, 0f, 1f),
						center = new Vector2(0.5f, 0.5f),
						intensity = 0.45f,
						smoothness = 0.2f,
						roundness = 1f,
						mask = null,
						opacity = 1f,
						rounded = false
					};
				}
			}

			// Token: 0x0600699D RID: 27037 RVA: 0x00343F6C File Offset: 0x0034216C
			public static VignetteModel.Settings PIOFBQKIQEO()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(901f, 264f, 1464f, 1510f),
					center = new Vector2(1325f, 1145f),
					intensity = 1878f,
					smoothness = 1551f,
					roundness = 374f,
					mask = null,
					opacity = 791f,
					rounded = true
				};
			}

			// Token: 0x0600699E RID: 27038 RVA: 0x00344000 File Offset: 0x00342200
			public static VignetteModel.Settings JMFBQMKFLBG()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(443f, 513f, 1815f, 92f),
					center = new Vector2(1670f, 829f),
					intensity = 318f,
					smoothness = 1838f,
					roundness = 1755f,
					mask = null,
					opacity = 575f,
					rounded = true
				};
			}

			// Token: 0x0600699F RID: 27039 RVA: 0x00344094 File Offset: 0x00342294
			public static VignetteModel.Settings LILIBDQEIBM()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1772f, 302f, 1529f, 350f),
					center = new Vector2(1555f, 1340f),
					intensity = 648f,
					smoothness = 778f,
					roundness = 1927f,
					mask = null,
					opacity = 53f,
					rounded = false
				};
			}

			// Token: 0x060069A0 RID: 27040 RVA: 0x00344128 File Offset: 0x00342328
			public static VignetteModel.Settings GJCLCJLQNBK()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(365f, 137f, 474f, 1225f),
					center = new Vector2(993f, 475f),
					intensity = 1764f,
					smoothness = 997f,
					roundness = 21f,
					mask = null,
					opacity = 1328f,
					rounded = true
				};
			}

			// Token: 0x060069A1 RID: 27041 RVA: 0x003441BC File Offset: 0x003423BC
			public static VignetteModel.Settings OKIFIQLFJMM()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(945f, 1559f, 634f, 1699f),
					center = new Vector2(1414f, 575f),
					intensity = 1878f,
					smoothness = 681f,
					roundness = 625f,
					mask = null,
					opacity = 1964f,
					rounded = false
				};
			}

			// Token: 0x060069A2 RID: 27042 RVA: 0x00344250 File Offset: 0x00342450
			public static VignetteModel.Settings GODFBEDNBDB()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(344f, 246f, 612f, 1736f),
					center = new Vector2(365f, 1001f),
					intensity = 44f,
					smoothness = 1501f,
					roundness = 1964f,
					mask = null,
					opacity = 694f,
					rounded = true
				};
			}

			// Token: 0x060069A3 RID: 27043 RVA: 0x003442E4 File Offset: 0x003424E4
			public static VignetteModel.Settings OQGIEDOFKDG()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(489f, 488f, 3f, 856f),
					center = new Vector2(224f, 1657f),
					intensity = 909f,
					smoothness = 795f,
					roundness = 901f,
					mask = null,
					opacity = 24f,
					rounded = true
				};
			}

			// Token: 0x060069A4 RID: 27044 RVA: 0x00344378 File Offset: 0x00342578
			public static VignetteModel.Settings IMIJNPIIHEK()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1188f, 531f, 10f, 766f),
					center = new Vector2(1881f, 241f),
					intensity = 1821f,
					smoothness = 394f,
					roundness = 1676f,
					mask = null,
					opacity = 1406f,
					rounded = false
				};
			}

			// Token: 0x060069A5 RID: 27045 RVA: 0x0034440C File Offset: 0x0034260C
			public static VignetteModel.Settings OGDHJJODQGC()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1219f, 303f, 1201f, 139f),
					center = new Vector2(1576f, 1422f),
					intensity = 550f,
					smoothness = 336f,
					roundness = 1372f,
					mask = null,
					opacity = 1575f,
					rounded = false
				};
			}

			// Token: 0x060069A6 RID: 27046 RVA: 0x003444A0 File Offset: 0x003426A0
			public static VignetteModel.Settings LNQMILQOBHP()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(966f, 837f, 114f, 1740f),
					center = new Vector2(173f, 424f),
					intensity = 236f,
					smoothness = 1797f,
					roundness = 1434f,
					mask = null,
					opacity = 661f,
					rounded = true
				};
			}

			// Token: 0x060069A7 RID: 27047 RVA: 0x00344534 File Offset: 0x00342734
			public static VignetteModel.Settings EMLBMMLLCKB()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1017f, 928f, 820f, 1015f),
					center = new Vector2(1302f, 623f),
					intensity = 320f,
					smoothness = 198f,
					roundness = 1034f,
					mask = null,
					opacity = 1783f,
					rounded = true
				};
			}

			// Token: 0x060069A8 RID: 27048 RVA: 0x003445C8 File Offset: 0x003427C8
			public static VignetteModel.Settings HONMJCFNNGI()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(257f, 498f, 512f, 692f),
					center = new Vector2(1500f, 533f),
					intensity = 1984f,
					smoothness = 148f,
					roundness = 1907f,
					mask = null,
					opacity = 1327f,
					rounded = false
				};
			}

			// Token: 0x060069A9 RID: 27049 RVA: 0x0034465C File Offset: 0x0034285C
			public static VignetteModel.Settings CBPCHEBOBNI()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(201f, 542f, 1549f, 322f),
					center = new Vector2(917f, 721f),
					intensity = 1613f,
					smoothness = 580f,
					roundness = 55f,
					mask = null,
					opacity = 485f,
					rounded = false
				};
			}

			// Token: 0x060069AA RID: 27050 RVA: 0x003446F0 File Offset: 0x003428F0
			public static VignetteModel.Settings BMDHMEEIQQM()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1951f, 554f, 518f, 912f),
					center = new Vector2(188f, 1506f),
					intensity = 828f,
					smoothness = 279f,
					roundness = 753f,
					mask = null,
					opacity = 122f,
					rounded = true
				};
			}

			// Token: 0x060069AB RID: 27051 RVA: 0x00344784 File Offset: 0x00342984
			public static VignetteModel.Settings FEDCFQNLCBP()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1044f, 206f, 244f, 1255f),
					center = new Vector2(444f, 1020f),
					intensity = 931f,
					smoothness = 1605f,
					roundness = 374f,
					mask = null,
					opacity = 1335f,
					rounded = true
				};
			}

			// Token: 0x060069AC RID: 27052 RVA: 0x00344818 File Offset: 0x00342A18
			public static VignetteModel.Settings EKBHCDLLDKG()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1339f, 1266f, 884f, 722f),
					center = new Vector2(1828f, 1361f),
					intensity = 1966f,
					smoothness = 88f,
					roundness = 1782f,
					mask = null,
					opacity = 489f,
					rounded = false
				};
			}

			// Token: 0x060069AD RID: 27053 RVA: 0x003448AC File Offset: 0x00342AAC
			public static VignetteModel.Settings BKOQOBFCMNJ()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(1041f, 1103f, 1689f, 1520f),
					center = new Vector2(805f, 845f),
					intensity = 1915f,
					smoothness = 1541f,
					roundness = 1690f,
					mask = null,
					opacity = 1114f,
					rounded = true
				};
			}

			// Token: 0x060069AE RID: 27054 RVA: 0x00344940 File Offset: 0x00342B40
			public static VignetteModel.Settings DNGJLKJBCMP()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(951f, 1693f, 913f, 879f),
					center = new Vector2(1056f, 705f),
					intensity = 1119f,
					smoothness = 1469f,
					roundness = 500f,
					mask = null,
					opacity = 1184f,
					rounded = false
				};
			}

			// Token: 0x060069AF RID: 27055 RVA: 0x003449D4 File Offset: 0x00342BD4
			public static VignetteModel.Settings OJCLCQNDJJJ()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Masked,
					color = new Color(890f, 480f, 652f, 1651f),
					center = new Vector2(1968f, 279f),
					intensity = 184f,
					smoothness = 578f,
					roundness = 975f,
					mask = null,
					opacity = 1921f,
					rounded = true
				};
			}

			// Token: 0x060069B0 RID: 27056 RVA: 0x00344A68 File Offset: 0x00342C68
			public static VignetteModel.Settings NLKNLIGKCIL()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1190f, 65f, 396f, 216f),
					center = new Vector2(1795f, 238f),
					intensity = 521f,
					smoothness = 1593f,
					roundness = 229f,
					mask = null,
					opacity = 1865f,
					rounded = true
				};
			}

			// Token: 0x060069B1 RID: 27057 RVA: 0x00344AFC File Offset: 0x00342CFC
			public static VignetteModel.Settings BMQKJJQPIFJ()
			{
				return new VignetteModel.Settings
				{
					mode = VignetteModel.HLFPMMMLBPH.Classic,
					color = new Color(1518f, 1496f, 536f, 14f),
					center = new Vector2(932f, 78f),
					intensity = 984f,
					smoothness = 47f,
					roundness = 92f,
					mask = null,
					opacity = 957f,
					rounded = false
				};
			}

			// Token: 0x04001636 RID: 5686
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public VignetteModel.HLFPMMMLBPH mode;

			// Token: 0x04001637 RID: 5687
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x04001638 RID: 5688
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x04001639 RID: 5689
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x0400163A RID: 5690
			[Range(0.01f, 1f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			// Token: 0x0400163B RID: 5691
			[Tooltip("Lower values will make a square-ish vignette.")]
			[Range(0f, 1f)]
			public float roundness;

			// Token: 0x0400163C RID: 5692
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			// Token: 0x0400163D RID: 5693
			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			// Token: 0x0400163E RID: 5694
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;
		}
	}
}
