using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasiyazica
{
    internal class metal
    {
        // 原材料
        // 鉱石
        int ironore = 0;    // 鉄鉱石
        int copperore = 0;  // 銅鉱石
        int silverore = 0;  // 銀鉱石
        int goldore = 0;    // 金鉱石
        int bauxite = 0;    // ボーキサイト
        int coalore = 0;    // 石炭鉱石
        int tinore = 0;     // 錫鉱石
        int leadore = 0;    // 鉛鉱石
        int zincore = 0;    // 亜鉛鉱石
        int quartzore = 0;  // 石英鉱石
        int feldsparore = 0; // 長石鉱石
        int gypsumore = 0;  // 石膏鉱石
        int limestoneore = 0; // 石灰石鉱石
        int clayore = 0;    // 粘土鉱石
        int saltore = 0;    // 岩塩鉱石
        int sulfurore = 0;  // 硫黄鉱石
        int phosphateore = 0; // リン鉱石
        int magnesiteore = 0; // マグネサイト鉱石
        int chromiteore = 0; // クロム鉱石
        int uraniumore = 0; // ウラン鉱石
        int platinumore = 0; // プラチナ鉱石
        int titaniumore = 0; // チタン鉱石
        int nickelore = 0;  // ニッケル鉱石
        int cobaltore = 0;  // コバルト鉱石
        int manganeseore = 0; // マンガン鉱石
        int vanadiumore = 0; // バナジウム鉱石
        int zirconiumore = 0; // ジルコニウム鉱石
        int lithiumore = 0; // リチウム鉱石
        int berylore = 0;   // ベリル鉱石
        int talcoseore = 0; // タルコ鉱石
        int magnesioriteore = 0; // マグネシオライト鉱石
        int haliteore = 0;  // ハライト鉱石
        int azuriteore = 0; // アズライト鉱石
        int malachiteore = 0; // マラカイト鉱石
        int cinnabarore = 0; // シンナバー鉱石
        int galenaore = 0;  // 方鉛鉱鉱石
        int sphaleriteore = 0; // スファレライト鉱石
        int chalcopyriteore = 0; // 黄銅鉱鉱石
        int pyriteore = 0;  // 黄鉄鉱鉱石
        int magnetiteore = 0; // 磁鉄鉱鉱石
        int hematiteore = 0; // 赤鉄鉱鉱石
        int limoniteore = 0; // 褐鉄鉱鉱石

        // レア素材
        // レア鉱石
        int adamantium = 0; // アダマンチウム
        int dragonite = 0;  // ドラゴナイト
        int orichalcum = 0; // オリハルコン
        int celestite = 0; // セレスティ
        int crystal = 0;  // クリスタル

        // 粒子素材
        int spiritdust = 0; // スピリット粒子
        int soulshard = 0;  // ソウルシャード
        int stardust = 0;   // スターダスト
        int moondust = 0;   // ムーンダスト
        int aether = 0; // エーテル

        // 加工素材
        // 鋼材
        int iron = 0;       // 鉄
        int steel = 0;      // 鋼
        int copper = 0;     // 銅
        int silver = 0;     // 銀
        int gold = 0;       // 金
        int stone = 0;      // 石
        int glass = 0;      // ガラス
        int wood = 0;       // 木
        int leather = 0;    // 革
        int cloth = 0;      // 布
        int arminium = 0;   // アルミニウム
        int plastic = 0;    // プラスチック
        int rubber = 0;     // ゴム
        int concrete = 0;   // コンクリート
        int ceramic = 0;    // セラミック
        int fiber = 0;      // 繊維
        int paper = 0;      // 紙
        int alloy = 0;      // 合金
        int dularum = 0;    // ジュラルミン
        int brass = 0;      // 真鍮
        int bronze = 0;     // 青銅
        int pewter = 0;     // ピューター
        int titanium = 0;   // チタン
        int nickel = 0;     // ニッケル
        int cobalt = 0;     // コバルト
        int manganese = 0;  // マンガン
        int vanadium = 0;   // バナジウム
        int zirconium = 0; // ジルコニウム
        int lithium = 0;    // リチウム
        int beryl = 0;      // ベリル
        int tungsten = 0;   // タングステン
        int molybdenum = 0; // モリブデン
        int tantalum = 0;   // タンタル
        int niobium = 0;    // ニオブ
        int hafnium = 0;    // ハフニウム
        int rhenium = 0;    // レニウム
        int osmium = 0;     // オスミウム
        int iridium = 0;    // イリジウム
        int ruthenium = 0;  // ルテニウム
        int palladium = 0;  // パラジウム
        int platinum = 0;   // プラチナ
        int uranium = 0;    // ウラン

        // レア合金
        int eternalium = 0; // エターナリウム
        int netherium = 0;  // ネザーリウム
        int astralsteel = 0; // アストラルスチール

        //超合金
        int mithril = 0;    // ミスリル (ドラゴナイト・エーテル化合物)
        int celestialcrystal = 0; // セレスティアルクリスタル（セレスティ・クリスタル化合物）
        int vibranium = 0;  // ヴィブラニウム（スターダスト・ムーンダスト合金）
        int quantanium = 0; // クアンタニウム（ソウルシャード・スピリット粒子化合物）

        // 超レア素材
        int phoenixfeather = 0; // フェニックスフェザー
        int dragonheart = 0; // ドラゴンハート

    }
}
