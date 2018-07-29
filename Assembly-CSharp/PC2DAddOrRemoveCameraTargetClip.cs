using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000392 RID: 914
[Serializable]
public class PC2DAddOrRemoveCameraTargetClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x06007AF1 RID: 31473 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void CMBIMJNECIM(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007AF2 RID: 31474 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip CQHKDEDOPLO()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AF3 RID: 31475 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip MCDPGOMJCGH()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AF4 RID: 31476 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip MNQCPPKDBLN()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AF5 RID: 31477 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip KHIEMIIJNOG()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AF6 RID: 31478 RVA: 0x003A52D0 File Offset: 0x003A34D0
	public virtual Playable GLGOHFMKQIM(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 1);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.OCCEQIMQPOQ(this.JHFGIPGEDLE());
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007AF7 RID: 31479 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void KBFMEOJCDJQ(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	// (set) Token: 0x06007B11 RID: 31505 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public TimelineClip ClipReference { get; set; }

	// Token: 0x06007AF9 RID: 31481 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public ClipCaps EQGDQMLMGDK()
	{
		return ClipCaps.None;
	}

	// Token: 0x06007AFA RID: 31482 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip JHFGIPGEDLE()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AFB RID: 31483 RVA: 0x003A5320 File Offset: 0x003A3520
	public virtual Playable LPOJNJKPQOB(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 0);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.OMNJGJKCGHB(this.ClipReference);
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007AFC RID: 31484 RVA: 0x003A5370 File Offset: 0x003A3570
	public override Playable CreatePlayable(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 0);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.ClipReference = this.ClipReference;
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007AFD RID: 31485 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip BLQEHPMLHOF()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007AFE RID: 31486 RVA: 0x0000B03A File Offset: 0x0000923A
	public ClipCaps JHPEHJIOPLB()
	{
		return ClipCaps.Looping;
	}

	// Token: 0x06007AFF RID: 31487 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public ClipCaps EBFOGJCDMCG()
	{
		return ClipCaps.None;
	}

	// Token: 0x06007B00 RID: 31488 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void BIKEOOFBCHN(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B01 RID: 31489 RVA: 0x003A53C0 File Offset: 0x003A35C0
	public virtual Playable KMLJEFDNKDH(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 1);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.OCCEQIMQPOQ(this.EENMDCQQDHM());
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007B02 RID: 31490 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip HMLOJBLOMLI()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B03 RID: 31491 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public ClipCaps GPIFIECPHGD()
	{
		return ClipCaps.None;
	}

	// Token: 0x06007B04 RID: 31492 RVA: 0x003A5410 File Offset: 0x003A3610
	public virtual Playable FBEJCNDMQML(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 0);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.QMJJLCJFFCI(this.IKEHGIMFNCP());
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007B05 RID: 31493 RVA: 0x0000B03A File Offset: 0x0000923A
	public ClipCaps QPIDKENPBPC()
	{
		return ClipCaps.Looping;
	}

	// Token: 0x06007B06 RID: 31494 RVA: 0x0000B03A File Offset: 0x0000923A
	public ClipCaps KHCPJPPPCDK()
	{
		return ClipCaps.Looping;
	}

	// Token: 0x06007B07 RID: 31495 RVA: 0x003A5460 File Offset: 0x003A3660
	public virtual Playable ONJNQQEJOFB(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 0);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.LHCJHQGPQGQ(this.MCDPGOMJCGH());
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x06007B08 RID: 31496 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void LBGIQBKCEDG(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B09 RID: 31497 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public ClipCaps NQPKOHPHJQJ()
	{
		return ClipCaps.None;
	}

	// Token: 0x06007B0A RID: 31498 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip QKEQKDDQDOI()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B0B RID: 31499 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void FHHLBIGMQOM(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B0C RID: 31500 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void FLBGIIMIPGF(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B0D RID: 31501 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void NHEHHJBJBKG(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B0E RID: 31502 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip JKNEGGNKBBG()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B0F RID: 31503 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void KJLEOQQBGIK(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B10 RID: 31504 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip QFDEMDKFCGJ()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B12 RID: 31506 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void FFCLPLQLGQH(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B13 RID: 31507 RVA: 0x003A54B0 File Offset: 0x003A36B0
	public virtual Playable DKMHPMOFQGB(PlayableGraph HFJPOOPLNLQ, GameObject BLDHKNGOJKE)
	{
		ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour> playable = ScriptPlayable<PC2DAddOrRemoveCameraTargetBehaviour>.Create(HFJPOOPLNLQ, this.template, 1);
		PC2DAddOrRemoveCameraTargetBehaviour behaviour = playable.GetBehaviour();
		behaviour.QFNFCBDQCHQ(this.MCDPGOMJCGH());
		behaviour.cameraTarget = this.cameraTarget.Resolve(HFJPOOPLNLQ.GetResolver());
		return playable;
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06007B14 RID: 31508 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public ClipCaps clipCaps
	{
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06007B15 RID: 31509 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip ONLFPMBDGGP()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B16 RID: 31510 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip EENMDCQQDHM()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B18 RID: 31512 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void DMHEIHNEDNM(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B19 RID: 31513 RVA: 0x0002BAD9 File Offset: 0x00029CD9
	public void DQKQLJHQBCD(TimelineClip BGBMIEJJQKC)
	{
		this.<ClipReference>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06007B1A RID: 31514 RVA: 0x0000B03A File Offset: 0x0000923A
	public ClipCaps KKMLOGMGJHJ()
	{
		return ClipCaps.Looping;
	}

	// Token: 0x06007B1B RID: 31515 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip LDMQJOJPNBG()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x06007B1C RID: 31516 RVA: 0x0002BAE2 File Offset: 0x00029CE2
	public TimelineClip IKEHGIMFNCP()
	{
		return this.<ClipReference>k__BackingField;
	}

	// Token: 0x04001AA3 RID: 6819
	public PC2DAddOrRemoveCameraTargetBehaviour template = new PC2DAddOrRemoveCameraTargetBehaviour();

	// Token: 0x04001AA4 RID: 6820
	public ExposedReference<Transform> cameraTarget;
}
