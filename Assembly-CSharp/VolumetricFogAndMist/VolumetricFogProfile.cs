using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020003B0 RID: 944
	[CreateAssetMenu(fileName = "VolumetricFogProfile", menuName = "Volumetric Fog Profile", order = 100)]
	public class VolumetricFogProfile : ScriptableObject
	{
		// Token: 0x06007E8E RID: 32398 RVA: 0x003C0D10 File Offset: 0x003BEF10
		public void Load(VolumetricFog fog)
		{
			fog.density = this.density;
			fog.noiseStrength = this.noiseStrength;
			fog.height = this.height;
			fog.baselineHeight = this.baselineHeight;
			fog.distance = this.distance;
			fog.distanceFallOff = this.distanceFallOff;
			fog.maxFogLength = this.maxFogLength;
			fog.maxFogLengthFallOff = this.maxFogLengthFallOff;
			fog.baselineRelativeToCamera = this.baselineRelativeToCamera;
			fog.baselineRelativeToCameraDelay = this.baselineRelativeToCameraDelay;
			fog.noiseScale = this.noiseScale;
			fog.noiseSparse = this.noiseSparse;
			fog.noiseFinalMultiplier = this.noiseFinalMultiplier;
			fog.useXYPlane = this.useXYPlane;
			fog.lightingModel = this.lightingModel;
			fog.sunCopyColor = this.sunCopyColor;
			fog.alpha = this.alpha;
			fog.color = this.color;
			fog.specularColor = this.specularColor;
			fog.specularThreshold = this.specularThreshold;
			fog.specularIntensity = this.specularIntensity;
			fog.lightDirection = this.lightDirection;
			fog.lightIntensity = this.lightIntensity;
			fog.lightColor = this.lightColor;
			fog.speed = this.speed;
			fog.windDirection = this.windDirection;
			fog.turbulenceStrength = this.turbulenceStrength;
			fog.useRealTime = this.useRealTime;
			fog.skyColor = this.skyColor;
			fog.skyHaze = this.skyHaze;
			fog.skySpeed = this.skySpeed;
			fog.skyNoiseStrength = this.skyNoiseStrength;
			fog.skyAlpha = this.skyAlpha;
			fog.stepping = this.stepping;
			fog.steppingNear = this.steppingNear;
			fog.dithering = this.dithering;
			fog.ditherStrength = this.ditherStrength;
			if (this.downsamplingOverride)
			{
				fog.downsampling = this.downsampling;
				fog.edgeImprove = this.edgeImprove;
				fog.edgeThreshold = this.edgeThreshold;
			}
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x003C0F08 File Offset: 0x003BF108
		public void Save(VolumetricFog fog)
		{
			this.density = fog.density;
			this.noiseStrength = fog.noiseStrength;
			this.height = fog.height;
			this.baselineHeight = fog.baselineHeight;
			this.distance = fog.distance;
			this.distanceFallOff = fog.distanceFallOff;
			this.maxFogLength = fog.maxFogLength;
			this.maxFogLengthFallOff = fog.maxFogLengthFallOff;
			this.baselineRelativeToCamera = fog.baselineRelativeToCamera;
			this.baselineRelativeToCameraDelay = fog.baselineRelativeToCameraDelay;
			this.noiseScale = fog.noiseScale;
			this.noiseSparse = fog.noiseSparse;
			this.noiseFinalMultiplier = fog.noiseFinalMultiplier;
			this.useXYPlane = fog.useXYPlane;
			this.sunCopyColor = fog.sunCopyColor;
			this.alpha = fog.alpha;
			this.color = fog.color;
			this.specularColor = fog.specularColor;
			this.specularThreshold = fog.specularThreshold;
			this.specularIntensity = fog.specularIntensity;
			this.lightDirection = fog.lightDirection;
			this.lightIntensity = fog.lightIntensity;
			this.lightColor = fog.lightColor;
			this.lightingModel = fog.lightingModel;
			this.speed = fog.speed;
			this.windDirection = fog.windDirection;
			this.turbulenceStrength = fog.turbulenceStrength;
			this.useRealTime = fog.useRealTime;
			this.skyColor = fog.skyColor;
			this.skyHaze = fog.skyHaze;
			this.skySpeed = fog.skySpeed;
			this.skyNoiseStrength = fog.skyNoiseStrength;
			this.skyAlpha = fog.skyAlpha;
			this.stepping = fog.stepping;
			this.steppingNear = fog.steppingNear;
			this.dithering = fog.dithering;
			this.ditherStrength = fog.ditherStrength;
			this.downsampling = fog.downsampling;
			this.edgeImprove = fog.edgeImprove;
			this.edgeThreshold = fog.edgeThreshold;
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x003C10F8 File Offset: 0x003BF2F8
		public static void Lerp(VolumetricFogProfile profile1, VolumetricFogProfile profile2, float t, VolumetricFog fog)
		{
			if (t < 0f)
			{
				t = 0f;
			}
			else if (t > 1f)
			{
				t = 1f;
			}
			fog.density = profile1.density * (1f - t) + profile2.density * t;
			fog.noiseStrength = profile1.noiseStrength * (1f - t) + profile2.noiseStrength * t;
			fog.height = profile1.height * (1f - t) + profile2.height * t;
			fog.baselineHeight = profile1.baselineHeight * (1f - t) + profile2.baselineHeight * t;
			fog.distance = profile1.baselineHeight * (1f - t) + profile2.distance * t;
			fog.distanceFallOff = profile1.distanceFallOff * (1f - t) + profile2.distanceFallOff * t;
			fog.maxFogLength = profile1.maxFogLength * (1f - t) + profile2.maxFogLength * t;
			fog.maxFogLengthFallOff = profile1.maxFogLengthFallOff * (1f - t) + profile2.maxFogLengthFallOff * t;
			fog.baselineRelativeToCamera = ((t >= 0.5f) ? profile2.baselineRelativeToCamera : profile1.baselineRelativeToCamera);
			fog.baselineRelativeToCameraDelay = profile1.baselineRelativeToCameraDelay * (1f - t) + profile2.baselineRelativeToCameraDelay * t;
			fog.noiseScale = profile1.noiseScale * (1f - t) + profile2.noiseScale * t;
			fog.noiseSparse = profile1.noiseSparse * (1f - t) + profile2.noiseSparse * t;
			fog.noiseFinalMultiplier = profile1.noiseFinalMultiplier * (1f - t) + profile2.noiseFinalMultiplier * t;
			fog.sunCopyColor = ((t >= 0.5f) ? profile2.sunCopyColor : profile1.sunCopyColor);
			fog.alpha = profile1.alpha * (1f - t) + profile2.alpha * t;
			fog.color = profile1.color * (1f - t) + profile2.color * t;
			fog.specularColor = profile1.specularColor * (1f - t) + profile2.color * t;
			fog.specularThreshold = profile1.specularThreshold * (1f - t) + profile2.specularThreshold * t;
			fog.specularIntensity = profile1.specularIntensity * (1f - t) + profile2.specularIntensity * t;
			fog.lightDirection = profile1.lightDirection * (1f - t) + profile2.lightDirection * t;
			fog.lightIntensity = profile1.lightIntensity * (1f - t) + profile2.lightIntensity * t;
			fog.lightColor = profile1.lightColor * (1f - t) + profile2.lightColor * t;
			fog.speed = profile1.speed * (1f - t) + profile2.speed * t;
			fog.windDirection = profile1.windDirection * (1f - t) + profile2.windDirection * t;
			fog.turbulenceStrength = profile1.turbulenceStrength * (1f - t) + profile2.turbulenceStrength * t;
			fog.skyColor = profile1.skyColor * (1f - t) + profile2.skyColor * t;
			fog.skyHaze = profile1.skyHaze * (1f - t) + profile2.skyHaze * t;
			fog.skySpeed = profile1.skySpeed * (1f - t) + profile2.skySpeed * t;
			fog.skyNoiseStrength = profile1.skyNoiseStrength * (1f - t) + profile2.skyNoiseStrength * t;
			fog.skyAlpha = profile1.skyAlpha * (1f - t) + profile2.skyAlpha * t;
			fog.stepping = profile1.stepping * (1f - t) + profile2.stepping * t;
			fog.steppingNear = profile1.steppingNear * (1f - t) + profile2.steppingNear * t;
			fog.dithering = ((t >= 0.5f) ? profile2.dithering : profile1.dithering);
			fog.ditherStrength = profile1.ditherStrength * (1f - t) + profile2.ditherStrength * t;
		}

		// Token: 0x04001C7E RID: 7294
		public QQGJJNPLKME lightingModel;

		// Token: 0x04001C7F RID: 7295
		public bool sunCopyColor = true;

		// Token: 0x04001C80 RID: 7296
		[Range(0f, 1.25f)]
		public float density = 1f;

		// Token: 0x04001C81 RID: 7297
		[Range(0f, 1f)]
		public float noiseStrength = 0.8f;

		// Token: 0x04001C82 RID: 7298
		[Range(0f, 500f)]
		public float height = 4f;

		// Token: 0x04001C83 RID: 7299
		public float baselineHeight;

		// Token: 0x04001C84 RID: 7300
		[Range(0f, 1000f)]
		public float distance;

		// Token: 0x04001C85 RID: 7301
		[Range(0f, 5f)]
		public float distanceFallOff;

		// Token: 0x04001C86 RID: 7302
		[Range(0f, 2000f)]
		public float maxFogLength = 1000f;

		// Token: 0x04001C87 RID: 7303
		[Range(0f, 1f)]
		public float maxFogLengthFallOff;

		// Token: 0x04001C88 RID: 7304
		public bool baselineRelativeToCamera;

		// Token: 0x04001C89 RID: 7305
		[Range(0f, 1f)]
		public float baselineRelativeToCameraDelay;

		// Token: 0x04001C8A RID: 7306
		[Range(0.2f, 10f)]
		public float noiseScale = 1f;

		// Token: 0x04001C8B RID: 7307
		[Range(-0.3f, 2f)]
		public float noiseSparse;

		// Token: 0x04001C8C RID: 7308
		[Range(1f, 2f)]
		public float noiseFinalMultiplier = 1f;

		// Token: 0x04001C8D RID: 7309
		[Range(0f, 1.05f)]
		public float alpha = 1f;

		// Token: 0x04001C8E RID: 7310
		public Color color = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001C8F RID: 7311
		public Color specularColor = new Color(1f, 1f, 0.8f, 1f);

		// Token: 0x04001C90 RID: 7312
		[Range(0f, 1f)]
		public float specularThreshold = 0.6f;

		// Token: 0x04001C91 RID: 7313
		[Range(0f, 1f)]
		public float specularIntensity = 0.2f;

		// Token: 0x04001C92 RID: 7314
		public Vector3 lightDirection = new Vector3(1f, 0f, -1f);

		// Token: 0x04001C93 RID: 7315
		[Range(-1f, 3f)]
		public float lightIntensity = 0.2f;

		// Token: 0x04001C94 RID: 7316
		public Color lightColor = Color.white;

		// Token: 0x04001C95 RID: 7317
		[Range(0f, 1f)]
		public float speed = 0.01f;

		// Token: 0x04001C96 RID: 7318
		public bool useRealTime;

		// Token: 0x04001C97 RID: 7319
		public Vector3 windDirection = new Vector3(-1f, 0f, 0f);

		// Token: 0x04001C98 RID: 7320
		[Range(0f, 10f)]
		public float turbulenceStrength;

		// Token: 0x04001C99 RID: 7321
		public bool useXYPlane;

		// Token: 0x04001C9A RID: 7322
		public Color skyColor = new Color(0.89f, 0.89f, 0.89f, 1f);

		// Token: 0x04001C9B RID: 7323
		[Range(0f, 1000f)]
		public float skyHaze = 50f;

		// Token: 0x04001C9C RID: 7324
		[Range(0f, 1f)]
		public float skySpeed = 0.3f;

		// Token: 0x04001C9D RID: 7325
		[Range(0f, 1f)]
		public float skyNoiseStrength = 0.1f;

		// Token: 0x04001C9E RID: 7326
		[Range(0f, 1f)]
		public float skyAlpha = 1f;

		// Token: 0x04001C9F RID: 7327
		public float stepping = 12f;

		// Token: 0x04001CA0 RID: 7328
		public float steppingNear = 1f;

		// Token: 0x04001CA1 RID: 7329
		public bool dithering;

		// Token: 0x04001CA2 RID: 7330
		public float ditherStrength = 0.75f;

		// Token: 0x04001CA3 RID: 7331
		public bool downsamplingOverride;

		// Token: 0x04001CA4 RID: 7332
		[Range(1f, 8f)]
		public int downsampling = 1;

		// Token: 0x04001CA5 RID: 7333
		public bool edgeImprove;

		// Token: 0x04001CA6 RID: 7334
		[Range(1E-05f, 0.005f)]
		public float edgeThreshold = 0.0005f;
	}
}
