﻿using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Secret.CodeInspections;
using JetBrains.Util;

namespace JetBrains.ReSharper.PsiPlugin.CodeInspections.Psi
{
  [DaemonStage]
  public class PsiFileIndexStage : SecretDaemonStageBase
  {
    public override ErrorStripeRequest NeedsErrorStripe(IPsiSourceFile sourceFile, IContextBoundSettingsStore settings)
    {
      return IsSupported(sourceFile) ? ErrorStripeRequest.STRIPE_AND_ERRORS : ErrorStripeRequest.NONE;
    }

    public override IEnumerable<IDaemonStageProcess> CreateProcess(IDaemonProcess process, IContextBoundSettingsStore settings, DaemonProcessKind processKind)
    {
      if (!IsSupported(process.SourceFile))
      {
        return EmptyList<IDaemonStageProcess>.InstanceList;
      }
      return new List<IDaemonStageProcess> { new PsiFileIndexProcess(process, settings) };
    }
  }
}
