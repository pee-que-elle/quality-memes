using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020003A0 RID: 928
	[AddComponentMenu("")]
	public class FogVolume : MonoBehaviour
	{
		// Token: 0x06007D41 RID: 32065 RVA: 0x0002C86A File Offset: 0x0002AA6A
		private void Start()
		{
			if (this.targetFog == null)
			{
				this.targetFog = VolumetricFog.instance;
			}
			if (this.targetFog != null)
			{
				this.targetFog.useFogVolumes = true;
			}
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x003BA708 File Offset: 0x003B8908
		private void OnTriggerEnter(Collider other)
		{
			if (!this.cameraInside && !(this.targetFog == null))
			{
				if (other == this.targetCollider || other.gameObject.transform.GetComponentInChildren<Camera>() == this.targetFog.fogCamera)
				{
					this.cameraInside = true;
					if (this.enableProfileTransition && this.targetProfile != null)
					{
						this.targetFog.SetTargetProfile(this.targetProfile, this.transitionDuration);
					}
					if (this.enableAlphaTransition)
					{
						this.targetFog.SetTargetAlpha(this.targetFogAlpha, this.targetSkyHazeAlpha, this.transitionDuration);
					}
					if (this.enableFogColorTransition)
					{
						this.targetFog.SetTargetColor(this.targetFogColor, this.transitionDuration);
					}
					if (this.enableFogSpecularColorTransition)
					{
						this.targetFog.SetTargetSpecularColor(this.targetFogSpecularColor, this.transitionDuration);
					}
					if (this.enableLightColorTransition)
					{
						this.targetFog.SetTargetLightColor(this.targetLightColor, this.transitionDuration);
					}
					if (this.debugMode)
					{
						Debug.Log("Fog Volume entered by " + other.name);
					}
				}
				return;
			}
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x003BA838 File Offset: 0x003B8A38
		private void OnTriggerExit(Collider other)
		{
			if (this.cameraInside && !(this.targetFog == null))
			{
				if (other == this.targetCollider || other.gameObject.transform.GetComponentInChildren<Camera>() == this.targetFog.fogCamera)
				{
					this.cameraInside = false;
					if (this.enableProfileTransition && this.targetProfile != null)
					{
						this.targetFog.ClearTargetProfile(this.transitionDuration);
					}
					if (this.enableAlphaTransition)
					{
						this.targetFog.ClearTargetAlpha(this.transitionDuration);
					}
					if (this.enableFogColorTransition)
					{
						this.targetFog.ClearTargetColor(this.transitionDuration);
					}
					if (this.enableFogSpecularColorTransition)
					{
						this.targetFog.ClearTargetSpecularColor(this.transitionDuration);
					}
					if (this.enableLightColorTransition)
					{
						this.targetFog.ClearTargetLightColor(this.transitionDuration);
					}
					if (this.debugMode)
					{
						Debug.Log("Fog Volume exited by " + other.name);
					}
				}
				return;
			}
		}

		// Token: 0x04001B43 RID: 6979
		private const float GRAY = 0.8901961f;

		// Token: 0x04001B44 RID: 6980
		[Tooltip("Enables transition to a given profile.")]
		public bool enableProfileTransition;

		// Token: 0x04001B45 RID: 6981
		[Tooltip("Assign the transition profile.")]
		public VolumetricFogProfile targetProfile;

		// Token: 0x04001B46 RID: 6982
		[Tooltip("Enables alpha transition.")]
		public bool enableAlphaTransition;

		// Token: 0x04001B47 RID: 6983
		[Tooltip("Target alpha for fog when camera enters this fog volume")]
		[Range(0f, 1f)]
		public float targetFogAlpha = 0.5f;

		// Token: 0x04001B48 RID: 6984
		[Tooltip("Target alpha for sky haze when camera enters this fog volume")]
		[Range(0f, 1f)]
		public float targetSkyHazeAlpha = 0.5f;

		// Token: 0x04001B49 RID: 6985
		[Tooltip("Enables fog color transition.")]
		public bool enableFogColorTransition;

		// Token: 0x04001B4A RID: 6986
		[Tooltip("Target fog color 1 when gamera enters this fog folume")]
		public Color targetFogColor = new Color(0.8901961f, 0.8901961f, 0.8901961f);

		// Token: 0x04001B4B RID: 6987
		[Tooltip("Enables fog specular color transition.")]
		public bool enableFogSpecularColorTransition;

		// Token: 0x04001B4C RID: 6988
		[Tooltip("Target fog color 2 when gamera enters this fog folume")]
		public Color targetFogSpecularColor = new Color(0.8901961f, 0.8901961f, 0.8901961f);

		// Token: 0x04001B4D RID: 6989
		[Tooltip("Enables light color transition.")]
		public bool enableLightColorTransition;

		// Token: 0x04001B4E RID: 6990
		[Tooltip("Target light color when gamera enters this fog folume")]
		public Color targetLightColor = Color.white;

		// Token: 0x04001B4F RID: 6991
		[Tooltip("Set this to zero for changing fog alpha immediately upon enter/exit fog volume.")]
		public float transitionDuration = 3f;

		// Token: 0x04001B50 RID: 6992
		[Tooltip("Set collider that will trigger this fog volume. If not set, this fog volume will react to any collider which has the main camera. If you use a third person controller, assign the character collider here.")]
		public Collider targetCollider;

		// Token: 0x04001B51 RID: 6993
		[Tooltip("When enabled, a console message will be printed whenever this fog volume is entered or exited.")]
		public bool debugMode;

		// Token: 0x04001B52 RID: 6994
		[Tooltip("Assign target Volumetric Fog component that will be affected by this volume.")]
		public VolumetricFog targetFog;

		// Token: 0x04001B53 RID: 6995
		private bool cameraInside;
	}
}
