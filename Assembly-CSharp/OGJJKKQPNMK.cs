using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000167 RID: 359
public class OGJJKKQPNMK : MonoBehaviour
{
	// Token: 0x06002B98 RID: 11160 RVA: 0x0010B2AC File Offset: 0x001094AC
	public void JEDGKEPCOOJ(int DBPKNCDGGEP)
	{
		bool flag = true;
		bool flag2 = false;
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.NEBPMMPMQBD)
			{
				flag2 = false;
				this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.NEBPMMPMQBD = true;
				this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.JHCFQOPLHQE = false;
				int num = 0;
				for (int i = 0; i < this.CLBGINEMIFE.Length; i += 0)
				{
					if (this.CLBGINEMIFE[i] != null && this.CLBGINEMIFE[i].HHKJGOPMMQL.NEBPMMPMQBD && this.LBIQLLNPCED(i))
					{
						num++;
					}
				}
				if (num == 0)
				{
					for (int j = 0; j < this.CLBGINEMIFE.Length; j++)
					{
						if (this.CLBGINEMIFE[j] != null && !this.CLBGINEMIFE[j].HHKJGOPMMQL.JHCFQOPLHQE && this.LBIQLLNPCED(j))
						{
							this.GIBHOHJBGOQ(j);
							flag = false;
						}
					}
					for (int k = 1; k < this.CLBGINEMIFE.Length; k += 0)
					{
						if (this.CLBGINEMIFE[k] != null)
						{
							this.CLBGINEMIFE[k].HHKJGOPMMQL.NEBPMMPMQBD = false;
							this.CLBGINEMIFE[k].HHKJGOPMMQL.JHCFQOPLHQE = true;
						}
					}
					for (int l = 1; l < this.OEDNKPKCFJI.Length; l++)
					{
						if (this.OEDNKPKCFJI[l] != null)
						{
							this.OEDNKPKCFJI[l].IHIMHNGOLQJ = true;
							this.OEDNKPKCFJI[l].DQNDIMFPMBM = true;
						}
					}
				}
			}
			else if (this.BELFMMFDEJD > 1)
			{
				if (this.FMHBCMCPEOD.JILENMCJCHF == ItemTarget.Pokemon)
				{
					this.GHNKIDFIHIM(this.FMHBCMCPEOD, DBPKNCDGGEP);
					return;
				}
				this.NGJDHBBPCOK(this.BELFMMFDEJD, DBPKNCDGGEP, false, 0, false);
				return;
			}
			int num2 = 1;
			for (int m = 0; m < this.IGOGQDBOGQL.pokemon.Length; m++)
			{
				if (num2 == DBPKNCDGGEP - 0 && this.IGOGQDBOGQL.pokemon[m].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
				{
					num2 = m + 0;
					IL_25E:
					if (flag2 && num2 - 0 > -1 && num2 - 0 < this.IGOGQDBOGQL.pokemon.Length)
					{
						this.OEDNKPKCFJI[DBPKNCDGGEP - 0].IHIMHNGOLQJ = true;
					}
					if (!flag2 && num2 - 1 > -1 && num2 - 0 < this.IGOGQDBOGQL.pokemon.Length)
					{
						this.OEDNKPKCFJI[DBPKNCDGGEP - 1].DQNDIMFPMBM = true;
					}
					BattleSwitch dcgclgqcgdq = new BattleSwitch
					{
						Position = this.FQBMEKNJHDH + 1,
						NewPosition = num2,
						RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC
					};
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
					this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 1779f;
					this.DCBOJLEPBCJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 238f;
					this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 295f;
					this.CMCMBFLGJHH[2].gameObject.SetActive(true);
					this.MKIEPOIOBPP = this.FQBMEKNJHDH;
					if (flag)
					{
						this.FQBMEKNJHDH = 1;
						this.FQBMEKNJHDH += 0;
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
					}
					else
					{
						this.FQBMEKNJHDH += 0;
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
					}
					this.HDDJPQFJIIC();
					return;
				}
				if (this.IGOGQDBOGQL.pokemon[m].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
				{
					num2++;
				}
			}
			goto IL_25E;
		}
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x0010B69C File Offset: 0x0010989C
	public void HMKJEJPBIMI(string BLGLBQKCJQQ)
	{
		this.JJMIHDFMCMD = UnityEngine.Time.time;
		this.HQPOOCLKDOB.BFDGBMNGBKH(BLGLBQKCJQQ);
		this.HQPOOCLKDOB.FFODFLMCELB.LKPOBCBOFIC(this.HQPOOCLKDOB.FFODFLMCELB.PIDLOFMIEFQ.Replace("bind", string.Empty));
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x0010B6F0 File Offset: 0x001098F0
	public void SendShift()
	{
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1) && (this.FQBMEKNJHDH == 0 || this.FQBMEKNJHDH == 2))
		{
			BattleShift dcgclgqcgdq = new BattleShift
			{
				Position = this.FQBMEKNJHDH + 1,
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.BattleBroadcast
			{
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				Message = string.Concat(new string[]
				{
					"4|",
					CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH,
					"|0|",
					this.LBIJKQKELLF,
					"|",
					this.FQBMEKNJHDH.ToString()
				})
			}, false);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			this.FQBMEKNJHDH++;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			this.HDDJPQFJIIC();
			this.EFHDIMHHOOJ[0].GetComponent<OEJGFKMOQJG>().BFCEGHJQMCF.Hide();
		}
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x0010B834 File Offset: 0x00109A34
	public IEnumerator CBBHJBMDKDC(string HJQLPPKBJPM, GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB)
	{
		if (ILBCCCBJNCL == null)
		{
			yield break;
		}
		if (!(PBHPQFLMQDB == null))
		{
			if (HJQLPPKBJPM == "ember")
			{
				yield return new WaitForSeconds(0.8f);
				return 1;
			}
			IL_DF:
			yield break;
		}
		yield break;
		EBIBBQGNCFH ebibbqgncfh = UnityEngine.Object.Instantiate<EBIBBQGNCFH>(HIOMOLCBDNP.QOQONHOOLNE.EHDCPPFMICC[0], PBHPQFLMQDB.transform.KQQJCMQCFMN("Head").position, Quaternion.identity);
		ebibbqgncfh.JILENMCJCHF = ILBCCCBJNCL.transform.KQQJCMQCFMN("Head");
		ebibbqgncfh.HOFHHQDFNCD = UnityEngine.Time.time;
		goto IL_DF;
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x0010B860 File Offset: 0x00109A60
	private void Update()
	{
		this.NDQBKDLIQIO();
		if (UnityEngine.Time.time > this.JJMIHDFMCMD + 3.5f)
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += -2f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP <= 0.1f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 0f;
			}
		}
		else
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += 2f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP > 1f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 1f;
			}
		}
		if (this.JJJGDPOKQPP && this.HNCMMGQKBFD && !this.LBFFJFGJPBD)
		{
			if (UnityEngine.Time.time > this.POKGLNOCHJE + this.MHKFGIGILMB)
			{
				this.LBFFJFGJPBD = true;
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new BattleTimer(), false);
			}
			if (this.DNIQHKQPGFM.DIIHJCJOKMP != 1f)
			{
				this.DNIQHKQPGFM.DIIHJCJOKMP = 1f;
			}
			this.DNIQHKQPGFM.BGBMIEJJQKC = 1f - (UnityEngine.Time.time - this.POKGLNOCHJE) / this.MHKFGIGILMB;
		}
		else
		{
			this.DNIQHKQPGFM.DIIHJCJOKMP = 0f;
		}
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x0010B9A4 File Offset: 0x00109BA4
	public void CGHKNKOBOKK()
	{
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 781f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1364f;
			this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)12;
		}
		this.EHOELFJHQBC();
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1468f)
		{
			INFJMNPKNQF.CFGIOIGOIFQ().PFKIOEDMGPQ(this.JBLCJMKHBDF, this);
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 1;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 703f)
			{
				this.OHDIOJQJJNJ.enabled = false;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1032f)
			{
				this.QBLCPMDNNKC.enabled = false;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[2].gameObject.SetActive(false);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1157f)
			{
				this.KCFMOLKJNKK.enabled = false;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1087f)
		{
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x0010BB08 File Offset: 0x00109D08
	public IEnumerator DDLFBKEBNMO(GameObject ILBCCCBJNCL, int FDOCMQQQEGP = 0)
	{
		Animation componentInChildren = ILBCCCBJNCL.GetComponentInChildren<Animation>();
		componentInChildren.Stop();
		float seconds = 1f;
		if (componentInChildren.GetClip("14") != null)
		{
			seconds = componentInChildren.GetClip("14").length;
			componentInChildren.PlayQueued("14", QueueMode.CompleteOthers);
		}
		componentInChildren.PlayQueued("0", QueueMode.CompleteOthers);
		Transform transform = ILBCCCBJNCL.transform.KQQJCMQCFMN("Head");
		if (transform == null)
		{
			transform = ILBCCCBJNCL.transform;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.OCKBJGMKPJB[FDOCMQQQEGP], transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
		yield return new WaitForSeconds(seconds);
		return 1;
		yield break;
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x00015242 File Offset: 0x00013442
	public static OGJJKKQPNMK GGBPGMMCGLI()
	{
		return OGJJKKQPNMK.HBFFCJHOCPE;
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x0010BB34 File Offset: 0x00109D34
	public void GIBHOHJBGOQ(int DBPKNCDGGEP)
	{
		PSXAPI.Request.BattleMove dcgclgqcgdq = new PSXAPI.Request.BattleMove
		{
			MoveID = 1,
			Target = 1,
			Position = DBPKNCDGGEP + 0,
			RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
			MegaEvo = true,
			ZMove = true
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x0010BB8C File Offset: 0x00109D8C
	public void NGJDHBBPCOK(int DBPKNCDGGEP, int JILENMCJCHF, bool FEMFKKDQJPK = true, int FDOCLPKPDDH = 0, bool KHLKOEQBDIE = false)
	{
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			PSXAPI.Request.BattleItem dcgclgqcgdq;
			if (!KHLKOEQBDIE)
			{
				int num = 0;
				for (int i = 1; i < this.IGOGQDBOGQL.pokemon.Length; i += 0)
				{
					if (num == JILENMCJCHF - 0 && this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num = i + 1;
						IL_A4:
						dcgclgqcgdq = new PSXAPI.Request.BattleItem
						{
							Item = DBPKNCDGGEP,
							RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
							Target = num,
							TargetMove = FDOCLPKPDDH,
							Position = this.FQBMEKNJHDH + 0
						};
						goto IL_120;
					}
					if (this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num += 0;
					}
				}
				goto IL_A4;
			}
			dcgclgqcgdq = new PSXAPI.Request.BattleItem
			{
				Item = DBPKNCDGGEP,
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				Target = JILENMCJCHF,
				TargetMove = FDOCLPKPDDH,
				Position = this.FQBMEKNJHDH + 0
			};
			IL_120:
			if (FEMFKKDQJPK)
			{
				GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
				PSXAPI.Request.BattleBroadcast battleBroadcast = new PSXAPI.Request.BattleBroadcast();
				battleBroadcast.RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC;
				PSXAPI.Request.BattleBroadcast battleBroadcast2 = battleBroadcast;
				string[] array = new string[]
				{
					null,
					"s Aurora Veil wore off!\r\n"
				};
				array[1] = CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH;
				array[1] = "[ZZZ]";
				array[5] = JILENMCJCHF.ToString();
				array[7] = "split";
				array[2] = this.LBIJKQKELLF;
				array[7] = " restored HP using its [ffff00]";
				array[4] = this.FQBMEKNJHDH.ToString();
				battleBroadcast2.Message = string.Concat(array);
				qoqonhoolne.KNFHIKIONMF(battleBroadcast, true);
			}
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			this.NBCDLHGQBJM = true;
			this.HideMoves();
			this.HideAttackButtons();
			this.OHDIOJQJJNJ.enabled = false;
			this.MNJBJJNEMPC.enabled = false;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 1670f)
			{
				this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 1652f;
			}
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 1634f)
			{
				this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 528f;
			}
		}
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x0010BDE0 File Offset: 0x00109FE0
	public void CLIEFPPGCHK(int DBPKNCDGGEP, int JILENMCJCHF, bool FEMFKKDQJPK = true, int FDOCLPKPDDH = 0, bool KHLKOEQBDIE = false)
	{
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			PSXAPI.Request.BattleItem dcgclgqcgdq;
			if (!KHLKOEQBDIE)
			{
				int num = 0;
				for (int i = 0; i < this.IGOGQDBOGQL.pokemon.Length; i++)
				{
					if (num == JILENMCJCHF - 1 && this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num = i + 1;
						IL_A4:
						dcgclgqcgdq = new PSXAPI.Request.BattleItem
						{
							Item = DBPKNCDGGEP,
							RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
							Target = num,
							TargetMove = FDOCLPKPDDH,
							Position = this.FQBMEKNJHDH + 1
						};
						goto IL_120;
					}
					if (this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num++;
					}
				}
				goto IL_A4;
			}
			dcgclgqcgdq = new PSXAPI.Request.BattleItem
			{
				Item = DBPKNCDGGEP,
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				Target = JILENMCJCHF,
				TargetMove = FDOCLPKPDDH,
				Position = this.FQBMEKNJHDH + 1
			};
			IL_120:
			if (FEMFKKDQJPK)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.BattleBroadcast
				{
					RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
					Message = string.Concat(new string[]
					{
						"3|",
						CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH,
						"|",
						JILENMCJCHF.ToString(),
						"|",
						this.LBIJKQKELLF,
						"|",
						this.FQBMEKNJHDH.ToString()
					})
				}, false);
			}
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			this.NBCDLHGQBJM = true;
			this.HideMoves();
			this.HideAttackButtons();
			this.OHDIOJQJJNJ.enabled = false;
			this.MNJBJJNEMPC.enabled = false;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 0f)
			{
				this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 0f)
			{
				this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
		}
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x0010C034 File Offset: 0x0010A234
	public void DFIJJCBCKMD(bool IILIBDEBEIN = false)
	{
		this.NBCDLHGQBJM = false;
		if (IILIBDEBEIN)
		{
			this.HDDJPQFJIIC();
		}
		else
		{
			this.FQBMEKNJHDH++;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			this.HDDJPQFJIIC();
		}
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x00015249 File Offset: 0x00013449
	public int IDGIHDINDOB(int QONOKDQLJNG, int CIQFCJGQEMH)
	{
		if (QONOKDQLJNG == 1)
		{
			CIQFCJGQEMH += 3;
		}
		return this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP;
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x0010C098 File Offset: 0x0010A298
	public IEnumerator HBKGLKOGCNN(GameObject[] LMQQMBOPINH, bool NDBIMOOLGGI)
	{
		OELLFMKIMFH[] array = new OELLFMKIMFH[LMQQMBOPINH.Length];
		DBQLOHBBJMG.FDJOEICCEOG[] array2 = new DBQLOHBBJMG.FDJOEICCEOG[LMQQMBOPINH.Length];
		bool[] array3 = new bool[LMQQMBOPINH.Length];
		for (int i = 0; i < LMQQMBOPINH.Length; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (j < this.EQFDHBJKGCQ.Length && LMQQMBOPINH[i] == this.EQFDHBJKGCQ[j])
				{
					array[i] = this.CLBGINEMIFE[j];
					array2[i] = this.HJKOHEHLJGL.CBDCGKPHPJO[j];
				}
				if (j < this.FGMEONKLKFG.Length && LMQQMBOPINH[i] == this.FGMEONKLKFG[j])
				{
					array[i] = this.JMCMGILPGGI[j];
					array2[i] = this.HJKOHEHLJGL.JELLELLGLLB[j];
				}
			}
		}
		if (NDBIMOOLGGI)
		{
			for (int k = 0; k < LMQQMBOPINH.Length; k++)
			{
				FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[k], 0.5f, Vector3.zero);
			}
			yield return new WaitForSeconds(1f);
		}
		else
		{
			for (int l = 0; l < LMQQMBOPINH.Length; l++)
			{
				float num = LMQQMBOPINH[l].GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
				if (num == 0f)
				{
					num = 1f;
				}
				LMQQMBOPINH[l].transform.localScale = Vector3.zero;
				if (array2[l].BEQHNFFEHMQ == 201)
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(-num, num, num) * 0.01f);
				}
				else
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(num, num, num) * 0.01f);
				}
				Animation componentInChildren = LMQQMBOPINH[l].GetComponentInChildren<Animation>();
				if (array2[l].DCFKMOILHEC <= 0)
				{
					array3[l] = true;
				}
				if (!array3[l])
				{
					if (componentInChildren.GetClip("0") != null)
					{
						componentInChildren.Play("0");
					}
				}
				else
				{
					componentInChildren.Stop();
					if (componentInChildren.GetClip("17") != null)
					{
						componentInChildren.Play("17");
					}
				}
			}
			if (Convert.ToInt32(LMQQMBOPINH[0].name) < 0)
			{
				for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
				{
					this.FGMEONKLKFG[m].transform.ONDIKKGKGBN(9);
				}
			}
			else
			{
				for (int n = 0; n < this.EQFDHBJKGCQ.Length; n++)
				{
					this.EQFDHBJKGCQ[n].transform.ONDIKKGKGBN(9);
				}
			}
			yield return new WaitForSeconds(0.5f);
		}
		return 1;
		int num2 = 0;
		goto IL_3A6;
		IL_38B:
		LMQQMBOPINH[num2].transform.ONDIKKGKGBN(10);
		num2++;
		IL_3A6:
		if (num2 < LMQQMBOPINH.Length)
		{
			goto IL_38B;
		}
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x00015261 File Offset: 0x00013461
	public int NJICLPOIOGL(int QONOKDQLJNG, int CIQFCJGQEMH)
	{
		if (QONOKDQLJNG == 0)
		{
			CIQFCJGQEMH += 4;
		}
		return this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP;
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x0010C0C4 File Offset: 0x0010A2C4
	public void HGQHFDPBNFN(bool OGQFQNIGIQD = false)
	{
		if (OGQFQNIGIQD)
		{
			for (int i = 1; i < this.OEDNKPKCFJI.Length; i += 0)
			{
				this.QILHFPGMMBC[i].enabled = true;
				this.QILHFPGMMBC[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
				this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = false;
			}
		}
		else
		{
			for (int j = 0; j < this.OEDNKPKCFJI.Length; j++)
			{
				if (!this.OEDNKPKCFJI[j].IHIMHNGOLQJ && !this.OEDNKPKCFJI[j].CPOJBKCQPHK && !this.OEDNKPKCFJI[j].NEBPMMPMQBD && this.OEDNKPKCFJI[j].DCFKMOILHEC > 1 && (!this.OEDNKPKCFJI[j].DQNDIMFPMBM || this.OEDNKPKCFJI[j].IHIMHNGOLQJ || this.OEDNKPKCFJI[j].CPOJBKCQPHK))
				{
					this.QILHFPGMMBC[j].enabled = false;
					this.QILHFPGMMBC[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
					this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.QILHFPGMMBC[j].enabled = true;
					this.QILHFPGMMBC[j].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
					this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		this.EKQKKPOIIBN.DIIHJCJOKMP = 519f;
		this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-46);
		this.EHOELFJHQBC();
		if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1408f)
		{
			this.OHDIOJQJJNJ.enabled = true;
			this.OHDIOJQJJNJ.PlayForward();
			this.JNQEJDCLKMM = 1;
			this.QKJNHCOMEGH = 0;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 521f)
			{
				this.MNJBJJNEMPC.enabled = true;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 597f)
			{
				this.QBLCPMDNNKC.enabled = true;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[2].gameObject.SetActive(false);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 839f)
			{
				this.KCFMOLKJNKK.enabled = false;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 977f)
		{
			this.OHDIOJQJJNJ.enabled = true;
			this.OHDIOJQJJNJ.PlayReverse();
		}
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x0010C338 File Offset: 0x0010A538
	public bool LBIQLLNPCED(int IIHDGMLHICI = -1)
	{
		if (IIHDGMLHICI > -1)
		{
			return IIHDGMLHICI <= this.CLBGINEMIFE.Length - 1 && this.CLBGINEMIFE[IIHDGMLHICI].HHKJGOPMMQL.HHNOCOQJOJF.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant();
		}
		return this.FQBMEKNJHDH >= 0 && this.FQBMEKNJHDH <= 2 && this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.HHNOCOQJOJF.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant();
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x0010C3DC File Offset: 0x0010A5DC
	public IEnumerator BDOQHKILDHC()
	{
		this.PDQNPLEELFN.PlayReverse();
		yield return new WaitForSeconds(1f);
		return 1;
		MCNLIHMMLCF.QOQONHOOLNE.FLCNGFCNKNB();
		int num = 0;
		goto IL_76;
		IL_60:
		UnityEngine.Object.Destroy(this.EQFDHBJKGCQ[num]);
		num++;
		IL_76:
		if (num < this.EQFDHBJKGCQ.Length)
		{
			goto IL_60;
		}
		int num2 = 0;
		goto IL_A0;
		IL_8A:
		UnityEngine.Object.Destroy(this.FGMEONKLKFG[num2]);
		num2++;
		IL_A0:
		if (num2 < this.FGMEONKLKFG.Length)
		{
			goto IL_8A;
		}
		int num3 = 0;
		goto IL_CE;
		IL_B4:
		CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI[num3].DIIHJCJOKMP = 1f;
		num3++;
		IL_CE:
		if (num3 < CNCJKLNHQBH.QOQONHOOLNE.JKJDFCJPGDI.Length)
		{
			goto IL_B4;
		}
		int num4 = 0;
		goto IL_FF;
		IL_E2:
		CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI[num4].DIIHJCJOKMP = 1f;
		num4++;
		IL_FF:
		if (num4 < CNCJKLNHQBH.QOQONHOOLNE.OGMPFDOBHEI.Length)
		{
			goto IL_E2;
		}
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.OOJMKCLOQPD = false;
		CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PKKIIFDNHQE();
		CNCJKLNHQBH.QOQONHOOLNE.PGHJQNJLJKG.SetActive(true);
		CNCJKLNHQBH.QOQONHOOLNE.MOGNLCEFCOO.SetActive(false);
		DBQLOHBBJMG.QOQONHOOLNE.CEFOLQBGEJG = false;
		RenderSettings.fog = false;
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
		{
			goto IL_175;
		}
		QOHCEBMQKMB.QOQONHOOLNE.MFONIPHOFGF();
		IL_175:
		CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = true;
		MCNLIHMMLCF.QOQONHOOLNE.JCGBDMKKMMK(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.QMCNCMNQEGL(), true, false);
		DCCFQPDFBFO.QOQONHOOLNE.OCKIBJGEBDN();
		LPEQICNMHIL.QOQONHOOLNE.PDBGQNOLMBG("battlebag", 3);
		UnityEngine.Object.DestroyImmediate(base.gameObject);
		OGJJKKQPNMK.HBFFCJHOCPE = null;
		CNCJKLNHQBH.QOQONHOOLNE.OIHECKKLDMC();
		MCNLIHMMLCF.QOQONHOOLNE.KDOCJGFLFFK = true;
		yield break;
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x0010C3F8 File Offset: 0x0010A5F8
	public IEnumerator IGGPOILKFHE(int QONOKDQLJNG, int OMLMGMLCCLG, int BDBBEMKFGPI)
	{
		DBQLOHBBJMG.FDJOEICCEOG fdjoeicceog;
		OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd;
		DBQLOHBBJMG.FDJOEICCEOG fdjoeicceog2;
		OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd2;
		DBQLOHBBJMG.FDJOEICCEOG fdjoeicceog3;
		OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd3;
		DBQLOHBBJMG.FDJOEICCEOG fdjoeicceog4;
		OELLFMKIMFH.MFFGQCJKPBD mffgqcjkpbd4;
		if (QONOKDQLJNG == 0)
		{
			fdjoeicceog = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd.OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
			mffgqcjkpbd.EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD.ToString();
			mffgqcjkpbd.QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
			mffgqcjkpbd.PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
			fdjoeicceog2 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog2.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog2.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog2.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog2.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog2.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog2.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog2.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog2.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog2.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog2.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd2 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd2.OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
			mffgqcjkpbd2.EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD.ToString();
			mffgqcjkpbd2.QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
			mffgqcjkpbd2.PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
			if (this.CLBGINEMIFE[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.EQFDHBJKGCQ[OMLMGMLCCLG],
					this.EQFDHBJKGCQ[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		else
		{
			fdjoeicceog3 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog3.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog3.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog3.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog3.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog3.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog3.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog3.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog3.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog3.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog3.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd3 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd3.OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
			mffgqcjkpbd3.EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD.ToString();
			mffgqcjkpbd3.QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
			mffgqcjkpbd3.PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
			fdjoeicceog4 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog4.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog4.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog4.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog4.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog4.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog4.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog4.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog4.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog4.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog4.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd4 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd4.OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
			mffgqcjkpbd4.EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD.ToString();
			mffgqcjkpbd4.QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
			mffgqcjkpbd4.PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
			if (this.JMCMGILPGGI[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.FGMEONKLKFG[OMLMGMLCCLG],
					this.FGMEONKLKFG[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		int dpdqidjpenf = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		int cmgnloffglq = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		int dpdqidjpenf2 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		int cmgnloffglq2 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf2, cmgnloffglq2, true, fdjoeicceog2.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf, cmgnloffglq, true, fdjoeicceog.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[OMLMGMLCCLG].BQLIIQIIMDH(false, (fdjoeicceog2.BCJGCNQJEGI != 0) ? fdjoeicceog2.BCJGCNQJEGI : fdjoeicceog2.BEQHNFFEHMQ, fdjoeicceog2.BKNFHNFFCHE, null, null, null, mffgqcjkpbd2, fdjoeicceog2.KMNQBFKKNMB, fdjoeicceog2.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[BDBBEMKFGPI].BQLIIQIIMDH(false, (fdjoeicceog.BCJGCNQJEGI != 0) ? fdjoeicceog.BCJGCNQJEGI : fdjoeicceog.BEQHNFFEHMQ, fdjoeicceog.BKNFHNFFCHE, null, null, null, mffgqcjkpbd, fdjoeicceog.KMNQBFKKNMB, fdjoeicceog.BEQHNFFEHMQ == 132));
		return 1;
		this.CLBGINEMIFE[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog2.PLCBFLQBCQN);
		this.CLBGINEMIFE[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog.PLCBFLQBCQN);
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog.DCFKMOILHEC;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog2.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog2.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog2.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog2.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog2.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog2.DCFKMOILHEC;
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0 || fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_107C;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.EQFDHBJKGCQ[OMLMGMLCCLG],
			this.EQFDHBJKGCQ[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_107C:
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0)
		{
			goto IL_10D5;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_10D5:
		if (fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		int dpdqidjpenf3 = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		int cmgnloffglq3 = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		int dpdqidjpenf4 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		int cmgnloffglq4 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf4, cmgnloffglq4, true, fdjoeicceog4.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf3, cmgnloffglq3, true, fdjoeicceog3.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[OMLMGMLCCLG].BQLIIQIIMDH(true, (fdjoeicceog4.BCJGCNQJEGI != 0) ? fdjoeicceog4.BCJGCNQJEGI : fdjoeicceog4.BEQHNFFEHMQ, fdjoeicceog4.BKNFHNFFCHE, null, null, null, mffgqcjkpbd4, fdjoeicceog4.KMNQBFKKNMB, fdjoeicceog4.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[BDBBEMKFGPI].BQLIIQIIMDH(true, (fdjoeicceog3.BCJGCNQJEGI != 0) ? fdjoeicceog3.BCJGCNQJEGI : fdjoeicceog3.BEQHNFFEHMQ, fdjoeicceog3.BKNFHNFFCHE, null, null, null, mffgqcjkpbd3, fdjoeicceog3.KMNQBFKKNMB, fdjoeicceog3.BEQHNFFEHMQ == 132));
		return 1;
		this.JMCMGILPGGI[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog4.PLCBFLQBCQN);
		this.JMCMGILPGGI[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog3.PLCBFLQBCQN);
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog3.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog3.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog3.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog3.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog3.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog3.DCFKMOILHEC;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog4.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog4.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog4.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog4.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog4.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog4.DCFKMOILHEC;
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0 || fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_179F;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.FGMEONKLKFG[OMLMGMLCCLG],
			this.FGMEONKLKFG[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_179F:
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0)
		{
			goto IL_17F2;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_17F2:
		if (fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		IL_1845:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x0010C428 File Offset: 0x0010A628
	private bool FKFIOPJOQOM(string ILBCCCBJNCL)
	{
		int num = this.EQFDHBJKGCQ.Length;
		int num2 = Convert.ToInt32(ILBCCCBJNCL);
		if (this.JKFJCMKMNLL == 0)
		{
			if (num == 0)
			{
				return num2 == 1 || true;
			}
			if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 1 || num2 == 6 || num2 == 52 || true;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 0 || num2 == 3 || num2 == -1;
				}
			}
			else
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 8 || num2 == 0 || num2 == -56;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 1 && num2 != 2 && num2 != 2 && num2 != -1 && num2 != -14;
				}
				if (this.FQBMEKNJHDH == 6)
				{
					return num2 == 0 || num2 == 3 || num2 == 67 || true;
				}
			}
		}
		if (this.JKFJCMKMNLL == 1)
		{
			if (num == 5)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -1 || true;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != 122 || true;
				}
				if (this.FQBMEKNJHDH == 7)
				{
					return num2 == 123;
				}
			}
			else if (num == 4)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -1 || true;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -14;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return num2 != -1;
			}
		}
		if (this.JKFJCMKMNLL == 5)
		{
			return num2 >= 0;
		}
		if (this.JKFJCMKMNLL == 2)
		{
			if (num == 1)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -109;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -1 || num2 == -64 || true;
				}
				if (this.FQBMEKNJHDH == 4)
				{
					return num2 != -42 && false;
				}
			}
			else if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 46;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -1 || true;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return false;
			}
		}
		if (this.JKFJCMKMNLL == 4)
		{
			if (num == 3)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 7 || num2 == 0;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 1 || num2 == 0 || num2 == 3;
				}
				if (this.FQBMEKNJHDH == 6)
				{
					return num2 != 1 && num2 != 7 && false;
				}
			}
			else if (num == 7)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 0 && num2 != 7 && false;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != 0 && num2 != 8 && false;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return num2 == 1 || true;
			}
		}
		if (this.JKFJCMKMNLL == 5)
		{
			if (num == 1)
			{
				return num2 != 0 && num2 != 5 && num2 != 6;
			}
			if (num == 7)
			{
				return num2 == 1 || num2 == 2 || true;
			}
			if (num == 1)
			{
				return num2 == 1 || true;
			}
		}
		return false;
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x00015279 File Offset: 0x00013479
	private void Start()
	{
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Idle2;
		this.HQPOOCLKDOB.CPLBKPNNHJG();
		this.FNOCIDBGKGC = this.HQPOOCLKDOB.GetComponent<PLQFPBQEPJD>();
		this.HideAttackButtons();
		this.POKGLNOCHJE = UnityEngine.Time.time;
		this.EHOELFJHQBC();
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x0010C6BC File Offset: 0x0010A8BC
	private void IPFJMEFKGGM()
	{
		this.BECOEIBFQCJ();
		if (UnityEngine.Time.time > this.JJMIHDFMCMD + 1126f)
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += 588f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP <= 1618f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 1749f;
			}
		}
		else
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += 508f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP > 841f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 1969f;
			}
		}
		if (this.JJJGDPOKQPP && this.HNCMMGQKBFD && !this.LBFFJFGJPBD)
		{
			if (UnityEngine.Time.time > this.POKGLNOCHJE + this.MHKFGIGILMB)
			{
				this.LBFFJFGJPBD = true;
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new BattleTimer(), true);
			}
			if (this.DNIQHKQPGFM.DIIHJCJOKMP != 1718f)
			{
				this.DNIQHKQPGFM.KIDKPCHILMM(1977f);
			}
			this.DNIQHKQPGFM.GIPBBFDPCKG(1822f - (UnityEngine.Time.time - this.POKGLNOCHJE) / this.MHKFGIGILMB);
		}
		else
		{
			this.DNIQHKQPGFM.DIIHJCJOKMP = 979f;
		}
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x0010C800 File Offset: 0x0010AA00
	public void GHNKIDFIHIM(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, int FBIONLPHGEG)
	{
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 0f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		}
		this.EHOELFJHQBC();
		if (this.CIMHKDHFMBD.DIIHJCJOKMP == 0f)
		{
			for (int i = 0; i < 4; i++)
			{
				this.PDFOJLELNHP[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
				this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
				this.PDFOJLELNHP[i].GetComponent<CFQKPMGLMJN>().NGCLGFMBMHL = FBIONLPHGEG;
				this.PDFOJLELNHP[i].GetComponent<CFQKPMGLMJN>().IIFLHGMKIEM = this.BELFMMFDEJD;
			}
			for (int j = 0; j < this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ.Length; j++)
			{
				if (this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ != null && this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ[j] != null)
				{
					this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
					this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
					string text = this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ[j].FBCKQEDONJK;
					if (KGQECFKLKOP.MIKJDLGLEDQ(text) != null)
					{
						text = KGQECFKLKOP.MIKJDLGLEDQ(text).Name;
					}
					this.CMLGJIEIDBC[j].PIDLOFMIEFQ = string.Concat(new string[]
					{
						text,
						"\r\nPP ",
						this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ[j].LIQCECMEOIJ.ToString(),
						"/",
						this.OEDNKPKCFJI[FBIONLPHGEG - 1].EEILBMOOJHJ[j].JPLIFCNPICK.ToString()
					});
				}
			}
			this.KCFMOLKJNKK.enabled = true;
			this.KCFMOLKJNKK.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 0;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.MNJBJJNEMPC.enabled = true;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.QBLCPMDNNKC.enabled = true;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[3].gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x0010B834 File Offset: 0x00109A34
	public IEnumerator CNIGGKFJIGK(string HJQLPPKBJPM, GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB)
	{
		if (ILBCCCBJNCL == null)
		{
			yield break;
		}
		if (!(PBHPQFLMQDB == null))
		{
			if (HJQLPPKBJPM == "ember")
			{
				yield return new WaitForSeconds(0.8f);
				return 1;
			}
			IL_DF:
			yield break;
		}
		yield break;
		ebibbqgncfh = UnityEngine.Object.Instantiate<EBIBBQGNCFH>(HIOMOLCBDNP.QOQONHOOLNE.EHDCPPFMICC[0], PBHPQFLMQDB.transform.KQQJCMQCFMN("Head").position, Quaternion.identity);
		ebibbqgncfh.JILENMCJCHF = ILBCCCBJNCL.transform.KQQJCMQCFMN("Head");
		ebibbqgncfh.HOFHHQDFNCD = UnityEngine.Time.time;
		goto IL_DF;
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x0010C098 File Offset: 0x0010A298
	public IEnumerator GIEHPOGCCKJ(GameObject[] LMQQMBOPINH, bool NDBIMOOLGGI)
	{
		array = new OELLFMKIMFH[LMQQMBOPINH.Length];
		array2 = new DBQLOHBBJMG.FDJOEICCEOG[LMQQMBOPINH.Length];
		array3 = new bool[LMQQMBOPINH.Length];
		for (int i = 0; i < LMQQMBOPINH.Length; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (j < this.EQFDHBJKGCQ.Length && LMQQMBOPINH[i] == this.EQFDHBJKGCQ[j])
				{
					array[i] = this.CLBGINEMIFE[j];
					array2[i] = this.HJKOHEHLJGL.CBDCGKPHPJO[j];
				}
				if (j < this.FGMEONKLKFG.Length && LMQQMBOPINH[i] == this.FGMEONKLKFG[j])
				{
					array[i] = this.JMCMGILPGGI[j];
					array2[i] = this.HJKOHEHLJGL.JELLELLGLLB[j];
				}
			}
		}
		if (NDBIMOOLGGI)
		{
			for (int k = 0; k < LMQQMBOPINH.Length; k++)
			{
				FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[k], 0.5f, Vector3.zero);
			}
			yield return new WaitForSeconds(1f);
		}
		else
		{
			for (int l = 0; l < LMQQMBOPINH.Length; l++)
			{
				float num = LMQQMBOPINH[l].GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
				if (num == 0f)
				{
					num = 1f;
				}
				LMQQMBOPINH[l].transform.localScale = Vector3.zero;
				if (array2[l].BEQHNFFEHMQ == 201)
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(-num, num, num) * 0.01f);
				}
				else
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(num, num, num) * 0.01f);
				}
				Animation componentInChildren = LMQQMBOPINH[l].GetComponentInChildren<Animation>();
				if (array2[l].DCFKMOILHEC <= 0)
				{
					array3[l] = true;
				}
				if (!array3[l])
				{
					if (componentInChildren.GetClip("0") != null)
					{
						componentInChildren.Play("0");
					}
				}
				else
				{
					componentInChildren.Stop();
					if (componentInChildren.GetClip("17") != null)
					{
						componentInChildren.Play("17");
					}
				}
			}
			if (Convert.ToInt32(LMQQMBOPINH[0].name) < 0)
			{
				for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
				{
					this.FGMEONKLKFG[m].transform.ONDIKKGKGBN(9);
				}
			}
			else
			{
				for (int n = 0; n < this.EQFDHBJKGCQ.Length; n++)
				{
					this.EQFDHBJKGCQ[n].transform.ONDIKKGKGBN(9);
				}
			}
			yield return new WaitForSeconds(0.5f);
		}
		return 1;
		int num2 = 0;
		goto IL_3A6;
		IL_38B:
		LMQQMBOPINH[num2].transform.ONDIKKGKGBN(10);
		num2++;
		IL_3A6:
		if (num2 < LMQQMBOPINH.Length)
		{
			goto IL_38B;
		}
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x0010CA94 File Offset: 0x0010AC94
	public void LGQMKCQJQJC(string ILBCCCBJNCL, int ECNIJCPBPIG)
	{
		this.OpenCloseAttacks();
		this.JNQEJDCLKMM = ECNIJCPBPIG;
		this.NPNFPOCIDKD = ILBCCCBJNCL;
		this.QKJNHCOMEGH = 1;
		switch (ILBCCCBJNCL)
		{
		case "[FF8888]Admin":
		case "Guts":
		case " cut its own HP and put a curse on ":
		case "#,##0":
			this.QKJNHCOMEGH = 0;
			this.FQQLENFQBFH();
			return;

			if (this.EQFDHBJKGCQ.Length == 0 && this.FGMEONKLKFG.Length == 0)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectFoe;
			this.JKFJCMKMNLL = 1;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 661f;
			return;
		case "Poison Point":
			if (this.EQFDHBJKGCQ.Length == 0 && this.FGMEONKLKFG.Length == 0)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectUser;
			this.JKFJCMKMNLL = 0;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1038f;
			return;
		case ":":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectUser;
			this.JKFJCMKMNLL = 2;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1953f;
			return;
		case "[ff6666]":
			if (this.EQFDHBJKGCQ.Length == 1 && this.FGMEONKLKFG.Length == 0)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
			this.JKFJCMKMNLL = 3;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 594f;
			return;
		case "Music":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
			this.JKFJCMKMNLL = 0;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 936f;
			return;
		case "Big/":
			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;
		}
		this.FQQLENFQBFH();
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x000152B5 File Offset: 0x000134B5
	public void NIFKFLLMHCM(int HFBPHOGKGLK, KGQECFKLKOP.IJHPPMDDKIE CIQFCJGQEMH)
	{
		this.HGQHFDPBNFN(true);
		this.BELFMMFDEJD = HFBPHOGKGLK;
		this.FMHBCMCPEOD = CIQFCJGQEMH;
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x000152CC File Offset: 0x000134CC
	public void MDQEGMNKQJP()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = this;
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x0010CD60 File Offset: 0x0010AF60
	public void ECJLQJBPGND(string BLGLBQKCJQQ)
	{
		this.JJMIHDFMCMD = UnityEngine.Time.time;
		this.HQPOOCLKDOB.BFDGBMNGBKH(BLGLBQKCJQQ);
		this.HQPOOCLKDOB.FFODFLMCELB.PIDLOFMIEFQ = this.HQPOOCLKDOB.FFODFLMCELB.PIDLOFMIEFQ.Replace("Join Channel", string.Empty);
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000152D4 File Offset: 0x000134D4
	private void HFNKLOHMQFH()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = null;
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x0010CDB4 File Offset: 0x0010AFB4
	public void CFGMNHFIPBB(int HFBPHOGKGLK)
	{
		this.PQGHKEFEGFQ = HFBPHOGKGLK;
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.JKFJCMKMNLL = 2;
		this.EKQKKPOIIBN.DIIHJCJOKMP = 325f;
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 1153f)
		{
			this.MNJBJJNEMPC.enabled = false;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x0010CE14 File Offset: 0x0010B014
	public void GOLFMJGNEMC()
	{
		this.BELFMMFDEJD = 1;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 26f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1727f;
			this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)117;
		}
		this.ONOLCMHKBGC();
		if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1386f)
		{
			this.CMCMBFLGJHH[2].gameObject.SetActive(true);
			this.QBLCPMDNNKC.enabled = false;
			this.QBLCPMDNNKC.PlayForward();
			this.JNQEJDCLKMM = 1;
			this.QKJNHCOMEGH = 1;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1789f)
			{
				this.MNJBJJNEMPC.enabled = true;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1628f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1068f)
			{
				this.KCFMOLKJNKK.enabled = false;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1500f)
		{
			this.CMCMBFLGJHH[0].gameObject.SetActive(false);
			this.QBLCPMDNNKC.enabled = false;
			this.QBLCPMDNNKC.PlayReverse();
		}
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x000152DC File Offset: 0x000134DC
	public void SendMoveSelection(int FBIONLPHGEG, int ECNIJCPBPIG)
	{
		this.CLIEFPPGCHK(this.BELFMMFDEJD, FBIONLPHGEG, true, ECNIJCPBPIG, false);
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x0010C3F8 File Offset: 0x0010A5F8
	public IEnumerator LMCFJKKPENB(int QONOKDQLJNG, int OMLMGMLCCLG, int BDBBEMKFGPI)
	{
		if (QONOKDQLJNG == 0)
		{
			fdjoeicceog = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd.OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
			mffgqcjkpbd.EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD.ToString();
			mffgqcjkpbd.QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
			mffgqcjkpbd.PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
			fdjoeicceog2 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog2.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog2.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog2.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog2.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog2.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog2.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog2.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog2.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog2.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog2.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd2 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd2.OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
			mffgqcjkpbd2.EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD.ToString();
			mffgqcjkpbd2.QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
			mffgqcjkpbd2.PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
			if (this.CLBGINEMIFE[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.EQFDHBJKGCQ[OMLMGMLCCLG],
					this.EQFDHBJKGCQ[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		else
		{
			fdjoeicceog3 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog3.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog3.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog3.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog3.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog3.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog3.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog3.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog3.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog3.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog3.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd3 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd3.OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
			mffgqcjkpbd3.EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD.ToString();
			mffgqcjkpbd3.QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
			mffgqcjkpbd3.PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
			fdjoeicceog4 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog4.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog4.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog4.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog4.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog4.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog4.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog4.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog4.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog4.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog4.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd4 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd4.OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
			mffgqcjkpbd4.EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD.ToString();
			mffgqcjkpbd4.QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
			mffgqcjkpbd4.PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
			if (this.JMCMGILPGGI[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.FGMEONKLKFG[OMLMGMLCCLG],
					this.FGMEONKLKFG[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		dpdqidjpenf = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		cmgnloffglq = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		dpdqidjpenf2 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		cmgnloffglq2 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf2, cmgnloffglq2, true, fdjoeicceog2.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf, cmgnloffglq, true, fdjoeicceog.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[OMLMGMLCCLG].BQLIIQIIMDH(false, (fdjoeicceog2.BCJGCNQJEGI != 0) ? fdjoeicceog2.BCJGCNQJEGI : fdjoeicceog2.BEQHNFFEHMQ, fdjoeicceog2.BKNFHNFFCHE, null, null, null, mffgqcjkpbd2, fdjoeicceog2.KMNQBFKKNMB, fdjoeicceog2.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[BDBBEMKFGPI].BQLIIQIIMDH(false, (fdjoeicceog.BCJGCNQJEGI != 0) ? fdjoeicceog.BCJGCNQJEGI : fdjoeicceog.BEQHNFFEHMQ, fdjoeicceog.BKNFHNFFCHE, null, null, null, mffgqcjkpbd, fdjoeicceog.KMNQBFKKNMB, fdjoeicceog.BEQHNFFEHMQ == 132));
		return 1;
		this.CLBGINEMIFE[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog2.PLCBFLQBCQN);
		this.CLBGINEMIFE[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog.PLCBFLQBCQN);
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog.DCFKMOILHEC;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog2.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog2.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog2.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog2.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog2.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog2.DCFKMOILHEC;
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0 || fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_107C;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.EQFDHBJKGCQ[OMLMGMLCCLG],
			this.EQFDHBJKGCQ[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_107C:
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0)
		{
			goto IL_10D5;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_10D5:
		if (fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		dpdqidjpenf3 = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		cmgnloffglq3 = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		dpdqidjpenf4 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		cmgnloffglq4 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf4, cmgnloffglq4, true, fdjoeicceog4.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf3, cmgnloffglq3, true, fdjoeicceog3.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[OMLMGMLCCLG].BQLIIQIIMDH(true, (fdjoeicceog4.BCJGCNQJEGI != 0) ? fdjoeicceog4.BCJGCNQJEGI : fdjoeicceog4.BEQHNFFEHMQ, fdjoeicceog4.BKNFHNFFCHE, null, null, null, mffgqcjkpbd4, fdjoeicceog4.KMNQBFKKNMB, fdjoeicceog4.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[BDBBEMKFGPI].BQLIIQIIMDH(true, (fdjoeicceog3.BCJGCNQJEGI != 0) ? fdjoeicceog3.BCJGCNQJEGI : fdjoeicceog3.BEQHNFFEHMQ, fdjoeicceog3.BKNFHNFFCHE, null, null, null, mffgqcjkpbd3, fdjoeicceog3.KMNQBFKKNMB, fdjoeicceog3.BEQHNFFEHMQ == 132));
		return 1;
		this.JMCMGILPGGI[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog4.PLCBFLQBCQN);
		this.JMCMGILPGGI[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog3.PLCBFLQBCQN);
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog3.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog3.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog3.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog3.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog3.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog3.DCFKMOILHEC;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog4.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog4.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog4.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog4.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog4.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog4.DCFKMOILHEC;
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0 || fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_179F;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.FGMEONKLKFG[OMLMGMLCCLG],
			this.FGMEONKLKFG[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_179F:
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0)
		{
			goto IL_17F2;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_17F2:
		if (fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		IL_1845:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x0010CF74 File Offset: 0x0010B174
	private bool JLIBONJBQNG(string ILBCCCBJNCL)
	{
		int num = this.EQFDHBJKGCQ.Length;
		int num2 = Convert.ToInt32(ILBCCCBJNCL);
		if (this.JKFJCMKMNLL == 0)
		{
			if (num == 1)
			{
				return num2 == 0;
			}
			if (num == 6)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 1 || num2 == 7 || num2 == -63;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != 1 && num2 != 8 && num2 != -1 && false;
				}
			}
			else
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 4 || num2 == 3 || num2 == -8;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 0 || num2 == 6 || num2 == 8 || num2 == -1 || num2 == -109;
				}
				if (this.FQBMEKNJHDH == 8)
				{
					return num2 != 1 && num2 != 7 && num2 != 82;
				}
			}
		}
		if (this.JKFJCMKMNLL == 0)
		{
			if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -1;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -26;
				}
				if (this.FQBMEKNJHDH == 8)
				{
					return num2 != 6 || true;
				}
			}
			else if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -1;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -26;
				}
			}
			else if (num == 0 && this.FQBMEKNJHDH == 0)
			{
				return num2 == -1 && false;
			}
		}
		if (this.JKFJCMKMNLL == 4)
		{
			return num2 < 1;
		}
		if (this.JKFJCMKMNLL == 3)
		{
			if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 95;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -1 || num2 == -91 || true;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 19 && false;
				}
			}
			else if (num == 0)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -83 || true;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != -1;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return false;
			}
		}
		if (this.JKFJCMKMNLL == 2)
		{
			if (num == 0)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 0 || num2 == 0 || true;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 1 || num2 == 7 || num2 == 3;
				}
				if (this.FQBMEKNJHDH == 8)
				{
					return num2 != 0 && num2 != 7 && false;
				}
			}
			else if (num == 8)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 1 && num2 != 4 && false;
				}
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != 0 && num2 != 4 && false;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return num2 == 0 || true;
			}
		}
		if (this.JKFJCMKMNLL == 2)
		{
			if (num == 7)
			{
				return num2 != 1 && num2 != 0 && num2 != 7;
			}
			if (num == 3)
			{
				return num2 != 1 && num2 != 2;
			}
			if (num == 0)
			{
				return num2 != 0;
			}
		}
		return false;
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x0010D208 File Offset: 0x0010B408
	public void OpenClosePokemonWindow(bool OGQFQNIGIQD = false)
	{
		if (OGQFQNIGIQD)
		{
			for (int i = 0; i < this.OEDNKPKCFJI.Length; i++)
			{
				this.QILHFPGMMBC[i].enabled = true;
				this.QILHFPGMMBC[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = true;
			}
		}
		else
		{
			for (int j = 0; j < this.OEDNKPKCFJI.Length; j++)
			{
				if (!this.OEDNKPKCFJI[j].IHIMHNGOLQJ && !this.OEDNKPKCFJI[j].CPOJBKCQPHK && !this.OEDNKPKCFJI[j].NEBPMMPMQBD && this.OEDNKPKCFJI[j].DCFKMOILHEC > 0 && (!this.OEDNKPKCFJI[j].DQNDIMFPMBM || this.OEDNKPKCFJI[j].IHIMHNGOLQJ || this.OEDNKPKCFJI[j].CPOJBKCQPHK))
				{
					this.QILHFPGMMBC[j].enabled = true;
					this.QILHFPGMMBC[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
					this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.QILHFPGMMBC[j].enabled = false;
					this.QILHFPGMMBC[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
					this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		this.EHOELFJHQBC();
		if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 0f)
		{
			this.OHDIOJQJJNJ.enabled = true;
			this.OHDIOJQJJNJ.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 0;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.MNJBJJNEMPC.enabled = true;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1f)
			{
				this.QBLCPMDNNKC.enabled = true;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[3].gameObject.SetActive(true);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.KCFMOLKJNKK.enabled = true;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
		{
			this.OHDIOJQJJNJ.enabled = true;
			this.OHDIOJQJJNJ.PlayReverse();
		}
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x0010D47C File Offset: 0x0010B67C
	public void ODHNDFOKIQE(string ILBCCCBJNCL, int ECNIJCPBPIG)
	{
		this.OpenCloseAttacks();
		this.JNQEJDCLKMM = ECNIJCPBPIG;
		this.NPNFPOCIDKD = ILBCCCBJNCL;
		this.QKJNHCOMEGH = 0;
		switch (ILBCCCBJNCL)
		{
		case "Null":
			this.QKJNHCOMEGH = 0;
			this.FQQLENFQBFH();
			return;
		case "normal":
			if (this.EQFDHBJKGCQ.Length == 1 && this.FGMEONKLKFG.Length == 1)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectField;
			this.JKFJCMKMNLL = 0;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
			return;
		case "any":
			if (this.EQFDHBJKGCQ.Length == 1 && this.FGMEONKLKFG.Length == 1)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectField;
			this.JKFJCMKMNLL = 1;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
			return;
		case "adjacentAllyOrSelf":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectUser;
			this.JKFJCMKMNLL = 2;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
			return;
		case "adjacentAlly":
			if (this.EQFDHBJKGCQ.Length == 1 && this.FGMEONKLKFG.Length == 1)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectUser;
			this.JKFJCMKMNLL = 3;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
			return;
		case "adjacentFoe":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectFoe;
			this.JKFJCMKMNLL = 4;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
			return;
		case "allAdjacentFoes":
			this.FQQLENFQBFH();
			return;
		case "allAdjacent":
			this.FQQLENFQBFH();
			return;
		case "foeSide":
			this.FQQLENFQBFH();
			return;
		case "allyTeam":
			this.FQQLENFQBFH();
			return;
		case "allySide":
			this.FQQLENFQBFH();
			return;
		case "scripted":
			this.FQQLENFQBFH();
			return;
		case "randomNormal":
			this.FQQLENFQBFH();
			return;
		case "self":
			this.FQQLENFQBFH();
			return;
		case "all":
			this.FQQLENFQBFH();
			return;
		}
		this.FQQLENFQBFH();
	}

	// Token: 0x06002BBD RID: 11197 RVA: 0x0010D748 File Offset: 0x0010B948
	public void OpenCloseItemsWindow()
	{
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 0f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		}
		this.EHOELFJHQBC();
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 0f)
		{
			INFJMNPKNQF.QOQONHOOLNE.LGDIOIMGJEO(this.JBLCJMKHBDF, this);
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 0;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1f)
			{
				this.QBLCPMDNNKC.enabled = true;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[3].gameObject.SetActive(true);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.KCFMOLKJNKK.enabled = true;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
		{
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x0010D8AC File Offset: 0x0010BAAC
	public void PDDJMNOOPJD(bool OKLFOFLMHPN = false)
	{
		this.HNCMMGQKBFD = false;
		if (this.QHLPMOPOBNJ || this.LBFFJFGJPBD)
		{
			for (int i = 0; i < 3; i++)
			{
				this.FFEEMHBOBQJ[i].OIOMEPFJMGQ.SetActive(false);
			}
			this.BELFMMFDEJD = 0;
			this.FMHBCMCPEOD = null;
			this.POKGLNOCHJE = UnityEngine.Time.time;
			this.HideAttackButtons();
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
			this.HideMoves();
			return;
		}
		for (int j = 0; j < this.CLBGINEMIFE.Length; j++)
		{
			if (this.CLBGINEMIFE[j] != null)
			{
				this.CLBGINEMIFE[j].HFGCJIBECML();
			}
		}
		for (int k = 0; k < this.JMCMGILPGGI.Length; k++)
		{
			if (this.JMCMGILPGGI[k] != null)
			{
				this.JMCMGILPGGI[k].HFGCJIBECML();
			}
		}
		for (int l = 0; l < 6; l++)
		{
			this.QILHFPGMMBC[l].enabled = false;
			this.QILHFPGMMBC[l].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.QILHFPGMMBC[l].GetComponent<BoxCollider>().enabled = false;
			this.QILHFPGMMBC[l].GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = string.Empty;
			this.QILHFPGMMBC[l].gameObject.SetActive(false);
		}
		int m = 0;
		while (m < this.OEDNKPKCFJI.Length)
		{
			this.QILHFPGMMBC[m].gameObject.SetActive(true);
			HGOHLFJHLIC componentInChildren = this.QILHFPGMMBC[m].GetComponentInChildren<HGOHLFJHLIC>();
			componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(this.OEDNKPKCFJI[m].DBPKNCDGGEP);
			if (this.OEDNKPKCFJI[m].KMNQBFKKNMB != null && this.OEDNKPKCFJI[m].KMNQBFKKNMB.ToLowerInvariant().Contains("-primal"))
			{
				componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = "P. " + componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ;
			}
			if (this.OEDNKPKCFJI[m].BKNFHNFFCHE)
			{
				componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = "[SHINY]" + componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ;
			}
			if (this.OEDNKPKCFJI[m].KMNQBFKKNMB != null)
			{
				if (this.OEDNKPKCFJI[m].KMNQBFKKNMB.ToLowerInvariant().Contains("-mega-x"))
				{
					componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = "[MEGA] " + componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ;
				}
				else if (this.OEDNKPKCFJI[m].KMNQBFKKNMB.ToLowerInvariant().Contains("-mega-y"))
				{
					componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = "[MEGA] " + componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ;
				}
				else if (this.OEDNKPKCFJI[m].KMNQBFKKNMB.ToLowerInvariant().Contains("-mega"))
				{
					componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ = "[MEGA] " + componentInChildren.NMCIJEKPOPJ.PIDLOFMIEFQ;
				}
			}
			string str = string.Empty;
			if (this.OEDNKPKCFJI[m].OQDOCCGPJDQ == "F")
			{
				str = " [F]";
			}
			else if (this.OEDNKPKCFJI[m].OQDOCCGPJDQ == "M")
			{
				str = " [M]";
			}
			BKKHLBCLPJM nmcijekpopj = componentInChildren.NMCIJEKPOPJ;
			nmcijekpopj.PIDLOFMIEFQ += str;
			componentInChildren.QFLHCIMOPLG.PIDLOFMIEFQ = "[Lv]" + this.OEDNKPKCFJI[m].EOMPMQNGIBD.ToString();
			string text = this.OEDNKPKCFJI[m].PLCBFLQBCQN;
			if (text == null)
			{
				text = string.Empty;
			}
			string text2 = text.ToLowerInvariant();
			if (text2 == null)
			{
				goto IL_4F0;
			}
			if (OGJJKKQPNMK.EGDHGKOIEOG == null)
			{
				OGJJKKQPNMK.EGDHGKOIEOG = new Dictionary<string, int>(7)
				{
					{
						string.Empty,
						0
					},
					{
						"brn",
						1
					},
					{
						"tox",
						2
					},
					{
						"psn",
						3
					},
					{
						"slp",
						4
					},
					{
						"par",
						5
					},
					{
						"frz",
						6
					}
				};
			}
			int liqcecmeoij;
			if (!OGJJKKQPNMK.EGDHGKOIEOG.TryGetValue(text2, out liqcecmeoij))
			{
				goto IL_4F0;
			}
			switch (liqcecmeoij)
			{
			case 0:
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 0f;
				break;
			case 1:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_Burn";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 2:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_BadlyPoisoned";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 3:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_Poisoned";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 4:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_Sleep";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 5:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_Paralyzed";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 6:
				componentInChildren.PBBDKIFHGOK.KCLBMPFIPNQ = "Icon_Status_Frozen";
				componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 1f;
				break;
			case 7:
				goto IL_4F0;
			default:
				goto IL_4F0;
			}
			IL_501:
			int num = (int)(124.0 / ((double)this.OEDNKPKCFJI[m].QKBGGCKIOLG / (double)this.OEDNKPKCFJI[m].DCFKMOILHEC * 100.0) * 100.0 - 1.0);
			if (num > 124)
			{
				num = 124;
			}
			if (num <= 2)
			{
				num = 2;
			}
			if (this.OEDNKPKCFJI[m].DCFKMOILHEC > 0)
			{
				componentInChildren.KEDIOECQJJO.PIDLOFMIEFQ = this.OEDNKPKCFJI[m].DCFKMOILHEC.ToString() + "/" + this.OEDNKPKCFJI[m].QKBGGCKIOLG.ToString();
			}
			else
			{
				componentInChildren.KEDIOECQJJO.PIDLOFMIEFQ = "Fnt";
			}
			componentInChildren.OOQCHNEDMGG.KJGMGPCEJJD = num;
			if (componentInChildren.OOQCHNEDMGG.KJGMGPCEJJD < 75)
			{
				componentInChildren.OOQCHNEDMGG.CEGFBBHMKOE = Color.Lerp(Color.red, Color.yellow, (float)(1.0 / (151.0 / (double)componentInChildren.OOQCHNEDMGG.KJGMGPCEJJD)) * 2f);
			}
			else
			{
				componentInChildren.OOQCHNEDMGG.CEGFBBHMKOE = Color.Lerp(Color.yellow, Color.green, (float)(1.0 / (151.0 / (double)componentInChildren.OOQCHNEDMGG.KJGMGPCEJJD) - 0.5) * 2f);
			}
			if (!this.OEDNKPKCFJI[m].IHIMHNGOLQJ && !this.OEDNKPKCFJI[m].CPOJBKCQPHK && !this.OEDNKPKCFJI[m].NEBPMMPMQBD && this.OEDNKPKCFJI[m].DCFKMOILHEC > 0 && (!this.OEDNKPKCFJI[m].DQNDIMFPMBM || this.OEDNKPKCFJI[m].IHIMHNGOLQJ || this.OEDNKPKCFJI[m].CPOJBKCQPHK))
			{
				this.QILHFPGMMBC[m].enabled = true;
				this.QILHFPGMMBC[m].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.QILHFPGMMBC[m].GetComponent<BoxCollider>().enabled = true;
			}
			else
			{
				this.QILHFPGMMBC[m].enabled = false;
				this.QILHFPGMMBC[m].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				this.QILHFPGMMBC[m].GetComponent<BoxCollider>().enabled = false;
			}
			m++;
			continue;
			IL_4F0:
			componentInChildren.PBBDKIFHGOK.DIIHJCJOKMP = 0f;
			goto IL_501;
		}
		this.HNCMMGQKBFD = true;
		if (!OKLFOFLMHPN)
		{
			int num2 = 0;
			bool flag = false;
			int n = 0;
			while (n < this.CLBGINEMIFE.Length)
			{
				if (!(this.CLBGINEMIFE[n] != null) || !this.CLBGINEMIFE[n].HHKJGOPMMQL.NEBPMMPMQBD)
				{
					n++;
				}
				else
				{
					flag = true;
					IL_7C2:
					if (flag)
					{
						for (int num3 = 0; num3 < this.CLBGINEMIFE.Length; num3++)
						{
							if (this.CLBGINEMIFE[num3] != null)
							{
								num2++;
							}
						}
					}
					for (int num4 = 0; num4 < this.CLBGINEMIFE.Length; num4++)
					{
						if (this.CLBGINEMIFE[num4] != null && this.CLBGINEMIFE[num4].HHKJGOPMMQL.NEBPMMPMQBD)
						{
							if (this.LBIQLLNPCED(num4))
							{
								num2--;
								this.HideAttackButtons();
								this.FQBMEKNJHDH = num4;
								for (int num5 = 0; num5 < 3; num5++)
								{
									this.FFEEMHBOBQJ[num5].OIOMEPFJMGQ.SetActive(false);
								}
								this.FFEEMHBOBQJ[this.FQBMEKNJHDH].OIOMEPFJMGQ.SetActive(true);
								bool flag2 = true;
								for (int num6 = 0; num6 < this.OEDNKPKCFJI.Length; num6++)
								{
									if (this.OEDNKPKCFJI[num6].DCFKMOILHEC > 0)
									{
										flag2 = false;
										IL_8B5:
										if (!flag2)
										{
											int num7 = 0;
											for (int num8 = 0; num8 < this.OEDNKPKCFJI.Length; num8++)
											{
												if (this.OEDNKPKCFJI[num8].DCFKMOILHEC > 0 && !this.OEDNKPKCFJI[num8].CPOJBKCQPHK && !this.OEDNKPKCFJI[num8].IHIMHNGOLQJ)
												{
													num7++;
												}
											}
											if (num7 <= 0)
											{
												bool flag3 = false;
												int num9 = 0;
												while (num9 < this.IGOGQDBOGQL.pokemon.Length)
												{
													if (!(this.IGOGQDBOGQL.pokemon[num4].trainer.ToLowerInvariant() != KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant()) || this.IGOGQDBOGQL.pokemon[num4].active || this.IGOGQDBOGQL.pokemon[num4].condition.Contains("fnt"))
													{
														num9++;
													}
													else
													{
														flag3 = true;
														IL_999:
														if (flag3)
														{
															this.HNCMMGQKBFD = false;
															this.POKGLNOCHJE = UnityEngine.Time.time;
															goto IL_9D3;
														}
														this.JHDDHQJLNJJ(num4);
														this.HNCMMGQKBFD = false;
														this.POKGLNOCHJE = UnityEngine.Time.time;
														goto IL_9D3;
													}
												}
												goto IL_999;
											}
											if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 0f)
											{
												this.OpenClosePokemonWindow(false);
											}
										}
										else if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
										{
											this.OpenClosePokemonWindow(false);
										}
										return;
									}
								}
								goto IL_8B5;
							}
							num2--;
						}
						IL_9D3:;
					}
					if (num2 <= 0)
					{
						goto IL_ADB;
					}
					for (int num10 = 0; num10 < this.CLBGINEMIFE.Length; num10++)
					{
						if (!this.CLBGINEMIFE[num10].HHKJGOPMMQL.JHCFQOPLHQE && !this.CLBGINEMIFE[num10].HHKJGOPMMQL.NEBPMMPMQBD && this.CLBGINEMIFE[num10].HHKJGOPMMQL.HHNOCOQJOJF.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
						{
							this.JHDDHQJLNJJ(num10);
						}
					}
					this.FQBMEKNJHDH = 0;
					if (!this.LBIQLLNPCED(-1))
					{
						this.FQBMEKNJHDH++;
					}
					if (!this.LBIQLLNPCED(-1))
					{
						this.FQBMEKNJHDH++;
						goto IL_ADB;
					}
					goto IL_ADB;
				}
			}
			goto IL_7C2;
		}
		IL_ADB:
		if (this.CEBEEDEJOQL)
		{
			this.HideAttackButtons();
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			}
			this.HideMoves();
			this.HNCMMGQKBFD = false;
			this.POKGLNOCHJE = UnityEngine.Time.time;
			return;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (this.FQBMEKNJHDH < this.CLBGINEMIFE.Length && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.DCFKMOILHEC <= 0 && this.LBIQLLNPCED(-1))
		{
			this.JHDDHQJLNJJ(this.FQBMEKNJHDH);
			this.FQBMEKNJHDH++;
			this.PDDJMNOOPJD(false);
			return;
		}
		bool flag4 = false;
		if (this.FQBMEKNJHDH < this.CLBGINEMIFE.Length && this.LBIQLLNPCED(-1) && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.OEBEBPJEINC && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			this.KCHPEMQFOHP.SetActive(true);
			this.KCHPEMQFOHP.GetComponent<UIToggle>().value = false;
		}
		else
		{
			this.KCHPEMQFOHP.SetActive(false);
			this.KCHPEMQFOHP.GetComponent<UIToggle>().value = false;
		}
		for (int num11 = 0; num11 < 4; num11++)
		{
			this.EFHDIMHHOOJ[num11].gameObject.SetActive(true);
			this.EFHDIMHHOOJ[num11].GGBPLMICFHN = false;
			if (this.FQBMEKNJHDH < this.CLBGINEMIFE.Length && this.LBIQLLNPCED(-1) && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11] != null && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.DCFKMOILHEC > 0)
			{
				OEJGFKMOQJG component = this.EFHDIMHHOOJ[num11].GetComponent<OEJGFKMOQJG>();
				component.QCNHEHFGHMP = -1;
				component.OLBCQQJMCPK = string.Empty;
				KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MIKJDLGLEDQ(this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].CIQFCJGQEMH);
				if (moveInfo.BattleID == "frustration")
				{
					int qcnhehfghmp = -1;
					int.TryParse(this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].FBCKQEDONJK.Substring(12), out qcnhehfghmp);
					component.QCNHEHFGHMP = qcnhehfghmp;
				}
				else if (moveInfo.BattleID == "return")
				{
					int qcnhehfghmp2 = -1;
					int.TryParse(this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].FBCKQEDONJK.Substring(7), out qcnhehfghmp2);
					component.QCNHEHFGHMP = qcnhehfghmp2;
				}
				this.EFHDIMHHOOJ[num11].GGBPLMICFHN = true;
				if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].LIQCECMEOIJ == 0 && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].JPLIFCNPICK == 0)
				{
					component.EJJGJGDKLFD.PIDLOFMIEFQ = moveInfo.Name;
					component.JFPQFQHNCGQ.PIDLOFMIEFQ = "-";
					if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[3] == null && !moveInfo.Name.ToLowerInvariant().Contains("struggle"))
					{
						flag4 = true;
					}
				}
				else
				{
					BKKHLBCLPJM jfpqfqhncgq = component.JFPQFQHNCGQ;
					int liqcecmeoij = this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].LIQCECMEOIJ;
					jfpqfqhncgq.PIDLOFMIEFQ = liqcecmeoij.ToString() + "/" + this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].JPLIFCNPICK.ToString();
					component.EJJGJGDKLFD.PIDLOFMIEFQ = moveInfo.Name;
				}
				component.FBCKQEDONJK = this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11];
				component.GMQPDFJJDPO = this;
				this.EFHDIMHHOOJ[num11].gameObject.SetActive(true);
				string text3 = moveInfo.Type.ToLowerInvariant();
				if (moveInfo.Name == "Hidden Power")
				{
					text3 = this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].FBCKQEDONJK.ToLowerInvariant().Replace("hidden power ", string.Empty);
					component.OLBCQQJMCPK = text3;
				}
				if (text3 == null)
				{
					goto IL_13A4;
				}
				if (OGJJKKQPNMK.LPDLJMOCQEP == null)
				{
					OGJJKKQPNMK.LPDLJMOCQEP = new Dictionary<string, int>(18)
					{
						{
							"normal",
							0
						},
						{
							"fighting",
							1
						},
						{
							"flying",
							2
						},
						{
							"poison",
							3
						},
						{
							"ground",
							4
						},
						{
							"rock",
							5
						},
						{
							"bug",
							6
						},
						{
							"ghost",
							7
						},
						{
							"steel",
							8
						},
						{
							"fire",
							9
						},
						{
							"water",
							10
						},
						{
							"grass",
							11
						},
						{
							"electric",
							12
						},
						{
							"psychic",
							13
						},
						{
							"ice",
							14
						},
						{
							"dragon",
							15
						},
						{
							"dark",
							16
						},
						{
							"fairy",
							17
						}
					};
				}
				int num12;
				if (!OGJJKKQPNMK.LPDLJMOCQEP.TryGetValue(text3, out num12))
				{
					goto IL_13A4;
				}
				switch (num12)
				{
				case 0:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[0];
					break;
				case 1:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[1];
					break;
				case 2:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[2];
					break;
				case 3:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[3];
					break;
				case 4:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[4];
					break;
				case 5:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[5];
					break;
				case 6:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[6];
					break;
				case 7:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[7];
					break;
				case 8:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[8];
					break;
				case 9:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[9];
					break;
				case 10:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[10];
					break;
				case 11:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[11];
					break;
				case 12:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[12];
					break;
				case 13:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[13];
					break;
				case 14:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[14];
					break;
				case 15:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[15];
					break;
				case 16:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[16];
					break;
				case 17:
					component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[17];
					break;
				case 18:
					goto IL_13A4;
				default:
					goto IL_13A4;
				}
				IL_13C1:
				this.EFHDIMHHOOJ[num11].IDEOONDHNEL = component.CHCKFFKGDJO.CEGFBBHMKOE;
				this.EFHDIMHHOOJ[num11].BBIJQCIJQNM = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
				this.EFHDIMHHOOJ[num11].KCICOJFDCPQ = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
				this.EFHDIMHHOOJ[num11].DKMHBQNHQGD(true);
				component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[0];
				component.NBPQOHIHPIC.PIDLOFMIEFQ = KGQECFKLKOP.HDKMGCBMEIJ(text3);
				if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.EEILBMOOJHJ[num11].DONPNIFGBBF)
				{
					this.EFHDIMHHOOJ[num11].IDEOONDHNEL = this.EFHDIMHHOOJ[num11].BKOENCLICDI;
					this.EFHDIMHHOOJ[num11].BBIJQCIJQNM = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
					this.EFHDIMHHOOJ[num11].KCICOJFDCPQ = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
					this.EFHDIMHHOOJ[num11].DKMHBQNHQGD(true);
					this.EFHDIMHHOOJ[num11].GGBPLMICFHN = false;
					goto IL_15D5;
				}
				goto IL_15D5;
				IL_13A4:
				component.CHCKFFKGDJO.CEGFBBHMKOE = this.MDGDPIEIMBN[0];
				goto IL_13C1;
			}
			this.EFHDIMHHOOJ[num11].IDEOONDHNEL = this.EFHDIMHHOOJ[num11].BKOENCLICDI;
			this.EFHDIMHHOOJ[num11].BBIJQCIJQNM = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
			this.EFHDIMHHOOJ[num11].KCICOJFDCPQ = this.EFHDIMHHOOJ[num11].IDEOONDHNEL;
			this.EFHDIMHHOOJ[num11].DKMHBQNHQGD(true);
			this.EFHDIMHHOOJ[num11].GGBPLMICFHN = false;
			this.EFHDIMHHOOJ[num11].gameObject.SetActive(false);
			this.EFHDIMHHOOJ[num11].GetComponent<OEJGFKMOQJG>().JFPQFQHNCGQ.PIDLOFMIEFQ = string.Empty;
			this.EFHDIMHHOOJ[num11].GetComponent<OEJGFKMOQJG>().EJJGJGDKLFD.PIDLOFMIEFQ = string.Empty;
			this.EFHDIMHHOOJ[num11].GetComponent<OEJGFKMOQJG>().FBCKQEDONJK = null;
			this.EFHDIMHHOOJ[num11].GetComponent<OEJGFKMOQJG>().GMQPDFJJDPO = this;
			IL_15D5:;
		}
		if (this.FQBMEKNJHDH > this.CLBGINEMIFE.Length - 1)
		{
			this.HNCMMGQKBFD = false;
			this.POKGLNOCHJE = UnityEngine.Time.time;
			return;
		}
		for (int num13 = 0; num13 < this.CMCMBFLGJHH.Length - 1; num13++)
		{
			this.CMCMBFLGJHH[num13].gameObject.SetActive(true);
			this.CMCMBFLGJHH[num13].enabled = true;
			this.CMCMBFLGJHH[num13].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.CMCMBFLGJHH[num13].GetComponent<BoxCollider>().enabled = true;
		}
		this.CMCMBFLGJHH[4].enabled = false;
		this.CMCMBFLGJHH[4].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.CMCMBFLGJHH[4].GetComponent<BoxCollider>().enabled = false;
		this.CMCMBFLGJHH[4].gameObject.SetActive(false);
		if ((!this.FCMNJOPQBKQ || ((this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.BPHKNGMPLML || this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.FGQHEDFQIFC) && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.BHPMOFEKHPM != "runaway")) && (!this.FCMNJOPQBKQ || !this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.FGQHEDFQIFC || this.IGOGQDBOGQL.pokemon == null || ((this.IGOGQDBOGQL.pokemon[this.FQBMEKNJHDH].baseAbility == null || !(this.IGOGQDBOGQL.pokemon[this.FQBMEKNJHDH].baseAbility == "runaway")) && (this.IGOGQDBOGQL.pokemon[this.FQBMEKNJHDH].item == null || !(this.IGOGQDBOGQL.pokemon[this.FQBMEKNJHDH].item == "smokeball")))))
		{
			this.CMCMBFLGJHH[2].enabled = false;
			this.CMCMBFLGJHH[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.CMCMBFLGJHH[2].GetComponent<BoxCollider>().enabled = false;
		}
		if (!this.LJDIQKPJIJN || flag4)
		{
			this.CMCMBFLGJHH[1].enabled = false;
			this.CMCMBFLGJHH[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.CMCMBFLGJHH[1].GetComponent<BoxCollider>().enabled = false;
		}
		if (this.FQBMEKNJHDH < this.CLBGINEMIFE.Length && this.LBIQLLNPCED(-1) && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.BPHKNGMPLML && this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			this.CMCMBFLGJHH[0].enabled = false;
			this.CMCMBFLGJHH[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.CMCMBFLGJHH[0].GetComponent<BoxCollider>().enabled = false;
		}
		if (this.CLBGINEMIFE.Length == 3 && (this.FQBMEKNJHDH == 0 || this.FQBMEKNJHDH == 2))
		{
			this.CMCMBFLGJHH[4].gameObject.SetActive(true);
			this.CMCMBFLGJHH[4].enabled = true;
			this.CMCMBFLGJHH[4].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.CMCMBFLGJHH[4].GetComponent<BoxCollider>().enabled = true;
		}
		for (int num14 = 0; num14 < 3; num14++)
		{
			this.FFEEMHBOBQJ[num14].OIOMEPFJMGQ.SetActive(false);
		}
		this.FFEEMHBOBQJ[this.FQBMEKNJHDH].OIOMEPFJMGQ.SetActive(true);
		if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
		{
			this.OpenClosePokemonWindow(false);
		}
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
		{
			this.OpenCloseItemsWindow();
		}
		this.HideMoves();
		this.HNCMMGQKBFD = true;
		if ((this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2) && this.JPHPMGBCLKC != null)
		{
			this.BNJEHBEEHMP = UnityEngine.Time.time;
		}
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x0010F308 File Offset: 0x0010D508
	private void HDDJPQFJIIC()
	{
		if (this.FQBMEKNJHDH >= this.CLBGINEMIFE.Length)
		{
			for (int i = 0; i < this.OEDNKPKCFJI.Length; i++)
			{
				this.OEDNKPKCFJI[i].DQNDIMFPMBM = false;
			}
			this.FQBMEKNJHDH = 0;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			this.PDDJMNOOPJD(false);
			this.HideAttackButtons();
			this.HNCMMGQKBFD = false;
			this.POKGLNOCHJE = UnityEngine.Time.time;
		}
		else
		{
			this.PDDJMNOOPJD(false);
		}
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
	private bool ELNCNIGEKFK(string ILBCCCBJNCL)
	{
		int num = this.EQFDHBJKGCQ.Length;
		int num2 = Convert.ToInt32(ILBCCCBJNCL);
		if (this.JKFJCMKMNLL == 0)
		{
			if (num == 1)
			{
				return num2 == 1;
			}
			if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 1 || num2 == 2 || num2 == -2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 1 || num2 == 2 || num2 == -1;
				}
			}
			else
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 3 || num2 == 2 || num2 == -2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 1 || num2 == 2 || num2 == 3 || num2 == -1 || num2 == -3;
				}
				if (this.FQBMEKNJHDH == 2)
				{
					return num2 == 1 || num2 == 2 || num2 == -2;
				}
			}
		}
		if (this.JKFJCMKMNLL == 1)
		{
			if (num == 3)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -1;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != -2;
				}
				if (this.FQBMEKNJHDH == 2)
				{
					return num2 != -3;
				}
			}
			else if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 != -1;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 != -2;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return num2 != -1;
			}
		}
		if (this.JKFJCMKMNLL == 2)
		{
			return num2 < 0;
		}
		if (this.JKFJCMKMNLL == 3)
		{
			if (num == 3)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -1 || num2 == -3;
				}
				if (this.FQBMEKNJHDH == 2)
				{
					return num2 == -2;
				}
			}
			else if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == -2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == -1;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return false;
			}
		}
		if (this.JKFJCMKMNLL == 4)
		{
			if (num == 3)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 3 || num2 == 2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 1 || num2 == 2 || num2 == 3;
				}
				if (this.FQBMEKNJHDH == 2)
				{
					return num2 == 1 || num2 == 2;
				}
			}
			else if (num == 2)
			{
				if (this.FQBMEKNJHDH == 0)
				{
					return num2 == 1 || num2 == 2;
				}
				if (this.FQBMEKNJHDH == 1)
				{
					return num2 == 1 || num2 == 2;
				}
			}
			else if (num == 1 && this.FQBMEKNJHDH == 0)
			{
				return num2 == 1;
			}
		}
		if (this.JKFJCMKMNLL == 5)
		{
			if (num == 3)
			{
				return num2 == 1 || num2 == 2 || num2 == 3;
			}
			if (num == 2)
			{
				return num2 == 1 || num2 == 2;
			}
			if (num == 1)
			{
				return num2 == 1;
			}
		}
		return false;
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x0010F638 File Offset: 0x0010D838
	private void BECOEIBFQCJ()
	{
		if (!CNCJKLNHQBH.MOGQNGEPCEO().KOCBHNQNOJO.PCJIQBHPNEP && (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitUser || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe || this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)108))
		{
			this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-15);
			this.NIKIEDCIOIP = false;
			this.CFGPMQEMDPC = false;
		}
		if (this.OIIMKHGKPPB != this.JBLCJCLQGCJ)
		{
			if ((this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectUser || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectUser || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe) && this.EKQKKPOIIBN.DIIHJCJOKMP > 1247f)
			{
				this.EKQKKPOIIBN.DIIHJCJOKMP = 760f;
			}
			if (this.JPHPMGBCLKC == null && (this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.HitFoe || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectField) && (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)(-33) || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusPlayer || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitUser))
			{
				if (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)72)
				{
					HHDNDIHQCJI.CLDLLKMCPDK().transform.position = HHDNDIHQCJI.DMOKBPOKHOQ().INHKCKDDLEK[6].position;
					HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().DBLIJKDNBLI[8]);
				}
				else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusUser)
				{
					HHDNDIHQCJI.MOGQNGEPCEO().transform.position = HHDNDIHQCJI.DMOKBPOKHOQ().INHKCKDDLEK[0].position;
				}
				else
				{
					HHDNDIHQCJI.BJJJQNQDMPE().transform.position = HHDNDIHQCJI.BJJJQNQDMPE().LCHMGLFBIFQ.position;
				}
			}
			this.NIKIEDCIOIP = true;
			this.CFGPMQEMDPC = true;
			this.ONOLCMHKBGC();
		}
		if (this.BNJEHBEEHMP > 949f && UnityEngine.Time.time > this.BNJEHBEEHMP + 31f)
		{
			this.JPHPMGBCLKC = null;
			this.BNJEHBEEHMP = 334f;
			if (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)(-111))
			{
				HHDNDIHQCJI.MFQIJCPBPDF().transform.position = HHDNDIHQCJI.QDGLKKGJDGI().INHKCKDDLEK[1].position;
				HHDNDIHQCJI.MOGQNGEPCEO().transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().DBLIJKDNBLI[0]);
			}
			else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle)
			{
				HHDNDIHQCJI.BJJJQNQDMPE().transform.position = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[6].position;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.BJJJQNQDMPE().QKIIGPGGLIN);
			}
			else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusUser)
			{
				HHDNDIHQCJI.MFQIJCPBPDF().transform.position = HHDNDIHQCJI.GDDGJKOLGIQ().LCHMGLFBIFQ.position;
				HHDNDIHQCJI.GDDGJKOLGIQ().transform.LookAt(HHDNDIHQCJI.DMOKBPOKHOQ().QKIIGPGGLIN);
			}
			return;
		}
		if (!(this.JPHPMGBCLKC != null))
		{
			if (this.CFGPMQEMDPC && (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)19 || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusPlayer || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField))
			{
				if (!this.NIKIEDCIOIP)
				{
					if (Input.GetMouseButton(1))
					{
						this.NIKIEDCIOIP = true;
						this.DNHJPCPLKME = UnityEngine.Time.time;
					}
				}
				else if (Input.GetMouseButton(0))
				{
					this.DNHJPCPLKME = UnityEngine.Time.time;
					HHDNDIHQCJI.QDGLKKGJDGI().transform.RotateAround(HHDNDIHQCJI.GDDGJKOLGIQ().QKIIGPGGLIN.position, Vector3.up, Input.GetAxis("allAdjacentFoes") * this.NNCDBKCKKFN);
				}
			}
			if (this.NIKIEDCIOIP && this.JBLCJCLQGCJ != (KGQECFKLKOP.NHDNHHGJDHG)(-30) && UnityEngine.Time.time > this.DNHJPCPLKME + 1229f)
			{
				this.NIKIEDCIOIP = false;
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitUser)
			{
				if (this.NIKIEDCIOIP)
				{
					if (this.NPMBJFDKDOL == Vector3.zero)
					{
						this.NPMBJFDKDOL = HHDNDIHQCJI.MFQIJCPBPDF().LCHMGLFBIFQ.position;
					}
					if (HHDNDIHQCJI.MFQIJCPBPDF().transform.position != this.NPMBJFDKDOL && !this.CFGPMQEMDPC)
					{
						HHDNDIHQCJI.GDDGJKOLGIQ().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.CLDLLKMCPDK().transform.position, HHDNDIHQCJI.MOGQNGEPCEO().LCHMGLFBIFQ.position, 470f * UnityEngine.Time.deltaTime);
						if (HHDNDIHQCJI.BJJJQNQDMPE().transform.position == HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position)
						{
							this.CFGPMQEMDPC = false;
						}
					}
				}
				else if (HHDNDIHQCJI.MOGQNGEPCEO().transform.position != HHDNDIHQCJI.MOGQNGEPCEO().LCHMGLFBIFQ.position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.MOGQNGEPCEO().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.CLDLLKMCPDK().transform.position, HHDNDIHQCJI.MFQIJCPBPDF().LCHMGLFBIFQ.position, this.CDDKBFLPKHQ * UnityEngine.Time.deltaTime);
					if (HHDNDIHQCJI.GDDGJKOLGIQ().transform.position == HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position)
					{
						this.CFGPMQEMDPC = false;
					}
				}
				else
				{
					HHDNDIHQCJI.QDGLKKGJDGI().transform.RotateAround(HHDNDIHQCJI.DMOKBPOKHOQ().QKIIGPGGLIN.position, Vector3.up, 245f * UnityEngine.Time.deltaTime);
				}
				HHDNDIHQCJI.GDDGJKOLGIQ().transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().QKIIGPGGLIN);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField)
			{
				if (this.NIKIEDCIOIP)
				{
					if (this.NPMBJFDKDOL == Vector3.zero)
					{
						this.NPMBJFDKDOL = HHDNDIHQCJI.MFQIJCPBPDF().INHKCKDDLEK[0].position;
					}
					if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != this.NPMBJFDKDOL && !this.CFGPMQEMDPC)
					{
						HHDNDIHQCJI.CLDLLKMCPDK().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.DMOKBPOKHOQ().transform.position, HHDNDIHQCJI.QDGLKKGJDGI().LCHMGLFBIFQ.position, 1610f * UnityEngine.Time.deltaTime);
						if (HHDNDIHQCJI.DMOKBPOKHOQ().transform.position == HHDNDIHQCJI.DMOKBPOKHOQ().LCHMGLFBIFQ.position)
						{
							this.CFGPMQEMDPC = false;
						}
					}
				}
				else if (HHDNDIHQCJI.MOGQNGEPCEO().transform.position != HHDNDIHQCJI.DMOKBPOKHOQ().INHKCKDDLEK[3].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.GDDGJKOLGIQ().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.CLDLLKMCPDK().transform.position, HHDNDIHQCJI.MOGQNGEPCEO().INHKCKDDLEK[1].position, this.CDDKBFLPKHQ * UnityEngine.Time.deltaTime);
					if (HHDNDIHQCJI.CLDLLKMCPDK().transform.position == HHDNDIHQCJI.CLDLLKMCPDK().INHKCKDDLEK[3].position)
					{
						this.CFGPMQEMDPC = true;
					}
				}
				else
				{
					HHDNDIHQCJI.CLDLLKMCPDK().transform.RotateAround(HHDNDIHQCJI.QDGLKKGJDGI().QKIIGPGGLIN.position, Vector3.up, 1502f * UnityEngine.Time.deltaTime);
				}
				HHDNDIHQCJI.MFQIJCPBPDF().transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN);
			}
			if (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)(-17))
			{
				HHDNDIHQCJI.DMOKBPOKHOQ().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.GDDGJKOLGIQ().transform.position, HHDNDIHQCJI.QDGLKKGJDGI().INHKCKDDLEK[8].position, 596f * UnityEngine.Time.deltaTime);
				HHDNDIHQCJI.DMOKBPOKHOQ().transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().DBLIJKDNBLI[5]);
			}
			if (this.JBLCJCLQGCJ == (KGQECFKLKOP.NHDNHHGJDHG)(-84))
			{
				this.NIKIEDCIOIP = true;
				if (this.NPMBJFDKDOL == Vector3.zero)
				{
					this.NPMBJFDKDOL = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[2].position;
				}
				if (HHDNDIHQCJI.QDGLKKGJDGI().transform.position != this.NPMBJFDKDOL & this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.MOGQNGEPCEO().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, this.NPMBJFDKDOL, 1945f * UnityEngine.Time.deltaTime);
				}
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == this.NPMBJFDKDOL)
				{
					this.CFGPMQEMDPC = false;
				}
				if (this.CFGPMQEMDPC)
				{
					this.NPMBJFDKDOL = HHDNDIHQCJI.BJJJQNQDMPE().transform.position;
				}
				HHDNDIHQCJI.QDGLKKGJDGI().transform.LookAt(HHDNDIHQCJI.MFQIJCPBPDF().DBLIJKDNBLI[3]);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectUser)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().DBLIJKDNBLI[0]);
				if (HHDNDIHQCJI.CLDLLKMCPDK().transform.position != HHDNDIHQCJI.GDDGJKOLGIQ().INHKCKDDLEK[1].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.MOGQNGEPCEO().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.CLDLLKMCPDK().transform.position, HHDNDIHQCJI.GDDGJKOLGIQ().INHKCKDDLEK[0].position, 856f * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectUser)
			{
				HHDNDIHQCJI.MOGQNGEPCEO().transform.LookAt(HHDNDIHQCJI.DMOKBPOKHOQ().DBLIJKDNBLI[1]);
				if (HHDNDIHQCJI.DMOKBPOKHOQ().transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[0].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.GDDGJKOLGIQ().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.BJJJQNQDMPE().transform.position, HHDNDIHQCJI.QDGLKKGJDGI().INHKCKDDLEK[0].position, 978f * UnityEngine.Time.deltaTime);
				}
			}
			this.POQOIMFLCHJ = false;
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitUser)
			{
				this.POQOIMFLCHJ = true;
				HHDNDIHQCJI.CLDLLKMCPDK().transform.LookAt(HHDNDIHQCJI.MOGQNGEPCEO().DBLIJKDNBLI[1]);
				if (HHDNDIHQCJI.CLDLLKMCPDK().transform.position != HHDNDIHQCJI.BJJJQNQDMPE().INHKCKDDLEK[1].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.MFQIJCPBPDF().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.GDDGJKOLGIQ().transform.position, HHDNDIHQCJI.MOGQNGEPCEO().INHKCKDDLEK[1].position, this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusPlayer)
			{
				this.POQOIMFLCHJ = false;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.CLDLLKMCPDK().DBLIJKDNBLI[0]);
				if (HHDNDIHQCJI.CLDLLKMCPDK().transform.position != HHDNDIHQCJI.GDDGJKOLGIQ().INHKCKDDLEK[0].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.MOGQNGEPCEO().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.GDDGJKOLGIQ().transform.position, HHDNDIHQCJI.QDGLKKGJDGI().INHKCKDDLEK[0].position, this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitFoe)
			{
				this.POQOIMFLCHJ = false;
				float num = 899f / (float)Screen.width * Input.mousePosition.x;
				float num2 = 1407f / (float)Screen.height * Input.mousePosition.y;
				if (Input.mousePosition.y < (float)(Screen.height / 6))
				{
					num2 = 1098f;
				}
				if (num2 > 426f)
				{
					num2 = 90f;
				}
				if (num > 1559f)
				{
					num = 1307f;
				}
				HHDNDIHQCJI.MFQIJCPBPDF().transform.position = Vector3.MoveTowards(HHDNDIHQCJI.BJJJQNQDMPE().transform.position, HHDNDIHQCJI.BJJJQNQDMPE().INHKCKDDLEK[2].position + new Vector3(1615f + num, num2, 1405f), this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				HHDNDIHQCJI.MFQIJCPBPDF().transform.LookAt(HHDNDIHQCJI.GDDGJKOLGIQ().DBLIJKDNBLI[2]);
			}
			this.OIIMKHGKPPB = this.JBLCJCLQGCJ;
			return;
		}
		if (this.JPHPMGBCLKC.position.x > 1752f)
		{
			return;
		}
		Vector3 position = this.JPHPMGBCLKC.position + new Vector3(1455f, 1603f, -this.JPHPMGBCLKC.parent.localPosition.z * 1834f);
		HHDNDIHQCJI.DMOKBPOKHOQ().transform.position = position;
		HHDNDIHQCJI.DMOKBPOKHOQ().transform.LookAt(this.JPHPMGBCLKC);
		HHDNDIHQCJI.QOQONHOOLNE.transform.eulerAngles += new Vector3(1509f, 1621f, 1000f);
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x000152EE File Offset: 0x000134EE
	public void HideMoves()
	{
		if (this.CIMHKDHFMBD.DIIHJCJOKMP == 1f)
		{
			this.KCFMOLKJNKK.enabled = true;
			this.KCFMOLKJNKK.PlayReverse();
		}
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x00110288 File Offset: 0x0010E488
	public void SendRunPacket()
	{
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 0f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		}
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		BattleRun dcgclgqcgdq = new BattleRun
		{
			RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.BattleBroadcast
		{
			RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
			Message = string.Concat(new string[]
			{
				"5|",
				CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH,
				"|0|",
				this.LBIJKQKELLF,
				"|",
				this.FQBMEKNJHDH.ToString()
			})
		}, false);
		this.FQBMEKNJHDH++;
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		this.QBLCPMDNNKC.enabled = false;
		this.DCBOJLEPBCJ.DIIHJCJOKMP = 0f;
		this.CMCMBFLGJHH[3].gameObject.SetActive(true);
		this.HDDJPQFJIIC();
		this.EFHDIMHHOOJ[0].GetComponent<OEJGFKMOQJG>().BFCEGHJQMCF.Hide();
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x001103EC File Offset: 0x0010E5EC
	public void QODBQMFFDEH()
	{
		for (int i = 1; i < 4; i++)
		{
			this.EFHDIMHHOOJ[i].gameObject.SetActive(true);
		}
		this.QBLCPMDNNKC.enabled = true;
		this.DCBOJLEPBCJ.DIIHJCJOKMP = 1785f;
		this.CMCMBFLGJHH[2].gameObject.SetActive(false);
		for (int j = 1; j < this.CMCMBFLGJHH.Length; j++)
		{
			this.CMCMBFLGJHH[j].enabled = true;
			this.CMCMBFLGJHH[j].GetComponent<BoxCollider>().enabled = true;
			this.CMCMBFLGJHH[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x0010C3F8 File Offset: 0x0010A5F8
	public IEnumerator KINIKBGLKLB(int QONOKDQLJNG, int OMLMGMLCCLG, int BDBBEMKFGPI)
	{
		if (QONOKDQLJNG == 0)
		{
			fdjoeicceog = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd.OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
			mffgqcjkpbd.EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD.ToString();
			mffgqcjkpbd.QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
			mffgqcjkpbd.PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
			fdjoeicceog2 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog2.KMNQBFKKNMB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog2.OQDOCCGPJDQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog2.EOMPMQNGIBD = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog2.FDGMQFNGKKL = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog2.QKNEIJQHGCB = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog2.BEQHNFFEHMQ = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog2.BKNFHNFFCHE = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog2.PLCBFLQBCQN = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog2.BCJGCNQJEGI = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog2.DCFKMOILHEC = this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd2 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd2.OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
			mffgqcjkpbd2.EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD.ToString();
			mffgqcjkpbd2.QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
			mffgqcjkpbd2.PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
			if (this.CLBGINEMIFE[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.EQFDHBJKGCQ[OMLMGMLCCLG],
					this.EQFDHBJKGCQ[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		else
		{
			fdjoeicceog3 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog3.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB;
			fdjoeicceog3.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ;
			fdjoeicceog3.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD;
			fdjoeicceog3.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL;
			fdjoeicceog3.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB;
			fdjoeicceog3.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ;
			fdjoeicceog3.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE;
			fdjoeicceog3.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN;
			fdjoeicceog3.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI;
			fdjoeicceog3.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC;
			mffgqcjkpbd3 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd3.OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
			mffgqcjkpbd3.EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD.ToString();
			mffgqcjkpbd3.QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
			mffgqcjkpbd3.PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
			fdjoeicceog4 = new DBQLOHBBJMG.FDJOEICCEOG();
			fdjoeicceog4.KMNQBFKKNMB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB;
			fdjoeicceog4.OQDOCCGPJDQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ;
			fdjoeicceog4.EOMPMQNGIBD = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD;
			fdjoeicceog4.FDGMQFNGKKL = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL;
			fdjoeicceog4.QKNEIJQHGCB = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB;
			fdjoeicceog4.BEQHNFFEHMQ = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ;
			fdjoeicceog4.BKNFHNFFCHE = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE;
			fdjoeicceog4.PLCBFLQBCQN = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN;
			fdjoeicceog4.BCJGCNQJEGI = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI;
			fdjoeicceog4.DCFKMOILHEC = this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC;
			mffgqcjkpbd4 = new OELLFMKIMFH.MFFGQCJKPBD();
			mffgqcjkpbd4.OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
			mffgqcjkpbd4.EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD.ToString();
			mffgqcjkpbd4.QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
			mffgqcjkpbd4.PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
			if (this.JMCMGILPGGI[BDBBEMKFGPI].HHKJGOPMMQL.DBPKNCDGGEP > 0)
			{
				yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
				{
					this.FGMEONKLKFG[OMLMGMLCCLG],
					this.FGMEONKLKFG[BDBBEMKFGPI]
				}, true));
			}
			else
			{
				yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], true, false, false, true, true));
			}
		}
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		dpdqidjpenf = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		cmgnloffglq = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		dpdqidjpenf2 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		cmgnloffglq2 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf2, cmgnloffglq2, true, fdjoeicceog2.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf, cmgnloffglq, true, fdjoeicceog.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[OMLMGMLCCLG].BQLIIQIIMDH(false, (fdjoeicceog2.BCJGCNQJEGI != 0) ? fdjoeicceog2.BCJGCNQJEGI : fdjoeicceog2.BEQHNFFEHMQ, fdjoeicceog2.BKNFHNFFCHE, null, null, null, mffgqcjkpbd2, fdjoeicceog2.KMNQBFKKNMB, fdjoeicceog2.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.CLBGINEMIFE[BDBBEMKFGPI].BQLIIQIIMDH(false, (fdjoeicceog.BCJGCNQJEGI != 0) ? fdjoeicceog.BCJGCNQJEGI : fdjoeicceog.BEQHNFFEHMQ, fdjoeicceog.BKNFHNFFCHE, null, null, null, mffgqcjkpbd, fdjoeicceog.KMNQBFKKNMB, fdjoeicceog.BEQHNFFEHMQ == 132));
		return 1;
		this.CLBGINEMIFE[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog2.PLCBFLQBCQN);
		this.CLBGINEMIFE[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog.PLCBFLQBCQN);
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog.DCFKMOILHEC;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog2.KMNQBFKKNMB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog2.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog2.EOMPMQNGIBD;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog2.FDGMQFNGKKL;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog2.QKNEIJQHGCB;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog2.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog2.BKNFHNFFCHE;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog2.PLCBFLQBCQN;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog2.BCJGCNQJEGI;
		this.HJKOHEHLJGL.CBDCGKPHPJO[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog2.DCFKMOILHEC;
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0 || fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_107C;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.EQFDHBJKGCQ[OMLMGMLCCLG],
			this.EQFDHBJKGCQ[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_107C:
		if (fdjoeicceog2.BEQHNFFEHMQ <= 0)
		{
			goto IL_10D5;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_10D5:
		if (fdjoeicceog.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.EQFDHBJKGCQ[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], true, false, false, true, true));
		return 1;
		dpdqidjpenf3 = this.IDGIHDINDOB(QONOKDQLJNG, OMLMGMLCCLG);
		cmgnloffglq3 = this.CGIPHGNPFGI(QONOKDQLJNG, OMLMGMLCCLG);
		dpdqidjpenf4 = this.IDGIHDINDOB(QONOKDQLJNG, BDBBEMKFGPI);
		cmgnloffglq4 = this.CGIPHGNPFGI(QONOKDQLJNG, BDBBEMKFGPI);
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, OMLMGMLCCLG, dpdqidjpenf4, cmgnloffglq4, true, fdjoeicceog4.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(QONOKDQLJNG, BDBBEMKFGPI, dpdqidjpenf3, cmgnloffglq3, true, fdjoeicceog3.BEQHNFFEHMQ));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[OMLMGMLCCLG].BQLIIQIIMDH(true, (fdjoeicceog4.BCJGCNQJEGI != 0) ? fdjoeicceog4.BCJGCNQJEGI : fdjoeicceog4.BEQHNFFEHMQ, fdjoeicceog4.BKNFHNFFCHE, null, null, null, mffgqcjkpbd4, fdjoeicceog4.KMNQBFKKNMB, fdjoeicceog4.BEQHNFFEHMQ == 132));
		return 1;
		yield return base.StartCoroutine(this.JMCMGILPGGI[BDBBEMKFGPI].BQLIIQIIMDH(true, (fdjoeicceog3.BCJGCNQJEGI != 0) ? fdjoeicceog3.BCJGCNQJEGI : fdjoeicceog3.BEQHNFFEHMQ, fdjoeicceog3.BKNFHNFFCHE, null, null, null, mffgqcjkpbd3, fdjoeicceog3.KMNQBFKKNMB, fdjoeicceog3.BEQHNFFEHMQ == 132));
		return 1;
		this.JMCMGILPGGI[OMLMGMLCCLG].CDKDOMQGHBE(fdjoeicceog4.PLCBFLQBCQN);
		this.JMCMGILPGGI[BDBBEMKFGPI].CDKDOMQGHBE(fdjoeicceog3.PLCBFLQBCQN);
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].KMNQBFKKNMB = fdjoeicceog3.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].OQDOCCGPJDQ = fdjoeicceog3.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].EOMPMQNGIBD = fdjoeicceog3.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].FDGMQFNGKKL = fdjoeicceog3.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].QKNEIJQHGCB = fdjoeicceog3.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BEQHNFFEHMQ = fdjoeicceog3.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BKNFHNFFCHE = fdjoeicceog3.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].PLCBFLQBCQN = fdjoeicceog3.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].BCJGCNQJEGI = fdjoeicceog3.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[BDBBEMKFGPI].DCFKMOILHEC = fdjoeicceog3.DCFKMOILHEC;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].KMNQBFKKNMB = fdjoeicceog4.KMNQBFKKNMB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].OQDOCCGPJDQ = fdjoeicceog4.OQDOCCGPJDQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].EOMPMQNGIBD = fdjoeicceog4.EOMPMQNGIBD;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].FDGMQFNGKKL = fdjoeicceog4.FDGMQFNGKKL;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].QKNEIJQHGCB = fdjoeicceog4.QKNEIJQHGCB;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BEQHNFFEHMQ = fdjoeicceog4.BEQHNFFEHMQ;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BKNFHNFFCHE = fdjoeicceog4.BKNFHNFFCHE;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].PLCBFLQBCQN = fdjoeicceog4.PLCBFLQBCQN;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].BCJGCNQJEGI = fdjoeicceog4.BCJGCNQJEGI;
		this.HJKOHEHLJGL.JELLELLGLLB[OMLMGMLCCLG].DCFKMOILHEC = fdjoeicceog4.DCFKMOILHEC;
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0 || fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_179F;
		}
		yield return base.StartCoroutine(this.KDQKGGOLJJB(new GameObject[]
		{
			this.FGMEONKLKFG[OMLMGMLCCLG],
			this.FGMEONKLKFG[BDBBEMKFGPI]
		}, false));
		return 1;
		IL_179F:
		if (fdjoeicceog4.BEQHNFFEHMQ <= 0)
		{
			goto IL_17F2;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[OMLMGMLCCLG], false, false, false, true, false));
		return 1;
		IL_17F2:
		if (fdjoeicceog3.BEQHNFFEHMQ <= 0)
		{
			goto IL_1845;
		}
		yield return base.StartCoroutine(this.QPNCHCMLQCG(this.FGMEONKLKFG[BDBBEMKFGPI], false, false, false, true, false));
		return 1;
		IL_1845:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BC6 RID: 11206 RVA: 0x0011048C File Offset: 0x0010E68C
	public IEnumerator BKOHILBIPLQ(int QONOKDQLJNG, int CIQFCJGQEMH, int DPDQIDJPENF, int CMGNLOFFGLQ, bool FJNGJLNLLDP = false, int IKIJBQLMKJO = 0)
	{
		float num = 211f;
		int num2 = (int)((double)num / ((double)CMGNLOFFGLQ / (double)DPDQIDJPENF * 100.0) * 100.0 - 1.0);
		if ((float)num2 > num)
		{
			num2 = (int)num;
		}
		if (num2 <= 2)
		{
			num2 = 2;
		}
		if (QONOKDQLJNG == 1)
		{
			CIQFCJGQEMH += 3;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP = DPDQIDJPENF;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].OJMOOLNKQEP = CMGNLOFFGLQ;
		if (!FJNGJLNLLDP)
		{
			if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = Mathf.Min(211, this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD + 1);
			}
			JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL, 0.5f, num2, 0f);
			yield return new WaitForSeconds(0.5f);
			return 1;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO != null && DPDQIDJPENF > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO);
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD = num2;
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null)
		{
			if (DPDQIDJPENF == 0)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
			}
			else
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
			}
		}
		if (IKIJBQLMKJO <= 0)
		{
			yield break;
		}
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			yield break;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null))
		{
			yield break;
		}
		if (EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
			yield break;
		}
		yield break;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO = JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG, 0.5f, Mathf.Max(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD - 1, 2), 0.75f);
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO.AddOnFinished(new EventDelegate.LKPMKQMCHFH(this.FFEEMHBOBQJ[CIQFCJGQEMH].INNQKLOKBFL));
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null))
		{
			goto IL_4BA;
		}
		if (DPDQIDJPENF != 0)
		{
			goto IL_472;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
		goto IL_4BA;
		IL_472:
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
		IL_4BA:
		if (IKIJBQLMKJO <= 0 || !(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null) || !EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
		IL_53B:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x00110550 File Offset: 0x0010E750
	private void NDQBKDLIQIO()
	{
		if (!CNCJKLNHQBH.QOQONHOOLNE.KOCBHNQNOJO.PCJIQBHPNEP && (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2 || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Default))
		{
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Still;
			this.NIKIEDCIOIP = true;
			this.CFGPMQEMDPC = false;
		}
		if (this.OIIMKHGKPPB != this.JBLCJCLQGCJ)
		{
			if ((this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectUser || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.SelectField) && this.EKQKKPOIIBN.DIIHJCJOKMP > 0f)
			{
				this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
			}
			if (this.JPHPMGBCLKC == null && (this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.HitUser || this.OIIMKHGKPPB == KGQECFKLKOP.NHDNHHGJDHG.HitFoe) && (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Default || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2))
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Default)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[2].position;
					HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[2]);
				}
				else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position;
				}
				else
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position;
				}
			}
			this.NIKIEDCIOIP = false;
			this.CFGPMQEMDPC = false;
			this.EHOELFJHQBC();
		}
		if (this.BNJEHBEEHMP > 0f && UnityEngine.Time.time > this.BNJEHBEEHMP + 1f)
		{
			this.JPHPMGBCLKC = null;
			this.BNJEHBEEHMP = 0f;
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Default)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[2].position;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[2]);
			}
			else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN);
			}
			else if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.position = HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN);
			}
			return;
		}
		if (!(this.JPHPMGBCLKC != null))
		{
			if (this.CFGPMQEMDPC && (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Still || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle || this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2))
			{
				if (!this.NIKIEDCIOIP)
				{
					if (Input.GetMouseButton(1))
					{
						this.NIKIEDCIOIP = true;
						this.DNHJPCPLKME = UnityEngine.Time.time;
					}
				}
				else if (Input.GetMouseButton(1))
				{
					this.DNHJPCPLKME = UnityEngine.Time.time;
					HHDNDIHQCJI.QOQONHOOLNE.transform.RotateAround(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN.position, Vector3.up, Input.GetAxis("Mouse X") * this.NNCDBKCKKFN);
				}
			}
			if (this.NIKIEDCIOIP && this.JBLCJCLQGCJ != KGQECFKLKOP.NHDNHHGJDHG.Still && UnityEngine.Time.time > this.DNHJPCPLKME + 5f)
			{
				this.NIKIEDCIOIP = false;
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle)
			{
				if (this.NIKIEDCIOIP)
				{
					if (this.NPMBJFDKDOL == Vector3.zero)
					{
						this.NPMBJFDKDOL = HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position;
					}
					if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != this.NPMBJFDKDOL && !this.CFGPMQEMDPC)
					{
						HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position, 4f * UnityEngine.Time.deltaTime);
						if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position)
						{
							this.CFGPMQEMDPC = true;
						}
					}
				}
				else if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position, this.CDDKBFLPKHQ * UnityEngine.Time.deltaTime);
					if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position)
					{
						this.CFGPMQEMDPC = true;
					}
				}
				else
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.RotateAround(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN.position, Vector3.up, 10f * UnityEngine.Time.deltaTime);
				}
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2)
			{
				if (this.NIKIEDCIOIP)
				{
					if (this.NPMBJFDKDOL == Vector3.zero)
					{
						this.NPMBJFDKDOL = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position;
					}
					if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != this.NPMBJFDKDOL && !this.CFGPMQEMDPC)
					{
						HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position, 8f * UnityEngine.Time.deltaTime);
						if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == HHDNDIHQCJI.QOQONHOOLNE.LCHMGLFBIFQ.position)
						{
							this.CFGPMQEMDPC = true;
						}
					}
				}
				else if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position, this.CDDKBFLPKHQ * UnityEngine.Time.deltaTime);
					if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[3].position)
					{
						this.CFGPMQEMDPC = true;
					}
				}
				else
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.RotateAround(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN.position, Vector3.up, -5f * UnityEngine.Time.deltaTime);
				}
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.QKIIGPGGLIN);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Default)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[2].position, 3f * UnityEngine.Time.deltaTime);
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[2]);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Still)
			{
				this.NIKIEDCIOIP = true;
				if (this.NPMBJFDKDOL == Vector3.zero)
				{
					this.NPMBJFDKDOL = HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[4].position;
				}
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != this.NPMBJFDKDOL & !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, this.NPMBJFDKDOL, 6f * UnityEngine.Time.deltaTime);
				}
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position == this.NPMBJFDKDOL)
				{
					this.CFGPMQEMDPC = true;
				}
				if (this.CFGPMQEMDPC)
				{
					this.NPMBJFDKDOL = HHDNDIHQCJI.QOQONHOOLNE.transform.position;
				}
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[2]);
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitUser)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[1]);
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[1].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[1].position, 6f * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitFoe)
			{
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[0]);
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[0].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[0].position, 6f * UnityEngine.Time.deltaTime);
				}
			}
			this.POQOIMFLCHJ = false;
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe)
			{
				this.POQOIMFLCHJ = true;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[0]);
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[0].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[0].position, this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectUser)
			{
				this.POQOIMFLCHJ = true;
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[1]);
				if (HHDNDIHQCJI.QOQONHOOLNE.transform.position != HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[1].position && !this.CFGPMQEMDPC)
				{
					HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[1].position, this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				}
			}
			if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField)
			{
				this.POQOIMFLCHJ = true;
				float num = 9f / (float)Screen.width * Input.mousePosition.x;
				float num2 = 4f / (float)Screen.height * Input.mousePosition.y;
				if (Input.mousePosition.y < (float)(Screen.height / 2))
				{
					num2 = 0f;
				}
				if (num2 > 4f)
				{
					num2 = 4f;
				}
				if (num > 9f)
				{
					num = 9f;
				}
				HHDNDIHQCJI.QOQONHOOLNE.transform.position = Vector3.MoveTowards(HHDNDIHQCJI.QOQONHOOLNE.transform.position, HHDNDIHQCJI.QOQONHOOLNE.INHKCKDDLEK[2].position + new Vector3(-4.5f + num, num2, 0f), this.FNNPBQBOOQH * UnityEngine.Time.deltaTime);
				HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(HHDNDIHQCJI.QOQONHOOLNE.DBLIJKDNBLI[2]);
			}
			this.OIIMKHGKPPB = this.JBLCJCLQGCJ;
			return;
		}
		if (this.JPHPMGBCLKC.position.x > -15f)
		{
			return;
		}
		Vector3 position = this.JPHPMGBCLKC.position + new Vector3(0f, 3f, -this.JPHPMGBCLKC.parent.localPosition.z * 1.2f);
		HHDNDIHQCJI.QOQONHOOLNE.transform.position = position;
		HHDNDIHQCJI.QOQONHOOLNE.transform.LookAt(this.JPHPMGBCLKC);
		HHDNDIHQCJI.QOQONHOOLNE.transform.eulerAngles += new Vector3(-10f, 0f, 0f);
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x0011048C File Offset: 0x0010E68C
	public IEnumerator LMFFKPCINDQ(int QONOKDQLJNG, int CIQFCJGQEMH, int DPDQIDJPENF, int CMGNLOFFGLQ, bool FJNGJLNLLDP = false, int IKIJBQLMKJO = 0)
	{
		num = 211f;
		num2 = (int)((double)num / ((double)CMGNLOFFGLQ / (double)DPDQIDJPENF * 100.0) * 100.0 - 1.0);
		if ((float)num2 > num)
		{
			num2 = (int)num;
		}
		if (num2 <= 2)
		{
			num2 = 2;
		}
		if (QONOKDQLJNG == 1)
		{
			CIQFCJGQEMH += 3;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP = DPDQIDJPENF;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].OJMOOLNKQEP = CMGNLOFFGLQ;
		if (!FJNGJLNLLDP)
		{
			if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = Mathf.Min(211, this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD + 1);
			}
			JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL, 0.5f, num2, 0f);
			yield return new WaitForSeconds(0.5f);
			return 1;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO != null && DPDQIDJPENF > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO);
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD = num2;
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null)
		{
			if (DPDQIDJPENF == 0)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
			}
			else
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
			}
		}
		if (IKIJBQLMKJO <= 0)
		{
			yield break;
		}
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			yield break;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null))
		{
			yield break;
		}
		if (EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
			yield break;
		}
		yield break;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO = JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG, 0.5f, Mathf.Max(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD - 1, 2), 0.75f);
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO.AddOnFinished(new EventDelegate.LKPMKQMCHFH(this.FFEEMHBOBQJ[CIQFCJGQEMH].INNQKLOKBFL));
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null))
		{
			goto IL_4BA;
		}
		if (DPDQIDJPENF != 0)
		{
			goto IL_472;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
		goto IL_4BA;
		IL_472:
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
		IL_4BA:
		if (IKIJBQLMKJO <= 0 || !(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null) || !EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
		IL_53B:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x00015319 File Offset: 0x00013519
	private void LateUpdate()
	{
		if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC())
		{
			QOHCEBMQKMB.QOQONHOOLNE.Hide();
		}
	}

	// Token: 0x06002BCB RID: 11211 RVA: 0x001111A0 File Offset: 0x0010F3A0
	private IEnumerator KCNOIDHMLLG(GameObject[] LQBFBGBNHHC)
	{
		int num = 0;
		IL_195:
		if (num >= 3)
		{
			yield return null;
		}
		else
		{
			if (num < this.EQFDHBJKGCQ.Length)
			{
				BattleAnimator.AnimationData animationData = new BattleAnimator.AnimationData();
				animationData.target = LQBFBGBNHHC[num];
				animationData.battleHandler = base.gameObject;
				yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, 4, true));
				return 1;
			}
			IL_24A:
			if (num < this.FGMEONKLKFG.Length)
			{
				BattleAnimator.AnimationData animationData = new BattleAnimator.AnimationData();
				animationData.target = LQBFBGBNHHC[num + 3];
				animationData.battleHandler = base.gameObject;
				yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, 3, true));
				return 1;
			}
			IL_2D4:
			yield return new WaitForSeconds(0.2f);
		}
		return 1;
		Animation componentInChildren = this.EQFDHBJKGCQ[num].GetComponentInChildren<Animation>();
		if (!(componentInChildren != null) || this.CLBGINEMIFE[num].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			goto IL_24A;
		}
		componentInChildren.Stop();
		if (!(componentInChildren.GetClip("17") != null))
		{
			goto IL_24A;
		}
		yield return componentInChildren.KFKMPKNNMKK("17");
		return 1;
		Animation componentInChildren2 = this.FGMEONKLKFG[num].GetComponentInChildren<Animation>();
		if (!(componentInChildren2 != null) || this.JMCMGILPGGI[num].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			goto IL_2D4;
		}
		componentInChildren2.Stop();
		if (!(componentInChildren2.GetClip("17") != null))
		{
			goto IL_2D4;
		}
		yield return componentInChildren2.KFKMPKNNMKK("17");
		return 1;
		num++;
		goto IL_195;
		yield break;
	}

	// Token: 0x06002BCC RID: 11212 RVA: 0x001111C4 File Offset: 0x0010F3C4
	public void NIFFMBHOLMD(int DBPKNCDGGEP, int JILENMCJCHF, bool FEMFKKDQJPK = true, int FDOCLPKPDDH = 0, bool KHLKOEQBDIE = false)
	{
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			PSXAPI.Request.BattleItem dcgclgqcgdq;
			if (!KHLKOEQBDIE)
			{
				int num = 0;
				for (int i = 1; i < this.IGOGQDBOGQL.pokemon.Length; i++)
				{
					if (num == JILENMCJCHF - 1 && this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num = i + 0;
						IL_A4:
						dcgclgqcgdq = new PSXAPI.Request.BattleItem
						{
							Item = DBPKNCDGGEP,
							RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
							Target = num,
							TargetMove = FDOCLPKPDDH,
							Position = this.FQBMEKNJHDH + 1
						};
						goto IL_120;
					}
					if (this.IGOGQDBOGQL.pokemon[i].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						num++;
					}
				}
				goto IL_A4;
			}
			dcgclgqcgdq = new PSXAPI.Request.BattleItem
			{
				Item = DBPKNCDGGEP,
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				Target = JILENMCJCHF,
				TargetMove = FDOCLPKPDDH,
				Position = this.FQBMEKNJHDH + 1
			};
			IL_120:
			if (FEMFKKDQJPK)
			{
				GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
				PSXAPI.Request.BattleBroadcast battleBroadcast = new PSXAPI.Request.BattleBroadcast();
				battleBroadcast.RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC;
				PSXAPI.Request.BattleBroadcast battleBroadcast2 = battleBroadcast;
				string[] array = new string[8];
				array[0] = "adjacentAllyOrSelf";
				array[1] = CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
				array[2] = "Blank";
				array[4] = JILENMCJCHF.ToString();
				array[2] = "Invite to Party";
				array[7] = this.LBIJKQKELLF;
				array[0] = "Spectator";
				array[3] = this.FQBMEKNJHDH.ToString();
				battleBroadcast2.Message = string.Concat(array);
				qoqonhoolne.HLIOFPONLLE(battleBroadcast, false);
			}
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			this.NBCDLHGQBJM = false;
			this.HideMoves();
			this.HideAttackButtons();
			this.OHDIOJQJJNJ.enabled = false;
			this.MNJBJJNEMPC.enabled = false;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 925f)
			{
				this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 171f;
			}
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 336f)
			{
				this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 484f;
			}
		}
	}

	// Token: 0x06002BCD RID: 11213 RVA: 0x00111418 File Offset: 0x0010F618
	private IEnumerator DOODNDFBFCL(GameObject[] DICOBJOEPQJ, GameObject[] MJILJDHCCGM, bool CHGQGQOEEQC)
	{
		yield return base.StartCoroutine(this.KBHNQJFMBIP(this.JKCHKLNCCLE));
		return 1;
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Idle2;
		yield break;
	}

	// Token: 0x06002BCE RID: 11214 RVA: 0x00015331 File Offset: 0x00013531
	public void CDHGKQLJQND()
	{
		this.FQBMEKNJHDH = 0;
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06002BCF RID: 11215 RVA: 0x0001536E File Offset: 0x0001356E
	public void JENCFKOGOKF()
	{
		this.FQBMEKNJHDH = 1;
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH += 0;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x00111434 File Offset: 0x0010F634
	public IEnumerator GCIMPPLHKNK(GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB, int KIGOFEMDODM = 2, string HJQLPPKBJPM = "")
	{
		if (KIGOFEMDODM == 2)
		{
			if (PBHPQFLMQDB != null && PBHPQFLMQDB.GetComponentInChildren<Animation>() != null)
			{
				PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("8", QueueMode.CompleteOthers);
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
				yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
			}
			else
			{
				yield return new WaitForSeconds(0.5f);
			}
		}
		else if (KIGOFEMDODM == 3)
		{
			PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
			if (PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("13") != null && PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("14") != null)
			{
				if (PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("13").length == PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("14").length)
				{
					PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("12", QueueMode.CompleteOthers);
				}
				else
				{
					PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("13", QueueMode.CompleteOthers);
				}
			}
			else
			{
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("12", QueueMode.CompleteOthers);
			}
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
			yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
		}
		else if (KIGOFEMDODM == 4)
		{
			PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("9", QueueMode.CompleteOthers);
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
			yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
		}
		else
		{
			yield return null;
		}
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield break;
	}

	// Token: 0x06002BD1 RID: 11217 RVA: 0x000152CC File Offset: 0x000134CC
	public void EBMNJHJFGHK()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = this;
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x0011146C File Offset: 0x0010F66C
	public void IEBDBIOKOLC(GameObject DLHBFEIDHGM)
	{
		if (this.JKFJCMKMNLL == 0)
		{
			for (int i = 0; i < this.FGMEONKLKFG.Length; i++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField && this.FGMEONKLKFG[i] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[i].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			for (int j = 0; j < this.EQFDHBJKGCQ.Length; j++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField && this.EQFDHBJKGCQ[j] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[j].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 1)
		{
			for (int k = 0; k < this.FGMEONKLKFG.Length; k++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField && this.FGMEONKLKFG[k] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[k].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			for (int l = 0; l < this.EQFDHBJKGCQ.Length; l++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectField && this.EQFDHBJKGCQ[l] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[l].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 2)
		{
			for (int m = 0; m < this.EQFDHBJKGCQ.Length; m++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectUser && this.EQFDHBJKGCQ[m] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[m].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 3)
		{
			for (int n = 0; n < this.EQFDHBJKGCQ.Length; n++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectUser && this.EQFDHBJKGCQ[n] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[n].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 4)
		{
			for (int num = 0; num < this.FGMEONKLKFG.Length; num++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe && this.FGMEONKLKFG[num] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[num].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 5)
		{
			for (int num2 = 0; num2 < this.FGMEONKLKFG.Length; num2++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe && this.FGMEONKLKFG[num2] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
				{
					this.CLIEFPPGCHK(this.PQGHKEFEGFQ, Convert.ToInt32(this.FGMEONKLKFG[num2].name), false, 0, true);
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.BattleBroadcast
					{
						RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
						Message = string.Concat(new string[]
						{
							"2|",
							CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH,
							"|",
							this.FGMEONKLKFG[num2].name,
							"|",
							this.LBIJKQKELLF,
							"|",
							this.FQBMEKNJHDH.ToString()
						})
					}, false);
					this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x001118A4 File Offset: 0x0010FAA4
	public void MMCCHNLQEDM(string ILBCCCBJNCL, int ECNIJCPBPIG)
	{
		this.LEFGGJINGPF();
		this.JNQEJDCLKMM = ECNIJCPBPIG;
		this.NPNFPOCIDKD = ILBCCCBJNCL;
		this.QKJNHCOMEGH = 0;
		switch (ILBCCCBJNCL)
		{
		case "battlebag":
		case "Left":
			this.QKJNHCOMEGH = 0;
			this.FQQLENFQBFH();
			return;
		case "General":
			if (this.EQFDHBJKGCQ.Length == 1 && this.FGMEONKLKFG.Length == 0)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
			this.JKFJCMKMNLL = 0;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 777f;
			return;

			if (this.EQFDHBJKGCQ.Length == 0 && this.FGMEONKLKFG.Length == 1)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectField;
			this.JKFJCMKMNLL = 0;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 706f;
			return;
		case "#,##0":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
			this.JKFJCMKMNLL = 2;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1824f;
			return;
		case "magmastorm":
			if (this.EQFDHBJKGCQ.Length == 0 && this.FGMEONKLKFG.Length == 0)
			{
				this.FQQLENFQBFH();
				return;
			}
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitUser;
			this.JKFJCMKMNLL = 6;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 137f;
			return;
		case "Player/Hair":
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Idle;
			this.JKFJCMKMNLL = 7;
			this.EKQKKPOIIBN.DIIHJCJOKMP = 9f;
			return;
		case "x":
			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;
		case "0":
		case "Analytic":
			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;

			this.FQQLENFQBFH();
			return;
		}
		this.FQQLENFQBFH();
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x000152CC File Offset: 0x000134CC
	private void Awake()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = this;
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x00111B70 File Offset: 0x0010FD70
	public void KDMJOFNLBMB(bool IILIBDEBEIN = false)
	{
		this.NBCDLHGQBJM = false;
		if (IILIBDEBEIN)
		{
			this.HDDJPQFJIIC();
		}
		else
		{
			this.FQBMEKNJHDH++;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH += 0;
			}
			this.HDDJPQFJIIC();
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x00015242 File Offset: 0x00013442
	public static OGJJKKQPNMK QOQONHOOLNE
	{
		get
		{
			return OGJJKKQPNMK.HBFFCJHOCPE;
		}
	}

	// Token: 0x06002BD7 RID: 11223 RVA: 0x00111BD4 File Offset: 0x0010FDD4
	public void BDHDICQKQPN(int HFBPHOGKGLK)
	{
		this.PQGHKEFEGFQ = HFBPHOGKGLK;
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectFoe;
		this.JKFJCMKMNLL = 5;
		this.EKQKKPOIIBN.DIIHJCJOKMP = 1f;
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 0f)
		{
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x000152D4 File Offset: 0x000134D4
	private void MOPBKMJFKHF()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = null;
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x00002300 File Offset: 0x00000500
	public void MOPPIIOIIDM()
	{
	}

	// Token: 0x06002BDA RID: 11226 RVA: 0x00111C34 File Offset: 0x0010FE34
	public void OpenCloseAttacks()
	{
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 0f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 0f;
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		}
		this.EHOELFJHQBC();
		if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 0f)
		{
			this.CMCMBFLGJHH[3].gameObject.SetActive(false);
			this.QBLCPMDNNKC.enabled = true;
			this.QBLCPMDNNKC.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 0;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.MNJBJJNEMPC.enabled = true;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1f)
			{
				this.KCFMOLKJNKK.enabled = true;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1f)
		{
			this.CMCMBFLGJHH[3].gameObject.SetActive(true);
			this.QBLCPMDNNKC.enabled = true;
			this.QBLCPMDNNKC.PlayReverse();
		}
	}

	// Token: 0x06002BDB RID: 11227 RVA: 0x000152D4 File Offset: 0x000134D4
	private void GCPCLEJDGLN()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = null;
	}

	// Token: 0x06002BDC RID: 11228 RVA: 0x000153AB File Offset: 0x000135AB
	public void DGQNLBDBIGG(int HFBPHOGKGLK, KGQECFKLKOP.IJHPPMDDKIE CIQFCJGQEMH)
	{
		this.OpenClosePokemonWindow(true);
		this.BELFMMFDEJD = HFBPHOGKGLK;
		this.FMHBCMCPEOD = CIQFCJGQEMH;
	}

	// Token: 0x06002BDD RID: 11229 RVA: 0x00111D94 File Offset: 0x0010FF94
	private void ONOLCMHKBGC()
	{
		if (!this.LFOFQPMJFHF)
		{
			return;
		}
		if (this.JBLCJCLQGCJ != KGQECFKLKOP.NHDNHHGJDHG.FocusUser)
		{
			for (int i = 0; i < this.EQFDHBJKGCQ.Length; i++)
			{
				if (this.FFEEMHBOBQJ[i].KBICCNPFFGQ != null)
				{
					this.FFEEMHBOBQJ[i].KBICCNPFFGQ.enabled = true;
					this.FFEEMHBOBQJ[i].GNLJOOJDLGJ.NONQDHBCIIN(Color.white);
				}
			}
		}
		if (this.JBLCJCLQGCJ != KGQECFKLKOP.NHDNHHGJDHG.SelectUser)
		{
			for (int j = 1; j < this.FGMEONKLKFG.Length; j++)
			{
				if (this.FFEEMHBOBQJ[j + 7].KBICCNPFFGQ != null)
				{
					this.FFEEMHBOBQJ[j + 0].KBICCNPFFGQ.enabled = false;
					this.FFEEMHBOBQJ[j + 1].GNLJOOJDLGJ.NONQDHBCIIN(Color.white);
				}
			}
		}
		GameObject[] nbqmlbdnfnp = HHDNDIHQCJI.BJJJQNQDMPE().NBQMLBDNFNP;
		for (int k = 1; k < nbqmlbdnfnp.Length; k += 0)
		{
			GameObject gameObject = nbqmlbdnfnp[k];
			gameObject.SetActive(true);
		}
		this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 558f;
		KDGHILICJGN.JPMOJGDNKNC().gameObject.SetActive(false);
	}

	// Token: 0x06002BDE RID: 11230 RVA: 0x0010BB08 File Offset: 0x00109D08
	public IEnumerator QIHKGCQFCBJ(GameObject ILBCCCBJNCL, int FDOCMQQQEGP = 0)
	{
		componentInChildren = ILBCCCBJNCL.GetComponentInChildren<Animation>();
		componentInChildren.Stop();
		seconds = 1f;
		if (componentInChildren.GetClip("14") != null)
		{
			seconds = componentInChildren.GetClip("14").length;
			componentInChildren.PlayQueued("14", QueueMode.CompleteOthers);
		}
		componentInChildren.PlayQueued("0", QueueMode.CompleteOthers);
		transform = ILBCCCBJNCL.transform.KQQJCMQCFMN("Head");
		if (transform == null)
		{
			transform = ILBCCCBJNCL.transform;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.OCKBJGMKPJB[FDOCMQQQEGP], transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
		yield return new WaitForSeconds(seconds);
		return 1;
		yield break;
	}

	// Token: 0x06002BDF RID: 11231 RVA: 0x000153C2 File Offset: 0x000135C2
	public int CGIPHGNPFGI(int QONOKDQLJNG, int CIQFCJGQEMH)
	{
		if (QONOKDQLJNG == 1)
		{
			CIQFCJGQEMH += 3;
		}
		return this.FFEEMHBOBQJ[CIQFCJGQEMH].OJMOOLNKQEP;
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x00111EB4 File Offset: 0x001100B4
	public void LCQIMKJLJFF(int DBPKNCDGGEP)
	{
		bool flag = false;
		bool flag2 = false;
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.NEBPMMPMQBD)
			{
				flag2 = true;
				this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.NEBPMMPMQBD = false;
				this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.JHCFQOPLHQE = true;
				int num = 0;
				for (int i = 0; i < this.CLBGINEMIFE.Length; i++)
				{
					if (this.CLBGINEMIFE[i] != null && this.CLBGINEMIFE[i].HHKJGOPMMQL.NEBPMMPMQBD && this.LBIQLLNPCED(i))
					{
						num++;
					}
				}
				if (num == 0)
				{
					for (int j = 0; j < this.CLBGINEMIFE.Length; j++)
					{
						if (this.CLBGINEMIFE[j] != null && !this.CLBGINEMIFE[j].HHKJGOPMMQL.JHCFQOPLHQE && this.LBIQLLNPCED(j))
						{
							this.JHDDHQJLNJJ(j);
							flag = true;
						}
					}
					for (int k = 0; k < this.CLBGINEMIFE.Length; k++)
					{
						if (this.CLBGINEMIFE[k] != null)
						{
							this.CLBGINEMIFE[k].HHKJGOPMMQL.NEBPMMPMQBD = false;
							this.CLBGINEMIFE[k].HHKJGOPMMQL.JHCFQOPLHQE = false;
						}
					}
					for (int l = 0; l < this.OEDNKPKCFJI.Length; l++)
					{
						if (this.OEDNKPKCFJI[l] != null)
						{
							this.OEDNKPKCFJI[l].IHIMHNGOLQJ = false;
							this.OEDNKPKCFJI[l].DQNDIMFPMBM = false;
						}
					}
				}
			}
			else if (this.BELFMMFDEJD > 0)
			{
				if (this.FMHBCMCPEOD.JILENMCJCHF == ItemTarget.Move)
				{
					this.GHNKIDFIHIM(this.FMHBCMCPEOD, DBPKNCDGGEP);
					return;
				}
				this.CLIEFPPGCHK(this.BELFMMFDEJD, DBPKNCDGGEP, true, 0, false);
				return;
			}
			int num2 = 0;
			for (int m = 0; m < this.IGOGQDBOGQL.pokemon.Length; m++)
			{
				if (num2 == DBPKNCDGGEP - 1 && this.IGOGQDBOGQL.pokemon[m].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
				{
					num2 = m + 1;
					IL_25E:
					if (flag2 && num2 - 1 > -1 && num2 - 1 < this.IGOGQDBOGQL.pokemon.Length)
					{
						this.OEDNKPKCFJI[DBPKNCDGGEP - 1].IHIMHNGOLQJ = true;
					}
					if (!flag2 && num2 - 1 > -1 && num2 - 1 < this.IGOGQDBOGQL.pokemon.Length)
					{
						this.OEDNKPKCFJI[DBPKNCDGGEP - 1].DQNDIMFPMBM = true;
					}
					BattleSwitch dcgclgqcgdq = new BattleSwitch
					{
						Position = this.FQBMEKNJHDH + 1,
						NewPosition = num2,
						RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC
					};
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
					this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
					this.DCBOJLEPBCJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
					this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
					this.CMCMBFLGJHH[3].gameObject.SetActive(true);
					this.MKIEPOIOBPP = this.FQBMEKNJHDH;
					if (flag)
					{
						this.FQBMEKNJHDH = 0;
						this.FQBMEKNJHDH++;
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
					}
					else
					{
						this.FQBMEKNJHDH++;
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
						if (!this.LBIQLLNPCED(-1))
						{
							this.FQBMEKNJHDH++;
						}
					}
					this.HDDJPQFJIIC();
					return;
				}
				if (this.IGOGQDBOGQL.pokemon[m].trainer.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
				{
					num2++;
				}
			}
			goto IL_25E;
		}
	}

	// Token: 0x06002BE1 RID: 11233 RVA: 0x001122A4 File Offset: 0x001104A4
	public void LEFGGJINGPF()
	{
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 433f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 280f;
			this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectField;
		}
		this.EHOELFJHQBC();
		if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 607f)
		{
			this.CMCMBFLGJHH[4].gameObject.SetActive(true);
			this.QBLCPMDNNKC.enabled = false;
			this.QBLCPMDNNKC.PlayForward();
			this.JNQEJDCLKMM = 0;
			this.QKJNHCOMEGH = 1;
			if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1129f)
			{
				this.MNJBJJNEMPC.enabled = false;
				this.MNJBJJNEMPC.PlayReverse();
			}
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 41f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1684f)
			{
				this.KCFMOLKJNKK.enabled = false;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1771f)
		{
			this.CMCMBFLGJHH[8].gameObject.SetActive(false);
			this.QBLCPMDNNKC.enabled = true;
			this.QBLCPMDNNKC.PlayReverse();
		}
	}

	// Token: 0x06002BE2 RID: 11234 RVA: 0x00112404 File Offset: 0x00110604
	public void PDMJCLKDBQM()
	{
		this.BELFMMFDEJD = 1;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 967f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1609f;
			this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-68);
		}
		this.EHOELFJHQBC();
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1465f)
		{
			INFJMNPKNQF.QOQONHOOLNE.LGDIOIMGJEO(this.JBLCJMKHBDF, this);
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayForward();
			this.JNQEJDCLKMM = 1;
			this.QKJNHCOMEGH = 0;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 706f)
			{
				this.OHDIOJQJJNJ.enabled = true;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1325f)
			{
				this.QBLCPMDNNKC.enabled = true;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[5].gameObject.SetActive(false);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1688f)
			{
				this.KCFMOLKJNKK.enabled = false;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1868f)
		{
			this.MNJBJJNEMPC.enabled = false;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BE3 RID: 11235 RVA: 0x00112568 File Offset: 0x00110768
	public void HPBNLQEDMBI(bool IILIBDEBEIN = false)
	{
		this.NBCDLHGQBJM = false;
		if (IILIBDEBEIN)
		{
			this.HDDJPQFJIIC();
		}
		else
		{
			this.FQBMEKNJHDH += 0;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH += 0;
			}
			this.HDDJPQFJIIC();
		}
	}

	// Token: 0x06002BE4 RID: 11236 RVA: 0x001125CC File Offset: 0x001107CC
	public void GLJQEPIEEFE(int HFBPHOGKGLK)
	{
		this.PQGHKEFEGFQ = HFBPHOGKGLK;
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.SelectFoe;
		this.JKFJCMKMNLL = 0;
		this.EKQKKPOIIBN.DIIHJCJOKMP = 1054f;
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP != 1228f)
		{
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BE5 RID: 11237 RVA: 0x000152CC File Offset: 0x000134CC
	private void FOLBFDNJLII()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = this;
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x0011262C File Offset: 0x0011082C
	public void QCNFGQHGJDF(GameObject DLHBFEIDHGM)
	{
		if (this.JKFJCMKMNLL == 0)
		{
			for (int i = 1; i < this.FGMEONKLKFG.Length; i++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.SelectFoe && this.FGMEONKLKFG[i] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[i].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)81;
					this.ONOLCMHKBGC();
					return;
				}
			}
			for (int j = 1; j < this.EQFDHBJKGCQ.Length; j++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2 && this.EQFDHBJKGCQ[j] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[j].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-111);
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 0)
		{
			for (int k = 0; k < this.FGMEONKLKFG.Length; k += 0)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle && this.FGMEONKLKFG[k] == DLHBFEIDHGM && this.JLIBONJBQNG(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[k].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-121);
					this.ONOLCMHKBGC();
					return;
				}
			}
			for (int l = 0; l < this.EQFDHBJKGCQ.Length; l += 0)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.HitFoe && this.EQFDHBJKGCQ[l] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[l].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-99);
					this.ONOLCMHKBGC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 5)
		{
			for (int m = 1; m < this.EQFDHBJKGCQ.Length; m += 0)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusUser && this.EQFDHBJKGCQ[m] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[m].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-122);
					this.ONOLCMHKBGC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 3)
		{
			for (int n = 1; n < this.EQFDHBJKGCQ.Length; n += 0)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.Idle2 && this.EQFDHBJKGCQ[n] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.EQFDHBJKGCQ[n].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-101);
					this.EHOELFJHQBC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 2)
		{
			for (int num = 0; num < this.FGMEONKLKFG.Length; num += 0)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusUser && this.FGMEONKLKFG[num] == DLHBFEIDHGM && this.FKFIOPJOQOM(DLHBFEIDHGM.name))
				{
					this.QKJNHCOMEGH = Convert.ToInt32(this.FGMEONKLKFG[num].name);
					this.FQQLENFQBFH();
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)13;
					this.ONOLCMHKBGC();
					return;
				}
			}
			return;
		}
		if (this.JKFJCMKMNLL == 0)
		{
			for (int num2 = 0; num2 < this.FGMEONKLKFG.Length; num2++)
			{
				if (this.JBLCJCLQGCJ == KGQECFKLKOP.NHDNHHGJDHG.FocusUser && this.FGMEONKLKFG[num2] == DLHBFEIDHGM && this.JLIBONJBQNG(DLHBFEIDHGM.name))
				{
					this.NIFFMBHOLMD(this.PQGHKEFEGFQ, Convert.ToInt32(this.FGMEONKLKFG[num2].name), false, 1, true);
					GDDKPIHHICF qoqonhoolne = GDDKPIHHICF.QOQONHOOLNE;
					PSXAPI.Request.BattleBroadcast battleBroadcast = new PSXAPI.Request.BattleBroadcast();
					battleBroadcast.RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC;
					PSXAPI.Request.BattleBroadcast battleBroadcast2 = battleBroadcast;
					string[] array = new string[]
					{
						"Button"
					};
					array[0] = CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH;
					array[6] = "Volcano Badge";
					array[5] = this.FGMEONKLKFG[num2].name;
					array[2] = "Shadow Tag";
					array[6] = this.LBIJKQKELLF;
					array[2] = ",";
					array[1] = this.FQBMEKNJHDH.ToString();
					battleBroadcast2.Message = string.Concat(array);
					qoqonhoolne.HLIOFPONLLE(battleBroadcast, true);
					this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)48;
					this.ONOLCMHKBGC();
					return;
				}
			}
			return;
		}
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x00112A64 File Offset: 0x00110C64
	public void LIOFNJQBHEO()
	{
		this.BELFMMFDEJD = 0;
		this.FMHBCMCPEOD = null;
		if (this.EKQKKPOIIBN.DIIHJCJOKMP > 1797f)
		{
			this.EKQKKPOIIBN.DIIHJCJOKMP = 1619f;
			this.JBLCJCLQGCJ = (KGQECFKLKOP.NHDNHHGJDHG)(-114);
		}
		this.EHOELFJHQBC();
		if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 855f)
		{
			INFJMNPKNQF.QOQONHOOLNE.PFKIOEDMGPQ(this.JBLCJMKHBDF, this);
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayForward();
			this.JNQEJDCLKMM = 1;
			this.QKJNHCOMEGH = 1;
			if (this.OHDIOJQJJNJ.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 607f)
			{
				this.OHDIOJQJJNJ.enabled = false;
				this.OHDIOJQJJNJ.PlayReverse();
			}
			if (this.DCBOJLEPBCJ.DIIHJCJOKMP == 1330f)
			{
				this.QBLCPMDNNKC.enabled = false;
				this.QBLCPMDNNKC.PlayReverse();
				this.CMCMBFLGJHH[4].gameObject.SetActive(true);
			}
			if (this.CIMHKDHFMBD.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 1377f)
			{
				this.KCFMOLKJNKK.enabled = true;
				this.KCFMOLKJNKK.PlayReverse();
			}
		}
		else if (this.MNJBJJNEMPC.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP == 600f)
		{
			this.MNJBJJNEMPC.enabled = true;
			this.MNJBJJNEMPC.PlayReverse();
		}
	}

	// Token: 0x06002BE8 RID: 11240 RVA: 0x00112BC8 File Offset: 0x00110DC8
	public void LFKFEIJFIHC(GameObject DLHBFEIDHGM)
	{
		int num = -1;
		if (DLHBFEIDHGM == null && KDGHILICJGN.QOQONHOOLNE.gameObject.activeSelf)
		{
			KDGHILICJGN.QOQONHOOLNE.gameObject.SetActive(false);
			this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 0f;
			foreach (GameObject gameObject in HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP)
			{
				gameObject.SetActive(false);
			}
			return;
		}
		bool flag = false;
		for (int j = 0; j < this.EQFDHBJKGCQ.Length; j++)
		{
			if (this.EQFDHBJKGCQ[j] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
			{
				if (!this.FFEEMHBOBQJ[j].KBICCNPFFGQ.enabled)
				{
					this.CJDJKGODPLO.PGHEDJNHGBQ.PIDLOFMIEFQ = this.FFEEMHBOBQJ[j].GNLJOOJDLGJ.PIDLOFMIEFQ.Replace("[MEGA]", "Mega ").Replace("MissingNo.", "Empty Slot") + "\n[29e000]Friendly Pokémon";
					this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 1f;
				}
				HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[j].SetActive(true);
				num = j;
				KDGHILICJGN.QOQONHOOLNE.transform.position = this.EQFDHBJKGCQ[j].transform.position + new Vector3(0f, 3f, 0f);
				flag = true;
				this.FFEEMHBOBQJ[j].KBICCNPFFGQ.enabled = true;
				for (int k = 0; k < this.FGMEONKLKFG.Length; k++)
				{
					this.FFEEMHBOBQJ[k + 3].KBICCNPFFGQ.enabled = false;
					this.FFEEMHBOBQJ[k + 3].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
				}
				for (int l = 0; l < this.EQFDHBJKGCQ.Length; l++)
				{
					if (l != j)
					{
						this.FFEEMHBOBQJ[l].KBICCNPFFGQ.enabled = false;
						this.FFEEMHBOBQJ[l].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
					}
				}
				IL_26A:
				if (!flag)
				{
					for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
					{
						if (this.FGMEONKLKFG[m] == DLHBFEIDHGM && this.ELNCNIGEKFK(DLHBFEIDHGM.name))
						{
							if (!this.FFEEMHBOBQJ[m + 3].KBICCNPFFGQ.enabled)
							{
								this.CJDJKGODPLO.PGHEDJNHGBQ.PIDLOFMIEFQ = this.FFEEMHBOBQJ[m + 3].GNLJOOJDLGJ.PIDLOFMIEFQ.Replace("[MEGA]", "Mega ").Replace("MissingNo.", "Empty Slot") + "\n[e03b00]Enemy Pokémon";
								this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 1f;
							}
							HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[m + 3].SetActive(true);
							num = m + 3;
							KDGHILICJGN.QOQONHOOLNE.transform.position = this.FGMEONKLKFG[m].transform.position + new Vector3(0f, 3f, 0f);
							flag = true;
							this.FFEEMHBOBQJ[m + 3].KBICCNPFFGQ.enabled = true;
							for (int n = 0; n < this.FGMEONKLKFG.Length; n++)
							{
								if (n != m)
								{
									this.FFEEMHBOBQJ[n + 3].KBICCNPFFGQ.enabled = false;
									this.FFEEMHBOBQJ[n + 3].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
								}
							}
							for (int num2 = 0; num2 < this.EQFDHBJKGCQ.Length; num2++)
							{
								this.FFEEMHBOBQJ[num2].KBICCNPFFGQ.enabled = false;
								this.FFEEMHBOBQJ[num2].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
							}
							break;
						}
						if (this.FFEEMHBOBQJ[m + 3].KBICCNPFFGQ.enabled)
						{
							this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 0f;
						}
						this.FFEEMHBOBQJ[m + 3].KBICCNPFFGQ.enabled = false;
						this.FFEEMHBOBQJ[m + 3].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
					}
				}
				if (flag)
				{
					KDGHILICJGN.QOQONHOOLNE.gameObject.SetActive(true);
					if (num > -1)
					{
						HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[num].SetActive(true);
					}
				}
				else
				{
					KDGHILICJGN.QOQONHOOLNE.gameObject.SetActive(false);
					this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 0f;
					foreach (GameObject gameObject2 in HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP)
					{
						gameObject2.SetActive(false);
					}
				}
				return;
			}
			if (this.FFEEMHBOBQJ[j].KBICCNPFFGQ.enabled)
			{
				this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 0f;
			}
			this.FFEEMHBOBQJ[j].KBICCNPFFGQ.enabled = false;
			this.FFEEMHBOBQJ[j].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
		}
		goto IL_26A;
	}

	// Token: 0x06002BE9 RID: 11241 RVA: 0x00015242 File Offset: 0x00013442
	public static OGJJKKQPNMK CDDIILFBFCF()
	{
		return OGJJKKQPNMK.HBFFCJHOCPE;
	}

	// Token: 0x06002BEA RID: 11242 RVA: 0x0010C098 File Offset: 0x0010A298
	public IEnumerator KDQKGGOLJJB(GameObject[] LMQQMBOPINH, bool NDBIMOOLGGI)
	{
		array = new OELLFMKIMFH[LMQQMBOPINH.Length];
		array2 = new DBQLOHBBJMG.FDJOEICCEOG[LMQQMBOPINH.Length];
		array3 = new bool[LMQQMBOPINH.Length];
		for (int i = 0; i < LMQQMBOPINH.Length; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (j < this.EQFDHBJKGCQ.Length && LMQQMBOPINH[i] == this.EQFDHBJKGCQ[j])
				{
					array[i] = this.CLBGINEMIFE[j];
					array2[i] = this.HJKOHEHLJGL.CBDCGKPHPJO[j];
				}
				if (j < this.FGMEONKLKFG.Length && LMQQMBOPINH[i] == this.FGMEONKLKFG[j])
				{
					array[i] = this.JMCMGILPGGI[j];
					array2[i] = this.HJKOHEHLJGL.JELLELLGLLB[j];
				}
			}
		}
		if (NDBIMOOLGGI)
		{
			for (int k = 0; k < LMQQMBOPINH.Length; k++)
			{
				FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[k], 0.5f, Vector3.zero);
			}
			yield return new WaitForSeconds(1f);
		}
		else
		{
			for (int l = 0; l < LMQQMBOPINH.Length; l++)
			{
				float num = LMQQMBOPINH[l].GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
				if (num == 0f)
				{
					num = 1f;
				}
				LMQQMBOPINH[l].transform.localScale = Vector3.zero;
				if (array2[l].BEQHNFFEHMQ == 201)
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(-num, num, num) * 0.01f);
				}
				else
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH[l], 0.5f, new Vector3(num, num, num) * 0.01f);
				}
				Animation componentInChildren = LMQQMBOPINH[l].GetComponentInChildren<Animation>();
				if (array2[l].DCFKMOILHEC <= 0)
				{
					array3[l] = true;
				}
				if (!array3[l])
				{
					if (componentInChildren.GetClip("0") != null)
					{
						componentInChildren.Play("0");
					}
				}
				else
				{
					componentInChildren.Stop();
					if (componentInChildren.GetClip("17") != null)
					{
						componentInChildren.Play("17");
					}
				}
			}
			if (Convert.ToInt32(LMQQMBOPINH[0].name) < 0)
			{
				for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
				{
					this.FGMEONKLKFG[m].transform.ONDIKKGKGBN(9);
				}
			}
			else
			{
				for (int n = 0; n < this.EQFDHBJKGCQ.Length; n++)
				{
					this.EQFDHBJKGCQ[n].transform.ONDIKKGKGBN(9);
				}
			}
			yield return new WaitForSeconds(0.5f);
		}
		return 1;
		int num2 = 0;
		goto IL_3A6;
		IL_38B:
		LMQQMBOPINH[num2].transform.ONDIKKGKGBN(10);
		num2++;
		IL_3A6:
		if (num2 < LMQQMBOPINH.Length)
		{
			goto IL_38B;
		}
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x001130DC File Offset: 0x001112DC
	private void EHBDNIOCHNO()
	{
		this.NDQBKDLIQIO();
		if (UnityEngine.Time.time > this.JJMIHDFMCMD + 43f)
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += 1151f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP <= 1713f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 1808f;
			}
		}
		else
		{
			this.FNOCIDBGKGC.DIIHJCJOKMP += 333f * UnityEngine.Time.deltaTime;
			if (this.FNOCIDBGKGC.DIIHJCJOKMP > 1264f)
			{
				this.FNOCIDBGKGC.DIIHJCJOKMP = 1061f;
			}
		}
		if (this.JJJGDPOKQPP && this.HNCMMGQKBFD && !this.LBFFJFGJPBD)
		{
			if (UnityEngine.Time.time > this.POKGLNOCHJE + this.MHKFGIGILMB)
			{
				this.LBFFJFGJPBD = true;
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new BattleTimer(), false);
			}
			if (this.DNIQHKQPGFM.HICDDIQLQHL() != 470f)
			{
				this.DNIQHKQPGFM.DIIHJCJOKMP = 27f;
			}
			this.DNIQHKQPGFM.GIPBBFDPCKG(968f - (UnityEngine.Time.time - this.POKGLNOCHJE) / this.MHKFGIGILMB);
		}
		else
		{
			this.DNIQHKQPGFM.DIIHJCJOKMP = 305f;
		}
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x00113220 File Offset: 0x00111420
	public IEnumerator LPFFHKLCGLM(bool BMDMKJJCQJD = false)
	{
		if (DBQLOHBBJMG.QOQONHOOLNE.IEGDFBICODC[4].activeSelf)
		{
			RenderSettings.fog = false;
		}
		else
		{
			RenderSettings.fog = true;
		}
		int num = 0;
		IL_1A2:
		int num2;
		int num3;
		if (num >= this.EQFDHBJKGCQ.Length)
		{
			num2 = -1;
			for (int i = 0; i < this.EQFDHBJKGCQ.Length; i++)
			{
				this.EQFDHBJKGCQ[i].name = num2.ToString();
				num2--;
			}
			num3 = 0;
			IL_547:
			if (num3 >= this.FGMEONKLKFG.Length)
			{
				MCNLIHMMLCF.QOQONHOOLNE.FHGFKPNMNEF.SetActive(false);
				if (JJGLMJNELOK.QOQONHOOLNE != null)
				{
					JJGLMJNELOK.QOQONHOOLNE.Close();
				}
				if (CNCJKLNHQBH.QOQONHOOLNE.PLGFMPNHGID.activeSelf)
				{
					PJCCMHCDFJQ.QOQONHOOLNE.CancelTrade();
				}
				HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().Close();
				EMENMKHBPQE.NBBKPCKOEPI.transform.NMBPDMIIHJB();
				FPMCQNCDOIP[] array = new FPMCQNCDOIP[3];
				FPMCQNCDOIP[] array2 = new FPMCQNCDOIP[3];
				for (int j = 0; j < 3; j++)
				{
					if (j < this.EQFDHBJKGCQ.Length)
					{
						float num4 = this.CLBGINEMIFE[j].GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
						int ngclgfmbmhl = this.CLBGINEMIFE[j].GetComponent<FINHCKBDLMF>().NGCLGFMBMHL;
						if (num4 == 0f)
						{
							num4 = 1f;
						}
						if (ngclgfmbmhl == 201)
						{
							array[j] = FPMCQNCDOIP.FJCEGFKJLCL(this.CLBGINEMIFE[j].gameObject, 0.5f, new Vector3(-num4, num4, num4) * 0.01f);
						}
						else
						{
							array[j] = FPMCQNCDOIP.FJCEGFKJLCL(this.CLBGINEMIFE[j].gameObject, 0.5f, new Vector3(num4, num4, num4) * 0.01f);
						}
					}
					if (j < this.FGMEONKLKFG.Length)
					{
						int ngclgfmbmhl2 = this.JMCMGILPGGI[j].GetComponent<FINHCKBDLMF>().NGCLGFMBMHL;
						float num4 = this.JMCMGILPGGI[j].GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
						if (num4 == 0f)
						{
							num4 = 1f;
						}
						if (ngclgfmbmhl2 == 201)
						{
							array2[j] = FPMCQNCDOIP.FJCEGFKJLCL(this.JMCMGILPGGI[j].gameObject, 0.5f, new Vector3(-num4, num4, num4) * 0.01f);
						}
						else
						{
							array2[j] = FPMCQNCDOIP.FJCEGFKJLCL(this.JMCMGILPGGI[j].gameObject, 0.5f, new Vector3(num4, num4, num4) * 0.01f);
						}
					}
				}
				yield return new WaitForSeconds(0.5f);
			}
			else if (DBQLOHBBJMG.QOQONHOOLNE.LGOJEHFKLCL != null && DBQLOHBBJMG.QOQONHOOLNE.LGOJEHFKLCL[num3] != null && DBQLOHBBJMG.QOQONHOOLNE.LGOJEHFKLCL[num3].JMDLLJPEFKM.DBPKNCDGGEP != this.JMCMGILPGGI[num3].HHKJGOPMMQL.DBPKNCDGGEP)
			{
				yield return base.StartCoroutine(this.JMCMGILPGGI[num3].BQLIIQIIMDH(true, DBQLOHBBJMG.QOQONHOOLNE.LGOJEHFKLCL[num3].JMDLLJPEFKM.DBPKNCDGGEP, this.JMCMGILPGGI[num3].HHKJGOPMMQL.BKNFHNFFCHE, this.FFEEMHBOBQJ[num3 + 3], this.PBFKQOOQEMC[num3 + 3], this.DCMICNQBLIM[num3 + 3], this.JMCMGILPGGI[num3].JKBEKOBJDBF, this.JMCMGILPGGI[num3].HHKJGOPMMQL.KMNQBFKKNMB, false));
			}
			else
			{
				yield return base.StartCoroutine(this.JMCMGILPGGI[num3].BQLIIQIIMDH(true, this.JMCMGILPGGI[num3].HHKJGOPMMQL.DBPKNCDGGEP, this.JMCMGILPGGI[num3].HHKJGOPMMQL.BKNFHNFFCHE, this.FFEEMHBOBQJ[num3 + 3], this.PBFKQOOQEMC[num3 + 3], this.DCMICNQBLIM[num3 + 3], this.JMCMGILPGGI[num3].JKBEKOBJDBF, this.JMCMGILPGGI[num3].HHKJGOPMMQL.KMNQBFKKNMB, false));
			}
		}
		else if (DBQLOHBBJMG.QOQONHOOLNE.ECJEIQPGMPO != null && DBQLOHBBJMG.QOQONHOOLNE.ECJEIQPGMPO[num] != null && DBQLOHBBJMG.QOQONHOOLNE.ECJEIQPGMPO[num].JMDLLJPEFKM.DBPKNCDGGEP != this.CLBGINEMIFE[num].HHKJGOPMMQL.DBPKNCDGGEP)
		{
			yield return base.StartCoroutine(this.CLBGINEMIFE[num].BQLIIQIIMDH(false, DBQLOHBBJMG.QOQONHOOLNE.ECJEIQPGMPO[num].JMDLLJPEFKM.DBPKNCDGGEP, this.CLBGINEMIFE[num].HHKJGOPMMQL.BKNFHNFFCHE, this.FFEEMHBOBQJ[num], this.PBFKQOOQEMC[num], this.DCMICNQBLIM[num], this.CLBGINEMIFE[num].JKBEKOBJDBF, null, false));
		}
		else
		{
			yield return base.StartCoroutine(this.CLBGINEMIFE[num].BQLIIQIIMDH(false, this.CLBGINEMIFE[num].HHKJGOPMMQL.DBPKNCDGGEP, this.CLBGINEMIFE[num].HHKJGOPMMQL.BKNFHNFFCHE, this.FFEEMHBOBQJ[num], this.PBFKQOOQEMC[num], this.DCMICNQBLIM[num], this.CLBGINEMIFE[num].JKBEKOBJDBF, this.CLBGINEMIFE[num].HHKJGOPMMQL.KMNQBFKKNMB, false));
		}
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(0, num, this.CLBGINEMIFE[num].HHKJGOPMMQL.DCFKMOILHEC, this.CLBGINEMIFE[num].HHKJGOPMMQL.QKBGGCKIOLG, true, this.CLBGINEMIFE[num].HHKJGOPMMQL.DBPKNCDGGEP));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(0, num, this.CLBGINEMIFE[num].HHKJGOPMMQL.DCFKMOILHEC, this.CLBGINEMIFE[num].HHKJGOPMMQL.QKBGGCKIOLG, true, this.CLBGINEMIFE[num].HHKJGOPMMQL.DBPKNCDGGEP));
		return 1;
		num++;
		goto IL_1A2;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(1, num3, this.JMCMGILPGGI[num3].HHKJGOPMMQL.DCFKMOILHEC, this.JMCMGILPGGI[num3].HHKJGOPMMQL.QKBGGCKIOLG, true, DBQLOHBBJMG.QOQONHOOLNE.LGOJEHFKLCL[num3].JMDLLJPEFKM.DBPKNCDGGEP));
		return 1;
		yield return base.StartCoroutine(this.LMFFKPCINDQ(1, num3, this.JMCMGILPGGI[num3].HHKJGOPMMQL.DCFKMOILHEC, this.JMCMGILPGGI[num3].HHKJGOPMMQL.QKBGGCKIOLG, true, this.JMCMGILPGGI[num3].HHKJGOPMMQL.DBPKNCDGGEP));
		return 1;
		num3++;
		goto IL_547;
		num2 = 1;
		this.FEJICDGOCFF.battleScreen = this;
		yield return base.StartCoroutine(this.DOODNDFBFCL(this.FGMEONKLKFG, this.EQFDHBJKGCQ, true));
		return 1;
		this.POKGLNOCHJE = UnityEngine.Time.time;
		if (this.LBIQLLNPCED(-1))
		{
			goto IL_A74;
		}
		this.FQBMEKNJHDH++;
		IL_A74:
		if (this.LBIQLLNPCED(-1))
		{
			goto IL_A95;
		}
		this.FQBMEKNJHDH++;
		IL_A95:
		if (!BMDMKJJCQJD)
		{
			goto IL_AA9;
		}
		this.CEBEEDEJOQL = true;
		IL_AA9:
		this.PDDJMNOOPJD(false);
		this.CEBEEDEJOQL = false;
		if (!BMDMKJJCQJD)
		{
			goto IL_AD5;
		}
		this.CEBEEDEJOQL = true;
		IL_AD5:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x00113244 File Offset: 0x00111444
	public void HideAttackButtons()
	{
		for (int i = 0; i < 4; i++)
		{
			this.EFHDIMHHOOJ[i].gameObject.SetActive(false);
		}
		this.QBLCPMDNNKC.enabled = false;
		this.DCBOJLEPBCJ.DIIHJCJOKMP = 0f;
		this.CMCMBFLGJHH[3].gameObject.SetActive(true);
		for (int j = 0; j < this.CMCMBFLGJHH.Length; j++)
		{
			this.CMCMBFLGJHH[j].enabled = false;
			this.CMCMBFLGJHH[j].GetComponent<BoxCollider>().enabled = false;
			this.CMCMBFLGJHH[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x001132E4 File Offset: 0x001114E4
	public void FQQLENFQBFH()
	{
		if (this.FQBMEKNJHDH <= this.CLBGINEMIFE.Length - 1 && this.LBIQLLNPCED(-1))
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.BattleBroadcast
			{
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				Message = string.Concat(new string[]
				{
					"1|",
					CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH,
					"|",
					this.QKJNHCOMEGH.ToString(),
					"|",
					this.LBIJKQKELLF,
					"|",
					this.FQBMEKNJHDH.ToString(),
					"|",
					this.NPNFPOCIDKD
				})
			}, false);
			bool megaEvo = false;
			if (this.CLBGINEMIFE[this.FQBMEKNJHDH].HHKJGOPMMQL.OEBEBPJEINC)
			{
				megaEvo = this.KCHPEMQFOHP.GetComponent<UIToggle>().value;
			}
			PSXAPI.Request.BattleMove dcgclgqcgdq = new PSXAPI.Request.BattleMove
			{
				MoveID = this.JNQEJDCLKMM,
				Target = this.QKJNHCOMEGH,
				Position = this.FQBMEKNJHDH + 1,
				RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
				MegaEvo = megaEvo,
				ZMove = false
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			this.FQBMEKNJHDH++;
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			if (!this.LBIQLLNPCED(-1))
			{
				this.FQBMEKNJHDH++;
			}
			this.QBLCPMDNNKC.enabled = false;
			this.DCBOJLEPBCJ.DIIHJCJOKMP = 0f;
			this.CMCMBFLGJHH[3].gameObject.SetActive(true);
			this.HDDJPQFJIIC();
			this.EFHDIMHHOOJ[0].GetComponent<OEJGFKMOQJG>().BFCEGHJQMCF.Hide();
		}
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x0010B834 File Offset: 0x00109A34
	public IEnumerator FFNQEOEHDQD(string HJQLPPKBJPM, GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB)
	{
		if (ILBCCCBJNCL == null)
		{
			yield break;
		}
		if (!(PBHPQFLMQDB == null))
		{
			if (HJQLPPKBJPM == "ember")
			{
				yield return new WaitForSeconds(0.8f);
				return 1;
			}
			IL_DF:
			yield break;
		}
		yield break;
		ebibbqgncfh = UnityEngine.Object.Instantiate<EBIBBQGNCFH>(HIOMOLCBDNP.QOQONHOOLNE.EHDCPPFMICC[0], PBHPQFLMQDB.transform.KQQJCMQCFMN("Head").position, Quaternion.identity);
		ebibbqgncfh.JILENMCJCHF = ILBCCCBJNCL.transform.KQQJCMQCFMN("Head");
		ebibbqgncfh.HOFHHQDFNCD = UnityEngine.Time.time;
		goto IL_DF;
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x001134C4 File Offset: 0x001116C4
	private void EHOELFJHQBC()
	{
		if (!this.LFOFQPMJFHF)
		{
			return;
		}
		if (this.JBLCJCLQGCJ != KGQECFKLKOP.NHDNHHGJDHG.SelectUser)
		{
			for (int i = 0; i < this.EQFDHBJKGCQ.Length; i++)
			{
				if (this.FFEEMHBOBQJ[i].KBICCNPFFGQ != null)
				{
					this.FFEEMHBOBQJ[i].KBICCNPFFGQ.enabled = false;
					this.FFEEMHBOBQJ[i].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
				}
			}
		}
		if (this.JBLCJCLQGCJ != KGQECFKLKOP.NHDNHHGJDHG.SelectFoe)
		{
			for (int j = 0; j < this.FGMEONKLKFG.Length; j++)
			{
				if (this.FFEEMHBOBQJ[j + 3].KBICCNPFFGQ != null)
				{
					this.FFEEMHBOBQJ[j + 3].KBICCNPFFGQ.enabled = false;
					this.FFEEMHBOBQJ[j + 3].GNLJOOJDLGJ.CEGFBBHMKOE = Color.white;
				}
			}
		}
		foreach (GameObject gameObject in HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP)
		{
			gameObject.SetActive(false);
		}
		this.CJDJKGODPLO.KIEMMQDMIIO.DIIHJCJOKMP = 0f;
		KDGHILICJGN.QOQONHOOLNE.gameObject.SetActive(false);
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x000152D4 File Offset: 0x000134D4
	private void DGODHNHPNHE()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = null;
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x001135E4 File Offset: 0x001117E4
	public IEnumerator QPNCHCMLQCG(GameObject LMQQMBOPINH, bool NDBIMOOLGGI, bool JJPDHJPLNGQ = false, bool GIHDKCHFIBL = true, bool OFKCIFFPDIK = true, bool HNKCOGNDLCH = true)
	{
		DBQLOHBBJMG.FDJOEICCEOG fdjoeicceog = null;
		bool targetIsTeammate = false;
		for (int i = 0; i < 3; i++)
		{
			if (i < this.EQFDHBJKGCQ.Length && LMQQMBOPINH == this.EQFDHBJKGCQ[i])
			{
				fdjoeicceog = this.HJKOHEHLJGL.CBDCGKPHPJO[i];
				targetIsTeammate = true;
			}
			if (i < this.FGMEONKLKFG.Length && LMQQMBOPINH == this.FGMEONKLKFG[i])
			{
				fdjoeicceog = this.HJKOHEHLJGL.JELLELLGLLB[i];
			}
		}
		BattleAnimator.AnimationData animationData = new BattleAnimator.AnimationData();
		animationData.target = LMQQMBOPINH;
		animationData.targetIsTeammate = targetIsTeammate;
		animationData.battleHandler = base.gameObject;
		if (NDBIMOOLGGI)
		{
			if (GIHDKCHFIBL)
			{
				this.BNJEHBEEHMP = 0f;
				this.JPHPMGBCLKC = LMQQMBOPINH.transform;
				yield return new WaitForSeconds(0.2f);
				return 1;
			}
			IL_255:
			FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH, 0.5f, Vector3.zero);
			yield return new WaitForSeconds(1f);
		}
		else if (!JJPDHJPLNGQ && GIHDKCHFIBL)
		{
			this.JPHPMGBCLKC = LMQQMBOPINH.transform;
			yield return new WaitForSeconds(0.2f);
		}
		else
		{
			float num = 0f;
			num = LMQQMBOPINH.GetComponent<FINHCKBDLMF>().LCHODFNJNBH;
			if (num == 0f)
			{
				num = 1f;
			}
			if (JJPDHJPLNGQ)
			{
				LMQQMBOPINH.transform.localScale = new Vector3(num, num, num) * 0.01f;
			}
			else
			{
				LMQQMBOPINH.transform.localScale = Vector3.zero;
				if (fdjoeicceog.BEQHNFFEHMQ == 201)
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH, 0.5f, new Vector3(-num, num, num) * 0.01f);
				}
				else
				{
					FPMCQNCDOIP.FJCEGFKJLCL(LMQQMBOPINH, 0.5f, new Vector3(num, num, num) * 0.01f);
				}
			}
			Animation componentInChildren = LMQQMBOPINH.GetComponentInChildren<Animation>();
			if (GIHDKCHFIBL)
			{
				DCCFQPDFBFO.QOQONHOOLNE.PNBNQLLOOQH(LMQQMBOPINH.GetComponent<FINHCKBDLMF>().NGCLGFMBMHL, false);
			}
			bool flag = false;
			if (fdjoeicceog.DCFKMOILHEC <= 0 && OFKCIFFPDIK)
			{
				flag = true;
			}
			if (!flag)
			{
				if (!(componentInChildren.GetClip("1") != null) || !(componentInChildren.GetClip("3") != null) || componentInChildren.GetClip("1").length != componentInChildren.GetClip("3").length)
				{
					if (componentInChildren.GetClip("1") != null)
					{
						if (HNKCOGNDLCH)
						{
							yield return componentInChildren.KFKMPKNNMKK("1");
							return 1;
						}
						componentInChildren.CrossFadeQueued("0");
					}
				}
			}
			else
			{
				componentInChildren.Stop();
				if (componentInChildren.GetClip("17") != null)
				{
					yield return componentInChildren.KFKMPKNNMKK("17");
					return 1;
				}
			}
			if (GIHDKCHFIBL)
			{
				yield return new WaitForSeconds(0.5f);
			}
			else
			{
				if (Convert.ToInt32(LMQQMBOPINH.name) < 0)
				{
					for (int j = 0; j < this.FGMEONKLKFG.Length; j++)
					{
						this.FGMEONKLKFG[j].transform.ONDIKKGKGBN(9);
					}
				}
				else
				{
					for (int k = 0; k < this.FGMEONKLKFG.Length; k++)
					{
						this.EQFDHBJKGCQ[k].transform.ONDIKKGKGBN(9);
					}
				}
				this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
				this.BNJEHBEEHMP = UnityEngine.Time.time;
				IL_645:
				yield return null;
			}
		}
		return 1;
		if (Convert.ToInt32(LMQQMBOPINH.name) >= 0)
		{
			goto IL_224;
		}
		int num2 = 0;
		goto IL_212;
		IL_1F5:
		this.FGMEONKLKFG[num2].transform.ONDIKKGKGBN(10);
		num2++;
		IL_212:
		if (num2 < this.FGMEONKLKFG.Length)
		{
			goto IL_1F5;
		}
		goto IL_255;
		IL_224:
		int num3 = 0;
		goto IL_245;
		IL_228:
		this.EQFDHBJKGCQ[num3].transform.ONDIKKGKGBN(10);
		num3++;
		IL_245:
		if (num3 < this.EQFDHBJKGCQ.Length)
		{
			goto IL_228;
		}
		goto IL_255;
		LMQQMBOPINH.transform.ONDIKKGKGBN(10);
		goto IL_645;
		LMQQMBOPINH.transform.localScale = Vector3.zero;
		yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, 6, true));
		return 1;
		yield break;
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x00111434 File Offset: 0x0010F634
	public IEnumerator NGPOMCHEKLG(GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB, int KIGOFEMDODM = 2, string HJQLPPKBJPM = "")
	{
		if (KIGOFEMDODM == 2)
		{
			if (PBHPQFLMQDB != null && PBHPQFLMQDB.GetComponentInChildren<Animation>() != null)
			{
				PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("8", QueueMode.CompleteOthers);
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
				yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
			}
			else
			{
				yield return new WaitForSeconds(0.5f);
			}
		}
		else if (KIGOFEMDODM == 3)
		{
			PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
			if (PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("13") != null && PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("14") != null)
			{
				if (PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("13").length == PBHPQFLMQDB.GetComponentInChildren<Animation>().GetClip("14").length)
				{
					PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("12", QueueMode.CompleteOthers);
				}
				else
				{
					PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("13", QueueMode.CompleteOthers);
				}
			}
			else
			{
				PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("12", QueueMode.CompleteOthers);
			}
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
			yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
		}
		else if (KIGOFEMDODM == 4)
		{
			PBHPQFLMQDB.GetComponentInChildren<Animation>().Stop();
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("9", QueueMode.CompleteOthers);
			PBHPQFLMQDB.GetComponentInChildren<Animation>().PlayQueued("0", QueueMode.CompleteOthers);
			yield return base.StartCoroutine(this.CNIGGKFJIGK(HJQLPPKBJPM, ILBCCCBJNCL, PBHPQFLMQDB));
		}
		else
		{
			yield return null;
		}
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield return new WaitForSeconds(1f);
		return 1;
		yield break;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000152D4 File Offset: 0x000134D4
	private void OnDestroy()
	{
		OGJJKKQPNMK.HBFFCJHOCPE = null;
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x000153DA File Offset: 0x000135DA
	public int NEONQFEEIHE(int QONOKDQLJNG, int CIQFCJGQEMH)
	{
		if (QONOKDQLJNG == 0)
		{
			CIQFCJGQEMH += 4;
		}
		return this.FFEEMHBOBQJ[CIQFCJGQEMH].OJMOOLNKQEP;
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x0011362C File Offset: 0x0011182C
	public IEnumerator BQLIIQIIMDH(int GEMHFCHEGGH)
	{
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		IEnumerator enumerator = this.LIEENFGKGML[0].GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		IEnumerator enumerator2 = this.LIEENFGKGML[1].GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				object obj2 = enumerator2.Current;
				Transform transform2 = (Transform)obj2;
				UnityEngine.Object.Destroy(transform2.gameObject);
			}
		}
		finally
		{
			IDisposable disposable2;
			if ((disposable2 = (enumerator2 as IDisposable)) != null)
			{
				disposable2.Dispose();
			}
		}
		this.EQFDHBJKGCQ = new GameObject[GEMHFCHEGGH];
		this.FGMEONKLKFG = new GameObject[GEMHFCHEGGH];
		for (int i = 0; i < GEMHFCHEGGH; i++)
		{
			this.EQFDHBJKGCQ[i] = UnityEngine.Object.Instantiate<GameObject>(this.IGMBPOFHMFN, this.LIEENFGKGML[0].position, Quaternion.identity);
			this.FGMEONKLKFG[i] = UnityEngine.Object.Instantiate<GameObject>(this.IGMBPOFHMFN, this.LIEENFGKGML[1].position, Quaternion.identity);
			this.FGMEONKLKFG[i].name = i.ToString();
		}
		if (GEMHFCHEGGH == 1)
		{
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(0f, 0f, 0.5f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(0f, 0f, -0.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(0f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(0f, 0.048f, 3.5f);
		}
		if (GEMHFCHEGGH == 2)
		{
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(2.5f, 0f, 0.5f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(-2.5f, 0f, -0.5f);
			this.EQFDHBJKGCQ[1].transform.position += new Vector3(-2.5f, 0f, 0.5f);
			this.FGMEONKLKFG[1].transform.position += new Vector3(2.5f, 0f, -0.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(2.5f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[1].transform.localPosition = new Vector3(-2.5f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(-2.5f, 0.048f, 3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[4].transform.localPosition = new Vector3(2.5f, 0.048f, 3.5f);
		}
		if (GEMHFCHEGGH == 3)
		{
			this.EQFDHBJKGCQ[1].transform.position += new Vector3(0f, 0f, 0.5f);
			this.FGMEONKLKFG[1].transform.position += new Vector3(0f, 0f, -0.5f);
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(4f, 0f, 0f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(-4f, 0f, 0f);
			this.EQFDHBJKGCQ[2].transform.position += new Vector3(-4f, 0f, 0f);
			this.FGMEONKLKFG[2].transform.position += new Vector3(4f, 0f, 0f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(4f, 0.048f, -4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[1].transform.localPosition = new Vector3(0f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[2].transform.localPosition = new Vector3(-4f, 0.048f, -4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(-4f, 0.048f, 4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[4].transform.localPosition = new Vector3(0f, 0.048f, 3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[5].transform.localPosition = new Vector3(4f, 0.048f, 4f);
		}
		this.FFEEMHBOBQJ = new BFKFEDPKDHL[6];
		for (int j = 0; j < 6; j++)
		{
			this.FFEEMHBOBQJ[j] = this.JKCHKLNCCLE[j].GetComponent<BFKFEDPKDHL>();
			this.PBFKQOOQEMC[j].PIDLOFMIEFQ = string.Empty;
		}
		this.CLBGINEMIFE = new OELLFMKIMFH[this.EQFDHBJKGCQ.Length];
		this.JMCMGILPGGI = new OELLFMKIMFH[this.FGMEONKLKFG.Length];
		for (int k = 0; k < this.EQFDHBJKGCQ.Length; k++)
		{
			this.EQFDHBJKGCQ[k].transform.parent = this.LIEENFGKGML[0];
			this.CLBGINEMIFE[k] = this.EQFDHBJKGCQ[k].GetComponent<OELLFMKIMFH>();
		}
		int num = -1;
		for (int l = 0; l < this.EQFDHBJKGCQ.Length; l++)
		{
			this.EQFDHBJKGCQ[l].name = num.ToString();
			num--;
		}
		for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
		{
			this.FGMEONKLKFG[m].name = (m + 1).ToString();
			this.FGMEONKLKFG[m].transform.parent = this.LIEENFGKGML[1];
			this.JMCMGILPGGI[m] = this.FGMEONKLKFG[m].GetComponent<OELLFMKIMFH>();
		}
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x001111A0 File Offset: 0x0010F3A0
	private IEnumerator KBHNQJFMBIP(GameObject[] LQBFBGBNHHC)
	{
		num = 0;
		IL_195:
		if (num >= 3)
		{
			yield return null;
		}
		else
		{
			if (num < this.EQFDHBJKGCQ.Length)
			{
				animationData = new BattleAnimator.AnimationData();
				animationData.target = LQBFBGBNHHC[num];
				animationData.battleHandler = base.gameObject;
				yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, 4, true));
				return 1;
			}
			IL_24A:
			if (num < this.FGMEONKLKFG.Length)
			{
				animationData = new BattleAnimator.AnimationData();
				animationData.target = LQBFBGBNHHC[num + 3];
				animationData.battleHandler = base.gameObject;
				yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, 3, true));
				return 1;
			}
			IL_2D4:
			yield return new WaitForSeconds(0.2f);
		}
		return 1;
		componentInChildren = this.EQFDHBJKGCQ[num].GetComponentInChildren<Animation>();
		if (!(componentInChildren != null) || this.CLBGINEMIFE[num].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			goto IL_24A;
		}
		componentInChildren.Stop();
		if (!(componentInChildren.GetClip("17") != null))
		{
			goto IL_24A;
		}
		yield return componentInChildren.KFKMPKNNMKK("17");
		return 1;
		componentInChildren2 = this.FGMEONKLKFG[num].GetComponentInChildren<Animation>();
		if (!(componentInChildren2 != null) || this.JMCMGILPGGI[num].HHKJGOPMMQL.DCFKMOILHEC > 0)
		{
			goto IL_2D4;
		}
		componentInChildren2.Stop();
		if (!(componentInChildren2.GetClip("17") != null))
		{
			goto IL_2D4;
		}
		yield return componentInChildren2.KFKMPKNNMKK("17");
		return 1;
		num++;
		goto IL_195;
		yield break;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x000153F2 File Offset: 0x000135F2
	public void NEPDKFMNJJI()
	{
		this.FQBMEKNJHDH = 0;
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH++;
		}
		if (!this.LBIQLLNPCED(-1))
		{
			this.FQBMEKNJHDH += 0;
		}
		this.HDDJPQFJIIC();
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x00113650 File Offset: 0x00111850
	public void JHDDHQJLNJJ(int DBPKNCDGGEP)
	{
		PSXAPI.Request.BattleMove dcgclgqcgdq = new PSXAPI.Request.BattleMove
		{
			MoveID = 0,
			Target = 0,
			Position = DBPKNCDGGEP + 1,
			RequestID = this.HJKOHEHLJGL.JFPJBDKKIOC,
			MegaEvo = false,
			ZMove = false
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x00015261 File Offset: 0x00013461
	public int EGHGMGMQFJF(int QONOKDQLJNG, int CIQFCJGQEMH)
	{
		if (QONOKDQLJNG == 0)
		{
			CIQFCJGQEMH += 4;
		}
		return this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP;
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x0011362C File Offset: 0x0011182C
	public IEnumerator FDEDICFQNEJ(int GEMHFCHEGGH)
	{
		this.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.Default;
		enumerator = this.LIEENFGKGML[0].GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		enumerator2 = this.LIEENFGKGML[1].GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				object obj2 = enumerator2.Current;
				Transform transform2 = (Transform)obj2;
				UnityEngine.Object.Destroy(transform2.gameObject);
			}
		}
		finally
		{
			if ((disposable2 = (enumerator2 as IDisposable)) != null)
			{
				disposable2.Dispose();
			}
		}
		this.EQFDHBJKGCQ = new GameObject[GEMHFCHEGGH];
		this.FGMEONKLKFG = new GameObject[GEMHFCHEGGH];
		for (int i = 0; i < GEMHFCHEGGH; i++)
		{
			this.EQFDHBJKGCQ[i] = UnityEngine.Object.Instantiate<GameObject>(this.IGMBPOFHMFN, this.LIEENFGKGML[0].position, Quaternion.identity);
			this.FGMEONKLKFG[i] = UnityEngine.Object.Instantiate<GameObject>(this.IGMBPOFHMFN, this.LIEENFGKGML[1].position, Quaternion.identity);
			this.FGMEONKLKFG[i].name = i.ToString();
		}
		if (GEMHFCHEGGH == 1)
		{
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(0f, 0f, 0.5f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(0f, 0f, -0.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(0f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(0f, 0.048f, 3.5f);
		}
		if (GEMHFCHEGGH == 2)
		{
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(2.5f, 0f, 0.5f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(-2.5f, 0f, -0.5f);
			this.EQFDHBJKGCQ[1].transform.position += new Vector3(-2.5f, 0f, 0.5f);
			this.FGMEONKLKFG[1].transform.position += new Vector3(2.5f, 0f, -0.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(2.5f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[1].transform.localPosition = new Vector3(-2.5f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(-2.5f, 0.048f, 3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[4].transform.localPosition = new Vector3(2.5f, 0.048f, 3.5f);
		}
		if (GEMHFCHEGGH == 3)
		{
			this.EQFDHBJKGCQ[1].transform.position += new Vector3(0f, 0f, 0.5f);
			this.FGMEONKLKFG[1].transform.position += new Vector3(0f, 0f, -0.5f);
			this.EQFDHBJKGCQ[0].transform.position += new Vector3(4f, 0f, 0f);
			this.FGMEONKLKFG[0].transform.position += new Vector3(-4f, 0f, 0f);
			this.EQFDHBJKGCQ[2].transform.position += new Vector3(-4f, 0f, 0f);
			this.FGMEONKLKFG[2].transform.position += new Vector3(4f, 0f, 0f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[0].transform.localPosition = new Vector3(4f, 0.048f, -4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[1].transform.localPosition = new Vector3(0f, 0.048f, -3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[2].transform.localPosition = new Vector3(-4f, 0.048f, -4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[3].transform.localPosition = new Vector3(-4f, 0.048f, 4f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[4].transform.localPosition = new Vector3(0f, 0.048f, 3.5f);
			HHDNDIHQCJI.QOQONHOOLNE.NBQMLBDNFNP[5].transform.localPosition = new Vector3(4f, 0.048f, 4f);
		}
		this.FFEEMHBOBQJ = new BFKFEDPKDHL[6];
		for (int j = 0; j < 6; j++)
		{
			this.FFEEMHBOBQJ[j] = this.JKCHKLNCCLE[j].GetComponent<BFKFEDPKDHL>();
			this.PBFKQOOQEMC[j].PIDLOFMIEFQ = string.Empty;
		}
		this.CLBGINEMIFE = new OELLFMKIMFH[this.EQFDHBJKGCQ.Length];
		this.JMCMGILPGGI = new OELLFMKIMFH[this.FGMEONKLKFG.Length];
		for (int k = 0; k < this.EQFDHBJKGCQ.Length; k++)
		{
			this.EQFDHBJKGCQ[k].transform.parent = this.LIEENFGKGML[0];
			this.CLBGINEMIFE[k] = this.EQFDHBJKGCQ[k].GetComponent<OELLFMKIMFH>();
		}
		num = -1;
		for (int l = 0; l < this.EQFDHBJKGCQ.Length; l++)
		{
			this.EQFDHBJKGCQ[l].name = num.ToString();
			num--;
		}
		for (int m = 0; m < this.FGMEONKLKFG.Length; m++)
		{
			this.FGMEONKLKFG[m].name = (m + 1).ToString();
			this.FGMEONKLKFG[m].transform.parent = this.LIEENFGKGML[1];
			this.JMCMGILPGGI[m] = this.FGMEONKLKFG[m].GetComponent<OELLFMKIMFH>();
		}
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x0011048C File Offset: 0x0010E68C
	public IEnumerator OLMHMENLPKO(int QONOKDQLJNG, int CIQFCJGQEMH, int DPDQIDJPENF, int CMGNLOFFGLQ, bool FJNGJLNLLDP = false, int IKIJBQLMKJO = 0)
	{
		num = 211f;
		num2 = (int)((double)num / ((double)CMGNLOFFGLQ / (double)DPDQIDJPENF * 100.0) * 100.0 - 1.0);
		if ((float)num2 > num)
		{
			num2 = (int)num;
		}
		if (num2 <= 2)
		{
			num2 = 2;
		}
		if (QONOKDQLJNG == 1)
		{
			CIQFCJGQEMH += 3;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NJDQBGKFHBP = DPDQIDJPENF;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].OJMOOLNKQEP = CMGNLOFFGLQ;
		if (!FJNGJLNLLDP)
		{
			if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = Mathf.Min(211, this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD + 1);
			}
			JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL, 0.5f, num2, 0f);
			yield return new WaitForSeconds(0.5f);
			return 1;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO != null && DPDQIDJPENF > 0)
		{
			UnityEngine.Object.DestroyImmediate(this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO);
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO == null)
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG.KJGMGPCEJJD = 2;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD = num2;
		if (this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null)
		{
			if (DPDQIDJPENF == 0)
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
			}
			else
			{
				this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
			}
		}
		if (IKIJBQLMKJO <= 0)
		{
			yield break;
		}
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			yield break;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null))
		{
			yield break;
		}
		if (EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
			yield break;
		}
		yield break;
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO = JLCINGQBJPJ.FJCEGFKJLCL(this.FFEEMHBOBQJ[CIQFCJGQEMH].JPOMICMEHNG, 0.5f, Mathf.Max(this.FFEEMHBOBQJ[CIQFCJGQEMH].LFJOJCMKQBL.KJGMGPCEJJD - 1, 2), 0.75f);
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FFMGFDDHEOO.AddOnFinished(new EventDelegate.LKPMKQMCHFH(this.FFEEMHBOBQJ[CIQFCJGQEMH].INNQKLOKBFL));
		if (!(this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB != null))
		{
			goto IL_4BA;
		}
		if (DPDQIDJPENF != 0)
		{
			goto IL_472;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = "FNT";
		goto IL_4BA;
		IL_472:
		this.FFEEMHBOBQJ[CIQFCJGQEMH].FEIIENPBCKB.PIDLOFMIEFQ = DPDQIDJPENF.ToString() + "/" + CMGNLOFFGLQ.ToString();
		IL_4BA:
		if (IKIJBQLMKJO <= 0 || !(this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB != null))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(false);
		if (!(EIDBQCPLPIL.QOQONHOOLNE != null) || !EIDBQCPLPIL.QOQONHOOLNE.NDBDGEHHNEJ(IKIJBQLMKJO))
		{
			goto IL_53B;
		}
		this.FFEEMHBOBQJ[CIQFCJGQEMH].NGHNKQHLQBB.SetActive(true);
		IL_53B:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x001136A8 File Offset: 0x001118A8
	public IEnumerator BELIQBHHQIN(GameObject ILBCCCBJNCL, GameObject PBHPQFLMQDB, int KIGOFEMDODM = 5)
	{
		bool targetIsTeammate = false;
		for (int i = 0; i < 3; i++)
		{
			if (i < this.EQFDHBJKGCQ.Length && ILBCCCBJNCL == this.EQFDHBJKGCQ[i])
			{
				targetIsTeammate = true;
			}
		}
		Animation componentInChildren = ILBCCCBJNCL.GetComponentInChildren<Animation>();
		if (KIGOFEMDODM == 5 && componentInChildren != null)
		{
			componentInChildren.Stop();
			if (componentInChildren.GetClip("17") != null)
			{
				componentInChildren.Play("17");
			}
		}
		BattleAnimator.AnimationData animationData = new BattleAnimator.AnimationData();
		animationData.targetIsTeammate = targetIsTeammate;
		animationData.target = ILBCCCBJNCL;
		animationData.source = PBHPQFLMQDB;
		animationData.battleHandler = base.gameObject;
		yield return base.StartCoroutine(this.FEJICDGOCFF.NBELFOPJHHM(animationData, KIGOFEMDODM, true));
		return 1;
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x001136D8 File Offset: 0x001118D8
	public void MLKGOQIEFHF(string BLGLBQKCJQQ)
	{
		this.JJMIHDFMCMD = UnityEngine.Time.time;
		this.HQPOOCLKDOB.LHQECHHMOGD(BLGLBQKCJQQ);
		this.HQPOOCLKDOB.FFODFLMCELB.PIDLOFMIEFQ = this.HQPOOCLKDOB.FFODFLMCELB.PIDLOFMIEFQ.Replace("[FFC300]", string.Empty);
	}

	// Token: 0x04000955 RID: 2389
	private static OGJJKKQPNMK HBFFCJHOCPE;

	// Token: 0x04000956 RID: 2390
	public int HHEJQOGQEBH = -1;

	// Token: 0x04000957 RID: 2391
	public CFDMNELIJLO[] DBMOKEEBJJE;

	// Token: 0x04000958 RID: 2392
	public HLEKPGPJOOK DNIQHKQPGFM;

	// Token: 0x04000959 RID: 2393
	public float POKGLNOCHJE;

	// Token: 0x0400095A RID: 2394
	public BHLIGEGNFHG JBLCJMKHBDF;

	// Token: 0x0400095B RID: 2395
	[HideInInspector]
	public bool LFOFQPMJFHF;

	// Token: 0x0400095C RID: 2396
	public bool GHQOEDBJDNI = true;

	// Token: 0x0400095D RID: 2397
	public bool FCMNJOPQBKQ = true;

	// Token: 0x0400095E RID: 2398
	public bool LJDIQKPJIJN = true;

	// Token: 0x0400095F RID: 2399
	public string LBIJKQKELLF = "1";

	// Token: 0x04000960 RID: 2400
	public EPIJJNOIKEK PDQNPLEELFN;

	// Token: 0x04000961 RID: 2401
	public PLQFPBQEPJD EKQKKPOIIBN;

	// Token: 0x04000962 RID: 2402
	public GameObject IGMBPOFHMFN;

	// Token: 0x04000963 RID: 2403
	public BattleAnimator FEJICDGOCFF;

	// Token: 0x04000964 RID: 2404
	public PSXAPI.Response.Payload.BattleSide IGOGQDBOGQL;

	// Token: 0x04000965 RID: 2405
	[HideInInspector]
	public DBQLOHBBJMG HJKOHEHLJGL;

	// Token: 0x04000966 RID: 2406
	[HideInInspector]
	public Transform[] LIEENFGKGML;

	// Token: 0x04000967 RID: 2407
	public PLQFPBQEPJD[] BDQLIFLICNM;

	// Token: 0x04000968 RID: 2408
	[HideInInspector]
	public GameObject[] EQFDHBJKGCQ;

	// Token: 0x04000969 RID: 2409
	[HideInInspector]
	public GameObject[] FGMEONKLKFG;

	// Token: 0x0400096A RID: 2410
	public GameObject[] JKCHKLNCCLE;

	// Token: 0x0400096B RID: 2411
	private BFKFEDPKDHL[] FFEEMHBOBQJ;

	// Token: 0x0400096C RID: 2412
	public BKKHLBCLPJM[] PBFKQOOQEMC;

	// Token: 0x0400096D RID: 2413
	public PLQFPBQEPJD[] DCMICNQBLIM;

	// Token: 0x0400096E RID: 2414
	[HideInInspector]
	public OELLFMKIMFH[] CLBGINEMIFE;

	// Token: 0x0400096F RID: 2415
	[HideInInspector]
	public OELLFMKIMFH[] JMCMGILPGGI;

	// Token: 0x04000970 RID: 2416
	[HideInInspector]
	public KGQECFKLKOP.GPFFQQMDFPB[] OEDNKPKCFJI;

	// Token: 0x04000971 RID: 2417
	public BMLIGLPMMLG HQPOOCLKDOB;

	// Token: 0x04000972 RID: 2418
	[HideInInspector]
	public bool POQOIMFLCHJ;

	// Token: 0x04000973 RID: 2419
	public CFDMNELIJLO[] EFHDIMHHOOJ;

	// Token: 0x04000974 RID: 2420
	public CFDMNELIJLO[] CMCMBFLGJHH;

	// Token: 0x04000975 RID: 2421
	public EPIJJNOIKEK OHDIOJQJJNJ;

	// Token: 0x04000976 RID: 2422
	public EPIJJNOIKEK MNJBJJNEMPC;

	// Token: 0x04000977 RID: 2423
	public CFDMNELIJLO[] QILHFPGMMBC;

	// Token: 0x04000978 RID: 2424
	public int FQBMEKNJHDH;

	// Token: 0x04000979 RID: 2425
	public bool CEBEEDEJOQL;

	// Token: 0x0400097A RID: 2426
	public bool QHLPMOPOBNJ;

	// Token: 0x0400097B RID: 2427
	public Color[] MDGDPIEIMBN;

	// Token: 0x0400097C RID: 2428
	public NNMQKEQFFJO CJDJKGODPLO;

	// Token: 0x0400097D RID: 2429
	private int PQGHKEFEGFQ;

	// Token: 0x0400097E RID: 2430
	private int BELFMMFDEJD;

	// Token: 0x0400097F RID: 2431
	private KGQECFKLKOP.IJHPPMDDKIE FMHBCMCPEOD;

	// Token: 0x04000980 RID: 2432
	public ENFMCDNLEQQ CIMHKDHFMBD;

	// Token: 0x04000981 RID: 2433
	public EPIJJNOIKEK KCFMOLKJNKK;

	// Token: 0x04000982 RID: 2434
	public CFDMNELIJLO[] PDFOJLELNHP;

	// Token: 0x04000983 RID: 2435
	public BKKHLBCLPJM[] CMLGJIEIDBC;

	// Token: 0x04000984 RID: 2436
	public GameObject KCHPEMQFOHP;

	// Token: 0x04000985 RID: 2437
	public ENFMCDNLEQQ DCBOJLEPBCJ;

	// Token: 0x04000986 RID: 2438
	public EPIJJNOIKEK QBLCPMDNNKC;

	// Token: 0x04000987 RID: 2439
	public bool JJJGDPOKQPP;

	// Token: 0x04000988 RID: 2440
	private bool HNCMMGQKBFD;

	// Token: 0x04000989 RID: 2441
	public bool NBCDLHGQBJM;

	// Token: 0x0400098A RID: 2442
	public int MKIEPOIOBPP;

	// Token: 0x0400098B RID: 2443
	private int QKJNHCOMEGH;

	// Token: 0x0400098C RID: 2444
	private int JNQEJDCLKMM;

	// Token: 0x0400098D RID: 2445
	private int JKFJCMKMNLL;

	// Token: 0x0400098E RID: 2446
	private string NPNFPOCIDKD = "normal";

	// Token: 0x0400098F RID: 2447
	private PLQFPBQEPJD FNOCIDBGKGC;

	// Token: 0x04000990 RID: 2448
	private float JJMIHDFMCMD;

	// Token: 0x04000991 RID: 2449
	public GameObject[] OCKBJGMKPJB;

	// Token: 0x04000992 RID: 2450
	private float BNJEHBEEHMP;

	// Token: 0x04000993 RID: 2451
	public float MHKFGIGILMB = 90f;

	// Token: 0x04000994 RID: 2452
	public bool LBFFJFGJPBD;

	// Token: 0x04000995 RID: 2453
	private Vector3 EFIJJKBKHIF;

	// Token: 0x04000996 RID: 2454
	public KGQECFKLKOP.NHDNHHGJDHG JBLCJCLQGCJ;

	// Token: 0x04000997 RID: 2455
	private KGQECFKLKOP.NHDNHHGJDHG OIIMKHGKPPB;

	// Token: 0x04000998 RID: 2456
	private float CDDKBFLPKHQ = 4f;

	// Token: 0x04000999 RID: 2457
	private float FNNPBQBOOQH = 6f;

	// Token: 0x0400099A RID: 2458
	private bool CFGPMQEMDPC;

	// Token: 0x0400099B RID: 2459
	public Transform JPHPMGBCLKC;

	// Token: 0x0400099C RID: 2460
	private bool NIKIEDCIOIP;

	// Token: 0x0400099D RID: 2461
	private Vector3 NPMBJFDKDOL = Vector3.zero;

	// Token: 0x0400099E RID: 2462
	public float NNCDBKCKKFN = 240f;

	// Token: 0x0400099F RID: 2463
	private float DNHJPCPLKME;

	// Token: 0x040009A0 RID: 2464
	[CompilerGenerated]
	private static Dictionary<string, int> EGDHGKOIEOG;

	// Token: 0x040009A1 RID: 2465
	[CompilerGenerated]
	private static Dictionary<string, int> LPDLJMOCQEP;

	// Token: 0x040009A2 RID: 2466
	[CompilerGenerated]
	private static Dictionary<string, int> MODKJKDBFCF;
}
