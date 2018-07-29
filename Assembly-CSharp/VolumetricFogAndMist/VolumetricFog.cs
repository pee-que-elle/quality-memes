using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace VolumetricFogAndMist
{
	// Token: 0x020003AC RID: 940
	[HelpURL("http://kronnect.com/taptapgo")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Volumetric Fog & Mist")]
	public class VolumetricFog : MonoBehaviour
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06007D48 RID: 32072 RVA: 0x003BADC8 File Offset: 0x003B8FC8
		public static VolumetricFog instance
		{
			get
			{
				if (VolumetricFog._fog == null)
				{
					if (Camera.main != null)
					{
						VolumetricFog._fog = Camera.main.GetComponent<VolumetricFog>();
					}
					if (VolumetricFog._fog == null)
					{
						foreach (Camera camera in Camera.allCameras)
						{
							VolumetricFog._fog = camera.GetComponent<VolumetricFog>();
							if (VolumetricFog._fog != null)
							{
								break;
							}
						}
					}
				}
				return VolumetricFog._fog;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x0002C89F File Offset: 0x0002AA9F
		// (set) Token: 0x06007D4A RID: 32074 RVA: 0x0002C8A7 File Offset: 0x0002AAA7
		public QDIEOOCIEOL preset
		{
			get
			{
				return this._preset;
			}
			set
			{
				if (value != this._preset)
				{
					this._preset = value;
					this.UpdatePreset();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06007D4B RID: 32075 RVA: 0x0002C8C6 File Offset: 0x0002AAC6
		// (set) Token: 0x06007D4C RID: 32076 RVA: 0x003BAE40 File Offset: 0x003B9040
		public VolumetricFogProfile profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				if (value != this._profile)
				{
					this._profile = value;
					if (this._profile != null)
					{
						this._profile.Load(this);
						this._preset = QDIEOOCIEOL.Custom;
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06007D4D RID: 32077 RVA: 0x0002C8CE File Offset: 0x0002AACE
		// (set) Token: 0x06007D4E RID: 32078 RVA: 0x0002C8D6 File Offset: 0x0002AAD6
		public bool useFogVolumes
		{
			get
			{
				return this._useFogVolumes;
			}
			set
			{
				if (value != this._useFogVolumes)
				{
					this._useFogVolumes = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06007D4F RID: 32079 RVA: 0x0002C8EF File Offset: 0x0002AAEF
		// (set) Token: 0x06007D50 RID: 32080 RVA: 0x0002C8F7 File Offset: 0x0002AAF7
		public bool debugDepthPass
		{
			get
			{
				return this._debugPass;
			}
			set
			{
				if (value != this._debugPass)
				{
					this._debugPass = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06007D51 RID: 32081 RVA: 0x0002C910 File Offset: 0x0002AB10
		// (set) Token: 0x06007D52 RID: 32082 RVA: 0x0002C918 File Offset: 0x0002AB18
		public NCJNIPIJBCP transparencyBlendMode
		{
			get
			{
				return this._transparencyBlendMode;
			}
			set
			{
				if (value != this._transparencyBlendMode)
				{
					this._transparencyBlendMode = value;
					this.UpdateRenderComponents();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06007D53 RID: 32083 RVA: 0x0002C93D File Offset: 0x0002AB3D
		// (set) Token: 0x06007D54 RID: 32084 RVA: 0x0002C945 File Offset: 0x0002AB45
		public float transparencyBlendPower
		{
			get
			{
				return this._transparencyBlendPower;
			}
			set
			{
				if (value != this._transparencyBlendPower)
				{
					this._transparencyBlendPower = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x0002C964 File Offset: 0x0002AB64
		// (set) Token: 0x06007D56 RID: 32086 RVA: 0x0002C96C File Offset: 0x0002AB6C
		public LayerMask transparencyLayerMask
		{
			get
			{
				return this._transparencyLayerMask;
			}
			set
			{
				if (this._transparencyLayerMask != value)
				{
					this._transparencyLayerMask = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0002C98F File Offset: 0x0002AB8F
		// (set) Token: 0x06007D58 RID: 32088 RVA: 0x0002C997 File Offset: 0x0002AB97
		public QQGJJNPLKME lightingModel
		{
			get
			{
				return this._lightingModel;
			}
			set
			{
				if (value != this._lightingModel)
				{
					this._lightingModel = value;
					this.UpdateMaterialProperties();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06007D59 RID: 32089 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		// (set) Token: 0x06007D5A RID: 32090 RVA: 0x0002C9C4 File Offset: 0x0002ABC4
		public bool enableMultipleCameras
		{
			get
			{
				return this._enableMultipleCameras;
			}
			set
			{
				if (value != this._enableMultipleCameras)
				{
					this._enableMultipleCameras = value;
					this.UpdateMultiCameraSetup();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06007D5B RID: 32091 RVA: 0x0002C9E3 File Offset: 0x0002ABE3
		// (set) Token: 0x06007D5C RID: 32092 RVA: 0x0002C9EB File Offset: 0x0002ABEB
		public bool computeDepth
		{
			get
			{
				return this._computeDepth;
			}
			set
			{
				if (value != this._computeDepth)
				{
					this._computeDepth = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06007D5D RID: 32093 RVA: 0x0002CA0A File Offset: 0x0002AC0A
		// (set) Token: 0x06007D5E RID: 32094 RVA: 0x0002CA12 File Offset: 0x0002AC12
		public FDGBELCFEDF computeDepthScope
		{
			get
			{
				return this._computeDepthScope;
			}
			set
			{
				if (value != this._computeDepthScope)
				{
					this._computeDepthScope = value;
					if (this._computeDepthScope == FDGBELCFEDF.TreeBillboardsAndTransparentObjects)
					{
						this._transparencyBlendMode = NCJNIPIJBCP.None;
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06007D5F RID: 32095 RVA: 0x0002CA41 File Offset: 0x0002AC41
		// (set) Token: 0x06007D60 RID: 32096 RVA: 0x0002CA49 File Offset: 0x0002AC49
		public float transparencyCutOff
		{
			get
			{
				return this._transparencyCutOff;
			}
			set
			{
				if (value != this._transparencyCutOff)
				{
					this._transparencyCutOff = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x0002CA68 File Offset: 0x0002AC68
		// (set) Token: 0x06007D62 RID: 32098 RVA: 0x0002CA70 File Offset: 0x0002AC70
		public bool renderBeforeTransparent
		{
			get
			{
				return this._renderBeforeTransparent;
			}
			set
			{
				if (value != this._renderBeforeTransparent)
				{
					this._renderBeforeTransparent = value;
					if (this._renderBeforeTransparent)
					{
						this._transparencyBlendMode = NCJNIPIJBCP.None;
					}
					this.UpdateRenderComponents();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		// (set) Token: 0x06007D64 RID: 32100 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		public GameObject sun
		{
			get
			{
				return this._sun;
			}
			set
			{
				if (value != this._sun)
				{
					this._sun = value;
					this.UpdateSun();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06007D65 RID: 32101 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		// (set) Token: 0x06007D66 RID: 32102 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		public bool sunCopyColor
		{
			get
			{
				return this._sunCopyColor;
			}
			set
			{
				if (value != this._sunCopyColor)
				{
					this._sunCopyColor = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06007D67 RID: 32103 RVA: 0x0002CAF7 File Offset: 0x0002ACF7
		// (set) Token: 0x06007D68 RID: 32104 RVA: 0x0002CAFF File Offset: 0x0002ACFF
		public float density
		{
			get
			{
				return this._density;
			}
			set
			{
				if (value != this._density)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._density = value;
					this.UpdateMaterialProperties();
					this.UpdateTextureAlpha();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x0002CB35 File Offset: 0x0002AD35
		// (set) Token: 0x06007D6A RID: 32106 RVA: 0x0002CB3D File Offset: 0x0002AD3D
		public float noiseStrength
		{
			get
			{
				return this._noiseStrength;
			}
			set
			{
				if (value != this._noiseStrength)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._noiseStrength = value;
					this.UpdateMaterialProperties();
					this.UpdateTextureAlpha();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06007D6B RID: 32107 RVA: 0x0002CB73 File Offset: 0x0002AD73
		// (set) Token: 0x06007D6C RID: 32108 RVA: 0x0002CB7B File Offset: 0x0002AD7B
		public float noiseFinalMultiplier
		{
			get
			{
				return this._noiseFinalMultiplier;
			}
			set
			{
				if (value != this._noiseFinalMultiplier)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._noiseFinalMultiplier = value;
					this.UpdateMaterialProperties();
					this.UpdateTextureAlpha();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06007D6D RID: 32109 RVA: 0x0002CBB1 File Offset: 0x0002ADB1
		// (set) Token: 0x06007D6E RID: 32110 RVA: 0x0002CBB9 File Offset: 0x0002ADB9
		public float noiseSparse
		{
			get
			{
				return this._noiseSparse;
			}
			set
			{
				if (value != this._noiseSparse)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._noiseSparse = value;
					this.UpdateMaterialProperties();
					this.UpdateTextureAlpha();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x0002CBEF File Offset: 0x0002ADEF
		// (set) Token: 0x06007D70 RID: 32112 RVA: 0x0002CBF7 File Offset: 0x0002ADF7
		public float distance
		{
			get
			{
				return this._distance;
			}
			set
			{
				if (value != this._distance)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._distance = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06007D71 RID: 32113 RVA: 0x0002CC21 File Offset: 0x0002AE21
		// (set) Token: 0x06007D72 RID: 32114 RVA: 0x0002CC29 File Offset: 0x0002AE29
		public float maxFogLength
		{
			get
			{
				return this._maxFogLength;
			}
			set
			{
				if (value != this._maxFogLength)
				{
					this._maxFogLength = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06007D73 RID: 32115 RVA: 0x0002CC48 File Offset: 0x0002AE48
		// (set) Token: 0x06007D74 RID: 32116 RVA: 0x0002CC50 File Offset: 0x0002AE50
		public float maxFogLengthFallOff
		{
			get
			{
				return this._maxFogLengthFallOff;
			}
			set
			{
				if (value != this._maxFogLengthFallOff)
				{
					this._maxFogLengthFallOff = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x0002CC6F File Offset: 0x0002AE6F
		// (set) Token: 0x06007D76 RID: 32118 RVA: 0x0002CC77 File Offset: 0x0002AE77
		public float distanceFallOff
		{
			get
			{
				return this._distanceFallOff;
			}
			set
			{
				if (value != this._distanceFallOff)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._distanceFallOff = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x0002CCA1 File Offset: 0x0002AEA1
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x0002CCA9 File Offset: 0x0002AEA9
		public float height
		{
			get
			{
				return this._height;
			}
			set
			{
				if (value != this._height)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._height = Mathf.Max(value, 0.0001f);
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x0002CCDD File Offset: 0x0002AEDD
		// (set) Token: 0x06007D7A RID: 32122 RVA: 0x003BAE90 File Offset: 0x003B9090
		public float baselineHeight
		{
			get
			{
				return this._baselineHeight;
			}
			set
			{
				if (value != this._baselineHeight)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._baselineHeight = value;
					if (this._fogAreaRadius > 0f)
					{
						this._fogAreaPosition.y = this._baselineHeight;
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x0002CCE5 File Offset: 0x0002AEE5
		// (set) Token: 0x06007D7C RID: 32124 RVA: 0x0002CCED File Offset: 0x0002AEED
		public bool baselineRelativeToCamera
		{
			get
			{
				return this._baselineRelativeToCamera;
			}
			set
			{
				if (value != this._baselineRelativeToCamera)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._baselineRelativeToCamera = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06007D7D RID: 32125 RVA: 0x0002CD17 File Offset: 0x0002AF17
		// (set) Token: 0x06007D7E RID: 32126 RVA: 0x0002CD1F File Offset: 0x0002AF1F
		public float baselineRelativeToCameraDelay
		{
			get
			{
				return this._baselineRelativeToCameraDelay;
			}
			set
			{
				if (value != this._baselineRelativeToCameraDelay)
				{
					this._baselineRelativeToCameraDelay = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06007D7F RID: 32127 RVA: 0x0002CD3E File Offset: 0x0002AF3E
		// (set) Token: 0x06007D80 RID: 32128 RVA: 0x0002CD46 File Offset: 0x0002AF46
		public float noiseScale
		{
			get
			{
				return this._noiseScale;
			}
			set
			{
				if (value != this._noiseScale)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._noiseScale = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06007D81 RID: 32129 RVA: 0x0002CD70 File Offset: 0x0002AF70
		// (set) Token: 0x06007D82 RID: 32130 RVA: 0x0002CD78 File Offset: 0x0002AF78
		public float alpha
		{
			get
			{
				return this._alpha;
			}
			set
			{
				if (value != this._alpha)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._alpha = value;
					this.currentFogAlpha = this._alpha;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06007D83 RID: 32131 RVA: 0x0002CDAE File Offset: 0x0002AFAE
		// (set) Token: 0x06007D84 RID: 32132 RVA: 0x0002CDB6 File Offset: 0x0002AFB6
		public Color color
		{
			get
			{
				return this._color;
			}
			set
			{
				if (value != this._color)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._color = value;
					this.currentFogColor = this._color;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06007D85 RID: 32133 RVA: 0x0002CDF1 File Offset: 0x0002AFF1
		// (set) Token: 0x06007D86 RID: 32134 RVA: 0x003BAEE4 File Offset: 0x003B90E4
		public Color specularColor
		{
			get
			{
				return this._specularColor;
			}
			set
			{
				if (value != this._specularColor)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._specularColor = value;
					this.currentFogSpecularColor = this._specularColor;
					this.UpdateTexture();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06007D87 RID: 32135 RVA: 0x0002CDF9 File Offset: 0x0002AFF9
		// (set) Token: 0x06007D88 RID: 32136 RVA: 0x0002CE01 File Offset: 0x0002B001
		public float specularThreshold
		{
			get
			{
				return this._specularThreshold;
			}
			set
			{
				if (value != this._specularThreshold)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._specularThreshold = value;
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06007D89 RID: 32137 RVA: 0x0002CE2B File Offset: 0x0002B02B
		// (set) Token: 0x06007D8A RID: 32138 RVA: 0x0002CE33 File Offset: 0x0002B033
		public float specularIntensity
		{
			get
			{
				return this._specularIntensity;
			}
			set
			{
				if (value != this._specularIntensity)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._specularIntensity = value;
					this.UpdateMaterialProperties();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x0002CE63 File Offset: 0x0002B063
		// (set) Token: 0x06007D8C RID: 32140 RVA: 0x0002CE6B File Offset: 0x0002B06B
		public Vector3 lightDirection
		{
			get
			{
				return this._lightDirection;
			}
			set
			{
				if (value != this._lightDirection)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._lightDirection = value;
					this.UpdateMaterialProperties();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06007D8D RID: 32141 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
		// (set) Token: 0x06007D8E RID: 32142 RVA: 0x0002CEA8 File Offset: 0x0002B0A8
		public float lightIntensity
		{
			get
			{
				return this._lightIntensity;
			}
			set
			{
				if (value != this._lightIntensity)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._lightIntensity = value;
					this.UpdateMaterialProperties();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06007D8F RID: 32143 RVA: 0x0002CED8 File Offset: 0x0002B0D8
		// (set) Token: 0x06007D90 RID: 32144 RVA: 0x003BAF30 File Offset: 0x003B9130
		public Color lightColor
		{
			get
			{
				return this._lightColor;
			}
			set
			{
				if (value != this._lightColor)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._lightColor = value;
					this.currentLightColor = this._lightColor;
					this.UpdateMaterialProperties();
					this.UpdateTexture();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		// (set) Token: 0x06007D92 RID: 32146 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		public int updateTextureSpread
		{
			get
			{
				return this._updateTextureSpread;
			}
			set
			{
				if (value != this._updateTextureSpread)
				{
					this._updateTextureSpread = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0002CF01 File Offset: 0x0002B101
		// (set) Token: 0x06007D94 RID: 32148 RVA: 0x0002CF09 File Offset: 0x0002B109
		public float speed
		{
			get
			{
				return this._speed;
			}
			set
			{
				if (value != this._speed)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._speed = value;
					if (!Application.isPlaying)
					{
						this.UpdateWindSpeedQuick();
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0002CF3A File Offset: 0x0002B13A
		// (set) Token: 0x06007D96 RID: 32150 RVA: 0x0002CF42 File Offset: 0x0002B142
		public Vector3 windDirection
		{
			get
			{
				return this._windDirection;
			}
			set
			{
				if (value != this._windDirection)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._windDirection = value.normalized;
					if (!Application.isPlaying)
					{
						this.UpdateWindSpeedQuick();
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0002CF7E File Offset: 0x0002B17E
		// (set) Token: 0x06007D98 RID: 32152 RVA: 0x0002CF86 File Offset: 0x0002B186
		public bool useRealTime
		{
			get
			{
				return this._useRealTime;
			}
			set
			{
				if (value != this._useRealTime)
				{
					this._useRealTime = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06007D99 RID: 32153 RVA: 0x0002CF9F File Offset: 0x0002B19F
		// (set) Token: 0x06007D9A RID: 32154 RVA: 0x0002CFA7 File Offset: 0x0002B1A7
		public Color skyColor
		{
			get
			{
				return this._skyColor;
			}
			set
			{
				if (value != this._skyColor)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._skyColor = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0002CFD6 File Offset: 0x0002B1D6
		// (set) Token: 0x06007D9C RID: 32156 RVA: 0x0002CFDE File Offset: 0x0002B1DE
		public float skyHaze
		{
			get
			{
				return this._skyHaze;
			}
			set
			{
				if (value != this._skyHaze)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._skyHaze = value;
					if (!Application.isPlaying)
					{
						this.UpdateWindSpeedQuick();
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0002D00F File Offset: 0x0002B20F
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0002D017 File Offset: 0x0002B217
		public float skySpeed
		{
			get
			{
				return this._skySpeed;
			}
			set
			{
				if (value != this._skySpeed)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._skySpeed = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0002D03B File Offset: 0x0002B23B
		// (set) Token: 0x06007DA0 RID: 32160 RVA: 0x0002D043 File Offset: 0x0002B243
		public float skyNoiseStrength
		{
			get
			{
				return this._skyNoiseStrength;
			}
			set
			{
				if (value != this._skyNoiseStrength)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._skyNoiseStrength = value;
					if (!Application.isPlaying)
					{
						this.UpdateWindSpeedQuick();
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06007DA1 RID: 32161 RVA: 0x0002D074 File Offset: 0x0002B274
		// (set) Token: 0x06007DA2 RID: 32162 RVA: 0x0002D07C File Offset: 0x0002B27C
		public float skyAlpha
		{
			get
			{
				return this._skyAlpha;
			}
			set
			{
				if (value != this._skyAlpha)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._skyAlpha = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x0002D0A6 File Offset: 0x0002B2A6
		// (set) Token: 0x06007DA4 RID: 32164 RVA: 0x0002D0AE File Offset: 0x0002B2AE
		public float skyDepth
		{
			get
			{
				return this._skyDepth;
			}
			set
			{
				if (value != this._skyDepth)
				{
					this._skyDepth = value;
					if (!Application.isPlaying)
					{
						this.UpdateWindSpeedQuick();
					}
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		// (set) Token: 0x06007DA6 RID: 32166 RVA: 0x0002D0DC File Offset: 0x0002B2DC
		public GameObject character
		{
			get
			{
				return this._character;
			}
			set
			{
				if (value != this._character)
				{
					this._character = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06007DA7 RID: 32167 RVA: 0x0002D0FA File Offset: 0x0002B2FA
		// (set) Token: 0x06007DA8 RID: 32168 RVA: 0x0002D102 File Offset: 0x0002B302
		public OQCOLFQILDJ fogVoidTopology
		{
			get
			{
				return this._fogVoidTopology;
			}
			set
			{
				if (value != this._fogVoidTopology)
				{
					this._fogVoidTopology = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x0002D121 File Offset: 0x0002B321
		// (set) Token: 0x06007DAA RID: 32170 RVA: 0x0002D129 File Offset: 0x0002B329
		public float fogVoidFallOff
		{
			get
			{
				return this._fogVoidFallOff;
			}
			set
			{
				if (value != this._fogVoidFallOff)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._fogVoidFallOff = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x0002D153 File Offset: 0x0002B353
		// (set) Token: 0x06007DAC RID: 32172 RVA: 0x0002D15B File Offset: 0x0002B35B
		public float fogVoidRadius
		{
			get
			{
				return this._fogVoidRadius;
			}
			set
			{
				if (value != this._fogVoidRadius)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._fogVoidRadius = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x0002D185 File Offset: 0x0002B385
		// (set) Token: 0x06007DAE RID: 32174 RVA: 0x0002D18D File Offset: 0x0002B38D
		public Vector3 fogVoidPosition
		{
			get
			{
				return this._fogVoidPosition;
			}
			set
			{
				if (value != this._fogVoidPosition)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._fogVoidPosition = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06007DAF RID: 32175 RVA: 0x0002D1BC File Offset: 0x0002B3BC
		// (set) Token: 0x06007DB0 RID: 32176 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
		public float fogVoidDepth
		{
			get
			{
				return this._fogVoidDepth;
			}
			set
			{
				if (value != this._fogVoidDepth)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._fogVoidDepth = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x0002D1EE File Offset: 0x0002B3EE
		// (set) Token: 0x06007DB2 RID: 32178 RVA: 0x0002D1F6 File Offset: 0x0002B3F6
		public float fogVoidHeight
		{
			get
			{
				return this._fogVoidHeight;
			}
			set
			{
				if (value != this._fogVoidHeight)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._fogVoidHeight = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x0002D220 File Offset: 0x0002B420
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x0002D228 File Offset: 0x0002B428
		[Obsolete("Fog Void inverted is now deprecated. Use Fog Area settings.")]
		public bool fogVoidInverted
		{
			get
			{
				return this._fogVoidInverted;
			}
			set
			{
				this._fogVoidInverted = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x0002D231 File Offset: 0x0002B431
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x0002D239 File Offset: 0x0002B439
		public bool fogAreaShowGizmos
		{
			get
			{
				return this._fogAreaShowGizmos;
			}
			set
			{
				if (value != this._fogAreaShowGizmos)
				{
					this._fogAreaShowGizmos = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x0002D258 File Offset: 0x0002B458
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x0002D260 File Offset: 0x0002B460
		public GameObject fogAreaCenter
		{
			get
			{
				return this._fogAreaCenter;
			}
			set
			{
				if (value != this._fogAreaCenter)
				{
					this._fogAreaCenter = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x0002D27E File Offset: 0x0002B47E
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x0002D286 File Offset: 0x0002B486
		public float fogAreaFallOff
		{
			get
			{
				return this._fogAreaFallOff;
			}
			set
			{
				if (value != this._fogAreaFallOff)
				{
					this._fogAreaFallOff = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x0002D2A5 File Offset: 0x0002B4A5
		// (set) Token: 0x06007DBC RID: 32188 RVA: 0x0002D2AD File Offset: 0x0002B4AD
		public JJMDJDFJKLO fogAreaFollowMode
		{
			get
			{
				return this._fogAreaFollowMode;
			}
			set
			{
				if (value != this._fogAreaFollowMode)
				{
					this._fogAreaFollowMode = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06007DBD RID: 32189 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		// (set) Token: 0x06007DBE RID: 32190 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		public FNHCOCLFCFE fogAreaTopology
		{
			get
			{
				return this._fogAreaTopology;
			}
			set
			{
				if (value != this._fogAreaTopology)
				{
					this._fogAreaTopology = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x0002D2F3 File Offset: 0x0002B4F3
		// (set) Token: 0x06007DC0 RID: 32192 RVA: 0x0002D2FB File Offset: 0x0002B4FB
		public float fogAreaRadius
		{
			get
			{
				return this._fogAreaRadius;
			}
			set
			{
				if (value != this._fogAreaRadius)
				{
					this._fogAreaRadius = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x0002D31A File Offset: 0x0002B51A
		// (set) Token: 0x06007DC2 RID: 32194 RVA: 0x003BAF7C File Offset: 0x003B917C
		public Vector3 fogAreaPosition
		{
			get
			{
				return this._fogAreaPosition;
			}
			set
			{
				if (value != this._fogAreaPosition)
				{
					this._fogAreaPosition = value;
					if (this._fogAreaCenter == null || this._fogAreaFollowMode == JJMDJDFJKLO.RestrictToXZPlane)
					{
						this._baselineHeight = this._fogAreaPosition.y;
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x0002D322 File Offset: 0x0002B522
		// (set) Token: 0x06007DC4 RID: 32196 RVA: 0x0002D32A File Offset: 0x0002B52A
		public float fogAreaDepth
		{
			get
			{
				return this._fogAreaDepth;
			}
			set
			{
				if (value != this._fogAreaDepth)
				{
					this._fogAreaDepth = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x0002D349 File Offset: 0x0002B549
		// (set) Token: 0x06007DC6 RID: 32198 RVA: 0x0002D351 File Offset: 0x0002B551
		public float fogAreaHeight
		{
			get
			{
				return this._fogAreaHeight;
			}
			set
			{
				if (value != this._fogAreaHeight)
				{
					this._fogAreaHeight = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x0002D370 File Offset: 0x0002B570
		// (set) Token: 0x06007DC8 RID: 32200 RVA: 0x0002D378 File Offset: 0x0002B578
		public IHFHDGMNBJF fogAreaSortingMode
		{
			get
			{
				return this._fogAreaSortingMode;
			}
			set
			{
				if (value != this._fogAreaSortingMode)
				{
					this._fogAreaSortingMode = value;
					this.lastTimeSortInstances = 0f;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x0002D39C File Offset: 0x0002B59C
		// (set) Token: 0x06007DCA RID: 32202 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		public int fogAreaRenderOrder
		{
			get
			{
				return this._fogAreaRenderOrder;
			}
			set
			{
				if (value != this._fogAreaRenderOrder)
				{
					this._fogAreaRenderOrder = value;
					this.lastTimeSortInstances = 0f;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06007DCB RID: 32203 RVA: 0x0002D3C8 File Offset: 0x0002B5C8
		// (set) Token: 0x06007DCC RID: 32204 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		public bool pointLightTrackAuto
		{
			get
			{
				return this._pointLightTrackingAuto;
			}
			set
			{
				if (value != this._pointLightTrackingAuto)
				{
					this._pointLightTrackingAuto = value;
					this.TrackPointLights();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06007DCD RID: 32205 RVA: 0x0002D3EF File Offset: 0x0002B5EF
		// (set) Token: 0x06007DCE RID: 32206 RVA: 0x0002D3F7 File Offset: 0x0002B5F7
		public Transform pointLightTrackingPivot
		{
			get
			{
				return this._pointLightTrackingPivot;
			}
			set
			{
				if (value != this._pointLightTrackingPivot)
				{
					this._pointLightTrackingPivot = value;
					this.TrackPointLights();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06007DCF RID: 32207 RVA: 0x0002D41B File Offset: 0x0002B61B
		// (set) Token: 0x06007DD0 RID: 32208 RVA: 0x0002D423 File Offset: 0x0002B623
		public int pointLightTrackingCount
		{
			get
			{
				return this._pointLightTrackingCount;
			}
			set
			{
				if (value != this._pointLightTrackingCount)
				{
					this._pointLightTrackingCount = Mathf.Clamp(value, 0, 6);
					this.TrackPointLights();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x0002D449 File Offset: 0x0002B649
		// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x0002D451 File Offset: 0x0002B651
		public float pointLightTrackingCheckInterval
		{
			get
			{
				return this._pointLightTrackingCheckInterval;
			}
			set
			{
				if (value != this._pointLightTrackingCheckInterval)
				{
					this._pointLightTrackingCheckInterval = value;
					this.TrackPointLights();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06007DD3 RID: 32211 RVA: 0x0002D470 File Offset: 0x0002B670
		// (set) Token: 0x06007DD4 RID: 32212 RVA: 0x0002D478 File Offset: 0x0002B678
		public float pointLightInscattering
		{
			get
			{
				return this._pointLightInscattering;
			}
			set
			{
				if (value != this._pointLightInscattering)
				{
					this._pointLightInscattering = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06007DD5 RID: 32213 RVA: 0x0002D491 File Offset: 0x0002B691
		// (set) Token: 0x06007DD6 RID: 32214 RVA: 0x0002D499 File Offset: 0x0002B699
		public float pointLightIntensity
		{
			get
			{
				return this._pointLightIntensity;
			}
			set
			{
				if (value != this._pointLightIntensity)
				{
					this._pointLightIntensity = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x0002D4B2 File Offset: 0x0002B6B2
		// (set) Token: 0x06007DD8 RID: 32216 RVA: 0x0002D4BA File Offset: 0x0002B6BA
		public int downsampling
		{
			get
			{
				return this._downsampling;
			}
			set
			{
				if (value != this._downsampling)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._downsampling = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x0002D4DE File Offset: 0x0002B6DE
		// (set) Token: 0x06007DDA RID: 32218 RVA: 0x0002D4E6 File Offset: 0x0002B6E6
		public bool edgeImprove
		{
			get
			{
				return this._edgeImprove;
			}
			set
			{
				if (value != this._edgeImprove)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._edgeImprove = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06007DDB RID: 32219 RVA: 0x0002D510 File Offset: 0x0002B710
		// (set) Token: 0x06007DDC RID: 32220 RVA: 0x0002D518 File Offset: 0x0002B718
		public float edgeThreshold
		{
			get
			{
				return this._edgeThreshold;
			}
			set
			{
				if (value != this._edgeThreshold)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._edgeThreshold = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06007DDD RID: 32221 RVA: 0x0002D542 File Offset: 0x0002B742
		// (set) Token: 0x06007DDE RID: 32222 RVA: 0x0002D54A File Offset: 0x0002B74A
		public float stepping
		{
			get
			{
				return this._stepping;
			}
			set
			{
				if (value != this._stepping)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._stepping = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06007DDF RID: 32223 RVA: 0x0002D574 File Offset: 0x0002B774
		// (set) Token: 0x06007DE0 RID: 32224 RVA: 0x0002D57C File Offset: 0x0002B77C
		public float steppingNear
		{
			get
			{
				return this._steppingNear;
			}
			set
			{
				if (value != this._steppingNear)
				{
					this._preset = QDIEOOCIEOL.Custom;
					this._steppingNear = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x0002D5A6 File Offset: 0x0002B7A6
		// (set) Token: 0x06007DE2 RID: 32226 RVA: 0x0002D5AE File Offset: 0x0002B7AE
		public bool dithering
		{
			get
			{
				return this._dithering;
			}
			set
			{
				if (value != this._dithering)
				{
					this._dithering = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06007DE3 RID: 32227 RVA: 0x0002D5CD File Offset: 0x0002B7CD
		// (set) Token: 0x06007DE4 RID: 32228 RVA: 0x0002D5D5 File Offset: 0x0002B7D5
		public float ditherStrength
		{
			get
			{
				return this._ditherStrength;
			}
			set
			{
				if (value != this._ditherStrength)
				{
					this._ditherStrength = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06007DE5 RID: 32229 RVA: 0x0002D5F4 File Offset: 0x0002B7F4
		// (set) Token: 0x06007DE6 RID: 32230 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		public float jitterStrength
		{
			get
			{
				return this._jitterStrength;
			}
			set
			{
				if (value != this._jitterStrength)
				{
					this._jitterStrength = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06007DE7 RID: 32231 RVA: 0x0002D61B File Offset: 0x0002B81B
		// (set) Token: 0x06007DE8 RID: 32232 RVA: 0x0002D623 File Offset: 0x0002B823
		public bool lightScatteringEnabled
		{
			get
			{
				return this._lightScatteringEnabled;
			}
			set
			{
				if (value != this._lightScatteringEnabled)
				{
					this._lightScatteringEnabled = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06007DE9 RID: 32233 RVA: 0x0002D642 File Offset: 0x0002B842
		// (set) Token: 0x06007DEA RID: 32234 RVA: 0x0002D64A File Offset: 0x0002B84A
		public float lightScatteringDiffusion
		{
			get
			{
				return this._lightScatteringDiffusion;
			}
			set
			{
				if (value != this._lightScatteringDiffusion)
				{
					this._lightScatteringDiffusion = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06007DEB RID: 32235 RVA: 0x0002D669 File Offset: 0x0002B869
		// (set) Token: 0x06007DEC RID: 32236 RVA: 0x0002D671 File Offset: 0x0002B871
		public float lightScatteringSpread
		{
			get
			{
				return this._lightScatteringSpread;
			}
			set
			{
				if (value != this._lightScatteringSpread)
				{
					this._lightScatteringSpread = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06007DED RID: 32237 RVA: 0x0002D690 File Offset: 0x0002B890
		// (set) Token: 0x06007DEE RID: 32238 RVA: 0x0002D698 File Offset: 0x0002B898
		public int lightScatteringSamples
		{
			get
			{
				return this._lightScatteringSamples;
			}
			set
			{
				if (value != this._lightScatteringSamples)
				{
					this._lightScatteringSamples = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06007DEF RID: 32239 RVA: 0x0002D6B7 File Offset: 0x0002B8B7
		// (set) Token: 0x06007DF0 RID: 32240 RVA: 0x0002D6BF File Offset: 0x0002B8BF
		public float lightScatteringWeight
		{
			get
			{
				return this._lightScatteringWeight;
			}
			set
			{
				if (value != this._lightScatteringWeight)
				{
					this._lightScatteringWeight = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06007DF1 RID: 32241 RVA: 0x0002D6DE File Offset: 0x0002B8DE
		// (set) Token: 0x06007DF2 RID: 32242 RVA: 0x0002D6E6 File Offset: 0x0002B8E6
		public float lightScatteringIllumination
		{
			get
			{
				return this._lightScatteringIllumination;
			}
			set
			{
				if (value != this._lightScatteringIllumination)
				{
					this._lightScatteringIllumination = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x0002D705 File Offset: 0x0002B905
		// (set) Token: 0x06007DF4 RID: 32244 RVA: 0x0002D70D File Offset: 0x0002B90D
		public float lightScatteringDecay
		{
			get
			{
				return this._lightScatteringDecay;
			}
			set
			{
				if (value != this._lightScatteringDecay)
				{
					this._lightScatteringDecay = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06007DF5 RID: 32245 RVA: 0x0002D72C File Offset: 0x0002B92C
		// (set) Token: 0x06007DF6 RID: 32246 RVA: 0x0002D734 File Offset: 0x0002B934
		public float lightScatteringExposure
		{
			get
			{
				return this._lightScatteringExposure;
			}
			set
			{
				if (value != this._lightScatteringExposure)
				{
					this._lightScatteringExposure = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x0002D753 File Offset: 0x0002B953
		// (set) Token: 0x06007DF8 RID: 32248 RVA: 0x0002D75B File Offset: 0x0002B95B
		public float lightScatteringJittering
		{
			get
			{
				return this._lightScatteringJittering;
			}
			set
			{
				if (value != this._lightScatteringJittering)
				{
					this._lightScatteringJittering = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06007DF9 RID: 32249 RVA: 0x0002D77A File Offset: 0x0002B97A
		// (set) Token: 0x06007DFA RID: 32250 RVA: 0x0002D782 File Offset: 0x0002B982
		public bool fogBlur
		{
			get
			{
				return this._fogBlur;
			}
			set
			{
				if (value != this._fogBlur)
				{
					this._fogBlur = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06007DFB RID: 32251 RVA: 0x0002D7A1 File Offset: 0x0002B9A1
		// (set) Token: 0x06007DFC RID: 32252 RVA: 0x0002D7A9 File Offset: 0x0002B9A9
		public float fogBlurDepth
		{
			get
			{
				return this._fogBlurDepth;
			}
			set
			{
				if (value != this._fogBlurDepth)
				{
					this._fogBlurDepth = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		// (set) Token: 0x06007DFE RID: 32254 RVA: 0x0002D7D0 File Offset: 0x0002B9D0
		public bool sunShadows
		{
			get
			{
				return this._sunShadows;
			}
			set
			{
				if (value != this._sunShadows)
				{
					this._sunShadows = value;
					this.CleanUpTextureDepthSun();
					if (this._sunShadows)
					{
						this.needUpdateDepthSunTexture = true;
					}
					else
					{
						this.DestroySunShadowsDependencies();
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06007DFF RID: 32255 RVA: 0x0002D80C File Offset: 0x0002BA0C
		// (set) Token: 0x06007E00 RID: 32256 RVA: 0x0002D814 File Offset: 0x0002BA14
		public LayerMask sunShadowsLayerMask
		{
			get
			{
				return this._sunShadowsLayerMask;
			}
			set
			{
				if (this._sunShadowsLayerMask != value)
				{
					this._sunShadowsLayerMask = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06007E01 RID: 32257 RVA: 0x0002D837 File Offset: 0x0002BA37
		// (set) Token: 0x06007E02 RID: 32258 RVA: 0x0002D83F File Offset: 0x0002BA3F
		public float sunShadowsStrength
		{
			get
			{
				return this._sunShadowsStrength;
			}
			set
			{
				if (value != this._sunShadowsStrength)
				{
					this._sunShadowsStrength = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x0002D85E File Offset: 0x0002BA5E
		// (set) Token: 0x06007E04 RID: 32260 RVA: 0x0002D866 File Offset: 0x0002BA66
		public float sunShadowsBias
		{
			get
			{
				return this._sunShadowsBias;
			}
			set
			{
				if (value != this._sunShadowsBias)
				{
					this._sunShadowsBias = value;
					this.needUpdateDepthSunTexture = true;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06007E05 RID: 32261 RVA: 0x0002D88C File Offset: 0x0002BA8C
		// (set) Token: 0x06007E06 RID: 32262 RVA: 0x0002D894 File Offset: 0x0002BA94
		public float sunShadowsJitterStrength
		{
			get
			{
				return this._sunShadowsJitterStrength;
			}
			set
			{
				if (value != this._sunShadowsJitterStrength)
				{
					this._sunShadowsJitterStrength = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x0002D8B3 File Offset: 0x0002BAB3
		// (set) Token: 0x06007E08 RID: 32264 RVA: 0x0002D8BB File Offset: 0x0002BABB
		public int sunShadowsResolution
		{
			get
			{
				return this._sunShadowsResolution;
			}
			set
			{
				if (value != this._sunShadowsResolution)
				{
					this._sunShadowsResolution = value;
					this.needUpdateDepthSunTexture = true;
					this.CleanUpTextureDepthSun();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x0002D8E7 File Offset: 0x0002BAE7
		// (set) Token: 0x06007E0A RID: 32266 RVA: 0x0002D8EF File Offset: 0x0002BAEF
		public float sunShadowsMaxDistance
		{
			get
			{
				return this._sunShadowsMaxDistance;
			}
			set
			{
				if (value != this._sunShadowsMaxDistance)
				{
					this._sunShadowsMaxDistance = value;
					this.needUpdateDepthSunTexture = true;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x0002D915 File Offset: 0x0002BB15
		// (set) Token: 0x06007E0C RID: 32268 RVA: 0x0002D91D File Offset: 0x0002BB1D
		public KOBKEQBGOCM sunShadowsBakeMode
		{
			get
			{
				return this._sunShadowsBakeMode;
			}
			set
			{
				if (value != this._sunShadowsBakeMode)
				{
					this._sunShadowsBakeMode = value;
					this.needUpdateDepthSunTexture = true;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06007E0D RID: 32269 RVA: 0x0002D943 File Offset: 0x0002BB43
		// (set) Token: 0x06007E0E RID: 32270 RVA: 0x0002D94B File Offset: 0x0002BB4B
		public float sunShadowsRefreshInterval
		{
			get
			{
				return this._sunShadowsRefreshInterval;
			}
			set
			{
				if (value != this._sunShadowsRefreshInterval)
				{
					this._sunShadowsRefreshInterval = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06007E0F RID: 32271 RVA: 0x0002D96A File Offset: 0x0002BB6A
		// (set) Token: 0x06007E10 RID: 32272 RVA: 0x0002D972 File Offset: 0x0002BB72
		public float sunShadowsCancellation
		{
			get
			{
				return this._sunShadowsCancellation;
			}
			set
			{
				if (value != this._sunShadowsCancellation)
				{
					this._sunShadowsCancellation = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06007E11 RID: 32273 RVA: 0x0002D991 File Offset: 0x0002BB91
		// (set) Token: 0x06007E12 RID: 32274 RVA: 0x0002D999 File Offset: 0x0002BB99
		public float turbulenceStrength
		{
			get
			{
				return this._turbulenceStrength;
			}
			set
			{
				if (value != this._turbulenceStrength)
				{
					this._turbulenceStrength = value;
					if (this._turbulenceStrength <= 0f)
					{
						this.UpdateTexture();
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x0002D9CB File Offset: 0x0002BBCB
		// (set) Token: 0x06007E14 RID: 32276 RVA: 0x0002D9D3 File Offset: 0x0002BBD3
		public bool useXYPlane
		{
			get
			{
				return this._useXYPlane;
			}
			set
			{
				if (value != this._useXYPlane)
				{
					this._useXYPlane = value;
					if (this._sunShadows)
					{
						this.needUpdateDepthSunTexture = true;
					}
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06007E15 RID: 32277 RVA: 0x0002DA01 File Offset: 0x0002BC01
		// (set) Token: 0x06007E16 RID: 32278 RVA: 0x0002DA09 File Offset: 0x0002BC09
		public bool useSinglePassStereoRenderingMatrix
		{
			get
			{
				return this._useSinglePassStereoRenderingMatrix;
			}
			set
			{
				if (value != this._useSinglePassStereoRenderingMatrix)
				{
					this._useSinglePassStereoRenderingMatrix = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06007E17 RID: 32279 RVA: 0x0002DA22 File Offset: 0x0002BC22
		// (set) Token: 0x06007E18 RID: 32280 RVA: 0x0002DA2A File Offset: 0x0002BC2A
		public MCBBQFMQNEE spsrBehaviour
		{
			get
			{
				return this._spsrBehaviour;
			}
			set
			{
				if (value != this._spsrBehaviour)
				{
					this._spsrBehaviour = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x0002DA43 File Offset: 0x0002BC43
		public Camera fogCamera
		{
			get
			{
				return this.mainCamera;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x0002DA4B File Offset: 0x0002BC4B
		public int renderingInstancesCount
		{
			get
			{
				return this._renderingInstancesCount;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x0002DA53 File Offset: 0x0002BC53
		public bool hasCamera
		{
			get
			{
				if (!this._hasCameraChecked)
				{
					this._hasCamera = (base.GetComponent<Camera>() != null);
					this._hasCameraChecked = true;
				}
				return this._hasCamera;
			}
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x003BAFD4 File Offset: 0x003B91D4
		private void OnEnable()
		{
			this.isPartOfScene = (this.isPartOfScene || this.IsPartOfScene());
			if (!this.isPartOfScene)
			{
				return;
			}
			if (this._fogVoidInverted)
			{
				this._fogVoidInverted = false;
				this._fogAreaCenter = this._character;
				this._fogAreaDepth = this._fogVoidDepth;
				this._fogAreaFallOff = this._fogVoidFallOff;
				this._fogAreaHeight = this._fogVoidHeight;
				this._fogAreaPosition = this._fogVoidPosition;
				this._fogAreaRadius = this._fogVoidRadius;
				this._fogVoidRadius = 0f;
				this._character = null;
			}
			this.mainCamera = base.gameObject.GetComponent<Camera>();
			this._hasCamera = (this.mainCamera != null);
			this._hasCameraChecked = true;
			if (this._hasCamera)
			{
				this.fogRenderer = this;
				if (this.mainCamera.depthTextureMode == DepthTextureMode.None)
				{
					this.mainCamera.depthTextureMode = DepthTextureMode.Depth;
				}
			}
			else if (this.fogRenderer == null)
			{
				this.mainCamera = Camera.main;
				if (this.mainCamera == null)
				{
					return;
				}
				this.fogRenderer = this.mainCamera.GetComponent<VolumetricFog>();
				if (this.fogRenderer == null)
				{
					this.fogRenderer = this.mainCamera.gameObject.AddComponent<VolumetricFog>();
					this.fogRenderer.density = 0f;
				}
			}
			else
			{
				this.mainCamera = this.fogRenderer.mainCamera;
				if (this.mainCamera == null)
				{
					this.mainCamera = this.fogRenderer.GetComponent<Camera>();
				}
			}
			if (this._pointLights.Length < 6)
			{
				this._pointLights = new GameObject[6];
			}
			if (this._pointLightColors.Length < 6)
			{
				this._pointLightColors = new Color[6];
			}
			if (this._pointLightIntensities.Length < 6)
			{
				this._pointLightIntensities = new float[6];
			}
			if (this._pointLightIntensitiesMultiplier.Length < 6)
			{
				this._pointLightIntensitiesMultiplier = new float[6];
			}
			if (this._pointLightPositions.Length < 6)
			{
				this._pointLightPositions = new Vector3[6];
			}
			if (this._pointLightRanges.Length < 6)
			{
				this._pointLightRanges = new float[6];
			}
			if (this._pointLightTrackingPivot == null)
			{
				this._pointLightTrackingPivot = base.transform;
			}
			if (this.fogMat == null)
			{
				this.InitFogMaterial();
				if (this._profile != null)
				{
					this._profile.Load(this);
				}
			}
			else
			{
				this.UpdateMaterialPropertiesNow();
			}
			this.RegisterWithRenderers();
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x003BB244 File Offset: 0x003B9444
		private void OnDestroy()
		{
			if (!this._hasCamera)
			{
				this.UnregisterWithRenderers();
			}
			else
			{
				this.UnregisterFogArea(this);
			}
			if (this.depthCamObj != null)
			{
				UnityEngine.Object.DestroyImmediate(this.depthCamObj);
				this.depthCamObj = null;
			}
			if (this.adjustedTexture != null)
			{
				UnityEngine.Object.DestroyImmediate(this.adjustedTexture);
				this.adjustedTexture = null;
			}
			if (this.chaosLerpMat != null)
			{
				UnityEngine.Object.DestroyImmediate(this.chaosLerpMat);
				this.chaosLerpMat = null;
			}
			if (this.adjustedChaosTexture != null)
			{
				UnityEngine.Object.DestroyImmediate(this.adjustedChaosTexture);
				this.adjustedChaosTexture = null;
			}
			if (this.blurMat != null)
			{
				UnityEngine.Object.DestroyImmediate(this.blurMat);
				this.blurMat = null;
			}
			if (this.fogMat != null)
			{
				UnityEngine.Object.DestroyImmediate(this.fogMat);
				this.fogMat = null;
			}
			this.CleanUpDepthTexture();
			this.DestroySunShadowsDependencies();
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		public void DestroySelf()
		{
			this.DestroyRenderComponent<VolumetricFogPreT>();
			this.DestroyRenderComponent<VolumetricFogPosT>();
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x0002DA90 File Offset: 0x0002BC90
		private void Start()
		{
			this.currentFogAlpha = this._alpha;
			this.currentSkyHazeAlpha = this._skyAlpha;
			this.lastTextureUpdate = Time.time + 0.2f;
			this.RegisterWithRenderers();
			this.Update();
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x003BB334 File Offset: 0x003B9534
		private void Update()
		{
			if (!this.isPartOfScene)
			{
				return;
			}
			if (this.fogRenderer.sun != null)
			{
				Vector3 forward = this.fogRenderer.sun.transform.forward;
				if (!Application.isPlaying || (this.updatingTextureSlice < 0 && Time.time - this.lastTextureUpdate >= 0.2f))
				{
					if (forward != this._lightDirection)
					{
						this._lightDirection = forward;
						this.needUpdateTexture = true;
						this.needUpdateDepthSunTexture = true;
					}
					if (this.sunLight != null)
					{
						if (this._sunCopyColor && this.sunLight.color != this._lightColor)
						{
							this._lightColor = this.sunLight.color;
							this.currentLightColor = this._lightColor;
							this.needUpdateTexture = true;
						}
						if (this.sunLightIntensity != this.sunLight.intensity)
						{
							this.sunLightIntensity = this.sunLight.intensity;
							this.needUpdateTexture = true;
						}
					}
				}
			}
			if (!this.needUpdateTexture)
			{
				if (this._lightingModel == QQGJJNPLKME.Classic)
				{
					if (this.lastRenderSettingsAmbientIntensity != RenderSettings.ambientIntensity)
					{
						this.needUpdateTexture = true;
					}
					else if (this.lastRenderSettingsAmbientLight != RenderSettings.ambientLight)
					{
						this.needUpdateTexture = true;
					}
				}
				else if (this._lightingModel == QQGJJNPLKME.Natural && this.lastRenderSettingsAmbientLight != RenderSettings.ambientLight)
				{
					this.needUpdateTexture = true;
				}
			}
			if (this.transitionProfile)
			{
				float num = (Time.time - this.transitionStartTime) / this.transitionDuration;
				if (num > 1f)
				{
					num = 1f;
				}
				VolumetricFogProfile.Lerp(this.initialProfile, this.targetProfile, num, this);
				if (num >= 1f)
				{
					this.transitionProfile = false;
				}
			}
			if (this.transitionAlpha)
			{
				if (this.targetFogAlpha < 0f && this.targetSkyHazeAlpha < 0f)
				{
					if (this.currentFogAlpha != this._alpha || this.currentSkyHazeAlpha != this._skyAlpha)
					{
						if (this.transitionDuration > 0f)
						{
							this.currentFogAlpha = Mathf.Lerp(this.initialFogAlpha, this._alpha, (Time.time - this.transitionStartTime) / this.transitionDuration);
							this.currentSkyHazeAlpha = Mathf.Lerp(this.initialSkyHazeAlpha, this.alpha, (Time.time - this.transitionStartTime) / this.transitionDuration);
						}
						else
						{
							this.currentFogAlpha = this._alpha;
							this.currentSkyHazeAlpha = this._skyAlpha;
							this.transitionAlpha = false;
						}
						this.fogMat.SetFloat("_FogAlpha", this.currentFogAlpha);
						this.UpdateSkyColor(this.currentSkyHazeAlpha);
					}
				}
				else if (this.targetFogAlpha != this.currentFogAlpha || this.targetSkyHazeAlpha != this.currentSkyHazeAlpha)
				{
					if (this.transitionDuration > 0f)
					{
						this.currentFogAlpha = Mathf.Lerp(this.initialFogAlpha, this.targetFogAlpha, (Time.time - this.transitionStartTime) / this.transitionDuration);
						this.currentSkyHazeAlpha = Mathf.Lerp(this.initialSkyHazeAlpha, this.targetSkyHazeAlpha, (Time.time - this.transitionStartTime) / this.transitionDuration);
					}
					else
					{
						this.currentFogAlpha = this.targetFogAlpha;
						this.currentSkyHazeAlpha = this.targetSkyHazeAlpha;
						this.transitionAlpha = false;
					}
					this.fogMat.SetFloat("_FogAlpha", this.currentFogAlpha);
					this.UpdateSkyColor(this.currentSkyHazeAlpha);
				}
			}
			if (this.transitionColor)
			{
				if (this.targetColorActive)
				{
					if (this.targetFogColor != this.currentFogColor)
					{
						if (this.transitionDuration > 0f)
						{
							this.currentFogColor = Color.Lerp(this.initialFogColor, this.targetFogColor, (Time.time - this.transitionStartTime) / this.transitionDuration);
						}
						else
						{
							this.currentFogColor = this.targetFogColor;
							this.transitionColor = false;
						}
					}
				}
				else if (this.currentFogColor != this._color)
				{
					if (this.transitionDuration > 0f)
					{
						this.currentFogColor = Color.Lerp(this.initialFogColor, this._color, (Time.time - this.transitionStartTime) / this.transitionDuration);
					}
					else
					{
						this.currentFogColor = this._color;
						this.transitionColor = false;
					}
				}
				this.UpdateMaterialFogColor();
			}
			if (this.transitionSpecularColor)
			{
				if (this.targetSpecularColorActive)
				{
					if (this.targetFogSpecularColor != this.currentFogSpecularColor)
					{
						if (this.transitionDuration > 0f)
						{
							this.currentFogSpecularColor = Color.Lerp(this.initialFogSpecularColor, this.targetFogSpecularColor, (Time.time - this.transitionStartTime) / this.transitionDuration);
						}
						else
						{
							this.currentFogSpecularColor = this.targetFogSpecularColor;
							this.transitionSpecularColor = false;
						}
						this.needUpdateTexture = true;
					}
				}
				else if (this.currentFogSpecularColor != this._specularColor)
				{
					if (this.transitionDuration > 0f)
					{
						this.currentFogSpecularColor = Color.Lerp(this.initialFogSpecularColor, this._specularColor, (Time.time - this.transitionStartTime) / this.transitionDuration);
					}
					else
					{
						this.currentFogSpecularColor = this._specularColor;
						this.transitionSpecularColor = false;
					}
					this.needUpdateTexture = true;
				}
			}
			if (this.transitionLightColor)
			{
				if (this.targetLightColorActive)
				{
					if (this.targetLightColor != this.currentLightColor)
					{
						if (this.transitionDuration > 0f)
						{
							this.currentLightColor = Color.Lerp(this.initialLightColor, this.targetLightColor, (Time.time - this.transitionStartTime) / this.transitionDuration);
						}
						else
						{
							this.currentLightColor = this.targetLightColor;
							this.transitionLightColor = false;
						}
						this.needUpdateTexture = true;
					}
				}
				else if (this.currentLightColor != this._lightColor)
				{
					if (this.transitionDuration > 0f)
					{
						this.currentLightColor = Color.Lerp(this.initialLightColor, this._lightColor, (Time.time - this.transitionStartTime) / this.transitionDuration);
					}
					else
					{
						this.currentLightColor = this._lightColor;
						this.transitionLightColor = false;
					}
					this.needUpdateTexture = true;
				}
			}
			if (this._baselineRelativeToCamera)
			{
				this.UpdateMaterialHeights();
			}
			else if (this._character != null)
			{
				this._fogVoidPosition = this._character.transform.position;
				this.UpdateMaterialHeights();
			}
			if (this._fogAreaCenter != null)
			{
				if (this._fogAreaFollowMode == JJMDJDFJKLO.FullXYZ)
				{
					this._fogAreaPosition = this._fogAreaCenter.transform.position;
				}
				else
				{
					this._fogAreaPosition.x = this._fogAreaCenter.transform.position.x;
					this._fogAreaPosition.z = this._fogAreaCenter.transform.position.z;
				}
				this.UpdateMaterialHeights();
			}
			if (this._pointLightTrackingAuto && (!Application.isPlaying || Time.time - this.trackPointAutoLastTime > this._pointLightTrackingCheckInterval))
			{
				this.trackPointAutoLastTime = Time.time;
				this.TrackPointLights();
			}
			if (this.updatingTextureSlice >= 0)
			{
				this.UpdateTextureColors(this.adjustedColors, false);
			}
			else if (this.needUpdateTexture)
			{
				this.UpdateTexture();
			}
			if (this._hasCamera)
			{
				if (this._fogOfWarEnabled)
				{
					this.FogOfWarUpdate();
				}
				if (this._sunShadows && this.fogRenderer.sun)
				{
					this.CastSunShadows();
				}
				int count = this.fogInstances.Count;
				if (count > 1)
				{
					Vector3 position = this.mainCamera.transform.position;
					bool flag;
					if (!(flag = (!Application.isPlaying || Time.time - this.lastTimeSortInstances >= 2f)))
					{
						float num2 = (position.x - this.lastCamPos.x) * (position.x - this.lastCamPos.x) + (position.y - this.lastCamPos.y) * (position.y - this.lastCamPos.y) + (position.z - this.lastCamPos.z) * (position.z - this.lastCamPos.z);
						if (num2 > 625f)
						{
							this.lastCamPos = position;
							flag = true;
						}
					}
					if (flag)
					{
						this.lastTimeSortInstances = Time.time;
						float x2 = position.x;
						float y2 = position.y;
						float z = position.z;
						for (int i = 0; i < count; i++)
						{
							VolumetricFog volumetricFog = this.fogInstances[i];
							if (volumetricFog != null)
							{
								Vector3 position2 = volumetricFog.transform.position;
								position2.y = volumetricFog.currentFogAltitude;
								float num3 = x2 - position2.x;
								float num4 = y2 - position2.y;
								float num5 = num4 * num4;
								float num6 = y2 - (position2.y + volumetricFog.height);
								float num7 = num6 * num6;
								volumetricFog.distanceToCameraYAxis = ((num5 >= num7) ? num7 : num5);
								float num8 = z - position2.z;
								float num9 = num3 * num3 + num4 * num4 + num8 * num8;
								volumetricFog.distanceToCamera = num9;
								Vector3 position3 = position2 - volumetricFog.transform.localScale * 0.5f;
								Vector3 position4 = position2 + volumetricFog.transform.localScale * 0.5f;
								volumetricFog.distanceToCameraMin = this.mainCamera.WorldToScreenPoint(position3).z;
								volumetricFog.distanceToCameraMax = this.mainCamera.WorldToScreenPoint(position4).z;
							}
						}
						this.fogInstances.Sort(delegate(VolumetricFog x, VolumetricFog y)
						{
							if (!x || !y)
							{
								return 0;
							}
							if (x.fogAreaSortingMode != IHFHDGMNBJF.Fixed)
							{
								if (y.fogAreaSortingMode != IHFHDGMNBJF.Fixed)
								{
									if ((x.distanceToCameraMin >= y.distanceToCameraMin || x.distanceToCameraMax <= y.distanceToCameraMax) && (y.distanceToCameraMin >= x.distanceToCameraMin || y.distanceToCameraMax <= x.distanceToCameraMax) && x.fogAreaSortingMode != IHFHDGMNBJF.Altitude)
									{
										if (y.fogAreaSortingMode != IHFHDGMNBJF.Altitude)
										{
											if (x.distanceToCamera < y.distanceToCamera)
											{
												return 1;
											}
											if (x.distanceToCamera > y.distanceToCamera)
											{
												return -1;
											}
											return 0;
										}
									}
									if (x.distanceToCameraYAxis < y.distanceToCameraYAxis)
									{
										return 1;
									}
									if (x.distanceToCameraYAxis > y.distanceToCameraYAxis)
									{
										return -1;
									}
									return 0;
								}
							}
							if (x.fogAreaRenderOrder < y.fogAreaRenderOrder)
							{
								return -1;
							}
							if (x.fogAreaRenderOrder > y.fogAreaRenderOrder)
							{
								return 1;
							}
							return 0;
						});
					}
				}
			}
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x003BBD08 File Offset: 0x003B9F08
		private void OnPreCull()
		{
			if (base.enabled && base.gameObject.activeSelf && !(this.fogMat == null) && this._hasCamera && !(this.mainCamera == null))
			{
				if (this.mainCamera.depthTextureMode == DepthTextureMode.None)
				{
					this.mainCamera.depthTextureMode = DepthTextureMode.Depth;
				}
				if (this._computeDepth)
				{
					this.GetTransparentDepth();
				}
				if (this._hasCamera)
				{
					int count = this.fogRenderInstances.Count;
					for (int i = 0; i < count; i++)
					{
						if (this.fogRenderInstances[i] != null && this.fogRenderInstances[i].turbulenceStrength > 0f)
						{
							this.fogRenderInstances[i].ApplyChaos();
						}
					}
				}
				return;
			}
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0002DAC7 File Offset: 0x0002BCC7
		private void OnDidApplyAnimationProperties()
		{
			this.shouldUpdateMaterialProperties = true;
		}

		// Token: 0x06007E23 RID: 32291 RVA: 0x003BBDE4 File Offset: 0x003B9FE4
		private bool IsPartOfScene()
		{
			VolumetricFog[] array = UnityEngine.Object.FindObjectsOfType<VolumetricFog>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == this)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x003BBE14 File Offset: 0x003BA014
		private void InitFogMaterial()
		{
			this.targetFogAlpha = -1f;
			this.targetSkyHazeAlpha = -1f;
			this._skyColor.a = this._skyAlpha;
			this.updatingTextureSlice = -1;
			this.fogMat = new Material(Shader.Find("VolumetricFogAndMist/VolumetricFog"));
			this.fogMat.hideFlags = HideFlags.DontSave;
			Texture2D texture2D = Resources.Load<Texture2D>("Textures/Noise3");
			this.noiseColors = texture2D.GetPixels();
			this.adjustedColors = new Color[this.noiseColors.Length];
			this.adjustedTexture = new Texture2D(texture2D.width, texture2D.height, TextureFormat.RGBA32, false);
			this.adjustedTexture.hideFlags = HideFlags.DontSave;
			this.timeOfLastRender = Time.time;
			if (this._pointLightTrackingAuto)
			{
				this.TrackPointLights();
			}
			else
			{
				this.UpdatePointLights();
			}
			this.FogOfWarInit();
			if (this.fogOfWarTexture == null)
			{
				this.FogOfWarUpdateTexture();
			}
			this.CopyTransitionValues();
			this.UpdatePreset();
			this.oldBaselineRelativeCameraY = this.mainCamera.transform.position.y;
			if (this._sunShadows)
			{
				this.needUpdateDepthSunTexture = true;
			}
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x003BBF38 File Offset: 0x003BA138
		private void UpdateRenderComponents()
		{
			if (!this._hasCamera)
			{
				return;
			}
			if (this._renderBeforeTransparent)
			{
				this.AssignRenderComponent<VolumetricFogPreT>();
				this.DestroyRenderComponent<VolumetricFogPosT>();
			}
			else if (this._transparencyBlendMode == NCJNIPIJBCP.Blend)
			{
				this.AssignRenderComponent<VolumetricFogPreT>();
				this.AssignRenderComponent<VolumetricFogPosT>();
			}
			else
			{
				this.AssignRenderComponent<VolumetricFogPosT>();
				this.DestroyRenderComponent<VolumetricFogPreT>();
			}
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x003BBF88 File Offset: 0x003BA188
		private void DestroyRenderComponent<T>() where T : IVolumetricFogRenderComponent
		{
			T[] componentsInChildren = base.GetComponentsInChildren<T>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].fog == this || componentsInChildren[i].fog == null)
				{
					componentsInChildren[i].DestroySelf();
				}
			}
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x003BBFF8 File Offset: 0x003BA1F8
		private void AssignRenderComponent<T>() where T : Component, IVolumetricFogRenderComponent
		{
			T[] componentsInChildren = base.GetComponentsInChildren<T>(true);
			int num = -1;
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].fog == this)
				{
					return;
				}
				if (componentsInChildren[i].fog == null)
				{
					num = i;
				}
			}
			if (num < 0)
			{
				T t = base.gameObject.AddComponent<T>();
				t.fog = this;
			}
			else
			{
				componentsInChildren[num].fog = this;
			}
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x0002DAD0 File Offset: 0x0002BCD0
		private void RegisterFogArea(VolumetricFog fog)
		{
			if (this.fogInstances.Contains(fog))
			{
				return;
			}
			this.fogInstances.Add(fog);
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x0002DAED File Offset: 0x0002BCED
		private void UnregisterFogArea(VolumetricFog fog)
		{
			if (!this.fogInstances.Contains(fog))
			{
				return;
			}
			this.fogInstances.Remove(fog);
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x003BC090 File Offset: 0x003BA290
		private void RegisterWithRenderers()
		{
			this.allFogRenderers = UnityEngine.Object.FindObjectsOfType<VolumetricFog>();
			if (!this._hasCamera && this.fogRenderer != null)
			{
				if (this.fogRenderer.enableMultipleCameras)
				{
					for (int i = 0; i < this.allFogRenderers.Length; i++)
					{
						if (this.allFogRenderers[i].hasCamera)
						{
							this.allFogRenderers[i].RegisterFogArea(this);
						}
					}
				}
				else
				{
					this.fogRenderer.RegisterFogArea(this);
				}
			}
			else
			{
				this.fogInstances.Clear();
				this.RegisterFogArea(this);
				for (int j = 0; j < this.allFogRenderers.Length; j++)
				{
					if (!this.allFogRenderers[j].hasCamera && (this._enableMultipleCameras || this.allFogRenderers[j].fogRenderer == this))
					{
						this.RegisterFogArea(this.allFogRenderers[j]);
					}
				}
			}
			this.lastTimeSortInstances = 0f;
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x003BC178 File Offset: 0x003BA378
		private void UnregisterWithRenderers()
		{
			if (this.allFogRenderers != null)
			{
				for (int i = 0; i < this.allFogRenderers.Length; i++)
				{
					if (this.allFogRenderers[i] != null && this.allFogRenderers[i].hasCamera)
					{
						this.allFogRenderers[i].UnregisterFogArea(this);
					}
				}
			}
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x003BC1D0 File Offset: 0x003BA3D0
		public void UpdateMultiCameraSetup()
		{
			this.allFogRenderers = UnityEngine.Object.FindObjectsOfType<VolumetricFog>();
			for (int i = 0; i < this.allFogRenderers.Length; i++)
			{
				if (this.allFogRenderers[i] != null && this.allFogRenderers[i].hasCamera)
				{
					this.allFogRenderers[i].SetEnableMultipleCameras(this._enableMultipleCameras);
				}
			}
			this.RegisterWithRenderers();
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x0002DB0B File Offset: 0x0002BD0B
		private void SetEnableMultipleCameras(bool state)
		{
			this._enableMultipleCameras = state;
			this.RegisterWithRenderers();
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x003BC234 File Offset: 0x003BA434
		internal void DoOnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int count = this.fogInstances.Count;
			this.fogRenderInstances.Clear();
			for (int i = 0; i < count; i++)
			{
				if (this.fogInstances[i] != null && this.fogInstances[i].isActiveAndEnabled && this.fogInstances[i].density > 0f)
				{
					this.fogRenderInstances.Add(this.fogInstances[i]);
				}
			}
			this._renderingInstancesCount = this.fogRenderInstances.Count;
			if (this._renderingInstancesCount != 0 && !(this.mainCamera == null))
			{
				if (this._hasCamera && this._density <= 0f && this.shouldUpdateMaterialProperties)
				{
					this.UpdateMaterialPropertiesNow();
				}
				if (this._renderingInstancesCount == 1)
				{
					this.fogRenderInstances[0].DoOnRenderImageInstance(this.mainCamera, source, destination);
				}
				else
				{
					RenderTextureDescriptor descriptor = source.descriptor;
					descriptor.depthBufferBits = 0;
					descriptor.msaaSamples = 1;
					RenderTexture temporary = RenderTexture.GetTemporary(descriptor);
					this.fogRenderInstances[0].DoOnRenderImageInstance(this.mainCamera, source, temporary);
					if (this._renderingInstancesCount == 2)
					{
						this.fogRenderInstances[1].DoOnRenderImageInstance(this.mainCamera, temporary, destination);
					}
					if (this._renderingInstancesCount >= 3)
					{
						RenderTexture temporary2 = RenderTexture.GetTemporary(descriptor);
						RenderTexture source2 = temporary;
						RenderTexture renderTexture = temporary2;
						int num = this._renderingInstancesCount - 1;
						for (int j = 1; j < num; j++)
						{
							if (j > 1)
							{
								renderTexture.DiscardContents();
							}
							this.fogRenderInstances[j].DoOnRenderImageInstance(this.mainCamera, source2, renderTexture);
							if (renderTexture == temporary2)
							{
								source2 = temporary2;
								renderTexture = temporary;
							}
							else
							{
								source2 = temporary;
								renderTexture = temporary2;
							}
						}
						this.fogRenderInstances[num].DoOnRenderImageInstance(this.mainCamera, source2, destination);
						RenderTexture.ReleaseTemporary(temporary2);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				return;
			}
			Graphics.Blit(source, destination);
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x003BC434 File Offset: 0x003BA634
		internal void DoOnRenderImageInstance(Camera mainCamera, RenderTexture source, RenderTexture destination)
		{
			if (!(mainCamera == null) && !(this.fogMat == null))
			{
				if (!this._hasCamera)
				{
					this.CheckFogAreaDimensions();
					if (this._sunShadows && !this.fogRenderer.sunShadows)
					{
						this.fogRenderer.sunShadows = true;
					}
				}
				if (this.shouldUpdateMaterialProperties)
				{
					this.UpdateMaterialPropertiesNow();
				}
				if (Application.isPlaying)
				{
					if (this._useRealTime)
					{
						this.deltaTime = Time.time - this.timeOfLastRender;
						this.timeOfLastRender = Time.time;
					}
					else
					{
						this.deltaTime = Time.deltaTime;
					}
					this.UpdateWindSpeedQuick();
				}
				if (this._hasCamera)
				{
					if (this._spsrBehaviour == MCBBQFMQNEE.ForcedOn && !this._useSinglePassStereoRenderingMatrix)
					{
						this.useSinglePassStereoRenderingMatrix = true;
					}
					else if (this._spsrBehaviour == MCBBQFMQNEE.ForcedOff && this._useSinglePassStereoRenderingMatrix)
					{
						this.useSinglePassStereoRenderingMatrix = false;
					}
				}
				if (this.fogRenderer.useSinglePassStereoRenderingMatrix && XRSettings.enabled)
				{
					this.fogMat.SetMatrix("_ClipToWorld", mainCamera.cameraToWorldMatrix);
				}
				else
				{
					this.fogMat.SetMatrix("_ClipToWorld", mainCamera.cameraToWorldMatrix * mainCamera.projectionMatrix.inverse);
				}
				if (mainCamera.orthographic)
				{
					this.fogMat.SetVector("_ClipDir", mainCamera.transform.forward);
				}
				if (this.fogRenderer.sun && this._lightScatteringEnabled)
				{
					this.UpdateScatteringData();
				}
				for (int i = 0; i < 6; i++)
				{
					Light light = this.pointLightComponents[i];
					if (light != null)
					{
						if (this._pointLightColors[i] != light.color)
						{
							this._pointLightColors[i] = light.color;
							this.isDirty = true;
						}
						if (this._pointLightRanges[i] != light.range)
						{
							this._pointLightRanges[i] = light.range;
							this.isDirty = true;
						}
						if (this._pointLightPositions[i] != light.transform.position)
						{
							this._pointLightPositions[i] = light.transform.position;
							this.isDirty = true;
						}
						if (this._pointLightIntensities[i] != light.intensity)
						{
							this._pointLightIntensities[i] = light.intensity;
							this.isDirty = true;
						}
					}
					this.SetMaterialLightData(i, light);
				}
				if ((float)this._downsampling > 1f)
				{
					int scaledSize = this.GetScaledSize(source.width, (float)this._downsampling);
					int scaledSize2 = this.GetScaledSize(source.width, (float)this._downsampling);
					RenderTextureDescriptor descriptor = source.descriptor;
					descriptor.width = scaledSize;
					descriptor.height = scaledSize2;
					descriptor.msaaSamples = 1;
					this.reducedDestination = RenderTexture.GetTemporary(descriptor);
					RenderTextureDescriptor descriptor2 = source.descriptor;
					descriptor2.width = scaledSize;
					descriptor2.height = scaledSize2;
					descriptor2.msaaSamples = 1;
					RenderTextureFormat colorFormat = (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RFloat)) ? RenderTextureFormat.ARGBFloat : RenderTextureFormat.RFloat;
					descriptor.colorFormat = colorFormat;
					RenderTexture temporary = RenderTexture.GetTemporary(descriptor);
					if (this._fogBlur)
					{
						this.SetBlurTexture(source, descriptor);
					}
					if (this._edgeImprove && !XRSettings.enabled && SystemInfo.supportedRenderTargetCount >= 2)
					{
						this.fogMat.SetTexture("_MainTex", source);
						if (this.mrt == null)
						{
							this.mrt = new RenderBuffer[2];
						}
						this.mrt[0] = this.reducedDestination.colorBuffer;
						this.mrt[1] = temporary.colorBuffer;
						Graphics.SetRenderTarget(this.mrt, this.reducedDestination.depthBuffer);
						Graphics.Blit(null, this.fogMat, 1);
						this.fogMat.SetTexture("_DownsampledDepth", temporary);
					}
					else
					{
						Graphics.Blit(source, this.reducedDestination, this.fogMat, 3);
						if (this._edgeImprove)
						{
							Graphics.Blit(source, temporary, this.fogMat, 4);
							this.fogMat.SetTexture("_DownsampledDepth", temporary);
						}
						else
						{
							this.fogMat.SetTexture("_DownsampledDepth", null);
						}
					}
					this.fogMat.SetTexture("_FogDownsampled", this.reducedDestination);
					Graphics.Blit(source, destination, this.fogMat, 2);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(this.reducedDestination);
				}
				else
				{
					if (this._fogBlur)
					{
						RenderTextureDescriptor descriptor3 = source.descriptor;
						descriptor3.width = 256;
						descriptor3.height = 256;
						this.SetBlurTexture(source, descriptor3);
					}
					Graphics.Blit(source, destination, this.fogMat, 0);
				}
				return;
			}
			Graphics.Blit(source, destination);
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0002C2CF File Offset: 0x0002A4CF
		private int GetScaledSize(int size, float factor)
		{
			size = (int)((float)size / factor);
			size /= 4;
			if (size < 1)
			{
				size = 1;
			}
			return size * 4;
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x0002DB1A File Offset: 0x0002BD1A
		private void CleanUpDepthTexture()
		{
			if (this.depthTexture)
			{
				RenderTexture.ReleaseTemporary(this.depthTexture);
				this.depthTexture = null;
			}
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x003BC8E8 File Offset: 0x003BAAE8
		private void GetTransparentDepth()
		{
			this.CleanUpDepthTexture();
			if (this.depthCam == null)
			{
				if (this.depthCamObj == null)
				{
					this.depthCamObj = GameObject.Find("VFMDepthCamera");
				}
				if (this.depthCamObj == null)
				{
					this.depthCamObj = new GameObject("VFMDepthCamera");
					this.depthCam = this.depthCamObj.AddComponent<Camera>();
					this.depthCam.enabled = false;
					this.depthCamObj.hideFlags = HideFlags.HideAndDontSave;
				}
				else
				{
					this.depthCam = this.depthCamObj.GetComponent<Camera>();
					if (this.depthCam == null)
					{
						UnityEngine.Object.DestroyImmediate(this.depthCamObj);
						this.depthCamObj = null;
						return;
					}
				}
			}
			this.depthCam.CopyFrom(this.mainCamera);
			this.depthCam.depthTextureMode = DepthTextureMode.None;
			this.depthTexture = RenderTexture.GetTemporary(this.mainCamera.pixelWidth, this.mainCamera.pixelHeight, 24, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
			this.depthCam.backgroundColor = new Color(0f, 0f, 0f, 0f);
			this.depthCam.clearFlags = CameraClearFlags.Color;
			this.depthCam.cullingMask = this._transparencyLayerMask;
			this.depthCam.targetTexture = this.depthTexture;
			this.depthCam.renderingPath = RenderingPath.Forward;
			if (this.depthShader == null)
			{
				this.depthShader = Shader.Find("VolumetricFogAndMist/CopyDepth");
			}
			if (this.depthShaderAndTrans == null)
			{
				this.depthShaderAndTrans = Shader.Find("VolumetricFogAndMist/CopyDepthAndTrans");
			}
			FDGBELCFEDF computeDepthScope = this._computeDepthScope;
			if (computeDepthScope != FDGBELCFEDF.OnlyTreeBillboards)
			{
				if (computeDepthScope != FDGBELCFEDF.TreeBillboardsAndTransparentObjects)
				{
					this.depthCam.RenderWithShader(this.depthShaderAndTrans, null);
				}
				else
				{
					this.depthCam.RenderWithShader(this.depthShaderAndTrans, "RenderType");
				}
			}
			else
			{
				this.depthCam.RenderWithShader(this.depthShader, "RenderType");
			}
			Shader.SetGlobalTexture("_VolumetricFogDepthTexture", this.depthTexture);
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x003BCAE8 File Offset: 0x003BACE8
		private void CastSunShadows()
		{
			if (base.enabled && base.gameObject.activeSelf && !(this.fogMat == null))
			{
				if (this._sunShadowsBakeMode == KOBKEQBGOCM.Discrete && this._sunShadowsRefreshInterval > 0f && Time.time > this.lastShadowUpdateFrame + this._sunShadowsRefreshInterval)
				{
					this.needUpdateDepthSunTexture = true;
				}
				if (!Application.isPlaying || this.needUpdateDepthSunTexture || this.depthSunTexture == null || !this.depthSunTexture.IsCreated())
				{
					this.needUpdateDepthSunTexture = false;
					this.lastShadowUpdateFrame = Time.time;
					this.GetSunShadows();
				}
				return;
			}
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x003BCB94 File Offset: 0x003BAD94
		private void GetSunShadows()
		{
			if (!(this._sun == null) && this._sunShadows)
			{
				if (this.depthSunCam == null)
				{
					if (this.depthSunCamObj == null)
					{
						this.depthSunCamObj = GameObject.Find("VFMDepthSunCamera");
					}
					if (this.depthSunCamObj == null)
					{
						this.depthSunCamObj = new GameObject("VFMDepthSunCamera");
						this.depthSunCamObj.hideFlags = HideFlags.HideAndDontSave;
						this.depthSunCam = this.depthSunCamObj.AddComponent<Camera>();
					}
					else
					{
						this.depthSunCam = this.depthSunCamObj.GetComponent<Camera>();
						if (this.depthSunCam == null)
						{
							UnityEngine.Object.DestroyImmediate(this.depthSunCamObj);
							this.depthSunCamObj = null;
							return;
						}
					}
					if (this.depthSunShader == null)
					{
						this.depthSunShader = Shader.Find("VolumetricFogAndMist/CopySunDepth");
					}
					this.depthSunCam.SetReplacementShader(this.depthSunShader, "RenderType");
					this.depthSunCam.nearClipPlane = 1f;
					this.depthSunCam.renderingPath = RenderingPath.Forward;
					this.depthSunCam.orthographic = true;
					this.depthSunCam.aspect = 1f;
					this.depthSunCam.backgroundColor = new Color(0f, 0f, 0.5f, 0f);
					this.depthSunCam.clearFlags = CameraClearFlags.Color;
					this.depthSunCam.depthTextureMode = DepthTextureMode.None;
				}
				float orthographicSize = this._sunShadowsMaxDistance / 0.95f;
				this.depthSunCam.transform.position = this.mainCamera.transform.position - this._sun.transform.forward * 2000f;
				this.depthSunCam.transform.rotation = this._sun.transform.rotation;
				this.depthSunCam.farClipPlane = 4000f;
				this.depthSunCam.orthographicSize = orthographicSize;
				if (this.sunLight != null)
				{
					this.depthSunCam.cullingMask = this._sunShadowsLayerMask;
				}
				if (this.depthSunTexture == null)
				{
					int num = (int)Mathf.Pow(2f, (float)(this._sunShadowsResolution + 9));
					this.depthSunTexture = new RenderTexture(num, num, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
					this.depthSunTexture.hideFlags = HideFlags.DontSave;
					this.depthSunTexture.filterMode = FilterMode.Point;
					this.depthSunTexture.wrapMode = TextureWrapMode.Clamp;
					this.depthSunTexture.Create();
				}
				this.depthSunCam.targetTexture = this.depthSunTexture;
				Shader.SetGlobalFloat("_VF_ShadowBias", this._sunShadowsBias);
				if (Application.isPlaying && this._sunShadowsBakeMode == KOBKEQBGOCM.Realtime)
				{
					if (!this.depthSunCam.enabled)
					{
						this.depthSunCam.enabled = true;
					}
				}
				else
				{
					if (this.depthSunCam.enabled)
					{
						this.depthSunCam.enabled = false;
					}
					this.depthSunCam.Render();
				}
				Shader.SetGlobalMatrix("_VolumetricFogSunProj", this.depthSunCam.projectionMatrix * this.depthSunCam.worldToCameraMatrix);
				Shader.SetGlobalTexture("_VolumetricFogSunDepthTexture", this.depthSunTexture);
				Vector4 value = this.depthSunCam.transform.position;
				value.w = Mathf.Min(this._sunShadowsMaxDistance, this._maxFogLength);
				Shader.SetGlobalVector("_VolumetricFogSunWorldPos", value);
				this.UpdateSunShadowsData();
				return;
			}
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x003BCEFC File Offset: 0x003BB0FC
		private void SetBlurTexture(RenderTexture source, RenderTextureDescriptor desc)
		{
			if (this.blurMat == null)
			{
				Shader shader = Shader.Find("VolumetricFogAndMist/Blur");
				this.blurMat = new Material(shader);
				this.blurMat.hideFlags = HideFlags.DontSave;
			}
			if (this.blurMat == null)
			{
				return;
			}
			this.blurMat.SetFloat("_BlurDepth", this._fogBlurDepth);
			RenderTexture temporary = RenderTexture.GetTemporary(desc);
			Graphics.Blit(source, temporary, this.blurMat, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(desc);
			Graphics.Blit(temporary, temporary2, this.blurMat, 1);
			this.blurMat.SetFloat("_BlurDepth", this._fogBlurDepth * 2f);
			temporary.DiscardContents();
			Graphics.Blit(temporary2, temporary, this.blurMat, 0);
			temporary2.DiscardContents();
			Graphics.Blit(temporary, temporary2, this.blurMat, 1);
			this.fogMat.SetTexture("_BlurTex", temporary2);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0002DB3B File Offset: 0x0002BD3B
		private void DestroySunShadowsDependencies()
		{
			if (this.depthSunCamObj != null)
			{
				UnityEngine.Object.DestroyImmediate(this.depthSunCamObj);
				this.depthSunCamObj = null;
			}
			this.CleanUpTextureDepthSun();
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0002DB63 File Offset: 0x0002BD63
		private void CleanUpTextureDepthSun()
		{
			if (this.depthSunTexture != null)
			{
				this.depthSunTexture.Release();
				this.depthSunTexture = null;
			}
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0002DB85 File Offset: 0x0002BD85
		public string GetCurrentPresetName()
		{
			return Enum.GetName(typeof(QDIEOOCIEOL), this._preset);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x003BCFEC File Offset: 0x003BB1EC
		public void UpdatePreset()
		{
			QDIEOOCIEOL preset = this._preset;
			switch (preset)
			{
			case QDIEOOCIEOL.SandStorm1:
				this._skySpeed = 0.35f;
				this._skyHaze = 388f;
				this._skyNoiseStrength = 0.847f;
				this._skyAlpha = 1f;
				this._density = 0.487f;
				this._noiseStrength = 0.758f;
				this._noiseScale = 1.71f;
				this._noiseSparse = 0f;
				this._distance = 0f;
				this._distanceFallOff = 0f;
				this._height = 16f;
				this._stepping = 6f;
				this._steppingNear = 0f;
				this._alpha = 1f;
				this._color = new Color(0.505f, 0.505f, 0.505f, 1f);
				this._skyColor = this._color;
				this._specularColor = new Color(1f, 1f, 0.8f, 1f);
				this._specularIntensity = 0f;
				this._specularThreshold = 0.6f;
				this._lightColor = Color.white;
				this._lightIntensity = 0f;
				this._speed = 0.3f;
				this._windDirection = Vector3.right;
				this._downsampling = 1;
				this._baselineRelativeToCamera = false;
				this.CheckWaterLevel(false);
				this._fogVoidRadius = 0f;
				this.CopyTransitionValues();
				break;
			case QDIEOOCIEOL.Smoke:
				this._skySpeed = 0.109f;
				this._skyHaze = 10f;
				this._skyNoiseStrength = 0.119f;
				this._skyAlpha = 1f;
				this._density = 1f;
				this._noiseStrength = 0.767f;
				this._noiseScale = 1.6f;
				this._noiseSparse = 0f;
				this._distance = 0f;
				this._distanceFallOff = 0f;
				this._height = 8f;
				this._stepping = 12f;
				this._steppingNear = 25f;
				this._alpha = 1f;
				this._color = new Color(0.125f, 0.125f, 0.125f, 1f);
				this._skyColor = this._color;
				this._specularColor = new Color(1f, 1f, 1f, 1f);
				this._specularIntensity = 0.575f;
				this._specularThreshold = 0.6f;
				this._lightColor = Color.white;
				this._lightIntensity = 1f;
				this._speed = 0.075f;
				this._windDirection = Vector3.right;
				this._downsampling = 1;
				this._baselineRelativeToCamera = false;
				this.CheckWaterLevel(false);
				this._baselineHeight += 8f;
				this._fogVoidRadius = 0f;
				this.CopyTransitionValues();
				break;
			case QDIEOOCIEOL.ToxicSwamp:
				this._skySpeed = 0.062f;
				this._skyHaze = 22f;
				this._skyNoiseStrength = 0.694f;
				this._skyAlpha = 1f;
				this._density = 1f;
				this._noiseStrength = 1f;
				this._noiseScale = 1f;
				this._noiseSparse = 0f;
				this._distance = 0f;
				this._distanceFallOff = 0f;
				this._height = 2.5f;
				this._stepping = 20f;
				this._steppingNear = 50f;
				this._alpha = 0.95f;
				this._color = new Color(0.0238f, 0.175f, 0.109f, 1f);
				this._skyColor = this._color;
				this._specularColor = new Color(0.593f, 0.625f, 0.207f, 1f);
				this._specularIntensity = 0.735f;
				this._specularThreshold = 0.6f;
				this._lightColor = new Color(0.73f, 0.746f, 0.511f, 1f);
				this._lightIntensity = 0.492f;
				this._speed = 0.0003f;
				this._windDirection = Vector3.right;
				this._downsampling = 1;
				this._baselineRelativeToCamera = false;
				this.CheckWaterLevel(false);
				this._fogVoidRadius = 0f;
				this.CopyTransitionValues();
				break;
			case QDIEOOCIEOL.SandStorm2:
				this._skySpeed = 0f;
				this._skyHaze = 0f;
				this._skyNoiseStrength = 0.729f;
				this._skyAlpha = 0.55f;
				this._density = 0.545f;
				this._noiseStrength = 1f;
				this._noiseScale = 3f;
				this._noiseSparse = 0f;
				this._distance = 0f;
				this._distanceFallOff = 0f;
				this._height = 12f;
				this._stepping = 5f;
				this._steppingNear = 19.6f;
				this._alpha = 0.96f;
				this._color = new Color(0.609f, 0.609f, 0.609f, 1f);
				this._skyColor = this._color;
				this._specularColor = new Color(0.589f, 0.621f, 0.207f, 1f);
				this._specularIntensity = 0.505f;
				this._specularThreshold = 0.6f;
				this._lightColor = new Color(0.726f, 0.742f, 0.507f, 1f);
				this._lightIntensity = 0.581f;
				this._speed = 0.168f;
				this._windDirection = Vector3.right;
				this._downsampling = 1;
				this._baselineRelativeToCamera = false;
				this.CheckWaterLevel(false);
				this._fogVoidRadius = 0f;
				this.CopyTransitionValues();
				break;
			default:
				switch (preset)
				{
				case QDIEOOCIEOL.GroundFog:
					this._skySpeed = 0.3f;
					this._skyHaze = 0f;
					this._skyNoiseStrength = 0.1f;
					this._skyAlpha = 0.85f;
					this._density = 0.6f;
					this._noiseStrength = 0.479f;
					this._noiseScale = 1.15f;
					this._noiseSparse = 0f;
					this._distance = 5f;
					this._distanceFallOff = 1f;
					this._height = 1.5f;
					this._stepping = 8f;
					this._steppingNear = 0f;
					this._alpha = 0.95f;
					this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(1f, 1f, 0.8f, 1f);
					this._specularIntensity = 0.2f;
					this._specularThreshold = 0.6f;
					this._lightColor = Color.white;
					this._lightIntensity = 0.2f;
					this._speed = 0.01f;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					this.CopyTransitionValues();
					break;
				case QDIEOOCIEOL.FrostedGround:
					this._skySpeed = 0f;
					this._skyHaze = 0f;
					this._skyNoiseStrength = 0.729f;
					this._skyAlpha = 0.55f;
					this._density = 1f;
					this._noiseStrength = 0.164f;
					this._noiseScale = 1.81f;
					this._noiseSparse = 0f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 0.5f;
					this._stepping = 20f;
					this._steppingNear = 50f;
					this._alpha = 0.97f;
					this._color = new Color(0.546f, 0.648f, 0.71f, 1f);
					this._skyColor = this._color;
					this._specularColor = new Color(0.792f, 0.792f, 0.792f, 1f);
					this._specularIntensity = 1f;
					this._specularThreshold = 0.866f;
					this._lightColor = new Color(0.972f, 0.972f, 0.972f, 1f);
					this._lightIntensity = 0.743f;
					this._speed = 0f;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					this.CopyTransitionValues();
					break;
				case QDIEOOCIEOL.FoggyLake:
					this._skySpeed = 0.3f;
					this._skyHaze = 40f;
					this._skyNoiseStrength = 0.574f;
					this._skyAlpha = 0.827f;
					this._density = 1f;
					this._noiseStrength = 0.03f;
					this._noiseScale = 5.77f;
					this._noiseSparse = 0f;
					this._distance = 0f;
					this._distanceFallOff = 0f;
					this._height = 4f;
					this._stepping = 6f;
					this._steppingNear = 14.4f;
					this._alpha = 1f;
					this._color = new Color(0f, 0.96f, 1f, 1f);
					this._skyColor = this._color;
					this._specularColor = Color.white;
					this._lightColor = Color.white;
					this._specularIntensity = 0.861f;
					this._specularThreshold = 0.907f;
					this._lightIntensity = 0.126f;
					this._speed = 0f;
					this._downsampling = 1;
					this._baselineRelativeToCamera = false;
					this.CheckWaterLevel(false);
					this._fogVoidRadius = 0f;
					this.CopyTransitionValues();
					break;
				default:
					if (preset != QDIEOOCIEOL.Mist)
					{
						if (preset != QDIEOOCIEOL.WindyMist)
						{
							if (preset != QDIEOOCIEOL.LowClouds)
							{
								if (preset != QDIEOOCIEOL.SeaClouds)
								{
									if (preset != QDIEOOCIEOL.Fog)
									{
										if (preset != QDIEOOCIEOL.HeavyFog)
										{
											if (preset != QDIEOOCIEOL.Clear)
											{
												if (preset == QDIEOOCIEOL.WorldEdge)
												{
													this._skySpeed = 0.3f;
													this._skyHaze = 60f;
													this._skyNoiseStrength = 1f;
													this._skyAlpha = 0.96f;
													this._density = 1f;
													this._noiseStrength = 1f;
													this._noiseScale = 3f;
													this._noiseSparse = 0f;
													this._distance = 0f;
													this._distanceFallOff = 0f;
													this._height = 20f;
													this._stepping = 6f;
													this._alpha = 0.98f;
													this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
													this._skyColor = this._color;
													this._specularColor = new Color(1f, 1f, 0.8f, 1f);
													this._specularIntensity = 0.259f;
													this._specularThreshold = 0.6f;
													this._lightColor = Color.white;
													this._lightIntensity = 0.15f;
													this._speed = 0.03f;
													this._downsampling = 2;
													this._baselineRelativeToCamera = false;
													this.CheckWaterLevel(false);
													Terrain activeTerrain = VolumetricFog.GetActiveTerrain();
													if (activeTerrain != null)
													{
														this._fogVoidPosition = activeTerrain.transform.position + activeTerrain.terrainData.size * 0.5f;
														this._fogVoidRadius = activeTerrain.terrainData.size.x * 0.45f;
														this._fogVoidHeight = activeTerrain.terrainData.size.y;
														this._fogVoidDepth = activeTerrain.terrainData.size.z * 0.45f;
														this._fogVoidFallOff = 6f;
														this._fogAreaRadius = 0f;
														this._character = null;
														this._fogAreaCenter = null;
														float x = activeTerrain.terrainData.size.x;
														if (this.mainCamera.farClipPlane < x)
														{
															this.mainCamera.farClipPlane = x;
														}
														if (this._maxFogLength < x * 0.6f)
														{
															this._maxFogLength = x * 0.6f;
														}
													}
													this.CopyTransitionValues();
												}
											}
											else
											{
												this._density = 0f;
												this._fogOfWarEnabled = false;
												this._fogVoidRadius = 0f;
											}
										}
										else
										{
											this._skySpeed = 0.05f;
											this._skyHaze = 500f;
											this._skyNoiseStrength = 0.96f;
											this._skyAlpha = 1f;
											this._density = 0.35f;
											this._noiseStrength = 0.1f;
											this._noiseScale = 1f;
											this._noiseSparse = 0f;
											this._distance = 20f;
											this._distanceFallOff = 0.8f;
											this._height = 18f;
											this._stepping = 6f;
											this._steppingNear = 0f;
											this._alpha = 1f;
											this._color = new Color(0.91f, 0.91f, 0.91f, 1f);
											this._skyColor = this._color;
											this._specularColor = new Color(1f, 1f, 0.8f, 1f);
											this._specularIntensity = 0f;
											this._specularThreshold = 0.6f;
											this._lightColor = Color.white;
											this._lightIntensity = 0f;
											this._speed = 0.015f;
											this._downsampling = 1;
											this._baselineRelativeToCamera = false;
											this.CheckWaterLevel(false);
											this._fogVoidRadius = 0f;
											this.CopyTransitionValues();
										}
									}
									else
									{
										this._skySpeed = 0.3f;
										this._skyHaze = 144f;
										this._skyNoiseStrength = 0.7f;
										this._skyAlpha = 0.9f;
										this._density = 0.35f;
										this._noiseStrength = 0.3f;
										this._noiseScale = 1f;
										this._noiseSparse = 0f;
										this._distance = 20f;
										this._distanceFallOff = 0.7f;
										this._height = 8f;
										this._stepping = 8f;
										this._steppingNear = 0f;
										this._alpha = 0.97f;
										this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
										this._skyColor = this._color;
										this._specularColor = new Color(1f, 1f, 0.8f, 1f);
										this._specularIntensity = 0f;
										this._specularThreshold = 0.6f;
										this._lightColor = Color.white;
										this._lightIntensity = 0f;
										this._speed = 0.05f;
										this._downsampling = 1;
										this._baselineRelativeToCamera = false;
										this.CheckWaterLevel(false);
										this._fogVoidRadius = 0f;
										this.CopyTransitionValues();
									}
								}
								else
								{
									this._skySpeed = 0.3f;
									this._skyHaze = 60f;
									this._skyNoiseStrength = 1f;
									this._skyAlpha = 0.96f;
									this._density = 1f;
									this._noiseStrength = 1f;
									this._noiseScale = 1.5f;
									this._noiseSparse = 0f;
									this._distance = 0f;
									this._distanceFallOff = 0f;
									this._height = 12.4f;
									this._stepping = 6f;
									this._alpha = 0.98f;
									this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
									this._skyColor = this._color;
									this._specularColor = new Color(1f, 1f, 0.8f, 1f);
									this._specularIntensity = 0.259f;
									this._specularThreshold = 0.6f;
									this._lightColor = Color.white;
									this._lightIntensity = 0.15f;
									this._speed = 0.008f;
									this._downsampling = 1;
									this._baselineRelativeToCamera = false;
									this.CheckWaterLevel(false);
									this._fogVoidRadius = 0f;
									this.CopyTransitionValues();
								}
							}
							else
							{
								this._skySpeed = 0.3f;
								this._skyHaze = 60f;
								this._skyNoiseStrength = 1f;
								this._skyAlpha = 0.96f;
								this._density = 1f;
								this._noiseStrength = 0.7f;
								this._noiseScale = 1f;
								this._noiseSparse = 0f;
								this._distance = 0f;
								this._distanceFallOff = 0f;
								this._height = 4f;
								this._stepping = 12f;
								this._steppingNear = 0f;
								this._alpha = 0.98f;
								this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
								this._skyColor = this._color;
								this._specularColor = new Color(1f, 1f, 0.8f, 1f);
								this._specularIntensity = 0.15f;
								this._specularThreshold = 0.6f;
								this._lightColor = Color.white;
								this._lightIntensity = 0.15f;
								this._speed = 0.008f;
								this._downsampling = 1;
								this._baselineRelativeToCamera = false;
								this.CheckWaterLevel(false);
								this._fogVoidRadius = 0f;
								this.CopyTransitionValues();
							}
						}
						else
						{
							this._skySpeed = 0.3f;
							this._skyHaze = 25f;
							this._skyNoiseStrength = 0.1f;
							this._skyAlpha = 0.85f;
							this._density = 0.3f;
							this._noiseStrength = 0.5f;
							this._noiseScale = 1.15f;
							this._noiseSparse = 0f;
							this._distance = 0f;
							this._distanceFallOff = 0f;
							this._height = 6.5f;
							this._stepping = 10f;
							this._steppingNear = 0f;
							this._alpha = 1f;
							this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
							this._skyColor = this._color;
							this._specularColor = new Color(1f, 1f, 0.8f, 1f);
							this._specularIntensity = 0.1f;
							this._specularThreshold = 0.6f;
							this._lightColor = Color.white;
							this._lightIntensity = 0f;
							this._speed = 0.15f;
							this._downsampling = 1;
							this._baselineRelativeToCamera = false;
							this.CheckWaterLevel(false);
							this._fogVoidRadius = 0f;
							this.CopyTransitionValues();
						}
					}
					else
					{
						this._skySpeed = 0.3f;
						this._skyHaze = 15f;
						this._skyNoiseStrength = 0.1f;
						this._skyAlpha = 0.8f;
						this._density = 0.3f;
						this._noiseStrength = 0.6f;
						this._noiseScale = 1f;
						this._noiseSparse = 0f;
						this._distance = 0f;
						this._distanceFallOff = 0f;
						this._height = 6f;
						this._stepping = 8f;
						this._steppingNear = 0f;
						this._alpha = 1f;
						this._color = new Color(0.89f, 0.89f, 0.89f, 1f);
						this._skyColor = this._color;
						this._specularColor = new Color(1f, 1f, 0.8f, 1f);
						this._specularIntensity = 0.1f;
						this._specularThreshold = 0.6f;
						this._lightColor = Color.white;
						this._lightIntensity = 0.12f;
						this._speed = 0.01f;
						this._downsampling = 1;
						this._baselineRelativeToCamera = false;
						this.CheckWaterLevel(false);
						this._fogVoidRadius = 0f;
						this.CopyTransitionValues();
					}
					break;
				}
				break;
			}
			this.currentFogAlpha = this._alpha;
			this.currentFogColor = this._color;
			this.currentFogSpecularColor = this._specularColor;
			this.currentLightColor = this._lightColor;
			this.currentSkyHazeAlpha = this._skyAlpha;
			this.UpdateSun();
			this.FogOfWarUpdateTexture();
			this.UpdateMaterialProperties();
			this.UpdateRenderComponents();
			this.UpdateTextureAlpha();
			this.UpdateTexture();
			if (this._sunShadows)
			{
				this.needUpdateDepthSunTexture = true;
			}
			else
			{
				this.DestroySunShadowsDependencies();
			}
			if (!Application.isPlaying)
			{
				this.UpdateWindSpeedQuick();
			}
			this.TrackPointLights();
			this.lastTimeSortInstances = 0f;
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x003BE448 File Offset: 0x003BC648
		public void CheckWaterLevel(bool baseZero)
		{
			if (this.mainCamera == null)
			{
				return;
			}
			if (this._baselineHeight > this.mainCamera.transform.position.y || baseZero)
			{
				this._baselineHeight = 0f;
			}
			GameObject gameObject = GameObject.Find("Water");
			if (gameObject == null)
			{
				GameObject[] array = UnityEngine.Object.FindObjectsOfType<GameObject>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].layer == 4)
					{
						gameObject = array[i];
						break;
					}
				}
			}
			if (gameObject != null)
			{
				this._renderBeforeTransparent = false;
				if (this._baselineHeight < gameObject.transform.position.y)
				{
					this._baselineHeight = gameObject.transform.position.y;
				}
			}
			this.UpdateMaterialHeights();
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x003BE524 File Offset: 0x003BC724
		public static Terrain GetActiveTerrain()
		{
			Terrain terrain = Terrain.activeTerrain;
			if (terrain != null && terrain.isActiveAndEnabled)
			{
				return terrain;
			}
			for (int i = 0; i < Terrain.activeTerrains.Length; i++)
			{
				terrain = Terrain.activeTerrains[i];
				if (terrain != null && terrain.isActiveAndEnabled)
				{
					return terrain;
				}
			}
			return null;
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x0002DBA1 File Offset: 0x0002BDA1
		private void UpdateMaterialFogColor()
		{
			this.fogMat.SetColor("_Color", this.currentFogColor * 2f);
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x003BE578 File Offset: 0x003BC778
		private void UpdateMaterialHeights()
		{
			this.currentFogAltitude = this._baselineHeight;
			Vector3 fogAreaPosition = this._fogAreaPosition;
			if (this._fogAreaRadius > 0f)
			{
				if (this._fogAreaCenter != null && this._fogAreaFollowMode == JJMDJDFJKLO.FullXYZ)
				{
					this.currentFogAltitude += this._fogAreaCenter.transform.position.y;
				}
				fogAreaPosition.y = 0f;
			}
			if (this._baselineRelativeToCamera && !this._useXYPlane)
			{
				this.oldBaselineRelativeCameraY += (this.mainCamera.transform.position.y - this.oldBaselineRelativeCameraY) * Mathf.Clamp01(1.001f - this._baselineRelativeToCameraDelay);
				this.currentFogAltitude += this.oldBaselineRelativeCameraY - 1f;
			}
			float w = 0.01f / this._noiseScale;
			this.fogMat.SetVector("_FogData", new Vector4(this.currentFogAltitude, this._height, 1f / this._density, w));
			this.fogMat.SetFloat("_FogSkyHaze", this._skyHaze + this.currentFogAltitude);
			Vector3 v = this._fogVoidPosition - this.currentFogAltitude * Vector3.up;
			this.fogMat.SetVector("_FogVoidPosition", v);
			this.fogMat.SetVector("_FogAreaPosition", fogAreaPosition);
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0002DBC3 File Offset: 0x0002BDC3
		public void UpdateMaterialProperties()
		{
			this.shouldUpdateMaterialProperties = true;
			if (!Application.isPlaying)
			{
				this.UpdateMaterialPropertiesNow();
			}
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x003BE6F8 File Offset: 0x003BC8F8
		private void UpdateMaterialPropertiesNow()
		{
			if (this.fogMat == null)
			{
				return;
			}
			this.shouldUpdateMaterialProperties = false;
			this.UpdateSkyColor(this._skyAlpha);
			Vector4 value = new Vector4(1f / (this._stepping + 1f), 1f / (1f + this._steppingNear), this._edgeThreshold, (!this._dithering) ? 0f : (this._ditherStrength * 0.1f));
			this.fogMat.SetFloat("_Jitter", this._jitterStrength);
			if (!this._edgeImprove)
			{
				value.z = 0f;
			}
			this.fogMat.SetVector("_FogStepping", value);
			this.fogMat.SetFloat("_FogAlpha", this.currentFogAlpha);
			this.UpdateMaterialHeights();
			float num = 0.01f / this._noiseScale;
			float w = this._maxFogLength * this._maxFogLengthFallOff + 1f;
			this.fogMat.SetVector("_FogDistance", new Vector4(num * num * this._distance * this._distance, this._distanceFallOff * this._distanceFallOff + 0.1f, this._maxFogLength, w));
			this.UpdateMaterialFogColor();
			if (this.shaderKeywords == null)
			{
				this.shaderKeywords = new List<string>();
			}
			else
			{
				this.shaderKeywords.Clear();
			}
			if (this._distance > 0f)
			{
				this.shaderKeywords.Add("FOG_DISTANCE_ON");
			}
			if (this._fogVoidRadius > 0f && this._fogVoidFallOff > 0f)
			{
				Vector4 value2 = new Vector4(1f / (1f + this._fogVoidRadius), 1f / (1f + this._fogVoidHeight), 1f / (1f + this._fogVoidDepth), this._fogVoidFallOff);
				if (this._fogVoidTopology == OQCOLFQILDJ.Box)
				{
					this.shaderKeywords.Add("FOG_VOID_BOX");
				}
				else
				{
					this.shaderKeywords.Add("FOG_VOID_SPHERE");
				}
				this.fogMat.SetVector("_FogVoidData", value2);
			}
			if (this._fogAreaRadius > 0f && this._fogAreaFallOff > 0f)
			{
				Vector4 value3 = new Vector4(1f / (0.0001f + this._fogAreaRadius), 1f / (0.0001f + this._fogAreaHeight), 1f / (0.0001f + this._fogAreaDepth), this._fogAreaFallOff);
				if (this._fogAreaTopology == FNHCOCLFCFE.Box)
				{
					this.shaderKeywords.Add("FOG_AREA_BOX");
				}
				else
				{
					this.shaderKeywords.Add("FOG_AREA_SPHERE");
					value3.y = this._fogAreaRadius * this._fogAreaRadius;
					value3.x /= num;
					value3.z /= num;
				}
				this.fogMat.SetVector("_FogAreaData", value3);
			}
			if (this._skyHaze > 0f && this._skyAlpha > 0f && !this._useXYPlane && this.hasCamera)
			{
				this.shaderKeywords.Add("FOG_HAZE_ON");
			}
			if (this._fogOfWarEnabled)
			{
				this.shaderKeywords.Add("FOG_OF_WAR_ON");
				this.fogMat.SetTexture("_FogOfWar", this.fogOfWarTexture);
				this.fogMat.SetVector("_FogOfWarCenter", this._fogOfWarCenter);
				this.fogMat.SetVector("_FogOfWarSize", this._fogOfWarSize);
				Vector3 vector = this._fogOfWarCenter - 0.5f * this._fogOfWarSize;
				if (this._useXYPlane)
				{
					this.fogMat.SetVector("_FogOfWarCenterAdjusted", new Vector3(vector.x / this._fogOfWarSize.x, vector.y / (this._fogOfWarSize.y + 0.0001f), 1f));
				}
				else
				{
					this.fogMat.SetVector("_FogOfWarCenterAdjusted", new Vector3(vector.x / this._fogOfWarSize.x, 1f, vector.z / (this._fogOfWarSize.z + 0.0001f)));
				}
			}
			int num2 = -1;
			for (int i = 0; i < 6; i++)
			{
				if (this._pointLights[i] != null || this._pointLightRanges[i] * this._pointLightIntensities[i] > 0f)
				{
					num2 = i;
				}
			}
			if (num2 >= 0)
			{
				this.shaderKeywords.Add("FOG_POINT_LIGHT" + num2.ToString());
			}
			if (this.fogRenderer.sun)
			{
				this.UpdateScatteringData();
				if (this._lightScatteringEnabled && this._lightScatteringExposure > 0f)
				{
					this.shaderKeywords.Add("FOG_SCATTERING_ON");
				}
				if (this._sunShadows)
				{
					this.shaderKeywords.Add("FOG_SUN_SHADOWS_ON");
					this.UpdateSunShadowsData();
				}
			}
			if (this._fogBlur)
			{
				this.shaderKeywords.Add("FOG_BLUR_ON");
				this.fogMat.SetFloat("_FogBlurDepth", this._fogBlurDepth);
			}
			if (this._useXYPlane)
			{
				this.shaderKeywords.Add("FOG_USE_XY_PLANE");
			}
			if (this.fogRenderer.computeDepth)
			{
				this.shaderKeywords.Add("FOG_COMPUTE_DEPTH");
			}
			this.fogMat.shaderKeywords = this.shaderKeywords.ToArray();
			if (this._computeDepth && this._computeDepthScope == FDGBELCFEDF.TreeBillboardsAndTransparentObjects)
			{
				Shader.SetGlobalFloat("_VFM_CutOff", this._transparencyCutOff);
			}
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x003BEC98 File Offset: 0x003BCE98
		private void UpdateSunShadowsData()
		{
			if (!(this._sun == null) && this._sunShadows && !(this.fogMat == null))
			{
				float num = this._sunShadowsStrength * Mathf.Clamp01(-this._sun.transform.forward.y * 10f);
				if (num < 0f)
				{
					num = 0f;
				}
				if (num > 0f && !this.fogMat.IsKeywordEnabled("FOG_SUN_SHADOWS_ON"))
				{
					this.fogMat.EnableKeyword("FOG_SUN_SHADOWS_ON");
				}
				else if (num <= 0f && this.fogMat.IsKeywordEnabled("FOG_SUN_SHADOWS_ON"))
				{
					this.fogMat.DisableKeyword("FOG_SUN_SHADOWS_ON");
				}
				if (this._hasCamera)
				{
					Shader.SetGlobalVector("_VolumetricFogSunShadowsData", new Vector4(num, this._sunShadowsJitterStrength, this._sunShadowsCancellation, 0f));
				}
				return;
			}
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x003BED8C File Offset: 0x003BCF8C
		private void UpdateWindSpeedQuick()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (Application.isPlaying && this.lastFrameAppliedWind == Time.frameCount)
			{
				return;
			}
			this.lastFrameAppliedWind = Time.frameCount;
			float d = 0.01f / this._noiseScale;
			this.windSpeedAcum += this.deltaTime * this._windDirection * this._speed / d;
			this.fogMat.SetVector("_FogWindDir", this.windSpeedAcum);
			this.skyHazeSpeedAcum += this.deltaTime * this._skySpeed / 20f;
			this.fogMat.SetVector("_FogSkyData", new Vector4(this._skyHaze, this._skyNoiseStrength, this.skyHazeSpeedAcum, this._skyDepth));
		}

		// Token: 0x06007E42 RID: 32322 RVA: 0x003BEE70 File Offset: 0x003BD070
		private void UpdateScatteringData()
		{
			Vector3 vector = this.mainCamera.WorldToViewportPoint(this.fogRenderer.sun.transform.forward * 10000f);
			if (vector.z < 0f)
			{
				Vector2 vector2 = new Vector2(vector.x, vector.y);
				float num = Mathf.Clamp01(1f - this._lightDirection.y);
				if (vector2 != this.oldSunPos)
				{
					this.oldSunPos = vector2;
					this.fogMat.SetVector("_SunPosition", vector2);
					this.sunFade = Mathf.SmoothStep(1f, 0f, (vector2 - Vector2.one * 0.5f).magnitude * 0.5f) * num;
				}
				if (this._lightScatteringEnabled && !this.fogMat.IsKeywordEnabled("FOG_SCATTERING_ON"))
				{
					this.fogMat.EnableKeyword("FOG_SCATTERING_ON");
				}
				float num2 = this._lightScatteringExposure * this.sunFade;
				this.fogMat.SetVector("_FogScatteringData", new Vector4(this._lightScatteringSpread / (float)this._lightScatteringSamples, (float)((num2 <= 0f) ? 0 : this._lightScatteringSamples), num2, this._lightScatteringWeight / (float)this._lightScatteringSamples));
				this.fogMat.SetVector("_FogScatteringData2", new Vector4(this._lightScatteringIllumination, this._lightScatteringDecay, this._lightScatteringJittering, (!this._lightScatteringEnabled) ? 0f : (1.2f * this._lightScatteringDiffusion * num * this.sunLightIntensity)));
				this.fogMat.SetVector("_SunDir", -this._lightDirection);
				this.fogMat.SetColor("_SunColor", this._lightColor);
			}
			else if (this.fogMat.IsKeywordEnabled("FOG_SCATTERING_ON"))
			{
				this.fogMat.DisableKeyword("FOG_SCATTERING_ON");
			}
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x0002DBD9 File Offset: 0x0002BDD9
		private void UpdateSun()
		{
			if (this.fogRenderer.sun != null)
			{
				this.sunLight = this.fogRenderer.sun.GetComponent<Light>();
			}
			else
			{
				this.sunLight = null;
			}
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x003BF070 File Offset: 0x003BD270
		private void UpdateSkyColor(float alpha)
		{
			if (this.fogMat == null)
			{
				return;
			}
			float num = (this._lightIntensity + this.sunLightIntensity) * Mathf.Clamp01(1f - this._lightDirection.y);
			if (num < 0f)
			{
				num = 0f;
			}
			else if (num > 1f)
			{
				num = 1f;
			}
			this._skyColor.a = alpha;
			Color value = num * this._skyColor;
			this.fogMat.SetColor("_FogSkyColor", value);
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x003BF0FC File Offset: 0x003BD2FC
		private void UpdatePointLights()
		{
			for (int i = 0; i < this._pointLights.Length; i++)
			{
				GameObject gameObject = this._pointLights[i];
				if (gameObject != null)
				{
					this.pointLightComponents[i] = gameObject.GetComponent<Light>();
				}
				else
				{
					this.pointLightComponents[i] = null;
				}
			}
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x003BF148 File Offset: 0x003BD348
		private void UpdateTextureAlpha()
		{
			if (this.adjustedColors == null)
			{
				return;
			}
			float num = Mathf.Clamp(this._noiseStrength, 0f, 0.95f);
			for (int i = 0; i < this.adjustedColors.Length; i++)
			{
				float num2 = 1f - (this._noiseSparse + this.noiseColors[i].b) * num;
				num2 *= this._density * this._noiseFinalMultiplier;
				if (num2 < 0f)
				{
					num2 = 0f;
				}
				else if (num2 > 1f)
				{
					num2 = 1f;
				}
				this.adjustedColors[i].a = num2;
			}
			this.hasChangeAdjustedColorsAlpha = true;
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x003BF1F0 File Offset: 0x003BD3F0
		private void UpdateTexture()
		{
			if (this.fogMat == null)
			{
				return;
			}
			this.UpdateSkyColor(this._skyAlpha);
			float num = this._lightIntensity + this.sunLightIntensity;
			if (!this._useXYPlane)
			{
				num *= Mathf.Clamp01(1f - this._lightDirection.y * 2f);
			}
			QQGJJNPLKME lightingModel = this._lightingModel;
			if (lightingModel != QQGJJNPLKME.Natural)
			{
				if (lightingModel != QQGJJNPLKME.SingleLight)
				{
					Color a = RenderSettings.ambientLight * RenderSettings.ambientIntensity;
					this.updatingTextureLightColor = Color.Lerp(a, this.currentLightColor * num, num);
					this.lastRenderSettingsAmbientLight = RenderSettings.ambientLight;
					this.lastRenderSettingsAmbientIntensity = RenderSettings.ambientIntensity;
				}
				else
				{
					this.updatingTextureLightColor = Color.Lerp(Color.black, this.currentLightColor * num, this._lightIntensity);
				}
			}
			else
			{
				Color ambientLight = RenderSettings.ambientLight;
				this.lastRenderSettingsAmbientLight = RenderSettings.ambientLight;
				this.updatingTextureLightColor = Color.Lerp(ambientLight, this.currentLightColor * num + ambientLight, this._lightIntensity);
			}
			if (Application.isPlaying)
			{
				this.updatingTextureSlice = 0;
			}
			else
			{
				this.updatingTextureSlice = -1;
			}
			this.UpdateTextureColors(this.adjustedColors, this.hasChangeAdjustedColorsAlpha);
			this.needUpdateTexture = false;
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x003BF328 File Offset: 0x003BD528
		private void UpdateTextureColors(Color[] colors, bool forceUpdateEntireTexture)
		{
			float num = 1.0001f - this._specularThreshold;
			int width = this.adjustedTexture.width;
			Vector3 vector = new Vector3(-this._lightDirection.x, 0f, -this._lightDirection.z);
			Vector3 vector2 = vector.normalized * 0.3f;
			vector2.y = ((this._lightDirection.y <= 0f) ? (1f - Mathf.Clamp01(-this._lightDirection.y)) : Mathf.Clamp01(1f - this._lightDirection.y));
			int num2 = Mathf.FloorToInt(vector2.z * (float)width) * width;
			int num3 = (int)((float)num2 + vector2.x * (float)width) + colors.Length;
			float num4 = vector2.y / num;
			Color color = this.currentFogSpecularColor * (1f + this._specularIntensity) * this._specularIntensity;
			bool flag = false;
			if (this.updatingTextureSlice >= 1 || forceUpdateEntireTexture)
			{
				flag = true;
			}
			float num5 = this.updatingTextureLightColor.r * 0.5f;
			float num6 = this.updatingTextureLightColor.g * 0.5f;
			float num7 = this.updatingTextureLightColor.b * 0.5f;
			float num8 = color.r * 0.5f;
			float num9 = color.g * 0.5f;
			float num10 = color.b * 0.5f;
			int num11 = colors.Length;
			int num12 = 0;
			int num13 = num11;
			if (this.updatingTextureSlice >= 0)
			{
				if (this.updatingTextureSlice > this._updateTextureSpread)
				{
					this.updatingTextureSlice = -1;
					this.needUpdateTexture = true;
					return;
				}
				num12 = num11 * this.updatingTextureSlice / this._updateTextureSpread;
				num13 = num11 * (this.updatingTextureSlice + 1) / this._updateTextureSpread;
			}
			int num14 = 0;
			for (int i = num12; i < num13; i++)
			{
				int num15 = (i + num3) % num11;
				float a = colors[i].a;
				float num16 = (a - colors[num15].a) * num4;
				if (num16 < 0f)
				{
					num16 = 0f;
				}
				else if (num16 > 1f)
				{
					num16 = 1f;
				}
				float num17 = num5 + num8 * num16;
				float num18 = num6 + num9 * num16;
				float num19 = num7 + num10 * num16;
				if (!flag)
				{
					if (num14++ < 100)
					{
						if (num17 != colors[i].r || num18 != colors[i].g || num19 != colors[i].b)
						{
							flag = true;
						}
					}
					else if (!flag)
					{
						break;
					}
				}
				colors[i].r = num17;
				colors[i].g = num18;
				colors[i].b = num19;
			}
			bool flag2 = forceUpdateEntireTexture;
			if (flag)
			{
				if (this.updatingTextureSlice >= 0)
				{
					this.updatingTextureSlice++;
					if (this.updatingTextureSlice >= this._updateTextureSpread)
					{
						this.updatingTextureSlice = -1;
						flag2 = true;
					}
				}
				else
				{
					flag2 = true;
				}
			}
			else
			{
				this.updatingTextureSlice = -1;
			}
			if (flag2)
			{
				if (Application.isPlaying && this._turbulenceStrength > 0f && this.adjustedChaosTexture)
				{
					this.adjustedChaosTexture.SetPixels(this.adjustedColors);
					this.adjustedChaosTexture.Apply();
				}
				else
				{
					this.adjustedTexture.SetPixels(this.adjustedColors);
					this.adjustedTexture.Apply();
					this.fogMat.SetTexture("_NoiseTex", this.adjustedTexture);
				}
				this.lastTextureUpdate = Time.time;
			}
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x003BF6B8 File Offset: 0x003BD8B8
		internal void ApplyChaos()
		{
			if (this.adjustedTexture)
			{
				if (!Application.isPlaying || this.lastFrameAppliedChaos != Time.frameCount)
				{
					this.lastFrameAppliedChaos = Time.frameCount;
					if (this.chaosLerpMat == null)
					{
						Shader shader = Shader.Find("VolumetricFogAndMist/Chaos Lerp");
						this.chaosLerpMat = new Material(shader);
						this.chaosLerpMat.hideFlags = HideFlags.DontSave;
					}
					this.turbAcum += this.deltaTime * this._turbulenceStrength;
					this.chaosLerpMat.SetFloat("_Amount", this.turbAcum);
					if (!this.adjustedChaosTexture)
					{
						this.adjustedChaosTexture = UnityEngine.Object.Instantiate<Texture2D>(this.adjustedTexture);
						this.adjustedChaosTexture.hideFlags = HideFlags.DontSave;
					}
					RenderTexture temporary = RenderTexture.GetTemporary(this.adjustedTexture.width, this.adjustedTexture.height, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
					temporary.wrapMode = TextureWrapMode.Repeat;
					Graphics.Blit(this.adjustedChaosTexture, temporary, this.chaosLerpMat);
					this.fogMat.SetTexture("_NoiseTex", temporary);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
			}
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x0002DC0D File Offset: 0x0002BE0D
		private void CopyTransitionValues()
		{
			this.currentFogAlpha = this._alpha;
			this.currentSkyHazeAlpha = this._skyAlpha;
			this.currentFogColor = this._color;
			this.currentFogSpecularColor = this._specularColor;
			this.currentLightColor = this._lightColor;
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x003BF7D8 File Offset: 0x003BD9D8
		public void SetTargetProfile(VolumetricFogProfile targetProfile, float duration)
		{
			if (!this._useFogVolumes)
			{
				return;
			}
			this.initialProfile = ScriptableObject.CreateInstance<VolumetricFogProfile>();
			this.initialProfile.Save(this);
			this.targetProfile = targetProfile;
			this.transitionDuration = duration;
			this.transitionStartTime = Time.time;
			this.transitionProfile = true;
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x0002DC4B File Offset: 0x0002BE4B
		public void ClearTargetProfile(float duration)
		{
			this.SetTargetProfile(this.initialProfile, duration);
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x003BF828 File Offset: 0x003BDA28
		public void SetTargetAlpha(float newFogAlpha, float newSkyHazeAlpha, float duration)
		{
			if (!this._useFogVolumes)
			{
				return;
			}
			this.initialFogAlpha = this.currentFogAlpha;
			this.initialSkyHazeAlpha = this.currentSkyHazeAlpha;
			this.targetFogAlpha = newFogAlpha;
			this.targetSkyHazeAlpha = newSkyHazeAlpha;
			this.transitionDuration = duration;
			this.transitionStartTime = Time.time;
			this.transitionAlpha = true;
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x0002DC5A File Offset: 0x0002BE5A
		public void ClearTargetAlpha(float duration)
		{
			this.SetTargetAlpha(-1f, -1f, duration);
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0002DC6D File Offset: 0x0002BE6D
		public void SetTargetColor(Color newColor, float duration)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.initialFogColor = this.currentFogColor;
			this.targetFogColor = newColor;
			this.transitionDuration = duration;
			this.transitionStartTime = Time.time;
			this.transitionColor = true;
			this.targetColorActive = true;
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0002DCAB File Offset: 0x0002BEAB
		public void ClearTargetColor(float duration)
		{
			this.SetTargetColor(this._color, duration);
			this.targetColorActive = false;
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0002DCC1 File Offset: 0x0002BEC1
		public void SetTargetSpecularColor(Color newSpecularColor, float duration)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.initialFogSpecularColor = this.currentFogSpecularColor;
			this.targetFogSpecularColor = newSpecularColor;
			this.transitionDuration = duration;
			this.transitionStartTime = Time.time;
			this.transitionSpecularColor = true;
			this.targetSpecularColorActive = true;
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x0002DCFF File Offset: 0x0002BEFF
		public void ClearTargetSpecularColor(float duration)
		{
			this.SetTargetSpecularColor(this._specularColor, duration);
			this.targetSpecularColorActive = false;
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x003BF880 File Offset: 0x003BDA80
		public void SetTargetLightColor(Color newLightColor, float duration)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this._sunCopyColor = false;
			this.initialLightColor = this.currentLightColor;
			this.targetLightColor = newLightColor;
			this.transitionDuration = duration;
			this.transitionStartTime = Time.time;
			this.transitionLightColor = true;
			this.targetLightColorActive = true;
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x0002DD15 File Offset: 0x0002BF15
		public void ClearTargetLightColor(float duration)
		{
			this.SetTargetLightColor(this._lightColor, duration);
			this.targetLightColorActive = false;
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x003BF8D0 File Offset: 0x003BDAD0
		private void SetMaterialLightData(int k, Light lightComponent)
		{
			Vector3 v = this._pointLightPositions[k];
			if (!this._sunShadows)
			{
				v.y -= this._baselineHeight;
			}
			float w = this._pointLightRanges[k] * this._pointLightInscattering / 25f;
			float num = this._pointLightIntensity * this._pointLightIntensities[k] * this._pointLightIntensitiesMultiplier[k];
			if (this._distance > 0f)
			{
				float num2 = 0.01f / this._noiseScale;
				float num3 = this._distance * num2;
				Vector3 position = this.mainCamera.transform.position;
				Vector2 vector = new Vector2((position.x - v.x) * num2, (position.z - v.z) * num2);
				float num4 = Mathf.Max(num3 * num3 - vector.sqrMagnitude, 0f);
				num4 *= this._distanceFallOff * this._distanceFallOff + 0.1f;
				num = Mathf.Max(num - num4, 0f);
			}
			Vector4 value = new Vector4(this._pointLightColors[k].r * num, this._pointLightColors[k].g * num, this._pointLightColors[k].b * num, w);
			this.fogMat.SetVector(VolumetricFog.pointLightPositionUniformNames[k], v);
			this.fogMat.SetVector(VolumetricFog.pointLightColorUniformNames[k], value);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0002DD2B File Offset: 0x0002BF2B
		public GameObject GetPointLight(int index)
		{
			if (index >= 0 && index <= this._pointLights.Length)
			{
				return this._pointLights[index];
			}
			return null;
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x0002DD46 File Offset: 0x0002BF46
		public void SetPointLight(int index, GameObject pointLight)
		{
			if (index >= 0 && index <= this._pointLights.Length)
			{
				if (this._pointLights[index] != pointLight)
				{
					this._pointLights[index] = pointLight;
					this.UpdatePointLights();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x0002DD84 File Offset: 0x0002BF84
		public float GetPointLightRange(int index)
		{
			if (index >= 0 && index <= this._pointLightRanges.Length)
			{
				return this._pointLightRanges[index];
			}
			return 0f;
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x0002DDA3 File Offset: 0x0002BFA3
		public void SetPointLightRange(int index, float range)
		{
			if (index >= 0 && index <= this._pointLightRanges.Length)
			{
				if (range != this._pointLightRanges[index])
				{
					this._pointLightRanges[index] = range;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x0002DDD6 File Offset: 0x0002BFD6
		public float GetPointLightIntensity(int index)
		{
			if (index >= 0 && index <= this._pointLightIntensities.Length)
			{
				return this._pointLightIntensities[index];
			}
			return 0f;
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x0002DDF5 File Offset: 0x0002BFF5
		public void SetPointLightIntensity(int index, float intensity)
		{
			if (index >= 0 && index <= this._pointLightIntensities.Length)
			{
				if (intensity != this._pointLightIntensities[index])
				{
					this._pointLightIntensities[index] = intensity;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x0002DE28 File Offset: 0x0002C028
		public float GetPointLightIntensityMultiplier(int index)
		{
			if (index >= 0 && index <= this._pointLightIntensitiesMultiplier.Length)
			{
				return this._pointLightIntensitiesMultiplier[index];
			}
			return 0f;
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0002DE47 File Offset: 0x0002C047
		public void SetPointLightIntensityMultiplier(int index, float intensityMultiplier)
		{
			if (index >= 0 && index <= this._pointLightIntensitiesMultiplier.Length)
			{
				if (intensityMultiplier != this._pointLightIntensitiesMultiplier[index])
				{
					this._pointLightIntensitiesMultiplier[index] = intensityMultiplier;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0002DE7A File Offset: 0x0002C07A
		public Vector3 GetPointLightPosition(int index)
		{
			if (index >= 0 && index <= this._pointLightPositions.Length)
			{
				return this._pointLightPositions[index];
			}
			return Vector3.zero;
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x003BFA4C File Offset: 0x003BDC4C
		public void SetPointLightPosition(int index, Vector3 position)
		{
			if (index >= 0 && index <= this._pointLightPositions.Length)
			{
				if (position != this._pointLightPositions[index])
				{
					this._pointLightPositions[index] = position;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x0002DEA2 File Offset: 0x0002C0A2
		public Color GetPointLightColor(int index)
		{
			if (index >= 0 && index <= this._pointLightColors.Length)
			{
				return this._pointLightColors[index];
			}
			return Color.white;
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x003BFAA4 File Offset: 0x003BDCA4
		public void SetPointLightColor(int index, Color color)
		{
			if (index >= 0 && index <= this._pointLightColors.Length)
			{
				if (color != this._pointLightColors[index])
				{
					this._pointLightColors[index] = color;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
				return;
			}
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x0002DECA File Offset: 0x0002C0CA
		private void TrackNewLights()
		{
			this.lastFoundLights = UnityEngine.Object.FindObjectsOfType<Light>();
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x003BFAFC File Offset: 0x003BDCFC
		private void TrackPointLights()
		{
			if (!this._pointLightTrackingAuto)
			{
				return;
			}
			if (this._pointLightTrackingPivot == null)
			{
				this._pointLightTrackingPivot = base.transform;
			}
			if (this.lastFoundLights == null || !Application.isPlaying || Time.time - this.trackPointCheckNewLightsLastTime > 3f)
			{
				this.trackPointCheckNewLightsLastTime = Time.time;
				this.TrackNewLights();
			}
			int num = this.lastFoundLights.Length;
			if (this.lightBuffer == null || this.lightBuffer.Length != num)
			{
				this.lightBuffer = new Light[num];
			}
			for (int i = 0; i < num; i++)
			{
				this.lightBuffer[i] = this.lastFoundLights[i];
			}
			bool flag = false;
			for (int j = 0; j < 6; j++)
			{
				GameObject gameObject = null;
				if (j < this._pointLightTrackingCount)
				{
					gameObject = this.GetNearestLight(this.lightBuffer);
				}
				this._pointLights[j] = gameObject;
				if (this._pointLightRanges[j] != 0f && gameObject == null)
				{
					this._pointLightRanges[j] = 0f;
				}
				if (this.currentLights[j] != gameObject)
				{
					this.currentLights[j] = gameObject;
					flag = true;
				}
			}
			if (flag)
			{
				this.UpdatePointLights();
				this.UpdateMaterialProperties();
			}
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x003BFC28 File Offset: 0x003BDE28
		private GameObject GetNearestLight(Light[] lights)
		{
			float num = float.MaxValue;
			Vector3 position = this._pointLightTrackingPivot.position;
			GameObject result = null;
			int num2 = -1;
			for (int i = 0; i < lights.Length; i++)
			{
				Light light = lights[i];
				if (!(light == null) && light.enabled)
				{
					if (light.type == LightType.Point)
					{
						GameObject gameObject = lights[i].gameObject;
						if (gameObject.activeSelf)
						{
							float sqrMagnitude = (gameObject.transform.position - position).sqrMagnitude;
							if (sqrMagnitude < num)
							{
								result = gameObject;
								num = sqrMagnitude;
								num2 = i;
							}
						}
					}
				}
			}
			if (num2 >= 0)
			{
				lights[num2] = null;
			}
			return result;
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x003BFCCC File Offset: 0x003BDECC
		public static VolumetricFog CreateFogArea(Vector3 position, float radius, float height = 16f, float fallOff = 1f)
		{
			VolumetricFog volumetricFog = VolumetricFog.CreateFogAreaPlaceholder(true, position, radius, height, radius);
			volumetricFog.preset = QDIEOOCIEOL.SeaClouds;
			volumetricFog.transform.position = position;
			volumetricFog.skyHaze = 0f;
			volumetricFog.dithering = true;
			return volumetricFog;
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x003BFD0C File Offset: 0x003BDF0C
		public static VolumetricFog CreateFogArea(Vector3 position, Vector3 boxSize)
		{
			VolumetricFog volumetricFog = VolumetricFog.CreateFogAreaPlaceholder(false, position, boxSize.x * 0.5f, boxSize.y * 0.5f, boxSize.z * 0.5f);
			volumetricFog.preset = QDIEOOCIEOL.SeaClouds;
			volumetricFog.transform.position = position;
			volumetricFog.height = boxSize.y * 0.98f;
			volumetricFog.skyHaze = 0f;
			return volumetricFog;
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x003BFD7C File Offset: 0x003BDF7C
		private static VolumetricFog CreateFogAreaPlaceholder(bool spherical, Vector3 position, float radius, float height, float depth)
		{
			GameObject original = (!spherical) ? Resources.Load<GameObject>("Prefabs/FogBoxArea") : Resources.Load<GameObject>("Prefabs/FogSphereArea");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(original);
			gameObject.transform.position = position;
			gameObject.transform.localScale = new Vector3(radius, height, depth);
			return gameObject.GetComponent<VolumetricFog>();
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x003BFDD0 File Offset: 0x003BDFD0
		public static void RemoveAllFogAreas()
		{
			VolumetricFog[] array = UnityEngine.Object.FindObjectsOfType<VolumetricFog>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && !array[i].hasCamera)
				{
					UnityEngine.Object.DestroyImmediate(array[i].gameObject);
				}
			}
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x003BFE14 File Offset: 0x003BE014
		private void CheckFogAreaDimensions()
		{
			if (!this._hasCamera && this.mr == null)
			{
				this.mr = base.GetComponent<MeshRenderer>();
			}
			if (this.mr == null)
			{
				return;
			}
			Vector3 extents = this.mr.bounds.extents;
			FNHCOCLFCFE fogAreaTopology = this._fogAreaTopology;
			if (fogAreaTopology != FNHCOCLFCFE.Box)
			{
				if (fogAreaTopology == FNHCOCLFCFE.Sphere)
				{
					this.fogAreaRadius = extents.x;
					if (base.transform.localScale.z != base.transform.localScale.x)
					{
						base.transform.localScale = new Vector3(base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.x);
					}
				}
			}
			else
			{
				this.fogAreaRadius = extents.x;
				this.fogAreaHeight = extents.y;
				this.fogAreaDepth = extents.z;
			}
			if (this._fogAreaCenter != null)
			{
				if (this._fogAreaFollowMode == JJMDJDFJKLO.FullXYZ)
				{
					base.transform.position = this._fogAreaCenter.transform.position;
				}
				else
				{
					base.transform.position = new Vector3(this._fogAreaCenter.transform.position.x, base.transform.position.y, this._fogAreaCenter.transform.position.z);
				}
			}
			this.fogAreaPosition = base.transform.position;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x0002DED7 File Offset: 0x0002C0D7
		// (set) Token: 0x06007E6B RID: 32363 RVA: 0x0002DEDF File Offset: 0x0002C0DF
		public bool fogOfWarEnabled
		{
			get
			{
				return this._fogOfWarEnabled;
			}
			set
			{
				if (value != this._fogOfWarEnabled)
				{
					this._fogOfWarEnabled = value;
					this.FogOfWarUpdateTexture();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x0002DF04 File Offset: 0x0002C104
		// (set) Token: 0x06007E6D RID: 32365 RVA: 0x0002DF0C File Offset: 0x0002C10C
		public Vector3 fogOfWarCenter
		{
			get
			{
				return this._fogOfWarCenter;
			}
			set
			{
				if (value != this._fogOfWarCenter)
				{
					this._fogOfWarCenter = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x0002DF30 File Offset: 0x0002C130
		// (set) Token: 0x06007E6F RID: 32367 RVA: 0x0002DF38 File Offset: 0x0002C138
		public Vector3 fogOfWarSize
		{
			get
			{
				return this._fogOfWarSize;
			}
			set
			{
				if (value != this._fogOfWarSize && value.x > 0f && value.z > 0f)
				{
					this._fogOfWarSize = value;
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0002DF78 File Offset: 0x0002C178
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x0002DF80 File Offset: 0x0002C180
		public int fogOfWarTextureSize
		{
			get
			{
				return this._fogOfWarTextureSize;
			}
			set
			{
				if (value != this._fogOfWarTextureSize && value > 16)
				{
					this._fogOfWarTextureSize = value;
					this.FogOfWarUpdateTexture();
					this.UpdateMaterialProperties();
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0002DFAA File Offset: 0x0002C1AA
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x0002DFB2 File Offset: 0x0002C1B2
		public float fogOfWarRestoreDelay
		{
			get
			{
				return this._fogOfWarRestoreDelay;
			}
			set
			{
				if (value != this._fogOfWarRestoreDelay)
				{
					this._fogOfWarRestoreDelay = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0002DFCB File Offset: 0x0002C1CB
		// (set) Token: 0x06007E75 RID: 32373 RVA: 0x0002DFD3 File Offset: 0x0002C1D3
		public float fogOfWarRestoreDuration
		{
			get
			{
				return this._fogOfWarRestoreDuration;
			}
			set
			{
				if (value != this._fogOfWarRestoreDuration)
				{
					this._fogOfWarRestoreDuration = value;
					this.isDirty = true;
				}
			}
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0002DFEC File Offset: 0x0002C1EC
		private void FogOfWarInit()
		{
			this.fowTransitionList = new VolumetricFog.BBIQDMFGCNQ[10000];
			this.fowTransitionIndices = new Dictionary<int, int>(10000);
			this.lastTransitionPos = -1;
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x003BFFC4 File Offset: 0x003BE1C4
		private void FogOfWarUpdateTexture()
		{
			if (!this._fogOfWarEnabled)
			{
				return;
			}
			int scaledSize = this.GetScaledSize(this._fogOfWarTextureSize, 1f);
			if (this.fogOfWarTexture == null || this.fogOfWarTexture.width != scaledSize || this.fogOfWarTexture.height != scaledSize)
			{
				this.fogOfWarTexture = new Texture2D(scaledSize, scaledSize, TextureFormat.Alpha8, false);
				this.fogOfWarTexture.hideFlags = HideFlags.DontSave;
				this.fogOfWarTexture.filterMode = FilterMode.Bilinear;
				this.fogOfWarTexture.wrapMode = TextureWrapMode.Clamp;
				this.ResetFogOfWar();
			}
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x003C0050 File Offset: 0x003BE250
		private void FogOfWarUpdate()
		{
			if (!this._fogOfWarEnabled)
			{
				return;
			}
			int width = this.fogOfWarTexture.width;
			for (int i = 0; i <= this.lastTransitionPos; i++)
			{
				VolumetricFog.BBIQDMFGCNQ bbiqdmfgcnq = this.fowTransitionList[i];
				if (bbiqdmfgcnq.PIIMECMDJMH)
				{
					float num = Time.time - bbiqdmfgcnq.HOFHHQDFNCD - bbiqdmfgcnq.MLOOPDKFCHD;
					if (num > 0f)
					{
						float num2 = (bbiqdmfgcnq.CPKNEQGKQPQ > 0f) ? (num / bbiqdmfgcnq.CPKNEQGKQPQ) : 1f;
						num2 = Mathf.Clamp01(num2);
						byte a = (byte)Mathf.Lerp((float)bbiqdmfgcnq.MDJBEIHNIID, (float)bbiqdmfgcnq.KBHFNKLJBBE, num2);
						int num3 = bbiqdmfgcnq.DDLQKFDFMCJ * width + bbiqdmfgcnq.DGKOIGOLHDM;
						this.fogOfWarColorBuffer[num3].a = a;
						this.fogOfWarTexture.SetPixel(bbiqdmfgcnq.DGKOIGOLHDM, bbiqdmfgcnq.DDLQKFDFMCJ, this.fogOfWarColorBuffer[num3]);
						this.requiresTextureUpload = true;
						if (num2 >= 1f)
						{
							this.fowTransitionList[i].PIIMECMDJMH = false;
							if (bbiqdmfgcnq.KBHFNKLJBBE < 255 && this._fogOfWarRestoreDelay > 0f)
							{
								this.AddFowOfWarTransitionSlot(bbiqdmfgcnq.DGKOIGOLHDM, bbiqdmfgcnq.DDLQKFDFMCJ, bbiqdmfgcnq.KBHFNKLJBBE, byte.MaxValue, this._fogOfWarRestoreDelay, this._fogOfWarRestoreDuration);
							}
						}
					}
				}
			}
			if (this.requiresTextureUpload)
			{
				this.requiresTextureUpload = false;
				this.fogOfWarTexture.Apply();
			}
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0002E015 File Offset: 0x0002C215
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha)
		{
			this.SetFogOfWarAlpha(worldPosition, radius, fogNewAlpha, 1f);
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x003C01E8 File Offset: 0x003BE3E8
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration)
		{
			if (this.fogOfWarTexture == null)
			{
				return;
			}
			float num = (worldPosition.x - this._fogOfWarCenter.x) / this._fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (worldPosition.z - this._fogOfWarCenter.z) / this._fogOfWarSize.z + 0.5f;
			if (num2 >= 0f && num2 <= 1f)
			{
				int width = this.fogOfWarTexture.width;
				int height = this.fogOfWarTexture.height;
				int num3 = (int)(num * (float)width);
				int num4 = (int)(num2 * (float)height);
				int num5 = num4 * width + num3;
				byte b = (byte)(fogNewAlpha * 255f);
				Color32 color = this.fogOfWarColorBuffer[num5];
				if (b != color.a)
				{
					float num6 = radius / this._fogOfWarSize.z;
					int num7 = (int)((float)height * num6);
					for (int i = num4 - num7; i <= num4 + num7; i++)
					{
						if (i > 0 && i < height - 1)
						{
							for (int j = num3 - num7; j <= num3 + num7; j++)
							{
								if (j > 0 && j < width - 1)
								{
									int num8 = (int)Mathf.Sqrt((float)((num4 - i) * (num4 - i) + (num3 - j) * (num3 - j)));
									if (num8 <= num7)
									{
										num5 = i * width + j;
										Color32 color2 = this.fogOfWarColorBuffer[num5];
										byte b2 = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num8 / (float)num7);
										if (b2 < 255)
										{
											if (duration > 0f)
											{
												this.AddFowOfWarTransitionSlot(j, i, color2.a, b2, 0f, duration);
											}
											else
											{
												color2.a = b2;
												this.fogOfWarColorBuffer[num5] = color2;
												this.fogOfWarTexture.SetPixel(j, i, color2);
												this.requiresTextureUpload = true;
												if (this._fogOfWarRestoreDuration > 0f)
												{
													this.AddFowOfWarTransitionSlot(j, i, b2, byte.MaxValue, this._fogOfWarRestoreDelay, this._fogOfWarRestoreDuration);
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x003C0448 File Offset: 0x003BE648
		public void ResetFogOfWarAlpha(Vector3 worldPosition, float radius)
		{
			if (this.fogOfWarTexture == null)
			{
				return;
			}
			float num = (worldPosition.x - this._fogOfWarCenter.x) / this._fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (worldPosition.z - this._fogOfWarCenter.z) / this._fogOfWarSize.z + 0.5f;
			if (num2 >= 0f && num2 <= 1f)
			{
				int width = this.fogOfWarTexture.width;
				int height = this.fogOfWarTexture.height;
				int num3 = (int)(num * (float)width);
				int num4 = (int)(num2 * (float)height);
				int num5 = num4 * width + num3;
				float num6 = radius / this._fogOfWarSize.z;
				int num7 = (int)((float)height * num6);
				int num8 = num7 * num7;
				for (int i = num4 - num7; i <= num4 + num7; i++)
				{
					if (i > 0 && i < height - 1)
					{
						for (int j = num3 - num7; j <= num3 + num7; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num9 = (num4 - i) * (num4 - i) + (num3 - j) * (num3 - j);
								if (num9 <= num8)
								{
									num5 = i * width + j;
									Color32 color = this.fogOfWarColorBuffer[num5];
									color.a = byte.MaxValue;
									this.fogOfWarColorBuffer[num5] = color;
									this.fogOfWarTexture.SetPixel(j, i, color);
								}
							}
						}
					}
					this.requiresTextureUpload = true;
				}
				return;
			}
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x003C0600 File Offset: 0x003BE800
		public void ResetFogOfWar()
		{
			if (!(this.fogOfWarTexture == null) && this.isPartOfScene)
			{
				int height = this.fogOfWarTexture.height;
				int width = this.fogOfWarTexture.width;
				int num = height * width;
				if (this.fogOfWarColorBuffer == null || this.fogOfWarColorBuffer.Length != num)
				{
					this.fogOfWarColorBuffer = new Color32[num];
				}
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
				for (int i = 0; i < num; i++)
				{
					this.fogOfWarColorBuffer[i] = color;
				}
				this.fogOfWarTexture.SetPixels32(this.fogOfWarColorBuffer);
				this.fogOfWarTexture.Apply();
				this.lastTransitionPos = -1;
				this.fowTransitionIndices.Clear();
				this.isDirty = true;
				return;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06007E7D RID: 32381 RVA: 0x0002E025 File Offset: 0x0002C225
		// (set) Token: 0x06007E7E RID: 32382 RVA: 0x003C06D8 File Offset: 0x003BE8D8
		public Color32[] fogOfWarTextureData
		{
			get
			{
				return this.fogOfWarColorBuffer;
			}
			set
			{
				this.fogOfWarEnabled = true;
				this.fogOfWarColorBuffer = value;
				if (value == null || this.fogOfWarTexture == null)
				{
					return;
				}
				if (value.Length != this.fogOfWarTexture.width * this.fogOfWarTexture.height)
				{
					return;
				}
				this.fogOfWarTexture.SetPixels32(this.fogOfWarColorBuffer);
				this.fogOfWarTexture.Apply();
			}
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x003C0740 File Offset: 0x003BE940
		private void AddFowOfWarTransitionSlot(int x, int y, byte initialAlpha, byte targetAlpha, float delay, float duration)
		{
			int key = y * 64000 + x;
			int num;
			if (!this.fowTransitionIndices.TryGetValue(key, out num))
			{
				num = -1;
				for (int i = 0; i <= this.lastTransitionPos; i++)
				{
					if (!this.fowTransitionList[i].PIIMECMDJMH)
					{
						num = i;
						this.fowTransitionIndices[key] = num;
						break;
					}
				}
			}
			if (num >= 0 && this.fowTransitionList[num].PIIMECMDJMH && (this.fowTransitionList[num].DGKOIGOLHDM != x || this.fowTransitionList[num].DDLQKFDFMCJ != y))
			{
				num = -1;
			}
			if (num < 0)
			{
				num = ++this.lastTransitionPos;
				if (num >= 10000)
				{
					return;
				}
				this.fowTransitionIndices[key] = num;
			}
			this.fowTransitionList[num].DGKOIGOLHDM = x;
			this.fowTransitionList[num].DDLQKFDFMCJ = y;
			this.fowTransitionList[num].CPKNEQGKQPQ = duration;
			this.fowTransitionList[num].HOFHHQDFNCD = Time.time;
			this.fowTransitionList[num].MLOOPDKFCHD = delay;
			this.fowTransitionList[num].MDJBEIHNIID = initialAlpha;
			this.fowTransitionList[num].KBHFNKLJBBE = targetAlpha;
			this.fowTransitionList[num].PIIMECMDJMH = true;
		}

		// Token: 0x04001B84 RID: 7044
		public const string SKW_FOG_DISTANCE_ON = "FOG_DISTANCE_ON";

		// Token: 0x04001B85 RID: 7045
		public const string SKW_LIGHT_SCATTERING = "FOG_SCATTERING_ON";

		// Token: 0x04001B86 RID: 7046
		public const string SKW_FOG_AREA_BOX = "FOG_AREA_BOX";

		// Token: 0x04001B87 RID: 7047
		public const string SKW_FOG_AREA_SPHERE = "FOG_AREA_SPHERE";

		// Token: 0x04001B88 RID: 7048
		public const string SKW_FOG_VOID_BOX = "FOG_VOID_BOX";

		// Token: 0x04001B89 RID: 7049
		public const string SKW_FOG_VOID_SPHERE = "FOG_VOID_SPHERE";

		// Token: 0x04001B8A RID: 7050
		public const string SKW_FOG_HAZE_ON = "FOG_HAZE_ON";

		// Token: 0x04001B8B RID: 7051
		public const string SKW_FOG_OF_WAR_ON = "FOG_OF_WAR_ON";

		// Token: 0x04001B8C RID: 7052
		public const string SKW_FOG_BLUR = "FOG_BLUR_ON";

		// Token: 0x04001B8D RID: 7053
		public const string SKW_SUN_SHADOWS = "FOG_SUN_SHADOWS_ON";

		// Token: 0x04001B8E RID: 7054
		public const string SKW_FOG_USE_XY_PLANE = "FOG_USE_XY_PLANE";

		// Token: 0x04001B8F RID: 7055
		public const string SKW_FOG_COMPUTE_DEPTH = "FOG_COMPUTE_DEPTH";

		// Token: 0x04001B90 RID: 7056
		private const float TIME_BETWEEN_TEXTURE_UPDATES = 0.2f;

		// Token: 0x04001B91 RID: 7057
		private const string DEPTH_CAM_NAME = "VFMDepthCamera";

		// Token: 0x04001B92 RID: 7058
		private const string DEPTH_SUN_CAM_NAME = "VFMDepthSunCamera";

		// Token: 0x04001B93 RID: 7059
		private const string VFM_BUILD_FIRST_INSTALL = "VFMFirstInstall";

		// Token: 0x04001B94 RID: 7060
		private const string VFM_BUILD_HINT = "VFMBuildHint93b1";

		// Token: 0x04001B95 RID: 7061
		private static VolumetricFog _fog;

		// Token: 0x04001B96 RID: 7062
		[HideInInspector]
		public bool isDirty;

		// Token: 0x04001B97 RID: 7063
		[SerializeField]
		private QDIEOOCIEOL _preset = QDIEOOCIEOL.Mist;

		// Token: 0x04001B98 RID: 7064
		[SerializeField]
		private VolumetricFogProfile _profile;

		// Token: 0x04001B99 RID: 7065
		[SerializeField]
		private bool _useFogVolumes;

		// Token: 0x04001B9A RID: 7066
		[SerializeField]
		private bool _debugPass;

		// Token: 0x04001B9B RID: 7067
		[SerializeField]
		private NCJNIPIJBCP _transparencyBlendMode;

		// Token: 0x04001B9C RID: 7068
		[SerializeField]
		[Range(0f, 1f)]
		private float _transparencyBlendPower = 1f;

		// Token: 0x04001B9D RID: 7069
		[SerializeField]
		private LayerMask _transparencyLayerMask = -1;

		// Token: 0x04001B9E RID: 7070
		[SerializeField]
		private QQGJJNPLKME _lightingModel;

		// Token: 0x04001B9F RID: 7071
		[SerializeField]
		private bool _enableMultipleCameras;

		// Token: 0x04001BA0 RID: 7072
		[SerializeField]
		private bool _computeDepth;

		// Token: 0x04001BA1 RID: 7073
		[SerializeField]
		private FDGBELCFEDF _computeDepthScope;

		// Token: 0x04001BA2 RID: 7074
		[SerializeField]
		private float _transparencyCutOff = 0.1f;

		// Token: 0x04001BA3 RID: 7075
		[SerializeField]
		private bool _renderBeforeTransparent;

		// Token: 0x04001BA4 RID: 7076
		[SerializeField]
		private GameObject _sun;

		// Token: 0x04001BA5 RID: 7077
		[SerializeField]
		private bool _sunCopyColor = true;

		// Token: 0x04001BA6 RID: 7078
		[Range(0f, 1.25f)]
		[SerializeField]
		private float _density = 1f;

		// Token: 0x04001BA7 RID: 7079
		[SerializeField]
		[Range(0f, 1f)]
		private float _noiseStrength = 0.8f;

		// Token: 0x04001BA8 RID: 7080
		[SerializeField]
		[Range(1f, 2f)]
		private float _noiseFinalMultiplier = 1f;

		// Token: 0x04001BA9 RID: 7081
		[SerializeField]
		[Range(-0.3f, 2f)]
		private float _noiseSparse;

		// Token: 0x04001BAA RID: 7082
		[SerializeField]
		[Range(0f, 1000f)]
		private float _distance;

		// Token: 0x04001BAB RID: 7083
		[SerializeField]
		[Range(0f, 2000f)]
		private float _maxFogLength = 1000f;

		// Token: 0x04001BAC RID: 7084
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxFogLengthFallOff;

		// Token: 0x04001BAD RID: 7085
		[SerializeField]
		[Range(0f, 5f)]
		private float _distanceFallOff;

		// Token: 0x04001BAE RID: 7086
		[SerializeField]
		[Range(0.0001f, 500f)]
		private float _height = 4f;

		// Token: 0x04001BAF RID: 7087
		[SerializeField]
		private float _baselineHeight;

		// Token: 0x04001BB0 RID: 7088
		[SerializeField]
		private bool _baselineRelativeToCamera;

		// Token: 0x04001BB1 RID: 7089
		[SerializeField]
		[Range(0f, 1f)]
		private float _baselineRelativeToCameraDelay;

		// Token: 0x04001BB2 RID: 7090
		[SerializeField]
		[Range(0.2f, 25f)]
		private float _noiseScale = 1f;

		// Token: 0x04001BB3 RID: 7091
		[SerializeField]
		[Range(0f, 1.05f)]
		private float _alpha = 1f;

		// Token: 0x04001BB4 RID: 7092
		[SerializeField]
		private Color _color = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001BB5 RID: 7093
		[SerializeField]
		private Color _specularColor = new Color(1f, 1f, 0.8f, 1f);

		// Token: 0x04001BB6 RID: 7094
		[SerializeField]
		[Range(0f, 1f)]
		private float _specularThreshold = 0.6f;

		// Token: 0x04001BB7 RID: 7095
		[SerializeField]
		[Range(0f, 1f)]
		private float _specularIntensity = 0.2f;

		// Token: 0x04001BB8 RID: 7096
		[SerializeField]
		private Vector3 _lightDirection = new Vector3(1f, 0f, -1f);

		// Token: 0x04001BB9 RID: 7097
		[SerializeField]
		private float _lightIntensity = 0.2f;

		// Token: 0x04001BBA RID: 7098
		[SerializeField]
		private Color _lightColor = Color.white;

		// Token: 0x04001BBB RID: 7099
		[SerializeField]
		[Range(1f, 5f)]
		private int _updateTextureSpread = 1;

		// Token: 0x04001BBC RID: 7100
		[SerializeField]
		[Range(0f, 1f)]
		private float _speed = 0.01f;

		// Token: 0x04001BBD RID: 7101
		[SerializeField]
		private Vector3 _windDirection = new Vector3(-1f, 0f, 0f);

		// Token: 0x04001BBE RID: 7102
		[SerializeField]
		private bool _useRealTime;

		// Token: 0x04001BBF RID: 7103
		[SerializeField]
		private Color _skyColor = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001BC0 RID: 7104
		[Range(0f, 1000f)]
		[SerializeField]
		private float _skyHaze = 50f;

		// Token: 0x04001BC1 RID: 7105
		[SerializeField]
		[Range(0f, 1f)]
		private float _skySpeed = 0.3f;

		// Token: 0x04001BC2 RID: 7106
		[Range(0f, 1f)]
		[SerializeField]
		private float _skyNoiseStrength = 0.1f;

		// Token: 0x04001BC3 RID: 7107
		[SerializeField]
		[Range(0f, 1f)]
		private float _skyAlpha = 1f;

		// Token: 0x04001BC4 RID: 7108
		[SerializeField]
		[Range(0f, 0.999f)]
		private float _skyDepth = 0.999f;

		// Token: 0x04001BC5 RID: 7109
		[SerializeField]
		private GameObject _character;

		// Token: 0x04001BC6 RID: 7110
		[SerializeField]
		private OQCOLFQILDJ _fogVoidTopology;

		// Token: 0x04001BC7 RID: 7111
		[Range(0f, 10f)]
		[SerializeField]
		private float _fogVoidFallOff = 1f;

		// Token: 0x04001BC8 RID: 7112
		[SerializeField]
		private float _fogVoidRadius;

		// Token: 0x04001BC9 RID: 7113
		[SerializeField]
		private Vector3 _fogVoidPosition = Vector3.zero;

		// Token: 0x04001BCA RID: 7114
		[SerializeField]
		private float _fogVoidDepth;

		// Token: 0x04001BCB RID: 7115
		[SerializeField]
		private float _fogVoidHeight;

		// Token: 0x04001BCC RID: 7116
		[SerializeField]
		private bool _fogVoidInverted;

		// Token: 0x04001BCD RID: 7117
		[SerializeField]
		private bool _fogAreaShowGizmos = true;

		// Token: 0x04001BCE RID: 7118
		[SerializeField]
		private GameObject _fogAreaCenter;

		// Token: 0x04001BCF RID: 7119
		[SerializeField]
		[Range(0.001f, 10f)]
		private float _fogAreaFallOff = 1f;

		// Token: 0x04001BD0 RID: 7120
		[SerializeField]
		private JJMDJDFJKLO _fogAreaFollowMode;

		// Token: 0x04001BD1 RID: 7121
		[SerializeField]
		private FNHCOCLFCFE _fogAreaTopology = FNHCOCLFCFE.Sphere;

		// Token: 0x04001BD2 RID: 7122
		[SerializeField]
		private float _fogAreaRadius;

		// Token: 0x04001BD3 RID: 7123
		[SerializeField]
		private Vector3 _fogAreaPosition = Vector3.zero;

		// Token: 0x04001BD4 RID: 7124
		[SerializeField]
		private float _fogAreaDepth;

		// Token: 0x04001BD5 RID: 7125
		[SerializeField]
		private float _fogAreaHeight;

		// Token: 0x04001BD6 RID: 7126
		[SerializeField]
		private IHFHDGMNBJF _fogAreaSortingMode;

		// Token: 0x04001BD7 RID: 7127
		[SerializeField]
		private int _fogAreaRenderOrder = 1;

		// Token: 0x04001BD8 RID: 7128
		public const int MAX_POINT_LIGHTS = 6;

		// Token: 0x04001BD9 RID: 7129
		[SerializeField]
		private GameObject[] _pointLights = new GameObject[6];

		// Token: 0x04001BDA RID: 7130
		[SerializeField]
		private float[] _pointLightRanges = new float[6];

		// Token: 0x04001BDB RID: 7131
		[SerializeField]
		private float[] _pointLightIntensities = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x04001BDC RID: 7132
		[SerializeField]
		private float[] _pointLightIntensitiesMultiplier = new float[]
		{
			1f,
			1f,
			1f,
			1f,
			1f,
			1f
		};

		// Token: 0x04001BDD RID: 7133
		[SerializeField]
		private Vector3[] _pointLightPositions = new Vector3[6];

		// Token: 0x04001BDE RID: 7134
		[SerializeField]
		private Color[] _pointLightColors = new Color[]
		{
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f),
			new Color(1f, 1f, 0f, 1f)
		};

		// Token: 0x04001BDF RID: 7135
		[SerializeField]
		private bool _pointLightTrackingAuto;

		// Token: 0x04001BE0 RID: 7136
		[SerializeField]
		private Transform _pointLightTrackingPivot;

		// Token: 0x04001BE1 RID: 7137
		[SerializeField]
		[Range(0f, 6f)]
		private int _pointLightTrackingCount;

		// Token: 0x04001BE2 RID: 7138
		[SerializeField]
		[Range(0f, 5f)]
		private float _pointLightTrackingCheckInterval = 1f;

		// Token: 0x04001BE3 RID: 7139
		[SerializeField]
		private float _pointLightInscattering = 1f;

		// Token: 0x04001BE4 RID: 7140
		[SerializeField]
		private float _pointLightIntensity = 1f;

		// Token: 0x04001BE5 RID: 7141
		[SerializeField]
		[Range(1f, 8f)]
		private int _downsampling = 1;

		// Token: 0x04001BE6 RID: 7142
		[SerializeField]
		private bool _edgeImprove;

		// Token: 0x04001BE7 RID: 7143
		[SerializeField]
		[Range(1E-05f, 0.005f)]
		private float _edgeThreshold = 0.0005f;

		// Token: 0x04001BE8 RID: 7144
		[SerializeField]
		[Range(1f, 20f)]
		private float _stepping = 12f;

		// Token: 0x04001BE9 RID: 7145
		[Range(0f, 50f)]
		[SerializeField]
		private float _steppingNear = 1f;

		// Token: 0x04001BEA RID: 7146
		[SerializeField]
		private bool _dithering;

		// Token: 0x04001BEB RID: 7147
		[SerializeField]
		[Range(0.1f, 5f)]
		private float _ditherStrength = 0.75f;

		// Token: 0x04001BEC RID: 7148
		[SerializeField]
		[Range(0f, 2f)]
		private float _jitterStrength = 0.5f;

		// Token: 0x04001BED RID: 7149
		[SerializeField]
		private bool _lightScatteringEnabled;

		// Token: 0x04001BEE RID: 7150
		[SerializeField]
		[Range(0f, 1f)]
		private float _lightScatteringDiffusion = 0.7f;

		// Token: 0x04001BEF RID: 7151
		[SerializeField]
		[Range(0f, 1f)]
		private float _lightScatteringSpread = 0.686f;

		// Token: 0x04001BF0 RID: 7152
		[SerializeField]
		[Range(4f, 64f)]
		private int _lightScatteringSamples = 16;

		// Token: 0x04001BF1 RID: 7153
		[Range(0f, 50f)]
		[SerializeField]
		private float _lightScatteringWeight = 1.9f;

		// Token: 0x04001BF2 RID: 7154
		[Range(0f, 50f)]
		[SerializeField]
		private float _lightScatteringIllumination = 18f;

		// Token: 0x04001BF3 RID: 7155
		[Range(0.9f, 1.1f)]
		[SerializeField]
		private float _lightScatteringDecay = 0.986f;

		// Token: 0x04001BF4 RID: 7156
		[Range(0f, 0.2f)]
		[SerializeField]
		private float _lightScatteringExposure;

		// Token: 0x04001BF5 RID: 7157
		[SerializeField]
		[Range(0f, 1f)]
		private float _lightScatteringJittering = 0.5f;

		// Token: 0x04001BF6 RID: 7158
		[SerializeField]
		private bool _fogBlur;

		// Token: 0x04001BF7 RID: 7159
		[SerializeField]
		[Range(0f, 1f)]
		private float _fogBlurDepth = 0.05f;

		// Token: 0x04001BF8 RID: 7160
		[SerializeField]
		private bool _sunShadows;

		// Token: 0x04001BF9 RID: 7161
		[SerializeField]
		private LayerMask _sunShadowsLayerMask = -1;

		// Token: 0x04001BFA RID: 7162
		[Range(0f, 1f)]
		[SerializeField]
		private float _sunShadowsStrength = 0.5f;

		// Token: 0x04001BFB RID: 7163
		[SerializeField]
		private float _sunShadowsBias = 0.1f;

		// Token: 0x04001BFC RID: 7164
		[SerializeField]
		[Range(0f, 0.5f)]
		private float _sunShadowsJitterStrength = 0.1f;

		// Token: 0x04001BFD RID: 7165
		[Range(0f, 4f)]
		[SerializeField]
		private int _sunShadowsResolution = 2;

		// Token: 0x04001BFE RID: 7166
		[Range(50f, 2000f)]
		[SerializeField]
		private float _sunShadowsMaxDistance = 200f;

		// Token: 0x04001BFF RID: 7167
		[SerializeField]
		private KOBKEQBGOCM _sunShadowsBakeMode = KOBKEQBGOCM.Discrete;

		// Token: 0x04001C00 RID: 7168
		[SerializeField]
		private float _sunShadowsRefreshInterval;

		// Token: 0x04001C01 RID: 7169
		[Range(0f, 1f)]
		[SerializeField]
		private float _sunShadowsCancellation;

		// Token: 0x04001C02 RID: 7170
		[SerializeField]
		[Range(0f, 10f)]
		private float _turbulenceStrength;

		// Token: 0x04001C03 RID: 7171
		[SerializeField]
		private bool _useXYPlane;

		// Token: 0x04001C04 RID: 7172
		[SerializeField]
		private bool _useSinglePassStereoRenderingMatrix;

		// Token: 0x04001C05 RID: 7173
		[SerializeField]
		private MCBBQFMQNEE _spsrBehaviour;

		// Token: 0x04001C06 RID: 7174
		[NonSerialized]
		public float distanceToCameraMin;

		// Token: 0x04001C07 RID: 7175
		[NonSerialized]
		public float distanceToCameraMax;

		// Token: 0x04001C08 RID: 7176
		[NonSerialized]
		public float distanceToCamera;

		// Token: 0x04001C09 RID: 7177
		[NonSerialized]
		public float distanceToCameraYAxis;

		// Token: 0x04001C0A RID: 7178
		public VolumetricFog fogRenderer;

		// Token: 0x04001C0B RID: 7179
		private VolumetricFog[] allFogRenderers;

		// Token: 0x04001C0C RID: 7180
		private bool isPartOfScene;

		// Token: 0x04001C0D RID: 7181
		private float initialFogAlpha;

		// Token: 0x04001C0E RID: 7182
		private float targetFogAlpha;

		// Token: 0x04001C0F RID: 7183
		private float initialSkyHazeAlpha;

		// Token: 0x04001C10 RID: 7184
		private float targetSkyHazeAlpha;

		// Token: 0x04001C11 RID: 7185
		private bool transitionAlpha;

		// Token: 0x04001C12 RID: 7186
		private bool transitionColor;

		// Token: 0x04001C13 RID: 7187
		private bool transitionSpecularColor;

		// Token: 0x04001C14 RID: 7188
		private bool transitionLightColor;

		// Token: 0x04001C15 RID: 7189
		private bool transitionProfile;

		// Token: 0x04001C16 RID: 7190
		private bool targetColorActive;

		// Token: 0x04001C17 RID: 7191
		private bool targetSpecularColorActive;

		// Token: 0x04001C18 RID: 7192
		private bool targetLightColorActive;

		// Token: 0x04001C19 RID: 7193
		private Color initialFogColor;

		// Token: 0x04001C1A RID: 7194
		private Color targetFogColor;

		// Token: 0x04001C1B RID: 7195
		private Color initialFogSpecularColor;

		// Token: 0x04001C1C RID: 7196
		private Color targetFogSpecularColor;

		// Token: 0x04001C1D RID: 7197
		private Color initialLightColor;

		// Token: 0x04001C1E RID: 7198
		private Color targetLightColor;

		// Token: 0x04001C1F RID: 7199
		private float transitionDuration;

		// Token: 0x04001C20 RID: 7200
		private float transitionStartTime;

		// Token: 0x04001C21 RID: 7201
		private float currentFogAlpha;

		// Token: 0x04001C22 RID: 7202
		private float currentSkyHazeAlpha;

		// Token: 0x04001C23 RID: 7203
		private Color currentFogColor;

		// Token: 0x04001C24 RID: 7204
		private Color currentFogSpecularColor;

		// Token: 0x04001C25 RID: 7205
		private Color currentLightColor;

		// Token: 0x04001C26 RID: 7206
		private VolumetricFogProfile initialProfile;

		// Token: 0x04001C27 RID: 7207
		private VolumetricFogProfile targetProfile;

		// Token: 0x04001C28 RID: 7208
		private float oldBaselineRelativeCameraY;

		// Token: 0x04001C29 RID: 7209
		private float currentFogAltitude;

		// Token: 0x04001C2A RID: 7210
		private float skyHazeSpeedAcum;

		// Token: 0x04001C2B RID: 7211
		private bool _hasCamera;

		// Token: 0x04001C2C RID: 7212
		private bool _hasCameraChecked;

		// Token: 0x04001C2D RID: 7213
		private Camera mainCamera;

		// Token: 0x04001C2E RID: 7214
		private List<string> shaderKeywords;

		// Token: 0x04001C2F RID: 7215
		private Material blurMat;

		// Token: 0x04001C30 RID: 7216
		private RenderBuffer[] mrt;

		// Token: 0x04001C31 RID: 7217
		private int _renderingInstancesCount;

		// Token: 0x04001C32 RID: 7218
		private bool shouldUpdateMaterialProperties;

		// Token: 0x04001C33 RID: 7219
		[NonSerialized]
		public Material fogMat;

		// Token: 0x04001C34 RID: 7220
		private RenderTexture depthTexture;

		// Token: 0x04001C35 RID: 7221
		private RenderTexture depthSunTexture;

		// Token: 0x04001C36 RID: 7222
		private RenderTexture reducedDestination;

		// Token: 0x04001C37 RID: 7223
		private Light[] pointLightComponents = new Light[6];

		// Token: 0x04001C38 RID: 7224
		private Light[] lastFoundLights;

		// Token: 0x04001C39 RID: 7225
		private Light[] lightBuffer;

		// Token: 0x04001C3A RID: 7226
		private GameObject[] currentLights = new GameObject[6];

		// Token: 0x04001C3B RID: 7227
		private float trackPointAutoLastTime;

		// Token: 0x04001C3C RID: 7228
		private float trackPointCheckNewLightsLastTime;

		// Token: 0x04001C3D RID: 7229
		private Shader depthShader;

		// Token: 0x04001C3E RID: 7230
		private Shader depthShaderAndTrans;

		// Token: 0x04001C3F RID: 7231
		private GameObject depthCamObj;

		// Token: 0x04001C40 RID: 7232
		private Camera depthCam;

		// Token: 0x04001C41 RID: 7233
		private float lastTextureUpdate;

		// Token: 0x04001C42 RID: 7234
		private Vector3 windSpeedAcum;

		// Token: 0x04001C43 RID: 7235
		private Texture2D adjustedTexture;

		// Token: 0x04001C44 RID: 7236
		private Color[] noiseColors;

		// Token: 0x04001C45 RID: 7237
		private Color[] adjustedColors;

		// Token: 0x04001C46 RID: 7238
		private float sunLightIntensity = 1f;

		// Token: 0x04001C47 RID: 7239
		private bool needUpdateTexture;

		// Token: 0x04001C48 RID: 7240
		private bool hasChangeAdjustedColorsAlpha;

		// Token: 0x04001C49 RID: 7241
		private int updatingTextureSlice;

		// Token: 0x04001C4A RID: 7242
		private Color updatingTextureLightColor;

		// Token: 0x04001C4B RID: 7243
		private Color lastRenderSettingsAmbientLight;

		// Token: 0x04001C4C RID: 7244
		private float lastRenderSettingsAmbientIntensity;

		// Token: 0x04001C4D RID: 7245
		private int lastFrameAppliedChaos;

		// Token: 0x04001C4E RID: 7246
		private int lastFrameAppliedWind;

		// Token: 0x04001C4F RID: 7247
		private Light sunLight;

		// Token: 0x04001C50 RID: 7248
		private Vector2 oldSunPos;

		// Token: 0x04001C51 RID: 7249
		private float sunFade = 1f;

		// Token: 0x04001C52 RID: 7250
		private GameObject depthSunCamObj;

		// Token: 0x04001C53 RID: 7251
		private Camera depthSunCam;

		// Token: 0x04001C54 RID: 7252
		private Shader depthSunShader;

		// Token: 0x04001C55 RID: 7253
		[NonSerialized]
		public bool needUpdateDepthSunTexture;

		// Token: 0x04001C56 RID: 7254
		private float lastShadowUpdateFrame;

		// Token: 0x04001C57 RID: 7255
		private Texture2D adjustedChaosTexture;

		// Token: 0x04001C58 RID: 7256
		private Material chaosLerpMat;

		// Token: 0x04001C59 RID: 7257
		private float turbAcum;

		// Token: 0x04001C5A RID: 7258
		private float deltaTime;

		// Token: 0x04001C5B RID: 7259
		private float timeOfLastRender;

		// Token: 0x04001C5C RID: 7260
		private List<VolumetricFog> fogInstances = new List<VolumetricFog>();

		// Token: 0x04001C5D RID: 7261
		private List<VolumetricFog> fogRenderInstances = new List<VolumetricFog>();

		// Token: 0x04001C5E RID: 7262
		private MeshRenderer mr;

		// Token: 0x04001C5F RID: 7263
		private float lastTimeSortInstances;

		// Token: 0x04001C60 RID: 7264
		private const float FOG_INSTANCES_SORT_INTERVAL = 2f;

		// Token: 0x04001C61 RID: 7265
		private Vector3 lastCamPos;

		// Token: 0x04001C62 RID: 7266
		private static string[] pointLightPositionUniformNames = new string[]
		{
			"_FogPointLightPosition0",
			"_FogPointLightPosition1",
			"_FogPointLightPosition2",
			"_FogPointLightPosition3",
			"_FogPointLightPosition4",
			"_FogPointLightPosition5"
		};

		// Token: 0x04001C63 RID: 7267
		private static string[] pointLightColorUniformNames = new string[]
		{
			"_FogPointLightColor0",
			"_FogPointLightColor1",
			"_FogPointLightColor2",
			"_FogPointLightColor3",
			"_FogPointLightColor4",
			"_FogPointLightColor5"
		};

		// Token: 0x04001C64 RID: 7268
		private const int MAX_SIMULTANEOUS_TRANSITIONS = 10000;

		// Token: 0x04001C65 RID: 7269
		[SerializeField]
		private bool _fogOfWarEnabled;

		// Token: 0x04001C66 RID: 7270
		[SerializeField]
		private Vector3 _fogOfWarCenter;

		// Token: 0x04001C67 RID: 7271
		[SerializeField]
		private Vector3 _fogOfWarSize = new Vector3(1024f, 0f, 1024f);

		// Token: 0x04001C68 RID: 7272
		[SerializeField]
		[Range(32f, 2048f)]
		private int _fogOfWarTextureSize = 256;

		// Token: 0x04001C69 RID: 7273
		[Range(0f, 100f)]
		[SerializeField]
		private float _fogOfWarRestoreDelay;

		// Token: 0x04001C6A RID: 7274
		[Range(0f, 25f)]
		[SerializeField]
		private float _fogOfWarRestoreDuration = 2f;

		// Token: 0x04001C6B RID: 7275
		private Texture2D fogOfWarTexture;

		// Token: 0x04001C6C RID: 7276
		private Color32[] fogOfWarColorBuffer;

		// Token: 0x04001C6D RID: 7277
		private VolumetricFog.BBIQDMFGCNQ[] fowTransitionList;

		// Token: 0x04001C6E RID: 7278
		private int lastTransitionPos;

		// Token: 0x04001C6F RID: 7279
		private Dictionary<int, int> fowTransitionIndices;

		// Token: 0x04001C70 RID: 7280
		private bool requiresTextureUpload;

		// Token: 0x020003AD RID: 941
		private struct BBIQDMFGCNQ
		{
			// Token: 0x04001C72 RID: 7282
			public bool PIIMECMDJMH;

			// Token: 0x04001C73 RID: 7283
			public int DGKOIGOLHDM;

			// Token: 0x04001C74 RID: 7284
			public int DDLQKFDFMCJ;

			// Token: 0x04001C75 RID: 7285
			public float HOFHHQDFNCD;

			// Token: 0x04001C76 RID: 7286
			public float MLOOPDKFCHD;

			// Token: 0x04001C77 RID: 7287
			public float CPKNEQGKQPQ;

			// Token: 0x04001C78 RID: 7288
			public byte MDJBEIHNIID;

			// Token: 0x04001C79 RID: 7289
			public byte KBHFNKLJBBE;
		}
	}
}
