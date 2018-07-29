using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020002F7 RID: 759
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600678E RID: 26510 RVA: 0x000278A5 File Offset: 0x00025AA5
		// (set) Token: 0x0600677D RID: 26493 RVA: 0x0002788F File Offset: 0x00025A8F
		public DepthOfFieldModel.Settings settings
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

		// Token: 0x0600677E RID: 26494 RVA: 0x0002788F File Offset: 0x00025A8F
		public void NEBHFCDDQGL(DepthOfFieldModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00027898 File Offset: 0x00025A98
		public virtual void IDHJPEODHPE()
		{
			this.m_Settings = DepthOfFieldModel.Settings.MBLKIINBGDI();
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings OILMJDEQKHM()
		{
			return this.m_Settings;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x000278AD File Offset: 0x00025AAD
		public virtual void JELPJIDHQIJ()
		{
			this.m_Settings = DepthOfFieldModel.Settings.NLKNLIGKCIL();
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x000278BA File Offset: 0x00025ABA
		public override void BJJGDIOLJMI()
		{
			this.m_Settings = DepthOfFieldModel.Settings.defaultSettings;
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings ICJOMIGQMFC()
		{
			return this.m_Settings;
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x000278C7 File Offset: 0x00025AC7
		public virtual void KBHJOBPONEN()
		{
			this.m_Settings = DepthOfFieldModel.Settings.FDHLMPHBGMI();
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings EQLDMPKOGEL()
		{
			return this.m_Settings;
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x000278D4 File Offset: 0x00025AD4
		public virtual void JBJBNCOBQML()
		{
			this.m_Settings = DepthOfFieldModel.Settings.LIIQFPPIEKM();
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x0002788F File Offset: 0x00025A8F
		public void GJOHNHLCMID(DepthOfFieldModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x0002788F File Offset: 0x00025A8F
		public void GQEOEDENQNF(DepthOfFieldModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x0002788F File Offset: 0x00025A8F
		public void KMDFEEPLPIH(DepthOfFieldModel.Settings BGBMIEJJQKC)
		{
			this.m_Settings = BGBMIEJJQKC;
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings DCPMJDLDNMM()
		{
			return this.m_Settings;
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings DCBJMHJEFMG()
		{
			return this.m_Settings;
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings ICEIQHLLNEL()
		{
			return this.m_Settings;
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x000278A5 File Offset: 0x00025AA5
		public DepthOfFieldModel.Settings QKIEQHKDJEP()
		{
			return this.m_Settings;
		}

		// Token: 0x040015F2 RID: 5618
		[SerializeField]
		private DepthOfFieldModel.Settings m_Settings = DepthOfFieldModel.Settings.defaultSettings;

		// Token: 0x020002F8 RID: 760
		public enum HJOECFOPMKG
		{
			// Token: 0x040015F4 RID: 5620
			Small,
			// Token: 0x040015F5 RID: 5621
			Medium,
			// Token: 0x040015F6 RID: 5622
			Large,
			// Token: 0x040015F7 RID: 5623
			VeryLarge
		}

		// Token: 0x020002F9 RID: 761
		[Serializable]
		public struct Settings
		{
			// Token: 0x06006790 RID: 26512 RVA: 0x0033F358 File Offset: 0x0033D558
			public static DepthOfFieldModel.Settings LIIQFPPIEKM()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 1732f,
					aperture = 966f,
					focalLength = 436f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006791 RID: 26513 RVA: 0x0033F3A4 File Offset: 0x0033D5A4
			public static DepthOfFieldModel.Settings HMNNEKFJMGP()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 1772f,
					aperture = 337f,
					focalLength = 1965f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006792 RID: 26514 RVA: 0x0033F3F0 File Offset: 0x0033D5F0
			public static DepthOfFieldModel.Settings HONMJCFNNGI()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 1703f,
					aperture = 970f,
					focalLength = 1678f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006793 RID: 26515 RVA: 0x0033F43C File Offset: 0x0033D63C
			public static DepthOfFieldModel.Settings FDHLMPHBGMI()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 378f,
					aperture = 249f,
					focalLength = 921f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006794 RID: 26516 RVA: 0x0033F488 File Offset: 0x0033D688
			public static DepthOfFieldModel.Settings PBBBBNIEBDK()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 879f,
					aperture = 1880f,
					focalLength = 451f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006795 RID: 26517 RVA: 0x0033F4D4 File Offset: 0x0033D6D4
			public static DepthOfFieldModel.Settings NLKNLIGKCIL()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 1010f,
					aperture = 1363f,
					focalLength = 597f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006796 RID: 26518 RVA: 0x0033F520 File Offset: 0x0033D720
			public static DepthOfFieldModel.Settings DNGJLKJBCMP()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 72f,
					aperture = 555f,
					focalLength = 1617f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x06006797 RID: 26519 RVA: 0x0033F56C File Offset: 0x0033D76C
			public static DepthOfFieldModel.Settings FGIOKBBLFFK()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 964f,
					aperture = 1068f,
					focalLength = 1382f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06006798 RID: 26520 RVA: 0x0033F5B8 File Offset: 0x0033D7B8
			public static DepthOfFieldModel.Settings defaultSettings
			{
				get
				{
					return new DepthOfFieldModel.Settings
					{
						focusDistance = 10f,
						aperture = 5.6f,
						focalLength = 50f,
						useCameraFov = false,
						kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
					};
				}
			}

			// Token: 0x06006799 RID: 26521 RVA: 0x0033F604 File Offset: 0x0033D804
			public static DepthOfFieldModel.Settings MBLKIINBGDI()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 27f,
					aperture = 1859f,
					focalLength = 1177f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x0600679A RID: 26522 RVA: 0x0033F650 File Offset: 0x0033D850
			public static DepthOfFieldModel.Settings LCELIFBDEGJ()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 775f,
					aperture = 882f,
					focalLength = 392f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Small
				};
			}

			// Token: 0x0600679B RID: 26523 RVA: 0x0033F69C File Offset: 0x0033D89C
			public static DepthOfFieldModel.Settings EMLBMMLLCKB()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 527f,
					aperture = 590f,
					focalLength = 1539f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x0600679C RID: 26524 RVA: 0x0033F6E8 File Offset: 0x0033D8E8
			public static DepthOfFieldModel.Settings LILIBDQEIBM()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 606f,
					aperture = 247f,
					focalLength = 853f,
					useCameraFov = true,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Small
				};
			}

			// Token: 0x0600679D RID: 26525 RVA: 0x0033F734 File Offset: 0x0033D934
			public static DepthOfFieldModel.Settings OGDHJJODQGC()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 463f,
					aperture = 1222f,
					focalLength = 1903f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x0600679E RID: 26526 RVA: 0x0033F780 File Offset: 0x0033D980
			public static DepthOfFieldModel.Settings EKBHCDLLDKG()
			{
				return new DepthOfFieldModel.Settings
				{
					focusDistance = 720f,
					aperture = 646f,
					focalLength = 486f,
					useCameraFov = false,
					kernelSize = DepthOfFieldModel.HJOECFOPMKG.Medium
				};
			}

			// Token: 0x040015F8 RID: 5624
			[MHLQLMPHPHO(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			// Token: 0x040015F9 RID: 5625
			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			// Token: 0x040015FA RID: 5626
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			[Range(1f, 300f)]
			public float focalLength;

			// Token: 0x040015FB RID: 5627
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			// Token: 0x040015FC RID: 5628
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public DepthOfFieldModel.HJOECFOPMKG kernelSize;
		}
	}
}
