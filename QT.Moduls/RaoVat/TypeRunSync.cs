using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.RaoVat
{
    public enum TypeRunSync
    {
        AnalysicKeyword,
        FixSlug,
        AnalyscFieldProduct,
        ReloadAllProuduct,
        ChangeStausKeyWordFromFiedBlock,
        ReloadAllKeyWord,
        AnalysicKeywordFromProduct,
        SyncKeyWordMongoAndSolr,
        SyncProductSolrAndMongo
    }
}
