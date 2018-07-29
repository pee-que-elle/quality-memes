using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000317 RID: 791
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x00028094 File Offset: 0x00026294
		// (set) Token: 0x06006A4A RID: 27210 RVA: 0x0002809C File Offset: 0x0002629C
		public bool enabled
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
				if (value)
				{
					this.GPNDOOOMBCH();
				}
			}
		}

		// Token: 0x06006A4B RID: 27211
		public abstract void BJJGDIOLJMI();

		// Token: 0x06006A4C RID: 27212 RVA: 0x00002300 File Offset: 0x00000500
		public virtual void GPNDOOOMBCH()
		{
		}

		// Token: 0x04001663 RID: 5731
		[SerializeField]
		[PDFBHMMPDPF("enabled")]
		private bool m_Enabled;
	}
}
