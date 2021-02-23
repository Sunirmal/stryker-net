using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;

namespace Stryker.Core.Mutants.CsharpNodeOrchestrators
{
    internal class SyntaxNodeOrchestrator : NodeSpecificOrchestrator<SyntaxNode, SyntaxNode>
    {
        // we don't mutate this node
        protected override IEnumerable<Mutant> GenerateMutationForNode(SyntaxNode node, MutationContext context)
        {
            return Enumerable.Empty<Mutant>();
        }

        public SyntaxNodeOrchestrator(CsharpMutantOrchestrator mutantOrchestrator) : base(mutantOrchestrator)
        {
        }
    }
}
