using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000318 RID: 792
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x04001664 RID: 5732
		public BuiltinDebugViewsModel debugViews = new BuiltinDebugViewsModel();

		// Token: 0x04001665 RID: 5733
		public FogModel fog = new FogModel();

		// Token: 0x04001666 RID: 5734
		public AntialiasingModel antialiasing = new AntialiasingModel();

		// Token: 0x04001667 RID: 5735
		public AmbientOcclusionModel ambientOcclusion = new AmbientOcclusionModel();

		// Token: 0x04001668 RID: 5736
		public ScreenSpaceReflectionModel screenSpaceReflection = new ScreenSpaceReflectionModel();

		// Token: 0x04001669 RID: 5737
		public DepthOfFieldModel depthOfField = new DepthOfFieldModel();

		// Token: 0x0400166A RID: 5738
		public MotionBlurModel motionBlur = new MotionBlurModel();

		// Token: 0x0400166B RID: 5739
		public EyeAdaptationModel eyeAdaptation = new EyeAdaptationModel();

		// Token: 0x0400166C RID: 5740
		public BloomModel bloom = new BloomModel();

		// Token: 0x0400166D RID: 5741
		public ColorGradingModel colorGrading = new ColorGradingModel();

		// Token: 0x0400166E RID: 5742
		public UserLutModel userLut = new UserLutModel();

		// Token: 0x0400166F RID: 5743
		public ChromaticAberrationModel chromaticAberration = new ChromaticAberrationModel();

		// Token: 0x04001670 RID: 5744
		public GrainModel grain = new GrainModel();

		// Token: 0x04001671 RID: 5745
		public VignetteModel vignette = new VignetteModel();

		// Token: 0x04001672 RID: 5746
		public DitheringModel dithering = new DitheringModel();
	}
}
