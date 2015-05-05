# June 30, 2010 #

Tests revealed that exclusive locking is required for EA version control to work properly.  This is due to the effectively  binary nature of the XMI packages, which are in XML format.  Although these are text files, they are not comprehensible in the same manner as text documents or source code files.  The results of this test were documented in an e-mail from Arnel to Cautley as follows:

> _We may not yet be ready for this, with the following details I’m finding about the way EA works and how Mercurial works with EA files._

> It looks like each person has to go through version control setting when first setting up the cloned EA project to match the absolute path of the local version control repository.  There can only be one such copy of this repository, as the unique ID specification in EA will shift the local project path on a global basis and not on a project basis.

> We have to be really careful about leaving out a checked out package when creating the baseline EAP file.

> The read-only setting on the XMI file that EA plunks onto the file causes problems when merging updates.  The read-only setting must be unset.  If the read-only setting is unset, EA sees it as a change in the file even though the internals did not change.  This was curious to me because I cloned the EA source repository, made a change to one package, and checked it in.  Upon check-in, EA was reporting that all the other packages were modified, even though they weren’t changed since the cloning.  The only thing I could detect was that upon Mercurial check-out, the read-only attributes were unset, and that EA uses this attribute control to report what’s changed.

> Merge conflicts in the XML file will have to be resolved manually if the same package is edited by two or more users.  In one clone, I added a ClassA element.  In the other clone, I added a ClassB element.  Upon merging, the diff program started suggesting that ClassA had changed into ClassB, when in fact what I intended is that ClassA and ClassB should both remain distinct as two new classes after the merge, not one as KDiff was suggesting.

> In short, version control is horrific with the XMI files (they’re like binary files from our standpoint).  It looks like we must control package editing with a lock-type mechanism, but unfortunately Mercurial does not have this.  We’ll have to investigate a better procedure with this in mind.  Is this enough to go on, or should I postpone while we do more research?

Mercurial does not offer exclusive locking because of its distributed nature.  It is not a recommended version control platform for projects with large amounts of binary files.

A companion test project, [besasm-prgfx-ea](http://code.google.com/p/besasm-prgfx-ea), which uses Subversion, revealed that Google Code's Subversion implementation does not support exclusive locking (Cautley found this support issue: http://code.google.com/p/support/issues/detail?id=1349).  Cautley is currently investigating the possibility of other SVN hosts that may afford the kind of locking we're looking for.

# June 9, 2010 #

With the distributed VC model, I think we need to test the following scenario, to ensure that the EA XML files don’t get messed up.

The challenge is that we’re not dealing with source code, but with artifacts that are somewhere between a line-by-line source code file and a binary file like an image. The wags say that there is no substitute for a full exclusive lock on something like binary images. Our issue is that the integrity of the XML (XMI) file depends on chunks of files that, for example, maintain a particular syntax between matching XML tags… (though, maybe this really isn’t so different from compound structures in source code …)

  1. Both users A and B do a Hg “Get Latest” from the Google Code repository and thus have up-to-date local repositories.
  1. User A checks out package 123 from his/her local repository, using the EA tools.
  1. User B also checks out package 123 from their own local repository (using EA).
  1. Both users make changes to package 123.
  1. Both users check in their copy of the package (to their local repository).
  1. Both users push their changes back to the Google Code repository.  (with the associated pull and merge before push …. When needed.)

Need to look at two cases at least ….

  * Separate, non-conflicting changes to, say, two different diagrams or elements

  * Conflicting changes to, say, the same element.



AKA …

  * what guides can we give to folks about merging changes when Hg knows there’s a need to merge

  * how can we quickly converge on the “right” granularity in the EA model VC setup to make the units of work right-size?