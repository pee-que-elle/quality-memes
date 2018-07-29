using System;
using UnityEngine.PostProcessing;

// Token: 0x02000313 RID: 787
public abstract class EOJDINKLMIF<T> : JBGLEFPOLGP where T : PostProcessingModel
{
	// Token: 0x170003AA RID: 938
	// (get) Token: 0x060069FC RID: 27132 RVA: 0x00027E9B File Offset: 0x0002609B
	// (set) Token: 0x060069FD RID: 27133 RVA: 0x00027EA3 File Offset: 0x000260A3
	public T FIFNHCKNDQE { get; internal set; }

	// Token: 0x060069FE RID: 27134 RVA: 0x00027EAC File Offset: 0x000260AC
	public virtual void CPCICJDOELQ(NNLOOFHPMNG NHJNPMQEHDL, T FBPHJCDMFCE)
	{
		this.BEHMQBIFCOJ = NHJNPMQEHDL;
		this.FIFNHCKNDQE = FBPHJCDMFCE;
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x00027EBC File Offset: 0x000260BC
	public override PostProcessingModel CEKEFONEMIK()
	{
		return this.FIFNHCKNDQE;
	}
}
