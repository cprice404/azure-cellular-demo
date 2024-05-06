using CellRegistry;

public record CellWave(
    List<Cell> Cells
);

public record CellWaves
{
    public static List<CellWave> AllWaves()
    {
        var cellRegistry = CellRegistry.CellRegistry.Default();
        
        /**
         * Here we define the "waves" that will be deployed to, in all of our application component pipelines.
         * Each wave is a list of cells, and all of the cells in each wave will be deployed to in parallel.
         */
        return new List<CellWave>
        {
            /**
             * The idea is to start with a pre-prod wave that is not serving customer traffic. If any issues occur there,
             * the pipeline can be aborted before the changes have deployed out to production cells.
             */
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("alpha")
                }
            ),
            /**
             * The first production wave deploys to one (or a few) low-traffic production cells. Here, there is real
             * production traffic, so if an error shows up that did not get caught in the pre-prod waves, it may impact
             * real users. However, the blast radius is limited because we intentionally put lower-traffic cells in this
             * wave.
             */
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("westus3_1"),
                    cellRegistry.GetCellByName("southcentralus_1")
                }
            ),
            /**
             * As we move to later waves, we start deploying to more important, higher-traffic cells. Hopefully if we
             * have made it through the previous deployment waves without issues, we are relatively safe by this point.
             */
            new(
                new List<Cell>()
                {
                    cellRegistry.GetCellByName("westus2_1"),
                    cellRegistry.GetCellByName("eastus1_1")
                }
            )
        };
    }
}